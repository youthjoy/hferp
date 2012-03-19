using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel

{
   [Serializable]
   public partial class Sys_Map
   {
      private decimal map_ID;
      private bool map_ID_IsChanged=false;
      public decimal Map_ID
      {
         get{ return map_ID; }
         set{ map_ID = value; map_ID_IsChanged=true; }
      }
      public bool Map_ID_IsChanged
      {
         get{ return map_ID_IsChanged; }
         set{ map_ID_IsChanged = value; }
      }
      private string map_Module;
      private bool map_Module_IsChanged=false;
      public string Map_Module
      {
         get{ return map_Module; }
         set{ map_Module = value; map_Module_IsChanged=true; }
      }
      public bool Map_Module_IsChanged
      {
         get{ return map_Module_IsChanged; }
         set{ map_Module_IsChanged = value; }
      }
      private string map_Source;
      private bool map_Source_IsChanged=false;
      public string Map_Source
      {
         get{ return map_Source; }
         set{ map_Source = value; map_Source_IsChanged=true; }
      }
      public bool Map_Source_IsChanged
      {
         get{ return map_Source_IsChanged; }
         set{ map_Source_IsChanged = value; }
      }
      private string map_Object1;
      private bool map_Object1_IsChanged=false;
      public string Map_Object1
      {
         get{ return map_Object1; }
         set{ map_Object1 = value; map_Object1_IsChanged=true; }
      }
      public bool Map_Object1_IsChanged
      {
         get{ return map_Object1_IsChanged; }
         set{ map_Object1_IsChanged = value; }
      }
      private string map_Object2;
      private bool map_Object2_IsChanged=false;
      public string Map_Object2
      {
         get{ return map_Object2; }
         set{ map_Object2 = value; map_Object2_IsChanged=true; }
      }
      public bool Map_Object2_IsChanged
      {
         get{ return map_Object2_IsChanged; }
         set{ map_Object2_IsChanged = value; }
      }
      private string map_Object3;
      private bool map_Object3_IsChanged=false;
      public string Map_Object3
      {
         get{ return map_Object3; }
         set{ map_Object3 = value; map_Object3_IsChanged=true; }
      }
      public bool Map_Object3_IsChanged
      {
         get{ return map_Object3_IsChanged; }
         set{ map_Object3_IsChanged = value; }
      }
      private string map_Object4;
      private bool map_Object4_IsChanged=false;
      public string Map_Object4
      {
         get{ return map_Object4; }
         set{ map_Object4 = value; map_Object4_IsChanged=true; }
      }
      public bool Map_Object4_IsChanged
      {
         get{ return map_Object4_IsChanged; }
         set{ map_Object4_IsChanged = value; }
      }
      private string map_Object5;
      private bool map_Object5_IsChanged=false;
      public string Map_Object5
      {
         get{ return map_Object5; }
         set{ map_Object5 = value; map_Object5_IsChanged=true; }
      }
      public bool Map_Object5_IsChanged
      {
         get{ return map_Object5_IsChanged; }
         set{ map_Object5_IsChanged = value; }
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
