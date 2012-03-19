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
using System.Linq;
using QX.Plugin.Prod.Report;

namespace QX.Plugin.Cmd
{
    public partial class ProductCmdMain : F_BasciForm
    {
        private BLL.Bll_Prod_Command instance = new QX.BLL.Bll_Prod_Command();
        UltraGrid ug_listA = new UltraGrid();
        UltraGrid ug_listB = new UltraGrid();
        public ProductCmdMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductMain_Load);
            BindTopTool();
        }



        void ProductMain_Load(object sender, EventArgs e)
        {
            GridHelper grid = new GridHelper();
            ug_listA = grid.GenerateGrid("CList_ProdCommand", panel2, new Point(6, 20));
            ug_listA.InitializeRow += new InitializeRowEventHandler(ug_listA_InitializeRow);
            grid.SetGridReadOnly(ug_listA, true);

            LoadGrid1();

        }

        void ug_listA_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Prod_Command pc = e.Row.ListObject as Prod_Command;
            var Cmd_AllCount = pc.Cmd_AllCount;
            var Cmd_Udef3=Common.C_Class.Utils.TypeConverter.ObjectToInt(pc.Cmd_Udef3);

            if (Cmd_AllCount > Cmd_Udef3)
            {
                e.Row.Appearance.BackColor = Color.Yellow;
            }
            //if(pc.
        }

        #region 绑定工具栏及事件

        ToolStripTextBox txtKey = new ToolStripTextBox();

        FormHelper fHelper = new FormHelper();

        public void BindTopTool()
        {
            top_tool_0.AddClicked += new EventHandler(top_tool_0_AddClicked);
            top_tool_0.EditClicked += new EventHandler(top_tool_0_EditClicked);
            top_tool_0.QueryClicked += new EventHandler(top_tool_0_QueryClicked);
            top_tool_0.DelClicked += new EventHandler(top_tool_0_DelClicked);
            top_tool_0.RefreshClicked += new EventHandler(top_tool_0_RefreshClicked);
            top_tool_0.PrintClicked += new EventHandler(top_tool_0_PrintClicked);
            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.top_tool_0.AddCustomControl(4, tLabel3);

            this.top_tool_0.AddCustomControl(5, txtKey);

            ToolStripHelper tsHelper = new ToolStripHelper();

            //搜索按钮
            ToolStripButton searchPlanedBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchPlanedBtn_Click));

            this.top_tool_0.AddCustomControl(6, searchPlanedBtn);


            ToolStripButton prodBtn = tsHelper.New("购成品过滤", QX.Common.Properties.Resources.parts, new EventHandler(prodBtn_Click));

            this.top_tool_0.AddCustomControl(7, prodBtn);

            ToolStripButton updateCmdBtn = tsHelper.New("购成品维护", QX.Common.Properties.Resources.OK, new EventHandler(updateCmdBtn_Click));

            this.top_tool_0.AddCustomControl(8, updateCmdBtn);

            fHelper.PermissionControl(this.top_tool_0.toolStrip1.Items, PermissionModuleEnum.ProdCmd.ToString());

        }

        void top_tool_0_PrintClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listA.ActiveRow;
            if (row != null)
            {
                Prod_Command cmd = row.ListObject as Prod_Command;

                RptTicketCmd cmdMain = new RptTicketCmd(cmd.Cmd_Code);
                cmdMain.ShowDialog();
            }
        }

        void updateCmdBtn_Click(object sender, EventArgs e)
        {
            Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

            UltraGrid ug_list = panel2.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            if (ug_list.ActiveRow != null)
            {
                string Cmd_Code = ug_list.ActiveRow.Cells["Cmd_Code"].Value.ToString();
                Prod_Command model = instance.GetModel(" AND Cmd_Code='" + Cmd_Code + "' ");
                ProductCmdAdmin frm = new ProductCmdAdmin(instance, model);
                frm.OperationType = OperationTypeEnum.OperationType.View;
                frm.ShowDialog();
                LoadGrid1();
            }
        }

        void prodBtn_Click(object sender, EventArgs e)
        {

            RefreshProdGrid();
        }

        void searchPlanedBtn_Click(object sender, EventArgs e)
        {
            string key = this.txtKey.Text;
            if (string.IsNullOrEmpty(key))
            {
                RefreshGrid("");
            }
            else
            {
                RefreshGrid(key);
            }
        }

        /// <summary>
        /// 一下发指令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void top_tool_1_RefreshClicked(object sender, EventArgs e)
        {
            LoadGrid2();
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
            Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

            UltraGrid ug_list = panel2.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            if (ug_list.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    Prod_Command pc = ug_list.ActiveRow.ListObject as Prod_Command;
                    string Code = pc.Cmd_Code;
                    ///是否已存在毛坯入库
                    if (!string.IsNullOrEmpty(pc.Cmd_Udef3))
                    {
                        Alert.Show("当前指令已进入生产流程,不能进行删除!");
                        return;
                    }

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ProdCmd
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdCmd.ToString(), QX.Common.LogType.Delete.ToString());


                    bool result = instance.Delete(Code);
                    if (result)
                    {
                        top_tool_0_RefreshClicked(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            }
        }

        void top_tool_0_EditClicked(object sender, EventArgs e)
        {
            Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

            UltraGrid ug_list = panel2.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;
            int index = 0;
            if (ug_list.ActiveRow != null)
            {
                index = ug_list.ActiveRow.Index;
                string Cmd_Code = ug_list.ActiveRow.Cells["Cmd_Code"].Value.ToString();
                Prod_Command model = instance.GetModel(" AND Cmd_Code='" + Cmd_Code + "' ");
                ProductCmdAdmin frm = new ProductCmdAdmin(instance, model);
                
                frm.OperationType = OperationTypeEnum.OperationType.Edit;
                frm.ShowDialog();
                LoadGrid1();

                ug_list.Rows[index].Activate();
            }
        }
        void top_tool_0_QueryClicked(object sender, EventArgs e)
        {
            Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;
            if (ug_listA.ActiveRow != null)
            {
                string Cmd_Code = ug_listA.ActiveRow.Cells["Cmd_Code"].Value.ToString();
                Prod_Command model = instance.GetModel(" AND Cmd_Code='" + Cmd_Code + "' ");
                ProductCmdAdmin frm = new ProductCmdAdmin(instance, model);
                frm.OperationType = OperationTypeEnum.OperationType.Look;
                frm.ShowDialog();
            }
        }
        void top_tool_0_AddClicked(object sender, EventArgs e)
        {
            ProductCmdAdmin frm = new ProductCmdAdmin(instance, null);
            frm.OperationType = OperationTypeEnum.OperationType.Add;
            frm.ShowDialog();
            LoadGrid1();
        }
        #endregion

        /// <summary>
        /// 已下发
        /// </summary>
        /// <param name="filter"></param>
        private void LoadGrid2()
        {
            //GridHelper grid = new GridHelper();
            //List<Prod_Command> list = new List<Prod_Command>();
            //list = instance.GetAll();
            //ug_listB.DataSource = list;
        }

        /// <summary>
        /// 生产指令
        /// </summary>
        private void LoadGrid1()
        {
            List<Prod_Command> list = new List<Prod_Command>();
            list = instance.GetAll();
            ug_listA.DataSource = list;
        }

        public void RefreshGrid(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                List<Prod_Command> list = new List<Prod_Command>();
                list = instance.GetAll();
                
                ug_listA.DataSource = list;
            }
            else
            {
                List<Prod_Command> list = new List<Prod_Command>();
                list = instance.GetListByWhere(filter);
                ug_listA.DataSource = list;
            }

        }


        public void RefreshProdGrid()
        {

            List<Prod_Command> list = new List<Prod_Command>();
            list = instance.GetProdCmd();
            ug_listA.DataSource = list;

            foreach (var row in ug_listA.Rows)
            {
                Prod_Command cmd = row.ListObject as Prod_Command;
                if (string.IsNullOrEmpty(cmd.Cmd_Udef3))
                {
                    row.Appearance.BackColor = Color.Red;
                }
                else if (cmd.Cmd_AllCount > Common.C_Class.Utils.TypeConverter.ObjectToInt(cmd.Cmd_Udef3))
                {
                    row.Appearance.BackColor = Color.Wheat;
                }
                
            }

        }
    }
}
