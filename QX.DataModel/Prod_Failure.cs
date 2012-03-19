using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 设备故障记录
   /// </summary>
   [Serializable]
   public partial class Prod_Failure
   {
      /// <summary>
      /// 故障序号
      /// </summary>
      private decimal failure_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_ID_IsChanged=false;
      /// <summary>
      /// 故障序号
      /// </summary>
      public decimal Failure_ID
      {
         get{ return failure_ID; }
         set{ failure_ID = value; failure_ID_IsChanged=true; }
      }
      /// <summary>
      /// 故障序号
      /// </summary>
      public bool Failure_ID_IsChanged
      {
         get{ return failure_ID_IsChanged; }
         set{ failure_ID_IsChanged = value; }
      }
      private string failure_Code;
      private bool failure_Code_IsChanged=false;
      public string Failure_Code
      {
         get{ return failure_Code; }
         set{ failure_Code = value; failure_Code_IsChanged=true; }
      }
      public bool Failure_Code_IsChanged
      {
         get{ return failure_Code_IsChanged; }
         set{ failure_Code_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点编号
      /// </summary>
      private string failure_NodeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_NodeCode_IsChanged=false;
      /// <summary>
      /// 工艺节点编号
      /// </summary>
      public string Failure_NodeCode
      {
         get{ return failure_NodeCode; }
         set{ failure_NodeCode = value; failure_NodeCode_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点编号
      /// </summary>
      public bool Failure_NodeCode_IsChanged
      {
         get{ return failure_NodeCode_IsChanged; }
         set{ failure_NodeCode_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string failure_PartNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_PartNo_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string Failure_PartNo
      {
         get{ return failure_PartNo; }
         set{ failure_PartNo = value; failure_PartNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool Failure_PartNo_IsChanged
      {
         get{ return failure_PartNo_IsChanged; }
         set{ failure_PartNo_IsChanged = value; }
      }
      private string failure_EquSpec;
      private bool failure_EquSpec_IsChanged=false;
      public string Failure_EquSpec
      {
         get{ return failure_EquSpec; }
         set{ failure_EquSpec = value; failure_EquSpec_IsChanged=true; }
      }
      public bool Failure_EquSpec_IsChanged
      {
         get{ return failure_EquSpec_IsChanged; }
         set{ failure_EquSpec_IsChanged = value; }
      }
      /// <summary>
      /// 零件编号
      /// </summary>
      private string failure_ProdCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_ProdCode_IsChanged=false;
      /// <summary>
      /// 零件编号
      /// </summary>
      public string Failure_ProdCode
      {
         get{ return failure_ProdCode; }
         set{ failure_ProdCode = value; failure_ProdCode_IsChanged=true; }
      }
      /// <summary>
      /// 零件编号
      /// </summary>
      public bool Failure_ProdCode_IsChanged
      {
         get{ return failure_ProdCode_IsChanged; }
         set{ failure_ProdCode_IsChanged = value; }
      }
      /// <summary>
      /// 故障设备编号
      /// </summary>
      private string failure_EquCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_EquCode_IsChanged=false;
      /// <summary>
      /// 故障设备编号
      /// </summary>
      public string Failure_EquCode
      {
         get{ return failure_EquCode; }
         set{ failure_EquCode = value; failure_EquCode_IsChanged=true; }
      }
      /// <summary>
      /// 故障设备编号
      /// </summary>
      public bool Failure_EquCode_IsChanged
      {
         get{ return failure_EquCode_IsChanged; }
         set{ failure_EquCode_IsChanged = value; }
      }
      /// <summary>
      /// 故障设备名称
      /// </summary>
      private string failure_EquName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_EquName_IsChanged=false;
      /// <summary>
      /// 故障设备名称
      /// </summary>
      public string Failure_EquName
      {
         get{ return failure_EquName; }
         set{ failure_EquName = value; failure_EquName_IsChanged=true; }
      }
      /// <summary>
      /// 故障设备名称
      /// </summary>
      public bool Failure_EquName_IsChanged
      {
         get{ return failure_EquName_IsChanged; }
         set{ failure_EquName_IsChanged = value; }
      }
      /// <summary>
      /// 故障时间
      /// </summary>
      private DateTime failure_Time;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_Time_IsChanged=false;
      /// <summary>
      /// 故障时间
      /// </summary>
      public DateTime Failure_Time
      {
         get{ return failure_Time; }
         set{ failure_Time = value; failure_Time_IsChanged=true; }
      }
      /// <summary>
      /// 故障时间
      /// </summary>
      public bool Failure_Time_IsChanged
      {
         get{ return failure_Time_IsChanged; }
         set{ failure_Time_IsChanged = value; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      private string failure_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_Owner_IsChanged=false;
      /// <summary>
      /// 责任人
      /// </summary>
      public string Failure_Owner
      {
         get{ return failure_Owner; }
         set{ failure_Owner = value; failure_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      public bool Failure_Owner_IsChanged
      {
         get{ return failure_Owner_IsChanged; }
         set{ failure_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 维修状态
      /// </summary>
      private int failure_OPStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_OPStat_IsChanged=false;
      /// <summary>
      /// 维修状态
      /// </summary>
      public int Failure_OPStat
      {
         get{ return failure_OPStat; }
         set{ failure_OPStat = value; failure_OPStat_IsChanged=true; }
      }
      /// <summary>
      /// 维修状态
      /// </summary>
      public bool Failure_OPStat_IsChanged
      {
         get{ return failure_OPStat_IsChanged; }
         set{ failure_OPStat_IsChanged = value; }
      }
      /// <summary>
      /// 维修人
      /// </summary>
      private string failure_MaintainPep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_MaintainPep_IsChanged=false;
      /// <summary>
      /// 维修人
      /// </summary>
      public string Failure_MaintainPep
      {
         get{ return failure_MaintainPep; }
         set{ failure_MaintainPep = value; failure_MaintainPep_IsChanged=true; }
      }
      /// <summary>
      /// 维修人
      /// </summary>
      public bool Failure_MaintainPep_IsChanged
      {
         get{ return failure_MaintainPep_IsChanged; }
         set{ failure_MaintainPep_IsChanged = value; }
      }
      /// <summary>
      /// 维修人电话
      /// </summary>
      private string failure_MaintainTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_MaintainTel_IsChanged=false;
      /// <summary>
      /// 维修人电话
      /// </summary>
      public string Failure_MaintainTel
      {
         get{ return failure_MaintainTel; }
         set{ failure_MaintainTel = value; failure_MaintainTel_IsChanged=true; }
      }
      /// <summary>
      /// 维修人电话
      /// </summary>
      public bool Failure_MaintainTel_IsChanged
      {
         get{ return failure_MaintainTel_IsChanged; }
         set{ failure_MaintainTel_IsChanged = value; }
      }
      /// <summary>
      /// 修复时间
      /// </summary>
      private DateTime failure_FTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_FTime_IsChanged=false;
      /// <summary>
      /// 修复时间
      /// </summary>
      public DateTime Failure_FTime
      {
         get{ return failure_FTime; }
         set{ failure_FTime = value; failure_FTime_IsChanged=true; }
      }
      /// <summary>
      /// 修复时间
      /// </summary>
      public bool Failure_FTime_IsChanged
      {
         get{ return failure_FTime_IsChanged; }
         set{ failure_FTime_IsChanged = value; }
      }
      /// <summary>
      /// 故障状态
      /// </summary>
      private string failure_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_Stat_IsChanged=false;
      /// <summary>
      /// 故障状态
      /// </summary>
      public string Failure_Stat
      {
         get{ return failure_Stat; }
         set{ failure_Stat = value; failure_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 故障状态
      /// </summary>
      public bool Failure_Stat_IsChanged
      {
         get{ return failure_Stat_IsChanged; }
         set{ failure_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 故障描述
      /// </summary>
      private string failure_Desp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_Desp_IsChanged=false;
      /// <summary>
      /// 故障描述
      /// </summary>
      public string Failure_Desp
      {
         get{ return failure_Desp; }
         set{ failure_Desp = value; failure_Desp_IsChanged=true; }
      }
      /// <summary>
      /// 故障描述
      /// </summary>
      public bool Failure_Desp_IsChanged
      {
         get{ return failure_Desp_IsChanged; }
         set{ failure_Desp_IsChanged = value; }
      }
      /// <summary>
      /// 故障分类编号
      /// </summary>
      private string failure_CatCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_CatCode_IsChanged=false;
      /// <summary>
      /// 故障分类编号
      /// </summary>
      public string Failure_CatCode
      {
         get{ return failure_CatCode; }
         set{ failure_CatCode = value; failure_CatCode_IsChanged=true; }
      }
      /// <summary>
      /// 故障分类编号
      /// </summary>
      public bool Failure_CatCode_IsChanged
      {
         get{ return failure_CatCode_IsChanged; }
         set{ failure_CatCode_IsChanged = value; }
      }
      /// <summary>
      /// 故障分类名称
      /// </summary>
      private string failure_CatName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_CatName_IsChanged=false;
      /// <summary>
      /// 故障分类名称
      /// </summary>
      public string Failure_CatName
      {
         get{ return failure_CatName; }
         set{ failure_CatName = value; failure_CatName_IsChanged=true; }
      }
      /// <summary>
      /// 故障分类名称
      /// </summary>
      public bool Failure_CatName_IsChanged
      {
         get{ return failure_CatName_IsChanged; }
         set{ failure_CatName_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private int failure_VerifyStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_VerifyStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public int Failure_VerifyStat
      {
         get{ return failure_VerifyStat; }
         set{ failure_VerifyStat = value; failure_VerifyStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool Failure_VerifyStat_IsChanged
      {
         get{ return failure_VerifyStat_IsChanged; }
         set{ failure_VerifyStat_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime failure_VerifyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_VerifyDate_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime Failure_VerifyDate
      {
         get{ return failure_VerifyDate; }
         set{ failure_VerifyDate = value; failure_VerifyDate_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool Failure_VerifyDate_IsChanged
      {
         get{ return failure_VerifyDate_IsChanged; }
         set{ failure_VerifyDate_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string failure_VerifyOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_VerifyOwner_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string Failure_VerifyOwner
      {
         get{ return failure_VerifyOwner; }
         set{ failure_VerifyOwner = value; failure_VerifyOwner_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool Failure_VerifyOwner_IsChanged
      {
         get{ return failure_VerifyOwner_IsChanged; }
         set{ failure_VerifyOwner_IsChanged = value; }
      }
      /// <summary>
      /// 故障解决方案
      /// </summary>
      private string failure_VerifySol;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool failure_VerifySol_IsChanged=false;
      /// <summary>
      /// 故障解决方案
      /// </summary>
      public string Failure_VerifySol
      {
         get{ return failure_VerifySol; }
         set{ failure_VerifySol = value; failure_VerifySol_IsChanged=true; }
      }
      /// <summary>
      /// 故障解决方案
      /// </summary>
      public bool Failure_VerifySol_IsChanged
      {
         get{ return failure_VerifySol_IsChanged; }
         set{ failure_VerifySol_IsChanged = value; }
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
   }
}
