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
using Infragistics.Win.UltraWinGrid;
using QX.BLL;
using QX.Framework.AutoForm;
using QX.Shared;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using QX.Plugin.Contract.ComControl;

namespace QX.Plugin.Contract
{
    public partial class ContractTrace : F_BasicPop
    {
        public ContractTrace()
        {
            InitializeComponent();
        }

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        private SD_Contract GModel = new SD_Contract();
        private Bll_SD_Contract mainInstance = new Bll_SD_Contract();
        private Bll_SD_CDetail detailInstance = new Bll_SD_CDetail();
        private Bll_ContractManage instance = new Bll_ContractManage();

        public ContractTrace(SD_Contract contract, OperationTypeEnum.OperationType op)
        {
            InitializeComponent();
            OperationType = op;
            GModel = contract;

            this.Load += new EventHandler(ContractTrace_Load);
        }

        void ContractTrace_Load(object sender, EventArgs e)
        {
            BindTopTool();
            this.btnSave.Click += new EventHandler(btnSave_Click);

            LoadWindowControl();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        public ContractTrace(SD_Contract contract, OperationTypeEnum.OperationType op, bool isAuditFlag)
        {
            InitializeComponent();
            this.isAudit = isAuditFlag;
            OperationType = op;
            GModel = contract;
            this.Load += new EventHandler(ContractTrace_Load);

      
        }


        public void BindTopTool()
        {
            //CommonToolBar toolBar = new CommonToolBar();
            //toolBar.Dock = DockStyle.Top;
            //this.Controls.Add(toolBar);
            ToolStripHelper TsHelper = new ToolStripHelper();
            //ToolStripButton importDetail = TsHelper.New("合同明细导入", QX.Common.Properties.Resources.import, new EventHandler(importDetail_Click));
            //toolBar.AddCustomControl(importDetail);


            //ToolStripButton exportDetail = TsHelper.New("合同明细导出", QX.Common.Properties.Resources.import, new EventHandler(exportDetail_Click));

            //toolBar.AddCustomControl(exportDetail);
            ////tool_bar_button.AddCustomControl(TsHelper.New("保存", global::QX.Common.Properties.Resources.save, tool_bar_button_SaveClicked));
            ////tool_bar_button.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));

            ToolStripButton prodSelBtn = TsHelper.New("零件选择", QX.Common.Properties.Resources.search, new EventHandler(prodSelBtn_Click));

            toolBar.AddCustomControl(prodSelBtn);
        }

        void prodSelBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_list.ActiveRow;
            if (row != null)
            {
                SD_CDetail detail = row.ListObject as SD_CDetail;
                TraceProdCodeSel prodSelFrm = new TraceProdCodeSel(detail);
                prodSelFrm.CallBack += new TraceProdCodeSel.DCallBackHandler(prodSelFrm_CallBack);
                prodSelFrm.ShowDialog();
            }
        }

        void prodSelFrm_CallBack(object sender, List<Prod_PlanProd> list)
        {
            BindingSource  source=ug_traceList.DataSource as BindingSource;
            IEnumerable<SD_ContractTrace> lll=source.List.Cast<SD_ContractTrace>();
            
            if (list != null && list.Count > 0)
            {
                foreach (var d in list)
                {
                    if (lll.FirstOrDefault(o => o.SDT_ProdCode == d.PlanProd_Code) != null)
                    {
                        continue;
                    }

                    var r = this.ug_traceList.DisplayLayout.Bands[0].AddNew();
                    var temp=r.ListObject as SD_ContractTrace;

                    temp.SDT_PartNo = d.PlanProd_PartNo;
                    temp.SDT_PartName = d.PlanProd_PartName;
                    temp.SDT_Owner = SessionConfig.UserCode;
                    temp.SDT_OwnerName = SessionConfig.EmpName;
                    temp.SDT_ODate = DateTime.Now;
                    temp.SDT_Num = 1;
                    temp.SDT_ProdCode=d.PlanProd_Code;
                    
                }
            }
        }

        void exportDetail_Click(object sender, EventArgs e)
        {
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
                //this.uGridExport.EndExport += new Infragistics.Win.UltraWinGrid.ExcelExport.EndExportEventHandler(uGridExport_EndExport);
                export.Export(this.ug_list, file);
            }
        }

        void importDetail_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
            //saveFileDialog.FilterIndex = 0;
            //saveFileDialog.RestoreDirectory = true;
            //saveFileDialog.CreatePrompt = true;
            //saveFileDialog.Title = "导出文件保存路径";
            //if (DialogResult.OK == saveFileDialog.ShowDialog())
            //{
            //    string file = saveFileDialog.FileName;
            //    this.uGridExcel.EndExport += new Infragistics.Win.UltraWinGrid.ExcelExport.EndExportEventHandler(uGridExcel_EndExport);
            //    this.uGridExcel.Export(this.ug_list, file);
            //}
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                string path = ofd.FileName;
                DataTable dataSource = ExcelHelper.Import(path);
                if (dataSource != null && dataSource.Rows.Count > 0)
                {
                    BindExcel(dataSource);
                }
                else
                {
                    Alert.Show("您导入的数据源为空,请确认后重新导入!");
                }
            }
        }



        private void BindExcel(DataTable dataSource)
        {
            List<SD_CDetail> list = new List<SD_CDetail>();
            foreach (DataRow dr in dataSource.Rows)
            {
                SD_CDetail d = new SD_CDetail();

                if (dr[1] != null)
                {
                    d.CDetail_Cmd = dr[1].ToString();
                }
                if (dr[2] != null)
                {
                    d.CDetail_Project = dr[2].ToString();
                }
                if (dr[3] != null)
                {
                    d.CDetail_PartName = dr[3].ToString();
                }
                if (dr[4] != null)
                {
                    d.CDetail_ProdCode = dr[4].ToString();
                }
                if (dr[5] != null)
                {
                    d.CDetail_PartNo = dr[5].ToString();
                }
                if (dr[6] != null)
                {
                    d.CDetail_Unit = dr[6].ToString();
                }
                if (dr[7] != null)
                {
                    d.CDetail_Num = Common.C_Class.Utils.TypeConverter.ObjectToInt(dr[7]);
                }
                if (dr[8] != null)
                {
                    d.CDetail_Price = Common.C_Class.Utils.TypeConverter.ObjectToDecimal(dr[8].ToString());
                }
                if (dr[9] != null)
                {
                    d.CDetail_Sum = Common.C_Class.Utils.TypeConverter.ObjectToDecimal(dr[9].ToString());
                }
                if (dr[10] != null)
                {
                    d.CDetail_NoTax = Common.C_Class.Utils.TypeConverter.ObjectToDecimal(dr[10].ToString());
                }
                if (dr[11] != null)
                {
                    d.CDetail_Intro = dr[11].ToString();
                }
                if (dr[12] != null)
                {

                    d.CDetail_Date = Common.C_Class.Utils.TypeConverter.ObjectToDateTime(dr[12].ToString());
                }

                list.Add(d);
            }

            BindingSource s = new BindingSource();
            s.DataSource = list;
            this.ug_list.DataSource = s;
        }


        #region 操作句柄
        //合同明细
        UltraGrid ug_list = new UltraGrid();

        UltraGrid ug_traceList = new UltraGrid();
        #endregion

        /// <summary>
        /// 读取窗体控件
        /// </summary>
        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            BindModelHelper bindHelper = new BindModelHelper();
            GridHelper gHelper = new GridHelper();
            List<SD_CDetail> rawDetailList = new List<SD_CDetail>();
            helper.GenerateForm("FContract", this.gpBasic, new Point(6, 20));

            switch (operationType)
            {
                //合同执行情况
                case OperationTypeEnum.OperationType.View:
                    {
                        gpBasic.Enabled = false;
                        ug_list = gHelper.GenerateGrid("CList_GCDetail", this.panel2, new Point(6, 20));
                        ug_list.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;

                        this.ug_traceList = gHelper.GenerateGrid("CList_ContractTrace", this.panel1, new Point(6, 20));
                        //ug_traceList.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                        ug_list.BeforeRowDeactivate += new CancelEventHandler(ug_list_BeforeRowDeactivate);
                        ug_list.AfterRowActivate += new EventHandler(ug_list_AfterRowActivate);
                       
                        break;
                    }
                default:
                    break;
            }

            rawDetailList = this.detailInstance.GetCDetailByContract(GModel.Contract_Code);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = rawDetailList;
            bindHelper.BindModelToControl<SD_Contract>(GModel, this.gpBasic.Controls, "");
            ug_list.DataSource = dataSource;

            //设置数据过滤
            gHelper.SetExcelStyleFilter(ug_list);


            //合同追踪数据
            var rawDetailList1 = new List<SD_ContractTrace>();
            BindingSource dataSourceTrace = new BindingSource();
            ug_traceList.AfterExitEditMode += new EventHandler(ug_traceList_AfterExitEditMode);
            dataSourceTrace.DataSource = rawDetailList1;
            ug_traceList.DataSource = dataSourceTrace;

        }

        void ug_traceList_AfterExitEditMode(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_traceList.ActiveRow;
            if (row != null)
            {
                var d=row.ListObject as SD_ContractTrace;
                for (int i = row.Index + 1; i < this.ug_traceList.Rows.Count; i++)
                {
                    this.ug_traceList.Rows[i].Cells["SDT_FOwner"].Value = d.SDT_FOwner;
                    this.ug_traceList.Rows[i].Cells["SDT_FOwnerName"].Value = d.SDT_FOwnerName;
                }
            }
        }

        void ug_list_BeforeRowDeactivate(object sender, CancelEventArgs e)
        {
            var arow = ug_list.ActiveRow;
            if (arow != null)
            {
                var detail = arow.ListObject as SD_CDetail;
                if (detail == null)
                {
                    return;
                }
                List<SD_ContractTrace> source = new List<SD_ContractTrace>();
                foreach (var row in this.ug_traceList.Rows)
                {
                    SD_ContractTrace m = row.ListObject as SD_ContractTrace;
                    source.Add(m);
                }
                SaveDetail(detail, source);
            }
        }

 

        public void SaveDetail(SD_CDetail main,List<SD_ContractTrace> list)
        {
            detailInstance.AddOrUpdateContractTrace(main, list);
        }

        void ug_list_AfterRowActivate(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_list.ActiveRow;
            if (row != null)
            {
               SD_CDetail detail=row.ListObject as SD_CDetail;
               if (detail == null)
               {
                   return;
               }
                //合同追踪数据
               var rawDetailList1 = detailInstance.GetTraceContractList(detail.CDetail_Code);
                BindingSource dataSourceTrace = new BindingSource();
                dataSourceTrace.DataSource = rawDetailList1;
                ug_traceList.DataSource = dataSourceTrace;
            }
        }

        public void SaveContractTrace()
        {
            var arow = ug_list.ActiveRow;
            if (arow != null)
            {
                QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                         , QX.Shared.SessionConfig.UserName
                         , "localhost"
                         , this.Name
                         , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().ContractTrace
                         , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Contract.ToString(), QX.Common.LogType.Edit.ToString());

                var detail = arow.ListObject as SD_CDetail;
                if (detail == null)
                {
                    return;
                }
                List<SD_ContractTrace> source = new List<SD_ContractTrace>();
                foreach (var row in this.ug_traceList.Rows)
                {
                    SD_ContractTrace m = row.ListObject as SD_ContractTrace;
                    if (!string.IsNullOrEmpty(m.SDT_ProdCode))
                    {
                        source.Add(m);
                    }
                }
                SaveDetail(detail, source);
            }
        }

        private void SaveGrid(UltraGrid ug_list)
        {
            List<SD_CDetail> list = new List<SD_CDetail>();
            foreach (UltraGridRow row in ug_list.Rows)
            {
                SD_CDetail line = row.ListObject as SD_CDetail;
                line.CDetail_ContractNo = GModel.Contract_Code;
                if (string.IsNullOrEmpty(line.CDetail_Code))
                {
                    line.CDetail_Code = detailInstance.GenerateCDetailCode();
                }
                line.Stat = 0;
                list.Add(line);
            }
            instance.SaveContract(GModel, list);

            SaveContractTrace();
        }
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            SD_Contract rawMain = new SD_Contract();
            rawMain = GModel;
            BindModelHelper helper = new BindModelHelper();
            //Sys_PD_Module module = this.gpBasic.Tag as Sys_PD_Module;
            //if (module == null)
            //{
            //    MessageShow(false);
            //    return;
            //}

            helper.BindControlToModel(rawMain, this.gpBasic.Controls, "");
            rawMain.Contract_Bak = txtBak.Text;

            if (string.IsNullOrEmpty(rawMain.Contract_CustCode))
            {
                Alert.Show("请先选择签约客户!");
                return;
            }

            Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

            //UltraGrid ug_list = panel2.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            if (rawMain == null)
            {
                return;
            }
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.View:
                    result = true;
                   
                    break;
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    if (rawMain.Contract_Code != GModel.Contract_Code)
                    {
                        if (!CheckIsExist(rawMain.Contract_Code))
                        {
                            result = this.mainInstance.Update(rawMain);
                        }
                        else
                        {
                            MessageBox.Show("指令编号已经存在");
                            return;
                        }
                    }
                    else
                    {
                        result = mainInstance.Update(rawMain);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    if (!CheckIsExist(rawMain.Contract_Code))
                    {
                        rawMain.Stat = 0;
                        result = mainInstance.AddContract(rawMain);
                    }
                    else
                    {
                        MessageBox.Show("指令编号已经存在");
                        return;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            SaveGrid(ug_list);
            MessageShow(result);


            this.Close();
        }
        public void MessageShow(bool result)
        {
            if (result)
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
            }
        }
        public bool CheckIsExist(string NodeCode)
        {
            bool result = false;
            SD_Contract model = this.mainInstance.GetModel(" AND (Contract_Code='" + NodeCode + "')");
            if (model != null && !String.IsNullOrEmpty(model.Contract_Code))
            {
                result = true;
            }
            return result;
        }


    }
}
