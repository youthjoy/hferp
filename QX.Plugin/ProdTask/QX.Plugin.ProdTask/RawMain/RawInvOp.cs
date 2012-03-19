using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BseDict;
using QX.BLL;
using QX.Plugin.Cmd;

namespace QX.Plugin.Prod.RawMain
{
    public partial class RawInvOp : F_BasicPop
    {
        public RawInvOp()
        {
            InitializeComponent();

            BindTopTool();
        }

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType = OperationTypeEnum.OperationType.Edit;
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
        private BLL.Bll_Prod_CmdDetail pdInstance = new QX.BLL.Bll_Prod_CmdDetail();

        public RawInvOp(Bll_Raw_Main _mainInstance, Raw_Main _gmodel)
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

            BindTopTool();
        }


        public RawInvOp(Bll_Raw_Main _mainInstance, Raw_Main _gmodel, bool isAudit)
        {
            InitializeComponent();
            this.isAudit = isAudit;
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

            BindTopTool();
        }

        void RawInvOp_Load(object sender, EventArgs e)
        {

            LoadWindowControl();

        }
        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            this.tool_bar_button.SaveClicked += new EventHandler(tool_bar_button_SaveClicked);
            //tool_bar_button.AddCustomControl(TsHelper.New("保存", global::QX.Common.Properties.Resources.save, tool_bar_button_SaveClicked));
            tool_bar_button.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));


            ToolStripButton cmdSelBtn = TsHelper.New("指令代入", QX.Common.Properties.Resources.parts, new EventHandler(cmdSelBtn_Click));
            //cmdSelBtn.Click += new EventHandler(cmdSelBtn_Click);
            this.tbDetail.AddCustomControl(cmdSelBtn);


            ToolStripButton msgBtn = TsHelper.New("短信通知", QX.Common.Properties.Resources.planner, new EventHandler(msgBtn_Click));

            this.tool_bar_button.AddCustomControl(msgBtn);
            //}
        }

        private Bll_Audit auInstance = new Bll_Audit();

        void msgBtn_Click(object sender, EventArgs e)
        {
            if (OperationTypeEnum.OperationType.Add == operationType)
            {
                Alert.Show("请先保存后再通知下一步相关审核人员!");
                return;
            }
            if (string.IsNullOrEmpty(GModel.AuditCurAudit))
            {
                var model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString());
                if (model != null)
                {
                    AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString(), model.VT_VerifyNode_Code);
                    UserSel.Show();
                }
            }
            else
            {
                AuditUserSel UserSel = new AuditUserSel(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString(), GModel.AuditCurAudit);
                UserSel.Show();
            }
        }

        private Bll_Prod_CmdDetail cmdInstance = new Bll_Prod_CmdDetail();

        void cmdSelBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_list.ActiveRow;
            if (row != null)
            {
                Raw_Detail detail = row.ListObject as Raw_Detail;
                var list = ug_list.Rows;
                //获取指令主表
                var cmdMain = cmdInstance.GetCommand(detail.RDetail_Command);
                //获取指令明细
                var temp = cmdInstance.GetByCommand(detail.RDetail_Command);

                //var current = temp.FirstOrDefault(o => o.CmdDetail_ID.ToString().Equals(detail.RDetail_DCommand));

                //row.Cells["RDetail_Command"].Value = current.Cmd_Code;
                //row.Cells["RDetail_CustomerName"].Value = cmdMain.Cmd_Dep_Code2;
                //row.Cells["RDetail_Customer"].Value = cmdMain.Cmd_Dep_Name;
                //row.Cells["RDetail_DCommand"].Value = current.CmdDetail_ID;
                //row.Cells["RDetail_PartNo"].Value = current.CmdDetail_PartNo;
                //row.Cells["RDetail_Name"].Value = current.CmdDetail_PartName;
                //row.Cells["RDetail_Num"].Value = current.CmdDetail_Num;
                //row.Cells["RDetail_Unit"].Value = current.CmdDetail_Unit;

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
                            nrow.Cells["RDetail_CustomerName"].Value = cmdMain.Cmd_Dep_Name;
                            nrow.Cells["RDetail_Customer"].Value = cmdMain.Cmd_Dep_Code2;
                            nrow.Cells["RDetail_Nodes"].Value = d.CmdDetail_Roads;

                            nrow.Cells["RDetail_DCommand"].Value = d.CmdDetail_ID;
                            nrow.Cells["RDetail_PartNo"].Value = d.CmdDetail_PartNo;
                            nrow.Cells["RDetail_Name"].Value = d.CmdDetail_PartName;
                            nrow.Cells["RDetail_Num"].Value = d.CmdDetail_Num - d.CmdDetail_DNum;
                            nrow.Cells["RDetail_Unit"].Value = d.CmdDetail_Unit;
                        }
                    }
                }
            }
        }

        void tool_bar_button_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                this.Close();
            }
        }
        void tool_bar_button_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 操作句柄

        UltraGrid ug_list = new UltraGrid();
        #endregion

        BindModelHelper bindHelper = new BindModelHelper();
        /// <summary>
        /// 读取窗体控件
        /// </summary>
        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            GridHelper gHelper = new GridHelper();
            List<Raw_Detail> rawDetailList = new List<Raw_Detail>();
            ug_list = gHelper.GenerateGrid("CList_RawDetail", this.gbDetail, new Point(6, 20));
            List<Raw_Detail> list = new List<Raw_Detail>();
            BindingSource dataSourceTmp = new BindingSource();
            dataSourceTmp.DataSource = list;
            ug_list.DataSource = dataSourceTmp;
            ug_list.BeforeEnterEditMode += new CancelEventHandler(ug_list_BeforeEnterEditMode);
            ug_list.CellChange += new CellEventHandler(ug_list_CellChange);

            //if (module == null)
            //    return;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    {
                        this.tool_bar_button.SetButtonEnabled("SAVE", false, false);
                        helper.GenerateForm("CIForm_RawMain", this.gbMain, new Point(6, 20));
                        Sys_PD_Module module = gbMain.Tag as Sys_PD_Module;
                        //gHelper.SetGridReadOnly(ug_list, true);
                        ug_list.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                        bindHelper.BindModelToControl<Raw_Main>(GModel, this.gbMain.Controls, module.SPM_TPrefix);

                        //获取毛坯明细列表
                        rawDetailList = this.detailInstance.GetByRawMainCode(GModel.RawMain_Code);

                        BindingSource dataSource = new BindingSource();
                        dataSource.DataSource = rawDetailList;
                        ug_list.DataSource = dataSource;

                        break;
                    }
                case OperationTypeEnum.OperationType.Edit:
                    {

                        //编辑收货
                        helper.GenerateForm("CIForm_RawMain", this.gbMain, new Point(6, 20));
                        //Sys_PD_Module module = gbMain.Tag as Sys_PD_Module;
                        bindHelper.BindModelToControl<Raw_Main>(GModel, this.gbMain.Controls, "");

                        //获取毛坯明细列表
                        rawDetailList = this.detailInstance.GetByRawMainCode(GModel.RawMain_Code);

                        BindingSource dataSource = new BindingSource();
                        dataSource.DataSource = rawDetailList;
                        ug_list.DataSource = dataSource;

                        break;
                    }
                case OperationTypeEnum.OperationType.View:
                    {
                        //编辑收货
                        helper.GenerateForm("CIForm_RawMainIn", this.gbMain, new Point(6, 20));
                        //Sys_PD_Module module = gbMain.Tag as Sys_PD_Module;
                        bindHelper.BindModelToControl<Raw_Main>(GModel, this.gbMain.Controls, "");

                        //获取毛坯明细列表
                        rawDetailList = this.detailInstance.GetByRawMainCode(GModel.RawMain_Code);

                        BindingSource dataSource = new BindingSource();
                        dataSource.DataSource = rawDetailList;
                        ug_list.DataSource = dataSource;

                        break;
                    }
                case OperationTypeEnum.OperationType.Add:
                    {
                        GModel.RawMain_iType = QX.Common.C_Class.OperationTypeEnum.RawMainStatEnum.PI.ToString();
                        GModel.RawMain_Code = this.mainInstance.GenerateRawMainCode();
                        helper.GenerateForm("CIForm_RawMain", this.gbMain, new Point(6, 20));

                        bindHelper.BindModelToControl<Raw_Main>(GModel, this.gbMain.Controls, "");


                        try
                        {
                            UltraCombo combo = bindHelper.FindCtl<UltraCombo>(this.gbMain.Controls, "RawMain_RefCode");
                            combo.ValueChanged += new EventHandler(combo_ValueChanged);
                        }
                        catch (Exception ex)
                        {

                        }
                        break;
                    }
                default:
                    break;
            }


        }

        //private BLL.Bll_Prod_CmdDetail pdInstance = new QX.BLL.Bll_Prod_CmdDetail();

        void ug_list_CellChange(object sender, CellEventArgs e)
        {

            if (e.Cell.Column.Key == "RDetail_Num")
            {
                Raw_Detail detail = e.Cell.Row.ListObject as Raw_Detail;
                if (detail != null)
                {
                    var num = QX.Common.C_Class.Utils.TypeConverter.ObjectToInt(e.Cell.Value);
                    List<Prod_CodeMap> list = new List<Prod_CodeMap>();
                    list = pdInstance.GetMapList(detail.RDetail_Command, detail.RDetail_PartNo);

                    if (num > list.Count)
                    {
                        ug_list.EventManager.AllEventsEnabled = false;

                        e.Cell.Value = list.Count;

                        ug_list.EventManager.AllEventsEnabled = true;
                        Alert.Show("您输入的毛坯数量与指令已编制的零件编号数量不符，请查证确认!");
                    }
                }
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

                    if (detail.RDetail_Command != null && detail.RDetail_PartNo != null)
                    {
                        //ProdCodeList CodeList = new ProdCodeList(detail.RDetail_Command, detail.RDetail_PartNo, true);
                        switch (operationType)
                        {
                            case OperationTypeEnum.OperationType.Look:
                                {
                                    //查看
                                    RawProdCode CodeList = new RawProdCode(GModel.RawMain_Code, detail.RDetail_Command, detail.RDetail_PartNo, OperationTypeEnum.OperationType.View);
                                    CodeList.Show();
                                }
                                break;
                            case OperationTypeEnum.OperationType.Add:
                            case OperationTypeEnum.OperationType.Edit:
                                {
                                    //编辑或添加
                                    RawProdCode CodeList = new RawProdCode(GModel.RawMain_Code, detail.RDetail_Command, detail.RDetail_PartNo, OperationTypeEnum.OperationType.Edit);
                                    CodeList.Show();
                                }
                                break;//审核时候
                            case OperationTypeEnum.OperationType.View:
                                {
                                    RawProdCode CodeList = new RawProdCode(GModel.RawMain_Code, detail.RDetail_Command, detail.RDetail_PartNo, OperationTypeEnum.OperationType.Look);
                                    CodeList.Show();

                                }
                                break;

                        }


                        QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                , QX.Shared.SessionConfig.UserName
                , "localhost"
                , this.Name
                , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().RawProdCode
                , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Raw.ToString(), QX.Common.LogType.Edit.ToString());


                    }
                    e.Cancel = true;
                }
            }
        }

        void combo_ValueChanged(object sender, EventArgs e)
        {
            UltraCombo combo = sender as UltraCombo;

            if (combo != null && combo.Value != null)
            {
                var value = combo.Value.ToString();

                var model = mainInstance.GetModel(string.Format(" AND RawMain_Code='{0}'", value));

                if (model != null)
                {
                    string mainCode = model.RawMain_Code;
                    GModel = model;
                    //GModel.RawMain_iType = OperationTypeEnum.RawMainStatEnum.PI.ToString();
                    GModel.RawMain_RefCode = mainCode;
                    GModel.RawMain_RefType = OperationTypeEnum.RawMainStatEnum.PO.ToString();
                    //GModel.RawMain_Code = this.mainInstance.GenerateRawMainCode();
                    GModel.CreateDate = DateTime.Now;

                    var list = this.detailInstance.GetByRawMainCode(value);

                    bindHelper.BindModelToControl<Raw_Main>(GModel, this.gbMain.Controls, "");
                    BindingSource dataSource = new BindingSource();
                    dataSource.DataSource = list;
                    ug_list.DataSource = dataSource;
                }
            }
        }

        private void SaveGrid(UltraGrid ug_list)
        {
            List<Raw_Detail> list = new List<Raw_Detail>();

            foreach (UltraGridRow row in ug_list.Rows)
            {
                Raw_Detail line = row.ListObject as Raw_Detail;
                if (OperationType == OperationTypeEnum.OperationType.Add)
                {
                    line.RawMain_Code = GModel.RawMain_Code;
                    line.RDetail_Code = detailInstance.GenerateRawDetailCode();
                    line.Stat = 0;
                }
                else
                {
                    if (string.IsNullOrEmpty(line.RDetail_Code))
                    {
                        line.RDetail_Code = detailInstance.GenerateRawDetailCode();
                    }
                }


                list.Add(line);
            }

            detailInstance.UpdateDetailAndInv(list, GModel);
        }



        public bool IsHaveProdCode()
        {

            foreach (var r in this.ug_list.Rows)
            {
                Raw_Detail rd = r.ListObject as Raw_Detail;


                if (rd.RDetail_Num == 0)
                {
                    Alert.Show("入库数量不能为0");
                    return false;
                }

                //判断该入库单据的相关联的零件编号
                var list=cmdInstance.GetMapListForValidate(GModel.RawMain_Code,rd.RDetail_Command,rd.RDetail_PartNo);
                if (list.Count == 0)
                {
                    Alert.Show(string.Format("零件图号为{0}未选择零件编号", rd.RDetail_PartNo));
                    return false;
                }
               else if(list.Count<rd.RDetail_Num)
                {
                   //如果存在数量关系不对应，则要提示数量不对应，是否还需要下达
                    if(Alert.ShowIsConfirm(string.Format("零件图号为{0}的产品所关联的零件编号数量与入库数量不一致，是否仍然要下达?", rd.RDetail_PartNo)))
                    {
                        continue;
                    }
                    return false;
                }
                else if (list.Count > rd.RDetail_Num)
                {
                    //如果存在数量关系不对应，则要提示数量不对应，是否还需要下达
                    Alert.Show(string.Format("零件图号为{0}的产品所关联的零件编号数量与入库数量不一致，请确认!", rd.RDetail_PartNo));
                    
                    return false;
                }
            }
            return true;
        }

        private bool SaveData()
        {
            #region  保存数据
            bool result = false;
            Raw_Main rawMain = new Raw_Main();
            rawMain = GModel;
            //BindModelHelper helper = new BindModelHelper();
            Sys_PD_Module module = this.gbMain.Tag as Sys_PD_Module;
            if (module == null)
            {
                MessageShow(false);
                return false;
            }

            bindHelper.BindControlToModel(rawMain, this.gbMain.Controls, module.SPM_TPrefix);

            Sys_PD_Module gridModule = this.gbDetail.Tag as Sys_PD_Module;

            UltraGrid ug_list = gbDetail.Controls.Find(gridModule.SPM_LPrefix + gridModule.SPM_Module, true).FirstOrDefault() as UltraGrid;

            if (rawMain == null)
            {
                return false;
            }


            if (!IsHaveProdCode())
            {
                return false;
            }

            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().RawIn
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Raw.ToString(), QX.Common.LogType.Edit.ToString());

                    //毛坯采购订单状态更新
                    rawMain.RawMain_iType = OperationTypeEnum.RawMainStatEnum.PI.ToString();

                    //更新库存表(采购明细)
                    if (rawMain.RawMain_Code != GModel.RawMain_Code)
                    {
                        if (!CheckIsExist(rawMain.RawMain_Code))
                        {
                            result = this.mainInstance.Update(rawMain);
                        }
                        else
                        {
                            MessageBox.Show("指令编号已经存在");

                        }
                    }
                    else
                    {
                        result = mainInstance.Update(rawMain);
                    }
                    break;
                case OperationTypeEnum.OperationType.View:
                    {
                        //毛坯采购订单状态更新
                        rawMain.RawMain_iType = OperationTypeEnum.RawMainStatEnum.PI.ToString();

                        //更新库存表(采购明细)
                        if (rawMain.RawMain_Code != GModel.RawMain_Code)
                        {
                            if (!CheckIsExist(rawMain.RawMain_Code))
                            {
                                result = this.mainInstance.Update(rawMain);
                            }
                            else
                            {
                                MessageBox.Show("指令编号已经存在");

                            }
                        }
                        else
                        {
                            result = mainInstance.Update(rawMain);
                        }
                        break;
                    }
                case OperationTypeEnum.OperationType.Add:


                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
            , QX.Shared.SessionConfig.UserName
            , "localhost"
            , this.Name
            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().RawIn
            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Raw.ToString(), QX.Common.LogType.Add.ToString());


                    GModel.RawMain_iType = QX.Common.C_Class.OperationTypeEnum.RawMainStatEnum.PI.ToString();


                    if (!CheckIsExist(rawMain.RawMain_Code))
                    {
                        rawMain.Stat = 0;
                        result = mainInstance.AddRawMainInv(rawMain);
                    }
                    else
                    {
                        MessageBox.Show("指令编号已经存在");

                    }
                    break;
                default:
                    break;
            }
            #endregion
            SaveGrid(ug_list);
            MessageShow(result);

            return result;
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
            //Raw_Main model = this.mainInstance.GetModel(" AND (RawMain_Code='" + NodeCode + "')");
            //if (model != null && !String.IsNullOrEmpty(model.RawMain_Code))
            //{
            result = false;
            //}
            return result;
        }

    }
}
