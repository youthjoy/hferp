using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOProd_Task
    {
        /// <summary>
        /// 返回当前表最大值
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>最小返回0</returns>
        public object GetMax(string columnName)
        {
            string sql = string.Format(@"SELECT
	isnull(Max({0}),0)
FROM
	Prod_Task", columnName);

            return idb.ReturnValue(sql);
        }

        public List<Prod_Task> GetListByWhereExtend(string strCondition)
        {
            List<Prod_Task> ret = new List<Prod_Task>();
            string sql = @"SELECT  Task_Customer,Task_ID,Task_Code,Task_Name,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,Task_PartCat,Task_PartCatName
,Task_Owner,Task_Date,TaskDetail_Unit,TaskDetail_Num,Task_DNum,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_Remark,Task_CustomerName,Stat 
,(SELECT isnull(count(PlanProd_ID),0) FROM Prod_PlanProd WHERE PlanProd_TaskCode=Task_Code and isnull(stat,0)=0) AS Task_PlanNum
FROM Prod_Task 
WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";

            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Prod_Task prod_Task = new Prod_Task();
                if (dr["Task_ID"] != DBNull.Value) prod_Task.Task_ID = Convert.ToInt64(dr["Task_ID"]);
                if (dr["Task_Code"] != DBNull.Value) prod_Task.Task_Code = Convert.ToString(dr["Task_Code"]);
                if (dr["Task_Name"] != DBNull.Value) prod_Task.Task_Name = Convert.ToString(dr["Task_Name"]);
                if (dr["TaskDetail_CmdCode"] != DBNull.Value) prod_Task.TaskDetail_CmdCode = Convert.ToString(dr["TaskDetail_CmdCode"]);
                if (dr["TaskDetail_PartNo"] != DBNull.Value) prod_Task.TaskDetail_PartNo = Convert.ToString(dr["TaskDetail_PartNo"]);
                if (dr["TaskDetail_PartName"] != DBNull.Value) prod_Task.TaskDetail_PartName = Convert.ToString(dr["TaskDetail_PartName"]);
                if (dr["Task_PartCat"] != DBNull.Value) prod_Task.Task_PartCat = Convert.ToString(dr["Task_PartCat"]);
                if (dr["Task_PartCatName"] != DBNull.Value) prod_Task.Task_PartCatName = Convert.ToString(dr["Task_PartCatName"]);
                if (dr["Task_Owner"] != DBNull.Value) prod_Task.Task_Owner = Convert.ToString(dr["Task_Owner"]);
                if (dr["Task_Date"] != DBNull.Value) prod_Task.Task_Date = Convert.ToDateTime(dr["Task_Date"]);
                if (dr["TaskDetail_Unit"] != DBNull.Value) prod_Task.TaskDetail_Unit = Convert.ToString(dr["TaskDetail_Unit"]);
                if (dr["TaskDetail_Num"] != DBNull.Value) prod_Task.TaskDetail_Num = Convert.ToInt32(dr["TaskDetail_Num"]);
                if (dr["Task_DNum"] != DBNull.Value) prod_Task.Task_DNum = Convert.ToInt32(dr["Task_DNum"]);
                if (dr["TaskDetail_ProdType"] != DBNull.Value) prod_Task.TaskDetail_ProdType = Convert.ToString(dr["TaskDetail_ProdType"]);
                if (dr["TaskDetail_PlanBegin"] != DBNull.Value) prod_Task.TaskDetail_PlanBegin = Convert.ToDateTime(dr["TaskDetail_PlanBegin"]);
                if (dr["TaskDetail_PlanEnd"] != DBNull.Value) prod_Task.TaskDetail_PlanEnd = Convert.ToDateTime(dr["TaskDetail_PlanEnd"]);
                if (dr["TaskDetail_ActEnd"] != DBNull.Value) prod_Task.TaskDetail_ActEnd = Convert.ToDateTime(dr["TaskDetail_ActEnd"]);
                if (dr["Task_FNum"] != DBNull.Value) prod_Task.Task_FNum = Convert.ToInt32(dr["Task_FNum"]);
                if (dr["Task_Roads"] != DBNull.Value) prod_Task.Task_Roads = Convert.ToString(dr["Task_Roads"]);
                if (dr["Task_ProdCode"] != DBNull.Value) prod_Task.Task_ProdCode = Convert.ToString(dr["Task_ProdCode"]);
                if (dr["Task_Stat"] != DBNull.Value) prod_Task.Task_Stat = Convert.ToString(dr["Task_Stat"]);
                if (dr["Task_Remark"] != DBNull.Value) prod_Task.Task_Remark = Convert.ToString(dr["Task_Remark"]);
                if (dr["Task_Customer"] != DBNull.Value) prod_Task.Task_Customer = Convert.ToString(dr["Task_Customer"]);
                if (dr["Task_CustomerName"] != DBNull.Value) prod_Task.Task_CustomerName = Convert.ToString(dr["Task_CustomerName"]);
                if (dr["Stat"] != DBNull.Value) prod_Task.Stat = Convert.ToInt32(dr["Stat"]);
                //扩展属性
                if (dr["Task_PlanNum"] != DBNull.Value) prod_Task.Task_PlanNum = Convert.ToInt32(dr["Task_PlanNum"]);

                ret.Add(prod_Task);
            }
            dr.Close();
            return ret;
        }

        /// <summary>
        /// 需要剔除重复的任务
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<Prod_Task> GetListByWhereWithContract(string strCondition)
        {

            List<Prod_Task> ret = new List<Prod_Task>();
            string sql = @"select distinct  pc.Cmd_CBill, pt.*,sdr.SDR_ContractCode  from prod_task pt
join SD_CRProdCode sdr on sdr.SDR_PartNo=pt.TaskDetail_PartNo and sdr.SDR_CmdCode=pt.TaskDetail_CmdCode and isnull(sdr.stat,0)=0
left join prod_command pc on pc.cmd_code=pt.TaskDetail_CmdCode and isnull(pc.stat,0)=0
where 1=1 AND ((pt.Stat is null) or (pt.Stat=0) )  ";
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
                    Prod_Task prod_Task = new Prod_Task();
                    if (dr["Task_ID"] != DBNull.Value) prod_Task.Task_ID = Convert.ToInt64(dr["Task_ID"]);
                    if (dr["Task_Code"] != DBNull.Value) prod_Task.Task_Code = Convert.ToString(dr["Task_Code"]);
                    if (dr["Task_Name"] != DBNull.Value) prod_Task.Task_Name = Convert.ToString(dr["Task_Name"]);
                    if (dr["TaskDetail_CmdCode"] != DBNull.Value) prod_Task.TaskDetail_CmdCode = Convert.ToString(dr["TaskDetail_CmdCode"]);
                    if (dr["TaskDetail_PartNo"] != DBNull.Value) prod_Task.TaskDetail_PartNo = Convert.ToString(dr["TaskDetail_PartNo"]);
                    if (dr["TaskDetail_PartName"] != DBNull.Value) prod_Task.TaskDetail_PartName = Convert.ToString(dr["TaskDetail_PartName"]);
                    if (dr["Task_PartCat"] != DBNull.Value) prod_Task.Task_PartCat = Convert.ToString(dr["Task_PartCat"]);
                    if (dr["Task_PartCatName"] != DBNull.Value) prod_Task.Task_PartCatName = Convert.ToString(dr["Task_PartCatName"]);
                    if (dr["Task_Owner"] != DBNull.Value) prod_Task.Task_Owner = Convert.ToString(dr["Task_Owner"]);
                    if (dr["Task_Date"] != DBNull.Value) prod_Task.Task_Date = Convert.ToDateTime(dr["Task_Date"]);
                    if (dr["TaskDetail_Unit"] != DBNull.Value) prod_Task.TaskDetail_Unit = Convert.ToString(dr["TaskDetail_Unit"]);
                    if (dr["TaskDetail_Num"] != DBNull.Value) prod_Task.TaskDetail_Num = Convert.ToInt32(dr["TaskDetail_Num"]);
                    if (dr["Task_DNum"] != DBNull.Value) prod_Task.Task_DNum = Convert.ToInt32(dr["Task_DNum"]);
                    if (dr["TaskDetail_ProdType"] != DBNull.Value) prod_Task.TaskDetail_ProdType = Convert.ToString(dr["TaskDetail_ProdType"]);
                    if (dr["TaskDetail_PlanBegin"] != DBNull.Value) prod_Task.TaskDetail_PlanBegin = Convert.ToDateTime(dr["TaskDetail_PlanBegin"]);
                    if (dr["TaskDetail_PlanEnd"] != DBNull.Value) prod_Task.TaskDetail_PlanEnd = Convert.ToDateTime(dr["TaskDetail_PlanEnd"]);
                    if (dr["TaskDetail_ActEnd"] != DBNull.Value) prod_Task.TaskDetail_ActEnd = Convert.ToDateTime(dr["TaskDetail_ActEnd"]);
                    if (dr["Task_FNum"] != DBNull.Value) prod_Task.Task_FNum = Convert.ToInt32(dr["Task_FNum"]);
                    if (dr["Task_Roads"] != DBNull.Value) prod_Task.Task_Roads = Convert.ToString(dr["Task_Roads"]);
                    if (dr["Task_ProdCode"] != DBNull.Value) prod_Task.Task_ProdCode = Convert.ToString(dr["Task_ProdCode"]);
                    if (dr["Task_Stat"] != DBNull.Value) prod_Task.Task_Stat = Convert.ToString(dr["Task_Stat"]);
                    if (dr["Task_Remark"] != DBNull.Value) prod_Task.Task_Remark = Convert.ToString(dr["Task_Remark"]);
                    if (dr["Stat"] != DBNull.Value) prod_Task.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["AuditStat"] != DBNull.Value) prod_Task.AuditStat = Convert.ToString(dr["AuditStat"]);
                    if (dr["AuditCurAudit"] != DBNull.Value) prod_Task.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                    if (dr["Task_Customer"] != DBNull.Value) prod_Task.Task_Customer = Convert.ToString(dr["Task_Customer"]);
                    if (dr["Task_CustomerName"] != DBNull.Value) prod_Task.Task_CustomerName = Convert.ToString(dr["Task_CustomerName"]);
                    if (dr["Task_RefInv"] != DBNull.Value) prod_Task.Task_RefInv = Convert.ToString(dr["Task_RefInv"]);

                    if (dr["SDR_ContractCode"] != DBNull.Value) prod_Task.SDR_ContractCode = Convert.ToString(dr["SDR_ContractCode"]);
                    if (dr["Cmd_CBill"] != DBNull.Value) prod_Task.Cmd_Creator = Convert.ToString(dr["Cmd_CBill"]);
                    ret.Add(prod_Task);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;

        }
    }
}
