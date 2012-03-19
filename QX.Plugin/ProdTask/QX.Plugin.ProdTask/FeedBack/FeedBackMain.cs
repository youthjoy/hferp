using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Framework.AutoForm;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.Plugin.Prod.Prod;
using QX.Plugin.Prod.Report;

namespace QX.Plugin.FeedBack
{
    public partial class FeedBackMain : F_BasciForm
    {
        public FeedBackMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(FeedBackMain_Load);
            BindTopTool();
        }

        void FeedBackMain_Load(object sender, EventArgs e)
        {
            //待审核
            this.ug_listAudit = gridHelper.GenerateGrid("CList_Feedback", this.pInv, new Point(6, 20));
            //ug_listAudit.InitializeRow += new InitializeRowEventHandler(ug_listAudit_InitializeRow);
            gridHelper.SetGridReadOnly(ug_listAudit, true);

            ug_listAudit.DoubleClickRow += new DoubleClickRowEventHandler(ug_listAudit_DoubleClickRow);

            this.ug_listInList = gridHelper.GenerateGrid("CList_Feedback", this.pInList, new Point(6, 20));
            ug_listInList.InitializeRow += new InitializeRowEventHandler(ug_listInList_InitializeRow);
            gridHelper.SetGridReadOnly(ug_listInList, true);

            gridHelper.SetExcelStyleFilter(ug_listInList);
            gridHelper.SetExcelStyleFilter(ug_listAudit);

            BindDataToGrid();
        }

        void ug_listInList_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Bse_Feedback model = e.Row.ListObject as Bse_Feedback;
            if (model != null)
            {
                if (model.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                {
                    //string v=e.Row.Cells["AuditCurAudit"].Value.ToString();
                    e.Row.Cells["AuditCurAudit"].Value = "审理完成";
                }

            }
        }

        void ug_listAudit_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            
        }


        #region 窗体单例

        public static FeedBackMain NewForm = null;



        public static FeedBackMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new FeedBackMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        UltraGrid ug_listAudit = new UltraGrid();//待审核
        UltraGrid ug_listInList = new UltraGrid(); //历史记录
        GridHelper gridHelper = new GridHelper();

        BLL.Bll_FeedBack fiInstance = new QX.BLL.Bll_FeedBack();


        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }



        void ug_listAudit_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            QueryAuditData();
        }

        private void BindDataToGrid()
        {

            List<Bse_Feedback> list_inv = new List<Bse_Feedback>();
            list_inv = fiInstance.GetAuditFeedBackList();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list_inv;
            ug_listAudit.DataSource = dataSource;


            List<Bse_Feedback> list_raw = new List<Bse_Feedback>();
            list_raw = fiInstance.GetFeedBackList();

            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;
        }

        FormHelper fHelper = new FormHelper();


        public void BindTopTool()
        {
            tbFAudit.AuditClicked += new EventHandler(tbFAudit_AuditClicked);
            tbFAudit.RefreshClicked += new EventHandler(tbFAudit_RefreshClicked);
            tbFAudit.QueryClicked += new EventHandler(tbFAudit_QueryClicked);
            tbFAudit.PrintClicked += new EventHandler(tbFAudit_PrintClicked);
            tbFAudit.AddClicked += new EventHandler(tbFAudit_AddClicked);


            tbList.RefreshClicked += new EventHandler(tbList_RefreshClicked);
            tbList.QueryClicked += new EventHandler(tbList_QueryClicked);
            tbList.HistoryClicked += new EventHandler(tbList_HistoryClicked);
            tbList.PrintClicked += new EventHandler(tbList_PrintClicked);
            tbList.EditClicked += new EventHandler(tbList_EditClicked);

            fHelper.PermissionControl(tbFAudit.toolStrip1.Items, PermissionModuleEnum.Feedback.ToString());
            fHelper.PermissionControl(this.tbList.toolStrip1.Items, PermissionModuleEnum.Feedback.ToString());
        }

        void tbFAudit_AddClicked(object sender, EventArgs e)
        {
            //UltraGridRow row = this.ug_listInList.ActiveRow;
            //if (row != null)
            //{
                Bse_Feedback finfo = new Bse_Feedback();
                //finfo.FInfo_Code = fiInstance.GenerateFailureInfor();
                FeedBackOp viewFrm = new FeedBackOp(finfo, false);

                viewFrm.OperationType = OperationTypeEnum.OperationType.Add;
                viewFrm.ShowDialog();

                RefreshAuditing();
                RefreshHitory();
            //}
        }

        void tbList_EditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Bse_Feedback finfo = row.ListObject as Bse_Feedback;
                FeedBackOp viewFrm = new FeedBackOp(finfo, false);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;
                viewFrm.Show();
            }

        }
        //待审核
        void tbList_PrintClicked(object sender, EventArgs e)
        {

            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Bse_Feedback fi = row.ListObject as Bse_Feedback;

                if (Alert.ShowIsConfirm("确定打印当前不合格审理单据吗?"))
                {
                    fi.FB_IsPrint = "Yes";
                    fiInstance.UpdateFeedBack(fi);
                }

                RptFBView rpt = new RptFBView(fi);
                rpt.Show();
            }
        }

        void tbList_HistoryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {


                Bse_Feedback finfo = row.ListObject as Bse_Feedback;

                FeedBackOp viewFrm = new FeedBackOp(finfo, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Look;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(), finfo.FB_Code);
                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                if (DialogResult.OK == frm.ShowDialog())
                {
                    viewFrm.isAudit = false;
                    viewFrm.Close();
                }
            }
        }

        void tbFAudit_PrintClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {
                Bse_Feedback fi = row.ListObject as Bse_Feedback;
                if (fi.AuditStat != "LastAudit")
                {
                    if (Alert.ShowIsConfirm("确定打印当前不合格审理单据吗?"))
                    {
                        fi.FB_IsPrint = "Yes";
                        fiInstance.UpdateFeedBack(fi);
                    }

                    RptFBView rpt = new RptFBView(fi);
                    rpt.Show();
                }
                else
                {
                    if (Alert.ShowIsConfirm("确定打印当前不合格审理单据吗?"))
                    {
                        fi.FB_IsPrint = "Yes";
                        fiInstance.UpdateFeedBack(fi);
                    }

                    RptFBView rpt = new RptFBView(fi);
                    rpt.Show();
                }
            }

        }

        void tbList_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {

                Bse_Feedback finfo = row.ListObject as Bse_Feedback;

                FeedBackOp viewFrm = new FeedBackOp( finfo, false);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                viewFrm.ShowDialog();

            }
        }

        void tbFAudit_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {


                Bse_Feedback finfo = row.ListObject as Bse_Feedback;

                FeedBackOp viewFrm = new FeedBackOp(finfo, false);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                viewFrm.ShowDialog();
            }
        }

        /// <summary>
        /// 待处理不合格品 单据数据查看
        /// </summary>
        public void QueryAuditData()
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {

                Bse_Feedback finfo = row.ListObject as Bse_Feedback;

                FeedBackOp viewFrm = new FeedBackOp(finfo, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                viewFrm.ShowDialog();

            }
        }

        void tbFAudit_RefreshClicked(object sender, EventArgs e)
        {
            RefreshAuditing();
        }

        void tbList_RefreshClicked(object sender, EventArgs e)
        {
            List<Bse_Feedback> list_raw = new List<Bse_Feedback>();
            list_raw = fiInstance.GetFeedBackList();
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;
        }

        private void RefreshHitory()
        {
            List<Bse_Feedback> list_raw = new List<Bse_Feedback>();
            list_raw = fiInstance.GetFeedBackList();
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;
        }


        private void RefreshAuditing()
        {
            List<Bse_Feedback> list_inv = new List<Bse_Feedback>();
            list_inv = fiInstance.GetAuditFeedBackList();
            ug_listAudit.DataSource = list_inv;
        }

        void tbFAudit_AuditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {


                Bse_Feedback finfo = row.ListObject as Bse_Feedback;

                FeedBackOp viewFrm = new FeedBackOp(finfo, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(), finfo.FB_Code, finfo.AuditCurAudit, viewFrm);
                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                if (DialogResult.OK == frm.ShowDialog())
                {
                    viewFrm.isAudit = false;
                    viewFrm.Close();
                }
            }
        }

        void frm_CallBack(AuditReturnResultEnum re, string AStat)
        {
            //审核行
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {
                Bse_Feedback model = row.ListObject as Bse_Feedback;
                switch (re)
                {
                    case AuditReturnResultEnum.Success:

                        Alert.Show("审核完成");

                        break;
                    case AuditReturnResultEnum.Fail:
                        Alert.Show("审核失败!");
                        break;
                }
            }
            RefreshAuditing();

        }
    }
}
