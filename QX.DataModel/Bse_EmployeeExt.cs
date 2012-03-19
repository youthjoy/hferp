using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Bse_EmployeeExt
   {
      private decimal empE_ID;
      private bool empE_ID_IsChanged=false;
      public decimal EmpE_ID
      {
         get{ return empE_ID; }
         set{ empE_ID = value; empE_ID_IsChanged=true; }
      }
      public bool EmpE_ID_IsChanged
      {
         get{ return empE_ID_IsChanged; }
         set{ empE_ID_IsChanged = value; }
      }
      private string empE_Module;
      private bool empE_Module_IsChanged=false;
      public string EmpE_Module
      {
         get{ return empE_Module; }
         set{ empE_Module = value; empE_Module_IsChanged=true; }
      }
      public bool EmpE_Module_IsChanged
      {
         get{ return empE_Module_IsChanged; }
         set{ empE_Module_IsChanged = value; }
      }
      private string empE_EmpCode;
      private bool empE_EmpCode_IsChanged=false;
      public string EmpE_EmpCode
      {
         get{ return empE_EmpCode; }
         set{ empE_EmpCode = value; empE_EmpCode_IsChanged=true; }
      }
      public bool EmpE_EmpCode_IsChanged
      {
         get{ return empE_EmpCode_IsChanged; }
         set{ empE_EmpCode_IsChanged = value; }
      }
      private string empE_Udef1;
      private bool empE_Udef1_IsChanged=false;
      public string EmpE_Udef1
      {
         get{ return empE_Udef1; }
         set{ empE_Udef1 = value; empE_Udef1_IsChanged=true; }
      }
      public bool EmpE_Udef1_IsChanged
      {
         get{ return empE_Udef1_IsChanged; }
         set{ empE_Udef1_IsChanged = value; }
      }
      private string empE_Udef2;
      private bool empE_Udef2_IsChanged=false;
      public string EmpE_Udef2
      {
         get{ return empE_Udef2; }
         set{ empE_Udef2 = value; empE_Udef2_IsChanged=true; }
      }
      public bool EmpE_Udef2_IsChanged
      {
         get{ return empE_Udef2_IsChanged; }
         set{ empE_Udef2_IsChanged = value; }
      }
      private string empE_Udef3;
      private bool empE_Udef3_IsChanged=false;
      public string EmpE_Udef3
      {
         get{ return empE_Udef3; }
         set{ empE_Udef3 = value; empE_Udef3_IsChanged=true; }
      }
      public bool EmpE_Udef3_IsChanged
      {
         get{ return empE_Udef3_IsChanged; }
         set{ empE_Udef3_IsChanged = value; }
      }
      private string empE_Udef4;
      private bool empE_Udef4_IsChanged=false;
      public string EmpE_Udef4
      {
         get{ return empE_Udef4; }
         set{ empE_Udef4 = value; empE_Udef4_IsChanged=true; }
      }
      public bool EmpE_Udef4_IsChanged
      {
         get{ return empE_Udef4_IsChanged; }
         set{ empE_Udef4_IsChanged = value; }
      }
      private string empE_Udef5;
      private bool empE_Udef5_IsChanged=false;
      public string EmpE_Udef5
      {
         get{ return empE_Udef5; }
         set{ empE_Udef5 = value; empE_Udef5_IsChanged=true; }
      }
      public bool EmpE_Udef5_IsChanged
      {
         get{ return empE_Udef5_IsChanged; }
         set{ empE_Udef5_IsChanged = value; }
      }
      private string empE_Udef6;
      private bool empE_Udef6_IsChanged=false;
      public string EmpE_Udef6
      {
         get{ return empE_Udef6; }
         set{ empE_Udef6 = value; empE_Udef6_IsChanged=true; }
      }
      public bool EmpE_Udef6_IsChanged
      {
         get{ return empE_Udef6_IsChanged; }
         set{ empE_Udef6_IsChanged = value; }
      }
      private string empE_Udef7;
      private bool empE_Udef7_IsChanged=false;
      public string EmpE_Udef7
      {
         get{ return empE_Udef7; }
         set{ empE_Udef7 = value; empE_Udef7_IsChanged=true; }
      }
      public bool EmpE_Udef7_IsChanged
      {
         get{ return empE_Udef7_IsChanged; }
         set{ empE_Udef7_IsChanged = value; }
      }
      private string empE_Udef8;
      private bool empE_Udef8_IsChanged=false;
      public string EmpE_Udef8
      {
         get{ return empE_Udef8; }
         set{ empE_Udef8 = value; empE_Udef8_IsChanged=true; }
      }
      public bool EmpE_Udef8_IsChanged
      {
         get{ return empE_Udef8_IsChanged; }
         set{ empE_Udef8_IsChanged = value; }
      }
      private string empE_Udef9;
      private bool empE_Udef9_IsChanged=false;
      public string EmpE_Udef9
      {
         get{ return empE_Udef9; }
         set{ empE_Udef9 = value; empE_Udef9_IsChanged=true; }
      }
      public bool EmpE_Udef9_IsChanged
      {
         get{ return empE_Udef9_IsChanged; }
         set{ empE_Udef9_IsChanged = value; }
      }
      private string empE_Udef10;
      private bool empE_Udef10_IsChanged=false;
      public string EmpE_Udef10
      {
         get{ return empE_Udef10; }
         set{ empE_Udef10 = value; empE_Udef10_IsChanged=true; }
      }
      public bool EmpE_Udef10_IsChanged
      {
         get{ return empE_Udef10_IsChanged; }
         set{ empE_Udef10_IsChanged = value; }
      }
      private string empE_Udef11;
      private bool empE_Udef11_IsChanged=false;
      public string EmpE_Udef11
      {
         get{ return empE_Udef11; }
         set{ empE_Udef11 = value; empE_Udef11_IsChanged=true; }
      }
      public bool EmpE_Udef11_IsChanged
      {
         get{ return empE_Udef11_IsChanged; }
         set{ empE_Udef11_IsChanged = value; }
      }
      private string empE_Udef12;
      private bool empE_Udef12_IsChanged=false;
      public string EmpE_Udef12
      {
         get{ return empE_Udef12; }
         set{ empE_Udef12 = value; empE_Udef12_IsChanged=true; }
      }
      public bool EmpE_Udef12_IsChanged
      {
         get{ return empE_Udef12_IsChanged; }
         set{ empE_Udef12_IsChanged = value; }
      }
      private string empE_Udef13;
      private bool empE_Udef13_IsChanged=false;
      public string EmpE_Udef13
      {
         get{ return empE_Udef13; }
         set{ empE_Udef13 = value; empE_Udef13_IsChanged=true; }
      }
      public bool EmpE_Udef13_IsChanged
      {
         get{ return empE_Udef13_IsChanged; }
         set{ empE_Udef13_IsChanged = value; }
      }
      private string empE_Udef14;
      private bool empE_Udef14_IsChanged=false;
      public string EmpE_Udef14
      {
         get{ return empE_Udef14; }
         set{ empE_Udef14 = value; empE_Udef14_IsChanged=true; }
      }
      public bool EmpE_Udef14_IsChanged
      {
         get{ return empE_Udef14_IsChanged; }
         set{ empE_Udef14_IsChanged = value; }
      }
      private string empE_Udef15;
      private bool empE_Udef15_IsChanged=false;
      public string EmpE_Udef15
      {
         get{ return empE_Udef15; }
         set{ empE_Udef15 = value; empE_Udef15_IsChanged=true; }
      }
      public bool EmpE_Udef15_IsChanged
      {
         get{ return empE_Udef15_IsChanged; }
         set{ empE_Udef15_IsChanged = value; }
      }
      private string empE_Udef16;
      private bool empE_Udef16_IsChanged=false;
      public string EmpE_Udef16
      {
         get{ return empE_Udef16; }
         set{ empE_Udef16 = value; empE_Udef16_IsChanged=true; }
      }
      public bool EmpE_Udef16_IsChanged
      {
         get{ return empE_Udef16_IsChanged; }
         set{ empE_Udef16_IsChanged = value; }
      }
      private string empE_Udef17;
      private bool empE_Udef17_IsChanged=false;
      public string EmpE_Udef17
      {
         get{ return empE_Udef17; }
         set{ empE_Udef17 = value; empE_Udef17_IsChanged=true; }
      }
      public bool EmpE_Udef17_IsChanged
      {
         get{ return empE_Udef17_IsChanged; }
         set{ empE_Udef17_IsChanged = value; }
      }
      private string empE_Udef18;
      private bool empE_Udef18_IsChanged=false;
      public string EmpE_Udef18
      {
         get{ return empE_Udef18; }
         set{ empE_Udef18 = value; empE_Udef18_IsChanged=true; }
      }
      public bool EmpE_Udef18_IsChanged
      {
         get{ return empE_Udef18_IsChanged; }
         set{ empE_Udef18_IsChanged = value; }
      }
      private string empE_Udef19;
      private bool empE_Udef19_IsChanged=false;
      public string EmpE_Udef19
      {
         get{ return empE_Udef19; }
         set{ empE_Udef19 = value; empE_Udef19_IsChanged=true; }
      }
      public bool EmpE_Udef19_IsChanged
      {
         get{ return empE_Udef19_IsChanged; }
         set{ empE_Udef19_IsChanged = value; }
      }
      private string empE_Udef20;
      private bool empE_Udef20_IsChanged=false;
      public string EmpE_Udef20
      {
         get{ return empE_Udef20; }
         set{ empE_Udef20 = value; empE_Udef20_IsChanged=true; }
      }
      public bool EmpE_Udef20_IsChanged
      {
         get{ return empE_Udef20_IsChanged; }
         set{ empE_Udef20_IsChanged = value; }
      }
      private string empE_Udef21;
      private bool empE_Udef21_IsChanged=false;
      public string EmpE_Udef21
      {
         get{ return empE_Udef21; }
         set{ empE_Udef21 = value; empE_Udef21_IsChanged=true; }
      }
      public bool EmpE_Udef21_IsChanged
      {
         get{ return empE_Udef21_IsChanged; }
         set{ empE_Udef21_IsChanged = value; }
      }
      private string empE_Udef22;
      private bool empE_Udef22_IsChanged=false;
      public string EmpE_Udef22
      {
         get{ return empE_Udef22; }
         set{ empE_Udef22 = value; empE_Udef22_IsChanged=true; }
      }
      public bool EmpE_Udef22_IsChanged
      {
         get{ return empE_Udef22_IsChanged; }
         set{ empE_Udef22_IsChanged = value; }
      }
      private string empE_Udef23;
      private bool empE_Udef23_IsChanged=false;
      public string EmpE_Udef23
      {
         get{ return empE_Udef23; }
         set{ empE_Udef23 = value; empE_Udef23_IsChanged=true; }
      }
      public bool EmpE_Udef23_IsChanged
      {
         get{ return empE_Udef23_IsChanged; }
         set{ empE_Udef23_IsChanged = value; }
      }
      private string empE_Udef24;
      private bool empE_Udef24_IsChanged=false;
      public string EmpE_Udef24
      {
         get{ return empE_Udef24; }
         set{ empE_Udef24 = value; empE_Udef24_IsChanged=true; }
      }
      public bool EmpE_Udef24_IsChanged
      {
         get{ return empE_Udef24_IsChanged; }
         set{ empE_Udef24_IsChanged = value; }
      }
      private string empE_Udef25;
      private bool empE_Udef25_IsChanged=false;
      public string EmpE_Udef25
      {
         get{ return empE_Udef25; }
         set{ empE_Udef25 = value; empE_Udef25_IsChanged=true; }
      }
      public bool EmpE_Udef25_IsChanged
      {
         get{ return empE_Udef25_IsChanged; }
         set{ empE_Udef25_IsChanged = value; }
      }
      private string empE_Udef26;
      private bool empE_Udef26_IsChanged=false;
      public string EmpE_Udef26
      {
         get{ return empE_Udef26; }
         set{ empE_Udef26 = value; empE_Udef26_IsChanged=true; }
      }
      public bool EmpE_Udef26_IsChanged
      {
         get{ return empE_Udef26_IsChanged; }
         set{ empE_Udef26_IsChanged = value; }
      }
      private string empE_Udef27;
      private bool empE_Udef27_IsChanged=false;
      public string EmpE_Udef27
      {
         get{ return empE_Udef27; }
         set{ empE_Udef27 = value; empE_Udef27_IsChanged=true; }
      }
      public bool EmpE_Udef27_IsChanged
      {
         get{ return empE_Udef27_IsChanged; }
         set{ empE_Udef27_IsChanged = value; }
      }
      private string empE_Udef28;
      private bool empE_Udef28_IsChanged=false;
      public string EmpE_Udef28
      {
         get{ return empE_Udef28; }
         set{ empE_Udef28 = value; empE_Udef28_IsChanged=true; }
      }
      public bool EmpE_Udef28_IsChanged
      {
         get{ return empE_Udef28_IsChanged; }
         set{ empE_Udef28_IsChanged = value; }
      }
      private string empE_Udef29;
      private bool empE_Udef29_IsChanged=false;
      public string EmpE_Udef29
      {
         get{ return empE_Udef29; }
         set{ empE_Udef29 = value; empE_Udef29_IsChanged=true; }
      }
      public bool EmpE_Udef29_IsChanged
      {
         get{ return empE_Udef29_IsChanged; }
         set{ empE_Udef29_IsChanged = value; }
      }
      private string empE_Udef30;
      private bool empE_Udef30_IsChanged=false;
      public string EmpE_Udef30
      {
         get{ return empE_Udef30; }
         set{ empE_Udef30 = value; empE_Udef30_IsChanged=true; }
      }
      public bool EmpE_Udef30_IsChanged
      {
         get{ return empE_Udef30_IsChanged; }
         set{ empE_Udef30_IsChanged = value; }
      }
      private DateTime empE_BeginTime;
      private bool empE_BeginTime_IsChanged=false;
      public DateTime EmpE_BeginTime
      {
         get{ return empE_BeginTime; }
         set{ empE_BeginTime = value; empE_BeginTime_IsChanged=true; }
      }
      public bool EmpE_BeginTime_IsChanged
      {
         get{ return empE_BeginTime_IsChanged; }
         set{ empE_BeginTime_IsChanged = value; }
      }
      private DateTime empE_EndTime;
      private bool empE_EndTime_IsChanged=false;
      public DateTime EmpE_EndTime
      {
         get{ return empE_EndTime; }
         set{ empE_EndTime = value; empE_EndTime_IsChanged=true; }
      }
      public bool EmpE_EndTime_IsChanged
      {
         get{ return empE_EndTime_IsChanged; }
         set{ empE_EndTime_IsChanged = value; }
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
