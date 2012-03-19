using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QX.DataAceess;
using QX.DataModel;

namespace QX.DataAceess
{
    public partial class ADOBse_Dict
    {
        /// <summary>
        /// 返回当前表最大值
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>最小返回0</returns>
        public object GetMax(string columnName, string key)
        {
            string sql = string.Format(@"SELECT
	isnull(Max({0}),0)
FROM
	Bse_Dict WHERE 1=1 AND Dict_Key='{1}'", columnName, key);

            return idb.ReturnValue(sql);
        }

        public DataTable GenerateCode(string key)
        {

            DataTable dt = idb.RunProcReturnDatatable("qx_find_dictkeycode", new List<SqlParameter>() { new SqlParameter("sTable", key) }.ToArray());
            return dt;
        }


        ///// <summary>
        ///// 获取指定的数据字典 Bse_Dict对象集合
        ///// </summary>
        //public List<Bse_Dict> GetListByWhere(string strCondition)
        //{
        //    //idb = DBOperator.GetInstance();
        //    List<Bse_Dict> ret = new List<Bse_Dict>();
        //    string sql = "SELECT  Dict_ID,Dict_Key,Dict_Code,Dict_Name,Dict_Order,Dict_PCode,Dict_PName,Dict_Desp,Dict_SCode,Dict_Bak,Dict_UDef1,Dict_UDef2,Dict_UDef3,Dict_UDef4,Dict_UDef5,Dict_Level,Dict_IsEditable,Stat FROM Bse_Dict WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
        //    if (!string.IsNullOrEmpty(strCondition))
        //    {
        //        strCondition.Replace('\'', '"'); //防sql注入
        //        sql += strCondition;
        //    }
        //    using (SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql))
        //    {

        //        try
        //        {

        //            while (dr.Read())
        //            {
        //                Bse_Dict bse_Dict = new Bse_Dict();
        //                if (dr["Dict_ID"] != DBNull.Value) bse_Dict.Dict_ID = Convert.ToInt64(dr["Dict_ID"]);
        //                if (dr["Dict_Key"] != DBNull.Value) bse_Dict.Dict_Key = Convert.ToString(dr["Dict_Key"]);
        //                if (dr["Dict_Code"] != DBNull.Value) bse_Dict.Dict_Code = Convert.ToString(dr["Dict_Code"]);
        //                if (dr["Dict_Name"] != DBNull.Value) bse_Dict.Dict_Name = Convert.ToString(dr["Dict_Name"]);
        //                if (dr["Dict_PCode"] != DBNull.Value) bse_Dict.Dict_PCode = Convert.ToString(dr["Dict_PCode"]);
        //                if (dr["Dict_PName"] != DBNull.Value) bse_Dict.Dict_PName = Convert.ToString(dr["Dict_PName"]);
        //                if (dr["Dict_Desp"] != DBNull.Value) bse_Dict.Dict_Desp = Convert.ToString(dr["Dict_Desp"]);
        //                if (dr["Dict_SCode"] != DBNull.Value) bse_Dict.Dict_SCode = Convert.ToString(dr["Dict_SCode"]);
        //                if (dr["Dict_Bak"] != DBNull.Value) bse_Dict.Dict_Bak = Convert.ToString(dr["Dict_Bak"]);
        //                if (dr["Dict_UDef1"] != DBNull.Value) bse_Dict.Dict_UDef1 = Convert.ToString(dr["Dict_UDef1"]);
        //                if (dr["Dict_UDef2"] != DBNull.Value) bse_Dict.Dict_UDef2 = Convert.ToString(dr["Dict_UDef2"]);
        //                if (dr["Dict_UDef3"] != DBNull.Value) bse_Dict.Dict_UDef3 = Convert.ToString(dr["Dict_UDef3"]);
        //                if (dr["Dict_UDef4"] != DBNull.Value) bse_Dict.Dict_UDef4 = Convert.ToString(dr["Dict_UDef4"]);
        //                if (dr["Dict_UDef5"] != DBNull.Value) bse_Dict.Dict_UDef5 = Convert.ToString(dr["Dict_UDef5"]);
        //                if (dr["Dict_Level"] != DBNull.Value) bse_Dict.Dict_Level = Convert.ToInt32(dr["Dict_Level"]);
        //                if (dr["Dict_IsEditable"] != DBNull.Value) bse_Dict.Dict_IsEditable = Convert.ToInt32(dr["Dict_IsEditable"]);
        //                if (dr["Stat"] != DBNull.Value) bse_Dict.Stat = Convert.ToInt32(dr["Stat"]);
        //                if (dr["Dict_Order"] != DBNull.Value) bse_Dict.Dict_Order = Convert.ToInt32(dr["Dict_Order"]);
        //                ret.Add(bse_Dict);
        //            }
        //        }
        //        catch (System.Exception ex) { throw ex; }
        //        finally { if (dr != null) { dr.Close(); } }
        //    }
        //    return ret;
        //}

        ///// <summary>
        ///// 获取指定的数据字典 Bse_Dict对象集合
        ///// </summary>
        //public List<Bse_Dict> GetListByWhere(string strCondition)
        //{
        //    idb = DBOperator.GetInstance();
        //    List<Bse_Dict> ret = new List<Bse_Dict>();
        //    string sql = "SELECT  Dict_ID,Dict_Key,Dict_Code,Dict_Name,Dict_Order,Dict_PCode,Dict_PName,Dict_Desp,Dict_SCode,Dict_Bak,Dict_UDef1,Dict_UDef2,Dict_UDef3,Dict_UDef4,Dict_UDef5,Dict_Level,Dict_IsEditable,Stat FROM Bse_Dict WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
        //    if (!string.IsNullOrEmpty(strCondition))
        //    {
        //        strCondition.Replace('\'', '"'); //防sql注入
        //        sql += strCondition;
        //    }
        //    using (SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql))
        //    {

        //        try
        //        {

        //            while (dr.Read())
        //            {
        //                Bse_Dict bse_Dict = new Bse_Dict();
        //                if (dr["Dict_ID"] != DBNull.Value) bse_Dict.Dict_ID = Convert.ToDecimal(dr["Dict_ID"]);
        //                if (dr["Dict_Key"] != DBNull.Value) bse_Dict.Dict_Key = Convert.ToString(dr["Dict_Key"]);
        //                if (dr["Dict_Code"] != DBNull.Value) bse_Dict.Dict_Code = Convert.ToString(dr["Dict_Code"]);
        //                if (dr["Dict_Name"] != DBNull.Value) bse_Dict.Dict_Name = Convert.ToString(dr["Dict_Name"]);
        //                if (dr["Dict_Order"] != DBNull.Value) bse_Dict.Dict_Order = Convert.ToInt32(dr["Dict_Order"]);
        //                if (dr["Dict_PCode"] != DBNull.Value) bse_Dict.Dict_PCode = Convert.ToString(dr["Dict_PCode"]);
        //                if (dr["Dict_PName"] != DBNull.Value) bse_Dict.Dict_PName = Convert.ToString(dr["Dict_PName"]);
        //                if (dr["Dict_Desp"] != DBNull.Value) bse_Dict.Dict_Desp = Convert.ToString(dr["Dict_Desp"]);
        //                if (dr["Dict_SCode"] != DBNull.Value) bse_Dict.Dict_SCode = Convert.ToString(dr["Dict_SCode"]);
        //                if (dr["Dict_Bak"] != DBNull.Value) bse_Dict.Dict_Bak = Convert.ToString(dr["Dict_Bak"]);
        //                if (dr["Dict_UDef1"] != DBNull.Value) bse_Dict.Dict_UDef1 = Convert.ToString(dr["Dict_UDef1"]);
        //                if (dr["Dict_UDef2"] != DBNull.Value) bse_Dict.Dict_UDef2 = Convert.ToString(dr["Dict_UDef2"]);
        //                if (dr["Dict_UDef3"] != DBNull.Value) bse_Dict.Dict_UDef3 = Convert.ToString(dr["Dict_UDef3"]);
        //                if (dr["Dict_UDef4"] != DBNull.Value) bse_Dict.Dict_UDef4 = Convert.ToString(dr["Dict_UDef4"]);
        //                if (dr["Dict_UDef5"] != DBNull.Value) bse_Dict.Dict_UDef5 = Convert.ToString(dr["Dict_UDef5"]);
        //                if (dr["Dict_Level"] != DBNull.Value) bse_Dict.Dict_Level = Convert.ToInt32(dr["Dict_Level"]);
        //                if (dr["Dict_IsEditable"] != DBNull.Value) bse_Dict.Dict_IsEditable = Convert.ToInt32(dr["Dict_IsEditable"]);
        //                if (dr["Stat"] != DBNull.Value) bse_Dict.Stat = Convert.ToInt32(dr["Stat"]);
        //                ret.Add(bse_Dict);
        //            }
        //        }
        //        catch (System.Exception ex) { throw ex; }
        //        finally { if (dr != null) { dr.Close();  } }
        //    }
        //    return ret;
        //}
    }
}
