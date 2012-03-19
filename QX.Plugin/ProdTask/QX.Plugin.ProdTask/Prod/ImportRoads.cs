using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.DataModel;
using System.Reflection;
using System.Collections;
using QX.Common.C_Class;
using QX.Common.C_Form;
namespace QX.Plugin.Prod
{
    public partial class ImportRoads : F_BasicPop
    {
        public ImportRoads()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 零件图号
        /// </summary>
        /// <param name="PartNo"></param>
        public ImportRoads(string partNo)
        {
            InitializeComponent();

            this.CurNodeDict = new Dictionary<string,int>();
            this.CurNodeTimeCostDict = new Dictionary<string,string>();
            PartNo = partNo;
            BindEvent();

            this.Load += new EventHandler(CommRoadNodes_Load);
        }


        public void BindEvent()
        {
            this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        #region Member

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private Dictionary<string, int> _CurNodeDict = new Dictionary<string, int>();
        /// <summary>
        /// 当前工艺节点列表
        /// </summary>
        public Dictionary<string, int> CurNodeDict
        {
            get { return _CurNodeDict; }
            set { _CurNodeDict = value; }
        }

        private Dictionary<string, string> _CurNodeTimeCostDict = new Dictionary<string, string>();
        public Dictionary<string, string> CurNodeTimeCostDict
        {
            get { return _CurNodeTimeCostDict; }
            set { _CurNodeTimeCostDict = value; }
        }


        private bool _IsChanged = false;

        public bool IsChanged
        {
            get { return _IsChanged; }
            set { _IsChanged = value; }
        }
        #endregion

        private void CommRoadNodes_Load(object sender, EventArgs e)
        {
            IsChanged = false;
            Init();
        }

        public void Init()
        {
            GridInit();
            NodeDataInit();
        }
        private string PartNo
        {
            get;
            set;
        }

        public void GridInit()
        {
            //List<Bse_Dict> list = dcInstance.GetListByDictKeyByNoRoot(DictKeyEnum.RoadNode);

            List<Road_Nodes> list = rnInstance.GetRoadNodesByComponents(PartNo);

            IBindingList bl = new BindingList<Road_Nodes>(list);

            this.gvRoadNodes.AutoGenerateColumns = false;

            this.gvRoadNodes.EditMode = DataGridViewEditMode.EditOnEnter;
            this.gvRoadNodes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.gvRoadNodes.MultiSelect = false;
            this.gvRoadNodes.ReadOnly = false;
            this.gvRoadNodes.Columns["RNodes_Code"].ReadOnly = true;
            this.gvRoadNodes.Columns["RNodes_Name"].ReadOnly = true;
            this.gvRoadNodes.Columns["RNodes_TimeCost"].Visible = true;
            this.gvRoadNodes.Columns["RNodes_Value"].Visible = true;
            this.gvRoadNodes.Columns["RNodes_TimeCost"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.gvRoadNodes.Columns["Order"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.gvRoadNodes.CellValueChanged += new DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);

            this.gvRoadNodes.CurrentCellDirtyStateChanged += new EventHandler(dataGridView_CurrentCellDirtyStateChanged);

            this.gvRoadNodes.CellEndEdit += new DataGridViewCellEventHandler(this.gvRoadNodes_CellEndEdit);

            this.gvRoadNodes.DataSource = bl;


        }

        public void SetTimeCostReadoly()
        {
            this.gvRoadNodes.Columns["RNodes_TimeCost"].ReadOnly = true;

            this.gvRoadNodes.Columns["RNodes_TimeCost"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public void NodeDataInit()
        {
            //foreach (DataGridViewRow row in this.gvRoadNodes.Rows)
            //{
            //    //获取当前行对应的工艺编号
            //    string dictCode = row.Cells["Dict_Code"].Value.ToString();

            //    ////默认每行的Order均为0
            //    row.Cells["Order"].Value = 0;

            //    if (!string.IsNullOrEmpty(dictCode) && CurNodeDict.ContainsKey(dictCode) && CurNodeTimeCostDict.ContainsKey(dictCode))
            //    {

            //        int tmpOrder = Convert.ToInt32(CurNodeDict[dictCode]);

            //        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
            //        checkCell.Value = true;

            //        row.Cells["Order"].Value = tmpOrder;

            //        row.Cells["TimeCost"].Value = CurNodeTimeCostDict[dictCode];
            //    }

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsChanged = false;
            ImportRoadNodes();

            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            IsChanged = true;

            ImportRoadNodes();

            this.Close();
        }

        //导入生产工艺路线
        private void ImportRoadNodes()
        {
            Dictionary<string, int> nodesDict = new Dictionary<string, int>();
            Dictionary<string, string> timeCostDict = new Dictionary<string, string>();

            foreach (DataGridViewRow row in this.gvRoadNodes.Rows)
            {
                string nodeCode = row.Cells["RNodes_Code"].Value.ToString();

                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
                bool cbValue = Convert.ToBoolean(checkCell.Value);
                //遍历获取选中的工艺节点
                if (cbValue)
                {

                    string timeCost = row.Cells["RNodes_TimeCost"].Value == null ? "0" : row.Cells["RNodes_TimeCost"].Value.ToString();

                    int order = Convert.ToInt32(row.Cells["Order"].Value);

                    if (!nodesDict.ContainsKey(nodeCode) && !timeCostDict.ContainsKey(nodeCode))
                    {
                        nodesDict.Add(nodeCode, order);
                        timeCostDict.Add(nodeCode, timeCost);
                    }
                }

            }
            //更新当前工艺节点列表
            CurNodeDict = nodesDict;
            CurNodeTimeCostDict = timeCostDict;
            //IsChanged = true;
        }


        private void gvRoadNodes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //编辑结束后  1-保存编辑值  2-检查编辑值是否有重复


            DataGridViewRow row = this.gvRoadNodes.Rows[e.RowIndex];

            if (this.gvRoadNodes.Columns["Order"].DisplayIndex == e.ColumnIndex)
            {
                //row.Cells["checkbox"].Value = true;

                int order = Convert.ToInt32(row.Cells["Order"].Value);
                if (this.IsRepeatOrder(order, row.Index))
                {
                    Alert.Show("该顺序号已存在，请重新输入");

                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
                    checkCell.Value = false;
                    checkCell.ReadOnly = true;
                    row.Cells["Order"].Style.BackColor = Color.Red;
                }
                else
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
                    checkCell.ReadOnly = false;
                    row.Cells["Order"].Style.BackColor = Color.Empty;
                }
                //DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["checkbox"];
                //checkCell.Value = true;


            }
        }




        // This event handler manually raises the CellValueChanged event
        // by calling the CommitEdit method.

        void dataGridView_CurrentCellDirtyStateChanged(object sender,
            EventArgs e)
        {
            if (gvRoadNodes.IsCurrentCellDirty)
            {
                gvRoadNodes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        public void dataGridView_CellValueChanged(object sender,
    DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gvRoadNodes.Rows[e.RowIndex];

            if (this.gvRoadNodes.Columns[e.ColumnIndex].Name == "checkbox")
            {
                //Alert.Show(CurMaxOrder.ToString());
                //DataGridViewDisableButtonCell buttonCell =
                //    (DataGridViewDisableButtonCell)dataGridView1.
                //    Rows[e.RowIndex].Cells["Buttons"];

                DataGridViewCheckBoxCell checkCell =
                    (DataGridViewCheckBoxCell)gvRoadNodes.
                    Rows[e.RowIndex].Cells["checkbox"];
                //buttonCell.Enabled = !(Boolean)checkCell.Value;
                bool cbValue = Convert.ToBoolean(checkCell.Value);
                // cbValue 为被点击后的状态值  !cbValue为点击前的状态值
                if (cbValue)
                {
                    int cellOrderValue = Convert.ToInt32(row.Cells["Order"].Value);

                    //string comptCodeValue=row.Cells["Dict_Code"].Value.ToString();

                    //如果Order 为0 则表示为编辑数据值，则自动编排
                    if (cellOrderValue == 0)
                    {
                        //序号更新
                        cellOrderValue = GetOrder();
                        row.Cells["Order"].Value = cellOrderValue;
                    }

                    //if (!CurNodeDict.ContainsKey(comptCodeValue))
                    //{ 
                    //    CurNodeDict.Add(comptCodeValue,cellOrderValue);
                    //}

                }
                else
                {
                    //string comptCodeValue = row.Cells["Dict_Code"].Value.ToString();

                    //清除该行Order数据
                    row.Cells["Order"].Value = 0;


                }
                //gvRoadNodes.Invalidate();
            }
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
            foreach (DataGridViewRow row in this.gvRoadNodes.Rows)
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

            foreach (DataGridViewRow row in this.gvRoadNodes.Rows)
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
