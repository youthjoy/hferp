using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Prod_CodeMap
   {
      private decimal pMap_ID;
      private bool pMap_ID_IsChanged=false;
      public decimal PMap_ID
      {
         get{ return pMap_ID; }
         set{ pMap_ID = value; pMap_ID_IsChanged=true; }
      }
      public bool PMap_ID_IsChanged
      {
         get{ return pMap_ID_IsChanged; }
         set{ pMap_ID_IsChanged = value; }
      }
      private string pMap_Code;
      private bool pMap_Code_IsChanged=false;
      public string PMap_Code
      {
         get{ return pMap_Code; }
         set{ pMap_Code = value; pMap_Code_IsChanged=true; }
      }
      public bool PMap_Code_IsChanged
      {
         get{ return pMap_Code_IsChanged; }
         set{ pMap_Code_IsChanged = value; }
      }
      private int pMap_Order;
      private bool pMap_Order_IsChanged=false;
      public int PMap_Order
      {
         get{ return pMap_Order; }
         set{ pMap_Order = value; pMap_Order_IsChanged=true; }
      }
      public bool PMap_Order_IsChanged
      {
         get{ return pMap_Order_IsChanged; }
         set{ pMap_Order_IsChanged = value; }
      }
      private string pMap_PCode;
      private bool pMap_PCode_IsChanged=false;
      public string PMap_PCode
      {
         get{ return pMap_PCode; }
         set{ pMap_PCode = value; pMap_PCode_IsChanged=true; }
      }
      public bool PMap_PCode_IsChanged
      {
         get{ return pMap_PCode_IsChanged; }
         set{ pMap_PCode_IsChanged = value; }
      }
      private string pMap_MCode;
      private bool pMap_MCode_IsChanged=false;
      public string PMap_MCode
      {
         get{ return pMap_MCode; }
         set{ pMap_MCode = value; pMap_MCode_IsChanged=true; }
      }
      public bool PMap_MCode_IsChanged
      {
         get{ return pMap_MCode_IsChanged; }
         set{ pMap_MCode_IsChanged = value; }
      }
      private string pMap_Module;
      private bool pMap_Module_IsChanged=false;
      public string PMap_Module
      {
         get{ return pMap_Module; }
         set{ pMap_Module = value; pMap_Module_IsChanged=true; }
      }
      public bool PMap_Module_IsChanged
      {
         get{ return pMap_Module_IsChanged; }
         set{ pMap_Module_IsChanged = value; }
      }
      private string pMap_iType;
      private bool pMap_iType_IsChanged=false;
      public string PMap_iType
      {
         get{ return pMap_iType; }
         set{ pMap_iType = value; pMap_iType_IsChanged=true; }
      }
      public bool PMap_iType_IsChanged
      {
         get{ return pMap_iType_IsChanged; }
         set{ pMap_iType_IsChanged = value; }
      }
      private string pMap_Stat;
      private bool pMap_Stat_IsChanged=false;
      public string PMap_Stat
      {
         get{ return pMap_Stat; }
         set{ pMap_Stat = value; pMap_Stat_IsChanged=true; }
      }
      public bool PMap_Stat_IsChanged
      {
         get{ return pMap_Stat_IsChanged; }
         set{ pMap_Stat_IsChanged = value; }
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
      private string pMap_RawStat;
      private bool pMap_RawStat_IsChanged=false;
      public string PMap_RawStat
      {
         get{ return pMap_RawStat; }
         set{ pMap_RawStat = value; pMap_RawStat_IsChanged=true; }
      }
      public bool PMap_RawStat_IsChanged
      {
         get{ return pMap_RawStat_IsChanged; }
         set{ pMap_RawStat_IsChanged = value; }
      }
      private DateTime pMap_RawDate;
      private bool pMap_RawDate_IsChanged=false;
      public DateTime PMap_RawDate
      {
         get{ return pMap_RawDate; }
         set{ pMap_RawDate = value; pMap_RawDate_IsChanged=true; }
      }
      public bool PMap_RawDate_IsChanged
      {
         get{ return pMap_RawDate_IsChanged; }
         set{ pMap_RawDate_IsChanged = value; }
      }
      private DateTime pMap_PlanDate;
      private bool pMap_PlanDate_IsChanged=false;
      public DateTime PMap_PlanDate
      {
         get{ return pMap_PlanDate; }
         set{ pMap_PlanDate = value; pMap_PlanDate_IsChanged=true; }
      }
      public bool PMap_PlanDate_IsChanged
      {
         get{ return pMap_PlanDate_IsChanged; }
         set{ pMap_PlanDate_IsChanged = value; }
      }
      private string pMap_RawMainCode;
      private bool pMap_RawMainCode_IsChanged=false;
      public string PMap_RawMainCode
      {
         get{ return pMap_RawMainCode; }
         set{ pMap_RawMainCode = value; pMap_RawMainCode_IsChanged=true; }
      }
      public bool PMap_RawMainCode_IsChanged
      {
         get{ return pMap_RawMainCode_IsChanged; }
         set{ pMap_RawMainCode_IsChanged = value; }
      }
      private string pMap_Udef1;
      private bool pMap_Udef1_IsChanged=false;
      public string PMap_Udef1
      {
         get{ return pMap_Udef1; }
         set{ pMap_Udef1 = value; pMap_Udef1_IsChanged=true; }
      }
      public bool PMap_Udef1_IsChanged
      {
         get{ return pMap_Udef1_IsChanged; }
         set{ pMap_Udef1_IsChanged = value; }
      }
      private string pMap_Udef3;
      private bool pMap_Udef3_IsChanged=false;
      public string PMap_Udef3
      {
         get{ return pMap_Udef3; }
         set{ pMap_Udef3 = value; pMap_Udef3_IsChanged=true; }
      }
      public bool PMap_Udef3_IsChanged
      {
         get{ return pMap_Udef3_IsChanged; }
         set{ pMap_Udef3_IsChanged = value; }
      }
      private string pMap_TaskCode;
      private bool pMap_TaskCode_IsChanged=false;
      public string PMap_TaskCode
      {
         get{ return pMap_TaskCode; }
         set{ pMap_TaskCode = value; pMap_TaskCode_IsChanged=true; }
      }
      public bool PMap_TaskCode_IsChanged
      {
         get{ return pMap_TaskCode_IsChanged; }
         set{ pMap_TaskCode_IsChanged = value; }
      }
      private DateTime pMap_TaskDate;
      private bool pMap_TaskDate_IsChanged=false;
      public DateTime PMap_TaskDate
      {
         get{ return pMap_TaskDate; }
         set{ pMap_TaskDate = value; pMap_TaskDate_IsChanged=true; }
      }
      public bool PMap_TaskDate_IsChanged
      {
         get{ return pMap_TaskDate_IsChanged; }
         set{ pMap_TaskDate_IsChanged = value; }
      }
   }
}
