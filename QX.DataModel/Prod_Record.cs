using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Prod_Record
   {
      /// <summary>
      /// 生产记录序号
      /// </summary>
      private int pRD_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_ID_IsChanged=false;
      /// <summary>
      /// 生产记录序号
      /// </summary>
      public int PRD_ID
      {
         get{ return pRD_ID; }
         set{ pRD_ID = value; pRD_ID_IsChanged=true; }
      }
      /// <summary>
      /// 生产记录序号
      /// </summary>
      public bool PRD_ID_IsChanged
      {
         get{ return pRD_ID_IsChanged; }
         set{ pRD_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产记录编码
      /// </summary>
      private string pRD_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Code_IsChanged=false;
      /// <summary>
      /// 生产记录编码
      /// </summary>
      public string PRD_Code
      {
         get{ return pRD_Code; }
         set{ pRD_Code = value; pRD_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产记录编码
      /// </summary>
      public bool PRD_Code_IsChanged
      {
         get{ return pRD_Code_IsChanged; }
         set{ pRD_Code_IsChanged = value; }
      }
      /// <summary>
      /// 工序编码
      /// </summary>
      private string pRD_NodeCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_NodeCode_IsChanged=false;
      /// <summary>
      /// 工序编码
      /// </summary>
      public string PRD_NodeCode
      {
         get{ return pRD_NodeCode; }
         set{ pRD_NodeCode = value; pRD_NodeCode_IsChanged=true; }
      }
      /// <summary>
      /// 工序编码
      /// </summary>
      public bool PRD_NodeCode_IsChanged
      {
         get{ return pRD_NodeCode_IsChanged; }
         set{ pRD_NodeCode_IsChanged = value; }
      }
      /// <summary>
      /// 工序名称
      /// </summary>
      private string pRD_NodeName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_NodeName_IsChanged=false;
      /// <summary>
      /// 工序名称
      /// </summary>
      public string PRD_NodeName
      {
         get{ return pRD_NodeName; }
         set{ pRD_NodeName = value; pRD_NodeName_IsChanged=true; }
      }
      /// <summary>
      /// 工序名称
      /// </summary>
      public bool PRD_NodeName_IsChanged
      {
         get{ return pRD_NodeName_IsChanged; }
         set{ pRD_NodeName_IsChanged = value; }
      }
      /// <summary>
      /// 完工数量
      /// </summary>
      private int pRD_FNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_FNum_IsChanged=false;
      /// <summary>
      /// 完工数量
      /// </summary>
      public int PRD_FNum
      {
         get{ return pRD_FNum; }
         set{ pRD_FNum = value; pRD_FNum_IsChanged=true; }
      }
      /// <summary>
      /// 完工数量
      /// </summary>
      public bool PRD_FNum_IsChanged
      {
         get{ return pRD_FNum_IsChanged; }
         set{ pRD_FNum_IsChanged = value; }
      }
      /// <summary>
      /// 设备编码
      /// </summary>
      private string pRD_EquCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_EquCode_IsChanged=false;
      /// <summary>
      /// 设备编码
      /// </summary>
      public string PRD_EquCode
      {
         get{ return pRD_EquCode; }
         set{ pRD_EquCode = value; pRD_EquCode_IsChanged=true; }
      }
      /// <summary>
      /// 设备编码
      /// </summary>
      public bool PRD_EquCode_IsChanged
      {
         get{ return pRD_EquCode_IsChanged; }
         set{ pRD_EquCode_IsChanged = value; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      private string pRD_EquName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_EquName_IsChanged=false;
      /// <summary>
      /// 设备名称
      /// </summary>
      public string PRD_EquName
      {
         get{ return pRD_EquName; }
         set{ pRD_EquName = value; pRD_EquName_IsChanged=true; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      public bool PRD_EquName_IsChanged
      {
         get{ return pRD_EquName_IsChanged; }
         set{ pRD_EquName_IsChanged = value; }
      }
      /// <summary>
      /// 操作人员
      /// </summary>
      private string pRD_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Operator_IsChanged=false;
      /// <summary>
      /// 操作人员
      /// </summary>
      public string PRD_Operator
      {
         get{ return pRD_Operator; }
         set{ pRD_Operator = value; pRD_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人员
      /// </summary>
      public bool PRD_Operator_IsChanged
      {
         get{ return pRD_Operator_IsChanged; }
         set{ pRD_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 开工时间
      /// </summary>
      private DateTime pRD_Begin;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Begin_IsChanged=false;
      /// <summary>
      /// 开工时间
      /// </summary>
      public DateTime PRD_Begin
      {
         get{ return pRD_Begin; }
         set{ pRD_Begin = value; pRD_Begin_IsChanged=true; }
      }
      /// <summary>
      /// 开工时间
      /// </summary>
      public bool PRD_Begin_IsChanged
      {
         get{ return pRD_Begin_IsChanged; }
         set{ pRD_Begin_IsChanged = value; }
      }
      /// <summary>
      /// 完工时间
      /// </summary>
      private DateTime pRD_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_End_IsChanged=false;
      /// <summary>
      /// 完工时间
      /// </summary>
      public DateTime PRD_End
      {
         get{ return pRD_End; }
         set{ pRD_End = value; pRD_End_IsChanged=true; }
      }
      /// <summary>
      /// 完工时间
      /// </summary>
      public bool PRD_End_IsChanged
      {
         get{ return pRD_End_IsChanged; }
         set{ pRD_End_IsChanged = value; }
      }
      /// <summary>
      /// 工时
      /// </summary>
      private int pRD_TimeCost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_TimeCost_IsChanged=false;
      /// <summary>
      /// 工时
      /// </summary>
      public int PRD_TimeCost
      {
         get{ return pRD_TimeCost; }
         set{ pRD_TimeCost = value; pRD_TimeCost_IsChanged=true; }
      }
      /// <summary>
      /// 工时
      /// </summary>
      public bool PRD_TimeCost_IsChanged
      {
         get{ return pRD_TimeCost_IsChanged; }
         set{ pRD_TimeCost_IsChanged = value; }
      }
      /// <summary>
      /// 生产部门
      /// </summary>
      private string pRD_ProDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_ProDept_IsChanged=false;
      /// <summary>
      /// 生产部门
      /// </summary>
      public string PRD_ProDept
      {
         get{ return pRD_ProDept; }
         set{ pRD_ProDept = value; pRD_ProDept_IsChanged=true; }
      }
      /// <summary>
      /// 生产部门
      /// </summary>
      public bool PRD_ProDept_IsChanged
      {
         get{ return pRD_ProDept_IsChanged; }
         set{ pRD_ProDept_IsChanged = value; }
      }
      /// <summary>
      /// 计划开工
      /// </summary>
      private DateTime pRD_PlanBegin;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_PlanBegin_IsChanged=false;
      /// <summary>
      /// 计划开工
      /// </summary>
      public DateTime PRD_PlanBegin
      {
         get{ return pRD_PlanBegin; }
         set{ pRD_PlanBegin = value; pRD_PlanBegin_IsChanged=true; }
      }
      /// <summary>
      /// 计划开工
      /// </summary>
      public bool PRD_PlanBegin_IsChanged
      {
         get{ return pRD_PlanBegin_IsChanged; }
         set{ pRD_PlanBegin_IsChanged = value; }
      }
      /// <summary>
      /// 计划完工
      /// </summary>
      private DateTime pRD_PlanEnd;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_PlanEnd_IsChanged=false;
      /// <summary>
      /// 计划完工
      /// </summary>
      public DateTime PRD_PlanEnd
      {
         get{ return pRD_PlanEnd; }
         set{ pRD_PlanEnd = value; pRD_PlanEnd_IsChanged=true; }
      }
      /// <summary>
      /// 计划完工
      /// </summary>
      public bool PRD_PlanEnd_IsChanged
      {
         get{ return pRD_PlanEnd_IsChanged; }
         set{ pRD_PlanEnd_IsChanged = value; }
      }
      /// <summary>
      /// 专业
      /// </summary>
      private string pRD_Specialty;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Specialty_IsChanged=false;
      /// <summary>
      /// 专业
      /// </summary>
      public string PRD_Specialty
      {
         get{ return pRD_Specialty; }
         set{ pRD_Specialty = value; pRD_Specialty_IsChanged=true; }
      }
      /// <summary>
      /// 专业
      /// </summary>
      public bool PRD_Specialty_IsChanged
      {
         get{ return pRD_Specialty_IsChanged; }
         set{ pRD_Specialty_IsChanged = value; }
      }
      /// <summary>
      /// 生产数量
      /// </summary>
      private int pRD_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Num_IsChanged=false;
      /// <summary>
      /// 生产数量
      /// </summary>
      public int PRD_Num
      {
         get{ return pRD_Num; }
         set{ pRD_Num = value; pRD_Num_IsChanged=true; }
      }
      /// <summary>
      /// 生产数量
      /// </summary>
      public bool PRD_Num_IsChanged
      {
         get{ return pRD_Num_IsChanged; }
         set{ pRD_Num_IsChanged = value; }
      }
      /// <summary>
      /// 确认人
      /// </summary>
      private string pRD_ConfirmMen;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_ConfirmMen_IsChanged=false;
      /// <summary>
      /// 确认人
      /// </summary>
      public string PRD_ConfirmMen
      {
         get{ return pRD_ConfirmMen; }
         set{ pRD_ConfirmMen = value; pRD_ConfirmMen_IsChanged=true; }
      }
      /// <summary>
      /// 确认人
      /// </summary>
      public bool PRD_ConfirmMen_IsChanged
      {
         get{ return pRD_ConfirmMen_IsChanged; }
         set{ pRD_ConfirmMen_IsChanged = value; }
      }
      /// <summary>
      /// 下达人
      /// </summary>
      private string pRD_Deployor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Deployor_IsChanged=false;
      /// <summary>
      /// 下达人
      /// </summary>
      public string PRD_Deployor
      {
         get{ return pRD_Deployor; }
         set{ pRD_Deployor = value; pRD_Deployor_IsChanged=true; }
      }
      /// <summary>
      /// 下达人
      /// </summary>
      public bool PRD_Deployor_IsChanged
      {
         get{ return pRD_Deployor_IsChanged; }
         set{ pRD_Deployor_IsChanged = value; }
      }
      /// <summary>
      /// 下达时间
      /// </summary>
      private DateTime pRD_DeployDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_DeployDate_IsChanged=false;
      /// <summary>
      /// 下达时间
      /// </summary>
      public DateTime PRD_DeployDate
      {
         get{ return pRD_DeployDate; }
         set{ pRD_DeployDate = value; pRD_DeployDate_IsChanged=true; }
      }
      /// <summary>
      /// 下达时间
      /// </summary>
      public bool PRD_DeployDate_IsChanged
      {
         get{ return pRD_DeployDate_IsChanged; }
         set{ pRD_DeployDate_IsChanged = value; }
      }
      /// <summary>
      /// 工序内容
      /// </summary>
      private string pRD_NodeContent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_NodeContent_IsChanged=false;
      /// <summary>
      /// 工序内容
      /// </summary>
      public string PRD_NodeContent
      {
         get{ return pRD_NodeContent; }
         set{ pRD_NodeContent = value; pRD_NodeContent_IsChanged=true; }
      }
      /// <summary>
      /// 工序内容
      /// </summary>
      public bool PRD_NodeContent_IsChanged
      {
         get{ return pRD_NodeContent_IsChanged; }
         set{ pRD_NodeContent_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pRD_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pRD_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PRD_Remark
      {
         get{ return pRD_Remark; }
         set{ pRD_Remark = value; pRD_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PRD_Remark_IsChanged
      {
         get{ return pRD_Remark_IsChanged; }
         set{ pRD_Remark_IsChanged = value; }
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
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createTime_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
   }
}
