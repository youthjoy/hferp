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
using QX.DataModel;

namespace QX.Plugin.Prod.FHelper
{
    public partial class FHelperSupSel : Form
    {
        public FHelperSupSel()
        {
            InitializeComponent();
         

            InitGrid();
            RefreshGrid();
            InitToolBar();
        }



        UltraGrid uGridData = new UltraGrid();

        GridHelper gridHelper = new GridHelper();

        BLL.Bll_FHelper_Price ptInstance = new QX.BLL.Bll_FHelper_Price();

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

        public FHelperSupSel(string data)
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

        public delegate void DCallBackHandler(bool result,FHelper_Price model);
        public event DCallBackHandler CallBack;

        public void InitToolBar()
        {

            ////时间控件
            //ToolStripLabel tLabel = new ToolStripLabel();
            //tLabel.Text = "开始时间:";
            //this.tool_bar_CContract_List.AddCustomControl(0, tLabel);

            //this.tool_bar_CContract_List.AddCDTPtoToolstrip(1, bDate);
            //bDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));
            //ToolStripLabel tLabel2 = new ToolStripLabel();
            //tLabel2.Text = "结束时间:";
            //this.tool_bar_CContract_List.AddCustomControl(2, tLabel2);


            //this.tool_bar_CContract_List.AddCDTPtoToolstrip(3, eDate);
            //eDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));


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
            string key = this.txtKey.Text;
            var list = ptInstance.GetFHelperPrice(string.Format(" and ( FP_ManuName like '%{0}%' OR FP_CompCode like '%{0}%' OR FP_NodeName like '%{0}%')", key));

            uGridData.DataSource = list;
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
                this.Text = "外协厂商选择";
                uGridData = gridHelper.GenerateGrid("CList_FHelper_Price_Sel", this.panel1, new Point(0, 0));
                gridHelper.SetExcelStyleFilter(uGridData);
                uGridData.DoubleClickRow += new DoubleClickRowEventHandler(uGridData_DoubleClickRow);
                gridHelper.SetGridReadOnly(uGridData, true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void uGridData_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            FHelper_Price price = e.Row.ListObject as FHelper_Price;
            if (CallBack != null)
            {
                CallBack(true, price);
                this.Close();
            }
        }



        private void RefreshGrid()
        {
            var list = ptInstance.GetFHelperPrice(string.Empty);

            uGridData.DataSource = list;
        }


        #endregion

    }
}
