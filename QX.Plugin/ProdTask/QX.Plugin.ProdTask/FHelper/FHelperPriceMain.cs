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
using QX.BseDict;
using QX.Framework.AutoForm;
using QX.Plugin.Prod;

namespace QX.Plugin.FHelper
{
    public partial class FHelperPriceMain : F_BasciForm
    {
        public FHelperPriceMain()
        {
            InitializeComponent();
            ToolInit();
        }

        ToolStripTextBox txtKey = new ToolStripTextBox();

        FormHelper fHelper = new FormHelper();

        private void ToolInit()
        {
            this.commonToolBar1.AddClicked += new EventHandler(commonToolBar1_AddClicked);
            this.commonToolBar1.RefreshClicked += new EventHandler(commonToolBar1_RefreshClicked);
            this.commonToolBar1.EditClicked += new EventHandler(commonToolBar1_EditClicked);

            this.tbOuting.AuditClicked += new EventHandler(commonToolBar2_AuditClicked);
            this.tbOuting.RefreshClicked += new EventHandler(commonToolBar2_RefreshClicked);


            //我的申请单
            this.commonToolBar1.AddCustomControl(5, txtKey);

            ToolStripButton searchBtn = new ToolStripButton();
            searchBtn.Text = "搜索";
            Image image3 = QX.Common.Properties.Resources.search;
            searchBtn.Image = image3;
            searchBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            searchBtn.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            searchBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            searchBtn.Click += new EventHandler(searchBtn_Click);
            this.commonToolBar1.AddCustomControl(6, searchBtn);


            fHelper.PermissionControl(this.commonToolBar1.toolStrip1.Items, PermissionModuleEnum.FHelper.ToString());
        }


        void searchBtn_Click(object sender, EventArgs e)
        {

            string key = this.txtKey.Text;

            string where = string.Empty;

            if (string.IsNullOrEmpty(key))
            {
                uGridHandingBind();
            }
            else
            {

            }


        }

        private void FilterData(string key)
        {

            Predicate<DataModel.FHelper_Price> math = delegate(DataModel.FHelper_Price p) { return (p.FP_ManuName.ToUpper().Contains(key.ToUpper()) || (p.FP_NodeName.ToUpper().Contains(key.ToUpper()) || (p.FP_CompName.Contains(key)))); };

            List<DataModel.FHelper_Price> filterData = CollectionHelper.Filter<DataModel.FHelper_Price>(CurFHelperPriceDataSource, math);

            uGridHanding.DataSource = filterData;
        }

        void commonToolBar1_EditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridHanding.ActiveRow;
            if (row != null)
            {

                DataModel.FHelper_Price p = row.ListObject as DataModel.FHelper_Price;

                var model = pInstance.GetModelByCode(p.FP_Code);

                if (model.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                {
                    Alert.Show("当前单据已进入审核流程，不能更新其单据信息!");
                    FHPriceOp PriceFrm = new FHPriceOp(p, OperationTypeEnum.OperationType.Look, false);
                    PriceFrm.ShowDialog();
                    uGridHandingBind();
                }
                else
                {

                    FHPriceOp PriceFrm = new FHPriceOp(p, OperationTypeEnum.OperationType.Edit, false);
                    PriceFrm.ShowDialog();
                    uGridHandingBind();
                }


            }
        }

        void commonToolBar1_RefreshClicked(object sender, EventArgs e)
        {
            uGridHandingBind();
        }

        void commonToolBar2_RefreshClicked(object sender, EventArgs e)
        {
            uGridOutingBind();
        }

        void commonToolBar2_AuditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridAudit.ActiveRow;
            if (row != null)
            {
                var model = row.ListObject as DataModel.FHelper_Price;
                FHPriceOp viewFrm = new FHPriceOp(model, OperationTypeEnum.OperationType.Edit, true);
                //viewFrm.ContractInstance = instance;
                //viewFrm.CdetailInstance = DetailInstance;
                //viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.FHelperPriceAudit.ToString(), model.FP_Code, model.AuditCurAudit, viewFrm);

                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                if (DialogResult.OK == frm.ShowDialog())
                {
                    viewFrm.isAudit = false;
                    viewFrm.Close();
                }
            }
        }

        void frm_CallBack(AuditReturnResultEnum re, string AStat)
        {
            //审核行
            UltraGridRow row = this.uGridAudit.ActiveRow;

            switch (re)
            {
                case AuditReturnResultEnum.Success:
                    uGridOutingBind();
                    Alert.Show("审核完成");
                    break;
                case AuditReturnResultEnum.Fail:
                    Alert.Show("审核失败!");
                    break;
            }
        }


        void commonToolBar1_AddClicked(object sender, EventArgs e)
        {
            FHPriceOp PriceFrm = new FHPriceOp(new QX.DataModel.FHelper_Price(), OperationTypeEnum.OperationType.Add, false);
            PriceFrm.ShowDialog();
            uGridHandingBind();
        }

        #region 窗体单例

        public static FHelperPriceMain NewForm = null;



        public static FHelperPriceMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new FHelperPriceMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void FHelperPriceMain_Load(object sender, EventArgs e)
        {
            uGridOutingInit();

            uGridHandingInit();
        }


        #region 待审核

        private Bll_FHelper_Price pInstance = new Bll_FHelper_Price();


        private List<QX.DataModel.FHelper_Price> CurFHelperPriceDataSource = new List<QX.DataModel.FHelper_Price>();

        private GridHandler _FHelperHandler;

        public GridHandler FHelperHandler
        {
            get { return _FHelperHandler; }
            set { _FHelperHandler = value; }
        }

        private Dictionary<string, string> _FHelperPriceDicColumn = new Dictionary<string, string>();

        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> FHelperPriceDicColumn
        {
            get { return _FHelperPriceDicColumn; }
            set { _FHelperPriceDicColumn = value; }
        }

        UltraGrid uGridHanding = new UltraGrid();

        public void uGridHandingInit()
        {
            FHelperHandler = new GridHandler(this.uGridHanding);

            uGridHandingInitColumn();
            uGridEventInit();
            uGridHandingBind();

            //uGridHandingStyleInit();


        }

        void uGridHanding_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            try
            {
                DataModel.FHelper_Price price = e.Row.ListObject as DataModel.FHelper_Price;
                OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), price.AuditStat));

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
                        break;
                    case OperationTypeEnum.AudtiOperaTypeEnum.Litter:
                        e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[2];
                        break;
                }
            }
            catch
            {

            }
        }


        private void uGridEventInit()
        {
            this.uGridHanding.InitializeRow += new InitializeRowEventHandler(uGridHanding_InitializeRow);

        }

        void uGridHanding_AfterExitEditMode(object sender, EventArgs e)
        {
            UltraGridCell aCell = this.uGridHanding.ActiveCell;
            if (aCell != null)
            {
                MessageBox.Show(aCell.Value.ToString());
            }
        }

        //void uGridHanding_CellChange(object sender, CellEventArgs e)
        //{
        //    if (e.Cell.Column.Key == "FP_Price")
        //    {
        //        MessageBox.Show(e.Cell.Value.ToString());
        //    }
        //}

        void uGridHanding_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell aCell = this.uGridHanding.ActiveCell;
            if (aCell != null)
            {

                if (aCell.Column.Key == "FP_ManuName" || aCell.Column.Key == "FP_ManuCode")
                {

                    CommManu manuFrm = new CommManu();
                    manuFrm.CallBack += new CommManu.DCallBackHandler(manuFrm_CallBack);
                    manuFrm.ShowDialog();
                    e.Cancel = true;
                }
            }
        }

        void manuFrm_CallBack(bool result, FHelper_ManuList data)
        {
            if (data != null)
            {
                UltraGridRow row = this.uGridHanding.ActiveRow;
                row.Cells["FP_ManuName"].Value = data.FM_ManuName;
                row.Cells["FP_ManuCode"].Value = data.FM_ManuCode;

                DataModel.FHelper_Price price = row.ListObject as DataModel.FHelper_Price;
                pInstance.Update(price);
            }
        }


        private void uGridHandingInitColumn()
        {
            List<DataModel.FHelper_Price> list = new List<DataModel.FHelper_Price>();
            GridHelper gen = new GridHelper();

            uGridHanding = gen.GenerateGrid("CList_FHelper_Price", this.panel1, new Point(0, 0));

            uGridHanding.DataSource = list;
            gen.SetGridColumnStyle(uGridHanding, AutoFitStyle.ExtendLastColumn);
            uGridHanding.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

            //    FHelperPriceDicColumn.Add("FP_ManuName", "厂家名称");
            //    FHelperPriceDicColumn.Add("FP_ManuCode", "厂家编码");
            //    FHelperPriceDicColumn.Add("FP_RefComptCode", "零件编号");
            //    //FHelperPriceDicColumn.Add("FP_CompName", "零件名称");
            //    FHelperPriceDicColumn.Add("FP_CompCode", "零件图号");
            //    FHelperPriceDicColumn.Add("FP_NodeName", "工序名称");
            //    FHelperPriceDicColumn.Add("FP_Price", "费用");
            //    FHelperPriceDicColumn.Add("FP_Creator", "编制人");
            //    FHelperPriceDicColumn.Add("FP_Creatime", "编制时间");

            //    FHelperHandler.BindData(CurFHelperPriceDataSource, FHelperPriceDicColumn);
            //FHelperHandler.BindData<DataModel.FHelper_Price>(CurFHelperPriceDataSource,hideColumn, false);
        }

        public void uGridHandingBind()
        {
            CurFHelperPriceDataSource = pInstance.GetHandingPriceList();

            uGridHanding.DataSource = CurFHelperPriceDataSource;

            uGridHanding.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
        }

        public void RefreshPriceList()
        {
            CurFHelperPriceDataSource = pInstance.GetHandingPriceList();

            uGridHanding.DataSource = CurFHelperPriceDataSource;
        }

        #endregion

        #region 待审核


        private Bll_FHelper_Info infoInstance = new Bll_FHelper_Info();

        private List<DataModel.FHelper_Price> CurFHelper_PriceDataSource = new List<DataModel.FHelper_Price>();
        //部门选择处理Handler
        private Bll_Dept deptInstance = new Bll_Dept();

        private GridHandler _FHelperOutingHandler;

        public GridHandler FHelperOutingHandler
        {
            get { return _FHelperOutingHandler; }
            set { _FHelperOutingHandler = value; }
        }

        private Dictionary<string, string> FHelperDicColumn = new Dictionary<string, string>();

        UltraGrid uGridAudit = new UltraGrid();

        public void uGridOutingInit()
        {
            FHelperOutingHandler = new GridHandler(this.uGridAudit);

            uGridOutingInitColumn();
            uGridOutingEventInit();
            uGridOutingBind();


        }


        private void uGridOutingEventInit()
        {
            //this.uGridOuting.BeforeEnterEditMode += new CancelEventHandler(uGridOuting_BeforeEnterEditMode);
            //this.uGridOuting.InitializeRow += new InitializeRowEventHandler(uGridOuting_InitializeRow);
        }


        void uGridOuting_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell aCell = this.uGridAudit.ActiveCell;
            if (aCell != null)
            {
                Prod_Roads pr = this.uGridAudit.ActiveRow.ListObject as Prod_Roads;
                switch (aCell.Column.Key)
                {
                    case "FHelperInfo_FSup":

                        CommManu outingManuFrm = new CommManu();
                        outingManuFrm.CallBack += new CommManu.DCallBackHandler(outingManuFrm_CallBack);
                        outingManuFrm.ShowDialog();
                        e.Cancel = true;
                        break;
                }
            }
        }

        void outingManuFrm_CallBack(bool result, FHelper_ManuList data)
        {


            if (data != null)
            {
                UltraGridRow row = this.uGridAudit.ActiveRow;
                row.Cells["FHelperInfo_FSupName"].Value = data.FM_ManuName;
                row.Cells["FHelperInfo_FSup"].Value = data.FM_ManuCode;

                DataModel.FHelper_Info info = row.ListObject as DataModel.FHelper_Info;
                FHelper_Info newInfo = infoInstance.HandingInfo(info);

                FHelperOutingHandler.UpdateRow<FHelper_Info>(row, info);

                //RefreshOutingInfo();
            }
        }

        private void uGridOutingInitColumn()
        {
            List<DataModel.FHelper_Price> list = new List<DataModel.FHelper_Price>();

            GridHelper gen = new GridHelper();

            uGridAudit = gen.GenerateGrid("CList_FHelper_Price", this.panel2, new Point(0, 0));

            uGridAudit.DataSource = list;
            //gen.SetGridColumnStyle(uGridAudit, AutoFitStyle.ExtendLastColumn);
            uGridAudit.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
        }

        public void uGridOutingBind()
        {

            CurFHelper_PriceDataSource = pInstance.GetAuditingList();

            uGridAudit.DataSource = CurFHelper_PriceDataSource;
        }



        public void RefreshOutingInfo()
        {
            CurFHelper_PriceDataSource = pInstance.GetAuditingList();

            uGridAudit.DataSource = CurFHelper_PriceDataSource;
        }


        #endregion

    }
}
