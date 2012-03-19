using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Bse_FeedDetail
   {
      private decimal fBI_ID;
      private bool fBI_ID_IsChanged=false;
      public decimal FBI_ID
      {
         get{ return fBI_ID; }
         set{ fBI_ID = value; fBI_ID_IsChanged=true; }
      }
      public bool FBI_ID_IsChanged
      {
         get{ return fBI_ID_IsChanged; }
         set{ fBI_ID_IsChanged = value; }
      }
      private string fBI_MCode;
      private bool fBI_MCode_IsChanged=false;
      public string FBI_MCode
      {
         get{ return fBI_MCode; }
         set{ fBI_MCode = value; fBI_MCode_IsChanged=true; }
      }
      public bool FBI_MCode_IsChanged
      {
         get{ return fBI_MCode_IsChanged; }
         set{ fBI_MCode_IsChanged = value; }
      }
      private string fBI_DCode;
      private bool fBI_DCode_IsChanged=false;
      public string FBI_DCode
      {
         get{ return fBI_DCode; }
         set{ fBI_DCode = value; fBI_DCode_IsChanged=true; }
      }
      public bool FBI_DCode_IsChanged
      {
         get{ return fBI_DCode_IsChanged; }
         set{ fBI_DCode_IsChanged = value; }
      }
      private string fBI_DName;
      private bool fBI_DName_IsChanged=false;
      public string FBI_DName
      {
         get{ return fBI_DName; }
         set{ fBI_DName = value; fBI_DName_IsChanged=true; }
      }
      public bool FBI_DName_IsChanged
      {
         get{ return fBI_DName_IsChanged; }
         set{ fBI_DName_IsChanged = value; }
      }
      private string fBI_itype;
      private bool fBI_itype_IsChanged=false;
      public string FBI_itype
      {
         get{ return fBI_itype; }
         set{ fBI_itype = value; fBI_itype_IsChanged=true; }
      }
      public bool FBI_itype_IsChanged
      {
         get{ return fBI_itype_IsChanged; }
         set{ fBI_itype_IsChanged = value; }
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
