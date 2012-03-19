using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;
using System.Diagnostics;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Class;
using QX.BseDict;

namespace QX.Plugin.FailureManage
{
    public partial class EqufailureCat :F_BseDic
    {
        public EqufailureCat()
        {
            InitializeComponent();
            //this.ultraGrid1.DoubleClick += new System.EventHandler(this.ultraGrid1_DoubleClick);
            //this.commonToolBar1.AddClicked += new EventHandler(this.btnTvAdd_Click);
            //this.commonToolBar1.EditClicked += new EventHandler(this.btnTvUpdate_Click);
            //this.commonToolBar1.DelClicked += new EventHandler(this.btnGridDelete_Click);
        }


        private void EqufailureCat_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(true, DictKeyEnum.FailureCat, SysWinEnum.DictWin);
        }
        //private Bll_Equ_FailureCat fcInstance = new Bll_Equ_FailureCat();

        ////public GridHandler gHandler
        ////{
        ////    get;
        ////    set;
        ////}
        //private BindModelHelper _bmHelper;

        //private BindModelHelper bmHelper
        //{
        //    get { return _bmHelper; }
        //    set { _bmHelper = value; }
        //}

        //private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        //private DataTable _dtTree;


        //public DataTable DtTree
        //{
        //    get { return _dtTree; }
        //    set { _dtTree = value; }
        //}


        //#region 窗体单例
        //public static EqufailureCat NewForm = null;



        //public static EqufailureCat Instance()
        //{
        //    if (NewForm == null || NewForm.IsDisposed == true)
        //    {

        //        NewForm = new EqufailureCat();
        //    }
        //    else
        //    {
        //        NewForm.Activate();
        //    }
        //    return NewForm;
        //}

        //#endregion




        //private void EqufailureCat_Load(object sender, EventArgs e)
        //{
        //    //this.WindowState = FormWindowState.Normal;
        //    this.MinimizeBox = false;
        //    this.MaximizeBox = false;
        //    //InitGrid();


        //    //this.Refresh();
        //    Init();
        //}

        //public void Init()
        //{

        //    SetMode(OperationTypeEnum.OperationType.Look);
        //    bmHelper = new BindModelHelper();

        //    this.tvFailureCat.Nodes.Clear();

        //    CreateDataSource();

        //    this.tvFailureCat.ContextMenuStrip = this.cMenu;

        //    if (DtTree.Rows.Count != 0)
        //    {
        //        InitTree(this.tvFailureCat.Nodes, null);
        //        this.tvFailureCat.Nodes[0].Expand();
        //    }

        //}

        //private void CreateDataSource()
        //{
        //    List<Bse_Dict> list = fcInstance.GetFailureCatList();

        //    DtTree = ConvertX.ToDataTable<Bse_Dict>(list);
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
        //        dv.RowFilter = "Dict_PCode is null";
        //    }
        //    else
        //    { 
        //        dv.RowFilter = "Dict_PCode='" + parentId + "'";
        //    }
            
        //    foreach (DataRowView drv in dv)
        //    {
        //        tmpNd = new TreeNode();

        //        tmpNd.Tag = drv["Dict_Code"].ToString();
        //        tmpNd.Text = drv["Dict_Name"].ToString();

        //        Nds.Add(tmpNd);
        //        intId = drv["Dict_PCode"].ToString();
        //        InitTree(tmpNd.Nodes, tmpNd.Tag.ToString());
        //    }
        //}

        //private TreeNode _selectedNode;

        //private TreeNode SelectedNode
        //{
        //    get { return _selectedNode; }
        //    set { _selectedNode = value; }
        //}

        //private OperationTypeEnum.OperationType _currentMode;

        //public OperationTypeEnum.OperationType CurrentMode
        //{
        //    get { return _currentMode; }
        //    set { _currentMode = value; }
        //}

        //private void tvFailureCat_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {


        //        tvFailureCat.SelectedNode = tvFailureCat.GetNodeAt(e.X, e.Y);
        //        this.SelectedNode = tvFailureCat.SelectedNode;

        //        if (this.SelectedNode.Level == 0)
        //        {
        //            this.cMenu.Items["tbtnLook"].Visible = false;
        //            this.cMenu.Items["btnGridDelete"].Visible = false;
        //            this.cMenu.Items["btnTvUpdate"].Visible = false;
        //        }
        //        else
        //        {
        //            this.cMenu.Items["tbtnLook"].Visible = true;
        //            this.cMenu.Items["btnGridDelete"].Visible = true;
        //            this.cMenu.Items["btnTvUpdate"].Visible = true;
        //        }

        //        this.cMenu.Items["txtNode"].Text = tvFailureCat.SelectedNode.Text;
        //        //this.cMenu.Show();
        //    }

        //    if (e.Button == MouseButtons.Left)
        //    {
        //        tvFailureCat.SelectedNode = tvFailureCat.GetNodeAt(e.X, e.Y);
        //        this.SelectedNode = tvFailureCat.SelectedNode;

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

        //private void tvFailureCat_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        LookData();
        //    }
        //}

        //public int m_MouseClicks = 0;
        ////记录鼠标在myTreeView控件上按下的次数


        //private void tvFailureCat_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
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

        //private void tvFailureCat_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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

        //private void tvFailureCat_MouseDown(object sender, MouseEventArgs e)
        //{
        //    this.m_MouseClicks = e.Clicks;
        //}

        //#endregion

        //#region ContextMenu



        //private void btnGridDelete_Click(object sender, EventArgs e)
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

        //            Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());
        //            if (fcInstance.IsHaveChild(Dict))
        //            {
        //                //提示不能删除非子结点
        //                Alert.Show("请先删除子分类");
        //            }
        //            else
        //            {
        //                //todo  删除操作
        //                if (fcInstance.DeleteFailureCat(Dict))
        //                {
        //                    SelectedNode.Remove();
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


        //private Bse_Dict _dict;

        //public Bse_Dict Dict
        //{
        //    get { return _dict; }
        //    set { _dict = value; }
        //}

        //private void btnTvUpdate_Click(object sender, EventArgs e)
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);

        //        Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());
        //        SetMode(OperationTypeEnum.OperationType.Edit);

        //        bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);
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

        //private void LookData()
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);
        //        Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());
        //        SetMode(OperationTypeEnum.OperationType.Look);

        //        bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);

        //    }
        //}

        //private void btnTvAdd_Click(object sender, EventArgs e)
        //{
        //    if (SelectedNode != null)
        //    {
        //        //MessageBox.Show(this.SelectedNode.Text);

        //        //Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());
        //        Dict = new Bse_Dict();

        //        Dict.Dict_PCode = SelectedNode.Tag.ToString();
        //        Dict.Dict_PName = SelectedNode.Text;
        //        SetMode(OperationTypeEnum.OperationType.Add);

        //        //bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);
        //    }
        //}

        //#endregion

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

        //public void EnableEditMode(bool flag)
        //{
        //    if (flag)
        //    {
        //        foreach (Control item in gbFailurenList.Controls)
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
        //        foreach (Control item in gbFailurenList.Controls)
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

        //public void ClearTextBox()
        //{

        //    foreach (Control item in gbFailurenList.Controls)
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

        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    bool result = false;
        //    switch (CurrentMode)
        //    {
        //        case OperationTypeEnum.OperationType.Look: break;
        //        case OperationTypeEnum.OperationType.Edit:
        //            bmHelper.BindControlToModel<Bse_Dict>(Dict, gbFailurenList.Controls);
        //            result = fcInstance.EditFailureCatInfo(Dict);
        //            if (result)
        //            {
        //                SelectedNode.Text = Dict.Dict_Name;
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
        //            bmHelper.BindControlToModel<Bse_Dict>(Dict, gbFailurenList.Controls);
        //            result = fcInstance.AddFailureCatInfo(Dict);
        //            if (result)
        //            {

        //                AddTreeNode(SelectedNode, Dict);
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

        //public void AddTreeNode(TreeNode parentNode, Bse_Dict dict)
        //{
        //    TreeNode tmpNd = new TreeNode();

        //    tmpNd.Tag = dict.Dict_Code;
        //    tmpNd.Text = dict.Dict_Name;

        //    parentNode.Nodes.Add(tmpNd);
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    ClearTextBox();
        //}








        //#region 原故障分类方法
        //private void ultraGrid1_MouseClick(object sender, MouseEventArgs e)
        //{


        //    if (e.Button == MouseButtons.Right)
        //    {
        //        //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体

        //        //获取当前双击点的位置
        //        Point p = System.Windows.Forms.Cursor.Position;

        //        //获取当前双击点在网格中所处的位置
        //        p = this.ultraGrid1.PointToClient(p);

        //        //获取双击点网格控件的元素
        //        Infragistics.Win.UIElement oUI = this.ultraGrid1.DisplayLayout.UIElement.ElementFromPoint(p);
        //        if (oUI != null)
        //        {

        //            //判断双击点是不是行，也可能是列，如果网格控件选取方式不是设的选中整行的话。
        //            Infragistics.Win.UltraWinGrid.UltraGridRow oRowUI = oUI.SelectableItem as Infragistics.Win.UltraWinGrid.UltraGridRow;

        //            if (oRowUI != null && !oRowUI.IsEmptyRow && oRowUI.IsActiveRow)
        //            {
        //                //cMenu.Show((UltraGrid)sender, e.X, e.Y);
        //                //cMenu.Items["btnPaste"].Enabled = false;
        //                //ActiveRow = oRowUI;
        //                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
        //                //string id = oRowUI.Cells["FailureCat_ID"].Value.ToString();

        //                //EqufailureCatInfo frm = new EqufailureCatInfo(QX.Plugin.FailureManage.EqufailureCatInfo.OperationTypeEnum.Edit, id);
        //                //frm.ShowDialog();


        //                //string s = oRowUI.Cells[0].Value.ToString();
        //                //MessageBox.Show(s);

        //            }

        //        }
        //    }
        //}
        //private void ultraGrid1_DoubleClick(object sender, EventArgs e)
        //{
        //    //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体

        //    //获取当前双击点的位置
        //    Point p = System.Windows.Forms.Cursor.Position;

        //    //获取当前双击点在网格中所处的位置
        //    p = this.ultraGrid1.PointToClient(p);

        //    //获取双击点网格控件的元素
        //    Infragistics.Win.UIElement oUI = this.ultraGrid1.DisplayLayout.UIElement.ElementFromPoint(p);
        //    if (oUI != null)
        //    {

        //        //判断双击点是不是行，也可能是列，如果网格控件选取方式不是设的选中整行的话。
        //        Infragistics.Win.UltraWinGrid.UltraGridRow oRowUI = oUI.SelectableItem as Infragistics.Win.UltraWinGrid.UltraGridRow;

        //        if (oRowUI != null && !oRowUI.IsEmptyRow)
        //        {
        //            //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
        //            string id = oRowUI.Cells["FailureCat_ID"].Value.ToString();

        //            EqufailureCatInfo frm = new EqufailureCatInfo(QX.Plugin.FailureManage.EqufailureCatInfo.OperationTypeEnum.Edit, id);
        //            frm.ShowDialog();


        //            //string s = oRowUI.Cells[0].Value.ToString();
        //            //MessageBox.Show(s);

        //        }

        //    }
        //}

        /////// <summary>
        /////// 初始化绑定
        /////// </summary>
        ////private void InitEditBind(string id)
        ////{
        ////    Equ_FailureCat equ = fcInstance.GetEntiyByKey(id);
        ////    if (equ != null)
        ////    {
        ////        PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(Equ_FailureCat));
        ////        foreach (Control item in this.gbFalureCat.Controls)
        ////        {
        ////            if (item.GetType() == typeof(TextBox))
        ////            {
        ////                item.Text = p[item.Name].GetValue(equ).ToString();
        ////            }
        ////            else if (item.GetType() == typeof(DateTimePicker))
        ////            {
        ////                string time = p[item.Name].GetValue(equ).ToString();
        ////                if (!string.IsNullOrEmpty(time) && time != "0001-1-1 0:00:00")
        ////                {
        ////                    DateTime tempTime = DateTime.Now;
        ////                    if (DateTime.TryParse(time, out tempTime))
        ////                    {
        ////                        ((DateTimePicker)item).Value = tempTime;
        ////                    }
        ////                }
        ////            }
        ////            else if (item.GetType() == typeof(ComboBox))
        ////            {

        ////                ((ComboBox)item).SelectedValue = p[item.Name].GetValue(equ);
        ////            }
        ////        }
        ////    }
        ////}


        //public void InitGrid()
        //{


        //    List<Equ_FailureCat> list = fcInstance.GetListForPage();

        //    gHandler = new GridHandler(this.ultraGrid1);


        //    Dictionary<string, string> dic = new Dictionary<string, string>();
        //    dic.Add("FailureCat_ID", "故障序号");
        //    dic.Add("FailureCat_Code", "故障分类编号");
        //    dic.Add("FailureCat_Name", "故障分类名称");
        //    dic.Add("FailureCat_Intro", "故障分类解释");
        //    dic.Add("FailureCat_Bak", "备注");
        //    //gh.BindData(list);
        //    gHandler.BindData(list, dic, true);
        //    //gh.BindData(list);
        //    gHandler.SetDefaultStyle();
        //    //gh.SetAlternateRowStyle();
        //    gHandler.SetExcelStyleFilter();

        //}



        //private void btnAdd_Click(object sender, EventArgs e)
        //{

        //    EqufailureCatInfo frm = new EqufailureCatInfo(QX.Plugin.FailureManage.EqufailureCatInfo.OperationTypeEnum.Add, "");
        //    frm.ShowDialog();
        //}


        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    MSGCon msgCon = new MSGCon("你确定要删除该信息?");
        //    msgCon.StartPosition = FormStartPosition.CenterParent;
        //    msgCon.ShowDialog();

        //    if (msgCon.sReturn == StringHelper.CONRESULT_OK)
        //    {
        //        List<string> list = GetGridCheckBoxData();

        //        if (list.Count == 0)
        //        {
        //            MessageBox.Show("请选择要删除的信息!");
        //            return;
        //        }
        //        string result = fcInstance.RemoveFailureCats(list);
        //        if (result.Equals("1"))
        //        {
        //            MessageBox.Show("成功删除");
        //        }
        //        else
        //        {
        //            MessageBox.Show(result);
        //        }
        //    }
        //}

        //private List<string> GetGridCheckBoxData()
        //{
        //    List<string> list = new List<string>();

        //    foreach (UltraGridRow r in this.ultraGrid1.DisplayLayout.Rows)
        //    {
        //        if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
        //        {
        //            list.Add(r.Cells["FailureCat_ID"].Value.ToString());
        //        }
        //    }



        //    return list;
        //}






        //#region 故障分类信息维护

        ////private bool _isEdit;

        ////public bool IsEdit
        ////{
        ////    get { return _isEdit; }
        ////    set { _isEdit = value; }
        ////}

        ////bool IsHide = true;
        ////private void btnAdd_Click(object sender, EventArgs e)
        ////{
        ////    if (IsHide)
        ////    {
        ////        IsEdit = false;
        ////        ShowFailureBox();
        ////        IsHide = false;

        ////    }
        ////    //this.Refresh();
        ////}



        ////private void ShowFailureBox()
        ////{
        ////    gbFalureCat.Visible = true;
        ////    gbFalureCat.Height = 165;
        ////    this.gbFailurenList.Location = new Point(this.gbFailurenList.Location.X, gbFailurenList.Location.Y + 165);
        ////}

        ////private void HideFailureBox()
        ////{
        ////    gbFalureCat.Visible = false;
        ////    gbFalureCat.Height = 0;
        ////    this.gbFailurenList.Location = new Point(this.gbFailurenList.Location.X, gbFailurenList.Location.Y - 165);
        ////}


        ////private void btnCancel_Click(object sender, EventArgs e)
        ////{
        ////    if (!IsHide)
        ////    {
        ////        HideFailureBox();
        ////        IsHide = true;
        ////    }
        ////}

        ////private void btnConfirm_Click(object sender, EventArgs e)
        ////{
        ////    if (!IsHide)
        ////    {
        ////        HideFailureBox();
        ////        IsHide = true;
        ////    }

        ////}

        //#endregion



        //#endregion
    }
}
