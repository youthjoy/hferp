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
using QX.Common.C_Class;

namespace QX.Plugin.Contract
{
    public partial class CustomersManage : F_BasciForm
    {
        private Bll_SD_Customer instance = new Bll_SD_Customer();
        private SD_Customer model = new SD_Customer();
        private DataTable dt;
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }

        #region 窗体单例
        public static CustomersManage NewForm = null;
        public static CustomersManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new CustomersManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion

        public CustomersManage()
        {
            InitializeComponent();
            tool_top.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            ultraGrid1.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);
        }

        void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            tool_top_EditClicked(this, EventArgs.Empty);
        }

        private void CustomersManage_Load(object sender, EventArgs e)
        {
            InitGrid("");            
        }

        void tool_top_RefreshClicked(object sender, EventArgs e)
        {
            InitGrid(""); 
        }

        void tool_top_DelClicked(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string Code = ultraGrid1.ActiveRow.Cells["Cust_Code"].Value.ToString();
                    bool result = instance.Delete(Code);
                    if (result)
                    {
                        tool_top_RefreshClicked(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            }
        }

        void tool_top_EditClicked(object sender, EventArgs e)
        {
            string Code = ultraGrid1.ActiveRow.Cells["Cust_Code"].Value.ToString();
            SD_Customer model = instance.GetModel(" AND Cust_Code='" + Code + "'");
            Customer customer = new Customer(instance,model);
            customer.OperationType = OperationTypeEnum.OperationType.Edit;
            customer.ShowDialog();
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            Customer customer = new Customer(instance,null);
            customer.OperationType = OperationTypeEnum.OperationType.Add;
            customer.ShowDialog();
        }

        private void InitGrid(string filter)
        {
            List<SD_Customer> list = instance.GetAll();
            dt = ConvertX.ToDataTable<SD_Customer>(list);
            gHandler = new GridHandler(this.ultraGrid1);
            MetaReflection<SD_Customer> meta = new MetaReflection<SD_Customer>();
            Dictionary<String, String> dic = meta.GetMeta();                   
            if (!String.IsNullOrEmpty(filter))
            {
                DataTable tmp = FilterDataTable(filter);
                gHandler.BindData(tmp, dic, false);
            }
            else
            {
                gHandler.BindData(dt, dic, false);
            }
            gHandler.SetDefaultStyle();
            //gHandler.SetAlternateRowStyle();
            gHandler.SetExcelStyleFilter();
        }

        /// <summary>
        /// 筛选
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private DataTable FilterDataTable(string filter)
        {
            DataTable tmpDT = new DataTable();
            tmpDT = dt.Clone();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow[] rows = dt.Select(filter);
                for (int i = 0; i < rows.Length; i++)
                {
                    tmpDT.ImportRow(rows[i]);
                }
            }

            return tmpDT;
        }
    }
}
