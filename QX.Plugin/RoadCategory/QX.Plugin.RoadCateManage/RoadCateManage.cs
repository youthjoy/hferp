using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.DataModel;
using System.Reflection;
using System.Collections;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BseDict;


namespace QX.Plugin.RoadCateManage
{
    public partial class RoadCateManage :F_BseDic
    {
        public RoadCateManage()
        {
            InitializeComponent();

        }


        #region 窗体单例

        public static RoadCateManage NewForm = null;



        public static RoadCateManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new RoadCateManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void RoadCateManage_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(true, DictKeyEnum.RoadCate, SysWinEnum.DictWin);
        }


        //private void BindEvent()
        //{
        //    this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);

        //    #region ContextMenuStrip Event

        //    this.tbtnLook.Click += new System.EventHandler(this.tbtnLook_Click);

        //    this.btnTvAdd.Click += new System.EventHandler(this.btnTvAdd_Click);

        //    this.btnTvUpdate.Click += new System.EventHandler(this.btnTvUpdate_Click);

        //    this.btnGridDelete.Click += new System.EventHandler(this.btnDelete_Click);

        //    #endregion

        //    #region Treeview Event
        //    this.treeView1.MouseClick += new MouseEventHandler(this.treeView1_MouseClick);

        //    this.treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);

        //    this.treeView1.MouseDown += new MouseEventHandler(this.treeView1_MouseDown);

        //    this.treeView1.BeforeCollapse += new TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);

        //    this.treeView1.BeforeExpand += new TreeViewCancelEventHandler(this.treeView1_BeforeExpand);


        //    #endregion

        //    #region ToolBar

        //    this.commonToolBar1.AddClicked += new EventHandler(this.btnTvAdd_Click);
        //    this.commonToolBar1.EditClicked += new EventHandler(this.btnTvUpdate_Click);
        //    this.commonToolBar1.DelClicked += new EventHandler(this.btnDelete_Click);

        //    #endregion

        //}



        //#region Member

        ////字典表Bll操作对象
        //private Bll_Road_Category rcInstance = new Bll_Road_Category();

        ////private Bll_Bse_Dict _dcInstance;

        ////public Bll_Bse_Dict dcInstance
        ////{
        ////    get { return _dcInstance; }
        ////    set { _dcInstance = value; }
        ////}

        //private Road_Category _dict;

        ///// <summary>
        ///// 当前编辑或添加对应的实体数据对象
        ///// </summary>
        //public Road_Category CurrentRoadCate
        //{
        //    get { return _dict; }
        //    set { _dict = value; }
        //}

        ////树控件数据源DataTable
        //private DataTable _dtTree;

        //public DataTable DtTree
        //{
        //    get { return _dtTree; }
        //    set { _dtTree = value; }
        //}


        //private BindModelHelper _bmHelper;

        //private BindModelHelper bmHelper
        //{
        //    get { return _bmHelper; }
        //    set { _bmHelper = value; }
        //}


        //private bool _IsLevel = false;
        ///// <summary>
        ///// 是否存在层级关系（树级关系）
        ///// </summary>
        //public bool IsLevel
        //{
        //    get { return _IsLevel; }
        //    set { _IsLevel = value; }
        //}

        //#endregion



        //public void Init()
        //{


        //    SetMode(OperationTypeEnum.OperationType.Look);

        //    bmHelper = new BindModelHelper();

        //    this.treeView1.Nodes.Clear();

        //    CreateDataSource();

        //    this.treeView1.ContextMenuStrip = this.cMenu;

        //    if (DtTree.Rows.Count != 0)
        //    {
        //        InitTree(this.treeView1.Nodes, null);
        //        this.treeView1.Nodes[0].Expand();
        //    }


        //}

        //#region 初始化树控件及数据源



        //private void CreateDataSource()
        //{
        //    List<Road_Category> list = rcInstance.GetAll();

        //    DtTree = ConvertX.ToDataTable<Road_Category>(list);
        //    DtTree.TableName = "TreeViewSource";
        //}

        ///// <summary>
        ///// 初始化树控件
        ///// </summary>
        ///// <param name="Nds"></param>
        ///// <param name="parentId"></param>
        //private void InitTree(TreeNodeCollection Nds, string parentId)
        //{
        //    DataView dv = new DataView();
        //    TreeNode tmpNd;
        //    string intId;
        //    dv.Table = DtTree;
        //    if (string.IsNullOrEmpty(parentId))
        //    {
        //        dv.RowFilter = "Cate_PCode is NULL";
        //    }
        //    else
        //    {
        //        dv.RowFilter = "Cate_PCode='" + parentId + "'";
        //    }
        //    foreach (DataRowView drv in dv)
        //    {
        //        tmpNd = new TreeNode();

        //        tmpNd.Tag = drv["Cate_Code"].ToString();
        //        tmpNd.Text = drv["Cate_Name"].ToString();

        //        Nds.Add(tmpNd);
        //        //intId = drv["Cate_PCode"].ToString();
        //        InitTree(tmpNd.Nodes, tmpNd.Tag.ToString());
        //    }
        //}



        //#endregion




        //private TreeNode _selectedNode;

        ////当前选中的树节点
        //private TreeNode SelectedNode
        //{
        //    get { return _selectedNode; }
        //    set { _selectedNode = value; }
        //}

        ///// <summary>
        ///// 当前Mode（编辑、添加、查看）
        ///// </summary>
        //private OperationTypeEnum.OperationType _currentMode;

        //public OperationTypeEnum.OperationType CurrentMode
        //{
        //    get { return _currentMode; }
        //    set { _currentMode = value; }
        //}

        //private DictKeyEnum _DictKey;

        ///// <summary>
        ///// 当前窗口对应编辑的关键字
        ///// </summary>
        //public DictKeyEnum DictKey
        //{
        //    get { return _DictKey; }
        //    set { _DictKey = value; }
        //}

        //#region TreeView Event

        //private void treeView1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {


        //        treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
        //        this.SelectedNode = treeView1.SelectedNode;

        //        if (this.SelectedNode.Level == 0)
        //        {
        //            this.cMenu.Items["btnTvAdd"].Visible = true;
        //            this.cMenu.Items["tbtnLook"].Visible = false;
        //            this.cMenu.Items["btnGridDelete"].Visible = false;
        //            this.cMenu.Items["btnTvUpdate"].Visible = false;
        //        }
        //        else if (!IsLevel)
        //        {
        //            //this.cMenu.Items["tbtnLook"].Visible = false;
        //            //this.cMenu.Items["btnGridDelete"].Visible = false;
        //            this.cMenu.Items["btnTvAdd"].Visible = false;
        //            this.cMenu.Items["tbtnLook"].Visible = true;
        //            this.cMenu.Items["btnGridDelete"].Visible = true;
        //            this.cMenu.Items["btnTvUpdate"].Visible = true;
        //        }
        //        else
        //        {
        //            this.cMenu.Items["btnTvAdd"].Visible = true;
        //            this.cMenu.Items["tbtnLook"].Visible = true;
        //            this.cMenu.Items["btnGridDelete"].Visible = true;
        //            this.cMenu.Items["btnTvUpdate"].Visible = true;
        //        }

        //        this.cMenu.Items["txtNode"].Text = treeView1.SelectedNode.Text;
        //        //this.cMenu.Show();
        //    }

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
        //        this.SelectedNode = treeView1.SelectedNode;

        //        //switch (e.Clicks)
        //        //{
        //        //    case 1:
        //        //        //暂不做特殊处理
        //        //        break;
        //        //    case 2:
        //        //        //进入查看状态
        //        //        LookData();
        //        //        break;
        //        //}

        //    }
        //}




        //#region 双击事件的处理

        //private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        LookData();
        //    }
        //}

        //public int m_MouseClicks = 0;
        ////记录鼠标在myTreeView控件上按下的次数


        //private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        //{
        //    if (this.m_MouseClicks > 1)
        //    { //如果是鼠标双击则禁止结点折叠 
        //        e.Cancel = true;
        //    }
        //    else
        //    { //如果是鼠标单击则允许结点折叠 
        //        e.Cancel = false;
        //    }

        //}

        //private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        //{
        //    if (this.m_MouseClicks > 1)
        //    { //如果是鼠标双击则禁止结点展开 
        //        e.Cancel = true;
        //    }
        //    else
        //    { //如果是鼠标单击则允许结点展开 
        //        e.Cancel = false;
        //    }

        //}

        //private void treeView1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.m_MouseClicks = e.Clicks;
        //}

        //#endregion

        //#region ContextMenu


        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);
        //        //MSGCon msgCon = new MSGCon("你确定要删除该分类?");
        //        //msgCon.StartPosition = FormStartPosition.CenterParent;
        //        //msgCon.ShowDialog();

        //        DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该分类?");

        //        if (dialog == DialogResult.OK)
        //        {

        //            CurrentRoadCate = rcInstance.GetRoadCatByCode(this.SelectedNode.Tag.ToString());
        //            if (rcInstance.IsHaveChild(CurrentRoadCate))
        //            {
        //                //提示不能删除非子结点
        //                Alert.Show("请先删除子分类");
        //            }
        //            else
        //            {
        //                //todo  删除操作
        //                if (rcInstance.DeleteRoadCate(CurrentRoadCate) > 0)
        //                {
        //                    SelectedNode.Remove();
        //                    ClearTextBox();
        //                    Alert.Show("删除成功");
        //                }
        //                else
        //                {
        //                    Alert.Show("删除失败");
        //                }

        //            }
        //            //SetMode(OperationTypeEnum.OperationType.Edit);
        //            //bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);

        //        }

        //    }
        //}



        //private void btnTvUpdate_Click(object sender, EventArgs e)
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);
        //        //根节点不能编辑
        //        if (this.SelectedNode.Level == 0)
        //        {
        //            Alert.Show("根节点不能直接编辑");
        //        }
        //        else
        //        {
        //            CurrentRoadCate = rcInstance.GetRoadCatByCode(this.SelectedNode.Tag.ToString());
        //            SetMode(OperationTypeEnum.OperationType.Edit);

        //            bmHelper.BindModelToControl<Road_Category>(CurrentRoadCate, this.gpControls.Controls);
        //        }

        //    }
        //}

        //private void tbtnLook_Click(object sender, EventArgs e)
        //{
        //    //if (SelectedNode != null)
        //    //{
        //    //    //MessageBox.Show(this.SelectedNode.Text);
        //    //    Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());
        //    //    SetMode(OperationTypeEnum.OperationType.Look);

        //    //    bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);


        //    //}

        //    LookData();
        //}


        //private void btnTvAdd_Click(object sender, EventArgs e)
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);

        //        //Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());

        //        if (this.SelectedNode.Level != 0 && !IsLevel)
        //        {
        //            Alert.Show("不能添加叶子节点!");
        //        }
        //        else
        //        {
        //            CurrentRoadCate = new Road_Category();
        //            //添加的新节点对应的父节点编码
        //            CurrentRoadCate.Cate_PCode = SelectedNode.Tag.ToString();
        //            //CurrentRoadCate. = SelectedNode.Text;

        //            //SetlblMessage("添加"+Dict.Dict_PName+"子结点信息");

        //            SetMode(OperationTypeEnum.OperationType.Add);
        //        }
        //        //bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);
        //    }
        //}


        ////private void SetlblMessage(string  msg)
        ////{
        ////    this.lblMessage = msg;
        ////}

        //private void LookData()
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);
        //        CurrentRoadCate = rcInstance.GetRoadCatByCode(this.SelectedNode.Tag.ToString());
        //        SetMode(OperationTypeEnum.OperationType.Look);

        //        bmHelper.BindModelToControl<Road_Category>(CurrentRoadCate, this.gpControls.Controls);

        //    }
        //}



        //#endregion

        //#endregion

        ///// <summary>
        ///// 设置当前窗口对应Mode（添加，编辑，查看）
        ///// </summary>
        ///// <param name="mode"></param>
        //public void SetMode(OperationTypeEnum.OperationType mode)
        //{
        //    switch (mode)
        //    {
        //        case OperationTypeEnum.OperationType.Look:
        //            ClearTextBox();
        //            EnableEditMode(false);
        //            CurrentMode = OperationTypeEnum.OperationType.Look;
        //            break;
        //        case OperationTypeEnum.OperationType.Edit:
        //            ClearTextBox();
        //            EnableEditMode(true);
        //            CurrentMode = OperationTypeEnum.OperationType.Edit;
        //            break;
        //        case OperationTypeEnum.OperationType.Add:
        //            ClearTextBox();
        //            EnableEditMode(true);
        //            CurrentMode = OperationTypeEnum.OperationType.Add;
        //            break;
        //    }
        //}

        ///// <summary>
        ///// 设置文本框是否可编辑
        ///// </summary>
        ///// <param name="flag"></param>
        //public void EnableEditMode(bool flag)
        //{
        //    if (flag)
        //    {
        //        foreach (Control item in gpControls.Controls)
        //        {
        //            if (item.GetType() == typeof(TextBox))
        //            {

        //                ((TextBox)item).ReadOnly = false;

        //            }
        //            else if (item.GetType() == typeof(Button))
        //            {
        //                ((Button)item).Visible = true;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (Control item in gpControls.Controls)
        //        {
        //            if (item.GetType() == typeof(TextBox))
        //            {
        //                ((TextBox)item).ReadOnly = true;
        //            }
        //            else if (item.GetType() == typeof(Button))
        //            {
        //                ((Button)item).Visible = false;
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 清空文本框
        ///// </summary>
        //public void ClearTextBox()
        //{

        //    foreach (Control item in gpControls.Controls)
        //    {
        //        if (item.GetType() == typeof(TextBox))
        //        {
        //            if (item.GetType() == typeof(TextBox))
        //            {
        //                ((TextBox)item).Text = string.Empty;
        //            }
        //        }
        //    }

        //}


        ///// <summary>
        ///// 保存或确定按钮对应事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    int result = 0;
        //    switch (CurrentMode)
        //    {
        //        case OperationTypeEnum.OperationType.Look: break;
        //        case OperationTypeEnum.OperationType.Edit:
        //            bmHelper.BindControlToModel<Road_Category>(CurrentRoadCate, gpControls.Controls);
        //            result = rcInstance.UpdateRoadCate(CurrentRoadCate);
        //            if (result > 0)
        //            {
        //                SelectedNode.Text = CurrentRoadCate.Cate_Name;
        //                SetMode(OperationTypeEnum.OperationType.Look);
        //                Alert.Show("编辑成功");
        //            }
        //            else
        //            {
        //                //提示处理  todo
        //                Alert.Show("编辑失败");
        //            }

        //            break;
        //        case OperationTypeEnum.OperationType.Add:


        //            bmHelper.BindControlToModel<Road_Category>(CurrentRoadCate, gpControls.Controls);

        //            if (rcInstance.IsRepeatCode(CurrentRoadCate))
        //            {
        //                Alert.Show(CurrentRoadCate.Cate_Code+"已存在，请不要重复编码!");
        //                return;
        //            }

        //            result = rcInstance.AddRoadCate(CurrentRoadCate);
        //            if (result > 0)
        //            {

        //                AddTreeNode(SelectedNode, CurrentRoadCate);
        //                SelectedNode.Expand();
        //                SetMode(OperationTypeEnum.OperationType.Look);
        //                Alert.Show("添加成功");
        //            }
        //            else
        //            {
        //                //提示处理  todo
        //                Alert.Show("添加失败");
        //            }
        //            break;
        //    }
        //}

        ///// <summary>
        ///// 添加对应处理方法
        ///// </summary>
        ///// <param name="parentNode"></param>
        ///// <param name="dict"></param>
        //public void AddTreeNode(TreeNode parentNode, Road_Category dict)
        //{
        //    TreeNode tmpNd = new TreeNode();

        //    tmpNd.Tag = dict.Cate_Code;
        //    tmpNd.Text = dict.Cate_Name;

        //    parentNode.Nodes.Add(tmpNd);
        //}

        ///// <summary>
        ///// 取消按钮
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    ClearTextBox();
        //}
    }
}
