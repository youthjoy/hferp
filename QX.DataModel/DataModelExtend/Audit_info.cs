using System;
using System.Collections.Generic;
using System.Text;

namespace QX.DataModel
{
    public class Audit_info
    {
        /// <summary>
        /// 模板序号
        /// </summary>
        private int vT_ID;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vT_ID_IsChanged = false;
        /// <summary>
        /// 模板序号
        /// </summary>
        [MetaData("VT_ID", "模板序号")]
        public int VT_ID
        {
            get { return vT_ID; }
            set { vT_ID = value; vT_ID_IsChanged = true; }
        }
        /// <summary>
        /// 模板序号
        /// </summary>
        public bool VT_ID_IsChanged
        {
            get { return vT_ID_IsChanged; }
            set { vT_ID_IsChanged = value; }
        }
        /// <summary>
        /// 模板关键字
        /// </summary>
        private string vT_Key;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vT_Key_IsChanged = false;
        /// <summary>
        /// 模板关键字
        /// </summary>
        [MetaData("VT_Key", "模板关键字")]
        public string VT_Key
        {
            get { return vT_Key; }
            set { vT_Key = value; vT_Key_IsChanged = true; }
        }
        /// <summary>
        /// 模板关键字
        /// </summary>
        public bool VT_Key_IsChanged
        {
            get { return vT_Key_IsChanged; }
            set { vT_Key_IsChanged = value; }
        }
        private int vT_NodeOrder;
        private bool vT_NodeOrder_IsChanged = false;
        [MetaData("VT_NodeOrder", "")]
        public int VT_NodeOrder
        {
            get { return vT_NodeOrder; }
            set { vT_NodeOrder = value; vT_NodeOrder_IsChanged = true; }
        }
        public bool VT_NodeOrder_IsChanged
        {
            get { return vT_NodeOrder_IsChanged; }
            set { vT_NodeOrder_IsChanged = value; }
        }
        private string vT_Remark;
        private bool vT_Remark_IsChanged = false;
        [MetaData("VT_Remark", "")]
        public string VT_Remark
        {
            get { return vT_Remark; }
            set { vT_Remark = value; vT_Remark_IsChanged = true; }
        }
        public bool VT_Remark_IsChanged
        {
            get { return vT_Remark_IsChanged; }
            set { vT_Remark_IsChanged = value; }
        }
        /// <summary>
        /// 模板阶段序号
        /// </summary>
        private string vT_No;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vT_No_IsChanged = false;
        /// <summary>
        /// 模板阶段序号
        /// </summary>
        [MetaData("VT_No", "模板阶段序号")]
        public string VT_No
        {
            get { return vT_No; }
            set { vT_No = value; vT_No_IsChanged = true; }
        }
        /// <summary>
        /// 模板阶段序号
        /// </summary>
        public bool VT_No_IsChanged
        {
            get { return vT_No_IsChanged; }
            set { vT_No_IsChanged = value; }
        }
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
        public bool VerifyNode_Name_IsChanged
        {
            get { return verifyNode_Name_IsChanged; }
            set { verifyNode_Name_IsChanged = value; }
        }
        private string verifyNode_Remark;
        private bool verifyNode_Remark_IsChanged = false;
        [MetaData("VerifyNode_Remark", "")]
        public string VerifyNode_Remark
        {
            get { return verifyNode_Remark; }
            set { verifyNode_Remark = value; verifyNode_Remark_IsChanged = true; }
        }
        public bool VerifyNode_Remark_IsChanged
        {
            get { return verifyNode_Remark_IsChanged; }
            set { verifyNode_Remark_IsChanged = value; }
        }
        private string flag;
        private bool flag_IsChanged = false;
        [MetaData("Flag", "")]
        public string Flag
        {
            get { return flag; }
            set { flag = value; flag_IsChanged = true; }
        }
        public bool Flag_IsChanged
        {
            get { return flag_IsChanged; }
            set { flag_IsChanged = value; }
        }
        private int stat;
        private bool stat_IsChanged = false;
        [MetaData("Stat", "")]
        public int Stat
        {
            get { return stat; }
            set { stat = value; stat_IsChanged = true; }
        }
        public bool Stat_IsChanged
        {
            get { return stat_IsChanged; }
            set { stat_IsChanged = value; }
        }

        /// <summary>
        /// 审核用户序号
        /// </summary>
        private int vU_ID;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vU_ID_IsChanged = false;
        /// <summary>
        /// 审核用户序号
        /// </summary>
        [MetaData("VU_ID", "审核用户序号")]
        public int VU_ID
        {
            get { return vU_ID; }
            set { vU_ID = value; vU_ID_IsChanged = true; }
        }
        /// <summary>
        /// 审核用户序号
        /// </summary>
        public bool VU_ID_IsChanged
        {
            get { return vU_ID_IsChanged; }
            set { vU_ID_IsChanged = value; }
        }
        /// <summary>
        /// 阶段编码
        /// </summary>
        private string verifyNode_Code;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool verifyNode_Code_IsChanged = false;
        /// <summary>
        /// 阶段编码
        /// </summary>
        [MetaData("VerifyNode_Code", "阶段编码")]
        public string VerifyNode_Code
        {
            get { return verifyNode_Code; }
            set { verifyNode_Code = value; verifyNode_Code_IsChanged = true; }
        }
        /// <summary>
        /// 阶段编码
        /// </summary>
        public bool VerifyNode_Code_IsChanged
        {
            get { return verifyNode_Code_IsChanged; }
            set { verifyNode_Code_IsChanged = value; }
        }
        /// <summary>
        /// 用户
        /// </summary>
        private string vU_User;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vU_User_IsChanged = false;
        /// <summary>
        /// 用户
        /// </summary>
        [MetaData("VU_User", "用户")]
        public string VU_User
        {
            get { return vU_User; }
            set { vU_User = value; vU_User_IsChanged = true; }
        }
        /// <summary>
        /// 用户
        /// </summary>
        public bool VU_User_IsChanged
        {
            get { return vU_User_IsChanged; }
            set { vU_User_IsChanged = value; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        private string vU_Dept;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vU_Dept_IsChanged = false;
        /// <summary>
        /// 部门
        /// </summary>
        [MetaData("VU_Dept", "部门")]
        public string VU_Dept
        {
            get { return vU_Dept; }
            set { vU_Dept = value; vU_Dept_IsChanged = true; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public bool VU_Dept_IsChanged
        {
            get { return vU_Dept_IsChanged; }
            set { vU_Dept_IsChanged = value; }
        }
        /// <summary>
        /// 职务
        /// </summary>
        private string vU_Duty;
        /// <summary>
        /// 改变标识
        /// </summary>
        private bool vU_Duty_IsChanged = false;
        /// <summary>
        /// 职务
        /// </summary>
        [MetaData("VU_Duty", "职务")]
        public string VU_Duty
        {
            get { return vU_Duty; }
            set { vU_Duty = value; vU_Duty_IsChanged = true; }
        }
        /// <summary>
        /// 职务
        /// </summary>
        public bool VU_Duty_IsChanged
        {
            get { return vU_Duty_IsChanged; }
            set { vU_Duty_IsChanged = value; }
        }
        private string vT_Code;
        private bool vT_Code_IsChanged = false;
        [MetaData("VT_Code", "")]
        public string VT_Code
        {
            get { return vT_Code; }
            set { vT_Code = value; vT_Code_IsChanged = true; }
        }
        public bool VT_Code_IsChanged
        {
            get { return vT_Code_IsChanged; }
            set { vT_Code_IsChanged = value; }
        }
    }
}
