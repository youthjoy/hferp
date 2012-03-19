using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.DataModel;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Class;

using QX.Common.C_Form;

namespace QX.Plugin.Prod.Component
{
    public partial class CompOpLog :F_BasciForm
    {


        public CompOpLog()
        {
            InitializeComponent();

            this.Load += new EventHandler(DFailureMain_Load);

            BindTopTool();
        }

        public CompOpLog(string data)
        {
            InitializeComponent();

            string[] s = data.Split('|');

            if (s.Length == 1)
            {
                ModuleCode = s[0];
                FormModule = "CList_OpLog";
            }
            else
            {
                ModuleCode = s[0];
                FormModule = s[1];
            }

            //ModuleCode = data;
            this.Load += new EventHandler(DFailureMain_Load);
  
            BindTopTool();
        }

        private string FormModule
        {
            get;
            set;
        }

        private string ModuleCode
        {
            get;
            set;
        }

        void DFailureMain_Load(object sender, EventArgs e)
        {
            //待审核
            this.ug_listLog = gridHelper.GenerateGrid(FormModule, this.pnlGrid, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listLog, true);

            BindDataToGrid();
        }


        #region 窗体单例

        public static CompOpLog NewForm = null;



        public static CompOpLog Instance(string code)
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new CompOpLog(code);
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        UltraGrid ug_listLog = new UltraGrid();//设备故障列表


        GridHelper gridHelper = new GridHelper();

        BLL.Bll_Operation opInstance = new QX.BLL.Bll_Operation();


        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        private void BindDataToGrid()
        {

            List<Bse_OpLog> list = new List<Bse_OpLog>();
            list = opInstance.GetOpLog(ModuleCode);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            ug_listLog.DataSource = dataSource;

        }

        public void BindTopTool()
        {

            tbGrid.RefreshClicked += new EventHandler(tbGrid_RefreshClicked);

        }


        void tbGrid_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }






    }
}
