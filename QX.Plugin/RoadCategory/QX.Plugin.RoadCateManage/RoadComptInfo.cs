using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX.DataModel;
using QX.BLL;
using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
namespace QX.Plugin.RoadCateManage
{
    public partial class RoadComptInfo : F_BasicPop
    {
        public RoadComptInfo()
        {
            InitializeComponent();
        }




        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="DevId"></param>
        public RoadComptInfo(Bll_Road_Components instance, OperationTypeEnum.OperationType type, string rcId)
        {
            InitializeComponent();
            rcInstance = instance;
            OperationType = type;
            CompCode = rcId;

            BindEvent();

        }

        public void BindEvent()
        {
            this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);

            this.btnApply.Click += new EventHandler(this.btnApply_Click);

            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.KeyPreview = true;

            this.KeyUp += new KeyEventHandler(this.Form_KeyUp);

            this.Comp_CatName.Click += new EventHandler(this.roadCate_Click);

            //this.uGridTemlate.ClickCellButton += new CellEventHandler(uGridTemlate_ClickCellButton);

        }


        private void RoadComptInfo_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Init();
        }


        public void Init()
        {


            this.MinimizeBox = false;

            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {

                SetMode(OperationTypeEnum.OperationType.Edit);
                InitEditBind(CompCode);
                TemplateInit();
            }
            else
            {
                SetMode(OperationTypeEnum.OperationType.Add);
                //StyleInit();
                this.uGridTemlate.DisplayLayout.GroupByBox.Hidden = true;
                InitAddData();
            }
        }


        public void TemplateInit()
        {
            RoadComptCode = CompCode;
            ControlInit();
            GridInit();
            StyleInit();
        }

        #region 零件维护

        private BindModelHelper _bmHelper;

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }



        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Road_Components rcInstance = new Bll_Road_Components();

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        /// <summary>
        /// 操作类型
        /// </summary>
        private OperationTypeEnum.OperationType _OperationType;

        public OperationTypeEnum.OperationType OperationType
        {
            get { return _OperationType; }
            set { _OperationType = value; }
        }


        //零件编号
        private string _CompCode;

        public string CompCode
        {
            get { return _CompCode; }
            set { _CompCode = value; }
        }


        private Road_Components _RoadCompt = null;

        /// <summary>
        /// 当前窗体对应的编辑实体对象（）
        /// </summary>
        public Road_Components CurrentRoadCompt
        {
            get { return _RoadCompt; }
            set { _RoadCompt = value; }
        }

        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }




        #region 数据初始化







        /// <summary>
        /// 添加模式初始化
        /// </summary>
        private void InitAddData()
        {
            bmHelper = new BindModelHelper();

            CurrentRoadCompt = new Road_Components();

            EventHandler handler = new EventHandler(this.contolValue_Changed);

            bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);

            //如果为添加状态则不需要显示“应用”按钮
            this.btnApply.Visible = false;
        }



        /// <summary>
        /// 编辑模式初始化绑定
        /// </summary>
        private void InitEditBind(string code)
        {
            Road_Components rc = rcInstance.GetRoadComponentByCode(code);

            CurrentRoadCompt = rc;

            bmHelper = new BindModelHelper();
            bmHelper.BindModelToControl<Road_Components>(rc, gpCompt.Controls);

            EventHandler handler = new EventHandler(this.contolValue_Changed);

            bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);
        }


        #endregion

        #region 按钮控件事件

        /// <summary>
        /// 控件值发生变化时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contolValue_Changed(object sender, EventArgs e)
        {
            IsEdited = true;
        }


        private void roadCate_Callback(object sender, DataTable list)
        {
            if (list != null && list.Rows.Count > 0)
            {
                this.Comp_CatName.Text = list.Rows[0]["Dict_Name"] != null ? list.Rows[0]["Dict_Name"].ToString() : string.Empty;
                this.Comp_CatCode.Text = list.Rows[0]["Dict_Code"] != null ? list.Rows[0]["Dict_Code"].ToString() : string.Empty;
            }
        }

        private void roadCate_Click(object sender, EventArgs e)
        {
            DataTable dtRoad = ConvertX.ToDataTable(dcInstance.GetListByDictKey(DictKeyEnum.RoadCate));
            dtRoad.TableName = "roadCateList";
            //DataTable dtUser = ConvertX.ToDataTable(employeeInstance.GetAllEmployee());
            //dtUser.TableName = "userlist";
            CommRoadCate user = new CommRoadCate(dtRoad, new Size(460, 380));
            user.CallBack += new CommRoadCate.DCallBackHandler(this.roadCate_Callback);
            user.ShowDialog();
        }




        //确定按钮事件
        private void btnConfirm_Click(object sender, EventArgs e)
        {







            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {

                if (!this.IsAllowEdit(this.CompCode))
                {
                    Alert.Show("当前零件图号正在审核中，不能进行编辑操作!");
                    return;
                }


                //数据是否有效，否则返回
                if (!ValidateData())
                {
                    return;
                }
                switch (EditEntity())
                {
                    case 0: Alert.Show("编辑失败"); break;
                    case 1:
                        Alert.Show("编辑成功");
                        //this.Close(); 
                        break;
                    case 2: Alert.Show("零件图号已重复，请重新输入!"); break;
                }


            }//添加处理
            else
            {

                //数据是否有效，否则返回
                if (!ValidateData())
                {
                    return;
                }

                switch (AddEntity())
                {
                    case 0: Alert.Show("添加失败"); break;
                    case 1:
                        Alert.Show("添加成功");
                        TemplateInit();
                        ////添加成功后设置不可用，即一次添加一个不允许重复添加
                        //this.btnConfirm.Enabled = false;
                        //this.btnCancel.Enabled = false;

                        //添加成功后转成编辑模式
                        SetMode(OperationTypeEnum.OperationType.Edit);

                        break;
                    case 2: Alert.Show("零件图号已重复，请重新输入!"); break;
                }


            }

        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
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

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            //数据是否有效，否则返回
            if (!ValidateData())
            {
                return;
            }


            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {


                switch (EditEntity())
                {
                    case 0: Alert.Show("编辑失败"); break;
                    case 1: Alert.Show("编辑成功"); break;
                    case 2: Alert.Show("零件图号已重复，请重新输入!"); break;
                }


            }//添加处理
            else
            {
                //AddEntity();


                switch (AddEntity())
                {
                    case 0: Alert.Show("添加失败"); break;
                    case 1:
                        Alert.Show("添加成功");
                        //添加成功后设置不可用，即一次添加一个不允许重复添加
                        this.btnConfirm.Enabled = false;

                        //this.Close(); 
                        break;
                    case 2: Alert.Show("零件图号已重复，请重新输入!"); break;
                }

            }
        }

        private bool ValidateData()
        {
            #region 数据有效性验证

            bool flag = true;

            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("Comp_Code", new ValidateModel(true, 20, 0, new string[] { "零件图号不能为空", "设备编号字符数不能超过20个" }));
            dict.Add("Comp_Name", new ValidateModel(true, 20, 0, new string[] { "；零件名称不能为空", "设备名称字符数不能超过20个" }));
            //dict.Add("

            Dictionary<string, string> re = ValidateControlHelper.Validate(gpCompt.Controls, dict);

            if (re.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<string, string> k in re)
                {
                    //Control c = this.Controls.Find("lb" + k, true);
                    sb.AppendLine(k.Value);
                }

                Alert.Show(sb.ToString());

                flag = false;
            }

            return flag;

            #endregion
        }

        public bool IsRepeatCode(Road_Components rc)
        {
            return rcInstance.IsRepeatCode(rc);
        }

        private int EditEntity()
        {
            Road_Components rc = CurrentRoadCompt;

            string code = rc.Comp_Code;

            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls);

            //判断是否更改编码，如果更改则判断其是否重复
            if (!code.Equals(rc.Comp_Code) && this.IsRepeatCode(rc))
            {
                return 2;
            }


            if (rcInstance.UpdateRoadCompt(rc) >= 1)
            {
                CurrentRoadCompt = rc;
                //编辑成功后的处理
                IsEdited = false;
                //Alert.Show("编辑成功!");
                return 1;

            }
            else
            {
                //失败原因显示
                //todo
                return 0;
            }

        }


        public int AddEntity()
        {
            Road_Components rc = CurrentRoadCompt;

            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls);

            if (this.IsRepeatCode(rc))
            {
                //Alert.Show("零件图号已重复，请重新输入");
                return 2;
            }

                      
            int re = rcInstance.AddRoadCompt(rc);



            if (re > 0)
            {
                //添加成功后设置当前Comp_Code为其最新编码
                CompCode = rc.Comp_Code;
                IsEdited = false;
                return 1;

            }
            else
            {
                //失败原因显示
                //todo
                return 0;
            }
        }

        #endregion

        private OperationTypeEnum.OperationType _currentMode;

        public OperationTypeEnum.OperationType CurrentMode
        {
            get { return _currentMode; }
            set { _currentMode = value; }
        }

        public void SetMode(OperationTypeEnum.OperationType mode)
        {
            switch (mode)
            {
                case OperationTypeEnum.OperationType.Look:
                    //ClearTextBox();
                    //EnableEditMode(false);
                    OperationType = OperationTypeEnum.OperationType.Look;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    //ClearTextBox();
                    //EnableEditMode(true);
                    this.commonToolBar1.Visible = true;
                    this.Comp_Code.ReadOnly = true;
                    this.btnConfirm.Visible = true;
                    this.btnApply.Visible = true;
                    this.btnCancel.Visible = true;
                    OperationType = OperationTypeEnum.OperationType.Edit;
                    break;
                case OperationTypeEnum.OperationType.Add:
                    //ClearTextBox();
                    //EnableEditMode(true);
                    this.commonToolBar1.Visible = false;
                    this.Comp_Code.ReadOnly = false;
                    this.btnConfirm.Visible = true;
                    this.btnApply.Visible = false;
                    this.btnCancel.Visible = true;
                    OperationType = OperationTypeEnum.OperationType.Add;
                    break;
            }
        }


        public void EnableEditMode(bool flag)
        {
            if (flag)
            {
                foreach (Control item in gpCompt.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {

                        ((TextBox)item).ReadOnly = false;

                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control item in gpCompt.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).ReadOnly = true;
                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = false;
                    }
                }
            }
        }

        public void ClearTextBox()
        {

            foreach (Control item in gpCompt.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Text = string.Empty;
                    }
                }
            }

        }


        #endregion


        #region 工艺路线维护



        #region Member

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private Bll_Dept deptInstance = new Bll_Dept();


        private Bll_Road_TestRef rtInstance = new Bll_Road_TestRef();

        private string _roadComptCode;
        /// <summary>
        /// 当前对应的零件图号
        /// </summary>
        public string RoadComptCode
        {
            get { return _roadComptCode; }
            set { _roadComptCode = value; }
        }



        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }


        private Dictionary<string, string> _rnDicColumn;
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> RNDicColumn
        {
            get { return _rnDicColumn; }
            set { _rnDicColumn = value; }
        }


        private List<Road_Nodes> _CurGridDataSource;

        public List<Road_Nodes> CurGridDataSource
        {
            get { return _CurGridDataSource; }
            set { _CurGridDataSource = value; }
        }

        #endregion

        #region 数据初始化


        //public void Init()
        //{
        //    GridInit();
        //}

        public void ControlInit()
        {
            #region 工艺路线

            ToolStripButton tButton = new ToolStripButton();
            tButton.Text = "工艺导入";
            Image image = global::QX.Common.Properties.Resources.import;　　　　//从资源文件中引用
            tButton.Image = image;
            tButton.Size = new Size(43, 28);
            tButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar1.AddCustomControl(tButton);

            tButton.Click += new EventHandler(this.btnRoadNodeImport_Click);


            ToolStripButton tButton1 = new ToolStripButton();
            tButton1.Text = "检测参数维护";
            Image image1 = global::QX.Common.Properties.Resources.compedit;　　　　//从资源文件中引用
            tButton1.Image = image1;
            tButton1.Size = new Size(43, 28);
            tButton1.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar1.AddCustomControl(tButton1);

            tButton1.Click += new EventHandler(this.btnRoadTestRefImport_Click);
            #region ultragrid

            //this.uGridTemlate.BeforeEnterEditMode += new CancelEventHandler(uGridTemlate_BeforeEnterEditMode);


            //GridEventInit();

            #endregion


            #endregion
        }

        public void GridRefresh()
        {
            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);
            this.gHandler.BindData(CurGridDataSource, RNDicColumn, false);
            this.uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Dept_Name"].CellClickAction = CellClickAction.Edit;
            AddCustomizeColumn();
            //GridInit();
        }

        /// <summary>
        /// Grid事件初始化
        /// </summary>
        private void GridEventInit()
        {
            #region ultragrid

            //this.uGridTemlate.BeforeEnterEditMode += new CancelEventHandler(uGridTemlate_BeforeEnterEditMode);

            this.uGridTemlate.BeforeEnterEditMode += new CancelEventHandler(uGridTemlate_BeforeEnterEditMode);

            this.uGridTemlate.ClickCellButton += new CellEventHandler(uGridTemlate_ClickCellButton);

            #endregion
        }

        public void GridInit()
        {
            //GridInit();
            GridEventInit();
            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);
            ///初始化GridHandler
            gHandler = new GridHandler(this.uGridTemlate);
            RNDicColumn = new Dictionary<string, string>();
            //DicColumn.Add("RNodes_PartCode", "零件图号");
            RNDicColumn.Add("RNodes_Name", "工艺名称");
            RNDicColumn.Add("RNodes_Code", "工艺编码");
            RNDicColumn.Add("RNodes_Order", "工艺节点顺序");
            RNDicColumn.Add("RNodes_Dept_Name", "生产部门");
            RNDicColumn.Add("RNodes_TimeCost", "生产所需时间(小时)");
            RNDicColumn.Add("RNodes_Class_Name", "班组名称");
            RNDicColumn.Add("RNodes_Cost", "成本价格");
            //this.gHandler.BindData<Road_Nodes>(CurGridDataSource, false);

            this.gHandler.BindData(CurGridDataSource, RNDicColumn, false);

            this.uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Dept_Name"].CellClickAction = CellClickAction.Edit;
            this.uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Class_Name"].CellClickAction = CellClickAction.Edit;

            AddCustomizeColumn();
        }

        public void AddCustomizeColumn()
        {

            //UltraGridColumn ImageColumn = new UltraGridColumn();

            this.uGridTemlate.DisplayLayout.Bands[0].Columns.Add("TestRef", "");
            UltraGridColumn col = this.uGridTemlate.DisplayLayout.Bands[0].Columns["TestRef"];

            col.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;

            col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            col.Width = 16;
            col.DataType = typeof(object);
            System.Drawing.Image image = global::QX.Common.Properties.Resources.compedit;　　　　//从资源文件中引用
            col.CellButtonAppearance.Image = image;

            //col.NullText = "0";
            //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            //col.DataType = typeof(bool);
            col.DefaultCellValue = "";
            //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never;
            col.AllowRowFiltering = DefaultableBoolean.False;
            //col.Swap(this.uGridTemlate.DisplayLayout.Bands[0].Columns[0]);
            col.CellClickAction = CellClickAction.Edit;
        }


        public void StyleInit()
        {
            //gh.BindData(list);
            gHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            gHandler.SetExcelStyleFilter();
        }

        #endregion


        void uGridTemlate_ClickCellButton(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "TestRef")
            {
                ImportRoadTestRefHandle(e.Cell.Row.Index);
            }
        }

        /// <summary>
        /// 工艺节点检测参数导入更新
        /// </summary>
        /// <param name="rowIndex"></param>
        private void ImportRoadTestRefHandle(int rowIndex)
        {

            if (!this.IsAllowEdit(this.CompCode))
            {
                Alert.Show("当前零件图号正在审核中，不能对其工艺路线相关信息进行编辑操作!");
                return;
            }

            int curRowIndex = rowIndex;
            UltraGridRow row = this.uGridTemlate.Rows[curRowIndex];
            string nodeCode = row.Cells["RNodes_Code"].Value.ToString();
            string compt = RoadComptCode;
            Dictionary<string, Road_TestRef> nodeTestDic = new Dictionary<string, Road_TestRef>();
            List<Road_TestRef> testRefList = rtInstance.GetTestRefListByNodeCode(compt, nodeCode);
            foreach (Road_TestRef rt in testRefList)
            {
                nodeTestDic.Add(rt.TestRef_Code, rt);
            }

            CommRoadTest rFrm = new CommRoadTest(RoadComptCode, nodeCode, nodeTestDic);

            rFrm.ShowDialog();

            if (rFrm.IsChanged && rFrm.RoadTestList.Count > 0)
            {
                rtInstance.AddOrUpdateRoadNodesTestRef(RoadComptCode, nodeCode, rFrm.RoadTestList);
            }
        }


        private void btnRoadTestRefImport_Click(object sender, EventArgs e)
        {
            if (this.uGridTemlate.ActiveRow != null)
            {
                ImportRoadTestRefHandle(this.uGridTemlate.ActiveRow.Index);
            }
        }

        public void btnRoadNodeImport_Click(object sender, EventArgs e)
        {
            //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体
            //UltraGridRow row = this.uGridTemlate.ActiveRow;

            //if (row != null && row.Cells["Comp_Code"].Value != null)
            //{
            //    //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
            //    string id = row.Cells["Comp_Code"].Value.ToString();

            //判断是否可以编辑
            if (!this.IsAllowEdit(this.CompCode))
            {
                Alert.Show("当前零件图号正在审核中，不能进行工艺路线编辑操作!");
                return;
            }


            Dictionary<string, int> nodeDic = new Dictionary<string, int>();
            Dictionary<string, string> timeCostDic = new Dictionary<string, string>();

            foreach (Road_Nodes r in CurGridDataSource)
            {

                nodeDic.Add(r.RNodes_Code, r.RNodes_Order);

                timeCostDic.Add(r.RNodes_Code, r.RNodes_TimeCost.ToString());
            }

            CommRoadNodes frm = new CommRoadNodes(nodeDic, timeCostDic);

            frm.ShowDialog();

            if (frm.IsChanged)
            {
                rnInstance.AddOrUpdateRoadNodes(RoadComptCode, frm.CurNodeDict, frm.CurNodeTimeCostDict);

                this.GridRefresh();
            }
        }


        private void uGridTemlate_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {

            if (!this.IsAllowEdit(this.CompCode))
            {
                Alert.Show("当前零件图号正在审核中，不能对其工艺路线信息进行编辑操作!");
                return;
            }


            UltraGridRow row = this.uGridTemlate.ActiveRow;
            UltraGridCell cell = this.uGridTemlate.ActiveCell;
            if (row != null && cell.Column.Key == "RNodes_Dept_Name")
            {
                CommDept<Bll_Dept, Bse_Department> CommDept = new CommDept<Bll_Dept, Bse_Department>(deptInstance,
                new Size(350, 350));
                CommDept.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(CommDept_CallBack);
                CommDept.ShowDialog();

     
            }
            else if (row != null && cell != null && cell.Column.Key == "RNodes_Class_Name")
            {
                CommDept<Bll_Dept, Bse_Department> ClassNameFrm = new CommDept<Bll_Dept, Bse_Department>(deptInstance,
            new Size(350, 350));
                ClassNameFrm.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(ClassNameFrm_CallBack);
                ClassNameFrm.ShowDialog();
            }

            e.Cancel = true;

        }

        void ClassNameFrm_CallBack(object sender, DataTable list)
        {
            if (list.Rows.Count == 1)
            {

                UltraGridRow row = this.uGridTemlate.ActiveRow;

                if (row != null)
                {
                    row.Cells["RNodes_Class_Name"].Value = list.Rows[0]["Dept_Name"].ToString();
                    row.Cells["RNodes_Class_Code"].Value = list.Rows[0]["Dept_Code"].ToString();
                    //当前行对应工艺节点编码
                    string tmpCode = row.Cells["RNodes_Code"].Value.ToString();
                    //更新该工艺对应部门信息
                    Road_Nodes rn = row.ListObject as Road_Nodes;
                    //rnInstance.UpdateDept(RoadComptCode, tmpCode, list.Rows[0]["Dept_Code"].ToString(), list.Rows[0]["Dept_Name"].ToString());
                    rnInstance.UpdateRoadCompt(rn);
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

                UltraGridRow row = this.uGridTemlate.ActiveRow;

                if (row != null)
                {
                    row.Cells["RNodes_Dept_Name"].Value = list.Rows[0]["Dept_Name"].ToString();
                    row.Cells["RNodes_Dept_Code"].Value = list.Rows[0]["Dept_Code"].ToString();
                    //当前行对应工艺节点编码
                    string tmpCode = row.Cells["RNodes_Code"].Value.ToString();
                    //更新该工艺对应部门信息
                    rnInstance.UpdateDept(RoadComptCode, tmpCode, list.Rows[0]["Dept_Code"].ToString(), list.Rows[0]["Dept_Name"].ToString());
                }
            }
        }
        #endregion


        public bool IsAllowEdit(string code)
        {
            return rcInstance.IsAllowEdit(code);
        }
    }
}
