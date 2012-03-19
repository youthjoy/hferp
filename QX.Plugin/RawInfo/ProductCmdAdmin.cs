using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;

namespace QX.Plugin.RawInfo
{
    public partial class ProductCmdAdmin : F_BasicPop
    {
        private BLL.Bll_Prod_Command MainInstance = null;
        private BLL.Bll_Prod_CmdDetail DetailInstance = null;
        private Prod_Command GModel = new Prod_Command();
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }
        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public ProductCmdAdmin(BLL.Bll_Prod_Command _instance, Prod_Command _gmodel)
        {
            InitializeComponent();
            this.MainInstance = _instance;
            this.DetailInstance = new QX.BLL.Bll_Prod_CmdDetail(); 
            this.GModel = _gmodel;
            tool_top.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            gvMain.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(gvMain_DoubleClickRow);
            btnOk.Click+=new EventHandler(btnOk_Click);
            btnSave.Click+=new EventHandler(btnSave_Click);
            btnCancle.Click += new EventHandler(btnCancle_Click);

            Cmd_Dep_Code2.Click += new EventHandler(Cmd_Dep_Code2_Click);
            this.Load += new EventHandler(RawManage_Load);
        }

        void Cmd_Dep_Code2_Click(object sender, EventArgs e)
        {
            Bll_Dept DeptInstance = new Bll_Dept();
            Bll_Bse_Employee EmployeeInstance = new Bll_Bse_Employee();
            CommDept<Bll_Dept, Bse_Department> CommDept = new CommDept<Bll_Dept, Bse_Department>(DeptInstance,
                new Size(350, 350));
            CommDept.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(CommDept_CallBack);
            CommDept.ShowDialog();
        }
        void CommDept_CallBack(object sender, DataTable list)
        {
            if (list != null && list.Rows.Count > 0)
            {
                Cmd_Dep_Code2.Text = list.Rows[0]["Dept_Code"] != null ? list.Rows[0]["Dept_Code"].ToString() : string.Empty;
                Cmd_Dep_Name.Text = list.Rows[0]["Dept_Name"] != null ? list.Rows[0]["Dept_Name"].ToString() : string.Empty;
            }
        }

        void gvMain_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            
        }

        void tool_top_RefreshClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Cmd_Code.Text))
            {
                Predicate<Prod_CmdDetail> filter = delegate(Prod_CmdDetail p) { return p.Cmd_Code == Cmd_Code.Text; };
                InitGrid(filter);
            }           
        }

        void tool_top_DelClicked(object sender, EventArgs e)
        {
            if (gvMain.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string Code = gvMain.ActiveRow.Cells["Cmd_Code"].Value.ToString();
                    string DetailCode = gvMain.ActiveRow.Cells["CmdDetail_Project"].Value.ToString();
                    bool result = DetailInstance.Delete(Code, DetailCode);
                    if (result)
                    {
                        tool_top_RefreshClicked(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            }
        }

        void tool_top_EditClicked(object sender, EventArgs e)
        {
            string Code = gvMain.ActiveRow.Cells["Cmd_Code"].Value.ToString();
            string DetailCode = gvMain.ActiveRow.Cells["CmdDetail_Project"].Value.ToString();
            Prod_CmdDetail model = DetailInstance.GetModel(" AND Cmd_Code='" + Code + "' AND CmdDetail_Project='" + DetailCode + "'");
            ProductCmdDetail Detail = new ProductCmdDetail(DetailInstance, model, GetModel());
            Detail.OperationType = OperationTypeEnum.OperationType.Edit;
            Detail.CallBack += new ProductCmdDetail.DataChangeHandler(Detail_CallBack);
            Detail.ShowDialog();
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            ProductCmdDetail Detail = new ProductCmdDetail(DetailInstance, null, GetModel());
            Detail.OperationType = OperationTypeEnum.OperationType.Add;
            Detail.CallBack += new ProductCmdDetail.DataChangeHandler(Detail_CallBack);
            Detail.ShowDialog();
        }

        void Detail_CallBack(object sender, EventArgs e)
        {
            tool_top_RefreshClicked(sender, EventArgs.Empty);
        }

        private Prod_Command GetModel()
        {            
            BindModelHelper helper = new BindModelHelper();
            helper.BindControlToModel<Prod_Command>(GModel, this.gp_top.Controls);
            if (GModel == null)
            {
                GModel = new Prod_Command();
            }
            return GModel;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            Prod_Command model = new Prod_Command();
            BindModelHelper helper = new BindModelHelper();
            helper.BindControlToModel(model, this.gp_top.Controls);
            if (model == null)
            {
                return;
            }
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    if (model.Cmd_Code != GModel.Cmd_Code)
                    {
                        if (!CheckIsExist(model.Cmd_Code))
                        {
                            result = MainInstance.Update(model);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        result = MainInstance.Update(model);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    if (!CheckIsExist(model.Cmd_Code))
                    {
                        result = MainInstance.Insert(model);
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            MessageShow(result);
        }

        /// <summary>
        /// 操作提示
        /// </summary>
        /// <param name="result"></param>
        public void MessageShow(bool result)
        {
            if (result)
            {
                gp_button.Visible = true;
                Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
            }
        }


        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckIsExist(string NodeCode)
        {
            bool result = false;
            Prod_Command model = MainInstance.GetModel(" AND (Cmd_Code='" + NodeCode + "')");
            if (model != null && !String.IsNullOrEmpty(model.Cmd_Code))
            {
                result = true;
                Alert.Show(GlobalConfiguration.CNLanguage["dept_codeone"]);
            }
            return result;
        }

        private void RawManage_Load(object sender, EventArgs e)
        {
            btnSave.Click += new EventHandler(btnSave_Click);
            btnOk.Click += new EventHandler(btnOk_Click);
            //btnAdd.Click += new EventHandler(btnAdd_Click);
            BindModelHelper modelHepler = new BindModelHelper();
            Predicate<Prod_CmdDetail> filter = null;
            //操作类型
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    modelHepler.BindModelToControl<Prod_Command>(GModel, this.gp_top.Controls);
                    filter = new Predicate<Prod_CmdDetail>(delegate(Prod_CmdDetail p)
                    {
                        return p.Cmd_Code == GModel.Cmd_Code;
                    });
                    InitGrid(filter);
                    //foreach (Control item in this.gp_top.Controls)
                    //{
                    //    if (item.GetType()==typeof(TextBox) || item.GetType()==typeof(ToolStripButton))
                    //    {

                    //    }
                    //    item.Enabled = false;
                    //}
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    modelHepler.BindModelToControl<Prod_Command>(GModel, this.gp_top.Controls);
                    filter = new Predicate<Prod_CmdDetail>(delegate(Prod_CmdDetail p)
                    {
                        return p.Cmd_Code == GModel.Cmd_Code;
                    });
                    InitGrid(filter);
                    break;
                case OperationTypeEnum.OperationType.Add:
                    gp_button.Visible = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void InitGrid(Predicate<Prod_CmdDetail> filter)
        {
            List<Prod_CmdDetail> list = DetailInstance.GetAll();
            gHandler = new GridHandler(this.gvMain);
            MetaReflection<Prod_CmdDetail> meta = new MetaReflection<Prod_CmdDetail>();
            Dictionary<String, String> dic = meta.GetMeta();
            if (filter != null)
            {
                List<Prod_CmdDetail> tmpList = QX.Common.C_Class.CollectionHelper.Filter<Prod_CmdDetail>(list, filter);
                gHandler.BindData(tmpList, dic, false);
            }
            else
            {
                gHandler.BindData(list, dic, false);
            }
            gHandler.SetDefaultStyle();
            //gHandler.SetAlternateRowStyle();
            gHandler.SetExcelStyleFilter();
        }

    }
}
