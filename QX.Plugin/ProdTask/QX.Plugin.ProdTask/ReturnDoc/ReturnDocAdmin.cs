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
using QX.BLL;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Shared;
using System.Linq;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.ReturnDoc
{
    public partial class ReturnDocAdmin : F_BasicPop
    {
        private BLL.Bll_Inv_Movement MainInstance = null;
        private Inv_Movement GModel = null;

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public ReturnDocAdmin(BLL.Bll_Inv_Movement _instance, Inv_Movement _gmodel)
        {
            InitializeComponent();
            if(_instance==null)
            {
                MainInstance = new Bll_Inv_Movement();
            }
            else
            {
                this.MainInstance = _instance;
            }
            if (_gmodel == null)
            {
                GModel = new Inv_Movement();
            }
            else
            {
                GModel = _gmodel;
            }
            //btnOk.Click+=new EventHandler(btnOk_Click);
            btnSave.Click+=new EventHandler(btnSave_Click);
            btnCancle.Click += new EventHandler(btnCancle_Click);

            this.Load += new EventHandler(RawManage_Load);
        }

        //void btnOk_Click(object sender, EventArgs e)
        //{
        //    if(SaveData())
        //    {}
        //}

        void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                this.Close();
            }
        }

        void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        private bool SaveData()
        {
            #region  保存数据
            bool result = false;
            BindModelHelper helper = new BindModelHelper(); 
            Sys_PD_Module module = gp_top.Tag as Sys_PD_Module;
            if (module == null)
            {
                MessageShow(false);
                return false;
            }

            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    Inv_Movement inv_Monvement = new Inv_Movement();
                    helper.BindControlToModel(inv_Monvement, this.gp_top.Controls, module.SPM_TPrefix);

                    if (inv_Monvement == null)
                    {
                        return false;
                    }

                    if (inv_Monvement.MV_Code != GModel.MV_Code)
                    {
                        if (!CheckIsExist(inv_Monvement.MV_Code))
                        {
                            result = MainInstance.Update(inv_Monvement);
                        }
                        else
                        {
                            MessageBox.Show("指令编号已经存在");
                            return false;
                        }
                    }
                    else
                    {
                        result = MainInstance.Update(inv_Monvement);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:

                    helper.BindControlToModel(GModel, this.gp_top.Controls, module.SPM_TPrefix);

                    if (!CheckIsExist(GModel.MV_Code))
                    {
                        result = MainInstance.Insert(GModel);
                    }
                    else
                    {
                        MessageBox.Show("指令编号已经存在");
                        return false;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            MessageShow(result);
            return result;
        }

        /// <summary>
        /// 操作提示
        /// </summary>
        /// <param name="result"></param>
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

        private void RawManage_Load(object sender, EventArgs e)
        {
            LoadWindowControl();
        }

        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckIsExist(string NodeCode)
        {
            bool result = false;
            //Inv_Movement model = MainInstance.GetModel(" AND (MV_Code='" + NodeCode + "')");
            //if (model != null && !String.IsNullOrEmpty(model.MV_Code))
            //{
            //    result = true;
            //}
            return result;
        }

        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();
            helper.GenerateForm("CForm_ReturnDoc", gp_top, new Point(6, 20));

            Sys_PD_Module module = gp_top.Tag as Sys_PD_Module;
            if (module == null)
                return;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    BindDataToControl();
                    this.btnSave.Enabled = false;
                    //this.btnOk.Enabled = false;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    BindDataToControl();
                    break;
                case OperationTypeEnum.OperationType.Add:
                    GModel.MV_Code = MainInstance.GenerateCommandCode();
                    UltraTextEditor txt_MV_Code = Controls.Find("MV_Code", true)[0] as UltraTextEditor;
                    txt_MV_Code.Text = GModel.MV_Code;
                    GModel.CreateTime = DateTime.Now;
                    GModel.Stat = 0;
                    GModel.UpdateTime = DateTime.Now;
                    GModel.MV_Type = "退货单";
                    GModel.MV_Creator = SessionConfig.UserCode;
                    break;
                default:
                    break;
            }            
        }

        private void BindDataToControl()
        {
            BindModelHelper bmHelper = new BindModelHelper();
            bmHelper.BindModelToControl<Inv_Movement>(GModel, gp_top.Controls, "");
        }
    }
}
