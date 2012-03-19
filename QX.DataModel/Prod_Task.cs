using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 生产任务表
   /// </summary>
   [Serializable]
   public partial class Prod_Task
   {
      /// <summary>
      /// 生产任务序号
      /// </summary>
      private Int64 task_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_ID_IsChanged=false;
      /// <summary>
      /// 生产任务序号
      /// </summary>
      public Int64 Task_ID
      {
         get{ return task_ID; }
         set{ task_ID = value; task_ID_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务序号
      /// </summary>
      public bool Task_ID_IsChanged
      {
         get{ return task_ID_IsChanged; }
         set{ task_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务编号
      /// </summary>
      private string task_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_Code_IsChanged=false;
      /// <summary>
      /// 生产任务编号
      /// </summary>
      public string Task_Code
      {
         get{ return task_Code; }
         set{ task_Code = value; task_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务编号
      /// </summary>
      public bool Task_Code_IsChanged
      {
         get{ return task_Code_IsChanged; }
         set{ task_Code_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务名称
      /// </summary>
      private string task_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_Name_IsChanged=false;
      /// <summary>
      /// 生产任务名称
      /// </summary>
      public string Task_Name
      {
         get{ return task_Name; }
         set{ task_Name = value; task_Name_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务名称
      /// </summary>
      public bool Task_Name_IsChanged
      {
         get{ return task_Name_IsChanged; }
         set{ task_Name_IsChanged = value; }
      }
      private string taskDetail_CmdCode;
      private bool taskDetail_CmdCode_IsChanged=false;
      public string TaskDetail_CmdCode
      {
         get{ return taskDetail_CmdCode; }
         set{ taskDetail_CmdCode = value; taskDetail_CmdCode_IsChanged=true; }
      }
      public bool TaskDetail_CmdCode_IsChanged
      {
         get{ return taskDetail_CmdCode_IsChanged; }
         set{ taskDetail_CmdCode_IsChanged = value; }
      }
      private string taskDetail_PartNo;
      private bool taskDetail_PartNo_IsChanged=false;
      public string TaskDetail_PartNo
      {
         get{ return taskDetail_PartNo; }
         set{ taskDetail_PartNo = value; taskDetail_PartNo_IsChanged=true; }
      }
      public bool TaskDetail_PartNo_IsChanged
      {
         get{ return taskDetail_PartNo_IsChanged; }
         set{ taskDetail_PartNo_IsChanged = value; }
      }
      private string taskDetail_PartName;
      private bool taskDetail_PartName_IsChanged=false;
      public string TaskDetail_PartName
      {
         get{ return taskDetail_PartName; }
         set{ taskDetail_PartName = value; taskDetail_PartName_IsChanged=true; }
      }
      public bool TaskDetail_PartName_IsChanged
      {
         get{ return taskDetail_PartName_IsChanged; }
         set{ taskDetail_PartName_IsChanged = value; }
      }
      private string task_PartCat;
      private bool task_PartCat_IsChanged=false;
      public string Task_PartCat
      {
         get{ return task_PartCat; }
         set{ task_PartCat = value; task_PartCat_IsChanged=true; }
      }
      public bool Task_PartCat_IsChanged
      {
         get{ return task_PartCat_IsChanged; }
         set{ task_PartCat_IsChanged = value; }
      }
      private string task_PartCatName;
      private bool task_PartCatName_IsChanged=false;
      public string Task_PartCatName
      {
         get{ return task_PartCatName; }
         set{ task_PartCatName = value; task_PartCatName_IsChanged=true; }
      }
      public bool Task_PartCatName_IsChanged
      {
         get{ return task_PartCatName_IsChanged; }
         set{ task_PartCatName_IsChanged = value; }
      }
      /// <summary>
      /// 编制人
      /// </summary>
      private string task_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_Owner_IsChanged=false;
      /// <summary>
      /// 编制人
      /// </summary>
      public string Task_Owner
      {
         get{ return task_Owner; }
         set{ task_Owner = value; task_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 编制人
      /// </summary>
      public bool Task_Owner_IsChanged
      {
         get{ return task_Owner_IsChanged; }
         set{ task_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 编制时间
      /// </summary>
      private DateTime task_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_Date_IsChanged=false;
      /// <summary>
      /// 编制时间
      /// </summary>
      public DateTime Task_Date
      {
         get{ return task_Date; }
         set{ task_Date = value; task_Date_IsChanged=true; }
      }
      /// <summary>
      /// 编制时间
      /// </summary>
      public bool Task_Date_IsChanged
      {
         get{ return task_Date_IsChanged; }
         set{ task_Date_IsChanged = value; }
      }
      private string taskDetail_Unit;
      private bool taskDetail_Unit_IsChanged=false;
      public string TaskDetail_Unit
      {
         get{ return taskDetail_Unit; }
         set{ taskDetail_Unit = value; taskDetail_Unit_IsChanged=true; }
      }
      public bool TaskDetail_Unit_IsChanged
      {
         get{ return taskDetail_Unit_IsChanged; }
         set{ taskDetail_Unit_IsChanged = value; }
      }
      private int taskDetail_Num;
      private bool taskDetail_Num_IsChanged=false;
      public int TaskDetail_Num
      {
         get{ return taskDetail_Num; }
         set{ taskDetail_Num = value; taskDetail_Num_IsChanged=true; }
      }
      public bool TaskDetail_Num_IsChanged
      {
         get{ return taskDetail_Num_IsChanged; }
         set{ taskDetail_Num_IsChanged = value; }
      }
      private int task_DNum;
      private bool task_DNum_IsChanged=false;
      public int Task_DNum
      {
         get{ return task_DNum; }
         set{ task_DNum = value; task_DNum_IsChanged=true; }
      }
      public bool Task_DNum_IsChanged
      {
         get{ return task_DNum_IsChanged; }
         set{ task_DNum_IsChanged = value; }
      }
      private string taskDetail_ProdType;
      private bool taskDetail_ProdType_IsChanged=false;
      public string TaskDetail_ProdType
      {
         get{ return taskDetail_ProdType; }
         set{ taskDetail_ProdType = value; taskDetail_ProdType_IsChanged=true; }
      }
      public bool TaskDetail_ProdType_IsChanged
      {
         get{ return taskDetail_ProdType_IsChanged; }
         set{ taskDetail_ProdType_IsChanged = value; }
      }
      private DateTime taskDetail_PlanBegin;
      private bool taskDetail_PlanBegin_IsChanged=false;
      public DateTime TaskDetail_PlanBegin
      {
         get{ return taskDetail_PlanBegin; }
         set{ taskDetail_PlanBegin = value; taskDetail_PlanBegin_IsChanged=true; }
      }
      public bool TaskDetail_PlanBegin_IsChanged
      {
         get{ return taskDetail_PlanBegin_IsChanged; }
         set{ taskDetail_PlanBegin_IsChanged = value; }
      }
      private DateTime taskDetail_PlanEnd;
      private bool taskDetail_PlanEnd_IsChanged=false;
      public DateTime TaskDetail_PlanEnd
      {
         get{ return taskDetail_PlanEnd; }
         set{ taskDetail_PlanEnd = value; taskDetail_PlanEnd_IsChanged=true; }
      }
      public bool TaskDetail_PlanEnd_IsChanged
      {
         get{ return taskDetail_PlanEnd_IsChanged; }
         set{ taskDetail_PlanEnd_IsChanged = value; }
      }
      private DateTime taskDetail_ActEnd;
      private bool taskDetail_ActEnd_IsChanged=false;
      public DateTime TaskDetail_ActEnd
      {
         get{ return taskDetail_ActEnd; }
         set{ taskDetail_ActEnd = value; taskDetail_ActEnd_IsChanged=true; }
      }
      public bool TaskDetail_ActEnd_IsChanged
      {
         get{ return taskDetail_ActEnd_IsChanged; }
         set{ taskDetail_ActEnd_IsChanged = value; }
      }
      private int task_FNum;
      private bool task_FNum_IsChanged=false;
      public int Task_FNum
      {
         get{ return task_FNum; }
         set{ task_FNum = value; task_FNum_IsChanged=true; }
      }
      public bool Task_FNum_IsChanged
      {
         get{ return task_FNum_IsChanged; }
         set{ task_FNum_IsChanged = value; }
      }
      private string task_Roads;
      private bool task_Roads_IsChanged=false;
      public string Task_Roads
      {
         get{ return task_Roads; }
         set{ task_Roads = value; task_Roads_IsChanged=true; }
      }
      public bool Task_Roads_IsChanged
      {
         get{ return task_Roads_IsChanged; }
         set{ task_Roads_IsChanged = value; }
      }
      private string task_ProdCode;
      private bool task_ProdCode_IsChanged=false;
      public string Task_ProdCode
      {
         get{ return task_ProdCode; }
         set{ task_ProdCode = value; task_ProdCode_IsChanged=true; }
      }
      public bool Task_ProdCode_IsChanged
      {
         get{ return task_ProdCode_IsChanged; }
         set{ task_ProdCode_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务状态
      /// </summary>
      private string task_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_Stat_IsChanged=false;
      /// <summary>
      /// 生产任务状态
      /// </summary>
      public string Task_Stat
      {
         get{ return task_Stat; }
         set{ task_Stat = value; task_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务状态
      /// </summary>
      public bool Task_Stat_IsChanged
      {
         get{ return task_Stat_IsChanged; }
         set{ task_Stat_IsChanged = value; }
      }
      private string task_Remark;
      private bool task_Remark_IsChanged=false;
      public string Task_Remark
      {
         get{ return task_Remark; }
         set{ task_Remark = value; task_Remark_IsChanged=true; }
      }
      public bool Task_Remark_IsChanged
      {
         get{ return task_Remark_IsChanged; }
         set{ task_Remark_IsChanged = value; }
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
      private string auditStat;
      private bool auditStat_IsChanged=false;
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private string auditCurAudit;
      private bool auditCurAudit_IsChanged=false;
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      private string task_Customer;
      private bool task_Customer_IsChanged=false;
      public string Task_Customer
      {
         get{ return task_Customer; }
         set{ task_Customer = value; task_Customer_IsChanged=true; }
      }
      public bool Task_Customer_IsChanged
      {
         get{ return task_Customer_IsChanged; }
         set{ task_Customer_IsChanged = value; }
      }
      private string task_CustomerName;
      private bool task_CustomerName_IsChanged=false;
      public string Task_CustomerName
      {
         get{ return task_CustomerName; }
         set{ task_CustomerName = value; task_CustomerName_IsChanged=true; }
      }
      public bool Task_CustomerName_IsChanged
      {
         get{ return task_CustomerName_IsChanged; }
         set{ task_CustomerName_IsChanged = value; }
      }
      private string task_RefInv;
      private bool task_RefInv_IsChanged=false;
      public string Task_RefInv
      {
         get{ return task_RefInv; }
         set{ task_RefInv = value; task_RefInv_IsChanged=true; }
      }
      public bool Task_RefInv_IsChanged
      {
         get{ return task_RefInv_IsChanged; }
         set{ task_RefInv_IsChanged = value; }
      }
   }
}
