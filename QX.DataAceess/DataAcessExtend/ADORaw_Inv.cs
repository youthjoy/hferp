using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;

namespace QX.DataAceess
{
    public partial class ADORaw_Inv
    {
        /// <summary>
        /// 获取指定的Raw_Inv对象集合
        /// </summary>
        public List<Raw_Inv> GetListByWhereExtend(string strCondition)
        {
            List<Raw_Inv> ret = new List<Raw_Inv>();
            string sql = @"SELECT distinct  RI_ID,RI_Code,RI_RawCode,RI_Sum,RI_AvailableNum,RI_UsedNum
,RI_CompCode,RI_CmdCode,RI_Customer,RI_InOperator,RI_InTime,RI_OutOperator,RI_OutTime,RI_Remark,ri.RI_RefRawCode,ri.RI_RefDetailCode,ri.Stat,rc.Comp_Name,rc.Comp_CatName
FROM Raw_Inv  ri
LEFT JOIN Road_Components rc ON rc.Comp_Code=ri.RI_CompCode
--JOIN Prod_Command pc ON pc.Cmd_Code=ri.RI_CmdCode
WHERE 1=1 AND ((ri.Stat is null) or (ri.Stat=0)) AND isnull(rc.stat,0)=0 ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Raw_Inv raw_Inv = new Raw_Inv();
                if (dr["RI_ID"] != DBNull.Value) raw_Inv.RI_ID = Convert.ToInt32(dr["RI_ID"]);
                if (dr["RI_Code"] != DBNull.Value) raw_Inv.RI_Code = Convert.ToString(dr["RI_Code"]);
                if (dr["RI_RawCode"] != DBNull.Value) raw_Inv.RI_RawCode = Convert.ToString(dr["RI_RawCode"]);
                if (dr["RI_Sum"] != DBNull.Value) raw_Inv.RI_Sum = Convert.ToInt32(dr["RI_Sum"]);
                if (dr["RI_AvailableNum"] != DBNull.Value) raw_Inv.RI_AvailableNum = Convert.ToInt32(dr["RI_AvailableNum"]);
                if (dr["RI_UsedNum"] != DBNull.Value) raw_Inv.RI_UsedNum = Convert.ToInt32(dr["RI_UsedNum"]);
                if (dr["RI_CompCode"] != DBNull.Value) raw_Inv.RI_CompCode = Convert.ToString(dr["RI_CompCode"]);
                if (dr["RI_CmdCode"] != DBNull.Value) raw_Inv.RI_CmdCode = Convert.ToString(dr["RI_CmdCode"]);
                if (dr["RI_InOperator"] != DBNull.Value) raw_Inv.RI_InOperator = Convert.ToString(dr["RI_InOperator"]);
                if (dr["RI_InTime"] != DBNull.Value) raw_Inv.RI_InTime = Convert.ToDateTime(dr["RI_InTime"]);
                if (dr["RI_OutOperator"] != DBNull.Value) raw_Inv.RI_OutOperator = Convert.ToString(dr["RI_OutOperator"]);
                if (dr["RI_OutTime"] != DBNull.Value) raw_Inv.RI_OutTime = Convert.ToDateTime(dr["RI_OutTime"]);
                if (dr["RI_Remark"] != DBNull.Value) raw_Inv.RI_Remark = Convert.ToString(dr["RI_Remark"]);
                if (dr["RI_Customer"] != DBNull.Value) raw_Inv.RI_Customer = Convert.ToString(dr["RI_Customer"]);
                if (dr["RI_RefRawCode"] != DBNull.Value) raw_Inv.RI_RefRawCode = Convert.ToString(dr["RI_RefRawCode"]);
                if (dr["RI_RefDetailCode"] != DBNull.Value) raw_Inv.RI_RefDetailCode = Convert.ToString(dr["RI_RefDetailCode"]);
                if (dr["Stat"] != DBNull.Value) raw_Inv.Stat = Convert.ToInt32(dr["Stat"]);


                if (dr["Comp_Name"] != DBNull.Value) raw_Inv.RI_CompName = Convert.ToString(dr["Comp_Name"]);
                if (dr["Comp_CatName"] != DBNull.Value) raw_Inv.RI_Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
                ret.Add(raw_Inv);
            }
            dr.Close();
            return ret;
        }
    }
}
