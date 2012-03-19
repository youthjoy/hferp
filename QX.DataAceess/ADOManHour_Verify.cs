using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAcess;

namespace QX.DataAceess
{
   /// <summary>
   /// 工时审核表
   /// </summary>
   [Serializable]
   public partial class ADOManHour_Verify
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加工时审核表 ManHour_Verify对象(即:一条记录)
      /// </summary>
      public int Add(ManHour_Verify manHour_Verify)
      {
         string sql = "INSERT INTO ManHour_Verify (Verify_PartCode,Verify_ManHour,Verify_Cost,Verify_Stat,Verify_Time,Verify_Resp,Verify_RespName,Verify_RoadNodeCode) VALUES (@Verify_PartCode,@Verify_ManHour,@Verify_Cost,@Verify_Stat,@Verify_Time,@Verify_Resp,@Verify_RespName,@Verify_RoadNodeCode)";
         if (string.IsNullOrEmpty(manHour_Verify.Verify_PartCode))
         {
            idb.AddParameter("@Verify_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_PartCode", manHour_Verify.Verify_PartCode);
         }
         if (manHour_Verify.Verify_ManHour == 0)
         {
            idb.AddParameter("@Verify_ManHour", 0);
         }
         else
         {
            idb.AddParameter("@Verify_ManHour", manHour_Verify.Verify_ManHour);
         }
         if (manHour_Verify.Verify_Cost == 0)
         {
            idb.AddParameter("@Verify_Cost", 0);
         }
         else
         {
            idb.AddParameter("@Verify_Cost", manHour_Verify.Verify_Cost);
         }
         if (manHour_Verify.Verify_Stat == 0)
         {
            idb.AddParameter("@Verify_Stat", 0);
         }
         else
         {
            idb.AddParameter("@Verify_Stat", manHour_Verify.Verify_Stat);
         }
         if (manHour_Verify.Verify_Time == DateTime.MinValue)
         {
            idb.AddParameter("@Verify_Time", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_Time", manHour_Verify.Verify_Time);
         }
         if (string.IsNullOrEmpty(manHour_Verify.Verify_Resp))
         {
            idb.AddParameter("@Verify_Resp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_Resp", manHour_Verify.Verify_Resp);
         }
         if (string.IsNullOrEmpty(manHour_Verify.Verify_RespName))
         {
            idb.AddParameter("@Verify_RespName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_RespName", manHour_Verify.Verify_RespName);
         }
         if (string.IsNullOrEmpty(manHour_Verify.Verify_RoadNodeCode))
         {
            idb.AddParameter("@Verify_RoadNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_RoadNodeCode", manHour_Verify.Verify_RoadNodeCode);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加工时审核表 ManHour_Verify对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(ManHour_Verify manHour_Verify)
      {
         string sql = "INSERT INTO ManHour_Verify (Verify_PartCode,Verify_ManHour,Verify_Cost,Verify_Stat,Verify_Time,Verify_Resp,Verify_RespName,Verify_RoadNodeCode) VALUES (@Verify_PartCode,@Verify_ManHour,@Verify_Cost,@Verify_Stat,@Verify_Time,@Verify_Resp,@Verify_RespName,@Verify_RoadNodeCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(manHour_Verify.Verify_PartCode))
         {
            idb.AddParameter("@Verify_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_PartCode", manHour_Verify.Verify_PartCode);
         }
         if (manHour_Verify.Verify_ManHour == 0)
         {
            idb.AddParameter("@Verify_ManHour", 0);
         }
         else
         {
            idb.AddParameter("@Verify_ManHour", manHour_Verify.Verify_ManHour);
         }
         if (manHour_Verify.Verify_Cost == 0)
         {
            idb.AddParameter("@Verify_Cost", 0);
         }
         else
         {
            idb.AddParameter("@Verify_Cost", manHour_Verify.Verify_Cost);
         }
         if (manHour_Verify.Verify_Stat == 0)
         {
            idb.AddParameter("@Verify_Stat", 0);
         }
         else
         {
            idb.AddParameter("@Verify_Stat", manHour_Verify.Verify_Stat);
         }
         if (manHour_Verify.Verify_Time == DateTime.MinValue)
         {
            idb.AddParameter("@Verify_Time", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_Time", manHour_Verify.Verify_Time);
         }
         if (string.IsNullOrEmpty(manHour_Verify.Verify_Resp))
         {
            idb.AddParameter("@Verify_Resp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_Resp", manHour_Verify.Verify_Resp);
         }
         if (string.IsNullOrEmpty(manHour_Verify.Verify_RespName))
         {
            idb.AddParameter("@Verify_RespName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_RespName", manHour_Verify.Verify_RespName);
         }
         if (string.IsNullOrEmpty(manHour_Verify.Verify_RoadNodeCode))
         {
            idb.AddParameter("@Verify_RoadNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_RoadNodeCode", manHour_Verify.Verify_RoadNodeCode);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新工时审核表 ManHour_Verify对象(即:一条记录
      /// </summary>
      public int Update(ManHour_Verify manHour_Verify)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       ManHour_Verify       SET ");
            if(manHour_Verify.Verify_PartCode_IsChanged){sbParameter.Append("Verify_PartCode=@Verify_PartCode, ");}
      if(manHour_Verify.Verify_ManHour_IsChanged){sbParameter.Append("Verify_ManHour=@Verify_ManHour, ");}
      if(manHour_Verify.Verify_Cost_IsChanged){sbParameter.Append("Verify_Cost=@Verify_Cost, ");}
      if(manHour_Verify.Verify_Stat_IsChanged){sbParameter.Append("Verify_Stat=@Verify_Stat, ");}
      if(manHour_Verify.Verify_Time_IsChanged){sbParameter.Append("Verify_Time=@Verify_Time, ");}
      if(manHour_Verify.Verify_Resp_IsChanged){sbParameter.Append("Verify_Resp=@Verify_Resp, ");}
      if(manHour_Verify.Verify_RespName_IsChanged){sbParameter.Append("Verify_RespName=@Verify_RespName, ");}
      if(manHour_Verify.Verify_RoadNodeCode_IsChanged){sbParameter.Append("Verify_RoadNodeCode=@Verify_RoadNodeCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Verify_ID=@Verify_ID; " );
      string sql=sb.ToString();
         if(manHour_Verify.Verify_PartCode_IsChanged)
         {
         if (string.IsNullOrEmpty(manHour_Verify.Verify_PartCode))
         {
            idb.AddParameter("@Verify_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_PartCode", manHour_Verify.Verify_PartCode);
         }
          }
         if(manHour_Verify.Verify_ManHour_IsChanged)
         {
         if (manHour_Verify.Verify_ManHour == 0)
         {
            idb.AddParameter("@Verify_ManHour", 0);
         }
         else
         {
            idb.AddParameter("@Verify_ManHour", manHour_Verify.Verify_ManHour);
         }
          }
         if(manHour_Verify.Verify_Cost_IsChanged)
         {
         if (manHour_Verify.Verify_Cost == 0)
         {
            idb.AddParameter("@Verify_Cost", 0);
         }
         else
         {
            idb.AddParameter("@Verify_Cost", manHour_Verify.Verify_Cost);
         }
          }
         if(manHour_Verify.Verify_Stat_IsChanged)
         {
         if (manHour_Verify.Verify_Stat == 0)
         {
            idb.AddParameter("@Verify_Stat", 0);
         }
         else
         {
            idb.AddParameter("@Verify_Stat", manHour_Verify.Verify_Stat);
         }
          }
         if(manHour_Verify.Verify_Time_IsChanged)
         {
         if (manHour_Verify.Verify_Time == DateTime.MinValue)
         {
            idb.AddParameter("@Verify_Time", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_Time", manHour_Verify.Verify_Time);
         }
          }
         if(manHour_Verify.Verify_Resp_IsChanged)
         {
         if (string.IsNullOrEmpty(manHour_Verify.Verify_Resp))
         {
            idb.AddParameter("@Verify_Resp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_Resp", manHour_Verify.Verify_Resp);
         }
          }
         if(manHour_Verify.Verify_RespName_IsChanged)
         {
         if (string.IsNullOrEmpty(manHour_Verify.Verify_RespName))
         {
            idb.AddParameter("@Verify_RespName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_RespName", manHour_Verify.Verify_RespName);
         }
          }
         if(manHour_Verify.Verify_RoadNodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(manHour_Verify.Verify_RoadNodeCode))
         {
            idb.AddParameter("@Verify_RoadNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Verify_RoadNodeCode", manHour_Verify.Verify_RoadNodeCode);
         }
          }

         idb.AddParameter("@Verify_ID", manHour_Verify.Verify_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除工时审核表 ManHour_Verify对象(即:一条记录
      /// </summary>
      public int Delete(Int64 verify_ID)
      {
         string sql = "DELETE ManHour_Verify WHERE 1=1  AND Verify_ID=@Verify_ID ";
         idb.AddParameter("@Verify_ID", verify_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的工时审核表 ManHour_Verify对象(即:一条记录
      /// </summary>
      public ManHour_Verify GetByKey(Int64 verify_ID)
      {
         ManHour_Verify manHour_Verify = new ManHour_Verify();
         string sql = "SELECT  Verify_ID,Verify_PartCode,Verify_ManHour,Verify_Cost,Verify_Stat,Verify_Time,Verify_Resp,Verify_RespName,Verify_RoadNodeCode FROM ManHour_Verify WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Verify_ID=@Verify_ID ";
         idb.AddParameter("@Verify_ID", verify_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Verify_ID"] != DBNull.Value) manHour_Verify.Verify_ID = Convert.ToInt64(dr["Verify_ID"]);
            if (dr["Verify_PartCode"] != DBNull.Value) manHour_Verify.Verify_PartCode = Convert.ToString(dr["Verify_PartCode"]);
            if (dr["Verify_ManHour"] != DBNull.Value) manHour_Verify.Verify_ManHour = Convert.ToDecimal(dr["Verify_ManHour"]);
            if (dr["Verify_Cost"] != DBNull.Value) manHour_Verify.Verify_Cost = Convert.ToInt32(dr["Verify_Cost"]);
            if (dr["Verify_Stat"] != DBNull.Value) manHour_Verify.Verify_Stat = Convert.ToInt32(dr["Verify_Stat"]);
            if (dr["Verify_Time"] != DBNull.Value) manHour_Verify.Verify_Time = Convert.ToDateTime(dr["Verify_Time"]);
            if (dr["Verify_Resp"] != DBNull.Value) manHour_Verify.Verify_Resp = Convert.ToString(dr["Verify_Resp"]);
            if (dr["Verify_RespName"] != DBNull.Value) manHour_Verify.Verify_RespName = Convert.ToString(dr["Verify_RespName"]);
            if (dr["Verify_RoadNodeCode"] != DBNull.Value) manHour_Verify.Verify_RoadNodeCode = Convert.ToString(dr["Verify_RoadNodeCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return manHour_Verify;
      }
      /// <summary>
      /// 获取指定的工时审核表 ManHour_Verify对象集合
      /// </summary>
      public List<ManHour_Verify> GetListByWhere(string strCondition)
      {
         List<ManHour_Verify> ret = new List<ManHour_Verify>();
         string sql = "SELECT  Verify_ID,Verify_PartCode,Verify_ManHour,Verify_Cost,Verify_Stat,Verify_Time,Verify_Resp,Verify_RespName,Verify_RoadNodeCode FROM ManHour_Verify WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            ManHour_Verify manHour_Verify = new ManHour_Verify();
            if (dr["Verify_ID"] != DBNull.Value) manHour_Verify.Verify_ID = Convert.ToInt64(dr["Verify_ID"]);
            if (dr["Verify_PartCode"] != DBNull.Value) manHour_Verify.Verify_PartCode = Convert.ToString(dr["Verify_PartCode"]);
            if (dr["Verify_ManHour"] != DBNull.Value) manHour_Verify.Verify_ManHour = Convert.ToDecimal(dr["Verify_ManHour"]);
            if (dr["Verify_Cost"] != DBNull.Value) manHour_Verify.Verify_Cost = Convert.ToInt32(dr["Verify_Cost"]);
            if (dr["Verify_Stat"] != DBNull.Value) manHour_Verify.Verify_Stat = Convert.ToInt32(dr["Verify_Stat"]);
            if (dr["Verify_Time"] != DBNull.Value) manHour_Verify.Verify_Time = Convert.ToDateTime(dr["Verify_Time"]);
            if (dr["Verify_Resp"] != DBNull.Value) manHour_Verify.Verify_Resp = Convert.ToString(dr["Verify_Resp"]);
            if (dr["Verify_RespName"] != DBNull.Value) manHour_Verify.Verify_RespName = Convert.ToString(dr["Verify_RespName"]);
            if (dr["Verify_RoadNodeCode"] != DBNull.Value) manHour_Verify.Verify_RoadNodeCode = Convert.ToString(dr["Verify_RoadNodeCode"]);
            ret.Add(manHour_Verify);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的工时审核表 ManHour_Verify对象(即:一条记录
      /// </summary>
      public List<ManHour_Verify> GetAll()
      {
         List<ManHour_Verify> ret = new List<ManHour_Verify>();
         string sql = "SELECT  Verify_ID,Verify_PartCode,Verify_ManHour,Verify_Cost,Verify_Stat,Verify_Time,Verify_Resp,Verify_RespName,Verify_RoadNodeCode FROM ManHour_Verify where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            ManHour_Verify manHour_Verify = new ManHour_Verify();
            if (dr["Verify_ID"] != DBNull.Value) manHour_Verify.Verify_ID = Convert.ToInt64(dr["Verify_ID"]);
            if (dr["Verify_PartCode"] != DBNull.Value) manHour_Verify.Verify_PartCode = Convert.ToString(dr["Verify_PartCode"]);
            if (dr["Verify_ManHour"] != DBNull.Value) manHour_Verify.Verify_ManHour = Convert.ToDecimal(dr["Verify_ManHour"]);
            if (dr["Verify_Cost"] != DBNull.Value) manHour_Verify.Verify_Cost = Convert.ToInt32(dr["Verify_Cost"]);
            if (dr["Verify_Stat"] != DBNull.Value) manHour_Verify.Verify_Stat = Convert.ToInt32(dr["Verify_Stat"]);
            if (dr["Verify_Time"] != DBNull.Value) manHour_Verify.Verify_Time = Convert.ToDateTime(dr["Verify_Time"]);
            if (dr["Verify_Resp"] != DBNull.Value) manHour_Verify.Verify_Resp = Convert.ToString(dr["Verify_Resp"]);
            if (dr["Verify_RespName"] != DBNull.Value) manHour_Verify.Verify_RespName = Convert.ToString(dr["Verify_RespName"]);
            if (dr["Verify_RoadNodeCode"] != DBNull.Value) manHour_Verify.Verify_RoadNodeCode = Convert.ToString(dr["Verify_RoadNodeCode"]);
            ret.Add(manHour_Verify);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
