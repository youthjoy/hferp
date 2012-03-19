using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class SD_CRProdCode
   {
      private decimal sDR_ID;
      private bool sDR_ID_IsChanged=false;
      public decimal SDR_ID
      {
         get{ return sDR_ID; }
         set{ sDR_ID = value; sDR_ID_IsChanged=true; }
      }
      public bool SDR_ID_IsChanged
      {
         get{ return sDR_ID_IsChanged; }
         set{ sDR_ID_IsChanged = value; }
      }
      private string sDR_Code;
      private bool sDR_Code_IsChanged=false;
      public string SDR_Code
      {
         get{ return sDR_Code; }
         set{ sDR_Code = value; sDR_Code_IsChanged=true; }
      }
      public bool SDR_Code_IsChanged
      {
         get{ return sDR_Code_IsChanged; }
         set{ sDR_Code_IsChanged = value; }
      }
      private string sDR_ContractCode;
      private bool sDR_ContractCode_IsChanged=false;
      public string SDR_ContractCode
      {
         get{ return sDR_ContractCode; }
         set{ sDR_ContractCode = value; sDR_ContractCode_IsChanged=true; }
      }
      public bool SDR_ContractCode_IsChanged
      {
         get{ return sDR_ContractCode_IsChanged; }
         set{ sDR_ContractCode_IsChanged = value; }
      }
      private string sDR_DetailCode;
      private bool sDR_DetailCode_IsChanged=false;
      public string SDR_DetailCode
      {
         get{ return sDR_DetailCode; }
         set{ sDR_DetailCode = value; sDR_DetailCode_IsChanged=true; }
      }
      public bool SDR_DetailCode_IsChanged
      {
         get{ return sDR_DetailCode_IsChanged; }
         set{ sDR_DetailCode_IsChanged = value; }
      }
      private string sDR_CmdCode;
      private bool sDR_CmdCode_IsChanged=false;
      public string SDR_CmdCode
      {
         get{ return sDR_CmdCode; }
         set{ sDR_CmdCode = value; sDR_CmdCode_IsChanged=true; }
      }
      public bool SDR_CmdCode_IsChanged
      {
         get{ return sDR_CmdCode_IsChanged; }
         set{ sDR_CmdCode_IsChanged = value; }
      }
      private string sDR_TaskCode;
      private bool sDR_TaskCode_IsChanged=false;
      public string SDR_TaskCode
      {
         get{ return sDR_TaskCode; }
         set{ sDR_TaskCode = value; sDR_TaskCode_IsChanged=true; }
      }
      public bool SDR_TaskCode_IsChanged
      {
         get{ return sDR_TaskCode_IsChanged; }
         set{ sDR_TaskCode_IsChanged = value; }
      }
      private string sDR_PartNo;
      private bool sDR_PartNo_IsChanged=false;
      public string SDR_PartNo
      {
         get{ return sDR_PartNo; }
         set{ sDR_PartNo = value; sDR_PartNo_IsChanged=true; }
      }
      public bool SDR_PartNo_IsChanged
      {
         get{ return sDR_PartNo_IsChanged; }
         set{ sDR_PartNo_IsChanged = value; }
      }
      private string sDR_PartName;
      private bool sDR_PartName_IsChanged=false;
      public string SDR_PartName
      {
         get{ return sDR_PartName; }
         set{ sDR_PartName = value; sDR_PartName_IsChanged=true; }
      }
      public bool SDR_PartName_IsChanged
      {
         get{ return sDR_PartName_IsChanged; }
         set{ sDR_PartName_IsChanged = value; }
      }
      private string sDR_ProdCode;
      private bool sDR_ProdCode_IsChanged=false;
      public string SDR_ProdCode
      {
         get{ return sDR_ProdCode; }
         set{ sDR_ProdCode = value; sDR_ProdCode_IsChanged=true; }
      }
      public bool SDR_ProdCode_IsChanged
      {
         get{ return sDR_ProdCode_IsChanged; }
         set{ sDR_ProdCode_IsChanged = value; }
      }
      private string sDR_PlanCode;
      private bool sDR_PlanCode_IsChanged=false;
      public string SDR_PlanCode
      {
         get{ return sDR_PlanCode; }
         set{ sDR_PlanCode = value; sDR_PlanCode_IsChanged=true; }
      }
      public bool SDR_PlanCode_IsChanged
      {
         get{ return sDR_PlanCode_IsChanged; }
         set{ sDR_PlanCode_IsChanged = value; }
      }
      private decimal sDR_Sum;
      private bool sDR_Sum_IsChanged=false;
      public decimal SDR_Sum
      {
         get{ return sDR_Sum; }
         set{ sDR_Sum = value; sDR_Sum_IsChanged=true; }
      }
      public bool SDR_Sum_IsChanged
      {
         get{ return sDR_Sum_IsChanged; }
         set{ sDR_Sum_IsChanged = value; }
      }
      private decimal sDR_Price;
      private bool sDR_Price_IsChanged=false;
      public decimal SDR_Price
      {
         get{ return sDR_Price; }
         set{ sDR_Price = value; sDR_Price_IsChanged=true; }
      }
      public bool SDR_Price_IsChanged
      {
         get{ return sDR_Price_IsChanged; }
         set{ sDR_Price_IsChanged = value; }
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
   }
}
