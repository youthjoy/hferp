using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataModel;

namespace QX.Shared
{
    public sealed  class SessionConfig
    {
        public static string UserID
        {
            get;
            set;
        }

        /// <summary>
        /// 登录用户名
        /// </summary>
        public static string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public static string EmpName
        {
            get;
            set;
        }

        /// <summary>
        /// 部门名称
        /// </summary>
        public static string DeptName
        {
            get;
            set;
        }


        /// <summary>
        /// 员工编号
        /// </summary>
        public static string UserCode
        {
            get;
            set;
        }

        /// <summary>
        /// 部门编码
        /// </summary>
        public static string DeptCode
        {
            get;
            set;
        }

        public static bool IsAdmin
        {
            get;
            set;
        }

        public static List<Sys_Function> PermissionList
        {
            get;
            set;
        }
    }
}
