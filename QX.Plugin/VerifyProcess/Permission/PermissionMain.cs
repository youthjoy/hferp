using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using QX.BLL;
using QX.Framework.AutoForm;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.DataModel;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.BaseModule.Permission
{
    public partial class PermissionMain : F_BasicPop
    {
        public PermissionMain(Bse_Employee emp)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(emp.Emp_LoginID))
            {
                UserCode = emp.Emp_Code;
                UserName = emp.Emp_Name;
                //emp.Emp_LoginID = UserName;
                emp.Emp_LoginID = UserName;
                emp.Emp_LoginPwd = "1";
                emp.Emp_CanLogin = "Yes";
            }
            else
            {
                UserName = emp.Emp_LoginID;
            }
            Employee = emp;
            EventInit();
        }

        private Bse_Employee Employee
        {
            get;
            set;
        }

        public string UserCode
        {
            get;
            set;
        }

        private Bll_Bse_Employee empInstance = new Bll_Bse_Employee();

        private void PermissionMain_Load(object sender, EventArgs e)
        {
            InitData();
        }

        #region 窗体单例

        //public static PermissionMain NewForm = null;
        //public static PermissionMain Instance()
        //{
        //    if (NewForm == null || NewForm.IsDisposed == true)
        //    {
        //        NewForm = new PermissionMain();
        //    }
        //    else
        //    {
        //        NewForm.Activate();
        //    }
        //    return NewForm;
        //}
        #endregion


        public void EventInit()
        {
            ToolStripButton pSaveBtn = new QX.Common.C_Class.ToolStripHelper().New("保存"
    , QX.Common.Properties.Resources.save
    , new EventHandler(pSaveBtn_Click));

            this.tbGrid.AddCustomControl(pSaveBtn);

        }

        void pSaveBtn_Click(object sender, EventArgs e)
        {
            SaveData();

            Alert.Show("数据更新完成");

            this.Close();
        }

        private void SaveData()
        {
            try
            {
                bmHelper.BindControlToModel<Bse_Employee>(Employee, this.gpSys.Controls, "");

                var re = empInstance.UpdateEmployee(Employee);

                List<Sys_UserPermission> list = new List<Sys_UserPermission>();

                foreach (UltraGridRow row in comGrid.Rows)
                {
                    if (row.Cells["IsCheck"] != null && row.Cells["IsCheck"].Value.ToString() == "True")
                    {

                        Sys_UserPermission item = row.ListObject as Sys_UserPermission;
                        item.PU_UserCode = UserCode;
                        item.PU_UserName = UserName;

                        list.Add(item);
                    }
                }


                foreach (UltraGridRow row in this.funGrid.Rows)
                {
                    if (row.Cells["IsCheck"] != null && row.Cells["IsCheck"].Value.ToString() == "True")
                    {

                        Sys_UserPermission item = row.ListObject as Sys_UserPermission;

                        item.PU_UserName = UserName;

                        list.Add(item);
                    }
                }

                pcInstance.AddOrUpdatePermission(UserName, list);
            }
            catch (Exception e)
            {

            }
        }

        private string UserName
        {
            get;
            set;
        }

        private BindModelHelper bmHelper = new BindModelHelper();

        private void InitData()
        {
            FormHelper gen = new FormHelper();

            gen.GenerateForm("FLogin", this.gpSys, new Point(6, 20));

            bmHelper.BindModelToControl<Bse_Employee>(Employee, this.gpSys.Controls, "");

            var ctl = bmHelper.FindCtl<UltraTextEditor>(this.gpSys.Controls, "Emp_LoginPwd");
            if (ctl != null)
            {
                ctl.PasswordChar = '*';
            }


            GridInit();
        }

        private Bll_UserPermission pcInstance = new Bll_UserPermission();

        UltraGrid comGrid = new UltraGrid();


        UltraGrid funGrid = new UltraGrid();

        List<Sys_UserPermission> userList = new List<Sys_UserPermission>();
        


        private void GridInit()
        {


            //ControlGen.ContrlGenerate gen = new BC.ControlGen.ContrlGenerate();
            GridHelper gen = new GridHelper();

            #region 菜单权限
            List<Sys_Function> temp = pcInstance.GetAllFunctionList("1");

            List<Sys_UserPermission> list = (from p in temp select new Sys_UserPermission { PU_FunCode = p.Fun_Code, PU_FunName = p.Fun_Name, PU_FunPCode = p.Fun_PCode }).ToList();

            comGrid = gen.GenerateGrid("GPermission", this.pnlPerm, new Point(6, 20));

            comGrid.InitializeRow += new InitializeRowEventHandler(comGrid_InitializeRow);
            comGrid.CellChange += new CellEventHandler(comGrid_CellChange);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;

            comGrid.DataSource = dataSource;

            //列宽度自适应
            comGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;

            comGrid.DisplayLayout.Bands[0].Columns.Add("IsCheck", "操作");
            UltraGridColumn col = comGrid.DisplayLayout.Bands[0].Columns["IsCheck"];

            col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            //col.NullText = "0";
            col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col.DataType = typeof(bool);
            col.DefaultCellValue = false;
            col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
            col.AllowRowFiltering = DefaultableBoolean.False;

            col.Header.VisiblePosition = 0;
            col.CellClickAction = CellClickAction.EditAndSelectText;

            userList = pcInstance.GetUserPermissionList(UserName);

            InitUserPermission(userList);

            SetGridEditMode(false, comGrid);


            #endregion

            #region 功能权限


            List<Sys_Function> temp1 = pcInstance.GetAllFunctionList("2");

            List<Sys_UserPermission> list1 = (from p in temp1 select new Sys_UserPermission { PU_FunCode = p.Fun_Code, PU_FunName = p.Fun_Name, PU_FunPCode = p.Fun_PCode }).ToList();

            funGrid = gen.GenerateGrid("GPermission", this.panel1, new Point(6, 20));
            funGrid.InitializeRow += new InitializeRowEventHandler(funGrid_InitializeRow);
            //funGrid.InitializeRow += new InitializeRowEventHandler(comGrid_InitializeRow);
            //funGrid.CellChange += new CellEventHandler(comGrid_CellChange);
            funGrid.CellChange += new CellEventHandler(funGrid_CellChange);
            BindingSource dataSource1 = new BindingSource();

            dataSource1.DataSource = list1;

            funGrid.DataSource = dataSource1;

            //列宽度自适应
            funGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;

            funGrid.DisplayLayout.Bands[0].Columns.Add("IsCheck", "操作");

            UltraGridColumn col1 = funGrid.DisplayLayout.Bands[0].Columns["IsCheck"];

            col1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            //col.NullText = "0";
            col1.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col1.DataType = typeof(bool);
            col1.DefaultCellValue = false;
            col1.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col1.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
            col1.AllowRowFiltering = DefaultableBoolean.False;

            col1.Header.VisiblePosition = 0;
            col1.CellClickAction = CellClickAction.EditAndSelectText;

            //userList = pcInstance.GetUserPermissionList(UserName);

            InitFunPermission(userList);

            SetGridEditMode(false, funGrid);


            #endregion
        }

        void funGrid_CellChange(object sender, CellEventArgs e)
        {
            Sys_UserPermission sup = e.Cell.Row.ListObject as Sys_UserPermission;

            if (e.Cell.Column.Key == "IsCheck" && string.IsNullOrEmpty(sup.PU_FunPCode))
            {

                funGrid.EventManager.SetEnabled(EventGroups.AllEvents, false);

                foreach (UltraGridRow row in this.funGrid.Rows)
                {
                    Sys_UserPermission temp = row.ListObject as Sys_UserPermission;
                    if (temp.PU_FunPCode == sup.PU_FunCode)
                    {
                        row.Cells["IsCheck"].Value = e.Cell.Value;
                    }
                }

                funGrid.EventManager.SetEnabled(EventGroups.AllEvents, true);
            }
        }

        void funGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Sys_UserPermission fun = e.Row.ListObject as Sys_UserPermission;

            if (fun != null && string.IsNullOrEmpty(fun.PU_FunPCode))
            {
                e.Row.Appearance.BackColor = Color.Wheat;
            }

        }

        void comGrid_CellChange(object sender, CellEventArgs e)
        {
            Sys_UserPermission sup = e.Cell.Row.ListObject as Sys_UserPermission;
            if (e.Cell.Column.Key == "IsCheck" && string.IsNullOrEmpty(sup.PU_FunPCode))
            {

                comGrid.EventManager.SetEnabled(EventGroups.AllEvents, false);

                foreach (UltraGridRow row in this.comGrid.Rows)
                {
                    Sys_UserPermission temp = row.ListObject as Sys_UserPermission;
                    if (temp.PU_FunPCode == sup.PU_FunCode)
                    {
                        row.Cells["IsCheck"].Value = e.Cell.Value;
                    }
                }

                comGrid.EventManager.SetEnabled(EventGroups.AllEvents, true);
            }
        }


        private void InitUserPermission(List<Sys_UserPermission> list)
        {
            foreach (UltraGridRow row in this.comGrid.Rows)
            {
                Sys_UserPermission p = row.ListObject as Sys_UserPermission;
                var temp = list.FirstOrDefault(o => o.PU_FunCode == p.PU_FunCode);
                if (temp != null)
                {

                    row.Cells["PU_Code"].Value = temp.PU_Code;
                    row.Cells["IsCheck"].Value = true;
                }
            }
        }


        private void InitFunPermission(List<Sys_UserPermission> list)
        {
            foreach (UltraGridRow row in this.funGrid.Rows)
            {
                Sys_UserPermission p = row.ListObject as Sys_UserPermission;
                var temp = list.FirstOrDefault(o => o.PU_FunCode == p.PU_FunCode);
                if (temp != null)
                {

                    row.Cells["PU_Code"].Value = temp.PU_Code;
                    row.Cells["IsCheck"].Value = true;
                }
            }
        }

        void comGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            Sys_UserPermission fun = e.Row.ListObject as Sys_UserPermission;

            if (fun != null && string.IsNullOrEmpty(fun.PU_FunPCode))
            {
                e.Row.Appearance.BackColor = Color.Wheat;
            }

            //Sys_Function fun = e.Row.ListObject as Sys_Function;

            //if (userList != null && fun != null)
            //{
            //    var model = userList.FirstOrDefault(o => o.PU_FunCode == fun.Fun_Code);
            //    if (e.Row.Cells.Exists("IsCheck"))
            //    {
            //        e.Row.Cells["IsCheck"].Value = true;
            //    }
            //}
        }

        public void SetGridEditMode(bool flag, UltraGrid grid)
        {
            if (flag)
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
            }
            else
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
            }

        }


    }
}
