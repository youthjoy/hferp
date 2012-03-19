using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Common.C_Form;
namespace QX.BseDict
{
    public partial class CommRoadTest :F_BasicPop
    {
        public CommRoadTest()
        {
            InitializeComponent();
        }

        private void CommRoadTest_Load(object sender, EventArgs e)
        {
            Init();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="roadNodeCode">工艺节点编码</param>
        /// <param name="nodeDic">Key -- Code  value--Order</param>
        public CommRoadTest(string comptCode, string nodeCode, Dictionary<string, Road_TestRef> roadTestList)
        {
            InitializeComponent();
            //this.CurNodeDict = nodeDic;
            RoadTestList = roadTestList;
            ComptCode = comptCode;
            RNodeCode = nodeCode;
            BindEvent();
        }

        public void BindEvent()
        {
            this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        #region Member

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        private Dictionary<string, Road_TestRef> _RoadTestList;

        public Dictionary<string, Road_TestRef> RoadTestList
        {
            get { return _RoadTestList; }
            set { _RoadTestList = value; }
        }

        private string _ComptCode;

        public string ComptCode
        {
            get { return _ComptCode; }
            set { _ComptCode = value; }
        }


        private string _RNodeCode;

        public string RNodeCode
        {
            get { return _RNodeCode; }
            set { _RNodeCode = value; }
        }

        //private Dictionary<string, int> _CurNodeDict;
        ///// <summary>
        ///// 当前工艺节点列表
        ///// </summary>
        //public Dictionary<string, int> CurNodeDict
        //{
        //    get { return _CurNodeDict; }
        //    set { _CurNodeDict = value; }
        //}

        //private int _CurMaxOrder;

        //public int CurMaxOrder
        //{
        //    get { return _CurMaxOrder; }
        //    set { _CurMaxOrder = value; }
        //}


        private bool _IsChanged = false;

        public bool IsChanged
        {
            get { return _IsChanged; }
            set { _IsChanged = value; }
        }
        #endregion



        public void Init()
        {
            GridInit();
            NodeDataInit();
        }

        public void GridInit()
        {
            List<Bse_Dict> list = dcInstance.GetListByDictKeyByNoRoot(DictKeyEnum.RoadTest);
            IBindingList bl = new BindingList<Bse_Dict>(list);
            //BindingSource dataSource = new BindingSource();
            //dataSource.DataSource = list;

            this.gvRoadTest.AutoGenerateColumns = false;

            this.gvRoadTest.EditMode = DataGridViewEditMode.EditOnEnter;
            this.gvRoadTest.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.gvRoadTest.MultiSelect = false;
            this.gvRoadTest.ReadOnly = false;
            this.gvRoadTest.Columns["Dict_Code"].ReadOnly = true;
            this.gvRoadTest.Columns["Dict_Name"].ReadOnly = true;

            //this.gvRoadTest.Columns["Order"].SortMode = DataGridViewColumnSortMode.NotSortable;


            //gvRoadTest.SelectionChanged += new EventHandler(
            //DataGridView_SelectionChanged);
            //this.gvRoadTest.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);

            //this.gvRoadTest.CurrentCellDirtyStateChanged += new EventHandler(dataGridView_CurrentCellDirtyStateChanged);

            //this.gvRoadTest.CellEndEdit += new DataGridViewCellEventHandler(this.gvRoadTest_CellEndEdit);

            //this.gvRoadTest.CellLeave += new DataGridViewCellEventHandler(this.dataGridView_CellLeave);



            this.gvRoadTest.DataSource = bl;


        }


        public void NodeDataInit()
        {
            foreach (DataGridViewRow row in this.gvRoadTest.Rows)
            {
                //获取当前行对应的工艺编号
                string dictCode = row.Cells["Dict_Code"].Value.ToString();


                if (!string.IsNullOrEmpty(dictCode) && RoadTestList.ContainsKey(dictCode))
                {

                    //int tmpOrder = Convert.ToInt32(CurNodeDict[dictCode]);
                    //如果有更大的排序值则保存（使在初始化的时候CurMaxOrder即保存当前最大的排序值）
                    //if (tmpOrder > CurMaxOrder)
                    //{
                    //    CurMaxOrder = tmpOrder;
                    //}

                    //row.Cells["checkbox"].ReadOnly = false;
                    //row.Cells["Order"].ReadOnly = false;

                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
                    checkCell.Value = true;

                    row.Cells["TestRef_High"].Value = RoadTestList[dictCode].TestRef_High;
                    row.Cells["TestRef_Low"].Value = RoadTestList[dictCode].TestRef_Low;
                    row.Cells["TestRef_Value"].Value = RoadTestList[dictCode].TestRef_Value;
                    row.Cells["TestRef_IsLast"].Value = RoadTestList[dictCode].TestRef_IsLast;
                    //row.Cells["Order"].Value = tmpOrder;

                }

            }


            //this.gvRoadTest.Sort(this.gvRoadTest.Columns["Order"], ListSortDirection.Ascending);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ImportRoadNodes();

            this.Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ImportRoadNodes();

            this.Close();
        }

        private void ImportRoadNodes()
        {
            Dictionary<string, Road_TestRef> nodesDict = new Dictionary<string, Road_TestRef>();

            foreach (DataGridViewRow row in this.gvRoadTest.Rows)
            {
                string testRefCode = row.Cells["Dict_Code"].Value.ToString();


                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
                bool cbValue = Convert.ToBoolean(checkCell.Value);
                //遍历获取选中的工艺节点
                if (cbValue)
                {

                    if (!nodesDict.ContainsKey(testRefCode))
                    {
                        
                        Road_TestRef roadTestRef = new Road_TestRef();
                        // 检测参数名称
                        roadTestRef.TestRef_Name = row.Cells["Dict_Name"].Value.ToString();
                        //零件图号
                        roadTestRef.TestRef_PartNo = ComptCode;
                        //工艺节点编码
                        roadTestRef.TestRef_RNodeCode = RNodeCode;
                        //检测参数编码
                        roadTestRef.TestRef_Code = testRefCode;

                        if (row.Cells["TestRef_High"].Value != null)
                        {
                            roadTestRef.TestRef_High = row.Cells["TestRef_High"].Value.ToString();
                        }
                        if (row.Cells["TestRef_Low"].Value != null)
                        {
                            roadTestRef.TestRef_Low = row.Cells["TestRef_Low"].Value.ToString();
                        }

                        if (row.Cells["TestRef_Value"].Value != null)
                        {
                            roadTestRef.TestRef_Value = row.Cells["TestRef_Value"].Value.ToString();
                        }

                        if (row.Cells["TestRef_IsLast"].Value != null && row.Cells["TestRef_IsLast"].Value.ToString().ToLower() == "true")
                        {

                            roadTestRef.TestRef_IsLast = 1;
                        }
                        else
                        {
                            roadTestRef.TestRef_IsLast = 0;
                        }
                        nodesDict.Add(testRefCode, roadTestRef);
                    }
                }

            }
            //更新当前工艺节点列表
            RoadTestList = nodesDict;

            IsChanged = true;
        }


        private void gvRoadTest_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //编辑结束后  1-保存编辑值  2-检查编辑值是否有重复


            //DataGridViewRow row = this.gvRoadTest.Rows[e.RowIndex];

            //if (this.gvRoadTest.Columns["Order"].DisplayIndex == e.ColumnIndex)
            //{
            //    //row.Cells["checkbox"].Value = true;

            //    int order = Convert.ToInt32(row.Cells["Order"].Value);
            //    if (this.IsRepeatOrder(order, row.Index))
            //    {
            //        Alert.Show("该顺序号已存在，请重新输入");

            //        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
            //        checkCell.Value = false;
            //        checkCell.ReadOnly = true;
            //        row.Cells["Order"].Style.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
            //        checkCell.ReadOnly = false;
            //        row.Cells["Order"].Style.BackColor = Color.Empty;
            //    }
            //    //DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
            //    //checkCell.Value = true;


            //}
        }




        // This event handler manually raises the CellValueChanged event
        // by calling the CommitEdit method.

        void dataGridView_CurrentCellDirtyStateChanged(object sender,
            EventArgs e)
        {
            if (gvRoadTest.IsCurrentCellDirty)
            {
                gvRoadTest.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        public void dataGridView_CellValueChanged(object sender,
    DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.gvRoadTest.Rows[e.RowIndex];

            //if (this.gvRoadTest.Columns[e.ColumnIndex].Name == "checkbox")
            //{
            //    //Alert.Show(CurMaxOrder.ToString());
            //    //DataGridViewDisableButtonCell buttonCell =
            //    //    (DataGridViewDisableButtonCell)dataGridView1.
            //    //    Rows[e.RowIndex].Cells["Buttons"];

            //    DataGridViewCheckBoxCell checkCell =
            //        (DataGridViewCheckBoxCell)gvRoadTest.
            //        Rows[e.RowIndex].Cells["checkbox"];
            //    //buttonCell.Enabled = !(Boolean)checkCell.Value;
            //    bool cbValue = Convert.ToBoolean(checkCell.Value);
            //    // cbValue 为被点击后的状态值  !cbValue为点击前的状态值
            //    if (cbValue)
            //    {
            //        int cellOrderValue = Convert.ToInt32(row.Cells["Order"].Value);

            //        //string comptCodeValue=row.Cells["Dict_Code"].Value.ToString();

            //        //如果Order 为0 则表示为编辑数据值，则自动编排
            //        if (cellOrderValue == 0)
            //        {
            //            //序号更新
            //            cellOrderValue = GetOrder();
            //            row.Cells["Order"].Value = cellOrderValue;
            //        }

            //        //if (!CurNodeDict.ContainsKey(comptCodeValue))
            //        //{ 
            //        //    CurNodeDict.Add(comptCodeValue,cellOrderValue);
            //        //}

            //    }
            //    else
            //    {
            //        //string comptCodeValue = row.Cells["Dict_Code"].Value.ToString();

            //        //清除该行Order数据
            //        row.Cells["Order"].Value = 0;


            //    }
            //    //gvRoadTest.Invalidate();
            //}
        }

        /// <summary>
        /// 是否存在重复顺序序号
        /// </summary>
        /// <param name="order"></param>
        /// <param name="rowIndex">当前行号</param>
        /// <returns></returns>
        public bool IsRepeatOrder(int order, int rowIndex)
        {
            bool flag = false;
            foreach (DataGridViewRow row in this.gvRoadTest.Rows)
            {
                if (row.Index != rowIndex)
                {

                    int tmpCurOrder = Convert.ToInt32(row.Cells["Order"].Value);

                    if (order != 0 && order == tmpCurOrder)
                    {
                        flag = true;
                    }
                }

            }

            return flag;
        }

        /// <summary>
        /// 获取当前最新序号
        /// </summary>
        /// <returns></returns>
        public int GetOrder()
        {
            int tmpOrder = 0;

            foreach (DataGridViewRow row in this.gvRoadTest.Rows)
            {


                int tmpCurOrder = Convert.ToInt32(row.Cells["Order"].Value);

                if (tmpOrder <= tmpCurOrder)
                {
                    tmpOrder = tmpCurOrder;
                }

            }

            return tmpOrder + 10;

        }

    }
}
