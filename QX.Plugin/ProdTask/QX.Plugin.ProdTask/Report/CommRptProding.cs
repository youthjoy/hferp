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
using QX.BLL;
using QX.DataModel;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace QX.Plugin.Prod.Report
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CommRptProding : F_BasciForm
    {
        public CommRptProding()
        {
            InitializeComponent();
        }

        //UltraGrid uGridData = new UltraGrid();

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

        public CommRptProding(string data)
        {
            InitializeComponent();
            try
            {
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
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
        }



        #region 工具栏初始化

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        ComboBox comboStat = new ComboBox();

        public void InitToolBar()
        {
            //this.tool_bar_CContract_List.EditClicked += new EventHandler(tool_bar_CContract_List_EditClicked);

            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tool_bar_CContract_List.AddCustomControl(0, tLabel);

            this.tool_bar_CContract_List.AddCDTPtoToolstrip(1, bDate);
            bDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));
            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tool_bar_CContract_List.AddCustomControl(2, tLabel2);


            this.tool_bar_CContract_List.AddCDTPtoToolstrip(3, eDate);
            eDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));
            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tool_bar_CContract_List.AddCustomControl(4, tLabel3);

            this.tool_bar_CContract_List.AddCustomControl(5, txtKey);

            ToolStripHelper tsHelper = new ToolStripHelper();


            Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();
            List<Bse_Dict> list = dcInstance.GetListByDictKeyByNoRoot("SearchType");

            comboStat.DataSource = list;
            comboStat.DisplayMember = "Dict_Name";
            comboStat.ValueMember = "Dict_Code";
            comboStat.Tag = list;

            ToolStripControlHost comboStatHost = new ToolStripControlHost(comboStat);
            comboStatHost.Margin = new Padding(5, 0, 0, 0);
            this.tool_bar_CContract_List.AddCustomControl(6, comboStatHost);


            ToolStripButton SearchBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));
            tool_bar_CContract_List.AddCustomControl(7, SearchBtn);

            //tool_bar_CContract_List.RefreshClicked += new EventHandler(tool_bar_CContract_List_RefreshClicked);

            ToolStripButton NodeViewBtn = tsHelper.New("查看工序", QX.Common.Properties.Resources.nodes, new EventHandler(NodeViewBtn_Click));
            //NodeViewBtn.Click += new EventHandler(NodeViewBtn_Click);
            tool_bar_CContract_List.AddCustomControl(NodeViewBtn);

            ToolStripButton btnExport = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(btnExport_Click));

            tool_bar_CContract_List.AddCustomControl(btnExport);
        }

        void btnExport_Click(object sender, EventArgs e)
        {
            if (uGridData.Rows.Count <= 0)
            {
                Alert.Show("现阶段没有数据可以导出!");
                return;
            }
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
                export.Export(uGridData, file);
                Alert.Show("导出完成!");
            }
        }

        void tool_bar_CContract_List_EditClicked(object sender, EventArgs e)
        {
            test t = new test();
            t.ShowDialog();
        }

        private BLL.Bll_Prod_Roads prInst = new QX.BLL.Bll_Prod_Roads();

        void NodeViewBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridData.ActiveRow;
            if (row != null)
            {
                string pcode = row.Cells["PRoad_PlanCode"].Value.ToString();
                CommPRoads frm = new CommPRoads(pcode);
                frm.ShowDialog();
            }
        }

        void tool_bar_CContract_List_RefreshClicked(object sender, EventArgs e)
        {
            RfreshGrid();
        }

        void SearchBtn_Click(object sender, EventArgs e)
        {
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            string key = this.txtKey.Text;
            string type = this.comboStat.SelectedValue.ToString();

            string where = string.Empty;

            ArrayList list = new ArrayList();

            list.Add(beginDate);
            list.Add(endDate);
            list.Add(key);
            list.Add("");
            list.Add(type);
            list.Add("");
            DataTable dt = comInst.GetComDataTableByCode("", DataCode, list);



            DataTable newdt = new DataTable();
            newdt = dt.Clone();
            uGridData.DataSource = dt;
            ////客户
            //if (type == "CustType")
            //{

            //    DataRow[] dr = dt.Select(string.Format("Cmd_Dep_Name like '%{0}%' OR PRoad_NodeName like '%{0}%' OR PlanProd_PartNo like '%{0}%' or PRoad_ProdCode like '%{0}%'", key));
            //    for (int i = 0; i < dr.Length; i++)
            //    {
            //        newdt.ImportRow((DataRow)dr[i]);
            //    }
            //}
            //else if (type == "ProdType")
            //{
            //    DataRow[] dr = dt.Select(string.Format("Comp_CatName like '%{0}%' OR PRoad_NodeName like '%{0}%' OR PlanProd_PartNo like '%{0}%' or PRoad_ProdCode like '%{0}%'", key));
            //    for (int i = 0; i < dr.Length; i++)
            //    {
            //        newdt.ImportRow((DataRow)dr[i]);
            //    }
            //}
            //else
            //{
            //    DataRow[] dr = dt.Select(string.Format("PRoad_NodeName like '%{0}%' OR PlanProd_PartNo like '%{0}%' or PRoad_ProdCode like '%{0}%'", key));
            //    for (int i = 0; i < dr.Length; i++)
            //    {
            //        newdt.ImportRow((DataRow)dr[i]);
            //    }
            //}
            //uGridData.DisplayLayout.Override.AllowGroupBy = DefaultableBoolean.True;
            //this.uGridData.DisplayLayout.GroupByBox.Hidden = false;

            //uGridData.DataSource = dt;
            ////uGridData.DataSource = dt;
            ////uGridData.DisplayLayout.Override.AllowGroupBy = DefaultableBoolean.True;
            //uGridData.DisplayLayout.Override.AllowGroupBy = DefaultableBoolean.True;
            //this.uGridData.DisplayLayout.GroupByBox.Hidden = false;
            //this.uGridData.DisplayLayout.Override.GroupByColumnsHidden = DefaultableBoolean.False;

            //this.uGridData.DisplayLayout.Bands[0].Summaries.Clear();
            //this.uGridData.DisplayLayout.Bands[0].Columns["PRoad_NodeName"].AllowRowSummaries = AllowRowSummaries.True;
            //this.uGridData.DisplayLayout.Bands[0].SummaryFooterCaption = "数量:";
            //this.uGridData.DisplayLayout.Bands[0].Summaries.Add(SummaryType.Count, this.uGridData.DisplayLayout.Bands[0].Columns["PRoad_NodeName"]);
            //this.uGridData.DisplayLayout.Bands[0].Summaries[0].DisplayFormat = "{0}";
        }


        #endregion

        #region 数据

        /// <summary>
        /// 结算单
        /// </summary>
        private void InitGrid()
        {
            try
            {
                
                gridHelper.GenerateColumn(MapData[0],this.uGridData, new Point(0, 0));

                gridHelper.SetGridReadOnly(uGridData, true);
                gridHelper.SetExcelStyleFilter(uGridData);
                //GridHandler handler = new GridHandler(uGridData);

                //handler.SetDefaultStyle();

                uGridData.DisplayLayout.Override.AllowGroupBy = DefaultableBoolean.True;
                this.uGridData.DisplayLayout.GroupByBox.Hidden = false;
                this.uGridData.DisplayLayout.Override.GroupByColumnsHidden = DefaultableBoolean.False;
                this.uGridData.DisplayLayout.GroupByBox.Prompt = "把要分组统计的列拖到这里";

                this.uGridData.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True;
                this.uGridData.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.RowIndex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void RfreshGrid()
        {
            ArrayList list = new ArrayList();
            DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);
            uGridData.DataSource = dt;



        }


        #endregion

    }
}
