using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 经营处合同信息
   /// </summary>
   [Serializable]
   public partial class SD_Contract
   {
      /// <summary>
      /// 合同序号
      /// </summary>
      private Int64 contract_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_ID_IsChanged=false;
      /// <summary>
      /// 合同序号
      /// </summary>
      public Int64 Contract_ID
      {
         get{ return contract_ID; }
         set{ contract_ID = value; contract_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同序号
      /// </summary>
      public bool Contract_ID_IsChanged
      {
         get{ return contract_ID_IsChanged; }
         set{ contract_ID_IsChanged = value; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      private string contract_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Code_IsChanged=false;
      /// <summary>
      /// 合同编号
      /// </summary>
      public string Contract_Code
      {
         get{ return contract_Code; }
         set{ contract_Code = value; contract_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      public bool Contract_Code_IsChanged
      {
         get{ return contract_Code_IsChanged; }
         set{ contract_Code_IsChanged = value; }
      }
      /// <summary>
      /// 合同名称
      /// </summary>
      private string contract_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Name_IsChanged=false;
      /// <summary>
      /// 合同名称
      /// </summary>
      public string Contract_Name
      {
         get{ return contract_Name; }
         set{ contract_Name = value; contract_Name_IsChanged=true; }
      }
      /// <summary>
      /// 合同名称
      /// </summary>
      public bool Contract_Name_IsChanged
      {
         get{ return contract_Name_IsChanged; }
         set{ contract_Name_IsChanged = value; }
      }
      /// <summary>
      /// 签订日期
      /// </summary>
      private DateTime contract_CDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CDate_IsChanged=false;
      /// <summary>
      /// 签订日期
      /// </summary>
      public DateTime Contract_CDate
      {
         get{ return contract_CDate; }
         set{ contract_CDate = value; contract_CDate_IsChanged=true; }
      }
      /// <summary>
      /// 签订日期
      /// </summary>
      public bool Contract_CDate_IsChanged
      {
         get{ return contract_CDate_IsChanged; }
         set{ contract_CDate_IsChanged = value; }
      }
      /// <summary>
      /// 有效日期
      /// </summary>
      private DateTime contract_EffectDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_EffectDate_IsChanged=false;
      /// <summary>
      /// 有效日期
      /// </summary>
      public DateTime Contract_EffectDate
      {
         get{ return contract_EffectDate; }
         set{ contract_EffectDate = value; contract_EffectDate_IsChanged=true; }
      }
      /// <summary>
      /// 有效日期
      /// </summary>
      public bool Contract_EffectDate_IsChanged
      {
         get{ return contract_EffectDate_IsChanged; }
         set{ contract_EffectDate_IsChanged = value; }
      }
      /// <summary>
      /// 合同负责人名称
      /// </summary>
      private string contract_OwnerName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_OwnerName_IsChanged=false;
      /// <summary>
      /// 合同负责人名称
      /// </summary>
      public string Contract_OwnerName
      {
         get{ return contract_OwnerName; }
         set{ contract_OwnerName = value; contract_OwnerName_IsChanged=true; }
      }
      /// <summary>
      /// 合同负责人名称
      /// </summary>
      public bool Contract_OwnerName_IsChanged
      {
         get{ return contract_OwnerName_IsChanged; }
         set{ contract_OwnerName_IsChanged = value; }
      }
      /// <summary>
      /// 合同负责人
      /// </summary>
      private string contract_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Owner_IsChanged=false;
      /// <summary>
      /// 合同负责人
      /// </summary>
      public string Contract_Owner
      {
         get{ return contract_Owner; }
         set{ contract_Owner = value; contract_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 合同负责人
      /// </summary>
      public bool Contract_Owner_IsChanged
      {
         get{ return contract_Owner_IsChanged; }
         set{ contract_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 合同单位负责人
      /// </summary>
      private string contract_CustOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CustOwner_IsChanged=false;
      /// <summary>
      /// 合同单位负责人
      /// </summary>
      public string Contract_CustOwner
      {
         get{ return contract_CustOwner; }
         set{ contract_CustOwner = value; contract_CustOwner_IsChanged=true; }
      }
      /// <summary>
      /// 合同单位负责人
      /// </summary>
      public bool Contract_CustOwner_IsChanged
      {
         get{ return contract_CustOwner_IsChanged; }
         set{ contract_CustOwner_IsChanged = value; }
      }
      /// <summary>
      /// 合同单位联系方式
      /// </summary>
      private string contract_CustLink;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CustLink_IsChanged=false;
      /// <summary>
      /// 合同单位联系方式
      /// </summary>
      public string Contract_CustLink
      {
         get{ return contract_CustLink; }
         set{ contract_CustLink = value; contract_CustLink_IsChanged=true; }
      }
      /// <summary>
      /// 合同单位联系方式
      /// </summary>
      public bool Contract_CustLink_IsChanged
      {
         get{ return contract_CustLink_IsChanged; }
         set{ contract_CustLink_IsChanged = value; }
      }
      /// <summary>
      /// 合同类别
      /// </summary>
      private string contract_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Type_IsChanged=false;
      /// <summary>
      /// 合同类别
      /// </summary>
      public string Contract_Type
      {
         get{ return contract_Type; }
         set{ contract_Type = value; contract_Type_IsChanged=true; }
      }
      /// <summary>
      /// 合同类别
      /// </summary>
      public bool Contract_Type_IsChanged
      {
         get{ return contract_Type_IsChanged; }
         set{ contract_Type_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string contract_CustCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CustCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string Contract_CustCode
      {
         get{ return contract_CustCode; }
         set{ contract_CustCode = value; contract_CustCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool Contract_CustCode_IsChanged
      {
         get{ return contract_CustCode_IsChanged; }
         set{ contract_CustCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string contract_CustName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CustName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string Contract_CustName
      {
         get{ return contract_CustName; }
         set{ contract_CustName = value; contract_CustName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool Contract_CustName_IsChanged
      {
         get{ return contract_CustName_IsChanged; }
         set{ contract_CustName_IsChanged = value; }
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
      /// 合同状态
      /// </summary>
      private string contract_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Stat_IsChanged=false;
      /// <summary>
      /// 合同状态
      /// </summary>
      public string Contract_Stat
      {
         get{ return contract_Stat; }
         set{ contract_Stat = value; contract_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 合同状态
      /// </summary>
      public bool Contract_Stat_IsChanged
      {
         get{ return contract_Stat_IsChanged; }
         set{ contract_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 状态修改时间
      /// </summary>
      private DateTime contract_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Date_IsChanged=false;
      /// <summary>
      /// 状态修改时间
      /// </summary>
      public DateTime Contract_Date
      {
         get{ return contract_Date; }
         set{ contract_Date = value; contract_Date_IsChanged=true; }
      }
      /// <summary>
      /// 状态修改时间
      /// </summary>
      public bool Contract_Date_IsChanged
      {
         get{ return contract_Date_IsChanged; }
         set{ contract_Date_IsChanged = value; }
      }
      /// <summary>
      /// 合同审核状态
      /// </summary>
      private int contract_VerifyStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_VerifyStat_IsChanged=false;
      /// <summary>
      /// 合同审核状态
      /// </summary>
      public int Contract_VerifyStat
      {
         get{ return contract_VerifyStat; }
         set{ contract_VerifyStat = value; contract_VerifyStat_IsChanged=true; }
      }
      /// <summary>
      /// 合同审核状态
      /// </summary>
      public bool Contract_VerifyStat_IsChanged
      {
         get{ return contract_VerifyStat_IsChanged; }
         set{ contract_VerifyStat_IsChanged = value; }
      }
      /// <summary>
      /// 合同审核时间
      /// </summary>
      private DateTime contract_VerifyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_VerifyDate_IsChanged=false;
      /// <summary>
      /// 合同审核时间
      /// </summary>
      public DateTime Contract_VerifyDate
      {
         get{ return contract_VerifyDate; }
         set{ contract_VerifyDate = value; contract_VerifyDate_IsChanged=true; }
      }
      /// <summary>
      /// 合同审核时间
      /// </summary>
      public bool Contract_VerifyDate_IsChanged
      {
         get{ return contract_VerifyDate_IsChanged; }
         set{ contract_VerifyDate_IsChanged = value; }
      }
      /// <summary>
      /// 下一审核节点
      /// </summary>
      private int contract_VerifyNextNode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_VerifyNextNode_IsChanged=false;
      /// <summary>
      /// 下一审核节点
      /// </summary>
      public int Contract_VerifyNextNode
      {
         get{ return contract_VerifyNextNode; }
         set{ contract_VerifyNextNode = value; contract_VerifyNextNode_IsChanged=true; }
      }
      /// <summary>
      /// 下一审核节点
      /// </summary>
      public bool Contract_VerifyNextNode_IsChanged
      {
         get{ return contract_VerifyNextNode_IsChanged; }
         set{ contract_VerifyNextNode_IsChanged = value; }
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
      private string contract_Bak;
      private bool contract_Bak_IsChanged=false;
      public string Contract_Bak
      {
         get{ return contract_Bak; }
         set{ contract_Bak = value; contract_Bak_IsChanged=true; }
      }
      public bool Contract_Bak_IsChanged
      {
         get{ return contract_Bak_IsChanged; }
         set{ contract_Bak_IsChanged = value; }
      }
      private string contract_Creator;
      private bool contract_Creator_IsChanged=false;
      public string Contract_Creator
      {
         get{ return contract_Creator; }
         set{ contract_Creator = value; contract_Creator_IsChanged=true; }
      }
      public bool Contract_Creator_IsChanged
      {
         get{ return contract_Creator_IsChanged; }
         set{ contract_Creator_IsChanged = value; }
      }
      private string contract_Cmd;
      private bool contract_Cmd_IsChanged=false;
      public string Contract_Cmd
      {
         get{ return contract_Cmd; }
         set{ contract_Cmd = value; contract_Cmd_IsChanged=true; }
      }
      public bool Contract_Cmd_IsChanged
      {
         get{ return contract_Cmd_IsChanged; }
         set{ contract_Cmd_IsChanged = value; }
      }
      private string contract_Project;
      private bool contract_Project_IsChanged=false;
      public string Contract_Project
      {
         get{ return contract_Project; }
         set{ contract_Project = value; contract_Project_IsChanged=true; }
      }
      public bool Contract_Project_IsChanged
      {
         get{ return contract_Project_IsChanged; }
         set{ contract_Project_IsChanged = value; }
      }
   }
}
