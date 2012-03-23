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
        private List<Road_Nodes> UpdateDataSource
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
            ultraOptionSetBatch.CheckedIndex = 0;
        }

        UltraGrid comGrid = new UltraGrid();
        GridHelper gen = new GridHelper();
        //ToolStripTextBox compTxt = new ToolStripTextBox();
        //ToolStripTextBox nodeTxt = new ToolStripTextBox();
        public void BindEvent()
        {

            ToolStripHelper tsHelper = new ToolStripHelper();
          
            //ToolStripLabel complbl = new ToolStripLabel();
            //complbl.Text = "零件图号:";
            //this.commonToolBar1.AddCustomControl(complbl);
            //this.commonToolBar1.AddCustomControl(compTxt);

            //ToolStripLabel nodelbl = new ToolStripLabel();
            //nodelbl.Text = "工序:";
            //this.commonToolBar1.AddCustomControl(nodelbl);
            //this.commonToolBar1.AddCustomControl(nodeTxt);

            ToolStripButton searchBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchBtn_Click));
            this.commonToolBar1.AddCustomControl(searchBtn);

            ToolStripButton selectAllBtn = tsHelper.New("全选", QX.Common.Properties.Resources.batch, new EventHandler(selectAllBtn_Click));
            this.commonToolBar1.AddCustomControl(selectAllBtn);

            ToolStripButton selectOpsideBtn = tsHelper.New("反选", QX.Common.Properties.Resources.batch, new EventHandler(selectOpsideBtn_Click));
            this.commonToolBar1.AddCustomControl(selectOpsideBtn);

            ToolStripButton batchUpdate = tsHelper.New("批量更新", QX.Common.Properties.Resources.edit, new EventHandler(batchUpdate_Click));
            this.commonToolBar1.AddCustomControl(batchUpdate);

            this.commonToolBar1.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);
        }

        void batchUpdate_Click(object sender, EventArgs e)
        {
            if (ultraOptionSetBatch.CheckedItem == null)
            {
                MessageBox.Show("请选择更新方式");
                return;
            }
            var rows = this.comGrid.Selected.Rows;
            if (rows.Count < 1)
            {
                MessageBox.Show("请选择需要更改价格的工艺节点！！可多选");
                return;
            }
            foreach (var r in rows)
            {
                Road_Nodes rn = r.ListObject as Road_Nodes;
                if (ultraOptionSetBatch.CheckedIndex == 0)
                {
                    r.Cells["RNodes_Value"].Value = ultraNumericEditorDirectPrice.Value;
                    rn.RNodes_Value = decimal.Parse(ultraNumericEditorDirectPrice.Value.ToString());
                }
                else
                {
                    r.Cells["RNodes_Value"].Value = double.Parse(r.Cells["RNodes_Value"].Value.ToString()) * (1 + double.Parse(ultraNumericEditorPercent.Value.ToString()) / 100.00);
                    rn.RNodes_Value = decimal.Parse(r.Cells["RNodes_Value"].Value.ToString());
                }
                
                r.Cells["RNodes_Cost"].Value = rn.RNodes_TimeCost*rn.RNodes_Value;
                r.Cells["UpdateFlag"].Value = "true";
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
            //string comp = this.compTxt.Text;
            //string node = this.nodeTxt.Text;
            //CurrentDataSource= rnInstance.GetNodeListForBatchPrice(comp, node);
            if (!ultraCheckEditorCon1.Checked && !ultraCheckEditorCon2.Checked && !ultraCheckEditorCon3.Checked && !ultraCheckEditorCon4.Checked)
            {
                MessageBox.Show("请指定搜索条件！");
                return;
            }
            string sCondition = " (1 <> 1 )";
            if (ultraCheckEditorCon1.Checked == true)
            {
                if (ultraNumericEditorPriceLow1.Value == null || ultraNumericEditorPriceHigh1.Value == null)
                {
                    MessageBox.Show("请输入条件一的价格区间");
                    return;
                }
                sCondition = sCondition + " or (RNodes_PartCode like '%" 
                    + ultraFormattedTextEditorComp1.Text.Trim() + "%' and RNodes_Name like '%" 
                    + ultraFormattedTextEditorNode1.Text.Trim() + "%' and RNodes_Value between " 
                    + ultraNumericEditorPriceLow1.Value.ToString() + " and " 
                    + ultraNumericEditorPriceHigh1.Value.ToString()+ ")";
            }
            if (ultraCheckEditorCon2.Checked == true)
            {
                if (ultraNumericEditorPriceLow2.Value == null || ultraNumericEditorPriceHigh2.Value == null)
                {
                    MessageBox.Show("请输入条件一的价格区间");
                    return;
                }
                sCondition = sCondition + " or (RNodes_PartCode like '%"
                    + ultraFormattedTextEditorComp2.Text.Trim() + "%' and RNodes_Name like '%"
                    + ultraFormattedTextEditorNode2.Text.Trim() + "%' and RNodes_Value between "
                    + ultraNumericEditorPriceLow2.Value.ToString() + " and "
                    + ultraNumericEditorPriceHigh2.Value.ToString() + ")";
            }
            if (ultraCheckEditorCon3.Checked == true)
            {
                if (ultraNumericEditorPriceLow3.Value == null || ultraNumericEditorPriceHigh3.Value == null)
                {
                    MessageBox.Show("请输入条件一的价格区间");
                    return;
                }
                sCondition = sCondition + " or (RNodes_PartCode like '%"
                    + ultraFormattedTextEditorComp3.Text.Trim() + "%' and RNodes_Name like '%"
                    + ultraFormattedTextEditorNode3.Text.Trim() + "%' and RNodes_Value between "
                    + ultraNumericEditorPriceLow3.Value.ToString() + " and "
                    + ultraNumericEditorPriceHigh3.Value.ToString() + ")";
            }
            if (ultraCheckEditorCon4.Checked == true)
            {
                if (ultraNumericEditorPriceLow4.Value == null || ultraNumericEditorPriceHigh4.Value == null)
                {
                    MessageBox.Show("请输入条件一的价格区间");
                    return;
                }
                sCondition = sCondition + " or (RNodes_PartCode like '%"
                    + ultraFormattedTextEditorComp4.Text.Trim() + "%' and RNodes_Name like '%"
                    + ultraFormattedTextEditorNode4.Text.Trim() + "%' and RNodes_Value between "
                    + ultraNumericEditorPriceLow4.Value.ToString() + " and "
                    + ultraNumericEditorPriceHigh4.Value.ToString() + ")";
            }
            CurrentDataSource = rnInstance.GetNodeListByWhere(" and (" + sCondition + ")");
            this.comGrid.DataSource = CurrentDataSource;
            if (!this.comGrid.DisplayLayout.Bands[0].Columns.Exists("UpdateFlag"))
            {
                this.comGrid.DisplayLayout.Bands[0].Columns.Add("UpdateFlag");
                this.comGrid.DisplayLayout.Bands[0].Columns["UpdateFlag"].Hidden = true;
            }
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
            e.Row.Cells["RNodes_Cost"].Value = r.RNodes_Value * r.RNodes_TimeCost;
            e.Row.Cells["UpdateFlag"].Value = "true";
        }

        void comGrid_AfterExitEditMode(object sender, EventArgs e)
        {
            
        }

        public void BindData()
        { 
            
        }

        public bool SaveData()
        {
            UpdateDataSource = null;
            UpdateDataSource = new List<Road_Nodes>();
            foreach (UltraGridRow aRow in this.comGrid.Rows)
            {
                if (aRow.Cells["UpdateFlag"].Value == null)
                    continue;
                if (aRow.Cells["UpdateFlag"].Value.ToString() == "true")
                {
                    Road_Nodes rn = aRow.ListObject as Road_Nodes;
                    UpdateDataSource.Add(rn);
                }
            }
            return rnInstance.BatchUpdateNodes(UpdateDataSource);
        }
        void selectAllBtn_Click(object sender, EventArgs e)
        {
            foreach (UltraGridRow aRow in comGrid.Rows)
            {
                aRow.Selected = true;
            }
        }

        void selectOpsideBtn_Click(object sender, EventArgs e)
        {
            foreach (UltraGridRow aRow in comGrid.Rows)
            {
                aRow.Selected = !aRow.Selected;
            }
        }
    }
}
