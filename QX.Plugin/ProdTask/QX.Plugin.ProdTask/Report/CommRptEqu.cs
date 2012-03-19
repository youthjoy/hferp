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
namespace QX.Plugin.Report
{
    public partial class CommRptEqu : F_BasciForm
    {
        public CommRptEqu()
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

        public CommRptEqu(string data)
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
            RefreshGrid();
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

        }

        void tool_bar_CContract_List_RefreshClicked(object sender, EventArgs e)
        {
            RefreshGrid();
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
            DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);

            DataTable newdt = new DataTable();
            newdt = dt.Clone();
            DataRow[] dr = dt.Select(string.Format(" Failure_EquSpec like '%{0}%' or Failure_EquCode like '%{0}%' or Failure_EquName like '%{0}%'", key));
            for (int i = 0; i < dr.Length; i++)
            {
                newdt.ImportRow((DataRow)dr[i]);
            }
            uGridData.DataSource = newdt;


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
                uGridData = gridHelper.GenerateGrid(MapData[0], this.panel1, new Point(0, 0));

                gridHelper.SetGridReadOnly(uGridData, true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void RefreshGrid()
        {
            ArrayList list = new ArrayList();
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            string key = this.txtKey.Text;

            string where = string.Empty;

            list.Add(beginDate);
            list.Add(endDate);
            list.Add("");
            list.Add("");
            list.Add("");
            list.Add("");

            DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);
            uGridData.DataSource = dt;
        }


        #endregion

    }
}
