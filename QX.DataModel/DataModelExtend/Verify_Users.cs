using System;
using System.Collections.Generic;
using System.Text;

namespace QX.DataModel
{
    public partial class Verify_Users
    {
        /// <summary>
        /// 阶段名称
        /// </summary>
        private string verifyNode_Name;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool verifyNode_Name_IsChanged = false;
        /// <summary>
        /// 阶段名称
        /// </summary>
        [MetaData("VerifyNode_Name", "阶段名称")]
        public string VerifyNode_Name
        {
            get { return verifyNode_Name; }
            set { verifyNode_Name = value; verifyNode_Name_IsChanged = true; }
        }


       
        /// <summary>
        /// 阶段名称
        /// </summary>
        private string verifyUser_Name;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool verifyUser_Name_IsChanged = false;
        /// <summary>
        /// 阶段名称
        /// </summary>
        [MetaData("VU_UserName", "用户")]
        public string VU_UserName
        {
            get { return verifyUser_Name; }
            set { verifyUser_Name = value; verifyUser_Name_IsChanged = true; }
        }


        /// <summary>
        /// 部门名称
        /// </summary>
        private string verifyDept_Name;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool verifyDept_Name_IsChanged = false;
        /// <summary>
        /// 部门名称
        /// </summary>
        [MetaData("VU_DeptName", "部门")]
        public string VU_DeptName
        {
            get { return verifyDept_Name; }
            set { verifyDept_Name = value; verifyDept_Name_IsChanged = true; }
        }
    }
}
