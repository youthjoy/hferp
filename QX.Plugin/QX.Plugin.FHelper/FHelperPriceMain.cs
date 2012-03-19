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

namespace QX.Plugin.FHelper
{
    public partial class FHelperPriceMain : F_BasciForm
    {
        public FHelperPriceMain()
        {
            InitializeComponent();
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


        public void uGridHandingInit()
        {
            FHelperHandler = new GridHandler(this.uGridHanding);


            uGridHandingInitColumn();

            uGridHandingBind();

            uGridHandingStyleInit();

            uGridEventInit();
        }

        private void uGridEventInit()
        {

            this.uGridHanding.BeforeEnterEditMode += new CancelEventHandler(uGridHanding_BeforeEnterEditMode);
            //this.uGridHanding.CellChange += new CellEventHandler(uGridHanding_CellChange);
            this.uGridHanding.AfterExitEditMode += new EventHandler(uGridHanding_AfterExitEditMode);


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

        private void uGridHandingStyleInit()
        {

            FHelperHandler.SetDefaultStyle();
            FHelperHandler.SetExcelStyleFilter();

            this.uGridHanding.DisplayLayout.Bands[0].Columns["FP_ManuName"].CellClickAction = CellClickAction.EditAndSelectText;
            this.uGridHanding.DisplayLayout.Bands[0].Columns["FP_ManuCode"].CellClickAction = CellClickAction.EditAndSelectText;
            this.uGridHanding.DisplayLayout.Bands[0].Columns["FP_Price"].CellClickAction = CellClickAction.Edit;
        }

        private void uGridHandingInitColumn()
        {
            FHelperPriceDicColumn.Add("FP_ManuName", "厂家名称");
            FHelperPriceDicColumn.Add("FP_ManuCode", "厂家编码");
            FHelperPriceDicColumn.Add("FP_RefComptCode", "零件编号");
            //FHelperPriceDicColumn.Add("FP_CompName", "零件名称");
            FHelperPriceDicColumn.Add("FP_CompCode", "零件图号");
            FHelperPriceDicColumn.Add("FP_NodeName", "工序名称");
            FHelperPriceDicColumn.Add("FP_Price", "费用");
            FHelperPriceDicColumn.Add("FP_Creator", "编制人");
            FHelperPriceDicColumn.Add("FP_Creatime", "编制时间");

            FHelperHandler.BindData(CurFHelperPriceDataSource, FHelperPriceDicColumn);
            //FHelperHandler.BindData<DataModel.FHelper_Price>(CurFHelperPriceDataSource,hideColumn, false);
        }

        public void uGridHandingBind()
        {
            CurFHelperPriceDataSource = pInstance.GetHandingPriceList();

            FHelperHandler.BindData(CurFHelperPriceDataSource, FHelperPriceDicColumn);

            AdjustPlaningTaskGridColumn();
        }

        public void AdjustPlaningTaskGridColumn()
        {

            FHelperHandler.AdjustGridColumn(FHelperPriceDicColumn);
        }

        private void RefreshPlaningTask()
        {
            //CurPlanProdDataSource = ptInstance.GetFinProdTask();

            CurFHelperPriceDataSource = pInstance.GetHandingPriceList();

            FHelperHandler.BindData(CurFHelperPriceDataSource, FHelperPriceDicColumn);

            AdjustPlaningTaskGridColumn();
        }

        private void RefreshPlaningTask(List<Prod_Task> list)
        {
            FHelperHandler.BindData(list, FHelperPriceDicColumn);

            AdjustPlaningTaskGridColumn();
        }

        #endregion

        #region 待出厂


        private Bll_FHelper_Info infoInstance = new Bll_FHelper_Info();

        private List<FHelper_Info> CurFHelperOutingDataSource = new List<FHelper_Info>();
        //部门选择处理Handler
        private Bll_Dept deptInstance = new Bll_Dept();

        private GridHandler _FHelperOutingHandler;

        public GridHandler FHelperOutingHandler
        {
            get { return _FHelperOutingHandler; }
            set { _FHelperOutingHandler = value; }
        }

        private Dictionary<string, string> FHelperDicColumn = new Dictionary<string, string>();


        public void uGridOutingInit()
        {
            FHelperOutingHandler = new GridHandler(this.uGridOuting);

            uGridOutingInitColumn();


            uGridOutingBind();

            uGridOutingtyleInit();

            uGridOutingEventInit();
        }


        private void uGridOutingEventInit()
        {
            this.uGridOuting.BeforeEnterEditMode += new CancelEventHandler(uGridOuting_BeforeEnterEditMode);
        }

        void uGridOuting_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell aCell = this.uGridOuting.ActiveCell;
            if (aCell != null)
            {
                Prod_Roads pr = this.uGridOuting.ActiveRow.ListObject as Prod_Roads;
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
                UltraGridRow row = this.uGridOuting.ActiveRow;
                row.Cells["FHelperInfo_FSupName"].Value = data.FM_ManuName;
                row.Cells["FHelperInfo_FSup"].Value = data.FM_ManuCode;
               
                DataModel.FHelper_Info info = row.ListObject as DataModel.FHelper_Info;
                FHelper_Info newInfo = infoInstance.HandingInfo(info);

                FHelperOutingHandler.UpdateRow<FHelper_Info>(row, info);

                //RefreshOutingInfo();
            }
        }



        private void uGridOutingtyleInit()
        {
            this.uGridOuting.DisplayLayout.Bands[0].Columns["FHelperInfo_FSup"].CellClickAction = CellClickAction.Edit;
            //this.uGridOuting.DisplayLayout.Bands[0].Columns["PRoad_EquName"].CellClickAction = CellClickAction.Edit;



            FHelperOutingHandler.SetDefaultStyle();
            FHelperOutingHandler.SetExcelStyleFilter();

            //this.uGridOuting.DisplayLayout.Bands[0].Columns["PRoad_Begin"].Width = 100;
            //this.uGridOuting.DisplayLayout.Bands[0].Columns["PRoad_End"].Width = 100;
        }



        private void uGridOutingInitColumn()
        {
            FHelperDicColumn.Add("FHelperInfo_RoadNodeName", "外协加工节点名称");
            FHelperDicColumn.Add("FHelperInfo_RoadNodes", "外协加工节点编码");
            FHelperDicColumn.Add("FHelperInfo_PartCode", "零件图号");
            FHelperDicColumn.Add("FHelperInfo_ProdCode", "零件编码");
            FHelperDicColumn.Add("FHelperInfo_FSup", "外协厂家");
            FHelperDicColumn.Add("FHelperInfo_Price", "价格");
            FHelperDicColumn.Add("FHelperInfo_Owner", "编制人");
            FHelperDicColumn.Add("FHelperInfo_Date", "编制时间");
            FHelperOutingHandler.BindData(CurFHelperOutingDataSource, FHelperDicColumn);
        }

        public void uGridOutingBind()
        {
            CurFHelperOutingDataSource = infoInstance.GetFHelperOutingList();
            FHelperOutingHandler.BindData(CurFHelperOutingDataSource, FHelperDicColumn);

            AdjustPlanNodeGridColumn();
        }

        public void AdjustPlanNodeGridColumn()
        {
            FHelperOutingHandler.AdjustGridColumn(FHelperDicColumn);
        }

        public void RefreshOutingInfo()
        {
            CurFHelperOutingDataSource = infoInstance.GetFHelperOutingList();
            FHelperOutingHandler.BindData(CurFHelperOutingDataSource, FHelperDicColumn);

            AdjustPlanNodeGridColumn();
        }


        #endregion

    }
}
