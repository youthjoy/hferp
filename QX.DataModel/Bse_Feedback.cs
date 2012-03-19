using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Bse_Feedback
   {
      private decimal fB_ID;
      private bool fB_ID_IsChanged=false;
      public decimal FB_ID
      {
         get{ return fB_ID; }
         set{ fB_ID = value; fB_ID_IsChanged=true; }
      }
      public bool FB_ID_IsChanged
      {
         get{ return fB_ID_IsChanged; }
         set{ fB_ID_IsChanged = value; }
      }
      private string fB_Code;
      private bool fB_Code_IsChanged=false;
      public string FB_Code
      {
         get{ return fB_Code; }
         set{ fB_Code = value; fB_Code_IsChanged=true; }
      }
      public bool FB_Code_IsChanged
      {
         get{ return fB_Code_IsChanged; }
         set{ fB_Code_IsChanged = value; }
      }
      private string fB_Customer;
      private bool fB_Customer_IsChanged=false;
      public string FB_Customer
      {
         get{ return fB_Customer; }
         set{ fB_Customer = value; fB_Customer_IsChanged=true; }
      }
      public bool FB_Customer_IsChanged
      {
         get{ return fB_Customer_IsChanged; }
         set{ fB_Customer_IsChanged = value; }
      }
      private string fB_CustomerName;
      private bool fB_CustomerName_IsChanged=false;
      public string FB_CustomerName
      {
         get{ return fB_CustomerName; }
         set{ fB_CustomerName = value; fB_CustomerName_IsChanged=true; }
      }
      public bool FB_CustomerName_IsChanged
      {
         get{ return fB_CustomerName_IsChanged; }
         set{ fB_CustomerName_IsChanged = value; }
      }
      private string fB_Contact;
      private bool fB_Contact_IsChanged=false;
      public string FB_Contact
      {
         get{ return fB_Contact; }
         set{ fB_Contact = value; fB_Contact_IsChanged=true; }
      }
      public bool FB_Contact_IsChanged
      {
         get{ return fB_Contact_IsChanged; }
         set{ fB_Contact_IsChanged = value; }
      }
      private string fB_Mobile;
      private bool fB_Mobile_IsChanged=false;
      public string FB_Mobile
      {
         get{ return fB_Mobile; }
         set{ fB_Mobile = value; fB_Mobile_IsChanged=true; }
      }
      public bool FB_Mobile_IsChanged
      {
         get{ return fB_Mobile_IsChanged; }
         set{ fB_Mobile_IsChanged = value; }
      }
      private string fB_Content;
      private bool fB_Content_IsChanged=false;
      public string FB_Content
      {
         get{ return fB_Content; }
         set{ fB_Content = value; fB_Content_IsChanged=true; }
      }
      public bool FB_Content_IsChanged
      {
         get{ return fB_Content_IsChanged; }
         set{ fB_Content_IsChanged = value; }
      }
      private DateTime fB_Date;
      private bool fB_Date_IsChanged=false;
      public DateTime FB_Date
      {
         get{ return fB_Date; }
         set{ fB_Date = value; fB_Date_IsChanged=true; }
      }
      public bool FB_Date_IsChanged
      {
         get{ return fB_Date_IsChanged; }
         set{ fB_Date_IsChanged = value; }
      }
      private string fB_RespDept;
      private bool fB_RespDept_IsChanged=false;
      public string FB_RespDept
      {
         get{ return fB_RespDept; }
         set{ fB_RespDept = value; fB_RespDept_IsChanged=true; }
      }
      public bool FB_RespDept_IsChanged
      {
         get{ return fB_RespDept_IsChanged; }
         set{ fB_RespDept_IsChanged = value; }
      }
      private string fB_RespDeptName;
      private bool fB_RespDeptName_IsChanged=false;
      public string FB_RespDeptName
      {
         get{ return fB_RespDeptName; }
         set{ fB_RespDeptName = value; fB_RespDeptName_IsChanged=true; }
      }
      public bool FB_RespDeptName_IsChanged
      {
         get{ return fB_RespDeptName_IsChanged; }
         set{ fB_RespDeptName_IsChanged = value; }
      }
      private string fB_Level;
      private bool fB_Level_IsChanged=false;
      public string FB_Level
      {
         get{ return fB_Level; }
         set{ fB_Level = value; fB_Level_IsChanged=true; }
      }
      public bool FB_Level_IsChanged
      {
         get{ return fB_Level_IsChanged; }
         set{ fB_Level_IsChanged = value; }
      }
      private string fB_Cate;
      private bool fB_Cate_IsChanged=false;
      public string FB_Cate
      {
         get{ return fB_Cate; }
         set{ fB_Cate = value; fB_Cate_IsChanged=true; }
      }
      public bool FB_Cate_IsChanged
      {
         get{ return fB_Cate_IsChanged; }
         set{ fB_Cate_IsChanged = value; }
      }
      private string fB_CateOther;
      private bool fB_CateOther_IsChanged=false;
      public string FB_CateOther
      {
         get{ return fB_CateOther; }
         set{ fB_CateOther = value; fB_CateOther_IsChanged=true; }
      }
      public bool FB_CateOther_IsChanged
      {
         get{ return fB_CateOther_IsChanged; }
         set{ fB_CateOther_IsChanged = value; }
      }
      private string fB_Reason;
      private bool fB_Reason_IsChanged=false;
      public string FB_Reason
      {
         get{ return fB_Reason; }
         set{ fB_Reason = value; fB_Reason_IsChanged=true; }
      }
      public bool FB_Reason_IsChanged
      {
         get{ return fB_Reason_IsChanged; }
         set{ fB_Reason_IsChanged = value; }
      }
      private string fB_ReasonOther;
      private bool fB_ReasonOther_IsChanged=false;
      public string FB_ReasonOther
      {
         get{ return fB_ReasonOther; }
         set{ fB_ReasonOther = value; fB_ReasonOther_IsChanged=true; }
      }
      public bool FB_ReasonOther_IsChanged
      {
         get{ return fB_ReasonOther_IsChanged; }
         set{ fB_ReasonOther_IsChanged = value; }
      }
      private string fB_Handle;
      private bool fB_Handle_IsChanged=false;
      public string FB_Handle
      {
         get{ return fB_Handle; }
         set{ fB_Handle = value; fB_Handle_IsChanged=true; }
      }
      public bool FB_Handle_IsChanged
      {
         get{ return fB_Handle_IsChanged; }
         set{ fB_Handle_IsChanged = value; }
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
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private DateTime createTime;
      private bool createTime_IsChanged=false;
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
      private DateTime updateTime;
      private bool updateTime_IsChanged=false;
      public DateTime UpdateTime
      {
         get{ return updateTime; }
         set{ updateTime = value; updateTime_IsChanged=true; }
      }
      public bool UpdateTime_IsChanged
      {
         get{ return updateTime_IsChanged; }
         set{ updateTime_IsChanged = value; }
      }
      private string fB_IsPrint;
      private bool fB_IsPrint_IsChanged=false;
      public string FB_IsPrint
      {
         get{ return fB_IsPrint; }
         set{ fB_IsPrint = value; fB_IsPrint_IsChanged=true; }
      }
      public bool FB_IsPrint_IsChanged
      {
         get{ return fB_IsPrint_IsChanged; }
         set{ fB_IsPrint_IsChanged = value; }
      }
      private string fB_Creator;
      private bool fB_Creator_IsChanged=false;
      public string FB_Creator
      {
         get{ return fB_Creator; }
         set{ fB_Creator = value; fB_Creator_IsChanged=true; }
      }
      public bool FB_Creator_IsChanged
      {
         get{ return fB_Creator_IsChanged; }
         set{ fB_Creator_IsChanged = value; }
      }
   }
}
