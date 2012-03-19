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
using QX.Shared;

namespace QX.Plugin.Contract.ComControl
{
    public partial class FinanceProdRef : Form
    {
        public FinanceProdRef(SD_CDetail d, SD_Contract c)
        {
            InitializeComponent();

            this.Load += new EventHandler(Form_load);
            CDetail = d;
            Contract = c;
            BindEvent();
        }

        public delegate void DCallBackHandler(object sender, List<Prod_PlanProd> list);
        public event DCallBackHandler CallBack;

        public SD_CDetail CDetail
        {
            get;
            set;
        }

        public SD_Contract Contract
        {
            get;
            set;
        }

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
            this.tool_bar.toolStrip1.Items["Key"].Text = CDetail.CDetail_PartNo;

            this.btn_left.Click += new EventHandler(btn_left_Click);
            //this.btn_right.Click += new EventHandler(btn_right_Click);
        }

        void tool_bar_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.tool_bar.GetSearchValue("bDate", "Date");
            string eDate = this.tool_bar.GetSearchValue("eDate", "Date");
            string key = this.tool_bar.GetSearchValue("Key", "Text");

            var list = cdInstance.GetCmdDetailForContract(bDate, eDate, key);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

        }

        /// <summary>
        /// 选中的零件编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_right_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_left_Click(object sender, EventArgs e)
        {
            var rows = this.comGrid.ActiveRow;
            if (rows != null)
            {
                Prod_CmdDetail detail = rows.ListObject as Prod_CmdDetail;
                Prod_Command cmd = cdInstance.GetCommand(detail.Cmd_Code);
                var list = rnInstance.GetRoadNodesByComponents(detail.CmdDetail_PartNo);

                var pricelist = sdInstance.GetFinanceListForPatch(Contract.Contract_CustCode, detail.CmdDetail_PartNo, cmd.Cmd_Udef2);

                foreach (var rn in list)
                {
                    UltraGridRow row = this.roadGrid.DisplayLayout.Bands[0].AddNew();
                    SD_Finance sf = row.ListObject as SD_Finance;
                    //模糊匹配价格 取最新的
                    var node=pricelist.FirstOrDefault(o => o.SDF_NodeCode == rn.RNodes_Code);
                    if (node != null)
                    {
                        sf.SDF_Value = node.SDF_Value;
                    }
                    else
                    {
                        sf.SDF_Value = 0;
                    }

                    sf.SDF_CmdCode = detail.Cmd_Code;
                    sf.SDF_ContractCode = CDetail.CDetail_ContractNo;
                    sf.SDF_ContractDetail = CDetail.CDetail_Code;
                    sf.SDF_Customer = Contract.Contract_CustCode;
                    sf.SDF_CustomerName = Contract.Contract_CustName;
                    sf.SDF_NodeCode = rn.RNodes_Code;
                    sf.SDF_NodeName = rn.RNodes_Name;
                    sf.SDF_ProdType = cmd.Cmd_Udef2;
                    sf.SDF_PartNo = detail.CmdDetail_PartNo;
                    sf.SDF_PartName = detail.CmdDetail_PartName;
                    
                }
                this.roadGrid.DisplayLayout.Bands[0].AddNew();
            }

        }

        void tool_bar_SaveClicked(object sender, EventArgs e)
        {

            if (SaveData())
            {
                Alert.Show("保存成功!");
            }
            else
            {
                Alert.Show("保存失败!");
            }

        }

        public bool SaveData()
        {

            List<SD_Finance> list = new List<SD_Finance>();

            foreach (var r in this.roadGrid.Rows)
            {
                SD_Finance road = r.ListObject as SD_Finance;

                list.Add(road);

            }

            var flag = sdInstance.AddOrUpdateFinance(CDetail, list);

            return flag;
        }


        public UltraGrid comGrid = new UltraGrid();

        public UltraGrid prodGrid = new UltraGrid();

        public UltraGrid roadGrid = new UltraGrid();

        GridHelper gen = new GridHelper();

        private Bll_SD_CDetail sdInstance = new Bll_SD_CDetail();
        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();
        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();
        private Bll_Prod_CmdDetail cdInstance = new Bll_Prod_CmdDetail();

        public void BindData()
        {
            //left 指令明细
            comGrid = gen.GenerateGrid("CList_ProdCmdDetail", this.panel1, new Point(0, 0));
            comGrid.AfterRowActivate += new EventHandler(comGrid_AfterRowActivate);
            List<Prod_CmdDetail> list = new List<Prod_CmdDetail>();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

            //right
            ///零件编号
            prodGrid = gen.GenerateGrid("CList_CodeMap", this.panel2, new Point(0, 0));

            List<Prod_CodeMap> list1 = new List<Prod_CodeMap>();

            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list1;
            prodGrid.DataSource = dataSource1;

            roadGrid = gen.GenerateGrid("CList_Finance", this.panel3, new Point(0, 0));
            List<SD_Finance> list2 = new List<SD_Finance>();

            list2 = sdInstance.GetFinanceListByContract(CDetail);
            if (list2.Count == 0)
            {
                this.Text = "未关联价格信息";
            }
            BindingSource dataSource2 = new BindingSource();
            dataSource2.DataSource = list2;
            roadGrid.DataSource = dataSource2;
        }

        void comGrid_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.comGrid.ActiveRow;
            if (row != null)
            {
                Prod_CmdDetail detail = row.ListObject as Prod_CmdDetail;
                var list1 = cdInstance.GetMapList(detail.Cmd_Code, detail.CmdDetail_PartNo);
                BindingSource dataSource1 = new BindingSource();
                dataSource1.DataSource = list1;
                prodGrid.DataSource = dataSource1;
            }
        }



    }
}
