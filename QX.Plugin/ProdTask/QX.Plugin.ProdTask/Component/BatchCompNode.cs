using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Class;
using QX.DataModel;
using QX.BLL;
using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;
using QX.Shared;

namespace QX.Plugin.RoadCateManage
{
    public partial class BatchCompNode : Form
    {
        Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private List<Road_Nodes> CurrentDataSource
        {
            get;
            set;
        }

        public BatchCompNode()
        {
            InitializeComponent();

            BindEvent();

            this.Load += new EventHandler(BatchCompNode_Load);

        }

        void BatchCompNode_Load(object sender, EventArgs e)
        {
            InitData();
        }

        UltraGrid comGrid = new UltraGrid();
        GridHelper gen = new GridHelper();
        ToolStripTextBox compTxt = new ToolStripTextBox();
        ToolStripTextBox nodeTxt = new ToolStripTextBox();
        public void BindEvent()
        {

            ToolStripHelper tsHelper = new ToolStripHelper();
          
            ToolStripLabel complbl = new ToolStripLabel();
            complbl.Text = "零件图号:";
            this.commonToolBar1.AddCustomControl(complbl);
            this.commonToolBar1.AddCustomControl(compTxt);

            ToolStripLabel nodelbl = new ToolStripLabel();
            nodelbl.Text = "工序:";
            this.commonToolBar1.AddCustomControl(nodelbl);
            this.commonToolBar1.AddCustomControl(nodeTxt);

            ToolStripButton searchBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchBtn_Click));
            this.commonToolBar1.AddCustomControl(searchBtn);

            ToolStripButton batchUpdate = tsHelper.New("批量更新", QX.Common.Properties.Resources.batch, new EventHandler(batchUpdate_Click));
            this.commonToolBar1.AddCustomControl(batchUpdate);

            this.commonToolBar1.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);
        }

        void batchUpdate_Click(object sender, EventArgs e)
        {
            var rows = this.comGrid.Selected.Rows;
            var arow = this.comGrid.ActiveRow;
            var refNode = arow.ListObject as Road_Nodes;
            foreach (var r in rows)
            {
                Road_Nodes rn = r.ListObject as Road_Nodes;
                r.Cells["RNodes_Value"].Value = refNode.RNodes_Value;
                rn.RNodes_Value = refNode.RNodes_Value;
                r.Cells["RNodes_Cost"].Value = rn.RNodes_TimeCost*rn.RNodes_Value;
            }
        }

        void commonToolBar1_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Alert.Show("更新完成");
            }
        }

        void searchBtn_Click(object sender, EventArgs e)
        {
            string comp = this.compTxt.Text;
            string node = this.nodeTxt.Text;
            CurrentDataSource= rnInstance.GetNodeListForBatchPrice(comp, node);
            this.comGrid.DataSource = CurrentDataSource;
        }

        public void InitData()
        {
            comGrid = gen.GenerateGrid("GNodes_Batch", this.panel1, new Point(0, 0));
            List<Road_Nodes> list = new List<Road_Nodes>();
            comGrid.DataSource = list;

            gen.SetExcelStyleFilter(comGrid);

            comGrid.AfterRowUpdate += new RowEventHandler(comGrid_AfterRowUpdate);
        }

        void comGrid_AfterRowUpdate(object sender, RowEventArgs e)
        {
            var r= e.Row.ListObject as Road_Nodes;
            e.Row.Cells["RNodes_Cost"].Value = r.RNodes_Value*r.RNodes_TimeCost;
        }

        void comGrid_AfterExitEditMode(object sender, EventArgs e)
        {
            
        }

        public void BindData()
        { 
            
        }

        public bool SaveData()
        {

            return rnInstance.BatchUpdateNodes(CurrentDataSource);
        }
    }
}
