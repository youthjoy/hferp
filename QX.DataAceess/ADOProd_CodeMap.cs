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
   public partial class ADOProd_CodeMap
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Prod_CodeMap对象(即:一条记录)
      /// </summary>
      public int Add(Prod_CodeMap prod_CodeMap)
      {
         string sql = "INSERT INTO Prod_CodeMap (PMap_Code,PMap_Order,PMap_PCode,PMap_MCode,PMap_Module,PMap_iType,PMap_Stat,Stat,PMap_RawStat,PMap_RawDate,PMap_PlanDate,PMap_RawMainCode,PMap_Udef1,PMap_Udef3,PMap_TaskCode,PMap_TaskDate) VALUES (@PMap_Code,@PMap_Order,@PMap_PCode,@PMap_MCode,@PMap_Module,@PMap_iType,@PMap_Stat,@Stat,@PMap_RawStat,@PMap_RawDate,@PMap_PlanDate,@PMap_RawMainCode,@PMap_Udef1,@PMap_Udef3,@PMap_TaskCode,@PMap_TaskDate)";
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Code))
         {
            idb.AddParameter("@PMap_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Code", prod_CodeMap.PMap_Code);
         }
         if (prod_CodeMap.PMap_Order == 0)
         {
            idb.AddParameter("@PMap_Order", 0);
         }
         else
         {
            idb.AddParameter("@PMap_Order", prod_CodeMap.PMap_Order);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_PCode))
         {
            idb.AddParameter("@PMap_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_PCode", prod_CodeMap.PMap_PCode);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_MCode))
         {
            idb.AddParameter("@PMap_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_MCode", prod_CodeMap.PMap_MCode);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Module))
         {
            idb.AddParameter("@PMap_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Module", prod_CodeMap.PMap_Module);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_iType))
         {
            idb.AddParameter("@PMap_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_iType", prod_CodeMap.PMap_iType);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Stat))
         {
            idb.AddParameter("@PMap_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Stat", prod_CodeMap.PMap_Stat);
         }
         if (prod_CodeMap.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_CodeMap.Stat);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_RawStat))
         {
            idb.AddParameter("@PMap_RawStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawStat", prod_CodeMap.PMap_RawStat);
         }
         if (prod_CodeMap.PMap_RawDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_RawDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawDate", prod_CodeMap.PMap_RawDate);
         }
         if (prod_CodeMap.PMap_PlanDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_PlanDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_PlanDate", prod_CodeMap.PMap_PlanDate);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_RawMainCode))
         {
            idb.AddParameter("@PMap_RawMainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawMainCode", prod_CodeMap.PMap_RawMainCode);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Udef1))
         {
            idb.AddParameter("@PMap_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Udef1", prod_CodeMap.PMap_Udef1);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Udef3))
         {
            idb.AddParameter("@PMap_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Udef3", prod_CodeMap.PMap_Udef3);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_TaskCode))
         {
            idb.AddParameter("@PMap_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_TaskCode", prod_CodeMap.PMap_TaskCode);
         }
         if (prod_CodeMap.PMap_TaskDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_TaskDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_TaskDate", prod_CodeMap.PMap_TaskDate);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Prod_CodeMap对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_CodeMap prod_CodeMap)
      {
         string sql = "INSERT INTO Prod_CodeMap (PMap_Code,PMap_Order,PMap_PCode,PMap_MCode,PMap_Module,PMap_iType,PMap_Stat,Stat,PMap_RawStat,PMap_RawDate,PMap_PlanDate,PMap_RawMainCode,PMap_Udef1,PMap_Udef3,PMap_TaskCode,PMap_TaskDate) VALUES (@PMap_Code,@PMap_Order,@PMap_PCode,@PMap_MCode,@PMap_Module,@PMap_iType,@PMap_Stat,@Stat,@PMap_RawStat,@PMap_RawDate,@PMap_PlanDate,@PMap_RawMainCode,@PMap_Udef1,@PMap_Udef3,@PMap_TaskCode,@PMap_TaskDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Code))
         {
            idb.AddParameter("@PMap_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Code", prod_CodeMap.PMap_Code);
         }
         if (prod_CodeMap.PMap_Order == 0)
         {
            idb.AddParameter("@PMap_Order", 0);
         }
         else
         {
            idb.AddParameter("@PMap_Order", prod_CodeMap.PMap_Order);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_PCode))
         {
            idb.AddParameter("@PMap_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_PCode", prod_CodeMap.PMap_PCode);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_MCode))
         {
            idb.AddParameter("@PMap_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_MCode", prod_CodeMap.PMap_MCode);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Module))
         {
            idb.AddParameter("@PMap_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Module", prod_CodeMap.PMap_Module);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_iType))
         {
            idb.AddParameter("@PMap_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_iType", prod_CodeMap.PMap_iType);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Stat))
         {
            idb.AddParameter("@PMap_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Stat", prod_CodeMap.PMap_Stat);
         }
         if (prod_CodeMap.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_CodeMap.Stat);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_RawStat))
         {
            idb.AddParameter("@PMap_RawStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawStat", prod_CodeMap.PMap_RawStat);
         }
         if (prod_CodeMap.PMap_RawDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_RawDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawDate", prod_CodeMap.PMap_RawDate);
         }
         if (prod_CodeMap.PMap_PlanDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_PlanDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_PlanDate", prod_CodeMap.PMap_PlanDate);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_RawMainCode))
         {
            idb.AddParameter("@PMap_RawMainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawMainCode", prod_CodeMap.PMap_RawMainCode);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Udef1))
         {
            idb.AddParameter("@PMap_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Udef1", prod_CodeMap.PMap_Udef1);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Udef3))
         {
            idb.AddParameter("@PMap_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Udef3", prod_CodeMap.PMap_Udef3);
         }
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_TaskCode))
         {
            idb.AddParameter("@PMap_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_TaskCode", prod_CodeMap.PMap_TaskCode);
         }
         if (prod_CodeMap.PMap_TaskDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_TaskDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_TaskDate", prod_CodeMap.PMap_TaskDate);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Prod_CodeMap对象(即:一条记录
      /// </summary>
      public int Update(Prod_CodeMap prod_CodeMap)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_CodeMap       SET ");
            if(prod_CodeMap.PMap_Code_IsChanged){sbParameter.Append("PMap_Code=@PMap_Code, ");}
      if(prod_CodeMap.PMap_Order_IsChanged){sbParameter.Append("PMap_Order=@PMap_Order, ");}
      if(prod_CodeMap.PMap_PCode_IsChanged){sbParameter.Append("PMap_PCode=@PMap_PCode, ");}
      if(prod_CodeMap.PMap_MCode_IsChanged){sbParameter.Append("PMap_MCode=@PMap_MCode, ");}
      if(prod_CodeMap.PMap_Module_IsChanged){sbParameter.Append("PMap_Module=@PMap_Module, ");}
      if(prod_CodeMap.PMap_iType_IsChanged){sbParameter.Append("PMap_iType=@PMap_iType, ");}
      if(prod_CodeMap.PMap_Stat_IsChanged){sbParameter.Append("PMap_Stat=@PMap_Stat, ");}
      if(prod_CodeMap.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_CodeMap.PMap_RawStat_IsChanged){sbParameter.Append("PMap_RawStat=@PMap_RawStat, ");}
      if(prod_CodeMap.PMap_RawDate_IsChanged){sbParameter.Append("PMap_RawDate=@PMap_RawDate, ");}
      if(prod_CodeMap.PMap_PlanDate_IsChanged){sbParameter.Append("PMap_PlanDate=@PMap_PlanDate, ");}
      if(prod_CodeMap.PMap_RawMainCode_IsChanged){sbParameter.Append("PMap_RawMainCode=@PMap_RawMainCode, ");}
      if(prod_CodeMap.PMap_Udef1_IsChanged){sbParameter.Append("PMap_Udef1=@PMap_Udef1, ");}
      if(prod_CodeMap.PMap_Udef3_IsChanged){sbParameter.Append("PMap_Udef3=@PMap_Udef3, ");}
      if(prod_CodeMap.PMap_TaskCode_IsChanged){sbParameter.Append("PMap_TaskCode=@PMap_TaskCode, ");}
      if(prod_CodeMap.PMap_TaskDate_IsChanged){sbParameter.Append("PMap_TaskDate=@PMap_TaskDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PMap_ID=@PMap_ID; " );
      string sql=sb.ToString();
         if(prod_CodeMap.PMap_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Code))
         {
            idb.AddParameter("@PMap_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Code", prod_CodeMap.PMap_Code);
         }
          }
         if(prod_CodeMap.PMap_Order_IsChanged)
         {
         if (prod_CodeMap.PMap_Order == 0)
         {
            idb.AddParameter("@PMap_Order", 0);
         }
         else
         {
            idb.AddParameter("@PMap_Order", prod_CodeMap.PMap_Order);
         }
          }
         if(prod_CodeMap.PMap_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_PCode))
         {
            idb.AddParameter("@PMap_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_PCode", prod_CodeMap.PMap_PCode);
         }
          }
         if(prod_CodeMap.PMap_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_MCode))
         {
            idb.AddParameter("@PMap_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_MCode", prod_CodeMap.PMap_MCode);
         }
          }
         if(prod_CodeMap.PMap_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Module))
         {
            idb.AddParameter("@PMap_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Module", prod_CodeMap.PMap_Module);
         }
          }
         if(prod_CodeMap.PMap_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_iType))
         {
            idb.AddParameter("@PMap_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_iType", prod_CodeMap.PMap_iType);
         }
          }
         if(prod_CodeMap.PMap_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Stat))
         {
            idb.AddParameter("@PMap_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Stat", prod_CodeMap.PMap_Stat);
         }
          }
         if(prod_CodeMap.Stat_IsChanged)
         {
         if (prod_CodeMap.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_CodeMap.Stat);
         }
          }
         if(prod_CodeMap.PMap_RawStat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_RawStat))
         {
            idb.AddParameter("@PMap_RawStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawStat", prod_CodeMap.PMap_RawStat);
         }
          }
         if(prod_CodeMap.PMap_RawDate_IsChanged)
         {
         if (prod_CodeMap.PMap_RawDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_RawDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawDate", prod_CodeMap.PMap_RawDate);
         }
          }
         if(prod_CodeMap.PMap_PlanDate_IsChanged)
         {
         if (prod_CodeMap.PMap_PlanDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_PlanDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_PlanDate", prod_CodeMap.PMap_PlanDate);
         }
          }
         if(prod_CodeMap.PMap_RawMainCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_RawMainCode))
         {
            idb.AddParameter("@PMap_RawMainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_RawMainCode", prod_CodeMap.PMap_RawMainCode);
         }
          }
         if(prod_CodeMap.PMap_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Udef1))
         {
            idb.AddParameter("@PMap_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Udef1", prod_CodeMap.PMap_Udef1);
         }
          }
         if(prod_CodeMap.PMap_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_Udef3))
         {
            idb.AddParameter("@PMap_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_Udef3", prod_CodeMap.PMap_Udef3);
         }
          }
         if(prod_CodeMap.PMap_TaskCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CodeMap.PMap_TaskCode))
         {
            idb.AddParameter("@PMap_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_TaskCode", prod_CodeMap.PMap_TaskCode);
         }
          }
         if(prod_CodeMap.PMap_TaskDate_IsChanged)
         {
         if (prod_CodeMap.PMap_TaskDate == DateTime.MinValue)
         {
            idb.AddParameter("@PMap_TaskDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PMap_TaskDate", prod_CodeMap.PMap_TaskDate);
         }
          }

         idb.AddParameter("@PMap_ID", prod_CodeMap.PMap_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Prod_CodeMap对象(即:一条记录
      /// </summary>
      public int Delete(decimal pMap_ID)
      {
         string sql = "DELETE Prod_CodeMap WHERE 1=1  AND PMap_ID=@PMap_ID ";
         idb.AddParameter("@PMap_ID", pMap_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Prod_CodeMap对象(即:一条记录
      /// </summary>
      public Prod_CodeMap GetByKey(decimal pMap_ID)
      {
         Prod_CodeMap prod_CodeMap = new Prod_CodeMap();
         string sql = "SELECT  PMap_ID,PMap_Code,PMap_Order,PMap_PCode,PMap_MCode,PMap_Module,PMap_iType,PMap_Stat,Stat,PMap_RawStat,PMap_RawDate,PMap_PlanDate,PMap_RawMainCode,PMap_Udef1,PMap_Udef3,PMap_TaskCode,PMap_TaskDate FROM Prod_CodeMap WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PMap_ID=@PMap_ID ";
         idb.AddParameter("@PMap_ID", pMap_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PMap_ID"] != DBNull.Value) prod_CodeMap.PMap_ID = Convert.ToDecimal(dr["PMap_ID"]);
            if (dr["PMap_Code"] != DBNull.Value) prod_CodeMap.PMap_Code = Convert.ToString(dr["PMap_Code"]);
            if (dr["PMap_Order"] != DBNull.Value) prod_CodeMap.PMap_Order = Convert.ToInt32(dr["PMap_Order"]);
            if (dr["PMap_PCode"] != DBNull.Value) prod_CodeMap.PMap_PCode = Convert.ToString(dr["PMap_PCode"]);
            if (dr["PMap_MCode"] != DBNull.Value) prod_CodeMap.PMap_MCode = Convert.ToString(dr["PMap_MCode"]);
            if (dr["PMap_Module"] != DBNull.Value) prod_CodeMap.PMap_Module = Convert.ToString(dr["PMap_Module"]);
            if (dr["PMap_iType"] != DBNull.Value) prod_CodeMap.PMap_iType = Convert.ToString(dr["PMap_iType"]);
            if (dr["PMap_Stat"] != DBNull.Value) prod_CodeMap.PMap_Stat = Convert.ToString(dr["PMap_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_CodeMap.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PMap_RawStat"] != DBNull.Value) prod_CodeMap.PMap_RawStat = Convert.ToString(dr["PMap_RawStat"]);
            if (dr["PMap_RawDate"] != DBNull.Value) prod_CodeMap.PMap_RawDate = Convert.ToDateTime(dr["PMap_RawDate"]);
            if (dr["PMap_PlanDate"] != DBNull.Value) prod_CodeMap.PMap_PlanDate = Convert.ToDateTime(dr["PMap_PlanDate"]);
            if (dr["PMap_RawMainCode"] != DBNull.Value) prod_CodeMap.PMap_RawMainCode = Convert.ToString(dr["PMap_RawMainCode"]);
            if (dr["PMap_Udef1"] != DBNull.Value) prod_CodeMap.PMap_Udef1 = Convert.ToString(dr["PMap_Udef1"]);
            if (dr["PMap_Udef3"] != DBNull.Value) prod_CodeMap.PMap_Udef3 = Convert.ToString(dr["PMap_Udef3"]);
            if (dr["PMap_TaskCode"] != DBNull.Value) prod_CodeMap.PMap_TaskCode = Convert.ToString(dr["PMap_TaskCode"]);
            if (dr["PMap_TaskDate"] != DBNull.Value) prod_CodeMap.PMap_TaskDate = Convert.ToDateTime(dr["PMap_TaskDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_CodeMap;
      }
      /// <summary>
      /// 获取指定的Prod_CodeMap对象集合
      /// </summary>
      public List<Prod_CodeMap> GetListByWhere(string strCondition)
      {
         List<Prod_CodeMap> ret = new List<Prod_CodeMap>();
         string sql = "SELECT  PMap_ID,PMap_Code,PMap_Order,PMap_PCode,PMap_MCode,PMap_Module,PMap_iType,PMap_Stat,Stat,PMap_RawStat,PMap_RawDate,PMap_PlanDate,PMap_RawMainCode,PMap_Udef1,PMap_Udef3,PMap_TaskCode,PMap_TaskDate FROM Prod_CodeMap WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_CodeMap prod_CodeMap = new Prod_CodeMap();
            if (dr["PMap_ID"] != DBNull.Value) prod_CodeMap.PMap_ID = Convert.ToDecimal(dr["PMap_ID"]);
            if (dr["PMap_Code"] != DBNull.Value) prod_CodeMap.PMap_Code = Convert.ToString(dr["PMap_Code"]);
            if (dr["PMap_Order"] != DBNull.Value) prod_CodeMap.PMap_Order = Convert.ToInt32(dr["PMap_Order"]);
            if (dr["PMap_PCode"] != DBNull.Value) prod_CodeMap.PMap_PCode = Convert.ToString(dr["PMap_PCode"]);
            if (dr["PMap_MCode"] != DBNull.Value) prod_CodeMap.PMap_MCode = Convert.ToString(dr["PMap_MCode"]);
            if (dr["PMap_Module"] != DBNull.Value) prod_CodeMap.PMap_Module = Convert.ToString(dr["PMap_Module"]);
            if (dr["PMap_iType"] != DBNull.Value) prod_CodeMap.PMap_iType = Convert.ToString(dr["PMap_iType"]);
            if (dr["PMap_Stat"] != DBNull.Value) prod_CodeMap.PMap_Stat = Convert.ToString(dr["PMap_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_CodeMap.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PMap_RawStat"] != DBNull.Value) prod_CodeMap.PMap_RawStat = Convert.ToString(dr["PMap_RawStat"]);
            if (dr["PMap_RawDate"] != DBNull.Value) prod_CodeMap.PMap_RawDate = Convert.ToDateTime(dr["PMap_RawDate"]);
            if (dr["PMap_PlanDate"] != DBNull.Value) prod_CodeMap.PMap_PlanDate = Convert.ToDateTime(dr["PMap_PlanDate"]);
            if (dr["PMap_RawMainCode"] != DBNull.Value) prod_CodeMap.PMap_RawMainCode = Convert.ToString(dr["PMap_RawMainCode"]);
            if (dr["PMap_Udef1"] != DBNull.Value) prod_CodeMap.PMap_Udef1 = Convert.ToString(dr["PMap_Udef1"]);
            if (dr["PMap_Udef3"] != DBNull.Value) prod_CodeMap.PMap_Udef3 = Convert.ToString(dr["PMap_Udef3"]);
            if (dr["PMap_TaskCode"] != DBNull.Value) prod_CodeMap.PMap_TaskCode = Convert.ToString(dr["PMap_TaskCode"]);
            if (dr["PMap_TaskDate"] != DBNull.Value) prod_CodeMap.PMap_TaskDate = Convert.ToDateTime(dr["PMap_TaskDate"]);
            ret.Add(prod_CodeMap);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Prod_CodeMap对象(即:一条记录
      /// </summary>
      public List<Prod_CodeMap> GetAll()
      {
         List<Prod_CodeMap> ret = new List<Prod_CodeMap>();
         string sql = "SELECT  PMap_ID,PMap_Code,PMap_Order,PMap_PCode,PMap_MCode,PMap_Module,PMap_iType,PMap_Stat,Stat,PMap_RawStat,PMap_RawDate,PMap_PlanDate,PMap_RawMainCode,PMap_Udef1,PMap_Udef3,PMap_TaskCode,PMap_TaskDate FROM Prod_CodeMap where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_CodeMap prod_CodeMap = new Prod_CodeMap();
            if (dr["PMap_ID"] != DBNull.Value) prod_CodeMap.PMap_ID = Convert.ToDecimal(dr["PMap_ID"]);
            if (dr["PMap_Code"] != DBNull.Value) prod_CodeMap.PMap_Code = Convert.ToString(dr["PMap_Code"]);
            if (dr["PMap_Order"] != DBNull.Value) prod_CodeMap.PMap_Order = Convert.ToInt32(dr["PMap_Order"]);
            if (dr["PMap_PCode"] != DBNull.Value) prod_CodeMap.PMap_PCode = Convert.ToString(dr["PMap_PCode"]);
            if (dr["PMap_MCode"] != DBNull.Value) prod_CodeMap.PMap_MCode = Convert.ToString(dr["PMap_MCode"]);
            if (dr["PMap_Module"] != DBNull.Value) prod_CodeMap.PMap_Module = Convert.ToString(dr["PMap_Module"]);
            if (dr["PMap_iType"] != DBNull.Value) prod_CodeMap.PMap_iType = Convert.ToString(dr["PMap_iType"]);
            if (dr["PMap_Stat"] != DBNull.Value) prod_CodeMap.PMap_Stat = Convert.ToString(dr["PMap_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_CodeMap.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PMap_RawStat"] != DBNull.Value) prod_CodeMap.PMap_RawStat = Convert.ToString(dr["PMap_RawStat"]);
            if (dr["PMap_RawDate"] != DBNull.Value) prod_CodeMap.PMap_RawDate = Convert.ToDateTime(dr["PMap_RawDate"]);
            if (dr["PMap_PlanDate"] != DBNull.Value) prod_CodeMap.PMap_PlanDate = Convert.ToDateTime(dr["PMap_PlanDate"]);
            if (dr["PMap_RawMainCode"] != DBNull.Value) prod_CodeMap.PMap_RawMainCode = Convert.ToString(dr["PMap_RawMainCode"]);
            if (dr["PMap_Udef1"] != DBNull.Value) prod_CodeMap.PMap_Udef1 = Convert.ToString(dr["PMap_Udef1"]);
            if (dr["PMap_Udef3"] != DBNull.Value) prod_CodeMap.PMap_Udef3 = Convert.ToString(dr["PMap_Udef3"]);
            if (dr["PMap_TaskCode"] != DBNull.Value) prod_CodeMap.PMap_TaskCode = Convert.ToString(dr["PMap_TaskCode"]);
            if (dr["PMap_TaskDate"] != DBNull.Value) prod_CodeMap.PMap_TaskDate = Convert.ToDateTime(dr["PMap_TaskDate"]);
            ret.Add(prod_CodeMap);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
