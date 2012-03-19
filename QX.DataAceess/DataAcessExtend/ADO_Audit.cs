using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public class ADO_Audit
    {
        private ADOComm instance = new ADOComm();

        public string Audit(string vRCode)
        {
            SqlParameter x1 = new SqlParameter("@auditCode", SqlDbType.VarChar, 50);
            x1.Value = vRCode;
            SqlParameter[] param = new SqlParameter[] { x1 };
            IDbDataParameter[] parames = param as IDbDataParameter[];
            DataTable dt = instance.ExcuteProc("qx_sp_audit", parames);
            return dt.Rows[0][0].ToString();
        }


        public string AuditFilterWhere(string moduleCode, string UserId)
        {
            SqlParameter x1 = new SqlParameter("@userID", SqlDbType.VarChar, 20);
            x1.Value = UserId;
            SqlParameter x2 = new SqlParameter("@moduleCode", SqlDbType.VarChar, 20);
            x2.Value = moduleCode;

            SqlParameter x3 = new SqlParameter("@filterSQL", SqlDbType.VarChar, 200);
            x3.Direction = ParameterDirection.Output;
            x3.Value = moduleCode;
            SqlParameter[] param = new SqlParameter[] { x1, x2, x3 };
            IDbDataParameter[] parames = param as IDbDataParameter[];
            DataTable dt = instance.ExcuteProc("qx_sp_auditfilter", parames);
            return dt.Rows[0][0].ToString();
        }
    }
}
