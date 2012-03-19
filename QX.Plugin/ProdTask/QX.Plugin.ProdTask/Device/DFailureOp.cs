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

namespace QX.Plugin.DeviceManage
{
    public partial class DFailureOp : F_BasicPop
    {
        public DFailureOp()
        {
            InitializeComponent();
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

        private Prod_Failure GModel = new Prod_Failure();
        private Bll_Bse_Equ mainInstance = null;
        //private Bll_Bse_Equ detailInstance = null;

        public DFailureOp(Bll_Bse_Equ _mainInstance, Prod_Failure _gmodel)
        {
            InitializeComponent();

            if (_mainInstance == null)
            {
                mainInstance = new Bll_Bse_Equ();
            }
            else
            {
                this.mainInstance = _mainInstance;
            }
            if (_gmodel == null)
            {
                _gmodel = new Prod_Failure();
            }
            else
            {
                GModel = _gmodel;
            }

            this.GModel = _gmodel;

            this.Load += new EventHandler(DFailureOp_Load);

            BindTopTool();
        }

        void DFailureOp_Load(object sender, EventArgs e)
        {
            LoadWindowControl();
        }


        public void BindTopTool()
        {
            ToolStripHelper TsHelper = new ToolStripHelper();
            this.tbDF.SaveClicked += new EventHandler(tool_bar_button_SaveClicked);
            //this.tbDF.AddCustomControl(TsHelper.New("保存", global::QX.Common.Properties.Resources.save, tool_bar_button_SaveClicked));
            tbDF.AddCustomControl(TsHelper.New("取消", global::QX.Common.Properties.Resources.finished, tool_bar_button_CancelClicked));
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
            //List<Raw_Detail> rawDetailList = new List<Raw_Detail>();

            //List<Raw_Detail> list = new List<Raw_Detail>();
            //BindingSource dataSourceTmp = new BindingSource();
            //dataSourceTmp.DataSource = list;
            //ug_list.DataSource = dataSourceTmp;



            //if (module == null)
            //    return;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    {

                        helper.GenerateForm("CForm_DFailure", this.gpBse, new Point(6, 20));
                        //Sys_PD_Module module = gbMain.Tag as Sys_PD_Module;
                        //gHelper.SetGridReadOnly(ug_list, true);
                        bindHelper.BindModelToControl<Prod_Failure>(GModel, this.gpBse.Controls, "");

                        break;
                    }
                case OperationTypeEnum.OperationType.Edit:
                    {

                        //编辑收货
                        helper.GenerateForm("CForm_DFailure", this.gpBse, new Point(6, 20));
                        //Sys_PD_Module module = gbMain.Tag as Sys_PD_Module;
                        bindHelper.BindModelToControl<Prod_Failure>(GModel, this.gpBse.Controls, "");


                        break;
                    }
                case OperationTypeEnum.OperationType.Add:
                    {
                        GModel.Failure_Code = mainInstance.GeneratePFailureCode();

                        helper.GenerateForm("CForm_DFailure", this.gpBse, new Point(6, 20));

                        bindHelper.BindModelToControl<Prod_Failure>(GModel, this.gpBse.Controls, "");

                        break;
                    }
                default:
                    break;
            }


        }

        private bool SaveData()
        {
            #region  保存数据
            bool result = false;
            Prod_Failure rawMain = new Prod_Failure();
            rawMain = GModel;
            //BindModelHelper helper = new BindModelHelper();
            //Sys_PD_Module module = this.Tag as Sys_PD_Module;
            //if (module == null)
            //{
            //    MessageShow(false);
            //    return false;
            //}

            bindHelper.BindControlToModel(rawMain, this.gpBse.Controls, "");


            if (rawMain == null)
            {
                return false;
            }

            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    //更新库存表(采购明细)

                    if (rawMain.Failure_Code != GModel.Failure_Code)
                    {
                        if (!CheckIsExist(rawMain.Failure_Code))
                        {
                            result = this.mainInstance.UpdatePFailure(rawMain);
                        }
                        else
                        {
                            MessageBox.Show("编号已经存在");

                        }
                    }
                    else
                    {
                        result = mainInstance.UpdateDFailure(rawMain);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:

                    if (!CheckIsExist(rawMain.Failure_Code))
                    {
                        rawMain.Stat = 0;
                        result = mainInstance.AddPFailure(rawMain);
                    }
                    else
                    {
                        MessageBox.Show("编号已经存在");

                    }
                    break;
                default:
                    break;
            }
            #endregion


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
