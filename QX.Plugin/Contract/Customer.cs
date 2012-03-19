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

namespace QX.Plugin.Contract
{
    public partial class Customer : F_BasicPop
    {
        private BLL.Bll_SD_Customer instance = null;
        private SD_Customer GModel = null;
        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public Customer(BLL.Bll_SD_Customer _instance,SD_Customer _gmodel)
        {
            InitializeComponent();
            this.instance = _instance;
            this.GModel = _gmodel;          
        }

        public Customer()
        {
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            SD_Customer model = new SD_Customer();
            BindModelHelper helper = new BindModelHelper();
            helper.BindControlToModel(model, this.Controls);
            if (model == null)
            {
                return;
            }
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    if (model.Cust_Code != GModel.Cust_Code)
                    {
                        if (!CheckIsExist(model.Cust_Code))
                        {
                            result = instance.Update(model);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        result = instance.Update(model);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    if (!CheckIsExist(model.Cust_Code))
                    {
                        result = instance.Insert(model);
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            MessageShow(result);
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


        /// <summary>
        /// 检查部门是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckIsExist(string NodeCode)
        {
            bool result = false;
            SD_Customer model = instance.GetModel(" AND (Cust_Code='" + NodeCode + "')");
            if (!String.IsNullOrEmpty(model.Cust_Code))
            {
                result = true;
                Alert.Show(GlobalConfiguration.CNLanguage["dept_codeone"]);
            }
            return result;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            btnSave.Click += new EventHandler(btnSave_Click);
            btnOk.Click += new EventHandler(btnOk_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click); 

            //操作类型
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    BindModelHelper modelHepler = new BindModelHelper();
                    modelHepler.BindModelToControl<SD_Customer>(GModel, this.Controls);
                    break;
                case OperationTypeEnum.OperationType.Add:
                    break;
                default:
                    break;
            }
        }


    }
}
