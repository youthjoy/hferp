using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 生产计划(产品计划)
   /// </summary>
   [Serializable]
   public partial class Prod_PlanProd
   {
      private Int64 planProd_ID;
      private bool planProd_ID_IsChanged=false;
      public Int64 PlanProd_ID
      {
         get{ return planProd_ID; }
         set{ planProd_ID = value; planProd_ID_IsChanged=true; }
      }
      public bool PlanProd_ID_IsChanged
      {
         get{ return planProd_ID_IsChanged; }
         set{ planProd_ID_IsChanged = value; }
      }
      private string planProd_PlanCode;
      private bool planProd_PlanCode_IsChanged=false;
      public string PlanProd_PlanCode
      {
         get{ return planProd_PlanCode; }
         set{ planProd_PlanCode = value; planProd_PlanCode_IsChanged=true; }
      }
      public bool PlanProd_PlanCode_IsChanged
      {
         get{ return planProd_PlanCode_IsChanged; }
         set{ planProd_PlanCode_IsChanged = value; }
      }
      private string planProd_Code;
      private bool planProd_Code_IsChanged=false;
      public string PlanProd_Code
      {
         get{ return planProd_Code; }
         set{ planProd_Code = value; planProd_Code_IsChanged=true; }
      }
      public bool PlanProd_Code_IsChanged
      {
         get{ return planProd_Code_IsChanged; }
         set{ planProd_Code_IsChanged = value; }
      }
      private string planProd_TaskDetailCode;
      private bool planProd_TaskDetailCode_IsChanged=false;
      public string PlanProd_TaskDetailCode
      {
         get{ return planProd_TaskDetailCode; }
         set{ planProd_TaskDetailCode = value; planProd_TaskDetailCode_IsChanged=true; }
      }
      public bool PlanProd_TaskDetailCode_IsChanged
      {
         get{ return planProd_TaskDetailCode_IsChanged; }
         set{ planProd_TaskDetailCode_IsChanged = value; }
      }
      private string planProd_TaskCode;
      private bool planProd_TaskCode_IsChanged=false;
      public string PlanProd_TaskCode
      {
         get{ return planProd_TaskCode; }
         set{ planProd_TaskCode = value; planProd_TaskCode_IsChanged=true; }
      }
      public bool PlanProd_TaskCode_IsChanged
      {
         get{ return planProd_TaskCode_IsChanged; }
         set{ planProd_TaskCode_IsChanged = value; }
      }
      private string planProd_CmdDetailCode;
      private bool planProd_CmdDetailCode_IsChanged=false;
      public string PlanProd_CmdDetailCode
      {
         get{ return planProd_CmdDetailCode; }
         set{ planProd_CmdDetailCode = value; planProd_CmdDetailCode_IsChanged=true; }
      }
      public bool PlanProd_CmdDetailCode_IsChanged
      {
         get{ return planProd_CmdDetailCode_IsChanged; }
         set{ planProd_CmdDetailCode_IsChanged = value; }
      }
      private string planProd_CmdCode;
      private bool planProd_CmdCode_IsChanged=false;
      public string PlanProd_CmdCode
      {
         get{ return planProd_CmdCode; }
         set{ planProd_CmdCode = value; planProd_CmdCode_IsChanged=true; }
      }
      public bool PlanProd_CmdCode_IsChanged
      {
         get{ return planProd_CmdCode_IsChanged; }
         set{ planProd_CmdCode_IsChanged = value; }
      }
      private string planProd_Period;
      private bool planProd_Period_IsChanged=false;
      public string PlanProd_Period
      {
         get{ return planProd_Period; }
         set{ planProd_Period = value; planProd_Period_IsChanged=true; }
      }
      public bool PlanProd_Period_IsChanged
      {
         get{ return planProd_Period_IsChanged; }
         set{ planProd_Period_IsChanged = value; }
      }
      private string planProd_PartNo;
      private bool planProd_PartNo_IsChanged=false;
      public string PlanProd_PartNo
      {
         get{ return planProd_PartNo; }
         set{ planProd_PartNo = value; planProd_PartNo_IsChanged=true; }
      }
      public bool PlanProd_PartNo_IsChanged
      {
         get{ return planProd_PartNo_IsChanged; }
         set{ planProd_PartNo_IsChanged = value; }
      }
      private string planProd_PartName;
      private bool planProd_PartName_IsChanged=false;
      public string PlanProd_PartName
      {
         get{ return planProd_PartName; }
         set{ planProd_PartName = value; planProd_PartName_IsChanged=true; }
      }
      public bool PlanProd_PartName_IsChanged
      {
         get{ return planProd_PartName_IsChanged; }
         set{ planProd_PartName_IsChanged = value; }
      }
      private int planProd_Num;
      private bool planProd_Num_IsChanged=false;
      public int PlanProd_Num
      {
         get{ return planProd_Num; }
         set{ planProd_Num = value; planProd_Num_IsChanged=true; }
      }
      public bool PlanProd_Num_IsChanged
      {
         get{ return planProd_Num_IsChanged; }
         set{ planProd_Num_IsChanged = value; }
      }
      private int planProd_FNum;
      private bool planProd_FNum_IsChanged=false;
      public int PlanProd_FNum
      {
         get{ return planProd_FNum; }
         set{ planProd_FNum = value; planProd_FNum_IsChanged=true; }
      }
      public bool PlanProd_FNum_IsChanged
      {
         get{ return planProd_FNum_IsChanged; }
         set{ planProd_FNum_IsChanged = value; }
      }
      private DateTime planProd_Begin;
      private bool planProd_Begin_IsChanged=false;
      public DateTime PlanProd_Begin
      {
         get{ return planProd_Begin; }
         set{ planProd_Begin = value; planProd_Begin_IsChanged=true; }
      }
      public bool PlanProd_Begin_IsChanged
      {
         get{ return planProd_Begin_IsChanged; }
         set{ planProd_Begin_IsChanged = value; }
      }
      private DateTime planProd_End;
      private bool planProd_End_IsChanged=false;
      public DateTime PlanProd_End
      {
         get{ return planProd_End; }
         set{ planProd_End = value; planProd_End_IsChanged=true; }
      }
      public bool PlanProd_End_IsChanged
      {
         get{ return planProd_End_IsChanged; }
         set{ planProd_End_IsChanged = value; }
      }
      private string planProd_LineCode;
      private bool planProd_LineCode_IsChanged=false;
      public string PlanProd_LineCode
      {
         get{ return planProd_LineCode; }
         set{ planProd_LineCode = value; planProd_LineCode_IsChanged=true; }
      }
      public bool PlanProd_LineCode_IsChanged
      {
         get{ return planProd_LineCode_IsChanged; }
         set{ planProd_LineCode_IsChanged = value; }
      }
      private string planProd_FStat;
      private bool planProd_FStat_IsChanged=false;
      public string PlanProd_FStat
      {
         get{ return planProd_FStat; }
         set{ planProd_FStat = value; planProd_FStat_IsChanged=true; }
      }
      public bool PlanProd_FStat_IsChanged
      {
         get{ return planProd_FStat_IsChanged; }
         set{ planProd_FStat_IsChanged = value; }
      }
      private DateTime planProd_FBDate;
      private bool planProd_FBDate_IsChanged=false;
      public DateTime PlanProd_FBDate
      {
         get{ return planProd_FBDate; }
         set{ planProd_FBDate = value; planProd_FBDate_IsChanged=true; }
      }
      public bool PlanProd_FBDate_IsChanged
      {
         get{ return planProd_FBDate_IsChanged; }
         set{ planProd_FBDate_IsChanged = value; }
      }
      private DateTime planProd_FDate;
      private bool planProd_FDate_IsChanged=false;
      public DateTime PlanProd_FDate
      {
         get{ return planProd_FDate; }
         set{ planProd_FDate = value; planProd_FDate_IsChanged=true; }
      }
      public bool PlanProd_FDate_IsChanged
      {
         get{ return planProd_FDate_IsChanged; }
         set{ planProd_FDate_IsChanged = value; }
      }
      private string planProd_ConfirmPep;
      private bool planProd_ConfirmPep_IsChanged=false;
      public string PlanProd_ConfirmPep
      {
         get{ return planProd_ConfirmPep; }
         set{ planProd_ConfirmPep = value; planProd_ConfirmPep_IsChanged=true; }
      }
      public bool PlanProd_ConfirmPep_IsChanged
      {
         get{ return planProd_ConfirmPep_IsChanged; }
         set{ planProd_ConfirmPep_IsChanged = value; }
      }
      private string planProd_Owner;
      private bool planProd_Owner_IsChanged=false;
      public string PlanProd_Owner
      {
         get{ return planProd_Owner; }
         set{ planProd_Owner = value; planProd_Owner_IsChanged=true; }
      }
      public bool PlanProd_Owner_IsChanged
      {
         get{ return planProd_Owner_IsChanged; }
         set{ planProd_Owner_IsChanged = value; }
      }
      private DateTime planProd_Date;
      private bool planProd_Date_IsChanged=false;
      public DateTime PlanProd_Date
      {
         get{ return planProd_Date; }
         set{ planProd_Date = value; planProd_Date_IsChanged=true; }
      }
      public bool PlanProd_Date_IsChanged
      {
         get{ return planProd_Date_IsChanged; }
         set{ planProd_Date_IsChanged = value; }
      }
      private string planProd_Bak;
      private bool planProd_Bak_IsChanged=false;
      public string PlanProd_Bak
      {
         get{ return planProd_Bak; }
         set{ planProd_Bak = value; planProd_Bak_IsChanged=true; }
      }
      public bool PlanProd_Bak_IsChanged
      {
         get{ return planProd_Bak_IsChanged; }
         set{ planProd_Bak_IsChanged = value; }
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
      private string planProd_Patch;
      private bool planProd_Patch_IsChanged=false;
      public string PlanProd_Patch
      {
         get{ return planProd_Patch; }
         set{ planProd_Patch = value; planProd_Patch_IsChanged=true; }
      }
      public bool PlanProd_Patch_IsChanged
      {
         get{ return planProd_Patch_IsChanged; }
         set{ planProd_Patch_IsChanged = value; }
      }
      private DateTime planProd_ActBTime;
      private bool planProd_ActBTime_IsChanged=false;
      public DateTime PlanProd_ActBTime
      {
         get{ return planProd_ActBTime; }
         set{ planProd_ActBTime = value; planProd_ActBTime_IsChanged=true; }
      }
      public bool PlanProd_ActBTime_IsChanged
      {
         get{ return planProd_ActBTime_IsChanged; }
         set{ planProd_ActBTime_IsChanged = value; }
      }
      private DateTime planProd_ActETime;
      private bool planProd_ActETime_IsChanged=false;
      public DateTime PlanProd_ActETime
      {
         get{ return planProd_ActETime; }
         set{ planProd_ActETime = value; planProd_ActETime_IsChanged=true; }
      }
      public bool PlanProd_ActETime_IsChanged
      {
         get{ return planProd_ActETime_IsChanged; }
         set{ planProd_ActETime_IsChanged = value; }
      }
      private string planProd_MPatchCode;
      private bool planProd_MPatchCode_IsChanged=false;
      public string PlanProd_MPatchCode
      {
         get{ return planProd_MPatchCode; }
         set{ planProd_MPatchCode = value; planProd_MPatchCode_IsChanged=true; }
      }
      public bool PlanProd_MPatchCode_IsChanged
      {
         get{ return planProd_MPatchCode_IsChanged; }
         set{ planProd_MPatchCode_IsChanged = value; }
      }
      private string planProd_MainPatch;
      private bool planProd_MainPatch_IsChanged=false;
      public string PlanProd_MainPatch
      {
         get{ return planProd_MainPatch; }
         set{ planProd_MainPatch = value; planProd_MainPatch_IsChanged=true; }
      }
      public bool PlanProd_MainPatch_IsChanged
      {
         get{ return planProd_MainPatch_IsChanged; }
         set{ planProd_MainPatch_IsChanged = value; }
      }
   }
}
