using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Sys_Function
   {
      private decimal fun_ID;
      private bool fun_ID_IsChanged=false;
      public decimal Fun_ID
      {
         get{ return fun_ID; }
         set{ fun_ID = value; fun_ID_IsChanged=true; }
      }
      public bool Fun_ID_IsChanged
      {
         get{ return fun_ID_IsChanged; }
         set{ fun_ID_IsChanged = value; }
      }
      /// <summary>
      /// 功能编码
      /// </summary>
      private string fun_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Code_IsChanged=false;
      /// <summary>
      /// 功能编码
      /// </summary>
      public string Fun_Code
      {
         get{ return fun_Code; }
         set{ fun_Code = value; fun_Code_IsChanged=true; }
      }
      /// <summary>
      /// 功能编码
      /// </summary>
      public bool Fun_Code_IsChanged
      {
         get{ return fun_Code_IsChanged; }
         set{ fun_Code_IsChanged = value; }
      }
      /// <summary>
      /// 名称
      /// </summary>
      private string fun_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Name_IsChanged=false;
      /// <summary>
      /// 名称
      /// </summary>
      public string Fun_Name
      {
         get{ return fun_Name; }
         set{ fun_Name = value; fun_Name_IsChanged=true; }
      }
      /// <summary>
      /// 名称
      /// </summary>
      public bool Fun_Name_IsChanged
      {
         get{ return fun_Name_IsChanged; }
         set{ fun_Name_IsChanged = value; }
      }
      private string fun_PCode;
      private bool fun_PCode_IsChanged=false;
      public string Fun_PCode
      {
         get{ return fun_PCode; }
         set{ fun_PCode = value; fun_PCode_IsChanged=true; }
      }
      public bool Fun_PCode_IsChanged
      {
         get{ return fun_PCode_IsChanged; }
         set{ fun_PCode_IsChanged = value; }
      }
      private int fun_Order;
      private bool fun_Order_IsChanged=false;
      public int Fun_Order
      {
         get{ return fun_Order; }
         set{ fun_Order = value; fun_Order_IsChanged=true; }
      }
      public bool Fun_Order_IsChanged
      {
         get{ return fun_Order_IsChanged; }
         set{ fun_Order_IsChanged = value; }
      }
      /// <summary>
      /// 是否启用
      /// </summary>
      private int fun_Flag;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fun_Flag_IsChanged=false;
      /// <summary>
      /// 是否启用
      /// </summary>
      public int Fun_Flag
      {
         get{ return fun_Flag; }
         set{ fun_Flag = value; fun_Flag_IsChanged=true; }
      }
      /// <summary>
      /// 是否启用
      /// </summary>
      public bool Fun_Flag_IsChanged
      {
         get{ return fun_Flag_IsChanged; }
         set{ fun_Flag_IsChanged = value; }
      }
      private string fun_Remark;
      private bool fun_Remark_IsChanged=false;
      public string Fun_Remark
      {
         get{ return fun_Remark; }
         set{ fun_Remark = value; fun_Remark_IsChanged=true; }
      }
      public bool Fun_Remark_IsChanged
      {
         get{ return fun_Remark_IsChanged; }
         set{ fun_Remark_IsChanged = value; }
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
