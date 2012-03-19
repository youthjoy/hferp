using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using QX.BLL;
namespace QX.Plugin.Prod
{
    public partial class TestRefList : F_BasicPop
    {
        public TestRefList()
        {
            InitializeComponent();
        }

        private Bll_TestRef instance = new QX.BLL.Bll_TestRef();
        UltraGrid ug_listA = new UltraGrid();
        UltraGrid ug_listB = new UltraGrid();

        public OperationTypeEnum.OperationType OpType
        {
            get;
            set;
        }

        public TestRefList(string prodCode,OperationTypeEnum.OperationType Op)
        {
            InitializeComponent();

            OpType = Op;
            ProdCode = prodCode;
            this.Load += new EventHandler(ProductMain_Load);
            BindTopTool();

        }

        public string ProdCode
        {
            get;
            set;
        }

        void ProductMain_Load(object sender, EventArgs e)
        {
            GridHelper grid = new GridHelper();
            ug_listA = grid.GenerateGrid("GLTestRef", panel2, new Point(6, 20));
            grid.SetGridReadOnly(ug_listA, true);
            grid.SetGridColumnStyle(ug_listA, AutoFitStyle.ExtendLastColumn);


            LoadGrid1();
            LoadGrid2();
        }

        #region 绑定工具栏及事件

        ToolStripTextBox txtKey = new ToolStripTextBox();
           //搜索按钮
        ToolStripButton ConfirmBtn;

        public void BindTopTool()
        {
            switch (OpType)
            {
                case OperationTypeEnum.OperationType.Look:

                    break;

                case OperationTypeEnum.OperationType.Edit:
                    //搜索按钮
                    ConfirmBtn = new ToolStripHelper().New("确认", QX.Common.Properties.Resources.OK, new EventHandler(ConfirmBtn_Click));
                    this.top_tool_0.AddCustomControl(7, ConfirmBtn);
                    //ConfirmBtn.Click += new EventHandler(ConfirmBtn_Click);
                    break;
            }


            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.top_tool_0.AddCustomControl(4, tLabel3);


            this.top_tool_0.AddCustomControl(5, txtKey);

            //搜索按钮
            ToolStripButton searchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchBtn_Click));
            this.top_tool_0.AddCustomControl(6, searchBtn);
        }


        void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (this.ug_listA.Rows.Count != 0)
            {
                DialogResult re = Alert.Show(MessageBoxButtons.OKCancel, "终检确认合格?");
                if (re == DialogResult.OK)
                {
                    instance.ConfirmTest(ProdCode);

                    ConfirmBtn.Enabled = false;
                }
            }
        }

        void searchBtn_Click(object sender, EventArgs e)
        {
            string key = this.txtKey.Text;

            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                FilterData();
            }
            else
            {
                LoadGrid1();
            }
        }

        /// <summary>
        /// 过滤数据
        /// </summary>
        public void FilterData()
        {

            string key = this.txtKey.Text;

            Predicate<Prod_TestRef> math = delegate(Prod_TestRef p) { return (p.PTestRef_NodeName.ToUpper().Contains(key.ToUpper()) || (p.PTestRef_NodeCode.ToUpper().Contains(key.ToUpper()) || (p.PTestRef_TestNode.ToUpper().Contains(key.ToUpper()) || (p.PTestRef_TestName.ToUpper().Contains(key.ToUpper()))))); };

            List<Prod_TestRef> filterData = CollectionHelper.Filter<Prod_TestRef>(CurDataSource, math);

            this.RefreshGrid(filterData);
        }

        #endregion

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void LoadGrid2()
        {
            //GridHelper grid = new GridHelper();
            //List<Prod_Command> list = new List<Prod_Command>();
            //list = instance.GetAll();
            //ug_listB.DataSource = list;
        }

        List<Prod_TestRef> CurDataSource = new List<Prod_TestRef>();

        private void LoadGrid1()
        {
            List<Prod_TestRef> list = new List<Prod_TestRef>();
            list = instance.GetTestRefList(ProdCode);
            CurDataSource = list;
            ug_listA.DataSource = list;
        }

        private void RefreshGrid(List<Prod_TestRef> list)
        {
            ug_listA.DataSource = list;
        }
    }
}
