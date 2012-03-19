using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;

namespace QX.DataAceess
{
    public partial class ADOVerifyProcess_Records
    {
        /// <summary>
        /// 获取指定的审核流程记录表 VerifyProcess_Records对象集合
        /// </summary>
        public List<VerifyProcess_Records> GetListByWhereExtend(string strCondition)
        {
            List<VerifyProcess_Records> ret = new List<VerifyProcess_Records>();
            string sql = "SELECT  VRecord_ID,VRecord_Code,Module_Code,Record_ID,VRecord_VCode,(select top 1 Emp_Name from Bse_Employee where Emp_Code=VRecord_Owner) as VRecord_Owner,VRecord_Date,VRecord_Opinion,VRecord_Flag,VRecord_UDef1,VRecord_UDef2,VRecord_UDef3,VRecord_UDef4,VRecord_UDef5,VRecord_UDef6,Stat FROM VerifyProcess_Records WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = null;
            try
            {
                dr = (SqlDataReader)idb.ReturnReader(sql);
                while (dr.Read())
                {
                    VerifyProcess_Records verifyProcess_Records = new VerifyProcess_Records();
                    if (dr["VRecord_ID"] != DBNull.Value) verifyProcess_Records.VRecord_ID = Convert.ToDecimal(dr["VRecord_ID"]);
                    if (dr["VRecord_Code"] != DBNull.Value) verifyProcess_Records.VRecord_Code = Convert.ToString(dr["VRecord_Code"]);
                    if (dr["Module_Code"] != DBNull.Value) verifyProcess_Records.Module_Code = Convert.ToString(dr["Module_Code"]);
                    if (dr["Record_ID"] != DBNull.Value) verifyProcess_Records.Record_ID = Convert.ToString(dr["Record_ID"]);
                    if (dr["VRecord_VCode"] != DBNull.Value) verifyProcess_Records.VRecord_VCode = Convert.ToString(dr["VRecord_VCode"]);
                    if (dr["VRecord_Owner"] != DBNull.Value) verifyProcess_Records.VRecord_Owner = Convert.ToString(dr["VRecord_Owner"]);
                    if (dr["VRecord_Date"] != DBNull.Value) verifyProcess_Records.VRecord_Date = Convert.ToDateTime(dr["VRecord_Date"]);
                    if (dr["VRecord_Opinion"] != DBNull.Value) verifyProcess_Records.VRecord_Opinion = Convert.ToString(dr["VRecord_Opinion"]);
                    if (dr["VRecord_Flag"] != DBNull.Value) verifyProcess_Records.VRecord_Flag = Convert.ToString(dr["VRecord_Flag"]);
                    if (dr["VRecord_UDef1"] != DBNull.Value) verifyProcess_Records.VRecord_UDef1 = Convert.ToString(dr["VRecord_UDef1"]);
                    if (dr["VRecord_UDef2"] != DBNull.Value) verifyProcess_Records.VRecord_UDef2 = Convert.ToString(dr["VRecord_UDef2"]);
                    if (dr["VRecord_UDef3"] != DBNull.Value) verifyProcess_Records.VRecord_UDef3 = Convert.ToString(dr["VRecord_UDef3"]);
                    if (dr["VRecord_UDef4"] != DBNull.Value) verifyProcess_Records.VRecord_UDef4 = Convert.ToString(dr["VRecord_UDef4"]);
                    if (dr["VRecord_UDef5"] != DBNull.Value) verifyProcess_Records.VRecord_UDef5 = Convert.ToString(dr["VRecord_UDef5"]);
                    if (dr["VRecord_UDef6"] != DBNull.Value) verifyProcess_Records.VRecord_UDef6 = Convert.ToString(dr["VRecord_UDef6"]);
                    if (dr["Stat"] != DBNull.Value) verifyProcess_Records.Stat = Convert.ToInt32(dr["Stat"]);
                    ret.Add(verifyProcess_Records);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } }
            return ret;
        }
    }
}
