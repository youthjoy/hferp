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
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using QX.BseDict;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace QX.Plugin.Contract
{
    public partial class ContractManage : F_BasciForm
    {
        private BLL.Bll_ContractManage ContractMange = new QX.BLL.Bll_ContractManage();
        private BLL.Bll_SD_Contract instance = new QX.BLL.Bll_SD_Contract();
        private BLL.Bll_SD_CDetail DetailInstance = new QX.BLL.Bll_SD_CDetail();
        private SD_Contract model = new SD_Contract();
        private List<SD_CDetail> DetailList = new List<SD_CDetail>();
        private DataTable dt;
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }


        UltraGrid uGridList = new UltraGrid();

        UltraGrid uGridAudit = new UltraGrid();

        #region 窗体单例
        public static ContractManage NewForm = null;
        public static ContractManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new ContractManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion

        ToolStripTextBox txtKey = new ToolStripTextBox();

        ToolStripTextBox txtLastKey = new ToolStripTextBox();

        DateTimePicker bFDate = new DateTimePicker();

        DateTimePicker eFDate = new DateTimePicker();

        GridHelper gen = new GridHelper();

        public ContractManage()
        {
            InitializeComponent();

            ToolStripHelper tsHelper = new ToolStripHelper();

            tool_top.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            tool_top.QueryClicked += new EventHandler(tool_top_QueryClicked);

            uGridList.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);


            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tool_top.AddCustomControl(7, tLabel);

            this.tool_top.AddCDTPtoToolstrip(8, bFDate);

            bFDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));


            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tool_top.AddCustomControl(9, tLabel2);

            this.tool_top.AddCDTPtoToolstrip(10, eFDate);

            eFDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));

            this.tool_top.AddCustomControl(11, txtKey);

            ToolStripButton searchBtn = new ToolStripButton();
            searchBtn.Text = "搜索";
            Image image3 = QX.Common.Properties.Resources.search;
            searchBtn.Image = image3;
            searchBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            searchBtn.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            searchBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            searchBtn.Click += new EventHandler(btnSearch_Click);
            this.tool_top.AddCustomControl(12, searchBtn);

            ToolStripHelper TsHelper = new ToolStripHelper();
            //ToolStripButton exportDetail = TsHelper.New("合同导出", QX.Common.Properties.Resources.import, new EventHandler(exportDetail_Click));
            //exportDetail.Name = "export";
            //tool_top.AddCustomControl(13,exportDetail);

            ToolStripButton exportContract = TsHelper.New("合同明细导出", QX.Common.Properties.Resources.import, new EventHandler(exportContract_Click));
            exportContract.Name = "exportdetail";
            tool_top.AddCustomControl(14, exportContract);

            ToolStripButton onWorkBtn = tsHelper.New("合同执行跟踪", QX.Common.Properties.Resources.compedit, new EventHandler(onWorkBtn_Click));

            this.tool_top.AddCustomControl(14, onWorkBtn);

            #region 待审核

            tbAudit.AuditClicked += new EventHandler(tbAudit_AuditClicked);
            tbAudit.RefreshClicked += new EventHandler(tbAudit_RefreshClicked);
            tbAudit.QueryClicked += new EventHandler(tbAudit_QueryClicked);

            #endregion

            #region 终审

            this.tbLast.RefreshClicked += new EventHandler(tbLast_RefreshClicked);

            this.tbLast.AddCustomControl(3, txtLastKey);

            ToolStripButton searchLastBtn = new ToolStripButton();
            searchLastBtn.Text = "搜索";
            searchLastBtn.Image = image3;
            searchLastBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            searchLastBtn.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            searchLastBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            searchLastBtn.Click += new EventHandler(btnLastSearch_Click);
            this.tbLast.AddCustomControl(4, searchLastBtn);

            this.tbLast.QueryClicked += new EventHandler(tbLast_QueryClicked);

            this.tbLast.HistoryClicked += new EventHandler(tbLast_HistoryClicked);

            #endregion
        }

        void exportContract_Click(object sender, EventArgs e)
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
                    grid = gen.GenerateGrid("CList_ExportContract", p, new Point(0, 0));

                    DataTable dt = DetailInstance.GetCDetailForExport(list);
                    grid.DataSource = dt;
                    grid.Refresh();
                    export.Export(grid, file);
                    Alert.Show("导出完成!");
                }
            }
            else
            {
                Alert.Show("请选择要导出的合同!");
            }
        }

        void exportDetail_Click(object sender, EventArgs e)
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
                //this.uGridExport.EndExport += new Infragistics.Win.UltraWinGrid.ExcelExport.EndExportEventHandler(uGridExport_EndExport);
                export.Export(this.uGridList, file);
            }
        }



        void onWorkBtn_Click(object sender, EventArgs e)
        {
            string Contract_Code = string.Empty;

            var row = uGridList.ActiveRow;
            if (row != null)
            {
                var item = row.ListObject as SD_Contract;

                var newitem = instance.GetModel(string.Format(" AND Contract_Code='{0}'", item.Contract_Code));



                ContractTrace op = new ContractTrace(item, OperationTypeEnum.OperationType.View);

            
                op.ShowDialog();

      
            }
        }

        void tbAudit_QueryClicked(object sender, EventArgs e)
        {
            string Contract_Code = string.Empty;

            var row = this.uGridAudit.ActiveRow;
            if (row != null)
            {
                var item = row.ListObject as SD_Contract;

                var newitem = instance.GetModel(string.Format(" AND Contract_Code='{0}'", item.Contract_Code));

                ContractOP op = new ContractOP(item, OperationTypeEnum.OperationType.Look);

                op.ShowDialog();

            }
        }

        void tool_top_QueryClicked(object sender, EventArgs e)
        {
            string Contract_Code = string.Empty;

            var row = uGridList.ActiveRow;
            if (row != null)
            {
                var item = row.ListObject as SD_Contract;

                var newitem = instance.GetModel(string.Format(" AND Contract_Code='{0}'", item.Contract_Code));

                ContractOP op = new ContractOP(item, OperationTypeEnum.OperationType.Look);

                op.ShowDialog();

            }
        }

        void tbLast_HistoryClicked(object sender, EventArgs e)
        {

            UltraGridRow row = this.uGridLast.ActiveRow;
            if (row != null)
            {
                SD_Contract road = row.ListObject as SD_Contract;
                ComAuditMain auditMain = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.ContractAudit.ToString(), road.Contract_Code);
                auditMain.ShowDialog();
            }
        }

        void tbLast_QueryClicked(object sender, EventArgs e)
        {
            string Contract_Code = string.Empty;

            var row = this.uGridLast.ActiveRow;
            if (row != null)
            {
                var item = row.ListObject as SD_Contract;

                var newitem = instance.GetModel(string.Format(" AND Contract_Code='{0}'", item.Contract_Code));
                ContractOP op = new ContractOP(item, OperationTypeEnum.OperationType.Edit);

                op.OperationType = OperationTypeEnum.OperationType.Look;
                op.ShowDialog();
            }
        }
        /// <summary>
        /// 终审列表刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tbLast_RefreshClicked(object sender, EventArgs e)
        {
            RefreshLastGrid();
        }

        /// <summary>
        /// 终审列表搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtLastKey.Text))
            {
                FilterLastDataTable(txtLastKey.Text);
            }
            else
            {
                RefreshLastGrid();
            }
        }

        /// <summary>
        /// 合同列表搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                RefreshListGrid(txtKey.Text);
            }
            else
            {
                RefreshListGrid("");
            }
        }

        void tbAudit_RefreshClicked(object sender, EventArgs e)
        {
            RefreshAuditGrid();
        }

        void tbAudit_AuditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridAudit.ActiveRow;
            if (row != null)
            {
                SD_Contract contract = row.ListObject as SD_Contract;
                //var  model = instance.GetModel(" AND Contract_Code='" + Contract_Code + "'");
                DetailList = DetailInstance.GetList(" AND CDetail_ContractNo='" + contract.Contract_Code + "' ");


                ContractOP viewFrm = new ContractOP(contract, OperationTypeEnum.OperationType.Edit, true);
                //viewFrm.ContractInstance = instance;
                //viewFrm.CdetailInstance = DetailInstance;
                //viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.ContractAudit.ToString(), contract.Contract_Code, contract.AuditCurAudit, viewFrm);

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
            UltraGridRow row = this.uGridAudit.ActiveRow;

            switch (re)
            {
                case AuditReturnResultEnum.Success:
                    RefreshAuditGrid();
                    Alert.Show("审核完成");
                    break;
                case AuditReturnResultEnum.Fail:
                    Alert.Show("审核失败!");
                    break;
            }
        }

        void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            tool_top_EditClicked(this, EventArgs.Empty);
        }

        void tool_top_RefreshClicked(object sender, EventArgs e)
        {
            //InitGrid("");
            RefreshListGrid("");
        }


        void tool_top_DelClicked(object sender, EventArgs e)
        {
            if (uGridList.ActiveRow != null)
            {
                if (DialogResult.Yes == Alert.Show(MessageBoxButtons.YesNo, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string Code = uGridList.ActiveRow.Cells["Contract_Code"].Value.ToString();
                    bool result = ContractMange.DeleteContract(Code);
                    if (result)
                    {
                        //InitGrid("");
                        RefreshListGrid("");
                        Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
                    }
                    else
                    {
                        Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
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
            string Contract_Code = string.Empty;

            var row = uGridList.ActiveRow;
            if (row != null)
            {
                var item = row.ListObject as SD_Contract;

                var newitem = instance.GetModel(string.Format(" AND Contract_Code='{0}'", item.Contract_Code));

                ContractOP op = new ContractOP(item, OperationTypeEnum.OperationType.Edit);

                if (newitem.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                {
                    Alert.Show("当前合同正在审核流程中，不能进行数据更改!");
                    
                    op.OperationType = OperationTypeEnum.OperationType.Look;

                    
                }
                //op.ContractInstance = instance;
                //op.CdetailInstance = DetailInstance;
                //op.OperationType = OperationTypeEnum.OperationType.Edit;
                op.ShowDialog();
                //InitGrid("");
                RefreshListGrid("");
            }
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            var model = new SD_Contract();
            model.Contract_Code = instance.GenerateContractCode();
            ContractOP op = new ContractOP(model, OperationTypeEnum.OperationType.Add);
            //op.ContractInstance = instance;
            //op.CdetailInstance = DetailInstance;
            //op.OperationType = OperationTypeEnum.OperationType.Add;
            //op.CallBack += new ContractOP.DDataChangeHandler(op_CallBack);
            op.ShowDialog();
            //InitGrid("");
            RefreshListGrid("");
            RefreshAuditGrid();
        }

        void op_CallBack(object sender, EventArgs e)
        {
            //InitGrid("");
            RefreshListGrid("");
        }

        private FormHelper fHelper = new FormHelper();

        private void ContractManage_Load(object sender, EventArgs e)
        {
            InitGrid("");

            InitLastGrid();

            InitAuditGrid();

            fHelper.PermissionControl(this.tool_top.toolStrip1.Items, PermissionModuleEnum.Contract.ToString());
        }

        List<SD_Contract> ContractSource = new List<SD_Contract>();

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void InitGrid(string filter)
        {
            //MetaReflection<SD_Contract> reflection = new MetaReflection<SD_Contract>();
            //Dictionary<string, string> dic = reflection.GetMeta();
            List<SD_Contract> list = instance.GetMyList();
            ContractSource = list;
            GridHelper gen = new GridHelper();
            uGridList = gen.GenerateGrid("GContract", this.pnlList, new Point(0, 0));
            uGridList.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(uGridList_InitializeRow);
            uGridList.DataSource = list;
            //设置数据过滤
            gen.SetExcelStyleFilter(uGridList);

            gen.SetGridReadOnly(uGridList, true);

            gen.SetGridColumnStyle(uGridList, AutoFitStyle.ExtendLastColumn);


            #region 待审核

            //MetaReflection<SD_Contract> reflection = new MetaReflection<SD_Contract>();
            //Dictionary<string, string> dic = reflection.GetMeta();
            //List<SD_Contract> list = instance.GetAll();

            List<SD_Contract> auditlist = instance.GetAuditContract();

            uGridAudit = gen.GenerateGrid("GContract", this.pnlAudit, new Point(0, 0));

            uGridAudit.DataSource = auditlist;

            gen.SetGridReadOnly(uGridAudit, true);

            gen.SetGridColumnStyle(uGridAudit, AutoFitStyle.ExtendLastColumn);


            #endregion

            AddCustomColumn();

        }

        private void AddCustomColumn()
        {

            if (!this.uGridList.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = uGridList.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
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
                uGridList.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = uGridList.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
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

        private List<SD_Contract> GetGridCheckBoxData()
        {
            List<SD_Contract> list = new List<SD_Contract>();

            foreach (UltraGridRow r in this.uGridList.DisplayLayout.Rows)
            {

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    SD_Contract planProd = r.ListObject as SD_Contract;
                    list.Add(planProd);
                }
            }

            return list;
        }

        void uGridList_InitializeRow(object sender, InitializeRowEventArgs e)
        {


            UltraGridRow row = e.Row;
            try
            {
                SD_Contract val = row.ListObject as SD_Contract;

                if (val != null && val.AuditStat != null)
                {

                    OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), val.AuditStat));

                    switch (auditType)
                    {
                        case OperationTypeEnum.AudtiOperaTypeEnum.Auditing:

                            e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[0];
                            //e.Row.Cells["RComponents_AuditStat"].Value = "待审核";
                            break;
                        case OperationTypeEnum.AudtiOperaTypeEnum.OnAudit:
                            e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[1];
                            //e.Row.Appearance.BackColor = auditedColor;
                            //e.Row.Cells["RComponents_AuditStat"].Value = "审核中";
                            break;
                        case OperationTypeEnum.AudtiOperaTypeEnum.LastAudit:
                            //e.Row.Cells["RComponents_AuditStat"].Value = "已终审";
                            break;
                        case OperationTypeEnum.AudtiOperaTypeEnum.Litter:
                            e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[2];
                            break;
                    }
                }
                else
                {
                    e.Row.Appearance.BackColor = Color.Red;
                    //e.Row.Cells["RComponents_AuditStat"].Value = "未知状态";
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void RefreshListGrid(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {

                List<SD_Contract> list = instance.GetMyList();
                uGridList.DataSource = list;
            }
            else
            {
                var tmp = FilterDataTable(filter);
                uGridList.DataSource = tmp;
            }
            AddCustomColumn();
            //    gHandler.BindData(tmp, dic, false);
        }



        /// <summary>
        /// 筛选
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private List<SD_Contract> FilterDataTable(string filter)
        {
            string bDate = bFDate.Value.ToString();
            string eDate = eFDate.Value.ToString();
            string key = this.txtKey.Text;

            //Predicate<SD_Contract> math = delegate(SD_Contract p) { return (p.Contract_Code.Contains(key.ToUpper()) || ((p.Contract_Name == null ? "" : p.Contract_Name).Contains(key.ToUpper()))); };

            //List<SD_Contract> filterData = CollectionHelper.Filter<SD_Contract>(ContractSource, math);
            var list=instance.GetContractListByWhere(bDate,eDate,key);
            return list;
        }


        #region 待审核


        public void InitAuditGrid()
        {
            //List<SD_Contract> list = instance.GetAuditContract();
            //GridHelper gen = new GridHelper();
            ////uGridAudit = gen.GenerateGrid("GContract", this.pnlAudit, new Point(0, 0));
            //uGridAudit.DataSource = list;
            //gen.SetGridReadOnly(uGridLast, true);
            //gen.SetGridColumnStyle(uGridLast, AutoFitStyle.ExtendLastColumn);

        }

        public void RefreshAuditGrid()
        {
            List<SD_Contract> list = instance.GetAuditContract();
            //if (list.Count == 0)
            //{
            //    uGridAudit.DataSource = new List<SD_Contract>();
            //}
            //else
            //{
            uGridAudit.DataSource = list;
            //}
            uGridAudit.Refresh();
        }

        #endregion


        #region 终审

        UltraGrid uGridLast = new UltraGrid();

        List<SD_Contract> CurLastSource = new List<SD_Contract>();
        public void InitLastGrid()
        {
            List<SD_Contract> list = instance.GetLastAudit();
            CurLastSource = list;
            GridHelper gen = new GridHelper();
            uGridLast = gen.GenerateGrid("GContract", this.pnlLast, new Point(0, 0));
            uGridLast.DataSource = list;
            gen.SetGridReadOnly(uGridLast, true);
            gen.SetGridColumnStyle(uGridLast, AutoFitStyle.ExtendLastColumn);

        }

        public void RefreshLastGrid()
        {

            List<SD_Contract> list = instance.GetLastAudit();
            uGridLast.DataSource = list;

        }

        private void FilterLastDataTable(string filter)
        {

            string key = filter;

            Predicate<SD_Contract> math = delegate(SD_Contract p) { return (p.Contract_Code.ToUpper().Contains(key.ToUpper()) || (p.Contract_Name.ToUpper().Contains(key.ToUpper()))); };

            List<SD_Contract> filterData = CollectionHelper.Filter<SD_Contract>(CurLastSource, math);
            uGridLast.DataSource = filterData;
        }

        #endregion
    }
}
