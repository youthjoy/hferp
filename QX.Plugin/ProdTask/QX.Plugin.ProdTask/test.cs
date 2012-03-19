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
namespace QX.Plugin.Prod
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();

            this.Load += new EventHandler(test_Load);
        }

        void test_Load(object sender, EventArgs e)
        {
            InitGrid();
            
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

     

        #region 工具栏初始化

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        ComboBox comboStat = new ComboBox();

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
            //ToolStripLabel tLabel3 = new ToolStripLabel();
            //tLabel3.Text = "关键字:";
            //this.tool_bar_CContract_List.AddCustomControl(4, tLabel3);

            //this.tool_bar_CContract_List.AddCustomControl(5, txtKey);

            //ToolStripHelper tsHelper = new ToolStripHelper();


            //Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();
            //List<Bse_Dict> list = dcInstance.GetListByDictKeyByNoRoot("SearchType");

            //comboStat.DataSource = list;
            //comboStat.DisplayMember = "Dict_Name";
            //comboStat.ValueMember = "Dict_Code";
            //comboStat.Tag = list;

            //ToolStripControlHost comboStatHost = new ToolStripControlHost(comboStat);
            //comboStatHost.Margin = new Padding(5, 0, 0, 0);
            //this.tool_bar_CContract_List.AddCustomControl(6, comboStatHost);


            //ToolStripButton SearchBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));
            //tool_bar_CContract_List.AddCustomControl(7, SearchBtn);

            ////tool_bar_CContract_List.RefreshClicked += new EventHandler(tool_bar_CContract_List_RefreshClicked);

            //ToolStripButton NodeViewBtn = tsHelper.New("查看工序", QX.Common.Properties.Resources.nodes, new EventHandler(NodeViewBtn_Click));
            ////NodeViewBtn.Click += new EventHandler(NodeViewBtn_Click);
            //tool_bar_CContract_List.AddCustomControl(NodeViewBtn);
        }

        private BLL.Bll_Prod_Roads prInst = new QX.BLL.Bll_Prod_Roads();

       

        #endregion

        #region 数据

        /// <summary>
        /// 结算单
        /// </summary>
        private void InitGrid()
        {
            try
            {
                
                ArrayList list = new ArrayList();
                DataTable dt = comInst.GetComDataTableByCode("", "qx_rpt_proding", list);
                ultraGrid1.DataSource = dt;
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void RfreshGrid()
        {
            //ArrayList list = new ArrayList();
            //DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);
            //uGridData.DataSource = dt;



        }


        #endregion
    }
}
