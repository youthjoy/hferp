﻿using System;
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

namespace QX.Plugin.Prod.ComControl
{
    public partial class ProdCodeSel : Form
    {
        public ProdCodeSel()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form_load);

            BindEvent();
        }

        public delegate void DCallBackHandler(object sender, List<Prod_PlanProd> list);
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

            ToolStripButton rawBtn = new ToolStripHelper().New("毛坯", QX.Common.Properties.Resources.stockin, new EventHandler(rawBtn_Click));

            this.tool_bar.AddCustomControl(rawBtn);
        }

        void rawBtn_Click(object sender, EventArgs e)
        {
            if (CallBack != null)
            {
                var row=this.comGrid.ActiveRow;
                if (row != null)
                  {
                      Prod_PlanProd p = row.ListObject as Prod_PlanProd;
                      p.PlanProd_Code = "毛坯入库";
                      CallBack("raw", new List<Prod_PlanProd>() { p });
                      this.Close();
                }
            }

        }


        void tool_bar_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.tool_bar.GetSearchValue("bDate", "Date");
            string eDate = this.tool_bar.GetSearchValue("eDate", "Date");
            string key = this.tool_bar.GetSearchValue("Key", "Text");

            var list = ppInstance.GetPlanList(bDate, eDate, key);
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
                    Prod_PlanProd road = row.ListObject as Prod_PlanProd;
                    var newrow = roadGrid.DisplayLayout.Bands[0].AddNew();

                    if (road != null)
                    {
                        PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(Prod_PlanProd));

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
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            foreach (var r in roadGrid.Rows)
            {
                Prod_PlanProd road = r.ListObject as Prod_PlanProd;
                if (!list.Exists(o => o.PlanProd_PlanCode == road.PlanProd_PlanCode))
                {
                    list.Add(road);
                }
            }

            if (CallBack != null)
            {
                CallBack(null, list);
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
        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();
        public void BindData()
        {
            //left 
            comGrid = gen.GenerateGrid("CList_FProdCode", this.panel1, new Point(0, 0));

            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

            //right

            roadGrid = gen.GenerateGrid("CList_FProdCode", this.panel2, new Point(0, 0));

            List<Prod_PlanProd> list1 = new List<Prod_PlanProd>();
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list1;
            roadGrid.DataSource = dataSource1;
        }



    }
}
