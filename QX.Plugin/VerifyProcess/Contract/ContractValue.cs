using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;

using QX.Shared;
using System.Collections;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace QX.Plugin.Contract
{
    public partial class ContractValue : Form
    {
        public ContractValue()
        {
            InitializeComponent();
            BindEvent();
            this.Load += new EventHandler(Form_load);
        }

        public delegate void DCallBackHandler(object sender, List<Prod_PlanProd> list);
        public event DCallBackHandler CallBack;

        void Form_load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindEvent()
        {
            //this.tool_bar.AddClicked += new EventHandler(tool_bar_AddClicked);
            //this.tool_bar.SaveClicked += new EventHandler(tool_bar_SaveClicked);
            this.tool_bar.SearchClicked += new EventHandler(tool_bar_SearchClicked);
            this.tool_bar.AddSearchAllModule();

        }

        void tool_bar_SearchClicked(object sender, EventArgs e)
        {
            this.RfreshGrid();
        }


        //public UltraGrid custGrid = new UltraGrid();
        public UltraGrid partGrid = new UltraGrid();
        public UltraGrid roadGrid = new UltraGrid();

        GridHelper gen = new GridHelper();
        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();
        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();
        private Bll_SD_CDetail sdcInstance = new Bll_SD_CDetail();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        public void BindData()
        {

            gen.GenerateColumn("CList_CustContract", this.custGrid, new Point(0, 0));
            //custGrid.AfterExitEditMode += new EventHandler(custGrid_AfterExitEditMode);
            //this.custGrid.AfterRowActivate+=new EventHandler(custGrid_AfterRowActivate);
            List<SD_Finance> list = new List<SD_Finance>();
            list = sdcInstance.GetFinanceList("", "", "");
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            this.custGrid.DataSource = dataSource;
            this.custGrid.DisplayLayout.Override.MergedCellStyle = MergedCellStyle.Always;
            this.custGrid.DisplayLayout.Bands[0].Columns["SDF_Customer"].MergedCellStyle = MergedCellStyle.Always;



            //this.partGrid = gen.GenerateGrid("CList_CustPart", this.panel2, new Point(0, 0));
            //partGrid.AfterRowActivate += new EventHandler(partGrid_AfterRowActivate);
            //List<SD_Finance> list2 = new List<SD_Finance>();
            //BindingSource dataSource2 = new BindingSource();
            //dataSource2.DataSource = list2;
            //this.partGrid.DataSource = dataSource2;

            //roadGrid = gen.GenerateGrid("CList_CustNodes", this.panel3, new Point(0, 0));

            //List<SD_Finance> list1 = new List<SD_Finance>();
            //BindingSource dataSource1 = new BindingSource();
            //dataSource1.DataSource = list1;
            //roadGrid.DataSource = dataSource1;
        }
        #region  暂时隐藏
        //void custGrid_AfterExitEditMode(object sender, EventArgs e)
        //{
        //    //UltraGridRow row = this.custGrid.ActiveRow;
        //    //if (row != null)
        //    //{
        //    //    SD_Contract sd = row.ListObject as SD_Contract;

        //    //    this.PartBind(sd.Contract_CustCode);
        //    //}
        //}

        //void partGrid_AfterRowActivate(object sender, EventArgs e)
        //{
        //    //UltraGridRow row = this.partGrid.ActiveRow;
        //    //if (row != null)
        //    //{

        //    //    SD_CDetail sd = row.ListObject as SD_CDetail;
        //    //    this.NodesBind(sd.CDetail_PartNo);
        //    //}
        //}

        //void custGrid_AfterRowActivate(object sender, EventArgs e)
        //{
        //    //UltraGridRow row = this.custGrid.ActiveRow;
        //    //if (row != null)
        //    //{

        //    //    SD_Contract sd = row.ListObject as SD_Contract;
        //    //    this.PartBind(sd.Contract_CustCode);
        //    //}
        //}

        //public void PartBind(string cust)
        //{
        //    if (string.IsNullOrEmpty(cust))
        //    {
        //        var list = new List<SD_CDetail>();
        //        partGrid.DataSource = list;
        //    }
        //    else
        //    {
        //        var list = sdcInstance.GetDetailListByCust(cust);
        //        partGrid.DataSource = list;
        //    }
        //}

        //public void NodesBind(string partno)
        //{
        //    if (string.IsNullOrEmpty(partno))
        //    {
        //        List<Road_Nodes> list = new List<Road_Nodes>();

        //        roadGrid.DataSource = list;
        //    }
        //    else
        //    {
        //        List<Road_Nodes> list = new List<Road_Nodes>();
        //        list = rnInstance.GetRoadNodesByComponents(partno);
        //        roadGrid.DataSource = list;
        //    }
        //}
        #endregion



        //UltraGrid custGrid = new UltraGrid();

        GridHelper gridHelper = new GridHelper();

        BLL.Bll_Comm comInst = new QX.BLL.Bll_Comm();

        private OperationTypeEnum operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public OperationTypeEnum OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public string DataCode
        {
            get;
            set;
        }

        public string ModuleCode
        {
            get;
            set;
        }


        public string[] MapData
        {
            get;
            set;
        }

        public ContractValue(string data)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(data))
            {
                MapData = data.Split('|');
            }

            if (MapData.Length == 0)
            {
                Alert.Show("数据配置错误!");
            }

            DataCode = MapData[1];
            ModuleCode = MapData[0];
            this.Text = MapData[2];
            InitGrid();
            RfreshGrid();
            InitToolBar();
            BindEvent();
        }



        #region 工具栏初始化

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        public void InitToolBar()
        {

            ////时间控件
            //ToolStripLabel tLabel = new ToolStripLabel();
            //tLabel.Text = "开始时间:";
            //this.tool_bar_CContract_List.AddCustomControl(0, tLabel);

            //this.tool_bar_CContract_List.AddCDTPtoToolstrip(1, bDate);
            //bDate.Value = DateTime.Now.AddMonths(-1);
            //ToolStripLabel tLabel2 = new ToolStripLabel();
            //tLabel2.Text = "结束时间:";
            //this.tool_bar_CContract_List.AddCustomControl(2, tLabel2);


            //this.tool_bar_CContract_List.AddCDTPtoToolstrip(3, eDate);
            //eDate.Value = DateTime.Now;
            //ToolStripLabel tLabel3 = new ToolStripLabel();
            //tLabel3.Text = "关键字:";
            //this.tool_bar_CContract_List.AddCustomControl(4, tLabel3);

            //this.tool_bar_CContract_List.AddCustomControl(5, txtKey);

            //ToolStripHelper tsHelper = new ToolStripHelper();
            //ToolStripButton SearchBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));
            //tool_bar_CContract_List.AddCustomControl(6, SearchBtn);

            //tool_bar_CContract_List.RefreshClicked += new EventHandler(tool_bar_CContract_List_RefreshClicked);

            //ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(this.exportBtn_Click));

            //tool_bar_CContract_List.AddCustomControl(exportBtn);

        }

        void exportBtn_Click(object sender, EventArgs e)
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
                export.Export(this.custGrid, file);
                Alert.Show("导出完成!");
            }
        }

        void tool_bar_CContract_List_RefreshClicked(object sender, EventArgs e)
        {
            RfreshGrid();
        }

        void SearchBtn_Click(object sender, EventArgs e)
        {
            //DateTime beginDate = this.bDate.Value;
            //DateTime endDate = this.eDate.Value;
            //string key = this.txtKey.Text;

            //string where = string.Empty;

            //ArrayList list = new ArrayList();
            //list.Add(beginDate);
            //list.Add(endDate);
            //list.Add(key);
            //list.Add("");
            //list.Add("");
            //list.Add("");
            //DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);
            //DataTable newdt = new DataTable();
            //newdt = dt.Clone();
            //DataRow[] dr = dt.Select(string.Format(" Cust_Name like '%{0}%' OR Equ_Name like '%{0}%' OR Equ_Code like '%{0}%' OR PlanProd_PartNo like '%{0}%' OR PlanProd_PartName like '%{0}%'", key));
            //for (int i = 0; i < dr.Length; i++)
            //{
            //    newdt.ImportRow((DataRow)dr[i]);
            //}
            //custGrid.DataSource = newdt;

            RfreshGrid();
        }


        #endregion

        #region 数据


        private void InitGrid()
        {
            try
            {
                gridHelper.GenerateColumn(MapData[0], custGrid, new Point(0, 0));

                gridHelper.SetGridReadOnly(custGrid, true);
                //gridHelper.SetExcelStyleFilter(custGrid);
                custGrid.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;

                //this.custGrid.DisplayLayout.Override.MergedCellStyle = MergedCellStyle.Always;
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AddCustomerCol()
        {

            try
            {

                ArrayList list = CreateParamsForRpt();

                UltraGrid grid = custGrid;
                //该时间段内所有工序
                DataTable dt = comInst.GetComDataTableByCode("ProdingNode", DataCode, list);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!grid.DisplayLayout.Bands[0].Columns.Exists(dt.Rows[i]["PRoad_NodeCode"].ToString()))
                    {
                        var ucol = grid.DisplayLayout.Bands[0].Columns.Add(dt.Rows[i]["PRoad_NodeCode"].ToString(), dt.Rows[i]["PRoad_NodeName"].ToString());
                        ucol.Width = 30;
                        ucol.Header.VisiblePosition = 100 + i;
                        //ug_list.DisplayLayout.Bands[0].Columns[field.DCP_ControlID].AllowRowSummaries = AllowRowSummaries.SingleSummaryBasedOnDataType;
                        ucol.AllowRowSummaries = AllowRowSummaries.SingleSummaryBasedOnDataType;

                        var setting = this.custGrid.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, ucol);
                        //this.custGrid.DisplayLayout.Bands[0].SummaryFooterCaption = "合计";
                        setting.DisplayFormat = "{0:.##}";

                    }
                    else
                    {

                        grid.DisplayLayout.Bands[0].Columns.Remove(dt.Rows[i]["PRoad_NodeCode"].ToString());
                        var ucol = grid.DisplayLayout.Bands[0].Columns.Add(dt.Rows[i]["PRoad_NodeCode"].ToString(), dt.Rows[i]["PRoad_NodeName"].ToString());
                        ucol.Width = 30;
                        ucol.Header.VisiblePosition = 100 + i;


                        ucol.AllowRowSummaries = AllowRowSummaries.SingleSummaryBasedOnDataType;
            
                        var setting = this.custGrid.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, ucol);
                        //this.custGrid.DisplayLayout.Bands[0].SummaryFooterCaption = "合计";
                        setting.DisplayFormat = "{0:.##}";
                    }
                }

            }
            catch (Exception ex)
            {

            }


        }

        private ArrayList CreateParamsForRpt()
        {
            ArrayList list = new ArrayList();
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            string key = this.txtKey.Text;

            string where = string.Empty;

            list.Add(beginDate);
            list.Add(endDate);
            list.Add(key);
            list.Add("");
            list.Add("");
            list.Add("");

            return list;
        }
        bool isInit = false;

        private void RfreshGrid()
        {
            ArrayList list = CreateParamsForRpt();
            //获取该时间段内的零件  存储过程名称-模块
            DataTable dt = comInst.GetComDataTableByCode(MapData[0], MapData[1], list);
            this.custGrid.DataSource = dt;
            if (!isInit)
            {

                this.custGrid.DisplayLayout.Bands[0].Columns["SDF_Customer"].MergedCellStyle = MergedCellStyle.Always;
                this.custGrid.DisplayLayout.Bands[0].Columns["SDF_PartName"].MergedCellStyle = MergedCellStyle.Always;
                this.custGrid.DisplayLayout.Bands[0].Columns["SDF_PartNo"].MergedCellStyle = MergedCellStyle.Always;
                this.custGrid.DisplayLayout.Bands[0].Columns["SDF_ProdType"].MergedCellStyle = MergedCellStyle.Always;
                isInit = true;
                
            }
            //添加自定义列（工序）
            AddCustomerCol();

            ArrayList allData = CreateParamsForRpt();
            //所有数据（包括工序节点在内)
            DataTable dtAll = comInst.GetComDataTableByCode("All", DataCode, list);

            foreach (var r in custGrid.Rows)
            {
                foreach (var c in custGrid.DisplayLayout.Bands[0].Columns)
                {
                    var ds = dtAll.Select(string.Format(" SDF_NodeCode='{0}' AND SDF_PartNo='{1}' AND SDF_Customer='{2}' AND SDF_ProdType='{3}'", c.Key, r.Cells["SDF_PartNo"].Value, r.Cells["SDF_Customer"].Value, r.Cells["SDF_ProdType"].Value));
                    if (ds.Length > 0)
                    {
                        r.Cells[c.Key].Value = ds.FirstOrDefault()["SDF_Value"];
                    }
                }
            }

            //if (!isInit && !custGrid.DisplayLayout.Bands[0].Summaries.Exists("RCount"))
            //{
            //    custGrid.DisplayLayout.Bands[0].Columns["RCount"].AllowRowSummaries = AllowRowSummaries.SingleSummaryBasedOnDataType;

            //    var setting = this.custGrid.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, custGrid.DisplayLayout.Bands[0].Columns["RCount"]);
            //    this.custGrid.DisplayLayout.Bands[0].SummaryFooterCaption = "合计";
            //    setting.DisplayFormat = "{0:.##}";
            //    isInit = true;
            //}
        }


        #endregion
    }
}

