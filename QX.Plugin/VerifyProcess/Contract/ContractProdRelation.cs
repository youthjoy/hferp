using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using QX.BLL;
using QX.DataModel;
using QX.Common.C_Class;

namespace QX.Plugin.Contract
{
    public partial class ContractProdRelation : Form
    {
        public ContractProdRelation()
        {
            InitializeComponent();
            BindEvent();
            this.Load += new EventHandler(ContractProdRelation_Load);
        }

        void ContractProdRelation_Load(object sender, EventArgs e)
        {
            InitData();

            BindData();
        }

        ToolStripTextBox txtPlanKey = new ToolStripTextBox();

        public void BindEvent()
        { 
           //任务列表
            this.tbTask.SearchClicked += new EventHandler(tbTask_SearchClicked);
            this.tbTask.AddSearchAllModule();
            

            //零件列表


            //工序列表
            ToolStripLabel tLabel4 = new ToolStripLabel();
            tLabel4.Text = "关键字:";
            tbPlan.AddCustomControl(4, tLabel4);
            txtPlanKey.KeyDown += new KeyEventHandler(txtPlanKey_KeyDown);
            tbPlan.AddCustomControl(5, txtPlanKey);

            //搜索按钮
            ToolStripButton searchPlanFBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchPlanFBtn_Click));

            tbPlan.AddCustomControl(6, searchPlanFBtn);


        }

        //计划搜索
        void txtPlanKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPlanFBtn_Click(null, null);
            }
        }

        void searchPlanFBtn_Click(object sender, EventArgs e)
        {
            string key = txtPlanKey.Text;
            if (string.IsNullOrEmpty(key))
            {
                return;
            }
           
            var list = ppInstance.GetPlanProdListForContract(string.Format("AND PlanProd_Code like '%{0}%'",key));
            this.planGrid.DataSource = list;

        }

        void tbTask_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.tbTask.GetSearchValue("bDate", "Date");
            string eDate = this.tbTask.GetSearchValue("eDate", "Date");
            string key = this.tbTask.GetSearchValue("Key", "Text");

            //string where = string.Format(" AND Task_Date between '{0}' and '{1}' AND (TaskDetail_CmdCode like '%{2}%' OR TaskDetail_PartNo like '%{2}%' )",bDate,eDate,key);
            //任务列表
            List<Prod_Task> list = ptInstance.GetProdTaskWithContract(bDate,eDate,key);
           
            taskGrid.DataSource = list;
            if (list.Count == 0)
            {
                PlanGridBind(null);
            }

        }

        UltraGrid taskGrid = new UltraGrid();
        UltraGrid planGrid = new UltraGrid();
        UltraGrid roadGrid = new UltraGrid();
        GridHelper gHelper = new GridHelper();
        private Bll_ProdTask ptInstance = new QX.BLL.Bll_ProdTask();
        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();
        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        public void InitData()
        {
            //任务列表
            List<Prod_Task> list = new List<Prod_Task>();
            taskGrid = gHelper.GenerateGrid("CList_CProdTask", this.panel1, new Point(0, 0));
            taskGrid.DataSource = list;
            gHelper.SetGridReadOnly(taskGrid, true);
            taskGrid.AfterRowActivate += new EventHandler(taskGrid_AfterRowActivate);
            gHelper.SetExcelStyleFilter(taskGrid);

            //零件列表
            List<Prod_PlanProd> list1 = new List<Prod_PlanProd>();
            planGrid = gHelper.GenerateGrid("RGProdPlan", this.panel3, new Point(0, 0));
            planGrid.DataSource = list1;
            planGrid.AfterRowActivate += new EventHandler(planGrid_AfterRowActivate);
            gHelper.SetGridReadOnly(planGrid, true);
            //工序列表
            List<Prod_Roads> list2 = new List<Prod_Roads>();
            roadGrid = gHelper.GenerateGrid("GRProdRoads", this.panel4, new Point(0, 0));
            roadGrid.DataSource = list2;
            gHelper.SetGridReadOnly(roadGrid, true);
        }


        public void BindData()
        {  //任务列表
            tbTask_SearchClicked(null, null);
        }

        void planGrid_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.planGrid.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                RoadGridBind(plan.PlanProd_PlanCode);

                //任务列表  事件关闭
                UltraGridRow taskRow = this.taskGrid.ActiveRow;
                if (taskRow == null)
                {
                    return;
                }
                
                Prod_Task task = taskRow.ListObject as Prod_Task;
                if (task.Task_Code != plan.PlanProd_TaskCode)
                {
                    this.taskGrid.EventManager.SetEnabled(EventGroups.AfterEvents, false);

                    foreach (var trow in taskGrid.Rows)
                    {
                        Prod_Task temp = trow.ListObject as Prod_Task;
                        if (temp.Task_Code == plan.PlanProd_TaskCode)
                        {
                            trow.Activate();
                            trow.Selected = true;
                            break;
                        }
                    }

                    this.taskGrid.EventManager.SetEnabled(EventGroups.AfterEvents, true);
                }

            } 
        }

        void taskGrid_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.taskGrid.ActiveRow;
            if (row != null)
            {
                Prod_Task task = row.ListObject as Prod_Task;
                PlanGridBind(task.Task_Code);
            }
        }

        public void PlanGridBind(string taskCode)
        {
            List<Prod_PlanProd> list1 = new List<Prod_PlanProd>();
            if (!string.IsNullOrEmpty(taskCode))
            {

                list1 = ppInstance.GetPlanProdListForContract(string.Format("AND PlanProd_TaskCode ='{0}'",taskCode));

                planGrid.DataSource = list1;
            }
            else
            {
                planGrid.DataSource = list1;
            }
        }


        public void RoadGridBind(string plan)
        {
            if (!string.IsNullOrEmpty(plan))
            {
                List<Prod_Roads> list1 = new List<Prod_Roads>();
                list1 = prInstance.GetPlanRoadListByPlanCode(plan);
                roadGrid.DataSource = list1;
            }
            else
            {
                roadGrid.DataSource = new List<Prod_Roads>();
            }
        }
    }
}
