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
using QX.Plugin.Prod.Report;
using QX.Shared;

namespace QX.Plugin.Prod
{
    public partial class CommInfoHandle : Form
    {
        public CommInfoHandle()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form_load);

            BindEvent();
        }

        public delegate void DCallBackHandler(object sender, List<Prod_Roads> list);
        public event DCallBackHandler CallBack;

        void Form_load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindEvent()
        {
            //this.tool_bar.AddClicked += new EventHandler(tool_bar_AddClicked);
            this.tool_bar.SaveClicked += new EventHandler(tool_bar_SaveClicked);
            this.tool_bar.SearchClicked += new EventHandler(tool_bar_SearchClicked);
            this.tool_bar.AddSearchAllModule();

            this.btn_left.Click += new EventHandler(btn_left_Click);
            this.btn_right.Click += new EventHandler(btn_right_Click);

        }

        void tool_bar_SearchClicked(object sender, EventArgs e)
        {
            string bDate=this.tool_bar.GetSearchValue("bDate", "Date");
            string eDate = this.tool_bar.GetSearchValue("eDate", "Date");
            string key = this.tool_bar.GetSearchValue("Key", "Text");

            var list = prInstance.GetProdNodeList(bDate, eDate, key);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

        }

        void btn_right_Click(object sender, EventArgs e)
        {
            var rows = comGrid.Selected.Rows;
            if (rows != null)
            {
                foreach (var row in rows)
                {
                    Prod_Roads road = row.ListObject as Prod_Roads;
                    var newrow = roadGrid.DisplayLayout.Bands[0].AddNew();

                    if (road != null)
                    {
                        PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(Prod_Roads));

                        foreach (UltraGridCell cell in newrow.Cells)
                        {
                            if (cell.Column.IsBound)
                            {
                                object value = pc[cell.Column.Key].GetValue(road);
                                if (value != null)
                                {
                                    newrow.Cells[cell.Column.Key].Value = value;
                                }
                            }
                        }

             
                    }
                }
            }
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_left_Click(object sender, EventArgs e)
        {
            var rows = this.roadGrid.Selected.Rows;
            if (rows != null)
            {
                foreach (var r in rows)
                {
                    r.Delete(false);
                }
            }
        }

        void tool_bar_SaveClicked(object sender, EventArgs e)
        {
            List<Prod_Roads> list = new List<Prod_Roads>();
            foreach (var r in roadGrid.Rows)
            {
                Prod_Roads road = r.ListObject as Prod_Roads;
                if (!list.Exists(o => o.PRoad_PlanCode == road.PRoad_PlanCode && o.PRoad_NodeCode == road.PRoad_NodeCode))
                {
                    list.Add(road);
                }
            }

            if (CallBack != null)
            {
                CallBack(true, list);
                this.Close();
            }
        }

        void tool_bar_AddClicked(object sender, EventArgs e)
        {
            
        }
        public UltraGrid comGrid = new UltraGrid();

        public UltraGrid roadGrid = new UltraGrid();

        GridHelper gen = new GridHelper();
        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        public void BindData()
        {
           //left 
            comGrid = gen.GenerateGrid("CList_BatchProdInfo", this.panel1, new Point(0, 0));
            gen.SetExcelStyleFilter(comGrid);
            List<Prod_Roads> list = new List<Prod_Roads>();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

            //right

            roadGrid = gen.GenerateGrid("CList_RoadNode", this.panel2, new Point(0, 0));

            List<Prod_Roads> list1 = new List<Prod_Roads>();
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list1;
            roadGrid.DataSource = dataSource1;
        }

        private void btn_right_Click_1(object sender, EventArgs e)
        {

        }

     
    }
}
