using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class FHelper_Price
   {
      /// <summary>
      /// 外协价格序号
      /// </summary>
      private int fP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_ID_IsChanged=false;
      /// <summary>
      /// 外协价格序号
      /// </summary>
      public int FP_ID
      {
         get{ return fP_ID; }
         set{ fP_ID = value; fP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 外协价格序号
      /// </summary>
      public bool FP_ID_IsChanged
      {
         get{ return fP_ID_IsChanged; }
         set{ fP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 外协价格编码
      /// </summary>
      private string fP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_Code_IsChanged=false;
      /// <summary>
      /// 外协价格编码
      /// </summary>
      public string FP_Code
      {
         get{ return fP_Code; }
         set{ fP_Code = value; fP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 外协价格编码
      /// </summary>
      public bool FP_Code_IsChanged
      {
         get{ return fP_Code_IsChanged; }
         set{ fP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家名称
      /// </summary>
      private string fP_ManuName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_ManuName_IsChanged=false;
      /// <summary>
      /// 外协厂家名称
      /// </summary>
      public string FP_ManuName
      {
         get{ return fP_ManuName; }
         set{ fP_ManuName = value; fP_ManuName_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家名称
      /// </summary>
      public bool FP_ManuName_IsChanged
      {
         get{ return fP_ManuName_IsChanged; }
         set{ fP_ManuName_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家编码
      /// </summary>
      private string fP_ManuCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_ManuCode_IsChanged=false;
      /// <summary>
      /// 外协厂家编码
      /// </summary>
      public string FP_ManuCode
      {
         get{ return fP_ManuCode; }
         set{ fP_ManuCode = value; fP_ManuCode_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家编码
      /// </summary>
      public bool FP_ManuCode_IsChanged
      {
         get{ return fP_ManuCode_IsChanged; }
         set{ fP_ManuCode_IsChanged = value; }
      }
      /// <summary>
      /// 外协零件名称
      /// </summary>
      private string fP_CompName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_CompName_IsChanged=false;
      /// <summary>
      /// 外协零件名称
      /// </summary>
      public string FP_CompName
      {
         get{ return fP_CompName; }
         set{ fP_CompName = value; fP_CompName_IsChanged=true; }
      }
      /// <summary>
      /// 外协零件名称
      /// </summary>
      public bool FP_CompName_IsChanged
      {
         get{ return fP_CompName_IsChanged; }
         set{ fP_CompName_IsChanged = value; }
      }
      /// <summary>
      /// 外协零件图号
      /// </summary>
      private string fP_CompCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_CompCode_IsChanged=false;
      /// <summary>
      /// 外协零件图号
      /// </summary>
      public string FP_CompCode
      {
         get{ return fP_CompCode; }
         set{ fP_CompCode = value; fP_CompCode_IsChanged=true; }
      }
      /// <summary>
      /// 外协零件图号
      /// </summary>
      public bool FP_CompCode_IsChanged
      {
         get{ return fP_CompCode_IsChanged; }
         set{ fP_CompCode_IsChanged = value; }
      }
      /// <summary>
      /// 工序节点参考编码（字典）
      /// </summary>
      private string fP_RefComptCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_RefComptCode_IsChanged=false;
      /// <summary>
      /// 工序节点参考编码（字典）
      /// </summary>
      public string FP_RefComptCode
      {
         get{ return fP_RefComptCode; }
         set{ fP_RefComptCode = value; fP_RefComptCode_IsChanged=true; }
      }
      /// <summary>
      /// 工序节点参考编码（字典）
      /// </summary>
      public bool FP_RefComptCode_IsChanged
      {
         get{ return fP_RefComptCode_IsChanged; }
         set{ fP_RefComptCode_IsChanged = value; }
      }
      /// <summary>
      /// 外协工序名称
      /// </summary>
      private string fP_NodeName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_NodeName_IsChanged=false;
      /// <summary>
      /// 外协工序名称
      /// </summary>
      public string FP_NodeName
      {
         get{ return fP_NodeName; }
         set{ fP_NodeName = value; fP_NodeName_IsChanged=true; }
      }
      /// <summary>
      /// 外协工序名称
      /// </summary>
      public bool FP_NodeName_IsChanged
      {
         get{ return fP_NodeName_IsChanged; }
         set{ fP_NodeName_IsChanged = value; }
      }
      /// <summary>
      /// 外协工序编码
      /// </summary>
      private string fP_PNodeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_PNodeCode_IsChanged=false;
      /// <summary>
      /// 外协工序编码
      /// </summary>
      public string FP_PNodeCode
      {
         get{ return fP_PNodeCode; }
         set{ fP_PNodeCode = value; fP_PNodeCode_IsChanged=true; }
      }
      /// <summary>
      /// 外协工序编码
      /// </summary>
      public bool FP_PNodeCode_IsChanged
      {
         get{ return fP_PNodeCode_IsChanged; }
         set{ fP_PNodeCode_IsChanged = value; }
      }
      private decimal fP_Price;
      private bool fP_Price_IsChanged=false;
      public decimal FP_Price
      {
         get{ return fP_Price; }
         set{ fP_Price = value; fP_Price_IsChanged=true; }
      }
      public bool FP_Price_IsChanged
      {
         get{ return fP_Price_IsChanged; }
         set{ fP_Price_IsChanged = value; }
      }
      /// <summary>
      /// 外协价格创建人
      /// </summary>
      private string fP_Creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_Creator_IsChanged=false;
      /// <summary>
      /// 外协价格创建人
      /// </summary>
      public string FP_Creator
      {
         get{ return fP_Creator; }
         set{ fP_Creator = value; fP_Creator_IsChanged=true; }
      }
      /// <summary>
      /// 外协价格创建人
      /// </summary>
      public bool FP_Creator_IsChanged
      {
         get{ return fP_Creator_IsChanged; }
         set{ fP_Creator_IsChanged = value; }
      }
      /// <summary>
      /// 外协价格创建时间
      /// </summary>
      private DateTime fP_Creatime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_Creatime_IsChanged=false;
      /// <summary>
      /// 外协价格创建时间
      /// </summary>
      public DateTime FP_Creatime
      {
         get{ return fP_Creatime; }
         set{ fP_Creatime = value; fP_Creatime_IsChanged=true; }
      }
      /// <summary>
      /// 外协价格创建时间
      /// </summary>
      public bool FP_Creatime_IsChanged
      {
         get{ return fP_Creatime_IsChanged; }
         set{ fP_Creatime_IsChanged = value; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      private string fP_CurNode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_CurNode_IsChanged=false;
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public string FP_CurNode
      {
         get{ return fP_CurNode; }
         set{ fP_CurNode = value; fP_CurNode_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public bool FP_CurNode_IsChanged
      {
         get{ return fP_CurNode_IsChanged; }
         set{ fP_CurNode_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string fP_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fP_Stat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string FP_Stat
      {
         get{ return fP_Stat; }
         set{ fP_Stat = value; fP_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool FP_Stat_IsChanged
      {
         get{ return fP_Stat_IsChanged; }
         set{ fP_Stat_IsChanged = value; }
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
   }
}
