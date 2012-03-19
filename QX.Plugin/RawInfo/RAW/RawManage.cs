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

namespace QX.Plugin.RawInfo
{
    public partial class RawManage : F_BasicPop
    {
        private BLL.Bll_Raw_Main RawMainInstance = null;
        private BLL.Bll_Raw_Detail RawDetailInstance = null;
        private Raw_Main GModel = new Raw_Main();
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

        public RawManage(BLL.Bll_Raw_Main _instance, Raw_Main _gmodel)
        {
            InitializeComponent();
            this.RawMainInstance = _instance;
            this.RawDetailInstance = new QX.BLL.Bll_Raw_Detail();            
            this.GModel = _gmodel;
            tool_top.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            gvMain.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(gvMain_DoubleClickRow);

        }

        void gvMain_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            
        }

        void tool_top_RefreshClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(RawMain_Code.Text))
            {
                Predicate<Raw_Detail> filter = delegate(Raw_Detail p) { return p.RawMain_Code == RawMain_Code.Text; };
                InitGrid(filter);
            }           
        }

        void tool_top_DelClicked(object sender, EventArgs e)
        {
            if (gvMain.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string Code = gvMain.ActiveRow.Cells["RDetail_Code"].Value.ToString();
                    bool result =  RawDetailInstance.Delete(Code);
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
            string Code = gvMain.ActiveRow.Cells["RawMain_Code"].Value.ToString();
            string DetailCode = gvMain.ActiveRow.Cells["RDetail_Code"].Value.ToString();
            Raw_Detail model = RawDetailInstance.GetModel(" AND RawMain_Code='" + Code + "' AND RDetail_Code='" + DetailCode + "'");
            RawDetail RawDetail = new RawDetail(RawDetailInstance, model, GetModel());
            RawDetail.OperationType = OperationTypeEnum.OperationType.Edit;
            RawDetail.CallBack += new RawDetail.DataChangeHandler(RawDetail_CallBack);
            RawDetail.ShowDialog();
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            RawDetail RawDetail = new RawDetail(RawDetailInstance, null, GetModel());
            RawDetail.OperationType = OperationTypeEnum.OperationType.Add;
            RawDetail.CallBack += new RawDetail.DataChangeHandler(RawDetail_CallBack);
            RawDetail.ShowDialog();
        }

        void RawDetail_CallBack(object sender, EventArgs e)
        {
            tool_top_RefreshClicked(sender, EventArgs.Empty);
        }

        private Raw_Main GetModel()
        {
            BindModelHelper helper = new BindModelHelper();
            helper.BindControlToModel<Raw_Main>(GModel, this.gp_top.Controls);
            if (GModel==null)
            {
                GModel = new Raw_Main();
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

        /// <summary>
        /// 保存数据
        /// </summary>
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            Raw_Main model = new Raw_Main();
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
                    if (model.RawMain_Code != GModel.RawMain_Code)
                    {
                        if (!CheckIsExist(model.RawMain_Code))
                        {
                            result = RawMainInstance.Update(model);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        result = RawMainInstance.Update(model);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    if (!CheckIsExist(model.RawMain_Code))
                    {
                        result = RawMainInstance.Insert(model);
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
        /// 检查部门是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckIsExist(string NodeCode)
        {
            bool result = false;
            Raw_Main model = RawMainInstance.GetModel(" AND (RawMain_Code='" + NodeCode + "')");
            if (model!=null && !String.IsNullOrEmpty(model.RawMain_Code))
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
            btnAdd.Click += new EventHandler(btnAdd_Click);
            BindModelHelper modelHepler = new BindModelHelper();
            Predicate<Raw_Detail> filter = null;
            //操作类型
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    modelHepler.BindModelToControl<Raw_Main>(GModel, this.gp_top.Controls);
                    filter = new Predicate<Raw_Detail>(delegate(Raw_Detail p)
                    {
                        return p.RawMain_Code == GModel.RawMain_Code;
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
                    modelHepler.BindModelToControl<Raw_Main>(GModel, this.gp_top.Controls);
                    filter = new Predicate<Raw_Detail>(delegate(Raw_Detail p) {
                        return p.RawMain_Code == GModel.RawMain_Code;
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
        private void InitGrid(Predicate<Raw_Detail> filter)
        {
            List<Raw_Detail> list = RawDetailInstance.GetAll();
            gHandler = new GridHandler(this.gvMain);
            MetaReflection<Raw_Detail> meta = new MetaReflection<Raw_Detail>();
            Dictionary<String, String> dic = meta.GetMeta();
            if (filter != null)
            {
                List<Raw_Detail> tmpList = QX.Common.C_Class.CollectionHelper.Filter<Raw_Detail>(list, filter);
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
