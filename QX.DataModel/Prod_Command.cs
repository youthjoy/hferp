using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 生产指令表
   /// </summary>
   [Serializable]
   public partial class Prod_Command
   {
      /// <summary>
      /// 生产指令序号
      /// </summary>
      private Int64 cmd_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_ID_IsChanged=false;
      /// <summary>
      /// 生产指令序号
      /// </summary>
      public Int64 Cmd_ID
      {
         get{ return cmd_ID; }
         set{ cmd_ID = value; cmd_ID_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令序号
      /// </summary>
      public bool Cmd_ID_IsChanged
      {
         get{ return cmd_ID_IsChanged; }
         set{ cmd_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令编码
      /// </summary>
      private string cmd_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Code_IsChanged=false;
      /// <summary>
      /// 生产指令编码
      /// </summary>
      public string Cmd_Code
      {
         get{ return cmd_Code; }
         set{ cmd_Code = value; cmd_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令编码
      /// </summary>
      public bool Cmd_Code_IsChanged
      {
         get{ return cmd_Code_IsChanged; }
         set{ cmd_Code_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令单位编码
      /// </summary>
      private string cmd_Dep_Code2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Dep_Code2_IsChanged=false;
      /// <summary>
      /// 生产指令单位编码
      /// </summary>
      public string Cmd_Dep_Code2
      {
         get{ return cmd_Dep_Code2; }
         set{ cmd_Dep_Code2 = value; cmd_Dep_Code2_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令单位编码
      /// </summary>
      public bool Cmd_Dep_Code2_IsChanged
      {
         get{ return cmd_Dep_Code2_IsChanged; }
         set{ cmd_Dep_Code2_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令单位名称
      /// </summary>
      private string cmd_Dep_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Dep_Name_IsChanged=false;
      /// <summary>
      /// 生产指令单位名称
      /// </summary>
      public string Cmd_Dep_Name
      {
         get{ return cmd_Dep_Name; }
         set{ cmd_Dep_Name = value; cmd_Dep_Name_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令单位名称
      /// </summary>
      public bool Cmd_Dep_Name_IsChanged
      {
         get{ return cmd_Dep_Name_IsChanged; }
         set{ cmd_Dep_Name_IsChanged = value; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      private string cmd_Contract_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Contract_Code_IsChanged=false;
      /// <summary>
      /// 合同编号
      /// </summary>
      public string Cmd_Contract_Code
      {
         get{ return cmd_Contract_Code; }
         set{ cmd_Contract_Code = value; cmd_Contract_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      public bool Cmd_Contract_Code_IsChanged
      {
         get{ return cmd_Contract_Code_IsChanged; }
         set{ cmd_Contract_Code_IsChanged = value; }
      }
      /// <summary>
      /// 指令类型
      /// </summary>
      private string cmd_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Type_IsChanged=false;
      /// <summary>
      /// 指令类型
      /// </summary>
      public string Cmd_Type
      {
         get{ return cmd_Type; }
         set{ cmd_Type = value; cmd_Type_IsChanged=true; }
      }
      /// <summary>
      /// 指令类型
      /// </summary>
      public bool Cmd_Type_IsChanged
      {
         get{ return cmd_Type_IsChanged; }
         set{ cmd_Type_IsChanged = value; }
      }
      /// <summary>
      /// 承制单位
      /// </summary>
      private string cmd_Supplier;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Supplier_IsChanged=false;
      /// <summary>
      /// 承制单位
      /// </summary>
      public string Cmd_Supplier
      {
         get{ return cmd_Supplier; }
         set{ cmd_Supplier = value; cmd_Supplier_IsChanged=true; }
      }
      /// <summary>
      /// 承制单位
      /// </summary>
      public bool Cmd_Supplier_IsChanged
      {
         get{ return cmd_Supplier_IsChanged; }
         set{ cmd_Supplier_IsChanged = value; }
      }
      /// <summary>
      /// 编制人
      /// </summary>
      private string cmd_CBill;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_CBill_IsChanged=false;
      /// <summary>
      /// 编制人
      /// </summary>
      public string Cmd_CBill
      {
         get{ return cmd_CBill; }
         set{ cmd_CBill = value; cmd_CBill_IsChanged=true; }
      }
      /// <summary>
      /// 编制人
      /// </summary>
      public bool Cmd_CBill_IsChanged
      {
         get{ return cmd_CBill_IsChanged; }
         set{ cmd_CBill_IsChanged = value; }
      }
      /// <summary>
      /// 编制人姓名
      /// </summary>
      private string cmd_CBillName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_CBillName_IsChanged=false;
      /// <summary>
      /// 编制人姓名
      /// </summary>
      public string Cmd_CBillName
      {
         get{ return cmd_CBillName; }
         set{ cmd_CBillName = value; cmd_CBillName_IsChanged=true; }
      }
      /// <summary>
      /// 编制人姓名
      /// </summary>
      public bool Cmd_CBillName_IsChanged
      {
         get{ return cmd_CBillName_IsChanged; }
         set{ cmd_CBillName_IsChanged = value; }
      }
      /// <summary>
      /// 编制时间
      /// </summary>
      private DateTime cmd_CBillTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_CBillTime_IsChanged=false;
      /// <summary>
      /// 编制时间
      /// </summary>
      public DateTime Cmd_CBillTime
      {
         get{ return cmd_CBillTime; }
         set{ cmd_CBillTime = value; cmd_CBillTime_IsChanged=true; }
      }
      /// <summary>
      /// 编制时间
      /// </summary>
      public bool Cmd_CBillTime_IsChanged
      {
         get{ return cmd_CBillTime_IsChanged; }
         set{ cmd_CBillTime_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cmd_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Cmd_Bak
      {
         get{ return cmd_Bak; }
         set{ cmd_Bak = value; cmd_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Cmd_Bak_IsChanged
      {
         get{ return cmd_Bak_IsChanged; }
         set{ cmd_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      private string cmd_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Stat_IsChanged=false;
      /// <summary>
      /// 单据状态
      /// </summary>
      public string Cmd_Stat
      {
         get{ return cmd_Stat; }
         set{ cmd_Stat = value; cmd_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 单据状态
      /// </summary>
      public bool Cmd_Stat_IsChanged
      {
         get{ return cmd_Stat_IsChanged; }
         set{ cmd_Stat_IsChanged = value; }
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
      private DateTime auditDate;
      private bool auditDate_IsChanged=false;
      public DateTime AuditDate
      {
         get{ return auditDate; }
         set{ auditDate = value; auditDate_IsChanged=true; }
      }
      public bool AuditDate_IsChanged
      {
         get{ return auditDate_IsChanged; }
         set{ auditDate_IsChanged = value; }
      }
      private string auditOwner;
      private bool auditOwner_IsChanged=false;
      public string AuditOwner
      {
         get{ return auditOwner; }
         set{ auditOwner = value; auditOwner_IsChanged=true; }
      }
      public bool AuditOwner_IsChanged
      {
         get{ return auditOwner_IsChanged; }
         set{ auditOwner_IsChanged = value; }
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
      private string cmd_Udef1;
      private bool cmd_Udef1_IsChanged=false;
      public string Cmd_Udef1
      {
         get{ return cmd_Udef1; }
         set{ cmd_Udef1 = value; cmd_Udef1_IsChanged=true; }
      }
      public bool Cmd_Udef1_IsChanged
      {
         get{ return cmd_Udef1_IsChanged; }
         set{ cmd_Udef1_IsChanged = value; }
      }
      private string cmd_Udef2;
      private bool cmd_Udef2_IsChanged=false;
      public string Cmd_Udef2
      {
         get{ return cmd_Udef2; }
         set{ cmd_Udef2 = value; cmd_Udef2_IsChanged=true; }
      }
      public bool Cmd_Udef2_IsChanged
      {
         get{ return cmd_Udef2_IsChanged; }
         set{ cmd_Udef2_IsChanged = value; }
      }
      private string cmd_Udef3;
      private bool cmd_Udef3_IsChanged=false;
      public string Cmd_Udef3
      {
         get{ return cmd_Udef3; }
         set{ cmd_Udef3 = value; cmd_Udef3_IsChanged=true; }
      }
      public bool Cmd_Udef3_IsChanged
      {
         get{ return cmd_Udef3_IsChanged; }
         set{ cmd_Udef3_IsChanged = value; }
      }
      private string cmd_Udef4;
      private bool cmd_Udef4_IsChanged=false;
      public string Cmd_Udef4
      {
         get{ return cmd_Udef4; }
         set{ cmd_Udef4 = value; cmd_Udef4_IsChanged=true; }
      }
      public bool Cmd_Udef4_IsChanged
      {
         get{ return cmd_Udef4_IsChanged; }
         set{ cmd_Udef4_IsChanged = value; }
      }
      private int cmd_AllCount;
      private bool cmd_AllCount_IsChanged=false;
      public int Cmd_AllCount
      {
         get{ return cmd_AllCount; }
         set{ cmd_AllCount = value; cmd_AllCount_IsChanged=true; }
      }
      public bool Cmd_AllCount_IsChanged
      {
         get{ return cmd_AllCount_IsChanged; }
         set{ cmd_AllCount_IsChanged = value; }
      }
   }
}
