using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;
using QX.Plugin.Prod.Report;
using QX.Plugin.RoadCateManage;

namespace QX.Plugin.Prod
{
    public partial class ProdPlanMain : F_BasciForm
    {
        public ProdPlanMain()
        {
            InitializeComponent();
            BindEvent();
        }

        private Infragistics.Win.UltraWinGrid.UltraGrid uGridPlan = new UltraGrid();
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridPlanNodes = new UltraGrid();

        FormHelper fHelper = new FormHelper();

        private void BindEvent()
        {
            ToolStripHelper tsHelper = new ToolStripHelper();

            //待计划
            ToolStripButton tButton = new ToolStripButton();
            tButton.Text = "下发计划";
            tButton.Name = "deploy";
            Image image = global::QX.Common.Properties.Resources.planner;　　　　//从资源文件中引用
            tButton.Image = image;
            tButton.Size = new Size(43, 28);
            tButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            tButton.Click += new EventHandler(DeployPlan_Click);
            this.tbPlaningTask.AddCustomControl(tButton);
            this.tbPlaningTask.RefreshClicked += new EventHandler(tbPlaningTask_RefreshClicked);

            this.tbPlaningTask.SetButtonText("query", "工序查看调整");
            this.tbPlaningTask.QueryClicked += new EventHandler(tbPlaningTask_QueryClicked);

            //已计划
            ToolStripButton planTaskButton = new ToolStripButton();
            planTaskButton.Text = "下发计划";
            planTaskButton.Name = "deploy";
            Image image5 = global::QX.Common.Properties.Resources.planner;　　　　//从资源文件中引用
            planTaskButton.Image = image5;
            planTaskButton.Size = new Size(43, 28);
            planTaskButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            planTaskButton.TextImageRelation = TextImageRelation.ImageAboveText;
            planTaskButton.Click += new EventHandler(planTaskButton_Click);
            this.tbPlanTask.AddCustomControl(planTaskButton);
            this.tbPlanTask.SetButtonText("query", "工序查看调整");
            this.tbPlanTask.QueryClicked += new EventHandler(tbPlanTask_QueryClicked);

            //this.tbPlanTask.AccessibilityObjectc

            #region PRoad
            ToolStripButton nodesButton = new ToolStripButton();
            nodesButton.Name = "nodeChange";
            nodesButton.Text = "工序调整";
            Image image1 = global::QX.Common.Properties.Resources.nodes;　　　　//从资源文件中引用
            nodesButton.Image = image1;
            nodesButton.Size = new Size(43, 28);
            nodesButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            nodesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            nodesButton.Click += new EventHandler(nodesButton_Click);
            this.tbPlanNodes.AddCustomControl(nodesButton);

            ToolStripButton scheduleAllButton = new ToolStripButton();
            scheduleAllButton.Text = "全部更新";
            scheduleAllButton.Name = "scheduleAll";
            Image image2 = global::QX.Common.Properties.Resources.schedule;　　　　//从资源文件中引用
            scheduleAllButton.Image = image2;
            scheduleAllButton.Size = new Size(43, 28);
            scheduleAllButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            scheduleAllButton.TextImageRelation = TextImageRelation.ImageAboveText;
            scheduleAllButton.Click += new EventHandler(scheduleButton_Click);
            this.tbPlanNodes.AddCustomControl(scheduleAllButton);


            ToolStripButton autoScheduleButton = new ToolStripButton();
            autoScheduleButton.Text = "自动排期";
            autoScheduleButton.Name = "scheduleAuto";
            Image image4 = global::QX.Common.Properties.Resources.schedule;　　　　//从资源文件中引用
            autoScheduleButton.Image = image4;
            autoScheduleButton.Size = new Size(43, 28);
            autoScheduleButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            autoScheduleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            autoScheduleButton.Click += new EventHandler(autoScheduleButton_Click);
            this.tbPlanNodes.AddCustomControl(autoScheduleButton);

            this.tbPlanNodes.SaveClicked += new EventHandler(tbPlanNodes_SaveClicked);

            #endregion

            #region 批量调整
            ToolStripButton batchButton = new ToolStripButton();
            batchButton.Name = "batch";
            batchButton.Text = "批量调整";
            Image image3 = global::QX.Common.Properties.Resources.batch;　　　　//从资源文件中引用
            batchButton.Image = image3;
            batchButton.Size = new Size(43, 28);
            batchButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            batchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            batchButton.Click += new EventHandler(batchButton_Click);
            this.tbPlan.AddCustomControl(batchButton);

            //this.tbPlan.PrintClicked += new EventHandler(tbPlan_PrintClicked);

            #endregion

            this.tabPlanTask.SelectedIndexChanged += new EventHandler(tabPlanTask_SelectedIndexChanged);


            #region 已计划任务工具栏

            uGridPlanedTaskToolBar();

            #endregion


            fHelper.PermissionControl(tbPlanTask.toolStrip1.Items, PermissionModuleEnum.ProdPlan.ToString());
            fHelper.PermissionControl(tbPlaningTask.toolStrip1.Items, PermissionModuleEnum.ProdPlan.ToString());
            fHelper.PermissionControl(tbPlan.toolStrip1.Items, PermissionModuleEnum.ProdPlan.ToString());
            fHelper.PermissionControl(tbPlanNodes.toolStrip1.Items, PermissionModuleEnum.ProdPlan.ToString());

        }

        void tbPlanTask_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlanTask.ActiveRow;
            if (row != null)
            {
                Prod_Task task = row.ListObject as Prod_Task;
                RoadComptInfo CompFrm = new RoadComptInfo(new Bll_Road_Components(), OperationTypeEnum.OperationType.Edit, task.TaskDetail_PartNo);
                CompFrm.Show();
            }
        }
        //查看
        void tbPlaningTask_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlaningTask.ActiveRow;
            if (row != null)
            {
                Prod_Task task = row.ListObject as Prod_Task;
                RoadComptInfo CompFrm = new RoadComptInfo(new Bll_Road_Components(), OperationTypeEnum.OperationType.Edit, task.TaskDetail_PartNo);
                CompFrm.Show();
            }
        }

        void tbPlanNodes_SaveClicked(object sender, EventArgs e)
        {
            UltraGridRow row1 = this.uGridPlan.ActiveRow;
            if (row1 != null)
            {
                if (!IsCanEdit(uGridPlan))
                {
                    return;
                }
                List<Prod_Roads> list = new List<Prod_Roads>();
                foreach (UltraGridRow row in this.uGridPlanNodes.Rows)
                {
                    Prod_Roads road = row.ListObject as Prod_Roads;
                    list.Add(road);
                }

                if (prInstance.AddOrUpdatePRoads(list))
                {
                    Alert.Show("数据更新完成!");
                }
            }
        }

        void tbPlaningTask_RefreshClicked(object sender, EventArgs e)
        {
            RefreshPlaningTask();
        }

        void autoScheduleButton_Click(object sender, EventArgs e)
        {

            UltraGridRow row = this.uGridPlanNodes.ActiveRow;
            if (row != null)
            {

                if (!IsCanEdit(uGridPlan))
                {
                    return;
                }

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定自动更新当前选中节点之后的节点排期?");

                if (dialog == DialogResult.OK)
                {

                    Prod_Roads pr = row.ListObject as Prod_Roads;

                    prInstance.IncrementalAjustPlanRoads(pr);

                    uGridPlanNodeBind(pr.PRoad_PlanCode);
                }
            }
        }

        /// <summary>
        /// 批量调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void batchButton_Click(object sender, EventArgs e)
        {
            List<Prod_PlanProd> checkList = GetGridCheckBoxData();
            //选择的行作为批量更新模板
            UltraGridRow row = this.uGridPlan.ActiveRow;

            if (checkList != null && checkList.Count > 0)
            {
                Prod_PlanProd prodPlan = row.ListObject as Prod_PlanProd;

                AjustProdPlan batchPlan = new AjustProdPlan(prodPlan, checkList);
                batchPlan.CallBack += new AjustProdPlan.DCallBackHandler(batchPlan_CallBack);
                batchPlan.ShowDialog();
            }
        }

        void batchPlan_CallBack(List<Prod_PlanProd> planList, List<Prod_Roads> prList)
        {
            if (prInstance.BatchUpdateProdRoads(planList, prList))
            {
                Alert.Show("批量更新成功!");
                uGridPlanNodeBind(planList[0].PlanProd_PlanCode);
            }
        }

        private List<Prod_PlanProd> GetGridCheckBoxData()
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();

            foreach (UltraGridRow r in this.uGridPlan.DisplayLayout.Rows)
            {
                Prod_PlanProd prod = r.ListObject as Prod_PlanProd;
                string stat = prod.IInfor_Stat;
                if (stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Entering.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Testing.ToString())
                {
                    continue;
                }

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    Prod_PlanProd planProd = r.ListObject as Prod_PlanProd;
                    list.Add(planProd);
                }
            }

            return list;
        }

        /// <summary>
        /// 排期事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void scheduleButton_Click(object sender, EventArgs e)
        {
            //当前对应生产计划
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null && uGridPlanNodes.Rows.Count > 0)
            {

                if (!IsCanEdit(uGridPlan))
                {
                    return;
                }

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定更新全部工艺节点排期?");

                if (dialog == DialogResult.OK)
                {
                    Prod_PlanProd prodPlan = row.ListObject as Prod_PlanProd;
                    prInstance.AjustPlanRoadsTimeCost(prodPlan);

                    this.uGridPlanNodeBind(prodPlan.PlanProd_PlanCode);
                }
            }
        }

        /// <summary>
        /// 工序调整事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void nodesButton_Click(object sender, EventArgs e)
        {

            //导入条件--计划不为空
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {

                if (!IsCanEdit(uGridPlan))
                {
                    return;
                }
                UltraGridRow prow = this.uGridPlanNodes.ActiveRow;
                Prod_Roads road = prow.ListObject as Prod_Roads;
                ImportRoads frm = new ImportRoads(road.PRoad_CompCode);

                frm.ShowDialog();

                if (frm.IsChanged)
                {
                    Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                    List<Prod_Roads> list = new List<Prod_Roads>();
                    foreach (UltraGridRow row1 in this.uGridPlanNodes.Rows)
                    {
                        Prod_Roads node = row1.ListObject as Prod_Roads;
                        list.Add(node);
                    }

                    prInstance.AddOrUpdatePlanRoads(plan, list, frm.CurNodeDict, frm.CurNodeTimeCostDict);

                    //this.GridRefresh();

                    RefreshPlanNodeList();
                }

            }
        }

        private bool IsPlaningTaskInit = true;

        private bool IsPlanedTaskInit = false;

        void tabPlanTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPlanTask.SelectedIndex)
            {
                case 0:
                    if (IsPlaningTaskInit)
                    {
                        RefreshPlaningTask();
                    }
                    break;
                case 1:
                    if (IsPlanedTaskInit)
                    {
                        RefreshPlanTaskuGrid();
                    }
                    else
                    {
                        uGridPlanTaskInit();
                        IsPlanedTaskInit = true;
                    }
                    break;

            }
        }

        void planTaskButton_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlanTask.ActiveRow;
            if (row != null)
            {
                Prod_Task pt = row.ListObject as Prod_Task;
                if (pt.TaskDetail_Num <= pt.Task_DNum)
                {
                    Alert.Show("该任务计划已下发完毕!");
                }
                else
                {
                    DeployProdTaskToPlan(pt);
                }
            }
        }

        #region 窗体单例

        public static ProdPlanMain NewForm = null;



        public static ProdPlanMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new ProdPlanMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void ProdPlanMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            //已计划任务
            //uGridPlanTaskInit();
            //待计划列表
            uGridPlaningTaskInit();

            //计划产品零件
            uGridPlanInit();

            uGridPlanNodeInit();


            RefreshPlanList(new List<Prod_PlanProd>());
        }

        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        #region 待计划计划任务


        UltraGrid uGridPlaningTask = new UltraGrid();

        private List<Prod_Task> CurPlaningProdDataSource = new List<Prod_Task>();

        private GridHandler _PlaningProdHandler;

        public GridHandler PlaningProdHandler
        {
            get { return _PlaningProdHandler; }
            set { _PlaningProdHandler = value; }
        }

        private Dictionary<string, string> _PlaningProdDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> PlaningProdDicColumn
        {
            get { return _PlaningProdDicColumn; }
            set { _PlaningProdDicColumn = value; }
        }

        public void uGridPlaningTaskInit()
        {
            PlaningProdHandler = new GridHandler(this.uGridPlaningTask);
            uGridPlaningTaskBind();
        }


        void DeployPlan_Click(object sender, EventArgs e)
        {

            UltraGridRow row = this.uGridPlaningTask.ActiveRow;
            if (row != null)
            {
                Prod_Task pt = row.ListObject as Prod_Task;
                if (pt.TaskDetail_Num == pt.Task_DNum)
                {
                    Alert.Show("该任务计划已下发完毕!");
                }
                else
                {
                    DeployProdTaskToPlan(pt);
                    RefreshPlaningTask();
                }
            }


        }


        private void DeployProdTaskToPlan(Prod_Task pt)
        {

            DeployPlan planFrm = new DeployPlan(pt);
            planFrm.CallBack += new DeployPlan.DCallBackHandler(planFrm_CallBack);
            planFrm.ShowDialog();

        }

        void planFrm_CallBack(bool result, Prod_Task pt)
        {
            Alert.Show("下发计划成功!");
            if (this.tabPlanTask.SelectedIndex == 0)
            {
                //ActiveTab(1);
                //if (this.uGridPlanTask.Rows.Count > 0)
                //{
                //    this.uGridPlanTask.Rows[this.uGridPlanTask.Rows.Count - 1].Activate();
                //}
            }
            else
            {
                //ActiveTab(1);
                //UltraGridRow row = this.uGridPlanTask.ActiveRow;
                //PlaningProdHandler.UpdateRow<Prod_Task>(row, pt);

                //if (row != null)
                //{
                //    uGridPlanBind(row.Cells["Task_Code"].Value.ToString());
                //}
            }
        }

        private void ActiveTab(int index)
        {
            this.tabPlanTask.SelectedIndex = index;
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        public void uGridPlaningTaskBind()
        {
            CurPlaningProdDataSource = ppInstance.GetPlanTaskList();

            GridHelper gen = new GridHelper();

            uGridPlaningTask = gen.GenerateGrid("GProdTask", this.panel1, new Point(0, 0));
            
            uGridPlaningTask.DataSource = CurPlaningProdDataSource;
            uGridPlaningTask.AfterRowActivate += new EventHandler(uGridPlaningTask_AfterRowActivate);
            PlaningProdHandler.SetGridEditMode(false, uGridPlaningTask);

        }

        void uGridPlaningTask_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlaningTask.ActiveRow;
            if (row != null && row.Cells["Task_Code"].Value != null && row.Cells["Task_Name"].Value != null)
            {
                string taskCode = row.Cells["Task_Code"].Value.ToString();
                string taskName = row.Cells["Task_Name"].Value.ToString();
                SetPlanGridCaption(taskCode + "  " + taskName);
                uGridPlanBind(taskCode);
            }
        }

        /// <summary>
        /// 待计划列表刷新
        /// </summary>
        private void RefreshPlaningTask()
        {

            CurPlaningProdDataSource = ppInstance.GetPlanTaskList();

            uGridPlaningTask.DataSource = CurPlaningProdDataSource;

            if (CurPlaningProdDataSource.Count == 0)
            {
                RefreshPlanList(new List<Prod_PlanProd>());
                RefreshPlanNodeList(new List<Prod_Roads>());
            }

        }


        #endregion

        #region 已计划计划任务

        /// <summary>
        /// 已计划任务
        /// </summary>
        private List<Prod_Task> CurPlanProdDataSource = new List<Prod_Task>();

        private GridHandler _PlanProdHandler;

        public GridHandler PlanProdHandler
        {
            get { return _PlanProdHandler; }
            set { _PlanProdHandler = value; }
        }

        private Dictionary<string, string> _PlanProdDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> PlanProdDicColumn
        {
            get { return _PlanProdDicColumn; }
            set { _PlanProdDicColumn = value; }
        }

        UltraGrid uGridPlanTask = new UltraGrid();

        ToolStripTextBox txtPlaned = new ToolStripTextBox();

        private void uGridPlanedTaskToolBar()
        {

            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tbPlanTask.AddCustomControl(4, tLabel3);


            this.tbPlanTask.AddCustomControl(5, txtPlaned);

            //搜索按钮
            ToolStripButton searchPlanedBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchPlanedBtn_Click));
            this.tbPlanTask.AddCustomControl(6, searchPlanedBtn);
        }


        /// <summary>
        /// 已计划任务列表搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchPlanedBtn_Click(object sender, EventArgs e)
        {
            string key = txtPlaned.Text;

            string where = string.Format(" AND (TaskDetail_CmdCode like '%{0}%' OR Task_Name like '%{0}%' or Task_Code like '%{0}%'  or TaskDetail_PartName like '%{0}%' or TaskDetail_PartNo like '%{0}%')", key);

            List<Prod_Task> list = ppInstance.GetPlanedTaskListWithFitler(where);

            uGridPlanTask.DataSource = list;
        }

        /// <summary>
        /// 已计划生产任务列表初始化
        /// </summary>
        public void uGridPlanTaskInit()
        {
            PlanProdHandler = new GridHandler(this.uGridPlanTask);



            //uGridPlanTaskInitColumn();

            uGridPlanTaskBind();

            uGridPlanTaskEventInit();

            //uGridPlanTaskStyleInit();

        }

        private void uGridPlanTaskEventInit()
        {
            //this.uGridPlanTask.InitializeRow += new InitializeRowEventHandler(uGridPlanTask_InitializeRow);
            this.uGridPlanTask.AfterRowActivate += new EventHandler(uGridPlanTask_AfterRowActivate);


        }

        void uGridPlanTask_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            //int dNum = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(e.Row.Cells[""].Value);
            //int allNum=
        }


        void uGridPlanTask_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlanTask.ActiveRow;
            if (row != null && row.Cells["Task_Code"].Value != null && row.Cells["Task_Name"].Value != null)
            {
                string taskCode = row.Cells["Task_Code"].Value.ToString();
                string taskName = row.Cells["Task_Name"].Value.ToString();
                SetPlanGridCaption(taskCode + "  " + taskName);
                uGridPlanBind(taskCode);
            }
        }

        private void uGridPlanTaskStyleInit()
        {
            PlanProdHandler.SetDefaultStyle();
            PlanProdHandler.SetExcelStyleFilter();
        }



        public void uGridPlanTaskBind()
        {
            CurPlanProdDataSource = ppInstance.GetPlanedTaskList();

            GridHelper gen = new GridHelper();

            uGridPlanTask = gen.GenerateGrid("GPlanTask", this.panel2, new Point(0, 0));

            uGridPlanTask.DataSource = CurPlanProdDataSource;

            PlanProdHandler.SetGridEditMode(false, uGridPlanTask);

            //PlanProdHandler.BindData(CurPlanProdDataSource, PlanProdDicColumn);

            //AdjustPlanTaskGridColumn();
        }


        private void RefreshPlanTaskuGrid()
        {
            //CurPlanProdDataSource = ptInstance.GetFinProdTask();

            CurPlanProdDataSource = ppInstance.GetPlanedTaskList();


            uGridPlanTask.DataSource = CurPlanProdDataSource;
            //PlanProdHandler.BindData(CurPlanProdDataSource, PlanProdDicColumn);

            //AdjustPlanTaskGridColumn();
        }

        #endregion

        #region 计划列表

        private List<Prod_PlanProd> CurPlanDataSource = new List<Prod_PlanProd>();


        public void uGridPlanInit()
        {
            uGridPlanInitColumn();

            uGridPlanEventInit();

        }


        private void uGridPlanEventInit()
        {
            this.uGridPlan.AfterRowActivate += new EventHandler(uGridPlan_AfterRowActivate);
            this.uGridPlan.CellChange += new CellEventHandler(uGridPlan_CellChange);
            this.uGridPlan.InitializeRow += new InitializeRowEventHandler(uGridPlan_InitializeRow);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void uGridPlan_CellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "checkbox" && e.Cell.Row.Cells["IInfor_Stat"].Value != null)
            {
                //库存状态
                string stat = e.Cell.Row.Cells["IInfor_Stat"].Value.ToString();

                if (stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Entering.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Testing.ToString())
                {
                    e.Cell.Value = false;
                }
            }

        }

        void uGridPlan_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Prod_PlanProd plan = e.Row.ListObject as Prod_PlanProd;

            if (string.IsNullOrEmpty(plan.IInfor_Stat))
            {
                return;
            }

            string stat = e.Row.Cells["IInfor_Stat"].Value.ToString();

            if (stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Entering.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Testing.ToString())
            {
                e.Row.Appearance.BackColor = Color.Wheat;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void uGridPlan_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                if (plan != null && !string.IsNullOrEmpty(plan.PlanProd_PlanCode))
                {
                    string planCode = row.Cells["PlanProd_PlanCode"].Value.ToString();
                    uGridPlanNodeBind(planCode);
                }
            }

        }


        /// <summary>
        /// 设置计划列表标题
        /// </summary>
        /// <param name="title"></param>
        private void SetPlanGridCaption(string title)
        {

            //PlanHandler.SetGridCaption(title);
        }

        private void uGridPlanInitColumn()
        {
            GridHelper gen = new GridHelper();
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();

            uGridPlan = gen.GenerateGrid("GProdPlan", this.panel3, new Point(0, 0));

            uGridPlan.DataSource = list;

            gen.SetGridReadOnly(uGridPlan, true);

            //PlanHandler.SetGridEditMode(false, uGridPlan);

            uGridPlan.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;

            AddCustomColumn();

        }



        public void uGridPlanBind(string taskCode)
        {
            isInit = false;
            CurPlanDataSource = ppInstance.GetPlanProdList(taskCode);

            uGridPlan.DataSource = CurPlanDataSource;
            AddCustomColumn();
        }



        private bool isInit = true;

        private void AddCustomColumn()
        {

            if (!uGridPlan.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = uGridPlan.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;

            }
            else
            {
                uGridPlan.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = uGridPlan.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;
            }

            //try
            //{
            //    if (!isInit)
            //    {

            //        this.uGridPlan.DisplayLayout.Bands[0].Columns.Remove("checkbox");
            //    }


            //    this.uGridPlan.DisplayLayout.Bands[0].Columns.Add("checkbox", "");

            //    UltraGridColumn column1 = this.uGridPlan.DisplayLayout.Bands[0].Columns["checkbox"];

            //    column1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            //    column1.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            //    column1.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            //    //column1.CellButtonAppearance.Image = global::BC.Common.Properties.Resources.edit;　　　　//从资源文件中引用
            //    column1.DataType = typeof(bool);
            //    column1.DefaultCellValue = false;
            //    column1.Width = 18;

            //    //调整到第一列
            //    column1.Header.VisiblePosition = 0;

            //    column1.CellClickAction = CellClickAction.Edit;
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void RefreshuGridPlaned()
        {
            isInit = false;
            CurPlanProdDataSource = ppInstance.GetPlanedTaskList();

            uGridPlan.DataSource = CurPlanProdDataSource;
            AddCustomColumn();
        }



        private void RefreshPlanList(List<Prod_PlanProd> list)
        {

            uGridPlan.DataSource = list;
        }

        #endregion

        #region 工艺路线列表


        private List<Prod_Roads> CurPlanNodeDataSource = new List<Prod_Roads>();
        //部门选择处理Handler
        private Bll_Dept deptInstance = new Bll_Dept();

        private GridHandler _PlanNodeHandler;

        public GridHandler PlanNodeHandler
        {
            get { return _PlanNodeHandler; }
            set { _PlanNodeHandler = value; }
        }

        private Dictionary<string, string> PlanNodeDicColumn = new Dictionary<string, string>();


        public void uGridPlanNodeInit()
        {
            PlanNodeHandler = new GridHandler(this.uGridPlanNodes);

            uGridPlanNodeInitColumn();

            uGridPlanNodeEventInit();
        }


        private void uGridPlanNodeEventInit()
        {
            //点击部门  时间  等事件处理
            this.uGridPlanNodes.BeforeEnterEditMode += new CancelEventHandler(uGridPlanNodes_BeforeEnterEditMode);

            this.uGridPlanNodes.CellChange += new CellEventHandler(uGridPlanNodes_CellChange);
        }

        void uGridPlanNodes_CellChange(object sender, CellEventArgs e)
        {          //如果选择了时间控件

            Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;

            if (IsNodeCanUpdate(e.Cell.Row))
            {

                switch (e.Cell.Column.Key)
                {
                    case "PRoad_Begin":
                        {
                            UltraGridColumn column = e.Cell.Column;
                            EmbeddableEditorBase editor = e.Cell.EditorResolved;
                            object beginValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                            //Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;
                            pr.PRoad_Begin = DateTime.Parse(beginValue.ToString());
                            prInstance.Update(pr);
                            break;
                        }
                    case "PRoad_End":
                        {
                            UltraGridColumn column = e.Cell.Column;
                            EmbeddableEditorBase editor = e.Cell.EditorResolved;
                            object endValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                            //Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;
                            pr.PRoad_End = DateTime.Parse(endValue.ToString());
                            prInstance.Update(pr);
                            break;
                        }
                    case "PRoad_EquCode":
                        {
                            UltraGridColumn column = e.Cell.Column;
                            EmbeddableEditorBase editor = e.Cell.EditorResolved;
                            object endValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                            //Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;
                            pr.PRoad_EquCode = e.Cell.Value.ToString();
                            prInstance.Update(pr);
                            break;
                        }

                }
            }

        }


        void uGridPlanNodes_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell aCell = this.uGridPlanNodes.ActiveCell;


            if (aCell != null)
            {
                Prod_Roads pr = this.uGridPlanNodes.ActiveRow.ListObject as Prod_Roads;

                if (IsNodeCanUpdate(this.uGridPlanNodes.ActiveRow))
                {
                    switch (aCell.Column.Key)
                    {
                        case "PRoad_NodeDepName":
                            { //需要判断是否可以编辑

                                //e.Cancel = true;
                                CommDept<Bll_Dept, Bse_Department> CommDept = new CommDept<Bll_Dept, Bse_Department>(deptInstance,
                       new Size(350, 350));
                                CommDept.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(CommDept_CallBack);
                                CommDept.ShowDialog();
                                e.Cancel = true;
                                break;
                            }
                        case "PRoad_NodeDepCode":
                            {
                                //需要判断是否可以编辑

                                //e.Cancel = true;
                                CommDept<Bll_Dept, Bse_Department> CommDept = new CommDept<Bll_Dept, Bse_Department>(deptInstance,
                       new Size(350, 350));
                                CommDept.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(CommDept_CallBack);
                                CommDept.ShowDialog();
                                e.Cancel = true;
                                break;
                            }
                        case "PRoad_EquName":

                            break;
                    }
                }//end
                else
                {

                }

            }

        }


        /// <summary>
        /// 用户选择后的返回事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="list"></param>
        void CommDept_CallBack(object sender, DataTable list)
        {
            if (list.Rows.Count == 1)
            {

                UltraGridRow row = this.uGridPlanNodes.ActiveRow;

                if (row != null)
                {
                    Prod_Roads pr = row.ListObject as Prod_Roads;

                    if (prInstance.IsNeedFHelper(list.Rows[0]["Dept_Code"].ToString()))
                    {
                        //问题：如果进入外协流程，是否换可以编辑相关信息
                        DialogResult diaolog = Alert.Show(MessageBoxButtons.OKCancel, "是否需要外协?");
                        if (diaolog == DialogResult.OK)
                        {
                            row.Cells["PRoad_NodeDepName"].Value = list.Rows[0]["Dept_Name"].ToString();
                            row.Cells["PRoad_NodeDepCode"].Value = list.Rows[0]["Dept_Code"].ToString();
                            Prod_Roads pr1 = row.ListObject as Prod_Roads;
                            if (prInstance.UpdateDept(pr1, 1))
                            {
                                Alert.Show("该工序已经入外协处理流程!");
                            }
                        }
                    }
                    else
                    {
                        row.Cells["PRoad_NodeDepName"].Value = list.Rows[0]["Dept_Name"].ToString();
                        row.Cells["PRoad_NodeDepCode"].Value = list.Rows[0]["Dept_Code"].ToString();
                        Prod_Roads pr2 = row.ListObject as Prod_Roads;
                        prInstance.UpdateDept(pr2, 0);
                    }
                }
            }
        }

        private List<string> TimeControlMap
        {
            get;
            set;
        }

        private void TimeControlMapInit()
        {
            Bll_Sys_Map mapInst = new Bll_Sys_Map();
            var map = mapInst.GetModel(string.Format(" AND Map_Module='{0}' And Map_Source='{0}'", "RecordTime"));
            TimeControlMap = map.Map_Object1.Split(',').ToList();
        }

        private void uGridPlanNodeInitColumn()
        {
            TimeControlMapInit();

            List<Prod_Roads> list = new List<Prod_Roads>();

            GridHelper gen = new GridHelper();

            uGridPlanNodes = gen.GenerateGrid("GProdRoads", this.panel4, new Point(0, 0));

            uGridPlanNodes.DataSource = list;

            //gen.SetGridReadOnly(uGridPlanNodes, false);
            //PlanNodeHandler.SetGridEditMode(true, uGridPlanNodes);
            uGridPlanNodes.BeforeCellListDropDown += new CancelableCellEventHandler(uGridPlanNodes_BeforeCellListDropDown);
            uGridPlanNodes.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

            uGridPlanNodes.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;


            if (uGridPlanNodes.DisplayLayout.Bands[0].Columns.Exists("PRoad_NodeDepName"))
            {
                uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_NodeDepName"].CellClickAction = CellClickAction.Edit;
            }
            if (uGridPlanNodes.DisplayLayout.Bands[0].Columns.Exists("PRoad_EquName"))
            {
                uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_EquName"].CellClickAction = CellClickAction.Edit;
            }

        }

        void uGridPlanNodes_BeforeCellListDropDown(object sender, CancelableCellEventArgs e)
        {

            var cell = e.Cell;
            if (TimeControlMap.Contains(cell.Column.Key))
            {
                TimeControl controlTime = new TimeControl(cell.Column.Key);
                controlTime.CallBack += new TimeControl.DCallBackHandler(userTimeSelect_CallBack);
                //controlTime.Location = new Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                controlTime.ShowWin(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                e.Cancel = true;
            }

        }

        private void userTimeSelect_CallBack(string key, object val)
        {
            UltraGridRow row = this.uGridPlanNodes.ActiveRow;
            if (row != null && row.Cells.Exists(key))
            {
                row.Cells[key].Value = val;
            }
        }


        public void uGridPlanNodeBind(string planCode)
        {

            CurPlanNodeDataSource = prInstance.GetPlanRoadList(planCode);

            uGridPlanNodes.DataSource = CurPlanNodeDataSource;

        }

        /// <summary>
        /// 当前节点是否可以编辑
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool IsNodeCanUpdate(UltraGridRow row)
        {
            bool flag = false;
            if (row != null)
            {
                Prod_Roads pr = row.ListObject as Prod_Roads;

                if (pr != null && pr.PRoad_IsDone)
                {
                    flag = false;
                    Alert.Show("当前节点已进入生产流程，不能更新其数据!");
                }
                else
                {
                    flag = true;
                }
            }

            return flag;
        }

        /// <summary>
        /// 判断工艺节点是否可以批量更新（工序调整、时间等）
        /// </summary>
        /// <param name="grid">生产计划</param>
        /// <returns></returns>
        public bool IsCanEdit(UltraGrid grid)
        {
            bool flag = true;

            UltraGridRow row = grid.ActiveRow;
            Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
            string stat = plan.IInfor_Stat;
            string pstat = plan.IInfor_ProdStat;
            if (pstat == OperationTypeEnum.ProdStatEnum.Normal.ToString() && (stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Entering.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString() || stat == QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Testing.ToString()))
            {
                Alert.Show("当前工艺节点已完成，不能更新其数据!");
                flag = false;
            }
            else if (pstat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
            {
                Alert.Show("当前生产产品正在不合格品审理流程中，不能更新其数据!");
                flag = false;
            }

            return flag;

        }


        private void RefreshPlanNodeList(List<Prod_Roads> list)
        {
            CurPlanNodeDataSource = list;
            uGridPlanNodes.DataSource = list;
        }
        /// <summary>
        /// 刷新节点数据
        /// </summary>
        private void RefreshPlanNodeList()
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                CurPlanNodeDataSource = prInstance.GetPlanRoadList(plan.PlanProd_PlanCode);
                uGridPlanNodes.DataSource = CurPlanNodeDataSource;
            }
        }



        //private void RefreshuGridPlanNode()
        //{
        //    //CurPlanProdDataSource = ptInstance.GetFinProdTask();
        //    PlanNodeHandler.BindData(CurPlanNodeDataSource, PlanNodeDicColumn);

        //    AdjustPlanNodeGridColumn();
        //}

        //private void RefreshuGridPlanNode(List<Road_Components> list)
        //{
        //    PlanNodeHandler.BindData(list, PlanNodeDicColumn);

        //    AdjustPlanNodeGridColumn();
        //}

        #endregion
    }
}
