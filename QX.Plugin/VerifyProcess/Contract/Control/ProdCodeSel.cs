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
    public partial class ProdCodeSel : Form
    {
        public ProdCodeSel(SD_CDetail sd)
        {
            InitializeComponent();

            this.Load += new EventHandler(Form_load);
            CDetail = sd;
            BindEvent();
        }

        public delegate void DCallBackHandler(object sender, List<SD_CRProdCode> list);
        public event DCallBackHandler CallBack;

        public SD_CDetail CDetail
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

            this.btn_left.Click += new EventHandler(btn_left_Click);
            this.btn_right.Click += new EventHandler(btn_right_Click);
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

        /// <summary>
        /// 选中的零件编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btn_right_Click(object sender, EventArgs e)
        {
            var rows = comGrid.Selected.Rows;
            int rcount = rows.Count;
            if (rows.Count == 0)
            {
                return;
            }
            else if ((rcount+this.roadGrid.Rows.Count) > CDetail.CDetail_Num)
            {
                Alert.Show(string.Format("该图号合同细目只有{0}件，请重新选择!",CDetail.CDetail_Num));
                return;
            }


            if (rows != null)
            {
                foreach (var row in rows)
                {
                    Prod_PlanProd road = row.ListObject as Prod_PlanProd;
                    UltraGridRow newrow;

                    newrow = roadGrid.DisplayLayout.Bands[0].AddNew();

                    if (road != null)
                    {
                        var r = newrow.ListObject as SD_CRProdCode;
                        r.SDR_ProdCode = road.PlanProd_Code;
                        r.SDR_PlanCode = road.PlanProd_PlanCode;
                        r.SDR_CmdCode = road.PlanProd_CmdCode;
                        r.SDR_ContractCode = CDetail.CDetail_ContractNo;
                        r.SDR_DetailCode = CDetail.CDetail_Code;
                        r.SDR_PartNo = road.PlanProd_PartNo;
                        r.SDR_PartName = road.PlanProd_PartName;
                        if (CDetail.CDetail_Num != 0)
                        {
                            r.SDR_Price = CDetail.CDetail_Sum / CDetail.CDetail_Num;
                        }
                    }
                }

                roadGrid.DisplayLayout.Bands[0].AddNew();
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
            if (rows != null && rows.Count != 0)
            {
                foreach (var r in rows)
                {
                    r.Delete(false);
                }
            }
            else
            {
                this.roadGrid.ActiveRow.Delete(false);
            }
        }

        void tool_bar_SaveClicked(object sender, EventArgs e)
        {
            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ContractProdRelation
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Contract.ToString(), QX.Common.LogType.Edit.ToString());

            List<SD_CRProdCode> list = new List<SD_CRProdCode>();
            foreach (var r in roadGrid.Rows)
            {
                SD_CRProdCode road = r.ListObject as SD_CRProdCode;
                if (!list.Exists(o => o.SDR_ProdCode == road.SDR_ProdCode))
                {
                    if (!string.IsNullOrEmpty(road.SDR_ProdCode))
                    {
                        list.Add(road);
                    }
                }
            }

            sdInstance.AddOrUpdateSDRelation(CDetail, list);

            if (Alert.ShowIsConfirm("数据已经保存，是否需要关闭窗口!"))
            {
                this.Close();
            }
        }

        void tool_bar_AddClicked(object sender, EventArgs e)
        {

        }

        public UltraGrid comGrid = new UltraGrid();

        public UltraGrid roadGrid = new UltraGrid();

        GridHelper gen = new GridHelper();

        private Bll_SD_CDetail sdInstance = new Bll_SD_CDetail();
        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();
        public void BindData()
        {
            //left 
            comGrid = gen.GenerateGrid("RGProdPlan", this.panel1, new Point(0, 0));

            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

            //right

            roadGrid = gen.GenerateGrid("CList_ContractRelation", this.panel2, new Point(0, 0));

            List<SD_CRProdCode> list1 = new List<SD_CRProdCode>();
            list1 = sdInstance.GetCDetailRelation(CDetail.CDetail_Code);
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list1;
            roadGrid.DataSource = dataSource1;
        }



    }
}
