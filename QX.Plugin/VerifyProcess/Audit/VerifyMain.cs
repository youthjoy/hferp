using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.BLL;
using QX.Common.C_Class;
using QX.Common.C_Class.Utils;
using QX.DataModel;
using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;


namespace QX.Plugin.VerifyProcess
{
    public partial class VerifyMain : F_BasciForm
    {
        public VerifyMain()
        {
            InitializeComponent();
            BindEvent();
        }

        public void BindEvent()
        {
            //this.btnConfirm.Click += new EventHandler(btnConfirm_Click);

            //this.btnCancel.Click += new EventHandler(btnCancel_Click);

            this.commonToolBar1.SaveClicked += new EventHandler(btnConfirm_Click);
        }

        private void VerifyMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {


            TreeInit();
            uGridTemplateInit();
            //uGridTemplateInit();

            uGridCreatorInit();

        }

        #region Member


        private enum ReturnResultEnum
        {
            /// <summary>
            /// 失败
            /// </summary>
            Failure,
            /// <summary>
            /// 成功
            /// </summary>
            Success,
            /// <summary>
            /// 审核用户重复
            /// </summary>
            UserRepeat,
            /// <summary>
            /// 阶段编码重复
            /// </summary>
            CodeRepeat
        }

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        //private Bll_Verify_Nodes vnInstance = new Bll_Verify_Nodes();

        private Bll_Verify_Users vuInstance = new Bll_Verify_Users();

        private Bll_Verify_Template vtInstance = new Bll_Verify_Template();

        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }

        private BindModelHelper _bmHelper = new BindModelHelper();

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }

        private string _CurTemplateNo;

        public string CurTemplateNo
        {
            get { return _CurTemplateNo; }
            set { _CurTemplateNo = value; }
        }

        private Audit_Template CurTemplate;

        private Dictionary<string, string> _DicColumn = new Dictionary<string, string>();
        /// <summary>
        /// 阶段模板对应阶段节点显示列
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }


        private Dictionary<string, string> VerifyNodeColumn = new Dictionary<string, string>();

        private List<Verify_TemplateConfig> dataSource = new List<Verify_TemplateConfig>();

        #endregion

        #region TreeView

        private void TreeInit()
        {
            this.tvTemplate.Nodes.Clear();
            List<Audit_Template> list = vtInstance.GetTemlateList();
            InitTree(list);


        }

        /// <summary>
        /// 双击节点进入编辑状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvTemplate_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node != null)
            {
                //当前编辑对应模板编码
                CurTemplateNo = node.Tag.ToString();

                CurTemplate = vtInstance.GetTemplateByCode(CurTemplateNo);
                //审核模板本身数据
                TemplateDataInit();
                //审核模板相关阶段
                uGridTemplateDataInit();
                //审核流程创建人
                uGridCreatorDataInit();
            }
        }

        /// <summary>
        /// 初始化树控件
        /// </summary>
        /// <param name="Nds"></param>
        /// <param name="parentId"></param>
        private void InitTree(List<Audit_Template> source)
        {
            foreach (Audit_Template vt in source)
            {
                TreeNode node = new TreeNode();
                node.Text = vt.Template_Name;
                node.Tag = vt.Template_Key;
                this.tvTemplate.Nodes.Add(node);
            }
        }


        #endregion

        #region 基础数据

        public void TemplateDataInit()
        {
            if (CurTemplate != null)
            {
                this.VT_Key.Text = CurTemplate.Template_Name;
                this.VT_Remark.Text = CurTemplate.Template_Remark;
            }
        }



        #endregion

        #region Grid


        private string _VT_No;

        public string VT_No
        {
            get { return _VT_No; }
            set { _VT_No = value; }
        }

        #region Grid 初始化

        //模板对应节点数据绑定
        public void uGridTemplateDataInit()
        {
            InitData();
        }

        //模板显示格式初始化
        public void uGridTemplateInit()
        {
            gHandler = new GridHandler(this.uGridTemplate);
            InitColumn();
            StyleInit();
            InitControl();
            //this.uGridInv.DisplayLayout.GroupByBox.Hidden = false;

        }

        /// <summary>
        /// 样式初始化
        /// </summary>
        public void StyleInit()
        {
            gHandler.SetDefaultStyle();

            //列宽度自适应
            this.uGridTemplate.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;

            this.uGridTemplate.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.Select;

            this.uGridTemplate.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;

            this.uGridTemplate.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;

            this.uGridTemplate.DisplayLayout.Override.AllowDelete = DefaultableBoolean.True;
        }

        public void InitColumn()
        {
            DicColumn.Add("VT_VerifyNode_Code", "阶段编码");
            DicColumn.Add("VT_VerifyNode_Name", "阶段名称");
            DicColumn.Add("VT_VerifyNode_BackName", "驳回阶段名称");
            DicColumn.Add("VT_VerifyNode_Back", "驳回阶段编码");
            DicColumn.Add("VT_Remark", "备注");
            #region 用于选择阶段后的阶段模板更新Grid数据使用
            //VerifyNodeColumn.Add("VT_VerifyNode_Name", "阶段名称");
            //VerifyNodeColumn.Add("VerifyNode_Remark", "阶段描述");
            //VerifyNodeColumn.Add("VerifyNode_Code", "阶段编码");
            #endregion

            gHandler.BindData(dataSource, DicColumn);

            AddTemplateCustomCol();


            this.uGridTemplate.DisplayLayout.Bands[0].Columns["VT_Remark"].CellClickAction = CellClickAction.EditAndSelectText;
        }


        private void AddTemplateCustomCol()
        {
            //this.uGridTemplate.DisplayLayout.Bands[0].Columns.Add("RejectVerifyNode_Name", "驳回返回阶段");

            this.uGridTemplate.DisplayLayout.Bands[0].Columns.Add("NodeEdit", "");

            //UltraGridColumn column = this.uGridTemplate.DisplayLayout.Bands[0].Columns["RejectVerifyNode_Name"];

            UltraGridColumn column1 = this.uGridTemplate.DisplayLayout.Bands[0].Columns["NodeEdit"];

            column1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;

            column1.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            column1.CellButtonAppearance.Image = global::QX.Common.Properties.Resources.edit;　　　　//从资源文件中引用


            column1.Width = 18;

            //调整到第一列
            column1.Header.VisiblePosition = 0;

            column1.CellClickAction = CellClickAction.Edit;

            //UltraGridColumn column2 = this.uGridTemplate.DisplayLayout.Bands[0].Columns["VT_Remark"];
            //column2.Header.VisiblePosition = 3;
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void InitData()
        {

            dataSource = vtInstance.GetNodesForTemplateCode(CurTemplateNo);

            gHandler.BindData(dataSource, DicColumn);

            AddTemplateCustomCol();

            this.uGridTemplate.DisplayLayout.Bands[0].AddNew();
        }


        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void InitControl()
        {

            this.uGridTemplate.BeforeEnterEditMode += new CancelEventHandler(uGridTemplate_BeforeEnterEditMode);

            this.uGridTemplate.ClickCellButton += new CellEventHandler(uGridTemplate_ClickCellButton);

            this.uGridTemplate.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(uGridTemplate_BeforeRowsDeleted);
        }

        #endregion

        void uGridTemplate_ClickCellButton(object sender, CellEventArgs e)
        {

            if (e.Cell.Column.Key == "NodeEdit" && e.Cell.Row != this.uGridTemplate.GetRow(ChildRow.Last) && e.Cell.Row.Cells["VT_VerifyNode_Code"].Value != null)
            {
                string code = e.Cell.Row.Cells["VT_VerifyNode_Code"].Value.ToString();
                VerifyNode frm = new VerifyNode(OperationTypeEnum.OperationType.Edit, code);
                frm.CallBack += new VerifyNode.DCallBackHandler(EditNode_CallBack);
                frm.ShowDialog();
            }
        }

        void uGridTemplate_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = true;

            int tmp = e.Rows.Length;

            if (tmp >= 1 && e.Rows[tmp - 1] == uGridTemplate.GetRow(ChildRow.Last))
            {
                this.uGridTemplate.DisplayLayout.Bands[0].AddNew();
            }
        }

        private void uGridTemplate_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {

            UltraGridRow row = this.uGridTemplate.ActiveRow;
            UltraGridCell cell = this.uGridTemplate.ActiveCell;

            //阶段选择
            if (row != null && cell != null && (cell.Column.Key == "VT_VerifyNode_Name" || cell.Column.Key == "VT_VerifyNode_Code"))
            {
                CommVerifyNodes frm = new CommVerifyNodes();
                frm.CallBack += new CommVerifyNodes.DCallBackHandler(SelectNode_CallBack);
                frm.ShowDialog();
                cell.Activated = false;
            }

            //驳回阶段选择
            if (row != null && cell != null && cell.Column.Key == "VT_VerifyNode_BackName" && row.Cells["VT_VerifyNode_Code"].Value != null)
            {

                CommVerifyNodes frm = new CommVerifyNodes(row.Cells["VT_VerifyNode_Code"].Value.ToString());
                frm.CallBack += new CommVerifyNodes.DCallBackHandler(SelectRejectNode_CallBack);
                frm.ShowDialog();

                cell.Activated = false;
            }

            if (cell != null && cell.Column.Key == "VT_Remark")
            {
                return;
            }

            e.Cancel = true;
        }

        //驳回阶段选择回调事件
        private void SelectRejectNode_CallBack(object sender, Verify_Nodes node)
        {
            UltraGridRow row = this.uGridTemplate.ActiveRow;
            UltraGridCell cell = this.uGridTemplate.ActiveCell;

            //判断是否为空，为空则表示未选择，则不作处理
            if (node != null && row != null)
            {

                row.Cells["VT_VerifyNode_Back"].Value = node.VerifyNode_Code;
                row.Cells["VT_VerifyNode_BackName"].Value = node.VerifyNode_Name;
            }
        }

        //阶段选择回调事件
        private void SelectNode_CallBack(object sender, Verify_Nodes node)
        {

            UltraGridRow row = this.uGridTemplate.ActiveRow;
            UltraGridCell cell = this.uGridTemplate.ActiveCell;

            //判断是否为空，为空则表示未选择，则不作处理
            if (node != null && row != null)
            {
                Verify_TemplateConfig tl = new Verify_TemplateConfig();
                tl.VT_VerifyNode_Code = node.VerifyNode_Code;
                tl.VT_VerifyNode_Name = node.VerifyNode_Name;

                //阶段模板编码
                tl.VT_Key = CurTemplateNo;


                //判断选择的阶段编码有重复，有则提示
                if (IsRepeateCode("VT_VerifyNode_Code", tl.VT_VerifyNode_Code))
                {
                    Alert.Show("当前选择的阶段:" + tl.VT_VerifyNode_Name + "已存在，请重新选择!");
                    return;
                }

                gHandler.UpdateRow<Verify_TemplateConfig>(row, DicColumn, tl);

                if (row == uGridTemplate.GetRow(ChildRow.Last))
                {
                    uGridTemplate.EventManager.SetEnabled(EventGroups.AllEvents, false);
                    uGridTemplate.DisplayLayout.Bands[0].AddNew();
                    uGridTemplate.ActiveRow = row;
                    uGridTemplate.EventManager.SetEnabled(EventGroups.AllEvents, true);
                }

            }
        }

        private bool IsRepeateCode(string columnName, string verifyNodeCode)
        {
            bool flag = false;
            foreach (UltraGridRow row in this.uGridTemplate.Rows)
            {
                if (row.Cells[columnName].Value != null)
                {
                    string code = row.Cells[columnName].Value.ToString();
                    if (verifyNodeCode == code)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }


        private void EditNode_CallBack(object sender, Verify_Nodes node)
        {
            //Verify_Nodes vn = node;
            //当前点击按钮所在行
            UltraGridRow row = this.uGridTemplate.ActiveRow;
            if (row != null)
            {
                Verify_TemplateConfig config = row.ListObject as Verify_TemplateConfig;

                config.VT_VerifyNode_Name = node.VerifyNode_Name;
                config.VT_VerifyNode_Code = node.VerifyNode_Code;
                row.Cells["VT_VerifyNode_Code"].Value = node.VerifyNode_Code;
                row.Cells["VT_VerifyNode_Name"].Value = node.VerifyNode_Name;
                //row.Cells["VT_VerifyNode_Back"].Value = "";
                //row.Cells["VT_VerifyNode_BackName"].Value = "";

                //更新阶段模板信息（不更新驳回返回阶段）
                gHandler.UpdateRow<Verify_TemplateConfig>(row, DicColumn, config);
            }

        }


        #endregion

        #region 创建人


        private GridHandler _cGHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler CGHandler
        {
            get { return _cGHanlder; }
            set { _cGHanlder = value; }
        }

        private Dictionary<string, string> CreatorColumn = new Dictionary<string, string>();


        private List<Verify_Users> CreatorSource = new List<Verify_Users>();

        #region Grid 初始化


        //模板对应节点数据绑定
        public void uGridCreatorDataInit()
        {
            uGridCreatorInitControl();
            uGridCreatorInitData();
        }

        //模板显示格式初始化
        public void uGridCreatorInit()
        {
            CGHandler = new GridHandler(this.uGridCreator);
            uGridCreatorInitColumn();
            uGridCreatorStyleInit();
            //this.uGridInv.DisplayLayout.GroupByBox.Hidden = false;

        }

        /// <summary>
        /// 样式初始化
        /// </summary>
        public void uGridCreatorStyleInit()
        {
            CGHandler.SetDefaultStyle();

            this.uGridCreator.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.Select;

            this.uGridCreator.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
            this.uGridCreator.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;
            this.uGridCreator.DisplayLayout.Override.AllowDelete = DefaultableBoolean.True;
        }

        public void uGridCreatorInitColumn()
        {
            //DicColumn.Add("VerifyNode_Name", "阶段名称");
            //DicColumn.Add("VerifyNode_Remark", "阶段描述");
            CreatorColumn.Add("VU_UserName", "用户");
            CreatorColumn.Add("VU_DeptName", "部门");
            CreatorColumn.Add("VU_Duty", "职务");

            //#region 用于更新Grid数据使用
            //VerifyNodeColumn.Add("VerifyNode_Name", "阶段名称");
            //VerifyNodeColumn.Add("VerifyNode_Remark", "阶段描述");
            //VerifyNodeColumn.Add("VerifyNode_Code", "阶段编码");
            //#endregion

            CGHandler.BindData(CreatorSource, CreatorColumn);

            AddCustomCol();
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void uGridCreatorInitData()
        {

            CreatorSource = vuInstance.GetCreatorListByTemplateCode(CurTemplateNo);
            //DicColumn.Add("VerifyNode_Name", "阶段名称");
            //DicColumn.Add("VerifyNode_Remark", "阶段描述");

            CGHandler.BindData(CreatorSource, CreatorColumn);

            AddCustomCol();

            this.uGridCreator.DisplayLayout.Bands[0].AddNew();
        }

        private void AddCustomCol()
        {
            //this.uGridCreator.DisplayLayout.Bands[0].Columns.Add("VU_UserName", "用户");

            //this.uGridCreator.DisplayLayout.Bands[0].Columns.Add("VU_DeptName", "部门");

            UltraGridColumn column = this.uGridCreator.DisplayLayout.Bands[0].Columns["VU_UserName"];
            UltraGridColumn column1 = this.uGridCreator.DisplayLayout.Bands[0].Columns["VU_DeptName"];
            column.Header.VisiblePosition = 0;
            column1.Header.VisiblePosition = 1;

        }


        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void uGridCreatorInitControl()
        {


            //this.uGridCreator.AfterPerformAction += new AfterUltraGridPerformActionEventHandler(uGridCreator_AfterPerformAction);

            //this.uGridCreator.AfterEnterEditMode += new EventHandler(uGridCreator_AfterEnterEditMode);         

            //this.uGridCreator.CellChange += new CellEventHandler(uGridCreator_CellChange);

            this.uGridCreator.BeforeEnterEditMode += new CancelEventHandler(uGridCreator_BeforeEnterEditMode);

            this.uGridCreator.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(uGridCreator_BeforeRowsDeleted);
            //this.uGridCreator.ClickCellButton += new CellEventHandler(uGridCreator_ClickCellButton);
            //this.uGridCreator.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInv_InitializeRow);

            //this.uGridCreator.DoubleClickRow += new DoubleClickRowEventHandler(uGridInv_DoubleClickRow);
        }



        void uGridCreator_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = true;

            int tmp = e.Rows.Length;

            if (tmp >= 1 && e.Rows[tmp - 1] == uGridCreator.GetRow(ChildRow.Last))
            {
                this.uGridCreator.DisplayLayout.Bands[0].AddNew();
            }
        }

        private void uGridCreator_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            Bll_Dept bllDept = new Bll_Dept();
            Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
            CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> user =
                new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
            user.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(user_CallBack);
            user.ShowDialog();
            e.Cancel = true;
        }


        private bool IsRepeateUser(string columnName, string userCode)
        {
            bool flag = false;
            foreach (UltraGridRow row in this.uGridCreator.Rows)
            {
                if (row.Cells[columnName].Value != null)
                {
                    string code = row.Cells[columnName].Value.ToString();
                    if (userCode == code)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }

        private void user_CallBack(object sender, DataTable list)
        {
            if (list.Rows.Count == 1)
            {

                UltraGridRow row = this.uGridCreator.ActiveRow;

                if (row != null)
                {


                    if (IsRepeateUser("VU_User", list.Rows[0]["Emp_Code"].ToString()))
                    {
                        Alert.Show("当前选择的用户:" + list.Rows[0]["Emp_Name"].ToString() + "已存在，请重新选择!");
                        return;
                    }


                    row.Cells["VU_User"].Value = list.Rows[0]["Emp_Code"] != null ? list.Rows[0]["Emp_Code"].ToString() : string.Empty;

                    row.Cells["VU_UserName"].Value = list.Rows[0]["Emp_Name"] != null ? list.Rows[0]["Emp_Name"].ToString() : string.Empty;


                    row.Cells["VU_Dept"].Value = list.Rows[0]["Emp_Dept_Code"] != null ? list.Rows[0]["Emp_Dept_Code"].ToString() : string.Empty;

                    row.Cells["VU_DeptName"].Value = list.Rows[0]["Emp_Dept_Name"] != null ? list.Rows[0]["Emp_Dept_Name"].ToString() : string.Empty;


                    row.Cells["VU_Duty"].Value = list.Rows[0]["Emp_DutyName"] != null ? list.Rows[0]["Emp_DutyName"].ToString() : string.Empty;

                    if (row == uGridCreator.GetRow(ChildRow.Last))
                    {

                        //turn off events for now so the grid does not fire any updating
                        //deactivating events while we add our row
                        uGridCreator.EventManager.SetEnabled(EventGroups.AllEvents, false);
                        //add a blank row
                        uGridCreator.DisplayLayout.Bands[0].AddNew();
                        //deselct the newly added row as the activerow
                        uGridCreator.ActiveRow = null;
                        //set the activecell back to the cell we were editing
                        //uGridNodes.ActiveCell = e.Cell;
                        //place that cell in edit mode
                        //uGridNodes.PerformAction(UltraGridAction.EnterEditMode, false, false);
                        //place the cursor at the end of the text in the cell
                        //uGridNodes.ActiveCell.SelStart = uGridNodes.ActiveCell.Text.Length;
                        //turn our events back on
                        uGridCreator.EventManager.SetEnabled(EventGroups.AllEvents, true);

                    }

                }
            }
        }

        #endregion


        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CurTemplate != null)
            {
                ReturnResultEnum flag = UpdateTemplate();
                ReturnResultEnum cFlag = UpdateCreatorTemplate();
                if (flag == ReturnResultEnum.Success && cFlag == ReturnResultEnum.Success)
                {
                    Alert.Show("更新审核模板成功!");
                }
                else if (flag == ReturnResultEnum.CodeRepeat)
                {
                    Alert.Show("同一模板下面不允许有重复阶段!");
                }
                else if (cFlag == ReturnResultEnum.UserRepeat)
                {
                    Alert.Show("同一模板下面不允许有重复创建人!");
                }
                else
                {
                    Alert.Show("未能完全成功更新审核模板!");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Flag 0 表示失败  1表示成功 2表示 重复</returns>
        private ReturnResultEnum UpdateTemplate()
        {

            //int flag = 1;

            //模板基础数据更新
            CurTemplate.Template_Name = this.VT_Key.Text;
            CurTemplate.Template_Remark = this.VT_Remark.Text;
            //模板数据更新
            var re = vtInstance.UpdateTemplate(CurTemplate);

            //模板对应阶段节点更新
            Dictionary<string, Verify_TemplateConfig> list = new Dictionary<string, Verify_TemplateConfig>();
            foreach (UltraGridRow row in this.uGridTemplate.Rows)
            {
                //最后一行是系统自动添加的空行，不做更新考虑
                if (row != this.uGridTemplate.GetRow(ChildRow.Last))
                {
                    Verify_TemplateConfig vt = row.ListObject as Verify_TemplateConfig;

                    //模板编码
                    vt.VT_Key = CurTemplateNo;

                    //阶段序号
                    vt.VT_VerifyNode_Order = row.Index + 1;

                    //如果添加重复阶段则返回并提示
                    if (list.ContainsKey(vt.VT_VerifyNode_Code))
                    {
                        return ReturnResultEnum.CodeRepeat;
                        //break;
                    }
                    else
                    {
                        list.Add(vt.VT_VerifyNode_Code, vt);
                    }
                }
            }

            if (vtInstance.AddOrUpdateConfig(CurTemplate, list) > 0)
            {
                return ReturnResultEnum.Success;
            }
            else
            {
                return ReturnResultEnum.Failure;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>0 表示失败  1表示成功 2表示 重复</returns>
        private ReturnResultEnum UpdateCreatorTemplate()
        {

            //模板对应阶段节点更新
            Dictionary<string, Verify_Users> list = new Dictionary<string, Verify_Users>();
            foreach (UltraGridRow row in this.uGridCreator.Rows)
            {
                //最后一行是系统自动添加的空行，不做更新考虑
                if (row != this.uGridCreator.GetRow(ChildRow.Last))
                {
                    Verify_Users vu = row.ListObject as Verify_Users;
                    vu.VU_VerifyTempldate_Code = CurTemplateNo;

                    if (list.ContainsKey(vu.VU_User))
                    {
                        return ReturnResultEnum.UserRepeat;
                    }

                    list.Add(vu.VU_User, vu);

                }
            }

            if (vuInstance.AddOrUpdateCreatorVerifyUser(CurTemplateNo, list) > 0)
            {
                return ReturnResultEnum.Success;
            }
            else
            {
                return ReturnResultEnum.Failure;
            }
        }

    }
}
