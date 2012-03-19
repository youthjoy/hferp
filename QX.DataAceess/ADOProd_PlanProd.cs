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
   /// 生产计划(产品计划)
   /// </summary>
   [Serializable]
   public partial class ADOProd_PlanProd
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产计划(产品计划) Prod_PlanProd对象(即:一条记录)
      /// </summary>
      public int Add(Prod_PlanProd prod_PlanProd)
      {
         string sql = "INSERT INTO Prod_PlanProd (PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FStat,PlanProd_FBDate,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_Bak,Stat,PlanProd_Patch,PlanProd_ActBTime,PlanProd_ActETime,PlanProd_MPatchCode,PlanProd_MainPatch) VALUES (@PlanProd_PlanCode,@PlanProd_Code,@PlanProd_TaskDetailCode,@PlanProd_TaskCode,@PlanProd_CmdDetailCode,@PlanProd_CmdCode,@PlanProd_Period,@PlanProd_PartNo,@PlanProd_PartName,@PlanProd_Num,@PlanProd_FNum,@PlanProd_Begin,@PlanProd_End,@PlanProd_LineCode,@PlanProd_FStat,@PlanProd_FBDate,@PlanProd_FDate,@PlanProd_ConfirmPep,@PlanProd_Owner,@PlanProd_Date,@PlanProd_Bak,@Stat,@PlanProd_Patch,@PlanProd_ActBTime,@PlanProd_ActETime,@PlanProd_MPatchCode,@PlanProd_MainPatch)";
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PlanCode))
         {
            idb.AddParameter("@PlanProd_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PlanCode", prod_PlanProd.PlanProd_PlanCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Code))
         {
            idb.AddParameter("@PlanProd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Code", prod_PlanProd.PlanProd_Code);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_TaskDetailCode))
         {
            idb.AddParameter("@PlanProd_TaskDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_TaskDetailCode", prod_PlanProd.PlanProd_TaskDetailCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_TaskCode))
         {
            idb.AddParameter("@PlanProd_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_TaskCode", prod_PlanProd.PlanProd_TaskCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_CmdDetailCode))
         {
            idb.AddParameter("@PlanProd_CmdDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_CmdDetailCode", prod_PlanProd.PlanProd_CmdDetailCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_CmdCode))
         {
            idb.AddParameter("@PlanProd_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_CmdCode", prod_PlanProd.PlanProd_CmdCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Period))
         {
            idb.AddParameter("@PlanProd_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Period", prod_PlanProd.PlanProd_Period);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PartNo))
         {
            idb.AddParameter("@PlanProd_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PartNo", prod_PlanProd.PlanProd_PartNo);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PartName))
         {
            idb.AddParameter("@PlanProd_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PartName", prod_PlanProd.PlanProd_PartName);
         }
         if (prod_PlanProd.PlanProd_Num == 0)
         {
            idb.AddParameter("@PlanProd_Num", 0);
         }
         else
         {
            idb.AddParameter("@PlanProd_Num", prod_PlanProd.PlanProd_Num);
         }
         if (prod_PlanProd.PlanProd_FNum == 0)
         {
            idb.AddParameter("@PlanProd_FNum", 0);
         }
         else
         {
            idb.AddParameter("@PlanProd_FNum", prod_PlanProd.PlanProd_FNum);
         }
         if (prod_PlanProd.PlanProd_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Begin", prod_PlanProd.PlanProd_Begin);
         }
         if (prod_PlanProd.PlanProd_End == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_End", prod_PlanProd.PlanProd_End);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_LineCode))
         {
            idb.AddParameter("@PlanProd_LineCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_LineCode", prod_PlanProd.PlanProd_LineCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_FStat))
         {
            idb.AddParameter("@PlanProd_FStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FStat", prod_PlanProd.PlanProd_FStat);
         }
         if (prod_PlanProd.PlanProd_FBDate == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_FBDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FBDate", prod_PlanProd.PlanProd_FBDate);
         }
         if (prod_PlanProd.PlanProd_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FDate", prod_PlanProd.PlanProd_FDate);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_ConfirmPep))
         {
            idb.AddParameter("@PlanProd_ConfirmPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ConfirmPep", prod_PlanProd.PlanProd_ConfirmPep);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Owner))
         {
            idb.AddParameter("@PlanProd_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Owner", prod_PlanProd.PlanProd_Owner);
         }
         if (prod_PlanProd.PlanProd_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Date", prod_PlanProd.PlanProd_Date);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Bak))
         {
            idb.AddParameter("@PlanProd_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Bak", prod_PlanProd.PlanProd_Bak);
         }
         if (prod_PlanProd.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_PlanProd.Stat);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Patch))
         {
            idb.AddParameter("@PlanProd_Patch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Patch", prod_PlanProd.PlanProd_Patch);
         }
         if (prod_PlanProd.PlanProd_ActBTime == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_ActBTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ActBTime", prod_PlanProd.PlanProd_ActBTime);
         }
         if (prod_PlanProd.PlanProd_ActETime == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_ActETime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ActETime", prod_PlanProd.PlanProd_ActETime);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_MPatchCode))
         {
            idb.AddParameter("@PlanProd_MPatchCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_MPatchCode", prod_PlanProd.PlanProd_MPatchCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_MainPatch))
         {
            idb.AddParameter("@PlanProd_MainPatch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_MainPatch", prod_PlanProd.PlanProd_MainPatch);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加生产计划(产品计划) Prod_PlanProd对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_PlanProd prod_PlanProd)
      {
         string sql = "INSERT INTO Prod_PlanProd (PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FStat,PlanProd_FBDate,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_Bak,Stat,PlanProd_Patch,PlanProd_ActBTime,PlanProd_ActETime,PlanProd_MPatchCode,PlanProd_MainPatch) VALUES (@PlanProd_PlanCode,@PlanProd_Code,@PlanProd_TaskDetailCode,@PlanProd_TaskCode,@PlanProd_CmdDetailCode,@PlanProd_CmdCode,@PlanProd_Period,@PlanProd_PartNo,@PlanProd_PartName,@PlanProd_Num,@PlanProd_FNum,@PlanProd_Begin,@PlanProd_End,@PlanProd_LineCode,@PlanProd_FStat,@PlanProd_FBDate,@PlanProd_FDate,@PlanProd_ConfirmPep,@PlanProd_Owner,@PlanProd_Date,@PlanProd_Bak,@Stat,@PlanProd_Patch,@PlanProd_ActBTime,@PlanProd_ActETime,@PlanProd_MPatchCode,@PlanProd_MainPatch);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PlanCode))
         {
            idb.AddParameter("@PlanProd_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PlanCode", prod_PlanProd.PlanProd_PlanCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Code))
         {
            idb.AddParameter("@PlanProd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Code", prod_PlanProd.PlanProd_Code);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_TaskDetailCode))
         {
            idb.AddParameter("@PlanProd_TaskDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_TaskDetailCode", prod_PlanProd.PlanProd_TaskDetailCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_TaskCode))
         {
            idb.AddParameter("@PlanProd_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_TaskCode", prod_PlanProd.PlanProd_TaskCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_CmdDetailCode))
         {
            idb.AddParameter("@PlanProd_CmdDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_CmdDetailCode", prod_PlanProd.PlanProd_CmdDetailCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_CmdCode))
         {
            idb.AddParameter("@PlanProd_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_CmdCode", prod_PlanProd.PlanProd_CmdCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Period))
         {
            idb.AddParameter("@PlanProd_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Period", prod_PlanProd.PlanProd_Period);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PartNo))
         {
            idb.AddParameter("@PlanProd_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PartNo", prod_PlanProd.PlanProd_PartNo);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PartName))
         {
            idb.AddParameter("@PlanProd_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PartName", prod_PlanProd.PlanProd_PartName);
         }
         if (prod_PlanProd.PlanProd_Num == 0)
         {
            idb.AddParameter("@PlanProd_Num", 0);
         }
         else
         {
            idb.AddParameter("@PlanProd_Num", prod_PlanProd.PlanProd_Num);
         }
         if (prod_PlanProd.PlanProd_FNum == 0)
         {
            idb.AddParameter("@PlanProd_FNum", 0);
         }
         else
         {
            idb.AddParameter("@PlanProd_FNum", prod_PlanProd.PlanProd_FNum);
         }
         if (prod_PlanProd.PlanProd_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Begin", prod_PlanProd.PlanProd_Begin);
         }
         if (prod_PlanProd.PlanProd_End == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_End", prod_PlanProd.PlanProd_End);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_LineCode))
         {
            idb.AddParameter("@PlanProd_LineCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_LineCode", prod_PlanProd.PlanProd_LineCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_FStat))
         {
            idb.AddParameter("@PlanProd_FStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FStat", prod_PlanProd.PlanProd_FStat);
         }
         if (prod_PlanProd.PlanProd_FBDate == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_FBDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FBDate", prod_PlanProd.PlanProd_FBDate);
         }
         if (prod_PlanProd.PlanProd_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FDate", prod_PlanProd.PlanProd_FDate);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_ConfirmPep))
         {
            idb.AddParameter("@PlanProd_ConfirmPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ConfirmPep", prod_PlanProd.PlanProd_ConfirmPep);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Owner))
         {
            idb.AddParameter("@PlanProd_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Owner", prod_PlanProd.PlanProd_Owner);
         }
         if (prod_PlanProd.PlanProd_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Date", prod_PlanProd.PlanProd_Date);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Bak))
         {
            idb.AddParameter("@PlanProd_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Bak", prod_PlanProd.PlanProd_Bak);
         }
         if (prod_PlanProd.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_PlanProd.Stat);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Patch))
         {
            idb.AddParameter("@PlanProd_Patch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Patch", prod_PlanProd.PlanProd_Patch);
         }
         if (prod_PlanProd.PlanProd_ActBTime == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_ActBTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ActBTime", prod_PlanProd.PlanProd_ActBTime);
         }
         if (prod_PlanProd.PlanProd_ActETime == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_ActETime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ActETime", prod_PlanProd.PlanProd_ActETime);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_MPatchCode))
         {
            idb.AddParameter("@PlanProd_MPatchCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_MPatchCode", prod_PlanProd.PlanProd_MPatchCode);
         }
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_MainPatch))
         {
            idb.AddParameter("@PlanProd_MainPatch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_MainPatch", prod_PlanProd.PlanProd_MainPatch);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新生产计划(产品计划) Prod_PlanProd对象(即:一条记录
      /// </summary>
      public int Update(Prod_PlanProd prod_PlanProd)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_PlanProd       SET ");
            if(prod_PlanProd.PlanProd_PlanCode_IsChanged){sbParameter.Append("PlanProd_PlanCode=@PlanProd_PlanCode, ");}
      if(prod_PlanProd.PlanProd_Code_IsChanged){sbParameter.Append("PlanProd_Code=@PlanProd_Code, ");}
      if(prod_PlanProd.PlanProd_TaskDetailCode_IsChanged){sbParameter.Append("PlanProd_TaskDetailCode=@PlanProd_TaskDetailCode, ");}
      if(prod_PlanProd.PlanProd_TaskCode_IsChanged){sbParameter.Append("PlanProd_TaskCode=@PlanProd_TaskCode, ");}
      if(prod_PlanProd.PlanProd_CmdDetailCode_IsChanged){sbParameter.Append("PlanProd_CmdDetailCode=@PlanProd_CmdDetailCode, ");}
      if(prod_PlanProd.PlanProd_CmdCode_IsChanged){sbParameter.Append("PlanProd_CmdCode=@PlanProd_CmdCode, ");}
      if(prod_PlanProd.PlanProd_Period_IsChanged){sbParameter.Append("PlanProd_Period=@PlanProd_Period, ");}
      if(prod_PlanProd.PlanProd_PartNo_IsChanged){sbParameter.Append("PlanProd_PartNo=@PlanProd_PartNo, ");}
      if(prod_PlanProd.PlanProd_PartName_IsChanged){sbParameter.Append("PlanProd_PartName=@PlanProd_PartName, ");}
      if(prod_PlanProd.PlanProd_Num_IsChanged){sbParameter.Append("PlanProd_Num=@PlanProd_Num, ");}
      if(prod_PlanProd.PlanProd_FNum_IsChanged){sbParameter.Append("PlanProd_FNum=@PlanProd_FNum, ");}
      if(prod_PlanProd.PlanProd_Begin_IsChanged){sbParameter.Append("PlanProd_Begin=@PlanProd_Begin, ");}
      if(prod_PlanProd.PlanProd_End_IsChanged){sbParameter.Append("PlanProd_End=@PlanProd_End, ");}
      if(prod_PlanProd.PlanProd_LineCode_IsChanged){sbParameter.Append("PlanProd_LineCode=@PlanProd_LineCode, ");}
      if(prod_PlanProd.PlanProd_FStat_IsChanged){sbParameter.Append("PlanProd_FStat=@PlanProd_FStat, ");}
      if(prod_PlanProd.PlanProd_FBDate_IsChanged){sbParameter.Append("PlanProd_FBDate=@PlanProd_FBDate, ");}
      if(prod_PlanProd.PlanProd_FDate_IsChanged){sbParameter.Append("PlanProd_FDate=@PlanProd_FDate, ");}
      if(prod_PlanProd.PlanProd_ConfirmPep_IsChanged){sbParameter.Append("PlanProd_ConfirmPep=@PlanProd_ConfirmPep, ");}
      if(prod_PlanProd.PlanProd_Owner_IsChanged){sbParameter.Append("PlanProd_Owner=@PlanProd_Owner, ");}
      if(prod_PlanProd.PlanProd_Date_IsChanged){sbParameter.Append("PlanProd_Date=@PlanProd_Date, ");}
      if(prod_PlanProd.PlanProd_Bak_IsChanged){sbParameter.Append("PlanProd_Bak=@PlanProd_Bak, ");}
      if(prod_PlanProd.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_PlanProd.PlanProd_Patch_IsChanged){sbParameter.Append("PlanProd_Patch=@PlanProd_Patch, ");}
      if(prod_PlanProd.PlanProd_ActBTime_IsChanged){sbParameter.Append("PlanProd_ActBTime=@PlanProd_ActBTime, ");}
      if(prod_PlanProd.PlanProd_ActETime_IsChanged){sbParameter.Append("PlanProd_ActETime=@PlanProd_ActETime, ");}
      if(prod_PlanProd.PlanProd_MPatchCode_IsChanged){sbParameter.Append("PlanProd_MPatchCode=@PlanProd_MPatchCode, ");}
      if(prod_PlanProd.PlanProd_MainPatch_IsChanged){sbParameter.Append("PlanProd_MainPatch=@PlanProd_MainPatch ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PlanProd_ID=@PlanProd_ID; " );
      string sql=sb.ToString();
         if(prod_PlanProd.PlanProd_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PlanCode))
         {
            idb.AddParameter("@PlanProd_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PlanCode", prod_PlanProd.PlanProd_PlanCode);
         }
          }
         if(prod_PlanProd.PlanProd_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Code))
         {
            idb.AddParameter("@PlanProd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Code", prod_PlanProd.PlanProd_Code);
         }
          }
         if(prod_PlanProd.PlanProd_TaskDetailCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_TaskDetailCode))
         {
            idb.AddParameter("@PlanProd_TaskDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_TaskDetailCode", prod_PlanProd.PlanProd_TaskDetailCode);
         }
          }
         if(prod_PlanProd.PlanProd_TaskCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_TaskCode))
         {
            idb.AddParameter("@PlanProd_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_TaskCode", prod_PlanProd.PlanProd_TaskCode);
         }
          }
         if(prod_PlanProd.PlanProd_CmdDetailCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_CmdDetailCode))
         {
            idb.AddParameter("@PlanProd_CmdDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_CmdDetailCode", prod_PlanProd.PlanProd_CmdDetailCode);
         }
          }
         if(prod_PlanProd.PlanProd_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_CmdCode))
         {
            idb.AddParameter("@PlanProd_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_CmdCode", prod_PlanProd.PlanProd_CmdCode);
         }
          }
         if(prod_PlanProd.PlanProd_Period_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Period))
         {
            idb.AddParameter("@PlanProd_Period", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Period", prod_PlanProd.PlanProd_Period);
         }
          }
         if(prod_PlanProd.PlanProd_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PartNo))
         {
            idb.AddParameter("@PlanProd_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PartNo", prod_PlanProd.PlanProd_PartNo);
         }
          }
         if(prod_PlanProd.PlanProd_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_PartName))
         {
            idb.AddParameter("@PlanProd_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_PartName", prod_PlanProd.PlanProd_PartName);
         }
          }
         if(prod_PlanProd.PlanProd_Num_IsChanged)
         {
         if (prod_PlanProd.PlanProd_Num == 0)
         {
            idb.AddParameter("@PlanProd_Num", 0);
         }
         else
         {
            idb.AddParameter("@PlanProd_Num", prod_PlanProd.PlanProd_Num);
         }
          }
         if(prod_PlanProd.PlanProd_FNum_IsChanged)
         {
         if (prod_PlanProd.PlanProd_FNum == 0)
         {
            idb.AddParameter("@PlanProd_FNum", 0);
         }
         else
         {
            idb.AddParameter("@PlanProd_FNum", prod_PlanProd.PlanProd_FNum);
         }
          }
         if(prod_PlanProd.PlanProd_Begin_IsChanged)
         {
         if (prod_PlanProd.PlanProd_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Begin", prod_PlanProd.PlanProd_Begin);
         }
          }
         if(prod_PlanProd.PlanProd_End_IsChanged)
         {
         if (prod_PlanProd.PlanProd_End == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_End", prod_PlanProd.PlanProd_End);
         }
          }
         if(prod_PlanProd.PlanProd_LineCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_LineCode))
         {
            idb.AddParameter("@PlanProd_LineCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_LineCode", prod_PlanProd.PlanProd_LineCode);
         }
          }
         if(prod_PlanProd.PlanProd_FStat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_FStat))
         {
            idb.AddParameter("@PlanProd_FStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FStat", prod_PlanProd.PlanProd_FStat);
         }
          }
         if(prod_PlanProd.PlanProd_FBDate_IsChanged)
         {
         if (prod_PlanProd.PlanProd_FBDate == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_FBDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FBDate", prod_PlanProd.PlanProd_FBDate);
         }
          }
         if(prod_PlanProd.PlanProd_FDate_IsChanged)
         {
         if (prod_PlanProd.PlanProd_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_FDate", prod_PlanProd.PlanProd_FDate);
         }
          }
         if(prod_PlanProd.PlanProd_ConfirmPep_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_ConfirmPep))
         {
            idb.AddParameter("@PlanProd_ConfirmPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ConfirmPep", prod_PlanProd.PlanProd_ConfirmPep);
         }
          }
         if(prod_PlanProd.PlanProd_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Owner))
         {
            idb.AddParameter("@PlanProd_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Owner", prod_PlanProd.PlanProd_Owner);
         }
          }
         if(prod_PlanProd.PlanProd_Date_IsChanged)
         {
         if (prod_PlanProd.PlanProd_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Date", prod_PlanProd.PlanProd_Date);
         }
          }
         if(prod_PlanProd.PlanProd_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Bak))
         {
            idb.AddParameter("@PlanProd_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Bak", prod_PlanProd.PlanProd_Bak);
         }
          }
         if(prod_PlanProd.Stat_IsChanged)
         {
         if (prod_PlanProd.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_PlanProd.Stat);
         }
          }
         if(prod_PlanProd.PlanProd_Patch_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_Patch))
         {
            idb.AddParameter("@PlanProd_Patch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_Patch", prod_PlanProd.PlanProd_Patch);
         }
          }
         if(prod_PlanProd.PlanProd_ActBTime_IsChanged)
         {
         if (prod_PlanProd.PlanProd_ActBTime == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_ActBTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ActBTime", prod_PlanProd.PlanProd_ActBTime);
         }
          }
         if(prod_PlanProd.PlanProd_ActETime_IsChanged)
         {
         if (prod_PlanProd.PlanProd_ActETime == DateTime.MinValue)
         {
            idb.AddParameter("@PlanProd_ActETime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_ActETime", prod_PlanProd.PlanProd_ActETime);
         }
          }
         if(prod_PlanProd.PlanProd_MPatchCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_MPatchCode))
         {
            idb.AddParameter("@PlanProd_MPatchCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_MPatchCode", prod_PlanProd.PlanProd_MPatchCode);
         }
          }
         if(prod_PlanProd.PlanProd_MainPatch_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_PlanProd.PlanProd_MainPatch))
         {
            idb.AddParameter("@PlanProd_MainPatch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PlanProd_MainPatch", prod_PlanProd.PlanProd_MainPatch);
         }
          }

         idb.AddParameter("@PlanProd_ID", prod_PlanProd.PlanProd_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除生产计划(产品计划) Prod_PlanProd对象(即:一条记录
      /// </summary>
      public int Delete(Int64 planProd_ID)
      {
         string sql = "DELETE Prod_PlanProd WHERE 1=1  AND PlanProd_ID=@PlanProd_ID ";
         idb.AddParameter("@PlanProd_ID", planProd_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的生产计划(产品计划) Prod_PlanProd对象(即:一条记录
      /// </summary>
      public Prod_PlanProd GetByKey(Int64 planProd_ID)
      {
         Prod_PlanProd prod_PlanProd = new Prod_PlanProd();
         string sql = "SELECT  PlanProd_ID,PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FStat,PlanProd_FBDate,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_Bak,Stat,PlanProd_Patch,PlanProd_ActBTime,PlanProd_ActETime,PlanProd_MPatchCode,PlanProd_MainPatch FROM Prod_PlanProd WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PlanProd_ID=@PlanProd_ID ";
         idb.AddParameter("@PlanProd_ID", planProd_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
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
            if (dr["PlanProd_MainPatch"] != DBNull.Value) prod_PlanProd.PlanProd_MainPatch = Convert.ToString(dr["PlanProd_MainPatch"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_PlanProd;
      }
      /// <summary>
      /// 获取指定的生产计划(产品计划) Prod_PlanProd对象集合
      /// </summary>
      public List<Prod_PlanProd> GetListByWhere(string strCondition)
      {
         List<Prod_PlanProd> ret = new List<Prod_PlanProd>();
         string sql = "SELECT  PlanProd_ID,PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FStat,PlanProd_FBDate,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_Bak,Stat,PlanProd_Patch,PlanProd_ActBTime,PlanProd_ActETime,PlanProd_MPatchCode,PlanProd_MainPatch FROM Prod_PlanProd WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            if (dr["PlanProd_MainPatch"] != DBNull.Value) prod_PlanProd.PlanProd_MainPatch = Convert.ToString(dr["PlanProd_MainPatch"]);
            ret.Add(prod_PlanProd);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产计划(产品计划) Prod_PlanProd对象(即:一条记录
      /// </summary>
      public List<Prod_PlanProd> GetAll()
      {
         List<Prod_PlanProd> ret = new List<Prod_PlanProd>();
         string sql = "SELECT  PlanProd_ID,PlanProd_PlanCode,PlanProd_Code,PlanProd_TaskDetailCode,PlanProd_TaskCode,PlanProd_CmdDetailCode,PlanProd_CmdCode,PlanProd_Period,PlanProd_PartNo,PlanProd_PartName,PlanProd_Num,PlanProd_FNum,PlanProd_Begin,PlanProd_End,PlanProd_LineCode,PlanProd_FStat,PlanProd_FBDate,PlanProd_FDate,PlanProd_ConfirmPep,PlanProd_Owner,PlanProd_Date,PlanProd_Bak,Stat,PlanProd_Patch,PlanProd_ActBTime,PlanProd_ActETime,PlanProd_MPatchCode,PlanProd_MainPatch FROM Prod_PlanProd where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
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
            if (dr["PlanProd_MainPatch"] != DBNull.Value) prod_PlanProd.PlanProd_MainPatch = Convert.ToString(dr["PlanProd_MainPatch"]);
            ret.Add(prod_PlanProd);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
