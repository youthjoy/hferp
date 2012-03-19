using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class UserRelationData
   {
      /// <summary>
      /// 用户关联数据序号
      /// </summary>
      private int uRD_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uRD_ID_IsChanged=false;
      /// <summary>
      /// 用户关联数据序号
      /// </summary>
      public int URD_ID
      {
         get{ return uRD_ID; }
         set{ uRD_ID = value; uRD_ID_IsChanged=true; }
      }
      /// <summary>
      /// 用户关联数据序号
      /// </summary>
      public bool URD_ID_IsChanged
      {
         get{ return uRD_ID_IsChanged; }
         set{ uRD_ID_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string uRD_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uRD_Operator_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string URD_Operator
      {
         get{ return uRD_Operator; }
         set{ uRD_Operator = value; uRD_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool URD_Operator_IsChanged
      {
         get{ return uRD_Operator_IsChanged; }
         set{ uRD_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      private DateTime uRD_OpTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uRD_OpTime_IsChanged=false;
      /// <summary>
      /// 操作时间
      /// </summary>
      public DateTime URD_OpTime
      {
         get{ return uRD_OpTime; }
         set{ uRD_OpTime = value; uRD_OpTime_IsChanged=true; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      public bool URD_OpTime_IsChanged
      {
         get{ return uRD_OpTime_IsChanged; }
         set{ uRD_OpTime_IsChanged = value; }
      }
      /// <summary>
      /// 数据关联模块
      /// </summary>
      private string uRD_Module;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uRD_Module_IsChanged=false;
      /// <summary>
      /// 数据关联模块
      /// </summary>
      public string URD_Module
      {
         get{ return uRD_Module; }
         set{ uRD_Module = value; uRD_Module_IsChanged=true; }
      }
      /// <summary>
      /// 数据关联模块
      /// </summary>
      public bool URD_Module_IsChanged
      {
         get{ return uRD_Module_IsChanged; }
         set{ uRD_Module_IsChanged = value; }
      }
      /// <summary>
      /// 操作类型
      /// </summary>
      private string uRD_OpType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uRD_OpType_IsChanged=false;
      /// <summary>
      /// 操作类型
      /// </summary>
      public string URD_OpType
      {
         get{ return uRD_OpType; }
         set{ uRD_OpType = value; uRD_OpType_IsChanged=true; }
      }
      /// <summary>
      /// 操作类型
      /// </summary>
      public bool URD_OpType_IsChanged
      {
         get{ return uRD_OpType_IsChanged; }
         set{ uRD_OpType_IsChanged = value; }
      }
      /// <summary>
      /// 关联的数据编码
      /// </summary>
      private string uRD_DataCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uRD_DataCode_IsChanged=false;
      /// <summary>
      /// 关联的数据编码
      /// </summary>
      public string URD_DataCode
      {
         get{ return uRD_DataCode; }
         set{ uRD_DataCode = value; uRD_DataCode_IsChanged=true; }
      }
      /// <summary>
      /// 关联的数据编码
      /// </summary>
      public bool URD_DataCode_IsChanged
      {
         get{ return uRD_DataCode_IsChanged; }
         set{ uRD_DataCode_IsChanged = value; }
      }
   }
}
