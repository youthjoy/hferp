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
using Infragistics.Win.UltraWinGrid.ExcelExport;
using QX.Shared;
using QX.Plugin.Prod.ComControl;

namespace QX.Plugin.Prod
{
    public partial class FailureMain : F_BasciForm
    {
        public FailureMain()
        {
            InitializeComponent();

            //this.Load += new EventHandler(RawInvList_Load);
            BindTopTool();
        }
        private BLL.Bll_Sys_Map mapInstance = new QX.BLL.Bll_Sys_Map();
        public List<Sys_Map> MapSource
        {
            get;
            set;
        }


        #region 窗体单例

        public static FailureMain NewForm = null;



        public static FailureMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new FailureMain();
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

        BLL.Bll_Failure_Information fiInstance = new QX.BLL.Bll_Failure_Information();


        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }


        void FailureMain_Load(object sender, EventArgs e)
        {
            MapSource = mapInstance.GetListByCode(string.Format("AND Map_Module ='FailureSource'"));

            //待审核
            this.ug_listAudit = gridHelper.GenerateGrid("GFailure", this.pInv, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listAudit, true);

            ug_listAudit.DoubleClickRow += new DoubleClickRowEventHandler(ug_listAudit_DoubleClickRow);
            ug_listAudit.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(ug_listAudit_InitializeRow);


            //不合格单据列表
            this.ug_listInList = gridHelper.GenerateGrid("GFailure", this.pInList, new Point(6, 20));
            ug_listInList.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(ug_listInList_InitializeRow);
            ug_listInList.DoubleClickRow += new DoubleClickRowEventHandler(ug_listInList_DoubleClickRow);
            gridHelper.SetGridReadOnly(ug_listInList, true);

            gridHelper.SetExcelStyleFilter(ug_listInList);
            gridHelper.SetExcelStyleFilter(ug_listAudit);

            BindDataToGrid();
        }

        void ug_listInList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Failure_Information fi = row.ListObject as Failure_Information;

                RptFailView rpt = new RptFailView(fi);
                rpt.Show();
            }
        }

        void ug_listInList_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Failure_Information fail = e.Row.ListObject as Failure_Information;
            if (fail != null)
            {
                if (fail.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                {
                    //string v=e.Row.Cells["AuditCurAudit"].Value.ToString();
                    e.Row.Cells["AuditCurAudit"].Value = "审理完成";

                }

            }
        }

        void ug_listAudit_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Failure_Information fail = e.Row.ListObject as Failure_Information;
            if (fail != null)
            {
                if (fail.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                {
                    //string v=e.Row.Cells["AuditCurAudit"].Value.ToString();
                    e.Row.Cells["AuditCurAudit"].Value = "审理完成";

                }

            }
        }

        void ug_listAudit_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {
                Failure_Information fi = row.ListObject as Failure_Information;

                RptFailView rpt = new RptFailView(fi);
                rpt.Show();
            }
        }

        private void BindDataToGrid()
        {

            List<Failure_Information> list_inv = new List<Failure_Information>();
            list_inv = fiInstance.GetAuditingFailureInforList();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list_inv;
            ug_listAudit.DataSource = dataSource;

            string begin = bDate.Value.ToString();
            string end = eDate.Value.ToString();
            string key = string.Empty;
            List<Failure_Information> list_raw = new List<Failure_Information>();
            list_raw = fiInstance.GetFailureInforList(begin, end, key);
            //List<Failure_Information> list_raw = new List<Failure_Information>();
            //list_raw = fiInstance.GetFailureInforList();

            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;

            AddCustomColumn();
        }

        FormHelper fHelper = new FormHelper();

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        public void BindTopTool()
        {
            //审核
            tbFAudit.AuditClicked += new EventHandler(tbFAudit_AuditClicked);
            tbFAudit.RefreshClicked += new EventHandler(tbFAudit_RefreshClicked);
            tbFAudit.QueryClicked += new EventHandler(tbFAudit_QueryClicked);
            tbFAudit.PrintClicked += new EventHandler(tbFAudit_PrintClicked);
            //tbFAudit.AddClicked += new EventHandler(tbFAudit_AddClicked);
            //this.tbFAudit.EditClicked += new EventHandler(tbFAudit_EditClicked);



            //历史
            tbList.RefreshClicked += new EventHandler(tbList_RefreshClicked);
            tbList.QueryClicked += new EventHandler(tbList_QueryClicked);
            tbList.HistoryClicked += new EventHandler(tbList_HistoryClicked);
            tbList.PrintClicked += new EventHandler(tbList_PrintClicked);
            tbList.EditClicked += new EventHandler(tbList_EditClicked);

            tbList.AddClicked += new EventHandler(tbList_AddClicked);

            ToolStripHelper tsHelper = new ToolStripHelper();

            ToolStripButton editForTechBtn = tsHelper.New("单据维护", QX.Common.Properties.Resources.edit, new EventHandler(editForTechBtn_Click));
            editForTechBtn.Name = "editForTechBtn";
            tbList.AddCustomControl(editForTechBtn);

            ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(exportBtn_Click));
            exportBtn.Name = "btnexport";
            tbList.AddCustomControl(exportBtn);

            ToolStripButton cancelBtn = tsHelper.New("审核回滚", QX.Common.Properties.Resources.cancel, new EventHandler(cancelBtn_Click));
            cancelBtn.Name = "cancelFInfo";
            //cancelBtn.Click += new EventHandler(cancelBtn_Click);
            this.tbList.AddCustomControl(cancelBtn);

            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tbList.AddCustomControl(0, tLabel);

            this.tbList.AddCDTPtoToolstrip(1, bDate);
            bDate.Value = DateTime.Now.AddMonths(-1);
            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tbList.AddCustomControl(2, tLabel2);


            this.tbList.AddCDTPtoToolstrip(3, eDate);
            eDate.Value = DateTime.Now.AddHours(1);
            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tbList.AddCustomControl(4, tLabel3);

            this.tbList.AddCustomControl(5, txtKey);


            ToolStripButton SearchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));

            //SearchBtn.Click += new EventHandler(SearchBtn_Click);
            tbList.AddCustomControl(6, SearchBtn);



            fHelper.PermissionControl(tbFAudit.toolStrip1.Items, PermissionModuleEnum.Failure.ToString());
            fHelper.PermissionControl(this.tbList.toolStrip1.Items, PermissionModuleEnum.Failure.ToString());
        }



        void cancelBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Failure_Information info = row.ListObject as Failure_Information;
                if (info.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                {
                    Alert.Show("该单据已终审，不能进行回滚操作!");
                    return;
                }
                CancelFailure cancelFailure = new CancelFailure(info);
                cancelFailure.ShowDialog();
            }
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editForTechBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Failure_Information temp = row.ListObject as Failure_Information;
                Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));
                FailureOpEx viewFrm = new FailureOpEx(fiInstance, finfo, false);

                viewFrm.ShowDialog();
            }
        }

        void SearchBtn_Click(object sender, EventArgs e)
        {
            string begin = bDate.Value.ToString();
            string end = eDate.Value.ToString();
            string key = txtKey.Text;
            List<Failure_Information> list_raw = new List<Failure_Information>();
            list_raw = fiInstance.GetFailureInforList(begin, end, key);
            //List<Failure_Information> list_raw = new List<Failure_Information>();
            //list_raw = fiInstance.GetFailureInforList();

            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;

            AddCustomColumn();
        }

        GridHelper gen = new GridHelper();

        void exportBtn_Click(object sender, EventArgs e)
        {
            var list = GetGridCheckBoxData();
            if (list.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.Title = "导出文件保存路径";
                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    string file = saveFileDialog.FileName;
                    UltraGridExcelExporter export = new UltraGridExcelExporter();
                    UltraGrid grid = new UltraGrid();
                    Panel p = new Panel();
                    this.Controls.Add(p);
                    grid = gen.GenerateGrid("GFailure_Ex", p, new Point(0, 0));
                    var source = fiInstance.GetFailureForExport(list);
                    grid.DataSource = source;
                    grid.Refresh();
                    export.Export(grid, file);
                    Alert.Show("导出完成!");
                }
            }
            else
            {
                Alert.Show("请选择要导出的不合格审理单据!");
            }


            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
            //saveFileDialog.FilterIndex = 0;
            //saveFileDialog.RestoreDirectory = true;
            //saveFileDialog.CreatePrompt = true;
            //saveFileDialog.Title = "导出文件保存路径";
            //if (DialogResult.OK == saveFileDialog.ShowDialog())
            //{
            //    string file = saveFileDialog.FileName;
            //    UltraGridExcelExporter export = new UltraGridExcelExporter();

            //    export.Export(this.ug_listAudit, file);
            //    Alert.Show("导出完成!");
            //}

        }

        private List<Failure_Information> GetGridCheckBoxData()
        {
            List<Failure_Information> list = new List<Failure_Information>();

            foreach (UltraGridRow r in this.ug_listInList.DisplayLayout.Rows)
            {

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    Failure_Information planProd = r.ListObject as Failure_Information;
                    list.Add(planProd);
                }
            }

            return list;
        }

        void tbFAudit_EditClicked(object sender, EventArgs e)
        {

            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {
                Failure_Information temp = row.ListObject as Failure_Information;
                Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));
                FailureOp viewFrm = new FailureOp(fiInstance, finfo, false);
                if (finfo.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                {

                    viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                }
                else
                {
                    viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                    Alert.Show("当前单据已进入审核流程,不能更新其数据");
                }

                viewFrm.ShowDialog();
            }
        }

        void tbFAudit_AddClicked(object sender, EventArgs e)
        {
            //UltraGridRow row = this.ug_listInList.ActiveRow;
            //if (row != null)
            //{
            Failure_Information finfo = new Failure_Information();
            finfo.FInfo_Code = fiInstance.GenerateFailureInfor();
            FailureOp viewFrm = new FailureOp(fiInstance, finfo, false);

            viewFrm.OperationType = OperationTypeEnum.OperationType.View;
            viewFrm.Show();

            RefreshAuditing();
            RefreshHitory();
            //}
        }

        void tbList_AddClicked(object sender, EventArgs e)
        {
            BatchFailureOp BFFrm = new BatchFailureOp(new QX.BLL.Bll_Failure_Information(), null, OperationTypeEnum.OperationType.Add);
            BFFrm.CallBack += new BatchFailureOp.DCallBackHandler(BFFrm_CallBack);
            BFFrm.ShowDialog();
        }

        void BFFrm_CallBack(bool sender, Failure_Information model)
        {
            RefreshAuditing();
            RefreshHitory();
        }

        void tbList_EditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
          

            Failure_Information temp = row.ListObject as Failure_Information;
            Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));
            if (string.IsNullOrEmpty(finfo.FInfo_RelationCode))
            {
                FailureOp viewFrm = new FailureOp(fiInstance, finfo, false);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;
                viewFrm.Show();

            }
            else
            {
                BatchFailureOp BFFrm = new BatchFailureOp(new QX.BLL.Bll_Failure_Information(), finfo, OperationTypeEnum.OperationType.Edit);
                //BFFrm.CallBack += new BatchFailureOp.DCallBackHandler(BFFrm_CallBack);
                BFFrm.Show();
            }


        }
        //待审核
        void tbList_PrintClicked(object sender, EventArgs e)
        {

            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Failure_Information fi = row.ListObject as Failure_Information;

                //if (Alert.ShowIsConfirm("确定打印当前不合格审理单据吗?"))
                //{
                ///如果是财务相关人员打印则更新打印状态
                if (SessionConfig.DeptCode == "0310")
                {
                    fi.FInfo_IsPrint = "Yes";
                    fiInstance.UpdateFailure(fi);
                }
                //}

                RptFailView rpt = new RptFailView(fi);
                rpt.Show();
            }
        }

        void tbList_HistoryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {


                Failure_Information finfo = row.ListObject as Failure_Information;
                FailureOp viewFrm = new FailureOp(fiInstance, finfo, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Look;

                ComFAuditMain frm = new ComFAuditMain(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), finfo.FInfo_Code);
                frm.CallBack += new ComFAuditMain.DCallBackHandler(frm_CallBack);
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
                Failure_Information fi = row.ListObject as Failure_Information;
                //if (fi.AuditStat != "LastAudit")
                //{
                //if (Alert.ShowIsConfirm("确定打印当前不合格审理单据吗?"))
                //{
                //fi.FInfo_IsPrint = "Yes";
                //fiInstance.UpdateFailure(fi);

                ///如果是财务相关人员打印则更新打印状态
               


                RptFailView rptFail = new RptFailView(fi);
                rptFail.CallBack += new RptFailView.DCallBackHandler(rptFail_CallBack);
                rptFail.Show();
                //}
                //else
                //{ 

                //}
            }

        }

        void rptFail_CallBack(bool result,Failure_Information fi)
        {
            if (SessionConfig.DeptCode == "0310")
            {
                fi.FInfo_IsPrint = "Yes";
                fiInstance.UpdateFailure(fi);
            }
        }

        void tbList_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {

                //Failure_Information temp = row.ListObject as Failure_Information;
                //Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));
                //FailureOp viewFrm = new FailureOp(fiInstance, finfo, false);
                //viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                //viewFrm.ShowDialog();
                //UltraGridRow row = this.ug_listInList.ActiveRow;

                Failure_Information temp = row.ListObject as Failure_Information;
                Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));
                if (string.IsNullOrEmpty(finfo.FInfo_RelationCode))
                {
                    FailureOp viewFrm = new FailureOp(fiInstance, finfo, false);
                    viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                    viewFrm.Show();

                }
                else
                {
                    BatchFailureOp BFFrm = new BatchFailureOp(new QX.BLL.Bll_Failure_Information(), finfo, OperationTypeEnum.OperationType.Look);
                    //BFFrm.CallBack += new BatchFailureOp.DCallBackHandler(BFFrm_CallBack);
                    BFFrm.Show();
                }

            }
        }

        void tbFAudit_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {

                Failure_Information temp = row.ListObject as Failure_Information;
                Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));
                FailureOp viewFrm = new FailureOp(fiInstance, finfo, false);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Look;
                viewFrm.Show();

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

                Failure_Information finfo = row.ListObject as Failure_Information;

                FailureOp viewFrm = new FailureOp(fiInstance, finfo, true);
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
            List<Failure_Information> list_raw = new List<Failure_Information>();
            list_raw = fiInstance.GetFailureInforList();
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;

            AddCustomColumn();
        }

        private void RefreshHitory()
        {
            string begin = bDate.Value.ToString();
            string end = eDate.Value.ToString();
            string key = txtKey.Text;
            List<Failure_Information> list_raw = new List<Failure_Information>();
            list_raw = fiInstance.GetFailureInforList(begin, end, key);
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;

            AddCustomColumn();
        }

        private void RefreshAuditing()
        {
            List<Failure_Information> list_inv = new List<Failure_Information>();
            list_inv = fiInstance.GetAuditingFailureInforList();
            ug_listAudit.DataSource = list_inv;
        }

        void tbFAudit_AuditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {

                Failure_Information temp = row.ListObject as Failure_Information;
                Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", temp.FInfo_Code));

                if (string.IsNullOrEmpty(finfo.FInfo_RelationCode))
                {
                    FailureOp viewFrm = new FailureOp(fiInstance, finfo, true);
                    viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                    ComFAuditMain frm = new ComFAuditMain(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), finfo.FInfo_Code, finfo.AuditCurAudit, viewFrm);
                    frm.CallBack += new ComFAuditMain.DCallBackHandler(frm_CallBack);
                    if (DialogResult.OK == frm.ShowDialog())
                    {
                        viewFrm.isAudit = false;
                        viewFrm.Close();
                    }
                }
                else
                {
                    //FailureOp viewFrm = new FailureOp(fiInstance, finfo, true);
                    //viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;
                    BatchFailureOp BFFrm = new BatchFailureOp(new QX.BLL.Bll_Failure_Information(), finfo, OperationTypeEnum.OperationType.Edit);

                    ComFAuditMain frm = new ComFAuditMain(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), finfo.FInfo_Code, finfo.AuditCurAudit, BFFrm);
                    frm.CallBack += new ComFAuditMain.DCallBackHandler(frm_CallBack);
                    if (DialogResult.OK == frm.ShowDialog())
                    {
                        BFFrm.isAudit = false;
                        BFFrm.Close();
                    }
                }
            }
        }

        private BLL.Bll_Prod_Record preInstance = new QX.BLL.Bll_Prod_Record();

        private BLL.Bll_Inv_Information invInstance = new QX.BLL.Bll_Inv_Information();

        /// <summary>
        /// 审核回调函数(思路（先进行流程判断（ComFauditMain里面判断）是否进入返工OR报废）-->如果需要返工返修OR报废则对零件分别进行处理
        ///                                                                       -->如果不需要返工OR报废则根据处理方法批量更新产品状态)
        ///                                                                       
        /// </summary>
        /// <param name="re"></param>
        /// <param name="AStat"></param>
        void frm_CallBack(FAuditReturnResultEnum re, string AStat, string method)
        {
            //审核行
            UltraGridRow row = this.ug_listAudit.ActiveRow;
            if (row != null)
            {
                Failure_Information model = row.ListObject as Failure_Information;
                switch (re)
                {
                    case FAuditReturnResultEnum.Success:

                        Failure_Information finfo = fiInstance.GetModel(string.Format(" AND FInfo_Code='{0}'", model.FInfo_Code));

                        //适配以前的数据（如果有关联的多零件编号则用新窗口）
                        if (string.IsNullOrEmpty(finfo.FInfo_RelationCode))
                        {
                            if (finfo.FInfo_Stat == OperationTypeEnum.ProdStatEnum.Normal.ToString() || finfo.FInfo_Stat == "MoreUse")
                            {

                                MethodInvoker mi = delegate
                                {
                                    var f = new BLL.Bll_Failure_Information();
                                    var pr = f.CheckProdStat(finfo);

                                    var pInstance = new QX.BLL.Bll_Prod_Record();
                                    pInstance.SetProdNodeChecked(pr);

                                };
                                mi.BeginInvoke(null, null);
                            }
                            else
                            {
                                Alert.Show("审理完成!");
                            }
                        }//end  适配以前的数据
                        else
                        {
                            var map = MapSource.FirstOrDefault(o => o.Map_Object1 == model.AuditCurAudit);
                            //是否处于返工返修
                            if (map != null)
                            {
                                //如果为1则表示需要进一步确认的零件
                                if ("1".Equals(map.Map_Object3))
                                {
                                    FailureProdHandle frmProd = new FailureProdHandle(finfo);
                                    frmProd.ShowDialog();
                                }//根据选择的处理方法批量更新零件的状态(超差，单配)
                                else
                                {
                                    fiInstance.BatchProdStatChange(model, method);
                                }
                            }
                            else
                            {
                                Alert.Show("审理完成!");
                            }


                        }//不需要扭转，正常状态

                        //if (finfo.FInfo_Stat == OperationTypeEnum.ProdStatEnum.Normal.ToString()||finfo.FInfo_Stat=="MoreUse")
                        //{

                        //    MethodInvoker mi = delegate
                        //    {
                        //        var f = new BLL.Bll_Failure_Information();
                        //        var pr = f.CheckProdStat(finfo);
                        //        var pInstance = new QX.BLL.Bll_Prod_Record();
                        //        pInstance.SetProdNodeChecked(pr);

                        //    };
                        //    mi.BeginInvoke(null, null);
                        //    Alert.Show("产品已确认可以继续使用!");
                        //}//Hacker  如果审核后单据变成废单状态，表示被驳回，则进行额外处理（单据重置第一个审核节点）
                        //else if (finfo.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString())
                        //{
                        //    fiInstance.ResetProdStat(finfo);
                        //    Alert.Show("单据将重新进行处理!");
                        //}
                        //else
                        //{
                        //    Alert.Show("审核完成");
                        //}
                        break;
                    case FAuditReturnResultEnum.Fail:
                        Alert.Show("审核失败!");
                        break;
                }
            }
            RefreshAuditing();

        }


        private void AddCustomColumn()
        {

            if (!this.ug_listInList.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = ug_listInList.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;

            }
            else
            {
                ug_listInList.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = ug_listInList.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;
            }


        }


    }
}
