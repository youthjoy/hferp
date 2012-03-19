using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class SD_ContractValue
   {
      private decimal cPR_ID;
      private bool cPR_ID_IsChanged=false;
      public decimal CPR_ID
      {
         get{ return cPR_ID; }
         set{ cPR_ID = value; cPR_ID_IsChanged=true; }
      }
      public bool CPR_ID_IsChanged
      {
         get{ return cPR_ID_IsChanged; }
         set{ cPR_ID_IsChanged = value; }
      }
      private string cPR_Code;
      private bool cPR_Code_IsChanged=false;
      public string CPR_Code
      {
         get{ return cPR_Code; }
         set{ cPR_Code = value; cPR_Code_IsChanged=true; }
      }
      public bool CPR_Code_IsChanged
      {
         get{ return cPR_Code_IsChanged; }
         set{ cPR_Code_IsChanged = value; }
      }
      private string cPR_ContractCode;
      private bool cPR_ContractCode_IsChanged=false;
      public string CPR_ContractCode
      {
         get{ return cPR_ContractCode; }
         set{ cPR_ContractCode = value; cPR_ContractCode_IsChanged=true; }
      }
      public bool CPR_ContractCode_IsChanged
      {
         get{ return cPR_ContractCode_IsChanged; }
         set{ cPR_ContractCode_IsChanged = value; }
      }
      private string cPR_Customer;
      private bool cPR_Customer_IsChanged=false;
      public string CPR_Customer
      {
         get{ return cPR_Customer; }
         set{ cPR_Customer = value; cPR_Customer_IsChanged=true; }
      }
      public bool CPR_Customer_IsChanged
      {
         get{ return cPR_Customer_IsChanged; }
         set{ cPR_Customer_IsChanged = value; }
      }
      private string cPR_CusomterName;
      private bool cPR_CusomterName_IsChanged=false;
      public string CPR_CusomterName
      {
         get{ return cPR_CusomterName; }
         set{ cPR_CusomterName = value; cPR_CusomterName_IsChanged=true; }
      }
      public bool CPR_CusomterName_IsChanged
      {
         get{ return cPR_CusomterName_IsChanged; }
         set{ cPR_CusomterName_IsChanged = value; }
      }
      private string cPR_CmdCode;
      private bool cPR_CmdCode_IsChanged=false;
      public string CPR_CmdCode
      {
         get{ return cPR_CmdCode; }
         set{ cPR_CmdCode = value; cPR_CmdCode_IsChanged=true; }
      }
      public bool CPR_CmdCode_IsChanged
      {
         get{ return cPR_CmdCode_IsChanged; }
         set{ cPR_CmdCode_IsChanged = value; }
      }
      private string cPR_PartNod;
      private bool cPR_PartNod_IsChanged=false;
      public string CPR_PartNod
      {
         get{ return cPR_PartNod; }
         set{ cPR_PartNod = value; cPR_PartNod_IsChanged=true; }
      }
      public bool CPR_PartNod_IsChanged
      {
         get{ return cPR_PartNod_IsChanged; }
         set{ cPR_PartNod_IsChanged = value; }
      }
      private string cPR_PartName;
      private bool cPR_PartName_IsChanged=false;
      public string CPR_PartName
      {
         get{ return cPR_PartName; }
         set{ cPR_PartName = value; cPR_PartName_IsChanged=true; }
      }
      public bool CPR_PartName_IsChanged
      {
         get{ return cPR_PartName_IsChanged; }
         set{ cPR_PartName_IsChanged = value; }
      }
      private string cPR_Node;
      private bool cPR_Node_IsChanged=false;
      public string CPR_Node
      {
         get{ return cPR_Node; }
         set{ cPR_Node = value; cPR_Node_IsChanged=true; }
      }
      public bool CPR_Node_IsChanged
      {
         get{ return cPR_Node_IsChanged; }
         set{ cPR_Node_IsChanged = value; }
      }
      private decimal cPR_Price;
      private bool cPR_Price_IsChanged=false;
      public decimal CPR_Price
      {
         get{ return cPR_Price; }
         set{ cPR_Price = value; cPR_Price_IsChanged=true; }
      }
      public bool CPR_Price_IsChanged
      {
         get{ return cPR_Price_IsChanged; }
         set{ cPR_Price_IsChanged = value; }
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
