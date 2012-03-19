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
   public partial class ADOFailure_Information
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Failure_Information对象(即:一条记录)
      /// </summary>
      public int Add(Failure_Information failure_Information)
      {
         string sql = "INSERT INTO Failure_Information (FInfo_Code,FInfo_CustomerCode,FInfo_HandCode,FInfo_RespEntity1,FInfo_RespEntity2,FInfo_CmdCode,FInfo_PartNo,FInfo_PartName,FInfo_PartSpec,FInfo_Num,FInfo_ProdNo,FInfo_FindNode,FInfo_FindNodeName,FInfo_RespNode,FInfo_RespEntity,FInfo_TechReq,FInfo_InCompetent,FInfo_Owner,FInfo_Date,FInfo_Process,FInfo_Stat,FInfo_IsCancel,FInfo_CancelPep,FInfo_CancelDate,FInfo_CancelDesp,FInfo_IsClaim,FInfo_ClaimDesp,FInfo_ClaimPep,FInfo_ClaimDate,FInfo_Reason,Stat,AuditStat,AuditCurAudit,FInfo_Udef1,FInfo_Udef2,FInfo_IsPrint,FInfo_RespNodeName,FInfo_RespEntityName,FInfo_Creator,FInfo_CreatorCode,FInfo_CreateTime,FInfo_RelationCode) VALUES (@FInfo_Code,@FInfo_CustomerCode,@FInfo_HandCode,@FInfo_RespEntity1,@FInfo_RespEntity2,@FInfo_CmdCode,@FInfo_PartNo,@FInfo_PartName,@FInfo_PartSpec,@FInfo_Num,@FInfo_ProdNo,@FInfo_FindNode,@FInfo_FindNodeName,@FInfo_RespNode,@FInfo_RespEntity,@FInfo_TechReq,@FInfo_InCompetent,@FInfo_Owner,@FInfo_Date,@FInfo_Process,@FInfo_Stat,@FInfo_IsCancel,@FInfo_CancelPep,@FInfo_CancelDate,@FInfo_CancelDesp,@FInfo_IsClaim,@FInfo_ClaimDesp,@FInfo_ClaimPep,@FInfo_ClaimDate,@FInfo_Reason,@Stat,@AuditStat,@AuditCurAudit,@FInfo_Udef1,@FInfo_Udef2,@FInfo_IsPrint,@FInfo_RespNodeName,@FInfo_RespEntityName,@FInfo_Creator,@FInfo_CreatorCode,@FInfo_CreateTime,@FInfo_RelationCode)";
         if (string.IsNullOrEmpty(failure_Information.FInfo_Code))
         {
            idb.AddParameter("@FInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Code", failure_Information.FInfo_Code);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CustomerCode))
         {
            idb.AddParameter("@FInfo_CustomerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CustomerCode", failure_Information.FInfo_CustomerCode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_HandCode))
         {
            idb.AddParameter("@FInfo_HandCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_HandCode", failure_Information.FInfo_HandCode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity1))
         {
            idb.AddParameter("@FInfo_RespEntity1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity1", failure_Information.FInfo_RespEntity1);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity2))
         {
            idb.AddParameter("@FInfo_RespEntity2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity2", failure_Information.FInfo_RespEntity2);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CmdCode))
         {
            idb.AddParameter("@FInfo_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CmdCode", failure_Information.FInfo_CmdCode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartNo))
         {
            idb.AddParameter("@FInfo_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartNo", failure_Information.FInfo_PartNo);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartName))
         {
            idb.AddParameter("@FInfo_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartName", failure_Information.FInfo_PartName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartSpec))
         {
            idb.AddParameter("@FInfo_PartSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartSpec", failure_Information.FInfo_PartSpec);
         }
         if (failure_Information.FInfo_Num == 0)
         {
            idb.AddParameter("@FInfo_Num", 0);
         }
         else
         {
            idb.AddParameter("@FInfo_Num", failure_Information.FInfo_Num);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_ProdNo))
         {
            idb.AddParameter("@FInfo_ProdNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ProdNo", failure_Information.FInfo_ProdNo);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_FindNode))
         {
            idb.AddParameter("@FInfo_FindNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_FindNode", failure_Information.FInfo_FindNode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_FindNodeName))
         {
            idb.AddParameter("@FInfo_FindNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_FindNodeName", failure_Information.FInfo_FindNodeName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespNode))
         {
            idb.AddParameter("@FInfo_RespNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespNode", failure_Information.FInfo_RespNode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity))
         {
            idb.AddParameter("@FInfo_RespEntity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity", failure_Information.FInfo_RespEntity);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_TechReq))
         {
            idb.AddParameter("@FInfo_TechReq", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_TechReq", failure_Information.FInfo_TechReq);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_InCompetent))
         {
            idb.AddParameter("@FInfo_InCompetent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_InCompetent", failure_Information.FInfo_InCompetent);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Owner))
         {
            idb.AddParameter("@FInfo_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Owner", failure_Information.FInfo_Owner);
         }
         if (failure_Information.FInfo_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Date", failure_Information.FInfo_Date);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Process))
         {
            idb.AddParameter("@FInfo_Process", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Process", failure_Information.FInfo_Process);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Stat))
         {
            idb.AddParameter("@FInfo_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Stat", failure_Information.FInfo_Stat);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsCancel))
         {
            idb.AddParameter("@FInfo_IsCancel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsCancel", failure_Information.FInfo_IsCancel);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CancelPep))
         {
            idb.AddParameter("@FInfo_CancelPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelPep", failure_Information.FInfo_CancelPep);
         }
         if (failure_Information.FInfo_CancelDate == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_CancelDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelDate", failure_Information.FInfo_CancelDate);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CancelDesp))
         {
            idb.AddParameter("@FInfo_CancelDesp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelDesp", failure_Information.FInfo_CancelDesp);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsClaim))
         {
            idb.AddParameter("@FInfo_IsClaim", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsClaim", failure_Information.FInfo_IsClaim);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_ClaimDesp))
         {
            idb.AddParameter("@FInfo_ClaimDesp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimDesp", failure_Information.FInfo_ClaimDesp);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_ClaimPep))
         {
            idb.AddParameter("@FInfo_ClaimPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimPep", failure_Information.FInfo_ClaimPep);
         }
         if (failure_Information.FInfo_ClaimDate == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_ClaimDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimDate", failure_Information.FInfo_ClaimDate);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Reason))
         {
            idb.AddParameter("@FInfo_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Reason", failure_Information.FInfo_Reason);
         }
         if (failure_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", failure_Information.Stat);
         }
         if (string.IsNullOrEmpty(failure_Information.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", failure_Information.AuditStat);
         }
         if (string.IsNullOrEmpty(failure_Information.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", failure_Information.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Udef1))
         {
            idb.AddParameter("@FInfo_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Udef1", failure_Information.FInfo_Udef1);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Udef2))
         {
            idb.AddParameter("@FInfo_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Udef2", failure_Information.FInfo_Udef2);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsPrint))
         {
            idb.AddParameter("@FInfo_IsPrint", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsPrint", failure_Information.FInfo_IsPrint);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespNodeName))
         {
            idb.AddParameter("@FInfo_RespNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespNodeName", failure_Information.FInfo_RespNodeName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntityName))
         {
            idb.AddParameter("@FInfo_RespEntityName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntityName", failure_Information.FInfo_RespEntityName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Creator))
         {
            idb.AddParameter("@FInfo_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Creator", failure_Information.FInfo_Creator);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CreatorCode))
         {
            idb.AddParameter("@FInfo_CreatorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CreatorCode", failure_Information.FInfo_CreatorCode);
         }
         if (failure_Information.FInfo_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CreateTime", failure_Information.FInfo_CreateTime);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RelationCode))
         {
            idb.AddParameter("@FInfo_RelationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RelationCode", failure_Information.FInfo_RelationCode);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Failure_Information对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Failure_Information failure_Information)
      {
         string sql = "INSERT INTO Failure_Information (FInfo_Code,FInfo_CustomerCode,FInfo_HandCode,FInfo_RespEntity1,FInfo_RespEntity2,FInfo_CmdCode,FInfo_PartNo,FInfo_PartName,FInfo_PartSpec,FInfo_Num,FInfo_ProdNo,FInfo_FindNode,FInfo_FindNodeName,FInfo_RespNode,FInfo_RespEntity,FInfo_TechReq,FInfo_InCompetent,FInfo_Owner,FInfo_Date,FInfo_Process,FInfo_Stat,FInfo_IsCancel,FInfo_CancelPep,FInfo_CancelDate,FInfo_CancelDesp,FInfo_IsClaim,FInfo_ClaimDesp,FInfo_ClaimPep,FInfo_ClaimDate,FInfo_Reason,Stat,AuditStat,AuditCurAudit,FInfo_Udef1,FInfo_Udef2,FInfo_IsPrint,FInfo_RespNodeName,FInfo_RespEntityName,FInfo_Creator,FInfo_CreatorCode,FInfo_CreateTime,FInfo_RelationCode) VALUES (@FInfo_Code,@FInfo_CustomerCode,@FInfo_HandCode,@FInfo_RespEntity1,@FInfo_RespEntity2,@FInfo_CmdCode,@FInfo_PartNo,@FInfo_PartName,@FInfo_PartSpec,@FInfo_Num,@FInfo_ProdNo,@FInfo_FindNode,@FInfo_FindNodeName,@FInfo_RespNode,@FInfo_RespEntity,@FInfo_TechReq,@FInfo_InCompetent,@FInfo_Owner,@FInfo_Date,@FInfo_Process,@FInfo_Stat,@FInfo_IsCancel,@FInfo_CancelPep,@FInfo_CancelDate,@FInfo_CancelDesp,@FInfo_IsClaim,@FInfo_ClaimDesp,@FInfo_ClaimPep,@FInfo_ClaimDate,@FInfo_Reason,@Stat,@AuditStat,@AuditCurAudit,@FInfo_Udef1,@FInfo_Udef2,@FInfo_IsPrint,@FInfo_RespNodeName,@FInfo_RespEntityName,@FInfo_Creator,@FInfo_CreatorCode,@FInfo_CreateTime,@FInfo_RelationCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(failure_Information.FInfo_Code))
         {
            idb.AddParameter("@FInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Code", failure_Information.FInfo_Code);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CustomerCode))
         {
            idb.AddParameter("@FInfo_CustomerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CustomerCode", failure_Information.FInfo_CustomerCode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_HandCode))
         {
            idb.AddParameter("@FInfo_HandCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_HandCode", failure_Information.FInfo_HandCode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity1))
         {
            idb.AddParameter("@FInfo_RespEntity1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity1", failure_Information.FInfo_RespEntity1);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity2))
         {
            idb.AddParameter("@FInfo_RespEntity2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity2", failure_Information.FInfo_RespEntity2);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CmdCode))
         {
            idb.AddParameter("@FInfo_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CmdCode", failure_Information.FInfo_CmdCode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartNo))
         {
            idb.AddParameter("@FInfo_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartNo", failure_Information.FInfo_PartNo);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartName))
         {
            idb.AddParameter("@FInfo_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartName", failure_Information.FInfo_PartName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartSpec))
         {
            idb.AddParameter("@FInfo_PartSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartSpec", failure_Information.FInfo_PartSpec);
         }
         if (failure_Information.FInfo_Num == 0)
         {
            idb.AddParameter("@FInfo_Num", 0);
         }
         else
         {
            idb.AddParameter("@FInfo_Num", failure_Information.FInfo_Num);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_ProdNo))
         {
            idb.AddParameter("@FInfo_ProdNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ProdNo", failure_Information.FInfo_ProdNo);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_FindNode))
         {
            idb.AddParameter("@FInfo_FindNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_FindNode", failure_Information.FInfo_FindNode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_FindNodeName))
         {
            idb.AddParameter("@FInfo_FindNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_FindNodeName", failure_Information.FInfo_FindNodeName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespNode))
         {
            idb.AddParameter("@FInfo_RespNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespNode", failure_Information.FInfo_RespNode);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity))
         {
            idb.AddParameter("@FInfo_RespEntity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity", failure_Information.FInfo_RespEntity);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_TechReq))
         {
            idb.AddParameter("@FInfo_TechReq", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_TechReq", failure_Information.FInfo_TechReq);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_InCompetent))
         {
            idb.AddParameter("@FInfo_InCompetent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_InCompetent", failure_Information.FInfo_InCompetent);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Owner))
         {
            idb.AddParameter("@FInfo_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Owner", failure_Information.FInfo_Owner);
         }
         if (failure_Information.FInfo_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Date", failure_Information.FInfo_Date);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Process))
         {
            idb.AddParameter("@FInfo_Process", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Process", failure_Information.FInfo_Process);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Stat))
         {
            idb.AddParameter("@FInfo_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Stat", failure_Information.FInfo_Stat);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsCancel))
         {
            idb.AddParameter("@FInfo_IsCancel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsCancel", failure_Information.FInfo_IsCancel);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CancelPep))
         {
            idb.AddParameter("@FInfo_CancelPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelPep", failure_Information.FInfo_CancelPep);
         }
         if (failure_Information.FInfo_CancelDate == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_CancelDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelDate", failure_Information.FInfo_CancelDate);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CancelDesp))
         {
            idb.AddParameter("@FInfo_CancelDesp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelDesp", failure_Information.FInfo_CancelDesp);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsClaim))
         {
            idb.AddParameter("@FInfo_IsClaim", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsClaim", failure_Information.FInfo_IsClaim);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_ClaimDesp))
         {
            idb.AddParameter("@FInfo_ClaimDesp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimDesp", failure_Information.FInfo_ClaimDesp);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_ClaimPep))
         {
            idb.AddParameter("@FInfo_ClaimPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimPep", failure_Information.FInfo_ClaimPep);
         }
         if (failure_Information.FInfo_ClaimDate == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_ClaimDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimDate", failure_Information.FInfo_ClaimDate);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Reason))
         {
            idb.AddParameter("@FInfo_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Reason", failure_Information.FInfo_Reason);
         }
         if (failure_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", failure_Information.Stat);
         }
         if (string.IsNullOrEmpty(failure_Information.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", failure_Information.AuditStat);
         }
         if (string.IsNullOrEmpty(failure_Information.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", failure_Information.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Udef1))
         {
            idb.AddParameter("@FInfo_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Udef1", failure_Information.FInfo_Udef1);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Udef2))
         {
            idb.AddParameter("@FInfo_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Udef2", failure_Information.FInfo_Udef2);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsPrint))
         {
            idb.AddParameter("@FInfo_IsPrint", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsPrint", failure_Information.FInfo_IsPrint);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespNodeName))
         {
            idb.AddParameter("@FInfo_RespNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespNodeName", failure_Information.FInfo_RespNodeName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntityName))
         {
            idb.AddParameter("@FInfo_RespEntityName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntityName", failure_Information.FInfo_RespEntityName);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_Creator))
         {
            idb.AddParameter("@FInfo_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Creator", failure_Information.FInfo_Creator);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_CreatorCode))
         {
            idb.AddParameter("@FInfo_CreatorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CreatorCode", failure_Information.FInfo_CreatorCode);
         }
         if (failure_Information.FInfo_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CreateTime", failure_Information.FInfo_CreateTime);
         }
         if (string.IsNullOrEmpty(failure_Information.FInfo_RelationCode))
         {
            idb.AddParameter("@FInfo_RelationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RelationCode", failure_Information.FInfo_RelationCode);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Failure_Information对象(即:一条记录
      /// </summary>
      public int Update(Failure_Information failure_Information)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Failure_Information       SET ");
            if(failure_Information.FInfo_Code_IsChanged){sbParameter.Append("FInfo_Code=@FInfo_Code, ");}
      if(failure_Information.FInfo_CustomerCode_IsChanged){sbParameter.Append("FInfo_CustomerCode=@FInfo_CustomerCode, ");}
      if(failure_Information.FInfo_HandCode_IsChanged){sbParameter.Append("FInfo_HandCode=@FInfo_HandCode, ");}
      if(failure_Information.FInfo_RespEntity1_IsChanged){sbParameter.Append("FInfo_RespEntity1=@FInfo_RespEntity1, ");}
      if(failure_Information.FInfo_RespEntity2_IsChanged){sbParameter.Append("FInfo_RespEntity2=@FInfo_RespEntity2, ");}
      if(failure_Information.FInfo_CmdCode_IsChanged){sbParameter.Append("FInfo_CmdCode=@FInfo_CmdCode, ");}
      if(failure_Information.FInfo_PartNo_IsChanged){sbParameter.Append("FInfo_PartNo=@FInfo_PartNo, ");}
      if(failure_Information.FInfo_PartName_IsChanged){sbParameter.Append("FInfo_PartName=@FInfo_PartName, ");}
      if(failure_Information.FInfo_PartSpec_IsChanged){sbParameter.Append("FInfo_PartSpec=@FInfo_PartSpec, ");}
      if(failure_Information.FInfo_Num_IsChanged){sbParameter.Append("FInfo_Num=@FInfo_Num, ");}
      if(failure_Information.FInfo_ProdNo_IsChanged){sbParameter.Append("FInfo_ProdNo=@FInfo_ProdNo, ");}
      if(failure_Information.FInfo_FindNode_IsChanged){sbParameter.Append("FInfo_FindNode=@FInfo_FindNode, ");}
      if(failure_Information.FInfo_FindNodeName_IsChanged){sbParameter.Append("FInfo_FindNodeName=@FInfo_FindNodeName, ");}
      if(failure_Information.FInfo_RespNode_IsChanged){sbParameter.Append("FInfo_RespNode=@FInfo_RespNode, ");}
      if(failure_Information.FInfo_RespEntity_IsChanged){sbParameter.Append("FInfo_RespEntity=@FInfo_RespEntity, ");}
      if(failure_Information.FInfo_TechReq_IsChanged){sbParameter.Append("FInfo_TechReq=@FInfo_TechReq, ");}
      if(failure_Information.FInfo_InCompetent_IsChanged){sbParameter.Append("FInfo_InCompetent=@FInfo_InCompetent, ");}
      if(failure_Information.FInfo_Owner_IsChanged){sbParameter.Append("FInfo_Owner=@FInfo_Owner, ");}
      if(failure_Information.FInfo_Date_IsChanged){sbParameter.Append("FInfo_Date=@FInfo_Date, ");}
      if(failure_Information.FInfo_Process_IsChanged){sbParameter.Append("FInfo_Process=@FInfo_Process, ");}
      if(failure_Information.FInfo_Stat_IsChanged){sbParameter.Append("FInfo_Stat=@FInfo_Stat, ");}
      if(failure_Information.FInfo_IsCancel_IsChanged){sbParameter.Append("FInfo_IsCancel=@FInfo_IsCancel, ");}
      if(failure_Information.FInfo_CancelPep_IsChanged){sbParameter.Append("FInfo_CancelPep=@FInfo_CancelPep, ");}
      if(failure_Information.FInfo_CancelDate_IsChanged){sbParameter.Append("FInfo_CancelDate=@FInfo_CancelDate, ");}
      if(failure_Information.FInfo_CancelDesp_IsChanged){sbParameter.Append("FInfo_CancelDesp=@FInfo_CancelDesp, ");}
      if(failure_Information.FInfo_IsClaim_IsChanged){sbParameter.Append("FInfo_IsClaim=@FInfo_IsClaim, ");}
      if(failure_Information.FInfo_ClaimDesp_IsChanged){sbParameter.Append("FInfo_ClaimDesp=@FInfo_ClaimDesp, ");}
      if(failure_Information.FInfo_ClaimPep_IsChanged){sbParameter.Append("FInfo_ClaimPep=@FInfo_ClaimPep, ");}
      if(failure_Information.FInfo_ClaimDate_IsChanged){sbParameter.Append("FInfo_ClaimDate=@FInfo_ClaimDate, ");}
      if(failure_Information.FInfo_Reason_IsChanged){sbParameter.Append("FInfo_Reason=@FInfo_Reason, ");}
      if(failure_Information.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(failure_Information.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(failure_Information.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(failure_Information.FInfo_Udef1_IsChanged){sbParameter.Append("FInfo_Udef1=@FInfo_Udef1, ");}
      if(failure_Information.FInfo_Udef2_IsChanged){sbParameter.Append("FInfo_Udef2=@FInfo_Udef2, ");}
      if(failure_Information.FInfo_IsPrint_IsChanged){sbParameter.Append("FInfo_IsPrint=@FInfo_IsPrint, ");}
      if(failure_Information.FInfo_RespNodeName_IsChanged){sbParameter.Append("FInfo_RespNodeName=@FInfo_RespNodeName, ");}
      if(failure_Information.FInfo_RespEntityName_IsChanged){sbParameter.Append("FInfo_RespEntityName=@FInfo_RespEntityName, ");}
      if(failure_Information.FInfo_Creator_IsChanged){sbParameter.Append("FInfo_Creator=@FInfo_Creator, ");}
      if(failure_Information.FInfo_CreatorCode_IsChanged){sbParameter.Append("FInfo_CreatorCode=@FInfo_CreatorCode, ");}
      if(failure_Information.FInfo_CreateTime_IsChanged){sbParameter.Append("FInfo_CreateTime=@FInfo_CreateTime, ");}
      if(failure_Information.FInfo_RelationCode_IsChanged){sbParameter.Append("FInfo_RelationCode=@FInfo_RelationCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FInfo_ID=@FInfo_ID; " );
      string sql=sb.ToString();
         if(failure_Information.FInfo_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Code))
         {
            idb.AddParameter("@FInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Code", failure_Information.FInfo_Code);
         }
          }
         if(failure_Information.FInfo_CustomerCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_CustomerCode))
         {
            idb.AddParameter("@FInfo_CustomerCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CustomerCode", failure_Information.FInfo_CustomerCode);
         }
          }
         if(failure_Information.FInfo_HandCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_HandCode))
         {
            idb.AddParameter("@FInfo_HandCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_HandCode", failure_Information.FInfo_HandCode);
         }
          }
         if(failure_Information.FInfo_RespEntity1_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity1))
         {
            idb.AddParameter("@FInfo_RespEntity1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity1", failure_Information.FInfo_RespEntity1);
         }
          }
         if(failure_Information.FInfo_RespEntity2_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity2))
         {
            idb.AddParameter("@FInfo_RespEntity2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity2", failure_Information.FInfo_RespEntity2);
         }
          }
         if(failure_Information.FInfo_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_CmdCode))
         {
            idb.AddParameter("@FInfo_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CmdCode", failure_Information.FInfo_CmdCode);
         }
          }
         if(failure_Information.FInfo_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartNo))
         {
            idb.AddParameter("@FInfo_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartNo", failure_Information.FInfo_PartNo);
         }
          }
         if(failure_Information.FInfo_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartName))
         {
            idb.AddParameter("@FInfo_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartName", failure_Information.FInfo_PartName);
         }
          }
         if(failure_Information.FInfo_PartSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_PartSpec))
         {
            idb.AddParameter("@FInfo_PartSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_PartSpec", failure_Information.FInfo_PartSpec);
         }
          }
         if(failure_Information.FInfo_Num_IsChanged)
         {
         if (failure_Information.FInfo_Num == 0)
         {
            idb.AddParameter("@FInfo_Num", 0);
         }
         else
         {
            idb.AddParameter("@FInfo_Num", failure_Information.FInfo_Num);
         }
          }
         if(failure_Information.FInfo_ProdNo_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_ProdNo))
         {
            idb.AddParameter("@FInfo_ProdNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ProdNo", failure_Information.FInfo_ProdNo);
         }
          }
         if(failure_Information.FInfo_FindNode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_FindNode))
         {
            idb.AddParameter("@FInfo_FindNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_FindNode", failure_Information.FInfo_FindNode);
         }
          }
         if(failure_Information.FInfo_FindNodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_FindNodeName))
         {
            idb.AddParameter("@FInfo_FindNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_FindNodeName", failure_Information.FInfo_FindNodeName);
         }
          }
         if(failure_Information.FInfo_RespNode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespNode))
         {
            idb.AddParameter("@FInfo_RespNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespNode", failure_Information.FInfo_RespNode);
         }
          }
         if(failure_Information.FInfo_RespEntity_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntity))
         {
            idb.AddParameter("@FInfo_RespEntity", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntity", failure_Information.FInfo_RespEntity);
         }
          }
         if(failure_Information.FInfo_TechReq_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_TechReq))
         {
            idb.AddParameter("@FInfo_TechReq", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_TechReq", failure_Information.FInfo_TechReq);
         }
          }
         if(failure_Information.FInfo_InCompetent_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_InCompetent))
         {
            idb.AddParameter("@FInfo_InCompetent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_InCompetent", failure_Information.FInfo_InCompetent);
         }
          }
         if(failure_Information.FInfo_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Owner))
         {
            idb.AddParameter("@FInfo_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Owner", failure_Information.FInfo_Owner);
         }
          }
         if(failure_Information.FInfo_Date_IsChanged)
         {
         if (failure_Information.FInfo_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Date", failure_Information.FInfo_Date);
         }
          }
         if(failure_Information.FInfo_Process_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Process))
         {
            idb.AddParameter("@FInfo_Process", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Process", failure_Information.FInfo_Process);
         }
          }
         if(failure_Information.FInfo_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Stat))
         {
            idb.AddParameter("@FInfo_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Stat", failure_Information.FInfo_Stat);
         }
          }
         if(failure_Information.FInfo_IsCancel_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsCancel))
         {
            idb.AddParameter("@FInfo_IsCancel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsCancel", failure_Information.FInfo_IsCancel);
         }
          }
         if(failure_Information.FInfo_CancelPep_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_CancelPep))
         {
            idb.AddParameter("@FInfo_CancelPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelPep", failure_Information.FInfo_CancelPep);
         }
          }
         if(failure_Information.FInfo_CancelDate_IsChanged)
         {
         if (failure_Information.FInfo_CancelDate == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_CancelDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelDate", failure_Information.FInfo_CancelDate);
         }
          }
         if(failure_Information.FInfo_CancelDesp_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_CancelDesp))
         {
            idb.AddParameter("@FInfo_CancelDesp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CancelDesp", failure_Information.FInfo_CancelDesp);
         }
          }
         if(failure_Information.FInfo_IsClaim_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsClaim))
         {
            idb.AddParameter("@FInfo_IsClaim", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsClaim", failure_Information.FInfo_IsClaim);
         }
          }
         if(failure_Information.FInfo_ClaimDesp_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_ClaimDesp))
         {
            idb.AddParameter("@FInfo_ClaimDesp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimDesp", failure_Information.FInfo_ClaimDesp);
         }
          }
         if(failure_Information.FInfo_ClaimPep_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_ClaimPep))
         {
            idb.AddParameter("@FInfo_ClaimPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimPep", failure_Information.FInfo_ClaimPep);
         }
          }
         if(failure_Information.FInfo_ClaimDate_IsChanged)
         {
         if (failure_Information.FInfo_ClaimDate == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_ClaimDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ClaimDate", failure_Information.FInfo_ClaimDate);
         }
          }
         if(failure_Information.FInfo_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Reason))
         {
            idb.AddParameter("@FInfo_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Reason", failure_Information.FInfo_Reason);
         }
          }
         if(failure_Information.Stat_IsChanged)
         {
         if (failure_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", failure_Information.Stat);
         }
          }
         if(failure_Information.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", failure_Information.AuditStat);
         }
          }
         if(failure_Information.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", failure_Information.AuditCurAudit);
         }
          }
         if(failure_Information.FInfo_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Udef1))
         {
            idb.AddParameter("@FInfo_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Udef1", failure_Information.FInfo_Udef1);
         }
          }
         if(failure_Information.FInfo_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Udef2))
         {
            idb.AddParameter("@FInfo_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Udef2", failure_Information.FInfo_Udef2);
         }
          }
         if(failure_Information.FInfo_IsPrint_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_IsPrint))
         {
            idb.AddParameter("@FInfo_IsPrint", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_IsPrint", failure_Information.FInfo_IsPrint);
         }
          }
         if(failure_Information.FInfo_RespNodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespNodeName))
         {
            idb.AddParameter("@FInfo_RespNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespNodeName", failure_Information.FInfo_RespNodeName);
         }
          }
         if(failure_Information.FInfo_RespEntityName_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RespEntityName))
         {
            idb.AddParameter("@FInfo_RespEntityName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RespEntityName", failure_Information.FInfo_RespEntityName);
         }
          }
         if(failure_Information.FInfo_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_Creator))
         {
            idb.AddParameter("@FInfo_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_Creator", failure_Information.FInfo_Creator);
         }
          }
         if(failure_Information.FInfo_CreatorCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_CreatorCode))
         {
            idb.AddParameter("@FInfo_CreatorCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CreatorCode", failure_Information.FInfo_CreatorCode);
         }
          }
         if(failure_Information.FInfo_CreateTime_IsChanged)
         {
         if (failure_Information.FInfo_CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@FInfo_CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_CreateTime", failure_Information.FInfo_CreateTime);
         }
          }
         if(failure_Information.FInfo_RelationCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Information.FInfo_RelationCode))
         {
            idb.AddParameter("@FInfo_RelationCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_RelationCode", failure_Information.FInfo_RelationCode);
         }
          }

         idb.AddParameter("@FInfo_ID", failure_Information.FInfo_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Failure_Information对象(即:一条记录
      /// </summary>
      public int Delete(decimal fInfo_ID)
      {
         string sql = "DELETE Failure_Information WHERE 1=1  AND FInfo_ID=@FInfo_ID ";
         idb.AddParameter("@FInfo_ID", fInfo_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Failure_Information对象(即:一条记录
      /// </summary>
      public Failure_Information GetByKey(decimal fInfo_ID)
      {
         Failure_Information failure_Information = new Failure_Information();
         string sql = "SELECT  FInfo_ID,FInfo_Code,FInfo_CustomerCode,FInfo_HandCode,FInfo_RespEntity1,FInfo_RespEntity2,FInfo_CmdCode,FInfo_PartNo,FInfo_PartName,FInfo_PartSpec,FInfo_Num,FInfo_ProdNo,FInfo_FindNode,FInfo_FindNodeName,FInfo_RespNode,FInfo_RespEntity,FInfo_TechReq,FInfo_InCompetent,FInfo_Owner,FInfo_Date,FInfo_Process,FInfo_Stat,FInfo_IsCancel,FInfo_CancelPep,FInfo_CancelDate,FInfo_CancelDesp,FInfo_IsClaim,FInfo_ClaimDesp,FInfo_ClaimPep,FInfo_ClaimDate,FInfo_Reason,Stat,AuditStat,AuditCurAudit,FInfo_Udef1,FInfo_Udef2,FInfo_IsPrint,FInfo_RespNodeName,FInfo_RespEntityName,FInfo_Creator,FInfo_CreatorCode,FInfo_CreateTime,FInfo_RelationCode FROM Failure_Information WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FInfo_ID=@FInfo_ID ";
         idb.AddParameter("@FInfo_ID", fInfo_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FInfo_ID"] != DBNull.Value) failure_Information.FInfo_ID = Convert.ToDecimal(dr["FInfo_ID"]);
            if (dr["FInfo_Code"] != DBNull.Value) failure_Information.FInfo_Code = Convert.ToString(dr["FInfo_Code"]);
            if (dr["FInfo_CustomerCode"] != DBNull.Value) failure_Information.FInfo_CustomerCode = Convert.ToString(dr["FInfo_CustomerCode"]);
            if (dr["FInfo_HandCode"] != DBNull.Value) failure_Information.FInfo_HandCode = Convert.ToString(dr["FInfo_HandCode"]);
            if (dr["FInfo_RespEntity1"] != DBNull.Value) failure_Information.FInfo_RespEntity1 = Convert.ToString(dr["FInfo_RespEntity1"]);
            if (dr["FInfo_RespEntity2"] != DBNull.Value) failure_Information.FInfo_RespEntity2 = Convert.ToString(dr["FInfo_RespEntity2"]);
            if (dr["FInfo_CmdCode"] != DBNull.Value) failure_Information.FInfo_CmdCode = Convert.ToString(dr["FInfo_CmdCode"]);
            if (dr["FInfo_PartNo"] != DBNull.Value) failure_Information.FInfo_PartNo = Convert.ToString(dr["FInfo_PartNo"]);
            if (dr["FInfo_PartName"] != DBNull.Value) failure_Information.FInfo_PartName = Convert.ToString(dr["FInfo_PartName"]);
            if (dr["FInfo_PartSpec"] != DBNull.Value) failure_Information.FInfo_PartSpec = Convert.ToString(dr["FInfo_PartSpec"]);
            if (dr["FInfo_Num"] != DBNull.Value) failure_Information.FInfo_Num = Convert.ToInt32(dr["FInfo_Num"]);
            if (dr["FInfo_ProdNo"] != DBNull.Value) failure_Information.FInfo_ProdNo = Convert.ToString(dr["FInfo_ProdNo"]);
            if (dr["FInfo_FindNode"] != DBNull.Value) failure_Information.FInfo_FindNode = Convert.ToString(dr["FInfo_FindNode"]);
            if (dr["FInfo_FindNodeName"] != DBNull.Value) failure_Information.FInfo_FindNodeName = Convert.ToString(dr["FInfo_FindNodeName"]);
            if (dr["FInfo_RespNode"] != DBNull.Value) failure_Information.FInfo_RespNode = Convert.ToString(dr["FInfo_RespNode"]);
            if (dr["FInfo_RespEntity"] != DBNull.Value) failure_Information.FInfo_RespEntity = Convert.ToString(dr["FInfo_RespEntity"]);
            if (dr["FInfo_TechReq"] != DBNull.Value) failure_Information.FInfo_TechReq = Convert.ToString(dr["FInfo_TechReq"]);
            if (dr["FInfo_InCompetent"] != DBNull.Value) failure_Information.FInfo_InCompetent = Convert.ToString(dr["FInfo_InCompetent"]);
            if (dr["FInfo_Owner"] != DBNull.Value) failure_Information.FInfo_Owner = Convert.ToString(dr["FInfo_Owner"]);
            if (dr["FInfo_Date"] != DBNull.Value) failure_Information.FInfo_Date = Convert.ToDateTime(dr["FInfo_Date"]);
            if (dr["FInfo_Process"] != DBNull.Value) failure_Information.FInfo_Process = Convert.ToString(dr["FInfo_Process"]);
            if (dr["FInfo_Stat"] != DBNull.Value) failure_Information.FInfo_Stat = Convert.ToString(dr["FInfo_Stat"]);
            if (dr["FInfo_IsCancel"] != DBNull.Value) failure_Information.FInfo_IsCancel = Convert.ToString(dr["FInfo_IsCancel"]);
            if (dr["FInfo_CancelPep"] != DBNull.Value) failure_Information.FInfo_CancelPep = Convert.ToString(dr["FInfo_CancelPep"]);
            if (dr["FInfo_CancelDate"] != DBNull.Value) failure_Information.FInfo_CancelDate = Convert.ToDateTime(dr["FInfo_CancelDate"]);
            if (dr["FInfo_CancelDesp"] != DBNull.Value) failure_Information.FInfo_CancelDesp = Convert.ToString(dr["FInfo_CancelDesp"]);
            if (dr["FInfo_IsClaim"] != DBNull.Value) failure_Information.FInfo_IsClaim = Convert.ToString(dr["FInfo_IsClaim"]);
            if (dr["FInfo_ClaimDesp"] != DBNull.Value) failure_Information.FInfo_ClaimDesp = Convert.ToString(dr["FInfo_ClaimDesp"]);
            if (dr["FInfo_ClaimPep"] != DBNull.Value) failure_Information.FInfo_ClaimPep = Convert.ToString(dr["FInfo_ClaimPep"]);
            if (dr["FInfo_ClaimDate"] != DBNull.Value) failure_Information.FInfo_ClaimDate = Convert.ToDateTime(dr["FInfo_ClaimDate"]);
            if (dr["FInfo_Reason"] != DBNull.Value) failure_Information.FInfo_Reason = Convert.ToString(dr["FInfo_Reason"]);
            if (dr["Stat"] != DBNull.Value) failure_Information.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) failure_Information.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) failure_Information.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["FInfo_Udef1"] != DBNull.Value) failure_Information.FInfo_Udef1 = Convert.ToString(dr["FInfo_Udef1"]);
            if (dr["FInfo_Udef2"] != DBNull.Value) failure_Information.FInfo_Udef2 = Convert.ToString(dr["FInfo_Udef2"]);
            if (dr["FInfo_IsPrint"] != DBNull.Value) failure_Information.FInfo_IsPrint = Convert.ToString(dr["FInfo_IsPrint"]);
            if (dr["FInfo_RespNodeName"] != DBNull.Value) failure_Information.FInfo_RespNodeName = Convert.ToString(dr["FInfo_RespNodeName"]);
            if (dr["FInfo_RespEntityName"] != DBNull.Value) failure_Information.FInfo_RespEntityName = Convert.ToString(dr["FInfo_RespEntityName"]);
            if (dr["FInfo_Creator"] != DBNull.Value) failure_Information.FInfo_Creator = Convert.ToString(dr["FInfo_Creator"]);
            if (dr["FInfo_CreatorCode"] != DBNull.Value) failure_Information.FInfo_CreatorCode = Convert.ToString(dr["FInfo_CreatorCode"]);
            if (dr["FInfo_CreateTime"] != DBNull.Value) failure_Information.FInfo_CreateTime = Convert.ToDateTime(dr["FInfo_CreateTime"]);
            if (dr["FInfo_RelationCode"] != DBNull.Value) failure_Information.FInfo_RelationCode = Convert.ToString(dr["FInfo_RelationCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return failure_Information;
      }
      /// <summary>
      /// 获取指定的Failure_Information对象集合
      /// </summary>
      public List<Failure_Information> GetListByWhere(string strCondition)
      {
         List<Failure_Information> ret = new List<Failure_Information>();
         string sql = "SELECT  FInfo_ID,FInfo_Code,FInfo_CustomerCode,FInfo_HandCode,FInfo_RespEntity1,FInfo_RespEntity2,FInfo_CmdCode,FInfo_PartNo,FInfo_PartName,FInfo_PartSpec,FInfo_Num,FInfo_ProdNo,FInfo_FindNode,FInfo_FindNodeName,FInfo_RespNode,FInfo_RespEntity,FInfo_TechReq,FInfo_InCompetent,FInfo_Owner,FInfo_Date,FInfo_Process,FInfo_Stat,FInfo_IsCancel,FInfo_CancelPep,FInfo_CancelDate,FInfo_CancelDesp,FInfo_IsClaim,FInfo_ClaimDesp,FInfo_ClaimPep,FInfo_ClaimDate,FInfo_Reason,Stat,AuditStat,AuditCurAudit,FInfo_Udef1,FInfo_Udef2,FInfo_IsPrint,FInfo_RespNodeName,FInfo_RespEntityName,FInfo_Creator,FInfo_CreatorCode,FInfo_CreateTime,FInfo_RelationCode FROM Failure_Information WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Failure_Information failure_Information = new Failure_Information();
            if (dr["FInfo_ID"] != DBNull.Value) failure_Information.FInfo_ID = Convert.ToDecimal(dr["FInfo_ID"]);
            if (dr["FInfo_Code"] != DBNull.Value) failure_Information.FInfo_Code = Convert.ToString(dr["FInfo_Code"]);
            if (dr["FInfo_CustomerCode"] != DBNull.Value) failure_Information.FInfo_CustomerCode = Convert.ToString(dr["FInfo_CustomerCode"]);
            if (dr["FInfo_HandCode"] != DBNull.Value) failure_Information.FInfo_HandCode = Convert.ToString(dr["FInfo_HandCode"]);
            if (dr["FInfo_RespEntity1"] != DBNull.Value) failure_Information.FInfo_RespEntity1 = Convert.ToString(dr["FInfo_RespEntity1"]);
            if (dr["FInfo_RespEntity2"] != DBNull.Value) failure_Information.FInfo_RespEntity2 = Convert.ToString(dr["FInfo_RespEntity2"]);
            if (dr["FInfo_CmdCode"] != DBNull.Value) failure_Information.FInfo_CmdCode = Convert.ToString(dr["FInfo_CmdCode"]);
            if (dr["FInfo_PartNo"] != DBNull.Value) failure_Information.FInfo_PartNo = Convert.ToString(dr["FInfo_PartNo"]);
            if (dr["FInfo_PartName"] != DBNull.Value) failure_Information.FInfo_PartName = Convert.ToString(dr["FInfo_PartName"]);
            if (dr["FInfo_PartSpec"] != DBNull.Value) failure_Information.FInfo_PartSpec = Convert.ToString(dr["FInfo_PartSpec"]);
            if (dr["FInfo_Num"] != DBNull.Value) failure_Information.FInfo_Num = Convert.ToInt32(dr["FInfo_Num"]);
            if (dr["FInfo_ProdNo"] != DBNull.Value) failure_Information.FInfo_ProdNo = Convert.ToString(dr["FInfo_ProdNo"]);
            if (dr["FInfo_FindNode"] != DBNull.Value) failure_Information.FInfo_FindNode = Convert.ToString(dr["FInfo_FindNode"]);
            if (dr["FInfo_FindNodeName"] != DBNull.Value) failure_Information.FInfo_FindNodeName = Convert.ToString(dr["FInfo_FindNodeName"]);
            if (dr["FInfo_RespNode"] != DBNull.Value) failure_Information.FInfo_RespNode = Convert.ToString(dr["FInfo_RespNode"]);
            if (dr["FInfo_RespEntity"] != DBNull.Value) failure_Information.FInfo_RespEntity = Convert.ToString(dr["FInfo_RespEntity"]);
            if (dr["FInfo_TechReq"] != DBNull.Value) failure_Information.FInfo_TechReq = Convert.ToString(dr["FInfo_TechReq"]);
            if (dr["FInfo_InCompetent"] != DBNull.Value) failure_Information.FInfo_InCompetent = Convert.ToString(dr["FInfo_InCompetent"]);
            if (dr["FInfo_Owner"] != DBNull.Value) failure_Information.FInfo_Owner = Convert.ToString(dr["FInfo_Owner"]);
            if (dr["FInfo_Date"] != DBNull.Value) failure_Information.FInfo_Date = Convert.ToDateTime(dr["FInfo_Date"]);
            if (dr["FInfo_Process"] != DBNull.Value) failure_Information.FInfo_Process = Convert.ToString(dr["FInfo_Process"]);
            if (dr["FInfo_Stat"] != DBNull.Value) failure_Information.FInfo_Stat = Convert.ToString(dr["FInfo_Stat"]);
            if (dr["FInfo_IsCancel"] != DBNull.Value) failure_Information.FInfo_IsCancel = Convert.ToString(dr["FInfo_IsCancel"]);
            if (dr["FInfo_CancelPep"] != DBNull.Value) failure_Information.FInfo_CancelPep = Convert.ToString(dr["FInfo_CancelPep"]);
            if (dr["FInfo_CancelDate"] != DBNull.Value) failure_Information.FInfo_CancelDate = Convert.ToDateTime(dr["FInfo_CancelDate"]);
            if (dr["FInfo_CancelDesp"] != DBNull.Value) failure_Information.FInfo_CancelDesp = Convert.ToString(dr["FInfo_CancelDesp"]);
            if (dr["FInfo_IsClaim"] != DBNull.Value) failure_Information.FInfo_IsClaim = Convert.ToString(dr["FInfo_IsClaim"]);
            if (dr["FInfo_ClaimDesp"] != DBNull.Value) failure_Information.FInfo_ClaimDesp = Convert.ToString(dr["FInfo_ClaimDesp"]);
            if (dr["FInfo_ClaimPep"] != DBNull.Value) failure_Information.FInfo_ClaimPep = Convert.ToString(dr["FInfo_ClaimPep"]);
            if (dr["FInfo_ClaimDate"] != DBNull.Value) failure_Information.FInfo_ClaimDate = Convert.ToDateTime(dr["FInfo_ClaimDate"]);
            if (dr["FInfo_Reason"] != DBNull.Value) failure_Information.FInfo_Reason = Convert.ToString(dr["FInfo_Reason"]);
            if (dr["Stat"] != DBNull.Value) failure_Information.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) failure_Information.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) failure_Information.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["FInfo_Udef1"] != DBNull.Value) failure_Information.FInfo_Udef1 = Convert.ToString(dr["FInfo_Udef1"]);
            if (dr["FInfo_Udef2"] != DBNull.Value) failure_Information.FInfo_Udef2 = Convert.ToString(dr["FInfo_Udef2"]);
            if (dr["FInfo_IsPrint"] != DBNull.Value) failure_Information.FInfo_IsPrint = Convert.ToString(dr["FInfo_IsPrint"]);
            if (dr["FInfo_RespNodeName"] != DBNull.Value) failure_Information.FInfo_RespNodeName = Convert.ToString(dr["FInfo_RespNodeName"]);
            if (dr["FInfo_RespEntityName"] != DBNull.Value) failure_Information.FInfo_RespEntityName = Convert.ToString(dr["FInfo_RespEntityName"]);
            if (dr["FInfo_Creator"] != DBNull.Value) failure_Information.FInfo_Creator = Convert.ToString(dr["FInfo_Creator"]);
            if (dr["FInfo_CreatorCode"] != DBNull.Value) failure_Information.FInfo_CreatorCode = Convert.ToString(dr["FInfo_CreatorCode"]);
            if (dr["FInfo_CreateTime"] != DBNull.Value) failure_Information.FInfo_CreateTime = Convert.ToDateTime(dr["FInfo_CreateTime"]);
            if (dr["FInfo_RelationCode"] != DBNull.Value) failure_Information.FInfo_RelationCode = Convert.ToString(dr["FInfo_RelationCode"]);
            ret.Add(failure_Information);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Failure_Information对象(即:一条记录
      /// </summary>
      public List<Failure_Information> GetAll()
      {
         List<Failure_Information> ret = new List<Failure_Information>();
         string sql = "SELECT  FInfo_ID,FInfo_Code,FInfo_CustomerCode,FInfo_HandCode,FInfo_RespEntity1,FInfo_RespEntity2,FInfo_CmdCode,FInfo_PartNo,FInfo_PartName,FInfo_PartSpec,FInfo_Num,FInfo_ProdNo,FInfo_FindNode,FInfo_FindNodeName,FInfo_RespNode,FInfo_RespEntity,FInfo_TechReq,FInfo_InCompetent,FInfo_Owner,FInfo_Date,FInfo_Process,FInfo_Stat,FInfo_IsCancel,FInfo_CancelPep,FInfo_CancelDate,FInfo_CancelDesp,FInfo_IsClaim,FInfo_ClaimDesp,FInfo_ClaimPep,FInfo_ClaimDate,FInfo_Reason,Stat,AuditStat,AuditCurAudit,FInfo_Udef1,FInfo_Udef2,FInfo_IsPrint,FInfo_RespNodeName,FInfo_RespEntityName,FInfo_Creator,FInfo_CreatorCode,FInfo_CreateTime,FInfo_RelationCode FROM Failure_Information where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Failure_Information failure_Information = new Failure_Information();
            if (dr["FInfo_ID"] != DBNull.Value) failure_Information.FInfo_ID = Convert.ToDecimal(dr["FInfo_ID"]);
            if (dr["FInfo_Code"] != DBNull.Value) failure_Information.FInfo_Code = Convert.ToString(dr["FInfo_Code"]);
            if (dr["FInfo_CustomerCode"] != DBNull.Value) failure_Information.FInfo_CustomerCode = Convert.ToString(dr["FInfo_CustomerCode"]);
            if (dr["FInfo_HandCode"] != DBNull.Value) failure_Information.FInfo_HandCode = Convert.ToString(dr["FInfo_HandCode"]);
            if (dr["FInfo_RespEntity1"] != DBNull.Value) failure_Information.FInfo_RespEntity1 = Convert.ToString(dr["FInfo_RespEntity1"]);
            if (dr["FInfo_RespEntity2"] != DBNull.Value) failure_Information.FInfo_RespEntity2 = Convert.ToString(dr["FInfo_RespEntity2"]);
            if (dr["FInfo_CmdCode"] != DBNull.Value) failure_Information.FInfo_CmdCode = Convert.ToString(dr["FInfo_CmdCode"]);
            if (dr["FInfo_PartNo"] != DBNull.Value) failure_Information.FInfo_PartNo = Convert.ToString(dr["FInfo_PartNo"]);
            if (dr["FInfo_PartName"] != DBNull.Value) failure_Information.FInfo_PartName = Convert.ToString(dr["FInfo_PartName"]);
            if (dr["FInfo_PartSpec"] != DBNull.Value) failure_Information.FInfo_PartSpec = Convert.ToString(dr["FInfo_PartSpec"]);
            if (dr["FInfo_Num"] != DBNull.Value) failure_Information.FInfo_Num = Convert.ToInt32(dr["FInfo_Num"]);
            if (dr["FInfo_ProdNo"] != DBNull.Value) failure_Information.FInfo_ProdNo = Convert.ToString(dr["FInfo_ProdNo"]);
            if (dr["FInfo_FindNode"] != DBNull.Value) failure_Information.FInfo_FindNode = Convert.ToString(dr["FInfo_FindNode"]);
            if (dr["FInfo_FindNodeName"] != DBNull.Value) failure_Information.FInfo_FindNodeName = Convert.ToString(dr["FInfo_FindNodeName"]);
            if (dr["FInfo_RespNode"] != DBNull.Value) failure_Information.FInfo_RespNode = Convert.ToString(dr["FInfo_RespNode"]);
            if (dr["FInfo_RespEntity"] != DBNull.Value) failure_Information.FInfo_RespEntity = Convert.ToString(dr["FInfo_RespEntity"]);
            if (dr["FInfo_TechReq"] != DBNull.Value) failure_Information.FInfo_TechReq = Convert.ToString(dr["FInfo_TechReq"]);
            if (dr["FInfo_InCompetent"] != DBNull.Value) failure_Information.FInfo_InCompetent = Convert.ToString(dr["FInfo_InCompetent"]);
            if (dr["FInfo_Owner"] != DBNull.Value) failure_Information.FInfo_Owner = Convert.ToString(dr["FInfo_Owner"]);
            if (dr["FInfo_Date"] != DBNull.Value) failure_Information.FInfo_Date = Convert.ToDateTime(dr["FInfo_Date"]);
            if (dr["FInfo_Process"] != DBNull.Value) failure_Information.FInfo_Process = Convert.ToString(dr["FInfo_Process"]);
            if (dr["FInfo_Stat"] != DBNull.Value) failure_Information.FInfo_Stat = Convert.ToString(dr["FInfo_Stat"]);
            if (dr["FInfo_IsCancel"] != DBNull.Value) failure_Information.FInfo_IsCancel = Convert.ToString(dr["FInfo_IsCancel"]);
            if (dr["FInfo_CancelPep"] != DBNull.Value) failure_Information.FInfo_CancelPep = Convert.ToString(dr["FInfo_CancelPep"]);
            if (dr["FInfo_CancelDate"] != DBNull.Value) failure_Information.FInfo_CancelDate = Convert.ToDateTime(dr["FInfo_CancelDate"]);
            if (dr["FInfo_CancelDesp"] != DBNull.Value) failure_Information.FInfo_CancelDesp = Convert.ToString(dr["FInfo_CancelDesp"]);
            if (dr["FInfo_IsClaim"] != DBNull.Value) failure_Information.FInfo_IsClaim = Convert.ToString(dr["FInfo_IsClaim"]);
            if (dr["FInfo_ClaimDesp"] != DBNull.Value) failure_Information.FInfo_ClaimDesp = Convert.ToString(dr["FInfo_ClaimDesp"]);
            if (dr["FInfo_ClaimPep"] != DBNull.Value) failure_Information.FInfo_ClaimPep = Convert.ToString(dr["FInfo_ClaimPep"]);
            if (dr["FInfo_ClaimDate"] != DBNull.Value) failure_Information.FInfo_ClaimDate = Convert.ToDateTime(dr["FInfo_ClaimDate"]);
            if (dr["FInfo_Reason"] != DBNull.Value) failure_Information.FInfo_Reason = Convert.ToString(dr["FInfo_Reason"]);
            if (dr["Stat"] != DBNull.Value) failure_Information.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) failure_Information.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) failure_Information.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["FInfo_Udef1"] != DBNull.Value) failure_Information.FInfo_Udef1 = Convert.ToString(dr["FInfo_Udef1"]);
            if (dr["FInfo_Udef2"] != DBNull.Value) failure_Information.FInfo_Udef2 = Convert.ToString(dr["FInfo_Udef2"]);
            if (dr["FInfo_IsPrint"] != DBNull.Value) failure_Information.FInfo_IsPrint = Convert.ToString(dr["FInfo_IsPrint"]);
            if (dr["FInfo_RespNodeName"] != DBNull.Value) failure_Information.FInfo_RespNodeName = Convert.ToString(dr["FInfo_RespNodeName"]);
            if (dr["FInfo_RespEntityName"] != DBNull.Value) failure_Information.FInfo_RespEntityName = Convert.ToString(dr["FInfo_RespEntityName"]);
            if (dr["FInfo_Creator"] != DBNull.Value) failure_Information.FInfo_Creator = Convert.ToString(dr["FInfo_Creator"]);
            if (dr["FInfo_CreatorCode"] != DBNull.Value) failure_Information.FInfo_CreatorCode = Convert.ToString(dr["FInfo_CreatorCode"]);
            if (dr["FInfo_CreateTime"] != DBNull.Value) failure_Information.FInfo_CreateTime = Convert.ToDateTime(dr["FInfo_CreateTime"]);
            if (dr["FInfo_RelationCode"] != DBNull.Value) failure_Information.FInfo_RelationCode = Convert.ToString(dr["FInfo_RelationCode"]);
            ret.Add(failure_Information);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
