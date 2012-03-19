using System;
using System.Data;


namespace QX.DataModel
{
   [Serializable]
   public partial class Failure_Process
   {
      private Int64 fProcess_ID;
      private bool fProcess_ID_IsChanged=false;
      [MetaData("FProcess_ID","")]
      public Int64 FProcess_ID
      {
         get{ return fProcess_ID; }
         set{ fProcess_ID = value; fProcess_ID_IsChanged=true; }
      }
      public bool FProcess_ID_IsChanged
      {
         get{ return fProcess_ID_IsChanged; }
         set{ fProcess_ID_IsChanged = value; }
      }
      private Int64 fInfo_ID;
      private bool fInfo_ID_IsChanged=false;
      [MetaData("FInfo_ID","")]
      public Int64 FInfo_ID
      {
         get{ return fInfo_ID; }
         set{ fInfo_ID = value; fInfo_ID_IsChanged=true; }
      }
      public bool FInfo_ID_IsChanged
      {
         get{ return fInfo_ID_IsChanged; }
         set{ fInfo_ID_IsChanged = value; }
      }
      private string fProcess_ProdCode;
      private bool fProcess_ProdCode_IsChanged=false;
      [MetaData("FProcess_ProdCode","")]
      public string FProcess_ProdCode
      {
         get{ return fProcess_ProdCode; }
         set{ fProcess_ProdCode = value; fProcess_ProdCode_IsChanged=true; }
      }
      public bool FProcess_ProdCode_IsChanged
      {
         get{ return fProcess_ProdCode_IsChanged; }
         set{ fProcess_ProdCode_IsChanged = value; }
      }
      private string fProcess_PartNo;
      private bool fProcess_PartNo_IsChanged=false;
      [MetaData("FProcess_PartNo","")]
      public string FProcess_PartNo
      {
         get{ return fProcess_PartNo; }
         set{ fProcess_PartNo = value; fProcess_PartNo_IsChanged=true; }
      }
      public bool FProcess_PartNo_IsChanged
      {
         get{ return fProcess_PartNo_IsChanged; }
         set{ fProcess_PartNo_IsChanged = value; }
      }
      private string fProcess_PartName;
      private bool fProcess_PartName_IsChanged=false;
      [MetaData("FProcess_PartName","")]
      public string FProcess_PartName
      {
         get{ return fProcess_PartName; }
         set{ fProcess_PartName = value; fProcess_PartName_IsChanged=true; }
      }
      public bool FProcess_PartName_IsChanged
      {
         get{ return fProcess_PartName_IsChanged; }
         set{ fProcess_PartName_IsChanged = value; }
      }
      private string fProcess_Key;
      private bool fProcess_Key_IsChanged=false;
      [MetaData("FProcess_Key","")]
      public string FProcess_Key
      {
         get{ return fProcess_Key; }
         set{ fProcess_Key = value; fProcess_Key_IsChanged=true; }
      }
      public bool FProcess_Key_IsChanged
      {
         get{ return fProcess_Key_IsChanged; }
         set{ fProcess_Key_IsChanged = value; }
      }
      private string fProcess_RespPep;
      private bool fProcess_RespPep_IsChanged=false;
      [MetaData("FProcess_RespPep","")]
      public string FProcess_RespPep
      {
         get{ return fProcess_RespPep; }
         set{ fProcess_RespPep = value; fProcess_RespPep_IsChanged=true; }
      }
      public bool FProcess_RespPep_IsChanged
      {
         get{ return fProcess_RespPep_IsChanged; }
         set{ fProcess_RespPep_IsChanged = value; }
      }
      private string fProcess_RespSup;
      private bool fProcess_RespSup_IsChanged=false;
      [MetaData("FProcess_RespSup","")]
      public string FProcess_RespSup
      {
         get{ return fProcess_RespSup; }
         set{ fProcess_RespSup = value; fProcess_RespSup_IsChanged=true; }
      }
      public bool FProcess_RespSup_IsChanged
      {
         get{ return fProcess_RespSup_IsChanged; }
         set{ fProcess_RespSup_IsChanged = value; }
      }
      private string fProcess_Introduction;
      private bool fProcess_Introduction_IsChanged=false;
      [MetaData("FProcess_Introduction","")]
      public string FProcess_Introduction
      {
         get{ return fProcess_Introduction; }
         set{ fProcess_Introduction = value; fProcess_Introduction_IsChanged=true; }
      }
      public bool FProcess_Introduction_IsChanged
      {
         get{ return fProcess_Introduction_IsChanged; }
         set{ fProcess_Introduction_IsChanged = value; }
      }
      private string fProcess_Method;
      private bool fProcess_Method_IsChanged=false;
      [MetaData("FProcess_Method","")]
      public string FProcess_Method
      {
         get{ return fProcess_Method; }
         set{ fProcess_Method = value; fProcess_Method_IsChanged=true; }
      }
      public bool FProcess_Method_IsChanged
      {
         get{ return fProcess_Method_IsChanged; }
         set{ fProcess_Method_IsChanged = value; }
      }
      private string fProcess_Owner;
      private bool fProcess_Owner_IsChanged=false;
      [MetaData("FProcess_Owner","")]
      public string FProcess_Owner
      {
         get{ return fProcess_Owner; }
         set{ fProcess_Owner = value; fProcess_Owner_IsChanged=true; }
      }
      public bool FProcess_Owner_IsChanged
      {
         get{ return fProcess_Owner_IsChanged; }
         set{ fProcess_Owner_IsChanged = value; }
      }
      private DateTime fProcess_Date;
      private bool fProcess_Date_IsChanged=false;
      [MetaData("FProcess_Date","")]
      public DateTime FProcess_Date
      {
         get{ return fProcess_Date; }
         set{ fProcess_Date = value; fProcess_Date_IsChanged=true; }
      }
      public bool FProcess_Date_IsChanged
      {
         get{ return fProcess_Date_IsChanged; }
         set{ fProcess_Date_IsChanged = value; }
      }
   }
}
