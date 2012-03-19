using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
namespace QX.DataAceess
{
    public partial class ADOSys_PD_GridFormat
    {
        public DataTable GetRefData(string sql)
        {
            return idb.ReturnDataTable(sql);
        }

        public void DeleteFormatter(string sModule, string sEmp)
        {
            string ssql = string.Format("delete from Sys_PD_GridFormat where empl_no = '{0}' and colfor_code = '{1}' ", sEmp, sModule);
            idb.ExeCmd(ssql);
        }
    }
}
