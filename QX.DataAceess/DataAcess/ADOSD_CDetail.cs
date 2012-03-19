using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOSD_CDetail
    {
        /// <summary>
        /// 获取指定的合同细目信息 SD_CDetail对象集合
        /// </summary>
        public DataTable GetListByWhereForExport(string strCondition)
        {
           
            string sql = @"SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,Contract_Stat,Contract_Date,Contract_VerifyStat,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat,AuditCurAudit,Contract_Bak,Contract_Creator,Contract_Cmd,Contract_Project,CDetail_ID,CDetail_Code,CDetail_PartNo,CDetail_PartName,CDetail_Num,CDetail_Price,CDetail_Intro,CDetail_Bak,CDetail_OnNum,CDetail_FNum,CDetail_DNum,CDetail_ContractNo,CDetail_Date,CDetail_Cmd,CDetail_Project,CDetail_Sum,CDetail_NoTax,CDetail_ProdCode,CDetail_Unit
 FROM SD_CDetail sd,SD_Contract sc
WHERE 1=1 AND sc.Contract_Code=sd.cdetail_ContractNO and  ((sd.Stat is null) or (sd.Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            return idb.ReturnDataTable(sql);
        }
    }
}
