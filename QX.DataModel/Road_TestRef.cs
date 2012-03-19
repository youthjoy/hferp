using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 零件部位检测模板
   /// </summary>
   [Serializable]
   public partial class Road_TestRef
   {
      /// <summary>
      /// 零件部位检测序号
      /// </summary>
      private Int64 testRef_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_ID_IsChanged=false;
      /// <summary>
      /// 零件部位检测序号
      /// </summary>
      public Int64 TestRef_ID
      {
         get{ return testRef_ID; }
         set{ testRef_ID = value; testRef_ID_IsChanged=true; }
      }
      /// <summary>
      /// 零件部位检测序号
      /// </summary>
      public bool TestRef_ID_IsChanged
      {
         get{ return testRef_ID_IsChanged; }
         set{ testRef_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模板节点序号
      /// </summary>
      private int testRef_RNodeID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_RNodeID_IsChanged=false;
      /// <summary>
      /// 模板节点序号
      /// </summary>
      public int TestRef_RNodeID
      {
         get{ return testRef_RNodeID; }
         set{ testRef_RNodeID = value; testRef_RNodeID_IsChanged=true; }
      }
      /// <summary>
      /// 模板节点序号
      /// </summary>
      public bool TestRef_RNodeID_IsChanged
      {
         get{ return testRef_RNodeID_IsChanged; }
         set{ testRef_RNodeID_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string testRef_PartNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_PartNo_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string TestRef_PartNo
      {
         get{ return testRef_PartNo; }
         set{ testRef_PartNo = value; testRef_PartNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool TestRef_PartNo_IsChanged
      {
         get{ return testRef_PartNo_IsChanged; }
         set{ testRef_PartNo_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string testRef_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string TestRef_PartName
      {
         get{ return testRef_PartName; }
         set{ testRef_PartName = value; testRef_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool TestRef_PartName_IsChanged
      {
         get{ return testRef_PartName_IsChanged; }
         set{ testRef_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      private string testRef_RNodeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_RNodeCode_IsChanged=false;
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      public string TestRef_RNodeCode
      {
         get{ return testRef_RNodeCode; }
         set{ testRef_RNodeCode = value; testRef_RNodeCode_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      public bool TestRef_RNodeCode_IsChanged
      {
         get{ return testRef_RNodeCode_IsChanged; }
         set{ testRef_RNodeCode_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点名称
      /// </summary>
      private string testRef_RNodeName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_RNodeName_IsChanged=false;
      /// <summary>
      /// 工艺节点名称
      /// </summary>
      public string TestRef_RNodeName
      {
         get{ return testRef_RNodeName; }
         set{ testRef_RNodeName = value; testRef_RNodeName_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点名称
      /// </summary>
      public bool TestRef_RNodeName_IsChanged
      {
         get{ return testRef_RNodeName_IsChanged; }
         set{ testRef_RNodeName_IsChanged = value; }
      }
      /// <summary>
      /// 检测参数编号
      /// </summary>
      private string testRef_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_Code_IsChanged=false;
      /// <summary>
      /// 检测参数编号
      /// </summary>
      public string TestRef_Code
      {
         get{ return testRef_Code; }
         set{ testRef_Code = value; testRef_Code_IsChanged=true; }
      }
      /// <summary>
      /// 检测参数编号
      /// </summary>
      public bool TestRef_Code_IsChanged
      {
         get{ return testRef_Code_IsChanged; }
         set{ testRef_Code_IsChanged = value; }
      }
      /// <summary>
      /// 检测参数名称
      /// </summary>
      private string testRef_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_Name_IsChanged=false;
      /// <summary>
      /// 检测参数名称
      /// </summary>
      public string TestRef_Name
      {
         get{ return testRef_Name; }
         set{ testRef_Name = value; testRef_Name_IsChanged=true; }
      }
      /// <summary>
      /// 检测参数名称
      /// </summary>
      public bool TestRef_Name_IsChanged
      {
         get{ return testRef_Name_IsChanged; }
         set{ testRef_Name_IsChanged = value; }
      }
      /// <summary>
      /// 检测参考值
      /// </summary>
      private string testRef_Value;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_Value_IsChanged=false;
      /// <summary>
      /// 检测参考值
      /// </summary>
      public string TestRef_Value
      {
         get{ return testRef_Value; }
         set{ testRef_Value = value; testRef_Value_IsChanged=true; }
      }
      /// <summary>
      /// 检测参考值
      /// </summary>
      public bool TestRef_Value_IsChanged
      {
         get{ return testRef_Value_IsChanged; }
         set{ testRef_Value_IsChanged = value; }
      }
      /// <summary>
      /// 检测上限
      /// </summary>
      private string testRef_High;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_High_IsChanged=false;
      /// <summary>
      /// 检测上限
      /// </summary>
      public string TestRef_High
      {
         get{ return testRef_High; }
         set{ testRef_High = value; testRef_High_IsChanged=true; }
      }
      /// <summary>
      /// 检测上限
      /// </summary>
      public bool TestRef_High_IsChanged
      {
         get{ return testRef_High_IsChanged; }
         set{ testRef_High_IsChanged = value; }
      }
      /// <summary>
      /// 检测下限
      /// </summary>
      private string testRef_Low;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_Low_IsChanged=false;
      /// <summary>
      /// 检测下限
      /// </summary>
      public string TestRef_Low
      {
         get{ return testRef_Low; }
         set{ testRef_Low = value; testRef_Low_IsChanged=true; }
      }
      /// <summary>
      /// 检测下限
      /// </summary>
      public bool TestRef_Low_IsChanged
      {
         get{ return testRef_Low_IsChanged; }
         set{ testRef_Low_IsChanged = value; }
      }
      /// <summary>
      /// 检测状态
      /// </summary>
      private int testRef_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_Stat_IsChanged=false;
      /// <summary>
      /// 检测状态
      /// </summary>
      public int TestRef_Stat
      {
         get{ return testRef_Stat; }
         set{ testRef_Stat = value; testRef_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 检测状态
      /// </summary>
      public bool TestRef_Stat_IsChanged
      {
         get{ return testRef_Stat_IsChanged; }
         set{ testRef_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 检测顺序
      /// </summary>
      private int testRef_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_Order_IsChanged=false;
      /// <summary>
      /// 检测顺序
      /// </summary>
      public int TestRef_Order
      {
         get{ return testRef_Order; }
         set{ testRef_Order = value; testRef_Order_IsChanged=true; }
      }
      /// <summary>
      /// 检测顺序
      /// </summary>
      public bool TestRef_Order_IsChanged
      {
         get{ return testRef_Order_IsChanged; }
         set{ testRef_Order_IsChanged = value; }
      }
      /// <summary>
      /// 是否在终检参数
      /// </summary>
      private int testRef_IsLast;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool testRef_IsLast_IsChanged=false;
      /// <summary>
      /// 是否在终检参数
      /// </summary>
      public int TestRef_IsLast
      {
         get{ return testRef_IsLast; }
         set{ testRef_IsLast = value; testRef_IsLast_IsChanged=true; }
      }
      /// <summary>
      /// 是否在终检参数
      /// </summary>
      public bool TestRef_IsLast_IsChanged
      {
         get{ return testRef_IsLast_IsChanged; }
         set{ testRef_IsLast_IsChanged = value; }
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
