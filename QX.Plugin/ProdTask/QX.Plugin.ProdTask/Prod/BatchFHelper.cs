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
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;

namespace QX.Plugin.Prod
{
    public partial class BatchFHelper : Form
    {
        public BatchFHelper()
        {
            InitializeComponent();
        }

        public delegate void DCallBackHandler(bool result, Prod_Roads road);
        public event DCallBackHandler CallBack;
        private BLL.Bll_FHelper_Info MainInstance = null;

        private Bll_Prod_Record prInstance = new Bll_Prod_Record();
        private Bll_Prod_Roads proInstance = new Bll_Prod_Roads();
        private FHelper_Info GModel = new FHelper_Info();
        private string nextStat = "";
        private string refCode = "";
        BindModelHelper helper = new BindModelHelper();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public Prod_PlanProd PlanProd
        {
            get;
            set;
        }

        public List<Prod_PlanProd> PlanProdList
        {
            get;
            set;
        }

        public List<Prod_Roads> PRoadsList
        {
            get;
            set;
        }

        public BatchFHelper(Bll_FHelper_Info _instance, FHelper_Info _gmodel, Prod_PlanProd plan, List<Prod_Roads> roads)
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
            if (_gmodel == null)
            {
                _gmodel = new FHelper_Info();
            }
            this.OperationType = OperationTypeEnum.OperationType.Add;
            this.GModel = _gmodel;
            PlanProd = plan;
            PRoadsList = roads;
            BindTopTool();

            LoadWindowControl();

        }

        public BatchFHelper(List<Prod_PlanProd> plans, List<Prod_Roads> roads)
        {
            InitializeComponent();


            MainInstance = new Bll_FHelper_Info();

           

            this.OperationType = OperationTypeEnum.OperationType.Edit;
            this.GModel = new FHelper_Info();
            PlanProdList=plans;
            PlanProd = plans.FirstOrDefault();
            PRoadsList = roads;
            BindTopTool();

            LoadWindowControl();
        }

        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();

            this.commonToolBar1.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);

            commonToolBar1.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked));
            
        }

        void commonToolBar1_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().BatchFHelper
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.FHelper.ToString(), QX.Common.LogType.Edit.ToString());



                Alert.Show("数据更新完成!");
                this.Close();
            }

        }

        public bool SaveData()
        {
            var flag = true;
            BindModelHelper bindHelper = new BindModelHelper();
            bindHelper.BindControlToModel<FHelper_Info>(GModel, gpMain.Controls, "");

            if (OperationType == OperationTypeEnum.OperationType.Add)
            {
                StringBuilder sb = new StringBuilder();
                ///当前零件对应的工序节点批量更新
                foreach (var r in PRoadsList)
                {
                    sb.Append(r.PRoad_NodeCode).Append(",");
                    r.PRoad_ActBTime = DateTime.Now;
                    r.PRoad_NodeDepCode = GlobalConfiguration.MarketDept;
                    r.PRoad_NodeDepName = GlobalConfiguration.MarketName;
                    
                    proInstance.Update(r);
                }

                prInstance.BatchEnterFHelper(PlanProd,GModel, GModel.FHelperInfo_RoadNodes, sb.ToString().TrimEnd(','));
            }
            else
            {
                foreach (var p in PlanProdList)
                {
                    List<Prod_Roads> roads = proInstance.GetPlanRoadListByPlanCode(p.PlanProd_PlanCode);
                    StringBuilder sb = new StringBuilder();
                    ///当前零件对应的工序节点批量更新
                    foreach (var r in PRoadsList)
                    {
                        sb.Append(r.PRoad_NodeCode).Append(",");
                         //零件对应工艺模板
                        var ro=roads.FirstOrDefault(o => o.PRoad_NodeCode == r.PRoad_NodeCode&&o.PRoad_Order==r.PRoad_Order);
                        if (ro != null)
                        {
                            ro.PRoad_NodeDepCode = GlobalConfiguration.MarketDept;
                            ro.PRoad_NodeDepName = GlobalConfiguration.MarketName;
                            proInstance.Update(ro);
                        }
                    }
                    prInstance.BatchEnterFHelper(p,GModel, GModel.FHelperInfo_RoadNodes, sb.ToString().TrimEnd(','));
                }

                if (CallBack != null)
                {
                    CallBack(true, new Prod_Roads());
                }
                
            }

          

            return flag;
        }

        void commonToolBar1_DelClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        UltraCombo comboEditor = new UltraCombo();
        UltraTextEditor partNoEditor = new UltraTextEditor();
        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            BindModelHelper bindHelper = new BindModelHelper();
            helper.GenerateForm("CForm_FHBatchNode", gpMain, new Point(6, 20));
            StringBuilder sb = new StringBuilder();
            foreach (var pr in PRoadsList)
            {
                sb.Append(pr.PRoad_NodeName + ",");
            }
            sb.Append(PlanProd.PlanProd_Code);
            if (OperationType == OperationTypeEnum.OperationType.Add)
            {
                GModel.FHelperInfo_PartCode = PlanProd.PlanProd_PartNo;
                GModel.FHelperInfo_ProdCode = PlanProd.PlanProd_Code;
                GModel.FHelperInfo_RoadNodes = sb.ToString();
            }
            else
            {
                StringBuilder sp = new StringBuilder();
                foreach (var p in PlanProdList)
                {
                    sp.Append(p.PlanProd_Code).Append(",");
                }
                GModel.FHelperInfo_PartCode = PlanProd.PlanProd_PartNo;
                GModel.FHelperInfo_ProdCode = sp.ToString().TrimEnd(',');
                GModel.FHelperInfo_RoadNodes = sb.ToString();
            }
            bindHelper.BindModelToControl<FHelper_Info>(GModel, gpMain.Controls, "");

            comboEditor = bindHelper.FindCtl<UltraCombo>(this.gpMain.Controls, "FHelperInfo_FSup");
            comboEditor.Click += new EventHandler(combo_Click);
            partNoEditor = bindHelper.FindCtl<UltraTextEditor>(this.gpMain.Controls, "FHelperInfo_PartCode");
        }

        void combo_Click(object sender, EventArgs e)
        {
            QX.Plugin.Prod.ComControl.FSupSel supSel = new QX.Plugin.Prod.ComControl.FSupSel(partNoEditor.Value.ToString());
            supSel.CallBack += new QX.Plugin.Prod.ComControl.FSupSel.DCallBackHandler(supSel_CallBack);
            supSel.ShowDialog();
        }

        void supSel_CallBack(object sender, List<FHelper_Price> list)
        {
            comboEditor.Value = list[0].FP_ManuCode;
            comboEditor.Text = list[0].FP_ManuName;
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

        }
    }
}
