using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Raw_Inv
   {
      private decimal rI_ID;
      private bool rI_ID_IsChanged=false;
      public decimal RI_ID
      {
         get{ return rI_ID; }
         set{ rI_ID = value; rI_ID_IsChanged=true; }
      }
      public bool RI_ID_IsChanged
      {
         get{ return rI_ID_IsChanged; }
         set{ rI_ID_IsChanged = value; }
      }
      private string rI_Code;
      private bool rI_Code_IsChanged=false;
      public string RI_Code
      {
         get{ return rI_Code; }
         set{ rI_Code = value; rI_Code_IsChanged=true; }
      }
      public bool RI_Code_IsChanged
      {
         get{ return rI_Code_IsChanged; }
         set{ rI_Code_IsChanged = value; }
      }
      private string rI_RawCode;
      private bool rI_RawCode_IsChanged=false;
      public string RI_RawCode
      {
         get{ return rI_RawCode; }
         set{ rI_RawCode = value; rI_RawCode_IsChanged=true; }
      }
      public bool RI_RawCode_IsChanged
      {
         get{ return rI_RawCode_IsChanged; }
         set{ rI_RawCode_IsChanged = value; }
      }
      private int rI_Sum;
      private bool rI_Sum_IsChanged=false;
      public int RI_Sum
      {
         get{ return rI_Sum; }
         set{ rI_Sum = value; rI_Sum_IsChanged=true; }
      }
      public bool RI_Sum_IsChanged
      {
         get{ return rI_Sum_IsChanged; }
         set{ rI_Sum_IsChanged = value; }
      }
      private int rI_AvailableNum;
      private bool rI_AvailableNum_IsChanged=false;
      public int RI_AvailableNum
      {
         get{ return rI_AvailableNum; }
         set{ rI_AvailableNum = value; rI_AvailableNum_IsChanged=true; }
      }
      public bool RI_AvailableNum_IsChanged
      {
         get{ return rI_AvailableNum_IsChanged; }
         set{ rI_AvailableNum_IsChanged = value; }
      }
      private int rI_UsedNum;
      private bool rI_UsedNum_IsChanged=false;
      public int RI_UsedNum
      {
         get{ return rI_UsedNum; }
         set{ rI_UsedNum = value; rI_UsedNum_IsChanged=true; }
      }
      public bool RI_UsedNum_IsChanged
      {
         get{ return rI_UsedNum_IsChanged; }
         set{ rI_UsedNum_IsChanged = value; }
      }
      private string rI_CompCode;
      private bool rI_CompCode_IsChanged=false;
      public string RI_CompCode
      {
         get{ return rI_CompCode; }
         set{ rI_CompCode = value; rI_CompCode_IsChanged=true; }
      }
      public bool RI_CompCode_IsChanged
      {
         get{ return rI_CompCode_IsChanged; }
         set{ rI_CompCode_IsChanged = value; }
      }
      private string rI_CmdCode;
      private bool rI_CmdCode_IsChanged=false;
      public string RI_CmdCode
      {
         get{ return rI_CmdCode; }
         set{ rI_CmdCode = value; rI_CmdCode_IsChanged=true; }
      }
      public bool RI_CmdCode_IsChanged
      {
         get{ return rI_CmdCode_IsChanged; }
         set{ rI_CmdCode_IsChanged = value; }
      }
      private string rI_InOperator;
      private bool rI_InOperator_IsChanged=false;
      public string RI_InOperator
      {
         get{ return rI_InOperator; }
         set{ rI_InOperator = value; rI_InOperator_IsChanged=true; }
      }
      public bool RI_InOperator_IsChanged
      {
         get{ return rI_InOperator_IsChanged; }
         set{ rI_InOperator_IsChanged = value; }
      }
      private DateTime rI_InTime;
      private bool rI_InTime_IsChanged=false;
      public DateTime RI_InTime
      {
         get{ return rI_InTime; }
         set{ rI_InTime = value; rI_InTime_IsChanged=true; }
      }
      public bool RI_InTime_IsChanged
      {
         get{ return rI_InTime_IsChanged; }
         set{ rI_InTime_IsChanged = value; }
      }
      private string rI_OutOperator;
      private bool rI_OutOperator_IsChanged=false;
      public string RI_OutOperator
      {
         get{ return rI_OutOperator; }
         set{ rI_OutOperator = value; rI_OutOperator_IsChanged=true; }
      }
      public bool RI_OutOperator_IsChanged
      {
         get{ return rI_OutOperator_IsChanged; }
         set{ rI_OutOperator_IsChanged = value; }
      }
      private DateTime rI_OutTime;
      private bool rI_OutTime_IsChanged=false;
      public DateTime RI_OutTime
      {
         get{ return rI_OutTime; }
         set{ rI_OutTime = value; rI_OutTime_IsChanged=true; }
      }
      public bool RI_OutTime_IsChanged
      {
         get{ return rI_OutTime_IsChanged; }
         set{ rI_OutTime_IsChanged = value; }
      }
      private string rI_Remark;
      private bool rI_Remark_IsChanged=false;
      public string RI_Remark
      {
         get{ return rI_Remark; }
         set{ rI_Remark = value; rI_Remark_IsChanged=true; }
      }
      public bool RI_Remark_IsChanged
      {
         get{ return rI_Remark_IsChanged; }
         set{ rI_Remark_IsChanged = value; }
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
      private string rI_Customer;
      private bool rI_Customer_IsChanged=false;
      public string RI_Customer
      {
         get{ return rI_Customer; }
         set{ rI_Customer = value; rI_Customer_IsChanged=true; }
      }
      public bool RI_Customer_IsChanged
      {
         get{ return rI_Customer_IsChanged; }
         set{ rI_Customer_IsChanged = value; }
      }
      private string rI_RefRawCode;
      private bool rI_RefRawCode_IsChanged=false;
      public string RI_RefRawCode
      {
         get{ return rI_RefRawCode; }
         set{ rI_RefRawCode = value; rI_RefRawCode_IsChanged=true; }
      }
      public bool RI_RefRawCode_IsChanged
      {
         get{ return rI_RefRawCode_IsChanged; }
         set{ rI_RefRawCode_IsChanged = value; }
      }
      private string rI_RefDetailCode;
      private bool rI_RefDetailCode_IsChanged=false;
      public string RI_RefDetailCode
      {
         get{ return rI_RefDetailCode; }
         set{ rI_RefDetailCode = value; rI_RefDetailCode_IsChanged=true; }
      }
      public bool RI_RefDetailCode_IsChanged
      {
         get{ return rI_RefDetailCode_IsChanged; }
         set{ rI_RefDetailCode_IsChanged = value; }
      }
      private string rI_Udef1;
      private bool rI_Udef1_IsChanged=false;
      public string RI_Udef1
      {
         get{ return rI_Udef1; }
         set{ rI_Udef1 = value; rI_Udef1_IsChanged=true; }
      }
      public bool RI_Udef1_IsChanged
      {
         get{ return rI_Udef1_IsChanged; }
         set{ rI_Udef1_IsChanged = value; }
      }
      private string rI_Udef2;
      private bool rI_Udef2_IsChanged=false;
      public string RI_Udef2
      {
         get{ return rI_Udef2; }
         set{ rI_Udef2 = value; rI_Udef2_IsChanged=true; }
      }
      public bool RI_Udef2_IsChanged
      {
         get{ return rI_Udef2_IsChanged; }
         set{ rI_Udef2_IsChanged = value; }
      }
   }
}
