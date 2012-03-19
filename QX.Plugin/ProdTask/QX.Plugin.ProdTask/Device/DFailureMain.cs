using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Framework.AutoForm;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.Plugin.Prod.Prod;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace QX.Plugin.DeviceManage
{
    public partial class DFailureMain : F_BasciForm
    {
        public DFailureMain()
        {
            InitializeComponent();

            this.Load += new EventHandler(DFailureMain_Load);

            BindTopTool();
        }

        void DFailureMain_Load(object sender, EventArgs e)
        {
            //待审核
            this.ug_listDF = gridHelper.GenerateGrid("CList_Failure", this.pnlList, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listDF, true);


            //历史
            this.ug_listHis = gridHelper.GenerateGrid("CList_Failure", this.pnlHis, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listHis, true);

            BindDataToGrid();
        }


        #region 窗体单例

        public static DFailureMain NewForm = null;



        public static DFailureMain Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new DFailureMain();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        UltraGrid ug_listDF = new UltraGrid();//设备故障列表

        UltraGrid ug_listHis = new UltraGrid();

        GridHelper gridHelper = new GridHelper();

        BLL.Bll_Bse_Equ equInstance = new QX.BLL.Bll_Bse_Equ();


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

            List<Prod_Failure> list_inv = new List<Prod_Failure>();
            list_inv = equInstance.GetPFailureList();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list_inv;
            ug_listDF.DataSource = dataSource;

            //历史记录
            List<Prod_Failure> list1 = new List<Prod_Failure>();
            list1 = equInstance.GetPFailureListHis();
            
            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list1;
            ug_listHis.DataSource = dataSource1;
        }

        private FormHelper fHelper = new FormHelper();

        public void BindTopTool()
        {
            tbGrid.AddClicked += new EventHandler(tbGrid_AddClicked);
            tbGrid.EditClicked += new EventHandler(tbGrid_EditClicked);
            tbGrid.RefreshClicked += new EventHandler(tbGrid_RefreshClicked);

            ToolStripHelper tsHelper = new ToolStripHelper();

            ToolStripButton batchBtn = tsHelper.New("批量停机", QX.Common.Properties.Resources.batch, new EventHandler(batchBtn_Click));
            //batchBtn.Click += new EventHandler(batchBtn_Click);
            tbGrid.AddCustomControl(batchBtn);



            this.tbHis.RefreshClicked += new EventHandler(tbHis_RefreshClicked);
            ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(exportBtn_Click));
            
            tbHis.AddCustomControl(exportBtn);


            fHelper.PermissionControl(this.tbGrid.toolStrip1.Items, PermissionModuleEnum.DeviceFailOp.ToString());
        }

        void exportBtn_Click(object sender, EventArgs e)
        {
            if (ug_listHis.Rows.Count <= 0)
            {
                Alert.Show("现阶段没有数据可以导出!");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "导出文件保存路径";
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                string file = saveFileDialog.FileName;
                UltraGridExcelExporter export = new UltraGridExcelExporter();
                export.Export(this.ug_listHis, file);
                Alert.Show("导出完成!");
            }
        }

        void batchBtn_Click(object sender, EventArgs e)
        {
            BatchEleMain eleMain = new BatchEleMain();
            eleMain.ShowDialog();
        }

        void tbHis_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        void tbGrid_EditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listDF.ActiveRow;
            if (row != null)
            {
                Prod_Failure pf = row.ListObject as Prod_Failure;

                DFailureOp DFailureFrm = new DFailureOp(equInstance, pf);
                DFailureFrm.OperationType = OperationTypeEnum.OperationType.Edit;
                DFailureFrm.ShowDialog();

                BindDataToGrid();

            }
        }

        void tbGrid_AddClicked(object sender, EventArgs e)
        {
            DFailureOp DFailureFrm = new DFailureOp(equInstance, null);
            DFailureFrm.OperationType = OperationTypeEnum.OperationType.Add;
            DFailureFrm.ShowDialog();

            BindDataToGrid();

        }

        void tbGrid_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }




        private void RefreshHitory()
        {
            //List<Failure_Information> list_raw = new List<Failure_Information>();
            //list_raw = equInstance.GetFailureInforList();
            //BindingSource dataSource1 = new BindingSource();
            //dataSource1.DataSource = list_raw;
            //ug_listInList.DataSource = dataSource1;
        }




    }
}
