using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;

namespace QX.Plugin.Contract
{
    public partial class ContractManage : F_BasciForm
    {
        private BLL.Bll_ContractManage ContractMange = new QX.BLL.Bll_ContractManage();
        private BLL.Bll_SD_Contract instance = new QX.BLL.Bll_SD_Contract();
        private BLL.Bll_SD_CDetail DetailInstance = new QX.BLL.Bll_SD_CDetail();
        private SD_Contract model = new SD_Contract();
        private List<SD_CDetail> DetailList = new List<SD_CDetail>();
        private DataTable dt;
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }

        #region 窗体单例
        public static ContractManage NewForm = null;
        public static ContractManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new ContractManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion
        public ContractManage()
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
            tool_top_EditClicked(this,EventArgs.Empty);
        }

        void tool_top_RefreshClicked(object sender, EventArgs e)
        {
            InitGrid("");
        }


        void tool_top_DelClicked(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow != null)
            {
                if (DialogResult.Yes == Alert.Show(MessageBoxButtons.YesNo, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string Code = ultraGrid1.ActiveRow.Cells["Contract_Code"].Value.ToString();
                    bool result = ContractMange.DeleteContract(Code);
                    if (result)
                    {
                        InitGrid("");
                        Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
                    }
                    else
                    {
                        Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
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
            string Contract_Code = string.Empty;
            if (ultraGrid1.ActiveRow!=null)
            {
                if (ultraGrid1.ActiveRow.Cells["Contract_Code"].Value!=null)
                {
                    Contract_Code = ultraGrid1.ActiveRow.Cells["Contract_Code"].Value.ToString();
                }
                model = instance.GetModel(" AND Contract_Code='"+Contract_Code+"'");
                DetailList = DetailInstance.GetList(" AND CDetail_ContractNo='" + Contract_Code + "' ");
            }

            ContractOP op = new ContractOP(model,DetailList);
            op.ContractInstance = instance;
            op.CdetailInstance = DetailInstance;
            op.OperationType = OperationTypeEnum.OperationType.Edit;
            op.ShowDialog();
            InitGrid("");
        }

        void tool_top_AddClicked(object sender, EventArgs e)
        {
            ContractOP op = new ContractOP(new SD_Contract(), new List<SD_CDetail>());
            op.ContractInstance = instance;
            op.CdetailInstance = DetailInstance;
            op.OperationType = OperationTypeEnum.OperationType.Add;
            op.CallBack += new ContractOP.DDataChangeHandler(op_CallBack);
            op.ShowDialog();
            InitGrid("");
        }

        void op_CallBack(object sender, EventArgs e)
        {
            InitGrid("");
        }

        private void ContractManage_Load(object sender, EventArgs e)
        {
            InitGrid("");
        }

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void InitGrid(string filter)
        {
            MetaReflection<SD_Contract> reflection = new MetaReflection<SD_Contract>();
            Dictionary<string, string> dic = reflection.GetMeta();            
            List<SD_Contract> list = instance.GetAll();
            dt = ConvertX.ToDataTable<SD_Contract>(list);
            gHandler = new GridHandler(this.ultraGrid1);           
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
