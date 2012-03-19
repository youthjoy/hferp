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

namespace QX.BseDict
{
    public partial class F_BseDic : F_BasicPop
    {
        public F_BseDic()
        {
            InitializeComponent();

            //InitializeExtendComponent();

            BindEvent();

        }

        private void BindEvent()
        {
            this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);

            #region ContextMenuStrip Event

            this.tbtnLook.Click += new System.EventHandler(this.tbtnLook_Click);

            this.btnTvAdd.Click += new System.EventHandler(this.btnTvAdd_Click);

            this.btnTvUpdate.Click += new System.EventHandler(this.btnTvUpdate_Click);

            this.btnGridDelete.Click += new System.EventHandler(this.btnDelete_Click);

            #endregion

            #region Treeview Event
            this.treeView1.MouseClick += new MouseEventHandler(this.treeView1_MouseClick);

            this.treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);

            this.treeView1.MouseDown += new MouseEventHandler(this.treeView1_MouseDown);

            this.treeView1.BeforeCollapse += new TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);

            this.treeView1.BeforeExpand += new TreeViewCancelEventHandler(this.treeView1_BeforeExpand);


            #endregion

            #region ToolBar

            this.commonToolBar1.AddClicked += new EventHandler(this.btnTvAdd_Click);
            this.commonToolBar1.EditClicked += new EventHandler(this.btnTvUpdate_Click);
            this.commonToolBar1.DelClicked += new EventHandler(this.btnDelete_Click);

            #endregion

            this.KeyPreview = true;

            this.KeyUp += new KeyEventHandler(this.F_BseDict_KeyUp);
        }


        #region Member

        //字典表Bll操作对象
        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        //private Bll_Bse_Dict _dcInstance;

        //public Bll_Bse_Dict dcInstance
        //{
        //    get { return _dcInstance; }
        //    set { _dcInstance = value; }
        //}

        private Bse_Dict _dict;

        /// <summary>
        /// 当前编辑或添加对应的实体数据对象
        /// </summary>
        public Bse_Dict Dict
        {
            get { return _dict; }
            set { _dict = value; }
        }

        //树控件数据源DataTable
        private DataTable _dtTree;

        public DataTable DtTree
        {
            get { return _dtTree; }
            set { _dtTree = value; }
        }


        private BindModelHelper _bmHelper;

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }


        private bool _IsLevel = false;
        /// <summary>
        /// 是否存在层级关系（树级关系）
        /// </summary>
        public bool IsLevel
        {
            get { return _IsLevel; }
            set { _IsLevel = value; }
        }


        #region 提示信息

        private string _AddSuccessMessage="添加成功";
        /// <summary>
        /// 添加成功提示信息
        /// </summary>
        public string AddSuccessMessage
        {
            get { return _AddSuccessMessage; }
            set { _AddSuccessMessage = value; }
        }

        private string _AddFailureMessage="添加失败";
        /// <summary>
        /// 添加失败提示信息
        /// </summary>
        public string AddFailureMessage
        {
            get { return _AddFailureMessage; }
            set { _AddFailureMessage = value; }
        }


        private string _EditSuccessMessage="编辑成功";
        /// <summary>
        /// 编辑成功提示信息
        /// </summary>
        public string  EditSuccessMessage
        {
            get { return _EditSuccessMessage; }
            set { _EditSuccessMessage = value; }
        }

        private string _EditFailureMessage="编辑失败";
        /// <summary>
        /// 编辑失败提示信息
        /// </summary>
        public string EditFailureMessage
        {
            get { return _EditFailureMessage; }
            set { _EditFailureMessage = value; }
        }


        private string _DeletePromtMessage="删除成功";
        /// <summary>
        /// 删除成功提示信息
        /// </summary>
        public string DeletePromtMessage
        {
            get { return _DeletePromtMessage; }
            set { _DeletePromtMessage = value; }
        }

        private string _IsRepeateMessage = "编码有重复，请重新输入!";
        /// <summary>
        /// 重复编码提示信息
        /// </summary>
        public string IsRepeateCodeMessage
        {
            get { return _IsRepeateMessage; }
            set { _IsRepeateMessage = value; }
        }

        private string _TextBox1PromtMessage="编码不能为空";
        /// <summary>
        /// 编码文本框提示信息
        /// </summary>
        public string TextBox1PromtMessage
        {
            get { return _TextBox1PromtMessage; }
            set { _TextBox1PromtMessage = value; }
        }

        private string _TextBox2PromtMessage="名称不能为空";
        /// <summary>
        /// 名称文本框提示信息
        /// </summary>
        public string TextBox2PromtMessage
        {
            get { return _TextBox2PromtMessage; }
            set { _TextBox2PromtMessage = value; }
        }

        #endregion

        #endregion

        private void F_BseDic_Load(object sender, EventArgs e)
        {
            //InitControl(DictKeyEnum.GenderCat,SysWinEnum.DictWin);

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);



        }

        private void F_BseDict_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// 控件初始化
        /// </summary>
        /// <param name="winKey"></param>
        public void InitControl(SysWinEnum winKey)
        {
            List<Sys_Control> list = dcInstance.GetControlMapForDict(DictKey, winKey);

            foreach (Sys_Control Sc in list)
            {

                Control[] controls = this.gpDict.Controls.Find(Sc.Sys_ControlName, true);
                Control[] txtControls = this.gpDict.Controls.Find(Sc.Sys_TextBoxName, true);

                if (controls != null && controls.Length > 0)
                {
                    controls[0].Visible = true;
                    controls[0].Text = Sc.Sys_ControlLabel;
                }

                if (txtControls != null && txtControls.Length > 0)
                {
                    txtControls[0].Visible = true;
                }

            }
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="isLevel"></param>
        /// <param name="key"></param>
        /// <param name="winKey"></param>
        public void Init(bool isLevel, DictKeyEnum key, SysWinEnum winKey)
        {

            this.IsLevel = isLevel;

            DictKey = key;

            InitControl(winKey);

            SetMode(OperationTypeEnum.OperationType.Look);

            bmHelper = new BindModelHelper();

            this.treeView1.Nodes.Clear();

            CreateDataSource();

            this.treeView1.ContextMenuStrip = this.cMenu;

            if (DtTree.Rows.Count != 0)
            {
                InitTree(this.treeView1.Nodes, null);
                this.treeView1.Nodes[0].Expand();

                this.Text = treeView1.Nodes[0].Text + "管理";
            }

            
        }

        #region 初始化树控件及数据源



        private void CreateDataSource()
        {
            List<Bse_Dict> list = dcInstance.GetListByDictKey(DictKey);

            DtTree = ConvertX.ToDataTable<Bse_Dict>(list);
            DtTree.TableName = "TreeViewSource";
        }

        /// <summary>
        /// 初始化树控件
        /// </summary>
        /// <param name="Nds"></param>
        /// <param name="parentId"></param>
        private void InitTree(TreeNodeCollection Nds, string parentId)
        {
            DataView dv = new DataView();
            TreeNode tmpNd;
            //string intId;
            dv.Table = DtTree;
            if (string.IsNullOrEmpty(parentId))
            {
                dv.RowFilter = "Dict_PCode is NULL";
            }
            else
            {
                dv.RowFilter = "Dict_PCode='" + parentId + "'";
            }

            foreach (DataRowView drv in dv)
            {
                tmpNd = new TreeNode();

                tmpNd.Tag = drv["Dict_Code"].ToString();
                if (string.IsNullOrEmpty(parentId))
                {
                    tmpNd.Text = drv["Dict_Name"].ToString();
                }
                else
                {
                    tmpNd.Text = drv["Dict_Name"].ToString();
                    //tmpNd.Text = drv["Dict_Code"].ToString() + " " + drv["Dict_Name"].ToString();
                }

                Nds.Add(tmpNd);
                //intId = drv["Dict_PCode"].ToString();
                InitTree(tmpNd.Nodes, tmpNd.Tag.ToString());
            }
        }



        #endregion




        private TreeNode _selectedNode;

        //当前选中的树节点
        private TreeNode SelectedNode
        {
            get { return _selectedNode; }
            set { _selectedNode = value; }
        }

        /// <summary>
        /// 当前Mode（编辑、添加、查看）
        /// </summary>
        private OperationTypeEnum.OperationType _currentMode;

        public OperationTypeEnum.OperationType CurrentMode
        {
            get { return _currentMode; }
            set { _currentMode = value; }
        }

        private DictKeyEnum _DictKey;

        /// <summary>
        /// 当前窗口对应编辑的关键字
        /// </summary>
        public DictKeyEnum DictKey
        {
            get { return _DictKey; }
            set { _DictKey = value; }
        }

        #region TreeView Event

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
                this.SelectedNode = treeView1.SelectedNode;

                if (this.SelectedNode.Level == 0)
                {
                    this.cMenu.Items["btnTvAdd"].Visible = true;
                    this.cMenu.Items["tbtnLook"].Visible = false;
                    this.cMenu.Items["btnGridDelete"].Visible = false;
                    this.cMenu.Items["btnTvUpdate"].Visible = false;
                }
                else if (!IsLevel)
                {
                    //this.cMenu.Items["tbtnLook"].Visible = false;
                    //this.cMenu.Items["btnGridDelete"].Visible = false;
                    this.cMenu.Items["btnTvAdd"].Visible = false;
                    this.cMenu.Items["tbtnLook"].Visible = true;
                    this.cMenu.Items["btnGridDelete"].Visible = true;
                    this.cMenu.Items["btnTvUpdate"].Visible = true;
                }
                else
                {
                    this.cMenu.Items["btnTvAdd"].Visible = true;
                    this.cMenu.Items["tbtnLook"].Visible = true;
                    this.cMenu.Items["btnGridDelete"].Visible = true;
                    this.cMenu.Items["btnTvUpdate"].Visible = true;
                }

                this.cMenu.Items["txtNode"].Text = treeView1.SelectedNode.Text;
                //this.cMenu.Show();
            }

            if (e.Button == MouseButtons.Left)
            {
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
                this.SelectedNode = treeView1.SelectedNode;

                //switch (e.Clicks)
                //{
                //    case 1:
                //        //暂不做特殊处理
                //        break;
                //    case 2:
                //        //进入查看状态
                //        LookData();
                //        break;
                //}

            }
        }




        #region 双击事件的处理

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);
                this.SelectedNode = treeView1.SelectedNode;
                //根节点除了可以添加子节点，不能进行其他任何操作
                if (this.SelectedNode.Level != 0)
                {
                    LookData();
                }

            }
        }

        public int m_MouseClicks = 0;
        //记录鼠标在myTreeView控件上按下的次数


        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (this.m_MouseClicks > 1)
            { //如果是鼠标双击则禁止结点折叠 
                e.Cancel = true;
            }
            else
            { //如果是鼠标单击则允许结点折叠 
                e.Cancel = false;
            }

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (this.m_MouseClicks > 1)
            { //如果是鼠标双击则禁止结点展开 
                e.Cancel = true;
            }
            else
            { //如果是鼠标单击则允许结点展开 
                e.Cancel = false;
            }

        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_MouseClicks = e.Clicks;
        }

        #endregion

        #region ContextMenu


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                //MessageBox.Show(this.SelectedNode.Text);
                //MSGCon msgCon = new MSGCon("你确定要删除该分类?");
                //msgCon.StartPosition = FormStartPosition.CenterParent;
                //msgCon.ShowDialog();

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该分类?");

                if (dialog == DialogResult.OK)
                {
                    
                    Dict = dcInstance.GetDictByKey(DictKey.ToString(),this.SelectedNode.Tag.ToString());
                    if (dcInstance.IsHaveChild(Dict, DictKey))
                    {
                        //提示不能删除非子结点
                        Alert.Show("请先删除子分类");
                    }
                    else
                    {
                        //todo  删除操作
                        if (dcInstance.DeleteDict(Dict) > 0)
                        {
                            SelectedNode.Remove();
                            ClearTextBox();
                            Alert.Show("删除成功");
                        }
                        else
                        {
                            Alert.Show("删除失败");
                        }

                    }
                    //SetMode(OperationTypeEnum.OperationType.Edit);
                    //bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);

                }

            }
        }



        private void btnTvUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                //MessageBox.Show(this.SelectedNode.Text);
                //根节点不能编辑
                if (this.SelectedNode.Level == 0)
                {
                    Alert.Show("根节点不能直接编辑");
                }
                else
                {
                    Dict = dcInstance.GetDictByKey(DictKey.ToString(),this.SelectedNode.Tag.ToString());
                    SetMode(OperationTypeEnum.OperationType.Edit);

                    bmHelper.BindModelToControl<Bse_Dict>(Dict, this.gpDict.Controls);
                }

            }
        }

        private void tbtnLook_Click(object sender, EventArgs e)
        {
            //if (SelectedNode != null)
            //{
            //    //MessageBox.Show(this.SelectedNode.Text);
            //    Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());
            //    SetMode(OperationTypeEnum.OperationType.Look);

            //    bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);


            //}

            LookData();
        }


        private void btnTvAdd_Click(object sender, EventArgs e)
        {
            //如果是层级字典则无限级;不是层级则无论点击任何节点添加均是针对根节点添加
            if (IsLevel)
            {

                if (SelectedNode != null)
                {
                    //MessageBox.Show(this.SelectedNode.Text);

                    //Dict = fcInstance.GetFailureCatInfoByKey(this.SelectedNode.Tag.ToString());

                    //if (this.SelectedNode.Level != 0 && !IsLevel)
                    //{
                    //    Alert.Show("不能添加叶子节点!");
                    //}
                    //else
                    //{

                    Dict = new Bse_Dict();

                    //设置当前添加状态的字典实体关键字
                    Dict.Dict_Key = DictKey.ToString();

                    Dict.Dict_PCode = SelectedNode.Tag.ToString();
                    Dict.Dict_PName = SelectedNode.Text;

                    //SetlblMessage("添加"+Dict.Dict_PName+"子结点信息");

                    SetMode(OperationTypeEnum.OperationType.Add);
                    //}
                    //bmHelper.BindModelToControl<Bse_Dict>(Dict, gbFailurenList.Controls);
                }
                else
                {
                    Alert.Show("请先选择要操作的节点!");
                }
            }
            else
            {


                if (this.treeView1.Nodes.Count > 0)
                {
                    //this.treeView1.Nodes[0];

                    //if (SelectedNode == null)
                    //{ 
                    SelectedNode = this.treeView1.Nodes[0];
                    //}

                    Dict = new Bse_Dict();

                    //设置当前添加状态的字典实体关键字
                    Dict.Dict_Key = DictKey.ToString();
                    Dict.Dict_PCode = this.treeView1.Nodes[0].Tag.ToString();
                    Dict.Dict_PName = this.treeView1.Nodes[0].Text;

                    //SetlblMessage("添加"+Dict.Dict_PName+"子结点信息");

                    SetMode(OperationTypeEnum.OperationType.Add);
                }

            }
        }


        //private void SetlblMessage(string  msg)
        //{
        //    this.lblMessage = msg;
        //}

        private void LookData()
        {
            if (SelectedNode != null)
            {
                //MessageBox.Show(this.SelectedNode.Text);
                Dict = dcInstance.GetDictByKey(DictKey.ToString(),this.SelectedNode.Tag.ToString());
                SetMode(OperationTypeEnum.OperationType.Look);

                bmHelper.BindModelToControl<Bse_Dict>(Dict, this.gpDict.Controls);

            }
        }



        #endregion

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
                    ClearTextBox();
                    EnableEditMode(false);
                    CurrentMode = OperationTypeEnum.OperationType.Look;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    ClearTextBox();
                    EnableEditMode(true);
                    this.Dict_Code.ReadOnly = true;
                    CurrentMode = OperationTypeEnum.OperationType.Edit;
                    break;
                case OperationTypeEnum.OperationType.Add:

                    ClearTextBox();
                    EnableEditMode(true);
                    this.Dict_Code.Text = dcInstance.GenerateDictCode(DictKey.ToString());
                    //this.Dict_Code.ReadOnly = false;
                    CurrentMode = OperationTypeEnum.OperationType.Add;
                    break;
            }
        }

        /// <summary>
        /// 设置文本框是否可编辑
        /// </summary>
        /// <param name="flag"></param>
        public void EnableEditMode(bool flag)
        {
            if (flag)
            {
                foreach (Control item in gpDict.Controls)
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
                foreach (Control item in gpDict.Controls)
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

        /// <summary>
        /// 清空文本框
        /// </summary>
        public void ClearTextBox()
        {

            foreach (Control item in gpDict.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
             
                        ((TextBox)item).Text = string.Empty;

                }
            }

        }


        /// <summary>
        /// 保存或确定按钮对应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (!this.ValidateData())
            {
                return;
            }

            int result = 0;
            switch (CurrentMode)
            {
                case OperationTypeEnum.OperationType.Look: 
                    
                    break;
                case OperationTypeEnum.OperationType.Edit:


                    bmHelper.BindControlToModel<Bse_Dict>(Dict, gpDict.Controls);

                    //if (dcInstance.IsRepeatCode(Dict))
                    //{
                    //    Alert.Show(IsRepeateCodeMessage);
                    //    return;
                    //}

                    result = dcInstance.UpdateDict(Dict);
                    if (result > 0)
                    {
                        SelectedNode.Text =Dict.Dict_Name;
                        SetMode(OperationTypeEnum.OperationType.Look);
                        Alert.Show(EditSuccessMessage);
                    }
                    else
                    {
                        //提示处理  todo
                        Alert.Show(EditFailureMessage);
                    }

                    break;
                case OperationTypeEnum.OperationType.Add:

                    

                    bmHelper.BindControlToModel<Bse_Dict>(Dict, gpDict.Controls);

                    if (dcInstance.IsRepeatCode(Dict))
                    {
                        Alert.Show(IsRepeateCodeMessage);
                        return;
                    }

                    result = dcInstance.AddDict(Dict, DictKey);
                    if (result > 0)
                    {

                        AddTreeNode(SelectedNode, Dict);

                        SelectedNode.Expand();
                        SetMode(OperationTypeEnum.OperationType.Look);
                        Alert.Show(AddSuccessMessage);
                    }
                    else
                    {
                        //提示处理  todo
                        Alert.Show(AddFailureMessage);
                    }
                    break;
            }
        }

        /// <summary>
        /// 添加对应处理方法
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="dict"></param>
        public void AddTreeNode(TreeNode parentNode, Bse_Dict dict)
        {
            TreeNode tmpNd = new TreeNode();

            tmpNd.Tag = dict.Dict_Code;
            tmpNd.Text = dict.Dict_Name;

            parentNode.Nodes.Add(tmpNd);
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }


        private bool ValidateData()
        {
            #region 数据有效性验证

            bool flag = true;

            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("Dict_Code", new ValidateModel(true, 20, 0, new string[] { TextBox1PromtMessage, "编码字符数不能超过20个" }));
            dict.Add("Dict_Name", new ValidateModel(true, 20, 0, new string[] { TextBox2PromtMessage, "名称字符数不能超过20个" }));
            //dict.Add("

            Dictionary<string, string> re = ValidateControlHelper.Validate(this.gpDict.Controls, dict);

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

    }
}
