using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.Common.C_Class;
using System.Data.SqlClient;


namespace QX.DataAceess
{
    public class ADOBse_Audti
    {
        //public IDBOperator idb = DBOperator.GetInstance();

        //public List<Audit_info> GetAllPocess(string UserId, OperationTypeEnum.AuditTemplateEnum audittype)
        //{
        //    List<Audit_info> list = new List<Audit_info>();
        //    StringBuilder sql = new StringBuilder();
        //    sql.AppendLine("SELECT * FROM Verify_Template vt,Verify_Users vu");
        //    sql.AppendLine(" WHERE vt.VerifyNode_Code=vu.VerifyNode_Code");
        //    sql.AppendLine(" AND vt.Flag='1'");
        //    sql.AppendLine(" AND vt.VT_No='" + audittype.ToString() + "'");
        //    sql.AppendLine(" AND vu.VU_User='" + UserId + "'");
            
        //    SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql.ToString());
        //    while (dr.Read())
        //    {
        //        Audit_info bse_Dict = new Audit_info();
        //        if (dr["Flag"] != DBNull.Value) bse_Dict.Flag = Convert.ToString(dr["Flag"]);
        //        if (dr["Stat"] != DBNull.Value) bse_Dict.Stat = Convert.ToInt32(dr["Stat"]);
        //        if (dr["VerifyNode_Code"] != DBNull.Value) bse_Dict.VerifyNode_Code = Convert.ToString(dr["VerifyNode_Code"]);
        //        if (dr["VerifyNode_Name"] != DBNull.Value) bse_Dict.VerifyNode_Name = Convert.ToString(dr["VerifyNode_Name"]);
        //        if (dr["VerifyNode_Remark"] != DBNull.Value) bse_Dict.VerifyNode_Remark = Convert.ToString(dr["VerifyNode_Remark"]);
        //        if (dr["VT_Code"] != DBNull.Value) bse_Dict.VT_Code = Convert.ToString(dr["VT_Code"]);
        //        if (dr["VT_ID"] != DBNull.Value) bse_Dict.VT_ID = Convert.ToInt32(dr["VT_ID"]);
        //        if (dr["VT_Key"] != DBNull.Value) bse_Dict.VT_Key = Convert.ToString(dr["VT_Key"]);
        //        if (dr["VT_No"] != DBNull.Value) bse_Dict.VT_No = Convert.ToString(dr["VT_No"]);
        //        if (dr["VT_NodeOrder"] != DBNull.Value) bse_Dict.VT_NodeOrder = Convert.ToInt32(dr["VT_NodeOrder"]);
        //        if (dr["VT_Remark"] != DBNull.Value) bse_Dict.VT_Remark = Convert.ToString(dr["VT_Remark"]);
        //        if (dr["VU_Dept"] != DBNull.Value) bse_Dict.VU_Dept = Convert.ToString(dr["VU_Dept"]);
        //        if (dr["VU_Duty"] != DBNull.Value) bse_Dict.VU_Duty = Convert.ToString(dr["VU_Duty"]);
        //        if (dr["VU_ID"] != DBNull.Value) bse_Dict.VU_ID = Convert.ToInt32(dr["VU_ID"]);
        //        if (dr["VU_User"] != DBNull.Value) bse_Dict.VU_User = Convert.ToString(dr["VU_User"]);
        //        list.Add(bse_Dict);
        //    }
        //    dr.Close();
        //    return list;
        //}

        //public List<Audit_info> GetAllPocess(OperationTypeEnum.AuditTemplateEnum audittype)
        //{
        //    List<Audit_info> list = new List<Audit_info>();
        //    StringBuilder sql = new StringBuilder();
        //    sql.AppendLine("SELECT * FROM Verify_Template vt,Verify_Users vu");
        //    sql.AppendLine(" WHERE vt.VerifyNode_Code=vu.VerifyNode_Code");
        //    sql.AppendLine(" AND vt.Flag='1'");
        //    sql.AppendLine(" AND vt.VT_No='" + audittype.ToString() + "'");

        //    SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql.ToString());
        //    while (dr.Read())
        //    {
        //        Audit_info bse_Dict = new Audit_info();
        //        if (dr["Flag"] != DBNull.Value) bse_Dict.Flag = Convert.ToString(dr["Flag"]);
        //        if (dr["Stat"] != DBNull.Value) bse_Dict.Stat = Convert.ToInt32(dr["Stat"]);
        //        if (dr["VerifyNode_Code"] != DBNull.Value) bse_Dict.VerifyNode_Code = Convert.ToString(dr["VerifyNode_Code"]);
        //        if (dr["VerifyNode_Name"] != DBNull.Value) bse_Dict.VerifyNode_Name = Convert.ToString(dr["VerifyNode_Name"]);
        //        if (dr["VerifyNode_Remark"] != DBNull.Value) bse_Dict.VerifyNode_Remark = Convert.ToString(dr["VerifyNode_Remark"]);
        //        if (dr["VT_Code"] != DBNull.Value) bse_Dict.VT_Code = Convert.ToString(dr["VT_Code"]);
        //        if (dr["VT_ID"] != DBNull.Value) bse_Dict.VT_ID = Convert.ToInt32(dr["VT_ID"]);
        //        if (dr["VT_Key"] != DBNull.Value) bse_Dict.VT_Key = Convert.ToString(dr["VT_Key"]);
        //        if (dr["VT_No"] != DBNull.Value) bse_Dict.VT_No = Convert.ToString(dr["VT_No"]);
        //        if (dr["VT_NodeOrder"] != DBNull.Value) bse_Dict.VT_NodeOrder = Convert.ToInt32(dr["VT_NodeOrder"]);
        //        if (dr["VT_Remark"] != DBNull.Value) bse_Dict.VT_Remark = Convert.ToString(dr["VT_Remark"]);
        //        if (dr["VU_Dept"] != DBNull.Value) bse_Dict.VU_Dept = Convert.ToString(dr["VU_Dept"]);
        //        if (dr["VU_Duty"] != DBNull.Value) bse_Dict.VU_Duty = Convert.ToString(dr["VU_Duty"]);
        //        if (dr["VU_ID"] != DBNull.Value) bse_Dict.VU_ID = Convert.ToInt32(dr["VU_ID"]);
        //        if (dr["VU_User"] != DBNull.Value) bse_Dict.VU_User = Convert.ToString(dr["VU_User"]);
        //        list.Add(bse_Dict);
        //    }
        //    dr.Close();
        //    return list;
        //}        
    }
}
