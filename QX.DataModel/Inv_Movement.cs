using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Inv_Movement
   {
      private Int64 mV_ID;
      private bool mV_ID_IsChanged=false;
      public Int64 MV_ID
      {
         get{ return mV_ID; }
         set{ mV_ID = value; mV_ID_IsChanged=true; }
      }
      public bool MV_ID_IsChanged
      {
         get{ return mV_ID_IsChanged; }
         set{ mV_ID_IsChanged = value; }
      }
      private string mV_Code;
      private bool mV_Code_IsChanged=false;
      public string MV_Code
      {
         get{ return mV_Code; }
         set{ mV_Code = value; mV_Code_IsChanged=true; }
      }
      public bool MV_Code_IsChanged
      {
         get{ return mV_Code_IsChanged; }
         set{ mV_Code_IsChanged = value; }
      }
      private string mV_ProdCode;
      private bool mV_ProdCode_IsChanged=false;
      public string MV_ProdCode
      {
         get{ return mV_ProdCode; }
         set{ mV_ProdCode = value; mV_ProdCode_IsChanged=true; }
      }
      public bool MV_ProdCode_IsChanged
      {
         get{ return mV_ProdCode_IsChanged; }
         set{ mV_ProdCode_IsChanged = value; }
      }
      private string mV_PartNo;
      private bool mV_PartNo_IsChanged=false;
      public string MV_PartNo
      {
         get{ return mV_PartNo; }
         set{ mV_PartNo = value; mV_PartNo_IsChanged=true; }
      }
      public bool MV_PartNo_IsChanged
      {
         get{ return mV_PartNo_IsChanged; }
         set{ mV_PartNo_IsChanged = value; }
      }
      private string mV_PartName;
      private bool mV_PartName_IsChanged=false;
      public string MV_PartName
      {
         get{ return mV_PartName; }
         set{ mV_PartName = value; mV_PartName_IsChanged=true; }
      }
      public bool MV_PartName_IsChanged
      {
         get{ return mV_PartName_IsChanged; }
         set{ mV_PartName_IsChanged = value; }
      }
      private string mV_Owner;
      private bool mV_Owner_IsChanged=false;
      public string MV_Owner
      {
         get{ return mV_Owner; }
         set{ mV_Owner = value; mV_Owner_IsChanged=true; }
      }
      public bool MV_Owner_IsChanged
      {
         get{ return mV_Owner_IsChanged; }
         set{ mV_Owner_IsChanged = value; }
      }
      private DateTime mV_Date;
      private bool mV_Date_IsChanged=false;
      public DateTime MV_Date
      {
         get{ return mV_Date; }
         set{ mV_Date = value; mV_Date_IsChanged=true; }
      }
      public bool MV_Date_IsChanged
      {
         get{ return mV_Date_IsChanged; }
         set{ mV_Date_IsChanged = value; }
      }
      private string mV_OutNo;
      private bool mV_OutNo_IsChanged=false;
      public string MV_OutNo
      {
         get{ return mV_OutNo; }
         set{ mV_OutNo = value; mV_OutNo_IsChanged=true; }
      }
      public bool MV_OutNo_IsChanged
      {
         get{ return mV_OutNo_IsChanged; }
         set{ mV_OutNo_IsChanged = value; }
      }
      private int mV_Stat;
      private bool mV_Stat_IsChanged=false;
      public int MV_Stat
      {
         get{ return mV_Stat; }
         set{ mV_Stat = value; mV_Stat_IsChanged=true; }
      }
      public bool MV_Stat_IsChanged
      {
         get{ return mV_Stat_IsChanged; }
         set{ mV_Stat_IsChanged = value; }
      }
      private int mV_Num;
      private bool mV_Num_IsChanged=false;
      public int MV_Num
      {
         get{ return mV_Num; }
         set{ mV_Num = value; mV_Num_IsChanged=true; }
      }
      public bool MV_Num_IsChanged
      {
         get{ return mV_Num_IsChanged; }
         set{ mV_Num_IsChanged = value; }
      }
      private int mV_CheckStat;
      private bool mV_CheckStat_IsChanged=false;
      public int MV_CheckStat
      {
         get{ return mV_CheckStat; }
         set{ mV_CheckStat = value; mV_CheckStat_IsChanged=true; }
      }
      public bool MV_CheckStat_IsChanged
      {
         get{ return mV_CheckStat_IsChanged; }
         set{ mV_CheckStat_IsChanged = value; }
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
      private DateTime deleteTime;
      private bool deleteTime_IsChanged=false;
      public DateTime DeleteTime
      {
         get{ return deleteTime; }
         set{ deleteTime = value; deleteTime_IsChanged=true; }
      }
      public bool DeleteTime_IsChanged
      {
         get{ return deleteTime_IsChanged; }
         set{ deleteTime_IsChanged = value; }
      }
      private int mV_IsPrint;
      private bool mV_IsPrint_IsChanged=false;
      public int MV_IsPrint
      {
         get{ return mV_IsPrint; }
         set{ mV_IsPrint = value; mV_IsPrint_IsChanged=true; }
      }
      public bool MV_IsPrint_IsChanged
      {
         get{ return mV_IsPrint_IsChanged; }
         set{ mV_IsPrint_IsChanged = value; }
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
      /// <summary>
      /// 产品运动类型
      /// </summary>
      private string mV_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_Type_IsChanged=false;
      /// <summary>
      /// 产品运动类型
      /// </summary>
      public string MV_Type
      {
         get{ return mV_Type; }
         set{ mV_Type = value; mV_Type_IsChanged=true; }
      }
      /// <summary>
      /// 产品运动类型
      /// </summary>
      public bool MV_Type_IsChanged
      {
         get{ return mV_Type_IsChanged; }
         set{ mV_Type_IsChanged = value; }
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
      /// <summary>
      /// 创建者
      /// </summary>
      private string mV_Creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_Creator_IsChanged=false;
      /// <summary>
      /// 创建者
      /// </summary>
      public string MV_Creator
      {
         get{ return mV_Creator; }
         set{ mV_Creator = value; mV_Creator_IsChanged=true; }
      }
      /// <summary>
      /// 创建者
      /// </summary>
      public bool MV_Creator_IsChanged
      {
         get{ return mV_Creator_IsChanged; }
         set{ mV_Creator_IsChanged = value; }
      }
   }
}
