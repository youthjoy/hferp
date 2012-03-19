using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using QX.BLL;
using QX.Common.C_Class;
using QX.Common.C_Class.Utils;
using QX.DataModel;
using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;

namespace QX.Plugin.VerifyProcess
{
    public partial class CommVerifyNodes : F_BasicPop
    {
        public CommVerifyNodes()
        {
            InitializeComponent();

            BindEvent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vn">驳回返回阶段需排除的阶段</param>
        public CommVerifyNodes(string vn)
        {
            InitializeComponent();

            ExcludedNodeCode = vn;

            BindEvent();
        }

        ToolStripTextBox tTextBox = new ToolStripTextBox();

        private void BindEvent()
        {

            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "关键字搜索";
            this.commonToolBar1.AddCustomControl(tLabel);


            tTextBox.Text = "";
            //Image image = global::QX.Plugin.RoadCateManage.Properties.Resources.parts;　　　　//从资源文件中引用
            //tTextBox.Image = image;
            tTextBox.Size = new Size(150, 30);
            //tTextBox.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            //tTextBox.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar1.AddCustomControl(tTextBox);

            tTextBox.TextChanged += new EventHandler(tTextBox_TextChanged);
        }

        public delegate void DCallBackHandler(object sender, Verify_Nodes node);
        public event DCallBackHandler CallBack;

        private void CommVerifyNodes_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            uGridNodesInit();
        }

        #region Member

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Verify_Nodes vnInstance = new Bll_Verify_Nodes();

        //private Bll_Verify_Users vuInstance = new Bll_Verify_Users();

        private Verify_Nodes _CurSelNode;

        public Verify_Nodes CurSelNode
        {
            get { return _CurSelNode; }
            set { _CurSelNode = value; }
        }


        private string ExcludedNodeCode = string.Empty;

        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }

        private BindModelHelper _bmHelper = new BindModelHelper();

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }


        //private bool IsEdit = false;

        private Dictionary<string, string> _DicColumn = new Dictionary<string, string>();
        /// <summary>
        /// 需要隐藏的列名
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }

        private List<Verify_Nodes> dataSource = new List<Verify_Nodes>();


        #endregion

        #region Grid 初始化

        public void uGridNodesInit()
        {
            gHandler = new GridHandler(this.uGridNodes);

            InitControl();

            InitData();

            StyleInit();
            //this.uGridInv.DisplayLayout.GroupByBox.Hidden = false;

        }

        /// <summary>
        /// 样式初始化
        /// </summary>
        public void StyleInit()
        {
            gHandler.SetDefaultStyle();
            ////gh.SetAlternateRowStyle();
            //gHandler.SetExcelStyleFilter();

            //gHandler.SetCellClickAction(GridHandler.ClickActionEnum.Edit);
            this.uGridNodes.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
            //this.uGridNodes.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;
            //this.uGridNodes.DisplayLayout.Override.AllowDelete = DefaultableBoolean.True;
            //this.uGridNodes.DisplayLayout.Override.SequenceFixedAddRow = 2;
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void InitData()
        {
            if (!string.IsNullOrEmpty(ExcludedNodeCode))
            {
                dataSource = vnInstance.GetVerifyNodeListExcludedNode(ExcludedNodeCode);
            }
            else
            {
                dataSource = vnInstance.GetVerifyNodeList();
            }

            //DicColumn.Add("VU_User", "用户");
            //DicColumn.Add("VU_Dept", "部门");
            DicColumn.Add("VerifyNode_Name", "阶段名称");
            DicColumn.Add("VerifyNode_Remark", "阶段描述");
            DicColumn.Add("VerifyNode_AuditNum", "需要的审核人数");

            gHandler.BindData(dataSource, DicColumn);

            //AddCustomCol();

            //this.uGridNodes.DisplayLayout.Bands[0].AddNew();
        }

        private void AddCustomCol()
        {
            //this.uGridNodes.DisplayLayout.Bands[0].Columns.Add("VU_UserName", "用户");

            //this.uGridNodes.DisplayLayout.Bands[0].Columns.Add("VU_DeptName", "部门");

            //UltraGridColumn column = this.uGridNodes.DisplayLayout.Bands[0].Columns["VU_UserName"];
            //UltraGridColumn column1 = this.uGridNodes.DisplayLayout.Bands[0].Columns["VU_DeptName"];
            //column.Header.VisiblePosition = 0;
            //column1.Header.VisiblePosition = 1;

        }

        public void RefreshData()
        {
            //dataSource = invInstance.GetInvInfoListForCompt();
            if (!string.IsNullOrEmpty(ExcludedNodeCode))
            {
                dataSource = vnInstance.GetVerifyNodeListExcludedNode(ExcludedNodeCode);
            }
            else
            {
                dataSource = vnInstance.GetVerifyNodeList();
            }
            //dataSource = vnInstance.GetVerifyNodeList();
            gHandler.BindData(dataSource, DicColumn);
        }


        public void RefreshData(List<Verify_Nodes> data)
        {
            //dataSource = invInstance.GetInvInfoListForCompt();
            //if (!string.IsNullOrEmpty(ExcludedNodeCode))
            //{
            //    dataSource = vnInstance.GetVerifyNodeListExcludedNode(ExcludedNodeCode);
            //}
            //else
            //{
            //    dataSource = vnInstance.GetVerifyNodeList();
            //}
            //dataSource = vnInstance.GetVerifyNodeList();
            gHandler.BindData(data, DicColumn);
        }


        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void InitControl()
        {
            this.uGridNodes.DoubleClickRow += new DoubleClickRowEventHandler(uGridNodes_DoubleClickRow);

        }


        void uGridNodes_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGridRow row = e.Row;
            ConfirmSel(row);

        }

        #endregion


        private void tTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FilterData();
        }

        public void FilterData()
        {

            string key = tTextBox.Text;

            Predicate <Verify_Nodes> math = delegate(Verify_Nodes p) { return (p.VerifyNode_Code.ToUpper().Contains(key.ToUpper())||(p.VerifyNode_Name.ToUpper().Contains(key.ToUpper()))||(p.VerifyNode_AuditNum.ToString()==key)); };

            List<Verify_Nodes> filterData = CollectionHelper.Filter<Verify_Nodes>(dataSource, math);

            this.RefreshData(filterData);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridNodes.ActiveRow;
            if (row != null)
            {

                ConfirmSel(row);
            }
        }

        private void ConfirmSel(UltraGridRow row)
        {
            if (CallBack != null)
            {
                CurSelNode = row.ListObject as Verify_Nodes;

        
                CallBack(null, CurSelNode);

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewVN_Click(object sender, EventArgs e)
        {
            VerifyNode frm = new VerifyNode(OperationTypeEnum.OperationType.Add, null);

            frm.CallBack += new VerifyNode.DCallBackHandler(this.NodeAdd_CallBack);

            frm.ShowDialog();
        }

        private void NodeAdd_CallBack(object sender, Verify_Nodes node)
        {
            //添加成功后，刷新数据源
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                UltraGridRow row = this.uGridNodes.ActiveRow;

                if (row != null)
                {

                    VerifyNode frm = new VerifyNode(OperationTypeEnum.OperationType.Edit, row.Cells["VerifyNode_Code"].Value.ToString());
                    //frm.CallBack += new VerifyNode.DCallBackHandler(EditNode_CallBack);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            { 
            
            }
        }



    }
}
