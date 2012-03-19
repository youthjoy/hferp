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
using QX.BLL;
using QX.Framework.AutoForm;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Shared;
using Infragistics.Win.UltraWinEditors;
using QX.Plugin.Cmd;

namespace QX.Plugin.Prod.RawMain
{
    public partial class RawRecAdmin : F_BasicPop
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

        private Raw_Main GModel = new Raw_Main();
        private Bll_Raw_Main mainInstance = null;
        private Bll_Raw_Detail detailInstance = null;

        public RawRecAdmin(Bll_Raw_Main _mainInstance, Raw_Main _gmodel)
        {
            InitializeComponent();

            if (_mainInstance == null)
            {
                mainInstance = new Bll_Raw_Main();
            }
            else
            {
                this.mainInstance = _mainInstance;
            }
            if (_gmodel == null)
            {
                _gmodel = new Raw_Main();
            }
            else
            {
                GModel = _gmodel;
            }
            this.detailInstance = new QX.BLL.Bll_Raw_Detail();
            this.GModel = _gmodel;

            this.Load += new EventHandler(RawRecAdmin_Load);
        }
        public RawRecAdmin(Bll_Raw_Main _mainInstance, Raw_Main _gmodel,bool isAuditFlag)
        {
            InitializeComponent();

            if (_mainInstance == null)
            {
                mainInstance = new Bll_Raw_Main();
            }
            else
            {
                this.mainInstance = _mainInstance;
            }
            if (_gmodel == null)
            {
                _gmodel = new Raw_Main();
            }
            else
            {
                GModel = _gmodel;
            }
            this.detailInstance = new QX.BLL.Bll_Raw_Detail();
            this.GModel = _gmodel;
            this.isAudit = isAuditFlag;

            this.Load += new EventHandler(RawRecAdmin_Load);
        }

        void RawRecAdmin_Load(object sender, EventArgs e)
        {
            LoadWindowControl();
            BindTopTool();
        }
        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            ToolStripButton saveBtn = TsHelper.New("保存", global::QX.Common.Properties.Resources.save, tool_bar_button_SaveClicked);
            tool_bar_button.AddCustomControl(saveBtn);

            if (operationType == OperationTypeEnum.OperationType.Look)
            {
                saveBtn.Enabled = false;
            }
            
            tool_bar_button.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));


            ToolStripButton cmdSelBtn = TsHelper.New("指令代入", QX.Common.Properties.Resources.parts, new EventHandler(cmdSelBtn_Click));
            //cmdSelBtn.Click += new EventHandler(cmdSelBtn_Click);
            this.tbDetail.AddCustomControl(cmdSelBtn);
        }

        private Bll_Prod_CmdDetail cmdInstance = new Bll_Prod_CmdDetail();
        void cmdSelBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_list.ActiveRow;
            if (row != null)
            {
                Raw_Detail detail = row.ListObject as Raw_Detail;
                var list = ug_list.Rows;
                var command = cmdInstance.GetCommand(detail.RDetail_Command);
                var temp = cmdInstance.GetByCommand(detail.RDetail_Command);
                temp.RemoveAll(o => o.CmdDetail_ID.ToString().Equals(detail.RDetail_DCommand));
                foreach (var d in temp)
                {
                    //detail.rdetail_partname
                    if (list.FirstOrDefault(o => o.Cells["RDetail_DCommand"].Value != null && o.Cells["RDetail_DCommand"].Value.ToString() == d.CmdDetail_ID.ToString()) == null)
                    {
                        if (d.CmdDetail_Num - d.CmdDetail_DNum != 0)
                        {
                            UltraGridRow nrow = ug_list.DisplayLayout.Bands[0].AddNew();
                            nrow.Cells["RDetail_Command"].Value = d.Cmd_Code;
                            nrow.Cells["RDetail_DCommand"].Value = d.CmdDetail_ID;
                            nrow.Cells["RDetail_PartNo"].Value = d.CmdDetail_PartNo;
                            nrow.Cells["RDetail_Nodes"].Value = d.CmdDetail_Roads;
                            nrow.Cells["RDetail_Name"].Value = d.CmdDetail_PartName;
                            nrow.Cells["RDetail_CustomerName"].Value = command.Cmd_Dep_Name;
                            nrow.Cells["RDetail_Customer"].Value = command.Cmd_Dep_Code2;
                            nrow.Cells["RDetail_Num"].Value = d.CmdDetail_Num - d.CmdDetail_DNum;
                            nrow.Cells["RDetail_Unit"].Value = d.CmdDetail_Unit;
                        }
                    }
                }
            }
        }

        void tool_bar_button_SaveClicked(object sender, EventArgs e)
        {
            SaveData();
            //if (AuditFlag == false)
            //{
            //    this.Close();
            //}
            //else
            //{
            //    this.Hide();
            //}
        }
        void tool_bar_button_CancelClicked(object sender, EventArgs e)
        {
            //if (AuditFlag == false)
            //{
                this.Close();
            //}
            //else
            //{
            //    this.Hide();
            //}
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
            List<Raw_Detail> rawDetailList = new List<Raw_Detail>();
            helper.GenerateForm("CForm_RawMain", this.gbMain, new Point(6, 20));
            ug_list = gHelper.GenerateGrid("CList_RawDetail", this.gbDetail, new Point(6, 20));
            List<Raw_Detail> list = new List<Raw_Detail>();
            ug_list.DataSource = list;
            //Sys_PD_Module module = gbMain.Tag as Sys_PD_Module;
            //if (module == null)
            //    return;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    
                    gHelper.SetGridReadOnly(ug_list, true);
                    ug_list.DisplayLayout.Bands[0].Columns["RDetail_PartNo"].CellClickAction = CellClickAction.EditAndSelectText;
                    ug_list.DisplayLayout.Bands[0].Columns["RDetail_Name"].CellClickAction = CellClickAction.EditAndSelectText;
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    break;
                case OperationTypeEnum.OperationType.Add:

                    GModel.RawMain_iType = OperationTypeEnum.RawMainStatEnum.PO.ToString();
                    GModel.RawMain_Code = this.mainInstance.GenerateRawMainCode();
                    GModel.CreateDate = DateTime.Now;
                    GModel.Stat = 0;
                    break;
                default:
                    break;
            }

            rawDetailList = this.detailInstance.GetByRawMainCode(GModel.RawMain_Code);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = rawDetailList;
            bindHelper.BindModelToControl<Raw_Main>(GModel, this.gbMain.Controls,"");
            ug_list.DataSource = dataSource;
            ug_list.BeforeEnterEditMode += new CancelEventHandler(ug_list_BeforeEnterEditMode);
            var temp = bindHelper.FindCtl<UltraCombo>(this.gbMain.Controls, "RawMain_AppOwn");

            var dept = bindHelper.FindCtl<UltraCombo>(this.gbMain.Controls, "RawMain_AppDep");
            if (temp != null)
            {
                temp.Value = SessionConfig.UserCode;
            }

            if (dept != null)
            {
                dept.Value = SessionConfig.DeptCode;

            }
        }

        void ug_list_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridCell cell = this.ug_list.ActiveCell;
            if (cell != null)
            {
                if (cell.Column.Key == "RDetail_Udef1")
                {
                    
                    Raw_Detail detail = cell.Row.ListObject as Raw_Detail;
                    
                    if (detail.RDetail_Command != null&&detail.RDetail_PartNo!=null)
                    {
                        ProdCodeList CodeList = new ProdCodeList(detail.RDetail_Command, detail.RDetail_PartNo,true);
                        CodeList.Show();
                    }
                    e.Cancel = true;
                }
            }
        }

        private void SaveGrid(UltraGrid ug_list)
        {
            List<Raw_Detail> list = new List<Raw_Detail>();
            foreach (UltraGridRow row in ug_list.Rows)
            {
                Raw_Detail line = row.ListObject as Raw_Detail;
                line.RawMain_Code = GModel.RawMain_Code;
                if (string.IsNullOrEmpty(line.RDetail_Code))
                {
                    line.RDetail_Code = detailInstance.GenerateRawDetailCode();
                }
                line.Stat = 0;
                list.Add(line);
            }
            detailInstance.UpdateList(list, GModel);

            switch (operationType)
            { 
                case OperationTypeEnum.OperationType.Add:
                    this.Close();
                    break;
            }
        }
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            Raw_Main rawMain = new Raw_Main();
            rawMain = GModel;
            BindModelHelper helper = new BindModelHelper();
            //Sys_PD_Module module = this.gbMain.Tag as Sys_PD_Module;
            //if (module == null)
            //{
            //    MessageShow(false);
            //    return;
            //}
            helper.BindControlToModel(rawMain, this.gbMain.Controls,"");

            //if (string.IsNullOrEmpty(rawMain.RawMain_SupCode))
            //{
            //    Alert.Show("供应商必须选择");
            //    return;
            //}
            if (string.IsNullOrEmpty(rawMain.RawMain_Title))
            {
                Alert.Show("采购标题必须填写");
                return;
            }
            if (this.ug_list.Rows.Count < 1)
            {
                Alert.Show("采购内容必须填写");
                return;
            }

            Sys_PD_Module gridModule = this.gbDetail.Tag as Sys_PD_Module;

            UltraGrid ug_list = gbDetail.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            if (rawMain == null)
            {
                return;
            }
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    if (rawMain.RawMain_Code != GModel.RawMain_Code)
                    {
                        if (!CheckIsExist(rawMain.RawMain_Code))
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
                    if (!CheckIsExist(rawMain.RawMain_Code))
                    {
                        rawMain.Stat = 0;
                        result = mainInstance.AddRawMain(rawMain);
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
            Raw_Main model = this.mainInstance.GetModel(" AND (RawMain_Code='" + NodeCode + "')");
            if (model != null && !String.IsNullOrEmpty(model.RawMain_Code))
            {
                result = true;
            }
            return result;
        }
    }
}
