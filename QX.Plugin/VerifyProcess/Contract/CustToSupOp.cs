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
using QX.Common.C_Class;
using QX.Framework.AutoForm;
using QX.Shared;

namespace QX.Plugin.Contract
{
    public partial class CustToSupOp : F_BasicPop
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

            public CustToSupOp(string dataType, BLL.Bll_SD_Customer _instance, SD_Customer _gmodel)
            {
                InitializeComponent();
                this.instance = _instance;
                this.GModel = _gmodel;
                DataType = dataType;

                this.Load += new EventHandler(Customer_Load);
            }


            private string DataType
            {
                get;
                set;
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


                helper.BindControlToModel(model, this.groupBox1.Controls, "");
                helper.BindControlToModel(model, this.panel1.Controls, "");


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
                                model.Cust_Type = "GSup";
                                result = instance.CreateToSup(model);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            model.Cust_Type = "GSup";
                            //result = instance.Update(model);
                            result = instance.CreateToSup(model);
                        }
                        break;
                    case OperationTypeEnum.OperationType.Add:

                        //录入人
                        model.Cust_Owner = SessionConfig.UserName;
                        model.Cust_Date = DateTime.Now;

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
                switch (DataType)
                {
                    case "GCustomer": this.Text = "客户管理"; break;
                    case "GSup": this.Text = "供应商管理"; break;
                    case "GFHelper": this.Text = "外协厂商管理"; break;
                }
                FormHelper gen = new FormHelper();

                gen.GenerateForm("F" + DataType, this.groupBox1, new Point(6, 20));

                gen.GenerateForm("FC" + DataType, this.panel1, new Point(6, 20));

                btnSave.Click += new EventHandler(btnSave_Click);

                //btnOk.Click += new EventHandler(btnOk_Click);
                //btnAdd.Click += new EventHandler(btnAdd_Click);
                BindModelHelper modelHepler = new BindModelHelper();
                //操作类型
                switch (operationType)
                {
                    case OperationTypeEnum.OperationType.Look:
                        //btnOk.Enabled = false;
                        btnSave.Enabled = false;
                        break;
                    case OperationTypeEnum.OperationType.Edit:

                        GModel.Cust_TypeCode = string.Empty ;
                        GModel.Cust_Code = instance.GenerateCustCode();
                        modelHepler.BindModelToControl<SD_Customer>(GModel, this.groupBox1.Controls, "");

                        modelHepler.BindModelToControl<SD_Customer>(GModel, this.panel1.Controls, "");

                        break;
                    case OperationTypeEnum.OperationType.Add:

                        GModel = new SD_Customer();

                        GModel.Cust_Code = instance.GenerateCustCode();
                        //类型
                        GModel.Cust_Type = DataType;

                        modelHepler.BindModelToControl<SD_Customer>(GModel, this.groupBox1.Controls, "");

                        break;
                    default:
                        break;
                }
            }


        
    }
}
