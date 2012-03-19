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
using QX.Framework.AutoForm;
using Infragistics.Win;
using QX.Plugin.Prod.Report;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace QX.Plugin.InvInfo
{
    public partial class InvInfo : F_BasciForm
    {
        public InvInfo()
        {
            InitializeComponent();
            BindEvent();
        }
        DateTimePicker bFDate = new DateTimePicker();

        DateTimePicker eFDate = new DateTimePicker();
        ToolStripTextBox txtInKey = new ToolStripTextBox();


        DateTimePicker bODate = new DateTimePicker();

        DateTimePicker eODate = new DateTimePicker();
        ToolStripTextBox txtOInKey = new ToolStripTextBox();
        FormHelper fHelper = new FormHelper();



        DateTimePicker bIDate = new DateTimePicker();

        DateTimePicker eIDate = new DateTimePicker();
        ToolStripTextBox txtInHisKey = new ToolStripTextBox();

        private void BindEvent()
        {

            #region 库存信息
            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripButton btnPRoadView = tsHelper.New("查看工序", QX.Common.Properties.Resources.nodes, new EventHandler(btnPRoadView_Click));

            this.commonToolBar2.AddCustomControl(btnPRoadView);

            ToolStripButton tButton2 = new ToolStripButton();
            tButton2.Name = "btn_out";
            tButton2.Text = "出库";
            Image image2 = global::QX.Common.Properties.Resources.inventoryout;　　　　//从资源文件中引用
            tButton2.Image = image2;
            tButton2.Size = new Size(43, 28);
            tButton2.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar2.AddCustomControl(tButton2);

            tButton2.Click += new EventHandler(this.btnOutInventory_Click);



            ToolStripButton tButton3 = new ToolStripButton();
            tButton3.Name = "btn_in";
            tButton3.Text = "入库";
            Image image3 = global::QX.Common.Properties.Resources.stockin;　　　　//从资源文件中引用
            tButton3.Image = image3;
            tButton3.Size = new Size(43, 28);
            tButton3.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar2.AddCustomControl(tButton3);

            tButton3.Click += new EventHandler(this.btnInInventory_Click);


            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "计划开始时间:";
            this.commonToolBar2.AddCustomControl(0, tLabel);

            this.commonToolBar2.AddCDTPtoToolstrip(1, bFDate);

            bFDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));


            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "计划结束时间:";
            this.commonToolBar2.AddCustomControl(2, tLabel2);

            this.commonToolBar2.AddCDTPtoToolstrip(3, eFDate);

            eFDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));




            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.commonToolBar2.AddCustomControl(4, tLabel3);


            this.commonToolBar2.AddCustomControl(5, txtInKey);

            //搜索按钮
            ToolStripButton searchPlanedBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchInBtn_Click));
            this.commonToolBar2.AddCustomControl(6, searchPlanedBtn);


            ToolStripButton hisExportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(hisExportBtn_Click));

            this.commonToolBar2.AddCustomControl(hisExportBtn);

            #endregion

            #region  已出库列表

            this.tbOut.RefreshClicked += new EventHandler(tbOut_RefreshClicked);

            //时间控件
            ToolStripLabel oLabel = new ToolStripLabel();
            oLabel.Text = "计划开始时间:";
            this.tbOut.AddCustomControl(0, oLabel);

            this.tbOut.AddCDTPtoToolstrip(1, bODate);

            bODate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));


            ToolStripLabel oELabel = new ToolStripLabel();
            oELabel.Text = "计划结束时间:";
            this.tbOut.AddCustomControl(2, oELabel);

            this.tbOut.AddCDTPtoToolstrip(3, eODate);

            eODate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));




            ToolStripLabel tLabel5 = new ToolStripLabel();
            tLabel5.Text = "关键字:";
            this.tbOut.AddCustomControl(4, tLabel5);


            this.tbOut.AddCustomControl(5, txtOInKey);

            //搜索按钮
            ToolStripButton outSearchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(outSearchBtn_Click));

            this.tbOut.AddCustomControl(6, outSearchBtn);

            ToolStripButton btnOutPRoadView = tsHelper.New("查看工序", QX.Common.Properties.Resources.nodes, new EventHandler(btnOutPRoadView_Click));
            //btnOutPRoadView.Click += new EventHandler(btnOutPRoadView_Click);
            this.tbOut.AddCustomControl(btnOutPRoadView);

            ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(exportBtn_Click));
            this.tbOut.AddCustomControl(exportBtn);
            //exportBtn.Click += new EventHandler(exportBtn_Click);

            #endregion

            #region 已入库历史记录


            this.tbHisIn.RefreshClicked += new EventHandler(tbHisIn_RefreshClicked);

            //时间控件
            ToolStripLabel iLabel = new ToolStripLabel();
            iLabel.Text = "计划开始时间:";
            this.tbHisIn.AddCustomControl(0, iLabel);

            this.tbHisIn.AddCDTPtoToolstrip(1, bIDate);

            bIDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));


            ToolStripLabel iELabel = new ToolStripLabel();
            iELabel.Text = "计划结束时间:";
            this.tbHisIn.AddCustomControl(2, iELabel);

            this.tbHisIn.AddCDTPtoToolstrip(3, eIDate);

            eIDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));




            ToolStripLabel tLabel6 = new ToolStripLabel();
            tLabel6.Text = "关键字:";
            this.tbHisIn.AddCustomControl(4, tLabel6);


            this.tbHisIn.AddCustomControl(5, txtInHisKey);

            //搜索按钮
            ToolStripButton inHisSearchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(inHisSearchBtn_Click));
            this.tbHisIn.AddCustomControl(6, inHisSearchBtn);

            #endregion 

            fHelper.PermissionControl(this.commonToolBar2.toolStrip1.Items, PermissionModuleEnum.Inv.ToString());
            
        }

        void hisExportBtn_Click(object sender, EventArgs e)
        {
            if (this.uGridInvList.Rows.Count <= 0)
            {
                Alert.Show("现阶段没有数据可以导出!");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出文件保存路径";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                string file = saveFileDialog.FileName;
                UltraGridExcelExporter export = new UltraGridExcelExporter();
                export.Export(uGridInvList, file);
                Alert.Show("导出完成!");
            }
        }

        void exportBtn_Click(object sender, EventArgs e)
        {
            if (this.uGridOuting.Rows.Count <= 0)
            {
                Alert.Show("现阶段没有数据可以导出!");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出文件保存路径";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                string file = saveFileDialog.FileName;
                UltraGridExcelExporter export = new UltraGridExcelExporter();
                export.Export(uGridOuting, file);
                Alert.Show("导出完成!");
            }
        }

        void btnOutPRoadView_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridOuting.ActiveRow;
            if (row != null)
            {
                Inv_Information inv = row.ListObject as Inv_Information;
                string prodcode = inv.IInfor_ProdCode;
                string tcode = inv.IInfor_TaskCode;
                //string pcode = row.Cells["IInfor_ProdCode"].Value.ToString();
                CommPRoads frm = new CommPRoads(inv.IInfor_PlanCode);
                frm.ShowDialog();
            }
        }

        void inHisSearchBtn_Click(object sender, EventArgs e)
        {
            string obTime = bIDate.Value.ToString();

            string oetime = eIDate.Value.ToString();

            string key = this.txtInHisKey.Text;

            string where = string.Format(" AND IInfor_InDate>='{1}' AND IInfor_InDate<='{2}'  AND (IInfor_ProdCode like '%{0}%' or IInfor_PartName like '%{0}%'  or IInfor_PartNo like '%{0}%')", key, obTime, oetime);

            List<Inv_Information> list = invInstance.GetInHisInvListByWhere(where);

            this.uGridInHis.DataSource = list;
        }

        void tbHisIn_RefreshClicked(object sender, EventArgs e)
        {
            RefreshInHis();
        }
        /// <summary>
        /// 工序查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnPRoadView_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridInvList.ActiveRow;
            if (row != null)
            {
                string pcode = row.Cells["IInfor_PlanCode"].Value.ToString();
                CommPRoads frm = new CommPRoads(pcode);
                frm.ShowDialog();
            }
        }

        void outSearchBtn_Click(object sender, EventArgs e)
        {
            string obTime = bODate.Value.ToString();

            string oetime = eODate.Value.ToString();

            string key = this.txtOInKey.Text;

            string where = string.Format(" AND IInfor_InDate>='{1}' AND IInfor_InDate<='{2}'  AND (IInfor_ProdCode like '%{0}%' or IInfor_PartName like '%{0}%'  or IInfor_PartNo like '%{0}%')", key, obTime, oetime);

            List<Inv_Information> list = invInstance.GetOutingInvInfoListByWhere(where);

            uGridOuting.DataSource = list;

        }

        void tbOut_RefreshClicked(object sender, EventArgs e)
        {
            uGridOutingRefreshData();
        }


        void searchInBtn_Click(object sender, EventArgs e)
        {

            string btime = bFDate.Value.ToString();

            string etime = eFDate.Value.ToString();

            string key = this.txtInKey.Text;

            string where = string.Format(" AND IInfor_InDate>='{1}' AND IInfor_InDate<='{2}'  AND (IInfor_ProdCode like '%{0}%' or IInfor_PartName like '%{0}%'  or IInfor_PartNo like '%{0}%')", key, btime, etime);

            List<Inv_Information> list = invInstance.GetInvInfoListByWhere(where);

            uGridInvList.DataSource = list;
            isInit = false;
            AddCustomCol();
        }


        private void btnInInventory_Click(object sender, EventArgs e)
        {
            StockIn inFrm = new StockIn();
            inFrm.ShowDialog();
            uGridInvListRefreshData();
        }

        #region 窗体单例

        public static InvInfo NewForm = null;



        public static InvInfo Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new InvInfo();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void InvInfo_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            //与零件相关的库存信息列表（汇总）
            //uGridInvInit();
            //库存信息列表
            uGridInvListInit();
            //待出库
            uGridOutingInit();
            ///已入库历史记录
            uGridInHisInit();
        }


        #region Member

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }

        private Dictionary<string, string> _DicColumn = new Dictionary<string, string>();
        /// <summary>
        /// 需要隐藏的列名
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }

        private List<Inv_Information> dataSource = new List<Inv_Information>();

        #endregion

        private void btnOutInventory_Click(object sender, EventArgs e)
        {

            //DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该信息?");


            //if (dialog == DialogResult.OK)
            //{

            //Dictionary<int, string> list = gHandler.GetGridCheckBoxData("IInfor_ProdCode");
            List<Inv_Information> list = GetGridCheckBoxData();
            //是否选中要删除的数据
            if (list.Count != 0)
            {

                //List<string> promtMsgArray = new List<string>();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("确定出库以下零件:");
                foreach (var kv in list)
                {
                    string partNo = kv.IInfor_PartNo;
                    string partName = kv.IInfor_PartName;

                    //UltraGridRow row = this.uGridInvList.DisplayLayout.Rows[kv.Key];
                    //string partNo = row.Cells["IInfor_ProdCode"].Value.ToString();
                    //string partName = row.Cells["IInfor_PartName"].Value.ToString();
                    sb.AppendLine(partNo + ":" + partName);
                }

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, sb.ToString());


                if (dialog == DialogResult.OK)
                {
                    InvOut frm = new InvOut(list);
                    frm.ShowDialog();

                    uGridInvListRefreshData();
                    //int result = invInstance.UpdateInvInfoForList(list);
                }


            }
            else
            {
                Alert.Show("请先选择要出库的零件!");
            }

            //}


        }

        private List<Inv_Information> GetGridCheckBoxData()
        {
            //Dictionary<int, string> list = new Dictionary<int, string>();
            List<Inv_Information> list = new List<Inv_Information>();
            foreach (UltraGridRow r in this.uGridInvList.DisplayLayout.Rows)
            {
                if (r.Cells["IsCheck"].Value != null && r.Cells["IsCheck"].Value.ToString() == "True")
                {
                    var temp = r.ListObject as Inv_Information;
                    list.Add(temp);
                    //list.Add(r.Index, r.Cells["IInfor_ProdCode"].Value.ToString());
                }
            }



            return list;
        }


        //#region 汇总
        //#region Grid 初始化

        //public void uGridInvInit()
        //{
        //    //gHandler = new GridHandler(this.uGridInv);

        //    //InitControl();

        //    //InitData();

        //    //StyleInit();
        //    //this.uGridInv.DisplayLayout.GroupByBox.Hidden = false;

        //}

        ///// <summary>
        ///// 样式初始化
        ///// </summary>
        //public void StyleInit()
        //{
        //    gHandler.SetDefaultStyle();
        //    //gh.SetAlternateRowStyle();
        //    gHandler.SetExcelStyleFilter();
        //}

        ///// <summary>
        ///// 数据初始化
        ///// </summary>
        //public void InitData()
        //{
        //    dataSource = invInstance.GetInvInfoListForCompt();


        //    DicColumn.Add("IInfor_PartNo", "零件图号");
        //    DicColumn.Add("IInfor_PartName", "零件名称");
        //    //DicColumn.Add("IInfor_ProdCode", "零件编号");
        //    //DicColumn.Add("IInfor_PlanBegin", "计划开工时间");
        //    //DicColumn.Add("IInfor_PlanEnd", "计划完工时间");
        //    //DicColumn.Add("IInfor_InTime", "实际完工时间");
        //    DicColumn.Add("IInfor_Num", "库存数量");
        //    //DicColumn.Add("IInfor_WareHouse", "存储地");
        //    //DicColumn.Add("IInfor_InConfirm", "入库确认人");
        //    //DicColumn.Add("IInfor_InPep", "编制人");
        //    //DicColumn.Add("IInfor_InDate", "编制时间");
        //    //DicColumn.Add("IInfor_OutDate", "出库时间");
        //    //DicColumn.Add("IInfor_OutPep", "出库确认人");


        //    gHandler.BindData(dataSource, DicColumn);

        //}


        //public void RefreshData()
        //{
        //    dataSource = invInstance.GetInvInfoListForCompt();

        //    gHandler.BindData(dataSource, DicColumn);
        //}

        //public void RefreshData(object dataSource)
        //{
        //    //dataSource = invInstance.GetInvInfoList(ProdType);

        //    gHandler.BindData(dataSource, DicColumn);
        //}

        ///// <summary>
        ///// 事件及Grid对应事件初始化
        ///// </summary>
        //public void InitControl()
        //{

        //    this.uGridInv.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInv_InitializeRow);

        //    this.uGridInv.DoubleClickRow += new DoubleClickRowEventHandler(uGridInv_DoubleClickRow);
        //}

        //#endregion

        //#region Envent Handler

        //private void uGridInv_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        //{
        //    UltraGridRow row = this.uGridInv.ActiveRow;
        //    if (row != null)
        //    {
        //        string comptCode = row.Cells["IInfor_PartNo"].Value.ToString();
        //        ComptInv frm = new ComptInv(comptCode);
        //        frm.ShowDialog();
        //    }

        //}

        //private void uGridInv_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        //{
        //    //根据不同的产品库存状态显示不同的颜色
        //    //if (e.Row.Cells["IInfor_Num"].Value != null)
        //    //{
        //    //    int prodStat = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(e.Row.Cells["IInfor_Num"].Value);

        //    //    switch (prodStat)
        //    //    {
        //    //        //在制
        //    //        case 0:
        //    //            e.Row.Appearance.BackColor = Color.Lavender;

        //    //            break;
        //    //        //成品
        //    //        case 1:

        //    //            break;

        //    //    }
        //    //}
        //}

        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
        //    RefreshData();
        //}

        ///// <summary>
        ///// 入库
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnInventory_Click(object sender, EventArgs e)
        //{
        //    UltraGridRow row = this.uGridInv.ActiveRow;
        //    if (row != null)
        //    {
        //        //string prodCode = row.Cells["IInfor_ProdCode"].Value.ToString();
        //        //InvMaintain frm = new InvMaintain(prodCode);
        //        //frm.ShowDialog();

        //        //RefreshData();


        //        //库存信息管理
        //        string comptCode = row.Cells["IInfor_PartNo"].Value.ToString();
        //        ComptInv frm = new ComptInv(comptCode);
        //        frm.ShowDialog();
        //    }
        //}


        //#endregion
        //#endregion

        #region 库存信息列表

        private GridHandler _gHanlder1;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler1
        {
            get { return _gHanlder1; }
            set { _gHanlder1 = value; }
        }

        private Dictionary<string, string> _DicColumn1 = new Dictionary<string, string>();
        /// <summary>
        /// 需要隐藏的列名
        /// </summary>
        public Dictionary<string, string> DicColumn1
        {
            get { return _DicColumn1; }
            set { _DicColumn1 = value; }
        }

        private List<Inv_Information> dataSource1 = new List<Inv_Information>();


        #region Grid 初始化

        /// <summary>
        /// 库存
        /// </summary>
        UltraGrid uGridInvList = new UltraGrid();

        public void uGridInvListInit()
        {
            gHandler1 = new GridHandler(this.uGridInvList);

            uGridInvListInitControl();

            uGridInvListInitData();

            //uGridInvListStyleInit();




        }

        /// <summary>
        /// 样式初始化
        /// </summary>
        public void uGridInvListStyleInit()
        {
            gHandler1.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            gHandler1.SetExcelStyleFilter();
        }



        /// <summary>
        /// 数据初始化
        /// </summary>
        public void uGridInvListInitData()
        {
            dataSource1 = invInstance.GetInvInfoList();


            GridHelper gen = new GridHelper();

            uGridInvList = gen.GenerateGrid("GInv", this.panel1, new Point(0, 0));
            gen.SetExcelStyleFilter(uGridInvList);
            //this.uGridInvList.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInvList_InitializeRow);

            //this.uGridInvList.DoubleClickRow += new DoubleClickRowEventHandler(uGridInvList_DoubleClickRow);
            //this.uGridInvList.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInvList_InitializeRow);

            this.uGridInvList.DoubleClickRow += new DoubleClickRowEventHandler(uGridInvList_DoubleClickRow);


            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = dataSource1;

            uGridInvList.DataSource = dataSource;
            AddCustomCol();
            gen.SetGridReadOnly(uGridInvList, true);

            gen.SetGridColumnStyle(uGridInvList, AutoFitStyle.ExtendLastColumn);


          
        }


        public void uGridInvListRefreshData()
        {
            isInit = false;
            dataSource1 = invInstance.GetInvInfoList();
            uGridInvList.DataSource = dataSource1;
            AddCustomCol();
            //gHandler1.BindData(dataSource1, DicColumn1, true);

            //AddCustomCol();
        }

        public void uGridInvListRefreshData(object dataSource)
        {
            isInit = false;
            //dataSource = invInstance.GetInvInfoList(ProdType);
            uGridInvList.DataSource = dataSource;
            //gHandler1.BindData(dataSource1, DicColumn1, true);
            AddCustomCol();
            //AddCustomCol();

        }

        private bool isInit = true;

        public void AddCustomCol()
        {


            //if (!this.uGridInvList.DisplayLayout.Bands[0].Columns.Exists("IsCheck"))
            //{

            try
            {
                if (!isInit)
                {

                    this.uGridInvList.DisplayLayout.Bands[0].Columns.Remove("IsCheck");
                }
                this.uGridInvList.DisplayLayout.Bands[0].Columns.Add("IsCheck", "操作");

                UltraGridColumn col = this.uGridInvList.DisplayLayout.Bands[0].Columns["IsCheck"];

                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.NullText = "0";
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.AllowRowFiltering = DefaultableBoolean.False;
                col.CellClickAction = CellClickAction.EditAndSelectText;
                col.Header.VisiblePosition = 0;
            }
            catch
            { }
            //}


        }

        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void uGridInvListInitControl()
        {

            //this.uGridInvList.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInvList_InitializeRow);

            //this.uGridInvList.DoubleClickRow += new DoubleClickRowEventHandler(uGridInvList_DoubleClickRow);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uGridInvList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            //UltraGridRow row = this.uGridInv.ActiveRow;
            //if (row != null)
            //{
            //    string comptCode = row.Cells["IInfor_PartNo"].Value.ToString();
            //    ComptInv frm = new ComptInv(comptCode);
            //    frm.ShowDialog();
            //}

        }

        private void uGridInvList_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            //根据不同的产品库存状态显示不同的颜色
            if (e.Row.Cells["IInfor_Num"].Value != null)
            {
                int prodStat = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(e.Row.Cells["IInfor_Num"].Value);

                switch (prodStat)
                {
                    //
                    case 0:
                        e.Row.Appearance.BackColor = Color.SkyBlue;
                        //e.Row.Cells["IsOut"].Value = "已出库";

                        //e.Row.Cells["IInfor_Num"].Value = "已出库";
                        //e.Row.Cells["checkbox"].v
                        break;
                    //
                    case 1:
                        //e.Row.Cells["IsOut"].Value = "成品";
                        //e.Row.Cells["IInfor_Num"].Value = "成品";
                        break;

                }
            }
        }

        #endregion

        #endregion



        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string key = this.txtKey.Text;
            //List<Inv_Information> list = new List<Inv_Information>();

            //if (!string.IsNullOrEmpty(key))
            //{
            //    //Predicate<Inv_Information> math = delegate(Inv_Information p) { return (p.IInfor_PartNo.Contains(key)) || (p.IInfor_PartName.Contains(key)); };

            //    Predicate<Inv_Information> math = delegate(Inv_Information p) { return (p.IInfor_PartNo.ToUpper().Contains(key.ToUpper())); };

            //    list = CollectionHelper.Filter<Inv_Information>(dataSource, math);

            //    //RefreshData(list);
            //}
        }


        #region 已出库列表

        #region Grid 初始化

        private GridHandler _gHanlder2;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler2
        {
            get { return _gHanlder2; }
            set { _gHanlder2 = value; }
        }

        private Dictionary<string, string> _DicColumn2 = new Dictionary<string, string>();
        /// <summary>
        /// 需要隐藏的列名
        /// </summary>
        public Dictionary<string, string> DicColumn2
        {
            get { return _DicColumn2; }
            set { _DicColumn2 = value; }
        }

        private List<Inv_Information> dataSource2 = new List<Inv_Information>();
        /// <summary>
        /// 已出库
        /// </summary>
        UltraGrid uGridOuting = new UltraGrid();

        public void uGridOutingInit()
        {
            gHandler2 = new GridHandler(this.uGridOuting);

            uGridOutingInitData();
        }

        /// <summary>
        /// 样式初始化
        /// </summary>
        public void uGridOutingStyleInit()
        {
            gHandler2.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            gHandler2.SetExcelStyleFilter();
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void uGridOutingInitData()
        {
            //获取待出库列表
            dataSource2 = invInstance.GetOutingInvInfoList();

            GridHelper gen = new GridHelper();

            uGridOuting = gen.GenerateGrid("GInv", this.panel2, new Point(0, 0));
            gen.SetExcelStyleFilter(uGridOuting);
            //this.uGridOuting.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInvList_InitializeRow);

            //this.uGridOuting.DoubleClickRow += new DoubleClickRowEventHandler(uGridInvList_DoubleClickRow);

            uGridOuting.DataSource = dataSource2;

            gen.SetGridReadOnly(uGridOuting, true);

            gen.SetGridColumnStyle(uGridOuting, AutoFitStyle.ExtendLastColumn);
        }


        public void uGridOutingRefreshData()
        {
            //获取待出库列表
            dataSource2 = invInstance.GetOutingInvInfoList();
            uGridOuting.DataSource = dataSource2;
            //gHandler2.BindData(dataSource, DicColumn);
        }

        public void uGridOutingRefreshData(List<Inv_Information> data)
        {
            uGridOuting.DataSource = data;
        }

        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void uGridOutingInitControl()
        {

            //this.uGridOuting.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInv_InitializeRow);

            //this.uGridOuting.DoubleClickRow += new DoubleClickRowEventHandler(uGridInv_DoubleClickRow);
        }



        #endregion

        #endregion

        #region 已入库历史记录

        UltraGrid uGridInHis = new UltraGrid();
        GridHelper gen = new GridHelper();
        public void uGridInHisInit()
        {

            uGridInHis = gen.GenerateGrid("GInv", this.pnlHis, new Point(0, 0));
            List<Inv_Information> list = new List<Inv_Information>();
            list = invInstance.GetInHisInvList();
            gen.SetExcelStyleFilter(uGridInHis);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            uGridInHis.DataSource = dataSource;
            gen.SetGridReadOnly(uGridInHis, true);

            gen.SetGridColumnStyle(uGridInHis, AutoFitStyle.ExtendLastColumn);
            
        }

        public void RefreshInHis()
        {
            List<Inv_Information> list = new List<Inv_Information>();
            list = invInstance.GetInHisInvList();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            uGridInHis.DataSource = dataSource;
        }


        public void RefreshInHis(string filter)
        {
            List<Inv_Information> list = new List<Inv_Information>();
            list = invInstance.GetInHisInvList();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            uGridInHis.DataSource = dataSource;
        }

        #endregion

    }
}
