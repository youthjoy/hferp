using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;

namespace QX.Plugin.Prod
{
    public partial class AjustProdPlan : F_BasicPop
    {
        public AjustProdPlan()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="templatePlanProd">批量更新的模板计划</param>
        /// <param name="list">需要批量更新的计划列表</param>
        public AjustProdPlan(Prod_PlanProd templatePlanProd, List<Prod_PlanProd> list)
        {
            InitializeComponent();

            PlanProdList = list;
            TemplatePlan = templatePlanProd;

            BindEvent();
        }

        private void BindEvent()
        {
            ToolStripButton nodesButton = new ToolStripButton();
            nodesButton.Text = "工序调整";
            Image image1 = global::QX.Common.Properties.Resources.nodes;　　　　//从资源文件中引用
            nodesButton.Image = image1;
            nodesButton.Size = new Size(43, 28);
            nodesButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            nodesButton.TextImageRelation = TextImageRelation.ImageAboveText;
            nodesButton.Click += new EventHandler(nodesButton_Click);
            this.tbPRoads.AddCustomControl(nodesButton);


            ToolStripButton scheduleButton = new ToolStripButton();
            scheduleButton.Text = "全部更新";
            Image image2 = global::QX.Common.Properties.Resources.schedule;　　　　//从资源文件中引用
            scheduleButton.Image = image2;
            scheduleButton.Size = new Size(43, 28);
            scheduleButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            scheduleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            scheduleButton.Click += new EventHandler(scheduleButton_Click);
            this.tbPRoads.AddCustomControl(scheduleButton);

            ToolStripButton autoScheduleButton = new ToolStripButton();
            autoScheduleButton.Text = "自动排期";
            Image image4 = global::QX.Common.Properties.Resources.schedule;　　　　//从资源文件中引用
            autoScheduleButton.Image = image4;
            autoScheduleButton.Size = new Size(43, 28);
            autoScheduleButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            autoScheduleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            autoScheduleButton.Click += new EventHandler(autoScheduleButton_Click);
            this.tbPRoads.AddCustomControl(autoScheduleButton);

        }

        void autoScheduleButton_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPRoads.ActiveRow;
            UltraGridCell aCell = this.uGridPRoads.ActiveCell;
            if (row != null)
            {
                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定自动更新当前选中节点之后的节点排期?");

                if (dialog == DialogResult.OK)
                {
                    //UltraGridColumn column = aCell.Column;
                    if (aCell!= null)
                    {
                        EmbeddableEditorBase editor = aCell.EditorResolved;
                        object changeValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        aCell.Value = changeValue;
                    }

                    Prod_Roads pr = row.ListObject as Prod_Roads;



                    CurPlanNodeDataSource = prInstance.IncrementalAjustPlanRoadsWithNoSubmit(pr, CurPlanNodeDataSource);

                    RefreshPlanNodeList(CurPlanNodeDataSource);

                    //uGridPlanNodeBind(pr.PRoad_PlanCode);
                }
            }
        }

        //public List<Prod_Roads> FilterData(Prod_Roads pr,List<Prod_Roads> list)
        //{


        //    Predicate<Prod_Roads> math = delegate(Prod_Roads p) { return p.PRoad_Order >= pr.PRoad_Order; };
        //    List<Prod_Roads> filterData = CollectionHelper.Filter<Prod_Roads>(list, math);
        //    return filterData;
        //}

        void scheduleButton_Click(object sender, EventArgs e)
        {
            //当前对应生产计划

            CurPlanNodeDataSource = prInstance.AjustPlanRoadsTimeCostWithNoSubmit(CurPlanNodeDataSource, PlanProdList[0].PlanProd_Begin);
            RefreshPlanNodeList(CurPlanNodeDataSource);
            //this.u(prodPlan.PlanProd_PlanCode);

        }

        void nodesButton_Click(object sender, EventArgs e)
        {

            //if (this.uGridPRoads.Rows.Count != 0)
            //{
                Dictionary<string, int> nodeDic = new Dictionary<string, int>();
                Dictionary<string, string> timeCostDic = new Dictionary<string, string>();

                ////foreach (Prod_Roads r in CurPlanNodeDataSource)
                ////{
                ////    nodeDic.Add(r.PRoad_NodeCode, r.PRoad_Order);

                ////    timeCostDic.Add(r.PRoad_NodeCode, r.PRoad_TimeCost.ToString());
                ////}
                CommRoadNodes frm = new CommRoadNodes();

                frm.ShowDialog();

                if (frm.IsChanged && frm.CurNodeDict != null && frm.CurNodeTimeCostDict != null)
                {
                    var list = prInstance.AddOrUpdatePlanRoadsWithNoSubmit(CurPlanNodeDataSource, frm.CurNodeDict, frm.CurNodeTimeCostDict);
                    CurPlanNodeDataSource = list;
                    uGridPRoads.DataSource = list;
                    uGridPRoads.Refresh();
                }
            //}
        }

        private void AjustProdPlan_Load(object sender, EventArgs e)
        {
            uGridPlanNodeInit();
        }

        public delegate void DCallBackHandler(List<Prod_PlanProd> planList, List<Prod_Roads> prList);
        public event DCallBackHandler CallBack;

        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();


        //private string RoadCompCode = string.Empty;

        private List<Prod_PlanProd> PlanProdList = new List<Prod_PlanProd>();

        private List<Prod_Roads> CurPlanNodeDataSource = new List<Prod_Roads>();

        //部门选择处理Handler
        private Bll_Dept deptInstance = new Bll_Dept();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private Prod_PlanProd TemplatePlan = new Prod_PlanProd();

        private GridHandler _PlanNodeHandler;

        public GridHandler PlanNodeHandler
        {
            get { return _PlanNodeHandler; }
            set { _PlanNodeHandler = value; }
        }

        private Dictionary<string, string> PlanNodeDicColumn = new Dictionary<string, string>();


        public void uGridPlanNodeInit()
        {
            PlanNodeHandler = new GridHandler(this.uGridPRoads);

            uGridPlanNodeInitColumn();

            uGridPlanNodeBindForTemplate();

            uGridPRoadstyleInit();

            uGridPlanNodeEventInit();
        }


        private void uGridPlanNodeEventInit()
        {
            //点击部门  时间  等事件处理
            this.uGridPRoads.BeforeEnterEditMode += new CancelEventHandler(uGridPRoads_BeforeEnterEditMode);

            //this.uGridPRoads.CellChange += new CellEventHandler(uGridPRoads_CellChange);
        }

        void uGridPRoads_CellChange(object sender, CellEventArgs e)
        {          //如果选择了时间控件

            switch (e.Cell.Column.Key)
            {
                case "PRoad_Begin":
                    {
                        //UltraGridColumn column = e.Cell.Column;
                        //EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        //object beginValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        //e.Cell.Value = beginValue;
                        //Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;
                        //pr.PRoad_Begin = DateTime.Parse(beginValue.ToString());
                        //prInstance.Update(pr);
                        break;
                    }
                case "PRoad_End":
                    {
                        //UltraGridColumn column = e.Cell.Column;
                        //EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        //object endValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        //e.Cell.Value = endValue;
                        //Prod_Roads pr = e.Cell.Row.ListObject as Prod_Roads;
                        //pr.PRoad_End = DateTime.Parse(endValue.ToString());
                        //prInstance.Update(pr);
                        break;
                    }
            }


        }


        void uGridPRoads_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell aCell = this.uGridPRoads.ActiveCell;
            if (aCell != null)
            {
                Prod_Roads pr = this.uGridPRoads.ActiveRow.ListObject as Prod_Roads;
                switch (aCell.Column.Key)
                {
                    case "PRoad_NodeDepName":
                        e.Cancel = true;
                        CommDept<Bll_Dept, Bse_Department> CommDept = new CommDept<Bll_Dept, Bse_Department>(deptInstance,
               new Size(350, 350));
                        CommDept.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(CommDept_CallBack);
                        CommDept.ShowDialog();

                        break;
                    case "PRoad_EquName":
                        e.Cancel = true;
                        break;
                }
            }


            //MessageBox.Show(pr.PRoad_NodeName);
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

                UltraGridRow row = this.uGridPRoads.ActiveRow;

                if (row != null)
                {
                    Prod_Roads pr = row.ListObject as Prod_Roads;
                    if (prInstance.IsNeedFHelper(list.Rows[0]["Dept_Code"].ToString()))
                    {
                        //问题：如果进入外协流程，是否换可以编辑相关信息
                        DialogResult diaolog = Alert.Show(MessageBoxButtons.OK, "是否需要外协?");
                        if (diaolog == DialogResult.OK)
                        {
                            row.Cells["PRoad_NodeDepName"].Value = list.Rows[0]["Dept_Name"].ToString();
                            row.Cells["PRoad_NodeDepCode"].Value = list.Rows[0]["Dept_Code"].ToString();
                            Prod_Roads pr1 = row.ListObject as Prod_Roads;
                            prInstance.UpdateDept(pr1, 1);
                        }
                    }
                    else
                    {
                        row.Cells["PRoad_NodeDepName"].Value = list.Rows[0]["Dept_Name"].ToString();
                        row.Cells["PRoad_NodeDepCode"].Value = list.Rows[0]["Dept_Code"].ToString();
                        Prod_Roads pr2 = row.ListObject as Prod_Roads;
                        prInstance.UpdateDept(pr2, 0);
                    }



                    //当前行对应工艺节点编码
                    //string tmpCode = row.Cells["RNodes_Code"].Value.ToString();
                    //更新该工艺对应部门信息
                    //rnInstance.UpdateDept(RoadComptCode, tmpCode, list.Rows[0]["Dept_Code"].ToString(), list.Rows[0]["Dept_Name"].ToString());


                }
            }
        }

        private void uGridPRoadstyleInit()
        {
            this.uGridPRoads.DisplayLayout.Bands[0].Columns["PRoad_NodeDepName"].CellClickAction = CellClickAction.Edit;
            this.uGridPRoads.DisplayLayout.Bands[0].Columns["PRoad_EquName"].CellClickAction = CellClickAction.Edit;

            this.uGridPRoads.DisplayLayout.Bands[0].Columns["PRoad_Begin"].Width = 110;
            this.uGridPRoads.DisplayLayout.Bands[0].Columns["PRoad_End"].Width = 110;
        }


        UltraGrid uGridPRoads = new UltraGrid();

        private void uGridPlanNodeInitColumn()
        {
            GridHelper gen = new GridHelper();

            uGridPRoads = gen.GenerateGrid("AGProdRoads", this.panel1, new Point(0, 0));
            List<Prod_Roads> list=new List<Prod_Roads>();
            uGridPRoads.DataSource = list;
            gen.SetGridColumnStyle(uGridPRoads, AutoFitStyle.ExtendLastColumn);

            uGridPRoads.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

            //PlanNodeDicColumn.Add("PRoad_NodeDepName", "生产部门");
            //PlanNodeDicColumn.Add("PRoad_NodeName", "工序名称");
            //PlanNodeDicColumn.Add("PRoad_Begin", "计划开工");
            //PlanNodeDicColumn.Add("PRoad_End", "计划完工");
            //PlanNodeDicColumn.Add("PRoad_EquCode", "生产设备编号");
            //PlanNodeDicColumn.Add("PRoad_EquName", "生产设备名称");
            //PlanNodeDicColumn.Add("PRoad_Owner", "编制人");
            //PlanNodeDicColumn.Add("PRoad_Date", "编制时间");
            //PlanNodeDicColumn.Add("PRoad_Bak", "备注");
            //PlanNodeHandler.BindData(CurPlanNodeDataSource, PlanNodeDicColumn);
        }
        /// <summary>
        /// 此方法仅初始化使用
        /// </summary>
        public void uGridPlanNodeBindForTemplate()
        {
            //当前零件图号对应工艺路线模板--->默认选择的第一个生产计划为批量调整工艺路线模板开始时间
            //CurPlanNodeDataSource = prInstance.GetTemplateProdRoadsByComptCode(RoadCompCode, PlanProdList[0].PlanProd_Begin);
            CurPlanNodeDataSource = prInstance.GetPlanRoadList(TemplatePlan.PlanProd_PlanCode);
            uGridPRoads.DataSource = CurPlanNodeDataSource;
        }


        private void RefreshPlanNodeList(List<Prod_Roads> list)
        {
            uGridPRoads.DataSource = list;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Prod_Roads> prList = new List<Prod_Roads>();
            foreach (UltraGridRow row in this.uGridPRoads.Rows)
            {
                Prod_Roads pr = row.ListObject as Prod_Roads;
                prList.Add(pr);
            }
            if (prList.Count == 0)
            {
                Alert.Show("请输入您要调整的工序!");
                return;
            }
            if (CallBack != null)
            {
                CallBack(PlanProdList, prList);
                this.Close();
            }
        }

    }
}
