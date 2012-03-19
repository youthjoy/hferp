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
using QX.Framework.AutoForm;


namespace QX.Plugin.DeviceManage
{
    public partial class DeviceManage : F_BasciForm
    {
        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Bse_Equ equInstance = new Bll_Bse_Equ();

        #region 窗体单例
        public static DeviceManage NewForm = null;

        public static DeviceManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new DeviceManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion

        public DeviceManage()
        {
            InitializeComponent();
            BindEvent();

        }

        private void BindEvent()
        {
            #region toolbar事件初始化
            this.commonToolBar1.AddClicked += new EventHandler(this.btnAddDev_Click);
            this.commonToolBar1.EditClicked += new EventHandler(this.btnEdit_Click);
            this.commonToolBar1.DelClicked += new EventHandler(this.btnDelete_Click);
            //this.commonToolBar1.PrintClicked += new EventHandler(this.btnPrint_Click);
            this.commonToolBar1.RefreshClicked += new EventHandler(commonToolBar1_RefreshClicked);
            //ToolStripItem item = new ToolStripButton();
            //item.Name = "";
            ////item.Image = new Image();
            //item.Text = "测试";

            //this.commonToolBar1.AddCustomControl(item);
            #endregion


            this.ultraGrid1.DoubleClick += new System.EventHandler(this.ultraGrid1_DoubleClick);

            //窗体是否接受键盘事件响应
            this.KeyPreview = true;

            this.KeyUp += new KeyEventHandler(this.Form_KeyUp);
        }

        void commonToolBar1_RefreshClicked(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private FormHelper fHelper = new FormHelper();
        private void DeviceManage_Load(object sender, EventArgs e)
        {
            Init();

            fHelper.PermissionControl(this.commonToolBar1.toolStrip1.Items, PermissionModuleEnum.DeviceOp.ToString());
        }

        private GridHandler _gHanlder;

        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }

        private Dictionary<string, string> _DicColumn;
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }

        #region 数据初始化

        public void Init()
        {
            gHandler = new GridHandler(this.ultraGrid1);

            InitGrid();

            //StyleInit();
        }

        UltraGrid ultraGrid1 = new UltraGrid();

        public void InitGrid()
        {

            List<Bse_Equ> list = equInstance.GetListForPage();


            GridHelper gen = new GridHelper();

            ultraGrid1 = gen.GenerateGrid("GEqu", this.panel1, new Point(0, 0));
            ultraGrid1.DoubleClickRow += new DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);
            ultraGrid1.DataSource = list;

            gen.SetGridColumnStyle(ultraGrid1, AutoFitStyle.ExtendLastColumn);

            gen.SetGridReadOnly(ultraGrid1, true);

        }

        void ultraGrid1_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            EditHandle();
        }

        public void RefreshGrid()
        {
            List<Bse_Equ> list = equInstance.GetListForPage();

            ultraGrid1.DataSource = list;

        }
        /// <summary>
        /// Grid样式初始化
        /// </summary>
        public void StyleInit()
        {
            gHandler.SetDefaultStyle();
            gHandler.SetExcelStyleFilter();
        }

        #endregion


        #region 按钮事件

        private void ultraGrid1_DoubleClick(object sender, EventArgs e)
        {
            //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体

            //获取当前双击点的位置
            Point p = System.Windows.Forms.Cursor.Position;

            //获取当前双击点在网格中所处的位置
            p = this.ultraGrid1.PointToClient(p);

            //获取双击点网格控件的元素
            Infragistics.Win.UIElement oUI = this.ultraGrid1.DisplayLayout.UIElement.ElementFromPoint(p);
            if (oUI != null)
            {

                //判断双击点是不是行，也可能是列，如果网格控件选取方式不是设的选中整行的话。
                Infragistics.Win.UltraWinGrid.UltraGridRow oRowUI = oUI.SelectableItem as Infragistics.Win.UltraWinGrid.UltraGridRow;

                if (oRowUI != null && oRowUI.Cells["Equ_ID"].Value != null)
                {
                    //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                    string id = oRowUI.Cells["Equ_ID"].Value.ToString();
                    DeviceInfo dev = new DeviceInfo(equInstance, OperationTypeEnum.OperationType.Edit, id);
                    dev.ShowDialog();


                    if (dev.CurrentBseEqu != null)
                    {
                        //dev.BseEqu.Equ_ID = 41;
                        //gHandler.UpdateRow<Bse_Equ>(oRowUI, DicColumn, dev.CurrentBseEqu);
                        //this.ultraGrid1.Refresh();
                        RefreshGrid();

                    }


                }

            }
        }
        /// <summary>
        /// 打印按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintHelper h = new PrintHelper(this.ultraGrid1);
            List<string> list = new List<string>();
            list.Add("checkbox");
            h.Show();
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditHandle();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditHandle();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        private void EditHandle()
        {
            //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体
            UltraGridRow row = this.ultraGrid1.ActiveRow;

            if (row != null && row.Cells["Equ_ID"].Value != null)
            {
                //如果选中的是行，则我们可以通行行的单元格来获取对应的信息
                //string id = oRowUI.Cells["Equ_ID"].Value.ToString();
                string id = row.Cells["Equ_ID"].Value.ToString();
                DeviceInfo dev = new DeviceInfo(equInstance, OperationTypeEnum.OperationType.Edit, id);
                dev.ShowDialog();


                if (dev.CurrentBseEqu != null)
                {
                    RefreshGrid();
                    //dev.BseEqu.Equ_ID = 41;
                    //gHandler.UpdateRow<Bse_Equ>(row, DicColumn, dev.CurrentBseEqu);

                    //UpdateGridCaption();

                    //this.ultraGrid1.Refresh();
                }
            }
        }

        private void btnAddDev_Click(object sender, EventArgs e)
        {
            DeviceInfo dev = new DeviceInfo(equInstance, OperationTypeEnum.OperationType.Add, null);
            dev.ShowDialog();

            if (dev.CurrentBseEqu != null)
            {
                RefreshGrid();
                //gHandler.AddNewRow<Bse_Equ>(DicColumn, dev.CurrentBseEqu, "Equ_ID");
                //this.ultraGrid1.Refresh();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "你确定要删除该信息?");


            if (dialog == DialogResult.OK)
            {

                //Dictionary<int, string> list = GetGridCheckBoxData();
                UltraGridRow row = this.ultraGrid1.ActiveRow;
                Bse_Equ equ = row.ListObject as Bse_Equ;
               
                var result = equInstance.RemoveDevice(equ);

                if (result > 0)
                {


                    RefreshGrid();

                    Alert.Show("成功删除");
                }
                else
                {
                    Alert.Show("删除出现异常!");
                }
                //}
                //else
                //{
                //    Alert.Show("请先选择要删除的数据!");
                //}

            }
        }

        private Dictionary<int, string> GetGridCheckBoxData()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();

            foreach (UltraGridRow r in this.ultraGrid1.DisplayLayout.Rows)
            {
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    list.Add(r.Index, r.Cells["Equ_ID"].Value.ToString());
                }
            }



            return list;
        }

        #endregion


        private void ultraGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UpdateGridCaption();
            }
        }


        public void UpdateGridCaption()
        {
            UltraGridRow row = this.ultraGrid1.ActiveRow;
            if (row != null)
            {
                StringBuilder sb = new StringBuilder();
                if (row.Cells["Equ_Code"].Value != null)
                {
                    sb.Append("设备编码:" + row.Cells["Equ_Code"].Value.ToString());
                }
                if (row.Cells["Equ_Name"].Value != null)
                {
                    sb.Append(",设备名称:" + row.Cells["Equ_Name"].Value.ToString());
                }

                string msg = sb.ToString();
                gHandler.SetGridCaption(msg);
            }
        }

    }
}
