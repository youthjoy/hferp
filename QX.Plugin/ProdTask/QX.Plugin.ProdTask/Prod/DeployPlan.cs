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
using Infragistics.Win;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;
using QX.Plugin.Prod.Prod;

namespace QX.Plugin.Prod
{
    public partial class DeployPlan : F_BasicPop
    {
        public DeployPlan()
        {
            InitializeComponent();
        }

        UltraGrid uGridPlan = new UltraGrid();

        private Bll_Prod_CmdDetail pdInstance = new Bll_Prod_CmdDetail();

        public DeployPlan(Prod_Task planingTask)
        {
            InitializeComponent();
            OperationType = OperationTypeEnum.OperationType.Edit;
            PlaningTask = planingTask;
        }

        private void DeployPlan_Load(object sender, EventArgs e)
        {
            Init();
        }

        public delegate void DCallBackHandler(bool result, Prod_Task sender);
        public event DCallBackHandler CallBack;

        private Bll_ProdTask ptInstance = new Bll_ProdTask();
        //private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();
        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();

        private OperationTypeEnum.OperationType OperationType;

        private BindModelHelper _bmHelper = new BindModelHelper();

        private GridHelper gen = new GridHelper();

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }

        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }

        /// <summary>
        /// 当前要下达计划的任务
        /// </summary>
        private Prod_Task PlaningTask;

        public void Init()
        {
            IsCanSave = true;
            switch (OperationType)
            {

                case OperationTypeEnum.OperationType.Edit:


                    InitEditTaskInfo();
                    uGridPlanInit();

                    //InitCodeMap();
                    break;
            }
        }

        /// <summary>
        /// 设置当前窗口对应Mode（添加，编辑，查看）
        /// </summary>
        /// <param name="mode"></param>
        public void SetMode(OperationTypeEnum.OperationType mode)
        {
            switch (mode)
            {
                case OperationTypeEnum.OperationType.Edit:
                    OperationType = OperationTypeEnum.OperationType.Edit;

                    break;
            }
        }

        /// <summary>
        /// 控件值发生变化时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contolValue_Changed(object sender, EventArgs e)
        {
            IsEdited = true;
        }

        ToolStripComboBox tComboBox = new ToolStripComboBox();

        ToolStripButton tButton = new ToolStripButton();

        private List<Prod_CodeMap> CodeMapList
        {
            get;
            set;
        }

        public void InitEditTaskInfo()
        {

            FormHelper gen = new FormHelper();

            gen.GenerateForm("FDProdTask", this.gbDeployPlan, new Point(6, 20));

            bmHelper.BindModelToControl<Prod_Task>(PlaningTask, this.gbDeployPlan.Controls, "");

            ToolStripHelper tsHelper = new ToolStripHelper();

            ToolStripButton btnRefresh = tsHelper.New("重新获取编码", QX.Common.Properties.Resources.refresh, new EventHandler(btnRefresh_Click));

            this.commonToolBar1.AddCustomControl(btnRefresh);

            //#region 计划工具栏和事件

            //EventHandler handler = new EventHandler(this.contolValue_Changed);
            //bmHelper.BindEventToControl(gbDeployPlan.Controls, typeof(UltraTextEditor), handler);

            //ToolStripLabel tLabel = new ToolStripLabel();
            //tLabel.Text = "下达数量 ";
            //this.tbPlan.AddCustomControl(tLabel);



            //tComboBox.Size = new Size(150, 30);
            //this.tbPlan.AddCustomControl(tComboBox);
            //int availableNum = PlaningTask.TaskDetail_Num - PlaningTask.Task_DNum;
            //InitNumCombo(availableNum);

            //tButton.Image = QX.Common.Properties.Resources.OK;
            //tButton.Text = "确定";
            //tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            //tButton.Click += new EventHandler(tButton_Click);
            //tbPlan.AddCustomControl(tButton);


            //ToolStripButton tButtonAddPlan = new ToolStripButton();

            //tButtonAddPlan.Text = "添加";
            //Image addImage = global::QX.Common.Properties.Resources.add;　　　　//从资源文件中引用
            //tButtonAddPlan.Image = addImage;
            //tButtonAddPlan.Size = new Size(43, 28);
            //tButtonAddPlan.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            //tButtonAddPlan.TextImageRelation = TextImageRelation.ImageAboveText;
            //tButtonAddPlan.Click += new EventHandler(tButtonAddPlan_Click);
            //this.tbPlan.AddCustomControl(tButtonAddPlan);


            //ToolStripButton tButtonDelete = new ToolStripButton();

            //tButtonDelete.Text = "删除";
            //Image delImage = global::QX.Common.Properties.Resources.delete;　　　　//从资源文件中引用
            //tButtonDelete.Image = delImage;
            //tButtonDelete.Size = new Size(43, 28);
            //tButtonDelete.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            //tButtonDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            //tButtonDelete.Click += new EventHandler(tButtonDelete_Click);
            //this.tbPlan.AddCustomControl(tButtonDelete);


            //ToolStripHelper tsHelper = new ToolStripHelper();
            //ToolStripButton codeGenBtn = tsHelper.New("自动编号", QX.Common.Properties.Resources.import, new EventHandler(codeGenBtn_Click));
            //tbPlan.AddCustomControl(codeGenBtn);

            //#endregion
        }

        void btnRefresh_Click(object sender, EventArgs e)
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            BindingSource source = new BindingSource();
            source.DataSource = list;
            uGridPlan.DataSource = source;
            InitCodeMap();
        }

        void codeGenBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                FProdCode FPCFrm = new FProdCode();
                FPCFrm.ShowDialog();
                if (FPCFrm.IsConfirm)
                {
                    string code = FPCFrm.GCode;
                    string pre = FPCFrm.Prefix;

                    int gcode = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(code);

                    int i = 0;
                    for (i = row.Index; i < uGridPlan.Rows.Count; i++)
                    {
                        uGridPlan.Rows[i].Cells["PlanProd_Code"].Value = pre + gcode;
                        gcode++;
                    }

                }
            }
        }

        void tButtonDelete_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridPlan.ActiveRow;
            if (row != null)
            {
                row.Delete(false);
            }
        }

        void tButtonAddPlan_Click(object sender, EventArgs e)
        {
            int num = PlaningTask.TaskDetail_Num - PlaningTask.Task_DNum;
            //添加一行的条件--》不能超过可以下发的计划数量
            if (this.uGridPlan.Rows.Count < num)
            {
                Prod_PlanProd templateProdPlan = ppInstance.CreateProdPlanWithNoPersist(PlaningTask);
                PlanHandler.AddNewRow<Prod_PlanProd>(templateProdPlan);
            }
        }

        private void InitNumCombo(int AvailableNum)
        {
            //bmHelper.SetDropDownStyle(this.tComboBox);
            this.tComboBox.Items.Clear();

            for (int i = AvailableNum; i > 0; i--)
            {
                tComboBox.Items.Add(i);
            }

            if (tComboBox.Items.Count > 0)
            {
                tComboBox.SelectedIndex = 0;
            }

        }

        void tButton_Click(object sender, EventArgs e)
        {

            //InitCodeMap();
            //    //选择生成数量
            //    int num = Common.C_Class.Utils.TypeConverter.ObjectToInt(this.tComboBox.SelectedItem);
            //    //实际计划数量
            //    int rowNum = this.uGridPlan.Rows.Count;

            //    if (rowNum == 0)
            //    {
            //        List<Prod_PlanProd> list = ppInstance.DeployPlanWithNoSubmit(PlaningTask, num);
            //        uGridPlanBind(list);
            //    }//添加操作
            //    else if (num > rowNum)
            //    {
            //        DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定要重新生成计划列表吗?");
            //        if (dialog == DialogResult.OK)
            //        {
            //            Prod_PlanProd templateProdPlan = ppInstance.CreateProdPlanWithNoPersist(PlaningTask);
            //            int createNum = num - rowNum;
            //            for (int i = 0; i < createNum; i++)
            //            {
            //                PlanHandler.AddNewRow<Prod_PlanProd>(templateProdPlan);
            //            }
            //        }
            //    }//删除操作
            //    else if (num < rowNum)
            //    {
            //        DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定要重新生成计划列表吗?");
            //        if (dialog == DialogResult.OK)
            //        {
            //            int deleteNum = rowNum - num;
            //            for (int i = 0; i < deleteNum; i++)
            //            {
            //                this.uGridPlan.Rows[this.uGridPlan.Rows.Count - 1].Delete(false);
            //            }
            //        }
            //    }//如果选择的数量未变化，则提示确认是否需要重新更新
            //    else
            //    {
            //        DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定要重新生成计划列表吗?");
            //        if (dialog == DialogResult.OK)
            //        {
            //            List<Prod_PlanProd> list = ppInstance.DeployPlanWithNoSubmit(PlaningTask, num);
            //            uGridPlanBind(list);
            //        }
            //    }



        }


        #region 计划列表

        private List<Prod_PlanProd> CurPlanDataSource = new List<Prod_PlanProd>();

        private GridHandler _PlanHandler;

        public GridHandler PlanHandler
        {
            get { return _PlanHandler; }
            set { _PlanHandler = value; }
        }

        private List<string> TempPlanDataSource = new List<string>();

        private Dictionary<string, string> PlanDicColumn = new Dictionary<string, string>();


        public void uGridPlanInit()
        {
            PlanHandler = new GridHandler(this.uGridPlan);

            uGridPlanInitColumn();

            //uGridPlanStyleInit();

            uGridPlanEventInit();

            InitCodeMap();
        }

        public void uGridPlanEventInit()
        {
            this.uGridPlan.AfterRowUpdate += new RowEventHandler(uGridPlan_AfterRowUpdate);
            this.uGridPlan.CellChange += new CellEventHandler(uGridPlan_CellChange);
        }

        void uGridPlan_CellChange(object sender, CellEventArgs e)
        {
            switch (e.Cell.Column.Key)
            {
                case "PlanProd_Begin":
                    {

                        EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        object beginValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        e.Cell.Value = beginValue;
                        break;
                    }
                case "PlanProd_End":
                    {

                        EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        object endValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        e.Cell.Value = endValue;
                        break;
                    }
                case "PlanProd_Bak":
                    {
                        EmbeddableEditorBase editor = e.Cell.EditorResolved;
                        object endValue = editor.IsValid ? editor.Value : editor.CurrentEditText;
                        e.Cell.Value = endValue;
                        break;
                    }
            }
        }


        public bool IsCanSave
        {
            get;
            set;
        }

        void uGridPlan_AfterRowUpdate(object sender, RowEventArgs e)
        {
            //MessageBox.Show(e.Row.Cells["PlanProd_Code"].Value.ToString());
            object value = e.Row.Cells["PlanProd_Code"].Value;
            if (value != null && !string.IsNullOrEmpty(value.ToString()) && !TempPlanDataSource.Contains(value.ToString()))
            {
                if (!ppInstance.IsRepeatProdCode(value.ToString()))
                {
                    e.Row.RowSelectorAppearance.BackColor = Color.Empty;
                    TempPlanDataSource.Add(value.ToString());
                    IsCanSave = true;
                }
                else
                {
                    IsCanSave = false;
                    e.Row.RowSelectorAppearance.BackColor = Color.Red;
                }
            }
            //else
            //{
            //    e.Row.RowSelectorAppearance.BackColor = Color.Red;
            //}

        }


        private void uGridPlanStyleInit()
        {
            PlanHandler.SetDefaultStyle();
            //PlanHandler.SetExcelStyleFilter();

            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Begin"].Width = 100;

            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Begin"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Begin"].MaskInput = "yyyy-mm-dd hh:mm";
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Begin"].DefaultCellValue = DateTime.Now;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_End"].Width = 100;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_End"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_End"].MaskInput = "yyyy-mm-dd hh:mm";
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_End"].DefaultCellValue = DateTime.Now;

            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Code"].CellClickAction = CellClickAction.EditAndSelectText;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_LineCode"].CellClickAction = CellClickAction.EditAndSelectText;
            this.uGridPlan.DisplayLayout.Bands[0].Columns["PlanProd_Bak"].CellClickAction = CellClickAction.EditAndSelectText;
        }

        private void uGridPlanInitColumn()
        {
            PlanDicColumn.Add("PlanProd_Code", "零件编号");
            PlanDicColumn.Add("PlanProd_PartNo", "零件图号");
            PlanDicColumn.Add("PlanProd_PartName", "零件名称");
            PlanDicColumn.Add("PlanProd_Begin", "计划开工");
            PlanDicColumn.Add("PlanProd_End", "计划完工");
            //PlanDicColumn.Add("PlanProd_FDate", "实际完工时间");
            PlanDicColumn.Add("PlanProd_LineCode", "长票编号");
            //PlanDicColumn.Add("PlanProd_Owner", "编辑人");
            //PlanDicColumn.Add("PlanProd_Date", "编制时间");
            PlanDicColumn.Add("PlanProd_Bak", "备注");
            //PlanHandler.BindData(CurPlanDataSource, PlanDicColumn);
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            uGridPlan = gen.GenerateGrid("CList_DeployPlan", this.panel2, new Point(0, 0));
            BindingSource source = new BindingSource();
            source.DataSource = list;
            uGridPlan.DataSource = source;

            uGridPlan.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

        }

        public void uGridPlanBind(List<Prod_PlanProd> list)
        {
            //CurPlanDataSource = list;
            //PlanHandler.BindData(list, PlanDicColumn);
            //AdjustPlanGridColumn();
            BindingSource source = new BindingSource();
            source.DataSource = list;
            uGridPlan.DataSource = source;
        }


        #endregion

        /// <summary>
        /// 设置文本框是否可编辑
        /// </summary>
        /// <param name="flag"></param>
        public void EnableEditMode(bool flag)
        {
            if (flag)
            {
                foreach (Control item in this.gbDeployPlan.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {

                        ((TextBox)item).ReadOnly = false;

                    }
                    else if (item.GetType() == typeof(ComboBox))
                    {
                        ((ComboBox)item).Enabled = true;
                    }
                    else if (item.GetType() == typeof(DateTimePicker))
                    {
                        ((DateTimePicker)item).Enabled = true;
                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control item in this.gbDeployPlan.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).ReadOnly = true;
                    }
                    else if (item.GetType() == typeof(ComboBox))
                    {
                        ((ComboBox)item).Enabled = false;
                    }
                    else if (item.GetType() == typeof(DateTimePicker))
                    {
                        ((DateTimePicker)item).Enabled = false;
                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = false;
                    }
                }
            }
        }

        void btnConfirm_Click(object sender, EventArgs e)
        {


            switch (OperationType)
            {

                case OperationTypeEnum.OperationType.Edit:
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
  , QX.Shared.SessionConfig.UserName
  , "localhost"
  , this.Name
  , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdPlan
  , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdPlan.ToString(), QX.Common.LogType.Edit.ToString());



                    if (IsCanSave)
                    {
                        bool flag = true;
                        bmHelper.BindControlToModel<Prod_Task>(PlaningTask, this.gbDeployPlan.Controls, "");

                        //int deployPlanNum = ConvertX.ConvertObj2Int(tComboBox.SelectedItem);
                        //任务数量
                        int num = PlaningTask.TaskDetail_Num;
                        //下达数量
                        int count = uGridPlan.Rows.Count;

                        if (num < count)
                        {
                            Alert.Show(string.Format("任务数量为{0},下达计划数量不能大于生产任务数量", num));
                            return;
                        }

                        List<Prod_PlanProd> planList = new List<Prod_PlanProd>();


                        //生产计划相关
                        foreach (UltraGridRow row in this.uGridPlan.Rows)
                        {
                            Prod_PlanProd plan = row.ListObject as Prod_PlanProd;

                            if (string.IsNullOrEmpty(plan.PlanProd_Code))
                            {
                                flag = false;
                                break;
                            }

                            if (CodeMapList.FirstOrDefault(o => o.PMap_PCode == plan.PlanProd_Code) == null)
                            {
                                Alert.Show("您输入的零件编号与指令要求的编号范围有误!");
                                return;
                            }

                            planList.Add(plan);
                        }

                        if (planList.Count == 0)
                        {
                            Alert.Show("请输入您要下发的计划内容!");
                            return;
                        }




                        PlaningTask.Task_DNum = PlaningTask.Task_DNum + planList.Count;

                        if (num < PlaningTask.Task_DNum)
                        {
                            if (!Alert.ShowIsConfirm(string.Format("要下发的计划数量与原已下发累计数量（{0}）与任务总数量({1})不符合，确定要下达计划吗?", PlaningTask.Task_DNum,num)))
                            {
                                return;
                            }

                        }

                        if (flag && ppInstance.DeployPlanAndRoadNodes(PlaningTask, planList))
                        {

                            pdInstance.UpdateProdCodeMapStat(PlaningTask.TaskDetail_CmdCode, PlaningTask.TaskDetail_PartNo, planList);

                            if (CallBack != null)
                            {
                                CallBack(true, PlaningTask);
                                this.Close();
                            }
                        }
                        else
                        {
                            Alert.Show("输入数据有误，请查证后重新输入!");
                        }

                    }
                    else
                    {
                        Alert.Show("产品编码存在重复数据，请查证后重新输入!");
                    }

                    break;
            }
        }


        public void InitCodeMap()
        {
            Prod_PlanProd templateProdPlan = ppInstance.CreateProdPlanWithNoPersist(PlaningTask);
            //获取可以下发的零件编号
            var list = pdInstance.GetMapListByTaskForPlanDeploy(PlaningTask.TaskDetail_CmdCode, PlaningTask.TaskDetail_PartNo,PlaningTask.Task_Code);
            if (list == null || list.Count == 0)
            {
                list = pdInstance.GetMapListByTaskForDeploy(PlaningTask.TaskDetail_CmdCode, PlaningTask.TaskDetail_PartNo);
            }
            CodeMapList = list;
            uGridPlan.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;
            foreach (var i in list)
            {
                var row = this.uGridPlan.DisplayLayout.Bands[0].AddNew();
                templateProdPlan.PlanProd_Code = i.PMap_PCode;
                PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(Prod_PlanProd));

                foreach (UltraGridCell cell in row.Cells)
                {
                    if (cell.Column.IsBound)
                    {
                        object value = pc[cell.Column.Key].GetValue(templateProdPlan);
                        if (value != null)
                        {
                            row.Cells[cell.Column.Key].Value = value;
                        }
                    }
                }
            }
            uGridPlan.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
        }


        private List<Prod_PlanProd> GetGridCheckBoxData()
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();

            foreach (UltraGridRow r in this.uGridPlan.DisplayLayout.Rows)
            {
                Prod_PlanProd prod = r.ListObject as Prod_PlanProd;
                string stat = prod.IInfor_Stat;

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    Prod_PlanProd planProd = r.ListObject as Prod_PlanProd;
                    list.Add(planProd);
                }
            }

            return list;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        //关闭窗口处理方法
        private void CloseForm()
        {
            if (IsEdited)
            {

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定放弃保存当前编辑数据，关闭该窗口?");


                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

    }
}
