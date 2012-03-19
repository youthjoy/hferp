using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class SD_Finance
   {
      private decimal sDF_ID;
      private bool sDF_ID_IsChanged=false;
      public decimal SDF_ID
      {
         get{ return sDF_ID; }
         set{ sDF_ID = value; sDF_ID_IsChanged=true; }
      }
      public bool SDF_ID_IsChanged
      {
         get{ return sDF_ID_IsChanged; }
         set{ sDF_ID_IsChanged = value; }
      }
      private string sDF_Code;
      private bool sDF_Code_IsChanged=false;
      public string SDF_Code
      {
         get{ return sDF_Code; }
         set{ sDF_Code = value; sDF_Code_IsChanged=true; }
      }
      public bool SDF_Code_IsChanged
      {
         get{ return sDF_Code_IsChanged; }
         set{ sDF_Code_IsChanged = value; }
      }
      private string sDF_ContractCode;
      private bool sDF_ContractCode_IsChanged=false;
      public string SDF_ContractCode
      {
         get{ return sDF_ContractCode; }
         set{ sDF_ContractCode = value; sDF_ContractCode_IsChanged=true; }
      }
      public bool SDF_ContractCode_IsChanged
      {
         get{ return sDF_ContractCode_IsChanged; }
         set{ sDF_ContractCode_IsChanged = value; }
      }
      private string sDF_Customer;
      private bool sDF_Customer_IsChanged=false;
      public string SDF_Customer
      {
         get{ return sDF_Customer; }
         set{ sDF_Customer = value; sDF_Customer_IsChanged=true; }
      }
      public bool SDF_Customer_IsChanged
      {
         get{ return sDF_Customer_IsChanged; }
         set{ sDF_Customer_IsChanged = value; }
      }
      private string sDF_CustomerName;
      private bool sDF_CustomerName_IsChanged=false;
      public string SDF_CustomerName
      {
         get{ return sDF_CustomerName; }
         set{ sDF_CustomerName = value; sDF_CustomerName_IsChanged=true; }
      }
      public bool SDF_CustomerName_IsChanged
      {
         get{ return sDF_CustomerName_IsChanged; }
         set{ sDF_CustomerName_IsChanged = value; }
      }
      private string sDF_ContractDetail;
      private bool sDF_ContractDetail_IsChanged=false;
      public string SDF_ContractDetail
      {
         get{ return sDF_ContractDetail; }
         set{ sDF_ContractDetail = value; sDF_ContractDetail_IsChanged=true; }
      }
      public bool SDF_ContractDetail_IsChanged
      {
         get{ return sDF_ContractDetail_IsChanged; }
         set{ sDF_ContractDetail_IsChanged = value; }
      }
      private string sDF_CmdCode;
      private bool sDF_CmdCode_IsChanged=false;
      public string SDF_CmdCode
      {
         get{ return sDF_CmdCode; }
         set{ sDF_CmdCode = value; sDF_CmdCode_IsChanged=true; }
      }
      public bool SDF_CmdCode_IsChanged
      {
         get{ return sDF_CmdCode_IsChanged; }
         set{ sDF_CmdCode_IsChanged = value; }
      }
      private string sDF_PartNo;
      private bool sDF_PartNo_IsChanged=false;
      public string SDF_PartNo
      {
         get{ return sDF_PartNo; }
         set{ sDF_PartNo = value; sDF_PartNo_IsChanged=true; }
      }
      public bool SDF_PartNo_IsChanged
      {
         get{ return sDF_PartNo_IsChanged; }
         set{ sDF_PartNo_IsChanged = value; }
      }
      private string sDF_PartName;
      private bool sDF_PartName_IsChanged=false;
      public string SDF_PartName
      {
         get{ return sDF_PartName; }
         set{ sDF_PartName = value; sDF_PartName_IsChanged=true; }
      }
      public bool SDF_PartName_IsChanged
      {
         get{ return sDF_PartName_IsChanged; }
         set{ sDF_PartName_IsChanged = value; }
      }
      private string sDF_NodeCode;
      private bool sDF_NodeCode_IsChanged=false;
      public string SDF_NodeCode
      {
         get{ return sDF_NodeCode; }
         set{ sDF_NodeCode = value; sDF_NodeCode_IsChanged=true; }
      }
      public bool SDF_NodeCode_IsChanged
      {
         get{ return sDF_NodeCode_IsChanged; }
         set{ sDF_NodeCode_IsChanged = value; }
      }
      private string sDF_NodeName;
      private bool sDF_NodeName_IsChanged=false;
      public string SDF_NodeName
      {
         get{ return sDF_NodeName; }
         set{ sDF_NodeName = value; sDF_NodeName_IsChanged=true; }
      }
      public bool SDF_NodeName_IsChanged
      {
         get{ return sDF_NodeName_IsChanged; }
         set{ sDF_NodeName_IsChanged = value; }
      }
      private decimal sDF_Value;
      private bool sDF_Value_IsChanged=false;
      public decimal SDF_Value
      {
         get{ return sDF_Value; }
         set{ sDF_Value = value; sDF_Value_IsChanged=true; }
      }
      public bool SDF_Value_IsChanged
      {
         get{ return sDF_Value_IsChanged; }
         set{ sDF_Value_IsChanged = value; }
      }
      private string sDF_ProdType;
      private bool sDF_ProdType_IsChanged=false;
      public string SDF_ProdType
      {
         get{ return sDF_ProdType; }
         set{ sDF_ProdType = value; sDF_ProdType_IsChanged=true; }
      }
      public bool SDF_ProdType_IsChanged
      {
         get{ return sDF_ProdType_IsChanged; }
         set{ sDF_ProdType_IsChanged = value; }
      }
      private string sDF_Stat;
      private bool sDF_Stat_IsChanged=false;
      public string SDF_Stat
      {
         get{ return sDF_Stat; }
         set{ sDF_Stat = value; sDF_Stat_IsChanged=true; }
      }
      public bool SDF_Stat_IsChanged
      {
         get{ return sDF_Stat_IsChanged; }
         set{ sDF_Stat_IsChanged = value; }
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
      private DateTime creatTime;
      private bool creatTime_IsChanged=false;
      public DateTime CreatTime
      {
         get{ return creatTime; }
         set{ creatTime = value; creatTime_IsChanged=true; }
      }
      public bool CreatTime_IsChanged
      {
         get{ return creatTime_IsChanged; }
         set{ creatTime_IsChanged = value; }
      }
      private string sDF_Udef1;
      private bool sDF_Udef1_IsChanged=false;
      public string SDF_Udef1
      {
         get{ return sDF_Udef1; }
         set{ sDF_Udef1 = value; sDF_Udef1_IsChanged=true; }
      }
      public bool SDF_Udef1_IsChanged
      {
         get{ return sDF_Udef1_IsChanged; }
         set{ sDF_Udef1_IsChanged = value; }
      }
      private string sDF_Udef2;
      private bool sDF_Udef2_IsChanged=false;
      public string SDF_Udef2
      {
         get{ return sDF_Udef2; }
         set{ sDF_Udef2 = value; sDF_Udef2_IsChanged=true; }
      }
      public bool SDF_Udef2_IsChanged
      {
         get{ return sDF_Udef2_IsChanged; }
         set{ sDF_Udef2_IsChanged = value; }
      }
      private string sDF_Udef3;
      private bool sDF_Udef3_IsChanged=false;
      public string SDF_Udef3
      {
         get{ return sDF_Udef3; }
         set{ sDF_Udef3 = value; sDF_Udef3_IsChanged=true; }
      }
      public bool SDF_Udef3_IsChanged
      {
         get{ return sDF_Udef3_IsChanged; }
         set{ sDF_Udef3_IsChanged = value; }
      }
   }
}
