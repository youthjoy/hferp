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

namespace QX.Plugin.Prod.RawMain
{
    public partial class RawOrderList : F_BasciForm
    {
        UltraGrid ug_listMy;//我的毛坯采购计划
        UltraGrid ug_listOnAudit; //审核中的毛坯采购计划
        UltraGrid ug_listLastAudit;//终审通过的毛坯采购计划
        UltraGrid ug_listLitter;//拒绝的毛坯采购计划
        GridHelper gridHelper = new GridHelper();
        BLL.Bll_Raw_Main rawInstance = new QX.BLL.Bll_Raw_Main();
        BLL.Bll_Raw_Detail detailInstance = new QX.BLL.Bll_Raw_Detail();
        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public RawOrderList()
        {
            InitializeComponent();

            this.Load += new EventHandler(RawOrderList_Load);
            BindTopTool();
        }

        void RawOrderList_Load(object sender, EventArgs e)
        {
            //我的申请单
            ug_listMy = gridHelper.GenerateGrid("CList_RawMain", this.pMyRawOrder, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listMy, true);

            ug_listMy.InitializeRow += new InitializeRowEventHandler(ug_listMy_InitializeRow);

            //待审核
            ug_listOnAudit = gridHelper.GenerateGrid("CList_RawMain", this.pOnAudit, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listOnAudit, true);
            //终审
            ug_listLastAudit = gridHelper.GenerateGrid("CList_RawMain", this.pLastAudit, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listLastAudit, true);
            //废单
            ug_listLitter = gridHelper.GenerateGrid("CList_RawMain", this.pLitter, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_listLitter, true);


            LoadGridMyRawOrder();
            LoadGridOnAudit();
            LoadGridLastAudit();
            LoadGridLitter();
        }

        void ug_listMy_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            UltraGridRow row = e.Row;
            try
            {
                Raw_Main val = row.ListObject as Raw_Main;

                if (val != null && val.AuditStat != null)
                {

                    OperationTypeEnum.AudtiOperaTypeEnum auditType = (OperationTypeEnum.AudtiOperaTypeEnum)(Enum.Parse(typeof(OperationTypeEnum.AudtiOperaTypeEnum), val.AuditStat));

                    switch (auditType)
                    {
                        case OperationTypeEnum.AudtiOperaTypeEnum.Auditing:

                            e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[0];
                            //e.Row.Cells["RComponents_AuditStat"].Value = "待审核";
                            break;
                        case OperationTypeEnum.AudtiOperaTypeEnum.OnAudit:
                            e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[1];
                            //e.Row.Appearance.BackColor = auditedColor;
                            //e.Row.Cells["RComponents_AuditStat"].Value = "审核中";
                            break;
                        case OperationTypeEnum.AudtiOperaTypeEnum.LastAudit:
                            //e.Row.Cells["RComponents_AuditStat"].Value = "已终审";
                            break;
                        case OperationTypeEnum.AudtiOperaTypeEnum.Litter:
                            e.Row.Appearance.BackColor = GlobalConfiguration.AuditColor[2];
                            break;
                    }
                }
                else
                {
                    e.Row.Appearance.BackColor = Color.Red;
                    //e.Row.Cells["RComponents_AuditStat"].Value = "未知状态";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private FormHelper fHelper = new FormHelper();

        DateTimePicker bDate = new DateTimePicker();

        DateTimePicker eDate = new DateTimePicker();

        ToolStripTextBox txtKey = new ToolStripTextBox();

        public void BindTopTool()
        {
            //我的毛坯采购计划
            tool_top_my.AddClicked += new EventHandler(tool_top_my_AddClicked);
            tool_top_my.EditClicked += new EventHandler(tool_top_my_EditClicked);
            tool_top_my.DelClicked += new EventHandler(tool_top_my_DelClicked);
            tool_top_my.RefreshClicked += new EventHandler(tool_top_my_RefreshClicked);

            //时间控件
            ToolStripLabel tLabel = new ToolStripLabel();
            tLabel.Text = "开始时间:";
            this.tool_top_my.AddCustomControl(0, tLabel);

            this.tool_top_my.AddCDTPtoToolstrip(1, bDate);
            bDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01 00:00:00"));
            ToolStripLabel tLabel2 = new ToolStripLabel();
            tLabel2.Text = "结束时间:";
            this.tool_top_my.AddCustomControl(2, tLabel2);


            this.tool_top_my.AddCDTPtoToolstrip(3, eDate);
            eDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-28 23:59:59"));
            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tool_top_my.AddCustomControl(4, tLabel3);

            this.tool_top_my.AddCustomControl(5, txtKey);


            ToolStripButton SearchBtn = new ToolStripHelper().New("搜索", QX.Common.Properties.Resources.search, new EventHandler(SearchBtn_Click));
            tool_top_my.AddCustomControl(6, SearchBtn);

            //审核中的毛坯采购计划
            OnAuditToolBarInit();

            //终审通过的毛坯采购计划
            LastAuditToolBarInit();

            //拒绝的毛坯采购计划
            tool_top_litter.RefreshClicked += new EventHandler(tool_top_litter_RefreshClicked);
            tool_top_litter.HistoryClicked += new EventHandler(tool_top_litter_HistoryClicked);
            tool_top_litter.QueryClicked += new EventHandler(tool_top_litter_QueryClicked);


            


            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripButton exportBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(exportBtn_Click));

            tool_top_my.AddCustomControl(exportBtn);

            fHelper.PermissionControl(this.tool_top_my.toolStrip1.Items, PermissionModuleEnum.RawMain.ToString());
            fHelper.PermissionControl(this.tool_top_lastaudit.toolStrip1.Items, PermissionModuleEnum.RawMain.ToString());

    

        }

        void SearchBtn_Click(object sender, EventArgs e)
        {
            DateTime beginDate = this.bDate.Value;
            DateTime endDate = this.eDate.Value;
            string key = this.txtKey.Text;

            var list = rawInstance.GetPOListByWhere(beginDate.ToString(), endDate.ToString(), key);
            ug_listMy.DataSource = list;

        }

        GridHelper gen = new GridHelper();

        void exportBtn_Click(object sender, EventArgs e)
        {
            List<Raw_Main> list = ug_listMy.DataSource as List<Raw_Main>;
            if (list.Count <= 0)
            {
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
                Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter export = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter();
                //this.uGridExport.EndExport += new Infragistics.Win.UltraWinGrid.ExcelExport.EndExportEventHandler(uGridExport_EndExport);

                UltraGrid grid = new UltraGrid();
                Panel p = new Panel();
                this.Controls.Add(p);
                grid = gen.GenerateGrid("CList_ExportRDetail", p, new Point(0, 0));
                DataTable dt = detailInstance.GetDataForExport(list);
                //DataTable dt = DetailInstance.GetCDetailForExport(list);
                grid.DataSource = dt;
                grid.Refresh();
                export.Export(grid, file);
                Alert.Show("导出完成!");

            }
        }

        void tool_top_litter_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listLitter.ActiveRow;
            if (row != null)
            {
                Raw_Main main = row.ListObject as Raw_Main;

                Raw_Main newMain = rawInstance.GetModel(string.Format(" AND RawMain_Code='{0}'", main.RawMain_Code));


                RawRecAdmin frm = new RawRecAdmin(rawInstance, main);
                frm.OperationType = OperationTypeEnum.OperationType.Look;

                frm.ShowDialog();
            }
        }

        void tool_top_litter_HistoryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listLitter.ActiveRow;
            if (row != null)
            {
                Raw_Main raw = row.ListObject as Raw_Main;
                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), raw.RawMain_Code);
                frm.Show();
            }
        }

        void tool_top_litter_RefreshClicked(object sender, EventArgs e)
        {
            LoadGridLitter();
        }


        #region 我的申请单
        void tool_top_my_RefreshClicked(object sender, EventArgs e)
        {
            LoadGridMyRawOrder();
        }

        void tool_top_my_DelClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listMy.ActiveRow;
            if (row != null)
            {
                DialogResult dia = Alert.Show(MessageBoxButtons.OKCancel, "确定删除所选单据吗?");

                if (dia == DialogResult.OK)
                {

                    Raw_Main main = row.ListObject as Raw_Main;
                    if (main.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                    {
                        var flag = rawInstance.Delete(main.RawMain_Code);
                        if (flag)
                        {
                            Alert.Show("订单已删除!");

                        }
                    }
                    else
                    {
                        Alert.Show("当前单据已经入审核流程，不能删除其数据!");
                    }
                    LoadGridMyRawOrder();
                }
            }
        }

        void tool_top_my_EditClicked(object sender, EventArgs e)
        {
            EditRawMain();
        }

        void EditRawMain()
        {
            UltraGridRow row = this.ug_listMy.ActiveRow;
            if (row != null)
            {
                Raw_Main main = row.ListObject as Raw_Main;

                Raw_Main newMain = rawInstance.GetModel(string.Format(" AND RawMain_Code='{0}'", main.RawMain_Code));



                RawRecAdmin frm = new RawRecAdmin(rawInstance, main);

                if (newMain.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
                {
                    Alert.Show("当前单据已进入审核流程，不能进行数据更新!");
                    frm.OperationType = OperationTypeEnum.OperationType.Look;
                }
                else
                {
                    frm.OperationType = OperationTypeEnum.OperationType.Edit;
                }
                frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                frm.ShowDialog();
                LoadGridMyRawOrder();
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadGridMyRawOrder();
        }


        void tool_top_my_AddClicked(object sender, EventArgs e)
        {
            RawRecAdmin frm = new RawRecAdmin(rawInstance, null);
            frm.OperationType = OperationTypeEnum.OperationType.Add;
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.ShowDialog();
            LoadGridMyRawOrder();
        }
        /// <summary>
        /// 我的申请单
        /// </summary>
        private void LoadGridMyRawOrder()
        {
            List<Raw_Main> list = new List<Raw_Main>();
            list = rawInstance.GetRawPOList("myraw");
            this.ug_listMy.DataSource = list;
        }




        #endregion

        #region 待审核

        private void OnAuditToolBarInit()
        {   //待审核工具条
            ToolStripButton tButton2 = new ToolStripButton();
            tButton2.Text = "审核";
            Image image2 = global::QX.Common.Properties.Resources.audit;　　　　//从资源文件中引用
            tButton2.Image = image2;
            tButton2.Size = new Size(43, 28);
            tButton2.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            this.tool_top_onaudit.AddCustomControl(tButton2);

            tButton2.Click += new EventHandler(this.btnAudit_Click);


            this.tool_top_onaudit.RefreshClicked += new EventHandler(tool_top_onaudit_RefreshClicked);


            this.tool_top_onaudit.QueryClicked += new EventHandler(tool_top_onaudit_QueryClicked);
        }

        void tool_top_onaudit_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listOnAudit.ActiveRow;
            if (row != null)
            {
                Raw_Main main = row.ListObject as Raw_Main;

                Raw_Main newMain = rawInstance.GetModel(string.Format(" AND RawMain_Code='{0}'", main.RawMain_Code));



                RawRecAdmin frm = new RawRecAdmin(rawInstance, main);
                frm.OperationType = OperationTypeEnum.OperationType.Look;

                frm.ShowDialog();
            }
        }

        void tool_top_onaudit_RefreshClicked(object sender, EventArgs e)
        {
            LoadGridOnAudit();
        }


        private void btnAudit_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listOnAudit.ActiveRow;
            if (row != null)
            {


                Raw_Main raw = row.ListObject as Raw_Main;

                RawRecAdmin viewFrm = new RawRecAdmin(rawInstance, raw, true);
                viewFrm.OperationType = OperationTypeEnum.OperationType.Edit;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), raw.RawMain_Code, raw.AuditCurAudit, viewFrm);
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
            UltraGridRow row = this.ug_listOnAudit.ActiveRow;

            switch (re)
            {
                case AuditReturnResultEnum.Success:
                    //if (AStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                    //{
                    //    Raw_Main main = row.ListObject as Raw_Main;
                    //    rawInstance.UpdateRaw(main);
                    //}
                    LoadGridOnAudit();
                    Alert.Show("审核完成");
                    break;
                case AuditReturnResultEnum.Fail:
                    Alert.Show("审核失败!");
                    break;
            }
        }

        /// <summary>
        /// 待审核
        /// </summary>
        private void LoadGridOnAudit()
        {
            List<Raw_Main> list = new List<Raw_Main>();
            list = rawInstance.GetRawPOList("onaudit");
            this.ug_listOnAudit.DataSource = list;
        }



        #endregion

        #region 终审


        ToolStripTextBox txtLastAuditKey = new ToolStripTextBox();

        private void LastAuditToolBarInit()
        {


            ToolStripHelper tsHelper = new ToolStripHelper();
            ToolStripLabel tLabel3 = new ToolStripLabel();
            tLabel3.Text = "关键字:";
            this.tool_top_lastaudit.AddCustomControl(4, tLabel3);


            this.tool_top_lastaudit.AddCustomControl(5, txtLastAuditKey);

            //搜索按钮
            ToolStripButton searchFinBtn = tsHelper.New("搜索", QX.Common.Properties.Resources.search, new EventHandler(searchFinBtn_Click));
            //searchFBtn.Click += new EventHandler(searchFBtn_Click);
            this.tool_top_lastaudit.AddCustomControl(6, searchFinBtn);


            //查看审核历史
            ToolStripButton auditFinBtn = tsHelper.New("审核历史", QX.Common.Properties.Resources.history, new EventHandler(auditFinBtn_Click));
            //searchFBtn.Click += new EventHandler(searchFBtn_Click);
            this.tool_top_lastaudit.AddCustomControl(7, auditFinBtn);
            this.tool_top_lastaudit.QueryClicked += new EventHandler(tool_top_lastaudit_QueryClicked);
            this.tool_top_lastaudit.RefreshClicked += new EventHandler(tool_top_lastaudit_RefreshClicked);

            ToolStripButton trashBtn = tsHelper.New("废弃", QX.Common.Properties.Resources.delete, new EventHandler(trashBtn_Click));
            trashBtn.Name = "btn_trash";
            tool_top_lastaudit.AddCustomControl(trashBtn);

            ToolStripButton exportLastBtn = tsHelper.New("导出", QX.Common.Properties.Resources.import, new EventHandler(exportLastBtn_Click));

            tool_top_lastaudit.AddCustomControl(exportLastBtn);
        }

        void trashBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listLastAudit.ActiveRow;
            if (row != null)
            {
                if (Alert.ShowIsConfirm("您的操作将不可回滚,确定废弃当前单据吗?"))
                {
                    Raw_Main main = row.ListObject as Raw_Main;

                    var re=rawInstance.TrashRaw(main);
                    if (re)
                    {
                        Alert.Show("废弃单据成功!");
                    }
                    else
                    {
                        Alert.Show("废弃单据失败!");
                    }

                }
            }
        }

        void exportLastBtn_Click(object sender, EventArgs e)
        {
            List<Raw_Main> list = this.ug_listLastAudit.DataSource as List<Raw_Main>;
            if (list.Count <= 0)
            {
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
                Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter export = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter();
                //this.uGridExport.EndExport += new Infragistics.Win.UltraWinGrid.ExcelExport.EndExportEventHandler(uGridExport_EndExport);

                UltraGrid grid = new UltraGrid();
                Panel p = new Panel();
                this.Controls.Add(p);
                grid = gen.GenerateGrid("CList_ExportRDetail", p, new Point(0, 0));
                DataTable dt = detailInstance.GetDataForExport(list);
                //DataTable dt = DetailInstance.GetCDetailForExport(list);
                grid.DataSource = dt;
                grid.Refresh();
                export.Export(grid, file);
                Alert.Show("导出完成!");

            }
        }

        void tool_top_lastaudit_QueryClicked(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listLastAudit.ActiveRow;
            if (row != null)
            {
                Raw_Main main = row.ListObject as Raw_Main;

                Raw_Main newMain = rawInstance.GetModel(string.Format(" AND RawMain_Code='{0}'", main.RawMain_Code));

                RawRecAdmin frm = new RawRecAdmin(rawInstance, main);
                frm.OperationType = OperationTypeEnum.OperationType.Look;

                frm.ShowDialog();
            }
        }

        void tool_top_lastaudit_RefreshClicked(object sender, EventArgs e)
        {
            LoadGridLastAudit();
        }

        void auditFinBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_listLastAudit.ActiveRow;
            if (row != null)
            {
                Raw_Main raw = row.ListObject as Raw_Main;
                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), raw.RawMain_Code);
                frm.Show();
            }
        }

        void searchFinBtn_Click(object sender, EventArgs e)
        {
            string key = txtLastAuditKey.Text;

            string where = string.Format(" AND (RawMain_Code like '%{0}%' or RawMain_Title like '%{0}%'  or RawMain_CmdCode like '%{0}%' or RawMain_SupName like '%{0}%')", key);

            var list = rawInstance.GetRawPOListWithFitler("lastaudit", where);

            ug_listLastAudit.DataSource = list;

        }

        /// <summary>
        /// 终审
        /// </summary>
        private void LoadGridLastAudit()
        {
            List<Raw_Main> list = new List<Raw_Main>();
            list = rawInstance.GetRawPOList("lastaudit");
            this.ug_listLastAudit.DataSource = list;
        }

        #endregion

        #region 废单
        /// <summary>
        /// 废单
        /// </summary>
        private void LoadGridLitter()
        {
            List<Raw_Main> list = new List<Raw_Main>();
            list = rawInstance.GetRawPOList("litter");
            this.ug_listLitter.DataSource = list;
        }

        #endregion
    }
}
