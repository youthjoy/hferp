using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Failure_Relation
   {
      private decimal fR_ID;
      private bool fR_ID_IsChanged=false;
      public decimal FR_ID
      {
         get{ return fR_ID; }
         set{ fR_ID = value; fR_ID_IsChanged=true; }
      }
      public bool FR_ID_IsChanged
      {
         get{ return fR_ID_IsChanged; }
         set{ fR_ID_IsChanged = value; }
      }
      private string fR_Code;
      private bool fR_Code_IsChanged=false;
      public string FR_Code
      {
         get{ return fR_Code; }
         set{ fR_Code = value; fR_Code_IsChanged=true; }
      }
      public bool FR_Code_IsChanged
      {
         get{ return fR_Code_IsChanged; }
         set{ fR_Code_IsChanged = value; }
      }
      private string fR_ModuleCode;
      private bool fR_ModuleCode_IsChanged=false;
      public string FR_ModuleCode
      {
         get{ return fR_ModuleCode; }
         set{ fR_ModuleCode = value; fR_ModuleCode_IsChanged=true; }
      }
      public bool FR_ModuleCode_IsChanged
      {
         get{ return fR_ModuleCode_IsChanged; }
         set{ fR_ModuleCode_IsChanged = value; }
      }
      private string fR_PlanCode;
      private bool fR_PlanCode_IsChanged=false;
      public string FR_PlanCode
      {
         get{ return fR_PlanCode; }
         set{ fR_PlanCode = value; fR_PlanCode_IsChanged=true; }
      }
      public bool FR_PlanCode_IsChanged
      {
         get{ return fR_PlanCode_IsChanged; }
         set{ fR_PlanCode_IsChanged = value; }
      }
      private string fR_ProdCode;
      private bool fR_ProdCode_IsChanged=false;
      public string FR_ProdCode
      {
         get{ return fR_ProdCode; }
         set{ fR_ProdCode = value; fR_ProdCode_IsChanged=true; }
      }
      public bool FR_ProdCode_IsChanged
      {
         get{ return fR_ProdCode_IsChanged; }
         set{ fR_ProdCode_IsChanged = value; }
      }
      private string fR_PartNo;
      private bool fR_PartNo_IsChanged=false;
      public string FR_PartNo
      {
         get{ return fR_PartNo; }
         set{ fR_PartNo = value; fR_PartNo_IsChanged=true; }
      }
      public bool FR_PartNo_IsChanged
      {
         get{ return fR_PartNo_IsChanged; }
         set{ fR_PartNo_IsChanged = value; }
      }
      private string fR_PartName;
      private bool fR_PartName_IsChanged=false;
      public string FR_PartName
      {
         get{ return fR_PartName; }
         set{ fR_PartName = value; fR_PartName_IsChanged=true; }
      }
      public bool FR_PartName_IsChanged
      {
         get{ return fR_PartName_IsChanged; }
         set{ fR_PartName_IsChanged = value; }
      }
      private string fR_FailureCode;
      private bool fR_FailureCode_IsChanged=false;
      public string FR_FailureCode
      {
         get{ return fR_FailureCode; }
         set{ fR_FailureCode = value; fR_FailureCode_IsChanged=true; }
      }
      public bool FR_FailureCode_IsChanged
      {
         get{ return fR_FailureCode_IsChanged; }
         set{ fR_FailureCode_IsChanged = value; }
      }
      private string fR_Stat;
      private bool fR_Stat_IsChanged=false;
      public string FR_Stat
      {
         get{ return fR_Stat; }
         set{ fR_Stat = value; fR_Stat_IsChanged=true; }
      }
      public bool FR_Stat_IsChanged
      {
         get{ return fR_Stat_IsChanged; }
         set{ fR_Stat_IsChanged = value; }
      }
      private int fR_IsCurrent;
      private bool fR_IsCurrent_IsChanged=false;
      public int FR_IsCurrent
      {
         get{ return fR_IsCurrent; }
         set{ fR_IsCurrent = value; fR_IsCurrent_IsChanged=true; }
      }
      public bool FR_IsCurrent_IsChanged
      {
         get{ return fR_IsCurrent_IsChanged; }
         set{ fR_IsCurrent_IsChanged = value; }
      }
      private string fR_RefCode;
      private bool fR_RefCode_IsChanged=false;
      public string FR_RefCode
      {
         get{ return fR_RefCode; }
         set{ fR_RefCode = value; fR_RefCode_IsChanged=true; }
      }
      public bool FR_RefCode_IsChanged
      {
         get{ return fR_RefCode_IsChanged; }
         set{ fR_RefCode_IsChanged = value; }
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
      private string fR_Udef1;
      private bool fR_Udef1_IsChanged=false;
      public string FR_Udef1
      {
         get{ return fR_Udef1; }
         set{ fR_Udef1 = value; fR_Udef1_IsChanged=true; }
      }
      public bool FR_Udef1_IsChanged
      {
         get{ return fR_Udef1_IsChanged; }
         set{ fR_Udef1_IsChanged = value; }
      }
      private string fR_Udef2;
      private bool fR_Udef2_IsChanged=false;
      public string FR_Udef2
      {
         get{ return fR_Udef2; }
         set{ fR_Udef2 = value; fR_Udef2_IsChanged=true; }
      }
      public bool FR_Udef2_IsChanged
      {
         get{ return fR_Udef2_IsChanged; }
         set{ fR_Udef2_IsChanged = value; }
      }
      private string fR_Udef3;
      private bool fR_Udef3_IsChanged=false;
      public string FR_Udef3
      {
         get{ return fR_Udef3; }
         set{ fR_Udef3 = value; fR_Udef3_IsChanged=true; }
      }
      public bool FR_Udef3_IsChanged
      {
         get{ return fR_Udef3_IsChanged; }
         set{ fR_Udef3_IsChanged = value; }
      }
      private string fR_Udef4;
      private bool fR_Udef4_IsChanged=false;
      public string FR_Udef4
      {
         get{ return fR_Udef4; }
         set{ fR_Udef4 = value; fR_Udef4_IsChanged=true; }
      }
      public bool FR_Udef4_IsChanged
      {
         get{ return fR_Udef4_IsChanged; }
         set{ fR_Udef4_IsChanged = value; }
      }
      private string fR_Udef5;
      private bool fR_Udef5_IsChanged=false;
      public string FR_Udef5
      {
         get{ return fR_Udef5; }
         set{ fR_Udef5 = value; fR_Udef5_IsChanged=true; }
      }
      public bool FR_Udef5_IsChanged
      {
         get{ return fR_Udef5_IsChanged; }
         set{ fR_Udef5_IsChanged = value; }
      }
      private string fR_Udef6;
      private bool fR_Udef6_IsChanged=false;
      public string FR_Udef6
      {
         get{ return fR_Udef6; }
         set{ fR_Udef6 = value; fR_Udef6_IsChanged=true; }
      }
      public bool FR_Udef6_IsChanged
      {
         get{ return fR_Udef6_IsChanged; }
         set{ fR_Udef6_IsChanged = value; }
      }
      private string fR_Udef7;
      private bool fR_Udef7_IsChanged=false;
      public string FR_Udef7
      {
         get{ return fR_Udef7; }
         set{ fR_Udef7 = value; fR_Udef7_IsChanged=true; }
      }
      public bool FR_Udef7_IsChanged
      {
         get{ return fR_Udef7_IsChanged; }
         set{ fR_Udef7_IsChanged = value; }
      }
      private string fR_Udef8;
      private bool fR_Udef8_IsChanged=false;
      public string FR_Udef8
      {
         get{ return fR_Udef8; }
         set{ fR_Udef8 = value; fR_Udef8_IsChanged=true; }
      }
      public bool FR_Udef8_IsChanged
      {
         get{ return fR_Udef8_IsChanged; }
         set{ fR_Udef8_IsChanged = value; }
      }
   }
}
