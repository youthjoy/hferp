using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 工时审核表
   /// </summary>
   [Serializable]
   public partial class ManHour_Verify
   {
      /// <summary>
      /// 工时审核编号
      /// </summary>
      private Int64 verify_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_ID_IsChanged=false;
      /// <summary>
      /// 工时审核编号
      /// </summary>
      public Int64 Verify_ID
      {
         get{ return verify_ID; }
         set{ verify_ID = value; verify_ID_IsChanged=true; }
      }
      /// <summary>
      /// 工时审核编号
      /// </summary>
      public bool Verify_ID_IsChanged
      {
         get{ return verify_ID_IsChanged; }
         set{ verify_ID_IsChanged = value; }
      }
      /// <summary>
      /// 零图件号
      /// </summary>
      private string verify_PartCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_PartCode_IsChanged=false;
      /// <summary>
      /// 零图件号
      /// </summary>
      public string Verify_PartCode
      {
         get{ return verify_PartCode; }
         set{ verify_PartCode = value; verify_PartCode_IsChanged=true; }
      }
      /// <summary>
      /// 零图件号
      /// </summary>
      public bool Verify_PartCode_IsChanged
      {
         get{ return verify_PartCode_IsChanged; }
         set{ verify_PartCode_IsChanged = value; }
      }
      /// <summary>
      /// 生产工时
      /// </summary>
      private decimal verify_ManHour;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_ManHour_IsChanged=false;
      /// <summary>
      /// 生产工时
      /// </summary>
      public decimal Verify_ManHour
      {
         get{ return verify_ManHour; }
         set{ verify_ManHour = value; verify_ManHour_IsChanged=true; }
      }
      /// <summary>
      /// 生产工时
      /// </summary>
      public bool Verify_ManHour_IsChanged
      {
         get{ return verify_ManHour_IsChanged; }
         set{ verify_ManHour_IsChanged = value; }
      }
      /// <summary>
      /// 成本价格
      /// </summary>
      private int verify_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_Cost_IsChanged=false;
      /// <summary>
      /// 成本价格
      /// </summary>
      public int Verify_Cost
      {
         get{ return verify_Cost; }
         set{ verify_Cost = value; verify_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 成本价格
      /// </summary>
      public bool Verify_Cost_IsChanged
      {
         get{ return verify_Cost_IsChanged; }
         set{ verify_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private int verify_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_Stat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public int Verify_Stat
      {
         get{ return verify_Stat; }
         set{ verify_Stat = value; verify_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool Verify_Stat_IsChanged
      {
         get{ return verify_Stat_IsChanged; }
         set{ verify_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime verify_Time;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_Time_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime Verify_Time
      {
         get{ return verify_Time; }
         set{ verify_Time = value; verify_Time_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool Verify_Time_IsChanged
      {
         get{ return verify_Time_IsChanged; }
         set{ verify_Time_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string verify_Resp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_Resp_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string Verify_Resp
      {
         get{ return verify_Resp; }
         set{ verify_Resp = value; verify_Resp_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool Verify_Resp_IsChanged
      {
         get{ return verify_Resp_IsChanged; }
         set{ verify_Resp_IsChanged = value; }
      }
      /// <summary>
      /// 审核人姓名
      /// </summary>
      private string verify_RespName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_RespName_IsChanged=false;
      /// <summary>
      /// 审核人姓名
      /// </summary>
      public string Verify_RespName
      {
         get{ return verify_RespName; }
         set{ verify_RespName = value; verify_RespName_IsChanged=true; }
      }
      /// <summary>
      /// 审核人姓名
      /// </summary>
      public bool Verify_RespName_IsChanged
      {
         get{ return verify_RespName_IsChanged; }
         set{ verify_RespName_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      private string verify_RoadNodeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verify_RoadNodeCode_IsChanged=false;
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      public string Verify_RoadNodeCode
      {
         get{ return verify_RoadNodeCode; }
         set{ verify_RoadNodeCode = value; verify_RoadNodeCode_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      public bool Verify_RoadNodeCode_IsChanged
      {
         get{ return verify_RoadNodeCode_IsChanged; }
         set{ verify_RoadNodeCode_IsChanged = value; }
      }
   }
}
