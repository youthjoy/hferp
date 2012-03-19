﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.DataModel;
using QX.BLL;
using QX.Common.C_Class;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Plugin.BaseModule.Permission;
using QX.Shared;
using System.Linq;
namespace QX.Plugin.DeptManage
{
    public partial class DeptInfo : F_BasciForm
    {
        private delegate void DSynHanlder();
        DataTable listEmployee;

        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }

        UltraGrid ultraGrid1 = new UltraGrid();

        //private Bll_Equ_FailureCat fcInstance = new Bll_Equ_FailureCat();
        private Bll_Dept instance = new Bll_Dept();
        private Bll_Bse_Employee employeeInstance = new Bll_Bse_Employee();


        FormHelper fHelper = new FormHelper();

        #region 窗体单例
        public static DeptInfo NewForm = null;
        public static DeptInfo Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new DeptInfo();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion

        public DeptInfo()
        {
            InitializeComponent();
            //树控件
            InitTree();
            //Grid
            InitGrid("");
            tool_left.AddClicked += new EventHandler(btnAddDept_Click);
            tool_left.EditClicked += new EventHandler(btnModify_Click);
            tool_left.DelClicked += new EventHandler(btnDelDept_Click);
            tool_left.RefreshClicked += new EventHandler(btnRefresh_Click);
            
            tool_left.SetButtonEnabled("his",false,false);
            tool_right.SetButtonEnabled("his", false, false);

            //tool_left.SetButtonStyle("image");
            tool_left.SetButtonEnabled("PRINT", false, false);
            tool_right.AddClicked += new EventHandler(tool_right_AddClicked);
            tool_right.EditClicked += new EventHandler(tool_right_EditClicked);
            tool_right.DelClicked += new EventHandler(tool_right_DelClicked);
            tool_right.RefreshClicked += new EventHandler(tool_right_RefreshClicked);
            tool_right.QueryClicked += new EventHandler(tool_right_QueryClicked);
            tool_right.SetButtonEnabled("PRINT", false, false);
            ultraGrid1.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(ultraGrid1_DoubleClickRow);
            //tv_left.AfterSelect += new TreeViewEventHandler(tv_left_AfterSelect);

            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripButton empExtBtn = tsHelper.New("员工信息登记", QX.Common.Properties.Resources.history, new EventHandler(empExtBtn_Click));
            empExtBtn.Name = "empExt";
            this.tool_right.AddCustomControl(empExtBtn);

            if (SessionConfig.IsAdmin)
            {
                ToolStripButton permissionBtn = new ToolStripButton();
                permissionBtn.Text = "权限";
                Image image = global::QX.Common.Properties.Resources.planner;　　　　//从资源文件中引用
                permissionBtn.Image = image;
                permissionBtn.Size = new Size(60, 40);
                permissionBtn.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                permissionBtn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                permissionBtn.TextImageRelation = TextImageRelation.ImageAboveText;
                permissionBtn.Click += new EventHandler(permissionBtn_Click);

                tool_right.AddCustomControl(permissionBtn);
            }

            fHelper.PermissionControl(tool_left.toolStrip1.Items,PermissionModuleEnum.Dept.ToString());
            fHelper.PermissionControl(this.tool_right.toolStrip1.Items, PermissionModuleEnum.Employee.ToString());
        }

        void tool_right_QueryClicked(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow != null)
            {
                string EmpolyCode = ultraGrid1.ActiveRow.Cells["Emp_Code"].Value.ToString();
                Bse_Employee model = employeeInstance.GetModel(" AND Emp_Code='" + EmpolyCode + "'");
                Employee employee = new Employee(employeeInstance, instance, model);
                employee.OperationType = OperationTypeEnum.OperationType.Look;
                //employee.DataChange += new Employee.DataChangeHandler(employee_DataChange);
                employee.ShowDialog();
                //var node = tv_left.SelectedNode;
                //if (node != null)
                //{
                //    RefreshGrid(node.Name);
                //}
                //else
                //{
                //    RefreshGrid();
                //}
            }
        }

        void empExtBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGrid1.ActiveRow;
            if (row != null)
            {
                Bse_Employee emp = row.ListObject as Bse_Employee;
                EmployeeExt ExtFrm = new EmployeeExt(emp);
                ExtFrm.Show();
            }
        }


        void permissionBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ultraGrid1.ActiveRow;
            if (row != null)
            {
                Bse_Employee emp = row.ListObject as Bse_Employee;
                PermissionMain permissionForm = new PermissionMain(emp);
                permissionForm.ShowDialog();
            }
        }


        void ultraGrid1_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            tool_right_EditClicked(this, EventArgs.Empty);
        }

        /// <summary>
        /// 刷新人员gird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tool_right_RefreshClicked(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        /// <summary>
        /// 人员删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tool_right_DelClicked(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string EmpolyCode = ultraGrid1.ActiveRow.Cells["Emp_Code"].Value.ToString();
                    Bse_Employee model = employeeInstance.GetModel(" AND Emp_Code='" + EmpolyCode + "'");
                    bool result = employeeInstance.DeleteEmployee(model);
                    if (result)
                    {
                        tool_right_RefreshClicked(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            }
        }

        /// <summary>
        /// 人员编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tool_right_EditClicked(object sender, EventArgs e)
        {
            if (ultraGrid1.ActiveRow != null)
            {
                string EmpolyCode = ultraGrid1.ActiveRow.Cells["Emp_Code"].Value.ToString();
                Bse_Employee model = employeeInstance.GetModel(" AND Emp_Code='" + EmpolyCode + "'");
                Employee employee = new Employee(employeeInstance, instance, model);
                employee.OperationType = OperationTypeEnum.OperationType.Edit;
                //employee.DataChange += new Employee.DataChangeHandler(employee_DataChange);
                employee.ShowDialog();
                var node = tv_left.SelectedNode;
                if (node != null)
                {
                    RefreshGrid(node.Name);
                }
                else
                { 
                     RefreshGrid();
                }
            }
        }

        void employee_DataChange(object sender, EventArgs e)
        {
            tool_right_RefreshClicked(this, EventArgs.Empty);
        }

        /// <summary>
        /// 人员添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tool_right_AddClicked(object sender, EventArgs e)
        {
            Employee employee = new Employee(employeeInstance, instance, null);
            employee.OperationType = OperationTypeEnum.OperationType.Add;
            employee.DataChange += new Employee.DataChangeHandler(employee_DataChange);
            employee.ShowDialog();
            RefreshGrid();
        }

        /// <summary>
        /// 读取部门人员信息
        /// </summary>
        public void InitGrid(string filter)
        {
            GridHelper gen = new GridHelper();

            List<Bse_Employee> list = employeeInstance.GetAllEmployee().OrderBy(o=>o.Emp_Order).ToList();
            //listEmployee = ConvertX.ToDataTable<Bse_Employee>(list);

            gHandler = new GridHandler(this.ultraGrid1);
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("Emp_Code", "人员编号");
            //dic.Add("Emp_Name", "姓名");
            //dic.Add("Emp_Gendar", "性别");
            //dic.Add("Emp_Dept_Code", "部门编号");
            //dic.Add("Emp_Dept_Name", "部门名称");
            //dic.Add("Emp_TitleName", "职称");
            //dic.Add("Emp_DutyName", "职务");
            //dic.Add("Emp_Birth", "出生日期");
            //dic.Add("Emp_StartDate", "进厂日期");
            //dic.Add("Emp_Mobile", "手机号");
            //dic.Add("Emp_HomeTel", "家庭座机");
            //dic.Add("Emp_Date", "停用日期");
            //dic.Add("Emp_CanLogin", "是否使用系统");
            //dic.Add("Emp_LoginID", "登录名");
            //dic.Add("Emp_LoginPwd", "登录密码");
            //dic.Add("备注", "备注");
            //if (!String.IsNullOrEmpty(filter))
            //{
            //    DataTable tmp = FilterDataTable(filter);
            //    //gHandler.BindData(tmp, dic, false);

            //    this.ultraGrid1 = gen.GenerateGrid("GEmp", this.panel5, new Point(0, 0));
            //    ultraGrid1.DataSource = listEmployee;

            //}
            //else
            //{
            //gHandler.BindData(listEmployee, dic, false);

            this.ultraGrid1 = gen.GenerateGrid("GEmp", this.panel5, new Point(0, 0));
            ultraGrid1.DataSource = list;

            //}
            //gHandler.SetDefaultStyle();
            ////gHandler.SetAlternateRowStyle();
            //gHandler.SetExcelStyleFilter();

            //Grid设置
            gHandler.SetGridEditMode(false, ultraGrid1);
        }

        /// <summary>
        /// 读取部门人员信息
        /// </summary>
        public void RefreshGrid(string filter)
        {
            if (string.IsNullOrEmpty(filter)||filter=="root")
            {
                List<Bse_Employee> list = employeeInstance.GetAllEmployee().OrderBy(o => o.Emp_Order).ToList();
                ultraGrid1.DataSource = list;
            }
            else
            {
                List<Bse_Employee> list = employeeInstance.GetEmpByDept(filter);
                ultraGrid1.DataSource = list;
            }
        }

        public void RefreshGrid()
        {

            List<Bse_Employee> list = employeeInstance.GetAllEmployee().OrderBy(o=>o.Emp_Order).ToList();
            ultraGrid1.DataSource = list;
        }

        /// <summary>
        /// 筛选人员
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private DataTable FilterDataTable(string filter)
        {
            DataTable tmpDT = new DataTable();
            tmpDT = listEmployee.Clone();
            if (listEmployee != null && listEmployee.Rows.Count > 0)
            {
                DataRow[] rows = listEmployee.Select(filter);
                for (int i = 0; i < rows.Length; i++)
                {
                    tmpDT.ImportRow(rows[i]);
                }
            }

            return tmpDT;
        }

        /// <summary>
        /// 读取部门类别
        /// </summary>
        public void InitTree()
        {
            tv_left.Nodes.Clear();
            //DataTable dt = ConvertX.ToDataTable<Bse_Department>(instance.GetAllDept());
            //dt.TableName = "deptname";
            TreeHelper<Bll_Dept, Bse_Department> treeHelper = new TreeHelper<Bll_Dept, Bse_Department>(tv_left, instance,
                "Dept_PCode", "Dept_Code", "Dept_Name", "Dept_Code", "GetAllDept", null);
            treeHelper.DataTableToTree(tv_left.Nodes, "");
            if (tv_left.Nodes.Count > 0)
            {
                tv_left.ExpandAll();
            }
        }

        /// <summary>
        /// 刷新左边树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new DSynHanlder(InitTree));
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnModify_Click(object sender, EventArgs e)
        {
            if (tv_left.SelectedNode != null)
            {
                Bse_Department model = instance.GetDeptModel(" And Dept_Code='" + tv_left.SelectedNode.Tag.ToString() + "'");
                Dept dept = new Dept(instance, employeeInstance, model);
                dept.OperationType = OperationTypeEnum.OperationType.Edit;
                dept.FormClosing += new FormClosingEventHandler(dept_FormClosing);
                dept.ShowDialog();
            }
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnDelDept_Click(object sender, EventArgs e)
        {
            if (tv_left.SelectedNode != null && !String.IsNullOrEmpty(tv_left.SelectedNode.Text))
            {
                DialogResult DiaLog = Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]);
                if (DialogResult.OK == DiaLog)
                {

                    bool result = instance.DeleteDept(tv_left.SelectedNode.Tag.ToString());
                    if (result)
                    {
                        tv_left.SelectedNode.Remove();
                    }

                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            }
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAddDept_Click(object sender, EventArgs e)
        {
            Dept dept = new Dept(instance, employeeInstance, null);
            dept.OperationType = OperationTypeEnum.OperationType.Add;
            dept.FormClosing += new FormClosingEventHandler(dept_FormClosing);
            if (tv_left.SelectedNode != null)
            {
                dept.SetDeptPCode(tv_left.SelectedNode.Tag.ToString(), tv_left.SelectedNode.Text);
            }
            else
            {
                if (tv_left.Nodes.Count > 0)
                {
                    dept.SetDeptPCode(tv_left.Nodes[0].Tag.ToString(), tv_left.Nodes[0].Text);
                }
            }
            dept.ShowDialog();
        }

        void dept_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnRefresh_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// 树节点选中后筛选数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_left_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectText = tv_left.SelectedNode.Tag != null ? tv_left.SelectedNode.Tag.ToString() : string.Empty;
            if (!string.IsNullOrEmpty(selectText))
            {
                string filter = selectText;
                //if (tv_left.SelectedNode.Level == 0)
                //{
                //    filter = "";
                //}
                RefreshGrid(filter);
            }
        }

        private void tv_left_DoubleClick(object sender, EventArgs e)
        {
            btnModify_Click(sender, e);
        }

        private void DeptInfo_Load(object sender, EventArgs e)
        {

        }

        private void tv_left_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    tvRoadCate.SelectedNode = tvRoadCate.GetNodeAt(e.X, e.Y);
            //    this.SelectedNode = tvRoadCate.SelectedNode;
            //    List<string> list = new List<string>();
            //    GetChildNode(this.SelectedNode, list);

            //    List<Road_Components> dataSource = rcInstance.GetListByRoadCate(list);
            //    //刷新数据源
            //    this.RefreshuGridLastAudit(dataSource);
            //}

            if (e.Button == MouseButtons.Left)
            {
                tv_left.SelectedNode = tv_left.GetNodeAt(e.X, e.Y);

                string selectText = tv_left.SelectedNode.Tag != null ? tv_left.SelectedNode.Tag.ToString() : string.Empty;
                if (!string.IsNullOrEmpty(selectText))
                {
                    string filter = selectText;
                    //if (tv_left.SelectedNode.Level == 0)
                    //{
                    //    filter = "";
                    //}
                    RefreshGrid(filter);
                }
            }
        }
    }
}
