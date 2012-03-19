using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 系统注册信息
   /// </summary>
   [Serializable]
   public partial class BSE_SysInfo
   {
      private string sys_ID;
      private bool sys_ID_IsChanged=false;
      public string Sys_ID
      {
         get{ return sys_ID; }
         set{ sys_ID = value; sys_ID_IsChanged=true; }
      }
      public bool Sys_ID_IsChanged
      {
         get{ return sys_ID_IsChanged; }
         set{ sys_ID_IsChanged = value; }
      }
      private string sys_CName;
      private bool sys_CName_IsChanged=false;
      public string Sys_CName
      {
         get{ return sys_CName; }
         set{ sys_CName = value; sys_CName_IsChanged=true; }
      }
      public bool Sys_CName_IsChanged
      {
         get{ return sys_CName_IsChanged; }
         set{ sys_CName_IsChanged = value; }
      }
      private string sys_CSName;
      private bool sys_CSName_IsChanged=false;
      public string Sys_CSName
      {
         get{ return sys_CSName; }
         set{ sys_CSName = value; sys_CSName_IsChanged=true; }
      }
      public bool Sys_CSName_IsChanged
      {
         get{ return sys_CSName_IsChanged; }
         set{ sys_CSName_IsChanged = value; }
      }
      private string sys_SName;
      private bool sys_SName_IsChanged=false;
      public string Sys_SName
      {
         get{ return sys_SName; }
         set{ sys_SName = value; sys_SName_IsChanged=true; }
      }
      public bool Sys_SName_IsChanged
      {
         get{ return sys_SName_IsChanged; }
         set{ sys_SName_IsChanged = value; }
      }
      private string sys_COwner;
      private bool sys_COwner_IsChanged=false;
      public string Sys_COwner
      {
         get{ return sys_COwner; }
         set{ sys_COwner = value; sys_COwner_IsChanged=true; }
      }
      public bool Sys_COwner_IsChanged
      {
         get{ return sys_COwner_IsChanged; }
         set{ sys_COwner_IsChanged = value; }
      }
      private string sys_OCompany;
      private bool sys_OCompany_IsChanged=false;
      public string Sys_OCompany
      {
         get{ return sys_OCompany; }
         set{ sys_OCompany = value; sys_OCompany_IsChanged=true; }
      }
      public bool Sys_OCompany_IsChanged
      {
         get{ return sys_OCompany_IsChanged; }
         set{ sys_OCompany_IsChanged = value; }
      }
      private string sys_CCategory;
      private bool sys_CCategory_IsChanged=false;
      public string Sys_CCategory
      {
         get{ return sys_CCategory; }
         set{ sys_CCategory = value; sys_CCategory_IsChanged=true; }
      }
      public bool Sys_CCategory_IsChanged
      {
         get{ return sys_CCategory_IsChanged; }
         set{ sys_CCategory_IsChanged = value; }
      }
      private string sys_CType;
      private bool sys_CType_IsChanged=false;
      public string Sys_CType
      {
         get{ return sys_CType; }
         set{ sys_CType = value; sys_CType_IsChanged=true; }
      }
      public bool Sys_CType_IsChanged
      {
         get{ return sys_CType_IsChanged; }
         set{ sys_CType_IsChanged = value; }
      }
      private string sys_Province;
      private bool sys_Province_IsChanged=false;
      public string Sys_Province
      {
         get{ return sys_Province; }
         set{ sys_Province = value; sys_Province_IsChanged=true; }
      }
      public bool Sys_Province_IsChanged
      {
         get{ return sys_Province_IsChanged; }
         set{ sys_Province_IsChanged = value; }
      }
      private string sys_City;
      private bool sys_City_IsChanged=false;
      public string Sys_City
      {
         get{ return sys_City; }
         set{ sys_City = value; sys_City_IsChanged=true; }
      }
      public bool Sys_City_IsChanged
      {
         get{ return sys_City_IsChanged; }
         set{ sys_City_IsChanged = value; }
      }
      private string sys_Addr;
      private bool sys_Addr_IsChanged=false;
      public string Sys_Addr
      {
         get{ return sys_Addr; }
         set{ sys_Addr = value; sys_Addr_IsChanged=true; }
      }
      public bool Sys_Addr_IsChanged
      {
         get{ return sys_Addr_IsChanged; }
         set{ sys_Addr_IsChanged = value; }
      }
      private string sys_PostCode;
      private bool sys_PostCode_IsChanged=false;
      public string Sys_PostCode
      {
         get{ return sys_PostCode; }
         set{ sys_PostCode = value; sys_PostCode_IsChanged=true; }
      }
      public bool Sys_PostCode_IsChanged
      {
         get{ return sys_PostCode_IsChanged; }
         set{ sys_PostCode_IsChanged = value; }
      }
      private string sys_Tel;
      private bool sys_Tel_IsChanged=false;
      public string Sys_Tel
      {
         get{ return sys_Tel; }
         set{ sys_Tel = value; sys_Tel_IsChanged=true; }
      }
      public bool Sys_Tel_IsChanged
      {
         get{ return sys_Tel_IsChanged; }
         set{ sys_Tel_IsChanged = value; }
      }
      private string sys_Fax;
      private bool sys_Fax_IsChanged=false;
      public string Sys_Fax
      {
         get{ return sys_Fax; }
         set{ sys_Fax = value; sys_Fax_IsChanged=true; }
      }
      public bool Sys_Fax_IsChanged
      {
         get{ return sys_Fax_IsChanged; }
         set{ sys_Fax_IsChanged = value; }
      }
      private string sys_Email;
      private bool sys_Email_IsChanged=false;
      public string Sys_Email
      {
         get{ return sys_Email; }
         set{ sys_Email = value; sys_Email_IsChanged=true; }
      }
      public bool Sys_Email_IsChanged
      {
         get{ return sys_Email_IsChanged; }
         set{ sys_Email_IsChanged = value; }
      }
      private string sys_BankName;
      private bool sys_BankName_IsChanged=false;
      public string Sys_BankName
      {
         get{ return sys_BankName; }
         set{ sys_BankName = value; sys_BankName_IsChanged=true; }
      }
      public bool Sys_BankName_IsChanged
      {
         get{ return sys_BankName_IsChanged; }
         set{ sys_BankName_IsChanged = value; }
      }
      private string sys_BankAcc;
      private bool sys_BankAcc_IsChanged=false;
      public string Sys_BankAcc
      {
         get{ return sys_BankAcc; }
         set{ sys_BankAcc = value; sys_BankAcc_IsChanged=true; }
      }
      public bool Sys_BankAcc_IsChanged
      {
         get{ return sys_BankAcc_IsChanged; }
         set{ sys_BankAcc_IsChanged = value; }
      }
      private string sys_Tax;
      private bool sys_Tax_IsChanged=false;
      public string Sys_Tax
      {
         get{ return sys_Tax; }
         set{ sys_Tax = value; sys_Tax_IsChanged=true; }
      }
      public bool Sys_Tax_IsChanged
      {
         get{ return sys_Tax_IsChanged; }
         set{ sys_Tax_IsChanged = value; }
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
      private string sys_EnglishName;
      private bool sys_EnglishName_IsChanged=false;
      public string Sys_EnglishName
      {
         get{ return sys_EnglishName; }
         set{ sys_EnglishName = value; sys_EnglishName_IsChanged=true; }
      }
      public bool Sys_EnglishName_IsChanged
      {
         get{ return sys_EnglishName_IsChanged; }
         set{ sys_EnglishName_IsChanged = value; }
      }
      private string sys_EnglishAddr;
      private bool sys_EnglishAddr_IsChanged=false;
      public string Sys_EnglishAddr
      {
         get{ return sys_EnglishAddr; }
         set{ sys_EnglishAddr = value; sys_EnglishAddr_IsChanged=true; }
      }
      public bool Sys_EnglishAddr_IsChanged
      {
         get{ return sys_EnglishAddr_IsChanged; }
         set{ sys_EnglishAddr_IsChanged = value; }
      }
      private string sys_EnglishContract;
      private bool sys_EnglishContract_IsChanged=false;
      public string Sys_EnglishContract
      {
         get{ return sys_EnglishContract; }
         set{ sys_EnglishContract = value; sys_EnglishContract_IsChanged=true; }
      }
      public bool Sys_EnglishContract_IsChanged
      {
         get{ return sys_EnglishContract_IsChanged; }
         set{ sys_EnglishContract_IsChanged = value; }
      }
      private string sys_BankAccName;
      private bool sys_BankAccName_IsChanged=false;
      public string Sys_BankAccName
      {
         get{ return sys_BankAccName; }
         set{ sys_BankAccName = value; sys_BankAccName_IsChanged=true; }
      }
      public bool Sys_BankAccName_IsChanged
      {
         get{ return sys_BankAccName_IsChanged; }
         set{ sys_BankAccName_IsChanged = value; }
      }
   }
}
