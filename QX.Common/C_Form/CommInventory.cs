using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using System.Reflection;

namespace QX.Common.C_Form
{
    public partial class CommInventory<E> : UserControl where E :class
    {

        public CommInventory()
        {
            InitializeComponent();
        }


        private void CommInventory_Load(object sender, EventArgs e)
        {
            //ProdType = ProdTypeEnum.Parts;
            Init();
        }

        public void Init()
        {
            //Type type = typeof(H);
            //invInstance =(H) type.InvokeMember(null,
            //   BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance,
            //   null, null, null);
            

            //当前零件图号对应库存列表
            uGridComptInvInit();
            //InvInInit();
            //出库
            //InvOutInit();
            ////待入库
            //EnteringInit();
            //EnableEditMode(false);
        }


        #region Member

        private string _ComptCode;
        //当前库存列表对应零件编号
        public string ComptCode
        {
            get { return _ComptCode; }
            set { _ComptCode = value; }
        }

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        //private H invInstance = new H();

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
        /// 
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }


        //private List<E> dataSource = new List<E>();
        #endregion

        #region Grid 初始化



        public void uGridComptInvInit()
        {
            gHandler = new GridHandler(this.uGridComptInv);

            InitControl();

            InitData();

            StyleInit();


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
            //Type type = typeof(H);

            // dataSource = (List<E>)type.InvokeMember("GetInvInfoListByComptCode",
            //                            BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
            //                            null, invInstance, new object[]{ComptCode});


            //dataSource = invInstance.GetInvInfoListByComptCode(ComptCode);


            DicColumn.Add("IInfor_PartNo", "零件图号");
            DicColumn.Add("IInfor_PartName", "零件名称");
            DicColumn.Add("IInfor_ProdCode", "零件编号");
            DicColumn.Add("IInfor_PlanBegin", "计划开工时间");
            DicColumn.Add("IInfor_PlanEnd", "计划完工时间");
            DicColumn.Add("IInfor_InTime", "实际完工时间");
            DicColumn.Add("IInfor_Num", "库存数量");
            DicColumn.Add("IInfor_WareHouse", "存储地");
            DicColumn.Add("IInfor_InConfirm", "入库确认人");
            DicColumn.Add("IInfor_InPep", "编制人");
            DicColumn.Add("IInfor_InDate", "编制时间");
            DicColumn.Add("IInfor_OutDate", "出库时间");
            DicColumn.Add("IInfor_OutPep", "出库确认人");


            //gHandler.BindData(dataSource, DicColumn);

            //AddCustomCol();
        }

        public void AddCustomCol()
        {
            this.uGridComptInv.DisplayLayout.Bands[0].Columns.Add("IsOut", "是否出库");

            UltraGridColumn Col = this.uGridComptInv.DisplayLayout.Bands[0].Columns["IsOut"];


        }

        public void RefreshData()
        {
            //List<Inv_Information> data = invInstance.GetInvInfoListByComptCode(ComptCode);

            //gHandler.BindData(data, DicColumn, true);

            //AddCustomCol();
        }

        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void InitControl()
        {

            this.uGridComptInv.InitializeRow += new InitializeRowEventHandler(uGridComptInv_InitializeRow);

            this.uGridComptInv.DoubleClickRow += new DoubleClickRowEventHandler(uGridComptInv_DoubleClickRow);
        }

        #endregion

        #region Envent Handler

        private void uGridComptInv_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGridRow row = this.uGridComptInv.ActiveRow;
            if (row != null)
            {
                string prodCode = row.Cells["IInfor_ProdCode"].Value.ToString();

                //InvInInit(prodCode);
                //出库操作
                ProdCode = prodCode;

                InvOutDataInit();
            }

        }

        private void uGridComptInv_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            //根据不同的产品库存状态显示不同的颜色
            if (e.Row.Cells["IInfor_Num"].Value != null)
            {
                int num = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(e.Row.Cells["IInfor_Num"].Value);

                switch (num)
                {
                    //已出库
                    case 0:
                        e.Row.Appearance.BackColor = Color.Lavender;
                        //e.Row.Cells["IsOut"].Value = "已出库";
                        break;
                    //成品
                    case 1:
                        //e.Row.Cells["IsOut"].Value = "成品";
                        break;

                }
            }


        }

        //private void btnInventory_Click(object sender, EventArgs e)
        //{
        //    UltraGridRow row = this.uGridComptInv.ActiveRow;
        //    if (row != null)
        //    {
        //        string prodCode = row.Cells["IInfor_ProdCode"].Value.ToString();
        //        InvMaintain frm = new InvMaintain(prodCode);
        //        frm.ShowDialog();

        //        RefreshData();
        //    }
        //}

        #endregion

        #region Member

        //private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        private string _prodCode;
        //零件编号（出库对应零件编号)
        public string ProdCode
        {
            get { return _prodCode; }
            set { _prodCode = value; }
        }

        private BindModelHelper _bmHelper = new BindModelHelper();
        /// <summary>
        /// 绑定数据Handler
        /// </summary>
        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }


        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }

        //private E InvInfor;

        #endregion

        #region 待入库列表

        //private void InvMaintain_Load(object sender, EventArgs e)
        //{
        //    BindEvent();

        //    //InitData();
        //}

        public void EnteringInit()
        {
            ToolStripButton tButton1 = new ToolStripButton();
            tButton1.Text = "入库";
            Image image1 = global::QX.Common.Properties.Resources.inventoryin;　　　　//从资源文件中引用
            tButton1.Image = image1;
            tButton1.Size = new Size(43, 28);
            tButton1.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            this.commonToolBar2.AddCustomControl(tButton1);

            tButton1.Click += new EventHandler(this.btnInventory_Click);

            uGridEnteringListInit();
        }

        private GridHandler enGHandler;

        //private List<E> enteringList = new List<E>();

        private void uGridEnteringListInit()
        {
            enGHandler = new GridHandler(this.uGridEnteringList);

            uGridEnteringListDataInit();

            uGridEnteringStyleInit();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventroryImport();
        }

        private void InventroryImport()
        {
            //MSGCon msgCon = new MSGCon("你确定要删除该信息?");
            //msgCon.StartPosition = FormStartPosition.CenterParent;
            //msgCon.ShowDialog();
            Dictionary<int, string> list = GetGridCheckBoxData();
            //DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定入库?");


            //是否选中要删除的数据
            if (list.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("确定入库以下零件:");
                foreach (KeyValuePair<int, string> kv in list)
                {
                    UltraGridRow row = this.uGridEnteringList.DisplayLayout.Rows[kv.Key];
                    string partNo = row.Cells["IInfor_PartNo"].Value.ToString();
                    string partName = row.Cells["IInfor_PartName"].Value.ToString();
                    sb.AppendLine(partNo + ":" + partName);
                }

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, sb.ToString());


                if (dialog == DialogResult.OK)
                {
                    //int result = invInstance.AddInvInfoForList(list);
                    int result = 0;
                    if (result > 0)
                    {
                        Alert.Show("入库成功");
                        RefreshData();
                        RefreshEnteringData();
                    }
                }
            }
            else
            {
                Alert.Show("请先选择要入库的零件!");
            }

        }



        private Dictionary<int, string> GetGridCheckBoxData()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();

            foreach (UltraGridRow r in this.uGridEnteringList.DisplayLayout.Rows)
            {
                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    list.Add(r.Index, r.Cells["IInfor_ProdCode"].Value.ToString());
                }
            }



            return list;
        }

        private void uGridEnteringListDataInit()
        {

            //enteringList = invInstance.GetEnteringInvInfoListByComptCode(ComptCode);


            //enGHandler.BindData(enteringList, DicColumn, true);
        }

        private void RefreshEnteringData()
        {
            //enteringList = invInstance.GetEnteringInvInfoListByComptCode(ComptCode);


            //enGHandler.BindData(enteringList, DicColumn, true);
        }

        private void uGridEnteringStyleInit()
        {
            enGHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            enGHandler.SetExcelStyleFilter();
        }

        #endregion

        #region 出库

        void InvOutInit()
        {
            ClearTextBox(tabInvOut.Controls);
            BindOutEvent();
        }

        private void BindOutEvent()
        {
            this.txtProdCode.Click += new EventHandler(txtProdCode_Click);
            this.btnInvOut.Click += new EventHandler(btnInvOut_Click);

            EventHandler handler = new EventHandler(this.outContolValue_Changed);

            bmHelper.BindEventToControl(this.tabInvOut.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(tabInvOut.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(tabInvOut.Controls, typeof(DateTimePicker), handler);
            //this.btnConfirm.Click += new EventHandler(btnConfirm_Click);

            //this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        private void txtProdCode_Click(object sender, EventArgs e)
        {

            CommonProd frm = new CommonProd(new Size(700, 300));
            //frm.Init<Inv_Information>(dataSource);
            frm.Show();

            frm.CallBack += new CommonProd.DCallBackHandler(ProdSelect_CallBack);
        }

        void ProdSelect_CallBack(object sender, List<string> dc)
        {
            if (dc != null && dc.Count > 0)
            {
                this.txtProdCode.Text = dc[0];

                ProdCode = dc[0];

                InvOutDataInit();
            }
        }

        public void InvNumInit(int count)
        {

            this.MV_Count.Items.Clear();

            for (int i = 1; i <= count; i++)
            {
                MV_Count.Items.Add(i);
            }

            if (MV_Count.Items.Count > 0)
            {
                MV_Count.SelectedIndex = 0;
            }
        }

        public void InvOutDataInit()
        {
            //this.IInfor_ProdCode.ReadOnly = true;
            if (!string.IsNullOrEmpty(ProdCode))
            {
                this.tabComptInv.SelectedIndex = 1;

                //InvInfor = invInstance.GetInvInfoByCode(ProdCode);

                this.txtProdCode.Text = ProdCode;

                //int count = InvInfor.IInfor_Num;
                int count = 0;
                InvNumInit(count);
            }
        }

        private void btnInvOut_Click(object sender, EventArgs e)
        {
            bool re = UpdateInv();
            if (re)
            {
                Alert.Show("更新零件库存信息成功！");
                ClearTextBox(tabInvOut.Controls);
                RefreshData();
            }
            else
            {
                Alert.Show("更新零件库存信息失败，请查证后重新输入确认!");
            }

        }


        private bool UpdateInv()
        {
            //InvInfor.IInfor_PartNo = ComptCode;
            //InvInfor.IInfor_ProdCode = ProdCode;

            //E inv = InvInfor;

            //bmHelper.BindControlToModel<E>(inv, this.tabInvOut.Controls);

            //出库
            //int re = invInstance.UpdateInvInfo(inv);
            int re = 0;
            if (re > 0)
            {
                IsEdited = false;

                return true;
            }
            {
                return false;
            }
        }

        /// <summary>
        /// 控件值发生变化时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outContolValue_Changed(object sender, EventArgs e)
        {
            IsEdited = true;
        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        public void ClearTextBox(Control.ControlCollection controls)
        {

            foreach (Control item in controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Text = string.Empty;
                }

                if (item.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)item;
                    cb.Items.Clear();
                    cb.Items.Add(0);
                    cb.SelectedItem = 0;
                }
            }

        }


        /// <summary>
        /// 设置文本框是否可编辑
        /// </summary>
        /// <param name="flag"></param>
        public void EnableEditMode(ControlCollection controls, bool flag)
        {
            if (flag)
            {
                foreach (Control item in controls)
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
                foreach (Control item in controls)
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

        #endregion

    }
}
