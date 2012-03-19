using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOSD_CDetail
    {

        public List<SD_CDetail> GetListByWhereForCust(string strCondition)
        {
            List<SD_CDetail> ret = new List<SD_CDetail>();
            string sql = @"SELECT  CDetail_PartNo,CDetail_PartName 
FROM SD_CDetail sd
JOIN SD_Contract sc on sc.Contract_Code=sd.CDetail_ContractNo and isnull(sc.stat,0)=0
 WHERE 1=1 AND ((sd.Stat is null) or (sd.Stat=0) ) 
 ";
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
                    SD_CDetail sD_CDetail = new SD_CDetail();
                    //if (dr["CDetail_ID"] != DBNull.Value) sD_CDetail.CDetail_ID = Convert.ToInt64(dr["CDetail_ID"]);
                    //if (dr["CDetail_Code"] != DBNull.Value) sD_CDetail.CDetail_Code = Convert.ToString(dr["CDetail_Code"]);
                    if (dr["CDetail_PartNo"] != DBNull.Value) sD_CDetail.CDetail_PartNo = Convert.ToString(dr["CDetail_PartNo"]);
                    if (dr["CDetail_PartName"] != DBNull.Value) sD_CDetail.CDetail_PartName = Convert.ToString(dr["CDetail_PartName"]);
                    //if (dr["CDetail_Num"] != DBNull.Value) sD_CDetail.CDetail_Num = Convert.ToInt32(dr["CDetail_Num"]);
                    //if (dr["CDetail_Price"] != DBNull.Value) sD_CDetail.CDetail_Price = Convert.ToDecimal(dr["CDetail_Price"]);
                    //if (dr["CDetail_Intro"] != DBNull.Value) sD_CDetail.CDetail_Intro = Convert.ToString(dr["CDetail_Intro"]);
                    //if (dr["CDetail_Bak"] != DBNull.Value) sD_CDetail.CDetail_Bak = Convert.ToString(dr["CDetail_Bak"]);
                    //if (dr["CDetail_OnNum"] != DBNull.Value) sD_CDetail.CDetail_OnNum = Convert.ToInt32(dr["CDetail_OnNum"]);
                    //if (dr["CDetail_FNum"] != DBNull.Value) sD_CDetail.CDetail_FNum = Convert.ToInt32(dr["CDetail_FNum"]);
                    //if (dr["CDetail_DNum"] != DBNull.Value) sD_CDetail.CDetail_DNum = Convert.ToInt32(dr["CDetail_DNum"]);
                    //if (dr["CDetail_ContractNo"] != DBNull.Value) sD_CDetail.CDetail_ContractNo = Convert.ToString(dr["CDetail_ContractNo"]);
                    //if (dr["Stat"] != DBNull.Value) sD_CDetail.Stat = Convert.ToInt32(dr["Stat"]);
                    //if (dr["CDetail_Date"] != DBNull.Value) sD_CDetail.CDetail_Date = Convert.ToDateTime(dr["CDetail_Date"]);
                    //if (dr["CDetail_Cmd"] != DBNull.Value) sD_CDetail.CDetail_Cmd = Convert.ToString(dr["CDetail_Cmd"]);
                    //if (dr["CDetail_Project"] != DBNull.Value) sD_CDetail.CDetail_Project = Convert.ToString(dr["CDetail_Project"]);
                    //if (dr["CDetail_Sum"] != DBNull.Value) sD_CDetail.CDetail_Sum = Convert.ToDecimal(dr["CDetail_Sum"]);
                    //if (dr["CDetail_NoTax"] != DBNull.Value) sD_CDetail.CDetail_NoTax = Convert.ToDecimal(dr["CDetail_NoTax"]);
                    //if (dr["CDetail_ProdCode"] != DBNull.Value) sD_CDetail.CDetail_ProdCode = Convert.ToString(dr["CDetail_ProdCode"]);
                    //if (dr["CDetail_Unit"] != DBNull.Value) sD_CDetail.CDetail_Unit = Convert.ToString(dr["CDetail_Unit"]);
                    //if (dr["CDetail_PRRelation"] != DBNull.Value) sD_CDetail.CDetail_PRRelation = Convert.ToString(dr["CDetail_PRRelation"]);
                    ret.Add(sD_CDetail);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
