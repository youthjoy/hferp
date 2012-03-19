using System;
using System.Data;


namespace QX.DataModel
{
   /// <summary>
   /// 生产任务细表
   /// </summary>
   [Serializable]
   public partial class Prod_TaskDetail
   {
      private Int64 taskDetail_ID;
      private bool taskDetail_ID_IsChanged=false;
      [MetaData("TaskDetail_ID","")]
      public Int64 TaskDetail_ID
      {
         get{ return taskDetail_ID; }
         set{ taskDetail_ID = value; taskDetail_ID_IsChanged=true; }
      }
      public bool TaskDetail_ID_IsChanged
      {
         get{ return taskDetail_ID_IsChanged; }
         set{ taskDetail_ID_IsChanged = value; }
      }
      private string taskDetail_Code;
      private bool taskDetail_Code_IsChanged=false;
      [MetaData("TaskDetail_Code","")]
      public string TaskDetail_Code
      {
         get{ return taskDetail_Code; }
         set{ taskDetail_Code = value; taskDetail_Code_IsChanged=true; }
      }
      public bool TaskDetail_Code_IsChanged
      {
         get{ return taskDetail_Code_IsChanged; }
         set{ taskDetail_Code_IsChanged = value; }
      }
      private string taskDetail_CmdCode;
      private bool taskDetail_CmdCode_IsChanged=false;
      [MetaData("TaskDetail_CmdCode","")]
      public string TaskDetail_CmdCode
      {
         get{ return taskDetail_CmdCode; }
         set{ taskDetail_CmdCode = value; taskDetail_CmdCode_IsChanged=true; }
      }
      public bool TaskDetail_CmdCode_IsChanged
      {
         get{ return taskDetail_CmdCode_IsChanged; }
         set{ taskDetail_CmdCode_IsChanged = value; }
      }
      private string taskDetail_PartNo;
      private bool taskDetail_PartNo_IsChanged=false;
      [MetaData("TaskDetail_PartNo","")]
      public string TaskDetail_PartNo
      {
         get{ return taskDetail_PartNo; }
         set{ taskDetail_PartNo = value; taskDetail_PartNo_IsChanged=true; }
      }
      public bool TaskDetail_PartNo_IsChanged
      {
         get{ return taskDetail_PartNo_IsChanged; }
         set{ taskDetail_PartNo_IsChanged = value; }
      }
      private string taskDetail_PartName;
      private bool taskDetail_PartName_IsChanged=false;
      [MetaData("TaskDetail_PartName","")]
      public string TaskDetail_PartName
      {
         get{ return taskDetail_PartName; }
         set{ taskDetail_PartName = value; taskDetail_PartName_IsChanged=true; }
      }
      public bool TaskDetail_PartName_IsChanged
      {
         get{ return taskDetail_PartName_IsChanged; }
         set{ taskDetail_PartName_IsChanged = value; }
      }
      private string taskDetail_Unit;
      private bool taskDetail_Unit_IsChanged=false;
      [MetaData("TaskDetail_Unit","")]
      public string TaskDetail_Unit
      {
         get{ return taskDetail_Unit; }
         set{ taskDetail_Unit = value; taskDetail_Unit_IsChanged=true; }
      }
      public bool TaskDetail_Unit_IsChanged
      {
         get{ return taskDetail_Unit_IsChanged; }
         set{ taskDetail_Unit_IsChanged = value; }
      }
      private int taskDetail_Num;
      private bool taskDetail_Num_IsChanged=false;
      [MetaData("TaskDetail_Num","")]
      public int TaskDetail_Num
      {
         get{ return taskDetail_Num; }
         set{ taskDetail_Num = value; taskDetail_Num_IsChanged=true; }
      }
      public bool TaskDetail_Num_IsChanged
      {
         get{ return taskDetail_Num_IsChanged; }
         set{ taskDetail_Num_IsChanged = value; }
      }
      private string taskDetail_ProdType;
      private bool taskDetail_ProdType_IsChanged=false;
      [MetaData("TaskDetail_ProdType","")]
      public string TaskDetail_ProdType
      {
         get{ return taskDetail_ProdType; }
         set{ taskDetail_ProdType = value; taskDetail_ProdType_IsChanged=true; }
      }
      public bool TaskDetail_ProdType_IsChanged
      {
         get{ return taskDetail_ProdType_IsChanged; }
         set{ taskDetail_ProdType_IsChanged = value; }
      }
      private DateTime taskDetail_PlanBegin;
      private bool taskDetail_PlanBegin_IsChanged=false;
      [MetaData("TaskDetail_PlanBegin","")]
      public DateTime TaskDetail_PlanBegin
      {
         get{ return taskDetail_PlanBegin; }
         set{ taskDetail_PlanBegin = value; taskDetail_PlanBegin_IsChanged=true; }
      }
      public bool TaskDetail_PlanBegin_IsChanged
      {
         get{ return taskDetail_PlanBegin_IsChanged; }
         set{ taskDetail_PlanBegin_IsChanged = value; }
      }
      private DateTime taskDetail_PlanEnd;
      private bool taskDetail_PlanEnd_IsChanged=false;
      [MetaData("TaskDetail_PlanEnd","")]
      public DateTime TaskDetail_PlanEnd
      {
         get{ return taskDetail_PlanEnd; }
         set{ taskDetail_PlanEnd = value; taskDetail_PlanEnd_IsChanged=true; }
      }
      public bool TaskDetail_PlanEnd_IsChanged
      {
         get{ return taskDetail_PlanEnd_IsChanged; }
         set{ taskDetail_PlanEnd_IsChanged = value; }
      }
      private DateTime taskDetail_ActEnd;
      private bool taskDetail_ActEnd_IsChanged=false;
      [MetaData("TaskDetail_ActEnd","")]
      public DateTime TaskDetail_ActEnd
      {
         get{ return taskDetail_ActEnd; }
         set{ taskDetail_ActEnd = value; taskDetail_ActEnd_IsChanged=true; }
      }
      public bool TaskDetail_ActEnd_IsChanged
      {
         get{ return taskDetail_ActEnd_IsChanged; }
         set{ taskDetail_ActEnd_IsChanged = value; }
      }
      private int task_FNum;
      private bool task_FNum_IsChanged=false;
      [MetaData("Task_FNum","")]
      public int Task_FNum
      {
         get{ return task_FNum; }
         set{ task_FNum = value; task_FNum_IsChanged=true; }
      }
      public bool Task_FNum_IsChanged
      {
         get{ return task_FNum_IsChanged; }
         set{ task_FNum_IsChanged = value; }
      }
      private string task_Roads;
      private bool task_Roads_IsChanged=false;
      [MetaData("Task_Roads","")]
      public string Task_Roads
      {
         get{ return task_Roads; }
         set{ task_Roads = value; task_Roads_IsChanged=true; }
      }
      public bool Task_Roads_IsChanged
      {
         get{ return task_Roads_IsChanged; }
         set{ task_Roads_IsChanged = value; }
      }
      private string task_ProdCode;
      private bool task_ProdCode_IsChanged=false;
      [MetaData("Task_ProdCode","")]
      public string Task_ProdCode
      {
         get{ return task_ProdCode; }
         set{ task_ProdCode = value; task_ProdCode_IsChanged=true; }
      }
      public bool Task_ProdCode_IsChanged
      {
         get{ return task_ProdCode_IsChanged; }
         set{ task_ProdCode_IsChanged = value; }
      }
      /// <summary>
      /// 生产任务状态
      /// </summary>
      private int task_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool task_Stat_IsChanged=false;
      /// <summary>
      /// 生产任务状态
      /// </summary>
      [MetaData("Task_Stat","生产任务状态")]
      public int Task_Stat
      {
         get{ return task_Stat; }
         set{ task_Stat = value; task_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 生产任务状态
      /// </summary>
      public bool Task_Stat_IsChanged
      {
         get{ return task_Stat_IsChanged; }
         set{ task_Stat_IsChanged = value; }
      }
      private int task_DNum;
      private bool task_DNum_IsChanged=false;
      [MetaData("Task_DNum","")]
      public int Task_DNum
      {
         get{ return task_DNum; }
         set{ task_DNum = value; task_DNum_IsChanged=true; }
      }
      public bool Task_DNum_IsChanged
      {
         get{ return task_DNum_IsChanged; }
         set{ task_DNum_IsChanged = value; }
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
