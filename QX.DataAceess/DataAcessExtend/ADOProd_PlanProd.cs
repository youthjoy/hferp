using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;
using System.Data;

namespace QX.DataAceess
{
    public partial class ADOProd_PlanProd
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
	Prod_PlanProd", columnName);

            return idb.ReturnValue(sql);
        }



        /// <summary>
        /// 关联库存表得到计划所处状态 Prod_PlanProd对象集合
        /// </summary>
        public List<Prod_PlanProd> GetListByWhereExtend(string strCondition)
        {
            List<Prod_PlanProd> ret = new List<Prod_PlanProd>();
            string sql = @"SELECT inv.IInfor_Stat Inv_Stat,IInfor_ProdStat Prod_Stat, PlanProd_ID,PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_Bak,pp.Stat,inv.IInfor_Stat,inv.IInfor_ProdStat
FROM Prod_PlanProd pp
JOIN Inv_Information inv on inv.IInfor_ProdCode=pp.planprod_code
WHERE 1=1 AND ((pp.Stat is null) or (pp.Stat=0) )  AND inv.IInfor_ProdStat  not in ('Defective') ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Prod_PlanProd prod_PlanProd = new Prod_PlanProd();
                if (dr["PlanProd_ID"] != DBNull.Value) prod_PlanProd.PlanProd_ID = Convert.ToInt64(dr["PlanProd_ID"]);
                if (dr["PlanProd_PlanCode"] != DBNull.Value) prod_PlanProd.PlanProd_PlanCode = Convert.ToString(dr["PlanProd_PlanCode"]);
                if (dr["PlanProd_Code"] != DBNull.Value) prod_PlanProd.PlanProd_Code = Convert.ToString(dr["PlanProd_Code"]);
                if (dr["PlanProd_TaskDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskDetailCode = Convert.ToString(dr["PlanProd_TaskDetailCode"]);
                if (dr["PlanProd_TaskCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskCode = Convert.ToString(dr["PlanProd_TaskCode"]);
                if (dr["PlanProd_CmdDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdDetailCode = Convert.ToString(dr["PlanProd_CmdDetailCode"]);
                if (dr["PlanProd_CmdCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdCode = Convert.ToString(dr["PlanProd_CmdCode"]);
                if (dr["PlanProd_Period"] != DBNull.Value) prod_PlanProd.PlanProd_Period = Convert.ToString(dr["PlanProd_Period"]);
                if (dr["PlanProd_PartNo"] != DBNull.Value) prod_PlanProd.PlanProd_PartNo = Convert.ToString(dr["PlanProd_PartNo"]);
                if (dr["PlanProd_PartName"] != DBNull.Value) prod_PlanProd.PlanProd_PartName = Convert.ToString(dr["PlanProd_PartName"]);
                if (dr["PlanProd_Num"] != DBNull.Value) prod_PlanProd.PlanProd_Num = Convert.ToInt32(dr["PlanProd_Num"]);
                if (dr["PlanProd_FNum"] != DBNull.Value) prod_PlanProd.PlanProd_FNum = Convert.ToInt32(dr["PlanProd_FNum"]);
                if (dr["PlanProd_Begin"] != DBNull.Value) prod_PlanProd.PlanProd_Begin = Convert.ToDateTime(dr["PlanProd_Begin"]);
                if (dr["PlanProd_End"] != DBNull.Value) prod_PlanProd.PlanProd_End = Convert.ToDateTime(dr["PlanProd_End"]);
                if (dr["PlanProd_LineCode"] != DBNull.Value) prod_PlanProd.PlanProd_LineCode = Convert.ToString(dr["PlanProd_LineCode"]);
                if (dr["PlanProd_FDate"] != DBNull.Value) prod_PlanProd.PlanProd_FDate = Convert.ToDateTime(dr["PlanProd_FDate"]);
                if (dr["PlanProd_ConfirmPep"] != DBNull.Value) prod_PlanProd.PlanProd_ConfirmPep = Convert.ToString(dr["PlanProd_ConfirmPep"]);
                if (dr["PlanProd_Owner"] != DBNull.Value) prod_PlanProd.PlanProd_Owner = Convert.ToString(dr["PlanProd_Owner"]);
                if (dr["PlanProd_Date"] != DBNull.Value) prod_PlanProd.PlanProd_Date = Convert.ToDateTime(dr["PlanProd_Date"]);
                if (dr["PlanProd_Bak"] != DBNull.Value) prod_PlanProd.PlanProd_Bak = Convert.ToString(dr["PlanProd_Bak"]);
                if (dr["Stat"] != DBNull.Value) prod_PlanProd.Stat = Convert.ToInt32(dr["Stat"]);

                if (dr["IInfor_Stat"] != DBNull.Value) prod_PlanProd.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
                if (dr["IInfor_ProdStat"] != DBNull.Value) prod_PlanProd.IInfor_ProdStat = Convert.ToString(dr["IInfor_ProdStat"]);
                ret.Add(prod_PlanProd);
            }
            dr.Close();
            return ret;
        }

        public List<Prod_PlanProd> GetListByWhereForContract(string strCondition)
        {
            List<Prod_PlanProd> ret = new List<Prod_PlanProd>();
            string sql = @"select pp.*,(select top 1 iinfor_stat from inv_information where iinfor_plancode=pp.Planprod_Plancode) AS IInfor_Stat,sdr.SDR_ContractCode from prod_planprod pp
join SD_CRProdCode sdr on pp.PlanProd_PlanCode=sdr.SDR_PlanCode and sdr.SDR_PartNo=pp.PlanProd_PartNo and sdr.SDR_CmdCode=pp.PlanProd_CmdCode and isnull(sdr.stat,0)=0
 WHERE 1=1 AND ((pp.Stat is null) or (pp.Stat=0) ) ";
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
                    Prod_PlanProd prod_PlanProd = new Prod_PlanProd();
                    if (dr["PlanProd_ID"] != DBNull.Value) prod_PlanProd.PlanProd_ID = Convert.ToInt64(dr["PlanProd_ID"]);
                    if (dr["PlanProd_PlanCode"] != DBNull.Value) prod_PlanProd.PlanProd_PlanCode = Convert.ToString(dr["PlanProd_PlanCode"]);
                    if (dr["PlanProd_Code"] != DBNull.Value) prod_PlanProd.PlanProd_Code = Convert.ToString(dr["PlanProd_Code"]);
                    if (dr["PlanProd_TaskDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskDetailCode = Convert.ToString(dr["PlanProd_TaskDetailCode"]);
                    if (dr["PlanProd_TaskCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskCode = Convert.ToString(dr["PlanProd_TaskCode"]);
                    if (dr["PlanProd_CmdDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdDetailCode = Convert.ToString(dr["PlanProd_CmdDetailCode"]);
                    if (dr["PlanProd_CmdCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdCode = Convert.ToString(dr["PlanProd_CmdCode"]);
                    if (dr["PlanProd_Period"] != DBNull.Value) prod_PlanProd.PlanProd_Period = Convert.ToString(dr["PlanProd_Period"]);
                    if (dr["PlanProd_PartNo"] != DBNull.Value) prod_PlanProd.PlanProd_PartNo = Convert.ToString(dr["PlanProd_PartNo"]);
                    if (dr["PlanProd_PartName"] != DBNull.Value) prod_PlanProd.PlanProd_PartName = Convert.ToString(dr["PlanProd_PartName"]);
                    if (dr["PlanProd_Num"] != DBNull.Value) prod_PlanProd.PlanProd_Num = Convert.ToInt32(dr["PlanProd_Num"]);
                    if (dr["PlanProd_FNum"] != DBNull.Value) prod_PlanProd.PlanProd_FNum = Convert.ToInt32(dr["PlanProd_FNum"]);
                    if (dr["PlanProd_Begin"] != DBNull.Value) prod_PlanProd.PlanProd_Begin = Convert.ToDateTime(dr["PlanProd_Begin"]);
                    if (dr["PlanProd_End"] != DBNull.Value) prod_PlanProd.PlanProd_End = Convert.ToDateTime(dr["PlanProd_End"]);
                    if (dr["PlanProd_LineCode"] != DBNull.Value) prod_PlanProd.PlanProd_LineCode = Convert.ToString(dr["PlanProd_LineCode"]);
                    if (dr["PlanProd_FStat"] != DBNull.Value) prod_PlanProd.PlanProd_FStat = Convert.ToString(dr["PlanProd_FStat"]);
                    if (dr["PlanProd_FBDate"] != DBNull.Value) prod_PlanProd.PlanProd_FBDate = Convert.ToDateTime(dr["PlanProd_FBDate"]);
                    if (dr["PlanProd_FDate"] != DBNull.Value) prod_PlanProd.PlanProd_FDate = Convert.ToDateTime(dr["PlanProd_FDate"]);
                    if (dr["PlanProd_ConfirmPep"] != DBNull.Value) prod_PlanProd.PlanProd_ConfirmPep = Convert.ToString(dr["PlanProd_ConfirmPep"]);
                    if (dr["PlanProd_Owner"] != DBNull.Value) prod_PlanProd.PlanProd_Owner = Convert.ToString(dr["PlanProd_Owner"]);
                    if (dr["PlanProd_Date"] != DBNull.Value) prod_PlanProd.PlanProd_Date = Convert.ToDateTime(dr["PlanProd_Date"]);
                    if (dr["PlanProd_Bak"] != DBNull.Value) prod_PlanProd.PlanProd_Bak = Convert.ToString(dr["PlanProd_Bak"]);
                    if (dr["Stat"] != DBNull.Value) prod_PlanProd.Stat = Convert.ToInt32(dr["Stat"]);
                    if (dr["PlanProd_Patch"] != DBNull.Value) prod_PlanProd.PlanProd_Patch = Convert.ToString(dr["PlanProd_Patch"]);
                    if (dr["PlanProd_ActBTime"] != DBNull.Value) prod_PlanProd.PlanProd_ActBTime = Convert.ToDateTime(dr["PlanProd_ActBTime"]);
                    if (dr["PlanProd_ActETime"] != DBNull.Value) prod_PlanProd.PlanProd_ActETime = Convert.ToDateTime(dr["PlanProd_ActETime"]);
                    if (dr["PlanProd_MPatchCode"] != DBNull.Value) prod_PlanProd.PlanProd_MPatchCode = Convert.ToString(dr["PlanProd_MPatchCode"]);

                    if (dr["IInfor_Stat"] != DBNull.Value) prod_PlanProd.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
                    ret.Add(prod_PlanProd);
                }
            }
            catch (System.Exception ex) { throw ex; }
            finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); } }
            return ret;
        }

        /// <summary>
        /// 获取产品列表（包括组合）
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetListByWherePatch(string strCondition)
        {
            List<Prod_PlanProd> ret = new List<Prod_PlanProd>();
            string sql = @"SELECT inv.IInfor_Stat Inv_Stat,IInfor_ProdStat Prod_Stat, PlanProd_ID,PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FStat,PlanProd_FBDate,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_MPatchCode,PlanProd_Bak,pp.Stat,PlanProd_Patch,inv.IInfor_Stat,inv.IInfor_ProdStat
FROM Prod_PlanProd pp
JOIN Inv_Information inv on inv.IInfor_ProdCode=pp.planprod_code and inv.IInfor_TaskCode=pp.PlanProd_Taskcode
WHERE 1=1 AND ((pp.Stat is null) or (pp.Stat=0) ) and isnull(inv.stat,0)=0  AND inv.IInfor_ProdStat  not in ('Defective')  ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Prod_PlanProd prod_PlanProd = new Prod_PlanProd();
                if (dr["PlanProd_ID"] != DBNull.Value) prod_PlanProd.PlanProd_ID = Convert.ToInt64(dr["PlanProd_ID"]);
                if (dr["PlanProd_PlanCode"] != DBNull.Value) prod_PlanProd.PlanProd_PlanCode = Convert.ToString(dr["PlanProd_PlanCode"]);
                if (dr["PlanProd_Code"] != DBNull.Value) prod_PlanProd.PlanProd_Code = Convert.ToString(dr["PlanProd_Code"]);
                if (dr["PlanProd_TaskDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskDetailCode = Convert.ToString(dr["PlanProd_TaskDetailCode"]);
                if (dr["PlanProd_TaskCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskCode = Convert.ToString(dr["PlanProd_TaskCode"]);
                if (dr["PlanProd_CmdDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdDetailCode = Convert.ToString(dr["PlanProd_CmdDetailCode"]);
                if (dr["PlanProd_CmdCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdCode = Convert.ToString(dr["PlanProd_CmdCode"]);
                if (dr["PlanProd_Period"] != DBNull.Value) prod_PlanProd.PlanProd_Period = Convert.ToString(dr["PlanProd_Period"]);
                if (dr["PlanProd_PartNo"] != DBNull.Value) prod_PlanProd.PlanProd_PartNo = Convert.ToString(dr["PlanProd_PartNo"]);
                if (dr["PlanProd_PartName"] != DBNull.Value) prod_PlanProd.PlanProd_PartName = Convert.ToString(dr["PlanProd_PartName"]);
                if (dr["PlanProd_Num"] != DBNull.Value) prod_PlanProd.PlanProd_Num = Convert.ToInt32(dr["PlanProd_Num"]);
                if (dr["PlanProd_FNum"] != DBNull.Value) prod_PlanProd.PlanProd_FNum = Convert.ToInt32(dr["PlanProd_FNum"]);
                if (dr["PlanProd_Begin"] != DBNull.Value) prod_PlanProd.PlanProd_Begin = Convert.ToDateTime(dr["PlanProd_Begin"]);
                if (dr["PlanProd_End"] != DBNull.Value) prod_PlanProd.PlanProd_End = Convert.ToDateTime(dr["PlanProd_End"]);
                if (dr["PlanProd_LineCode"] != DBNull.Value) prod_PlanProd.PlanProd_LineCode = Convert.ToString(dr["PlanProd_LineCode"]);
                if (dr["PlanProd_FStat"] != DBNull.Value) prod_PlanProd.PlanProd_FStat = Convert.ToString(dr["PlanProd_FStat"]);
                if (dr["PlanProd_FBDate"] != DBNull.Value) prod_PlanProd.PlanProd_FBDate = Convert.ToDateTime(dr["PlanProd_FBDate"]);
                if (dr["PlanProd_FDate"] != DBNull.Value) prod_PlanProd.PlanProd_FDate = Convert.ToDateTime(dr["PlanProd_FDate"]);
                if (dr["PlanProd_ConfirmPep"] != DBNull.Value) prod_PlanProd.PlanProd_ConfirmPep = Convert.ToString(dr["PlanProd_ConfirmPep"]);
                if (dr["PlanProd_Owner"] != DBNull.Value) prod_PlanProd.PlanProd_Owner = Convert.ToString(dr["PlanProd_Owner"]);
                if (dr["PlanProd_Date"] != DBNull.Value) prod_PlanProd.PlanProd_Date = Convert.ToDateTime(dr["PlanProd_Date"]);
                if (dr["PlanProd_Bak"] != DBNull.Value) prod_PlanProd.PlanProd_Bak = Convert.ToString(dr["PlanProd_Bak"]);
                if (dr["Stat"] != DBNull.Value) prod_PlanProd.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["PlanProd_Patch"] != DBNull.Value) prod_PlanProd.PlanProd_Patch = Convert.ToString(dr["PlanProd_Patch"]);
                if (dr["IInfor_Stat"] != DBNull.Value) prod_PlanProd.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
                if (dr["IInfor_ProdStat"] != DBNull.Value) prod_PlanProd.IInfor_ProdStat = Convert.ToString(dr["IInfor_ProdStat"]);
                if (dr["PlanProd_MPatchCode"] != DBNull.Value) prod_PlanProd.PlanProd_MPatchCode = Convert.ToString(dr["PlanProd_MPatchCode"]);
                ret.Add(prod_PlanProd);
            }
            dr.Close();
            return ret;
        }

        public List<Prod_PlanProd> GetListByWhereForPatch(string strCondition)
        {
            List<Prod_PlanProd> ret = new List<Prod_PlanProd>();
            string sql = @"select distinct b.* from prod_planprod a 
join (select * from prod_planprod) b on a.planprod_patch=b.planprod_code
where isnull(b.stat,0)=0 and isnull(a.stat,0)=0";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Prod_PlanProd prod_PlanProd = new Prod_PlanProd();
                if (dr["PlanProd_ID"] != DBNull.Value) prod_PlanProd.PlanProd_ID = Convert.ToInt64(dr["PlanProd_ID"]);
                if (dr["PlanProd_PlanCode"] != DBNull.Value) prod_PlanProd.PlanProd_PlanCode = Convert.ToString(dr["PlanProd_PlanCode"]);
                if (dr["PlanProd_Code"] != DBNull.Value) prod_PlanProd.PlanProd_Code = Convert.ToString(dr["PlanProd_Code"]);
                if (dr["PlanProd_TaskDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskDetailCode = Convert.ToString(dr["PlanProd_TaskDetailCode"]);
                if (dr["PlanProd_TaskCode"] != DBNull.Value) prod_PlanProd.PlanProd_TaskCode = Convert.ToString(dr["PlanProd_TaskCode"]);
                if (dr["PlanProd_CmdDetailCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdDetailCode = Convert.ToString(dr["PlanProd_CmdDetailCode"]);
                if (dr["PlanProd_CmdCode"] != DBNull.Value) prod_PlanProd.PlanProd_CmdCode = Convert.ToString(dr["PlanProd_CmdCode"]);
                if (dr["PlanProd_Period"] != DBNull.Value) prod_PlanProd.PlanProd_Period = Convert.ToString(dr["PlanProd_Period"]);
                if (dr["PlanProd_PartNo"] != DBNull.Value) prod_PlanProd.PlanProd_PartNo = Convert.ToString(dr["PlanProd_PartNo"]);
                if (dr["PlanProd_PartName"] != DBNull.Value) prod_PlanProd.PlanProd_PartName = Convert.ToString(dr["PlanProd_PartName"]);
                if (dr["PlanProd_Num"] != DBNull.Value) prod_PlanProd.PlanProd_Num = Convert.ToInt32(dr["PlanProd_Num"]);
                if (dr["PlanProd_FNum"] != DBNull.Value) prod_PlanProd.PlanProd_FNum = Convert.ToInt32(dr["PlanProd_FNum"]);
                if (dr["PlanProd_Begin"] != DBNull.Value) prod_PlanProd.PlanProd_Begin = Convert.ToDateTime(dr["PlanProd_Begin"]);
                if (dr["PlanProd_End"] != DBNull.Value) prod_PlanProd.PlanProd_End = Convert.ToDateTime(dr["PlanProd_End"]);
                if (dr["PlanProd_LineCode"] != DBNull.Value) prod_PlanProd.PlanProd_LineCode = Convert.ToString(dr["PlanProd_LineCode"]);
                if (dr["PlanProd_FStat"] != DBNull.Value) prod_PlanProd.PlanProd_FStat = Convert.ToString(dr["PlanProd_FStat"]);
                if (dr["PlanProd_FBDate"] != DBNull.Value) prod_PlanProd.PlanProd_FBDate = Convert.ToDateTime(dr["PlanProd_FBDate"]);
                if (dr["PlanProd_FDate"] != DBNull.Value) prod_PlanProd.PlanProd_FDate = Convert.ToDateTime(dr["PlanProd_FDate"]);
                if (dr["PlanProd_ConfirmPep"] != DBNull.Value) prod_PlanProd.PlanProd_ConfirmPep = Convert.ToString(dr["PlanProd_ConfirmPep"]);
                if (dr["PlanProd_Owner"] != DBNull.Value) prod_PlanProd.PlanProd_Owner = Convert.ToString(dr["PlanProd_Owner"]);
                if (dr["PlanProd_Date"] != DBNull.Value) prod_PlanProd.PlanProd_Date = Convert.ToDateTime(dr["PlanProd_Date"]);
                if (dr["PlanProd_Bak"] != DBNull.Value) prod_PlanProd.PlanProd_Bak = Convert.ToString(dr["PlanProd_Bak"]);
                if (dr["Stat"] != DBNull.Value) prod_PlanProd.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["PlanProd_Patch"] != DBNull.Value) prod_PlanProd.PlanProd_Patch = Convert.ToString(dr["PlanProd_Patch"]);
                //if (dr["IInfor_Stat"] != DBNull.Value) prod_PlanProd.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
                //if (dr["IInfor_ProdStat"] != DBNull.Value) prod_PlanProd.IInfor_ProdStat = Convert.ToString(dr["IInfor_ProdStat"]);
                ret.Add(prod_PlanProd);
            }
            dr.Close();
            return ret;
        }


    }
}
