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
   /// 生产任务表
   /// </summary>
   [Serializable]
   public partial class ADOProd_Task
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产任务表 Prod_Task对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Task prod_Task)
      {
         string sql = "INSERT INTO Prod_Task (Task_Code,Task_Name,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,Task_PartCat,Task_PartCatName,Task_Owner,Task_Date,TaskDetail_Unit,TaskDetail_Num,Task_DNum,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_Remark,Stat,AuditStat,AuditCurAudit,Task_Customer,Task_CustomerName,Task_RefInv) VALUES (@Task_Code,@Task_Name,@TaskDetail_CmdCode,@TaskDetail_PartNo,@TaskDetail_PartName,@Task_PartCat,@Task_PartCatName,@Task_Owner,@Task_Date,@TaskDetail_Unit,@TaskDetail_Num,@Task_DNum,@TaskDetail_ProdType,@TaskDetail_PlanBegin,@TaskDetail_PlanEnd,@TaskDetail_ActEnd,@Task_FNum,@Task_Roads,@Task_ProdCode,@Task_Stat,@Task_Remark,@Stat,@AuditStat,@AuditCurAudit,@Task_Customer,@Task_CustomerName,@Task_RefInv)";
         if (string.IsNullOrEmpty(prod_Task.Task_Code))
         {
            idb.AddParameter("@Task_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Code", prod_Task.Task_Code);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Name))
         {
            idb.AddParameter("@Task_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Name", prod_Task.Task_Name);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_CmdCode))
         {
            idb.AddParameter("@TaskDetail_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_CmdCode", prod_Task.TaskDetail_CmdCode);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_PartNo))
         {
            idb.AddParameter("@TaskDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartNo", prod_Task.TaskDetail_PartNo);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_PartName))
         {
            idb.AddParameter("@TaskDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartName", prod_Task.TaskDetail_PartName);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_PartCat))
         {
            idb.AddParameter("@Task_PartCat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_PartCat", prod_Task.Task_PartCat);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_PartCatName))
         {
            idb.AddParameter("@Task_PartCatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_PartCatName", prod_Task.Task_PartCatName);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Owner))
         {
            idb.AddParameter("@Task_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Owner", prod_Task.Task_Owner);
         }
         if (prod_Task.Task_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Task_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Date", prod_Task.Task_Date);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_Unit))
         {
            idb.AddParameter("@TaskDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Unit", prod_Task.TaskDetail_Unit);
         }
         if (prod_Task.TaskDetail_Num == 0)
         {
            idb.AddParameter("@TaskDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Num", prod_Task.TaskDetail_Num);
         }
         if (prod_Task.Task_DNum == 0)
         {
            idb.AddParameter("@Task_DNum", 0);
         }
         else
         {
            idb.AddParameter("@Task_DNum", prod_Task.Task_DNum);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_ProdType))
         {
            idb.AddParameter("@TaskDetail_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ProdType", prod_Task.TaskDetail_ProdType);
         }
         if (prod_Task.TaskDetail_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanBegin", prod_Task.TaskDetail_PlanBegin);
         }
         if (prod_Task.TaskDetail_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanEnd", prod_Task.TaskDetail_PlanEnd);
         }
         if (prod_Task.TaskDetail_ActEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_ActEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ActEnd", prod_Task.TaskDetail_ActEnd);
         }
         if (prod_Task.Task_FNum == 0)
         {
            idb.AddParameter("@Task_FNum", 0);
         }
         else
         {
            idb.AddParameter("@Task_FNum", prod_Task.Task_FNum);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Roads))
         {
            idb.AddParameter("@Task_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Roads", prod_Task.Task_Roads);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_ProdCode))
         {
            idb.AddParameter("@Task_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_ProdCode", prod_Task.Task_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Stat))
         {
            idb.AddParameter("@Task_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Stat", prod_Task.Task_Stat);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Remark))
         {
            idb.AddParameter("@Task_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Remark", prod_Task.Task_Remark);
         }
         if (prod_Task.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Task.Stat);
         }
         if (string.IsNullOrEmpty(prod_Task.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", prod_Task.AuditStat);
         }
         if (string.IsNullOrEmpty(prod_Task.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", prod_Task.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Customer))
         {
            idb.AddParameter("@Task_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Customer", prod_Task.Task_Customer);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_CustomerName))
         {
            idb.AddParameter("@Task_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_CustomerName", prod_Task.Task_CustomerName);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_RefInv))
         {
            idb.AddParameter("@Task_RefInv", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_RefInv", prod_Task.Task_RefInv);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加生产任务表 Prod_Task对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Task prod_Task)
      {
         string sql = "INSERT INTO Prod_Task (Task_Code,Task_Name,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,Task_PartCat,Task_PartCatName,Task_Owner,Task_Date,TaskDetail_Unit,TaskDetail_Num,Task_DNum,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_Remark,Stat,AuditStat,AuditCurAudit,Task_Customer,Task_CustomerName,Task_RefInv) VALUES (@Task_Code,@Task_Name,@TaskDetail_CmdCode,@TaskDetail_PartNo,@TaskDetail_PartName,@Task_PartCat,@Task_PartCatName,@Task_Owner,@Task_Date,@TaskDetail_Unit,@TaskDetail_Num,@Task_DNum,@TaskDetail_ProdType,@TaskDetail_PlanBegin,@TaskDetail_PlanEnd,@TaskDetail_ActEnd,@Task_FNum,@Task_Roads,@Task_ProdCode,@Task_Stat,@Task_Remark,@Stat,@AuditStat,@AuditCurAudit,@Task_Customer,@Task_CustomerName,@Task_RefInv);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Task.Task_Code))
         {
            idb.AddParameter("@Task_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Code", prod_Task.Task_Code);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Name))
         {
            idb.AddParameter("@Task_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Name", prod_Task.Task_Name);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_CmdCode))
         {
            idb.AddParameter("@TaskDetail_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_CmdCode", prod_Task.TaskDetail_CmdCode);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_PartNo))
         {
            idb.AddParameter("@TaskDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartNo", prod_Task.TaskDetail_PartNo);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_PartName))
         {
            idb.AddParameter("@TaskDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartName", prod_Task.TaskDetail_PartName);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_PartCat))
         {
            idb.AddParameter("@Task_PartCat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_PartCat", prod_Task.Task_PartCat);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_PartCatName))
         {
            idb.AddParameter("@Task_PartCatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_PartCatName", prod_Task.Task_PartCatName);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Owner))
         {
            idb.AddParameter("@Task_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Owner", prod_Task.Task_Owner);
         }
         if (prod_Task.Task_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Task_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Date", prod_Task.Task_Date);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_Unit))
         {
            idb.AddParameter("@TaskDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Unit", prod_Task.TaskDetail_Unit);
         }
         if (prod_Task.TaskDetail_Num == 0)
         {
            idb.AddParameter("@TaskDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Num", prod_Task.TaskDetail_Num);
         }
         if (prod_Task.Task_DNum == 0)
         {
            idb.AddParameter("@Task_DNum", 0);
         }
         else
         {
            idb.AddParameter("@Task_DNum", prod_Task.Task_DNum);
         }
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_ProdType))
         {
            idb.AddParameter("@TaskDetail_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ProdType", prod_Task.TaskDetail_ProdType);
         }
         if (prod_Task.TaskDetail_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanBegin", prod_Task.TaskDetail_PlanBegin);
         }
         if (prod_Task.TaskDetail_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanEnd", prod_Task.TaskDetail_PlanEnd);
         }
         if (prod_Task.TaskDetail_ActEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_ActEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ActEnd", prod_Task.TaskDetail_ActEnd);
         }
         if (prod_Task.Task_FNum == 0)
         {
            idb.AddParameter("@Task_FNum", 0);
         }
         else
         {
            idb.AddParameter("@Task_FNum", prod_Task.Task_FNum);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Roads))
         {
            idb.AddParameter("@Task_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Roads", prod_Task.Task_Roads);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_ProdCode))
         {
            idb.AddParameter("@Task_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_ProdCode", prod_Task.Task_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Stat))
         {
            idb.AddParameter("@Task_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Stat", prod_Task.Task_Stat);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Remark))
         {
            idb.AddParameter("@Task_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Remark", prod_Task.Task_Remark);
         }
         if (prod_Task.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Task.Stat);
         }
         if (string.IsNullOrEmpty(prod_Task.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", prod_Task.AuditStat);
         }
         if (string.IsNullOrEmpty(prod_Task.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", prod_Task.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_Customer))
         {
            idb.AddParameter("@Task_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Customer", prod_Task.Task_Customer);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_CustomerName))
         {
            idb.AddParameter("@Task_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_CustomerName", prod_Task.Task_CustomerName);
         }
         if (string.IsNullOrEmpty(prod_Task.Task_RefInv))
         {
            idb.AddParameter("@Task_RefInv", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_RefInv", prod_Task.Task_RefInv);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新生产任务表 Prod_Task对象(即:一条记录
      /// </summary>
      public int Update(Prod_Task prod_Task)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Task       SET ");
            if(prod_Task.Task_Code_IsChanged){sbParameter.Append("Task_Code=@Task_Code, ");}
      if(prod_Task.Task_Name_IsChanged){sbParameter.Append("Task_Name=@Task_Name, ");}
      if(prod_Task.TaskDetail_CmdCode_IsChanged){sbParameter.Append("TaskDetail_CmdCode=@TaskDetail_CmdCode, ");}
      if(prod_Task.TaskDetail_PartNo_IsChanged){sbParameter.Append("TaskDetail_PartNo=@TaskDetail_PartNo, ");}
      if(prod_Task.TaskDetail_PartName_IsChanged){sbParameter.Append("TaskDetail_PartName=@TaskDetail_PartName, ");}
      if(prod_Task.Task_PartCat_IsChanged){sbParameter.Append("Task_PartCat=@Task_PartCat, ");}
      if(prod_Task.Task_PartCatName_IsChanged){sbParameter.Append("Task_PartCatName=@Task_PartCatName, ");}
      if(prod_Task.Task_Owner_IsChanged){sbParameter.Append("Task_Owner=@Task_Owner, ");}
      if(prod_Task.Task_Date_IsChanged){sbParameter.Append("Task_Date=@Task_Date, ");}
      if(prod_Task.TaskDetail_Unit_IsChanged){sbParameter.Append("TaskDetail_Unit=@TaskDetail_Unit, ");}
      if(prod_Task.TaskDetail_Num_IsChanged){sbParameter.Append("TaskDetail_Num=@TaskDetail_Num, ");}
      if(prod_Task.Task_DNum_IsChanged){sbParameter.Append("Task_DNum=@Task_DNum, ");}
      if(prod_Task.TaskDetail_ProdType_IsChanged){sbParameter.Append("TaskDetail_ProdType=@TaskDetail_ProdType, ");}
      if(prod_Task.TaskDetail_PlanBegin_IsChanged){sbParameter.Append("TaskDetail_PlanBegin=@TaskDetail_PlanBegin, ");}
      if(prod_Task.TaskDetail_PlanEnd_IsChanged){sbParameter.Append("TaskDetail_PlanEnd=@TaskDetail_PlanEnd, ");}
      if(prod_Task.TaskDetail_ActEnd_IsChanged){sbParameter.Append("TaskDetail_ActEnd=@TaskDetail_ActEnd, ");}
      if(prod_Task.Task_FNum_IsChanged){sbParameter.Append("Task_FNum=@Task_FNum, ");}
      if(prod_Task.Task_Roads_IsChanged){sbParameter.Append("Task_Roads=@Task_Roads, ");}
      if(prod_Task.Task_ProdCode_IsChanged){sbParameter.Append("Task_ProdCode=@Task_ProdCode, ");}
      if(prod_Task.Task_Stat_IsChanged){sbParameter.Append("Task_Stat=@Task_Stat, ");}
      if(prod_Task.Task_Remark_IsChanged){sbParameter.Append("Task_Remark=@Task_Remark, ");}
      if(prod_Task.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_Task.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(prod_Task.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(prod_Task.Task_Customer_IsChanged){sbParameter.Append("Task_Customer=@Task_Customer, ");}
      if(prod_Task.Task_CustomerName_IsChanged){sbParameter.Append("Task_CustomerName=@Task_CustomerName, ");}
      if(prod_Task.Task_RefInv_IsChanged){sbParameter.Append("Task_RefInv=@Task_RefInv ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Task_ID=@Task_ID; " );
      string sql=sb.ToString();
         if(prod_Task.Task_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Code))
         {
            idb.AddParameter("@Task_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Code", prod_Task.Task_Code);
         }
          }
         if(prod_Task.Task_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Name))
         {
            idb.AddParameter("@Task_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Name", prod_Task.Task_Name);
         }
          }
         if(prod_Task.TaskDetail_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_CmdCode))
         {
            idb.AddParameter("@TaskDetail_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_CmdCode", prod_Task.TaskDetail_CmdCode);
         }
          }
         if(prod_Task.TaskDetail_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_PartNo))
         {
            idb.AddParameter("@TaskDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartNo", prod_Task.TaskDetail_PartNo);
         }
          }
         if(prod_Task.TaskDetail_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_PartName))
         {
            idb.AddParameter("@TaskDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartName", prod_Task.TaskDetail_PartName);
         }
          }
         if(prod_Task.Task_PartCat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_PartCat))
         {
            idb.AddParameter("@Task_PartCat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_PartCat", prod_Task.Task_PartCat);
         }
          }
         if(prod_Task.Task_PartCatName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_PartCatName))
         {
            idb.AddParameter("@Task_PartCatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_PartCatName", prod_Task.Task_PartCatName);
         }
          }
         if(prod_Task.Task_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Owner))
         {
            idb.AddParameter("@Task_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Owner", prod_Task.Task_Owner);
         }
          }
         if(prod_Task.Task_Date_IsChanged)
         {
         if (prod_Task.Task_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Task_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Date", prod_Task.Task_Date);
         }
          }
         if(prod_Task.TaskDetail_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_Unit))
         {
            idb.AddParameter("@TaskDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Unit", prod_Task.TaskDetail_Unit);
         }
          }
         if(prod_Task.TaskDetail_Num_IsChanged)
         {
         if (prod_Task.TaskDetail_Num == 0)
         {
            idb.AddParameter("@TaskDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Num", prod_Task.TaskDetail_Num);
         }
          }
         if(prod_Task.Task_DNum_IsChanged)
         {
         if (prod_Task.Task_DNum == 0)
         {
            idb.AddParameter("@Task_DNum", 0);
         }
         else
         {
            idb.AddParameter("@Task_DNum", prod_Task.Task_DNum);
         }
          }
         if(prod_Task.TaskDetail_ProdType_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.TaskDetail_ProdType))
         {
            idb.AddParameter("@TaskDetail_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ProdType", prod_Task.TaskDetail_ProdType);
         }
          }
         if(prod_Task.TaskDetail_PlanBegin_IsChanged)
         {
         if (prod_Task.TaskDetail_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanBegin", prod_Task.TaskDetail_PlanBegin);
         }
          }
         if(prod_Task.TaskDetail_PlanEnd_IsChanged)
         {
         if (prod_Task.TaskDetail_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanEnd", prod_Task.TaskDetail_PlanEnd);
         }
          }
         if(prod_Task.TaskDetail_ActEnd_IsChanged)
         {
         if (prod_Task.TaskDetail_ActEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_ActEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ActEnd", prod_Task.TaskDetail_ActEnd);
         }
          }
         if(prod_Task.Task_FNum_IsChanged)
         {
         if (prod_Task.Task_FNum == 0)
         {
            idb.AddParameter("@Task_FNum", 0);
         }
         else
         {
            idb.AddParameter("@Task_FNum", prod_Task.Task_FNum);
         }
          }
         if(prod_Task.Task_Roads_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Roads))
         {
            idb.AddParameter("@Task_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Roads", prod_Task.Task_Roads);
         }
          }
         if(prod_Task.Task_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_ProdCode))
         {
            idb.AddParameter("@Task_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_ProdCode", prod_Task.Task_ProdCode);
         }
          }
         if(prod_Task.Task_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Stat))
         {
            idb.AddParameter("@Task_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Stat", prod_Task.Task_Stat);
         }
          }
         if(prod_Task.Task_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Remark))
         {
            idb.AddParameter("@Task_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Remark", prod_Task.Task_Remark);
         }
          }
         if(prod_Task.Stat_IsChanged)
         {
         if (prod_Task.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Task.Stat);
         }
          }
         if(prod_Task.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", prod_Task.AuditStat);
         }
          }
         if(prod_Task.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", prod_Task.AuditCurAudit);
         }
          }
         if(prod_Task.Task_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_Customer))
         {
            idb.AddParameter("@Task_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Customer", prod_Task.Task_Customer);
         }
          }
         if(prod_Task.Task_CustomerName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_CustomerName))
         {
            idb.AddParameter("@Task_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_CustomerName", prod_Task.Task_CustomerName);
         }
          }
         if(prod_Task.Task_RefInv_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Task.Task_RefInv))
         {
            idb.AddParameter("@Task_RefInv", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_RefInv", prod_Task.Task_RefInv);
         }
          }

         idb.AddParameter("@Task_ID", prod_Task.Task_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除生产任务表 Prod_Task对象(即:一条记录
      /// </summary>
      public int Delete(Int64 task_ID)
      {
         string sql = "DELETE Prod_Task WHERE 1=1  AND Task_ID=@Task_ID ";
         idb.AddParameter("@Task_ID", task_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的生产任务表 Prod_Task对象(即:一条记录
      /// </summary>
      public Prod_Task GetByKey(Int64 task_ID)
      {
         Prod_Task prod_Task = new Prod_Task();
         string sql = "SELECT  Task_ID,Task_Code,Task_Name,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,Task_PartCat,Task_PartCatName,Task_Owner,Task_Date,TaskDetail_Unit,TaskDetail_Num,Task_DNum,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_Remark,Stat,AuditStat,AuditCurAudit,Task_Customer,Task_CustomerName,Task_RefInv FROM Prod_Task WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Task_ID=@Task_ID ";
         idb.AddParameter("@Task_ID", task_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
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
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_Task;
      }
      /// <summary>
      /// 获取指定的生产任务表 Prod_Task对象集合
      /// </summary>
      public List<Prod_Task> GetListByWhere(string strCondition)
      {
         List<Prod_Task> ret = new List<Prod_Task>();
         string sql = "SELECT  Task_ID,Task_Code,Task_Name,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,Task_PartCat,Task_PartCatName,Task_Owner,Task_Date,TaskDetail_Unit,TaskDetail_Num,Task_DNum,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_Remark,Stat,AuditStat,AuditCurAudit,Task_Customer,Task_CustomerName,Task_RefInv FROM Prod_Task WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            ret.Add(prod_Task);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产任务表 Prod_Task对象(即:一条记录
      /// </summary>
      public List<Prod_Task> GetAll()
      {
         List<Prod_Task> ret = new List<Prod_Task>();
         string sql = "SELECT  Task_ID,Task_Code,Task_Name,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,Task_PartCat,Task_PartCatName,Task_Owner,Task_Date,TaskDetail_Unit,TaskDetail_Num,Task_DNum,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_Remark,Stat,AuditStat,AuditCurAudit,Task_Customer,Task_CustomerName,Task_RefInv FROM Prod_Task where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
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
            ret.Add(prod_Task);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
