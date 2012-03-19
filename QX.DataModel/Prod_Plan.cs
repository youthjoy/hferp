using System;
using System.Data;


namespace QX.DataModel
{
   /// <summary>
   /// 生产计划表(下达)
   /// </summary>
   [Serializable]
   public partial class Prod_Plan
   {
      /// <summary>
      /// 生产任务下达序号
      /// </summary>
      private Int64 plan_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_ID_IsChanged=false;
      /// <summary>
      /// 生产任务下达序号
      /// </summary>
      [MetaData("Plan_ID","生产任务下达序号")]
      public Int64 Plan_ID
      {
         get{ return plan_ID; }
         set{ plan_ID = value; plan_ID_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务下达序号
      /// </summary>
      public bool Plan_ID_IsChanged
      {
         get{ return plan_ID_IsChanged; }
         set{ plan_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务下达编号
      /// </summary>
      private string plan_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Code_IsChanged=false;
      /// <summary>
      /// 生产任务下达编号
      /// </summary>
      [MetaData("Plan_Code","生产任务下达编号")]
      public string Plan_Code
      {
         get{ return plan_Code; }
         set{ plan_Code = value; plan_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务下达编号
      /// </summary>
      public bool Plan_Code_IsChanged
      {
         get{ return plan_Code_IsChanged; }
         set{ plan_Code_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务编号
      /// </summary>
      private string plan_Task_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Task_Code_IsChanged=false;
      /// <summary>
      /// 生产任务编号
      /// </summary>
      [MetaData("Plan_Task_Code","生产任务编号")]
      public string Plan_Task_Code
      {
         get{ return plan_Task_Code; }
         set{ plan_Task_Code = value; plan_Task_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务编号
      /// </summary>
      public bool Plan_Task_Code_IsChanged
      {
         get{ return plan_Task_Code_IsChanged; }
         set{ plan_Task_Code_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务明细编号
      /// </summary>
      private string plan_TaskDetail_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_TaskDetail_Code_IsChanged=false;
      /// <summary>
      /// 生产任务明细编号
      /// </summary>
      [MetaData("Plan_TaskDetail_Code","生产任务明细编号")]
      public string Plan_TaskDetail_Code
      {
         get{ return plan_TaskDetail_Code; }
         set{ plan_TaskDetail_Code = value; plan_TaskDetail_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务明细编号
      /// </summary>
      public bool Plan_TaskDetail_Code_IsChanged
      {
         get{ return plan_TaskDetail_Code_IsChanged; }
         set{ plan_TaskDetail_Code_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务名称
      /// </summary>
      private string plan_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Name_IsChanged=false;
      /// <summary>
      /// 生产任务名称
      /// </summary>
      [MetaData("Plan_Name","生产任务名称")]
      public string Plan_Name
      {
         get{ return plan_Name; }
         set{ plan_Name = value; plan_Name_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务名称
      /// </summary>
      public bool Plan_Name_IsChanged
      {
         get{ return plan_Name_IsChanged; }
         set{ plan_Name_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令明细号
      /// </summary>
      private string plan_CmdDetail_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_CmdDetail_Code_IsChanged=false;
      /// <summary>
      /// 生产指令明细号
      /// </summary>
      [MetaData("Plan_CmdDetail_Code","生产指令明细号")]
      public string Plan_CmdDetail_Code
      {
         get{ return plan_CmdDetail_Code; }
         set{ plan_CmdDetail_Code = value; plan_CmdDetail_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令明细号
      /// </summary>
      public bool Plan_CmdDetail_Code_IsChanged
      {
         get{ return plan_CmdDetail_Code_IsChanged; }
         set{ plan_CmdDetail_Code_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令号
      /// </summary>
      private string plan_Cmd_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Cmd_Code_IsChanged=false;
      /// <summary>
      /// 生产指令号
      /// </summary>
      [MetaData("Plan_Cmd_Code","生产指令号")]
      public string Plan_Cmd_Code
      {
         get{ return plan_Cmd_Code; }
         set{ plan_Cmd_Code = value; plan_Cmd_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令号
      /// </summary>
      public bool Plan_Cmd_Code_IsChanged
      {
         get{ return plan_Cmd_Code_IsChanged; }
         set{ plan_Cmd_Code_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string plan_PartCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_PartCode_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      [MetaData("Plan_PartCode","零件图号")]
      public string Plan_PartCode
      {
         get{ return plan_PartCode; }
         set{ plan_PartCode = value; plan_PartCode_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool Plan_PartCode_IsChanged
      {
         get{ return plan_PartCode_IsChanged; }
         set{ plan_PartCode_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string plan_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      [MetaData("Plan_PartName","零件名称")]
      public string Plan_PartName
      {
         get{ return plan_PartName; }
         set{ plan_PartName = value; plan_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool Plan_PartName_IsChanged
      {
         get{ return plan_PartName_IsChanged; }
         set{ plan_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string plan_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      [MetaData("Plan_Unit","单位")]
      public string Plan_Unit
      {
         get{ return plan_Unit; }
         set{ plan_Unit = value; plan_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool Plan_Unit_IsChanged
      {
         get{ return plan_Unit_IsChanged; }
         set{ plan_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 下达数量
      /// </summary>
      private int plan_DNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_DNum_IsChanged=false;
      /// <summary>
      /// 下达数量
      /// </summary>
      [MetaData("Plan_DNum","下达数量")]
      public int Plan_DNum
      {
         get{ return plan_DNum; }
         set{ plan_DNum = value; plan_DNum_IsChanged=true; }
      }
      /// <summary>
      /// 下达数量
      /// </summary>
      public bool Plan_DNum_IsChanged
      {
         get{ return plan_DNum_IsChanged; }
         set{ plan_DNum_IsChanged = value; }
      }
      /// <summary>
      /// 计划开工时间
      /// </summary>
      private DateTime plan_Begin;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Begin_IsChanged=false;
      /// <summary>
      /// 计划开工时间
      /// </summary>
      [MetaData("Plan_Begin","计划开工时间")]
      public DateTime Plan_Begin
      {
         get{ return plan_Begin; }
         set{ plan_Begin = value; plan_Begin_IsChanged=true; }
      }
      /// <summary>
      /// 计划开工时间
      /// </summary>
      public bool Plan_Begin_IsChanged
      {
         get{ return plan_Begin_IsChanged; }
         set{ plan_Begin_IsChanged = value; }
      }
      /// <summary>
      /// 计划完工时间
      /// </summary>
      private DateTime plan_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_End_IsChanged=false;
      /// <summary>
      /// 计划完工时间
      /// </summary>
      [MetaData("Plan_End","计划完工时间")]
      public DateTime Plan_End
      {
         get{ return plan_End; }
         set{ plan_End = value; plan_End_IsChanged=true; }
      }
      /// <summary>
      /// 计划完工时间
      /// </summary>
      public bool Plan_End_IsChanged
      {
         get{ return plan_End_IsChanged; }
         set{ plan_End_IsChanged = value; }
      }
      /// <summary>
      /// 工序名称
      /// </summary>
      private string plan_Roads;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Roads_IsChanged=false;
      /// <summary>
      /// 工序名称
      /// </summary>
      [MetaData("Plan_Roads","工序名称")]
      public string Plan_Roads
      {
         get{ return plan_Roads; }
         set{ plan_Roads = value; plan_Roads_IsChanged=true; }
      }
      /// <summary>
      /// 工序名称
      /// </summary>
      public bool Plan_Roads_IsChanged
      {
         get{ return plan_Roads_IsChanged; }
         set{ plan_Roads_IsChanged = value; }
      }
      /// <summary>
      /// 产品编号列表
      /// </summary>
      private string plan_ProdCodes;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_ProdCodes_IsChanged=false;
      /// <summary>
      /// 产品编号列表
      /// </summary>
      [MetaData("Plan_ProdCodes","产品编号列表")]
      public string Plan_ProdCodes
      {
         get{ return plan_ProdCodes; }
         set{ plan_ProdCodes = value; plan_ProdCodes_IsChanged=true; }
      }
      /// <summary>
      /// 产品编号列表
      /// </summary>
      public bool Plan_ProdCodes_IsChanged
      {
         get{ return plan_ProdCodes_IsChanged; }
         set{ plan_ProdCodes_IsChanged = value; }
      }
      /// <summary>
      /// 工程名称
      /// </summary>
      private string plan_Project;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Project_IsChanged=false;
      /// <summary>
      /// 工程名称
      /// </summary>
      [MetaData("Plan_Project","工程名称")]
      public string Plan_Project
      {
         get{ return plan_Project; }
         set{ plan_Project = value; plan_Project_IsChanged=true; }
      }
      /// <summary>
      /// 工程名称
      /// </summary>
      public bool Plan_Project_IsChanged
      {
         get{ return plan_Project_IsChanged; }
         set{ plan_Project_IsChanged = value; }
      }
      /// <summary>
      /// 下达人
      /// </summary>
      private string plan_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Owner_IsChanged=false;
      /// <summary>
      /// 下达人
      /// </summary>
      [MetaData("Plan_Owner","下达人")]
      public string Plan_Owner
      {
         get{ return plan_Owner; }
         set{ plan_Owner = value; plan_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 下达人
      /// </summary>
      public bool Plan_Owner_IsChanged
      {
         get{ return plan_Owner_IsChanged; }
         set{ plan_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 下达时间
      /// </summary>
      private DateTime plan_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Date_IsChanged=false;
      /// <summary>
      /// 下达时间
      /// </summary>
      [MetaData("Plan_Date","下达时间")]
      public DateTime Plan_Date
      {
         get{ return plan_Date; }
         set{ plan_Date = value; plan_Date_IsChanged=true; }
      }
      /// <summary>
      /// 下达时间
      /// </summary>
      public bool Plan_Date_IsChanged
      {
         get{ return plan_Date_IsChanged; }
         set{ plan_Date_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string plan_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      [MetaData("Plan_Bak","备注")]
      public string Plan_Bak
      {
         get{ return plan_Bak; }
         set{ plan_Bak = value; plan_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Plan_Bak_IsChanged
      {
         get{ return plan_Bak_IsChanged; }
         set{ plan_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 下达状态
      /// </summary>
      private int plan_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool plan_Stat_IsChanged=false;
      /// <summary>
      /// 下达状态
      /// </summary>
      [MetaData("Plan_Stat","下达状态")]
      public int Plan_Stat
      {
         get{ return plan_Stat; }
         set{ plan_Stat = value; plan_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 下达状态
      /// </summary>
      public bool Plan_Stat_IsChanged
      {
         get{ return plan_Stat_IsChanged; }
         set{ plan_Stat_IsChanged = value; }
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
      [MetaData("Stat","状态")]
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
