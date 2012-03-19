using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataModel;
using QX.DataAcess;
using System.Data;
namespace QX.DataAceess
{
    public partial class ADOFailure_Information
    {
        /// <summary>
        /// 获取指定的Failure_Information对象集合
        /// </summary>
        public DataTable GetListByWhereExtend(string strCondition)
        {
            List<Failure_Information> ret = new List<Failure_Information>();
            string sql = @"select f.*,(select top 1 isnull(VRecord_Opinion,'') from VerifyProcess_Records where  isnull(stat,0)=0 and Module_Code='FailureAudit_F001' and Record_ID=FInfo_Code and VRecord_VCode='100000000019') Remark0,
(select top 1 isnull(VRecord_Opinion,'') from VerifyProcess_Records where  isnull(stat,0)=0 and Module_Code='FailureAudit_F001' and Record_ID=FInfo_Code and VRecord_VCode='100000000030') Remark1,
(select top 1 isnull(VRecord_Opinion,'') from VerifyProcess_Records where  isnull(stat,0)=0 and Module_Code='FailureAudit_F001' and Record_ID=FInfo_Code and VRecord_VCode='100000000028') Remark2,
(select top 1 isnull(VRecord_Opinion,'') from VerifyProcess_Records where  isnull(stat,0)=0 and Module_Code='FailureAudit_F001' and Record_ID=FInfo_Code and VRecord_VCode='100000000038') Remark3,
(select top 1 isnull(VRecord_Opinion,'') from VerifyProcess_Records where  isnull(stat,0)=0 and Module_Code='FailureAudit_F001' and Record_ID=FInfo_Code and VRecord_VCode='100000000040') Remark4 from failure_information f 
 where isnull(f.stat,0)=0
 ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }

            return idb.ReturnDataTable(sql);
        }
    }
}
