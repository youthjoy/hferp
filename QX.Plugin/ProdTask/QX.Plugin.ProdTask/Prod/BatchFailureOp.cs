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
using QX.Plugin.Prod.ComControl;


namespace QX.Plugin.Prod
{
    public partial class BatchFailureOp : F_BasicPop
    {
        public BatchFailureOp()
        {
            InitializeComponent();
        }

        public delegate void DCallBackHandler(bool sender, Failure_Information model);
        public event DCallBackHandler CallBack;

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

        public BatchFailureOp(Bll_Failure_Information _mainInstance, Failure_Information _gmodel, OperationTypeEnum.OperationType op)
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
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

            OperationType = op;
            BindTopTool();
            this.Load += new EventHandler(FailureOp_Load);
        }


        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            tool_bar_button.SaveClicked += new EventHandler(tool_bar_button_SaveClicked);
            tool_bar_button.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));

            ToolStripButton msgBtn = TsHelper.New("短信通知", QX.Common.Properties.Resources.planner, new EventHandler(msgBtn_Click));

            //状态扭转
            ToolStripButton changeBtn = TsHelper.New("状态扭转", QX.Common.Properties.Resources.manage, new EventHandler(changeBtn_Click));
            changeBtn.Name = "changeFailureBtn";
            this.tool_bar_button.AddCustomControl(changeBtn);

            //报废回用
            ToolStripButton returnBtn = TsHelper.New("报废回用", QX.Common.Properties.Resources.manage, new EventHandler(returnBtn_Click));
            returnBtn.Name = "returnFailureBtn";
            this.tool_bar_button.AddCustomControl(returnBtn);

            this.tool_bar_button.AddCustomControl(msgBtn);

            helper.PermissionControl(this.tool_bar_button.toolStrip1.Items, PermissionModuleEnum.Failure.ToString());
        }

        /// <summary>
        /// 报废回用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void returnBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow r = this.comGrid.ActiveRow;
            if (r != null&&Alert.ShowIsConfirm("确定要取消该零件报废状态?"))
            {
                Failure_Relation fr = r.ListObject as Failure_Relation;
                fr.FR_Stat = "Normal";
                mainInstance.StatChange(fr);

                //如果已经终审则进行零件产品的状态扭转
                if (GModel.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                {
                    ///报废回用（撤销零件的不合格状态 
                    Inv_Information inv = invInstance.GetInvByPlanCode(fr.FR_PlanCode);
                    inv.IInfor_ProdStat = QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Normal.ToString();
                    invInstance.Update(inv);
                }

                QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().FailureReturn+"("+fr.FR_ProdCode+")"
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Failure.ToString(), QX.Common.LogType.Edit.ToString());


                Alert.Show("回用完成!");
            }
        }
        /// <summary>
        /// 状态扭转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void changeBtn_Click(object sender, EventArgs e)
        {
            var rows = this.comGrid.Selected.Rows;
            if (rows.Count == 0)
            {
                Alert.Show("请选择要扭转零件!");
                return;
            }
            ProdStatSel statSelFrm = new ProdStatSel();
            statSelFrm.CallBack += new ProdStatSel.DCallBackHandler(statSelFrm_CallBack);
            statSelFrm.ShowDialog();
        }

        void statSelFrm_CallBack(object sender, object stat)
        {
            var rows = this.comGrid.Selected.Rows;
            string s = stat.ToString();

            StringBuilder sb = new StringBuilder();
            foreach (var r in rows)
            {
                Failure_Relation fr = r.ListObject as Failure_Relation;
                fr.FR_Stat = s;
                sb.Append(fr.FR_ProdCode).Append(",");
                mainInstance.StatChange(fr);
            }

            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().FailureReturn + "(" + sb.ToString() + s+")"
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Failure.ToString(), QX.Common.LogType.Edit.ToString());


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
                    if (CallBack != null)
                    {
                        CallBack(true, GModel);
                    }
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
        FormHelper helper = new FormHelper();
        BindModelHelper bindHelper = new BindModelHelper();
        /// <summary>
        /// 读取窗体控件
        /// </summary>
        private void LoadWindowControl()
        {


            switch (operationType)
            {
                //手动添加模式的Form
                case OperationTypeEnum.OperationType.View:
                    helper.GenerateForm("CForm_FFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));
                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;//查看模式
                case OperationTypeEnum.OperationType.Look:
                    this.Text = "不合格单据查看界面";
                    helper.GenerateForm("CForm_FFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));
                    tool_bar_button.SetButtonEnabled("SAVE", false, true);
                    break;//编辑模式
                case OperationTypeEnum.OperationType.Edit:

                    this.Text = "不合格单据编辑界面";
                    helper.GenerateForm("CForm_BatchFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));

                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;//添加模式
                case OperationTypeEnum.OperationType.Add:
                    this.Text = "不合格单据添加界面";
                    helper.GenerateForm("CForm_BatchFailure", this.groupBox1, new Point(6, 20));
                    helper.GenerateForm("FHFailure", this.groupBox2, new Point(6, 20));

                    GModel.FInfo_Code = this.mainInstance.GenerateFailureInfor();
                    GModel.FInfo_Date = DateTime.Now;
                    GModel.Stat = 0;

                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;

                default:
                    break;
            }

            bindHelper.BindModelToControl<Failure_Information>(GModel, this.groupBox1.Controls, "");
            bindHelper.BindModelToControl<Failure_Information>(GModel, this.groupBox2.Controls, "");


            LoadProdCode();
        }

        UltraGrid comGrid = new UltraGrid();
        GridHelper ghelper = new GridHelper();

        private void LoadProdCode()
        {
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    {
                        var list = new List<Failure_Relation>();
                        BindingSource dataSource = new BindingSource();
                        dataSource.DataSource = list;
                        comGrid = ghelper.GenerateGrid("CList_FailureRelation", this.panel1, new Point(0, 0));
                        //List<Failure_Relation> list = new List<Failure_Relation>();
                        comGrid.DataSource = list;
                        ghelper.SetGridReadOnly(comGrid, false);
                        ProdCodeSel codeSel = new ProdCodeSel();
                        codeSel.CallBack += new ProdCodeSel.DCallBackHandler(codeSel_CallBack);
                        codeSel.ShowDialog();
                        break;
                    }
                case OperationTypeEnum.OperationType.Edit:
                    {
                        var list = mainInstance.GetRelation(GModel.FInfo_Code);
                        comGrid = ghelper.GenerateGrid("CList_FailureRelation", this.panel1, new Point(0, 0));

                        comGrid.DataSource = list;
                        ghelper.SetGridReadOnly(comGrid, true);
                        break;
                    }
                case OperationTypeEnum.OperationType.Look:
                    {
                        var list = mainInstance.GetRelation(GModel.FInfo_Code);
                        comGrid = ghelper.GenerateGrid("CList_FailureRelation", this.panel1, new Point(0, 0));

                        comGrid.DataSource = list;
                        ghelper.SetGridReadOnly(comGrid, true);
                        break;
                    }
            }

        }

        void codeSel_CallBack(object sender, List<Prod_PlanProd> list)
        {
            string type = string.Empty;
            if (sender != null)
            {
                type = sender.ToString();
            }

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = new List<Failure_Relation>();
            comGrid.DataSource = dataSource;
            if (list.Count != 0)
            {
                var p = list[0];
                GModel.FInfo_PartNo = p.PlanProd_PartNo;
                GModel.FInfo_PartName = p.PlanProd_PartName;
                GModel.FInfo_Num = list.Count;
                bindHelper.BindModelToControl<Failure_Information>(GModel, this.groupBox1.Controls, "");
            }
            else
            {
                this.Close();
            }

            if (string.IsNullOrEmpty(type))
            {
                foreach (var r in list)
                {
                    Failure_Relation d = new Failure_Relation();
                    d.FR_ProdCode = r.PlanProd_Code;
                    d.FR_PartName = r.PlanProd_PartName;
                    d.FR_PartNo = r.PlanProd_PartNo;
                    d.FR_PlanCode = r.PlanProd_PlanCode;
                    d.FR_Udef1 = "Prod";
                    var newrow = comGrid.DisplayLayout.Bands[0].AddNew();

                    if (d != null)
                    {
                        PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(Failure_Relation));

                        foreach (UltraGridCell cell in newrow.Cells)
                        {
                            if (cell.Column.IsBound)
                            {
                                object value = pc[cell.Column.Key].GetValue(d);
                                if (value != null)
                                {
                                    newrow.Cells[cell.Column.Key].Value = value;
                                }
                            }
                        }


                    }
                }
            }
            else
            {
                foreach (var r in list)
                {
                    Failure_Relation d = new Failure_Relation();
                    d.FR_ProdCode = r.PlanProd_Code;
                    d.FR_PartName = r.PlanProd_PartName;
                    d.FR_PartNo = r.PlanProd_PartNo;
                    d.FR_PlanCode = r.PlanProd_PlanCode;
                    d.FR_Udef1 = "Raw";
                    var newrow = comGrid.DisplayLayout.Bands[0].AddNew();

                    if (d != null)
                    {
                        PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(Failure_Relation));

                        foreach (UltraGridCell cell in newrow.Cells)
                        {
                            if (cell.Column.IsBound)
                            {
                                object value = pc[cell.Column.Key].GetValue(d);
                                if (value != null)
                                {
                                    newrow.Cells[cell.Column.Key].Value = value;
                                }
                            }
                        }


                    }
                }
            }

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


            //if (string.IsNullOrEmpty(rawMain.FInfo_ProdNo))
            //{
            //    Alert.Show("请填写不合格单据零件编号!");
            //    return false;
            //}
            
            //if (string.IsNullOrEmpty(rawMain.FInfo_PartNo))
            //{
            //    Alert.Show("请填写不合格单据零件图号!");
            //    return false;
            //}

            if (string.IsNullOrEmpty(rawMain.FInfo_InCompetent))
            {
                Alert.Show("请填写不合格情况!");
                return false;
            }

            if (string.IsNullOrEmpty(rawMain.FInfo_TechReq))
            {
                Alert.Show("请填写技术要求!");
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



                    string prodcode = SaveGrid();
                    //表示其使用的是新添加的单据
                    rawMain.FInfo_RelationCode = rawMain.FInfo_Code;
                    rawMain.FInfo_ProdNo = prodcode;

                    rawMain.Stat = 0;
                    rawMain.FInfo_CreateTime = DateTime.Now;
                    rawMain.FInfo_Creator = SessionConfig.EmpName;
                    rawMain.FInfo_CreatorCode = SessionConfig.UserCode;

                    var model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString());

                    if (model != null)
                    {
                        rawMain.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
                        rawMain.AuditCurAudit = model.VT_VerifyNode_Code;
                    }

                    result = mainInstance.AddFailure(rawMain);
                    break;
                default:
                    break;
            }
            #endregion

            MessageShow(result);

            return result;
        }

        /// <summary>
        /// 关联零件编号存储
        /// </summary>
        public string SaveGrid()
        {
            StringBuilder sb = new StringBuilder();
            List<Failure_Relation> list = new List<Failure_Relation>();
            foreach (var r in comGrid.Rows)
            {
                Failure_Relation fr = r.ListObject as Failure_Relation;
                //不合格单据编码
                fr.FR_FailureCode = GModel.FInfo_Code;
                fr.FR_Code = mainInstance.GenearateFailureRelationCode();
                fr.FR_IsCurrent = 1;
                fr.FR_ModuleCode = fr.FR_FailureCode + "_" + fr.FR_ProdCode;


                mainInstance.AddFR(fr);
                sb.Append(fr.FR_ProdCode).Append(",");
                if (string.IsNullOrEmpty(fr.FR_Udef1) || fr.FR_Udef1 != "Raw")
                {
                    ProdStatChange(fr.FR_PlanCode);
                }
            }

            return sb.ToString().TrimEnd(',');
        }

        Bll_Inv_Information invInstance = new Bll_Inv_Information();
        /// <summary>
        /// 生产状态流转
        /// </summary>
        public void ProdStatChange(string code)
        {
            Inv_Information inv = new Inv_Information();
            inv = invInstance.GetInvByPlanCode(code);
            inv.IInfor_ProdStat = QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
            invInstance.Update(inv);
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
