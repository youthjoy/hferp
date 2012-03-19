using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class FHelper_ManuList
   {
      /// <summary>
      /// 外协厂家序号
      /// </summary>
      private int fM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_ID_IsChanged=false;
      /// <summary>
      /// 外协厂家序号
      /// </summary>
      public int FM_ID
      {
         get{ return fM_ID; }
         set{ fM_ID = value; fM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家序号
      /// </summary>
      public bool FM_ID_IsChanged
      {
         get{ return fM_ID_IsChanged; }
         set{ fM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家编码
      /// </summary>
      private string fM_ManuCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_ManuCode_IsChanged=false;
      /// <summary>
      /// 外协厂家编码
      /// </summary>
      public string FM_ManuCode
      {
         get{ return fM_ManuCode; }
         set{ fM_ManuCode = value; fM_ManuCode_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家编码
      /// </summary>
      public bool FM_ManuCode_IsChanged
      {
         get{ return fM_ManuCode_IsChanged; }
         set{ fM_ManuCode_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家名称
      /// </summary>
      private string fM_ManuName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_ManuName_IsChanged=false;
      /// <summary>
      /// 外协厂家名称
      /// </summary>
      public string FM_ManuName
      {
         get{ return fM_ManuName; }
         set{ fM_ManuName = value; fM_ManuName_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家名称
      /// </summary>
      public bool FM_ManuName_IsChanged
      {
         get{ return fM_ManuName_IsChanged; }
         set{ fM_ManuName_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家联系号码
      /// </summary>
      private string fM_Telephone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_Telephone_IsChanged=false;
      /// <summary>
      /// 外协厂家联系号码
      /// </summary>
      public string FM_Telephone
      {
         get{ return fM_Telephone; }
         set{ fM_Telephone = value; fM_Telephone_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家联系号码
      /// </summary>
      public bool FM_Telephone_IsChanged
      {
         get{ return fM_Telephone_IsChanged; }
         set{ fM_Telephone_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家联系人
      /// </summary>
      private string fM_Contactor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_Contactor_IsChanged=false;
      /// <summary>
      /// 外协厂家联系人
      /// </summary>
      public string FM_Contactor
      {
         get{ return fM_Contactor; }
         set{ fM_Contactor = value; fM_Contactor_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家联系人
      /// </summary>
      public bool FM_Contactor_IsChanged
      {
         get{ return fM_Contactor_IsChanged; }
         set{ fM_Contactor_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂家地址
      /// </summary>
      private string fM_Address;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_Address_IsChanged=false;
      /// <summary>
      /// 外协厂家地址
      /// </summary>
      public string FM_Address
      {
         get{ return fM_Address; }
         set{ fM_Address = value; fM_Address_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂家地址
      /// </summary>
      public bool FM_Address_IsChanged
      {
         get{ return fM_Address_IsChanged; }
         set{ fM_Address_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string fM_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fM_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string FM_Remark
      {
         get{ return fM_Remark; }
         set{ fM_Remark = value; fM_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool FM_Remark_IsChanged
      {
         get{ return fM_Remark_IsChanged; }
         set{ fM_Remark_IsChanged = value; }
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
