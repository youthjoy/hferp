using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 毛坯采购主表
   /// </summary>
   [Serializable]
   public partial class Raw_Main
   {
      /// <summary>
      /// 毛坯主表序号
      /// </summary>
      private decimal rawMain_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_ID_IsChanged=false;
      /// <summary>
      /// 毛坯主表序号
      /// </summary>
      public decimal RawMain_ID
      {
         get{ return rawMain_ID; }
         set{ rawMain_ID = value; rawMain_ID_IsChanged=true; }
      }
      /// <summary>
      /// 毛坯主表序号
      /// </summary>
      public bool RawMain_ID_IsChanged
      {
         get{ return rawMain_ID_IsChanged; }
         set{ rawMain_ID_IsChanged = value; }
      }
      /// <summary>
      /// 毛坯申请编号
      /// </summary>
      private string rawMain_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_Code_IsChanged=false;
      /// <summary>
      /// 毛坯申请编号
      /// </summary>
      public string RawMain_Code
      {
         get{ return rawMain_Code; }
         set{ rawMain_Code = value; rawMain_Code_IsChanged=true; }
      }
      /// <summary>
      /// 毛坯申请编号
      /// </summary>
      public bool RawMain_Code_IsChanged
      {
         get{ return rawMain_Code_IsChanged; }
         set{ rawMain_Code_IsChanged = value; }
      }
      /// <summary>
      /// 申请标题
      /// </summary>
      private string rawMain_Title;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_Title_IsChanged=false;
      /// <summary>
      /// 申请标题
      /// </summary>
      public string RawMain_Title
      {
         get{ return rawMain_Title; }
         set{ rawMain_Title = value; rawMain_Title_IsChanged=true; }
      }
      /// <summary>
      /// 申请标题
      /// </summary>
      public bool RawMain_Title_IsChanged
      {
         get{ return rawMain_Title_IsChanged; }
         set{ rawMain_Title_IsChanged = value; }
      }
      /// <summary>
      /// 申请部门
      /// </summary>
      private string rawMain_AppDep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_AppDep_IsChanged=false;
      /// <summary>
      /// 申请部门
      /// </summary>
      public string RawMain_AppDep
      {
         get{ return rawMain_AppDep; }
         set{ rawMain_AppDep = value; rawMain_AppDep_IsChanged=true; }
      }
      /// <summary>
      /// 申请部门
      /// </summary>
      public bool RawMain_AppDep_IsChanged
      {
         get{ return rawMain_AppDep_IsChanged; }
         set{ rawMain_AppDep_IsChanged = value; }
      }
      private string rawMain_BusOwn;
      private bool rawMain_BusOwn_IsChanged=false;
      public string RawMain_BusOwn
      {
         get{ return rawMain_BusOwn; }
         set{ rawMain_BusOwn = value; rawMain_BusOwn_IsChanged=true; }
      }
      public bool RawMain_BusOwn_IsChanged
      {
         get{ return rawMain_BusOwn_IsChanged; }
         set{ rawMain_BusOwn_IsChanged = value; }
      }
      /// <summary>
      /// 申请人
      /// </summary>
      private string rawMain_AppOwn;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_AppOwn_IsChanged=false;
      /// <summary>
      /// 申请人
      /// </summary>
      public string RawMain_AppOwn
      {
         get{ return rawMain_AppOwn; }
         set{ rawMain_AppOwn = value; rawMain_AppOwn_IsChanged=true; }
      }
      /// <summary>
      /// 申请人
      /// </summary>
      public bool RawMain_AppOwn_IsChanged
      {
         get{ return rawMain_AppOwn_IsChanged; }
         set{ rawMain_AppOwn_IsChanged = value; }
      }
      /// <summary>
      /// 申请日期
      /// </summary>
      private DateTime rawMain_AppDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_AppDate_IsChanged=false;
      /// <summary>
      /// 申请日期
      /// </summary>
      public DateTime RawMain_AppDate
      {
         get{ return rawMain_AppDate; }
         set{ rawMain_AppDate = value; rawMain_AppDate_IsChanged=true; }
      }
      /// <summary>
      /// 申请日期
      /// </summary>
      public bool RawMain_AppDate_IsChanged
      {
         get{ return rawMain_AppDate_IsChanged; }
         set{ rawMain_AppDate_IsChanged = value; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      private string rawMain_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_Stat_IsChanged=false;
      /// <summary>
      /// 单据状态
      /// </summary>
      public string RawMain_Stat
      {
         get{ return rawMain_Stat; }
         set{ rawMain_Stat = value; rawMain_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      public bool RawMain_Stat_IsChanged
      {
         get{ return rawMain_Stat_IsChanged; }
         set{ rawMain_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 毛坯审核当前状态
      /// </summary>
      private string rawMain_CurStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_CurStat_IsChanged=false;
      /// <summary>
      /// 毛坯审核当前状态
      /// </summary>
      public string RawMain_CurStat
      {
         get{ return rawMain_CurStat; }
         set{ rawMain_CurStat = value; rawMain_CurStat_IsChanged=true; }
      }
      /// <summary>
      /// 毛坯审核当前状态
      /// </summary>
      public bool RawMain_CurStat_IsChanged
      {
         get{ return rawMain_CurStat_IsChanged; }
         set{ rawMain_CurStat_IsChanged = value; }
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
      private string rawMain_CmdCode;
      private bool rawMain_CmdCode_IsChanged=false;
      public string RawMain_CmdCode
      {
         get{ return rawMain_CmdCode; }
         set{ rawMain_CmdCode = value; rawMain_CmdCode_IsChanged=true; }
      }
      public bool RawMain_CmdCode_IsChanged
      {
         get{ return rawMain_CmdCode_IsChanged; }
         set{ rawMain_CmdCode_IsChanged = value; }
      }
      private string rawMain_SupCode;
      private bool rawMain_SupCode_IsChanged=false;
      public string RawMain_SupCode
      {
         get{ return rawMain_SupCode; }
         set{ rawMain_SupCode = value; rawMain_SupCode_IsChanged=true; }
      }
      public bool RawMain_SupCode_IsChanged
      {
         get{ return rawMain_SupCode_IsChanged; }
         set{ rawMain_SupCode_IsChanged = value; }
      }
      private string rawMain_SupName;
      private bool rawMain_SupName_IsChanged=false;
      public string RawMain_SupName
      {
         get{ return rawMain_SupName; }
         set{ rawMain_SupName = value; rawMain_SupName_IsChanged=true; }
      }
      public bool RawMain_SupName_IsChanged
      {
         get{ return rawMain_SupName_IsChanged; }
         set{ rawMain_SupName_IsChanged = value; }
      }
      private string rawMain_RefType;
      private bool rawMain_RefType_IsChanged=false;
      public string RawMain_RefType
      {
         get{ return rawMain_RefType; }
         set{ rawMain_RefType = value; rawMain_RefType_IsChanged=true; }
      }
      public bool RawMain_RefType_IsChanged
      {
         get{ return rawMain_RefType_IsChanged; }
         set{ rawMain_RefType_IsChanged = value; }
      }
      private string rawMain_RefCode;
      private bool rawMain_RefCode_IsChanged=false;
      public string RawMain_RefCode
      {
         get{ return rawMain_RefCode; }
         set{ rawMain_RefCode = value; rawMain_RefCode_IsChanged=true; }
      }
      public bool RawMain_RefCode_IsChanged
      {
         get{ return rawMain_RefCode_IsChanged; }
         set{ rawMain_RefCode_IsChanged = value; }
      }
      private string rawMain_iType;
      private bool rawMain_iType_IsChanged=false;
      public string RawMain_iType
      {
         get{ return rawMain_iType; }
         set{ rawMain_iType = value; rawMain_iType_IsChanged=true; }
      }
      public bool RawMain_iType_IsChanged
      {
         get{ return rawMain_iType_IsChanged; }
         set{ rawMain_iType_IsChanged = value; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createDate_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime updateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool updateDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime deleteDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool deleteDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
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
      private string rawMain_Creator;
      private bool rawMain_Creator_IsChanged=false;
      public string RawMain_Creator
      {
         get{ return rawMain_Creator; }
         set{ rawMain_Creator = value; rawMain_Creator_IsChanged=true; }
      }
      public bool RawMain_Creator_IsChanged
      {
         get{ return rawMain_Creator_IsChanged; }
         set{ rawMain_Creator_IsChanged = value; }
      }
      private string rawMain_Checker;
      private bool rawMain_Checker_IsChanged=false;
      public string RawMain_Checker
      {
         get{ return rawMain_Checker; }
         set{ rawMain_Checker = value; rawMain_Checker_IsChanged=true; }
      }
      public bool RawMain_Checker_IsChanged
      {
         get{ return rawMain_Checker_IsChanged; }
         set{ rawMain_Checker_IsChanged = value; }
      }
      private string rawMain_Customer;
      private bool rawMain_Customer_IsChanged=false;
      public string RawMain_Customer
      {
         get{ return rawMain_Customer; }
         set{ rawMain_Customer = value; rawMain_Customer_IsChanged=true; }
      }
      public bool RawMain_Customer_IsChanged
      {
         get{ return rawMain_Customer_IsChanged; }
         set{ rawMain_Customer_IsChanged = value; }
      }
   }
}
