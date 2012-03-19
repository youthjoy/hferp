using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.BLL;
using QX.Framework.AutoForm;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Class;
using QX.Common.C_Form;
namespace QX.BseDict
{
    public partial class SetNodeChecked : F_BasicPop
    {
        public SetNodeChecked(Prod_Roads nodes)
        {
            InitializeComponent();

            ProdRoad = nodes;

            IsPass = false;

            EventInit();
        }

        private Prod_Roads ProdRoad
        {
            get;
            set;
        }

        public bool IsPass
        {
            get;
            set;
        }

        private void SetNodeChecked_Load(object sender, EventArgs e)
        {
            InitData();
        }


        public delegate void DCallBackHandler(bool re, Prod_Roads pr, List<Road_TestRef> list);

        public event DCallBackHandler CallBack;

        public void EventInit()
        {
            ToolStripButton pOKBtn = new ToolStripHelper().New("合格"
    , QX.Common.Properties.Resources.OK, new EventHandler(pOKBtn_Click));
            this.commonToolBar1.AddCustomControl(pOKBtn);

            ToolStripButton setWrongBtn = new ToolStripHelper().New("不合格"
, QX.Common.Properties.Resources.delete, new EventHandler(setWrongBtn_Click));

            this.commonToolBar1.AddCustomControl(setWrongBtn);

        }

        void setWrongBtn_Click(object sender, EventArgs e)
        {

            IsPass = false;
            if (CallBack != null)
            {
                List<Road_TestRef> list = GetTestRef();
                CallBack(false, ProdRoad, list);
                this.Close();
            }
        }

        void pOKBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private List<Road_TestRef> GetTestRef()
        {
            List<Road_TestRef> list = new List<Road_TestRef>();
            foreach (UltraGridRow row in this.comGrid.Rows)
            {
                Road_TestRef t = row.ListObject as Road_TestRef;
                list.Add(t);
            }
            return list;
        }

        private void SaveData()
        {
            IsPass = true;
            if (CallBack != null)
            {

                List<Road_TestRef> list = GetTestRef();
                CallBack(true, ProdRoad, list);
                this.Close();
            }
        }

        private void InitData()
        {
            GridInit();
        }


        UltraGrid comGrid = new UltraGrid();

        private Bll_Road_TestRef trInstance = new Bll_Road_TestRef();

        private void GridInit()
        {
            GridHelper gen = new GridHelper();

            List<Road_TestRef> list = new List<Road_TestRef>();
            //获取当前工艺节点需要审核的检测参数
            list = trInstance.GetTestRefListByNodeCode(ProdRoad.PRoad_CompCode, ProdRoad.PRoad_NodeCode);

            comGrid = gen.GenerateGrid("GTestRef", this.panel1, new Point(0, 0));

            BindingSource dataSource = new BindingSource();

            dataSource.DataSource = list;

            comGrid.DataSource = dataSource;

            //SetGridEditMode(false, comGrid);

            comGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

            //列宽度自适应
            comGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;

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
