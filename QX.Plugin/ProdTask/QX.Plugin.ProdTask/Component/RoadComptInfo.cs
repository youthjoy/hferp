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
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;
using QX.Shared;

namespace QX.Plugin.RoadCateManage
{
    public partial class RoadComptInfo : F_BasicPop
    {

        private Bll_UserPermission upInstance = new Bll_UserPermission();

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
            IsBusy = false;
            BindEvent();
        }

        public bool _isBusy = false;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="DevId"></param>
        public RoadComptInfo(Bll_Road_Components instance, OperationTypeEnum.OperationType type, string rcId, bool isAuditFlag)
        {
            InitializeComponent();
            rcInstance = instance;
            OperationType = type;
            CompCode = rcId;
            IsBusy = false;
            BindEvent();

            this.isAudit = isAuditFlag;
        }

        private ToolStripButton btnConfirm = new ToolStripButton();

        private ToolStripButton btnApply = new ToolStripButton();

        private ToolStripButton btnCancel = new ToolStripButton();

        public void BindEvent()
        {

            ToolStripHelper tsHelper = new ToolStripHelper();

            this.KeyPreview = true;

            this.KeyUp += new KeyEventHandler(this.Form_KeyUp);

            btnApply.Text = "应用";
            Image image1 = global::QX.Common.Properties.Resources.OK;　　　　//从资源文件中引用
            btnApply.Image = image1;
            btnApply.Size = new Size(43, 28);
            btnApply.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            btnApply.TextImageRelation = TextImageRelation.ImageAboveText;
            btnApply.Click += new EventHandler(btnApply_Click);
            this.commonToolBar2.AddCustomControl(btnApply);

            //ToolStripButton tButton = new ToolStripButton();
            btnConfirm.Text = "保存";
            Image image = global::QX.Common.Properties.Resources.save;　　　　//从资源文件中引用
            btnConfirm.Image = image;
            btnConfirm.Size = new Size(43, 28);
            btnConfirm.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            btnConfirm.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConfirm.Click += new EventHandler(btnConfirm_Click);
            this.commonToolBar2.AddCustomControl(btnConfirm);


            btnCancel.Text = "取消";
            Image image2 = global::QX.Common.Properties.Resources.cancel;　　　　//从资源文件中引用
            btnCancel.Image = image2;
            btnCancel.Size = new Size(43, 28);
            btnCancel.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.Click += new EventHandler(btnCancel_Click);
            this.commonToolBar2.AddCustomControl(btnCancel);

            //if (OperationType == OperationTypeEnum.OperationType.Add)
            //{

            ToolStripButton msgBtn = tsHelper.New("短信通知", QX.Common.Properties.Resources.planner, new EventHandler(msgBtn_Click));

            this.commonToolBar2.AddCustomControl(msgBtn);
            //}
        }

        private Bll_Audit auInstance = new Bll_Audit();

        void msgBtn_Click(object sender, EventArgs e)
        {
            if (OperationTypeEnum.OperationType.Add == _OperationType)
            {
                Alert.Show("请先保存后再通知下一步相关审核人员!");
                return;
            }
            if (string.IsNullOrEmpty(CurrentRoadCompt.AuditCurAudit))
            {
                var model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString());
                if (model != null)
                {
                    AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), model.VT_VerifyNode_Code);
                    UserSel.Show();
                }
            }
            else
            {
                AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), CurrentRoadCompt.AuditCurAudit);
                UserSel.Show();
            }
        }


        private void RoadComptInfo_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Init();
        }


        public void Init()
        {
            FormHelper gen = new FormHelper();

            gen.GenerateForm("FComponents", this.gpCompt, new Point(6, 20));

            this.MinimizeBox = false;

            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {

                SetMode(OperationTypeEnum.OperationType.Edit);
                InitEditBind(CompCode);
                RoadComptCode = CompCode;
                TemplateInit();
                GridRefresh();
            }
            else if (OperationType == OperationTypeEnum.OperationType.Add)
            {
                SetMode(OperationTypeEnum.OperationType.Add);
                InitAddData();
                TemplateInit();
            }
            else
            {
                IsEdited = false;

                btnConfirm.Enabled = false;
                this.btnApply.Enabled = false;

                SetMode(OperationTypeEnum.OperationType.Look);
                InitLookBind(CompCode);
                RoadComptCode = CompCode;
                TemplateInit();
                GridRefresh();
            }
        }

        #region 零件维护

        public void TemplateInit()
        {
            ControlInit();
            GridInit();
            //StyleInit();
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

        private bool _IsEdited = true;

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

            CurrentRoadCompt.Comp_Code = rcInstance.GenerateComponentsCode();
            bmHelper.BindModelToControl<Road_Components>(CurrentRoadCompt, this.gpCompt.Controls, "");
            EventHandler handler = new EventHandler(this.contolValue_Changed);

            bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);

            //如果为添加状态则不需要显示“应用”按钮
            this.btnApply.Visible = false;
            //tApply.Visible = falcse;

        }



        /// <summary>
        /// 编辑模式初始化绑定
        /// </summary>
        private void InitEditBind(string code)
        {
            Road_Components rc = rcInstance.GetRoadComponentByCode(code);

            CurrentRoadCompt = rc;

            bmHelper = new BindModelHelper();
            bmHelper.BindModelToControl<Road_Components>(rc, gpCompt.Controls, "");

            EventHandler handler = new EventHandler(this.contolValue_Changed);

            bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);


        }


        /// <summary>
        /// 编辑模式初始化绑定
        /// </summary>
        private void InitLookBind(string code)
        {
            Road_Components rc = rcInstance.GetRoadComponentByCode(code);

            CurrentRoadCompt = rc;

            bmHelper = new BindModelHelper();
            bmHelper.BindModelToControl<Road_Components>(rc, gpCompt.Controls, "");

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
                //this.Comp_CatName.Text = list.Rows[0]["Dict_Name"] != null ? list.Rows[0]["Dict_Name"].ToString() : string.Empty;
                //this.Comp_CatCode.Text = list.Rows[0]["Dict_Code"] != null ? list.Rows[0]["Dict_Code"].ToString() : string.Empty;
            }
        }

        private void roadCate_Click(object sender, EventArgs e)
        {
            DataTable dtRoad = ConvertX.ToDataTable(dcInstance.GetListByDictKey(DictKeyEnum.RoadCate));
            dtRoad.TableName = "roadCateList";
            CommRoadCate user = new CommRoadCate(dtRoad, new Size(460, 380));
            user.CallBack += new CommRoadCate.DCallBackHandler(this.roadCate_Callback);
            user.ShowDialog();
        }




        //确定按钮事件
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {

                if (!isAudit && !this.IsAllowEdit(this.CompCode))
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
                    case 0:
                        Alert.Show("添加失败");
                        break;
                    case 1:
                        Alert.Show("添加成功");


                        GridRefresh();

                        //添加成功后转成编辑模式
                        SetMode(OperationTypeEnum.OperationType.Edit);

                        break;
                    case 2:
                        Alert.Show("零件图号已重复，请重新输入!");
                        break;
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
            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                          , QX.Shared.SessionConfig.UserName
                          , "localhost"
                          , this.Name
                          , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Components+"   "+CurrentRoadCompt.Comp_Code
                          , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Components.ToString(), QX.Common.LogType.Edit.ToString());


            Road_Components rc = CurrentRoadCompt;

            string code = rc.Comp_Code;

            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls, "");

            //判断是否更改编码，如果更改则判断其是否重复
            if (!CompCode.Equals(rc.Comp_Code) && this.IsRepeatCode(rc))
            {
                return 2;
            }

            if (IsBusy)
            {
                rc.Comp_IsBusy = 1;
            }

            if (rcInstance.UpdateRoadCompt(rc) >= 1)
            {
                CurrentRoadCompt = rc;

                SaveRNodes();

                //编辑成功后的处理
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


        public int AddEntity()
        {
            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                         , QX.Shared.SessionConfig.UserName
                         , "localhost"
                         , this.Name
                         , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Components
                         , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Components.ToString(), QX.Common.LogType.Add.ToString());


            Road_Components rc = CurrentRoadCompt;

            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls, "");

            if (this.IsRepeatCode(rc))
            {
                //Alert.Show("零件图号已重复，请重新输入");
                return 2;
            }

            RoadComptCode = rc.Comp_Code;
            rc.Comp_Creator = SessionConfig.UserCode;
            int re = rcInstance.AddRoadCompt(rc);

            if (re > 0)
            {

                Road_Components r = rcInstance.GetRoadComponentByCode(rc.Comp_Code);
                CurrentRoadCompt.Comp_ID = r.Comp_ID;
                

                //添加成功后设置当前Comp_Code为其最新编码
                CompCode = rc.Comp_Code;

                SaveRNodes();

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
                    this.btnConfirm.Visible = false;
                    this.btnApply.Enabled = false;
                    this.btnCancel.Visible = true;

                    OperationType = OperationTypeEnum.OperationType.Look;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    this.commonToolBar1.Visible = true;
                    this.btnConfirm.Visible = true;
                    this.btnApply.Visible = true;
                    this.btnCancel.Visible = true;
                    OperationType = OperationTypeEnum.OperationType.Edit;
                    break;
                case OperationTypeEnum.OperationType.Add:
                    this.commonToolBar1.Visible = true;
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
                    if (item.GetType() == typeof(UltraTextEditor))
                    {

                        ((UltraTextEditor)item).ReadOnly = false;

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
                    if (item.GetType() == typeof(UltraTextEditor))
                    {
                        ((UltraTextEditor)item).ReadOnly = true;
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
            //this.commonToolBar1.AddCustomControl(tButton);

            tButton.Click += new EventHandler(this.btnRoadNodeImport_Click);



            ToolStripButton tButton1 = new ToolStripButton();
            tButton1.Text = "检测参数维护";
            Image image1 = global::QX.Common.Properties.Resources.compedit;　　　　//从资源文件中引用
            tButton1.Image = image1;
            tButton1.Size = new Size(43, 28);
            tButton1.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            //this.commonToolBar1.AddCustomControl(tButton1);

            tButton1.Click += new EventHandler(this.btnRoadTestRefImport_Click);


            ToolStripHelper tsHelper = new ToolStripHelper();



            ToolStripButton AddNodeBtn = tsHelper.New("插入工序节点", QX.Common.Properties.Resources.import, new EventHandler(AddNodeBtn_Click));
            this.commonToolBar1.AddCustomControl(AddNodeBtn);
            if (OperationType == OperationTypeEnum.OperationType.Look)
            {
                AddNodeBtn.Enabled = false;
            }
            ToolStripButton batchDeptBtn = tsHelper.New("批量调整部门", QX.Common.Properties.Resources.import, new EventHandler(batchDeptBtn_Click));
            //this.commonToolBar1.AddCustomControl(batchDeptBtn);


            if (OperationType == OperationTypeEnum.OperationType.Look)
            {
                tButton.Enabled = false;
                tButton1.Enabled = false;
            }

            #endregion
        }

        /// <summary>
        /// 批量调整部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void batchDeptBtn_Click(object sender, EventArgs e)
        {

        }

        void AddNodeBtn_Click(object sender, EventArgs e)
        {
            if (OperationTypeEnum.OperationType.Add == _OperationType)
            {
                Alert.Show("请先保存后再维护工序信息");
                return;
            }

            if (!this.IsAllowEdit(this.CompCode))
            {
                Alert.Show("当前零件图号正在审核中，不能进行工艺路线编辑操作!");
                return;
            }

            CommRoadNodes frm = new CommRoadNodes();

            frm.ShowDialog();

            if (frm.IsChanged)
            {
                IsEdited = true;
                Dictionary<string, int> nodeList = frm.CurNodeDict;
                List<Road_Nodes> repeatNodes = new List<Road_Nodes>();
                List<Road_Nodes> list = new List<Road_Nodes>();
                foreach (UltraGridRow row in this.uGridTemlate.Rows)
                {
                    Road_Nodes node = row.ListObject as Road_Nodes;
                    if (!string.IsNullOrEmpty(node.RNodes_Code) && nodeList.ContainsKey(node.RNodes_Code))
                    {
                        //Alert.Show("与现有工序存在重复,请确认后重新导入");
                        repeatNodes.Add(node);
                        continue;
                    }

                    node.RNodes_Stat = 1;
                    list.Add(node);
                }

                if (repeatNodes.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("您刚才导入的工序(");
                    StringBuilder ns = new StringBuilder();
                    foreach (var n in repeatNodes)
                    {
                        ns.Append(n.RNodes_Name + ",");
                    }
                    sb.Append(ns.ToString().TrimEnd(',') + ")与现有工序存在重复,确定要插入吗?");

                    if (!Alert.ShowIsConfirm(sb.ToString()))
                    {
                        return;
                    }
                }

                rnInstance.AddNewRoadNodes(RoadComptCode, list, frm.CurNodeDict, frm.CurNodeTimeCostDict);

                this.GridRefresh();
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void GridRefresh()
        {
            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = CurGridDataSource;

            uGridTemlate.DataSource = dataSource;

            IsHavePriceAudit();
        }


        UltraGrid uGridTemlate = new UltraGrid();

        public void GridInit()
        {
            List<Road_Nodes> list = new List<Road_Nodes>();

            GridHelper gen = new GridHelper();

            uGridTemlate = gen.GenerateGrid("GNodes", this.pnlGrid, new Point(0, 0));
            uGridTemlate.InitializeRow += new InitializeRowEventHandler(uGridTemlate_InitializeRow);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;

            uGridTemlate.DataSource = dataSource;

            uGridTemlate.CellChange += new CellEventHandler(uGridTemlate_CellChange);

            gen.SetGridReadOnly(uGridTemlate, false);

            gen.SetGridColumnStyle(uGridTemlate, AutoFitStyle.ExtendLastColumn);

            uGridTemlate.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

            IsHavePriceAudit();
        }

        public void IsHavePriceAudit()
        {
            //if (isAudit)
            //{
            if (upInstance.IsHavePermission(SessionConfig.UserName, "RoadPrice_Prod"))
            {
                uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Udef1"].Hidden = false;
            }

            if (upInstance.IsHavePermission(SessionConfig.UserName, "RoadPrice_Fin"))
            {
                uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Udef2"].Hidden = false;
            }

            //如果没有权限则隐藏
            if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, "RoadPrice"))
            {
                uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Value"].Hidden = false;
            }
            else
            {
                uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Value"].Hidden = true;
            }

            //如果没有权限则隐藏
            if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, "RoadTimeCost"))
            {
                uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_TimeCost"].Hidden = false;
            }
            else
            {
                uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_TimeCost"].Hidden = true;
            }



            //if (!upInstance.IsHavePermission(SessionConfig.UserName, "RoadTimeCost"))
            //{
            //    uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_TimeCost"].Hidden = true;
            //}

            List<Sys_Map> list = new Bll_Sys_Map().GetListByCode(string.Format(" AND Map_Module='RoadCompPermission'"));
            if (list != null)
            {
                //权限配置
                foreach (var d in list)
                {
                    ///工票回收权限
                    if (upInstance.IsAdmin(SessionConfig.UserCode) || upInstance.IsHavePermission(SessionConfig.UserName, d.Map_Object1))
                    {
                        this.uGridTemlate.DisplayLayout.Bands[0].Columns[d.Map_Object2].Hidden = false;
                        this.uGridTemlate.DisplayLayout.Bands[0].Columns[d.Map_Object2].CellClickAction = CellClickAction.Edit;
                    }
                    else
                    {
                        this.uGridTemlate.DisplayLayout.Bands[0].Columns[d.Map_Object2].CellClickAction = CellClickAction.RowSelect;
                        this.uGridTemlate.DisplayLayout.Bands[0].Columns[d.Map_Object2].Hidden = true;

                    }
                }
            }
            //}
        }

        void uGridTemlate_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Road_Nodes rn = e.Row.ListObject as Road_Nodes;
            if (rn.RNodes_Stat == 1)
            {
                e.Row.Appearance.BackColor = Color.Wheat;
            }
         

        }

        void uGridTemlate_CellChange(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "RNodes_Value" || e.Cell.Column.Key == "RNodes_TimeCost")
            {
                decimal time = QX.Common.C_Class.Utils.TypeConverter.ObjectToDecimal(e.Cell.Row.Cells["RNodes_TimeCost"].Value.ToString());
                decimal money = 0;
                if (e.Cell.Row.Cells["RNodes_Value"].Value != null)
                {
                    money = decimal.Parse(e.Cell.Row.Cells["RNodes_Value"].Value.ToString());
                }
                e.Cell.Row.Cells["RNodes_Cost"].Value = time * money;

                //e.Cell.Row.Appearance.BackColor = Color.Wheat;

            }

            //if (e.Cell.Column.Key == "RNodes_Cost" ||e.Cell.Column.Key == "RNodes_Value" || e.Cell.Column.Key == "RNodes_Cost" || e.Cell.Column.Key == "RNodes_TimeCost")
            //{
            Road_Nodes rn = e.Cell.Row.ListObject as Road_Nodes;
            if (rn.RNodes_Stat != 1)
            {

                e.Cell.Row.Appearance.BackColor = Color.Wheat;

                if (!string.IsNullOrEmpty(rn.RNodes_Code))
                {
                    rn.RNodes_Stat = 1;
                    rnInstance.UpdateRoadNode(rn);
                }
            }
            //}

        }

        public void AddCustomizeColumn()
        {

            if (!this.uGridTemlate.DisplayLayout.Bands[0].Columns.Exists("TestRef"))
            {
                this.uGridTemlate.DisplayLayout.Bands[0].Columns.Add("TestRef", "");
                UltraGridColumn col = this.uGridTemlate.DisplayLayout.Bands[0].Columns["TestRef"];

                col.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;

                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                col.Width = 16;
                col.DataType = typeof(object);
                System.Drawing.Image image = global::QX.Common.Properties.Resources.compedit;　　　　//从资源文件中引用
                col.CellButtonAppearance.Image = image;
                col.Header.VisiblePosition = 0;
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


        private void SaveRNodes()
        {
            List<Road_Nodes> list = new List<Road_Nodes>();
            foreach (UltraGridRow row in this.uGridTemlate.Rows)
            {
                Road_Nodes node = row.ListObject as Road_Nodes;
                list.Add(node);
            }

            rnInstance.AddOrUpdateRoadNodes(CurrentRoadCompt, list);
        }

        /// <summary>
        /// 零件图号工序导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoadTestRefImport_Click(object sender, EventArgs e)
        {
            if (this.uGridTemlate.ActiveRow != null)
            {
                ImportRoadTestRefHandle(this.uGridTemlate.ActiveRow.Index);
            }
        }

        /// <summary>
        /// 工序导入处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnRoadNodeImport_Click(object sender, EventArgs e)
        {
            if (OperationTypeEnum.OperationType.Add == _OperationType)
            {
                Alert.Show("请先保存后再维护工序信息");
                return;
            }

            if (!this.IsAllowEdit(this.CompCode))
            {
                Alert.Show("当前零件图号正在审核中，不能进行工艺路线编辑操作!");
                return;
            }

            Dictionary<string, int> nodeDic = new Dictionary<string, int>();
            Dictionary<string, string> timeCostDic = new Dictionary<string, string>();

            foreach (Road_Nodes r in CurGridDataSource)
            {
                if (!nodeDic.ContainsKey(r.RNodes_Code) && !timeCostDic.ContainsKey(r.RNodes_Code))
                {
                    nodeDic.Add(r.RNodes_Code, r.RNodes_Order);

                    timeCostDic.Add(r.RNodes_Code, r.RNodes_TimeCost.ToString());

                }
            }

            CommRoadNodes frm = new CommRoadNodes(nodeDic, timeCostDic);

            frm.ShowDialog();

            if (frm.IsChanged)
            {
                IsEdited = true;

                //foreach (UltraGridRow row in this.uGridTemlate.Rows)
                //{
                //    Road_Nodes n = row.ListObject as Road_Nodes;

                //}


                //rnInstance.AddOrUpdateRoadNodes(RoadComptCode, frm.CurNodeDict, frm.CurNodeTimeCostDict);
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
