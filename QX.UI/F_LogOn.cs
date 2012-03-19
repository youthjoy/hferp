using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Framework.AutoForm;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using QX.Shared;

namespace QX.UI
{
    public partial class F_LogOn : QX.Common.C_Form.F_BasicPop
    {
        public F_LogOn(MethodInvoker mi)
        {
            InitializeComponent();

            mInvoker = mi;
        }

        private MethodInvoker mInvoker;

        private void InitData()
        {
            FormHelper gen = new FormHelper();

            //gen.GenerateForm("FLogin", this.groupBox1, new Point(6, 20));

        }

        private void F_LogOn_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            
            Login();

            QX.Log.PlateLog.WriteOp(SessionConfig.UserCode, SessionConfig.UserName, "", this.Name, DateTime.Now.ToString() + "," + SessionConfig.UserName + "登陆", QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.LoginModule.ToString(), QX.Common.LogType.Login.ToString());
        }

        private BindModelHelper bmHelper = new BindModelHelper();

        private BLL.Bll_Login loginInstance = new QX.BLL.Bll_Login();

        private Bll_UserPermission peInstance = new Bll_UserPermission();

        private Bse_Employee CurEmp = new Bse_Employee();

        private void Login()
        {
            string userName = this.txtUserName.Text;

            string password = this.txtPassword.Text;

            LoginResultEnum re = loginInstance.CheckLogin(userName, password, out CurEmp);

            switch (re)
            {
                case LoginResultEnum.Success:
                    Success();
                    break;
                case LoginResultEnum.InValidName:
                    Alert.Show("用户名无效!");
                    break;
                case LoginResultEnum.InValidPwd:
                    Alert.Show("密码输入错误!");
                    break;
                case LoginResultEnum.NoExsist:
                    Alert.Show("当前用户已失效!");
                    break;
                case LoginResultEnum.Fail:
                    Alert.Show("登录出现异常,请查证后重新登录!");
                    break;
            }

        }

        private void Success()
        {
            //
            QX.Shared.SessionConfig.UserID = this.txtUserName.Text;
            QX.Shared.SessionConfig.UserName = CurEmp.Emp_Name;
            QX.Shared.SessionConfig.UserCode = CurEmp.Emp_Code;
            QX.Shared.SessionConfig.DeptCode = CurEmp.Emp_Dept_Code;
            QX.Shared.SessionConfig.EmpName = CurEmp.Emp_Name;
            QX.Shared.SessionConfig.DeptName = CurEmp.Emp_Dept_Name;

            if (QX.Shared.SessionConfig.UserID==GlobalConfiguration.Admin||peInstance.IsAdmin(CurEmp.Emp_Code))
            {
                QX.Shared.SessionConfig.IsAdmin = true;
                List<Sys_Function> list = peInstance.GetAllFunctionList("1");
                SessionConfig.PermissionList = list;
            }
            else
            {
                QX.Shared.SessionConfig.IsAdmin = false;
                List<Sys_UserPermission> list = peInstance.GetUserPermissionList(SessionConfig.UserID);
                var temp = from p in list select new Sys_Function { Fun_Code = p.PU_FunCode };
                SessionConfig.PermissionList=temp.ToList();
            }
            mInvoker.BeginInvoke(null, null);

            this.Hide();
        }

        private void F_LogOn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
