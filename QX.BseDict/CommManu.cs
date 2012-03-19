using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.BLL;
using QX.DataModel;
using System.Reflection;
using System.Collections;
using QX.Common.C_Class;
using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;

namespace QX.BseDict
{
    public partial class CommManu : F_BasicPop
    {
        public CommManu()
        {
            InitializeComponent();
        }

        private void CommManu_Load(object sender, EventArgs e)
        {
            uGridManuInit();
        }


        public delegate void DCallBackHandler(bool result, FHelper_ManuList data);
        public event DCallBackHandler CallBack;

        #region 外协厂商列表

        private Bll_FHelper_ManuList mlInstance = new Bll_FHelper_ManuList();


        private List<QX.DataModel.FHelper_ManuList> CurFHelperManuDataSource = new List<QX.DataModel.FHelper_ManuList>();

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


        public void uGridManuInit()
        {
            FHelperHandler = new GridHandler(this.uGridManu);


            uGridManuInitColumn();

            uGridManuBind();

            uGridManuStyleInit();

            uGridEventInit();
        }

        private void uGridEventInit()
        {
            //this.uGridManu.BeforeEnterEditMode += new CancelEventHandler(uGridManu_BeforeEnterEditMode);
        }

        void uGridManu_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell aCell = this.uGridManu.ActiveCell;
            if (aCell != null)
            {

                if (aCell.Column.Key == "FP_ManuName" || aCell.Column.Key == "FP_ManuCode")
                {

                }
            }
        }

        private void uGridManuStyleInit()
        {
            FHelperHandler.SetDefaultStyle();
            FHelperHandler.SetExcelStyleFilter();
        }

        private void uGridManuInitColumn()
        {
            FHelperPriceDicColumn.Add("FM_ManuName", "厂家名称");
            FHelperPriceDicColumn.Add("FM_ManuCode", "厂家编码");

            FHelperPriceDicColumn.Add("FM_Telephone", "联系号码");
            FHelperPriceDicColumn.Add("FM_Contactr", "联系人");
            FHelperPriceDicColumn.Add("FM_Address", "地址");
            FHelperPriceDicColumn.Add("FM_Remark", "备注");
            FHelperHandler.BindData(CurFHelperManuDataSource, FHelperPriceDicColumn);
            //FHelperHandler.BindData<DataModel.FHelper_Price>(CurFHelperPriceDataSource,hideColumn, false);
        }

        public void uGridManuBind()
        {
            CurFHelperManuDataSource = this.mlInstance.GetManuList();

            FHelperHandler.BindData(CurFHelperManuDataSource, FHelperPriceDicColumn);

            AdjustPlaningTaskGridColumn();
        }

        public void AdjustPlaningTaskGridColumn()
        {

            FHelperHandler.AdjustGridColumn(FHelperPriceDicColumn);
        }





        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.uGridManu.ActiveRow;
            FHelper_ManuList manu = row.ListObject as FHelper_ManuList;
            if (CallBack != null)
            {
                CallBack(true, manu);
                this.Close();
            }
        }





    }
}
