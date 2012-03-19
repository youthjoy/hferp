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
using Infragistics.Win;

namespace QX.Plugin.Prod.Report
{
    public partial class CommRptContract : Form
    {


        public CommRptContract()
        {
            InitializeComponent();
        }



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

        public CommRptContract(string data)
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
            ToolStripHelper tsHelper=new ToolStripHelper();

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


            ToolStripButton SearchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));
            tool_bar_CContract_List.AddCustomControl(6, SearchBtn);

            tool_bar_CContract_List.RefreshClicked += new EventHandler(tool_bar_CContract_List_RefreshClicked);

            ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(exportBtn_Click));
            tool_bar_CContract_List.AddCustomControl(exportBtn);


        }
          

        void exportBtn_Click(object sender, EventArgs e)
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

        void tool_bar_CContract_List_RefreshClicked(object sender, EventArgs e)
        {
            //RfreshGrid();
            SearchBtn_Click(null, null);
        }

        void SearchBtn_Click(object sender, EventArgs e)
        {
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            string key = this.txtKey.Text;

            string where = string.Empty;

            ArrayList list = new ArrayList();
            list.Add(beginDate);
            list.Add(endDate);
            list.Add(key);
            list.Add("");
            list.Add("");
            list.Add("");
            DataTable dt = comInst.GetComDataTableByCode(ModuleCode,DataCode,list);

            DataTable newdt = new DataTable();
            newdt = dt.Clone();
            //DataRow[] dr = dt.Select(string.Format(" PlanProd_PartNo like '%{0}%' or PlanProd_PartName like '%{0}%'", key));
            //for (int i = 0; i < dr.Length; i++)
            //{
            //    newdt.ImportRow((DataRow)dr[i]);
            //}
            uGridData.DataSource = dt;

            //if ("CList_FProd".Equals(MapData[0]))
            //{
            //    uGridData.DisplayLayout.Bands[0].Columns["ProdCodeList"].CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            //    //uGridData.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(uGridData_InitializeRow);
            //}
            //uGridData.DataSource = dt;
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

                gridHelper.GenerateColumn(MapData[0], this.uGridData, new Point(0, 0));
    
                uGridData.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                gridHelper.SetExcelStyleFilter(uGridData);
                //gridHelper.SetGridReadOnly(uGridData, true);
            }
            catch(Exception ex)
            {
                
                throw ex;
            }
        }

        void uGridData_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            if (e.Row.Cells["ProdCodeList"].Value != null)
            {
                string code = e.Row.Cells["ProdCodeList"].Value.ToString();
                e.Row.Cells["ProdCodeList"].Value = code.Trim();
                string[] codelist = code.Trim(' ').Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                if (codelist.Length > 5)
                {
                    int len = codelist.Length;
                    int size = codelist.Length / 5;
                    if (len % 5 > 0)
                    {
                        size = size + 1;
                    }
                     e.Row.Height= 20*size;
       
                }
            }
        }



        private void RfreshGrid()
        {
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            //string key = this.txtKey.Text;

            ArrayList list = new ArrayList();
            list.Add(beginDate);
            list.Add(endDate);
            list.Add("");
            list.Add("");
            list.Add("Init");
            list.Add("");

            DataTable dt=comInst.GetComDataTableByCode(ModuleCode,DataCode,list);
            //DataTable dtn = dt.Clone();
            uGridData.DataSource = dt;

            if ("CList_FProd".Equals(MapData[0]))
            {
                //uGridData.DisplayLayout.Override.DefaultRowHeight = 40;
                uGridData.DisplayLayout.Bands[0].Columns["ProdCodeList"].CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
                uGridData.DisplayLayout.Bands[0].Columns["ProdCodeList"].VertScrollBar = true;

                //uGridData.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(uGridData_InitializeRow);
            }
        }

   
        #endregion
    }
}
