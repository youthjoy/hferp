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
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;

namespace QX.Plugin.RawInfo
{
    public partial class RawMain : F_BasciForm
    {

        private BLL.Bll_Raw_Main instance = new Bll_Raw_Main();
        private SD_Customer model = new SD_Customer();
        private DataTable dt;
        private Raw_Main CurrentRawModel;
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }

        #region 窗体单例
        public static RawMain NewForm = null;
        public static RawMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new RawMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion

        public RawMain()
        {
            InitializeComponent();
            #region 控件初始化
            //待审核清单
            tool_top_1.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top_1.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top_1.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top_1.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            gvMain_1.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);
            ToolStripHelper TsHelper = new ToolStripHelper();
            tool_top_1.AddCustomControl(TsHelper.New("审核", global::QX.Common.Properties.Resources.audit, btnAudit_Click));
            //已审核清单
            //tool_top_2.RefreshClicked += new EventHandler(tool_top_2_RefreshClicked);
            //tool_top_2.AddCustomControl(TsHelper.New("查看", global::QX.Common.Properties.Resources.look, btnLook_Click_Top2));
            //终审通过清单
            tool_top_3.RefreshClicked += new EventHandler(tool_top_3_RefreshClicked);
            tool_top_3.AddCustomControl(TsHelper.New("查看", global::QX.Common.Properties.Resources.look, btnLook_Click_Top3));
            //未通过清单
            tool_top_4.RefreshClicked += new EventHandler(tool_top_4_RefreshClicked);
            tool_top_4.EditClicked += new EventHandler(tool_top_4_EditClicked);
            tool_top_4.DelClicked += new EventHandler(tool_top_4_DelClicked);
            //我的申请单列表
            tool_top_0.AddCustomControl(TsHelper.New("查看", global::QX.Common.Properties.Resources.look, btnLook_Click_Top0));
            #endregion
        }

        #region  未通过清单
        void tool_top_4_DelClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void tool_top_4_EditClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void tool_top_4_RefreshClicked(object sender, EventArgs e)
        {

        }
        #endregion

        #region 终审通过清单
        void tool_top_3_RefreshClicked(object sender, EventArgs e)
        {

        }
        void btnLook3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 已审核清单

        void btnLook_Click_Top3(object sender, EventArgs e)
        {
            if (gv_Main3.ActiveRow != null)
            {
                string Code = gv_Main3.ActiveRow.Cells["RawMain_Code"].Value.ToString();
                Raw_Main model = instance.GetModel(" AND RawMain_Code='" + Code + "'");
                RawManage RawMange = new RawManage(instance, model);
                RawMange.OperationType = OperationTypeEnum.OperationType.Look;
                RawMange.ShowDialog();
            }
        }

        void btnLook_Click_Top2(object sender, EventArgs e)
        {
            //if (gvMain_2.ActiveRow!=null)
            //{
            //    string Code = gvMain_2.ActiveRow.Cells["RawMain_Code"].Value.ToString();
            //    Raw_Main model = instance.GetModel(" AND RawMain_Code='" + Code + "'");
            //    RawManage RawMange = new RawManage(instance, model);
            //    RawMange.OperationType = OperationTypeEnum.OperationType.Look;
            //    RawMange.ShowDialog();
            //}            
        }

        void btnLook_Click_Top0(object sender, EventArgs e)
        {
            if (gvMain_0.ActiveRow != null)
            {
                string Code = gvMain_0.ActiveRow.Cells["RawMain_Code"].Value.ToString();
                Raw_Main model = instance.GetModel(" AND RawMain_Code='" + Code + "'");
                RawManage RawMange = new RawManage(instance, model);
                RawMange.OperationType = OperationTypeEnum.OperationType.Look;
                RawMange.ShowDialog();
            }
        }

        void tool_top_2_RefreshClicked(object sender, EventArgs e)
        {

        }
        #endregion

        #region 待审核清单ToolBar

        /// <summary>
        /// 审核事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAudit_Click(object sender, EventArgs e)
        {
            if (gvMain_1.ActiveRow != null)
            {
                Raw_Main model = gvMain_1.ActiveRow.ListObject as Raw_Main;
                CurrentRawModel = model;
                //Audit<Raw_Main>.auditTemplate = OperationTypeEnum.AuditTemplateEnum.RawMain_M001;
                //Audit<Raw_Main> audit = new Audit<Raw_Main>(OperationTypeEnum.AuditTemplateEnum.RawMain_M001);
                //audit.ProcessNode = model.RawMain_CurStat;
                //audit.ProcessBussnissCode = model.RawMain_Code;
                //audit.Model = model;               
                //audit.OnLastAudit += new Audit<Raw_Main>.DHandlerLastAudit(audit_OnLastAudit);
                //audit.OnLitterAudit += new Audit<Raw_Main>.DHandlerLitterAudit(audit_OnLitterAudit);
                //audit.OnNextAudit += new Audit<Raw_Main>.DHandlerNextAudit(audit_OnNextAudit);
                //audit.OnRejctAudit += new Audit<Raw_Main>.DHandlerRejectAudit(audit_OnRejctAudit);
                //audit.OnAudit += new Audit<Raw_Main>.DhandlerOnAudit(audit_OnAudit);

                ComAuditMain audit = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), model.RawMain_Code, model.AuditCurAudit);
                audit.CallBack += new ComAuditMain.DCallBackHandler(audit_CallBack);
                audit.ShowDialog();
            }
        }

        void audit_CallBack(AuditReturnResultEnum re, string result)
        {
            throw new NotImplementedException();
        }

        void audit_OnAudit(object sender, Raw_Main obj)
        {
            obj.RawMain_IsOK = OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString();
            instance.Update(obj);
        }
        #region 审核事件
        void audit_OnRejctAudit(string RejectToNode, Raw_Main obj)
        {
            obj.RawMain_CurStat = RejectToNode;
            instance.Update(obj);
            Alert.Show("驳回成功");
        }

        void audit_OnNextAudit(string NextProcessNode, Raw_Main obj)
        {
            obj.RawMain_CurStat = NextProcessNode;
            instance.Update(obj);
            Alert.Show("审核成功，已流转到下一阶段");
        }

        void audit_OnLitterAudit(object sender, Raw_Main obj)
        {
            obj.RawMain_IsOK = OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString();
            instance.Update(obj);
            Alert.Show("驳回成功，此单已作废");
        }

        void audit_OnLastAudit(object sender, Raw_Main obj)
        {
            obj.RawMain_IsOK = OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString();
            instance.Update(obj);
            Alert.Show("终审成功");
        }
        #endregion

        void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            tool_top_EditClicked(this, EventArgs.Empty);
        }

        private void RawMain_Load(object sender, EventArgs e)
        {
            InitGrid(null, gvMain_0, "MyAudit");
        }

        void tool_top_RefreshClicked(object sender, EventArgs e)
        {
            Predicate<Raw_Main> math = delegate(Raw_Main p) { return p.RawMain_Code.Contains("xx"); };
            InitGrid(null, gvMain_1, OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString());
        }

        void tool_top_DelClicked(object sender, EventArgs e)
        {
            if (gvMain_1.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string Code = gvMain_1.ActiveRow.Cells["Cust_Code"].Value.ToString();
                    bool result = instance.Delete(Code);
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
            string Code = gvMain_1.ActiveRow.Cells["RawMain_Code"].Value.ToString();
            Raw_Main model = instance.GetModel(" AND RawMain_Code='" + Code + "'");
            RawManage RawMange = new RawManage(instance, model);
            RawMange.OperationType = OperationTypeEnum.OperationType.Edit;
            RawMange.ShowDialog();
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            RawManage RawMange = new RawManage(instance, null);
            RawMange.OperationType = OperationTypeEnum.OperationType.Add;
            RawMange.ShowDialog();
        }
        #endregion

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void InitGrid(Predicate<Raw_Main> filter, UltraGrid gv, String AuditType)
        {
            List<Raw_Main> list = new List<Raw_Main>();
            if (AuditType == "MyAudit")
            {
                list = instance.GetMyAudit(OperationTypeEnum.AuditTemplateEnum.RawMain_M001);
            }
            else if (AuditType == OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
            {
                list = instance.GetOnAuditList();
            }
            else
            {
                list = instance.GetRawMainByAuditType(AuditType);
            }
            gHandler = new GridHandler(gv);
            MetaReflection<Raw_Main> meta = new MetaReflection<Raw_Main>();
            Dictionary<String, String> dic = meta.GetMeta();
            if (filter != null)
            {
                List<Raw_Main> tmpList = QX.Common.C_Class.CollectionHelper.Filter<Raw_Main>(list, filter);
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

        private void TableControl_Selected(object sender, TabControlEventArgs e)
        {
            if (OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString() == e.TabPage.Name)
            {
                InitGrid(null, gvMain_1, e.TabPage.Name.ToString());
            }
            //else if(OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString() == e.TabPage.Name)
            //{
            //    InitGrid(null,gvMain_2, e.TabPage.Name.ToString()); 
            //}
            else if (OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString() == e.TabPage.Name)
            {
                InitGrid(null, gv_Main3, e.TabPage.Name.ToString());
            }
            else if (OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString() == e.TabPage.Name)
            {
                InitGrid(null, gv_Main4, e.TabPage.Name.ToString());
            }
            else if (e.TabPage.Name == "MyAudit")
            {
                InitGrid(null, gvMain_0, e.TabPage.Name.ToString());
            }
        }
    }
}
