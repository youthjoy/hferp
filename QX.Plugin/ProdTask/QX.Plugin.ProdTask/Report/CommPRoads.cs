using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;

namespace QX.Plugin.Prod.Report
{
    public partial class CommPRoads : F_BasicPop
    {

        public CommPRoads()
        {
            InitializeComponent();
        }

        public CommPRoads(string data)
        {
            InitializeComponent();

            DataCode = data;

            this.tbGrid.RefreshClicked += new EventHandler(tbGrid_RefreshClicked);

            this.Load += new EventHandler(ComDict_Load);
        }

        void tbGrid_RefreshClicked(object sender, EventArgs e)
        {
            uGridPlanNodeBind();
        }

        private void ComDict_Load(object sender, EventArgs e)
        {
            uGridPlanNodeInit();
        }

        #region 工艺路线列表

        /// <summary>
        /// 任务编码
        /// </summary>
        public string TaskCode
        {
            get;
            set;
        }

        public string DataCode
        {
            get;
            set;
        }

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        UltraGrid uGridPlanNodes = new UltraGrid();

        private Dictionary<string, string> PlanNodeDicColumn = new Dictionary<string, string>();


        public void uGridPlanNodeInit()
        {
            uGridPlanNodeInitColumn();
            uGridPlanNodeBind();
            //uGridPlanNodeEventInit();
        }






        private void uGridPlanNodeInitColumn()
        {
            GridHelper gen = new GridHelper();

            List<Prod_Roads> list = new List<Prod_Roads>();

            uGridPlanNodes = gen.GenerateGrid("GRProdRoads", this.pnlGrid, new Point(0, 0));

            uGridPlanNodes.DataSource = list;
            gen.SetGridReadOnly(uGridPlanNodes, true);
            //PlanNodeHandler.SetGridEditMode(true, uGridPlanNodes);
            uGridPlanNodes.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
        }

        public void uGridPlanNodeBind()
        {
            var list = prInstance.GetPlanRoadListByPlanCode(DataCode);

            uGridPlanNodes.DataSource = list;
        }

       

      


        #endregion
    }
}
