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
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using System.Collections;
using QX.Shared;

namespace QX.UI
{
    public partial class F_ToDo : F_BasciForm
    {
        public F_ToDo()
        {
            InitializeComponent();

            this.top_tool.RefreshClicked += new EventHandler(top_tool_RefreshClicked);

            this.Load += new EventHandler(F_ToDo_Load);

     
        }

        void top_tool_RefreshClicked(object sender, EventArgs e)
        {
            LoadGrid1();

            LoadGrid2();
        }

        private Bll_Comm instance = new Bll_Comm();

        UltraGrid ug_listA = new UltraGrid();

        UltraGrid ug_list1 = new UltraGrid();
        UltraGrid ug_list2 = new UltraGrid();
        UltraGrid ug_list3 = new UltraGrid();
        UltraGrid ug_list4 = new UltraGrid();

        public OperationTypeEnum.OperationType OpType
        {
            get;
            set;
        }


        public string ProdCode
        {
            get;
            set;
        }

        void F_ToDo_Load(object sender, EventArgs e)
        {
            GridHelper grid = new GridHelper();
            ug_listA = grid.GenerateGrid("CList_ToDoAudit", pnlAudit, new Point(6, 20));
            
            grid.SetGridReadOnly(ug_listA, true);
            grid.SetGridColumnStyle(ug_listA, AutoFitStyle.ExtendLastColumn);

            ug_list1 = grid.GenerateGrid("CList_ToDoPlan", pnlProd, new Point(6, 20));
            //ug_list1.DisplayLayout.LoadStyle = LoadStyle.LoadOnDemand;
            grid.SetGridColumnStyle(ug_list1, AutoFitStyle.ExtendLastColumn);
            grid.SetGridReadOnly(ug_list1, true);


            ug_list2 = grid.GenerateGrid("CList_ToDoProd", panel1, new Point(6, 20));
            //ug_list2.DisplayLayout.LoadStyle = LoadStyle.LoadOnDemand;
            grid.SetGridReadOnly(ug_list2, true);
            grid.SetGridColumnStyle(ug_list2, AutoFitStyle.ExtendLastColumn);


            ug_list3 = grid.GenerateGrid("CList_ToDoOut", panel2, new Point(6, 20));
            //ug_list3.DisplayLayout.LoadStyle = LoadStyle.LoadOnDemand;
            grid.SetGridReadOnly(ug_list3, true);
            grid.SetGridColumnStyle(ug_list3, AutoFitStyle.ExtendLastColumn);


            ug_list4 = grid.GenerateGrid("CList_ToDoUnQ", panel3, new Point(6, 20));
            //ug_list4.DisplayLayout.LoadStyle = LoadStyle.LoadOnDemand;
            grid.SetGridColumnStyle(ug_list4, AutoFitStyle.ExtendLastColumn);
            grid.SetGridReadOnly(ug_list4, true);


            LoadGrid1();
            LoadGrid2();
        }

        #region 绑定工具栏及事件

        public void BindTopTool()
        {
            switch (OpType)
            {
                case OperationTypeEnum.OperationType.Look:

                    break;

                case OperationTypeEnum.OperationType.Edit:
                    //搜索按钮

                    break;
            }



        }

        #endregion


        private void LoadGrid1()
        {
            //List<Prod_TestRef> list = new List<Prod_TestRef>();
            //list = instance.GetTestRefList(ProdCode);
            //CurDataSource = list;
            //ug_listA.DataSource = list;

            DataTable dt = new DataTable();
            Dictionary<string, object> array = new Dictionary<string, object>();
            array.Add("UserCode",SessionConfig.UserCode);
            array.Add("Module", "ToAudit");
            dt=instance.GetDataTablebyProc("qx_sp_todo", array);
            ug_listA.DataSource = dt;
        }


        private void LoadGrid2()
        {

            DataTable dt = new DataTable();
            Dictionary<string, object> array = new Dictionary<string, object>();
            array.Add("UserCode", SessionConfig.UserCode);
            array.Add("Module", "Plan");
            dt = instance.GetDataTablebyProc("qx_sp_todo", array);
            ug_list1.DataSource = dt;

            DataTable dt2= new DataTable();
            Dictionary<string, object> array2 = new Dictionary<string, object>();
            array2.Add("UserCode", SessionConfig.UserCode);
            array2.Add("Module", "Prod");
            dt2 = instance.GetDataTablebyProc("qx_sp_todo", array2);
            ug_list2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            Dictionary<string, object> array3= new Dictionary<string, object>();
            array3.Add("UserCode", SessionConfig.UserCode);
            array3.Add("Module", "Outing");
            dt3 = instance.GetDataTablebyProc("qx_sp_todo", array3);
            ug_list3.DataSource = dt2;

            DataTable dt4 = new DataTable();
            Dictionary<string, object> array4 = new Dictionary<string, object>();
            array4.Add("UserCode", SessionConfig.UserCode);
            array4.Add("Module", "Unqualified");
            dt4 = instance.GetDataTablebyProc("qx_sp_todo", array4);
            ug_list4.DataSource = dt4;
        }

        private void RefreshGrid()
        {
      
        }
    }
}
