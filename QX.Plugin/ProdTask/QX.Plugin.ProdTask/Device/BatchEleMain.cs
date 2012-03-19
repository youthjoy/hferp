using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using QX.Common.C_Form;
using QX.DataModel;
using QX.BLL;
using QX.Framework.AutoForm;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;

namespace QX.Plugin.DeviceManage
{
    public partial class BatchEleMain : Form
    {

        private BLL.Bll_Bse_Equ MainInstance = null;

        private Bll_Prod_Record prInstance = new Bll_Prod_Record();

        private Prod_Failure GModel = new Prod_Failure();



        BindModelHelper helper = new BindModelHelper();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;

        private List<FHelper_Info> BatchList
        {

            get;
            set;
        }

        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        string iType = "";

        //public BatchConfirmSup(Bll_FHelper_Info _instance, FHelper_Info _gmodel, string _iType, bool _isAudit)

        public BatchEleMain()
        {
            InitializeComponent();

            MainInstance = new Bll_Bse_Equ();

            BindTopTool();

            LoadWindowControl();

        }

        void BindViewTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));

        }

        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();


            this.commonToolBar1.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);

            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));

        }

        void commonToolBar1_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Alert.Show("数据更新完成!");
                this.Close();
            }

        }

        public bool SaveData()
        {

            bool flag = true;

            Sys_PD_Module module = this.gpMain.Tag as Sys_PD_Module;

            if (module == null)
            {
                Alert.Show("保存失败");
                return false;
            }

            List<Bse_Equ> list = GetGridCheckBoxData();
            helper.BindControlToModel<Prod_Failure>(GModel, this.gpMain.Controls, "");
            foreach (var e in list)
            {
                GModel.Failure_Code = MainInstance.GeneratePFailureCode();
                GModel.Failure_EquCode = e.Equ_Code;
                GModel.Failure_EquName = e.Equ_Name;
                GModel.Failure_EquSpec = e.Equ_Spec;
                flag=MainInstance.AddPFailure(GModel);
            }

            return flag;
        }

        void commonToolBar1_DelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        UltraGrid confirmGrid = new UltraGrid();

        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            BindModelHelper bindHelper = new BindModelHelper();
            helper.GenerateForm("CForm_BatchDFailure", gpMain, new Point(6, 20));

            GridHelper gen = new GridHelper();

            List<Bse_Equ> list = new List<Bse_Equ>();
            list = MainInstance.GetListForPage();
            confirmGrid = gen.GenerateGrid("GEqu_Batch", this.pnlGrid, new Point(0, 0));
            confirmGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            confirmGrid.DataSource = list;
            AddCustomColumn();
        }

        private void AddCustomColumn()
        {

            if (!this.confirmGrid.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = confirmGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;

            }
            else
            {
                confirmGrid.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = confirmGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;
            }


        }

        private List<Bse_Equ> GetGridCheckBoxData()
        {
            List<Bse_Equ> list = new List<Bse_Equ>();

            foreach (UltraGridRow r in this.confirmGrid.DisplayLayout.Rows)
            {

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    Bse_Equ planProd = r.ListObject as Bse_Equ;
                    list.Add(planProd);
                }
            }

            return list;
        }

        private void SetReadOnly()
        {
            foreach (Control ctr in gpMain.Controls)
            {
                ctr.Enabled = false;
            }
        }

        private void FHelperAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
