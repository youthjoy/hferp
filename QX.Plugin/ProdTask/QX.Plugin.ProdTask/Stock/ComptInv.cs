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
using QX.BseDict;
using QX.Framework.AutoForm;
using Infragistics.Win;
namespace QX.Plugin.InvInfo
{
    public partial class ComptInv :F_BasicPop
    {
        public ComptInv()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">零件图号</param>
        public ComptInv(string code)
        {
            InitializeComponent();
            ComptCode = code;
        }

        private void EventInit()
        {
            this.commonToolBar1.RefreshClicked += new EventHandler(commonToolBar1_RefreshClicked);
        }

        void commonToolBar1_RefreshClicked(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ComptInv_Load(object sender, EventArgs e)
        {
            //ProdType = ProdTypeEnum.Parts;
            Init();
        }

        public void Init()
        {
            //当前零件图号对应库存列表
            uGridComptInvInit();
            //InvInInit();
            //出库
            InvOutInit();
            //待入库
            EnteringInit();
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
        /// 
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }


        private List<Inv_Information> dataSource = new List<Inv_Information>();
        #endregion

        #region 库存Grid 初始化

        UltraGrid uGridComptInv = new UltraGrid();

        public void uGridComptInvInit()
        {
            gHandler = new GridHandler(this.uGridComptInv);

            InitControl();

            InitData();

            //StyleInit();


        }

        /// <summary>
        /// 样式初始化
        /// </summary>
        public void StyleInit()
        {
            //gHandler.SetDefaultStyle();
            ////gh.SetAlternateRowStyle();
            //gHandler.SetExcelStyleFilter();
        }

        /// <summary>
        /// 数据初始化()
        /// </summary>
        public void InitData()
        {
            dataSource = invInstance.GetInvInfoListByComptCode(ComptCode);

            GridHelper gen = new GridHelper();
            uGridComptInv = gen.GenerateGrid("GInv", this.panel1, new Point(0, 0));
            uGridComptInv.DataSource = dataSource;

            gHandler.SetGridEditMode(false, uGridComptInv);
            //DicColumn.Add("IInfor_PartNo", "零件图号");
            //DicColumn.Add("IInfor_PartName", "零件名称");
            //DicColumn.Add("IInfor_ProdCode", "零件编号");
            //DicColumn.Add("IInfor_PlanBegin", "计划开工时间");
            //DicColumn.Add("IInfor_PlanEnd", "计划完工时间");
            //DicColumn.Add("IInfor_InTime", "实际完工时间");
            //DicColumn.Add("IInfor_Num", "库存数量");
            //DicColumn.Add("IInfor_WareHouse", "存储地");
            //DicColumn.Add("IInfor_InConfirm", "入库确认人");
            //DicColumn.Add("IInfor_InPep", "编制人");
            //DicColumn.Add("IInfor_InDate", "编制时间");
            //DicColumn.Add("IInfor_OutDate", "出库时间");
            //DicColumn.Add("IInfor_OutPep", "出库确认人");


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
            List<Inv_Information> data = invInstance.GetInvInfoListByComptCode(ComptCode);
            uGridComptInv.DataSource = data;
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

        private Inv_Information InvInfor;

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

        private List<Inv_Information> enteringList = new List<Inv_Information>();

        private void uGridEnteringListInit()
        {
            enGHandler = new GridHandler(this.uGridEnteringList);

            uGridEnteringListDataInit();

            //uGridEnteringStyleInit();
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
            //Dictionary<int, string> list = GetGridCheckBoxData();
            ////DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定入库?");


            ////是否选中要删除的数据
            //if (list.Count != 0)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine("确定入库以下零件:");
            //    foreach (KeyValuePair<int, string> kv in list)
            //    {
            //        UltraGridRow row = this.uGridEnteringList.DisplayLayout.Rows[kv.Key];
            //        string partNo = row.Cells["IInfor_ProdCode"].Value.ToString();
            //        string partName = row.Cells["IInfor_PartName"].Value.ToString();
            //        sb.AppendLine(partNo + ":" + partName);
            //    }

            //    DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, sb.ToString());


            //    if (dialog == DialogResult.OK)
            //    {
            //        int result = invInstance.AddInvInfoForList(list);

            //        if (result > 0)
            //        {
            //            Alert.Show("入库成功");
            //            RefreshData();
            //            RefreshEnteringData();
            //        }
            //    }
            //}
            //else
            //{
            //    Alert.Show("请先选择要入库的零件!");
            //}

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


        private UltraGrid uGridEnteringList = new UltraGrid();

        private void uGridEnteringListDataInit()
        {
            GridHelper gen = new GridHelper();

            enteringList = invInstance.GetEnteringInvInfoListByComptCode(ComptCode);

            uGridEnteringList = gen.GenerateGrid("GWInv",this.panel2,new Point(0,0));

            uGridEnteringList.DataSource = enteringList;

            gHandler.SetGridEditMode(false, uGridEnteringList);

            //enGHandler.BindData(enteringList, DicColumn, true);

            AddCheckbox(uGridEnteringList);
        }


        private void AddCheckbox(UltraGrid comGrid)
        {

            comGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "操作");
            UltraGridColumn col = comGrid.DisplayLayout.Bands[0].Columns["checkbox"];

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

        private void RefreshEnteringData()
        {
            enteringList = invInstance.GetEnteringInvInfoListByComptCode(ComptCode);

            uGridEnteringList.DataSource = enteringList;
            //enGHandler.BindData(enteringList, DicColumn, true);
        }

        private void uGridEnteringStyleInit()
        {
            enGHandler.SetDefaultStyle();
            //gh.SetAlternateRowStyle();
            enGHandler.SetExcelStyleFilter();
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="code">零件编号</param>
        //void InvInInit()
        //{
        //    //ProdCode = code;
        //    InvInDataInit();
        //    InitCombo();
        //    BindEvent();
        //}


        //private void InitCombo()
        //{
        //    DictComboHelper.BindComboData(IInfor_Stat, DictKeyEnum.IInfor_Stat);
        //}

        //private void BindEvent()
        //{
        //    this.btnConfirm.Click += new EventHandler(btnConfirm_Click);

        //    //this.btnCancel.Click += new EventHandler(btnCancel_Click);
        //}



        //public void InvInDataInit()
        //{
        //    //this.IInfor_ProdCode.ReadOnly = true;

        //    InvInfor = new Inv_Information();
        //    InvInfor.IInfor_PartNo = ComptCode;

        //    ////this.IInfor_PartNo.ReadOnly = true;

        //    //InvInfor = invInstance.GetInvInfoByCode(ProdCode);

        //    //bmHelper.BindModelToControl<Inv_Information>(InvInfor, tabInvIn.Controls);


        //    EventHandler handler = new EventHandler(this.contolValue_Changed);

        //    bmHelper.BindEventToControl(tabInvIn.Controls, typeof(TextBox), handler);
        //    bmHelper.BindEventToControl(tabInvIn.Controls, typeof(ComboBox), handler);
        //    bmHelper.BindEventToControl(tabInvIn.Controls, typeof(DateTimePicker), handler);
        //}

        ///// <summary>
        ///// 控件值发生变化时触发事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void contolValue_Changed(object sender, EventArgs e)
        //{
        //    IsEdited = true;
        //}


        //private void btnConfirm_Click(object sender, EventArgs e)
        //{

        //    if (!ValidateData())
        //    {
        //        return;
        //    }

        //    bool re = AddProd();
        //    if (re)
        //    {
        //        Alert.Show("更新零件库存信息成功！");

        //        gHandler.AddNewRow<Inv_Information>(DicColumn, InvInfor);
        //        //RefreshData();
        //        //this.Close();
        //    }
        //    else
        //    {
        //        Alert.Show("更新零件库存信息失败，请查证后重新输入确认!");
        //        //this.Close();
        //    }

        //}

        //private bool AddProd()
        //{

        //    Inv_Information inv = InvInfor;

        //    bmHelper.BindControlToModel<Inv_Information>(inv, tabInvIn.Controls);

        //    InvInfor.IInfor_PartNo = ComptCode;
        //    //入库
        //    int re = invInstance.AddInv(inv);

        //    if (re > 0)
        //    {
        //        IsEdited = false;

        //        return true;
        //    }
        //    {
        //        return false;
        //    }
        //}

        //private bool ValidateData()
        //{
        //    return true;

        //    #region 数据有效性验证

        //    //bool flag = true;

        //    //Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
        //    //dict.Add("Comp_Code", new ValidateModel(true, 20, 0, new string[] { "零件", "设备编号字符数不能超过20个" }));
        //    //dict.Add("Comp_Name", new ValidateModel(true, 20, 0, new string[] { "；零件名称不能为空", "设备名称字符数不能超过20个" }));
        //    ////dict.Add("

        //    //Dictionary<string, string> re = ValidateControlHelper.Validate(gpCompt.Controls, dict);

        //    //if (re.Count != 0)
        //    //{
        //    //    StringBuilder sb = new StringBuilder();
        //    //    foreach (KeyValuePair<string, string> k in re)
        //    //    {
        //    //        //Control c = this.Controls.Find("lb" + k, true);
        //    //        sb.AppendLine(k.Value);
        //    //    }

        //    //    Alert.Show(sb.ToString());

        //    //    flag = false;
        //    //}

        //    //return flag;

        //    #endregion
        //}


        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    CloseForm();
        //}





        #endregion

        #region 出库

        void InvOutInit()
        {
            ClearTextBox(tabInvOut.Controls);
            //InvOutDataInit();
            //InvOutEventInit();
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
            frm.Init<Inv_Information>(dataSource);
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

                InvInfor = invInstance.GetInvInfoByCode(ProdCode);

                this.txtProdCode.Text = ProdCode;

                int count = InvInfor.IInfor_Num;

                InvNumInit(count);
            }
            //else
            //{
            //    //显示选择框

            //}

            //InvInfor.IInfor_PartNo = ComptCode;

            ////this.IInfor_PartNo.ReadOnly = true;

            //InvInfor = invInstance.GetInvInfoByCode(ProdCode);

            //bmHelper.BindModelToControl<Inv_Information>(InvInfor, tabInvIn.Controls);



        }

        private void btnInvOut_Click(object sender, EventArgs e)
        {
            //if (!ValidateData())
            //{
            //    return;
            //}

            bool re = UpdateInv();
            if (re)
            {
                Alert.Show("更新零件库存信息成功！");
                ClearTextBox(tabInvOut.Controls);
                RefreshData();
                //gHandler.UpdateRow<Inv_Information>(DicColumn, InvInfor);
                //RefreshData();
                //this.Close();
            }
            else
            {
                Alert.Show("更新零件库存信息失败，请查证后重新输入确认!");
                //this.Close();
            }

        }


        private bool UpdateInv()
        {
            InvInfor.IInfor_PartNo = ComptCode;
            InvInfor.IInfor_ProdCode = ProdCode;
            //int count = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(this.MV_Count.SelectedItem);

            //InvInfor.IInfor_Num = InvInfor.IInfor_Num - count;

            Inv_Information inv = InvInfor;

            bmHelper.BindControlToModel<Inv_Information>(inv, this.tabInvOut.Controls);

            //出库
            int re = invInstance.UpdateInvInfo(inv);

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

        //关闭窗口处理方法
        private void CloseForm()
        {
            if (IsEdited)
            {

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定放弃保存当前编辑数据，关闭该窗口?");


                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

        #endregion


    }
}
