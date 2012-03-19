using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOProd_CodeMap
    {
        public List<Prod_CodeMap> GetListByWhereExtend(string strCondition)
        {
            List<Prod_CodeMap> ret = new List<Prod_CodeMap>();
            string sql = "SELECT  PMap_ID,PMap_Code,PMap_Order,PMap_PCode,PMap_MCode,PMap_Module,PMap_iType,PMap_Stat,pm.Stat FROM Prod_CodeMap pm JOIN Prod_Command pc on pc.Cmd_Code =pm.PMap_Module WHERE 1=1 AND ((pm.Stat is null) or (pm.Stat=0) ) ";
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
                    Prod_CodeMap prod_CodeMap = new Prod_CodeMap();
                    if (dr["PMap_ID"] != DBNull.Value) prod_CodeMap.PMap_ID = Convert.ToDecimal(dr["PMap_ID"]);
                    if (dr["PMap_Code"] != DBNull.Value) prod_CodeMap.PMap_Code = Convert.ToString(dr["PMap_Code"]);
                    if (dr["PMap_Order"] != DBNull.Value) prod_CodeMap.PMap_Order = Convert.ToInt32(dr["PMap_Order"]);
                    if (dr["PMap_PCode"] != DBNull.Value) prod_CodeMap.PMap_PCode = Convert.ToString(dr["PMap_PCode"]);
                    if (dr["PMap_MCode"] != DBNull.Value) prod_CodeMap.PMap_MCode = Convert.ToString(dr["PMap_MCode"]);
                    if (dr["PMap_Module"] != DBNull.Value) prod_CodeMap.PMap_Module = Convert.ToString(dr["PMap_Module"]);
                    if (dr["PMap_iType"] != DBNull.Value) prod_CodeMap.PMap_iType = Convert.ToString(dr["PMap_iType"]);
                    if (dr["PMap_Stat"] != DBNull.Value) prod_CodeMap.PMap_Stat = Convert.ToString(dr["PMap_Stat"]);
                    if (dr["Stat"] != DBNull.Value) prod_CodeMap.Stat = Convert.ToInt32(dr["Stat"]);
                    ret.Add(prod_CodeMap);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }
    }
}
