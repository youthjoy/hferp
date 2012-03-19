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

namespace QX.Plugin.Prod.ComControl
{
    public partial class ComInfoSel : Form
    {
        public ComInfoSel(string type)
        {
            InitializeComponent();
    
            this.Load += new EventHandler(Form_load);
            BindEvent();
        }

        public string PartNo
        {
            get;
            set;
        }

        public delegate void DCallBackHandler(object sender, List<Bse_Equ> list);
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
           
        }

        private Bll_Bse_Equ equInstance = new Bll_Bse_Equ();

        void tool_bar_SearchClicked(object sender, EventArgs e)
        {
            string bDate=this.tool_bar.GetSearchValue("bDate", "Date");
            string eDate = this.tool_bar.GetSearchValue("eDate", "Date");
            string key = this.tool_bar.GetSearchValue("Key", "Text");

            var list = equInstance.GetListForPage(bDate,eDate,key);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

        }

        void tool_bar_SaveClicked(object sender, EventArgs e)
        {
            List<Bse_Equ> list = new List<Bse_Equ>();
            foreach (var r in this.comGrid.Rows)
            {
                Bse_Equ road = r.ListObject as Bse_Equ;
                list.Add(road);
            }

            if (CallBack != null)
            {
                CallBack(true, list);
                this.Close();
            }
        }

       
        public UltraGrid comGrid = new UltraGrid();


        GridHelper gen = new GridHelper();
        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();
        private BLL.Bll_FHelper_Price ppInstance = new Bll_FHelper_Price();
        public void BindData()
        {
           //left 
            comGrid = gen.GenerateGrid("CList_FSupSel", this.panel1, new Point(0, 0));

            List<FHelper_Price> list = new List<FHelper_Price>();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

            
        }

    }
}
