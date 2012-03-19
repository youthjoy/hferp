using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public enum FAuditReturnResultEnum
    {
        Success,
        Reject,
        Fail
    }

    /// <summary>
    /// 不合格单据审理窗体
    /// </summary>
    public partial class ComFAuditMain : F_BasicPop
    {
        public ComFAuditMain()
        {
            InitializeComponent();
            this.btView.Visible = false;
            this.Load += new EventHandler(ComAuditMain_Load);
        }

        Form viewForm;

        /// <summary>
        /// 正常审核
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="dataCode"></param>
        /// <param name="curNode"></param>
        public ComFAuditMain(string moduleCode, string dataCode, string curNode)
        {
            InitializeComponent();

            ModuleCode = moduleCode;

            DataCode = dataCode;

            CurNode = curNode;
            this.btView.Visible = false;

            this.Load += new EventHandler(ComAuditMain_Load);
        }

        /// <summary>
        /// 带查看功能
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="dataCode"></param>
        /// <param name="curNode"></param>
        /// <param name="pop"></param>
        public ComFAuditMain(string moduleCode, string dataCode, string curNode, Form pop)
        {
            InitializeComponent();

            ModuleCode = moduleCode;

            DataCode = dataCode;

            CurNode = curNode;
            viewForm = pop;
            this.btView.Visible = true;
            btView.Click += new EventHandler(btView_Click);

            this.Load += new EventHandler(ComAuditMain_Load);
        }

        /// <summary>
        /// 审核历史记录
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="dataCode">数据编码</param>
        public ComFAuditMain(string moduleCode, string dataCode)
        {
            InitializeComponent();

            ModuleCode = moduleCode;

            DataCode = dataCode;

            this.btView.Visible = false;
            CurNode = "";
            //btView.Click += new EventHandler(btView_Click);
            btnAccept.Visible = false;
            btnReject.Visible = false;

            this.Load += new EventHandler(ComAuditMain_Load);
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


        private void ComAuditMain_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            InitData();
        }

        #region 操作句柄

        public delegate void DCallBackHandler(FAuditReturnResultEnum re, string result,string method);

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

            AuditGridInit();

            FormHelper gen = new FormHelper();

            gen.GenerateForm("CForm_FAuditHistory", this.pnlMain, new Point(6, 20));

            RejectBackNode = adInstance.GetVerifyTemplateRejectBack(ModuleCode, CurNode);

            MethodInvoker mm = new MethodInvoker(GetNextNode);

            mm.BeginInvoke(null, null);

        }

        private void GetNextNode()
        {
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
            }

        }

        UltraGrid comGrid = new UltraGrid();

        private void AuditGridInit()
        {
            ////ControlGen.ContrlGenerate gen = new BC.ControlGen.ContrlGenerate();
            GridHelper gen = new GridHelper();

            List<VerifyProcess_Records> list = new List<VerifyProcess_Records>();

            list= adInstance.VerfiyProcessRecords(ModuleCode, DataCode);

            //list = re.ToList();

            comGrid = gen.GenerateGrid("CList_GAuditHistory", this.gpHis, new Point(6, 20));

            //BindingSource dataSource = new BindingSource();
            //dataSource.DataSource = list;

            comGrid.DataSource = list;

            SetGridEditMode(false, comGrid);

            ////列宽度自适应
            comGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;

            Bll_Sys_Map mapInst = new Bll_Sys_Map();
            MapSource = mapInst.GetListByCode(string.Format(" AND Map_Module='{0}'", "Failure"));

        }

        private List<Sys_Map> MapSource
        {
            get;
            set;
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
                    //选择的处理方法
                    CallBack(FAuditReturnResultEnum.Success, result,HandleMethod);

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
                    CallBack(FAuditReturnResultEnum.Fail, result,HandleMethod);
                }
            }

            this.Close();
        }

        public string HandleMethod
        {
            get;
            set;
        }
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
            //处理方法
            HandleMethod = record.VRecord_UDef2;

            string re= adInstance.Audit(record);

            var temp = MapSource.FirstOrDefault(o => o.Map_Source =="Normal");
            //如果处于委员会
            if (record.VRecord_VCode ==temp.Map_Object1)
            {
                IsToBackOrTrash(record);
            }
            else if(record.VRecord_VCode ==MapSource.FirstOrDefault(o => o.Map_Source=="FTrash").Map_Object1)
            {
                Failure_Information fInfo = fiInstance.GetModel(string.Format(" And FInfo_Code='{0}'", record.Record_ID));
                fInfo.AuditStat = "LastAudit";
                fInfo.AuditCurAudit = MapSource.FirstOrDefault(o => o.Map_Source == "FTrash").Map_Object1;
                fiInstance.UpdateFailure(fInfo);
            }
            else if (record.VRecord_VCode == MapSource.FirstOrDefault(o => o.Map_Source == "Back").Map_Object1)
            {
                Failure_Information fInfo = fiInstance.GetModel(string.Format(" And FInfo_Code='{0}'", record.Record_ID));
                fInfo.AuditStat = "LastAudit";
                fInfo.AuditCurAudit = MapSource.FirstOrDefault(o => o.Map_Source == "Back").Map_Object1;
                fiInstance.UpdateFailure(fInfo);
            }
            return re;

        }

        private Bll_VerifyProcess_Records vrInstance = new Bll_VerifyProcess_Records();

        private Bll_Failure_Information fiInstance = new Bll_Failure_Information();

        /// <summary>
        /// 返工返修OR报废判断
        /// </summary>
        /// <param name="record"></param>
        public void IsToBackOrTrash(VerifyProcess_Records record)
        {
            if (record.VRecord_UDef2 == "Back")
            {
                Failure_Information fInfo = fiInstance.GetModel(string.Format(" And FInfo_Code='{0}'", record.Record_ID));
                fInfo.AuditStat = "OnAudit";
                fInfo.AuditCurAudit = MapSource.FirstOrDefault(o => o.Map_Source == "Back").Map_Object1 ;

                fiInstance.UpdateFailure(fInfo);

                VerifyProcess_Records record1 = new VerifyProcess_Records();
                record1.Module_Code = OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString();
                record1.Record_ID = fInfo.FInfo_Code;
                record1.VRecord_VCode = fInfo.AuditCurAudit;
                record1.Stat = 2;
                vrInstance.Insert(record1);
            }
            else if (record.VRecord_UDef2 == "FTrash")
            {
                Failure_Information fInfo = fiInstance.GetModel(string.Format(" And FInfo_Code='{0}'", record.Record_ID));
                fInfo.FInfo_Stat = "FTrash";

                fInfo.AuditStat = "OnAudit";
                fInfo.AuditCurAudit = MapSource.FirstOrDefault(o => o.Map_Source =="FTrash").Map_Object1;

                fiInstance.UpdateFailure(fInfo);

                VerifyProcess_Records record1 = new VerifyProcess_Records();
                record1.Module_Code = OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString();
                record1.Record_ID = fInfo.FInfo_Code;
                record1.VRecord_VCode = fInfo.AuditCurAudit;
                record1.Stat = 2;
                vrInstance.Insert(record1);
            }

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
                    CallBack(FAuditReturnResultEnum.Success, re,HandleMethod);
                }
                else
                {
                    CallBack(FAuditReturnResultEnum.Fail, re,HandleMethod);
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
