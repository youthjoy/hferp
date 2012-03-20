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
using QX.Framework.AutoForm;

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

        ToolStripTextBox txtKey = new ToolStripTextBox();

        ToolStripTextBox txtLastKey = new ToolStripTextBox();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();
        GridHelper gen=new GridHelper();
        public void BindEvent()
        {
            ToolStripHelper tsHelper=new ToolStripHelper();
            #region toolbar事件初始化
            this.tbMyList.AddClicked += new EventHandler(this.btnAdd_Click);
            this.tbMyList.EditClicked += new EventHandler(this.btnEdit_Click);
            this.tbMyList.DelClicked += new EventHandler(this.btnDelete_Click);
            this.tbMyList.QueryClicked += new EventHandler(tbMyList_QueryClicked);
            this.tbMyList.RefreshClicked += new EventHandler(this.btnRefresh_Click);

            ToolStripButton batchPrice = tsHelper.New("批量调价", QX.Common.Properties.Resources.batch, new EventHandler(batchPrice_Click));
           // batchPrice.Click += new EventHandler(batchPrice_Click);
            batchPrice.Name = "batchPrice";
            this.tbMyList.AddCustomControl(batchPrice);

            //ToolStripButton tButton = new ToolStripButton();
            //tButton.Text = "工艺维护";
            //Image image = global::QX.Common.Properties.Resources.parts;　　　　//从资源文件中引用
            //tButton.Image = image;
            //tButton.Size = new Size(43, 28);
            //tButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            //tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            //this.tbMyList.AddCustomControl(tButton);

            //tButton.Click += new EventHandler(this.btnParts_Click);


            ToolStripButton tButton1 = new ToolStripButton();
            tButton1.Name = "btn_copy";
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

            this.tbAuditing.RefreshClicked += new EventHandler(tbAuditing_RefreshClicked);
            this.tbAuditing.QueryClicked += new EventHandler(tbAuditing_QueryClicked);


            //我的申请单
            this.tbMyList.AddCustomControl(9, txtKey, "r");

            ToolStripButton searchBtn = new ToolStripButton();
            searchBtn.Text = "搜索";
            Image image3 = QX.Common.Properties.Resources.search;
            searchBtn.Image = image3;
            searchBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            searchBtn.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            searchBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            searchBtn.Click += new EventHandler(btnSearch_Click);
            this.tbMyList.AddCustomControl(8, searchBtn, "r");

            this.tabComponets.Selected += new TabControlEventHandler(tabComponets_Selected);



            #endregion

            //ToolStripHelper tsHelper = new ToolStripHelper();
            #region TreeView Toolbar

            this.commTreeTool.RefreshClicked += new EventHandler(this.tvRefresh_Click);

            #endregion


            #region 终审清单


            this.tbLast.AddCustomControl(2, txtLastKey);

            ToolStripButton lastSearchBtn = new ToolStripButton();
            lastSearchBtn.Text = "搜索";
            Image image4 = QX.Common.Properties.Resources.search;
            lastSearchBtn.Image = image4;
            lastSearchBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            lastSearchBtn.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            lastSearchBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            lastSearchBtn.Click += new EventHandler(lastSearchBtn_Click);
            this.tbLast.AddCustomControl(3, lastSearchBtn);

            this.tbLast.RefreshClicked += new EventHandler(tbLast_RefreshClicked);

            this.tbLast.QueryClicked += new EventHandler(tbLast_QueryClicked);

            ToolStripButton exportBtn = tsHelper.New("全部导出", QX.Common.Properties.Resources.import, new EventHandler(exportBtn_Click));
            exportBtn.Name = "compExport";
            //exportBtn.Click += new EventHandler(exportBtn_Click);
            tbLast.AddCustomControl(exportBtn);
            #endregion


            #region 废弃

            this.tbTrash.RefreshClicked += new EventHandler(tbTrash_RefreshClicked);
            this.tbTrash.QueryClicked += new EventHandler(tbTrash_QueryClicked);
            this.tbTrash.HistoryClicked += new EventHandler(tbTrash_HistoryClicked);
            #endregion

        }

        void batchPrice_Click(object sender, EventArgs e)
        {
            BatchCompNode compNodeFrm = new BatchCompNode();
            compNodeFrm.ShowDialog();
        }

        void exportBtn_Click(object sender, EventArgs e)
        {
              SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.Title = "导出文件保存路径";
                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    string file = saveFileDialog.FileName;
                    Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter export = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter();
                    UltraGrid grid = new UltraGrid();
                    Panel p = new Panel();
                    this.Controls.Add(p);
                    grid = gen.GenerateGrid("GNodes_Export", p, new Point(0, 0));

                    var dt = rnInstance.GetRoadNodesList();
                    grid.DataSource = dt;
                    grid.Refresh();
                    export.Export(grid, file);
                    Alert.Show("导出完成!");
                }
        }

        void tbMyList_QueryClicked(object sender, EventArgs e)
        {
            LookHandle(uGridMyList);
        }

        //废弃清单 审核历史
        void tbTrash_HistoryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridTrash.ActiveRow;
            if (row != null)
            {
                Road_Components road = row.ListObject as Road_Components;
                ComAuditMain auditMain = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), road.Comp_Code);
                auditMain.ShowDialog();
            }
        }

        void tbAuditing_QueryClicked(object sender, EventArgs e)
        {
            LookHandle(this.uGridAuditing);
        }

        void tbTrash_QueryClicked(object sender, EventArgs e)
        {
            LookHandle(this.uGridTrash);
        }

        void tbLast_QueryClicked(object sender, EventArgs e)
        {
            LookHandle(uGridLastAudit);
        }

        void tbAuditing_RefreshClicked(object sender, EventArgs e)
        {
            RefreshuGridAuditing();
        }

        void tbLast_RefreshClicked(object sender, EventArgs e)
        {
            RefreshuGridLastAudit();
        }

        void tbTrash_RefreshClicked(object sender, EventArgs e)
        {
            RefreshuGridTrash();
        }

        void tabComponets_Selected(object sender, TabControlEventArgs e)
        {

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
                case 2:
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
                case 3:
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


        private FormHelper fHelper = new FormHelper();

        private void RoadComptMaintain_Load(object sender, EventArgs e)
        {
            Init();
            fHelper.PermissionControl(this.tbMyList.toolStrip1.Items, PermissionModuleEnum.Components.ToString());
            fHelper.PermissionControl(this.tbTrash.toolStrip1.Items, PermissionModuleEnum.Components.ToString());
            fHelper.PermissionControl(this.tbAuditing.toolStrip1.Items, PermissionModuleEnum.Components.ToString());
            fHelper.PermissionControl(this.tbLast.toolStrip1.Items, PermissionModuleEnum.Components.ToString());
        }


        public void Init()
        {
            //我的申请单
            uGridComponentsInit();
            IsMyListInit = true;
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

        UltraGrid uGridMyList = new UltraGrid();

        public void uGridComponentsInit()
        {

            gHandler = new GridHandler(this.uGridMyList);
            uGridComptBind(CurGridDataSource);
            uGridEventInit();
        }

        public void uGridComptBind(List<Road_Components> list)
        {
            CurGridDataSource = rcInstance.GetComponentsByUser();

            GridHelper gen = new GridHelper();

            uGridMyList = gen.GenerateGrid("GComponents", this.pnlMyList, new Point(0, 0));
            //合用一个initialrow方法
            this.uGridMyList.InitializeRow += new InitializeRowEventHandler(uGridMyList_InitializeRow);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = CurGridDataSource;

            uGridMyList.DataSource = dataSource;
            gen.SetExcelStyleFilter(this.uGridMyList);
            gen.SetGridReadOnly(uGridMyList, true);
            gen.SetGridColumnStyle(uGridMyList, AutoFitStyle.ExtendLastColumn);
        }

        void uGridMyList_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            UltraGridRow row = e.Row;

            Road_Components val = row.ListObject as Road_Components;

            if (val != null && val.AuditStat != null)
            {

                OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), val.AuditStat));

                switch (auditType)
                {
                    case OperationTypeEnum.AudtiOperaTypeEnum.Auditing:

                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[0];
                        //e.Row.Cells["RComponents_AuditStat"].Value = "待审核";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.OnAudit:
                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[1];
                        //e.Row.Appearance.BackColor = auditedColor;
                        //e.Row.Cells["RComponents_AuditStat"].Value = "审核中";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.LastAudit:
                        //e.Row.Cells["RComponents_AuditStat"].Value = "已终审";
                        e.Row.Cells["AuditCurAudit"].Value = "审理完成";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.Litter:
                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[2];
                        break;
                }
            }
            else
            {
                e.Row.Appearance.BackColor = Color.Red;
                //e.Row.Cells["RComponents_AuditStat"].Value = "未知状态";
            }
        }

       

        private void uGridEventInit()
        {
            this.uGridMyList.DoubleClickRow += new DoubleClickRowEventHandler(uGridMyList_DoubleClickRow);

        }

        /// <summary>
        /// 过滤数据
        /// </summary>
        public void FilterData()
        {

            string key = this.txtKey.Text;

            Predicate<Road_Components> math = delegate(Road_Components p) { return (p.Comp_Code != null && p.Comp_Code.ToUpper().Contains(key.ToUpper()) || (p.Comp_Name != null && p.Comp_Name.ToUpper().Contains(key.ToUpper()))); };

            List<Road_Components> filterData = CollectionHelper.Filter<Road_Components>(CurGridDataSource, math);

            this.RefreshGridRoadComponents(filterData);
        }


        /// <summary>
        /// 我的申请单刷新
        /// </summary>
        public void RefreshGridComponents()
        {
            CurGridDataSource = rcInstance.GetComponentsByUser();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = CurGridDataSource;
            uGridMyList.DataSource = dataSource;
        }
        //我的申请单
        public void RefreshGridRoadComponents(List<Road_Components> list)
        {
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            uGridMyList.DataSource = dataSource;

        }

        #region 我的申请单

        private void uGridAuditingComponents_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            UltraGridRow row = e.Row;

            Road_Components val = row.ListObject as Road_Components;

            if (val != null && val.AuditStat != null)
            {

                OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), val.AuditStat));

                switch (auditType)
                {
                    case OperationTypeEnum.AudtiOperaTypeEnum.Auditing:

                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[0];
                        //e.Row.Cells["RComponents_AuditStat"].Value = "待审核";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.OnAudit:
                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[1];
                        //e.Row.Appearance.BackColor = auditedColor;
                        //e.Row.Cells["RComponents_AuditStat"].Value = "审核中";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.LastAudit:
                        //e.Row.Cells["RComponents_AuditStat"].Value = "已终审";
                        e.Row.Cells["AuditCurAudit"].Value = "审理完成";
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.Litter:
                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[2];
                        break;
                }
            }
            else
            {
                e.Row.Appearance.BackColor = Color.Red;
                //e.Row.Cells["RComponents_AuditStat"].Value = "未知状态";
            }


        }

        void uGridMyList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            EditHandle();
        }

        //编辑零件图号
        private void EditHandle()
        {
            UltraGridRow row = this.uGridMyList.ActiveRow;


            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //Road_Components comp = row.ListObject as Road_Components;



                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string id = row.Cells["Comp_Code"].Value.ToString();

                var comp = rcInstance.GetRoadComponentByCode(id);

                OperationTypeEnum.OperationType op = OperationTypeEnum.OperationType.Edit;
                if (comp.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                {
                    if (comp.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                    {
                        op = OperationTypeEnum.OperationType.Look;

                        Alert.Show("当前零件图号已经入审核流程，您只能查看其相关数据");
                    }
                    else
                    {
                        op = OperationTypeEnum.OperationType.Edit;

                        Alert.Show("当前零件图号已终审，修改数据后将重新进入审核流程");
                    }
                }


                RoadComptInfo rFrm = new RoadComptInfo(rcInstance, op, id);

                rFrm.ShowDialog();

                if (rFrm.CurrentRoadCompt != null)
                {

                    Road_Components rc = rFrm.CurrentRoadCompt;
                    rc.RComponents_TimeCost = rcInstance.GetComponentTimeCost(rc.Comp_Code);
                    gHandler.UpdateRow<Road_Components>(row, rc);
                }
            }
        }
        /// <summary>
        /// 查看零件图号
        /// </summary>
        private void LookHandle(UltraGrid grid)
        {
            UltraGridRow row = grid.ActiveRow;

            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string id = row.Cells["Comp_Code"].Value.ToString();

                RoadComptInfo rFrm = new RoadComptInfo(rcInstance, OperationTypeEnum.OperationType.Look, id);

                rFrm.ShowDialog();

                if (rFrm.CurrentRoadCompt != null)
                {

                    //Road_Components rc = rFrm.CurrentRoadCompt;
                    //rc.RComponents_TimeCost = rcInstance.GetComponentTimeCost(rc.Comp_Code);
                    //gHandler.UpdateRow<Road_Components>(row, rc);
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
                RefreshGridComponents();
                //Road_Components rc = rFrm.CurrentRoadCompt;
                //rc.RComponents_TimeCost = rcInstance.GetComponentTimeCost(rc.Comp_Code);
                //gHandler.AddNewRow<Road_Components>(rc);
                //this.uGridMyList.Refresh();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MSGCon msgCon = new MSGCon("你确定要删除该信息?");
            //msgCon.StartPosition = FormStartPosition.CenterParent;
            //msgCon.ShowDialog();
            UltraGridRow row = this.uGridMyList.ActiveRow;
            if (row != null)
            {
                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该信息?");

                if (dialog == DialogResult.OK)
                {
                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                         , QX.Shared.SessionConfig.UserName
                         , "localhost"
                         , this.Name
                         , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Components
                         , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Components.ToString(), QX.Common.LogType.Delete.ToString());

                    Road_Components model = row.ListObject as Road_Components;
                    var re=rcInstance.RemoveCompt(model);
                    if (re >= 1)
                    {
                        //this.uGridMyList.Refresh();
                        RefreshGridComponents();
                        Alert.Show("删除图号成功!");
                    }
                    else
                    {
                        Alert.Show("删除图号失败!");
                    }
                    //}
                    //else
                    //{

                    //    Alert.Show("以下零件图号未能删除:" + result);
                    //}
                    //}
                    //else
                    //{
                    //    Alert.Show("请先选择要删除的数据!");
                    //}

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

        private void lastSearchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLastKey.Text))
            {
                FilterLastAuditData();
            }
            else
            {
                RefreshuGridLastAudit();
            }
        }


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
                    RefreshGridComponents();
                    //如果Comp_Code没改变则表示未添加成功或未添加
                    //gHandler.AddNewRow<Road_Components>(DicColumn, rFrm.CurrentRoadCompt);
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
                rFrm.FormClosed += new FormClosedEventHandler(rFrm_FormClosed);
                rFrm.Show();
            }
        }

        void rFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGridComponents();
        }

        #endregion

        #endregion

        #region 待审核列表


        private void btnAudit_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridAuditing.ActiveRow;
            if (row != null)
            {

                Road_Components com = row.ListObject as Road_Components;

                RoadComptInfo viewFrm = new RoadComptInfo(rcInstance, OperationTypeEnum.OperationType.Edit, com.Comp_Code, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), com.Comp_Code, com.AuditCurAudit, viewFrm);
                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                if (DialogResult.OK == frm.ShowDialog())
                {
                    viewFrm.isAudit = false;
                    viewFrm.Close();
                }


                //string compCode = row.Cells["Comp_Code"].Value.ToString();
                //CurAuditComponents = row.ListObject as Road_Components;

                //ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), compCode, CurAuditComponents.AuditCurAudit);
                //frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                //frm.ShowDialog();
            }
        }

        void frm_CallBack(AuditReturnResultEnum re, string AStat)
        {
            //审核行
            UltraGridRow row = this.uGridAuditing.ActiveRow;

            switch (re)
            {
                case AuditReturnResultEnum.Success:

                    Alert.Show("审核完成");
                    //更新已审核的工序列表
                    if (AStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                    {
                        Road_Components comp = row.ListObject as Road_Components;
                        rnInstance.SetNodeFinish(comp.Comp_Code);
                    }

                    RefreshuGridAuditing();

                    break;
                case AuditReturnResultEnum.Fail:
                    Alert.Show("审核失败!");
                    break;
            }
        }




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

        UltraGrid uGridAuditing = new UltraGrid();

        public void uGridAuditingInit()
        {

            AuditingGHandler = new GridHandler(this.uGridAuditing);

            //uGridAuditedComponentsInit();
           
            uGridAuditingBind(); 
            
            //uGridAuditingStyleInit();
        }

        void uGridAuditing_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Road_Components r = e.Row.ListObject as Road_Components;
            if (r.Comp_IsBusy == 1&&r.AuditStat!=OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
            {
                e.Row.RowSelectorAppearance.Image = QX.Common.Properties.Resources.busy;
            }

            
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

            GridHelper gen = new GridHelper();

            uGridAuditing = gen.GenerateGrid("GComponents", this.pnlOnAudit, new Point(0, 0));
            uGridAuditing.DoubleClickRow += new DoubleClickRowEventHandler(uGrid_DoubleClickRow);
            uGridAuditing.InitializeRow += new InitializeRowEventHandler(uGridAuditing_InitializeRow);

            uGridAuditing.DataSource = CurAuditingDataSource;

            gen.SetGridReadOnly(uGridAuditing, true);

            gen.SetGridColumnStyle(uGridAuditing, AutoFitStyle.ExtendLastColumn);
        }

        /// <summary>
        /// 待审列表刷新
        /// </summary>
        private void RefreshuGridAuditing()
        {
            CurAuditingDataSource = rcInstance.GetComponentsForAuditingStat();

            uGridAuditing.DataSource = CurAuditingDataSource;

        }

        private void RefreshuGridAuditing(List<Road_Components> list)
        {
            uGridAuditing.DataSource = list;
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


        public void FilterLastAuditData()
        {

            string key = this.txtLastKey.Text;

            Predicate<Road_Components> math = delegate(Road_Components p) { return (p.Comp_Code!=null&&p.Comp_Code.ToUpper().Contains(key.ToUpper()) || (p.Comp_Name!=null&&p.Comp_Name.ToUpper().Contains(key.ToUpper()))); };

            List<Road_Components> filterData = CollectionHelper.Filter<Road_Components>(CurLastAuditDataSource, math);

            this.RefreshuGridLastAudit(filterData);
        }


        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> LastAuditicColumn
        {
            get { return _lastAuditDicColumn; }
            set { _lastAuditDicColumn = value; }
        }


        UltraGrid uGridLastAudit = new UltraGrid();

        public void uGridLastAuditInit()
        {

            LastAuditGHandler = new GridHandler(this.uGridLastAudit);

            //uGridAuditedComponentsInit();
            uGridLastAudit.DoubleClickRow += new DoubleClickRowEventHandler(uGrid_DoubleClickRow);
            uGridLastAuditBind();

            //uGridLastAuditStyleInit();



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

            GridHelper gen = new GridHelper();

            uGridLastAudit = gen.GenerateGrid("CList_GComponents", this.pnlLast, new Point(0, 0));
            
            uGridLastAudit.DataSource = CurLastAuditDataSource;

            gen.SetGridReadOnly(uGridLastAudit, true);

            gen.SetGridColumnStyle(uGridLastAudit, AutoFitStyle.ExtendLastColumn);

            //LastAuditicColumn.Add("Comp_Code", "零部件图号");
            //LastAuditicColumn.Add("Comp_Name", "零部件名称");
            ////AuditedDicColumn.Add("Comp_Stat", "审核状态");
            //LastAuditicColumn.Add("RComponents_TimeCost", "零件定额工时");
            //LastAuditicColumn.Add("Comp_Bak", "备注");

            //LastAuditGHandler.BindData(CurLastAuditDataSource, LastAuditicColumn);

        }

        /// <summary>
        /// 终审列表刷新
        /// </summary>
        private void RefreshuGridLastAudit()
        {
            CurLastAuditDataSource = rcInstance.GetComponentsForLastAuditStat();
            uGridLastAudit.DataSource = CurLastAuditDataSource;
            //LastAuditGHandler.BindData(CurLastAuditDataSource, LastAuditicColumn);
        }



        private void RefreshuGridLastAudit(List<Road_Components> list)
        {
            uGridLastAudit.DataSource = list;

            //LastAuditGHandler.BindData(list, LastAuditicColumn);
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

        UltraGrid uGridTrash = new UltraGrid();

        public void uGridTrashInit()
        {

            TrashGHandler = new GridHandler(this.uGridTrash);

            //uGridAuditedComponentsInit();

            uGridTrashBind();

            //uGridTrashStyleInit();



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

            GridHelper gen = new GridHelper();

            uGridTrash = gen.GenerateGrid("GComponents", this.pnlTrash, new Point(0, 0));

            uGridTrash.DataSource = CurTrashDataSource;

            gen.SetGridReadOnly(uGridTrash, true);

            gen.SetGridColumnStyle(uGridTrash, AutoFitStyle.ExtendLastColumn);


            //TrashDicColumn.Add("Comp_Code", "零部件图号");
            //TrashDicColumn.Add("Comp_Name", "零部件名称");
            ////AuditedDicColumn.Add("Comp_Stat", "审核状态");
            //TrashDicColumn.Add("RComponents_TimeCost", "零件定额工时");
            //TrashDicColumn.Add("Comp_Bak", "备注");

            //TrashGHandler.BindData(CurTrashDataSource, TrashDicColumn);

        }

        /// <summary>
        /// 终审列表刷新
        /// </summary>
        private void RefreshuGridTrash()
        {
            CurTrashDataSource = rcInstance.GetComponentsForTrash();

            uGridTrash.DataSource = CurTrashDataSource;
            //TrashGHandler.BindData(CurTrashDataSource, TrashDicColumn);
        }



        private void RefreshuGridTrash(List<Road_Components> list)
        {

            uGridTrash.DataSource = list;
            //TrashGHandler.BindData(list, TrashDicColumn);
        }

        #endregion



        void uGrid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGrid grid = (UltraGrid)sender;
            UltraGridRow row = grid.ActiveRow;
            if (row != null && row.Cells["Comp_Code"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                string id = row.Cells["Comp_Code"].Value.ToString();

                RoadComptInfo rFrm = new RoadComptInfo(rcInstance, OperationTypeEnum.OperationType.Look, id);

                rFrm.ShowDialog();
            }
        }


        public bool IsAllowEdit(string code)
        {
            return rcInstance.IsAllowEdit(code);
        }
    }
}
