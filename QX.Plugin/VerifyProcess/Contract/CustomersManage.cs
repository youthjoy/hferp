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
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;

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

        private UltraGrid ultraGrid1 = new UltraGrid();

        private FormHelper fHelper = new FormHelper();

        public CustomersManage()
        {
            InitializeComponent();
            tool_top.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            tool_top.QueryClicked += new EventHandler(tool_top_QueryClicked);
            ultraGrid1.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);



        }

        void tool_top_QueryClicked(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow == null)
            {
                Alert.Show("请选择需要编辑的数据");
                return;
            }
            string Code = ultraGrid1.ActiveRow.Cells["Cust_Code"].Value.ToString();
            SD_Customer model = instance.GetModel(" AND Cust_Code='" + Code + "'");
            Customer customer = new Customer(DataType, instance, model);
            customer.OperationType = OperationTypeEnum.OperationType.Look;
            customer.FormClosed += new FormClosedEventHandler(customer_FormClosed);
            customer.ShowDialog();
        }

        public CustomersManage(string type)
        {
            InitializeComponent();
            DataType = type;
            BindTopTool(type);



            

            fHelper.PermissionControl(this.tool_top.toolStrip1.Items, type);
        }

        private void BindTopTool(string type)
        {
            tool_top.AddClicked += new EventHandler(tool_top_AddClicked);
            tool_top.EditClicked += new EventHandler(tool_top_EditClicked);
            tool_top.DelClicked += new EventHandler(tool_top_DelClicked);
            tool_top.RefreshClicked += new EventHandler(tool_top_RefreshClicked);
            ultraGrid1.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);

            if (type == "GCustomer")
            {
                ToolStripHelper tsHelper = new ToolStripHelper();
                ToolStripButton btnAddSup = tsHelper.New("生成供应商", QX.Common.Properties.Resources.copy, new EventHandler(btnAddSup_Click));
                tool_top.AddCustomControl(btnAddSup);
            }
        }

        void btnAddSup_Click(object sender, EventArgs e)
        {

            if (ultraGrid1.ActiveRow == null)
            {
                Alert.Show("请选择需要编辑的数据");
                return;
            }
            string Code = ultraGrid1.ActiveRow.Cells["Cust_Code"].Value.ToString();
            SD_Customer model = instance.GetModel(" AND Cust_Code='" + Code + "'");
            CustToSupOp ToSupFrm = new CustToSupOp("GSup", new Bll_SD_Customer(), model);
            ToSupFrm.OperationType = OperationTypeEnum.OperationType.Edit;
            //ToSupFrm.FormClosed += new FormClosedEventHandler(customer_FormClosed);
            ToSupFrm.ShowDialog();
            
        }

        private string DataType
        {
            get;
            set;
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
            //InitGrid("");
            RefreshCustGrid("");
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
            if (ultraGrid1.ActiveRow == null)
            {
                Alert.Show("请选择需要编辑的数据");
                return;
            }
            string Code = ultraGrid1.ActiveRow.Cells["Cust_Code"].Value.ToString();
            SD_Customer model = instance.GetModel(" AND Cust_Code='" + Code + "'");
            Customer customer = new Customer(DataType,instance, model);
            customer.OperationType = OperationTypeEnum.OperationType.Edit;
            customer.FormClosed += new FormClosedEventHandler(customer_FormClosed);
            customer.ShowDialog();
        }

        void customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //InitGrid("");
            RefreshCustGrid("");
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            Customer customer = new Customer(DataType,instance, null);
            customer.OperationType = OperationTypeEnum.OperationType.Add;
            customer.FormClosed += new FormClosedEventHandler(customer_FormClosed);
            customer.ShowDialog();
        }

        private void InitGrid(string filter)
        {
            GridHelper gen = new GridHelper();
            List<SD_Customer> list = instance.GetCustomerByType(DataType);

            this.ultraGrid1 = gen.GenerateGrid(DataType, this.panel2, new Point(0, 0));

            ultraGrid1.DataSource = list;
            gHandler = new GridHandler(this.ultraGrid1);
            gHandler.SetGridEditMode(false, this.ultraGrid1);
        }

        public void RefreshCustGrid(string filter)
        {
            List<SD_Customer> list = instance.GetCustomerByType(DataType);
            ultraGrid1.DataSource = list;
        }


    }
}
