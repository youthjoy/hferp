using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAcess;

namespace QX.DataAceess
{
   [Serializable]
   public partial class ADOSys_Map
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Map对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Map sys_Map)
      {
         string sql = "INSERT INTO Sys_Map (Map_Module,Map_Source,Map_Object1,Map_Object2,Map_Object3,Map_Object4,Map_Object5,Stat) VALUES (@Map_Module,@Map_Source,@Map_Object1,@Map_Object2,@Map_Object3,@Map_Object4,@Map_Object5,@Stat)";
         if (string.IsNullOrEmpty(sys_Map.Map_Module))
         {
            idb.AddParameter("@Map_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Module", sys_Map.Map_Module);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Source))
         {
            idb.AddParameter("@Map_Source", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Source", sys_Map.Map_Source);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object1))
         {
            idb.AddParameter("@Map_Object1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object1", sys_Map.Map_Object1);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object2))
         {
            idb.AddParameter("@Map_Object2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object2", sys_Map.Map_Object2);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object3))
         {
            idb.AddParameter("@Map_Object3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object3", sys_Map.Map_Object3);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object4))
         {
            idb.AddParameter("@Map_Object4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object4", sys_Map.Map_Object4);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object5))
         {
            idb.AddParameter("@Map_Object5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object5", sys_Map.Map_Object5);
         }
         if (sys_Map.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Map.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_Map对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Map sys_Map)
      {
         string sql = "INSERT INTO Sys_Map (Map_Module,Map_Source,Map_Object1,Map_Object2,Map_Object3,Map_Object4,Map_Object5,Stat) VALUES (@Map_Module,@Map_Source,@Map_Object1,@Map_Object2,@Map_Object3,@Map_Object4,@Map_Object5,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Map.Map_Module))
         {
            idb.AddParameter("@Map_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Module", sys_Map.Map_Module);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Source))
         {
            idb.AddParameter("@Map_Source", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Source", sys_Map.Map_Source);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object1))
         {
            idb.AddParameter("@Map_Object1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object1", sys_Map.Map_Object1);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object2))
         {
            idb.AddParameter("@Map_Object2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object2", sys_Map.Map_Object2);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object3))
         {
            idb.AddParameter("@Map_Object3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object3", sys_Map.Map_Object3);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object4))
         {
            idb.AddParameter("@Map_Object4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object4", sys_Map.Map_Object4);
         }
         if (string.IsNullOrEmpty(sys_Map.Map_Object5))
         {
            idb.AddParameter("@Map_Object5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object5", sys_Map.Map_Object5);
         }
         if (sys_Map.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Map.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_Map对象(即:一条记录
      /// </summary>
      public int Update(Sys_Map sys_Map)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Map       SET ");
            if(sys_Map.Map_Module_IsChanged){sbParameter.Append("Map_Module=@Map_Module, ");}
      if(sys_Map.Map_Source_IsChanged){sbParameter.Append("Map_Source=@Map_Source, ");}
      if(sys_Map.Map_Object1_IsChanged){sbParameter.Append("Map_Object1=@Map_Object1, ");}
      if(sys_Map.Map_Object2_IsChanged){sbParameter.Append("Map_Object2=@Map_Object2, ");}
      if(sys_Map.Map_Object3_IsChanged){sbParameter.Append("Map_Object3=@Map_Object3, ");}
      if(sys_Map.Map_Object4_IsChanged){sbParameter.Append("Map_Object4=@Map_Object4, ");}
      if(sys_Map.Map_Object5_IsChanged){sbParameter.Append("Map_Object5=@Map_Object5, ");}
      if(sys_Map.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Map_ID=@Map_ID; " );
      string sql=sb.ToString();
         if(sys_Map.Map_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Module))
         {
            idb.AddParameter("@Map_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Module", sys_Map.Map_Module);
         }
          }
         if(sys_Map.Map_Source_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Source))
         {
            idb.AddParameter("@Map_Source", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Source", sys_Map.Map_Source);
         }
          }
         if(sys_Map.Map_Object1_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Object1))
         {
            idb.AddParameter("@Map_Object1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object1", sys_Map.Map_Object1);
         }
          }
         if(sys_Map.Map_Object2_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Object2))
         {
            idb.AddParameter("@Map_Object2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object2", sys_Map.Map_Object2);
         }
          }
         if(sys_Map.Map_Object3_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Object3))
         {
            idb.AddParameter("@Map_Object3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object3", sys_Map.Map_Object3);
         }
          }
         if(sys_Map.Map_Object4_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Object4))
         {
            idb.AddParameter("@Map_Object4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object4", sys_Map.Map_Object4);
         }
          }
         if(sys_Map.Map_Object5_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Map.Map_Object5))
         {
            idb.AddParameter("@Map_Object5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Map_Object5", sys_Map.Map_Object5);
         }
          }
         if(sys_Map.Stat_IsChanged)
         {
         if (sys_Map.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Map.Stat);
         }
          }

         idb.AddParameter("@Map_ID", sys_Map.Map_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_Map对象(即:一条记录
      /// </summary>
      public int Delete(decimal map_ID)
      {
         string sql = "DELETE Sys_Map WHERE 1=1  AND Map_ID=@Map_ID ";
         idb.AddParameter("@Map_ID", map_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_Map对象(即:一条记录
      /// </summary>
      public Sys_Map GetByKey(decimal map_ID)
      {
         Sys_Map sys_Map = new Sys_Map();
         string sql = "SELECT  Map_ID,Map_Module,Map_Source,Map_Object1,Map_Object2,Map_Object3,Map_Object4,Map_Object5,Stat FROM Sys_Map WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Map_ID=@Map_ID ";
         idb.AddParameter("@Map_ID", map_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Map_ID"] != DBNull.Value) sys_Map.Map_ID = Convert.ToDecimal(dr["Map_ID"]);
            if (dr["Map_Module"] != DBNull.Value) sys_Map.Map_Module = Convert.ToString(dr["Map_Module"]);
            if (dr["Map_Source"] != DBNull.Value) sys_Map.Map_Source = Convert.ToString(dr["Map_Source"]);
            if (dr["Map_Object1"] != DBNull.Value) sys_Map.Map_Object1 = Convert.ToString(dr["Map_Object1"]);
            if (dr["Map_Object2"] != DBNull.Value) sys_Map.Map_Object2 = Convert.ToString(dr["Map_Object2"]);
            if (dr["Map_Object3"] != DBNull.Value) sys_Map.Map_Object3 = Convert.ToString(dr["Map_Object3"]);
            if (dr["Map_Object4"] != DBNull.Value) sys_Map.Map_Object4 = Convert.ToString(dr["Map_Object4"]);
            if (dr["Map_Object5"] != DBNull.Value) sys_Map.Map_Object5 = Convert.ToString(dr["Map_Object5"]);
            if (dr["Stat"] != DBNull.Value) sys_Map.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Map;
      }
      /// <summary>
      /// 获取指定的Sys_Map对象集合
      /// </summary>
      public List<Sys_Map> GetListByWhere(string strCondition)
      {
         List<Sys_Map> ret = new List<Sys_Map>();
         string sql = "SELECT  Map_ID,Map_Module,Map_Source,Map_Object1,Map_Object2,Map_Object3,Map_Object4,Map_Object5,Stat FROM Sys_Map WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Map sys_Map = new Sys_Map();
            if (dr["Map_ID"] != DBNull.Value) sys_Map.Map_ID = Convert.ToDecimal(dr["Map_ID"]);
            if (dr["Map_Module"] != DBNull.Value) sys_Map.Map_Module = Convert.ToString(dr["Map_Module"]);
            if (dr["Map_Source"] != DBNull.Value) sys_Map.Map_Source = Convert.ToString(dr["Map_Source"]);
            if (dr["Map_Object1"] != DBNull.Value) sys_Map.Map_Object1 = Convert.ToString(dr["Map_Object1"]);
            if (dr["Map_Object2"] != DBNull.Value) sys_Map.Map_Object2 = Convert.ToString(dr["Map_Object2"]);
            if (dr["Map_Object3"] != DBNull.Value) sys_Map.Map_Object3 = Convert.ToString(dr["Map_Object3"]);
            if (dr["Map_Object4"] != DBNull.Value) sys_Map.Map_Object4 = Convert.ToString(dr["Map_Object4"]);
            if (dr["Map_Object5"] != DBNull.Value) sys_Map.Map_Object5 = Convert.ToString(dr["Map_Object5"]);
            if (dr["Stat"] != DBNull.Value) sys_Map.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Map);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Map对象(即:一条记录
      /// </summary>
      public List<Sys_Map> GetAll()
      {
         List<Sys_Map> ret = new List<Sys_Map>();
         string sql = "SELECT  Map_ID,Map_Module,Map_Source,Map_Object1,Map_Object2,Map_Object3,Map_Object4,Map_Object5,Stat FROM Sys_Map where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Map sys_Map = new Sys_Map();
            if (dr["Map_ID"] != DBNull.Value) sys_Map.Map_ID = Convert.ToDecimal(dr["Map_ID"]);
            if (dr["Map_Module"] != DBNull.Value) sys_Map.Map_Module = Convert.ToString(dr["Map_Module"]);
            if (dr["Map_Source"] != DBNull.Value) sys_Map.Map_Source = Convert.ToString(dr["Map_Source"]);
            if (dr["Map_Object1"] != DBNull.Value) sys_Map.Map_Object1 = Convert.ToString(dr["Map_Object1"]);
            if (dr["Map_Object2"] != DBNull.Value) sys_Map.Map_Object2 = Convert.ToString(dr["Map_Object2"]);
            if (dr["Map_Object3"] != DBNull.Value) sys_Map.Map_Object3 = Convert.ToString(dr["Map_Object3"]);
            if (dr["Map_Object4"] != DBNull.Value) sys_Map.Map_Object4 = Convert.ToString(dr["Map_Object4"]);
            if (dr["Map_Object5"] != DBNull.Value) sys_Map.Map_Object5 = Convert.ToString(dr["Map_Object5"]);
            if (dr["Stat"] != DBNull.Value) sys_Map.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Map);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
