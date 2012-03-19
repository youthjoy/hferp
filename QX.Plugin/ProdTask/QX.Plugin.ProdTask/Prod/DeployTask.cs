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
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;
using QX.Shared;
using Infragistics.Win.UltraWinGrid;

namespace QX.Plugin.Prod
{
    public partial class DeployTask : F_BasicPop
    {
        public DeployTask()
        {
            InitializeComponent();
        }


        public DeployTask(OperationTypeEnum.OperationType type, Raw_Inv raw)
        {
            InitializeComponent();
            SetMode(type);
            DeployTaskingRaw = raw;
            BindEvent();
        }


        public DeployTask(OperationTypeEnum.OperationType type, Prod_Task pt)
        {
            InitializeComponent();
            SetMode(type);
            DeloyingTask = pt;
            BindEvent();
        }

        private void BindEvent()
        {
            this.KeyPreview = true;

            this.btnConfirm.Click += new EventHandler(btnConfirm_Click);

            this.btnCancel.Click += new EventHandler(btnCancel_Click);

            this.KeyUp += new KeyEventHandler(DeployTask_KeyUp);

            //this.Task_PartCatName.Click += new EventHandler(this.roadCate_Click);
        }

        void DeployTask_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }



        private void DeployTask_Load(object sender, EventArgs e)
        {
            Init();
            ProdCodeInit();
        }

        public delegate void DCallBackHandler(bool result, object sender);
        public event DCallBackHandler CallBack;

        private Bll_Prod_Command cmdInstance = new Bll_Prod_Command();
        private Bll_ProdTask ptInstance = new Bll_ProdTask();
        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        //private Bll_Prod_CmdDetail cmdInstance = new Bll_Prod_CmdDetail();
        private Bll_Prod_CmdDetail cdInstance = new Bll_Prod_CmdDetail();
        private BindModelHelper _bmHelper = new BindModelHelper();

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }

        /// <summary>
        /// 操作类型
        /// </summary>
        private OperationTypeEnum.OperationType _OperationType;

        public OperationTypeEnum.OperationType OperationType
        {
            get { return _OperationType; }
            set { _OperationType = value; }
        }


        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }

        private Raw_Inv DeployTaskingRaw;

        private Prod_Task DeloyingTask;

        public void Init()
        {

            FormHelper gen = new FormHelper();

            gen.GenerateForm("FCProdTask", this.gpCmd, new Point(6, 20));

            gen.GenerateForm("FProdTask", this.groupBox1, new Point(6, 20));

            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    InitDeployTask();

                    break;
                case OperationTypeEnum.OperationType.Edit:
                    InitEditTaskInfo();
                    break;
                case OperationTypeEnum.OperationType.Look:
                    InitLookTaskInfo();
                    break;
            }
        }

        #region 零件编号

        UltraGrid comGrid = new UltraGrid();
        GridHelper gen = new GridHelper();
        private Bll_Prod_CmdDetail pdInstance = new Bll_Prod_CmdDetail();
        List<Prod_CodeMap> prodCodeMap
        {
            get;
            set;
        }
        /// <summary>
        /// 零件编号列表初始化
        /// </summary>
        public void ProdCodeInit()
        {
            prodCodeMap = new List<Prod_CodeMap>();
            comGrid = gen.GenerateGrid("CList_CodeMap", this.pnlCode, new Point(0, 0));
            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    {
                        prodCodeMap = pdInstance.GetMapListByTaskForDeploy(DeloyingTask.TaskDetail_CmdCode, DeloyingTask.TaskDetail_PartNo, DeployTaskingRaw.RI_RefRawCode);
                        //hack  如果根据任务编号取不到关联的零件编号的话
                        if (prodCodeMap == null || prodCodeMap.Count == 0)
                        {
                            prodCodeMap = pdInstance.GetMapListByTaskForDeploy(DeloyingTask.TaskDetail_CmdCode, DeloyingTask.TaskDetail_PartNo);
                        }
                        break;
                    }
                case OperationTypeEnum.OperationType.Look:
                case OperationTypeEnum.OperationType.Edit:
                    {
                        prodCodeMap = pdInstance.GetMapListByTaskForPlanDeploy(DeloyingTask.TaskDetail_CmdCode, DeloyingTask.TaskDetail_PartNo,DeloyingTask.Task_Code);
                        //hack 
                        if (prodCodeMap == null || prodCodeMap.Count == 0)
                        {
                            prodCodeMap = pdInstance.GetMapListByTaskForDeploy(DeloyingTask.TaskDetail_CmdCode, DeloyingTask.TaskDetail_PartNo);
                        }
                        break;
                    }
            }

            comGrid.InitializeRow += new InitializeRowEventHandler(comGrid_InitializeRow);
            BindingSource source = new BindingSource();
            source.DataSource = prodCodeMap;
            comGrid.DataSource = source;
            gen.SetGridReadOnly(comGrid, true);
            //AddCustomColumn();
        }

        void comGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Prod_CodeMap map = e.Row.ListObject as Prod_CodeMap;
            if (!string.IsNullOrEmpty(map.PMap_Stat))
            {
                e.Row.Appearance.BackColor = Color.Wheat;
            }
        }

        /// <summary>
        /// 自定义列添加
        /// </summary>
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
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.EditAndSelectText;
            }
        }

        #endregion

        /// <summary>
        /// 设置当前窗口对应Mode（添加，编辑，查看）
        /// </summary>
        /// <param name="mode"></param>
        public void SetMode(OperationTypeEnum.OperationType mode)
        {
            switch (mode)
            {
                case OperationTypeEnum.OperationType.Look:

                    //EnableEditMode(false,this.groupBox1.Controls);
                    //EnableEditMode(false, this.gpCmd.Controls);
                    this.btnConfirm.Enabled = false;

                    OperationType = OperationTypeEnum.OperationType.Look;

                    break;
                case OperationTypeEnum.OperationType.Add:
                    //this.Task_Code.ReadOnly = true;
                    //this.TaskDetail_PartNo.ReadOnly = true;
                    //this.TaskDetail_PartName.ReadOnly = true;
                    //this.TaskDetail_CmdCode.ReadOnly = true;
                    OperationType = OperationTypeEnum.OperationType.Add;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    OperationType = OperationTypeEnum.OperationType.Edit;
                    //this.Task_Code.ReadOnly = true;
                    //this.TaskDetail_PartNo.ReadOnly = true;
                    //this.TaskDetail_PartName.ReadOnly = true;
                    //this.TaskDetail_CmdCode.ReadOnly = true;
                    break;
            }
        }

        #region 下达生产任务
        Bll_Road_Components rcInstance = new Bll_Road_Components();
        public void InitDeployTask()
        {
            if (DeloyingTask == null)
            {
                DeloyingTask = new Prod_Task();

                //var cmdModel=cmdInstance.GetModel(string.Format(" AND Cmd_Code='{0}'", DeployTaskingRaw.RI_CmdCode));

                DeloyingTask.Task_Code = ptInstance.CreateProdTaskCode();
                DeloyingTask.TaskDetail_CmdCode = DeployTaskingRaw.RI_CmdCode;
                DeloyingTask.TaskDetail_PartName = DeployTaskingRaw.RI_CompName;
                DeloyingTask.TaskDetail_PartNo = DeployTaskingRaw.RI_CompCode;

                DeloyingTask.TaskDetail_Num = DeployTaskingRaw.RI_AvailableNum;
                DeloyingTask.Task_Name = DeployTaskingRaw.RI_CompName + "-" + DeployTaskingRaw.RI_AvailableNum;

                var comp = rcInstance.GetRoadComponentByCode(DeployTaskingRaw.RI_CompCode);
                if (comp != null)
                {
                    DeloyingTask.Task_PartCat = comp.Comp_CatCode;
                    DeloyingTask.Task_PartCatName = comp.Comp_CatName;
                }
                var cmdTmp = cdInstance.GetModel(string.Format(" and Cmd_Code='{0}' AND CmdDetail_PartNo='{1}'", DeployTaskingRaw.RI_CmdCode, DeployTaskingRaw.RI_CompCode));
                var command = cmdInstance.GetModel(string.Format(" and Cmd_Code='{0}'", DeployTaskingRaw.RI_CmdCode));
                DeloyingTask.Task_ProdCode = cmdTmp.CmdDetail_Bak;
                DeloyingTask.Task_Roads = cmdTmp.CmdDetail_Roads;
                DeloyingTask.Task_Customer = command.Cmd_Dep_Code2;
                DeloyingTask.Task_CustomerName = command.Cmd_Dep_Name;
                DeloyingTask.Task_ProdCode = cmdTmp.CmdDetail_Project;
                //该生产任务相关的客户
                //DeloyingTask.Task_Customer=cmdTmp.cmd_d


                //需增加工序和产品类别字段
                //InitNumCombo(DeployTaskingRaw.RI_AvailableNum);
            }

            bmHelper.BindModelToControl<Prod_Task>(DeloyingTask, this.groupBox1.Controls, "");
            bmHelper.BindModelToControl<Prod_Task>(DeloyingTask, gpCmd.Controls, "");


            //EventHandler handler = new EventHandler(this.contolValue_Changed);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(TextBox), handler);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(ComboBox), handler);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(DateTimePicker), handler);
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

        //private void InitNumCombo(int AvailableNum)
        //{
        //    bmHelper.SetDropDownStyle(this.Task_DNum);
        //    this.Task_DNum.Items.Clear();

        //    for (int i = AvailableNum; i > 0; i--)
        //    {
        //        Task_DNum.Items.Add(i);
        //    }

        //    if (Task_DNum.Items.Count > 0)
        //    {
        //        Task_DNum.SelectedIndex = 0;
        //    }

        //}

        #endregion

        public void InitLookTaskInfo()
        {
            if (DeloyingTask == null)
            {
                DeloyingTask = new Prod_Task();
                DeloyingTask.Task_Code = ptInstance.CreateProdTaskCode();
                DeloyingTask.TaskDetail_CmdCode = DeployTaskingRaw.RI_CmdCode;
                DeloyingTask.TaskDetail_PartName = DeployTaskingRaw.RI_CompName;
                DeloyingTask.TaskDetail_PartNo = DeployTaskingRaw.RI_CompCode;

                //InitNumCombo(DeployTaskingRaw.RI_AvailableNum);
            }

            //InitNumCombo(DeloyingTask.Task_DNum);

            bmHelper.BindModelToControl<Prod_Task>(DeloyingTask, this.groupBox1.Controls, "");
            bmHelper.BindModelToControl<Prod_Task>(DeloyingTask, gpCmd.Controls, "");



            //EventHandler handler = new EventHandler(this.contolValue_Changed);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(TextBox), handler);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(ComboBox), handler);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(DateTimePicker), handler);

        }


        public void InitEditTaskInfo()
        {
            if (DeloyingTask == null)
            {
                DeloyingTask = new Prod_Task();
                DeloyingTask.Task_Code = ptInstance.CreateProdTaskCode();
                DeloyingTask.TaskDetail_CmdCode = DeployTaskingRaw.RI_CmdCode;
                DeloyingTask.TaskDetail_PartName = DeployTaskingRaw.RI_CompName;
                DeloyingTask.TaskDetail_PartNo = DeployTaskingRaw.RI_CompCode;

                //InitNumCombo(DeployTaskingRaw.RI_AvailableNum);
            }

            //InitNumCombo(DeloyingTask.Task_DNum);
            bmHelper.BindModelToControl<Prod_Task>(DeloyingTask, this.groupBox1.Controls, "");
            bmHelper.BindModelToControl<Prod_Task>(DeloyingTask, gpCmd.Controls, "");


            //EventHandler handler = new EventHandler(this.contolValue_Changed);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(TextBox), handler);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(ComboBox), handler);
            //bmHelper.BindEventToControl(gpTask.Controls, typeof(DateTimePicker), handler);

        }





        /// <summary>
        /// 设置文本框是否可编辑
        /// </summary>
        /// <param name="flag"></param>
        public void EnableEditMode(bool flag, Control.ControlCollection controls)
        {
            if (flag)
            {
                foreach (Control item in controls)
                {
                    if (item.GetType() == typeof(UltraTextEditor))
                    {

                        ((UltraTextEditor)item).ReadOnly = false;

                    }
                    else if (item.GetType() == typeof(UltraComboEditor))
                    {
                        ((UltraComboEditor)item).Enabled = true;
                    }
                    else if (item.GetType() == typeof(UltraDateTimeEditor))
                    {
                        ((UltraDateTimeEditor)item).Enabled = true;
                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control item in controls)
                {
                    if (item.GetType() == typeof(UltraTextEditor))
                    {
                        ((UltraTextEditor)item).ReadOnly = true;
                    }
                    else if (item.GetType() == typeof(UltraComboEditor))
                    {
                        ((UltraComboEditor)item).Enabled = false;
                    }
                    else if (item.GetType() == typeof(UltraDateTimeEditor))
                    {
                        ((UltraDateTimeEditor)item).Enabled = false;
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
                case OperationTypeEnum.OperationType.Add:


                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdTask
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdTask.ToString(), QX.Common.LogType.Add.ToString());


                    bmHelper.BindControlToModel<Prod_Task>(DeloyingTask, gpCmd.Controls, "");
                    bmHelper.BindControlToModel<Prod_Task>(DeloyingTask, this.groupBox1.Controls, "");

                    //下达任务参考的毛坯入库记录
                    DeloyingTask.Task_RefInv = DeployTaskingRaw.RI_Code;

                    DeloyingTask.Task_Owner = SessionConfig.UserCode;
                    DeloyingTask.Task_Date = DateTime.Now;

                    if (DeloyingTask.TaskDetail_Num > DeployTaskingRaw.RI_AvailableNum)
                    {
                        Alert.Show(string.Format("当前产品所存储毛坯数量为 {0},请重新输入数量！", DeployTaskingRaw.RI_AvailableNum));
                        return;
                    }
                    else if (DeloyingTask.TaskDetail_Num == 0)
                    {
                        Alert.Show("下达数量不能为0");
                        return;
                    }

                    if (!string.IsNullOrEmpty(DeloyingTask.TaskDetail_PartNo))
                    {
                        List<Road_Nodes> nodes = new Bll_Road_Nodes().GetRoadNodesByComponents(DeloyingTask.TaskDetail_PartNo);
                        if (nodes != null && nodes.Count == 0)
                        {
                            Alert.Show("请先维护零件工艺模板");
                            return;
                        }
                    }

                    IsEdited = false;
                    if (ptInstance.DeployProdTask(DeployTaskingRaw, DeloyingTask) > 0)
                    {
                        ProdCodeStatUpdate();

                        Alert.Show("下达任务成功!");


                        if (CallBack != null)
                        {
                            CallBack(true, null);
                        }
                        this.Close();

                    }
                    else
                    {
                        Alert.Show("填写信息有误，请确认后重新下达任务");
                    }
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
  , QX.Shared.SessionConfig.UserName
  , "localhost"
  , this.Name
  , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdTask
  , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdTask.ToString(), QX.Common.LogType.Edit.ToString());


                    bmHelper.BindControlToModel<Prod_Task>(DeloyingTask, gpCmd.Controls, "");
                    bmHelper.BindControlToModel<Prod_Task>(DeloyingTask, this.groupBox1.Controls, "");


                    if (DeloyingTask.TaskDetail_Num == 0)
                    {
                        Alert.Show("下达数量不能为0");
                        return;
                    }

                    DeloyingTask.Task_Owner = SessionConfig.UserCode;
                    DeloyingTask.Task_Date = DateTime.Now;

                    IsEdited = false;
                    if (ptInstance.Update(DeloyingTask) > 0)
                    {
                        ProdCodeStatUpdate();

                        Alert.Show(GlobalConfiguration.CNLanguage[MessageTypeEnum.EdtMessageEnum.mes_edit_sucess.ToString()]);
                        if (CallBack != null)
                        {
                            CallBack(true, null);
                        }
                        this.Close();

                    }
                    else
                    {
                        Alert.Show("填写信息有误，请确认后任务");
                    }
                    break;
            }
        }

        /// <summary>
        /// 零件编号映射表状态回写（任务编号)
        /// </summary>
        public void ProdCodeStatUpdate()
        {

            foreach (var r in prodCodeMap)
            {
                r.PMap_TaskCode = DeloyingTask.Task_Code;
                r.PMap_TaskDate = DateTime.Now;
                pdInstance.UpdateProdMap(r);
            }
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
                //MSGCon msg = new MSGCon("确定放弃保存当前编辑数据，关闭该窗口?");
                //msg.StartPosition = FormStartPosition.CenterParent;
                //msg.ShowDialog();

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
