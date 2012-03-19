using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;

namespace QX.Plugin.RoadCateManage
{
    public partial class RoadComptMaintain : F_BasciForm
    {
        public RoadComptMaintain()
        {
            InitializeComponent();

            BindEvent();
        }

        private bool IsMyListInit = false;

        private bool IsAuditingInit = false;

        private bool IsAuditedInit = false;

        private bool IsLastAuditInit = false;

        private bool IsTrashInit = false;

        public void BindEvent()
        {
            #region toolbar事件初始化
            this.tbMyList.AddClicked += new EventHandler(this.btnAdd_Click);
            this.tbMyList.EditClicked += new EventHandler(this.btnEdit_Click);
            this.tbMyList.DelClicked += new EventHandler(this.btnDelete_Click);

            this.tbMyList.RefreshClicked += new EventHandler(this.btnRefresh_Click);


            ToolStripButton tButton = new ToolStripButton();
            tButton.Text = "工艺维护";
            Image image = global::QX.Common.Properties.Resources.parts;　　　　//从资源文件中引用
            tButton.Image = image;
            tButton.Size = new Size(43, 28);
            tButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            this.tbMyList.AddCustomControl(tButton);

            tButton.Click += new EventHandler(this.btnParts_Click);


            ToolStripButton tButton1 = new ToolStripButton();
            tButton1.Text = "复制";
            Image image1 = global::QX.Common.Properties.Resources.copy;　　　　//从资源文件中引用
            tButton1.Image = image1;
            tButton1.Size = new Size(43, 28);
            tButton1.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            this.tbMyList.AddCustomControl(tButton1);

            tButton1.Click += new EventHandler(this.btnCopy_Click);


            //待审核工具条
            ToolStripButton tButton2 = new ToolStripButton();
            tButton2.Text = "审核";
            Image image2 = global::QX.Common.Properties.Resources.audit;　　　　//从资源文件中引用
            tButton2.Image = image2;
            tButton2.Size = new Size(43, 28);
            tButton2.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            this.tbAuditing.AddCustomControl(tButton2);

            tButton2.Click += new EventHandler(this.btnAudit_Click);

            #endregion


            #region TreeView Toolbar

            this.commTreeTool.RefreshClicked += new EventHandler(this.tvRefresh_Click);

            #endregion

            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);


            this.tabComponets.Selected += new TabControlEventHandler(tabComponets_Selected);
        }

        void tabComponets_Selected(object sender, TabControlEventArgs e)
        {

            //////我的申请单
            ////uGridComponentsInit();
            ////我的审核清单
            //uGridComponentsAuditedInit();
            ////终审清单
            //uGridLastAuditInit();
            ////待用户审核清单
            //uGridAuditingInit();

            //TreeViewInit();

            switch (e.TabPageIndex)
            {
                case 0:
                    if (!IsMyListInit)
                    {
                        //我的申请单
                        uGridComponentsInit();
                        IsMyListInit = true;
                    }
                    else
                    {
                        RefreshGridComponents();
                    }
                    break;
                case 1:
                    //我的审核清单
                    if (!IsAuditedInit)
                    {
                        uGridComponentsAuditedInit();
                        IsAuditedInit = true;
                    }
                    else
                    {
                        RefreshAuditedList();
                    }
                    break;
                case 2:
                    //待用户审核清单
                    if (!IsAuditingInit)
                    {
                        uGridAuditingInit();
                        IsAuditingInit = true;
                    }
                    else
                    {
                        RefreshuGridAuditing();
                    }
                    break;
                case 3:
                    //终审清单
                    if (!IsLastAuditInit)
                    {
                        TreeViewInit();
                        uGridLastAuditInit();
                        IsLastAuditInit = true;
                    }
                    else
                    {
                        RefreshuGridLastAudit();
                    }
                    break;
                case 4:
                    //废单
                    if (!IsTrashInit)
                    {
                        uGridTrashInit();
                        IsTrashInit = true;
                    }
                    else
                    {
                        RefreshuGridTrash();
                    }
                    break;

            }
        }



        #region 窗体单例

        public static RoadComptMaintain NewForm = null;



        public static RoadComptMaintain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new RoadComptMaintain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        #region Member

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Road_Components rcInstance = new Bll_Road_Components();

        private Road_Components CurAuditComponents = new Road_Components();

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }


        private GridHandler _auditedGHandler;

        public GridHandler AuditedGHandler
        {
            get { return _auditedGHandler; }
            set { _auditedGHandler = value; }
        }

        private Dictionary<string, string> _DicColumn = new Dictionary<string, string>();
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }

        private Dictionary<string, string> _auditedDicColumn = new Dictionary<string, string>();
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> AuditedDicColumn
        {
            get { return _auditedDicColumn; }
            set { _auditedDicColumn = value; }
        }

        //树控件数据源DataTable
        private DataTable _dtTree;

        public DataTable DtTree
        {
            get { return _dtTree; }
            set { _dtTree = value; }
        }


        private TreeNode _selectedNode;

        //当前选中的树节点
        private TreeNode SelectedNode
        {
            get { return _selectedNode; }
            set { _selectedNode = value; }
        }

        private List<Road_Components> _CurGridDataSource;
        //待审核列表数据源
        public List<Road_Components> CurGridDataSource
        {
            get { return _CurGridDataSource; }
            set { _CurGridDataSource = value; }
        }

        //已审核列表数据源
        private List<Road_Components> CurAuditedDataSource = new List<Road_Components>();

        #endregion

        private void RoadComptMaintain_Load(object sender, EventArgs e)
        {
            Init();
        }


        public void Init()
        {
            //我的申请单
            uGridComponentsInit();
            IsMyListInit = true;
            ////我的审核清单
            //uGridComponentsAuditedInit();
            ////终审清单
            //uGridLastAuditInit();
            ////待用户审核清单
            //uGridAuditingInit();
            ////树控件初始化化
            //TreeViewInit();
        }

        #region TreeView
        public void TreeViewInit()
        {
            this.tvRoadCate.Nodes.Clear();

            CreateDataSource();


            if (DtTree.Rows.Count != 0)
            {
                InitTree(this.tvRoadCate.Nodes, null);
                this.tvRoadCate.Nodes[0].Expand();
            }

            //InitTree(this.tvRoadCate.Nodes, null);

            this.tvRoadCate.MouseClick += new MouseEventHandler(this.tvRoadCate_MouseClick);

            //this.tvRoadCate.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.tvRoadCate_NodeMouseDoubleClick);

            this.tvRoadCate.MouseDown += new MouseEventHandler(this.tvRoadCate_MouseDown);

            this.tvRoadCate.BeforeCollapse += new TreeViewCancelEventHandler(this.tvRoadCate_BeforeCollapse);

            this.tvRoadCate.BeforeExpand += new TreeViewCancelEventHandler(this.tvRoadCate_BeforeExpand);

        }


        private void CreateDataSource()
        {
            List<Bse_Dict> list = dcInstance.GetListByDictKey(DictKeyEnum.RoadCate);

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
                tmpNd.Text = drv["Dict_Name"].ToString();

                Nds.Add(tmpNd);
                //intId = drv["Dict_PCode"].ToString();
                InitTree(tmpNd.Nodes, tmpNd.Tag.ToString());
            }
        }



        #region TreeView Event


        private void tvRefresh_Click(object sender, EventArgs e)
        {
            TreeViewInit();
        }

        private void tvRoadCate_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                tvRoadCate.SelectedNode = tvRoadCate.GetNodeAt(e.X, e.Y);
                this.SelectedNode = tvRoadCate.SelectedNode;
                List<string> list = new List<string>();
                GetChildNode(this.SelectedNode, list);

                List<Road_Components> dataSource = rcInstance.GetListByRoadCate(list);
                //刷新数据源
                this.RefreshuGridLastAudit(dataSource);
            }
        }




        public void GetChildNode(TreeNode tn, List<string> list)
        {
            list.Add(tn.Tag.ToString());

            if (tn.Nodes.Count == 0)
            {
                return;
            }

            foreach (TreeNode t in tn.Nodes)
            {

                GetChildNode(t, list);
            }
        }

        #region 双击事件的处理

        private void tvRoadCate_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //tvRoadCate.SelectedNode = tvRoadCate.GetNodeAt(e.X, e.Y);
                //this.SelectedNode = tvRoadCate.SelectedNode;
                //List<string> list = new List<string>();
                //GetChildNode(this.SelectedNode, list);

                //List<Road_Components> dataSource = rcInstance.GetListByRoadCate(list);
                //刷新数据源
                //this(dataSource);
            }
        }

        public int m_MouseClicks = 0;
        //记录鼠标在myTreeView控件上按下的次数


        private void tvRoadCate_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
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

        private void tvRoadCate_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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

        private void tvRoadCate_MouseDown(object sender, MouseEventArgs e)
        {
            this.m_MouseClicks = e.Clicks;
        }

        #endregion

        #endregion


        #endregion

        #region 我的申请单 Grid Init


        public void uGridComponentsInit()
        {

            gHandler = new GridHandler(this.uGridMyList);

            uGridEventInit();

            uGridComptBind(CurGridDataSource);

            MyListStyleInit();



        }

        private void MyListStyleInit()
        {
            gHandler.SetDefaultStyle();
            gHandler.SetExcelStyleFilter();

            //备注与审核状态显示位置对调
            this.uGridMyList.DisplayLayout.Bands[0].Columns["Comp_Bak"].Swap(this.uGridMyList.DisplayLayout.Bands[0].Columns["RComponents_AuditStat"]);
        }

        public void uGridComptBind(List<Road_Components> list)
        {
            CurGridDataSource = rcInstance.GetComponentsByUser();

            DicColumn = new Dictionary<string, string>();
            DicColumn.Add("Comp_Code", "零部件图号");
            DicColumn.Add("Comp_Name", "零部件名称");
            DicColumn.Add("RComponents_AuditStat", "审核状态");
            DicColumn.Add("RComponents_TimeCost", "零件定额工时");
            DicColumn.Add("Comp_Bak", "备注");

            gHandler.BindData(CurGridDataSource, DicColumn, true);

        }

        private void AddCustomColumn()
        {
            //this.uGridAuditingComponents.DisplayLayout.Bands[0].Columns.Add("StatName", "审核状态");

            //UltraGridColumn column1 = this.uGridAuditingComponents.DisplayLayout.Bands[0].Columns["StatName"];

            //column1.Header.VisiblePosition = 1;

        }

        private void uGridEventInit()
        {
            this.uGridMyList.DoubleClickRow += new DoubleClickRowEventHandler(uGridMyList_DoubleClickRow);

            this.uGridMyList.InitializeRow += new InitializeRowEventHandler(uGridAuditingComponents_InitializeRow);
        }



        public void FilterData()
        {

            string key = this.txtKey.Text;

            Predicate<Road_Components> math = delegate(Road_Components p) { return (p.Comp_Code.ToUpper().Contains(key.ToUpper()) || (p.Comp_Name.ToUpper().Contains(key.ToUpper()))); };

            List<Road_Components> filterData = CollectionHelper.Filter<Road_Components>(CurGridDataSource, math);

            this.RefreshGridRoadComponents(filterData);
        }


        public void RefreshGridComponents()
        {
            CurGridDataSource = rcInstance.GetComponentsByUser();

            gHandler.BindData(CurGridDataSource, DicColumn, true);
        }
        //我的申请单
        public void RefreshGridRoadComponents(List<Road_Components> list)
        {
            gHandler.BindData(list, DicColumn, true);
        }

        #region 我的申请单

        //private Color auditedColor = QX.Common.C_Class.Utils.TypeConverter.colorHx16toRGB("#B8CCE4");
        //private Color auditingColor = QX.Common.C_Class.Utils.TypeConverter.colorHx16toRGB("#DBE5F1");


        private void uGridAuditingComponents_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {

            if (e.Row.Cells["Comp_Stat"].Value != null)
            {

                OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), e.Row.Cells["Comp_Stat"].Value.ToString()));

                switch (auditType)
                {
                    case OperationTypeEnum.AudtiOperaTypeEnum.Auditing:
                        //e.Row.Appearance.BackColor = auditingColor;
                        e.Row.Cells["RComponents_AuditStat"].Value = "待审核";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.OnAudit:
                        //e.Row.Appearance.BackColor = auditedColor;
                        e.Row.Cells["RComponents_AuditStat"].Value = "审核中";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.LastAudit:
                        e.Row.Cells["RComponents_AuditStat"].Value = "已终审";
                        break;
                }
            }
            else
            {
                e.Row.Cells["RComponents_AuditStat"].Value = "未知状态";
            }


        }

        void uGridMyList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            EditHandle();
        }

        //private void uGridRoadComponets_DoubleClick(object sender, EventArgs e)
        //{
        //    EditHandle();
        //}


        //编辑零件图号
        private void EditHandle()
        {
            UltraGridRow row = this.uGridMyList.ActiveRow;

            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string id = row.Cells["Comp_Code"].Value.ToString();

                RoadComptInfo rFrm = new RoadComptInfo(rcInstance, OperationTypeEnum.OperationType.Edit, id);

                rFrm.ShowDialog();

                if (rFrm.CurrentRoadCompt != null)
                {

                    Road_Components rc = rFrm.CurrentRoadCompt;
                    rc.RComponents_TimeCost = rcInstance.GetComponentTimeCost(rc.Comp_Code);
                    gHandler.UpdateRow<Road_Components>(row, rc);
                }
            }
        }

        #region Toolbar

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditHandle();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            RoadComptInfo rFrm = new RoadComptInfo(rcInstance, OperationTypeEnum.OperationType.Add, null);

            rFrm.ShowDialog();


            if (rFrm.CurrentRoadCompt != null && !string.IsNullOrEmpty(rFrm.CurrentRoadCompt.Comp_Code))
            {
                Road_Components rc = rFrm.CurrentRoadCompt;
                rc.RComponents_TimeCost = rcInstance.GetComponentTimeCost(rc.Comp_Code);
                gHandler.AddNewRow<Road_Components>(rc);
                //this.uGridMyList.Refresh();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MSGCon msgCon = new MSGCon("你确定要删除该信息?");
            //msgCon.StartPosition = FormStartPosition.CenterParent;
            //msgCon.ShowDialog();

            DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该信息?");

            if (dialog == DialogResult.OK)
            {

                Dictionary<int, string> list = GetGridCheckBoxData();

                //是否选中要删除的数据
                if (list.Count != 0)
                {
                    string result = rcInstance.RemoveCompts(list);

                    if (result.Equals("1"))
                    {

                        foreach (KeyValuePair<int, string> k in list)
                        {
                            this.uGridMyList.Rows[k.Key].Hidden = true;
                            //取消单元格选中状态
                            this.uGridMyList.Rows[k.Key].Cells["checkbox"].Value = false;
                        }

                        this.uGridMyList.Refresh();

                        Alert.Show("成功删除");
                    }
                    else
                    {

                        Alert.Show("以下零件图号未能删除:" + result);
                    }
                }
                else
                {
                    Alert.Show("请先选择要删除的数据!");
                }

            }
        }

        private Dictionary<int, string> GetGridCheckBoxData()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();

            foreach (UltraGridRow r in this.uGridMyList.DisplayLayout.Rows)
            {
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    list.Add(r.Index, r.Cells["Comp_Code"].Value.ToString());
                }
            }

            return list;
        }

        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                FilterData();
            }
            else
            {
                RefreshGridComponents();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGridComponents();
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {

            //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体
            UltraGridRow row = this.uGridMyList.ActiveRow;

            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string code = row.Cells["Comp_Code"].Value.ToString();

                CopyRoadComponent rFrm = new CopyRoadComponent(OperationTypeEnum.OperationType.Copy, code);
                rFrm.ShowDialog();
                //MessageBox.Show(id);
                if (rFrm.CurrentRoadCompt != null && rFrm.CurrentRoadCompt.Comp_Code != code)
                {
                    //如果Comp_Code没改变则表示未添加成功或未添加
                    gHandler.AddNewRow<Road_Components>(DicColumn, rFrm.CurrentRoadCompt);
                }

            }


        }


        private void btnParts_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridMyList.ActiveRow;

            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string code = row.Cells["Comp_Code"].Value.ToString();

                RoadNodesTemplate rFrm = new RoadNodesTemplate(code);

                rFrm.Show();
            }
        }

        #endregion

        #endregion

        #region 我已审核过的清单


        public void uGridComponentsAuditedInit()
        {

            AuditedGHandler = new GridHandler(this.uGridAuditedComponents);

            uGridAuditedComponentsInit();

            uGridAuditedComponentsBind();

            AudtedListStyleInit();



        }

        private void AudtedListStyleInit()
        {
            //gh.BindData(list);
            AuditedGHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            AuditedGHandler.SetExcelStyleFilter();

            //备注与审核状态显示位置对调
            this.uGridAuditedComponents.DisplayLayout.Bands[0].Columns["Comp_Bak"].Swap(this.uGridAuditedComponents.DisplayLayout.Bands[0].Columns["RComponents_AuditStat"]);
        }

        public void uGridAuditedComponentsBind()
        {
            //CurAuditedDataSource = rcInstance.GetComponentsForLastAuditStat();
            CurAuditedDataSource = rcInstance.GetComponentsForAudted();
            //DicColumn = new Dictionary<string, string>();

            AuditedDicColumn.Add("Comp_Code", "零部件图号");
            AuditedDicColumn.Add("Comp_Name", "零部件名称");
            AuditedDicColumn.Add("RComponents_AuditStat", "审核状态");
            AuditedDicColumn.Add("RComponents_TimeCost", "零件定额工时");
            AuditedDicColumn.Add("Comp_Bak", "备注");

            AuditedGHandler.BindData(CurAuditedDataSource, AuditedDicColumn);

        }

        private void RefreshAuditedList()
        {
            CurAuditedDataSource = rcInstance.GetComponentsForAudted();
            AuditedGHandler.BindData(CurAuditedDataSource, AuditedDicColumn);
        }

        private void RefreshAuditedList(List<Road_Components> list)
        {
            AuditedGHandler.BindData(list, AuditedDicColumn);
        }

        //private void AddCustomColumn()
        //{
        //    this.uGridAuditingComponents.DisplayLayout.Bands[0].Columns.Add("StatName", "审核状态");

        //    UltraGridColumn column1 = this.uGridAuditingComponents.DisplayLayout.Bands[0].Columns["StatName"];

        //    column1.Header.VisiblePosition = 1;

        //}

        private void uGridAuditedComponentsInit()
        {
            //this.uGridAuditedComponents.DoubleClick += new EventHandler(uGridAuditedComponents_DoubleClick);

            this.uGridAuditedComponents.InitializeRow += new InitializeRowEventHandler(uGridAuditedComponents_InitializeRow);
        }

        void uGridAuditedComponents_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), e.Row.Cells["Comp_Stat"].Value.ToString()));


            switch (auditType)
            {
                case OperationTypeEnum.AudtiOperaTypeEnum.Auditing:
                    e.Row.Cells["RComponents_AuditStat"].Value = "待审核";
                    break;
                case OperationTypeEnum.AudtiOperaTypeEnum.OnAudit:
                    e.Row.Cells["RComponents_AuditStat"].Value = "审核中";
                    break;
                case OperationTypeEnum.AudtiOperaTypeEnum.LastAudit:
                    e.Row.Cells["RComponents_AuditStat"].Value = "已终审";
                    break;
            }
        }

        void uGridAuditedComponents_DoubleClick(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridAuditedComponents.ActiveRow;

            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string id = row.Cells["Comp_Code"].Value.ToString();

                AuditedRoadNodes rFrm = new AuditedRoadNodes(id);

                rFrm.ShowDialog();

            }

        }




        #endregion

        #region 待审核列表


        private void btnAudit_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridAuditing.ActiveRow;
            if (row != null)
            {
                //Audit<Road_Components>.auditTemplate=OperationTypeEnum.AuditTemplateEnum.Components_C001;
                string compCode = row.Cells["Comp_Code"].Value.ToString();
                //Audit<Road_Components> frm = new Audit<Road_Components>(OperationTypeEnum.AuditTemplateEnum.Components_C001);

                //frm.AuditTemplate = OperationTypeEnum.AuditTemplateEnum.Components_C001;
                CurAuditComponents = row.ListObject as Road_Components;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), compCode, CurAuditComponents.AuditCurAudit);
                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                frm.ShowDialog();

                //frm.ProcessBussnissCode = compCode;
                //frm.Model = CurAuditComponents;
                //frm.ProcessNode = CurAuditComponents.Comp_CurNode;

                //frm.OnLastAudit += new Audit<Road_Components>.DHandlerLastAudit(frm_OnLastAudit);
                //frm.OnLitterAudit += new Audit<Road_Components>.DHandlerLitterAudit(frm_OnLitterAudit);
                //frm.OnNextAudit += new Audit<Road_Components>.DHandlerNextAudit(frm_OnNextAudit);
                //frm.OnRejctAudit += new Audit<Road_Components>.DHandlerRejectAudit(frm_OnRejctAudit);
                //frm.OnAudit += new Audit<Road_Components>.DhandlerOnAudit(frm_OnAudit);
            }
        }

        void frm_CallBack(AuditReturnResultEnum re, string result)
        {
            throw new NotImplementedException();
        }


        #region 审核回调事件

        void frm_OnAudit(string ProcessNode, Road_Components obj)
        {
            //obj.Comp_CurNode = ProcessNode;
            obj.Comp_Stat = OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString();
            rcInstance.UpdateRoadCompt(obj);
        }

        void frm_OnRejctAudit(string RejectToNode, Road_Components obj)
        {
            obj.Comp_CurNode = RejectToNode;
            rcInstance.UpdateRoadCompt(obj);
        }

        void frm_OnNextAudit(string NextProcessNode, Road_Components obj)
        {
            obj.Comp_CurNode = NextProcessNode;
            obj.Comp_Stat = OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString();
            rcInstance.UpdateRoadCompt(obj);
            Alert.Show("审核成功！");
        }

        void frm_OnLitterAudit(object sender, Road_Components obj)
        {
            obj.Comp_Stat = OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString();
            rcInstance.UpdateRoadCompt(obj);
        }

        void frm_OnLastAudit(object sender, Road_Components obj)
        {
            obj.Comp_Stat = OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString();
            rcInstance.UpdateRoadCompt(obj);
        }
        #endregion

        // 待审核列表数据源
        private List<Road_Components> CurAuditingDataSource = new List<Road_Components>();

        private GridHandler _auditingGHandler;

        public GridHandler AuditingGHandler
        {
            get { return _auditingGHandler; }
            set { _auditingGHandler = value; }
        }

        private Dictionary<string, string> _auditingDicColumn = new Dictionary<string, string>();
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> AuditingDicColumn
        {
            get { return _auditingDicColumn; }
            set { _auditingDicColumn = value; }
        }


        public void uGridAuditingInit()
        {

            AuditingGHandler = new GridHandler(this.uGridAuditing);

            //uGridAuditedComponentsInit();

            uGridAuditingBind();

            uGridAuditingStyleInit();
        }

        private void uGridAuditingStyleInit()
        {
            AuditingGHandler.SetDefaultStyle();
            AuditingGHandler.SetExcelStyleFilter();

            //备注与审核状态显示位置对调
            this.uGridMyList.DisplayLayout.Bands[0].Columns["Comp_Bak"].Swap(this.uGridMyList.DisplayLayout.Bands[0].Columns["RComponents_TimeCost"]);
        }

        public void uGridAuditingBind()
        {
            //CurAuditedDataSource = rcInstance.GetComponentsForLastAuditStat();

            //DicColumn = new Dictionary<string, string>();
            CurAuditingDataSource = rcInstance.GetComponentsForAuditingStat();
            AuditingDicColumn.Add("Comp_Code", "零部件图号");
            AuditingDicColumn.Add("Comp_Name", "零部件名称");
            //AuditedDicColumn.Add("Comp_Stat", "审核状态");
            AuditingDicColumn.Add("RComponents_TimeCost", "零件定额工时");
            AuditingDicColumn.Add("Comp_Bak", "备注");

            AuditingGHandler.BindData(CurAuditingDataSource, AuditingDicColumn);

        }

        /// <summary>
        /// 待审列表刷新
        /// </summary>
        private void RefreshuGridAuditing()
        {
            CurAuditingDataSource = rcInstance.GetComponentsForAuditingStat();
            AuditingGHandler.BindData(CurAuditingDataSource, AuditingDicColumn);
        }

        private void RefreshuGridAuditing(List<Road_Components> list)
        {
            AuditingGHandler.BindData(list, AuditingDicColumn, true);
        }

        #endregion

        #region 已通过终审

        private List<Road_Components> CurLastAuditDataSource = new List<Road_Components>();

        private GridHandler _lastAuditGHandler;

        public GridHandler LastAuditGHandler
        {
            get { return _lastAuditGHandler; }
            set { _lastAuditGHandler = value; }
        }

        private Dictionary<string, string> _lastAuditDicColumn = new Dictionary<string, string>();
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> LastAuditicColumn
        {
            get { return _lastAuditDicColumn; }
            set { _lastAuditDicColumn = value; }
        }


        public void uGridLastAuditInit()
        {

            LastAuditGHandler = new GridHandler(this.uGridLastAudit);

            //uGridAuditedComponentsInit();

            uGridLastAuditBind();

            uGridLastAuditStyleInit();



        }

        private void uGridLastAuditStyleInit()
        {
            //gh.BindData(list);
            LastAuditGHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            LastAuditGHandler.SetExcelStyleFilter();
        }

        public void uGridLastAuditBind()
        {
            //CurAuditedDataSource = rcInstance.GetComponentsForLastAuditStat();

            //DicColumn = new Dictionary<string, string>();
            CurLastAuditDataSource = rcInstance.GetComponentsForLastAuditStat();
            LastAuditicColumn.Add("Comp_Code", "零部件图号");
            LastAuditicColumn.Add("Comp_Name", "零部件名称");
            //AuditedDicColumn.Add("Comp_Stat", "审核状态");
            LastAuditicColumn.Add("RComponents_TimeCost", "零件定额工时");
            LastAuditicColumn.Add("Comp_Bak", "备注");

            LastAuditGHandler.BindData(CurLastAuditDataSource, LastAuditicColumn);

        }

        /// <summary>
        /// 终审列表刷新
        /// </summary>
        private void RefreshuGridLastAudit()
        {
            CurLastAuditDataSource = rcInstance.GetComponentsForLastAuditStat();
            LastAuditGHandler.BindData(CurLastAuditDataSource, LastAuditicColumn);
        }



        private void RefreshuGridLastAudit(List<Road_Components> list)
        {
            LastAuditGHandler.BindData(list, LastAuditicColumn);
        }


        #endregion

        #region 废弃清单

        private List<Road_Components> CurTrashDataSource = new List<Road_Components>();

        private GridHandler _TrashGHandler;

        public GridHandler TrashGHandler
        {
            get { return _TrashGHandler; }
            set { _TrashGHandler = value; }
        }

        private Dictionary<string, string> _TrashDicColumn = new Dictionary<string, string>();
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> TrashDicColumn
        {
            get { return _TrashDicColumn; }
            set { _TrashDicColumn = value; }
        }


        public void uGridTrashInit()
        {

            TrashGHandler = new GridHandler(this.uGridTrash);

            //uGridAuditedComponentsInit();

            uGridTrashBind();

            uGridTrashStyleInit();



        }

        private void uGridTrashStyleInit()
        {
            //gh.BindData(list);
            TrashGHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            TrashGHandler.SetExcelStyleFilter();
        }

        public void uGridTrashBind()
        {
            //CurAuditedDataSource = rcInstance.GetComponentsForLastAuditStat();

            //DicColumn = new Dictionary<string, string>();
            CurTrashDataSource = rcInstance.GetComponentsForTrash();
            TrashDicColumn.Add("Comp_Code", "零部件图号");
            TrashDicColumn.Add("Comp_Name", "零部件名称");
            //AuditedDicColumn.Add("Comp_Stat", "审核状态");
            TrashDicColumn.Add("RComponents_TimeCost", "零件定额工时");
            TrashDicColumn.Add("Comp_Bak", "备注");

            TrashGHandler.BindData(CurTrashDataSource, TrashDicColumn);

        }

        /// <summary>
        /// 终审列表刷新
        /// </summary>
        private void RefreshuGridTrash()
        {
            CurTrashDataSource = rcInstance.GetComponentsForTrash();
            TrashGHandler.BindData(CurTrashDataSource, TrashDicColumn);
        }



        private void RefreshuGridTrash(List<Road_Components> list)
        {
            TrashGHandler.BindData(list, TrashDicColumn);
        }

        #endregion

        public bool IsAllowEdit(string code)
        {
            return rcInstance.IsAllowEdit(code);
        }
    }
}
