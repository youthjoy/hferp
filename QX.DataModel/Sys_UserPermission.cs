using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Sys_UserPermission
   {
      private decimal pU_ID;
      private bool pU_ID_IsChanged=false;
      public decimal PU_ID
      {
         get{ return pU_ID; }
         set{ pU_ID = value; pU_ID_IsChanged=true; }
      }
      public bool PU_ID_IsChanged
      {
         get{ return pU_ID_IsChanged; }
         set{ pU_ID_IsChanged = value; }
      }
      /// <summary>
      /// 用户权限编码
      /// </summary>
      private string pU_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pU_Code_IsChanged=false;
      /// <summary>
      /// 用户权限编码
      /// </summary>
      public string PU_Code
      {
         get{ return pU_Code; }
         set{ pU_Code = value; pU_Code_IsChanged=true; }
      }
      /// <summary>
      /// 用户权限编码
      /// </summary>
      public bool PU_Code_IsChanged
      {
         get{ return pU_Code_IsChanged; }
         set{ pU_Code_IsChanged = value; }
      }
      /// <summary>
      /// 功能编码
      /// </summary>
      private string pU_FunCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pU_FunCode_IsChanged=false;
      /// <summary>
      /// 功能编码
      /// </summary>
      public string PU_FunCode
      {
         get{ return pU_FunCode; }
         set{ pU_FunCode = value; pU_FunCode_IsChanged=true; }
      }
      /// <summary>
      /// 功能编码
      /// </summary>
      public bool PU_FunCode_IsChanged
      {
         get{ return pU_FunCode_IsChanged; }
         set{ pU_FunCode_IsChanged = value; }
      }
      private string pU_FunName;
      private bool pU_FunName_IsChanged=false;
      public string PU_FunName
      {
         get{ return pU_FunName; }
         set{ pU_FunName = value; pU_FunName_IsChanged=true; }
      }
      public bool PU_FunName_IsChanged
      {
         get{ return pU_FunName_IsChanged; }
         set{ pU_FunName_IsChanged = value; }
      }
      private string pU_FunPCode;
      private bool pU_FunPCode_IsChanged=false;
      public string PU_FunPCode
      {
         get{ return pU_FunPCode; }
         set{ pU_FunPCode = value; pU_FunPCode_IsChanged=true; }
      }
      public bool PU_FunPCode_IsChanged
      {
         get{ return pU_FunPCode_IsChanged; }
         set{ pU_FunPCode_IsChanged = value; }
      }
      /// <summary>
      /// 用户名
      /// </summary>
      private string pU_UserName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pU_UserName_IsChanged=false;
      /// <summary>
      /// 用户名
      /// </summary>
      public string PU_UserName
      {
         get{ return pU_UserName; }
         set{ pU_UserName = value; pU_UserName_IsChanged=true; }
      }
      /// <summary>
      /// 用户名
      /// </summary>
      public bool PU_UserName_IsChanged
      {
         get{ return pU_UserName_IsChanged; }
         set{ pU_UserName_IsChanged = value; }
      }
      private string pU_UserCode;
      private bool pU_UserCode_IsChanged=false;
      public string PU_UserCode
      {
         get{ return pU_UserCode; }
         set{ pU_UserCode = value; pU_UserCode_IsChanged=true; }
      }
      public bool PU_UserCode_IsChanged
      {
         get{ return pU_UserCode_IsChanged; }
         set{ pU_UserCode_IsChanged = value; }
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
   }
}
