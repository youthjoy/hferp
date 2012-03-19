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

namespace QX.Plugin.FeedBack
{
    public partial class FeedBackOp : F_BasicPop
    {
        public FeedBackOp(Bse_Feedback model, bool isAudit)
        {
            InitializeComponent();

            base.isAudit = isAudit;

            GModel = model;

            BindTopTool();

            this.Load += new EventHandler(FeedBackOp_Load);
        }

        private void BindTopTool()
        {
            ToolStripHelper tsHelper = new ToolStripHelper();
            this.tool_bar_button.SaveClicked += new EventHandler(top_tool_SaveClicked);
            ToolStripButton msgBtn = tsHelper.New("短信通知", QX.Common.Properties.Resources.planner, new EventHandler(msgBtn_Click));

            this.tool_bar_button.AddCustomControl(msgBtn);
            //}
        }

        private Bll_Audit auInstance = new Bll_Audit();

        void msgBtn_Click(object sender, EventArgs e)
        {
            if (OperationTypeEnum.OperationType.Add == operationType )
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
                var model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString());
                if (model != null)
                {
                    AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(), model.VT_VerifyNode_Code);
                    UserSel.ShowDialog();
                }
            }
            else
            {
                AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(), GModel.AuditCurAudit);
                UserSel.ShowDialog();
            }
        }

        void top_tool_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                if (OperationTypeEnum.OperationType.Add == operationType&& Alert.ShowIsConfirm("是否需要发送短信通知?"))
                {
                    SendMsg();
                }

                this.Close();
            }
        }

        void FeedBackOp_Load(object sender, EventArgs e)
        {
            LoadWindowControl();
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

        private Bse_Feedback GModel = new Bse_Feedback();
        private Bll_FeedBack mainInstance = new Bll_FeedBack();

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
                    helper.GenerateForm("CForm_Feedback", this.groupBox1, new Point(6, 20));


                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;
                case OperationTypeEnum.OperationType.Look:
                    helper.GenerateForm("CForm_Feedback", this.groupBox1, new Point(6, 20));

                    tool_bar_button.SetButtonEnabled("SAVE", false, true);
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    helper.GenerateForm("CForm_Feedback", this.groupBox1, new Point(6, 20));


                    tool_bar_button.SetButtonEnabled("SAVE", true, true);
                    break;
                case OperationTypeEnum.OperationType.Add:
                    helper.GenerateForm("CForm_Feedback", this.groupBox1, new Point(6, 20));

                    var d = bindHelper.FindCtl<UltraCombo>(this.groupBox1.Controls, "FB_Creator");
                    d.Value = SessionConfig.UserCode;
                    GModel.FB_Code = this.mainInstance.GenerateFeedBack();
                    GModel.CreateTime = DateTime.Now;
                    GModel.UpdateTime = DateTime.Now;
                    GModel.Stat = 0;
                    break;
                default:
                    break;
            }

            GModel.FB_Creator = SessionConfig.UserCode;
            GModel.FB_Date = DateTime.Now;

            bindHelper.BindModelToControl<Bse_Feedback>(GModel, this.groupBox1.Controls, "");

            InitResonCate();
        }

        private Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();

        public List<Bse_Dict> ProcessList
        {
            get;
            set;
        }

        public List<Bse_Dict> QAList
        {
            get;
            set;
        }

        public void InitResonCate()
        {
            List<Bse_Dict> ProcessList = dictInstance.GetListByDictKeyByNoRoot("Process");

            List<Bse_Dict> QAList = dictInstance.GetListByDictKeyByNoRoot("QA");


            List<Bse_FeedDetail> fdlist = mainInstance.GetFeedDetailList(GModel.FB_Code);
            var fplist = fdlist.Where(o => o.FBI_itype == "Process");
            var fqlist = fdlist.Where(o => o.FBI_itype == "QA");

            foreach (var d in ProcessList)
            {
                if (fplist.FirstOrDefault(o => o.FBI_DCode == d.Dict_Code) != null)
                {
                    cblProcess.Items.Add(d.Dict_Name, true);
                }
                else
                {
                    cblProcess.Items.Add(d.Dict_Name, false);
                }
            }

            foreach (var d in QAList)
            {
                if (fqlist.FirstOrDefault(o => o.FBI_DCode == d.Dict_Code) != null)
                {
                    this.cblQA.Items.Add(d.Dict_Name, true);
                }
                else
                {
                    cblQA.Items.Add(d.Dict_Name, false);
                }
            }

        }

        public void SaveDetail()
        {
            List<Bse_Dict> ProcessList = dictInstance.GetListByDictKeyByNoRoot("Process");

            List<Bse_Dict> QAList = dictInstance.GetListByDictKeyByNoRoot("QA");

            List<Bse_FeedDetail> detaillist = new List<Bse_FeedDetail>();
            foreach (var item in cblProcess.CheckedItems)
            {

                var d = ProcessList.FirstOrDefault(o => o.Dict_Name == item.ToString());
                if (d != null)
                {
                    detaillist.Add(new Bse_FeedDetail() { FBI_DCode = d.Dict_Code, FBI_DName = d.Dict_Name, FBI_itype = d.Dict_Key, FBI_MCode = GModel.FB_Code });
                }
            }

            foreach (var item in cblQA.CheckedItems)
            {

                var d = QAList.FirstOrDefault(o => o.Dict_Name == item.ToString());
                detaillist.Add(new Bse_FeedDetail() { FBI_DCode = d.Dict_Code, FBI_DName = d.Dict_Name, FBI_itype = d.Dict_Key, FBI_MCode = GModel.FB_Code });
            }

            mainInstance.AddOrUpdateDetail("", GModel, detaillist);
        }

        private bool SaveData()
        {
            #region  保存数据
            bool result = false;
            Bse_Feedback rawMain = new Bse_Feedback();
            rawMain = GModel;
            BindModelHelper helper = new BindModelHelper();
            Sys_PD_Module module = this.groupBox1.Tag as Sys_PD_Module;
            if (module == null)
            {
                MessageShow(false);
                return false;
            }

            helper.BindControlToModel(rawMain, this.groupBox1.Controls, module.SPM_TPrefix);



            if (rawMain == null)
            {
                return false;
            }
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    result = mainInstance.UpdateFeedBack(rawMain);
                    SaveDetail();
                    break;
                case OperationTypeEnum.OperationType.Add:

                    rawMain.Stat = 0;
                    result = mainInstance.AddFeedBackModel(rawMain);
                    SaveDetail();
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
                Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
            }
        }

    }
}
