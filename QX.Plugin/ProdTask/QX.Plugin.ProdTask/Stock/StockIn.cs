using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.Framework.AutoForm;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using QX.DataModel;
using QX.Common.C_Class;
using Infragistics.Win;
using QX.Plugin.Prod.Report;

namespace QX.Plugin.InvInfo
{

    public partial class StockIn : F_BasicPop
    {
        UltraGrid ug_GInv;
        GridHelper gridHelper = new GridHelper();
        Bll_Inv_Information instGInv = new Bll_Inv_Information();
        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }


        public StockIn()
        {
            InitializeComponent();

            InitGridGInv();
            RefreshGInv();
            InitToolBar_GInv();
        }

        public void InitToolBar_GInv()
        {

            ToolStripButton tButton3 = new ToolStripButton();
            tButton3.Text = "入库";
            Image image3 = global::QX.Common.Properties.Resources.stockin;　　　　//从资源文件中引用
            tButton3.Image = image3;
            tButton3.Size = new Size(43, 28);
            tButton3.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            this.tool_bar_GInv.AddCustomControl(tButton3);

            tButton3.Click += new EventHandler(this.btnInInventory_Click);

            //刷新
            tool_bar_GInv.RefreshClicked += new EventHandler(tool_bar_GInv_RefreshClicked);


            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripButton btnPRoadView = tsHelper.New("查看工序", QX.Common.Properties.Resources.nodes, new EventHandler(btnPRoadView_Click));

            this.tool_bar_GInv.AddCustomControl(btnPRoadView);

        }

        /// <summary>
        /// 工序查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnPRoadView_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_GInv.ActiveRow;
            if (row != null)
            {
                string pcode = row.Cells["IInfor_PlanCode"].Value.ToString();
                CommPRoads frm = new CommPRoads(pcode);
                frm.ShowDialog();
            }
        }

        private void btnInInventory_Click(object sender, EventArgs e)
        {
            List<Inv_Information> list=GetGridCheckBoxData();
            //Dictionary<int, string> list = GetGridCheckBoxData();
            //是否选中要删除的数据
            if (list.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("确定入库以下零件:");
                foreach (var  kv in list)
                {
                    //UltraGridRow row = this.ug_GInv.DisplayLayout.Rows[kv.Key];
                    //string partNo = row.Cells["IInfor_ProdCode"].Value.ToString();
                    //string partName = row.Cells["IInfor_PartName"].Value.ToString();
                    string partNo = kv.IInfor_ProdCode;
                    string partName = kv.IInfor_PartName;

                    sb.AppendLine(partNo + ":" + partName);
                }

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, sb.ToString());


                if (dialog == DialogResult.OK)
                {
                    //入库操作
                    instGInv.AddInvInfoForList(list);
                    RefreshGInv();
                }

                //检查是否该零件是组装组件，把其关联组件一起带入库
                MethodInvoker mi = delegate {
                    new Bll_Prod_Record().EnterStockForPatchProd(list);
                };

                mi.BeginInvoke(null, null);
            }
            else
            {
                Alert.Show("请先选择要出库的零件!");
            }

        }

        private bool IsInit = true;

        public void AddCustomCol()
        {
            if (!IsInit)
            {

                this.ug_GInv.DisplayLayout.Bands[0].Columns.Remove("IsCheck");
            }

            this.ug_GInv.DisplayLayout.Bands[0].Columns.Add("IsCheck", "操作");

            UltraGridColumn col = this.ug_GInv.DisplayLayout.Bands[0].Columns["IsCheck"];

            col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            //col.NullText = "0";
            col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col.DataType = typeof(bool);
            col.DefaultCellValue = false;
            col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
            col.AllowRowFiltering = DefaultableBoolean.False;

            col.Header.VisiblePosition = 0;
            col.CellClickAction = CellClickAction.EditAndSelectText;



        }

        private List<Inv_Information> GetGridCheckBoxData()
        {
            List<Inv_Information> list = new List<Inv_Information>();

            foreach (UltraGridRow r in this.ug_GInv.DisplayLayout.Rows)
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


        void tool_bar_GInv_RefreshClicked(object sender, EventArgs e)
        {
            RefreshGInv();
        }

        private void InitGridGInv()
        {
            this.ug_GInv = gridHelper.GenerateGrid("GInv", this.gbGrid, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_GInv, false);
            gridHelper.SetExcelStyleFilter(ug_GInv);
            ug_GInv.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            AddCustomCol();
        }

        private void RefreshGInv()
        {
            List<Inv_Information> list = new List<Inv_Information>();
            //list = this.instGInv.GetAll();
            list = this.instGInv.GetEnteringInvInfoList();
            this.ug_GInv.DataSource = list;
            IsInit = false;
            AddCustomCol();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
        }
    }
}
