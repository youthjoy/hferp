using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class ContractOP : F_BasicPop
    {
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

        public ContractOP(SD_Contract contract, OperationTypeEnum.OperationType op)
        {
            InitializeComponent();
            OperationType = op;
            GModel = contract;
        }
        public ContractOP(SD_Contract contract, OperationTypeEnum.OperationType op, bool isAuditFlag)
        {
            InitializeComponent();
            this.isAudit = isAuditFlag;
            OperationType = op;
            GModel = contract;
        }

        private List<Road_Components> Components
        {
            get;
            set;
        }

        public void BindTopTool()
        {
            CommonToolBar toolBar = new CommonToolBar();
            toolBar.Dock = DockStyle.Top;
            this.Controls.Add(toolBar);
            ToolStripHelper TsHelper = new ToolStripHelper();
            ToolStripButton importDetail = TsHelper.New("合同明细导入", QX.Common.Properties.Resources.import, new EventHandler(importDetail_Click));
            toolBar.AddCustomControl(importDetail);


            ToolStripButton exportDetail = TsHelper.New("合同明细导出", QX.Common.Properties.Resources.import, new EventHandler(exportDetail_Click));

            toolBar.AddCustomControl(exportDetail);
            //tool_bar_button.AddCustomControl(TsHelper.New("保存", global::QX.Common.Properties.Resources.save, tool_bar_button_SaveClicked));
            //tool_bar_button.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));
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
            bool flag = true;
            StringBuilder sb = new StringBuilder();
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

                //零件图号判断
                if (!string.IsNullOrEmpty(d.CDetail_PartNo)&&!Components.Exists(o => o.Comp_Code == d.CDetail_PartNo))
                {
                    flag = false;
                    sb.AppendFormat("{0},", d.CDetail_PartNo);
                    break;
                }

                if (!string.IsNullOrEmpty(d.CDetail_PartNo))
                {
                    list.Add(d);
                }
            }

            if (!flag)
            {
                Alert.Show("以下图号不存在" + sb.ToString().TrimEnd(','));
                return;
            }

            BindingSource s = new BindingSource();
            s.DataSource = list;
            this.ug_list.DataSource = s;
        }

        void tool_bar_button_SaveClicked(object sender, EventArgs e)
        {
            SaveData();

        }
        void tool_bar_button_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 操作句柄

        UltraGrid ug_list = new UltraGrid();
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


            //Sys_PD_Module module = gpBasic.Tag as Sys_PD_Module;
            //if (module == null)
            //    return;
            switch (operationType)
            {
                //合同执行情况
                case OperationTypeEnum.OperationType.View:
                    {
                        gpBasic.Enabled = false;
                        ug_list = gHelper.GenerateGrid("CList_GCDetail", this.panel2, new Point(6, 20));
                        ug_list.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                        break;
                    }
                case OperationTypeEnum.OperationType.Look:
                    ug_list = gHelper.GenerateGrid("GCDetail", this.panel2, new Point(6, 20));
                    //gHelper.SetGridReadOnly(ug_list, true);
                    ug_list.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                    this.btnSave.Enabled = false;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    BindTopTool();
                    ug_list = gHelper.GenerateGrid("GCDetail", this.panel2, new Point(6, 20));
                    break;
                case OperationTypeEnum.OperationType.Add:
                    BindTopTool();
                    ug_list = gHelper.GenerateGrid("GCDetail", this.panel2, new Point(6, 20));
                    //GModel.RawMain_iType = OperationTypeEnum.RawMainStatEnum.PO.ToString();
                    GModel.Contract_Code = this.mainInstance.GenerateContractCode();
                    GModel.Contract_Date = DateTime.Now;
                    GModel.Contract_Creator = SessionConfig.UserCode;
                    GModel.Stat = 0;
                    break;
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

            this.ug_list.BeforeEnterEditMode += new CancelEventHandler(ug_list_BeforeEnterEditMode);
        }


        void ug_list_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            //先进行数据有效性验证  合同编号 

            UltraGridCell cell = this.ug_list.ActiveCell;
            if (cell != null && cell.Column.Key == "CDetail_PRRelation")
            {
                SD_CDetail detail = cell.Row.ListObject as SD_CDetail;

                if (string.IsNullOrEmpty(detail.CDetail_ContractNo) || string.IsNullOrEmpty(detail.CDetail_Code))
                {
                    Alert.Show("请先保存合同相关信息");
                    e.Cancel = true;
                    return;
                }

                //合同编号
                detail.CDetail_ContractNo = GModel.Contract_Code;
                QX.Plugin.Contract.ComControl.ProdCodeSel codeSel = new QX.Plugin.Contract.ComControl.ProdCodeSel(detail);
                codeSel.ShowDialog();
                e.Cancel = true;
            }
            else if (cell != null && cell.Column.Key == "CDetail_Finance")
            {
                SD_CDetail detail = cell.Row.ListObject as SD_CDetail;
                FinanceProdRef financeRef = new FinanceProdRef(detail, GModel);
                financeRef.ShowDialog();
                e.Cancel = true;
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
        }
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            SD_Contract rawMain = new SD_Contract();
            rawMain = GModel;
            BindModelHelper helper = new BindModelHelper();

            helper.BindControlToModel(rawMain, this.gpBasic.Controls, "");
            rawMain.Contract_Bak = txtBak.Text;

            if (string.IsNullOrEmpty(rawMain.Contract_CustCode))
            {
                Alert.Show("请先选择签约客户!");
                return;
            }

            Sys_PD_Module gridModule = this.panel2.Tag as Sys_PD_Module;

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

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                         , QX.Shared.SessionConfig.UserName
                         , "localhost"
                         , this.Name
                         , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Contract
                         , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Contract.ToString(), QX.Common.LogType.Edit.ToString());


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

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                         , QX.Shared.SessionConfig.UserName
                         , "localhost"
                         , this.Name
                         , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Contract
                         , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Contract.ToString(), QX.Common.LogType.Add.ToString());


                    if (!CheckIsExist(rawMain.Contract_Code))
                    {
                        rawMain.Stat = 0;
                        result = mainInstance.AddContract(rawMain);
                        operationType = OperationTypeEnum.OperationType.Edit;
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


            //this.Close();
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

        private void ContractOP_Load(object sender, EventArgs e)
        {
            Components = new Bll_Road_Components().GetAll();

            LoadWindowControl();

        }
    }
}
