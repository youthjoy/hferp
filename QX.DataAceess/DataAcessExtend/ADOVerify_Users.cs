using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOVerify_Users
    {
        /// <summary>
        /// 获取指定的审核阶段用户 Verify_Users对象集合
        /// </summary>
        public List<Verify_Users> GetListByWhereExtend(string strCondition)
        {
            List<Verify_Users> ret = new List<Verify_Users>();
            string sql = @"SELECT  VU_ID,VerifyNode_Code,e.Emp_Name AS VU_UserName,Emp_Dept_Name AS VU_DeptName,VU_User,VU_Dept,VU_Duty,VerifyNode_Remark,Verify_Users.Stat,VT_Code
FROM Verify_Users 
JOIN Bse_Employee e on e.Emp_Code=Verify_Users.VU_User
WHERE 1=1 AND ((Verify_Users.Stat is null) or (Verify_Users.Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Verify_Users verify_Users = new Verify_Users();
                if (dr["VU_ID"] != DBNull.Value) verify_Users.VU_ID = Convert.ToDecimal(dr["VU_ID"]);
                if (dr["VU_VerifyNode_Code"] != DBNull.Value) verify_Users.VU_VerifyNode_Code = Convert.ToString(dr["VU_VerifyNode_Code"]);
                if (dr["VU_User"] != DBNull.Value) verify_Users.VU_User = Convert.ToString(dr["VU_User"]);
                if (dr["VU_Dept"] != DBNull.Value) verify_Users.VU_Dept = Convert.ToString(dr["VU_Dept"]);
                if (dr["VU_Duty"] != DBNull.Value) verify_Users.VU_Duty = Convert.ToString(dr["VU_Duty"]);
                if (dr["VU_VerifyTempldate_Code"] != DBNull.Value) verify_Users.VU_VerifyTempldate_Code = Convert.ToString(dr["VU_VerifyTempldate_Code"]);
                if (dr["Stat"] != DBNull.Value) verify_Users.Stat = Convert.ToInt32(dr["Stat"]);
                #region 扩展属性
                if (dr["VU_UserName"] != DBNull.Value) verify_Users.VU_UserName = Convert.ToString(dr["VU_UserName"]);
                if (dr["VU_DeptName"] != DBNull.Value) verify_Users.VU_DeptName = Convert.ToString(dr["VU_DeptName"]);

                #endregion
                ret.Add(verify_Users);
            }
            dr.Close();
            return ret;
        }

   
    }
}
