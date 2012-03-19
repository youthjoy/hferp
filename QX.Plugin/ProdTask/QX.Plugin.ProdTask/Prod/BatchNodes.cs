using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.DataModel;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;
using Infragistics.Win;


namespace QX.Plugin.Prod
{
    public partial class BatchNodes : Form
    {

        public delegate void DCallBackHandler(bool result, Prod_Roads road);
        public event DCallBackHandler CallBack;

        public BatchNodes()
        {
            InitializeComponent();
        }

        public BatchNodes(List<Prod_PlanProd> list)
        {
            InitializeComponent();
            CurDataSource = list;
            EventInit();

            this.Load += new EventHandler(ComDict_Load);
        }

        private void ComDict_Load(object sender, EventArgs e)
        {
            InitData();
        }


        /// <summary>
        /// 批量调整的零件
        /// </summary>
        public List<Prod_PlanProd> CurDataSource
        {
            get;
            set;
        }


        public void EventInit()
        {
            this.tbGrid.SaveClicked += new EventHandler(pSaveBtn_Click);

            this.tbGrid.RefreshClicked += new EventHandler(tbGrid_RefreshClicked);
            ToolStripHelper tsHelper=new ToolStripHelper();
            ToolStripButton batchBtn = tsHelper.New("批量外协", QX.Common.Properties.Resources.batch, new EventHandler(batchBtn_Click));

            this.tbGrid.AddCustomControl(batchBtn);
        }

        void batchBtn_Click(object sender, EventArgs e)
        {
            List<Prod_Roads> list = new List<Prod_Roads>();

            foreach (UltraGridRow r in this.comGrid.Selected.Rows)
            {
                Prod_Roads pr = r.ListObject as Prod_Roads;
                list.Add(pr);
            }
            if (list.Count == 0)
            {
                Alert.Show("请选择工艺节点!");
                return;
            }

            BatchFHelper fhelperForm = new BatchFHelper( CurDataSource, list);
            fhelperForm.CallBack += new BatchFHelper.DCallBackHandler(fhelperForm_CallBack);
            fhelperForm.ShowDialog();
        }

        void fhelperForm_CallBack(bool result, Prod_Roads road)
        {
            if (result)
            {
                this.Close();
            }
        }

        void tbGrid_RefreshClicked(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        void pSaveBtn_Click(object sender, EventArgs e)
        {
            List<Prod_Roads> list = GetGridCheckBoxData();
            Prod_Roads road = list.FirstOrDefault();


            if (list.Count == 0)
            {
                Alert.Show("请选择要更新的节点!");
                return;
            }
            if (SaveData(road))
            {
                if (CallBack != null)
                {
                    CallBack(true, road);
                }

                Alert.Show("数据更新完成");

                this.Close();
            }
        }
        //BLL.Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        private bool SaveData(Prod_Roads road)
        {

            List<Prod_Roads> fhelperList = new List<Prod_Roads>();
                StringBuilder sb = new StringBuilder();
            foreach (var p in CurDataSource)
            {
                List<Prod_Roads> rlist = prInstance.GetPlanRoadList(p.PlanProd_PlanCode);

                var old = rlist.FirstOrDefault(o => o.PRoad_IsCurrent == 1&&o.PRoad_Order!=road.PRoad_Order);
                //新节点
                var newnode = rlist.FirstOrDefault(o => o.PRoad_Order >= road.PRoad_Order && o.PRoad_NodeCode == road.PRoad_NodeCode);

                if (newnode != null)
                {
                    newnode.PRoad_NodeDepCode = road.PRoad_NodeDepCode;
                    newnode.PRoad_NodeDepName = road.PRoad_NodeDepName;
                    newnode.PRoad_RTicker = road.PRoad_RTicker;
                    newnode.PRoad_ActBTime = DateTime.Now;
                    newnode.PRoad_ActRTime = road.PRoad_ActRTime;
                    ///日志使用
                    sb.Append(p.PlanProd_Code).Append(',');

                    //设置当前节点状态
                    prInstance.SetCurrentNode(old, newnode);

                    if (newnode.PRoad_NodeDepCode == GlobalConfiguration.MarketDept)
                    {
                        fhelperList.Add(newnode);
                    }
                }

            }//end foreach

            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().BatchProdNode + "(" + sb.ToString() + ")"
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdRecordModule.ToString(), QX.Common.LogType.Edit.ToString());



            if (fhelperList.Count != 0)
            {
                MethodInvoker mi = delegate
                {

                    foreach (var f in fhelperList)
                    {
                        new Bll_Prod_Record().EnterFHelper(f);
                    }
                };

                mi.BeginInvoke(null, null);
            }

            return true;
        }

        private List<Prod_Roads> GetGridCheckBoxData()
        {
            List<Prod_Roads> list = new List<Prod_Roads>();

            foreach (UltraGridRow r in this.comGrid.DisplayLayout.Rows)
            {
                //过滤已配对的
                Prod_Roads d = r.ListObject as Prod_Roads;

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    //Prod_PlanProd planProd = r.ListObject as Prod_PlanProd;
                    list.Add(d);
                }
            }

            return list;
        }

        private void InitData()
        {

            GridInit();

            AddCustomColumn();
        }

        BLL.Bll_Prod_Roads prInstance = new Bll_Prod_Roads();


        UltraGrid comGrid = new UltraGrid();

        private void GridInit()
        {
            GridHelper gen = new GridHelper();

            //List<Bse_Dict> bsList = new List<Bse_Dict>();
            //string moduleCode = DataCode;
            //bsList = dcInstance.GetListByDictKeyByNoRoot(DataCode);

            //ADOSys_PD_Module moduleInstance = new ADOSys_PD_Module();
            //Sys_PD_Module module = new Sys_PD_Module();
            //module = moduleInstance.GetListByWhere(" and SPM_Module='" + DataCode + "'").FirstOrDefault();
            //if (module == null)
            //{

            //moduleCode = DataCode;
            //}

            comGrid = gen.GenerateGrid("CList_BatchNode", this.pnlGrid, new Point(6, 20));
            comGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            comGrid.BeforeEnterEditMode += new CancelEventHandler(comGrid_BeforeEnterEditMode);
            comGrid.CellChange += new CellEventHandler(comGrid_CellChange);
            List<Prod_Roads> list = prInstance.GetPlanRoadList(CurDataSource[0].PlanProd_PlanCode);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;

            comGrid.DataSource = dataSource;

            //列宽度自适应
            comGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;
            comGrid.Text = this.Text;
        }

        void comGrid_CellChange(object sender, CellEventArgs e)
        {
            //if (e.Cell.Column.Key == "PRoad_RTicker")
            //{
            //    e.Cell.Row.Cells["PRoad_ActRTime"].Value = DateTime.Now;
            //}
        }

        void comGrid_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridRow row = this.comGrid.ActiveRow;
            UltraGridCell cell = this.comGrid.ActiveCell;

            if (cell.Column.Key == "checkbox")
            {
                Prod_Roads newNode = row.ListObject as Prod_Roads;

                foreach (var r in this.comGrid.Rows)
                {
                    var val = r.Cells["checkbox"].Value;

                    Prod_Roads tmp = r.ListObject as Prod_Roads;

                    if (tmp.PRoad_ID == newNode.PRoad_ID)
                    {
                        continue;
                    }

                    EmbeddableEditorBase editor = r.Cells["checkbox"].EditorResolved;
                    object isCurrent = editor.IsValid ? editor.Value : editor.CurrentEditText;

                    r.Cells["checkbox"].Value = 0;
                    editor.Value = 0;


                }


                //设置当前点击节点为当前所处工序
                //newNode.PRoad_IsCurrent = 1;
                row.Cells["checkbox"].Value = 1;
                e.Cancel = true;
            }
            else if (cell.Column.Key == "PRoad_RTicker")
            {
                Bll_Dept bllDept = new Bll_Dept();
                Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
                CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> user =
                    new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
                user.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(user_CallBack);
                user.ShowDialog();
                e.Cancel = true;
            }
        }

        private void user_CallBack(object sender, DataTable list)
        {
            if (list == null)
            {
                UltraGridCell cell = this.comGrid.ActiveCell;

                if (cell != null)
                {
                    cell.Value = string.Empty;
                    
                    //e.Cell.Row.Cells["PRoad_ActRTime"].Value = DateTime.Now;
                }
            }
            else if (list.Rows.Count == 1)
            {

                UltraGridCell cell = this.comGrid.ActiveCell;

                if (cell != null)
                {
                    cell.Value = list.Rows[0]["Emp_Code"] != null ? list.Rows[0]["Emp_Code"].ToString() : string.Empty;
                    var time = cell.Row.Cells["PRoad_ActRTime"].Value;
                    if (time != null && time.ToString().Contains("0001"))
                    {
                        cell.Row.Cells["PRoad_ActRTime"].Value = DateTime.Now;
                    }
                }
            }
        }


        private void AddCustomColumn()
        {
            //try
            //{


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

            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void RefreshGrid()
        {
            List<Bse_Dict> bsList = new List<Bse_Dict>();

            List<Prod_Roads> list = prInstance.GetPlanRoadList(CurDataSource[0].PlanProd_PlanCode);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;
        }

        public void SetGridEditMode(bool flag, UltraGrid grid)
        {
            if (flag)
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
            }
            else
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
            }

        }
    }
}
