using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.BLL;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Form;
using QX.Common.C_Class;
using QX.Framework.AutoForm;
using QX.Shared;

namespace QX.BseDict
{

    public enum AuditReturnResultEnum
    {
        Success,
        Reject,
        Fail
    }

    public partial class ComAuditMain : F_BasicPop
    {
        Form viewForm;
        public ComAuditMain()
        {
            InitializeComponent();
            this.btView.Visible = false;
        }
        /// <summary>
        /// 正常审核
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="dataCode"></param>
        /// <param name="curNode">当前节点</param>
        public ComAuditMain(string moduleCode, string dataCode, string curNode)
        {
            InitializeComponent();

            ModuleCode = moduleCode;

            DataCode = dataCode;

            CurNode = curNode;
            this.btView.Visible = false;
        }
        /// <summary>
        /// 带查看功能
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="dataCode"></param>
        /// <param name="curNode"></param>
        /// <param name="pop"></param>
        public ComAuditMain(string moduleCode, string dataCode, string curNode, Form pop)
        {
            InitializeComponent();

            ModuleCode = moduleCode;

            DataCode = dataCode;

            CurNode = curNode;
            viewForm = pop;
            this.btView.Visible = true;
            btView.Click += new EventHandler(btView_Click);
        }

        /// <summary>
        /// 审核历史记录
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="dataCode"></param>
        public ComAuditMain(string moduleCode, string dataCode)
        {
            InitializeComponent();

            ModuleCode = moduleCode;

            DataCode = dataCode;

            this.btView.Visible = false;
            CurNode = "";
            //btView.Click += new EventHandler(btView_Click);
            btnAccept.Visible = false;
            btnReject.Visible = false;
        }
        void btView_Click(object sender, EventArgs e)
        {
            viewForm.Owner = this;
            viewForm.Show();
        }

        private string CurNode
        {
            get;
            set;
        }

        /// <summary>
        /// 所属审核模板编码
        /// </summary>
        private string ModuleCode
        {
            get;
            set;
        }
        /// <summary>
        /// 对应记录数据编码
        /// </summary>
        private string DataCode
        {
            get;
            set;
        }

        private Verify_TemplateConfig Config
        {
            get;
            set;
        }


        private void ComAuditMain_Load(object sender, EventArgs e)
        {
            InitData();
        }

        #region 操作句柄

        public delegate void DCallBackHandler(AuditReturnResultEnum re, string result);

        public event DCallBackHandler CallBack;

        private Bll_Audit adInstance = new Bll_Audit();


        private BindModelHelper bmHelper = new BindModelHelper();


        private Verify_TemplateConfig RejectBackNode
        {
            get;
            set;
        }

        #endregion


        private void InitData()
        {

            //ControlGen.ContrlGenerate gen = new BC.ControlGen.ContrlGenerate();
            AuditGridInit();

            FormHelper gen = new FormHelper();

            gen.GenerateForm("FAuditHistory", this.pnlMain, new Point(6, 20));

            RejectBackNode = adInstance.GetVerifyTemplateRejectBack(ModuleCode, CurNode);

            MethodInvoker mm = new MethodInvoker(GetNextNode);

            mm.BeginInvoke(null, null);

        }

        /// <summary>
        /// 获取下一结点 与当前节点配置信息
        /// </summary>
        private void GetNextNode()
        {
            var config = adInstance.GetVerifyTemplateNode(ModuleCode, CurNode);
            Config = config;



            var model = adInstance.GetVerifyTemplateNextNode(ModuleCode, CurNode);
            List<Verify_Users> list = new List<Verify_Users>();
            if (model != null)
            {
                list = adInstance.GetRelationUsers(model.VT_VerifyNode_Code);
            }
            if (model != null)
            {
                if (lblNext.InvokeRequired)
                {
                    MethodInvoker mi = delegate
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var d in list)
                        {
                            sb.Append(d.VU_UserName).Append(",");
                        }
                        if (list.Count == 0)
                        {
                            this.lblNext.Text = "下一审核阶段: " + model.VT_VerifyNode_Name;
                        }
                        else
                        {
                            this.lblNext.Text = "下一审核阶段: " + model.VT_VerifyNode_Name;
                            this.lblUser.Text = " 相关用户审核用户:" + sb.ToString().Trim().TrimEnd(',');
                        }



                    };
                    this.BeginInvoke(mi, null);
                }
                else
                {
                    this.lblNext.Text = "下一审核阶段: " + model.VT_VerifyNode_Name;
                }

                if (txtRemark.InvokeRequired)
                {
                    MethodInvoker mi = delegate
                    {
                        txtRemark.Text = Config.VT_Remark;

                    };
                    this.BeginInvoke(mi, null);
                }
                else
                {
                    txtRemark.Text = Config.VT_Remark;
                }
            }

        }

        UltraGrid comGrid = new UltraGrid();

        private void AuditGridInit()
        {
            ////ControlGen.ContrlGenerate gen = new BC.ControlGen.ContrlGenerate();
            GridHelper gen = new GridHelper();

            List<VerifyProcess_Records> list = new List<VerifyProcess_Records>();

            var re = adInstance.VerfiyProcessRecords(ModuleCode, DataCode);

            list = re.ToList();

            comGrid = gen.GenerateGrid("GAuditHistory", this.gpHis, new Point(6, 20));

            //BindingSource dataSource = new BindingSource();
            //dataSource.DataSource = list;

            comGrid.DataSource = list;

            SetGridEditMode(false, comGrid);

            ////列宽度自适应
            comGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;

        }

        public void SetGridEditMode(bool flag, UltraGrid grid)
        {
            if (flag)
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
            }
            else
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var result = string.Empty;
            result = Accept();

            if (CallBack != null)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    CallBack(AuditReturnResultEnum.Success, result);
                    if (result != OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                    {
                        var model = adInstance.GetVerifyTemplateNextNode(ModuleCode, CurNode);
                        if (model != null)
                        {
                            AuditUserSel sel = new AuditUserSel(ModuleCode, model.VT_VerifyNode_Code);
                            sel.ShowDialog();
                        }
                    }
                }
                else
                {
                    CallBack(AuditReturnResultEnum.Fail, result);
                }
            }

            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>返回审核后的状态</returns>
        private string Accept()
        {
            VerifyProcess_Records record = new VerifyProcess_Records();
            bmHelper.BindControlToModel<VerifyProcess_Records>(record, this.pnlMain.Controls, "");
            record.VRecord_Owner = SessionConfig.UserCode;
            //record.VRecord_Opinion = "";
            record.VRecord_Date = DateTime.Now;
            record.VRecord_Flag = QX.Common.C_Class.OperationTypeEnum.AudtiRecordsDataTypeEnum.Audited.ToString();
            record.VRecord_VCode = CurNode;//当前阶段编码
            record.Module_Code = ModuleCode;//审核模板关键字
            record.Record_ID = DataCode;//单据编码
            record.VRecord_Code = adInstance.GenerateVRecordCode();//记录编码

            return adInstance.Audit(record);
        }

        private string Reject()
        {
            VerifyProcess_Records record = new VerifyProcess_Records();
            bmHelper.BindControlToModel<VerifyProcess_Records>(record, this.pnlMain.Controls, "");
            record.VRecord_Owner = SessionConfig.UserCode;
            //record.VRecord_Opinion = "";
            record.VRecord_Date = DateTime.Now;
            record.VRecord_Flag = QX.Common.C_Class.OperationTypeEnum.AudtiRecordsDataTypeEnum.Reject.ToString();
            record.VRecord_VCode = CurNode;//当前阶段编码
            record.Module_Code = ModuleCode;//审核模板关键字
            record.Record_ID = DataCode;//单据编码
            record.VRecord_Code = adInstance.GenerateVRecordCode();//记录编码

            return adInstance.Audit(record);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RejectBackNode.VT_VerifyNode_Back))
            {
                DialogResult d = Alert.Show(MessageBoxButtons.OKCancel, "驳回后单据将作废，确定驳回吗?");
                if (d != DialogResult.OK)
                {
                    return;
                }
            }

            var re = Reject();

            if (CallBack != null)
            {
                if (!string.IsNullOrEmpty(re))
                {
                    CallBack(AuditReturnResultEnum.Success, re);
                }
                else
                {
                    CallBack(AuditReturnResultEnum.Fail, re);
                }
            }

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
