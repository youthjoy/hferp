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
    public partial class FHelperAdmin : F_BasicPop
    {
        private BLL.Bll_FHelper_Info MainInstance = null;

        private Bll_Prod_Record prInstance = new Bll_Prod_Record();

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

        public FHelperAdmin(Bll_FHelper_Info _instance, FHelper_Info _gmodel, string _iType, bool _isAudit)
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
            this.GModel = _gmodel;

            iType = _iType;
            //GModel.FHelperInfo_iType = fHelperInnerType.ToString();

            BindTopTool();

            LoadWindowControl();

            //如果没有参考单据，则默认为自己
            if (string.IsNullOrEmpty(GModel.FHelperInfo_RefCode))
            {
                GModel.FHelperInfo_RefCode = GModel.FHelperInfo_Code;
            }

            refCode = GModel.FHelperInfo_Code;

            //下一阶段的单据的编号  
            GModel.FHelperInfo_Code = MainInstance.GenerateCode();

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
        public FHelperAdmin(Bll_FHelper_Info _instance, FHelper_Info _gmodel)
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
            this.GModel = _gmodel;

            //GModel.FHelperInfo_iType = fHelperInnerType.ToString();
            if (GModel.FHelperInfo_iType == "FHelper")
            {
                iType = GModel.FHelperInfo_Stat;
            }
            else
            {
                iType = GModel.FHelperInfo_iType;
            }
            BindViewTool();

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
            //this.commonToolBar1.DelClicked += new EventHandler(commonToolBar1_DelClicked);
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

            //更新参考单据 出厂
            if (iType != OperationTypeEnum.FHelper_Stat.ConfirmSup.ToString())
            {

                //确认前的单据
                info = MainInstance.GetModel(" and FHelperInfo_Code='" + refCode + "'");//更新原单据
                //待入厂
                if (iType == OperationTypeEnum.FHelper_Stat.WaitIn.ToString())
                {
                    info.FHelperInfo_BackDate = DateTime.Now;

                }//待出厂
                else if (iType == OperationTypeEnum.FHelper_Stat.WaitOut.ToString())
                {
                    info.FHelperInfo_OutDate = DateTime.Now;
                }

                if (info != null)
                {
                    info.FHelperInfo_Stat = "Yes";
                    //确认前的单据 相关状态更新
                    if (!MainInstance.Update(info))
                    {
                        Alert.Show("更新数据出错");
                        return false;
                    }
                }

                //更新原单据   最原始的单据信息 （确认出入厂时候的那个单据） 实时跟踪其Stat处于哪一个状态
                info = MainInstance.GetModel(" and FHelperInfo_Code='" + GModel.FHelperInfo_RefCode + "'");//更新原单据
                
                //待入厂
                if (iType == OperationTypeEnum.FHelper_Stat.WaitIn.ToString())
                {
                    info.FHelperInfo_BackDate = DateTime.Now;

                }//待出厂
                else if (iType == OperationTypeEnum.FHelper_Stat.WaitOut.ToString())
                {
                    info.FHelperInfo_OutDate = DateTime.Now;
                }
                info.FHelperInfo_Stat = nextStat;
                MainInstance.Update(info);
            }
            else
            {
                //原始单据  扭转为下一状态
                info = MainInstance.GetModel(" and FHelperInfo_Code='" + GModel.FHelperInfo_RefCode + "'");//更新原单据
                helper.BindControlToModel(info, this.gpMain.Controls, module.SPM_TPrefix);
                info.FHelperInfo_RefCode = "";
                //info.FHelperInfo_Stat = "Yes";
                info.FHelperInfo_Code = refCode;
                info.FHelperInfo_Stat = nextStat;
                info.FHelperInfo_OutDate = DateTime.Now;
                MainInstance.Update(info);
            }

            #region 参考数据插入(下一状态的单据（即下一状态单据类型  要显示的数据）)

            GModel.FHelperInfo_Stat = "No";
            GModel.FHelperInfo_iType = nextStat;

            ///完工
            if (GModel.FHelperInfo_iType == "Done")
            {
                if (string.IsNullOrEmpty(GModel.FHelperInfo_IsBatch))
                {
                    MethodInvoker m = delegate { prInstance.SetFHelperFinish(GModel.FHelperInfo_ProdCode, GModel.FHelperInfo_RoadNodes); };

                    m.BeginInvoke(null, null);
                }
                else
                {
                    MethodInvoker m = delegate { prInstance.SetFHelperFinishForBatch(GModel.FHelperInfo_ProdCode, GModel.FHelperInfo_IsBatch); };

                    m.BeginInvoke(null, null);
                }
            }

            if (!MainInstance.Insert(GModel))
            {
                Alert.Show("更新数据出错");
                return false;
            }

            #endregion

            return flag;
        }

        void commonToolBar1_DelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            BindModelHelper bindHelper = new BindModelHelper();
            helper.GenerateForm("CForm_FH" + iType, gpMain, new Point(6, 20));

            var com = bindHelper.FindCtl<UltraCombo>(this.gpMain.Controls, "FHelperInfo_FSup");

           if (com != null)
           {
               com.BeforeDropDown += new CancelEventHandler(com_BeforeDropDown);
           }

        }

        void com_BeforeDropDown(object sender, CancelEventArgs e)
        {
            FHelperSupSel supSel = new FHelperSupSel();
            supSel.CallBack += new FHelperSupSel.DCallBackHandler(supSel_CallBack);
            supSel.ShowDialog();
            e.Cancel = true;

        }

        void supSel_CallBack(bool result, FHelper_Price model)
        {
            if (model != null)
            {
                BindModelHelper bindHelper = new BindModelHelper();
                var com = bindHelper.FindCtl<UltraCombo>(this.gpMain.Controls, "FHelperInfo_FSup");
                com.Value = model.FP_ManuCode;
                com.Text = model.FP_ManuName;
            }
        }

        void InitialWindowText()
        {
            switch (iType)
            {
                case "ConfirmSup":
                    this.Text = "外协供应商确认";
                    this.gpMain.Text = "外协供应商情况确认";
                    //nextStat = OperationTypeEnum.FHelper_Stat.WaitOut.ToString();
                    GModel.FHelperInfo_OutDate = DateTime.Now;
                    //跳过待出厂状态
                    nextStat = OperationTypeEnum.FHelper_Stat.WaitIn.ToString();
                    break;
                case "WaitOut":
                    this.Text = "外协出库";
                    this.gpMain.Text = "外协出库";
                    nextStat = OperationTypeEnum.FHelper_Stat.WaitIn.ToString();
                    break;
                case "WaitIn":
                    this.Text = "外协入库";
                    this.gpMain.Text = "外协入库";
                    GModel.FHelperInfo_BackDate = DateTime.Now;
                    nextStat = OperationTypeEnum.FHelper_Stat.WaitCheck.ToString();
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
