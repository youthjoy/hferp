using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Prod_Roads
   {
      private Int64 pRoad_ID;
      private bool pRoad_ID_IsChanged=false;
      public Int64 PRoad_ID
      {
         get{ return pRoad_ID; }
         set{ pRoad_ID = value; pRoad_ID_IsChanged=true; }
      }
      public bool PRoad_ID_IsChanged
      {
         get{ return pRoad_ID_IsChanged; }
         set{ pRoad_ID_IsChanged = value; }
      }
      private string pRoad_PlanCode;
      private bool pRoad_PlanCode_IsChanged=false;
      public string PRoad_PlanCode
      {
         get{ return pRoad_PlanCode; }
         set{ pRoad_PlanCode = value; pRoad_PlanCode_IsChanged=true; }
      }
      public bool PRoad_PlanCode_IsChanged
      {
         get{ return pRoad_PlanCode_IsChanged; }
         set{ pRoad_PlanCode_IsChanged = value; }
      }
      private string pRoad_ProdCode;
      private bool pRoad_ProdCode_IsChanged=false;
      public string PRoad_ProdCode
      {
         get{ return pRoad_ProdCode; }
         set{ pRoad_ProdCode = value; pRoad_ProdCode_IsChanged=true; }
      }
      public bool PRoad_ProdCode_IsChanged
      {
         get{ return pRoad_ProdCode_IsChanged; }
         set{ pRoad_ProdCode_IsChanged = value; }
      }
      private string pRoad_CompCode;
      private bool pRoad_CompCode_IsChanged=false;
      public string PRoad_CompCode
      {
         get{ return pRoad_CompCode; }
         set{ pRoad_CompCode = value; pRoad_CompCode_IsChanged=true; }
      }
      public bool PRoad_CompCode_IsChanged
      {
         get{ return pRoad_CompCode_IsChanged; }
         set{ pRoad_CompCode_IsChanged = value; }
      }
      private string pRoad_NodeCode;
      private bool pRoad_NodeCode_IsChanged=false;
      public string PRoad_NodeCode
      {
         get{ return pRoad_NodeCode; }
         set{ pRoad_NodeCode = value; pRoad_NodeCode_IsChanged=true; }
      }
      public bool PRoad_NodeCode_IsChanged
      {
         get{ return pRoad_NodeCode_IsChanged; }
         set{ pRoad_NodeCode_IsChanged = value; }
      }
      private string pRoad_NodeName;
      private bool pRoad_NodeName_IsChanged=false;
      public string PRoad_NodeName
      {
         get{ return pRoad_NodeName; }
         set{ pRoad_NodeName = value; pRoad_NodeName_IsChanged=true; }
      }
      public bool PRoad_NodeName_IsChanged
      {
         get{ return pRoad_NodeName_IsChanged; }
         set{ pRoad_NodeName_IsChanged = value; }
      }
      private string pRoad_NodeDepCode;
      private bool pRoad_NodeDepCode_IsChanged=false;
      public string PRoad_NodeDepCode
      {
         get{ return pRoad_NodeDepCode; }
         set{ pRoad_NodeDepCode = value; pRoad_NodeDepCode_IsChanged=true; }
      }
      public bool PRoad_NodeDepCode_IsChanged
      {
         get{ return pRoad_NodeDepCode_IsChanged; }
         set{ pRoad_NodeDepCode_IsChanged = value; }
      }
      private string pRoad_NodeDepName;
      private bool pRoad_NodeDepName_IsChanged=false;
      public string PRoad_NodeDepName
      {
         get{ return pRoad_NodeDepName; }
         set{ pRoad_NodeDepName = value; pRoad_NodeDepName_IsChanged=true; }
      }
      public bool PRoad_NodeDepName_IsChanged
      {
         get{ return pRoad_NodeDepName_IsChanged; }
         set{ pRoad_NodeDepName_IsChanged = value; }
      }
      private decimal pRoad_TimeCost;
      private bool pRoad_TimeCost_IsChanged=false;
      public decimal PRoad_TimeCost
      {
         get{ return pRoad_TimeCost; }
         set{ pRoad_TimeCost = value; pRoad_TimeCost_IsChanged=true; }
      }
      public bool PRoad_TimeCost_IsChanged
      {
         get{ return pRoad_TimeCost_IsChanged; }
         set{ pRoad_TimeCost_IsChanged = value; }
      }
      private int pRoad_Order;
      private bool pRoad_Order_IsChanged=false;
      public int PRoad_Order
      {
         get{ return pRoad_Order; }
         set{ pRoad_Order = value; pRoad_Order_IsChanged=true; }
      }
      public bool PRoad_Order_IsChanged
      {
         get{ return pRoad_Order_IsChanged; }
         set{ pRoad_Order_IsChanged = value; }
      }
      private DateTime pRoad_Begin;
      private bool pRoad_Begin_IsChanged=false;
      public DateTime PRoad_Begin
      {
         get{ return pRoad_Begin; }
         set{ pRoad_Begin = value; pRoad_Begin_IsChanged=true; }
      }
      public bool PRoad_Begin_IsChanged
      {
         get{ return pRoad_Begin_IsChanged; }
         set{ pRoad_Begin_IsChanged = value; }
      }
      private DateTime pRoad_End;
      private bool pRoad_End_IsChanged=false;
      public DateTime PRoad_End
      {
         get{ return pRoad_End; }
         set{ pRoad_End = value; pRoad_End_IsChanged=true; }
      }
      public bool PRoad_End_IsChanged
      {
         get{ return pRoad_End_IsChanged; }
         set{ pRoad_End_IsChanged = value; }
      }
      private string pRoad_EquCode;
      private bool pRoad_EquCode_IsChanged=false;
      public string PRoad_EquCode
      {
         get{ return pRoad_EquCode; }
         set{ pRoad_EquCode = value; pRoad_EquCode_IsChanged=true; }
      }
      public bool PRoad_EquCode_IsChanged
      {
         get{ return pRoad_EquCode_IsChanged; }
         set{ pRoad_EquCode_IsChanged = value; }
      }
      private string pRoad_EquName;
      private bool pRoad_EquName_IsChanged=false;
      public string PRoad_EquName
      {
         get{ return pRoad_EquName; }
         set{ pRoad_EquName = value; pRoad_EquName_IsChanged=true; }
      }
      public bool PRoad_EquName_IsChanged
      {
         get{ return pRoad_EquName_IsChanged; }
         set{ pRoad_EquName_IsChanged = value; }
      }
      private int pRoad_EquTimeCost;
      private bool pRoad_EquTimeCost_IsChanged=false;
      public int PRoad_EquTimeCost
      {
         get{ return pRoad_EquTimeCost; }
         set{ pRoad_EquTimeCost = value; pRoad_EquTimeCost_IsChanged=true; }
      }
      public bool PRoad_EquTimeCost_IsChanged
      {
         get{ return pRoad_EquTimeCost_IsChanged; }
         set{ pRoad_EquTimeCost_IsChanged = value; }
      }
      private DateTime pRoad_ActBTime;
      private bool pRoad_ActBTime_IsChanged=false;
      public DateTime PRoad_ActBTime
      {
         get{ return pRoad_ActBTime; }
         set{ pRoad_ActBTime = value; pRoad_ActBTime_IsChanged=true; }
      }
      public bool PRoad_ActBTime_IsChanged
      {
         get{ return pRoad_ActBTime_IsChanged; }
         set{ pRoad_ActBTime_IsChanged = value; }
      }
      private DateTime pRoad_ActETime;
      private bool pRoad_ActETime_IsChanged=false;
      public DateTime PRoad_ActETime
      {
         get{ return pRoad_ActETime; }
         set{ pRoad_ActETime = value; pRoad_ActETime_IsChanged=true; }
      }
      public bool PRoad_ActETime_IsChanged
      {
         get{ return pRoad_ActETime_IsChanged; }
         set{ pRoad_ActETime_IsChanged = value; }
      }
      private DateTime pRoad_ActCTime;
      private bool pRoad_ActCTime_IsChanged=false;
      public DateTime PRoad_ActCTime
      {
         get{ return pRoad_ActCTime; }
         set{ pRoad_ActCTime = value; pRoad_ActCTime_IsChanged=true; }
      }
      public bool PRoad_ActCTime_IsChanged
      {
         get{ return pRoad_ActCTime_IsChanged; }
         set{ pRoad_ActCTime_IsChanged = value; }
      }
      private DateTime pRoad_ActRTime;
      private bool pRoad_ActRTime_IsChanged=false;
      public DateTime PRoad_ActRTime
      {
         get{ return pRoad_ActRTime; }
         set{ pRoad_ActRTime = value; pRoad_ActRTime_IsChanged=true; }
      }
      public bool PRoad_ActRTime_IsChanged
      {
         get{ return pRoad_ActRTime_IsChanged; }
         set{ pRoad_ActRTime_IsChanged = value; }
      }
      private decimal pRoad_CostTime;
      private bool pRoad_CostTime_IsChanged=false;
      public decimal PRoad_CostTime
      {
         get{ return pRoad_CostTime; }
         set{ pRoad_CostTime = value; pRoad_CostTime_IsChanged=true; }
      }
      public bool PRoad_CostTime_IsChanged
      {
         get{ return pRoad_CostTime_IsChanged; }
         set{ pRoad_CostTime_IsChanged = value; }
      }
      private DateTime pRoad_FDate;
      private bool pRoad_FDate_IsChanged=false;
      public DateTime PRoad_FDate
      {
         get{ return pRoad_FDate; }
         set{ pRoad_FDate = value; pRoad_FDate_IsChanged=true; }
      }
      public bool PRoad_FDate_IsChanged
      {
         get{ return pRoad_FDate_IsChanged; }
         set{ pRoad_FDate_IsChanged = value; }
      }
      private string pRoad_ConfirmPep;
      private bool pRoad_ConfirmPep_IsChanged=false;
      public string PRoad_ConfirmPep
      {
         get{ return pRoad_ConfirmPep; }
         set{ pRoad_ConfirmPep = value; pRoad_ConfirmPep_IsChanged=true; }
      }
      public bool PRoad_ConfirmPep_IsChanged
      {
         get{ return pRoad_ConfirmPep_IsChanged; }
         set{ pRoad_ConfirmPep_IsChanged = value; }
      }
      private string pRoad_Owner;
      private bool pRoad_Owner_IsChanged=false;
      public string PRoad_Owner
      {
         get{ return pRoad_Owner; }
         set{ pRoad_Owner = value; pRoad_Owner_IsChanged=true; }
      }
      public bool PRoad_Owner_IsChanged
      {
         get{ return pRoad_Owner_IsChanged; }
         set{ pRoad_Owner_IsChanged = value; }
      }
      private DateTime pRoad_Date;
      private bool pRoad_Date_IsChanged=false;
      public DateTime PRoad_Date
      {
         get{ return pRoad_Date; }
         set{ pRoad_Date = value; pRoad_Date_IsChanged=true; }
      }
      public bool PRoad_Date_IsChanged
      {
         get{ return pRoad_Date_IsChanged; }
         set{ pRoad_Date_IsChanged = value; }
      }
      private string pRoad_Bak;
      private bool pRoad_Bak_IsChanged=false;
      public string PRoad_Bak
      {
         get{ return pRoad_Bak; }
         set{ pRoad_Bak = value; pRoad_Bak_IsChanged=true; }
      }
      public bool PRoad_Bak_IsChanged
      {
         get{ return pRoad_Bak_IsChanged; }
         set{ pRoad_Bak_IsChanged = value; }
      }
      private int pRoad_Stat;
      private bool pRoad_Stat_IsChanged=false;
      public int PRoad_Stat
      {
         get{ return pRoad_Stat; }
         set{ pRoad_Stat = value; pRoad_Stat_IsChanged=true; }
      }
      public bool PRoad_Stat_IsChanged
      {
         get{ return pRoad_Stat_IsChanged; }
         set{ pRoad_Stat_IsChanged = value; }
      }
      private bool pRoad_IsQuality;
      private bool pRoad_IsQuality_IsChanged=false;
      public bool PRoad_IsQuality
      {
         get{ return pRoad_IsQuality; }
         set{ pRoad_IsQuality = value; pRoad_IsQuality_IsChanged=true; }
      }
      public bool PRoad_IsQuality_IsChanged
      {
         get{ return pRoad_IsQuality_IsChanged; }
         set{ pRoad_IsQuality_IsChanged = value; }
      }
      private bool pRoad_IsDone;
      private bool pRoad_IsDone_IsChanged=false;
      public bool PRoad_IsDone
      {
         get{ return pRoad_IsDone; }
         set{ pRoad_IsDone = value; pRoad_IsDone_IsChanged=true; }
      }
      public bool PRoad_IsDone_IsChanged
      {
         get{ return pRoad_IsDone_IsChanged; }
         set{ pRoad_IsDone_IsChanged = value; }
      }
      private int pRoad_IsCurrent;
      private bool pRoad_IsCurrent_IsChanged=false;
      public int PRoad_IsCurrent
      {
         get{ return pRoad_IsCurrent; }
         set{ pRoad_IsCurrent = value; pRoad_IsCurrent_IsChanged=true; }
      }
      public bool PRoad_IsCurrent_IsChanged
      {
         get{ return pRoad_IsCurrent_IsChanged; }
         set{ pRoad_IsCurrent_IsChanged = value; }
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
      private string pRoad_RTicker;
      private bool pRoad_RTicker_IsChanged=false;
      public string PRoad_RTicker
      {
         get{ return pRoad_RTicker; }
         set{ pRoad_RTicker = value; pRoad_RTicker_IsChanged=true; }
      }
      public bool PRoad_RTicker_IsChanged
      {
         get{ return pRoad_RTicker_IsChanged; }
         set{ pRoad_RTicker_IsChanged = value; }
      }
      private string pRoad_ClassCode;
      private bool pRoad_ClassCode_IsChanged=false;
      public string PRoad_ClassCode
      {
         get{ return pRoad_ClassCode; }
         set{ pRoad_ClassCode = value; pRoad_ClassCode_IsChanged=true; }
      }
      public bool PRoad_ClassCode_IsChanged
      {
         get{ return pRoad_ClassCode_IsChanged; }
         set{ pRoad_ClassCode_IsChanged = value; }
      }
      private string pRoad_ClassName;
      private bool pRoad_ClassName_IsChanged=false;
      public string PRoad_ClassName
      {
         get{ return pRoad_ClassName; }
         set{ pRoad_ClassName = value; pRoad_ClassName_IsChanged=true; }
      }
      public bool PRoad_ClassName_IsChanged
      {
         get{ return pRoad_ClassName_IsChanged; }
         set{ pRoad_ClassName_IsChanged = value; }
      }
      private string pRoad_Udef1;
      private bool pRoad_Udef1_IsChanged=false;
      public string PRoad_Udef1
      {
         get{ return pRoad_Udef1; }
         set{ pRoad_Udef1 = value; pRoad_Udef1_IsChanged=true; }
      }
      public bool PRoad_Udef1_IsChanged
      {
         get{ return pRoad_Udef1_IsChanged; }
         set{ pRoad_Udef1_IsChanged = value; }
      }
      private string pRoad_Udef2;
      private bool pRoad_Udef2_IsChanged=false;
      public string PRoad_Udef2
      {
         get{ return pRoad_Udef2; }
         set{ pRoad_Udef2 = value; pRoad_Udef2_IsChanged=true; }
      }
      public bool PRoad_Udef2_IsChanged
      {
         get{ return pRoad_Udef2_IsChanged; }
         set{ pRoad_Udef2_IsChanged = value; }
      }
      private int pRoad_IsFix;
      private bool pRoad_IsFix_IsChanged=false;
      public int PRoad_IsFix
      {
         get{ return pRoad_IsFix; }
         set{ pRoad_IsFix = value; pRoad_IsFix_IsChanged=true; }
      }
      public bool PRoad_IsFix_IsChanged
      {
         get{ return pRoad_IsFix_IsChanged; }
         set{ pRoad_IsFix_IsChanged = value; }
      }
      private string pRoad_Receiver;
      private bool pRoad_Receiver_IsChanged=false;
      public string PRoad_Receiver
      {
         get{ return pRoad_Receiver; }
         set{ pRoad_Receiver = value; pRoad_Receiver_IsChanged=true; }
      }
      public bool PRoad_Receiver_IsChanged
      {
         get{ return pRoad_Receiver_IsChanged; }
         set{ pRoad_Receiver_IsChanged = value; }
      }
   }
}
