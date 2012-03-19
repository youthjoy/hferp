using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOSD_Contract
    {
        /// <summary>
        /// 获取指定的经营处合同信息 SD_Contract对象集合
        /// </summary>
        public List<SD_Contract> GetListByWhereExtend(string strCondition)
        {
            List<SD_Contract> ret = new List<SD_Contract>();
            string sql = @"SELECT  distinct Contract_ID,Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,sc.Stat
,Contract_Stat,Contract_Date,Contract_VerifyStat
,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat
,AuditCurAudit,Contract_Bak,Contract_Creator 
FROM SD_Contract sc 
LEFT JOIN SD_CDetail sd on sd.CDetail_ContractNo=sc.Contract_Code
WHERE 1=1 AND ((sc.Stat is null) or (sc.Stat=0) )  and isnull(sd.stat,0)=0";
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
                    SD_Contract sD_Contract = new SD_Contract();
                    if (dr["Contract_ID"] != DBNull.Value) sD_Contract.Contract_ID = Convert.ToInt64(dr["Contract_ID"]);
                    if (dr["Contract_Code"] != DBNull.Value) sD_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
                    if (dr["Contract_Name"] != DBNull.Value) sD_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
                    if (dr["Contract_CDate"] != DBNull.Value) sD_Contract.Contract_CDate = Convert.ToDateTime(dr["Contract_CDate"]);
                    if (dr["Contract_EffectDate"] != DBNull.Value) sD_Contract.Contract_EffectDate = Convert.ToDateTime(dr["Contract_EffectDate"]);
                    if (dr["Contract_OwnerName"] != DBNull.Value) sD_Contract.Contract_OwnerName = Convert.ToString(dr["Contract_OwnerName"]);
                    if (dr["Contract_Owner"] != DBNull.Value) sD_Contract.Contract_Owner = Convert.ToString(dr["Contract_Owner"]);
                    if (dr["Contract_CustOwner"] != DBNull.Value) sD_Contract.Contract_CustOwner = Convert.ToString(dr["Contract_CustOwner"]);
                    if (dr["Contract_CustLink"] != DBNull.Value) sD_Contract.Contract_CustLink = Convert.ToString(dr["Contract_CustLink"]);
                    if (dr["Contract_Type"] != DBNull.Value) sD_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
                    if (dr["Contract_CustCode"] != DBNull.Value) sD_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
                    if (dr["Contract_CustName"] != DBNull.Value) sD_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
                    if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["Contract_Stat"] != DBNull.Value) sD_Contract.Contract_Stat = Convert.ToString(dr["Contract_Stat"]);
                    if (dr["Contract_Date"] != DBNull.Value) sD_Contract.Contract_Date = Convert.ToDateTime(dr["Contract_Date"]);
                    if (dr["Contract_VerifyStat"] != DBNull.Value) sD_Contract.Contract_VerifyStat = Convert.ToInt32(dr["Contract_VerifyStat"]);
                    if (dr["Contract_VerifyDate"] != DBNull.Value) sD_Contract.Contract_VerifyDate = Convert.ToDateTime(dr["Contract_VerifyDate"]);
                    if (dr["Contract_VerifyNextNode"] != DBNull.Value) sD_Contract.Contract_VerifyNextNode = Convert.ToInt32(dr["Contract_VerifyNextNode"]);
                    if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
                    if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                    if (dr["Contract_Bak"] != DBNull.Value) sD_Contract.Contract_Bak = Convert.ToString(dr["Contract_Bak"]);
                    if (dr["Contract_Creator"] != DBNull.Value) sD_Contract.Contract_Creator = Convert.ToString(dr["Contract_Creator"]);
                    ret.Add(sD_Contract);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
