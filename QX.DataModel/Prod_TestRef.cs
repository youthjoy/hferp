using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Prod_TestRef
   {
      private Int64 pTestRef_ID;
      private bool pTestRef_ID_IsChanged=false;
      public Int64 PTestRef_ID
      {
         get{ return pTestRef_ID; }
         set{ pTestRef_ID = value; pTestRef_ID_IsChanged=true; }
      }
      public bool PTestRef_ID_IsChanged
      {
         get{ return pTestRef_ID_IsChanged; }
         set{ pTestRef_ID_IsChanged = value; }
      }
      /// <summary>
      /// 检测记录编码
      /// </summary>
      private string pTestRef_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_Code_IsChanged=false;
      /// <summary>
      /// 检测记录编码
      /// </summary>
      public string PTestRef_Code
      {
         get{ return pTestRef_Code; }
         set{ pTestRef_Code = value; pTestRef_Code_IsChanged=true; }
      }
      /// <summary>
      /// 检测记录编码
      /// </summary>
      public bool PTestRef_Code_IsChanged
      {
         get{ return pTestRef_Code_IsChanged; }
         set{ pTestRef_Code_IsChanged = value; }
      }
      /// <summary>
      /// 零件编号
      /// </summary>
      private string pTestRef_ProdCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_ProdCode_IsChanged=false;
      /// <summary>
      /// 零件编号
      /// </summary>
      public string PTestRef_ProdCode
      {
         get{ return pTestRef_ProdCode; }
         set{ pTestRef_ProdCode = value; pTestRef_ProdCode_IsChanged=true; }
      }
      /// <summary>
      /// 零件编号
      /// </summary>
      public bool PTestRef_ProdCode_IsChanged
      {
         get{ return pTestRef_ProdCode_IsChanged; }
         set{ pTestRef_ProdCode_IsChanged = value; }
      }
      /// <summary>
      /// 工序编号
      /// </summary>
      private string pTestRef_NodeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_NodeCode_IsChanged=false;
      /// <summary>
      /// 工序编号
      /// </summary>
      public string PTestRef_NodeCode
      {
         get{ return pTestRef_NodeCode; }
         set{ pTestRef_NodeCode = value; pTestRef_NodeCode_IsChanged=true; }
      }
      /// <summary>
      /// 工序编号
      /// </summary>
      public bool PTestRef_NodeCode_IsChanged
      {
         get{ return pTestRef_NodeCode_IsChanged; }
         set{ pTestRef_NodeCode_IsChanged = value; }
      }
      /// <summary>
      /// 工序名称
      /// </summary>
      private string pTestRef_NodeName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_NodeName_IsChanged=false;
      /// <summary>
      /// 工序名称
      /// </summary>
      public string PTestRef_NodeName
      {
         get{ return pTestRef_NodeName; }
         set{ pTestRef_NodeName = value; pTestRef_NodeName_IsChanged=true; }
      }
      /// <summary>
      /// 工序名称
      /// </summary>
      public bool PTestRef_NodeName_IsChanged
      {
         get{ return pTestRef_NodeName_IsChanged; }
         set{ pTestRef_NodeName_IsChanged = value; }
      }
      /// <summary>
      /// 部位参数编号
      /// </summary>
      private string pTestRef_TestNode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_TestNode_IsChanged=false;
      /// <summary>
      /// 部位参数编号
      /// </summary>
      public string PTestRef_TestNode
      {
         get{ return pTestRef_TestNode; }
         set{ pTestRef_TestNode = value; pTestRef_TestNode_IsChanged=true; }
      }
      /// <summary>
      /// 部位参数编号
      /// </summary>
      public bool PTestRef_TestNode_IsChanged
      {
         get{ return pTestRef_TestNode_IsChanged; }
         set{ pTestRef_TestNode_IsChanged = value; }
      }
      /// <summary>
      /// 部位参数名称
      /// </summary>
      private string pTestRef_TestName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_TestName_IsChanged=false;
      /// <summary>
      /// 部位参数名称
      /// </summary>
      public string PTestRef_TestName
      {
         get{ return pTestRef_TestName; }
         set{ pTestRef_TestName = value; pTestRef_TestName_IsChanged=true; }
      }
      /// <summary>
      /// 部位参数名称
      /// </summary>
      public bool PTestRef_TestName_IsChanged
      {
         get{ return pTestRef_TestName_IsChanged; }
         set{ pTestRef_TestName_IsChanged = value; }
      }
      /// <summary>
      /// 部位参数参考值
      /// </summary>
      private string pTestRef_RefValue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_RefValue_IsChanged=false;
      /// <summary>
      /// 部位参数参考值
      /// </summary>
      public string PTestRef_RefValue
      {
         get{ return pTestRef_RefValue; }
         set{ pTestRef_RefValue = value; pTestRef_RefValue_IsChanged=true; }
      }
      /// <summary>
      /// 部位参数参考值
      /// </summary>
      public bool PTestRef_RefValue_IsChanged
      {
         get{ return pTestRef_RefValue_IsChanged; }
         set{ pTestRef_RefValue_IsChanged = value; }
      }
      /// <summary>
      /// 部位检测上限
      /// </summary>
      private string pTestRef_High;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_High_IsChanged=false;
      /// <summary>
      /// 部位检测上限
      /// </summary>
      public string PTestRef_High
      {
         get{ return pTestRef_High; }
         set{ pTestRef_High = value; pTestRef_High_IsChanged=true; }
      }
      /// <summary>
      /// 部位检测上限
      /// </summary>
      public bool PTestRef_High_IsChanged
      {
         get{ return pTestRef_High_IsChanged; }
         set{ pTestRef_High_IsChanged = value; }
      }
      /// <summary>
      /// 部位检测下限
      /// </summary>
      private string pTestRef_Low;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_Low_IsChanged=false;
      /// <summary>
      /// 部位检测下限
      /// </summary>
      public string PTestRef_Low
      {
         get{ return pTestRef_Low; }
         set{ pTestRef_Low = value; pTestRef_Low_IsChanged=true; }
      }
      /// <summary>
      /// 部位检测下限
      /// </summary>
      public bool PTestRef_Low_IsChanged
      {
         get{ return pTestRef_Low_IsChanged; }
         set{ pTestRef_Low_IsChanged = value; }
      }
      /// <summary>
      /// 部位检测顺序
      /// </summary>
      private int pTestRef_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_Order_IsChanged=false;
      /// <summary>
      /// 部位检测顺序
      /// </summary>
      public int PTestRef_Order
      {
         get{ return pTestRef_Order; }
         set{ pTestRef_Order = value; pTestRef_Order_IsChanged=true; }
      }
      /// <summary>
      /// 部位检测顺序
      /// </summary>
      public bool PTestRef_Order_IsChanged
      {
         get{ return pTestRef_Order_IsChanged; }
         set{ pTestRef_Order_IsChanged = value; }
      }
      /// <summary>
      /// 是否终检参数
      /// </summary>
      private int pTestRef_IsLast;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_IsLast_IsChanged=false;
      /// <summary>
      /// 是否终检参数
      /// </summary>
      public int PTestRef_IsLast
      {
         get{ return pTestRef_IsLast; }
         set{ pTestRef_IsLast = value; pTestRef_IsLast_IsChanged=true; }
      }
      /// <summary>
      /// 是否终检参数
      /// </summary>
      public bool PTestRef_IsLast_IsChanged
      {
         get{ return pTestRef_IsLast_IsChanged; }
         set{ pTestRef_IsLast_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string pTestRef_PartCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_PartCode_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string PTestRef_PartCode
      {
         get{ return pTestRef_PartCode; }
         set{ pTestRef_PartCode = value; pTestRef_PartCode_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool PTestRef_PartCode_IsChanged
      {
         get{ return pTestRef_PartCode_IsChanged; }
         set{ pTestRef_PartCode_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string pTestRef_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string PTestRef_PartName
      {
         get{ return pTestRef_PartName; }
         set{ pTestRef_PartName = value; pTestRef_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool PTestRef_PartName_IsChanged
      {
         get{ return pTestRef_PartName_IsChanged; }
         set{ pTestRef_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 检测状态
      /// </summary>
      private int pTestRef_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pTestRef_Stat_IsChanged=false;
      /// <summary>
      /// 检测状态
      /// </summary>
      public int PTestRef_Stat
      {
         get{ return pTestRef_Stat; }
         set{ pTestRef_Stat = value; pTestRef_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 检测状态
      /// </summary>
      public bool PTestRef_Stat_IsChanged
      {
         get{ return pTestRef_Stat_IsChanged; }
         set{ pTestRef_Stat_IsChanged = value; }
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
