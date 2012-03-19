using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;
using QX.Common.C_Class;

namespace QX.DataAceess
{
    public partial class ADORaw_Main
    {

        public List<Raw_Main> GetMyAudit(OperationTypeEnum.AuditTemplateEnum TemplateType, String UserId)
        {
            List<Raw_Main> list = new List<Raw_Main>();
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("");
            sql.AppendLine("");
            sql.AppendLine("");
            sql.AppendLine("");
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql.ToString());
            while (dr.Read())
            {
                Raw_Main raw_Main = new Raw_Main();
                //if (dr["RawMain_ID"] != DBNull.Value) raw_Main.RawMain_ID = Convert.ToInt64(dr["RawMain_ID"]);
                //if (dr["RawMain_Code"] != DBNull.Value) raw_Main.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
                //if (dr["RawMain_AppDep"] != DBNull.Value) raw_Main.RawMain_AppDep = Convert.ToString(dr["RawMain_AppDep"]);
                //if (dr["RawMain_AppOwn"] != DBNull.Value) raw_Main.RawMain_AppOwn = Convert.ToString(dr["RawMain_AppOwn"]);
                //if (dr["RawMain_AppDate"] != DBNull.Value) raw_Main.RawMain_AppDate = Convert.ToDateTime(dr["RawMain_AppDate"]);
                //if (dr["RawMain_Title"] != DBNull.Value) raw_Main.RawMain_Title = Convert.ToString(dr["RawMain_Title"]);
                //if (dr["RawMain_IsOK"] != DBNull.Value) raw_Main.RawMain_IsOK = Convert.ToString(dr["RawMain_IsOK"]);
                //if (dr["RawMain_SupDep"] != DBNull.Value) raw_Main.RawMain_SupDep = Convert.ToString(dr["RawMain_SupDep"]);
                //if (dr["RawMain_CurStat"] != DBNull.Value) raw_Main.RawMain_CurStat = Convert.ToString(dr["RawMain_CurStat"]);
                //if (dr["Stat"] != DBNull.Value) raw_Main.Stat = Convert.ToInt32(dr["Stat"]);
                list.Add(raw_Main);
            }
            dr.Close();
            return list;
        }

    }
}
