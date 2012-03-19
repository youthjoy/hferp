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
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Shared;
using System.Linq;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.Cmd
{
    public partial class ProductCmdAdmin : F_BasicPop
    {
        private BLL.Bll_Prod_Command MainInstance = null;
        private BLL.Bll_Prod_CmdDetail DetailInstance = null;
        private Prod_Command GModel = new Prod_Command();
        public bool IsEdit = false;
        private Bll_SD_Contract scInstance = new Bll_SD_Contract();
        private Bll_SD_CDetail sdInstance = new Bll_SD_CDetail();
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
            if (_instance == null)
            {
                MainInstance = new Bll_Prod_Command();
            }
            else
            {
                this.MainInstance = _instance;
            }
            if (_gmodel == null)
            {
                _gmodel = new Prod_Command();
            }
            GModel = _gmodel;
            this.DetailInstance = new QX.BLL.Bll_Prod_CmdDetail();
            this.GModel = _gmodel;
            //btnOk.Click += new EventHandler(btnOk_Click);
            btnSave.Click += new EventHandler(btnSave_Click);
            btnCancle.Click += new EventHandler(btnCancle_Click);
            this.btnOk.Visible = false;
            this.Load += new EventHandler(RawManage_Load);
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                operationType = OperationTypeEnum.OperationType.Edit;
            }
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                this.Close();
            }


        }

        void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }
            return result;
        }

        UltraGrid ug_list = new UltraGrid();

        public List<Road_Components> CompList
        {
            get;
            set;
        }

        BLL.Bll_Road_Components rcInstance = new Bll_Road_Components();

        private void RawManage_Load(object sender, EventArgs e)
        {
            LoadWindowControl();

            CompList = rcInstance.GetAllComponents();
        }

        BindModelHelper bindHelper = new BindModelHelper();

        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();

            GridHelper gHelper = new GridHelper();
            List<Prod_CmdDetail> cmdDetailList = new List<Prod_CmdDetail>();
            helper.GenerateForm("CForm_ProdCommand", gp_top, new Point(6, 20));

            if (operationType == OperationTypeEnum.OperationType.View)
            {
                ug_list = gHelper.GenerateGrid("CList_PProdCmdDetail", panel2, new Point(6, 20));
            }
            else
            {
                ug_list = gHelper.GenerateGrid("CList_ProdCmdDetail", panel2, new Point(6, 20));

            }
            //Sys_PD_Module module = gp_top.Tag as Sys_PD_Module;
            //if (module == null)
            //    return;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    gHelper.SetGridReadOnly(ug_list, true);
                    this.btnSave.Enabled = false;
                    this.btnOk.Enabled = false;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    break;
                case OperationTypeEnum.OperationType.View:

                    break;
                case OperationTypeEnum.OperationType.Add:
                    GModel.Cmd_Code = MainInstance.GenerateCommandCode();
                    GModel.CreateDate = DateTime.Now;
                    GModel.Stat = 0;
                    GModel.UpdateDate = DateTime.Now;
                    GModel.Cmd_Supplier = "重庆禾丰机械";
                    GModel.Cmd_CBill = SessionConfig.UserCode;
                    GModel.Cmd_CBillName = SessionConfig.EmpName;
                    GModel.Cmd_CBillTime = DateTime.Now;
                    break;
                default:
                    break;
            }

            cmdDetailList = DetailInstance.GetByCommand(GModel.Cmd_Code);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = cmdDetailList;
            bindHelper.BindModelToControl<Prod_Command>(GModel, this.gp_top.Controls, "");
            ug_list.DataSource = dataSource;

            ug_list.BeforeEnterEditMode += new CancelEventHandler(ug_list_BeforeEnterEditMode);
            ug_list.CellChange += new CellEventHandler(ug_list_CellChange);
            //ug_list.InitializeRow += new InitializeRowEventHandler(ug_list_InitializeRow);
            var combo = bindHelper.FindCtl<UltraCombo>(this.gp_top.Controls, "Cmd_Contract_Code");
            if (combo != null)
            {
                combo.ValueChanged += new EventHandler(combo_ValueChanged);
            }
        }

        void ug_list_CellChange(object sender, CellEventArgs e)
        {
            //if (e.Cell.Column.Key == "CmdDetail_PartNo")
            //{
            //    List<Prod_CmdDetail> list = new List<Prod_CmdDetail>();
            //    foreach (var row in ug_list.Rows)
            //    {
            //        Prod_CmdDetail d = row.ListObject as Prod_CmdDetail;
            //        if (list.FirstOrDefault(o => o.CmdDetail_PartNo == d.CmdDetail_PartNo) != null)
            //        {
            //            Alert.Show("当前零件图号已存在，请确认!");
            //            break;
            //        }
            //        list.Add(d);
            //    }

            //}
        }

        void ug_list_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {

            UltraGridCell cell = this.ug_list.ActiveCell;
            if (cell != null)
            {
                if (cell.Column.Key == "CmdDetail_Project")
                {
                    Prod_CmdDetail detail = cell.Row.ListObject as Prod_CmdDetail;
                    if (detail.CmdDetail_PartNo != null)
                    {
                        if (string.IsNullOrEmpty(detail.Cmd_Code))
                        {
                            var cmd = bindHelper.FindCtl<UltraTextEditor>(this.gp_top.Controls, "Cmd_Code");
                            detail.Cmd_Code = cmd.Text;
                        }
                        ProdCodeList CodeList = new ProdCodeList(detail.Cmd_Code, detail.CmdDetail_PartNo.ToString());
                        CodeList.Show();

                        QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                , QX.Shared.SessionConfig.UserName
                , "localhost"
                , this.Name
                , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdCodeCmd
                , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdCmd.ToString(), QX.Common.LogType.Edit.ToString());

                    }
                    e.Cancel = true;
                }
            }
        }

        void combo_ValueChanged(object sender, EventArgs e)
        {
            UltraCombo combo = sender as UltraCombo;

            if (combo != null && combo.Value != null)
            {
                var value = combo.Value.ToString();

                var list = sdInstance.GetCmdDetailByContract(value);

                BindingSource dataSource = new BindingSource();
                dataSource.DataSource = list;
                ug_list.DataSource = dataSource;
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        private bool SaveData()
        {
            #region  保存数据
            bool result = false;
            BindModelHelper helper = new BindModelHelper();
            //Sys_PD_Module module = gp_top.Tag as Sys_PD_Module;
            //if (module == null)
            //{
            //    MessageShow(false);
            //    return;
            //}
            helper.BindControlToModel(GModel, this.gp_top.Controls, "");
            if (string.IsNullOrEmpty(GModel.Cmd_Code))
            {
                Alert.Show("生产指令不能为空");
                result = false;
                return result;
            }
            //if (string.IsNullOrEmpty(GModel.Cmd_Supplier))
            //{
            //    Alert.Show("客户不能为空");
            //    result = false;
            //    return result;
            //}


            List<Prod_CmdDetail> list = new List<Prod_CmdDetail>();
            StringBuilder sb = new StringBuilder();
            bool isExsist = false;
            foreach (UltraGridRow row in ug_list.Rows)
            {
                Prod_CmdDetail line = row.ListObject as Prod_CmdDetail;
                line.Cmd_Code = GModel.Cmd_Code;
                if (CompList.FirstOrDefault(o => o.Comp_Code == line.CmdDetail_PartNo) != null)
                {
                    list.Add(line);
                }
                else
                {
                    isExsist = true;
                    sb.Append(line.CmdDetail_PartNo).Append(",");
                }
            }

            if (isExsist)
            {
                result = false;
                Alert.Show(string.Format("以下零件图号模板({0})不存在,未能成功添加!", sb.ToString().TrimEnd(',')));
                return false;
            }
            int sum = list.Sum(o => o.CmdDetail_Num);
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdCmd
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdCmd.ToString(), QX.Common.LogType.Edit.ToString());

                    if (GModel.Cmd_Code != GModel.Cmd_Code)
                    {
                        GModel.Cmd_AllCount = sum;

                        GModel.Cmd_AllCount = sum;
                        result = MainInstance.Update(GModel);
                        return result;

                    }
                    else
                    {
                        GModel.Cmd_AllCount = sum;
                        result = MainInstance.Update(GModel);
                    }
                    break;
                case OperationTypeEnum.OperationType.View:


                    break;
                case OperationTypeEnum.OperationType.Add:

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdCmd
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdCmd.ToString(), QX.Common.LogType.Add.ToString());

                    if (!CheckIsExist(GModel.Cmd_Code))
                    {
                        GModel.Cmd_AllCount = sum;
                        result = MainInstance.Insert(GModel);
                    }
                    else
                    {
                        MessageBox.Show("指令编号已经存在");
                        result = false;
                        return result;
                    }
                    break;
                default:
                    break;
            }
            #endregion


            SaveGrid(list);

            MessageShow(true);

            return result;
        }

        private void SaveGrid(List<Prod_CmdDetail> list)
        {
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    DetailInstance.AddCmdList(list, GModel);
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    DetailInstance.UpdateList(list, GModel);
                    break;
            }
        }
    }
}
