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

namespace QX.Plugin.Prod.Prod
{
    public partial class CancelFailure : F_BasicPop
    {
        public CancelFailure()
        {
            InitializeComponent();
        }


        private BLL.Bll_Failure_Information MainInstance = null;

        private Bll_Prod_Record prInstance = new Bll_Prod_Record();

        private Failure_Information GModel = new Failure_Information();
        private string nextStat = "";
        private string refCode = "";
        BindModelHelper helper = new BindModelHelper();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;

        private List<FHelper_Info> BatchList
        {

            get;
            set;
        }

        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public Failure_Information FInfo
        {
            get;
            set;
        }
        /// <summary>
        /// 所有审核记录
        /// </summary>
        public List<VerifyProcess_Records> VARecords
        {
            get;
            set;
        }

        public CancelFailure(Failure_Information finfo)
        {
            InitializeComponent();

            MainInstance = new Bll_Failure_Information();
            GModel = new Failure_Information();
            FInfo = finfo;
            BindTopTool();

            LoadWindowControl();

            this.Load += new EventHandler(CancelFailure_Load);
        }

        void CancelFailure_Load(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        void BindViewTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));

        }

        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();


            ToolStripButton cancelBtn = TsHelper.New("确定撤销", QX.Common.Properties.Resources.cancel, new EventHandler(cancel_Click));
            //cancel.Click += new EventHandler(cancel_Click);
            cancelBtn.Name = "cancelFInfoBtn";
            commonToolBar1.AddCustomControl(cancelBtn);
            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));
            //this.commonToolBar1.DelClicked += new EventHandler(commonToolBar1_DelClicked);
        }

        /// <summary>
        /// 撤销不合格审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cancel_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Alert.Show("数据更新完成!");
                this.Close();
            }
        }

 
        public Bll_VerifyProcess_Records vrInstance = new Bll_VerifyProcess_Records();
       
        public bool SaveData()
        {
            

            var list = GetGridCheckBoxData();

            if (list.Count == 0)
            {
                Alert.Show("请选择要撤销的阶段!");
                return false;
            }

            if (string.IsNullOrEmpty(txtReason.Text))
            {
                Alert.Show("请填写撤销原因!");
                return false;
            }
            //回滚到的节点
            var v = list.FirstOrDefault();

            //包括当前节点在内
            var alist = VARecords.Where(o => o.VRecord_ID >= v.VRecord_ID);
            
            if (alist != null && alist.Count() != 0)
            {
                foreach (var a in alist)
                {
                    a.Stat = 0;
                    a.VRecord_UDef5 = SessionConfig.UserName;
                    a.VRecord_UDef6 = txtReason.Text;
                    a.VRecord_UDef5 = "Return";
                    a.VRecord_UDef1 = "LastDone";
                    vrInstance.Update(a);
                }

                //var next=alist.FirstOrDefault();

                FInfo.AuditCurAudit =v.VRecord_VCode ;
                MainInstance.UpdateFailure(FInfo);

            }//只有一步
            else if (VARecords.Count == 1)
            {
                v.Stat = 0;
                v.VRecord_UDef5 = SessionConfig.UserName;
                v.VRecord_UDef6 = txtReason.Text;
                v.VRecord_UDef5 = "Return";
                v.VRecord_UDef1 = "LastDone";
                vrInstance.Update(v);

                FInfo.AuditCurAudit = v.VRecord_VCode;
                MainInstance.UpdateFailure(FInfo);
            }
            else
            {
                v.Stat = 0;
                v.VRecord_UDef5 = SessionConfig.UserName;
                v.VRecord_UDef6 = txtReason.Text;
                v.VRecord_UDef1 = "LastDone";
                vrInstance.Update(v);

                FInfo.AuditCurAudit = v.VRecord_VCode;
                MainInstance.UpdateFailure(FInfo);
            }
           

            return true;

        }

        void commonToolBar1_DelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        UltraGrid confirmGrid = new UltraGrid();

        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            BindModelHelper bindHelper = new BindModelHelper();
            //helper.GenerateForm("CForm_BatchFH" + iType, gpMain, new Point(6, 20));

            GridHelper gen = new GridHelper();

            confirmGrid = gen.GenerateGrid("CList_GAuditHistory", this.panel1, new Point(6, 20));

            confirmGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            //confirmGrid.DataSource = new List<VerifyProcess_Records>();

            AddCustomColumn();
        }

        private void AddCustomColumn()
        {

            if (!this.confirmGrid.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = confirmGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;

            }
            else
            {
                confirmGrid.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = confirmGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;
            }


        }

        private List<VerifyProcess_Records> GetGridCheckBoxData()
        {
            List<VerifyProcess_Records> list = new List<VerifyProcess_Records>();

            foreach (UltraGridRow r in this.confirmGrid.DisplayLayout.Rows)
            {

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    VerifyProcess_Records planProd = r.ListObject as VerifyProcess_Records;
                    list.Add(planProd);
                }
            }

            return list;
        }

        public void BindDataGrid()
        {
            List<VerifyProcess_Records> list = new List<VerifyProcess_Records>();

            list = new Bll_Audit().VerfiyProcessRecords("FailureAudit_F001", FInfo.FInfo_Code);
            VARecords = list;
            confirmGrid.DataSource = VARecords.Where(o=>string.IsNullOrEmpty(o.VRecord_UDef6)).ToList();

            AddCustomColumn();

        }

   

    }
}
