using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class FHelper_Out
   {
      /// <summary>
      /// 外协出厂序号
      /// </summary>
      private Int64 fOut_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fOut_ID_IsChanged=false;
      /// <summary>
      /// 外协出厂序号
      /// </summary>
      public Int64 FOut_ID
      {
         get{ return fOut_ID; }
         set{ fOut_ID = value; fOut_ID_IsChanged=true; }
      }
      /// <summary>
      /// 外协出厂序号
      /// </summary>
      public bool FOut_ID_IsChanged
      {
         get{ return fOut_ID_IsChanged; }
         set{ fOut_ID_IsChanged = value; }
      }
      /// <summary>
      /// 操作经办人
      /// </summary>
      private string fOut_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fOut_Owner_IsChanged=false;
      /// <summary>
      /// 操作经办人
      /// </summary>
      public string FOut_Owner
      {
         get{ return fOut_Owner; }
         set{ fOut_Owner = value; fOut_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 操作经办人
      /// </summary>
      public bool FOut_Owner_IsChanged
      {
         get{ return fOut_Owner_IsChanged; }
         set{ fOut_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 操作经办时间
      /// </summary>
      private DateTime fOut_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fOut_Date_IsChanged=false;
      /// <summary>
      /// 操作经办时间
      /// </summary>
      public DateTime FOut_Date
      {
         get{ return fOut_Date; }
         set{ fOut_Date = value; fOut_Date_IsChanged=true; }
      }
      /// <summary>
      /// 操作经办时间
      /// </summary>
      public bool FOut_Date_IsChanged
      {
         get{ return fOut_Date_IsChanged; }
         set{ fOut_Date_IsChanged = value; }
      }
      /// <summary>
      /// 是否打印操作单
      /// </summary>
      private int fout_IsPrint;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fout_IsPrint_IsChanged=false;
      /// <summary>
      /// 是否打印操作单
      /// </summary>
      public int Fout_IsPrint
      {
         get{ return fout_IsPrint; }
         set{ fout_IsPrint = value; fout_IsPrint_IsChanged=true; }
      }
      /// <summary>
      /// 是否打印操作单
      /// </summary>
      public bool Fout_IsPrint_IsChanged
      {
         get{ return fout_IsPrint_IsChanged; }
         set{ fout_IsPrint_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int fOut_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fOut_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int FOut_Num
      {
         get{ return fOut_Num; }
         set{ fOut_Num = value; fOut_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool FOut_Num_IsChanged
      {
         get{ return fOut_Num_IsChanged; }
         set{ fOut_Num_IsChanged = value; }
      }
      /// <summary>
      /// 外协操作类型
      /// </summary>
      private string fOut_OPType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fOut_OPType_IsChanged=false;
      /// <summary>
      /// 外协操作类型
      /// </summary>
      public string FOut_OPType
      {
         get{ return fOut_OPType; }
         set{ fOut_OPType = value; fOut_OPType_IsChanged=true; }
      }
      /// <summary>
      /// 外协操作类型
      /// </summary>
      public bool FOut_OPType_IsChanged
      {
         get{ return fOut_OPType_IsChanged; }
         set{ fOut_OPType_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int fOut_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fOut_Stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int FOut_Stat
      {
         get{ return fOut_Stat; }
         set{ fOut_Stat = value; fOut_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      public bool FOut_Stat_IsChanged
      {
         get{ return fOut_Stat_IsChanged; }
         set{ fOut_Stat_IsChanged = value; }
      }
   }
}
