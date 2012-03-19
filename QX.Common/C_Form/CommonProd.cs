using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;

namespace QX.Common.C_Form
{
    public partial class CommonProd : Form
    {
        public CommonProd()
        {
            InitializeComponent();
        }

        public CommonProd(Size size)
        {
            InitializeComponent();
            this.Size = size;
        }


        private void CommonProd_Load(object sender, EventArgs e)
        {

        }


        public delegate void DCallBackHandler(object sender, List<string> data);
        public event DCallBackHandler CallBack;

        //private List<T> _dtData;
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


        //public CommProd(Size size)
        //{
        //    InitializeComponent();
        //    this.Size = size;
        //}


        public void Init<T>(List<T> dataSource)
        {

            gHandler = new GridHandler(this.uGridProd);
            //_dtData = dataSource;
            //初始化
            this.btnConfirm.Click += new EventHandler(btnOK_Click);
            DicColumn.Add("IInfor_ProdCode", "零件编号");
            DicColumn.Add("IInfor_PartNo", "零件图号");
            DicColumn.Add("IInfor_PartName", "零件名称");
            DicColumn.Add("IInfor_PlanBegin", "计划开工时间");
            DicColumn.Add("IInfor_PlanEnd", "计划完工时间");
            DicColumn.Add("IInfor_InTime", "实际完工时间");
            gHandler.BindData(dataSource, DicColumn);

            gHandler.SetDefaultStyle();

            this.uGridProd.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(uGridProd_DoubleClickRow);

            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        void uGridProd_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            UltraGridRow row = this.uGridProd.ActiveRow;

            if (row != null)
            {
                //string filter = "Dict_Code='" + tvMain.SelectedNode.Tag.ToString() + "'";
                //DataTable tmpDt = new DataTable();
                //tmpDt = _dtData.Clone();
                //DataRow[] list = _dtData.Select(filter);
                //for (int i = 0; i < list.Length; i++)
                //{
                //    tmpDt.ImportRow((DataRow)list[i]);
                //}
                string prodCode = row.Cells["IInfor_ProdCode"].Value.ToString();
                string partName = row.Cells["IInfor_PartName"].Value.ToString();
                List<string> dic = new List<string>();
                dic.Add(prodCode);

                if (CallBack != null)
                {
                    CallBack(null, dic);
                }
                this.Close();
            }
        }




        //void btnFresh_Click(object sender, EventArgs e)
        //{
        //    this.Refresh();
        //}

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {

            UltraGridRow row = this.uGridProd.ActiveRow;

            if (row != null)
            {
                //string filter = "Dict_Code='" + tvMain.SelectedNode.Tag.ToString() + "'";
                //DataTable tmpDt = new DataTable();
                //tmpDt = _dtData.Clone();
                //DataRow[] list = _dtData.Select(filter);
                //for (int i = 0; i < list.Length; i++)
                //{
                //    tmpDt.ImportRow((DataRow)list[i]);
                //}
                string prodCode = row.Cells["IInfor_ProdCode"].Value.ToString();
                string partName = row.Cells["IInfor_PartName"].Value.ToString();
                List<string> dic = new List<string>();
                dic.Add(prodCode);

                if (CallBack != null)
                {
                    CallBack(null, dic);
                }
                this.Close();
            }
        }
    }
}
