using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Prod_Patch
   {
      private decimal pP_ID;
      private bool pP_ID_IsChanged=false;
      public decimal PP_ID
      {
         get{ return pP_ID; }
         set{ pP_ID = value; pP_ID_IsChanged=true; }
      }
      public bool PP_ID_IsChanged
      {
         get{ return pP_ID_IsChanged; }
         set{ pP_ID_IsChanged = value; }
      }
      private string pP_Module;
      private bool pP_Module_IsChanged=false;
      public string PP_Module
      {
         get{ return pP_Module; }
         set{ pP_Module = value; pP_Module_IsChanged=true; }
      }
      public bool PP_Module_IsChanged
      {
         get{ return pP_Module_IsChanged; }
         set{ pP_Module_IsChanged = value; }
      }
      private string pP_Code;
      private bool pP_Code_IsChanged=false;
      public string PP_Code
      {
         get{ return pP_Code; }
         set{ pP_Code = value; pP_Code_IsChanged=true; }
      }
      public bool PP_Code_IsChanged
      {
         get{ return pP_Code_IsChanged; }
         set{ pP_Code_IsChanged = value; }
      }
      private string pP_PlanCode;
      private bool pP_PlanCode_IsChanged=false;
      public string PP_PlanCode
      {
         get{ return pP_PlanCode; }
         set{ pP_PlanCode = value; pP_PlanCode_IsChanged=true; }
      }
      public bool PP_PlanCode_IsChanged
      {
         get{ return pP_PlanCode_IsChanged; }
         set{ pP_PlanCode_IsChanged = value; }
      }
      private string pP_ProdCode;
      private bool pP_ProdCode_IsChanged=false;
      public string PP_ProdCode
      {
         get{ return pP_ProdCode; }
         set{ pP_ProdCode = value; pP_ProdCode_IsChanged=true; }
      }
      public bool PP_ProdCode_IsChanged
      {
         get{ return pP_ProdCode_IsChanged; }
         set{ pP_ProdCode_IsChanged = value; }
      }
      private string pP_iType;
      private bool pP_iType_IsChanged=false;
      public string PP_iType
      {
         get{ return pP_iType; }
         set{ pP_iType = value; pP_iType_IsChanged=true; }
      }
      public bool PP_iType_IsChanged
      {
         get{ return pP_iType_IsChanged; }
         set{ pP_iType_IsChanged = value; }
      }
      private string pP_Type;
      private bool pP_Type_IsChanged=false;
      public string PP_Type
      {
         get{ return pP_Type; }
         set{ pP_Type = value; pP_Type_IsChanged=true; }
      }
      public bool PP_Type_IsChanged
      {
         get{ return pP_Type_IsChanged; }
         set{ pP_Type_IsChanged = value; }
      }
      private string pP_PartNo;
      private bool pP_PartNo_IsChanged=false;
      public string PP_PartNo
      {
         get{ return pP_PartNo; }
         set{ pP_PartNo = value; pP_PartNo_IsChanged=true; }
      }
      public bool PP_PartNo_IsChanged
      {
         get{ return pP_PartNo_IsChanged; }
         set{ pP_PartNo_IsChanged = value; }
      }
      private string pP_PartName;
      private bool pP_PartName_IsChanged=false;
      public string PP_PartName
      {
         get{ return pP_PartName; }
         set{ pP_PartName = value; pP_PartName_IsChanged=true; }
      }
      public bool PP_PartName_IsChanged
      {
         get{ return pP_PartName_IsChanged; }
         set{ pP_PartName_IsChanged = value; }
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
      private string pP_IsMain;
      private bool pP_IsMain_IsChanged=false;
      public string PP_IsMain
      {
         get{ return pP_IsMain; }
         set{ pP_IsMain = value; pP_IsMain_IsChanged=true; }
      }
      public bool PP_IsMain_IsChanged
      {
         get{ return pP_IsMain_IsChanged; }
         set{ pP_IsMain_IsChanged = value; }
      }
      private int pP_Level;
      private bool pP_Level_IsChanged=false;
      public int PP_Level
      {
         get{ return pP_Level; }
         set{ pP_Level = value; pP_Level_IsChanged=true; }
      }
      public bool PP_Level_IsChanged
      {
         get{ return pP_Level_IsChanged; }
         set{ pP_Level_IsChanged = value; }
      }
      private string pP_Udef1;
      private bool pP_Udef1_IsChanged=false;
      public string PP_Udef1
      {
         get{ return pP_Udef1; }
         set{ pP_Udef1 = value; pP_Udef1_IsChanged=true; }
      }
      public bool PP_Udef1_IsChanged
      {
         get{ return pP_Udef1_IsChanged; }
         set{ pP_Udef1_IsChanged = value; }
      }
      private string pP_Udef2;
      private bool pP_Udef2_IsChanged=false;
      public string PP_Udef2
      {
         get{ return pP_Udef2; }
         set{ pP_Udef2 = value; pP_Udef2_IsChanged=true; }
      }
      public bool PP_Udef2_IsChanged
      {
         get{ return pP_Udef2_IsChanged; }
         set{ pP_Udef2_IsChanged = value; }
      }
      private string pP_Udef3;
      private bool pP_Udef3_IsChanged=false;
      public string PP_Udef3
      {
         get{ return pP_Udef3; }
         set{ pP_Udef3 = value; pP_Udef3_IsChanged=true; }
      }
      public bool PP_Udef3_IsChanged
      {
         get{ return pP_Udef3_IsChanged; }
         set{ pP_Udef3_IsChanged = value; }
      }
   }
}
