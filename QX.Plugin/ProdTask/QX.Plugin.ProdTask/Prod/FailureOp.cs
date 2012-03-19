using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;
using QX.BseDict;
using QX.Shared;


namespace QX.Plugin.Prod
{
    public partial class FailureOp : F_BasicPop
    {
        public FailureOp()
        {
            InitializeComponent();

        }


        private Failure_Information FInfo
        {
            get;
            set;
        }



        private void EventInit()
        {
            //tool_bar_button.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);
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

        private Failure_Information GModel = new Failure_Information();
        private Bll_Failure_Information mainInstance = null;

        public FailureOp(Bll_Failure_Information _mainInstance, Failure_Information _gmodel)
        {
            InitializeComponent();

            if (_mainInstance == null)
            {
                mainInstance = new Bll_Failure_Information();
            }
            else
            {
                this.mainInstance = _mainInstance;
            }
            if (_gmodel == null)
            {
                _gmodel = new Failure_Information();
            }
            else
            {
                GModel = _gmodel;
            }

            this.GModel = _gmodel;

        }

        public FailureOp(Bll_Failure_Information _mainInstance, Failure_Information _gmodel, bool isAuditFlag)
        {

            InitializeComponent();

            if (_mainInstance == null)
            {
                mainInstance = new Bll_Failure_Information();
            }
            else
            {
                this.mainInstance = _mainInstance;
            }
            if (_gmodel == null)
            {
                _gmodel = new Failure_Information();
            }
            else
            {
                GModel = _gmodel;
            }

            this.GModel = _gmodel;
            this.isAudit = isAuditFlag;

        }


        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            tool_bar_button.SaveClicked += new EventHandler(tool_bar_button_SaveClicked);
            tool_bar_button.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));

            ToolStripButton msgBtn = TsHelper.New("短信通知", QX.Common.Properties.Resources.planner, new EventHandler(msgBtn_Click));

            this.tool_bar_button.AddCustomControl(msgBtn);
            //}
        }

        private Bll_Audit auInstance = new Bll_Audit();

        void msgBtn_Click(object sender, EventArgs e)
        {
            if (OperationTypeEnum.OperationType.Add == operationType || OperationTypeEnum.OperationType.View == operationType)
            {
                Alert.Show("请先保存后再通知下一步相关审核人员!");
                return;
            }

            SendMsg();
        }

        private void SendMsg()
        {
            if (string.IsNullOrEmpty(GModel.AuditCurAudit))
            {
                var model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString());
                if (model != null)
                {
                    AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), model.VT_VerifyNode_Code);
                    UserSel.ShowDialog();
                }
            }
            else
            {
                AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), GModel.AuditCurAudit);
                UserSel.ShowDialog();
            }
        }

        private void FailureOp_Load(object sender, EventArgs e)
        {

            this.ShowInTaskbar = true;

            BindTopTool();
            LoadWindowControl();
            if (isAudit)
            {
                BindModelHelper helper = new BindModelHelper();
                UltraTextEditor editor = helper.FindCtl<UltraTextEditor>(this.groupBox1.Controls, "FInfo_InCompetent");
                if (editor != null)
                {
                    editor.ReadOnly = true;
                }
            }
        }

        void tool_bar_button_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                if ((OperationTypeEnum.OperationType.Add == operationType || OperationTypeEnum.OperationType.View == operationType) && Alert.ShowIsConfirm("是否需要发送短信通知?"))
                {
                    SendMsg();
                }

                this.Close();
            }
            //else
            //{
            //    MessageShow(false);
            //}
        }

        void tool_bar_button_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 操作句柄

        UltraGrid ug_list = new UltraGrid();
        #endregion

        /// <summary>
        /// 读取窗体控件
        /// </summary>
        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            BindModelHelper bindHelper = new BindModelHelper();

            switch (operationType)
            {
                //手动添加模式的Form
                case OperationTypeEnum.OperationType.View:
                    helper.GenerateForm("CForm_FFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));

                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;//查看模式
                case OperationTypeEnum.OperationType.Look:
                    helper.GenerateForm("CForm_FFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));

                    tool_bar_button.SetButtonEnabled("SAVE", false, true);
                    break;//编辑模式
                case OperationTypeEnum.OperationType.Edit:
                    helper.GenerateForm("FFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));

                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;//添加模式
                case OperationTypeEnum.OperationType.Add:
                    helper.GenerateForm("FFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));

                    GModel.FInfo_Code = this.mainInstance.GenerateFailureInfor();
                    GModel.FInfo_Date = DateTime.Now;
                    GModel.Stat = 0;
                    break;
                    
                default:
                    break;
            }

            bindHelper.BindModelToControl<Failure_Information>(GModel, this.groupBox1.Controls, "");
            bindHelper.BindModelToControl<Failure_Information>(GModel, this.groupBox2.Controls, "");
        }

        private bool SaveData()
        {
            #region  保存数据


            bool result = false;
            Failure_Information rawMain = new Failure_Information();
            rawMain = GModel;
            BindModelHelper helper = new BindModelHelper();
            Sys_PD_Module module = this.groupBox1.Tag as Sys_PD_Module;
            if (module == null)
            {
                MessageShow(false);
                return false;
            }

            helper.BindControlToModel(rawMain, this.groupBox1.Controls, module.SPM_TPrefix);

            helper.BindControlToModel(rawMain, this.groupBox2.Controls, module.SPM_TPrefix);




            if (rawMain == null)
            {
                MessageShow(false);
                return false;
            }

            if (string.IsNullOrEmpty(rawMain.FInfo_ProdNo))
            {
                Alert.Show("请填写不合格单据零件编号!");
                return false;
            }

            if (string.IsNullOrEmpty(rawMain.FInfo_PartNo))
            {
                Alert.Show("请填写不合格单据零件图号!");
                return false;
            }




            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
  , QX.Shared.SessionConfig.UserName
  , "localhost"
  , this.Name
  , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Failure
  , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Failure.ToString(), QX.Common.LogType.Edit.ToString());



                    rawMain.FInfo_CreateTime = DateTime.Now;
                    if (string.IsNullOrEmpty(rawMain.FInfo_CreatorCode))
                    {
                        rawMain.FInfo_Creator = SessionConfig.EmpName;
                        rawMain.FInfo_CreatorCode = SessionConfig.UserCode;
                    }
                    result = mainInstance.UpdateFailure(rawMain);

                    break;
                case OperationTypeEnum.OperationType.View:
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Failure
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Failure.ToString(), QX.Common.LogType.Edit.ToString());



                    rawMain.Stat = 0;
                    rawMain.FInfo_CreateTime = DateTime.Now;
                    rawMain.FInfo_Creator = SessionConfig.EmpName;
                    rawMain.FInfo_CreatorCode = SessionConfig.UserCode;
                    result = mainInstance.InsertNewFailure(rawMain);
                    break;
                case OperationTypeEnum.OperationType.Add:
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Failure
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Failure.ToString(), QX.Common.LogType.Add.ToString());


                    rawMain.Stat = 0;
                    rawMain.FInfo_CreateTime = DateTime.Now;
                    rawMain.FInfo_Creator = SessionConfig.EmpName;
                    rawMain.FInfo_CreatorCode = SessionConfig.UserCode;
                    result = mainInstance.AddFailure(rawMain);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("指令编号已经存在");
                    //    return;
                    //}
                    break;
                default:
                    break;
            }
            #endregion

            MessageShow(result);

            return result;
        }
        public void MessageShow(bool result)
        {
            if (result)
            {
                Alert.Show("数据更新成功!");
            }
            else
            {
                Alert.Show("数据更新失败!");
            }
        }

        public bool CheckIsExist(string NodeCode)
        {
            bool result = false;
            //Raw_Main model = this.mainInstance.GetModel(" AND (RawMain_Code='" + NodeCode + "')");
            //if (model != null && !String.IsNullOrEmpty(model.RawMain_Code))
            //{
            //    result = true;
            //}
            return result;
        }

    }
}
