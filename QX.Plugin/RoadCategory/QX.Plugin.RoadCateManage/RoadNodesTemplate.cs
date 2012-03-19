using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BseDict;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;

namespace QX.Plugin.RoadCateManage
{
    public partial class RoadNodesTemplate :F_BasicPop
    {
        public RoadNodesTemplate()
        {
            InitializeComponent();
        }

        public RoadNodesTemplate(string rcCode)
        {
            InitializeComponent();

            this.RoadComptCode = rcCode;

            BindEvent();
        }

        private void BindEvent()
        {
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
        }


        private void RoadNodesTemplate_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            Init();
        }


        #region Member

        private Bll_Road_Components rcInstance = new Bll_Road_Components();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private Bll_Road_TestRef rtInstance = new Bll_Road_TestRef();

        private Bll_Dept deptInstance = new Bll_Dept();

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


        public void Init()
        {
            GridInit();
        }

        public void GridRefresh()
        {
           
            //GridEventInit();
            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);
            this.gHandler.BindData(CurGridDataSource, RNDicColumn,false); 
            AddCustomizeColumn();
        }

        private void GridEventInit()
        {
            #region ultragrid

            this.uGridTemlate.BeforeEnterEditMode += new CancelEventHandler(uGridTemlate_BeforeEnterEditMode);

            this.uGridTemlate.ClickCellButton += new CellEventHandler(uGridTemlate_ClickCellButton);

            #endregion
        }

        public void GridInit()
        {

            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);
            gHandler = new GridHandler(this.uGridTemlate);

            RNDicColumn = new Dictionary<string, string>();
            //DicColumn.Add("RNodes_PartCode", "零件图号");
            RNDicColumn.Add("RNodes_Name", "工艺名称");
            RNDicColumn.Add("RNodes_Code", "工艺编码");
            RNDicColumn.Add("RNodes_Order", "工艺节点顺序");
            RNDicColumn.Add("RNodes_Dept_Name", "生产部门");
            RNDicColumn.Add("RNodes_TimeCost", "生产所需时间(小时)");
            RNDicColumn.Add("RNodes_Class_Name", "班组名称");
            //RNDicColumn.Add("RNodes_Class_Name", "班组名称");
            RNDicColumn.Add("RNodes_Cost", "成本价格");
            //this.gHandler.BindData<Road_Nodes>(CurGridDataSource, false);


            this.gHandler.BindData(CurGridDataSource, RNDicColumn, false);

            this.uGridTemlate.DisplayLayout.Bands[0].Columns["RNodes_Dept_Name"].CellClickAction = CellClickAction.Edit;


            //gh.BindData(list);
            gHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            gHandler.SetExcelStyleFilter();

            AddCustomizeColumn();

            GridEventInit();
        }

        /// <summary>
        /// 添加自定义列
        /// </summary>
        public void AddCustomizeColumn()
        {
            this.uGridTemlate.DisplayLayout.Bands[0].Columns.Add("TestRef", "");
            UltraGridColumn col = this.uGridTemlate.DisplayLayout.Bands[0].Columns["TestRef"];

            col.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;

            col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            col.Width = 18;
            col.DataType = typeof(object);
            Image image = global::QX.Common.Properties.Resources.compedit;　　　　//从资源文件中引用
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

        #endregion

        public void btnRoadNodeImport_Click(object sender, EventArgs e)
        {
            if (!this.IsAllowEdit(this.RoadComptCode))
            {
                Alert.Show("当前零件图号正在审核中，不能对其工艺路线相关信息进行编辑操作!");
                return;
            }

            Dictionary<string, int> nodeDic = new Dictionary<string, int>();
            Dictionary<string, string> timeCostDic = new Dictionary<string, string>();

            foreach (Road_Nodes r in CurGridDataSource)
            {

                nodeDic.Add(r.RNodes_Code, r.RNodes_Order);

                timeCostDic.Add(r.RNodes_Code, r.RNodes_TimeCost.ToString());
            }

            CommRoadNodes frm = new CommRoadNodes(nodeDic,timeCostDic);
            frm.ShowDialog();

            if (frm.IsChanged)
            {
                rnInstance.AddOrUpdateRoadNodes(RoadComptCode, frm.CurNodeDict,frm.CurNodeTimeCostDict);

                this.GridRefresh();
            }
        }


        private void ImportRoadTestRefHandle(int rowIndex)
        {

            if (!this.IsAllowEdit(this.RoadComptCode))
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

        void uGridTemlate_ClickCellButton(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key == "TestRef")
            {
                ImportRoadTestRefHandle(e.Cell.Row.Index);

            }
        }

        private void uGridTemlate_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            if (!this.IsAllowEdit(this.RoadComptCode))
            {
                Alert.Show("当前零件图号正在审核中，不能对其工艺路线相关信息进行编辑操作!");
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

                e.Cancel = true;
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



        public bool IsAllowEdit(string code)
        {
            return rcInstance.IsAllowEdit(code);
        }

    }
}
