using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 零件工艺路线模板
   /// </summary>
   [Serializable]
   public partial class Road_Nodes
   {
      /// <summary>
      /// 模板节点序号
      /// </summary>
      private Int64 rNodes_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_ID_IsChanged=false;
      /// <summary>
      /// 模板节点序号
      /// </summary>
      public Int64 RNodes_ID
      {
         get{ return rNodes_ID; }
         set{ rNodes_ID = value; rNodes_ID_IsChanged=true; }
      }
      /// <summary>
      /// 模板节点序号
      /// </summary>
      public bool RNodes_ID_IsChanged
      {
         get{ return rNodes_ID_IsChanged; }
         set{ rNodes_ID_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string rNodes_PartCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_PartCode_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string RNodes_PartCode
      {
         get{ return rNodes_PartCode; }
         set{ rNodes_PartCode = value; rNodes_PartCode_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool RNodes_PartCode_IsChanged
      {
         get{ return rNodes_PartCode_IsChanged; }
         set{ rNodes_PartCode_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string rNodes_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string RNodes_PartName
      {
         get{ return rNodes_PartName; }
         set{ rNodes_PartName = value; rNodes_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool RNodes_PartName_IsChanged
      {
         get{ return rNodes_PartName_IsChanged; }
         set{ rNodes_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      private string rNodes_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Code_IsChanged=false;
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      public string RNodes_Code
      {
         get{ return rNodes_Code; }
         set{ rNodes_Code = value; rNodes_Code_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点编码
      /// </summary>
      public bool RNodes_Code_IsChanged
      {
         get{ return rNodes_Code_IsChanged; }
         set{ rNodes_Code_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点名称
      /// </summary>
      private string rNodes_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Name_IsChanged=false;
      /// <summary>
      /// 工艺节点名称
      /// </summary>
      public string RNodes_Name
      {
         get{ return rNodes_Name; }
         set{ rNodes_Name = value; rNodes_Name_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点名称
      /// </summary>
      public bool RNodes_Name_IsChanged
      {
         get{ return rNodes_Name_IsChanged; }
         set{ rNodes_Name_IsChanged = value; }
      }
      /// <summary>
      /// 工艺节点顺序
      /// </summary>
      private int rNodes_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Order_IsChanged=false;
      /// <summary>
      /// 工艺节点顺序
      /// </summary>
      public int RNodes_Order
      {
         get{ return rNodes_Order; }
         set{ rNodes_Order = value; rNodes_Order_IsChanged=true; }
      }
      /// <summary>
      /// 工艺节点顺序
      /// </summary>
      public bool RNodes_Order_IsChanged
      {
         get{ return rNodes_Order_IsChanged; }
         set{ rNodes_Order_IsChanged = value; }
      }
      /// <summary>
      /// 生产所需时间
      /// </summary>
      private decimal rNodes_TimeCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_TimeCost_IsChanged=false;
      /// <summary>
      /// 生产所需时间
      /// </summary>
      public decimal RNodes_TimeCost
      {
         get{ return rNodes_TimeCost; }
         set{ rNodes_TimeCost = value; rNodes_TimeCost_IsChanged=true; }
      }
      /// <summary>
      /// 生产所需时间
      /// </summary>
      public bool RNodes_TimeCost_IsChanged
      {
         get{ return rNodes_TimeCost_IsChanged; }
         set{ rNodes_TimeCost_IsChanged = value; }
      }
      /// <summary>
      /// 成本价格
      /// </summary>
      private decimal rNodes_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Cost_IsChanged=false;
      /// <summary>
      /// 成本价格
      /// </summary>
      public decimal RNodes_Cost
      {
         get{ return rNodes_Cost; }
         set{ rNodes_Cost = value; rNodes_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 成本价格
      /// </summary>
      public bool RNodes_Cost_IsChanged
      {
         get{ return rNodes_Cost_IsChanged; }
         set{ rNodes_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 生产价值
      /// </summary>
      private decimal rNodes_Value;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Value_IsChanged=false;
      /// <summary>
      /// 生产价值
      /// </summary>
      public decimal RNodes_Value
      {
         get{ return rNodes_Value; }
         set{ rNodes_Value = value; rNodes_Value_IsChanged=true; }
      }
      /// <summary>
      /// 生产价值
      /// </summary>
      public bool RNodes_Value_IsChanged
      {
         get{ return rNodes_Value_IsChanged; }
         set{ rNodes_Value_IsChanged = value; }
      }
      /// <summary>
      /// 价格审核状态
      /// </summary>
      private int rNodes_PriceStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_PriceStat_IsChanged=false;
      /// <summary>
      /// 价格审核状态
      /// </summary>
      public int RNodes_PriceStat
      {
         get{ return rNodes_PriceStat; }
         set{ rNodes_PriceStat = value; rNodes_PriceStat_IsChanged=true; }
      }
      /// <summary>
      /// 价格审核状态
      /// </summary>
      public bool RNodes_PriceStat_IsChanged
      {
         get{ return rNodes_PriceStat_IsChanged; }
         set{ rNodes_PriceStat_IsChanged = value; }
      }
      /// <summary>
      /// 模板节点状态
      /// </summary>
      private int rNodes_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Stat_IsChanged=false;
      /// <summary>
      /// 模板节点状态
      /// </summary>
      public int RNodes_Stat
      {
         get{ return rNodes_Stat; }
         set{ rNodes_Stat = value; rNodes_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 模板节点状态
      /// </summary>
      public bool RNodes_Stat_IsChanged
      {
         get{ return rNodes_Stat_IsChanged; }
         set{ rNodes_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 节点使用部门编码
      /// </summary>
      private string rNodes_Dept_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Dept_Code_IsChanged=false;
      /// <summary>
      /// 节点使用部门编码
      /// </summary>
      public string RNodes_Dept_Code
      {
         get{ return rNodes_Dept_Code; }
         set{ rNodes_Dept_Code = value; rNodes_Dept_Code_IsChanged=true; }
      }
      /// <summary>
      /// 节点使用部门编码
      /// </summary>
      public bool RNodes_Dept_Code_IsChanged
      {
         get{ return rNodes_Dept_Code_IsChanged; }
         set{ rNodes_Dept_Code_IsChanged = value; }
      }
      /// <summary>
      /// 节点使用部门名称
      /// </summary>
      private string rNodes_Dept_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Dept_Name_IsChanged=false;
      /// <summary>
      /// 节点使用部门名称
      /// </summary>
      public string RNodes_Dept_Name
      {
         get{ return rNodes_Dept_Name; }
         set{ rNodes_Dept_Name = value; rNodes_Dept_Name_IsChanged=true; }
      }
      /// <summary>
      /// 节点使用部门名称
      /// </summary>
      public bool RNodes_Dept_Name_IsChanged
      {
         get{ return rNodes_Dept_Name_IsChanged; }
         set{ rNodes_Dept_Name_IsChanged = value; }
      }
      private string rNodes_EquCode;
      private bool rNodes_EquCode_IsChanged=false;
      public string RNodes_EquCode
      {
         get{ return rNodes_EquCode; }
         set{ rNodes_EquCode = value; rNodes_EquCode_IsChanged=true; }
      }
      public bool RNodes_EquCode_IsChanged
      {
         get{ return rNodes_EquCode_IsChanged; }
         set{ rNodes_EquCode_IsChanged = value; }
      }
      private string rNodes_EquName;
      private bool rNodes_EquName_IsChanged=false;
      public string RNodes_EquName
      {
         get{ return rNodes_EquName; }
         set{ rNodes_EquName = value; rNodes_EquName_IsChanged=true; }
      }
      public bool RNodes_EquName_IsChanged
      {
         get{ return rNodes_EquName_IsChanged; }
         set{ rNodes_EquName_IsChanged = value; }
      }
      private decimal rNodes_EquTime;
      private bool rNodes_EquTime_IsChanged=false;
      public decimal RNodes_EquTime
      {
         get{ return rNodes_EquTime; }
         set{ rNodes_EquTime = value; rNodes_EquTime_IsChanged=true; }
      }
      public bool RNodes_EquTime_IsChanged
      {
         get{ return rNodes_EquTime_IsChanged; }
         set{ rNodes_EquTime_IsChanged = value; }
      }
      /// <summary>
      /// 班组编号
      /// </summary>
      private string rNodes_Class_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Class_Code_IsChanged=false;
      /// <summary>
      /// 班组编号
      /// </summary>
      public string RNodes_Class_Code
      {
         get{ return rNodes_Class_Code; }
         set{ rNodes_Class_Code = value; rNodes_Class_Code_IsChanged=true; }
      }
      /// <summary>
      /// 班组编号
      /// </summary>
      public bool RNodes_Class_Code_IsChanged
      {
         get{ return rNodes_Class_Code_IsChanged; }
         set{ rNodes_Class_Code_IsChanged = value; }
      }
      /// <summary>
      /// 班组名称
      /// </summary>
      private string rNodes_Class_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Class_Name_IsChanged=false;
      /// <summary>
      /// 班组名称
      /// </summary>
      public string RNodes_Class_Name
      {
         get{ return rNodes_Class_Name; }
         set{ rNodes_Class_Name = value; rNodes_Class_Name_IsChanged=true; }
      }
      /// <summary>
      /// 班组名称
      /// </summary>
      public bool RNodes_Class_Name_IsChanged
      {
         get{ return rNodes_Class_Name_IsChanged; }
         set{ rNodes_Class_Name_IsChanged = value; }
      }
      /// <summary>
      /// 功能标志
      /// </summary>
      private int rNodes_Func;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_Func_IsChanged=false;
      /// <summary>
      /// 功能标志
      /// </summary>
      public int RNodes_Func
      {
         get{ return rNodes_Func; }
         set{ rNodes_Func = value; rNodes_Func_IsChanged=true; }
      }
      /// <summary>
      /// 功能标志
      /// </summary>
      public bool RNodes_Func_IsChanged
      {
         get{ return rNodes_Func_IsChanged; }
         set{ rNodes_Func_IsChanged = value; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      private int rNodes_CurPriceNode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rNodes_CurPriceNode_IsChanged=false;
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public int RNodes_CurPriceNode
      {
         get{ return rNodes_CurPriceNode; }
         set{ rNodes_CurPriceNode = value; rNodes_CurPriceNode_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public bool RNodes_CurPriceNode_IsChanged
      {
         get{ return rNodes_CurPriceNode_IsChanged; }
         set{ rNodes_CurPriceNode_IsChanged = value; }
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
      private DateTime updateTime;
      private bool updateTime_IsChanged=false;
      public DateTime UpdateTime
      {
         get{ return updateTime; }
         set{ updateTime = value; updateTime_IsChanged=true; }
      }
      public bool UpdateTime_IsChanged
      {
         get{ return updateTime_IsChanged; }
         set{ updateTime_IsChanged = value; }
      }
      private decimal rNodes_Udef1;
      private bool rNodes_Udef1_IsChanged=false;
      public decimal RNodes_Udef1
      {
         get{ return rNodes_Udef1; }
         set{ rNodes_Udef1 = value; rNodes_Udef1_IsChanged=true; }
      }
      public bool RNodes_Udef1_IsChanged
      {
         get{ return rNodes_Udef1_IsChanged; }
         set{ rNodes_Udef1_IsChanged = value; }
      }
      private decimal rNodes_Udef2;
      private bool rNodes_Udef2_IsChanged=false;
      public decimal RNodes_Udef2
      {
         get{ return rNodes_Udef2; }
         set{ rNodes_Udef2 = value; rNodes_Udef2_IsChanged=true; }
      }
      public bool RNodes_Udef2_IsChanged
      {
         get{ return rNodes_Udef2_IsChanged; }
         set{ rNodes_Udef2_IsChanged = value; }
      }
      private decimal rNodes_Udef3;
      private bool rNodes_Udef3_IsChanged=false;
      public decimal RNodes_Udef3
      {
         get{ return rNodes_Udef3; }
         set{ rNodes_Udef3 = value; rNodes_Udef3_IsChanged=true; }
      }
      public bool RNodes_Udef3_IsChanged
      {
         get{ return rNodes_Udef3_IsChanged; }
         set{ rNodes_Udef3_IsChanged = value; }
      }
   }
}
