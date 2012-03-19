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
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;


namespace QX.Plugin.Prod
{
    public partial class LastCheckMain :F_BasciForm
    {
        public LastCheckMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductMain_Load);
            BindTopTool();
        }


        #region 窗体单例

        public static LastCheckMain NewForm = null;



        public static LastCheckMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new LastCheckMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private BLL.Bll_Inv_Information instance = new QX.BLL.Bll_Inv_Information();
        UltraGrid ug_listA = new UltraGrid();
        UltraGrid ug_listB = new UltraGrid();

        void ProductMain_Load(object sender, EventArgs e)
        {
            GridHelper grid = new GridHelper();
            ug_listA = grid.GenerateGrid("GLastTest", panel2, new Point(6, 20));
            grid.SetGridColumnStyle(ug_listA, AutoFitStyle.ExtendLastColumn);
            grid.SetGridReadOnly(ug_listA, true);

            //ug_listB = grid.GenerateGrid("CList_ProdCommand", panel4, new Point(6, 20));
            //grid.SetGridReadOnly(ug_listB, true);

            LoadGrid1();
            //LoadGrid2();
        }

        #region 绑定工具栏及事件
        public void BindTopTool()
        {
            //top_tool_0.AddClicked += new EventHandler(top_tool_0_AddClicked);
            //top_tool_0.EditClicked += new EventHandler(top_tool_0_EditClicked);
            top_tool_0.QueryClicked += new EventHandler(top_tool_0_QueryClicked);
            //top_tool_0.DelClicked += new EventHandler(top_tool_0_DelClicked);
            top_tool_0.RefreshClicked += new EventHandler(top_tool_0_RefreshClicked);

            //top_tool_1.QueryClicked += new EventHandler(top_tool_1_QueryClicked);

            //搜索按钮
            ToolStripButton ConfirmBtn = new ToolStripHelper().New("终检确认", QX.Common.Properties.Resources.OK, new EventHandler(ConfirmBtn_Click));
            this.top_tool_0.AddCustomControl(6, ConfirmBtn);
            //ConfirmBtn.Click += new EventHandler(ConfirmBtn_Click);
        }

        void ConfirmBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listA.ActiveRow;
            if (row != null)
            {
                Inv_Information item = row.ListObject as Inv_Information;
                TestRefList TestFrm = new TestRefList(item.IInfor_ProdCode,OperationTypeEnum.OperationType.Edit);
                TestFrm.ShowDialog();
                LoadGrid1();
            }
        }

        void top_tool_1_QueryClicked(object sender, EventArgs e)
        {
            //Sys_PD_Module gridModule = this.panel4.Tag as Sys_PD_Module;
            //if (ug_listB.ActiveRow != null)
            //{
            //    string Cmd_Code = ug_listB.ActiveRow.Cells["Cmd_Code"].Value.ToString();
            //    Prod_Command model = instance.GetModel(" AND Cmd_Code='" + Cmd_Code + "' ");
            //    ProductCmdAdmin frm = new ProductCmdAdmin(instance, model);
            //    frm.OperationType = OperationTypeEnum.OperationType.Look;
            //    frm.ShowDialog();
            //}
        }

        void top_tool_0_RefreshClicked(object sender, EventArgs e)
        {
            LoadGrid1();
        }

        void top_tool_0_DelClicked(object sender, EventArgs e)
        {
            //Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

            //UltraGrid ug_list = panel2.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            //if (ug_list.ActiveRow != null)
            //{
            //    if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
            //    {
            //        string Code = ug_list.ActiveRow.Cells["Cmd_Code"].Value.ToString();
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
            //Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

            //UltraGrid ug_list = panel2.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            //if (ug_list.ActiveRow != null)
            //{
            //    string Cmd_Code = ug_list.ActiveRow.Cells["Cmd_Code"].Value.ToString();
            //    Prod_Command model = instance.GetModel(" AND Cmd_Code='" + Cmd_Code + "' ");
            //    ProductCmdAdmin frm = new ProductCmdAdmin(instance, model);
            //    frm.OperationType = OperationTypeEnum.OperationType.Edit;
            //    frm.ShowDialog();
            //}            
        }
        void top_tool_0_QueryClicked(object sender, EventArgs e)
        {

            UltraGridRow row = this.ug_listA.ActiveRow;
            if (row != null)
            {
                Inv_Information item = row.ListObject as Inv_Information;
                TestRefList TestFrm = new TestRefList(item.IInfor_ProdCode,OperationTypeEnum.OperationType.Look);
                TestFrm.ShowDialog();
            }
        }
        void top_tool_0_AddClicked(object sender, EventArgs e)
        {
            //ProductCmdAdmin frm = new ProductCmdAdmin(instance, null);
            //frm.OperationType = OperationTypeEnum.OperationType.Add;
            //frm.ShowDialog();
        }
        #endregion

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void LoadGrid2()
        {
            //List<Inv_Information> list = new List<Inv_Information>();
            //list = instance.GetLastCheckInvInfoList();
            //List<Prod_Command> list = new List<Prod_Command>();
            //list = instance.GetAll();
            //ug_listB.DataSource = list;
        }

        private void LoadGrid1()
        {
            List<Inv_Information> list = new List<Inv_Information>();
            list = instance.GetLastCheckInvInfoList();
            //List<Prod_Command> list = new List<Prod_Command>();
            //list = instance.GetAll();
            ug_listA.DataSource = list;
        }

    }
}
