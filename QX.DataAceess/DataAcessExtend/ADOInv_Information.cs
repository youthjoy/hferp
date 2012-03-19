using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;

namespace QX.DataAceess
{
    public partial class ADOInv_Information
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
	Inv_Information", columnName);

            return idb.ReturnValue(sql);
        }


        /// <summary>
        /// 获取指定的Inv_Information对象集合
        /// </summary>
        public List<Inv_Information> GetListByWhereExtend(string strCondition)
        {
            List<Inv_Information> ret = new List<Inv_Information>();
            string sql = @"SELECT  r.Comp_Code as IInfor_PartNo,r.Comp_Name as IInfor_PartName,
            ISNULL((Select SUM(IInfor_Num) from Inv_Information where Inv_Information.IInfor_PartNo=r.Comp_Code),0) as IInfor_Num
            FROM Road_Components r
            WHERE 1=1 AND ((r.Stat is null) or (r.Stat=0) ) ";
            //            string sql = @"SELECT  r.Comp_Code as IInfor_PartNo,r.Comp_Name as IInfor_PartName,IInfor_ProdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,Inv_Information.Stat,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime 
            //FROM Road_Components r
            //LEFT JOIN Inv_Information ON r.Comp_Code=Inv_Information.IInfor_PartNo 
            //WHERE 1=1 AND ((r.Stat is null) or (r.Stat=0) ) ";

            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }

            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Inv_Information inv_Information = new Inv_Information();
                //if (dr["IInfor_ID"] != DBNull.Value) inv_Information.IInfor_ID = Convert.ToInt64(dr["IInfor_ID"]);
                //if (dr["IInfor_ID"] != DBNull.Value) inv_Information.IInfor_ID = Convert.ToInt64(dr["IInfor_ID"]);
                if (dr["IInfor_PartNo"] != DBNull.Value) inv_Information.IInfor_PartNo = Convert.ToString(dr["IInfor_PartNo"]);
                if (dr["IInfor_PartName"] != DBNull.Value) inv_Information.IInfor_PartName = Convert.ToString(dr["IInfor_PartName"]);
                //if (dr["IInfor_ProdCode"] != DBNull.Value) inv_Information.IInfor_ProdCode = Convert.ToString(dr["IInfor_ProdCode"]);
                //if (dr["IInfor_PlanBegin"] != DBNull.Value) inv_Information.IInfor_PlanBegin = Convert.ToDateTime(dr["IInfor_PlanBegin"]);
                //if (dr["IInfor_PlanEnd"] != DBNull.Value) inv_Information.IInfor_PlanEnd = Convert.ToDateTime(dr["IInfor_PlanEnd"]);
                //if (dr["IInfor_InTime"] != DBNull.Value) inv_Information.IInfor_InTime = Convert.ToDateTime(dr["IInfor_InTime"]);
                if (dr["IInfor_Num"] != DBNull.Value) inv_Information.IInfor_Num = Convert.ToInt32(dr["IInfor_Num"]);
                //if (dr["IInfor_WareHouse"] != DBNull.Value) inv_Information.IInfor_WareHouse = Convert.ToString(dr["IInfor_WareHouse"]);
                //if (dr["IInfor_InConfirm"] != DBNull.Value) inv_Information.IInfor_InConfirm = Convert.ToString(dr["IInfor_InConfirm"]);
                //if (dr["IInfor_InPep"] != DBNull.Value) inv_Information.IInfor_InPep = Convert.ToString(dr["IInfor_InPep"]);
                //if (dr["IInfor_InDate"] != DBNull.Value) inv_Information.IInfor_InDate = Convert.ToDateTime(dr["IInfor_InDate"]);
                //if (dr["IInfor_Stat"] != DBNull.Value) inv_Information.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
                //if (dr["IInfor_OutDate"] != DBNull.Value) inv_Information.IInfor_OutDate = Convert.ToDateTime(dr["IInfor_OutDate"]);
                //if (dr["IInfor_OutPep"] != DBNull.Value) inv_Information.IInfor_OutPep = Convert.ToString(dr["IInfor_OutPep"]);
                //if (dr["IInfor_CustConfirmNo"] != DBNull.Value) inv_Information.IInfor_CustConfirmNo = Convert.ToString(dr["IInfor_CustConfirmNo"]);
                //if (dr["IInfor_CustConfirmDate"] != DBNull.Value) inv_Information.IInfor_CustConfirmDate = Convert.ToDateTime(dr["IInfor_CustConfirmDate"]);
                //if (dr["IInfor_CustBak"] != DBNull.Value) inv_Information.IInfor_CustBak = Convert.ToString(dr["IInfor_CustBak"]);
                //if (dr["Stat"] != DBNull.Value) inv_Information.Stat = Convert.ToInt32(dr["Stat"]);
                //if (dr["IInfor_ProdType"] != DBNull.Value) inv_Information.IInfor_ProdType = Convert.ToInt32(dr["IInfor_ProdType"]);
                //if (dr["CreateTime"] != DBNull.Value) inv_Information.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                //if (dr["UpdateTime"] != DBNull.Value) inv_Information.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
                //if (dr["DeleteTime"] != DBNull.Value) inv_Information.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
                ret.Add(inv_Information);
            }
            dr.Close();
            return ret;
        }


        /// <summary>
        /// 获取指定的Inv_Information对象集合
        /// </summary>
        public List<Inv_Information> GetInvListByWhere(string strCondition)
        {
            List<Inv_Information> ret = new List<Inv_Information>();
            string sql = @"SELECT distinct IInfor_ID,IInfor_TaskCode,IInfor_CmdCode,(select top 1 cmddetail_roads from prod_cmddetail where isnull(stat,0)=0 and cmd_code=iinfor_cmdcode and cmddetail_partno=iinfor_partno) as IInfor_CmdReq,IInfor_PlanCode, IInfor_PartNo,(select top 1 r.Comp_Name from road_components r where isnull(stat,0)=0 and r.Comp_Code=Inv_Information.IInfor_PartNo  )as IInfor_PartName,IInfor_ProdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,Inv_Information.Stat,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime 
FROM Inv_Information where 1=1 and isnull(stat,0)=0";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Inv_Information inv_Information = new Inv_Information();
                if (dr["IInfor_ID"] != DBNull.Value) inv_Information.IInfor_ID = Convert.ToInt64(dr["IInfor_ID"]);
                if (dr["IInfor_PartNo"] != DBNull.Value) inv_Information.IInfor_PartNo = Convert.ToString(dr["IInfor_PartNo"]);
                if (dr["IInfor_PartName"] != DBNull.Value) inv_Information.IInfor_PartName = Convert.ToString(dr["IInfor_PartName"]);
                if (dr["IInfor_TaskCode"] != DBNull.Value) inv_Information.IInfor_TaskCode = Convert.ToString(dr["IInfor_TaskCode"]);
                if (dr["IInfor_ProdCode"] != DBNull.Value) inv_Information.IInfor_ProdCode = Convert.ToString(dr["IInfor_ProdCode"]);
                if (dr["IInfor_PlanCode"] != DBNull.Value) inv_Information.IInfor_PlanCode = Convert.ToString(dr["IInfor_PlanCode"]);
                if (dr["IInfor_CmdCode"] != DBNull.Value) inv_Information.IInfor_CmdCode = Convert.ToString(dr["IInfor_CmdCode"]);
                if (dr["IInfor_PlanBegin"] != DBNull.Value) inv_Information.IInfor_PlanBegin = Convert.ToDateTime(dr["IInfor_PlanBegin"]);
                if (dr["IInfor_PlanEnd"] != DBNull.Value) inv_Information.IInfor_PlanEnd = Convert.ToDateTime(dr["IInfor_PlanEnd"]);
                if (dr["IInfor_InTime"] != DBNull.Value) inv_Information.IInfor_InTime = Convert.ToDateTime(dr["IInfor_InTime"]);
                if (dr["IInfor_Num"] != DBNull.Value) inv_Information.IInfor_Num = Convert.ToInt32(dr["IInfor_Num"]);
                if (dr["IInfor_WareHouse"] != DBNull.Value) inv_Information.IInfor_WareHouse = Convert.ToString(dr["IInfor_WareHouse"]);
                if (dr["IInfor_InConfirm"] != DBNull.Value) inv_Information.IInfor_InConfirm = Convert.ToString(dr["IInfor_InConfirm"]);
                if (dr["IInfor_InPep"] != DBNull.Value) inv_Information.IInfor_InPep = Convert.ToString(dr["IInfor_InPep"]);
                if (dr["IInfor_InDate"] != DBNull.Value) inv_Information.IInfor_InDate = Convert.ToDateTime(dr["IInfor_InDate"]);
                if (dr["IInfor_Stat"] != DBNull.Value) inv_Information.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
                if (dr["IInfor_OutDate"] != DBNull.Value) inv_Information.IInfor_OutDate = Convert.ToDateTime(dr["IInfor_OutDate"]);
                if (dr["IInfor_OutPep"] != DBNull.Value) inv_Information.IInfor_OutPep = Convert.ToString(dr["IInfor_OutPep"]);
                if (dr["IInfor_CustConfirmNo"] != DBNull.Value) inv_Information.IInfor_CustConfirmNo = Convert.ToString(dr["IInfor_CustConfirmNo"]);
                if (dr["IInfor_CustConfirmDate"] != DBNull.Value) inv_Information.IInfor_CustConfirmDate = Convert.ToDateTime(dr["IInfor_CustConfirmDate"]);
                if (dr["IInfor_CustBak"] != DBNull.Value) inv_Information.IInfor_CustBak = Convert.ToString(dr["IInfor_CustBak"]);
                if (dr["Stat"] != DBNull.Value) inv_Information.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["IInfor_ProdType"] != DBNull.Value) inv_Information.IInfor_ProdType = Convert.ToInt32(dr["IInfor_ProdType"]);
                if (dr["CreateTime"] != DBNull.Value) inv_Information.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
                if (dr["UpdateTime"] != DBNull.Value) inv_Information.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
                if (dr["DeleteTime"] != DBNull.Value) inv_Information.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);

                if (dr["IInfor_CmdReq"] != DBNull.Value) inv_Information.IInfor_CmdReq = Convert.ToString(dr["IInfor_CmdReq"]);

                ret.Add(inv_Information);
            }
            dr.Close();
            return ret;
        }
    }
}
