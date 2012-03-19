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
using QX.Framework.AutoForm;
using QX.Plugin.RoadCateManage;

namespace QX.Plugin.Prod
{
    public partial class ProdTaskMain : F_BasciForm
    {
        public ProdTaskMain()
        {
            InitializeComponent();
            BindEvent();

        }

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private void BindEvent()
        {

            #region ToolBar

            ToolStripButton tButton = new ToolStripButton();
            tButton.Name = "deploytask";
            tButton.Text = "下发任务";
            Image image = global::QX.Common.Properties.Resources.planner;　　　　//从资源文件中引用
            tButton.Image = image;
            tButton.Size = new Size(43, 28);
            tButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            tButton.Click += new EventHandler(tButton_Click);
            this.tbTasking.AddCustomControl(tButton);

            this.tbTasking.RefreshClicked += new EventHandler(tbTasking_RefreshClicked);



            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripButton btnComp = tsHelper.New("工序查看维护", QX.Common.Properties.Resources.compedit, new EventHandler(btnComp_Click));
            btnComp.Name = "btnComp";
            //btnComp.Click += new EventHandler(btnComp_Click);
            this.tbTasking.AddCustomControl(btnComp);

            //已下达任务

            ToolStripButton lookButton = new ToolStripButton();
            lookButton.Text = "查看";
            Image image1 = global::QX.Common.Properties.Resources.look;　　　　//从资源文件中引用
            lookButton.Image = image1;
            lookButton.Size = new Size(43, 28);
            lookButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            lookButton.TextImageRelation = TextImageRelation.ImageAboveText;
            lookButton.Click += new EventHandler(lookButton_Click);
            this.tbTask.AddCustomControl(lookButton);

            ToolStripButton FinishButton = new ToolStripButton();
            FinishButton.Name = "FDTask";
            FinishButton.Text = "编辑";
            Image image2 = global::QX.Common.Properties.Resources.edit;　　　　//从资源文件中引用
            FinishButton.Image = image2;
            FinishButton.Size = new Size(43, 28);
            FinishButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            FinishButton.TextImageRelation = TextImageRelation.ImageAboveText;
            FinishButton.Click += new EventHandler(FinishButton_Click);
            this.tbTask.AddCustomControl(FinishButton);

            //撤销按钮
            ToolStripButton rawRollbackBtn = new ToolStripHelper().New("撤销入库", QX.Common.Properties.Resources.search, new EventHandler(rawRollbackBtn_Click));
            rawRollbackBtn.Name = "rawRollbackBtn";
            this.tbTasking.AddCustomControl(rawRollbackBtn);


            #endregion

            #region 已下达生产任务
            InitTaskingToolBar();

            #endregion


            #region 已完成生产任务
            InitFinTaskToolBar();

            #endregion

            this.tabProdTask.Selected += new TabControlEventHandler(tabProdTask_Selected);
        }

        /// <summary>
        /// 待下达任务回滚
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rawRollbackBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridTasking.ActiveRow;
            if (row != null)
            {

                if (Alert.ShowIsConfirm("您的操作不可回滚，确定要撤销当前入库毛坯!"))
                {
                    Raw_Inv inv = row.ListObject as Raw_Inv;
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
    , QX.Shared.SessionConfig.UserName
    , "localhost"
    , this.Name
    , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().RollbackRawInv + "," + inv.RI_Code
    , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdTask.ToString(), QX.Common.LogType.Edit.ToString());

                    pHelper.RollBackRaw(inv);
                    RefreshTaskingGrid();
                }
            }
        }

        void btnComp_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridTasking.ActiveRow;
            if (row != null)
            {
                Raw_Inv task = row.ListObject as Raw_Inv;
                RoadComptInfo CompFrm = new RoadComptInfo(new Bll_Road_Components(), OperationTypeEnum.OperationType.Edit, task.RI_CompCode);
                CompFrm.Show();
            }
        }

        void tbTasking_RefreshClicked(object sender, EventArgs e)
        {
            RefreshTaskingGrid();
        }

        private void InitTaskingToolBar()
        {
            //时间控件


            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tbTask.AddCustomControl(0, tLabel);

            this.tbTask.AddCDTPtoToolstrip(1, bDate);

            bDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));


            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tbTask.AddCustomControl(2, tLabel2);

            this.tbTask.AddCDTPtoToolstrip(3, eDate);

            eDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));

            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tbTask.AddCustomControl(4, tLabel3);


            this.tbTask.AddCustomControl(5, txtKey);

            //搜索按钮
            ToolStripButton searchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchBtn_Click));
            this.tbTask.AddCustomControl(6, searchBtn);


            //撤销按钮
            ToolStripButton rollbackBtn = new ToolStripHelper().New("撤销", QX.Common.Properties.Resources.search, new EventHandler(rollbackBtn_Click));
            rollbackBtn.Name = "prodRollback";
            this.tbTask.AddCustomControl(rollbackBtn);

        }

        QX.Plugin.Prod.Common.ProdHelper pHelper = new QX.Plugin.Prod.Common.ProdHelper();
        //任务回滚
        void rollbackBtn_Click(object sender, EventArgs e)
        {
            var row = this.uGridTask.ActiveRow;
            Prod_Task task = row.ListObject as Prod_Task;
            if (task != null)
            {
                if (Alert.ShowIsConfirm("您的操作不可回滚，确定要撤销当前任务!"))
                {
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
          , QX.Shared.SessionConfig.UserName
          , "localhost"
          , this.Name
          , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().RollbackProdTask + "," + task.Task_Code
          , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdTask.ToString(), QX.Common.LogType.Edit.ToString());

                    pHelper.RollBackProdTask(task.Task_Code);
                    RefreshTaskuGrid();
                    Alert.Show("回滚完成！");
                }
            }
        }


        DateTimePicker bFDate = new DateTimePicker();

        DateTimePicker eFDate = new DateTimePicker();

        ToolStripTextBox txtFKey = new ToolStripTextBox();


        private void InitFinTaskToolBar()
        {

            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "计划开始时间:";
            this.tbFinTask.AddCustomControl(0, tLabel);

            this.tbFinTask.AddCDTPtoToolstrip(1, bFDate);

            bFDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));


            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "计划结束时间:";
            this.tbFinTask.AddCustomControl(2, tLabel2);

            this.tbFinTask.AddCDTPtoToolstrip(3, eFDate);

            eFDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));

            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tbFinTask.AddCustomControl(4, tLabel3);


            this.tbFinTask.AddCustomControl(5, txtFKey);

            //搜索按钮
            ToolStripButton searchFBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchFBtn_Click));

            this.tbFinTask.AddCustomControl(6, searchFBtn);

        }

        void searchFBtn_Click(object sender, EventArgs e)
        {
            DateTime beginDate = this.bFDate.Value;
            DateTime endDate = this.eFDate.Value;
            string key = this.txtFKey.Text;

            string where = string.Empty;

            if (string.IsNullOrEmpty(key))
            {
                where = string.Format(" AND  TaskDetail_ActEnd>'{0}' AND TaskDetail_ActEnd<='{1}'", beginDate, endDate);
            }
            else
            {
                where = string.Format(" AND  TaskDetail_ActEnd>'{0}' AND TaskDetail_ActEnd<='{1}' AND (Task_Name like '%{2}%' or Task_Code like '%{2}%'  or TaskDetail_PartName like '%{2}%' or TaskDetail_PartNo like '%{2}%')", beginDate, endDate, key);
            }


            List<Prod_Task> list = ptInstance.GetFinProdTaskByWhere(where);

            uGridFinTask.DataSource = list;
        }

        /// <summary>
        /// 已下任务搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchBtn_Click(object sender, EventArgs e)
        {
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            string key = this.txtKey.Text;

            string where = string.Empty;

            if (string.IsNullOrEmpty(key))
            {
                where = string.Format(" AND ( Task_Date>'{0}' AND Task_Date<='{1}') ", beginDate, endDate);
            }
            else
            {
                where = string.Format(" AND  Task_Date>'{0}' AND Task_Date<='{1}' AND (TaskDetail_CmdCode like '%{2}%' OR Task_Name like '%{2}%' or Task_Code like '%{2}%'  or TaskDetail_PartName like '%{2}%' or TaskDetail_PartNo like '%{2}%')", beginDate, endDate, key);
            }



            List<Prod_Task> list = ptInstance.GetProdTaskByWhere(where);

            uGridTask.DataSource = list;
        }



        //private bool IsDeloyingInit = true;

        //private bool IsDeloyedInit = true;

        void tabProdTask_Selected(object sender, TabControlEventArgs e)
        {
            switch (this.tabProdTask.SelectedIndex)
            {
                case 0:
                    RefreshTaskingGrid();
                    break;
                case 1:
                    RefreshTaskuGrid();
                    break;
                case 2:
                    RefreshFinTaskuGrid();
                    break;
            }
        }


        private FormHelper fHelper = new FormHelper();


        private void ProdTaskMain_Load(object sender, EventArgs e)
        {
            Init();

            fHelper.PermissionControl(this.tbTasking.toolStrip1.Items, PermissionModuleEnum.ProdTask.ToString());
            fHelper.PermissionControl(this.tbTask.toolStrip1.Items, PermissionModuleEnum.ProdTask.ToString());

        }

        private List<Road_Nodes> RNodes
        {
            get;
            set;
        }

        private void Init()
        {
            RNodes = rnInstance.GetAll();

            //未下达
            uGridTaskingInit();
            //已下达
            uGridTaskInit();
            //已完成
            uGridFinTaskInit();

            //树控件初始化
        }



        #region 待下达任务

        private Bll_ProdTask ptInstance = new Bll_ProdTask();

        private List<Raw_Inv> CurRawInvDataSource = new List<Raw_Inv>();

        private GridHandler _RawInvHandler;

        public GridHandler RawInvHandler
        {
            get { return _RawInvHandler; }
            set { _RawInvHandler = value; }
        }

        private Dictionary<string, string> _RawInvDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> RawInvDicColumn
        {
            get { return _RawInvDicColumn; }
            set { _RawInvDicColumn = value; }
        }

        public void uGridTaskingInit()
        {

            RawInvHandler = new GridHandler(this.uGridTasking);

            uGridTaskingBind();

            //uGridTaskingStyleInit();



        }

        private void uGridTaskingStyleInit()
        {
            RawInvHandler.SetDefaultStyle();
            RawInvHandler.SetExcelStyleFilter();
        }



        public void uGridTaskingBind()
        {
            CurRawInvDataSource = ptInstance.GetBeUseRawList();

            GridHelper gen = new GridHelper();

            this.uGridTasking = gen.GenerateGrid("GRawInv", this.panel1, new Point(0, 0));
            uGridTasking.InitializeRow += new InitializeRowEventHandler(uGridTasking_InitializeRow);
            uGridTasking.DataSource = CurRawInvDataSource;

            RawInvHandler.SetGridEditMode(false, uGridTasking);

            uGridTasking.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;

        }

        void uGridTasking_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Raw_Inv inv = e.Row.ListObject as Raw_Inv;
            if (inv != null)
            {
                var list = RNodes.Where(o => o.RNodes_PartCode == inv.RI_CompCode);
                if (list.Count() == 0)
                {
                    inv.RI_Udef1 = "待完善工序";
                }
                else
                {
                    inv.RI_Udef1 = "已有工序";
                }
            }
        }

        public void AdjustGridColumn()
        {
            RawInvHandler.AdjustGridColumn(RawInvDicColumn);
        }

        /// <summary>
        /// 刷新待下达任务列表
        /// </summary>
        private void RefreshTaskingGrid()
        {
            CurRawInvDataSource = ptInstance.GetBeUseRawList();

            uGridTasking.DataSource = CurRawInvDataSource;


        }

        /// <summary>
        /// 刷新待下达任务列表
        /// </summary>
        private void RefreshTaskingGrid(List<Road_Components> list)
        {
            RawInvHandler.BindData(list, RawInvDicColumn);
            uGridTasking.DataSource = CurRawInvDataSource;
            //AdjustGridColumn();
        }


        void tButton_Click(object sender, EventArgs e)
        {
            DeployTasking();
        }
        /// <summary>
        /// 下达任务
        /// </summary>
        private void DeployTasking()
        {

            //List<Raw_Inv> list = new List<Raw_Inv>();
            UltraGridRow row = this.uGridTasking.ActiveRow;

            if (row != null)
            {

                Raw_Inv raw = row.ListObject as Raw_Inv;

                DeployTask deployTaskFrm = new DeployTask(OperationTypeEnum.OperationType.Add, raw);

                deployTaskFrm.CallBack += new DeployTask.DCallBackHandler(deployTaskFrm_CallBack);

                deployTaskFrm.ShowDialog();
            }

        }

        private List<Raw_Inv> GetGridCheckBoxData()
        {
            List<Raw_Inv> list = new List<Raw_Inv>();

            foreach (UltraGridRow r in this.uGridTasking.DisplayLayout.Rows)
            {
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    list.Add((r.ListObject as Raw_Inv));
                }
            }

            return list;
        }

        void deployTaskFrm_CallBack(bool result, object sender)
        {
            if (result)
            {
                RefreshTaskingGrid();
            }
        }

        #endregion

        #region 已下达任务


        private List<Prod_Task> CurProdTaskDataSource = new List<Prod_Task>();

        private GridHandler _ProdTaskHandler;

        public GridHandler ProdTaskHandler
        {
            get { return _ProdTaskHandler; }
            set { _ProdTaskHandler = value; }
        }

        private Dictionary<string, string> _ProdTaskDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> ProdTaskDicColumn
        {
            get { return _ProdTaskDicColumn; }
            set { _ProdTaskDicColumn = value; }
        }

        public void uGridTaskInit()
        {
            ProdTaskHandler = new GridHandler(this.uGridTask);

            uGridTaskBind();

            this.uGridTask.DoubleClickRow += new DoubleClickRowEventHandler(uGridTask_DoubleClickRow);
        }

        void uGridTask_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            EditProdTask();
        }

        private void uGridTaskStyleInit()
        {
            ProdTaskHandler.SetDefaultStyle();
            ProdTaskHandler.SetExcelStyleFilter();
        }

        void lookButton_Click(object sender, EventArgs e)
        {
            EditProdTask();
        }


        private void EditProdTask()
        {
            UltraGridRow row = this.uGridTask.ActiveRow;
            if (row != null)
            {
                Prod_Task pt = row.ListObject as Prod_Task;
                Prod_Task task = ptInstance.GetTaskByCode(pt.Task_Code);
                DeployTask deployTaskFrm = new DeployTask(OperationTypeEnum.OperationType.Look, task);

                deployTaskFrm.ShowDialog();
            }
        }

        void FinishButton_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridTask.ActiveRow;

            Prod_Task pt = row.ListObject as Prod_Task;

            DeployTask deployTaskFrm = new DeployTask(OperationTypeEnum.OperationType.Edit, pt);
            deployTaskFrm.CallBack += new DeployTask.DCallBackHandler(deployFinTaskFrm_CallBack);
            deployTaskFrm.ShowDialog();
        }

        void finTask_CallBack(bool result, object sender)
        {
            RefreshTaskuGrid();
        }

        private Dictionary<string, Prod_Task> GetTaskGridCheckBoxData()
        {
            Dictionary<string, Prod_Task> list = new Dictionary<string, Prod_Task>();

            foreach (UltraGridRow r in this.uGridTask.DisplayLayout.Rows)
            {
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    Prod_Task pt = r.ListObject as Prod_Task;
                    list.Add(pt.Task_Code, pt);
                }
            }

            return list;
        }

        void deployFinTaskFrm_CallBack(bool result, object sender)
        {
            if (result)
            {
                //刷新当前界面
                RefreshTaskuGrid();
            }
        }




        public void uGridTaskBind()
        {
            CurProdTaskDataSource = ptInstance.GetProdTask();

            GridHelper gen = new GridHelper();

            this.uGridTask = gen.GenerateGrid("GProdTask", this.panel3, new Point(0, 0));

            uGridTask.DataSource = CurProdTaskDataSource;

            ProdTaskHandler.SetGridEditMode(false, uGridTask);

        }

        public void AdjustTaskGridColumn()
        {
            ProdTaskHandler.AdjustGridColumn(ProdTaskDicColumn);
        }

        /// <summary>
        /// 已下达刷新
        /// </summary>
        private void RefreshTaskuGrid()
        {
            CurProdTaskDataSource = ptInstance.GetProdTask();

            uGridTask.DataSource = CurProdTaskDataSource;

        }

        /// <summary>
        /// 已下达刷新
        /// </summary>
        private void RefreshTaskuGrid(List<Road_Components> list)
        {
            uGridTask.DataSource = list;
        }


        #endregion

        #region 已完成


        private List<Prod_Task> CurFinProdTaskDataSource = new List<Prod_Task>();

        private GridHandler _FinProdTaskHandler;

        public GridHandler FinProdTaskHandler
        {
            get { return _FinProdTaskHandler; }
            set { _FinProdTaskHandler = value; }
        }

        private Dictionary<string, string> _FinProdTaskDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> FinProdTaskDicColumn
        {
            get { return _FinProdTaskDicColumn; }
            set { _FinProdTaskDicColumn = value; }
        }


        public void uGridFinTaskInit()
        {
            FinProdTaskHandler = new GridHandler(this.uGridFinTask);

            uGridFinTaskBind();

            //uGridTaskFinStyleInit();
        }

        private void uGridTaskFinStyleInit()
        {
            FinProdTaskHandler.SetDefaultStyle();
            FinProdTaskHandler.SetExcelStyleFilter();
        }

        public void uGridFinTaskBind()
        {
            CurFinProdTaskDataSource = ptInstance.GetFinProdTask();

            GridHelper gen = new GridHelper();

            uGridFinTask = gen.GenerateGrid("GProdTask", this.panel4, new Point(0, 0));

            uGridFinTask.DataSource = CurFinProdTaskDataSource;

            FinProdTaskHandler.SetGridEditMode(false, uGridFinTask);

            //FinProdTaskDicColumn.Add("TaskDetail_CmdCode", "生产指令号");
            //FinProdTaskDicColumn.Add("Task_Code", "生产任务编码");
            //FinProdTaskDicColumn.Add("Task_Name", "生产任务名称");
            //FinProdTaskDicColumn.Add("TaskDetail_PartNo", "零件图号");
            //FinProdTaskDicColumn.Add("TaskDetail_PartName", "零件名称");
            //FinProdTaskDicColumn.Add("Task_PartCatName", "产品分类");
            //FinProdTaskDicColumn.Add("TaskDetail_Unit", "单位");
            //FinProdTaskDicColumn.Add("TaskDetail_Num", "计划数量");
            //FinProdTaskDicColumn.Add("Task_DNum", "任务数量");
            //FinProdTaskDicColumn.Add("TaskDetail_PlanBegin", "计划开工时间");
            //FinProdTaskDicColumn.Add("TaskDetail_PlanEnd", "计划完工时间");
            //FinProdTaskDicColumn.Add("TaskDetail_ActEnd", "实际完工时间");
            //FinProdTaskDicColumn.Add("Task_Remark", "备注");

            //FinProdTaskHandler.BindData(CurFinProdTaskDataSource, FinProdTaskDicColumn);

            //AdjustFinTaskGridColumn();
        }

        public void AdjustFinTaskGridColumn()
        {
            ProdTaskHandler.AdjustGridColumn(FinProdTaskDicColumn);
        }

        /// <summary>
        /// 已下达刷新
        /// </summary>
        private void RefreshFinTaskuGrid()
        {
            CurFinProdTaskDataSource = ptInstance.GetFinProdTask();

            //FinProdTaskHandler.BindData(CurFinProdTaskDataSource, FinProdTaskDicColumn, true);

            //AdjustFinTaskGridColumn();
        }

        /// <summary>
        /// 已下达刷新
        /// </summary>
        private void RefreshFinTaskuGrid(List<Road_Components> list)
        {
            FinProdTaskHandler.BindData(list, FinProdTaskDicColumn, true);

            AdjustFinTaskGridColumn();
        }


        #endregion
    }
}
