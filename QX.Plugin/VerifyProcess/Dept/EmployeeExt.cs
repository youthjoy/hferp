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
using QX.BLL;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;

namespace QX.Plugin.DeptManage
{
    public partial class EmployeeExt : Form
    {
        private BLL.Bll_Bse_Employee MainInstance = new Bll_Bse_Employee();

        private Bse_Employee GModel = new Bse_Employee();

        private Bse_EmployeeExt BseExt
        {
            get;
            set;
        }

        private GridHelper gridHelper = new GridHelper();
        BindModelHelper bmHelper = new BindModelHelper();
        FormHelper formHelper = new FormHelper();

        List<Bse_EmployeeExt> ExtSource
        {
            get;
            set;
        }

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }
        FormHelper fHelper = new FormHelper();
        public EmployeeExt(Bse_Employee emp)
        {
            InitializeComponent();

            GModel = emp;
 
            this.top_tool_0.SaveClicked += new EventHandler(top_tool_0_SaveClicked);
            fHelper.PermissionControl(top_tool_0.toolStrip1.Items, PermissionModuleEnum.EmployeeExt.ToString());
            this.Load += new EventHandler(EmployeeExt_Load);
        }

        void top_tool_0_SaveClicked(object sender, EventArgs e)
        {
            SaveData();
            Alert.Show("数据更新完成!");
            this.Close();
        }

        List<Sys_Map> MapSource
        {
            get;
            set;
        }

        void EmployeeExt_Load(object sender, EventArgs e)
        {
            Bll_Sys_Map mapInst = new Bll_Sys_Map();
            MapSource = mapInst.GetListByCode(string.Format(" AND Map_Module='{0}' and Map_Source='{0}'","EmployeeExt"));

            ExtSource=MainInstance.GetEmployeeExtend(GModel.Emp_Code);

            LoadTab();
        }

        private void LoadTab()
        {
            formHelper.GenerateForm("CList_ExBse",this.tabPage1,new Point(6,20));
            BseExt=ExtSource.FirstOrDefault(o=>o.EmpE_Module=="bse");
            if(BseExt==null)
            {
                BseExt=new Bse_EmployeeExt();
            }


            bmHelper.BindModelToControl<Bse_EmployeeExt>(BseExt,this.tabPage1.Controls,"");

            foreach (var d in MapSource)
            {
                TabPage tp = new TabPage();
                tp.Name = "tp" + d.Map_Object1;
                tp.Tag = d;
                tp.Text = d.Map_Object2;
                this.tabBse.TabPages.Add(tp);

                Panel panel = new Panel();

                panel.Location = new Point(0, 40);
                panel.Width = 850;
                panel.Height = 370;
                panel.Dock = DockStyle.Fill;
                tp.Controls.Add(panel);
                UltraGrid uGrid = new UltraGrid();
                uGrid = gridHelper.GenerateGrid("CList_Ex" + d.Map_Object1, panel, new Point(6, 20));
                uGrid.Name = "uGrid" + d.Map_Object1;
                gridHelper.SetGridColumnStyle(uGrid, AutoFitStyle.ResizeAllColumns);
                LoadPriceGridData(uGrid, d.Map_Object1);

            }
        }

        private void LoadPriceGridData(UltraGrid grid, string key)
        {
            var list = ExtSource.Where(o => o.EmpE_Module == key);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list.ToList();
            grid.DataSource = dataSource;
        }


        public void SaveData()
        {

            bmHelper.BindControlToModel<Bse_EmployeeExt>(BseExt, this.tabPage1.Controls, "");
            if (BseExt.EmpE_ID == 0)
            {
                BseExt.EmpE_Module = "bse";
                BseExt.EmpE_EmpCode = GModel.Emp_Code;
                MainInstance.AddExt(BseExt);
            }
            else
            {
                BseExt.EmpE_Module = "bse";
                BseExt.EmpE_EmpCode = GModel.Emp_Code;
                MainInstance.UpdateExt(BseExt);
            }

            List<Bse_EmployeeExt> list = new List<Bse_EmployeeExt>();
            foreach (var d in MapSource)
            {
                UltraGrid grid = null;
                grid = (UltraGrid)tabBse.Controls.Find("uGrid" + d.Map_Object1, true)[0];
                var dd = ((BindingSource)grid.DataSource).DataSource as List<Bse_EmployeeExt>;
                foreach (var p in dd)
                {
                    p.EmpE_Module = d.Map_Object1;
                    p.EmpE_EmpCode = GModel.Emp_Code;
                    list.Add(p);
                }

            }

            this.MainInstance.UpdateEmployeeExtList(GModel, list);


        }
    }
}
