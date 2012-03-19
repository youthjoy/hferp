using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;
using QX.Common.C_Class;
using QX.PluginFramework;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.DeptManage
{
    public partial class Employee : F_BasicPop, IPligunShare
    {
        public delegate void DataChangeHandler(object sender, EventArgs e);
        public event DataChangeHandler DataChange;

        private Bll_Dept DeptInstance;
        private Bll_Bse_Employee EmployeeInstance;
        private Bll_Bse_Dict DictInstance = new Bll_Bse_Dict();
        private Bse_Employee EmplyeeModel;

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public Employee()
        {

        }

        public Employee(Bll_Bse_Employee employeeInstance, Bll_Dept deptInstance, Bse_Employee _EmplyeeModel)
        {
            InitializeComponent();
            DeptInstance = deptInstance;
            EmployeeInstance = employeeInstance;
            EmplyeeModel = _EmplyeeModel;

        }


        private void Employee_Load(object sender, EventArgs e)
        {
            FormHelper gen = new FormHelper();
            BindModelHelper helper = new BindModelHelper();
            //表单生成
            gen.GenerateForm("FEmp", this.groupBox1, new Point(6, 20));
            gen.GenerateForm("FOEmp", this.panel2, new Point(6, 20));
            gen.GenerateForm("FCEmp", this.panel1, new Point(6, 20));

            switch (operationType)
            { 
                case OperationTypeEnum.OperationType.Look:
                    this.btnSave.Enabled = false;
                    break;
                    
            }

            //编辑或添加判断
            if (EmplyeeModel != null)
            {

                helper.BindModelToControl<Bse_Employee>(EmplyeeModel, this.groupBox1.Controls, "");
                helper.BindModelToControl<Bse_Employee>(EmplyeeModel, this.panel1.Controls, "");
                helper.BindModelToControl<Bse_Employee>(EmplyeeModel, this.panel2.Controls, "");
            }
            else
            {
                EmplyeeModel = new Bse_Employee();
                EmplyeeModel.Emp_Code = EmployeeInstance.GenerateEmpCode();
                helper.BindModelToControl<Bse_Employee>(EmplyeeModel, this.groupBox1.Controls, "");
                helper.BindModelToControl<Bse_Employee>(EmplyeeModel, this.panel1.Controls, "");
                helper.BindModelToControl<Bse_Employee>(EmplyeeModel, this.panel2.Controls, "");
            }

            btnSave.Click += new EventHandler(btnSave_Click);
            //btnOk.Click += new EventHandler(btnOk_Click);
            //Emp_Dept_Code.Click += new EventHandler(Emp_Dept_Code_Click);
            //Emp_Dept_Name.Click += new EventHandler(Emp_Dept_Code_Click);
            btnCancle.Click += new EventHandler(btnCancle_Click);

       
            //LoadDict();
        }

        void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        void Emp_Dept_Code_Click(object sender, EventArgs e)
        {
            //DataTable dt = ConvertX.ToDataTable(DeptInstance.GetAllDept());
            //dt.TableName = "deptlist";
            CommDept<Bll_Dept, Bse_Department> CommDept = new CommDept<Bll_Dept, Bse_Department>(DeptInstance,
                new Size(350, 350));
            CommDept.CallBack += new CommDept<Bll_Dept, Bse_Department>.DCallBackHandler(CommDept_CallBack);
            CommDept.ShowDialog();
        }

        void CommDept_CallBack(object sender, DataTable list)
        {
            if (list != null && list.Rows.Count > 0)
            {
                //Emp_Dept_Code.Text = list.Rows[0]["Dept_Code"] != null ? list.Rows[0]["Dept_Code"].ToString() : string.Empty;
                //Emp_Dept_Name.Text = list.Rows[0]["Dept_Name"] != null ? list.Rows[0]["Dept_Name"].ToString() : string.Empty;
            }
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                this.Close();
            }

        }

        public bool SaveData()
        {
            bool result = false;
            Bse_Employee model = new Bse_Employee();
            BindModelHelper helper = new BindModelHelper();
            //helper.BindControlToModel<Bse_Employee>(model, this.Controls);
            var mobileEditor=helper.FindCtl<UltraTextEditor>(this.panel1.Controls, "Emp_Mobile");
          
            helper.BindControlToModel<Bse_Employee>(model, this.groupBox1.Controls, "");
            helper.BindControlToModel<Bse_Employee>(model, this.panel1.Controls, "");
            helper.BindControlToModel<Bse_Employee>(model, this.panel2.Controls, "");
            if (string.IsNullOrEmpty(mobileEditor.Text))
            {
                model.Emp_Mobile = "";
            }
            //model.Emp_TitleName = Emp_Title.Text;
            //model.Emp_DutyName = Emp_Duty.Text;
            if (model != null)
            {
                switch (operationType)
                {
                    case OperationTypeEnum.OperationType.Look:
                        break;
                    case OperationTypeEnum.OperationType.Edit:
                        QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                            , QX.Shared.SessionConfig.UserName
                            , "localhost"
                            , this.Name
                            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Employee
                            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Employee.ToString(), QX.Common.LogType.Edit.ToString());

                        if (model.Emp_Code != EmplyeeModel.Emp_Code)
                        {

                            if (!CheckEmployeeIsExist(model.Emp_Code))
                            {
                                result = EmployeeInstance.UpdateEmployee(model);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            result = EmployeeInstance.UpdateEmployee(model);
                        }
                        break;
                    case OperationTypeEnum.OperationType.Add:
                        QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                            , QX.Shared.SessionConfig.UserName
                            , "localhost"
                            , this.Name
                            , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Employee
                            , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Employee.ToString(), QX.Common.LogType.Add.ToString());

                        if (!CheckEmployeeIsExist(model.Emp_Code))
                        {
                            var order=Common.C_Class.Utils.TypeConverter.StrToInt(model.Emp_Code);
                            model.Emp_Order = order;
                            result = EmployeeInstance.InsertEmployee(model);
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case OperationTypeEnum.OperationType.Delete:
                        break;
                    case OperationTypeEnum.OperationType.Search:
                        break;
                    default:
                        break;
                }
            }
            if (result)
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
                if (DataChange != null)
                {
                    DataChange(model, EventArgs.Empty);
                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
            }
            return result;
        }

        /// <summary>
        /// 检查人员编号
        /// </summary>
        /// <param name="NodeCode"></param>
        /// <returns></returns>
        public bool CheckEmployeeIsExist(string NodeCode)
        {
            bool result = false;
            Bse_Employee model = EmployeeInstance.GetModel(" AND (Emp_Code='" + NodeCode + "')");
            if (!String.IsNullOrEmpty(model.Emp_Code))
            {
                result = true;
                Alert.Show(GlobalConfiguration.CNLanguage["dept_employeeone"]);
            }
            return result;
        }

        /// <summary>
        /// 加载字典：职称，职务
        /// </summary>
        public void LoadDict()
        {
            List<Bse_Dict> TitleCat = DictInstance.GetListByDictKeyByNoRoot(DictKeyEnum.TitleCat);
            List<Bse_Dict> DutyCat = DictInstance.GetListByDictKeyByNoRoot(DictKeyEnum.DutyCat);
            List<Bse_Dict> GenderCat = DictInstance.GetListByDictKeyByNoRoot(DictKeyEnum.GenderCat);
            if (TitleCat != null && TitleCat.Count > 0)
            {
                Bse_Dict d1 = new Bse_Dict();
                d1.Dict_Code = "";
                d1.Dict_Name = "";
                TitleCat.Insert(0, d1);
                //Emp_Title.DataSource = TitleCat;
                //Emp_Title.DisplayMember = "Dict_Name";
                //Emp_Title.ValueMember = "Dict_Code";
            }
            if (DutyCat != null && DutyCat.Count > 0)
            {
                Bse_Dict d1 = new Bse_Dict();
                d1.Dict_Code = "";
                d1.Dict_Name = "";
                DutyCat.Insert(0, d1);
                //Emp_Duty.DataSource = DutyCat;
                //Emp_Duty.DisplayMember = "Dict_Name";
                //Emp_Duty.ValueMember = "Dict_Code";
            }
            if (GenderCat != null && GenderCat.Count > 0)
            {
                Bse_Dict d1 = new Bse_Dict();
                d1.Dict_Code = "";
                d1.Dict_Name = "";
                GenderCat.Insert(0, d1);
                //Emp_Gendar.DataSource = GenderCat;
                //Emp_Gendar.DisplayMember = "Dict_Name";
                //Emp_Gendar.ValueMember = "Dict_Code";
            }
            if (operationType == OperationTypeEnum.OperationType.Edit)
            {
                //if (!String.IsNullOrEmpty(EmplyeeModel.Emp_Title)) Emp_Title.SelectedValue = EmplyeeModel.Emp_Title;
                //if (!String.IsNullOrEmpty(EmplyeeModel.Emp_Duty)) Emp_Duty.SelectedValue = EmplyeeModel.Emp_Duty;
                //if (!String.IsNullOrEmpty(EmplyeeModel.Emp_Gendar)) Emp_Duty.SelectedValue = EmplyeeModel.Emp_Gendar;
            }
        }


        #region IPligunShare 成员

        public void Start()
        {
            Bll_Dept deptInstance = new Bll_Dept();
            Bll_Bse_Employee employeeInstance = new Bll_Bse_Employee();
            Employee e = new Employee(employeeInstance, deptInstance, null);
            e.operationType = OperationTypeEnum.OperationType.Add;
            e.ShowDialog();
        }
        private Object inData;
        public object InData
        {
            get
            {
                return inData;
            }
            set
            {
                inData = value;
            }
        }

        public event EventHandler<EventArgs> CallBack;

        #endregion
    }
}
