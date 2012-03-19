using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class SD_ContractTrace
   {
      private decimal sDT_ID;
      private bool sDT_ID_IsChanged=false;
      public decimal SDT_ID
      {
         get{ return sDT_ID; }
         set{ sDT_ID = value; sDT_ID_IsChanged=true; }
      }
      public bool SDT_ID_IsChanged
      {
         get{ return sDT_ID_IsChanged; }
         set{ sDT_ID_IsChanged = value; }
      }
      private string sDT_Code;
      private bool sDT_Code_IsChanged=false;
      public string SDT_Code
      {
         get{ return sDT_Code; }
         set{ sDT_Code = value; sDT_Code_IsChanged=true; }
      }
      public bool SDT_Code_IsChanged
      {
         get{ return sDT_Code_IsChanged; }
         set{ sDT_Code_IsChanged = value; }
      }
      private string sDT_MainCode;
      private bool sDT_MainCode_IsChanged=false;
      public string SDT_MainCode
      {
         get{ return sDT_MainCode; }
         set{ sDT_MainCode = value; sDT_MainCode_IsChanged=true; }
      }
      public bool SDT_MainCode_IsChanged
      {
         get{ return sDT_MainCode_IsChanged; }
         set{ sDT_MainCode_IsChanged = value; }
      }
      private string sDT_ContractCode;
      private bool sDT_ContractCode_IsChanged=false;
      public string SDT_ContractCode
      {
         get{ return sDT_ContractCode; }
         set{ sDT_ContractCode = value; sDT_ContractCode_IsChanged=true; }
      }
      public bool SDT_ContractCode_IsChanged
      {
         get{ return sDT_ContractCode_IsChanged; }
         set{ sDT_ContractCode_IsChanged = value; }
      }
      private string sDT_PartNo;
      private bool sDT_PartNo_IsChanged=false;
      public string SDT_PartNo
      {
         get{ return sDT_PartNo; }
         set{ sDT_PartNo = value; sDT_PartNo_IsChanged=true; }
      }
      public bool SDT_PartNo_IsChanged
      {
         get{ return sDT_PartNo_IsChanged; }
         set{ sDT_PartNo_IsChanged = value; }
      }
      private string sDT_PartName;
      private bool sDT_PartName_IsChanged=false;
      public string SDT_PartName
      {
         get{ return sDT_PartName; }
         set{ sDT_PartName = value; sDT_PartName_IsChanged=true; }
      }
      public bool SDT_PartName_IsChanged
      {
         get{ return sDT_PartName_IsChanged; }
         set{ sDT_PartName_IsChanged = value; }
      }
      private DateTime sDT_ODate;
      private bool sDT_ODate_IsChanged=false;
      public DateTime SDT_ODate
      {
         get{ return sDT_ODate; }
         set{ sDT_ODate = value; sDT_ODate_IsChanged=true; }
      }
      public bool SDT_ODate_IsChanged
      {
         get{ return sDT_ODate_IsChanged; }
         set{ sDT_ODate_IsChanged = value; }
      }
      private int sDT_Num;
      private bool sDT_Num_IsChanged=false;
      public int SDT_Num
      {
         get{ return sDT_Num; }
         set{ sDT_Num = value; sDT_Num_IsChanged=true; }
      }
      public bool SDT_Num_IsChanged
      {
         get{ return sDT_Num_IsChanged; }
         set{ sDT_Num_IsChanged = value; }
      }
      private string sDT_Owner;
      private bool sDT_Owner_IsChanged=false;
      public string SDT_Owner
      {
         get{ return sDT_Owner; }
         set{ sDT_Owner = value; sDT_Owner_IsChanged=true; }
      }
      public bool SDT_Owner_IsChanged
      {
         get{ return sDT_Owner_IsChanged; }
         set{ sDT_Owner_IsChanged = value; }
      }
      private string sDT_OwnerName;
      private bool sDT_OwnerName_IsChanged=false;
      public string SDT_OwnerName
      {
         get{ return sDT_OwnerName; }
         set{ sDT_OwnerName = value; sDT_OwnerName_IsChanged=true; }
      }
      public bool SDT_OwnerName_IsChanged
      {
         get{ return sDT_OwnerName_IsChanged; }
         set{ sDT_OwnerName_IsChanged = value; }
      }
      private string sDT_Remark;
      private bool sDT_Remark_IsChanged=false;
      public string SDT_Remark
      {
         get{ return sDT_Remark; }
         set{ sDT_Remark = value; sDT_Remark_IsChanged=true; }
      }
      public bool SDT_Remark_IsChanged
      {
         get{ return sDT_Remark_IsChanged; }
         set{ sDT_Remark_IsChanged = value; }
      }
      private string sDT_FOwner;
      private bool sDT_FOwner_IsChanged=false;
      public string SDT_FOwner
      {
         get{ return sDT_FOwner; }
         set{ sDT_FOwner = value; sDT_FOwner_IsChanged=true; }
      }
      public bool SDT_FOwner_IsChanged
      {
         get{ return sDT_FOwner_IsChanged; }
         set{ sDT_FOwner_IsChanged = value; }
      }
      private string sDT_FOwnerName;
      private bool sDT_FOwnerName_IsChanged=false;
      public string SDT_FOwnerName
      {
         get{ return sDT_FOwnerName; }
         set{ sDT_FOwnerName = value; sDT_FOwnerName_IsChanged=true; }
      }
      public bool SDT_FOwnerName_IsChanged
      {
         get{ return sDT_FOwnerName_IsChanged; }
         set{ sDT_FOwnerName_IsChanged = value; }
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
      private string sDT_ProdCode;
      private bool sDT_ProdCode_IsChanged=false;
      public string SDT_ProdCode
      {
         get{ return sDT_ProdCode; }
         set{ sDT_ProdCode = value; sDT_ProdCode_IsChanged=true; }
      }
      public bool SDT_ProdCode_IsChanged
      {
         get{ return sDT_ProdCode_IsChanged; }
         set{ sDT_ProdCode_IsChanged = value; }
      }
   }
}
