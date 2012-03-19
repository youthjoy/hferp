using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using QX.Common.C_Class;

namespace QX.Plugin.Report
{
    public partial class CommOnTrash : Form
    {
        public string[] MapData
        {
            get;
            set;
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

        public CommOnTrash(string data)
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
            ModuleCode = MapData[0];
            this.Text = MapData[2];
            BindEvent();
            this.Load += new EventHandler(CommTrashList_Load);
        }

        void CommTrashList_Load(object sender, EventArgs e)
        {
            InitData();
        }

        public void BindEvent()
        {
            this.tool_bar_CContract_List.SearchClicked += new EventHandler(tool_bar_CContract_List_SearchClicked);
            this.tool_bar_CContract_List.AddSearchAllModule();
        }

        BLL.Bll_Comm comInst = new QX.BLL.Bll_Comm();

        void tool_bar_CContract_List_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.tool_bar_CContract_List.GetSearchValue("bDate", "Date");
            string eDate = this.tool_bar_CContract_List.GetSearchValue("eDate", "Date");
            string key = this.tool_bar_CContract_List.GetSearchValue("Key", "Text");

            //DateTime beginDate = this.bDate.Value;
            //DateTime endDate = this.eDate.Value;
            //string key = this.txtKey.Text;
            //string type = this.comboStat.SelectedValue.ToString();

            string where = string.Empty;

            ArrayList list = new ArrayList();

            list.Add(bDate);
            list.Add(eDate);
            list.Add(key);
            list.Add("");
            list.Add("");
            list.Add("");
            DataTable dt = comInst.GetComDataTableByCode(ModuleCode, DataCode, list);



            //DataTable newdt = new DataTable();
            //newdt = dt.Clone();
            uGridData.DataSource = dt;

        }

        UltraGrid uGridData = new UltraGrid();

        private BLL.Bll_Prod_PlanProd ppInstance = new QX.BLL.Bll_Prod_PlanProd();

        private GridHelper gen = new GridHelper();

        public void InitData()
        {
            uGridData = gen.GenerateGrid("RGProdPlan", this.panel1, new Point(0, 0));
            gen.SetGridReadOnly(uGridData, true);

          
        }
    }
}
