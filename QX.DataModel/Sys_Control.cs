using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Sys_Control
   {
      private Int64 sys_ID;
      private bool sys_ID_IsChanged=false;
      public Int64 Sys_ID
      {
         get{ return sys_ID; }
         set{ sys_ID = value; sys_ID_IsChanged=true; }
      }
      public bool Sys_ID_IsChanged
      {
         get{ return sys_ID_IsChanged; }
         set{ sys_ID_IsChanged = value; }
      }
      private string sys_Win;
      private bool sys_Win_IsChanged=false;
      public string Sys_Win
      {
         get{ return sys_Win; }
         set{ sys_Win = value; sys_Win_IsChanged=true; }
      }
      public bool Sys_Win_IsChanged
      {
         get{ return sys_Win_IsChanged; }
         set{ sys_Win_IsChanged = value; }
      }
      private string sys_Key;
      private bool sys_Key_IsChanged=false;
      public string Sys_Key
      {
         get{ return sys_Key; }
         set{ sys_Key = value; sys_Key_IsChanged=true; }
      }
      public bool Sys_Key_IsChanged
      {
         get{ return sys_Key_IsChanged; }
         set{ sys_Key_IsChanged = value; }
      }
      private string sys_ControlName;
      private bool sys_ControlName_IsChanged=false;
      public string Sys_ControlName
      {
         get{ return sys_ControlName; }
         set{ sys_ControlName = value; sys_ControlName_IsChanged=true; }
      }
      public bool Sys_ControlName_IsChanged
      {
         get{ return sys_ControlName_IsChanged; }
         set{ sys_ControlName_IsChanged = value; }
      }
      private string sys_ControlLabel;
      private bool sys_ControlLabel_IsChanged=false;
      public string Sys_ControlLabel
      {
         get{ return sys_ControlLabel; }
         set{ sys_ControlLabel = value; sys_ControlLabel_IsChanged=true; }
      }
      public bool Sys_ControlLabel_IsChanged
      {
         get{ return sys_ControlLabel_IsChanged; }
         set{ sys_ControlLabel_IsChanged = value; }
      }
      private string sys_ControlDefault;
      private bool sys_ControlDefault_IsChanged=false;
      public string Sys_ControlDefault
      {
         get{ return sys_ControlDefault; }
         set{ sys_ControlDefault = value; sys_ControlDefault_IsChanged=true; }
      }
      public bool Sys_ControlDefault_IsChanged
      {
         get{ return sys_ControlDefault_IsChanged; }
         set{ sys_ControlDefault_IsChanged = value; }
      }
      private string sys_DBTable;
      private bool sys_DBTable_IsChanged=false;
      public string Sys_DBTable
      {
         get{ return sys_DBTable; }
         set{ sys_DBTable = value; sys_DBTable_IsChanged=true; }
      }
      public bool Sys_DBTable_IsChanged
      {
         get{ return sys_DBTable_IsChanged; }
         set{ sys_DBTable_IsChanged = value; }
      }
      private string sys_DBCol;
      private bool sys_DBCol_IsChanged=false;
      public string Sys_DBCol
      {
         get{ return sys_DBCol; }
         set{ sys_DBCol = value; sys_DBCol_IsChanged=true; }
      }
      public bool Sys_DBCol_IsChanged
      {
         get{ return sys_DBCol_IsChanged; }
         set{ sys_DBCol_IsChanged = value; }
      }
      private int sys_IsDefault;
      private bool sys_IsDefault_IsChanged=false;
      public int Sys_IsDefault
      {
         get{ return sys_IsDefault; }
         set{ sys_IsDefault = value; sys_IsDefault_IsChanged=true; }
      }
      public bool Sys_IsDefault_IsChanged
      {
         get{ return sys_IsDefault_IsChanged; }
         set{ sys_IsDefault_IsChanged = value; }
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
      private string sys_TextBoxName;
      private bool sys_TextBoxName_IsChanged=false;
      public string Sys_TextBoxName
      {
         get{ return sys_TextBoxName; }
         set{ sys_TextBoxName = value; sys_TextBoxName_IsChanged=true; }
      }
      public bool Sys_TextBoxName_IsChanged
      {
         get{ return sys_TextBoxName_IsChanged; }
         set{ sys_TextBoxName_IsChanged = value; }
      }
      private int isAllowEdit;
      private bool isAllowEdit_IsChanged=false;
      public int IsAllowEdit
      {
         get{ return isAllowEdit; }
         set{ isAllowEdit = value; isAllowEdit_IsChanged=true; }
      }
      public bool IsAllowEdit_IsChanged
      {
         get{ return isAllowEdit_IsChanged; }
         set{ isAllowEdit_IsChanged = value; }
      }
   }
}
