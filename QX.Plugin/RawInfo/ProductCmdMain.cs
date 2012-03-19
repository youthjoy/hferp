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
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;

namespace QX.Plugin.RawInfo
{
    public partial class ProductCmdMain : F_BasciForm
    {
        private BLL.Bll_Prod_Command instance = new QX.BLL.Bll_Prod_Command();
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }

        public ProductCmdMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductMain_Load);
            BindTopTool();
        }

        void ProductMain_Load(object sender, EventArgs e)
        {
            //InitGrid(null, gvMain_0, string.Empty);
            InitGrid();
        }

        #region 绑定工具栏及事件
        public void BindTopTool()
        {
            top_tool_0.AddClicked += new EventHandler(top_tool_0_AddClicked);
            top_tool_0.EditClicked += new EventHandler(top_tool_0_EditClicked);
            top_tool_0.DelClicked += new EventHandler(top_tool_0_DelClicked);
            top_tool_0.RefreshClicked += new EventHandler(top_tool_0_RefreshClicked);
        }

        void top_tool_0_RefreshClicked(object sender, EventArgs e)
        {
            //InitGrid(null, gvMain_0,string.Empty);
        }

        void top_tool_0_DelClicked(object sender, EventArgs e)
        {
            //if (gvMain_0.ActiveRow != null)
            //{
            //    if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
            //    {
            //        string Code = gvMain_0.ActiveRow.Cells["Cmd_Code"].Value.ToString();
            //        bool result = instance.Delete(Code);
            //        if (result)
            //        {
            //            top_tool_0_RefreshClicked(this, EventArgs.Empty);
            //        }
            //    }
            //}
            //else
            //{
            //    Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            //}
        }

        void top_tool_0_EditClicked(object sender, EventArgs e)
        {
            //if (gvMain_0.ActiveRow!=null)
            //{
            //    string Cmd_Code = gvMain_0.ActiveRow.Cells["Cmd_Code"].Value.ToString();
            //    Prod_Command model = instance.GetModel(" AND Cmd_Code='"+Cmd_Code+"' ");
            //    ProductCmdAdmin frm = new ProductCmdAdmin(instance,model);
            //    frm.OperationType = OperationTypeEnum.OperationType.Edit;
            //    frm.ShowDialog();
            //}            
        }

        void top_tool_0_AddClicked(object sender, EventArgs e)
        {
            ProductCmdAdmin frm = new ProductCmdAdmin(instance, null);
            frm.OperationType = OperationTypeEnum.OperationType.Add;
            frm.ShowDialog();
        }
        #endregion

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void InitGrid()
        {
            List<Prod_Command> list = new List<Prod_Command>();
            list = instance.GetAll();
            GridHelper grid = new GridHelper();
            UltraGrid ug_list = grid.GenerateGrid(" QX.DataAceess", panel2, new Point(6, 20));
            ug_list.DataSource = list;
        }
    }
}
