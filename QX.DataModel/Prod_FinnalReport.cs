using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Prod_FinnalReport
   {
      private Int64 fReport_ID;
      private bool fReport_ID_IsChanged=false;
      public Int64 FReport_ID
      {
         get{ return fReport_ID; }
         set{ fReport_ID = value; fReport_ID_IsChanged=true; }
      }
      public bool FReport_ID_IsChanged
      {
         get{ return fReport_ID_IsChanged; }
         set{ fReport_ID_IsChanged = value; }
      }
      private string fReport_ProdCode;
      private bool fReport_ProdCode_IsChanged=false;
      public string FReport_ProdCode
      {
         get{ return fReport_ProdCode; }
         set{ fReport_ProdCode = value; fReport_ProdCode_IsChanged=true; }
      }
      public bool FReport_ProdCode_IsChanged
      {
         get{ return fReport_ProdCode_IsChanged; }
         set{ fReport_ProdCode_IsChanged = value; }
      }
      private int fReport_Order;
      private bool fReport_Order_IsChanged=false;
      public int FReport_Order
      {
         get{ return fReport_Order; }
         set{ fReport_Order = value; fReport_Order_IsChanged=true; }
      }
      public bool FReport_Order_IsChanged
      {
         get{ return fReport_Order_IsChanged; }
         set{ fReport_Order_IsChanged = value; }
      }
      private string fReport_Name;
      private bool fReport_Name_IsChanged=false;
      public string FReport_Name
      {
         get{ return fReport_Name; }
         set{ fReport_Name = value; fReport_Name_IsChanged=true; }
      }
      public bool FReport_Name_IsChanged
      {
         get{ return fReport_Name_IsChanged; }
         set{ fReport_Name_IsChanged = value; }
      }
      private string fReport_Real;
      private bool fReport_Real_IsChanged=false;
      public string FReport_Real
      {
         get{ return fReport_Real; }
         set{ fReport_Real = value; fReport_Real_IsChanged=true; }
      }
      public bool FReport_Real_IsChanged
      {
         get{ return fReport_Real_IsChanged; }
         set{ fReport_Real_IsChanged = value; }
      }
      private string fReport_Report;
      private bool fReport_Report_IsChanged=false;
      public string FReport_Report
      {
         get{ return fReport_Report; }
         set{ fReport_Report = value; fReport_Report_IsChanged=true; }
      }
      public bool FReport_Report_IsChanged
      {
         get{ return fReport_Report_IsChanged; }
         set{ fReport_Report_IsChanged = value; }
      }
      private string fReport_High;
      private bool fReport_High_IsChanged=false;
      public string FReport_High
      {
         get{ return fReport_High; }
         set{ fReport_High = value; fReport_High_IsChanged=true; }
      }
      public bool FReport_High_IsChanged
      {
         get{ return fReport_High_IsChanged; }
         set{ fReport_High_IsChanged = value; }
      }
      private string fReport_Low;
      private bool fReport_Low_IsChanged=false;
      public string FReport_Low
      {
         get{ return fReport_Low; }
         set{ fReport_Low = value; fReport_Low_IsChanged=true; }
      }
      public bool FReport_Low_IsChanged
      {
         get{ return fReport_Low_IsChanged; }
         set{ fReport_Low_IsChanged = value; }
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
