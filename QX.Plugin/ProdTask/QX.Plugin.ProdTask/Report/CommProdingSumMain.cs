using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using System.Collections;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace QX.Plugin.Prod.Report
{
    public partial class CommProdingSumMain : F_BasciForm
    {
        public CommProdingSumMain()
        {
            InitializeComponent();
        }


        UltraGrid uGridData = new UltraGrid();

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

        public CommProdingSumMain(string data)
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
            ModuleCode = MapData[2];
            this.Text = MapData[3];
            InitGrid();
            RfreshGrid();
            InitToolBar();
        }



        #region 工具栏初始化

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        public void InitToolBar()
        {

            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tool_bar_CContract_List.AddCustomControl(0, tLabel);

            this.tool_bar_CContract_List.AddCDTPtoToolstrip(1, bDate);
            bDate.Value = DateTime.Now.AddMonths(-1);
            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tool_bar_CContract_List.AddCustomControl(2, tLabel2);


            this.tool_bar_CContract_List.AddCDTPtoToolstrip(3, eDate);
            eDate.Value = DateTime.Now;
            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tool_bar_CContract_List.AddCustomControl(4, tLabel3);

            this.tool_bar_CContract_List.AddCustomControl(5, txtKey);

            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripButton SearchBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));
            tool_bar_CContract_List.AddCustomControl(6, SearchBtn);

            tool_bar_CContract_List.RefreshClicked += new EventHandler(tool_bar_CContract_List_RefreshClicked);

            ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(this.exportBtn_Click));

            tool_bar_CContract_List.AddCustomControl(exportBtn);

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
                export.Export(uGridData, file);
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
            //uGridData.DataSource = newdt;

            RfreshGrid();
        }


        #endregion

        #region 数据


        private void InitGrid()
        {
            try
            {
                uGridData = gridHelper.GenerateGrid(MapData[0], this.panel1, new Point(0, 0));

                //gridHelper.SetGridReadOnly(uGridData, true);
                gridHelper.SetExcelStyleFilter(uGridData);
                uGridData.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
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

                UltraGrid grid = uGridData;
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

                        var setting = this.uGridData.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, ucol);
                        //this.uGridData.DisplayLayout.Bands[0].SummaryFooterCaption = "合计";
                        setting.DisplayFormat = "{0:.##}";

                    }
                    else
                    {

                        grid.DisplayLayout.Bands[0].Columns.Remove(dt.Rows[i]["PRoad_NodeCode"].ToString());
                        var ucol = grid.DisplayLayout.Bands[0].Columns.Add(dt.Rows[i]["PRoad_NodeCode"].ToString(), dt.Rows[i]["PRoad_NodeName"].ToString());
                        ucol.Width = 30;
                        ucol.Header.VisiblePosition = 100 + i;


                        ucol.AllowRowSummaries = AllowRowSummaries.SingleSummaryBasedOnDataType;

                        var setting = this.uGridData.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, ucol);
                        //this.uGridData.DisplayLayout.Bands[0].SummaryFooterCaption = "合计";
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
            //获取该时间段内的零件
            DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);
            uGridData.DataSource = dt;

            //添加自定义列（工序）
            AddCustomerCol();

            ArrayList allData = CreateParamsForRpt();
            //所有数据（包括工序节点在内)
            DataTable dtAll = comInst.GetComDataTableByCode("All", DataCode, list);

            foreach (var r in uGridData.Rows)
            {
                foreach (var c in uGridData.DisplayLayout.Bands[0].Columns)
                {
                    var ds = dtAll.Select(string.Format(" PRoad_NodeCode='{0}' AND PlanProd_PartNo='{1}' AND CustCode='{2}' AND PlanProd_TaskCode='{3}'", c.Key, r.Cells["PlanProd_PartNo"].Value, r.Cells["CustCode"].Value, r.Cells["PlanProd_TaskCode"].Value));
                    if (ds.Length > 0)
                    {
                        r.Cells[c.Key].Value = ds.FirstOrDefault()["RCount"];
                    }
                }
            }

            if (!isInit&&!uGridData.DisplayLayout.Bands[0].Summaries.Exists("RCount"))
            {
                uGridData.DisplayLayout.Bands[0].Columns["RCount"].AllowRowSummaries = AllowRowSummaries.SingleSummaryBasedOnDataType;

                var setting = this.uGridData.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Sum, uGridData.DisplayLayout.Bands[0].Columns["RCount"]);
                this.uGridData.DisplayLayout.Bands[0].SummaryFooterCaption = "合计";
                setting.DisplayFormat = "{0:.##}";
                isInit = true;
            }
        }


        #endregion
    }
}
