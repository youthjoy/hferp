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
    public partial class VerifyNode : F_BasicPop
    {
        public VerifyNode()
        {
            InitializeComponent();

            BindEvent();
        }

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
            CodeRepeat,
            /// <summary>
            /// 审核用户数量未达最低审核用户数量
            /// </summary>
            NotFit
        }

        public VerifyNode(OperationTypeEnum.OperationType opType, string nodeCode)
        {
            InitializeComponent();

            OperationType = opType;

            CurNodeCode = nodeCode;

            BindEvent();
        }


        public void BindEvent()
        {
            this.btnConfirm.Click += new EventHandler(btnConfirm_Click);

            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        private void VerifyNode_Load(object sender, EventArgs e)
        {

            Init();

        }

        private void Init()
        {
            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Edit:
                    InitEdit();
                    break;
                case OperationTypeEnum.OperationType.Add:
                    //Grid初始化
                    InitAdd();
                    break;
            }

            InitTextBoxControl();

        }

        #region Member

        public delegate void DCallBackHandler(object sender, Verify_Nodes node);
        public event DCallBackHandler CallBack;


        private string CurNodeCode = string.Empty;

        /// <summary>
        /// 操作类型
        /// </summary>
        private OperationTypeEnum.OperationType _OperationType;

        public OperationTypeEnum.OperationType OperationType
        {
            get { return _OperationType; }
            set { _OperationType = value; }
        }

        public void SetMode(OperationTypeEnum.OperationType mode)
        {
            switch (mode)
            {
                case OperationTypeEnum.OperationType.Look:

                    OperationType = OperationTypeEnum.OperationType.Look;
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    OperationType = OperationTypeEnum.OperationType.Edit;
                    break;
                case OperationTypeEnum.OperationType.Add:

                    break;
            }
        }

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Verify_Nodes vnInstance = new Bll_Verify_Nodes();

        private Bll_Verify_Users vuInstance = new Bll_Verify_Users();

        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }


        private Verify_Nodes CurNode = new Verify_Nodes();

        private BindModelHelper _bmHelper = new BindModelHelper();

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }


        private bool IsEdit = false;

        private Dictionary<string, string> _DicColumn = new Dictionary<string, string>();
        /// <summary>
        /// 需要隐藏的列名
        /// </summary>
        public Dictionary<string, string> DicColumn
        {
            get { return _DicColumn; }
            set { _DicColumn = value; }
        }

        private List<Verify_Users> dataSource = new List<Verify_Users>();

        #endregion


        #region 文本框

        private void InitTextBoxControl()
        {

            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Edit:

                    CurNode = vnInstance.GetVerifyNodeByCode(CurNodeCode);
                    bmHelper.BindModelToControl<Verify_Nodes>(CurNode, pnlVerifyNode.Controls);

                    break;
                case OperationTypeEnum.OperationType.Add:
                    CurNode = new Verify_Nodes();
                    CurNode.VerifyNode_Code = vnInstance.GenerateVerifyNodeCode();
                    bmHelper.BindModelToControl<Verify_Nodes>(CurNode, pnlVerifyNode.Controls);

                    break;
            }


            EventHandler handler = new EventHandler(this.contolValue_Changed);
            bmHelper.BindEventToControl(this.pnlVerifyNode.Controls, typeof(TextBox), handler);
        }


        /// <summary>
        /// 控件值发生变化时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contolValue_Changed(object sender, EventArgs e)
        {
            IsEdit = true;
        }

        #endregion

        public void InitEdit()
        {
            gHandler = new GridHandler(this.uGridNodes);

            InitControl();

            InitData();

            StyleInit();

            //阶段编码不可能编辑
            this.VerifyNode_Code.ReadOnly = true;
            this.VerifyNode_Name.ReadOnly = true;

        }

        public void InitAdd()
        {
            gHandler = new GridHandler(this.uGridNodes);

            InitControl();

            InitColumn();

            StyleInit();
        }

        #region Grid 初始化




        /// <summary>
        /// 样式初始化
        /// </summary>
        public void StyleInit()
        {
            gHandler.SetDefaultStyle();
            ////gh.SetAlternateRowStyle();
            //gHandler.SetExcelStyleFilter();

            //gHandler.SetCellClickAction(GridHandler.ClickActionEnum.Edit);
            this.uGridNodes.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
            this.uGridNodes.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;
            this.uGridNodes.DisplayLayout.Override.AllowDelete = DefaultableBoolean.True;
            //this.uGridNodes.DisplayLayout.Override.SequenceFixedAddRow = 2;
        }

        /// <summary>
        /// Grid
        /// Column初始化 --添加状态下使用
        /// </summary>
        public void InitColumn()
        {

            DicColumn.Add("VU_UserName", "用户");
            DicColumn.Add("VU_DeptName", "部门");
            DicColumn.Add("VU_Duty", "职务");

            gHandler.BindData(dataSource, DicColumn);

            AddCustomCol();

            this.uGridNodes.DisplayLayout.Bands[0].AddNew();
        }

        /// <summary>
        /// 数据初始化--编辑状态时候使用
        /// </summary>
        public void InitData()
        {
            dataSource = vuInstance.GetUsersByVerifyCode(CurNodeCode);
            //dataSource = new List<Verify_Nodes>();

            DicColumn.Add("VU_UserName", "用户");
            DicColumn.Add("VU_DeptName", "部门");
            DicColumn.Add("VU_Duty", "职务");

            gHandler.BindData(dataSource, DicColumn);

            AddCustomCol();

            this.uGridNodes.DisplayLayout.Bands[0].AddNew();
        }

        private void AddCustomCol()
        {
            //this.uGridNodes.DisplayLayout.Bands[0].Columns.Add("VU_UserName", "用户");

            //this.uGridNodes.DisplayLayout.Bands[0].Columns.Add("VU_DeptName", "部门");

            UltraGridColumn column = this.uGridNodes.DisplayLayout.Bands[0].Columns["VU_UserName"];
            UltraGridColumn column1 = this.uGridNodes.DisplayLayout.Bands[0].Columns["VU_DeptName"];
            column.Header.VisiblePosition = 0;
            column1.Header.VisiblePosition = 1;

        }


        public void RefreshData(object dataSource)
        {
            //dataSource = invInstance.GetInvInfoList(ProdType);

            gHandler.BindData(dataSource, DicColumn);
        }

        /// <summary>
        /// 事件及Grid对应事件初始化
        /// </summary>
        public void InitControl()
        {


            //this.uGridNodes.AfterPerformAction += new AfterUltraGridPerformActionEventHandler(uGridNodes_AfterPerformAction);

            //this.uGridNodes.AfterEnterEditMode += new EventHandler(uGridNodes_AfterEnterEditMode);           //this.uGridNodes.afteren

            //this.uGridNodes.CellChange += new CellEventHandler(uGridNodes_CellChange);

            this.uGridNodes.BeforeEnterEditMode += new CancelEventHandler(uGridNodes_BeforeEnterEditMode);
            this.uGridNodes.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(uGridNodes_BeforeRowsDeleted);
            //this.uGridNodes.ClickCellButton += new CellEventHandler(uGridNodes_ClickCellButton);
            //this.uGridNodes.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.uGridInv_InitializeRow);

            //this.uGridNodes.DoubleClickRow += new DoubleClickRowEventHandler(uGridInv_DoubleClickRow);
        }

        #endregion

        #region GridEvent 备用

        void uGridNodes_ClickCellButton(object sender, CellEventArgs e)
        {

        }

        void uGridNodes_AfterPerformAction(object sender, AfterUltraGridPerformActionEventArgs e)
        {
            //if (e.UltraGridAction == UltraGridAction.ExitEditMode)
            //{
            //    //双击测试，察看当前双击地方是不是一行，如果是则弹出窗体

            //    //获取当前双击点的位置
            //    Point p = System.Windows.Forms.Cursor.Position;

            //    //获取当前双击点在网格中所处的位置
            //    p = this.uGridNodes.PointToClient(p);

            //    //获取双击点网格控件的元素
            //    Infragistics.Win.UIElement oUI = this.uGridNodes.DisplayLayout.UIElement.ElementFromPoint(p);
            //    if (oUI != null)
            //    {

            //        //判断双击点是不是行，也可能是列，如果网格控件选取方式不是设的选中整行的话。
            //        Infragistics.Win.UltraWinGrid.UltraGridRow oRowUI = oUI.SelectableItem as Infragistics.Win.UltraWinGrid.UltraGridRow;
            //        //UltraGridCell oCellUI = oUI.SelectableItem as UltraGridCell;

            //        if (oRowUI != null && oRowUI == uGridNodes.GetRow(ChildRow.Last))
            //        {

            //            //turn off events for now so the grid does not fire any updating
            //            //deactivating events while we add our row
            //            uGridNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
            //            //add a blank row
            //            uGridNodes.DisplayLayout.Bands[0].AddNew();
            //            //deselct the newly added row as the activerow
            //            uGridNodes.ActiveRow = null;
            //            //set the activecell back to the cell we were editing
            //            //uGridNodes.ActiveCell = e.Cell;
            //            //place that cell in edit mode
            //            uGridNodes.PerformAction(UltraGridAction.EnterEditMode, false, false);
            //            //place the cursor at the end of the text in the cell
            //            uGridNodes.ActiveCell.SelStart = uGridNodes.ActiveCell.Text.Length;
            //            //turn our events back on
            //            uGridNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);



            //        }

            //    }
            //}
        }

        void uGridNodes_AfterEnterEditMode(object sender, EventArgs e)
        {

        }



        private void uGridNodes_CellChange(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            //since we have a blank row when we start we only need to add a row if the user
            //is editing the last row in the grid
            //this statement will only be true when you first enter a character in any cell in the last
            //row, because after that the last row of the grid is the blank row
            if (e.Cell.Row == uGridNodes.GetRow(ChildRow.Last))
            {
                //turn off events for now so the grid does not fire any updating
                //deactivating events while we add our row
                uGridNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                //add a blank row
                uGridNodes.DisplayLayout.Bands[0].AddNew();
                //deselct the newly added row as the activerow
                uGridNodes.ActiveRow = null;
                //set the activecell back to the cell we were editing
                uGridNodes.ActiveCell = e.Cell;
                //place that cell in edit mode
                uGridNodes.PerformAction(UltraGridAction.EnterEditMode, false, false);
                //place the cursor at the end of the text in the cell
                uGridNodes.ActiveCell.SelStart = uGridNodes.ActiveCell.Text.Length;
                //turn our events back on
                uGridNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);
            }

        }

        #endregion

        void uGridNodes_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            e.DisplayPromptMsg = true;

            int tmp = e.Rows.Length;

            if (tmp >= 1 && e.Rows[tmp - 1] == uGridNodes.GetRow(ChildRow.Last))
            {
                this.uGridNodes.DisplayLayout.Bands[0].AddNew();
            }
        }

        private void uGridNodes_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            Bll_Dept bllDept = new Bll_Dept();
            Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
            CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> user =
                new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
            user.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(user_CallBack);
            user.ShowDialog();
            e.Cancel = true;
        }

        private void user_CallBack(object sender, DataTable list)
        {
            if (list.Rows.Count == 1)
            {

                UltraGridRow row = this.uGridNodes.ActiveRow;

                if (row != null)
                {
                    //更新该工艺对应部门信息
                    row.Cells["VU_User"].Value = list.Rows[0]["Emp_Code"] != null ? list.Rows[0]["Emp_Code"].ToString() : string.Empty;

                    row.Cells["VU_UserName"].Value = list.Rows[0]["Emp_Name"] != null ? list.Rows[0]["Emp_Name"].ToString() : string.Empty;


                    row.Cells["VU_Dept"].Value = list.Rows[0]["Emp_Dept_Code"] != null ? list.Rows[0]["Emp_Dept_Code"].ToString() : string.Empty;

                    row.Cells["VU_DeptName"].Value = list.Rows[0]["Emp_Dept_Name"] != null ? list.Rows[0]["Emp_Dept_Name"].ToString() : string.Empty;


                    row.Cells["VU_Duty"].Value = list.Rows[0]["Emp_DutyName"] != null ? list.Rows[0]["Emp_DutyName"].ToString() : string.Empty;

                    if (row == uGridNodes.GetRow(ChildRow.Last))
                    {

                        //turn off events for now so the grid does not fire any updating
                        //deactivating events while we add our row
                        uGridNodes.EventManager.SetEnabled(EventGroups.AllEvents, false);
                        //add a blank row
                        uGridNodes.DisplayLayout.Bands[0].AddNew();
                        //deselct the newly added row as the activerow
                        uGridNodes.ActiveRow = null;
                        //set the activecell back to the cell we were editing
                        //uGridNodes.ActiveCell = e.Cell;
                        //place that cell in edit mode
                        //uGridNodes.PerformAction(UltraGridAction.EnterEditMode, false, false);
                        //place the cursor at the end of the text in the cell
                        //uGridNodes.ActiveCell.SelStart = uGridNodes.ActiveCell.Text.Length;
                        //turn our events back on
                        uGridNodes.EventManager.SetEnabled(EventGroups.AllEvents, true);



                    }

                }
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //数据是否有效，否则返回
            if (!ValidateData())
            {
                return;
            }



            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Edit:

                    switch (UpdateVerifyNode())
                    {
                        case ReturnResultEnum.Failure:
                            Alert.Show("编辑审核阶段失败!");
                            break;
                        case ReturnResultEnum.Success:
                            Alert.Show("编辑审核阶段成功");
                            if (CallBack != null)
                            {
                                CallBack(null, CurNode);
                            }
                            this.Close();
                            break;
                        case ReturnResultEnum.NotFit:
                            Alert.Show("审核人数不能低于最低审核通过人数！");
                            break;
                        case ReturnResultEnum.UserRepeat:
                            Alert.Show("同一阶段不允许有重复审核用户！");
                            break;

                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    switch (AddVerifyNode())
                    {
                        case ReturnResultEnum.Failure:
                            Alert.Show("添加审核阶段失败!");
                            break;
                        case ReturnResultEnum.Success:
                            Alert.Show("添加审核阶段成功");
                            if (CallBack != null)
                            {
                                CallBack(null, CurNode);
                            }
                            this.Close();
                            break;
                        case ReturnResultEnum.NotFit:
                            Alert.Show("审核人数不能低于最低审核通过人数！");
                            break;
                        case ReturnResultEnum.UserRepeat:
                            Alert.Show("同一阶段不允许有重复审核用户！");
                            break;
                        case ReturnResultEnum.CodeRepeat:
                            Alert.Show("阶段编码与其他阶段编码重复，请重新输入!");
                            break;

                    }
                    break;
            }



            //}
            //else
            //{
            //    Alert.Show("审核人数不能低于最低审核通过人数！");
            //}
        }


        private bool ValidateData()
        {
            #region 数据有效性验证

            bool flag = true;

            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("VerifyNode_Code", new ValidateModel(true, 20, 0, new string[] { "阶段编码不能为空", "阶段编码字符数不能超过20个" }));
            dict.Add("VerifyNode_Name", new ValidateModel(true, 20, 0, new string[] { "阶段名称不能为空", "阶段名称字符数不能超过20个" }));
            //dict.Add("

            Dictionary<string, string> re = ValidateControlHelper.Validate(this.pnlVerifyNode.Controls, dict);

            if (re.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<string, string> k in re)
                {
                    //Control c = this.Controls.Find("lb" + k, true);
                    sb.AppendLine(k.Value);
                }

                Alert.Show(sb.ToString());

                flag = false;
            }

            return flag;

            #endregion
        }

        private ReturnResultEnum UpdateVerifyNode()
        {
            //具体添加的审核人数
            int count = this.uGridNodes.Rows.Count;

            Verify_Nodes vn = CurNode;

            //待解决  判断阶段编码是否重复

            bmHelper.BindControlToModel(vn, pnlVerifyNode.Controls);

            if (count > 0 && count >= vn.VerifyNode_AuditNum)
            {

                //添加该阶段对应的审核人员
                Dictionary<string, Verify_Users> list = new Dictionary<string, Verify_Users>();

                foreach (UltraGridRow row in this.uGridNodes.Rows)
                {
                    if (row != uGridNodes.GetRow(ChildRow.Last))
                    {
                        Verify_Users vu = row.ListObject as Verify_Users;

                        //当前编辑状态对应的阶段编码
                        vu.VU_VerifyNode_Code = CurNodeCode;

                        //如果存在重复用户则返回
                        if (list.ContainsKey(vu.VU_User))
                        {
                            return ReturnResultEnum.UserRepeat;
                        }
                        list.Add(vu.VU_User, vu);
                    }
                }
                //更新阶段节点信息及其审核用户信息
                if (vnInstance.UpdateVerifyNode(vn) > 0 && vuInstance.AddOrUpdateVerifyUser(CurNodeCode, list) > 0)
                {
                    CurNode = vn;
                    return ReturnResultEnum.Success;
                }
                else
                {
                    return ReturnResultEnum.Failure;
                }


            }
            else
            {
                return ReturnResultEnum.NotFit;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>1 成功  0 失败  2 审核人数与最低审核人数要求不对应  3 表示阶段编码重复</returns>
        private ReturnResultEnum AddVerifyNode()
        {
            //具体添加的审核人数
            int count = this.uGridNodes.Rows.Count;

            Verify_Nodes vn = new Verify_Nodes();

            vn.VerifyNode_Code = vnInstance.GenerateNodeCode();

            bmHelper.BindControlToModel(vn, pnlVerifyNode.Controls);


            //if (!vnInstance.IsRepeatCode(vn.VerifyNode_Code))
            //{
            //    return ReturnResultEnum.CodeRepeat;
            //}


            if (count > 0 && count >= vn.VerifyNode_AuditNum)
            {

                //添加该阶段对应的审核人员
                Dictionary<string, Verify_Users> list = new Dictionary<string, Verify_Users>();

                foreach (UltraGridRow row in this.uGridNodes.Rows)
                {
                    if (row != uGridNodes.GetRow(ChildRow.Last))
                    {
                        Verify_Users vu = row.ListObject as Verify_Users;

                        vu.VU_VerifyNode_Code = vn.VerifyNode_Code;
                        //如果存在重复用户则返回
                        if (list.ContainsKey(vu.VU_User))
                        {
                            return ReturnResultEnum.UserRepeat;
                        }

                        list.Add(vu.VU_User, vu);
                    }
                }

                if (vnInstance.AddVerifyNodeAndUsers(vn, list) > 0)
                {
                    CurNode = vn;
                    return ReturnResultEnum.Success;
                }
                else
                {
                    return ReturnResultEnum.Failure;
                }


            }
            else
            {
                return ReturnResultEnum.NotFit;
            }
        }


        private void ClearBox()
        {

        }


        //关闭窗口处理方法
        private void CloseForm()
        {
            if (IsEdit)
            {
                //MSGCon msg = new MSGCon("确定放弃保存当前编辑数据，关闭该窗口?");
                //msg.StartPosition = FormStartPosition.CenterParent;
                //msg.ShowDialog();

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定放弃保存当前编辑数据，关闭该窗口?");


                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
