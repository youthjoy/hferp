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
using QX.Shared;
using QX.Plugin.Prod.Common;

namespace QX.Plugin.Prod
{
    public partial class ProdRecordMain : F_BasciForm
    {
        public ProdRecordMain()
        {
            InitializeComponent();

            EventInit();
        }

        #region 窗体单例

        public static ProdRecordMain NewForm = null;



        public static ProdRecordMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new ProdRecordMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion


        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();
        private Bll_Inv_Information invInstance = new Bll_Inv_Information();
        private void EventInit()
        {
            RadioButton doingTask = new RadioButton();
            doingTask.Name = "Doing";
            doingTask.Text = "待完成";
            doingTask.Width = 70;
            CurStat = "Doing";
            doingTask.Checked = true;
            doingTask.Click += new EventHandler(rbnTask_Click);
            RadioButton finTask = new RadioButton();
            finTask.Name = "Fin";
            finTask.Text = "已完成";
            finTask.Width = 70;
            finTask.Click += new EventHandler(rbnTask_Click);
            this.flowLayoutPanel1.Controls.Add(doingTask);
            this.flowLayoutPanel1.Controls.Add(finTask);


            #region 生产任务

            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tbPlaningTask.AddCustomControl(0, tLabel);

            this.tbPlaningTask.AddCDTPtoToolstrip(1, bDate);
            bDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));
            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tbPlaningTask.AddCustomControl(2, tLabel2);
            tbPlaningTask.AddCDTPtoToolstrip(3, eDate);


            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tbPlaningTask.AddCustomControl(4, tLabel3);
            txtFKey.KeyDown += new KeyEventHandler(txtFKey_KeyDown);

            this.tbPlaningTask.AddCustomControl(5, txtFKey);

            //搜索按钮
            ToolStripButton searchFBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchFBtn_Click));
            //searchFBtn.Click += new EventHandler(searchFBtn_Click);
            this.tbPlaningTask.AddCustomControl(6, searchFBtn);

            this.tbPlaningTask.RefreshClicked += new EventHandler(tbPlaningTask_RefreshClicked);

            //ToolStripHelper tsHelper = new ToolStripHelper();
            //ToolStripButton setFinBtn = tsHelper.New("完成", QX.Common.Properties.Resources.finished, new EventHandler(setFinBtn_Click));
            //this.tbPlaningTask.AddCustomControl(setFinBtn);

            #endregion

            ToolStripHelper tsHelper = new ToolStripHelper();

            #region tbPlan

            ToolStripButton batchCheck = tsHelper.New("批量完工", QX.Common.Properties.Resources.batch, new EventHandler(batchCheck_Click));
            batchCheck.Name = "batchCheck";
            tbPlan.AddCustomControl(batchCheck);

            ToolStripButton batchProdInfo = tsHelper.New("批量数据录入", QX.Common.Properties.Resources.batch, new EventHandler(batchProdInfo_Click));
            batchProdInfo.Name = "batchProdInfo";
            tbPlan.AddCustomControl(batchProdInfo);

            ToolStripLabel tLabel4 = new ToolStripLabel();
            tLabel4.Text = "关键字:";
            tbPlan.AddCustomControl(4, tLabel4);
            txtPlanKey.KeyDown += new KeyEventHandler(txtPlanKey_KeyDown);
            tbPlan.AddCustomControl(5, txtPlanKey);

            //搜索按钮
            ToolStripButton searchPlanFBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchPlanFBtn_Click));

            tbPlan.AddCustomControl(6, searchPlanFBtn);



            this.tbPlan.RefreshClicked += new EventHandler(tbPlan_RefreshClicked);


            ToolStripButton patchBtn = tsHelper.New("组合配对", QX.Common.Properties.Resources.parts, new EventHandler(patchBtn_Click));

            this.tbPlan.AddCustomControl(patchBtn);


            ToolStripButton batchChange = tsHelper.New("批量节点更新", QX.Common.Properties.Resources.batch, new EventHandler(batchChange_Click));
            //batchChange.Click += new EventHandler(batchChange_Click);
            tbPlan.AddCustomControl(batchChange);


            ToolStripButton trashProdBtn = tsHelper.New("作废", QX.Common.Properties.Resources.delete, new EventHandler(trashProdBtn_Click));
            trashProdBtn.Name = "trashProdBtn";
            //trashProdBtn.Click += new EventHandler(trashProdBtn_Click);
            //batchChange.Click += new EventHandler(batchChange_Click);
            tbPlan.AddCustomControl(trashProdBtn);

            ToolStripButton rollbackProdBtn = tsHelper.New("撤销计划", QX.Common.Properties.Resources.delete, new EventHandler(rollbackProdBtn_Click));
            rollbackProdBtn.Name = "rollbackProdBtn";
            //rollbackProdBtn.Click += new EventHandler(rollbackProdBtn_Click);
            //trashProdBtn.Click += new EventHandler(trashProdBtn_Click);
            //batchChange.Click += new EventHandler(batchChange_Click);
            tbPlan.AddCustomControl(rollbackProdBtn);

            ToolStripButton statRollBack = tsHelper.New("撤销完工状态", QX.Common.Properties.Resources.delete, new EventHandler(statRollBack_Click));
           
            rollbackProdBtn.Name = "statRollBack";
            //rollbackProdBtn.Click += new EventHandler(rollbackProdBtn_Click);
            //trashProdBtn.Click += new EventHandler(trashProdBtn_Click);
            //batchChange.Click += new EventHandler(batchChange_Click);
            tbPlan.AddCustomControl(statRollBack);

            #endregion

            #region 生产节点工艺

            this.tbPlanNodes.SaveClicked += new EventHandler(tbPlanNodes_SaveClicked);


            ToolStripButton nodeClrBtn = tsHelper.New("清除接票时间", QX.Common.Properties.Resources.delete, new EventHandler(nodeClrBtn_Click));
            nodeClrBtn.Name = "nodeClr";
            this.tbPlanNodes.AddCustomControl(nodeClrBtn);

            //ToolStripButton batchTimeUpdate = tsHelper.New("批量调整时间", QX.Common.Properties.Resources.batch, new EventHandler(batchTimeUpdate_Click));
            //this.tbPlanNodes.AddCustomControl(batchTimeUpdate);
            this.tbPlanNodes.PrintClicked += new EventHandler(tbPlanNodes_PrintClicked);


            ToolStripButton batchNodeTicket = tsHelper.New("批量更新接票人", QX.Common.Properties.Resources.batch, new EventHandler(batchNodeTicket_Click));
            batchNodeTicket.Name = "batchCheck";
            tbPlanNodes.AddCustomControl(batchNodeTicket);


            ToolStripButton batchFHelper = tsHelper.New("批量外协", QX.Common.Properties.Resources.batch, new EventHandler(batchFHelper_Click));
            //batchFHelper.Click += new EventHandler(batchFHelper_Click);
            tbPlanNodes.AddCustomControl(batchFHelper);
            #endregion


            fHelper.PermissionControl(tbPlan.toolStrip1.Items, PermissionModuleEnum.ProdRecord.ToString());
            fHelper.PermissionControl(tbPlanNodes.toolStrip1.Items, PermissionModuleEnum.ProdRecord.ToString());

        }

        void statRollBack_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                Prod_Roads road = prInstance.GetCurrentNode(plan.PlanProd_PlanCode);
                plan.PlanProd_FStat = "Planing";

                Inv_Information inv = invInstance.GetInvByPlanCode(plan.PlanProd_PlanCode);
                inv.IInfor_Stat = road.PRoad_NodeCode;
                invInstance.Update(inv);

                Alert.Show("撤销完成！");

                RefreshPlanList();
            }
        }

        ProdHelper pHelper = new ProdHelper();

        /// <summary>
        /// 生产计划回滚
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rollbackProdBtn_Click(object sender, EventArgs e)
        {
            var row = uGridPlan.ActiveRow;
            if (Alert.ShowIsConfirm("您的操作不可回滚，确定要撤销当前选中的零件吗？"))
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                pHelper.RollBackProdPlan(plan);
                RefreshPlanList();

                QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().RollbackProd + "," + plan.PlanProd_Code
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdRecordModule.ToString(), QX.Common.LogType.Edit.ToString());


                Alert.Show("回滚完成!");
            }

        }

        void batchProdInfo_Click(object sender, EventArgs e)
        {
            BatchProdInfo prodInfo = new BatchProdInfo();
            prodInfo.ShowDialog();
        }

        void trashProdBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {

                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                if (!Alert.ShowIsConfirm(string.Format("您确定要作废零件编号为：{0}的零件吗？（您的操作将不可回滚!）", plan.PlanProd_Code)))
                {
                    return;
                }
                ppInstance.TrashProd(plan);

                QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdPlan + ",作废" + plan.PlanProd_Code
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdRecordModule.ToString(), QX.Common.LogType.Edit.ToString());


                RefreshPlanList();
            }
        }

        void batchFHelper_Click(object sender, EventArgs e)
        {
            UltraGridRow planrow = uGridPlan.ActiveRow;
            Prod_PlanProd plan = planrow.ListObject as Prod_PlanProd;
            if (plan.IInfor_ProdStat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
            {
                Alert.Show("当前生产产品正在不合格品审理流程中，不能更新其数据!");
                return;
            }

            List<Prod_Roads> list = new List<Prod_Roads>();

            foreach (UltraGridRow r in uGridPlanNodes.Selected.Rows)
            {
                Prod_Roads pr = r.ListObject as Prod_Roads;
                list.Add(pr);
            }

            BatchFHelper fhelperForm = new BatchFHelper(new Bll_FHelper_Info(), new FHelper_Info(), plan, list);
            fhelperForm.ShowDialog();
        }

        void txtFKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchFBtn_Click(null, null);
            }
        }
        //计划搜索
        void txtPlanKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPlanFBtn_Click(null, null);
            }
        }




        void batchChange_Click(object sender, EventArgs e)
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            var flag = GetGridCheckBoxDataForBatch(out list);
            if (flag)
            {

                if (list.Count == 0)
                {
                    Alert.Show("请选择要批量更新的零件!");
                    return;
                }

                BatchNodes bNodesFrm = new BatchNodes(list);
                bNodesFrm.CallBack += new BatchNodes.DCallBackHandler(bNodesFrm_CallBack);
                bNodesFrm.ShowDialog();
            }
        }

        void bNodesFrm_CallBack(bool result, Prod_Roads road)
        {
            if (road != null)
            {
                SetPlanStat(road.PRoad_NodeCode);
                uGridPlanNodeBind(road.PRoad_PlanCode);
            }
        }

        private void ProdRecordMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            //进行中的任务
            uGridTaskInit();
            //已完成
            //uGridFinPlanTaskInit();
            //计划列表
            uGridPlanInit();
            //工序列表
            uGridPlanNodeInit();

            TimeControlMapInit();
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

        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        private Bll_Prod_Record recordInstance = new Bll_Prod_Record();

        private Bll_FHelper_Info infoInstance = new Bll_FHelper_Info();


        private Bll_UserPermission upInstance = new Bll_UserPermission();

        #region 待处理生产任务 已完成任务

        private List<Prod_Task> CurDoingTaskDataSource = new List<Prod_Task>();

        private GridHandler _DoingTaskHandler;

        public GridHandler DoingTaskHandler
        {
            get { return _DoingTaskHandler; }
            set { _DoingTaskHandler = value; }
        }

        private Dictionary<string, string> _DoingTaskDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> DoingTaskDicColumn
        {
            get { return _DoingTaskDicColumn; }
            set { _DoingTaskDicColumn = value; }
        }

        UltraGrid uGridDoingTask = new UltraGrid();
        /// <summary>
        /// 生产任务关键字
        /// </summary>
        ToolStripTextBox txtFKey = new ToolStripTextBox();
        /// <summary>
        /// 生产计划关键字
        /// </summary>
        ToolStripTextBox txtPlanKey = new ToolStripTextBox();

        public string CurStat
        {
            get;
            set;
        }

        FormHelper fHelper = new FormHelper();


        #region 工具栏事件
        /// <summary>
        /// 批量接票人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void batchNodeTicket_Click(object sender, EventArgs e)
        {
            Bll_Dept bllDept = new Bll_Dept();
            Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
            CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> userTicket =
                new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
            userTicket.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(userTicket_CallBack);
            userTicket.ShowDialog();


        }
        /// <summary>
        /// 批量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="list"></param>
        void userTicket_CallBack(object sender, DataTable list)
        {
            if (list.Rows.Count == 1)
            {

                string user = list.Rows[0]["Emp_Code"] != null ? list.Rows[0]["Emp_Code"].ToString() : string.Empty;
                var rows = this.uGridPlanNodes.Selected.Rows;
                foreach (var row in rows)
                {
                    row.Cells["PRoad_RTicker"].Value = user;
                }

                IsEdit = true;
            }

        }


        /// <summary>
        /// 配对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void patchBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;

                if (plan.IInfor_ProdStat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
                {
                    Alert.Show("当前单据正在不合格审理流程中");
                    return;
                }

                if (plan.PlanProd_FStat == "Finish")
                {
                    Alert.Show("当前零件已完工，请重新选择!");
                    return;
                }

                ProdPatch patchFrm = new ProdPatch(plan);

                patchFrm.ShowDialog();

                GetPatchProd();
            }

        }

        void tbPlanNodes_PrintClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlanNodes.ActiveRow;
            if (row != null)
            {
                var list = GetGridCheckBoxData();

                Prod_Roads pr = row.ListObject as Prod_Roads;
                StringBuilder sb = new StringBuilder();
                string template="Proad_PlanCode in ({0}) ";
               
                foreach (var p in list)
                {
                    sb.Append("'").Append(p.PlanProd_PlanCode).Append("',");
                }
                var s = "Where "+ string.Format(template, sb.ToString().TrimEnd(','))+ " AND PRoad_NodeCode = '"+pr.PRoad_NodeCode+"'";

                string where = string.Format("");

                RptHourView rptView = new RptHourView(s);
                rptView.Show();
            }
        }

        /// <summary>
        /// 生产计划搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchPlanFBtn_Click(object sender, EventArgs e)
        {
            string key = txtPlanKey.Text;
            if (string.IsNullOrEmpty(key))
            {
                return;
            }
            //string begin = bDate.Value.ToString();
            //string end = eDate.Value.ToString();
            //var list = CurPlanDataSource.Where(o => (o.PlanProd_PartName != null && o.PlanProd_PartName.Contains(key)) || (o.PlanProd_PartNo != null && o.PlanProd_PartNo.Contains(key)) || (o.PlanProd_Code != null && o.PlanProd_Code.Contains(key)));
            var list = ppInstance.GetPlanProdListForSearch(key);
            this.uGridPlan.DataSource = list;
            if (list.Count == 0)
            {
                this.uGridPlanNodes.DataSource = new List<Prod_Roads>();
            }
            AddCustomColumn();
        }

        void tbPlan_RefreshClicked(object sender, EventArgs e)
        {
            RefreshPlanList();
        }

        void batchTimeUpdate_Click(object sender, EventArgs e)
        {
            var rows = uGridPlanNodes.Selected.Rows;
        }

        void rbnTask_Click(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Name == "Doing")
            {
                CurStat = "Doing";
                var list = recordInstance.GetDoingTask();
                RefreshDoingTaskGrid(list);
            }
            else
            {
                CurStat = "Fin";
                var list = ppInstance.GetFinishTaskList();
                RefreshDoingTaskGrid(list);
            }
        }

        void tbPlanNodes_SaveClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {

                List<Prod_Roads> list = new List<Prod_Roads>();

                foreach (UltraGridRow r in uGridPlanNodes.Rows)
                {
                    Prod_Roads road = r.ListObject as Prod_Roads;
                    list.Add(road);
                }

                prInstance.AddOrUpdatePRoads(list);

                IsEdit = false;
            }

            Alert.Show("数据更新完成!");
        }

        /// <summary>
        /// 批量完工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void batchCheck_Click(object sender, EventArgs e)
        {
            List<Prod_PlanProd> checkList = GetGridCheckBoxData();
            if (checkList != null && checkList.Count > 0)
            {

                if (Alert.ShowIsConfirm("确认批量完工勾选的数据吗?"))
                {
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdPlanFin
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdRecordModule.ToString(), QX.Common.LogType.Edit.ToString());

                    recordInstance.BatchCheck(checkList);
                    RefreshPlanList();
                    Alert.Show("数据更新完成!");
                }
            }
            else
            {
                Alert.Show("请勾选要批量质检的零件编号!");
            }
        }


        /// <summary>
        /// 获取批量质检勾选数据项
        /// </summary>
        /// <returns></returns>
        private List<Prod_PlanProd> GetGridCheckBoxData()
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            bool flag = false;
            foreach (UltraGridRow r in this.uGridPlan.DisplayLayout.Rows)
            {
                //过滤已配对的
                Prod_PlanProd d = r.ListObject as Prod_PlanProd;
                if (!string.IsNullOrEmpty(d.PlanProd_MPatchCode) && d.PlanProd_MPatchCode != d.PlanProd_PlanCode)
                {
                    continue;
                }
                //过滤不合格的
                if(d.IInfor_ProdStat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
                {
                    flag = true;
                    continue;
                }
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    //Prod_PlanProd planProd = r.ListObject as Prod_PlanProd;
                    list.Add(d);
                }
            }

            if (flag)
            {
                Alert.Show("您选择的产品列表当中有不合格产品请确认后重新选择!");
            }
            return list;
        }

        private bool GetGridCheckBoxDataForBatch(out List<Prod_PlanProd> list)
        {

            bool flag = true;
            list = new List<Prod_PlanProd>();
            UltraGridRow trow = this.uGridDoingTask.ActiveRow;
            Prod_Task task = trow.ListObject as Prod_Task;
            foreach (UltraGridRow r in this.uGridPlan.DisplayLayout.Rows)
            {
                //过滤已配对的
                Prod_PlanProd d = r.ListObject as Prod_PlanProd;


                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    //如果
                    if (!string.IsNullOrEmpty(d.PlanProd_Patch))
                    {
                        flag = false;
                        Alert.Show("您选择的零件产品中存在已配对的，请重新选择!");
                        break;
                    }
                    //如果为不合格品则不进行处理
                    if (d.IInfor_ProdStat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
                    {
                        flag = false;
                        Alert.Show("您选择的零件产品中存在不合格品，请重新选择!");
                        break;
                    }


                    if (d.PlanProd_TaskCode != task.Task_Code)
                    {
                        flag = false;
                        Alert.Show("您选择的零件产品不是同一个生产任务下面的不能进行批量更新，请重新选择!");
                        break;
                    }

                    if (d.PlanProd_FStat == "Finish")
                    {
                        flag = false;
                        Alert.Show("您选择的零件产品已完成工序，不需要在更新节点!");
                        break;

                    }
                    //Prod_PlanProd planProd = r.ListObject as Prod_PlanProd;
                    list.Add(d);
                }
            }
            return flag;
            //return list;
        }

        void tbPlaningTask_RefreshClicked(object sender, EventArgs e)
        {
            RefreshTaskGrid();
        }

        /// <summary>
        /// 任务搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchFBtn_Click(object sender, EventArgs e)
        {
            string key = txtFKey.Text;
            string begin = bDate.Value.ToString();
            string end = eDate.Value.ToString();
            string where = string.Format(" AND Task_Date between '{1}' and '{2}' AND ( TaskDetail_CmdCode like '%{0}%' OR Task_Name like '%{0}%' or Task_Code like '%{0}%'  or TaskDetail_PartName like '%{0}%' or TaskDetail_PartNo like '%{0}%')", key, begin, end);
            if (CurStat == "Doing")
            {
                List<Prod_Task> list = recordInstance.GetDoingTaskByWhere(where);

                uGridDoingTask.DataSource = list;
            }
            else
            {
                List<Prod_Task> list = recordInstance.GetFinTaskByWhere(where);

                uGridDoingTask.DataSource = list;
            }
        }
        #endregion

        /// <summary>
        /// 任务初始化
        /// </summary>
        public void uGridTaskInit()
        {
            DoingTaskHandler = new GridHandler(this.uGridDoingTask);

            uGridTaskDataBind();
            uGridDoingTaskEventInit();

            gen.SetExcelStyleFilter(uGridDoingTask);
        }

        private void uGridDoingTaskEventInit()
        {
            this.uGridDoingTask.BeforeRowDeactivate += new CancelEventHandler(uGridDoingTask_BeforeRowDeactivate);
            this.uGridDoingTask.AfterRowActivate += new EventHandler(uGridTask_AfterRowActivate);
        }

        void uGridDoingTask_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (IsEdit)
            {
                Alert.Show("请先保存工艺节点相关更改信息!");
                e.Cancel = true;
            }
        }

        void uGridTask_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridDoingTask.ActiveRow;
            if (row != null && row.Cells["Task_Code"].Value != null)
            {
                string taskCode = row.Cells["Task_Code"].Value.ToString();
                uGridPlanBind(taskCode);
            }
        }
        GridHelper gen = new GridHelper();
        /// <summary>
        /// 初始化绑定数据（生产中零件)
        /// </summary>
        public void uGridTaskDataBind()
        {
            string key = txtFKey.Text;
            string begin = bDate.Value.ToString();
            string end = eDate.Value.ToString();
            string where = string.Format(" AND Task_Date between '{1}' and '{2}' AND ( TaskDetail_CmdCode like '%{0}%' OR Task_Name like '%{0}%' or Task_Code like '%{0}%'  or TaskDetail_PartName like '%{0}%' or TaskDetail_PartNo like '%{0}%')", key, begin, end);
            CurDoingTaskDataSource = recordInstance.GetDoingTaskByWhere(where);



            uGridDoingTask = gen.GenerateGrid("GProdTask", this.panel1, new Point(0, 0));

            uGridDoingTask.DataSource = CurDoingTaskDataSource;

            DoingTaskHandler.SetGridEditMode(false, uGridDoingTask);
        }

        /// <summary>
        /// 刷新任务列表
        /// </summary>
        private void RefreshTaskGrid()
        {
            //string key = txtFKey.Text;
            //string where = string.Format(" AND (Task_Name like '%{0}%' or Task_Code like '%{0}%'  or TaskDetail_PartName like '%{0}%' or TaskDetail_PartNo like '%{0}%')", key);
            if (CurStat == "Doing")
            {
                List<Prod_Task> list = recordInstance.GetDoingTask();

                uGridDoingTask.DataSource = list;
            }
            else
            {
                List<Prod_Task> list = recordInstance.GetFinishTaskList();

                uGridDoingTask.DataSource = list;
            }
            //CurDoingTaskDataSource = recordInstance.GetDoingTask();
            //uGridDoingTask.DataSource = CurDoingTaskDataSource;
        }

        private void RefreshDoingTaskGrid(List<Prod_Task> list)
        {
            uGridDoingTask.DataSource = list;
        }

        #endregion

        #region 计划列表

        private List<Prod_PlanProd> CurPlanDataSource = new List<Prod_PlanProd>();

        private GridHandler _PlanHandler;

        public GridHandler PlanHandler
        {
            get { return _PlanHandler; }
            set { _PlanHandler = value; }
        }
        /// <summary>
        /// 计划列表
        /// </summary>
        UltraGrid uGridPlan = new UltraGrid();

        private Dictionary<string, string> PlanDicColumn = new Dictionary<string, string>();

        public void uGridPlanInit()
        {
            //有组合配对的产品
            //GetPatchProd();

            uGridPlanInitColumn();

            uGridPlanEventInit();
        }

        private List<Prod_PlanProd> PatchList
        {
            get;
            set;
        }
        /// <summary>
        /// 获取所有零件信息
        /// </summary>
        public void GetPatchProd()
        {
            //UltraGridRow row = this.uGridDoingTask.ActiveRow;
            //if (row != null)
            //{
            //    Prod_Task task = row.ListObject as Prod_Task;
            PatchList = ppInstance.GetPatchListByTask();
            //}

        }

        private bool isInit = true;

        private void AddCustomColumn()
        {
            //try
            //{


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
                col.CellClickAction = CellClickAction.EditAndSelectText;

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
                col.CellClickAction = CellClickAction.EditAndSelectText;
            }

            //}
            //catch (Exception ex)
            //{

            //}
        }


        private void uGridPlanEventInit()
        {
            this.uGridPlan.InitializeRow += new InitializeRowEventHandler(uGridPlan_InitializeRow);
            this.uGridPlan.AfterRowActivate += new EventHandler(uGridPlan_AfterRowActivate);
            this.uGridPlan.BeforeRowDeactivate += new CancelEventHandler(uGridPlan_BeforeRowDeactivate);
            this.uGridPlan.DoubleClickRow += new DoubleClickRowEventHandler(uGridPlan_DoubleClickRow);
        }

        void uGridPlan_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            if (IsEdit)
            {
                Alert.Show("请先保存工艺节点相关更改信息!");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 双击 弹出配对框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void uGridPlan_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            //patchBtn_Click(null, null);
        }

        void uGridPlan_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Prod_PlanProd plan = e.Row.ListObject as Prod_PlanProd;
            string pstat = plan.IInfor_ProdStat;
            if (pstat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
            {
                e.Row.Appearance.BackColor = Color.OrangeRed;
            }
            //如果产品已配对但没有出库 
            if (!string.IsNullOrEmpty(plan.PlanProd_Patch)&&plan.IInfor_Stat!="Outing")
            {
                e.Row.RowSelectorAppearance.Image = QX.Common.Properties.Resources.patch;
                if (plan.PlanProd_MPatchCode!=plan.PlanProd_PlanCode)
                {
                    plan.IInfor_Stat = "Patch";
                }
            }
        }

        public bool IsCanEdit(UltraGrid grid)
        {
            bool flag = true;

            UltraGridRow row = grid.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                string pstat = plan.IInfor_ProdStat;
                if (pstat == OperationTypeEnum.ProdStatEnum.Unqualified.ToString())
                {
                    //Alert.Show("当前生产产品正在不合格品审理流程中，不能更新其数据!");
                    //flag = false;
                }
                else if (pstat == OperationTypeEnum.ProdStatEnum.Defective.ToString())
                {
                    Alert.Show("当前生产产品已报废，不能更新其数据!");
                    flag = false;
                }//PlanProd_MPatchCode记录的是当前零件所在组件配对里面其主零件编号
                else if (!string.IsNullOrEmpty(plan.PlanProd_Patch) && plan.PlanProd_PlanCode != plan.PlanProd_MPatchCode)
                {
                    Alert.Show(string.Format("当前产品已组合配对!"));
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }
            return flag;

        }

        void uGridPlan_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;

            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;

                string planCode = plan.PlanProd_PlanCode;
                //工艺节点绑定
                uGridPlanNodeBind(planCode);

                //任务列表  事件关闭
                UltraGridRow taskRow = this.uGridDoingTask.ActiveRow;
                if (taskRow == null)
                {
                    return;
                }

                Prod_Task task = taskRow.ListObject as Prod_Task;
                if (task.Task_Code != plan.PlanProd_TaskCode)
                {
                    uGridDoingTask.EventManager.SetEnabled(EventGroups.AfterEvents, false);

                    foreach (var trow in uGridDoingTask.Rows)
                    {
                        Prod_Task temp = trow.ListObject as Prod_Task;
                        if (temp.Task_Code == plan.PlanProd_TaskCode)
                        {
                            trow.Activate();
                            trow.Selected = true;
                            break;
                        }
                    }

                    uGridDoingTask.EventManager.SetEnabled(EventGroups.AfterEvents, true);
                }



            }
        }

        private void uGridPlanStyleInit()
        {
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Begin"].Width = 100;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_End"].Width = 100;
        }

        /// <summary>
        /// 设置计划列表标题
        /// </summary>
        /// <param name="title"></param>
        private void SetPlanGridCaption(string title)
        {

            PlanHandler.SetGridCaption(title);
        }

        private void uGridPlanInitColumn()
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            GridHelper gen = new GridHelper();

            uGridPlan = gen.GenerateGrid("RGProdPlan", this.panel3, new Point(0, 0));

            uGridPlan.DataSource = list;

            gen.SetGridReadOnly(uGridPlan, true);

            uGridPlan.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;


        }

        /// <summary>
        /// 生产计划数据绑定
        /// </summary>
        /// <param name="taskCode"></param>
        public void uGridPlanBind(string taskCode)
        {
            CurPlanDataSource = ppInstance.GetPlanProdList(taskCode);

            uGridPlan.DataSource = CurPlanDataSource;

            if (CurPlanDataSource.Count == 0)
            {
                RefreshPlanNodeList(new List<Prod_Roads>());
            }
            isInit = false;
            AddCustomColumn();
        }


        private void RefreshPlanList(List<Prod_PlanProd> list)
        {
            isInit = false;
            this.uGridPlan.DataSource = list;
            AddCustomColumn();
        }

        private void RefreshPlanList()
        {
            UltraGridRow row = uGridDoingTask.ActiveRow;
            Prod_Task task = row.ListObject as Prod_Task;
            if (task != null)
            {
                CurPlanDataSource = ppInstance.GetPlanProdList(task.Task_Code);
                this.uGridPlan.DataSource = CurPlanDataSource;
                AddCustomColumn();
            }
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

        private List<string> FinishNodeList = new List<string>();

        private List<string> CheckNodeList = new List<string>();

        UltraGrid uGridPlanNodes = new UltraGrid();

        public void uGridPlanNodeInit()
        {
            PlanNodeHandler = new GridHandler(this.uGridPlanNodes);

            uGridPlanNodeInitColumn();
            uGridPlanNodeEventInit();
        }

        private void uGridPlanNodeEventInit()
        {
            this.uGridPlanNodes.InitializeRow += new InitializeRowEventHandler(uGridPlanNodes_InitializeRow);

            //点击部门  时间  等事件处理
            this.uGridPlanNodes.BeforeEnterEditMode += new CancelEventHandler(uGridPlanNodes_BeforeEnterEditMode);
            this.uGridPlanNodes.BeforeCellListDropDown += new CancelableCellEventHandler(uGridPlanNodes_BeforeCellListDropDown);
            this.uGridPlanNodes.CellChange += new CellEventHandler(uGridPlanNodes_CellChange);
        }

        private bool IsEdit = false;

        void uGridPlanNodes_BeforeCellListDropDown(object sender, CancelableCellEventArgs e)
        {
            var row = e.Cell.Row;
            Prod_Roads pr = row.ListObject as Prod_Roads;
            if (pr != null && pr.PRoad_IsFix == 1)
            {
                Alert.Show("当前工序已冻结,不能进行时间更新！");
                e.Cancel = true;
                return;
            }
            var cell = e.Cell;
            if (TimeControlMap.Contains(cell.Column.Key))
            {
                var t = e.Cell.Value.ToString();
                string time = string.Empty;
                if (!t.Contains("0001"))
                {
                    time = t;
                }

                TimeControl controlTime = new TimeControl(cell.Column.Key, time);
                controlTime.CallBack += new TimeControl.DCallBackHandler(userTimeSelect_CallBack);
                //controlTime.Location = new Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                controlTime.ShowWin(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        void uGridPlanNodes_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {

            UltraGridRow row = this.uGridPlanNodes.ActiveRow;
            Prod_Roads pr = row.ListObject as Prod_Roads;

            if (!IsCanEdit(this.uGridPlan))
            {
                e.Cancel = true;
            }
            else if (pr.PRoad_IsFix == 1)
            {
                Alert.Show("当前工序已冻结，不能进行数据更新!");
                e.Cancel = true;
            }
            else
            {
                UltraGridCell cell = this.uGridPlanNodes.ActiveCell;
                if (cell == null)
                {
                    return;
                }//接票人
                else if (cell.Column.Key == "PRoad_RTicker")
                {
                    Bll_Dept bllDept = new Bll_Dept();
                    Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
                    CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> user =
                        new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
                    user.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(user_CallBack);
                    user.ShowDialog();
                    e.Cancel = true;
                }//确认人
                else if (cell.Column.Key == "PRoad_ConfirmPep")
                {
                    Bll_Dept bllDept = new Bll_Dept();
                    Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
                    CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> user =
                        new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
                    user.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(user_CallBack);
                    user.ShowDialog();
                    e.Cancel = true;
                }//当前节点
                else if (cell.Column.Key == "PRoad_IsCurrent")
                {
                    if (cell.Value.ToString() == "1")
                    {
                        e.Cancel = true;
                        return;
                    }
                    if (Alert.ShowIsConfirm("确定设置当前工件的生产状态吗?"))
                    {

                        Prod_Roads newNode = row.ListObject as Prod_Roads;
                        Prod_Roads oldNode = null;
                        foreach (var r in this.uGridPlanNodes.Rows)
                        {
                            var val = r.Cells["PRoad_IsCurrent"].Value;
                            EmbeddableEditorBase editor = r.Cells["PRoad_IsCurrent"].EditorResolved;
                            object isCurrent = editor.IsValid ? editor.Value : editor.CurrentEditText;

                            if (val.ToString() == "1" || isCurrent.ToString() == "1")
                            {
                                oldNode = r.ListObject as Prod_Roads;
                                oldNode.PRoad_IsCurrent = 0;
                                r.Cells["PRoad_IsDone"].Value = true;
                            }

                            r.Cells["PRoad_IsCurrent"].Value = 0;
                            editor.Value = 0;
                        }


                        //设置当前点击节点为当前所处工序
                        row.Cells["PRoad_IsCurrent"].Value = 1;
                        row.Cells["PRoad_ActRTime"].Value = DateTime.Now;

                        //设置当前节点状态
                        prInstance.SetCurrentNode(oldNode, newNode);
                        SetPlanStat(newNode.PRoad_NodeCode);

                        //判断是否需要外协
                        //var nextNode = recordInstance.GetNextNode(pr);

                        if (newNode.PRoad_IsCurrent == 1 && newNode != null && newNode.PRoad_NodeDepCode == GlobalConfiguration.MarketDept)
                        {
                            Alert.Show("工艺节点:" + newNode.PRoad_NodeName + "将进入外协处理流程,请联系相关人员进行处理!");

                            recordInstance.EnterFHelper(newNode);
                        }

                        //刷新工艺节点
                        uGridPlanNodeBind(pr.PRoad_PlanCode);
                    }

                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// 设置选中的计划的当前对应的节点状态
        /// </summary>
        public void SetPlanStat(string stat)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                row.Cells["IInfor_Stat"].Value = stat;
            }
        }

        private void userTimeSelect_CallBack(string key, object val)
        {
            UltraGridRow row = this.uGridPlanNodes.ActiveRow;
            if (row != null && row.Cells.Exists(key))
            {
                row.Cells[key].Value = val;
                IsEdit = true;
                switch (key)
                {
                    //长票交接时间
                    case "PRoad_ActCTime":
                        {
                            //长票交接时间
                            int count = this.uGridPlanNodes.Rows.Count;
                            int i = row.Index;
                            if (i + 1 < count)
                            {
                                UltraGridRow nRow = uGridPlanNodes.Rows[i + 1];
                                Prod_Roads road = nRow.ListObject as Prod_Roads;
                                if (!road.PRoad_IsDone)
                                {
                                    //默认下一长票交接时间为当前节点上交时间
                                    nRow.Cells["PRoad_ActRTime"].Value = val;
                                }
                            }

                            break;
                        }
                    case "PRoad_ActBTime":
                        {
                            Prod_Roads road = row.ListObject as Prod_Roads;

                            DateTime bDate = road.PRoad_ActBTime;
                            DateTime eDate = road.PRoad_ActETime;

                            TimeSpan ts = eDate - bDate;
                            //if (ts.TotalHours > 0)
                            //{
                            row.Cells["PRoad_CostTime"].Value = ts.TotalHours;
                            //}
                            TimeUpdate(road, row);
                            break;

                        }//实际完工时间
                    case "PRoad_ActETime":
                        {
                            Prod_Roads road = row.ListObject as Prod_Roads;

                            DateTime bDate = road.PRoad_ActBTime;
                            DateTime eDate = road.PRoad_ActETime;

                            TimeSpan ts = eDate - bDate;
                            //if (ts.TotalHours > 0)
                            //{
                            //实际工作时间 
                            double hour = ts.TotalHours;
                            row.Cells["PRoad_CostTime"].Value = ts.TotalHours;
                            //}
                            TimeUpdate(road, row);
                            break;
                        }//实际开工时间
                }


            }
        }

        public void TimeUpdate(Prod_Roads pr, UltraGridRow row)
        {
            //实际工时
            decimal actTime = pr.PRoad_CostTime;
            //额定工时
            decimal templateTime = pr.PRoad_TimeCost;
            if (actTime == 0)
            {
                row.Cells["PRoad_Udef1"].Value = templateTime;
            }//额定工时间-实际工作时间
            else if ((actTime - templateTime) > 0)
            {
                UltraGridCell tempCell = row.Cells["PRoad_Udef1"];
                tempCell.Value = actTime - templateTime;
                tempCell.Appearance.BackColor = Color.Red;
            }
            else if ((actTime - templateTime) <= 0)
            {
                UltraGridCell tempCell = row.Cells["PRoad_Udef1"];
                tempCell.Value = actTime - templateTime;
                tempCell.Appearance.BackColor = Color.Green;
            }
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="list"></param>
        private void user_CallBack(object sender, DataTable list)
        {
            if (list == null)
            {
                UltraGridCell cell = this.uGridPlanNodes.ActiveCell;

                if (cell != null)
                {
                    cell.Value = string.Empty;
                    IsEdit = true;
                }
            }
            else if (list.Rows.Count == 1)
            {

                UltraGridCell cell = this.uGridPlanNodes.ActiveCell;

                if (cell != null)
                {
                    cell.Value = list.Rows[0]["Emp_Code"] != null ? list.Rows[0]["Emp_Code"].ToString() : string.Empty;
                    IsEdit = true;
                }
            }
        }

        void uGridPlanNodes_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            UltraGridRow row = e.Row;

            Prod_Roads pr = row.ListObject as Prod_Roads;
            //是否已完成
            UltraGridCell aCell = row.Cells["PRoad_IsDone"];
            //是否已质检
            UltraGridCell cCell = row.Cells["PRoad_IsQuality"];

            if (aCell.Value != null)
            {
                FinishNodeList.Add(row.Cells["PRoad_NodeCode"].Value.ToString());
            }

            if (cCell.Value != null)
            {
                CheckNodeList.Add(row.Cells["PRoad_NodeCode"].Value.ToString());
            }
            //实际工时
            decimal actTime = pr.PRoad_CostTime;
            //额定工时
            decimal templateTime = pr.PRoad_TimeCost;
            if (actTime == 0)
            {

            }//额定工时间-实际工作时间
            else if ((actTime - templateTime) > 0)
            {
                UltraGridCell tempCell = row.Cells["PRoad_Udef1"];
                tempCell.Value = actTime - templateTime;
                tempCell.Appearance.BackColor = Color.Red;
            }
            else if ((actTime - templateTime) <= 0)
            {
                UltraGridCell tempCell = row.Cells["PRoad_Udef1"];
                tempCell.Value = actTime - templateTime;
                tempCell.Appearance.BackColor = Color.Green;
            }
            //if (pr.PRoad_NodeDepCode == GlobalConfiguration.MarketDept)
            //{

            //    MethodInvoker mi = delegate
            //    {
            //        Bll_FHelper_Info fin = new Bll_FHelper_Info();
            //        var info = fin.GetModel(string.Format(" AND FHelperInfo_ProdCode='{0}' AND FHelperInfo_RoadNodes='{1}'", pr.PRoad_ProdCode, pr.PRoad_NodeCode));

            //        if (info == null)
            //        {

            //            recordInstance.EnterFHelper(pr);
            //        }
            //    };

            //    mi.BeginInvoke(null, null);

            //}

        }

        void uGridPlanNodes_CellChange(object sender, CellEventArgs e)
        {
            switch (e.Cell.Column.Key)
            {
                #region PRoad_IsDone
                case "PRoad_IsDone":
                    {
                        EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        object changedValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        bool flag = QX.Common.C_Class.Utils.TypeConverter.StrToBool(changedValue.ToString(), false);
                        //设置已完成
                        if (flag)
                        {
                            DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "设置完成后，将不能回滚事务，确定设置完成吗？");
                            if (dialog == DialogResult.OK)
                            {
                                FinishNodeList.Add(e.Cell.Row.Cells["PRoad_NodeCode"].Value.ToString());

                                //设置交接时间 
                                e.Cell.Row.Cells["PRoad_ActCTime"].Value = DateTime.Now;

                                Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;

                                recordInstance.SetProdNodeFinish(pr);



                                //判断是否需要外协
                                var nextNode = recordInstance.GetNextNode(pr);

                                if (nextNode != null && nextNode.PRoad_NodeDepCode == GlobalConfiguration.MarketDept)
                                {
                                    Alert.Show("下一工艺:" + nextNode.PRoad_NodeName + "将进入外协处理流程,请联系相关人员进行处理!");

                                    recordInstance.EnterFHelper(nextNode);
                                }

                                //刷新工艺节点
                                uGridPlanNodeBind(pr.PRoad_PlanCode);
                            }
                            else
                            {
                                this.uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                                editor.Value = false;
                                e.Cell.Value = false;
                                uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);

                            }

                        }
                        else
                        {
                            //如果在已完成列表则不能回滚
                            if (FinishNodeList.Contains(e.Cell.Row.Cells["PRoad_NodeCode"].Value.ToString()))
                            {
                                this.uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                                editor.Value = true;
                                e.Cell.Value = true;
                                uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);
                            }
                        }
                        break;
                    }
                #endregion
                #region PRoad_IsQuality
                case "PRoad_IsQuality":
                    {
                        EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        object changedValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        bool flag = QX.Common.C_Class.Utils.TypeConverter.StrToBool(changedValue.ToString(), false);
                        if (flag)
                        {
                            DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "设置已质检后，将不能回滚事务，确定设置已质检吗？");
                            if (dialog == DialogResult.OK)
                            {

                                Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;

                                SetNodeChecked CheckNodeFrm = new SetNodeChecked(pr);

                                DialogResult result = MessageBox.Show("当前工序是否检测合格?", "质检确认", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                                if (result == DialogResult.Yes)
                                {
                                    //设置合格

                                    MethodInvoker mi = delegate
                                    {
                                        recordInstance.SetProdNodeChecked(true, pr);
                                    };
                                    mi.BeginInvoke(null, null);
                                    CheckNodeList.Add(e.Cell.Row.Cells["PRoad_NodeCode"].Value.ToString());

                                    Alert.Show("数据更新成功!");
                                }
                                else if (result == DialogResult.No)
                                {
                                    //刷新计划列表数据
                                    UltraGridRow row = this.uGridPlan.ActiveRow;
                                    if (row != null)
                                    {
                                        var plan = row.ListObject as Prod_PlanProd;
                                        plan.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
                                        row.Cells["IInfor_ProdStat"].Value = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();

                                        row.Selected = true;
                                        row.Activate();
                                    }

                                    //库存表更细状态
                                    Failure_Information fi = recordInstance.SetProdNodeChecked(false, pr);
                                    if (fi != null)
                                    {
                                        FailureOp FailureFrm = new FailureOp(new Bll_Failure_Information(), fi);
                                        FailureFrm.OperationType = OperationTypeEnum.OperationType.Edit;
                                        FailureFrm.ShowDialog();
                                        Alert.Show("单据进入不合格品审理流程!");

                                    }

                                    //Alert.Show("单据进入不合格品审理流程!");
                                    RefreshPlanNodeList();

                                }
                                else
                                {
                                    this.uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                                    editor.Value = false;
                                    e.Cell.Value = false;
                                    uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);


                                }


                            }
                            else
                            {

                                this.uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                                editor.Value = false;
                                e.Cell.Value = false;
                                uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);

                            }

                        }
                        else
                        {
                            //如果在已完成列表则不能回滚
                            if (CheckNodeList.Contains(e.Cell.Row.Cells["PRoad_NodeCode"].Value.ToString()))
                            {
                                this.uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                                editor.Value = true;
                                e.Cell.Value = true;
                                uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);
                            }
                        }
                        break;
                    }
                #endregion
                #region PRoad_NodeDepCode
                case "PRoad_NodeDepCode":
                    {
                        if (e.Cell.Value != null)
                        {
                            var curNode = e.Cell.Row.ListObject as Prod_Roads;
                            if (curNode.PRoad_IsCurrent == 1 && curNode != null && curNode.PRoad_NodeDepCode == GlobalConfiguration.MarketDept)
                            {
                                Alert.Show("工艺节点:" + curNode.PRoad_NodeName + "将进入外协处理流程,请联系相关人员进行处理!");

                                recordInstance.EnterFHelper(curNode);
                                IsEdit = true;
                            }
                        }
                        else
                        {

                        }

                        break;
                    }
                #endregion
                //长票交接时间
                //case "PRoad_ActCTime":
                //    {
                //        //长票交接时间
                //        int count = this.uGridPlanNodes.Rows.Count;
                //        int i = e.Cell.Row.Index;
                //        if (i + 1 < count)
                //        {
                //            UltraGridRow nRow = uGridPlanNodes.Rows[i + 1];
                //            Prod_Roads road = nRow.ListObject as Prod_Roads;
                //            if (!road.PRoad_IsDone)
                //            {
                //                nRow.Cells["PRoad_ActRTime"].Value = e.Cell.Value;
                //            }
                //        }

                //        break;
                //    }
                //case "PRoad_ActBTime":
                //    {
                //        Prod_Roads road = e.Cell.Row.ListObject as Prod_Roads;

                //        DateTime bDate = road.PRoad_ActBTime;
                //        DateTime eDate = road.PRoad_ActETime;

                //        TimeSpan ts = eDate - bDate;
                //        if (ts.TotalHours > 0)
                //        {
                //            e.Cell.Row.Cells["PRoad_CostTime"].Value = ts.TotalHours;
                //        }
                //        break;

                //    }
                //case "PRoad_ActETime":
                //    {
                //        Prod_Roads road = e.Cell.Row.ListObject as Prod_Roads;

                //        DateTime bDate = road.PRoad_ActBTime;
                //        DateTime eDate = road.PRoad_ActETime;

                //        TimeSpan ts = eDate - bDate;
                //        if (ts.TotalHours > 0)
                //        {
                //            double hour = ts.TotalHours;
                //            //double minute = ts.Minutes;
                //            e.Cell.Row.Cells["PRoad_CostTime"].Value = ts.TotalHours;
                //        }

                //        break;
                //    }
            }


            IsEdit = true;
        }

        void CheckNodeFrm_CallBack(bool re, Prod_Roads pr, List<Road_TestRef> list)
        {
            //true 合格
            if (re)
            {
                //设置合格

                MethodInvoker mi = delegate
                {
                    recordInstance.SetProdNodeChecked(true, pr, list);
                };
                mi.BeginInvoke(null, null);

                Alert.Show("数据更新成功!");
            }
            else//不合格处理
            {

                //刷新计划列表数据
                UltraGridRow row = this.uGridPlan.ActiveRow;
                if (row != null)
                {
                    var plan = row.ListObject as Prod_PlanProd;
                    plan.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
                    row.Cells["IInfor_ProdStat"].Value = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();

                    row.Selected = true;
                    row.Activate();
                }

                MethodInvoker mi = delegate
                {
                    //库存表更细状态
                    recordInstance.SetProdNodeChecked(false, pr, list);
                    //进入不合格品流程
                };
                mi.BeginInvoke(null, null);

                Alert.Show("单据进入不合格品审理流程!");
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
                                Alert.Show("该工序已经入外协处理流程，请联系相关人员处理!");
                            }
                            IsEdit = true;
                        }
                    }
                    else
                    {
                        row.Cells["PRoad_NodeDepName"].Value = list.Rows[0]["Dept_Name"].ToString();
                        row.Cells["PRoad_NodeDepCode"].Value = list.Rows[0]["Dept_Code"].ToString();
                        Prod_Roads pr2 = row.ListObject as Prod_Roads;
                        prInstance.UpdateDept(pr2, 0);
                        IsEdit = true;

                    }
                }
            }
        }

        private void uGridPlanNodeStyleInit()
        {
            this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_IsDone"].CellClickAction = CellClickAction.Edit;
            this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_IsQuality"].CellClickAction = CellClickAction.Edit;
            this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_IsCurrent"].CellClickAction = CellClickAction.Edit;
            ////接票人
            //this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_RTicker"].CellClickAction = CellClickAction.Edit;
            ////实际开始时间
            //this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActBTime"].CellClickAction = CellClickAction.Edit;
            ////实际完工时间
            //this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActETime"].CellClickAction = CellClickAction.Edit;
            //工票上交时间
            this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActCTime"].CellClickAction = CellClickAction.Edit;
            this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_CostTime"].CellClickAction = CellClickAction.Edit;

            List<Sys_Map> list = new Bll_Sys_Map().GetListByCode(string.Format(" AND Map_Module='PRecordPermission'"));

            //权限配置
            foreach (var d in list)
            {
                ///工票回收权限
                if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, d.Map_Object1))
                {
                    this.uGridPlanNodes.DisplayLayout.Bands[0].Columns[d.Map_Object2].CellClickAction = CellClickAction.Edit;
                }
                else
                {
                    this.uGridPlanNodes.DisplayLayout.Bands[0].Columns[d.Map_Object2].CellClickAction = CellClickAction.RowSelect;
                }
            }

            ///工票回收权限
            if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, "TicketReceiver"))
            {
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_Receiver"].CellClickAction = CellClickAction.Edit;
            }
            else
            {
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_Receiver"].CellClickAction = CellClickAction.RowSelect;
            }
            //生产信息权限
            if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, "ProdInfo"))
            {

                //生产设备、操作人员、实际开工时间、实际完工时间
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_EquCode"].CellActivation = Activation.AllowEdit;
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActBTime"].CellActivation = Activation.AllowEdit;
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActETime"].CellActivation = Activation.AllowEdit;
                //操作人
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ConfirmPep"].CellActivation = Activation.AllowEdit;
            }
            else
            {
                //生产设备、操作人员、实际开工时间、实际完工时间
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_EquCode"].CellActivation = Activation.NoEdit;
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActBTime"].CellActivation = Activation.NoEdit;
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ActETime"].CellActivation = Activation.NoEdit;
                //操作人
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_ConfirmPep"].CellActivation = Activation.NoEdit;
            }
            //接票人权限
            if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, "RTicket"))
            {
                //接票人
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_RTicker"].CellActivation = Activation.AllowEdit;
            }
            else
            {
                //接票人
                this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["PRoad_RTicker"].CellActivation = Activation.NoEdit;
            }
            ////当前节点
            //if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, "Proad_IsCurrent"))
            //{
            //    //接票人
            //    this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["Proad_IsCurrent"].CellActivation = Activation.AllowEdit;
            //}
            //else
            //{
            //    //接票人
            //    this.uGridPlanNodes.DisplayLayout.Bands[0].Columns["Proad_IsCurrent"].CellActivation = Activation.NoEdit;
            //}

        }

        private void uGridPlanNodeInitColumn()
        {
            GridHelper gen = new GridHelper();

            List<Prod_Roads> list = new List<Prod_Roads>();

            uGridPlanNodes = gen.GenerateGrid("GRProdRoads", this.panel4, new Point(0, 0));

            uGridPlanNodes.DataSource = list;

            PlanNodeHandler.SetGridEditMode(false, uGridPlanNodes);
            uGridPlanNodes.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
        }

        public void uGridPlanNodeBind(string planCode)
        {
            if (string.IsNullOrEmpty(planCode))
            {
                uGridPlanNodes.DataSource = new List<Prod_Roads>();

            }
            else
            {
                CurPlanNodeDataSource = prInstance.GetPlanRoadList(planCode);

                uGridPlanNodes.DataSource = CurPlanNodeDataSource;


            }
            uGridPlanNodeStyleInit();
        }

        /// <summary>
        /// 刷新节点
        /// </summary>
        private void RefreshPlanNodeList()
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                Prod_PlanProd plan = row.ListObject as Prod_PlanProd;
                CurPlanNodeDataSource = prInstance.GetPlanRoadList(plan.PlanProd_PlanCode);

                uGridPlanNodes.DataSource = CurPlanNodeDataSource;

                uGridPlanNodeStyleInit();
            }
        }


        /// <summary>
        /// 清楚接票时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void nodeClrBtn_Click(object sender, EventArgs e)
        {
            //UltraGridCell cell = this.uGridPlanNodes.ActiveCell;
            UltraGridRow aRow = this.uGridPlanNodes.ActiveRow;
            if (aRow != null)
            {
                var cell = aRow.Cells["PRoad_ActRTime"];
                //var aRow = cell.Row;
                var road = aRow.ListObject as Prod_Roads;
                //if (!road.PRoad_IsDone)
                //{
                this.uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                aRow.Cells["PRoad_ActRTime"].Value = "0001-1-1";
                uGridPlanNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);

                //}
            }
        }

        /// <summary>
        /// 刷新工艺节点列表
        /// </summary>
        /// <param name="list"></param>
        private void RefreshPlanNodeList(List<Prod_Roads> list)
        {
            uGridPlanNodes.DataSource = list;
        }

        #endregion
    }
}
