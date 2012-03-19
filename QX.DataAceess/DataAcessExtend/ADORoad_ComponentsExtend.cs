using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using System.Data.SqlClient;

namespace QX.DataAceess
{
    public partial class ADORoad_Components
    {
        /// <summary>
        /// 添加零件图号信息 Road_Components对象(即:一条记录)
        /// </summary>
        public object AddForReturn(Road_Components road_Components)
        {
            string sql = "INSERT INTO Road_Components (Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order) VALUES (@Comp_Code,@Comp_Name,@Comp_Design,@Comp_Bak,@Comp_Stat,@Comp_CatCode,@Comp_CatName,@Stat,@Comp_Order)";
            if (string.IsNullOrEmpty(road_Components.Comp_Code))
            {
                idb.AddParameter("@Comp_Code", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_Code", road_Components.Comp_Code);
            }
            if (string.IsNullOrEmpty(road_Components.Comp_Name))
            {
                idb.AddParameter("@Comp_Name", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_Name", road_Components.Comp_Name);
            }
            if (string.IsNullOrEmpty(road_Components.Comp_Design))
            {
                idb.AddParameter("@Comp_Design", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_Design", road_Components.Comp_Design);
            }
            if (string.IsNullOrEmpty(road_Components.Comp_Bak))
            {
                idb.AddParameter("@Comp_Bak", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_Bak", road_Components.Comp_Bak);
            }
            if (string.IsNullOrEmpty(road_Components.Comp_Stat))
            {
                idb.AddParameter("@Comp_Stat", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_Stat", road_Components.Comp_Stat);
            }
            if (string.IsNullOrEmpty(road_Components.Comp_CatCode))
            {
                idb.AddParameter("@Comp_CatCode", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_CatCode", road_Components.Comp_CatCode);
            }
            if (string.IsNullOrEmpty(road_Components.Comp_CatName))
            {
                idb.AddParameter("@Comp_CatName", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_CatName", road_Components.Comp_CatName);
            }
            if (road_Components.Stat == 0)
            {
                idb.AddParameter("@Stat", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Stat", road_Components.Stat);
            }
            if (road_Components.Comp_Order == 0)
            {
                idb.AddParameter("@Comp_Order", DBNull.Value);
            }
            else
            {
                idb.AddParameter("@Comp_Order", road_Components.Comp_Order);
            }

            return idb.ReturnValue(sql);
        }

        /// <summary>
        /// 获取指定的零件图号信息 Road_Components对象集合
        /// </summary>
        public List<Road_Components> GetListByWhereExtend(string strCondition)
        {
            List<Road_Components> ret = new List<Road_Components>();
            string sql = @"SELECT Comp_ID,Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime,(select sum(RNodes_TimeCost) from Road_Nodes rn where rn.RNodes_PartCode=Comp_Code and (rn.stat =0 or rn.stat is null)) as RComponents_TimeCost
FROM Road_Components 
WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Road_Components road_Components = new Road_Components();
                if (dr["Comp_ID"] != DBNull.Value) road_Components.Comp_ID = Convert.ToInt64(dr["Comp_ID"]);
                if (dr["Comp_Code"] != DBNull.Value) road_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
                if (dr["Comp_Name"] != DBNull.Value) road_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
                if (dr["Comp_Design"] != DBNull.Value) road_Components.Comp_Design = Convert.ToString(dr["Comp_Design"]);
                if (dr["Comp_Bak"] != DBNull.Value) road_Components.Comp_Bak = Convert.ToString(dr["Comp_Bak"]);
                if (dr["Comp_Stat"] != DBNull.Value) road_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
                if (dr["Comp_CatCode"] != DBNull.Value) road_Components.Comp_CatCode = Convert.ToString(dr["Comp_CatCode"]);
                if (dr["Comp_CatName"] != DBNull.Value) road_Components.Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
                if (dr["Stat"] != DBNull.Value) road_Components.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["Comp_Order"] != DBNull.Value) road_Components.Comp_Order = Convert.ToInt32(dr["Comp_Order"]);
                if (dr["AuditStat"] != DBNull.Value) road_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
                if (dr["AuditCurAudit"] != DBNull.Value) road_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                if (dr["Comp_CurNode"] != DBNull.Value) road_Components.Comp_CurNode = Convert.ToString(dr["Comp_CurNode"]);
                if (dr["Comp_Creator"] != DBNull.Value) road_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
                if (dr["Comp_CreatTime"] != DBNull.Value) road_Components.Comp_CreatTime = Convert.ToDateTime(dr["Comp_CreatTime"]);
                
                //扩展属性
                if (dr["RComponents_TimeCost"] != DBNull.Value) road_Components.RComponents_TimeCost = Convert.ToDecimal(dr["RComponents_TimeCost"]);

                ret.Add(road_Components);
            }
            dr.Close();
            return ret;
        }

        public object GetComponentsTimeCost(string strCondition)
        {
            string sql = @"select isnull(sum(RNodes_TimeCost),0) from Road_Nodes rn 
where 1=1 and (rn.stat =0 or rn.stat is null) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }

            return idb.ReturnValue(sql);
        }


        /// <summary>
        /// 获取指定的零件图号信息 Road_Components对象集合
        /// </summary>
        public List<Road_Components> GetListByWhereWithUserData(string strCondition)
        {
            List<Road_Components> ret = new List<Road_Components>();
            string sql = @"SELECT  Comp_ID,Comp_Code,Comp_Name,Comp_Design,Comp_Bak
,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime 
,(select isnull(sum(RNodes_TimeCost),0) from Road_Nodes rn where rn.RNodes_PartCode=Comp_Code and (rn.stat =0 or rn.stat is null)) as RComponents_TimeCost
FROM Road_Components 
WHERE 1=1 AND ((Stat is null) or (Stat=0)) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Road_Components road_Components = new Road_Components();
                if (dr["Comp_ID"] != DBNull.Value) road_Components.Comp_ID = Convert.ToInt64(dr["Comp_ID"]);
                if (dr["Comp_Code"] != DBNull.Value) road_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
                if (dr["Comp_Name"] != DBNull.Value) road_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
                if (dr["Comp_Design"] != DBNull.Value) road_Components.Comp_Design = Convert.ToString(dr["Comp_Design"]);
                if (dr["Comp_Bak"] != DBNull.Value) road_Components.Comp_Bak = Convert.ToString(dr["Comp_Bak"]);
                if (dr["Comp_Stat"] != DBNull.Value) road_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
                if (dr["Comp_CatCode"] != DBNull.Value) road_Components.Comp_CatCode = Convert.ToString(dr["Comp_CatCode"]);
                if (dr["Comp_CatName"] != DBNull.Value) road_Components.Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
                if (dr["Stat"] != DBNull.Value) road_Components.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["Comp_Order"] != DBNull.Value) road_Components.Comp_Order = Convert.ToInt32(dr["Comp_Order"]);
                if (dr["AuditStat"] != DBNull.Value) road_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
                if (dr["AuditCurAudit"] != DBNull.Value) road_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
                if (dr["Comp_CurNode"] != DBNull.Value) road_Components.Comp_CurNode = Convert.ToString(dr["Comp_CurNode"]);
                if (dr["Comp_Creator"] != DBNull.Value) road_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
                if (dr["Comp_CreatTime"] != DBNull.Value) road_Components.Comp_CreatTime = Convert.ToDateTime(dr["Comp_CreatTime"]);
                //扩展属性
                if (dr["RComponents_TimeCost"] != DBNull.Value) road_Components.RComponents_TimeCost = Convert.ToDecimal(dr["RComponents_TimeCost"]);

                ret.Add(road_Components);
            }
            dr.Close();
            return ret;
        }


        /// <summary>
        /// 获取指定的零件图号信息 Road_Components对象集合
        /// </summary>
        public List<Road_Components> GetListByWhereWithUserAudited(string strCondition)
        {
            List<Road_Components> ret = new List<Road_Components>();
            string sql = @"SELECT DISTINCT rc.* ,(select sum(RNodes_TimeCost) from Road_Nodes rn where rn.RNodes_PartCode=Comp_Code and (rn.stat =0 or rn.stat is null)) as RComponents_TimeCost FROM VerifyProcess_Records vr
JOIN Verify_Users vu  ON vu.VU_User=vr.VRecord_Owner
JOIN Road_Components rc ON rc.Comp_Code=vr.Record_ID 
WHERE vu.VU_VerifyTempldate_Code IS NULL AND (vr.Stat IS NULL OR vr.Stat=0) ";
            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition.Replace('\'', '"'); //防sql注入
                sql += strCondition;
            }
            SqlDataReader dr = (SqlDataReader)idb.ReturnReader(sql);
            while (dr.Read())
            {
                Road_Components road_Components = new Road_Components();
                if (dr["Comp_ID"] != DBNull.Value) road_Components.Comp_ID = Convert.ToInt64(dr["Comp_ID"]);
                if (dr["Comp_Code"] != DBNull.Value) road_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
                if (dr["Comp_Name"] != DBNull.Value) road_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
                if (dr["Comp_Design"] != DBNull.Value) road_Components.Comp_Design = Convert.ToString(dr["Comp_Design"]);
                if (dr["Comp_Bak"] != DBNull.Value) road_Components.Comp_Bak = Convert.ToString(dr["Comp_Bak"]);
                if (dr["Comp_Stat"] != DBNull.Value) road_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
                if (dr["Comp_CatCode"] != DBNull.Value) road_Components.Comp_CatCode = Convert.ToString(dr["Comp_CatCode"]);
                if (dr["Comp_CatName"] != DBNull.Value) road_Components.Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
                if (dr["Stat"] != DBNull.Value) road_Components.Stat = Convert.ToInt32(dr["Stat"]);
                if (dr["Comp_Order"] != DBNull.Value) road_Components.Comp_Order = Convert.ToInt32(dr["Comp_Order"]);
                if (dr["Comp_CurNode"] != DBNull.Value) road_Components.Comp_CurNode = Convert.ToString(dr["Comp_CurNode"]);

                //扩展属性
                if (dr["RComponents_TimeCost"] != DBNull.Value) road_Components.RComponents_TimeCost = Convert.ToDecimal(dr["RComponents_TimeCost"]);

                ret.Add(road_Components);
            }
            dr.Close();
            return ret;
        }
    }
}
