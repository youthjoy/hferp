using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Failure_Information
   {
      private decimal fInfo_ID;
      private bool fInfo_ID_IsChanged=false;
      public decimal FInfo_ID
      {
         get{ return fInfo_ID; }
         set{ fInfo_ID = value; fInfo_ID_IsChanged=true; }
      }
      public bool FInfo_ID_IsChanged
      {
         get{ return fInfo_ID_IsChanged; }
         set{ fInfo_ID_IsChanged = value; }
      }
      /// <summary>
      /// 审理单编号
      /// </summary>
      private string fInfo_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_Code_IsChanged=false;
      /// <summary>
      /// 审理单编号
      /// </summary>
      public string FInfo_Code
      {
         get{ return fInfo_Code; }
         set{ fInfo_Code = value; fInfo_Code_IsChanged=true; }
      }
      /// <summary>
      /// 审理单编号
      /// </summary>
      public bool FInfo_Code_IsChanged
      {
         get{ return fInfo_Code_IsChanged; }
         set{ fInfo_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户审理单号
      /// </summary>
      private string fInfo_CustomerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_CustomerCode_IsChanged=false;
      /// <summary>
      /// 客户审理单号
      /// </summary>
      public string FInfo_CustomerCode
      {
         get{ return fInfo_CustomerCode; }
         set{ fInfo_CustomerCode = value; fInfo_CustomerCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户审理单号
      /// </summary>
      public bool FInfo_CustomerCode_IsChanged
      {
         get{ return fInfo_CustomerCode_IsChanged; }
         set{ fInfo_CustomerCode_IsChanged = value; }
      }
      /// <summary>
      /// 手工号
      /// </summary>
      private string fInfo_HandCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_HandCode_IsChanged=false;
      /// <summary>
      /// 手工号
      /// </summary>
      public string FInfo_HandCode
      {
         get{ return fInfo_HandCode; }
         set{ fInfo_HandCode = value; fInfo_HandCode_IsChanged=true; }
      }
      /// <summary>
      /// 手工号
      /// </summary>
      public bool FInfo_HandCode_IsChanged
      {
         get{ return fInfo_HandCode_IsChanged; }
         set{ fInfo_HandCode_IsChanged = value; }
      }
      /// <summary>
      /// 责任单位1
      /// </summary>
      private string fInfo_RespEntity1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_RespEntity1_IsChanged=false;
      /// <summary>
      /// 责任单位1
      /// </summary>
      public string FInfo_RespEntity1
      {
         get{ return fInfo_RespEntity1; }
         set{ fInfo_RespEntity1 = value; fInfo_RespEntity1_IsChanged=true; }
      }
      /// <summary>
      /// 责任单位1
      /// </summary>
      public bool FInfo_RespEntity1_IsChanged
      {
         get{ return fInfo_RespEntity1_IsChanged; }
         set{ fInfo_RespEntity1_IsChanged = value; }
      }
      /// <summary>
      /// 责任单位2
      /// </summary>
      private string fInfo_RespEntity2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_RespEntity2_IsChanged=false;
      /// <summary>
      /// 责任单位2
      /// </summary>
      public string FInfo_RespEntity2
      {
         get{ return fInfo_RespEntity2; }
         set{ fInfo_RespEntity2 = value; fInfo_RespEntity2_IsChanged=true; }
      }
      /// <summary>
      /// 责任单位2
      /// </summary>
      public bool FInfo_RespEntity2_IsChanged
      {
         get{ return fInfo_RespEntity2_IsChanged; }
         set{ fInfo_RespEntity2_IsChanged = value; }
      }
      /// <summary>
      /// 指令号
      /// </summary>
      private string fInfo_CmdCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_CmdCode_IsChanged=false;
      /// <summary>
      /// 指令号
      /// </summary>
      public string FInfo_CmdCode
      {
         get{ return fInfo_CmdCode; }
         set{ fInfo_CmdCode = value; fInfo_CmdCode_IsChanged=true; }
      }
      /// <summary>
      /// 指令号
      /// </summary>
      public bool FInfo_CmdCode_IsChanged
      {
         get{ return fInfo_CmdCode_IsChanged; }
         set{ fInfo_CmdCode_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string fInfo_PartNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_PartNo_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string FInfo_PartNo
      {
         get{ return fInfo_PartNo; }
         set{ fInfo_PartNo = value; fInfo_PartNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool FInfo_PartNo_IsChanged
      {
         get{ return fInfo_PartNo_IsChanged; }
         set{ fInfo_PartNo_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string fInfo_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string FInfo_PartName
      {
         get{ return fInfo_PartName; }
         set{ fInfo_PartName = value; fInfo_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool FInfo_PartName_IsChanged
      {
         get{ return fInfo_PartName_IsChanged; }
         set{ fInfo_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 零件材质
      /// </summary>
      private string fInfo_PartSpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_PartSpec_IsChanged=false;
      /// <summary>
      /// 零件材质
      /// </summary>
      public string FInfo_PartSpec
      {
         get{ return fInfo_PartSpec; }
         set{ fInfo_PartSpec = value; fInfo_PartSpec_IsChanged=true; }
      }
      /// <summary>
      /// 零件材质
      /// </summary>
      public bool FInfo_PartSpec_IsChanged
      {
         get{ return fInfo_PartSpec_IsChanged; }
         set{ fInfo_PartSpec_IsChanged = value; }
      }
      /// <summary>
      /// 不合格品数量
      /// </summary>
      private int fInfo_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_Num_IsChanged=false;
      /// <summary>
      /// 不合格品数量
      /// </summary>
      public int FInfo_Num
      {
         get{ return fInfo_Num; }
         set{ fInfo_Num = value; fInfo_Num_IsChanged=true; }
      }
      /// <summary>
      /// 不合格品数量
      /// </summary>
      public bool FInfo_Num_IsChanged
      {
         get{ return fInfo_Num_IsChanged; }
         set{ fInfo_Num_IsChanged = value; }
      }
      /// <summary>
      /// 零件编号
      /// </summary>
      private string fInfo_ProdNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_ProdNo_IsChanged=false;
      /// <summary>
      /// 零件编号
      /// </summary>
      public string FInfo_ProdNo
      {
         get{ return fInfo_ProdNo; }
         set{ fInfo_ProdNo = value; fInfo_ProdNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件编号
      /// </summary>
      public bool FInfo_ProdNo_IsChanged
      {
         get{ return fInfo_ProdNo_IsChanged; }
         set{ fInfo_ProdNo_IsChanged = value; }
      }
      /// <summary>
      /// 发现工序
      /// </summary>
      private string fInfo_FindNode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_FindNode_IsChanged=false;
      /// <summary>
      /// 发现工序
      /// </summary>
      public string FInfo_FindNode
      {
         get{ return fInfo_FindNode; }
         set{ fInfo_FindNode = value; fInfo_FindNode_IsChanged=true; }
      }
      /// <summary>
      /// 发现工序
      /// </summary>
      public bool FInfo_FindNode_IsChanged
      {
         get{ return fInfo_FindNode_IsChanged; }
         set{ fInfo_FindNode_IsChanged = value; }
      }
      /// <summary>
      /// 发现工序名称
      /// </summary>
      private string fInfo_FindNodeName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_FindNodeName_IsChanged=false;
      /// <summary>
      /// 发现工序名称
      /// </summary>
      public string FInfo_FindNodeName
      {
         get{ return fInfo_FindNodeName; }
         set{ fInfo_FindNodeName = value; fInfo_FindNodeName_IsChanged=true; }
      }
      /// <summary>
      /// 发现工序名称
      /// </summary>
      public bool FInfo_FindNodeName_IsChanged
      {
         get{ return fInfo_FindNodeName_IsChanged; }
         set{ fInfo_FindNodeName_IsChanged = value; }
      }
      /// <summary>
      /// 责任工序
      /// </summary>
      private string fInfo_RespNode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_RespNode_IsChanged=false;
      /// <summary>
      /// 责任工序
      /// </summary>
      public string FInfo_RespNode
      {
         get{ return fInfo_RespNode; }
         set{ fInfo_RespNode = value; fInfo_RespNode_IsChanged=true; }
      }
      /// <summary>
      /// 责任工序
      /// </summary>
      public bool FInfo_RespNode_IsChanged
      {
         get{ return fInfo_RespNode_IsChanged; }
         set{ fInfo_RespNode_IsChanged = value; }
      }
      /// <summary>
      /// 主要责任部门
      /// </summary>
      private string fInfo_RespEntity;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_RespEntity_IsChanged=false;
      /// <summary>
      /// 主要责任部门
      /// </summary>
      public string FInfo_RespEntity
      {
         get{ return fInfo_RespEntity; }
         set{ fInfo_RespEntity = value; fInfo_RespEntity_IsChanged=true; }
      }
      /// <summary>
      /// 主要责任部门
      /// </summary>
      public bool FInfo_RespEntity_IsChanged
      {
         get{ return fInfo_RespEntity_IsChanged; }
         set{ fInfo_RespEntity_IsChanged = value; }
      }
      /// <summary>
      /// 技术要求
      /// </summary>
      private string fInfo_TechReq;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_TechReq_IsChanged=false;
      /// <summary>
      /// 技术要求
      /// </summary>
      public string FInfo_TechReq
      {
         get{ return fInfo_TechReq; }
         set{ fInfo_TechReq = value; fInfo_TechReq_IsChanged=true; }
      }
      /// <summary>
      /// 技术要求
      /// </summary>
      public bool FInfo_TechReq_IsChanged
      {
         get{ return fInfo_TechReq_IsChanged; }
         set{ fInfo_TechReq_IsChanged = value; }
      }
      /// <summary>
      /// 不合格情况
      /// </summary>
      private string fInfo_InCompetent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_InCompetent_IsChanged=false;
      /// <summary>
      /// 不合格情况
      /// </summary>
      public string FInfo_InCompetent
      {
         get{ return fInfo_InCompetent; }
         set{ fInfo_InCompetent = value; fInfo_InCompetent_IsChanged=true; }
      }
      /// <summary>
      /// 不合格情况
      /// </summary>
      public bool FInfo_InCompetent_IsChanged
      {
         get{ return fInfo_InCompetent_IsChanged; }
         set{ fInfo_InCompetent_IsChanged = value; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      private string fInfo_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_Owner_IsChanged=false;
      /// <summary>
      /// 制单人
      /// </summary>
      public string FInfo_Owner
      {
         get{ return fInfo_Owner; }
         set{ fInfo_Owner = value; fInfo_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      public bool FInfo_Owner_IsChanged
      {
         get{ return fInfo_Owner_IsChanged; }
         set{ fInfo_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 制单日期
      /// </summary>
      private DateTime fInfo_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_Date_IsChanged=false;
      /// <summary>
      /// 制单日期
      /// </summary>
      public DateTime FInfo_Date
      {
         get{ return fInfo_Date; }
         set{ fInfo_Date = value; fInfo_Date_IsChanged=true; }
      }
      /// <summary>
      /// 制单日期
      /// </summary>
      public bool FInfo_Date_IsChanged
      {
         get{ return fInfo_Date_IsChanged; }
         set{ fInfo_Date_IsChanged = value; }
      }
      /// <summary>
      /// 处理进度情况
      /// </summary>
      private string fInfo_Process;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_Process_IsChanged=false;
      /// <summary>
      /// 处理进度情况
      /// </summary>
      public string FInfo_Process
      {
         get{ return fInfo_Process; }
         set{ fInfo_Process = value; fInfo_Process_IsChanged=true; }
      }
      /// <summary>
      /// 处理进度情况
      /// </summary>
      public bool FInfo_Process_IsChanged
      {
         get{ return fInfo_Process_IsChanged; }
         set{ fInfo_Process_IsChanged = value; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      private string fInfo_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_Stat_IsChanged=false;
      /// <summary>
      /// 单据状态
      /// </summary>
      public string FInfo_Stat
      {
         get{ return fInfo_Stat; }
         set{ fInfo_Stat = value; fInfo_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      public bool FInfo_Stat_IsChanged
      {
         get{ return fInfo_Stat_IsChanged; }
         set{ fInfo_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 是否作废
      /// </summary>
      private string fInfo_IsCancel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_IsCancel_IsChanged=false;
      /// <summary>
      /// 是否作废
      /// </summary>
      public string FInfo_IsCancel
      {
         get{ return fInfo_IsCancel; }
         set{ fInfo_IsCancel = value; fInfo_IsCancel_IsChanged=true; }
      }
      /// <summary>
      /// 是否作废
      /// </summary>
      public bool FInfo_IsCancel_IsChanged
      {
         get{ return fInfo_IsCancel_IsChanged; }
         set{ fInfo_IsCancel_IsChanged = value; }
      }
      /// <summary>
      /// 作废人
      /// </summary>
      private string fInfo_CancelPep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_CancelPep_IsChanged=false;
      /// <summary>
      /// 作废人
      /// </summary>
      public string FInfo_CancelPep
      {
         get{ return fInfo_CancelPep; }
         set{ fInfo_CancelPep = value; fInfo_CancelPep_IsChanged=true; }
      }
      /// <summary>
      /// 作废人
      /// </summary>
      public bool FInfo_CancelPep_IsChanged
      {
         get{ return fInfo_CancelPep_IsChanged; }
         set{ fInfo_CancelPep_IsChanged = value; }
      }
      /// <summary>
      /// 作废时间
      /// </summary>
      private DateTime fInfo_CancelDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_CancelDate_IsChanged=false;
      /// <summary>
      /// 作废时间
      /// </summary>
      public DateTime FInfo_CancelDate
      {
         get{ return fInfo_CancelDate; }
         set{ fInfo_CancelDate = value; fInfo_CancelDate_IsChanged=true; }
      }
      /// <summary>
      /// 作废时间
      /// </summary>
      public bool FInfo_CancelDate_IsChanged
      {
         get{ return fInfo_CancelDate_IsChanged; }
         set{ fInfo_CancelDate_IsChanged = value; }
      }
      /// <summary>
      /// 作废说明
      /// </summary>
      private string fInfo_CancelDesp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_CancelDesp_IsChanged=false;
      /// <summary>
      /// 作废说明
      /// </summary>
      public string FInfo_CancelDesp
      {
         get{ return fInfo_CancelDesp; }
         set{ fInfo_CancelDesp = value; fInfo_CancelDesp_IsChanged=true; }
      }
      /// <summary>
      /// 作废说明
      /// </summary>
      public bool FInfo_CancelDesp_IsChanged
      {
         get{ return fInfo_CancelDesp_IsChanged; }
         set{ fInfo_CancelDesp_IsChanged = value; }
      }
      /// <summary>
      /// 是否理赔
      /// </summary>
      private string fInfo_IsClaim;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_IsClaim_IsChanged=false;
      /// <summary>
      /// 是否理赔
      /// </summary>
      public string FInfo_IsClaim
      {
         get{ return fInfo_IsClaim; }
         set{ fInfo_IsClaim = value; fInfo_IsClaim_IsChanged=true; }
      }
      /// <summary>
      /// 是否理赔
      /// </summary>
      public bool FInfo_IsClaim_IsChanged
      {
         get{ return fInfo_IsClaim_IsChanged; }
         set{ fInfo_IsClaim_IsChanged = value; }
      }
      /// <summary>
      /// 理赔说明
      /// </summary>
      private string fInfo_ClaimDesp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_ClaimDesp_IsChanged=false;
      /// <summary>
      /// 理赔说明
      /// </summary>
      public string FInfo_ClaimDesp
      {
         get{ return fInfo_ClaimDesp; }
         set{ fInfo_ClaimDesp = value; fInfo_ClaimDesp_IsChanged=true; }
      }
      /// <summary>
      /// 理赔说明
      /// </summary>
      public bool FInfo_ClaimDesp_IsChanged
      {
         get{ return fInfo_ClaimDesp_IsChanged; }
         set{ fInfo_ClaimDesp_IsChanged = value; }
      }
      /// <summary>
      /// 理赔责任人
      /// </summary>
      private string fInfo_ClaimPep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_ClaimPep_IsChanged=false;
      /// <summary>
      /// 理赔责任人
      /// </summary>
      public string FInfo_ClaimPep
      {
         get{ return fInfo_ClaimPep; }
         set{ fInfo_ClaimPep = value; fInfo_ClaimPep_IsChanged=true; }
      }
      /// <summary>
      /// 理赔责任人
      /// </summary>
      public bool FInfo_ClaimPep_IsChanged
      {
         get{ return fInfo_ClaimPep_IsChanged; }
         set{ fInfo_ClaimPep_IsChanged = value; }
      }
      /// <summary>
      /// 理赔处理时间
      /// </summary>
      private DateTime fInfo_ClaimDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fInfo_ClaimDate_IsChanged=false;
      /// <summary>
      /// 理赔处理时间
      /// </summary>
      public DateTime FInfo_ClaimDate
      {
         get{ return fInfo_ClaimDate; }
         set{ fInfo_ClaimDate = value; fInfo_ClaimDate_IsChanged=true; }
      }
      /// <summary>
      /// 理赔处理时间
      /// </summary>
      public bool FInfo_ClaimDate_IsChanged
      {
         get{ return fInfo_ClaimDate_IsChanged; }
         set{ fInfo_ClaimDate_IsChanged = value; }
      }
      private string fInfo_Reason;
      private bool fInfo_Reason_IsChanged=false;
      public string FInfo_Reason
      {
         get{ return fInfo_Reason; }
         set{ fInfo_Reason = value; fInfo_Reason_IsChanged=true; }
      }
      public bool FInfo_Reason_IsChanged
      {
         get{ return fInfo_Reason_IsChanged; }
         set{ fInfo_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string auditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      private string auditCurAudit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditCurAudit_IsChanged=false;
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      private string fInfo_Udef1;
      private bool fInfo_Udef1_IsChanged=false;
      public string FInfo_Udef1
      {
         get{ return fInfo_Udef1; }
         set{ fInfo_Udef1 = value; fInfo_Udef1_IsChanged=true; }
      }
      public bool FInfo_Udef1_IsChanged
      {
         get{ return fInfo_Udef1_IsChanged; }
         set{ fInfo_Udef1_IsChanged = value; }
      }
      private string fInfo_Udef2;
      private bool fInfo_Udef2_IsChanged=false;
      public string FInfo_Udef2
      {
         get{ return fInfo_Udef2; }
         set{ fInfo_Udef2 = value; fInfo_Udef2_IsChanged=true; }
      }
      public bool FInfo_Udef2_IsChanged
      {
         get{ return fInfo_Udef2_IsChanged; }
         set{ fInfo_Udef2_IsChanged = value; }
      }
      private string fInfo_IsPrint;
      private bool fInfo_IsPrint_IsChanged=false;
      public string FInfo_IsPrint
      {
         get{ return fInfo_IsPrint; }
         set{ fInfo_IsPrint = value; fInfo_IsPrint_IsChanged=true; }
      }
      public bool FInfo_IsPrint_IsChanged
      {
         get{ return fInfo_IsPrint_IsChanged; }
         set{ fInfo_IsPrint_IsChanged = value; }
      }
      private string fInfo_RespNodeName;
      private bool fInfo_RespNodeName_IsChanged=false;
      public string FInfo_RespNodeName
      {
         get{ return fInfo_RespNodeName; }
         set{ fInfo_RespNodeName = value; fInfo_RespNodeName_IsChanged=true; }
      }
      public bool FInfo_RespNodeName_IsChanged
      {
         get{ return fInfo_RespNodeName_IsChanged; }
         set{ fInfo_RespNodeName_IsChanged = value; }
      }
      private string fInfo_RespEntityName;
      private bool fInfo_RespEntityName_IsChanged=false;
      public string FInfo_RespEntityName
      {
         get{ return fInfo_RespEntityName; }
         set{ fInfo_RespEntityName = value; fInfo_RespEntityName_IsChanged=true; }
      }
      public bool FInfo_RespEntityName_IsChanged
      {
         get{ return fInfo_RespEntityName_IsChanged; }
         set{ fInfo_RespEntityName_IsChanged = value; }
      }
      private string fInfo_Creator;
      private bool fInfo_Creator_IsChanged=false;
      public string FInfo_Creator
      {
         get{ return fInfo_Creator; }
         set{ fInfo_Creator = value; fInfo_Creator_IsChanged=true; }
      }
      public bool FInfo_Creator_IsChanged
      {
         get{ return fInfo_Creator_IsChanged; }
         set{ fInfo_Creator_IsChanged = value; }
      }
      private string fInfo_CreatorCode;
      private bool fInfo_CreatorCode_IsChanged=false;
      public string FInfo_CreatorCode
      {
         get{ return fInfo_CreatorCode; }
         set{ fInfo_CreatorCode = value; fInfo_CreatorCode_IsChanged=true; }
      }
      public bool FInfo_CreatorCode_IsChanged
      {
         get{ return fInfo_CreatorCode_IsChanged; }
         set{ fInfo_CreatorCode_IsChanged = value; }
      }
      private DateTime fInfo_CreateTime;
      private bool fInfo_CreateTime_IsChanged=false;
      public DateTime FInfo_CreateTime
      {
         get{ return fInfo_CreateTime; }
         set{ fInfo_CreateTime = value; fInfo_CreateTime_IsChanged=true; }
      }
      public bool FInfo_CreateTime_IsChanged
      {
         get{ return fInfo_CreateTime_IsChanged; }
         set{ fInfo_CreateTime_IsChanged = value; }
      }
      private string fInfo_RelationCode;
      private bool fInfo_RelationCode_IsChanged=false;
      public string FInfo_RelationCode
      {
         get{ return fInfo_RelationCode; }
         set{ fInfo_RelationCode = value; fInfo_RelationCode_IsChanged=true; }
      }
      public bool FInfo_RelationCode_IsChanged
      {
         get{ return fInfo_RelationCode_IsChanged; }
         set{ fInfo_RelationCode_IsChanged = value; }
      }
   }
}
