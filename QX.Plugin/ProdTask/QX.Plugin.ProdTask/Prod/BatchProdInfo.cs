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
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;
using QX.Plugin.Prod.Report;
using QX.Shared;

namespace QX.Plugin.Prod
{
    public partial class BatchProdInfo : Form
    {
        public BatchProdInfo()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_load);

            BindEvent();
        }

        #region 句柄声明

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        #endregion

        void Form_load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindEvent()
        {
            this.tool_bar.AddClicked += new EventHandler(tool_bar_AddClicked);
            this.tool_bar.SaveClicked += new EventHandler(tool_bar_SaveClicked);
        }

        void tool_bar_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Alert.Show("数据更新成功!");
            }
        }

        public bool SaveData()
        {
            StringBuilder sb = new StringBuilder();
            List<Prod_Roads> list = new List<Prod_Roads>();
            foreach (var row in this.comGrid.Rows)
            {
                Prod_Roads pr = row.ListObject as Prod_Roads;
                if (!list.Exists(o => o.PRoad_ID == pr.PRoad_ID))
                {
                    try
                    {
                        if (pr.PRoad_TimeCost != 0)
                        {
                            var temp = pr.PRoad_ActETime - pr.PRoad_ActBTime;
                            //实际工时
                            pr.PRoad_CostTime = Convert.ToDecimal(temp.TotalHours);
                            pr.PRoad_Udef1 = (pr.PRoad_CostTime - pr.PRoad_TimeCost).ToString();
                        }
                    }
                    catch
                    {

                    }
                    list.Add(pr);
                    sb.Append(pr.PRoad_ProdCode).Append(',');
                }
            }

            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().BatchProdInfo + "(" + sb.ToString() + ")"
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.ProdRecordModule.ToString(), QX.Common.LogType.Edit.ToString());

            prInstance.UpdateNodeList(list);

            return true;

        }

        /// <summary>
        /// 工序选择回调事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="list"></param>
        void handleForm_CallBack(object sender, List<Prod_Roads> list)
        {
            if (list != null)
            {
                foreach (var d in list)
                {
                    if (d != null)
                    {
                        var newrow = this.comGrid.DisplayLayout.Bands[0].AddNew();
                        PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(Prod_Roads));

                        foreach (UltraGridCell cell in newrow.Cells)
                        {
                            if (cell.Column.IsBound)
                            {
                                object value = pc[cell.Column.Key].GetValue(d);
                                if (value != null)
                                {
                                    newrow.Cells[cell.Column.Key].Value = value;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 零件工序选择窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tool_bar_AddClicked(object sender, EventArgs e)
        {
            CommInfoHandle handleForm = new CommInfoHandle();
            handleForm.CallBack += new CommInfoHandle.DCallBackHandler(handleForm_CallBack);
            handleForm.Show();
        }

        public UltraGrid comGrid = new UltraGrid();
        GridHelper gen = new GridHelper();

        /// <summary>
        /// 数据绑定
        /// </summary>
        public void BindData()
        {

            TimeControlMapInit();

            comGrid = gen.GenerateGrid("CList_BatchUpdate", this.panel1, new Point(0, 0));
            gen.SetExcelStyleFilter(comGrid);
            List<Prod_Roads> list = new List<Prod_Roads>();
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            comGrid.DataSource = dataSource;

            comGrid.AfterExitEditMode += new EventHandler(comGrid_AfterExitEditMode);
            comGrid.BeforeEnterEditMode += new CancelEventHandler(comGrid_BeforeEnterEditMode);
            comGrid.BeforeCellListDropDown += new CancelableCellEventHandler(comGrid_BeforeCellListDropDown);
            
        }

        /// <summary>
        /// 判断是否点击了时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comGrid_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell cell = this.comGrid.ActiveCell;
            if (cell != null)
            {

                string key = cell.Column.Key;
                switch (key)
                {
                    case "PRoad_ConfirmPep":
                        Bll_Dept bllDept = new Bll_Dept();
                        Bll_Bse_Employee bllEmp = new Bll_Bse_Employee();
                        CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee> user =
                            new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>(bllDept, bllEmp, new Size(460, 380));
                        user.CallBack += new CommUser<Bll_Dept, Bll_Bse_Employee, Bse_Department, Bse_Employee>.DCallBackHandler(user_CallBack);
                        user.ShowDialog();
                        e.Cancel = true;
                        break;
                    case "PRoad_EquCode":

                        break;
                }
            }
        }

        void comGrid_AfterExitEditMode(object sender, EventArgs e)
        {
            UltraGridCell cell = this.comGrid.ActiveCell;
            if (cell != null)
            {

                string key = cell.Column.Key;
                switch (key)
                {
                    case "PRoad_EquCode":
                        BindCellData(cell.Row, key, cell.Value);
                        BindCellData(cell.Row, "PRoad_EquName", cell.Row.Cells["PRoad_EquName"].Value);
                        break;
                    case "": break;
                }
            }
        }

        void comGrid_CellChange(object sender, CellEventArgs e)
        {
            if (e.Cell != null)
            {

            }
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="list"></param>
        private void user_CallBack(object sender, DataTable list)
        {
            UltraGridCell cell = this.comGrid.ActiveCell;
            if (list == null)
            {


                if (cell != null)
                {
                    cell.Value = string.Empty;
                }
            }
            else if (list.Rows.Count == 1)
            {

                if (cell != null)
                {
                    cell.Value = list.Rows[0]["Emp_Code"] != null ? list.Rows[0]["Emp_Code"].ToString() : string.Empty;
                    BindCellData(cell.Row, cell.Column.Key, cell.Value);
                }
            }


        }

        /// <summary>
        /// 时间控件初始化
        /// </summary>
        private List<string> TimeControlMap
        {
            get;
            set;
        }

        private void TimeControlMapInit()
        {
            Bll_Sys_Map mapInst = new Bll_Sys_Map();
            var map = mapInst.GetModel(string.Format(" AND Map_Module='{0}' And Map_Source='{0}'", "RecordTime"));
            TimeControlMap = map.Map_Object1.Split(',').ToList();
        }

        void comGrid_BeforeCellListDropDown(object sender, CancelableCellEventArgs e)
        {
            var cell = e.Cell;
            if (TimeControlMap.Contains(cell.Column.Key))
            {
                var t = e.Cell.Value.ToString();
                string time = string.Empty;
                if (!t.Contains("0001"))
                {
                    time = t;
                }

                TimeControl controlTime = new TimeControl(cell.Column.Key, time);
                controlTime.CallBack += new TimeControl.DCallBackHandler(userTimeSelect_CallBack);
                //controlTime.Location = new Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                controlTime.ShowWin(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void userTimeSelect_CallBack(string key, object val)
        {
            UltraGridRow row = this.comGrid.ActiveRow;
            if (row != null && row.Cells.Exists(key))
            {
                row.Cells[key].Value = val;
                Prod_Roads pr = row.ListObject as Prod_Roads;
                if (key == "PRoad_ActETime")
                {
                    BindCellData(row, key, val);
                    BindCellData(row, "PRoad_ActBTime", val);

                    try
                    {
                        var temp = pr.PRoad_ActETime - pr.PRoad_ActBTime;
                        //实际工时
                        pr.PRoad_CostTime = Convert.ToDecimal(temp.TotalHours);
                        BindCellData(row, "PRoad_CostTime", pr.PRoad_CostTime);

                        pr.PRoad_Udef1 = (pr.PRoad_CostTime - pr.PRoad_TimeCost).ToString();
                        BindCellData(row, "PRoad_Udef1", pr.PRoad_Udef1);
                    }
                    catch (Exception ex)
                    { }
                }

            }

        }

        //private void TimeCalc()
        //{
        //    switch (key)
        //    {

        //        case "PRoad_ActBTime":
        //            {
        //                Prod_Roads road = row.ListObject as Prod_Roads;

        //                DateTime bDate = road.PRoad_ActBTime;
        //                DateTime eDate = road.PRoad_ActETime;

        //                TimeSpan ts = eDate - bDate;
        //                //if (ts.TotalHours > 0)
        //                //{
        //                row.Cells["PRoad_CostTime"].Value = ts.TotalHours;
        //                //}
        //                TimeUpdate(road, row);
        //                break;

        //            }//实际完工时间
        //        case "PRoad_ActETime":
        //            {
        //                Prod_Roads road = row.ListObject as Prod_Roads;

        //                DateTime bDate = road.PRoad_ActBTime;
        //                DateTime eDate = road.PRoad_ActETime;

        //                TimeSpan ts = eDate - bDate;
        //                //if (ts.TotalHours > 0)
        //                //{
        //                //实际工作时间 
        //                double hour = ts.TotalHours;
        //                row.Cells["PRoad_CostTime"].Value = ts.TotalHours;
        //                //}
        //                TimeUpdate(road, row);
        //                break;
        //            }//实际开工时间
        //    }
        //}

        private void BindCellData(UltraGridRow row, string key, object val)
        {
            for (int i = row.Index + 1; i < this.comGrid.Rows.Count; i++)
            {
                this.comGrid.Rows[i].Cells[key].Value = val;
            }
        }



    }
}
