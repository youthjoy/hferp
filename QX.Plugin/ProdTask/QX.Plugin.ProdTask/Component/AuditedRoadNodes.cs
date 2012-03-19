using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.BLL;
using QX.Common.C_Class;
using QX.DataModel;
using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;

namespace QX.Plugin.RoadCateManage
{
    public partial class AuditedRoadNodes : Form
    {
        public AuditedRoadNodes()
        {
            InitializeComponent();
        }

        public AuditedRoadNodes(string rcCode)
        {
            InitializeComponent();

            this.RoadComptCode = rcCode;
        }

        private void AuditedRoadNodes_Load(object sender, EventArgs e)
        {
            Init();
        }



        #region Member

        private Bll_Road_Components rcInstance = new Bll_Road_Components();

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private Bll_Road_TestRef rtInstance = new Bll_Road_TestRef();

        private Bll_Dept deptInstance = new Bll_Dept();

        private string _roadComptCode;
        /// <summary>
        /// 当前对应的零件图号
        /// </summary>
        public string RoadComptCode
        {
            get { return _roadComptCode; }
            set { _roadComptCode = value; }
        }



        private GridHandler _gHanlder;
        /// <summary>
        /// UltraGrid Helper
        /// </summary>
        public GridHandler gHandler
        {
            get { return _gHanlder; }
            set { _gHanlder = value; }
        }


        private Dictionary<string, string> _rnDicColumn;
        /// <summary>
        /// Grid控件显示列
        /// </summary>
        public Dictionary<string, string> RNDicColumn
        {
            get { return _rnDicColumn; }
            set { _rnDicColumn = value; }
        }

        private Dictionary<string, string> RTDicColumn = new Dictionary<string, string>();

        private List<Road_Nodes> _CurGridDataSource;

        public List<Road_Nodes> CurGridDataSource
        {
            get { return _CurGridDataSource; }
            set { _CurGridDataSource = value; }
        }

        #endregion

        #region 数据初始化


        public void Init()
        {
            GridInit();
        }

        public void GridRefresh()
        {

            //GridEventInit();
            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);
            this.gHandler.BindData(CurGridDataSource, RNDicColumn, false);
            AddCustomizeColumn();
        }

        private void GridEventInit()
        {
            #region ultragrid

            //this.uGridRNodes.BeforeEnterEditMode += new CancelEventHandler(uGridRNodes_BeforeEnterEditMode);

            //this.uGridRNodes.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(uGridRNodes_ClickCellButton);

            #endregion
        }

        void uGridRNodes_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            throw new NotImplementedException();
        }

        void uGridRNodes_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void GridInit()
        {

            CurGridDataSource = rnInstance.GetRoadNodesByComponents(RoadComptCode);

            List<Road_TestRef> rtList = rtInstance.GetTestRefList(RoadComptCode);

            gHandler = new GridHandler(this.uGridRNodes);

            RNDicColumn = new Dictionary<string, string>();
            //DicColumn.Add("RNodes_PartCode", "零件图号");
            RNDicColumn.Add("RNodes_Name", "工艺名称");
            RNDicColumn.Add("RNodes_Code", "工艺编码");
            RNDicColumn.Add("RNodes_Order", "工艺节点顺序");
            RNDicColumn.Add("RNodes_Dept_Name", "生产部门");
            RNDicColumn.Add("RNodes_TimeCost", "生产所需时间(小时)");
            RNDicColumn.Add("RNodes_Class_Name", "班组名称");
            //RNDicColumn.Add("RNodes_Class_Name", "班组名称");
            RNDicColumn.Add("RNodes_Cost", "成本价格");
            ////this.gHandler.BindData<Road_Nodes>(CurGridDataSource, false);


            RTDicColumn.Add("TestRef_Name", "检测参数名称");
            RTDicColumn.Add("TestRef_Value", "检测参考值");
            RTDicColumn.Add("TestRef_High", "检测上限");
            RTDicColumn.Add("TestRef_Low", "检测下限");


            // Declare DataSet to contain Hierarchical data
            DataSet dataSet = new DataSet();


            if (CurGridDataSource.Count > 0 && rtList.Count > 0)
            {
                DataTable rnDt = ConvertX.ToDataTable<Road_Nodes>(CurGridDataSource);
                rnDt.TableName = "Road_Nodes";

                DataTable rtDt = ConvertX.ToDataTable<Road_TestRef>(rtList);
                rtDt.TableName = "Road_TestRef";

                dataSet.Tables.Add(rnDt);
                dataSet.Tables.Add(rtDt);

                DataRelation relNodeTestRef = new DataRelation("RT"
                  , dataSet.Tables["Road_Nodes"].Columns["RNodes_Code"]
                  , dataSet.Tables["Road_TestRef"].Columns["TestRef_RNodeCode"]);

                dataSet.Relations.Add(relNodeTestRef);

                gHandler.BindHierarchicalData(dataSet, RNDicColumn, RTDicColumn);


            }
            else
            {
                gHandler.BindData(CurGridDataSource, RNDicColumn);
            }

            gHandler.SetDefaultStyle();
            //gHandler.SetExcelStyleFilter();

        }

        /// <summary>
        /// 添加自定义列
        /// </summary>
        public void AddCustomizeColumn()
        {
            //    this.uGridTemlate.DisplayLayout.Bands[0].Columns.Add("TestRef", "");
            //    UltraGridColumn col = this.uGridTemlate.DisplayLayout.Bands[0].Columns["TestRef"];

            //    col.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;

            //    col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            //    col.Width = 18;
            //    col.DataType = typeof(object);
            //    Image image = global::QX.Plugin.RoadCateManage.Properties.Resources.edit;　　　　//从资源文件中引用
            //    col.CellButtonAppearance.Image = image;
            //    //col.NullText = "0";
            //    //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            //    //col.DataType = typeof(bool);
            //    col.DefaultCellValue = "";
            //    //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            //    col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never;
            //    col.AllowRowFiltering = DefaultableBoolean.False;
            //    //col.Swap(this.uGridTemlate.DisplayLayout.Bands[0].Columns[0]);
            //    col.CellClickAction = CellClickAction.Edit;
        }

        #endregion
    }
}
