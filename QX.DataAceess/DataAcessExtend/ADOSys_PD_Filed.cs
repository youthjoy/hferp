using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
namespace QX.DataAceess
{
    public partial class ADOSys_PD_Filed
    {
        public DataTable GetRefData(string sql)
        {
            return idb.ReturnDataTable(sql);
        }
    }
}
