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
   public partial class ADOProd_Roads
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Prod_Roads对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Roads prod_Roads)
      {
         string sql = "INSERT INTO Prod_Roads (PRoad_PlanCode,PRoad_ProdCode,PRoad_CompCode,PRoad_NodeCode,PRoad_NodeName,PRoad_NodeDepCode,PRoad_NodeDepName,PRoad_TimeCost,PRoad_Order,PRoad_Begin,PRoad_End,PRoad_EquCode,PRoad_EquName,PRoad_EquTimeCost,PRoad_ActBTime,PRoad_ActETime,PRoad_ActCTime,PRoad_ActRTime,PRoad_CostTime,PRoad_FDate,PRoad_ConfirmPep,PRoad_Owner,PRoad_Date,PRoad_Bak,PRoad_Stat,PRoad_IsQuality,PRoad_IsDone,PRoad_IsCurrent,Stat,PRoad_RTicker,PRoad_ClassCode,PRoad_ClassName,PRoad_Udef1,PRoad_Udef2,PRoad_IsFix,PRoad_Receiver) VALUES (@PRoad_PlanCode,@PRoad_ProdCode,@PRoad_CompCode,@PRoad_NodeCode,@PRoad_NodeName,@PRoad_NodeDepCode,@PRoad_NodeDepName,@PRoad_TimeCost,@PRoad_Order,@PRoad_Begin,@PRoad_End,@PRoad_EquCode,@PRoad_EquName,@PRoad_EquTimeCost,@PRoad_ActBTime,@PRoad_ActETime,@PRoad_ActCTime,@PRoad_ActRTime,@PRoad_CostTime,@PRoad_FDate,@PRoad_ConfirmPep,@PRoad_Owner,@PRoad_Date,@PRoad_Bak,@PRoad_Stat,@PRoad_IsQuality,@PRoad_IsDone,@PRoad_IsCurrent,@Stat,@PRoad_RTicker,@PRoad_ClassCode,@PRoad_ClassName,@PRoad_Udef1,@PRoad_Udef2,@PRoad_IsFix,@PRoad_Receiver)";
         if (string.IsNullOrEmpty(prod_Roads.PRoad_PlanCode))
         {
            idb.AddParameter("@PRoad_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_PlanCode", prod_Roads.PRoad_PlanCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ProdCode))
         {
            idb.AddParameter("@PRoad_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ProdCode", prod_Roads.PRoad_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_CompCode))
         {
            idb.AddParameter("@PRoad_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_CompCode", prod_Roads.PRoad_CompCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeCode))
         {
            idb.AddParameter("@PRoad_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeCode", prod_Roads.PRoad_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeName))
         {
            idb.AddParameter("@PRoad_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeName", prod_Roads.PRoad_NodeName);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeDepCode))
         {
            idb.AddParameter("@PRoad_NodeDepCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeDepCode", prod_Roads.PRoad_NodeDepCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeDepName))
         {
            idb.AddParameter("@PRoad_NodeDepName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeDepName", prod_Roads.PRoad_NodeDepName);
         }
         if (prod_Roads.PRoad_TimeCost == 0)
         {
            idb.AddParameter("@PRoad_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_TimeCost", prod_Roads.PRoad_TimeCost);
         }
         if (prod_Roads.PRoad_Order == 0)
         {
            idb.AddParameter("@PRoad_Order", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_Order", prod_Roads.PRoad_Order);
         }
         if (prod_Roads.PRoad_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Begin", prod_Roads.PRoad_Begin);
         }
         if (prod_Roads.PRoad_End == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_End", prod_Roads.PRoad_End);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_EquCode))
         {
            idb.AddParameter("@PRoad_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_EquCode", prod_Roads.PRoad_EquCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_EquName))
         {
            idb.AddParameter("@PRoad_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_EquName", prod_Roads.PRoad_EquName);
         }
         if (prod_Roads.PRoad_EquTimeCost == 0)
         {
            idb.AddParameter("@PRoad_EquTimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_EquTimeCost", prod_Roads.PRoad_EquTimeCost);
         }
         if (prod_Roads.PRoad_ActBTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActBTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActBTime", prod_Roads.PRoad_ActBTime);
         }
         if (prod_Roads.PRoad_ActETime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActETime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActETime", prod_Roads.PRoad_ActETime);
         }
         if (prod_Roads.PRoad_ActCTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActCTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActCTime", prod_Roads.PRoad_ActCTime);
         }
         if (prod_Roads.PRoad_ActRTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActRTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActRTime", prod_Roads.PRoad_ActRTime);
         }
         if (prod_Roads.PRoad_CostTime == 0)
         {
            idb.AddParameter("@PRoad_CostTime", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_CostTime", prod_Roads.PRoad_CostTime);
         }
         if (prod_Roads.PRoad_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_FDate", prod_Roads.PRoad_FDate);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ConfirmPep))
         {
            idb.AddParameter("@PRoad_ConfirmPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ConfirmPep", prod_Roads.PRoad_ConfirmPep);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Owner))
         {
            idb.AddParameter("@PRoad_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Owner", prod_Roads.PRoad_Owner);
         }
         if (prod_Roads.PRoad_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Date", prod_Roads.PRoad_Date);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Bak))
         {
            idb.AddParameter("@PRoad_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Bak", prod_Roads.PRoad_Bak);
         }
         if (prod_Roads.PRoad_Stat == 0)
         {
            idb.AddParameter("@PRoad_Stat", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_Stat", prod_Roads.PRoad_Stat);
         }
         if (prod_Roads.PRoad_IsQuality == false)
         {
            idb.AddParameter("@PRoad_IsQuality", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_IsQuality", prod_Roads.PRoad_IsQuality);
         }
         if (prod_Roads.PRoad_IsDone == false)
         {
            idb.AddParameter("@PRoad_IsDone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_IsDone", prod_Roads.PRoad_IsDone);
         }
         if (prod_Roads.PRoad_IsCurrent == 0)
         {
            idb.AddParameter("@PRoad_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_IsCurrent", prod_Roads.PRoad_IsCurrent);
         }
         if (prod_Roads.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Roads.Stat);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_RTicker))
         {
            idb.AddParameter("@PRoad_RTicker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_RTicker", prod_Roads.PRoad_RTicker);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ClassCode))
         {
            idb.AddParameter("@PRoad_ClassCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ClassCode", prod_Roads.PRoad_ClassCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ClassName))
         {
            idb.AddParameter("@PRoad_ClassName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ClassName", prod_Roads.PRoad_ClassName);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Udef1))
         {
            idb.AddParameter("@PRoad_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Udef1", prod_Roads.PRoad_Udef1);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Udef2))
         {
            idb.AddParameter("@PRoad_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Udef2", prod_Roads.PRoad_Udef2);
         }
         if (prod_Roads.PRoad_IsFix == 0)
         {
            idb.AddParameter("@PRoad_IsFix", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_IsFix", prod_Roads.PRoad_IsFix);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Receiver))
         {
            idb.AddParameter("@PRoad_Receiver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Receiver", prod_Roads.PRoad_Receiver);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Prod_Roads对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Roads prod_Roads)
      {
         string sql = "INSERT INTO Prod_Roads (PRoad_PlanCode,PRoad_ProdCode,PRoad_CompCode,PRoad_NodeCode,PRoad_NodeName,PRoad_NodeDepCode,PRoad_NodeDepName,PRoad_TimeCost,PRoad_Order,PRoad_Begin,PRoad_End,PRoad_EquCode,PRoad_EquName,PRoad_EquTimeCost,PRoad_ActBTime,PRoad_ActETime,PRoad_ActCTime,PRoad_ActRTime,PRoad_CostTime,PRoad_FDate,PRoad_ConfirmPep,PRoad_Owner,PRoad_Date,PRoad_Bak,PRoad_Stat,PRoad_IsQuality,PRoad_IsDone,PRoad_IsCurrent,Stat,PRoad_RTicker,PRoad_ClassCode,PRoad_ClassName,PRoad_Udef1,PRoad_Udef2,PRoad_IsFix,PRoad_Receiver) VALUES (@PRoad_PlanCode,@PRoad_ProdCode,@PRoad_CompCode,@PRoad_NodeCode,@PRoad_NodeName,@PRoad_NodeDepCode,@PRoad_NodeDepName,@PRoad_TimeCost,@PRoad_Order,@PRoad_Begin,@PRoad_End,@PRoad_EquCode,@PRoad_EquName,@PRoad_EquTimeCost,@PRoad_ActBTime,@PRoad_ActETime,@PRoad_ActCTime,@PRoad_ActRTime,@PRoad_CostTime,@PRoad_FDate,@PRoad_ConfirmPep,@PRoad_Owner,@PRoad_Date,@PRoad_Bak,@PRoad_Stat,@PRoad_IsQuality,@PRoad_IsDone,@PRoad_IsCurrent,@Stat,@PRoad_RTicker,@PRoad_ClassCode,@PRoad_ClassName,@PRoad_Udef1,@PRoad_Udef2,@PRoad_IsFix,@PRoad_Receiver);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Roads.PRoad_PlanCode))
         {
            idb.AddParameter("@PRoad_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_PlanCode", prod_Roads.PRoad_PlanCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ProdCode))
         {
            idb.AddParameter("@PRoad_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ProdCode", prod_Roads.PRoad_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_CompCode))
         {
            idb.AddParameter("@PRoad_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_CompCode", prod_Roads.PRoad_CompCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeCode))
         {
            idb.AddParameter("@PRoad_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeCode", prod_Roads.PRoad_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeName))
         {
            idb.AddParameter("@PRoad_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeName", prod_Roads.PRoad_NodeName);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeDepCode))
         {
            idb.AddParameter("@PRoad_NodeDepCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeDepCode", prod_Roads.PRoad_NodeDepCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeDepName))
         {
            idb.AddParameter("@PRoad_NodeDepName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeDepName", prod_Roads.PRoad_NodeDepName);
         }
         if (prod_Roads.PRoad_TimeCost == 0)
         {
            idb.AddParameter("@PRoad_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_TimeCost", prod_Roads.PRoad_TimeCost);
         }
         if (prod_Roads.PRoad_Order == 0)
         {
            idb.AddParameter("@PRoad_Order", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_Order", prod_Roads.PRoad_Order);
         }
         if (prod_Roads.PRoad_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Begin", prod_Roads.PRoad_Begin);
         }
         if (prod_Roads.PRoad_End == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_End", prod_Roads.PRoad_End);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_EquCode))
         {
            idb.AddParameter("@PRoad_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_EquCode", prod_Roads.PRoad_EquCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_EquName))
         {
            idb.AddParameter("@PRoad_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_EquName", prod_Roads.PRoad_EquName);
         }
         if (prod_Roads.PRoad_EquTimeCost == 0)
         {
            idb.AddParameter("@PRoad_EquTimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_EquTimeCost", prod_Roads.PRoad_EquTimeCost);
         }
         if (prod_Roads.PRoad_ActBTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActBTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActBTime", prod_Roads.PRoad_ActBTime);
         }
         if (prod_Roads.PRoad_ActETime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActETime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActETime", prod_Roads.PRoad_ActETime);
         }
         if (prod_Roads.PRoad_ActCTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActCTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActCTime", prod_Roads.PRoad_ActCTime);
         }
         if (prod_Roads.PRoad_ActRTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActRTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActRTime", prod_Roads.PRoad_ActRTime);
         }
         if (prod_Roads.PRoad_CostTime == 0)
         {
            idb.AddParameter("@PRoad_CostTime", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_CostTime", prod_Roads.PRoad_CostTime);
         }
         if (prod_Roads.PRoad_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_FDate", prod_Roads.PRoad_FDate);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ConfirmPep))
         {
            idb.AddParameter("@PRoad_ConfirmPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ConfirmPep", prod_Roads.PRoad_ConfirmPep);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Owner))
         {
            idb.AddParameter("@PRoad_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Owner", prod_Roads.PRoad_Owner);
         }
         if (prod_Roads.PRoad_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Date", prod_Roads.PRoad_Date);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Bak))
         {
            idb.AddParameter("@PRoad_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Bak", prod_Roads.PRoad_Bak);
         }
         if (prod_Roads.PRoad_Stat == 0)
         {
            idb.AddParameter("@PRoad_Stat", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_Stat", prod_Roads.PRoad_Stat);
         }
         if (prod_Roads.PRoad_IsQuality == false)
         {
            idb.AddParameter("@PRoad_IsQuality", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_IsQuality", prod_Roads.PRoad_IsQuality);
         }
         if (prod_Roads.PRoad_IsDone == false)
         {
            idb.AddParameter("@PRoad_IsDone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_IsDone", prod_Roads.PRoad_IsDone);
         }
         if (prod_Roads.PRoad_IsCurrent == 0)
         {
            idb.AddParameter("@PRoad_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_IsCurrent", prod_Roads.PRoad_IsCurrent);
         }
         if (prod_Roads.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Roads.Stat);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_RTicker))
         {
            idb.AddParameter("@PRoad_RTicker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_RTicker", prod_Roads.PRoad_RTicker);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ClassCode))
         {
            idb.AddParameter("@PRoad_ClassCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ClassCode", prod_Roads.PRoad_ClassCode);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ClassName))
         {
            idb.AddParameter("@PRoad_ClassName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ClassName", prod_Roads.PRoad_ClassName);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Udef1))
         {
            idb.AddParameter("@PRoad_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Udef1", prod_Roads.PRoad_Udef1);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Udef2))
         {
            idb.AddParameter("@PRoad_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Udef2", prod_Roads.PRoad_Udef2);
         }
         if (prod_Roads.PRoad_IsFix == 0)
         {
            idb.AddParameter("@PRoad_IsFix", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_IsFix", prod_Roads.PRoad_IsFix);
         }
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Receiver))
         {
            idb.AddParameter("@PRoad_Receiver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Receiver", prod_Roads.PRoad_Receiver);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Prod_Roads对象(即:一条记录
      /// </summary>
      public int Update(Prod_Roads prod_Roads)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Roads       SET ");
            if(prod_Roads.PRoad_PlanCode_IsChanged){sbParameter.Append("PRoad_PlanCode=@PRoad_PlanCode, ");}
      if(prod_Roads.PRoad_ProdCode_IsChanged){sbParameter.Append("PRoad_ProdCode=@PRoad_ProdCode, ");}
      if(prod_Roads.PRoad_CompCode_IsChanged){sbParameter.Append("PRoad_CompCode=@PRoad_CompCode, ");}
      if(prod_Roads.PRoad_NodeCode_IsChanged){sbParameter.Append("PRoad_NodeCode=@PRoad_NodeCode, ");}
      if(prod_Roads.PRoad_NodeName_IsChanged){sbParameter.Append("PRoad_NodeName=@PRoad_NodeName, ");}
      if(prod_Roads.PRoad_NodeDepCode_IsChanged){sbParameter.Append("PRoad_NodeDepCode=@PRoad_NodeDepCode, ");}
      if(prod_Roads.PRoad_NodeDepName_IsChanged){sbParameter.Append("PRoad_NodeDepName=@PRoad_NodeDepName, ");}
      if(prod_Roads.PRoad_TimeCost_IsChanged){sbParameter.Append("PRoad_TimeCost=@PRoad_TimeCost, ");}
      if(prod_Roads.PRoad_Order_IsChanged){sbParameter.Append("PRoad_Order=@PRoad_Order, ");}
      if(prod_Roads.PRoad_Begin_IsChanged){sbParameter.Append("PRoad_Begin=@PRoad_Begin, ");}
      if(prod_Roads.PRoad_End_IsChanged){sbParameter.Append("PRoad_End=@PRoad_End, ");}
      if(prod_Roads.PRoad_EquCode_IsChanged){sbParameter.Append("PRoad_EquCode=@PRoad_EquCode, ");}
      if(prod_Roads.PRoad_EquName_IsChanged){sbParameter.Append("PRoad_EquName=@PRoad_EquName, ");}
      if(prod_Roads.PRoad_EquTimeCost_IsChanged){sbParameter.Append("PRoad_EquTimeCost=@PRoad_EquTimeCost, ");}
      if(prod_Roads.PRoad_ActBTime_IsChanged){sbParameter.Append("PRoad_ActBTime=@PRoad_ActBTime, ");}
      if(prod_Roads.PRoad_ActETime_IsChanged){sbParameter.Append("PRoad_ActETime=@PRoad_ActETime, ");}
      if(prod_Roads.PRoad_ActCTime_IsChanged){sbParameter.Append("PRoad_ActCTime=@PRoad_ActCTime, ");}
      if(prod_Roads.PRoad_ActRTime_IsChanged){sbParameter.Append("PRoad_ActRTime=@PRoad_ActRTime, ");}
      if(prod_Roads.PRoad_CostTime_IsChanged){sbParameter.Append("PRoad_CostTime=@PRoad_CostTime, ");}
      if(prod_Roads.PRoad_FDate_IsChanged){sbParameter.Append("PRoad_FDate=@PRoad_FDate, ");}
      if(prod_Roads.PRoad_ConfirmPep_IsChanged){sbParameter.Append("PRoad_ConfirmPep=@PRoad_ConfirmPep, ");}
      if(prod_Roads.PRoad_Owner_IsChanged){sbParameter.Append("PRoad_Owner=@PRoad_Owner, ");}
      if(prod_Roads.PRoad_Date_IsChanged){sbParameter.Append("PRoad_Date=@PRoad_Date, ");}
      if(prod_Roads.PRoad_Bak_IsChanged){sbParameter.Append("PRoad_Bak=@PRoad_Bak, ");}
      if(prod_Roads.PRoad_Stat_IsChanged){sbParameter.Append("PRoad_Stat=@PRoad_Stat, ");}
      if(prod_Roads.PRoad_IsQuality_IsChanged){sbParameter.Append("PRoad_IsQuality=@PRoad_IsQuality, ");}
      if(prod_Roads.PRoad_IsDone_IsChanged){sbParameter.Append("PRoad_IsDone=@PRoad_IsDone, ");}
      if(prod_Roads.PRoad_IsCurrent_IsChanged){sbParameter.Append("PRoad_IsCurrent=@PRoad_IsCurrent, ");}
      if(prod_Roads.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_Roads.PRoad_RTicker_IsChanged){sbParameter.Append("PRoad_RTicker=@PRoad_RTicker, ");}
      if(prod_Roads.PRoad_ClassCode_IsChanged){sbParameter.Append("PRoad_ClassCode=@PRoad_ClassCode, ");}
      if(prod_Roads.PRoad_ClassName_IsChanged){sbParameter.Append("PRoad_ClassName=@PRoad_ClassName, ");}
      if(prod_Roads.PRoad_Udef1_IsChanged){sbParameter.Append("PRoad_Udef1=@PRoad_Udef1, ");}
      if(prod_Roads.PRoad_Udef2_IsChanged){sbParameter.Append("PRoad_Udef2=@PRoad_Udef2, ");}
      if(prod_Roads.PRoad_IsFix_IsChanged){sbParameter.Append("PRoad_IsFix=@PRoad_IsFix, ");}
      if(prod_Roads.PRoad_Receiver_IsChanged){sbParameter.Append("PRoad_Receiver=@PRoad_Receiver ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PRoad_ID=@PRoad_ID; " );
      string sql=sb.ToString();
         if(prod_Roads.PRoad_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_PlanCode))
         {
            idb.AddParameter("@PRoad_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_PlanCode", prod_Roads.PRoad_PlanCode);
         }
          }
         if(prod_Roads.PRoad_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ProdCode))
         {
            idb.AddParameter("@PRoad_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ProdCode", prod_Roads.PRoad_ProdCode);
         }
          }
         if(prod_Roads.PRoad_CompCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_CompCode))
         {
            idb.AddParameter("@PRoad_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_CompCode", prod_Roads.PRoad_CompCode);
         }
          }
         if(prod_Roads.PRoad_NodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeCode))
         {
            idb.AddParameter("@PRoad_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeCode", prod_Roads.PRoad_NodeCode);
         }
          }
         if(prod_Roads.PRoad_NodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeName))
         {
            idb.AddParameter("@PRoad_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeName", prod_Roads.PRoad_NodeName);
         }
          }
         if(prod_Roads.PRoad_NodeDepCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeDepCode))
         {
            idb.AddParameter("@PRoad_NodeDepCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeDepCode", prod_Roads.PRoad_NodeDepCode);
         }
          }
         if(prod_Roads.PRoad_NodeDepName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_NodeDepName))
         {
            idb.AddParameter("@PRoad_NodeDepName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_NodeDepName", prod_Roads.PRoad_NodeDepName);
         }
          }
         if(prod_Roads.PRoad_TimeCost_IsChanged)
         {
         if (prod_Roads.PRoad_TimeCost == 0)
         {
            idb.AddParameter("@PRoad_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_TimeCost", prod_Roads.PRoad_TimeCost);
         }
          }
         if(prod_Roads.PRoad_Order_IsChanged)
         {
         if (prod_Roads.PRoad_Order == 0)
         {
            idb.AddParameter("@PRoad_Order", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_Order", prod_Roads.PRoad_Order);
         }
          }
         if(prod_Roads.PRoad_Begin_IsChanged)
         {
         if (prod_Roads.PRoad_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Begin", prod_Roads.PRoad_Begin);
         }
          }
         if(prod_Roads.PRoad_End_IsChanged)
         {
         if (prod_Roads.PRoad_End == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_End", prod_Roads.PRoad_End);
         }
          }
         if(prod_Roads.PRoad_EquCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_EquCode))
         {
            idb.AddParameter("@PRoad_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_EquCode", prod_Roads.PRoad_EquCode);
         }
          }
         if(prod_Roads.PRoad_EquName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_EquName))
         {
            idb.AddParameter("@PRoad_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_EquName", prod_Roads.PRoad_EquName);
         }
          }
         if(prod_Roads.PRoad_EquTimeCost_IsChanged)
         {
         if (prod_Roads.PRoad_EquTimeCost == 0)
         {
            idb.AddParameter("@PRoad_EquTimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_EquTimeCost", prod_Roads.PRoad_EquTimeCost);
         }
          }
         if(prod_Roads.PRoad_ActBTime_IsChanged)
         {
         if (prod_Roads.PRoad_ActBTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActBTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActBTime", prod_Roads.PRoad_ActBTime);
         }
          }
         if(prod_Roads.PRoad_ActETime_IsChanged)
         {
         if (prod_Roads.PRoad_ActETime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActETime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActETime", prod_Roads.PRoad_ActETime);
         }
          }
         if(prod_Roads.PRoad_ActCTime_IsChanged)
         {
         if (prod_Roads.PRoad_ActCTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActCTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActCTime", prod_Roads.PRoad_ActCTime);
         }
          }
         if(prod_Roads.PRoad_ActRTime_IsChanged)
         {
         if (prod_Roads.PRoad_ActRTime == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_ActRTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ActRTime", prod_Roads.PRoad_ActRTime);
         }
          }
         if(prod_Roads.PRoad_CostTime_IsChanged)
         {
         if (prod_Roads.PRoad_CostTime == 0)
         {
            idb.AddParameter("@PRoad_CostTime", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_CostTime", prod_Roads.PRoad_CostTime);
         }
          }
         if(prod_Roads.PRoad_FDate_IsChanged)
         {
         if (prod_Roads.PRoad_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_FDate", prod_Roads.PRoad_FDate);
         }
          }
         if(prod_Roads.PRoad_ConfirmPep_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ConfirmPep))
         {
            idb.AddParameter("@PRoad_ConfirmPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ConfirmPep", prod_Roads.PRoad_ConfirmPep);
         }
          }
         if(prod_Roads.PRoad_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Owner))
         {
            idb.AddParameter("@PRoad_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Owner", prod_Roads.PRoad_Owner);
         }
          }
         if(prod_Roads.PRoad_Date_IsChanged)
         {
         if (prod_Roads.PRoad_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PRoad_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Date", prod_Roads.PRoad_Date);
         }
          }
         if(prod_Roads.PRoad_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Bak))
         {
            idb.AddParameter("@PRoad_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Bak", prod_Roads.PRoad_Bak);
         }
          }
         if(prod_Roads.PRoad_Stat_IsChanged)
         {
         if (prod_Roads.PRoad_Stat == 0)
         {
            idb.AddParameter("@PRoad_Stat", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_Stat", prod_Roads.PRoad_Stat);
         }
          }
         if(prod_Roads.PRoad_IsQuality_IsChanged)
         {
         if (prod_Roads.PRoad_IsQuality == false)
         {
            idb.AddParameter("@PRoad_IsQuality", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_IsQuality", prod_Roads.PRoad_IsQuality);
         }
          }
         if(prod_Roads.PRoad_IsDone_IsChanged)
         {
         if (prod_Roads.PRoad_IsDone == false)
         {
            idb.AddParameter("@PRoad_IsDone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_IsDone", prod_Roads.PRoad_IsDone);
         }
          }
         if(prod_Roads.PRoad_IsCurrent_IsChanged)
         {
         if (prod_Roads.PRoad_IsCurrent == 0)
         {
            idb.AddParameter("@PRoad_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_IsCurrent", prod_Roads.PRoad_IsCurrent);
         }
          }
         if(prod_Roads.Stat_IsChanged)
         {
         if (prod_Roads.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Roads.Stat);
         }
          }
         if(prod_Roads.PRoad_RTicker_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_RTicker))
         {
            idb.AddParameter("@PRoad_RTicker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_RTicker", prod_Roads.PRoad_RTicker);
         }
          }
         if(prod_Roads.PRoad_ClassCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ClassCode))
         {
            idb.AddParameter("@PRoad_ClassCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ClassCode", prod_Roads.PRoad_ClassCode);
         }
          }
         if(prod_Roads.PRoad_ClassName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_ClassName))
         {
            idb.AddParameter("@PRoad_ClassName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_ClassName", prod_Roads.PRoad_ClassName);
         }
          }
         if(prod_Roads.PRoad_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Udef1))
         {
            idb.AddParameter("@PRoad_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Udef1", prod_Roads.PRoad_Udef1);
         }
          }
         if(prod_Roads.PRoad_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Udef2))
         {
            idb.AddParameter("@PRoad_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Udef2", prod_Roads.PRoad_Udef2);
         }
          }
         if(prod_Roads.PRoad_IsFix_IsChanged)
         {
         if (prod_Roads.PRoad_IsFix == 0)
         {
            idb.AddParameter("@PRoad_IsFix", 0);
         }
         else
         {
            idb.AddParameter("@PRoad_IsFix", prod_Roads.PRoad_IsFix);
         }
          }
         if(prod_Roads.PRoad_Receiver_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Roads.PRoad_Receiver))
         {
            idb.AddParameter("@PRoad_Receiver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRoad_Receiver", prod_Roads.PRoad_Receiver);
         }
          }

         idb.AddParameter("@PRoad_ID", prod_Roads.PRoad_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Prod_Roads对象(即:一条记录
      /// </summary>
      public int Delete(Int64 pRoad_ID)
      {
         string sql = "DELETE Prod_Roads WHERE 1=1  AND PRoad_ID=@PRoad_ID ";
         idb.AddParameter("@PRoad_ID", pRoad_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Prod_Roads对象(即:一条记录
      /// </summary>
      public Prod_Roads GetByKey(Int64 pRoad_ID)
      {
         Prod_Roads prod_Roads = new Prod_Roads();
         string sql = "SELECT  PRoad_ID,PRoad_PlanCode,PRoad_ProdCode,PRoad_CompCode,PRoad_NodeCode,PRoad_NodeName,PRoad_NodeDepCode,PRoad_NodeDepName,PRoad_TimeCost,PRoad_Order,PRoad_Begin,PRoad_End,PRoad_EquCode,PRoad_EquName,PRoad_EquTimeCost,PRoad_ActBTime,PRoad_ActETime,PRoad_ActCTime,PRoad_ActRTime,PRoad_CostTime,PRoad_FDate,PRoad_ConfirmPep,PRoad_Owner,PRoad_Date,PRoad_Bak,PRoad_Stat,PRoad_IsQuality,PRoad_IsDone,PRoad_IsCurrent,Stat,PRoad_RTicker,PRoad_ClassCode,PRoad_ClassName,PRoad_Udef1,PRoad_Udef2,PRoad_IsFix,PRoad_Receiver FROM Prod_Roads WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PRoad_ID=@PRoad_ID ";
         idb.AddParameter("@PRoad_ID", pRoad_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PRoad_ID"] != DBNull.Value) prod_Roads.PRoad_ID = Convert.ToInt64(dr["PRoad_ID"]);
            if (dr["PRoad_PlanCode"] != DBNull.Value) prod_Roads.PRoad_PlanCode = Convert.ToString(dr["PRoad_PlanCode"]);
            if (dr["PRoad_ProdCode"] != DBNull.Value) prod_Roads.PRoad_ProdCode = Convert.ToString(dr["PRoad_ProdCode"]);
            if (dr["PRoad_CompCode"] != DBNull.Value) prod_Roads.PRoad_CompCode = Convert.ToString(dr["PRoad_CompCode"]);
            if (dr["PRoad_NodeCode"] != DBNull.Value) prod_Roads.PRoad_NodeCode = Convert.ToString(dr["PRoad_NodeCode"]);
            if (dr["PRoad_NodeName"] != DBNull.Value) prod_Roads.PRoad_NodeName = Convert.ToString(dr["PRoad_NodeName"]);
            if (dr["PRoad_NodeDepCode"] != DBNull.Value) prod_Roads.PRoad_NodeDepCode = Convert.ToString(dr["PRoad_NodeDepCode"]);
            if (dr["PRoad_NodeDepName"] != DBNull.Value) prod_Roads.PRoad_NodeDepName = Convert.ToString(dr["PRoad_NodeDepName"]);
            if (dr["PRoad_TimeCost"] != DBNull.Value) prod_Roads.PRoad_TimeCost = Convert.ToDecimal(dr["PRoad_TimeCost"]);
            if (dr["PRoad_Order"] != DBNull.Value) prod_Roads.PRoad_Order = Convert.ToInt32(dr["PRoad_Order"]);
            if (dr["PRoad_Begin"] != DBNull.Value) prod_Roads.PRoad_Begin = Convert.ToDateTime(dr["PRoad_Begin"]);
            if (dr["PRoad_End"] != DBNull.Value) prod_Roads.PRoad_End = Convert.ToDateTime(dr["PRoad_End"]);
            if (dr["PRoad_EquCode"] != DBNull.Value) prod_Roads.PRoad_EquCode = Convert.ToString(dr["PRoad_EquCode"]);
            if (dr["PRoad_EquName"] != DBNull.Value) prod_Roads.PRoad_EquName = Convert.ToString(dr["PRoad_EquName"]);
            if (dr["PRoad_EquTimeCost"] != DBNull.Value) prod_Roads.PRoad_EquTimeCost = Convert.ToInt32(dr["PRoad_EquTimeCost"]);
            if (dr["PRoad_ActBTime"] != DBNull.Value) prod_Roads.PRoad_ActBTime = Convert.ToDateTime(dr["PRoad_ActBTime"]);
            if (dr["PRoad_ActETime"] != DBNull.Value) prod_Roads.PRoad_ActETime = Convert.ToDateTime(dr["PRoad_ActETime"]);
            if (dr["PRoad_ActCTime"] != DBNull.Value) prod_Roads.PRoad_ActCTime = Convert.ToDateTime(dr["PRoad_ActCTime"]);
            if (dr["PRoad_ActRTime"] != DBNull.Value) prod_Roads.PRoad_ActRTime = Convert.ToDateTime(dr["PRoad_ActRTime"]);
            if (dr["PRoad_CostTime"] != DBNull.Value) prod_Roads.PRoad_CostTime = Convert.ToDecimal(dr["PRoad_CostTime"]);
            if (dr["PRoad_FDate"] != DBNull.Value) prod_Roads.PRoad_FDate = Convert.ToDateTime(dr["PRoad_FDate"]);
            if (dr["PRoad_ConfirmPep"] != DBNull.Value) prod_Roads.PRoad_ConfirmPep = Convert.ToString(dr["PRoad_ConfirmPep"]);
            if (dr["PRoad_Owner"] != DBNull.Value) prod_Roads.PRoad_Owner = Convert.ToString(dr["PRoad_Owner"]);
            if (dr["PRoad_Date"] != DBNull.Value) prod_Roads.PRoad_Date = Convert.ToDateTime(dr["PRoad_Date"]);
            if (dr["PRoad_Bak"] != DBNull.Value) prod_Roads.PRoad_Bak = Convert.ToString(dr["PRoad_Bak"]);
            if (dr["PRoad_Stat"] != DBNull.Value) prod_Roads.PRoad_Stat = Convert.ToInt32(dr["PRoad_Stat"]);
            if (dr["PRoad_IsQuality"] != DBNull.Value) prod_Roads.PRoad_IsQuality = Convert.ToBoolean(dr["PRoad_IsQuality"]);
            if (dr["PRoad_IsDone"] != DBNull.Value) prod_Roads.PRoad_IsDone = Convert.ToBoolean(dr["PRoad_IsDone"]);
            if (dr["PRoad_IsCurrent"] != DBNull.Value) prod_Roads.PRoad_IsCurrent = Convert.ToInt32(dr["PRoad_IsCurrent"]);
            if (dr["Stat"] != DBNull.Value) prod_Roads.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PRoad_RTicker"] != DBNull.Value) prod_Roads.PRoad_RTicker = Convert.ToString(dr["PRoad_RTicker"]);
            if (dr["PRoad_ClassCode"] != DBNull.Value) prod_Roads.PRoad_ClassCode = Convert.ToString(dr["PRoad_ClassCode"]);
            if (dr["PRoad_ClassName"] != DBNull.Value) prod_Roads.PRoad_ClassName = Convert.ToString(dr["PRoad_ClassName"]);
            if (dr["PRoad_Udef1"] != DBNull.Value) prod_Roads.PRoad_Udef1 = Convert.ToString(dr["PRoad_Udef1"]);
            if (dr["PRoad_Udef2"] != DBNull.Value) prod_Roads.PRoad_Udef2 = Convert.ToString(dr["PRoad_Udef2"]);
            if (dr["PRoad_IsFix"] != DBNull.Value) prod_Roads.PRoad_IsFix = Convert.ToInt32(dr["PRoad_IsFix"]);
            if (dr["PRoad_Receiver"] != DBNull.Value) prod_Roads.PRoad_Receiver = Convert.ToString(dr["PRoad_Receiver"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_Roads;
      }
      /// <summary>
      /// 获取指定的Prod_Roads对象集合
      /// </summary>
      public List<Prod_Roads> GetListByWhere(string strCondition)
      {
         List<Prod_Roads> ret = new List<Prod_Roads>();
         string sql = "SELECT  PRoad_ID,PRoad_PlanCode,PRoad_ProdCode,PRoad_CompCode,PRoad_NodeCode,PRoad_NodeName,PRoad_NodeDepCode,PRoad_NodeDepName,PRoad_TimeCost,PRoad_Order,PRoad_Begin,PRoad_End,PRoad_EquCode,PRoad_EquName,PRoad_EquTimeCost,PRoad_ActBTime,PRoad_ActETime,PRoad_ActCTime,PRoad_ActRTime,PRoad_CostTime,PRoad_FDate,PRoad_ConfirmPep,PRoad_Owner,PRoad_Date,PRoad_Bak,PRoad_Stat,PRoad_IsQuality,PRoad_IsDone,PRoad_IsCurrent,Stat,PRoad_RTicker,PRoad_ClassCode,PRoad_ClassName,PRoad_Udef1,PRoad_Udef2,PRoad_IsFix,PRoad_Receiver FROM Prod_Roads WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_Roads prod_Roads = new Prod_Roads();
            if (dr["PRoad_ID"] != DBNull.Value) prod_Roads.PRoad_ID = Convert.ToInt64(dr["PRoad_ID"]);
            if (dr["PRoad_PlanCode"] != DBNull.Value) prod_Roads.PRoad_PlanCode = Convert.ToString(dr["PRoad_PlanCode"]);
            if (dr["PRoad_ProdCode"] != DBNull.Value) prod_Roads.PRoad_ProdCode = Convert.ToString(dr["PRoad_ProdCode"]);
            if (dr["PRoad_CompCode"] != DBNull.Value) prod_Roads.PRoad_CompCode = Convert.ToString(dr["PRoad_CompCode"]);
            if (dr["PRoad_NodeCode"] != DBNull.Value) prod_Roads.PRoad_NodeCode = Convert.ToString(dr["PRoad_NodeCode"]);
            if (dr["PRoad_NodeName"] != DBNull.Value) prod_Roads.PRoad_NodeName = Convert.ToString(dr["PRoad_NodeName"]);
            if (dr["PRoad_NodeDepCode"] != DBNull.Value) prod_Roads.PRoad_NodeDepCode = Convert.ToString(dr["PRoad_NodeDepCode"]);
            if (dr["PRoad_NodeDepName"] != DBNull.Value) prod_Roads.PRoad_NodeDepName = Convert.ToString(dr["PRoad_NodeDepName"]);
            if (dr["PRoad_TimeCost"] != DBNull.Value) prod_Roads.PRoad_TimeCost = Convert.ToDecimal(dr["PRoad_TimeCost"]);
            if (dr["PRoad_Order"] != DBNull.Value) prod_Roads.PRoad_Order = Convert.ToInt32(dr["PRoad_Order"]);
            if (dr["PRoad_Begin"] != DBNull.Value) prod_Roads.PRoad_Begin = Convert.ToDateTime(dr["PRoad_Begin"]);
            if (dr["PRoad_End"] != DBNull.Value) prod_Roads.PRoad_End = Convert.ToDateTime(dr["PRoad_End"]);
            if (dr["PRoad_EquCode"] != DBNull.Value) prod_Roads.PRoad_EquCode = Convert.ToString(dr["PRoad_EquCode"]);
            if (dr["PRoad_EquName"] != DBNull.Value) prod_Roads.PRoad_EquName = Convert.ToString(dr["PRoad_EquName"]);
            if (dr["PRoad_EquTimeCost"] != DBNull.Value) prod_Roads.PRoad_EquTimeCost = Convert.ToInt32(dr["PRoad_EquTimeCost"]);
            if (dr["PRoad_ActBTime"] != DBNull.Value) prod_Roads.PRoad_ActBTime = Convert.ToDateTime(dr["PRoad_ActBTime"]);
            if (dr["PRoad_ActETime"] != DBNull.Value) prod_Roads.PRoad_ActETime = Convert.ToDateTime(dr["PRoad_ActETime"]);
            if (dr["PRoad_ActCTime"] != DBNull.Value) prod_Roads.PRoad_ActCTime = Convert.ToDateTime(dr["PRoad_ActCTime"]);
            if (dr["PRoad_ActRTime"] != DBNull.Value) prod_Roads.PRoad_ActRTime = Convert.ToDateTime(dr["PRoad_ActRTime"]);
            if (dr["PRoad_CostTime"] != DBNull.Value) prod_Roads.PRoad_CostTime = Convert.ToDecimal(dr["PRoad_CostTime"]);
            if (dr["PRoad_FDate"] != DBNull.Value) prod_Roads.PRoad_FDate = Convert.ToDateTime(dr["PRoad_FDate"]);
            if (dr["PRoad_ConfirmPep"] != DBNull.Value) prod_Roads.PRoad_ConfirmPep = Convert.ToString(dr["PRoad_ConfirmPep"]);
            if (dr["PRoad_Owner"] != DBNull.Value) prod_Roads.PRoad_Owner = Convert.ToString(dr["PRoad_Owner"]);
            if (dr["PRoad_Date"] != DBNull.Value) prod_Roads.PRoad_Date = Convert.ToDateTime(dr["PRoad_Date"]);
            if (dr["PRoad_Bak"] != DBNull.Value) prod_Roads.PRoad_Bak = Convert.ToString(dr["PRoad_Bak"]);
            if (dr["PRoad_Stat"] != DBNull.Value) prod_Roads.PRoad_Stat = Convert.ToInt32(dr["PRoad_Stat"]);
            if (dr["PRoad_IsQuality"] != DBNull.Value) prod_Roads.PRoad_IsQuality = Convert.ToBoolean(dr["PRoad_IsQuality"]);
            if (dr["PRoad_IsDone"] != DBNull.Value) prod_Roads.PRoad_IsDone = Convert.ToBoolean(dr["PRoad_IsDone"]);
            if (dr["PRoad_IsCurrent"] != DBNull.Value) prod_Roads.PRoad_IsCurrent = Convert.ToInt32(dr["PRoad_IsCurrent"]);
            if (dr["Stat"] != DBNull.Value) prod_Roads.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PRoad_RTicker"] != DBNull.Value) prod_Roads.PRoad_RTicker = Convert.ToString(dr["PRoad_RTicker"]);
            if (dr["PRoad_ClassCode"] != DBNull.Value) prod_Roads.PRoad_ClassCode = Convert.ToString(dr["PRoad_ClassCode"]);
            if (dr["PRoad_ClassName"] != DBNull.Value) prod_Roads.PRoad_ClassName = Convert.ToString(dr["PRoad_ClassName"]);
            if (dr["PRoad_Udef1"] != DBNull.Value) prod_Roads.PRoad_Udef1 = Convert.ToString(dr["PRoad_Udef1"]);
            if (dr["PRoad_Udef2"] != DBNull.Value) prod_Roads.PRoad_Udef2 = Convert.ToString(dr["PRoad_Udef2"]);
            if (dr["PRoad_IsFix"] != DBNull.Value) prod_Roads.PRoad_IsFix = Convert.ToInt32(dr["PRoad_IsFix"]);
            if (dr["PRoad_Receiver"] != DBNull.Value) prod_Roads.PRoad_Receiver = Convert.ToString(dr["PRoad_Receiver"]);
            ret.Add(prod_Roads);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Prod_Roads对象(即:一条记录
      /// </summary>
      public List<Prod_Roads> GetAll()
      {
         List<Prod_Roads> ret = new List<Prod_Roads>();
         string sql = "SELECT  PRoad_ID,PRoad_PlanCode,PRoad_ProdCode,PRoad_CompCode,PRoad_NodeCode,PRoad_NodeName,PRoad_NodeDepCode,PRoad_NodeDepName,PRoad_TimeCost,PRoad_Order,PRoad_Begin,PRoad_End,PRoad_EquCode,PRoad_EquName,PRoad_EquTimeCost,PRoad_ActBTime,PRoad_ActETime,PRoad_ActCTime,PRoad_ActRTime,PRoad_CostTime,PRoad_FDate,PRoad_ConfirmPep,PRoad_Owner,PRoad_Date,PRoad_Bak,PRoad_Stat,PRoad_IsQuality,PRoad_IsDone,PRoad_IsCurrent,Stat,PRoad_RTicker,PRoad_ClassCode,PRoad_ClassName,PRoad_Udef1,PRoad_Udef2,PRoad_IsFix,PRoad_Receiver FROM Prod_Roads where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Roads prod_Roads = new Prod_Roads();
            if (dr["PRoad_ID"] != DBNull.Value) prod_Roads.PRoad_ID = Convert.ToInt64(dr["PRoad_ID"]);
            if (dr["PRoad_PlanCode"] != DBNull.Value) prod_Roads.PRoad_PlanCode = Convert.ToString(dr["PRoad_PlanCode"]);
            if (dr["PRoad_ProdCode"] != DBNull.Value) prod_Roads.PRoad_ProdCode = Convert.ToString(dr["PRoad_ProdCode"]);
            if (dr["PRoad_CompCode"] != DBNull.Value) prod_Roads.PRoad_CompCode = Convert.ToString(dr["PRoad_CompCode"]);
            if (dr["PRoad_NodeCode"] != DBNull.Value) prod_Roads.PRoad_NodeCode = Convert.ToString(dr["PRoad_NodeCode"]);
            if (dr["PRoad_NodeName"] != DBNull.Value) prod_Roads.PRoad_NodeName = Convert.ToString(dr["PRoad_NodeName"]);
            if (dr["PRoad_NodeDepCode"] != DBNull.Value) prod_Roads.PRoad_NodeDepCode = Convert.ToString(dr["PRoad_NodeDepCode"]);
            if (dr["PRoad_NodeDepName"] != DBNull.Value) prod_Roads.PRoad_NodeDepName = Convert.ToString(dr["PRoad_NodeDepName"]);
            if (dr["PRoad_TimeCost"] != DBNull.Value) prod_Roads.PRoad_TimeCost = Convert.ToDecimal(dr["PRoad_TimeCost"]);
            if (dr["PRoad_Order"] != DBNull.Value) prod_Roads.PRoad_Order = Convert.ToInt32(dr["PRoad_Order"]);
            if (dr["PRoad_Begin"] != DBNull.Value) prod_Roads.PRoad_Begin = Convert.ToDateTime(dr["PRoad_Begin"]);
            if (dr["PRoad_End"] != DBNull.Value) prod_Roads.PRoad_End = Convert.ToDateTime(dr["PRoad_End"]);
            if (dr["PRoad_EquCode"] != DBNull.Value) prod_Roads.PRoad_EquCode = Convert.ToString(dr["PRoad_EquCode"]);
            if (dr["PRoad_EquName"] != DBNull.Value) prod_Roads.PRoad_EquName = Convert.ToString(dr["PRoad_EquName"]);
            if (dr["PRoad_EquTimeCost"] != DBNull.Value) prod_Roads.PRoad_EquTimeCost = Convert.ToInt32(dr["PRoad_EquTimeCost"]);
            if (dr["PRoad_ActBTime"] != DBNull.Value) prod_Roads.PRoad_ActBTime = Convert.ToDateTime(dr["PRoad_ActBTime"]);
            if (dr["PRoad_ActETime"] != DBNull.Value) prod_Roads.PRoad_ActETime = Convert.ToDateTime(dr["PRoad_ActETime"]);
            if (dr["PRoad_ActCTime"] != DBNull.Value) prod_Roads.PRoad_ActCTime = Convert.ToDateTime(dr["PRoad_ActCTime"]);
            if (dr["PRoad_ActRTime"] != DBNull.Value) prod_Roads.PRoad_ActRTime = Convert.ToDateTime(dr["PRoad_ActRTime"]);
            if (dr["PRoad_CostTime"] != DBNull.Value) prod_Roads.PRoad_CostTime = Convert.ToDecimal(dr["PRoad_CostTime"]);
            if (dr["PRoad_FDate"] != DBNull.Value) prod_Roads.PRoad_FDate = Convert.ToDateTime(dr["PRoad_FDate"]);
            if (dr["PRoad_ConfirmPep"] != DBNull.Value) prod_Roads.PRoad_ConfirmPep = Convert.ToString(dr["PRoad_ConfirmPep"]);
            if (dr["PRoad_Owner"] != DBNull.Value) prod_Roads.PRoad_Owner = Convert.ToString(dr["PRoad_Owner"]);
            if (dr["PRoad_Date"] != DBNull.Value) prod_Roads.PRoad_Date = Convert.ToDateTime(dr["PRoad_Date"]);
            if (dr["PRoad_Bak"] != DBNull.Value) prod_Roads.PRoad_Bak = Convert.ToString(dr["PRoad_Bak"]);
            if (dr["PRoad_Stat"] != DBNull.Value) prod_Roads.PRoad_Stat = Convert.ToInt32(dr["PRoad_Stat"]);
            if (dr["PRoad_IsQuality"] != DBNull.Value) prod_Roads.PRoad_IsQuality = Convert.ToBoolean(dr["PRoad_IsQuality"]);
            if (dr["PRoad_IsDone"] != DBNull.Value) prod_Roads.PRoad_IsDone = Convert.ToBoolean(dr["PRoad_IsDone"]);
            if (dr["PRoad_IsCurrent"] != DBNull.Value) prod_Roads.PRoad_IsCurrent = Convert.ToInt32(dr["PRoad_IsCurrent"]);
            if (dr["Stat"] != DBNull.Value) prod_Roads.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PRoad_RTicker"] != DBNull.Value) prod_Roads.PRoad_RTicker = Convert.ToString(dr["PRoad_RTicker"]);
            if (dr["PRoad_ClassCode"] != DBNull.Value) prod_Roads.PRoad_ClassCode = Convert.ToString(dr["PRoad_ClassCode"]);
            if (dr["PRoad_ClassName"] != DBNull.Value) prod_Roads.PRoad_ClassName = Convert.ToString(dr["PRoad_ClassName"]);
            if (dr["PRoad_Udef1"] != DBNull.Value) prod_Roads.PRoad_Udef1 = Convert.ToString(dr["PRoad_Udef1"]);
            if (dr["PRoad_Udef2"] != DBNull.Value) prod_Roads.PRoad_Udef2 = Convert.ToString(dr["PRoad_Udef2"]);
            if (dr["PRoad_IsFix"] != DBNull.Value) prod_Roads.PRoad_IsFix = Convert.ToInt32(dr["PRoad_IsFix"]);
            if (dr["PRoad_Receiver"] != DBNull.Value) prod_Roads.PRoad_Receiver = Convert.ToString(dr["PRoad_Receiver"]);
            ret.Add(prod_Roads);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
