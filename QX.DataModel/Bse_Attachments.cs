using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 附件信息
   /// </summary>
   [Serializable]
   public partial class Bse_Attachments
   {
      /// <summary>
      /// 附件序号
      /// </summary>
      private Int64 aT_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_ID_IsChanged=false;
      /// <summary>
      /// 附件序号
      /// </summary>
      public Int64 AT_ID
      {
         get{ return aT_ID; }
         set{ aT_ID = value; aT_ID_IsChanged=true; }
      }
      /// <summary>
      /// 附件序号
      /// </summary>
      public bool AT_ID_IsChanged
      {
         get{ return aT_ID_IsChanged; }
         set{ aT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 附件标识关键字
      /// </summary>
      private string aT_Key;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Key_IsChanged=false;
      /// <summary>
      /// 附件标识关键字
      /// </summary>
      public string AT_Key
      {
         get{ return aT_Key; }
         set{ aT_Key = value; aT_Key_IsChanged=true; }
      }
      /// <summary>
      /// 附件标识关键字
      /// </summary>
      public bool AT_Key_IsChanged
      {
         get{ return aT_Key_IsChanged; }
         set{ aT_Key_IsChanged = value; }
      }
      /// <summary>
      /// 附件关键字编码
      /// </summary>
      private string aT_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Code_IsChanged=false;
      /// <summary>
      /// 附件关键字编码
      /// </summary>
      public string AT_Code
      {
         get{ return aT_Code; }
         set{ aT_Code = value; aT_Code_IsChanged=true; }
      }
      /// <summary>
      /// 附件关键字编码
      /// </summary>
      public bool AT_Code_IsChanged
      {
         get{ return aT_Code_IsChanged; }
         set{ aT_Code_IsChanged = value; }
      }
      /// <summary>
      /// 附件名称
      /// </summary>
      private string aT_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Name_IsChanged=false;
      /// <summary>
      /// 附件名称
      /// </summary>
      public string AT_Name
      {
         get{ return aT_Name; }
         set{ aT_Name = value; aT_Name_IsChanged=true; }
      }
      /// <summary>
      /// 附件名称
      /// </summary>
      public bool AT_Name_IsChanged
      {
         get{ return aT_Name_IsChanged; }
         set{ aT_Name_IsChanged = value; }
      }
      /// <summary>
      /// 附件创建时间
      /// </summary>
      private DateTime aT_CDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_CDate_IsChanged=false;
      /// <summary>
      /// 附件创建时间
      /// </summary>
      public DateTime AT_CDate
      {
         get{ return aT_CDate; }
         set{ aT_CDate = value; aT_CDate_IsChanged=true; }
      }
      /// <summary>
      /// 附件创建时间
      /// </summary>
      public bool AT_CDate_IsChanged
      {
         get{ return aT_CDate_IsChanged; }
         set{ aT_CDate_IsChanged = value; }
      }
      /// <summary>
      /// 附件更新时间
      /// </summary>
      private DateTime aT_UDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_UDate_IsChanged=false;
      /// <summary>
      /// 附件更新时间
      /// </summary>
      public DateTime AT_UDate
      {
         get{ return aT_UDate; }
         set{ aT_UDate = value; aT_UDate_IsChanged=true; }
      }
      /// <summary>
      /// 附件更新时间
      /// </summary>
      public bool AT_UDate_IsChanged
      {
         get{ return aT_UDate_IsChanged; }
         set{ aT_UDate_IsChanged = value; }
      }
      /// <summary>
      /// 附件创建人
      /// </summary>
      private string aT_Creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Creator_IsChanged=false;
      /// <summary>
      /// 附件创建人
      /// </summary>
      public string AT_Creator
      {
         get{ return aT_Creator; }
         set{ aT_Creator = value; aT_Creator_IsChanged=true; }
      }
      /// <summary>
      /// 附件创建人
      /// </summary>
      public bool AT_Creator_IsChanged
      {
         get{ return aT_Creator_IsChanged; }
         set{ aT_Creator_IsChanged = value; }
      }
      /// <summary>
      /// 附件更新人
      /// </summary>
      private string aT_Updator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool aT_Updator_IsChanged=false;
      /// <summary>
      /// 附件更新人
      /// </summary>
      public string AT_Updator
      {
         get{ return aT_Updator; }
         set{ aT_Updator = value; aT_Updator_IsChanged=true; }
      }
      /// <summary>
      /// 附件更新人
      /// </summary>
      public bool AT_Updator_IsChanged
      {
         get{ return aT_Updator_IsChanged; }
         set{ aT_Updator_IsChanged = value; }
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
      private string aT_tmpPath;
      private bool aT_tmpPath_IsChanged=false;
      public string AT_tmpPath
      {
         get{ return aT_tmpPath; }
         set{ aT_tmpPath = value; aT_tmpPath_IsChanged=true; }
      }
      public bool AT_tmpPath_IsChanged
      {
         get{ return aT_tmpPath_IsChanged; }
         set{ aT_tmpPath_IsChanged = value; }
      }
   }
}
