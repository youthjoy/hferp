using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BseDict;

namespace QX.Plugin.Prod.RawMain
{
    public partial class RawInvList : F_BasciForm
    {
        UltraGrid ug_listInv;//毛坯库存
        UltraGrid ug_listInList; //库存入库记录（待检验）
        UltraGrid ug_listIned;//已入库列表
        UltraGrid ug_audit = new UltraGrid();//待审核

        GridHelper gridHelper = new GridHelper();
        BLL.Bll_Raw_Main rawInstance = new QX.BLL.Bll_Raw_Main();
        BLL.Bll_Raw_Inv invInstance = new QX.BLL.Bll_Raw_Inv();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public RawInvList()
        {
            InitializeComponent();

            this.Load += new EventHandler(RawInvList_Load);
            BindTopTool();
        }

        void RawInvList_Load(object sender, EventArgs e)
        {
            //库存列表
            this.ug_listInv = gridHelper.GenerateGrid("CList_RawInv", this.pInv, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listInv, true);


            //入库记录
            this.ug_listInList = gridHelper.GenerateGrid("CList_RawIVHistory", this.pInList, new Point(6, 20));
            ug_listInList.DoubleClickRow += new DoubleClickRowEventHandler(ugrid_DoubleClickRow);
            gridHelper.SetGridReadOnly(ug_listInList, true);
            gridHelper.SetExcelStyleFilter(ug_listInList);
            //待检验
            this.ug_audit = gridHelper.GenerateGrid("CList_RawIVHistory", this.panel1, new Point(0, 0));
            gridHelper.SetGridReadOnly(ug_audit, true);

            ug_audit.DoubleClickRow += new DoubleClickRowEventHandler(ugrid_DoubleClickRow);
            //已入库列表（已通过检验）
            this.ug_listIned = gridHelper.GenerateGrid("CList_FinRawIVHistory", this.pnlIned, new Point(0, 0));
            gridHelper.SetGridReadOnly(ug_listIned, true);
            ug_listIned.DoubleClickRow += new DoubleClickRowEventHandler(ugrid_DoubleClickRow);
            BindDataToGrid();
        }

        void ugrid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            UltraGrid grid = (UltraGrid)sender;
            InitLook(grid);
        }

        private void InitLook(UltraGrid grid)
        {
            UltraGridRow row = grid.ActiveRow;
            if (row != null)
            {
                Raw_Main main = row.ListObject as Raw_Main;
                RawInvOp frm = new RawInvOp(new QX.BLL.Bll_Raw_Main(), main);
                frm.OperationType = OperationTypeEnum.OperationType.Look;
                frm.ShowDialog();

            }

        }

        private void BindDataToGrid()
        {
            // 绑定库存列表
            List<Raw_Inv> list_inv = new List<Raw_Inv>();
            list_inv = invInstance.GetAll();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list_inv;
            ug_listInv.DataSource = dataSource;

            //已入库列表（待检验）
            List<Raw_Main> list_raw = new List<Raw_Main>();
            list_raw = rawInstance.GetRawPIList();


            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_raw;
            ug_listInList.DataSource = dataSource1;


            // 绑定入库（审核）单列表
            List<Raw_Main> list_raw1 = new List<Raw_Main>();
            list_raw1 = rawInstance.GetRawAuditingPIList();

            BindingSource dataSource2 = new BindingSource();
            dataSource2.DataSource = list_raw1;
            this.ug_audit.DataSource = dataSource2;


            // 绑定入库单列表(已入库)
            List<Raw_Main> list_in = new List<Raw_Main>();
            list_in = rawInstance.GetRawInPIList();
            BindingSource dataSource3 = new BindingSource();
            dataSource3.DataSource = list_in;
            this.ug_listIned.DataSource = dataSource3;
        }

        /// <summary>
        /// 检验入库  搜索关键系
        /// </summary>
        ToolStripTextBox txtLastAuditKey = new ToolStripTextBox();
        FormHelper fHelper = new FormHelper();

        //已入库 
        ToolStripTextBox txtInedKey = new ToolStripTextBox();

        /// <summary>
        /// 库存列表 搜索关键字
        /// </summary>
        ToolStripTextBox txtInKey = new ToolStripTextBox();

        public void BindTopTool()
        {
            #region 毛坯入库
            commonToolBarIn.AddClicked += new EventHandler(commonToolBarIn_AddClicked);
            commonToolBarIn.EditClicked += new EventHandler(commonToolBarIn_EditClicked);
            //commonToolBarIn.DelClicked += new EventHandler(commonToolBarIn_DelClicked);
            commonToolBarIn.RefreshClicked += new EventHandler(commonToolBarIn_RefreshClicked);
            //commonToolBarIn.EditClicked+=new EventHandler(commonToolBarIn_EditClicked);
            commonToolBarIn.DelClicked += new EventHandler(commonToolBarIn_DelClicked);
            #endregion

            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.commonToolBarIn.AddCustomControl(4, tLabel3);


            this.commonToolBarIn.AddCustomControl(5, txtLastAuditKey);

            //搜索按钮
            ToolStripButton searchFinBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchFinBtn_Click));
            //searchFBtn.Click += new EventHandler(searchFBtn_Click);
            this.commonToolBarIn.AddCustomControl(6, searchFinBtn);


            //待审
            this.tbCon.AuditClicked += new EventHandler(tbCon_AuditClicked);
            this.tbCon.RefreshClicked += new EventHandler(tbCon_RefreshClicked);


            //库存列表
            commonToolBarInv.RefreshClicked += new EventHandler(commonToolBarInv_RefreshClicked);
            ToolStripLabel tLabel4 = new ToolStripLabel();
            tLabel4.Text = "关键字:";
            this.commonToolBarInv.AddCustomControl(4, tLabel4);
            this.commonToolBarInv.AddCustomControl(5, txtInKey);

            //搜索按钮
            ToolStripButton searchInBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchInBtn_Click));
            this.commonToolBarInv.AddCustomControl(6, searchInBtn);


            #region 已入库列表

            ToolStripLabel tLabel5 = new ToolStripLabel();
            tLabel5.Text = "关键字:";
            this.tbIned.AddCustomControl(4, tLabel5);


            this.tbIned.AddCustomControl(6, txtInedKey);

            //搜索按钮
            ToolStripButton searchInedBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchInedBtn_Click));

            this.tbIned.AddCustomControl(7, searchInedBtn);

            this.tbIned.QueryClicked += new EventHandler(tbIned_QueryClicked);

            #endregion


            fHelper.PermissionControl(this.commonToolBarIn.toolStrip1.Items, PermissionModuleEnum.RawInv.ToString());
        }

        void tbIned_QueryClicked(object sender, EventArgs e)
        {
            
            InitLook(this.ug_listIned);
        }

        /// <summary>
        /// 已入库列表搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchInedBtn_Click(object sender, EventArgs e)
        {
            string key = txtInedKey.Text;

            string where = string.Format(" AND (RawMain_Code like '%{0}%' or RawMain_Title like '%{0}%'  or RawMain_CmdCode like '%{0}%' or RawMain_SupName like '%{0}%')", key);

            var list = rawInstance.GetRawInedPIListWithFitler("pi", where);

            this.ug_listIned.DataSource = list;
        }

        /// <summary>
        /// 库存列表搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void searchInBtn_Click(object sender, EventArgs e)
        {
            string key = this.txtInKey.Text;

            string where = string.Format(" AND (RI_Code like '%{0}%' OR RI_CompCode like '%{0}%' or RI_CmdCode like '%{0}%')", key);

            var list = invInstance.GetInvByWhere(where);

            ug_listInv.DataSource = list;
        }


        void searchFinBtn_Click(object sender, EventArgs e)
        {
            string key = txtLastAuditKey.Text;

            string where = string.Format(" AND (RawMain_Code like '%{0}%' or RawMain_Title like '%{0}%'  or RawMain_CmdCode like '%{0}%' or RawMain_SupName like '%{0}%')", key);

            var list = rawInstance.GetRawPIListWithFitler("pi", where);

            ug_listInList.DataSource = list;

        }

        void tbCon_AuditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_audit.ActiveRow;
            if (row != null)
            {


                Raw_Main raw = row.ListObject as Raw_Main;

                RawInvOp viewFrm = new RawInvOp(rawInstance, raw, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.View;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString(), raw.RawMain_Code, raw.AuditCurAudit, viewFrm);
                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                if (DialogResult.OK == frm.ShowDialog())
                {

                    viewFrm.isAudit = false;
                    viewFrm.Close();
                }
            }
        }

        void frm_CallBack(AuditReturnResultEnum re, string AStat)
        {
            //审核行
            UltraGridRow row = this.ug_audit.ActiveRow;

            switch (re)
            {
                case AuditReturnResultEnum.Success:

                    if (AStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                    {
                        Raw_Main main = row.ListObject as Raw_Main;
                        rawInstance.UpdateRaw(main);
                    }

                    BindDataToGrid();
                    Alert.Show("审核完成");
                    break;
                case AuditReturnResultEnum.Fail:

                    Alert.Show("审核失败!");

                    break;
            }
        }

        void tbCon_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        void commonToolBarIn_AddClicked(object sender, EventArgs e)
        {
            RawInvOp frm = new RawInvOp(rawInstance, null);
            frm.OperationType = OperationTypeEnum.OperationType.Add;
            frm.ShowDialog();

            BindDataToGrid();
        }

        void commonToolBarIn_EditClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listInList.ActiveRow;
            if (row != null)
            {
                Raw_Main main = row.ListObject as Raw_Main;
                if (main.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                {
                    RawInvOp frm = new RawInvOp(rawInstance, main);
                    frm.OperationType = OperationTypeEnum.OperationType.Edit;
                    frm.ShowDialog();

                    BindDataToGrid();

                }
                else
                {
                    Alert.Show("当前单据已经进入审核流程,不能进行数据更新!");
                }

            }
        }

        void commonToolBarIn_DelClicked(object sender, EventArgs e)
        {

            UltraGridRow row = this.ug_listInList.ActiveRow;

            Raw_Main temp = row.ListObject as Raw_Main;
            var main = rawInstance.GetModel(string.Format(" and RawMain_Code='{0}'", temp.RawMain_Code));
            if (main.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
            {
                Alert.Show("当前单据已进入检验流程，不能进行删除删除！");
                return;
            }

            if (Alert.ShowIsConfirm("确定删除当前收货记录吗?"))
            {
                if (row != null)
                {


                    rawInstance.Delete(main);

                    BindDataToGrid();
                }
            }
        }

        void commonToolBarInv_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        void commonToolBarIn_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }
    }
}
