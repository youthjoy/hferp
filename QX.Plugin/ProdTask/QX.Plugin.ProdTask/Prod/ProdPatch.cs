using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using QX.DataModel;
using QX.Framework.AutoForm;
using QX.Common.C_Class;
using QX.Common.C_Form;
using Infragistics.Win;

namespace QX.Plugin.Prod
{
    public partial class ProdPatch : F_BasicPop
    {
        public ProdPatch()
        {
            InitializeComponent();
            EventInit();
            this.Load += new EventHandler(ProdPatch_Load);
        }

        public delegate void DCallBackHandler(bool flag, string result);

        public event DCallBackHandler CallBack;

        public ProdPatch(Prod_PlanProd plan)
        {
            InitializeComponent();
            CurProd = plan;

            this.Text = CurProd.PlanProd_Code + "_" + "组合配对界面";

            EventInit();
            this.Load += new EventHandler(ProdPatch_Load);
        }


        public Prod_PlanProd CurProd
        {
            get;
            set;
        }

        #region 窗体单例

        public static ProdPatch NewForm = null;



        public static ProdPatch Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new ProdPatch();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        void ProdPatch_Load(object sender, EventArgs e)
        {
            InitData();
        }

        UltraGrid comGrid = new UltraGrid();

        private BLL.Bll_Prod_PlanProd ppInstance = new QX.BLL.Bll_Prod_PlanProd();

        private GridHelper gen = new GridHelper();

        ToolStripTextBox txtPlaned = new ToolStripTextBox();

        public void EventInit()
        {


            //ToolStripLabel tLabel3 = new ToolStripLabel();
            //tLabel3.Text = "关键字:";
            //this.top_tool.AddCustomControl(4, tLabel3);


            //this.top_tool.AddCustomControl(5, txtPlaned);

            //搜索按钮
            //ToolStripButton searchPlanedBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchPlanedBtn_Click));
            //this.top_tool.AddCustomControl(6, searchPlanedBtn);

            this.top_tool.SaveClicked += new EventHandler(top_tool_SaveClicked);

            this.top_tool.RefreshClicked += new EventHandler(top_tool_RefreshClicked);
        }

        private void AddCustomColumn()
        {

            if (!comGrid.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = comGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.EditAndSelectText;

            }
            else
            {
                comGrid.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = comGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);

                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.EditAndSelectText;
            }

        }

        void top_tool_RefreshClicked(object sender, EventArgs e)
        {
            if (Alert.ShowIsConfirm("系统将重新加载原配对信息，未保存数据将不会带入!"))
            {
                BindingSource data = new BindingSource();
                data.DataSource = CurDataSource;
                this.comGrid.DataSource = data;
            }
        }

        void top_tool_SaveClicked(object sender, EventArgs e)
        {

            if (SaveData())
            {

                Alert.Show("数据更新成功!");
                this.Close();
            }

        }



        public bool SaveData()
        {
            List<Prod_Patch> list = new List<Prod_Patch>();
            StringBuilder sb = new StringBuilder();

            if (comGrid.Rows.Count == 0)
            {
                Alert.Show("请选择要配对的零件!");
                return false;
            }

            //if (comGrid.Rows.Count == 1)
            //{
            //    var r = comGrid.Rows[0];
            //    Prod_Patch n = r.ListObject as Prod_Patch;
            //    n.Stat = 1;

            //    ppInstance.UpdatePatch(n);

            //    Prod_PlanProd p =ppInstance.GetModelByKey(n.PP_PlanCode);
            //    p.PlanProd_Patch = string.Empty;
            //    p.PlanProd_MPatchCode = string.Empty;
            //    ppInstance.UpdatePlan(p);
            //    return false;
            //}
            int i = 0;
            foreach (var r in this.comGrid.Rows)
            {
                Prod_Patch p = r.ListObject as Prod_Patch;

                if (list.FirstOrDefault(o => o.PP_PlanCode == p.PP_PlanCode) != null)
                {
                    sb.Append(p.PP_ProdCode).Append(",");
                    continue;
                }

                i++;

                list.Add(p);
            }

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                Alert.Show(string.Format("以下零件编号存在重复({0}),请确认后重新输入!", sb.ToString().TrimEnd(',')));
                return false;
            }

            if (list.FirstOrDefault(o => o.PP_Type == "PatchType002") == null)
            {
                Alert.Show("请确定一个零件为主组件编号");
                return false;
            }

            ppInstance.AddOrUpdateProdPath(CurModule, list);
            return true;
        }

        List<Prod_PlanProd> Source = new List<Prod_PlanProd>();

        List<Prod_PlanProd> DataSource = new List<Prod_PlanProd>();

        public string CurModule
        {
            get;
            set;
        }

        List<Prod_Patch> CurDataSource
        {
            get;
            set;
        }

        public void InitData()
        {
            List<Prod_Patch> list = new List<Prod_Patch>();

            comGrid = gen.GenerateGrid("CList_ProdPatch", this.panel1, new Point(0, 0));

            //comGrid.BeforeRowsDeleted+=new BeforeRowsDeletedEventHandler(comGrid_BeforeRowsDeleted);

            list = ppInstance.GetPlanProdListForPatch(CurProd.PlanProd_PlanCode);
            List<Prod_Patch> list1 = new List<Prod_Patch>();
            if (list.Count != 0)
            {
                list1 = ppInstance.GetPlanProdListForPatchByModule(list[0].PP_Module);

                CurModule = list[0].PP_Module;

                BindingSource DataSource = new BindingSource();
                DataSource.DataSource = list1;
                comGrid.DataSource = DataSource;
            }
            else
            {


                CurModule = ppInstance.GenerateProdPatchCode();

                Prod_Patch temp = new Prod_Patch();

                temp.PP_PlanCode = CurProd.PlanProd_PlanCode;
                temp.PP_ProdCode = CurProd.PlanProd_Code;
                temp.PP_Module = CurModule;
                temp.PP_PartName = CurProd.PlanProd_PartName;
                temp.PP_PartNo = CurProd.PlanProd_PartNo;
                list1.Add(temp);

                BindingSource DataSource = new BindingSource();
                DataSource.DataSource = list1;
                comGrid.DataSource = DataSource;
            }

            CurDataSource = list1.ToList();

        }

        //void comGrid_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        //{
        //    foreach (var r in e.Rows)
        //    { 

        //    }
        //}




    }
}
