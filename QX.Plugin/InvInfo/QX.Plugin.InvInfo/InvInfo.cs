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

namespace QX.Plugin.InvInfo
{
    public partial class InvInfo : F_BasciForm
    {
        public InvInfo()
        {
            InitializeComponent();
            BindEvent();
        }

        private void BindEvent()
        {
            #region ToolBar

            this.commonToolBar1.RefreshClicked += new EventHandler(btnRefresh_Click);

            //ToolStripButton tButton = new ToolStripButton();
            //tButton.Text = "库存信息维护";
            //Image image = global::QX.Common.Properties.Resources.inventory;　　　　//从资源文件中引用
            //tButton.Image = image;
            //tButton.Size = new Size(43, 28);
            //tButton.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            //tButton.TextImageRelation = TextImageRelation.ImageAboveText;
            //this.commonToolBar1.AddCustomControl(tButton);

            //tButton.Click += new EventHandler(this.btnInventory_Click);



            ToolStripButton tButton1 = new ToolStripButton();
            tButton1.Text = "库存维护";
            Image image1 = global::QX.Common.Properties.Resources.inventory;　　　　//从资源文件中引用
            tButton1.Image = image1;
            tButton1.Size = new Size(43, 28);
            tButton1.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar1.AddCustomControl(tButton1);

            tButton1.Click += new EventHandler(this.btnInventory_Click);


            ToolStripButton tButton2 = new ToolStripButton();
            tButton2.Text = "出库";
            Image image2 = global::QX.Common.Properties.Resources.inventoryout;　　　　//从资源文件中引用
            tButton2.Image = image2;
            tButton2.Size = new Size(43, 28);
            tButton2.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar2.AddCustomControl(tButton2);

            tButton2.Click += new EventHandler(this.btnOutInventory_Click);

            #endregion
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
            //ProdType = ProdTypeEnum.Parts;
            Init();
        }

        public void Init()
        {
            //与零件相关的库存信息列表（汇总）
            uGridInvInit();
            //库存信息列表
            uGridInvListInit();
            //待出库
            uGridOutingInit();
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

        #region Grid 初始化

        public void uGridInvInit()
        {
            gHandler = new GridHandler(this.uGridInv);

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
            //gh.SetAlternateRowStyle();
            gHandler.SetExcelStyleFilter();
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void InitData()
        {
            dataSource = invInstance.GetInvInfoListForCompt();


            DicColumn.Add("IInfor_PartNo", "零件图号");
            DicColumn.Add("IInfor_PartName", "零件名称");
            //DicColumn.Add("IInfor_ProdCode", "零件编号");
            //DicColumn.Add("IInfor_PlanBegin", "计划开工时间");
            //DicColumn.Add("IInfor_PlanEnd", "计划完工时间");
            //DicColumn.Add("IInfor_InTime", "实际完工时间");
            DicColumn.Add("IInfor_Num", "库存数量");
            //DicColumn.Add("IInfor_WareHouse", "存储地");
            //DicColumn.Add("IInfor_InConfirm", "入库确认人");
            //DicColumn.Add("IInfor_InPep", "编制人");
            //DicColumn.Add("IInfor_InDate", "编制时间");
            //DicColumn.Add("IInfor_OutDate", "出库时间");
            //DicColumn.Add("IInfor_OutPep", "出库确认人");


            gHandler.BindData(dataSource, DicColumn);

        }


        public void RefreshData()
        {
            dataSource = invInstance.GetInvInfoListForCompt();

            gHandler.BindData(dataSource, DicColumn);
        }

        public void RefreshData(object dataSource)
        {
            //dataSource = invInstance.GetInvInfoList(ProdType);

            gHandler.BindData(dataSource, DicColumn);
        }

        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void InitControl()
        {

            this.uGridInv.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInv_InitializeRow);

            this.uGridInv.DoubleClickRow += new DoubleClickRowEventHandler(uGridInv_DoubleClickRow);
        }

        #endregion

        #region Envent Handler

        private void uGridInv_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGridRow row = this.uGridInv.ActiveRow;
            if (row != null)
            {
                string comptCode = row.Cells["IInfor_PartNo"].Value.ToString();
                ComptInv frm = new ComptInv(comptCode);
                frm.ShowDialog();
            }

        }

        private void uGridInv_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            //根据不同的产品库存状态显示不同的颜色
            //if (e.Row.Cells["IInfor_Num"].Value != null)
            //{
            //    int prodStat = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(e.Row.Cells["IInfor_Num"].Value);

            //    switch (prodStat)
            //    {
            //        //在制
            //        case 0:
            //            e.Row.Appearance.BackColor = Color.Lavender;

            //            break;
            //        //成品
            //        case 1:

            //            break;

            //    }
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridInv.ActiveRow;
            if (row != null)
            {
                //string prodCode = row.Cells["IInfor_ProdCode"].Value.ToString();
                //InvMaintain frm = new InvMaintain(prodCode);
                //frm.ShowDialog();

                //RefreshData();


                //库存信息管理
                string comptCode = row.Cells["IInfor_PartNo"].Value.ToString();
                ComptInv frm = new ComptInv(comptCode);
                frm.ShowDialog();
            }
        }


        private void btnOutInventory_Click(object sender, EventArgs e)
        {

            //DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该信息?");


            //if (dialog == DialogResult.OK)
            //{

            //Dictionary<int, string> list = gHandler.GetGridCheckBoxData("IInfor_ProdCode");
            Dictionary<int, string> list = GetGridCheckBoxData();
            //是否选中要删除的数据
            if (list.Count != 0)
            {

                //List<string> promtMsgArray = new List<string>();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("确定出库以下零件:");
                foreach (KeyValuePair<int, string> kv in list)
                {
                    UltraGridRow row = this.uGridInvList.DisplayLayout.Rows[kv.Key];
                    string partNo = row.Cells["IInfor_ProdCode"].Value.ToString();
                    string partName = row.Cells["IInfor_PartName"].Value.ToString();
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

        private Dictionary<int, string> GetGridCheckBoxData()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();

            foreach (UltraGridRow r in this.uGridInvList.DisplayLayout.Rows)
            {
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    list.Add(r.Index, r.Cells["IInfor_ProdCode"].Value.ToString());
                }
            }



            return list;
        }

        #endregion

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

        public void uGridInvListInit()
        {
            gHandler1 = new GridHandler(this.uGridInvList);

            uGridInvListInitControl();

            uGridInvListInitData();

            uGridInvListStyleInit();




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


            DicColumn1.Add("IInfor_PartNo", "零件图号");
            DicColumn1.Add("IInfor_PartName", "零件名称");
            DicColumn1.Add("IInfor_ProdCode", "零件编号");
            DicColumn1.Add("IInfor_PlanBegin", "计划开工时间");
            DicColumn1.Add("IInfor_PlanEnd", "计划完工时间");
            DicColumn1.Add("IInfor_InTime", "实际完工时间");
            DicColumn1.Add("IInfor_Num", "库存数量");
            DicColumn1.Add("IInfor_WareHouse", "存储地");
            DicColumn1.Add("IInfor_InConfirm", "入库确认人");

            //DicColumn1.Add("IsOut", "是否出库");
            //DicColumn.Add("IInfor_InPep", "编制人");
            //DicColumn.Add("IInfor_InDate", "编制时间");
            //DicColumn.Add("IInfor_OutDate", "出库时间");
            //DicColumn.Add("IInfor_OutPep", "出库确认人");
            gHandler1.BindData(dataSource1, DicColumn1, true);


            //UltraGridColumn Col = this.uGridInvList.DisplayLayout.Bands[0].Columns["IsOut"];

            //Col.Header.VisiblePosition = 1;
            //AddCustomCol();

        }


        public void uGridInvListRefreshData()
        {
            dataSource1 = invInstance.GetInvInfoList();

            gHandler1.BindData(dataSource1, DicColumn1, true);

            //AddCustomCol();
        }

        public void uGridInvListRefreshData(object dataSource)
        {
            //dataSource = invInstance.GetInvInfoList(ProdType);

            gHandler1.BindData(dataSource1, DicColumn1, true);

            //AddCustomCol();

        }


        public void AddCustomCol()
        {
            //this.uGridInvList.DisplayLayout.Bands[0].Columns.Add("IsOut", "是否出库");

            //UltraGridColumn Col = this.uGridInvList.DisplayLayout.Bands[0].Columns["IsOut"];

            //Col.Header.VisiblePosition = 1;


        }

        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void uGridInvListInitControl()
        {

            this.uGridInvList.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInvList_InitializeRow);

            this.uGridInvList.DoubleClickRow += new DoubleClickRowEventHandler(uGridInvList_DoubleClickRow);
        }


        private void uGridInvList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGridRow row = this.uGridInv.ActiveRow;
            if (row != null)
            {
                string comptCode = row.Cells["IInfor_PartNo"].Value.ToString();
                ComptInv frm = new ComptInv(comptCode);
                frm.ShowDialog();
            }

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
            string key = this.txtKey.Text;
            List<Inv_Information> list = new List<Inv_Information>();

            if (!string.IsNullOrEmpty(key))
            {
                //Predicate<Inv_Information> math = delegate(Inv_Information p) { return (p.IInfor_PartNo.Contains(key)) || (p.IInfor_PartName.Contains(key)); };

                Predicate<Inv_Information> math = delegate(Inv_Information p) { return (p.IInfor_PartNo.ToUpper().Contains(key.ToUpper())); };

                list = CollectionHelper.Filter<Inv_Information>(dataSource, math);

                RefreshData(list);
            }
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

        public void uGridOutingInit()
        {
            gHandler2 = new GridHandler(this.uGridOuting);

            uGridOutingInitControl();

            uGridOutingInitData();

            uGridOutingStyleInit();
            //this.uGridInv.DisplayLayout.GroupByBox.Hidden = false;

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


            DicColumn2.Add("IInfor_PartNo", "零件图号");
            DicColumn2.Add("IInfor_PartName", "零件名称");
            DicColumn2.Add("IInfor_ProdCode", "零件编号");
            DicColumn2.Add("IInfor_CustBak","备注");
            //DicColumn.Add("IInfor_PlanBegin", "计划开工时间");
            //DicColumn.Add("IInfor_PlanEnd", "计划完工时间");
            //DicColumn.Add("IInfor_InTime", "实际完工时间");
            //DicColumn2.Add("IInfor_Num", "库存数量");
            //DicColumn.Add("IInfor_WareHouse", "存储地");
            //DicColumn.Add("IInfor_InConfirm", "入库确认人");
            //DicColumn.Add("IInfor_InPep", "编制人");
            //DicColumn.Add("IInfor_InDate", "编制时间");
            //DicColumn.Add("IInfor_OutDate", "出库时间");
            //DicColumn.Add("IInfor_OutPep", "出库确认人");


            gHandler2.BindData(dataSource2, DicColumn2);

        }


        public void uGridOutingRefreshData()
        {
            //获取待出库列表
            dataSource2 = invInstance.GetOutingInvInfoList();

            gHandler2.BindData(dataSource, DicColumn);
        }

        public void uGridOutingRefreshData(object data)
        {
            //dataSource = invInstance.GetInvInfoList(ProdType);

            gHandler2.BindData(data, DicColumn2);
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



    }
}
