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

namespace QX.Plugin.Prod.FHelper
{
    public partial class BatchIn : Form
    {
        public BatchIn()
        {
            InitializeComponent();
        }

        private BLL.Bll_FHelper_Info MainInstance = null;

        private Bll_Prod_Record prInstance = new Bll_Prod_Record();

        private FHelper_Info GModel = new FHelper_Info();
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

        //private QX.Common.C_Class.OperationTypeEnum.FHelper_Stat fHelperInnerType;
        ///// <summary>
        ///// 操作类型
        ///// </summary>
        //public QX.Common.C_Class.OperationTypeEnum.FHelper_Stat FHelperInnerType
        //{
        //    get { return fHelperInnerType; }
        //    set { fHelperInnerType = value; }
        //}

        string iType = "";

        //public BatchConfirmSup(Bll_FHelper_Info _instance, FHelper_Info _gmodel, string _iType, bool _isAudit)
        //{
        //    InitializeComponent();

        //    if (_instance == null)
        //    {
        //        MainInstance = new Bll_FHelper_Info();
        //    }
        //    else
        //    {
        //        this.MainInstance = _instance;
        //    }
        //    if (_gmodel == null)
        //    {
        //        _gmodel = new FHelper_Info();
        //    }
        //    this.GModel = _gmodel;

        //    iType = _iType;
        //    //GModel.FHelperInfo_iType = fHelperInnerType.ToString();

        //    BindTopTool();

        //    LoadWindowControl();

        //    if (string.IsNullOrEmpty(GModel.FHelperInfo_RefCode))
        //    {
        //        GModel.FHelperInfo_RefCode = GModel.FHelperInfo_Code;
        //    }
        //    refCode = GModel.FHelperInfo_Code;
        //    GModel.FHelperInfo_Code = MainInstance.GenerateCode();

        //    Sys_PD_Module module = gpMain.Tag as Sys_PD_Module;
        //    if (module == null)
        //    {
        //        helper.BindModelToControl(GModel, gpMain.Controls, "");
        //    }
        //    else
        //    {
        //        helper.BindModelToControl(GModel, gpMain.Controls, module.SPM_TPrefix);
        //    }
        //}
        public BatchIn(Bll_FHelper_Info _instance, List<FHelper_Info> list)
        {
            InitializeComponent();

            if (_instance == null)
            {
                MainInstance = new Bll_FHelper_Info();
            }
            else
            {
                this.MainInstance = _instance;
            }
            if (list[0] == null)
            {
                this.GModel = new FHelper_Info();

            }
            else
            {
                this.GModel = list[0];
            }

            BatchList = list;
            //GModel.FHelperInfo_iType = fHelperInnerType.ToString();
            if (GModel.FHelperInfo_iType == "FHelper")
            {
                iType = GModel.FHelperInfo_Stat;
            }
            else
            {
                iType = GModel.FHelperInfo_iType;
            }

            BindTopTool();

            LoadWindowControl();

            Sys_PD_Module module = gpMain.Tag as Sys_PD_Module;
            if (module == null)
            {
                helper.BindModelToControl(GModel, gpMain.Controls, "");
            }
            else
            {
                helper.BindModelToControl(GModel, gpMain.Controls, module.SPM_TPrefix);
            }
        }

        void BindViewTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));

        }

        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();

            if (iType != OperationTypeEnum.FHelper_Stat.Done.ToString())
            {
                this.commonToolBar1.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);
            }
            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));
            //this.commonToolBar1.DelClicked += new EventHandler(commonToolBar1_DelClicked);
        }

        void commonToolBar1_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                Alert.Show("数据更新完成!");
                this.Close();
            }

        }

        public bool SaveData()
        {

            bool flag = true;

            Sys_PD_Module module = this.gpMain.Tag as Sys_PD_Module;

            if (module == null)
            {
                Alert.Show("保存失败");
                return false;
            }

            helper.BindControlToModel(GModel, this.gpMain.Controls, module.SPM_TPrefix);

            FHelper_Info info = new FHelper_Info();

            if (GModel.FHelperInfo_iType == "ConfirmSup" && string.IsNullOrEmpty(GModel.FHelperInfo_FSup))
            {
                Alert.Show("请先选择供应商!");
                return false;
            }
            //下一状态
            nextStat = "WaitCheck";

            foreach (var l in BatchList)
            {

                string refcode=l.FHelperInfo_Code;

                var oldModel = MainInstance.GetModel(string.Format(" AND FHelperInfo_Code='{0}'", refcode));
                //原始单据类型
                oldModel.FHelperInfo_iType = "ConfirmSup";
                oldModel.FHelperInfo_Stat = nextStat;
                oldModel.FHelperInfo_FSup = GModel.FHelperInfo_FSup;
                oldModel.FHelperInfo_Price = GModel.FHelperInfo_Price;

                MainInstance.Update(oldModel);

                //下一阶段的单据的编号  
                l.FHelperInfo_Code = MainInstance.GenerateCode();

                l.FHelperInfo_FSup = GModel.FHelperInfo_FSup;
                l.FHelperInfo_Price = GModel.FHelperInfo_Price;
                l.FHelperInfo_RefCode = refcode;
                l.FHelperInfo_Stat = "No";
                l.FHelperInfo_iType = nextStat;
                if (nextStat == "WaitCheck")
                {
                    
                    l.FHelperInfo_BackDate=GModel.FHelperInfo_BackDate;
                }
                else if (nextStat == "WaitIn")
                { 
                   l.FHelperInfo_OutDate=GModel.FHelperInfo_OutDate;
                }
                if (!MainInstance.Insert(l))
                {
                    Alert.Show("更新数据出错");
                    return false;
                }

           
            }
            return flag;
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
            helper.GenerateForm("CForm_FH" + iType, gpMain, new Point(6, 20));

            GridHelper gen = new GridHelper();

            confirmGrid = gen.GenerateGrid("CList_BatchFHelper", this.pnlGrid, new Point(0, 0));
            confirmGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            confirmGrid.DataSource = BatchList;
        }

        void InitialWindowText()
        {
            switch (iType)
            {
                case "ConfirmSup":
                    this.Text = "外协供应商确认";
                    this.gpMain.Text = "外协供应商情况确认";
                    //nextStat = OperationTypeEnum.FHelper_Stat.WaitOut.ToString();
                    //GModel.FHelperInfo_OutDate = DateTime.Now;
                    //跳过待出厂状态
                    nextStat = OperationTypeEnum.FHelper_Stat.WaitIn.ToString();
                    GModel.FHelperInfo_OutDate = DateTime.Now;
                    break;
                case "WaitOut":
                    this.Text = "外协出库";
                    this.gpMain.Text = "外协出库";
                    nextStat = OperationTypeEnum.FHelper_Stat.WaitIn.ToString();
                    GModel.FHelperInfo_OutDate = DateTime.Now;
                    break;
                case "WaitIn":
                    this.Text = "外协入库";
                    this.gpMain.Text = "外协入库";
                    GModel.FHelperInfo_BackDate = DateTime.Now;
                    nextStat = OperationTypeEnum.FHelper_Stat.WaitCheck.ToString();
                    GModel.FHelperInfo_BackDate = DateTime.Now;
                    break;
                case "WaitCheck":
                    this.Text = "外协回厂检测";
                    this.gpMain.Text = "外协回厂检测确认";
                    nextStat = OperationTypeEnum.FHelper_Stat.Done.ToString();
                    
                    break;

                case "Done":
                    this.Text = "外协完成情况查询";
                    this.gpMain.Text = "外协情况查询";

                    SetReadOnly();
                    break;
            }
        }

        private void SetReadOnly()
        {
            foreach (Control ctr in gpMain.Controls)
            {
                ctr.Enabled = false;
            }
        }

        private void FHelperAdmin_Load(object sender, EventArgs e)
        {
            InitialWindowText();
        }
    }
}
