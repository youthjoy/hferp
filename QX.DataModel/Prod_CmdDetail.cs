using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 生产指令细表
   /// </summary>
   [Serializable]
   public partial class Prod_CmdDetail
   {
      /// <summary>
      /// 生产指令细目序号
      /// </summary>
      private Int64 cmdDetail_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_ID_IsChanged=false;
      /// <summary>
      /// 生产指令细目序号
      /// </summary>
      public Int64 CmdDetail_ID
      {
         get{ return cmdDetail_ID; }
         set{ cmdDetail_ID = value; cmdDetail_ID_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令细目序号
      /// </summary>
      public bool CmdDetail_ID_IsChanged
      {
         get{ return cmdDetail_ID_IsChanged; }
         set{ cmdDetail_ID_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令编码
      /// </summary>
      private string cmd_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmd_Code_IsChanged=false;
      /// <summary>
      /// 生产指令编码
      /// </summary>
      public string Cmd_Code
      {
         get{ return cmd_Code; }
         set{ cmd_Code = value; cmd_Code_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令编码
      /// </summary>
      public bool Cmd_Code_IsChanged
      {
         get{ return cmd_Code_IsChanged; }
         set{ cmd_Code_IsChanged = value; }
      }
      /// <summary>
      /// 施工号
      /// </summary>
      private string cmdDetail_Project;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_Project_IsChanged=false;
      /// <summary>
      /// 施工号
      /// </summary>
      public string CmdDetail_Project
      {
         get{ return cmdDetail_Project; }
         set{ cmdDetail_Project = value; cmdDetail_Project_IsChanged=true; }
      }
      /// <summary>
      /// 施工号
      /// </summary>
      public bool CmdDetail_Project_IsChanged
      {
         get{ return cmdDetail_Project_IsChanged; }
         set{ cmdDetail_Project_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string cmdDetail_PartNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_PartNo_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string CmdDetail_PartNo
      {
         get{ return cmdDetail_PartNo; }
         set{ cmdDetail_PartNo = value; cmdDetail_PartNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool CmdDetail_PartNo_IsChanged
      {
         get{ return cmdDetail_PartNo_IsChanged; }
         set{ cmdDetail_PartNo_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string cmdDetail_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string CmdDetail_PartName
      {
         get{ return cmdDetail_PartName; }
         set{ cmdDetail_PartName = value; cmdDetail_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool CmdDetail_PartName_IsChanged
      {
         get{ return cmdDetail_PartName_IsChanged; }
         set{ cmdDetail_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string cmdDetail_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string CmdDetail_Unit
      {
         get{ return cmdDetail_Unit; }
         set{ cmdDetail_Unit = value; cmdDetail_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool CmdDetail_Unit_IsChanged
      {
         get{ return cmdDetail_Unit_IsChanged; }
         set{ cmdDetail_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int cmdDetail_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int CmdDetail_Num
      {
         get{ return cmdDetail_Num; }
         set{ cmdDetail_Num = value; cmdDetail_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool CmdDetail_Num_IsChanged
      {
         get{ return cmdDetail_Num_IsChanged; }
         set{ cmdDetail_Num_IsChanged = value; }
      }
      /// <summary>
      /// 加工工序
      /// </summary>
      private string cmdDetail_Roads;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_Roads_IsChanged=false;
      /// <summary>
      /// 加工工序
      /// </summary>
      public string CmdDetail_Roads
      {
         get{ return cmdDetail_Roads; }
         set{ cmdDetail_Roads = value; cmdDetail_Roads_IsChanged=true; }
      }
      /// <summary>
      /// 加工工序
      /// </summary>
      public bool CmdDetail_Roads_IsChanged
      {
         get{ return cmdDetail_Roads_IsChanged; }
         set{ cmdDetail_Roads_IsChanged = value; }
      }
      /// <summary>
      /// 主管采购员
      /// </summary>
      private string cmdDetail_Pur;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_Pur_IsChanged=false;
      /// <summary>
      /// 主管采购员
      /// </summary>
      public string CmdDetail_Pur
      {
         get{ return cmdDetail_Pur; }
         set{ cmdDetail_Pur = value; cmdDetail_Pur_IsChanged=true; }
      }
      /// <summary>
      /// 主管采购员
      /// </summary>
      public bool CmdDetail_Pur_IsChanged
      {
         get{ return cmdDetail_Pur_IsChanged; }
         set{ cmdDetail_Pur_IsChanged = value; }
      }
      /// <summary>
      /// 计划完工时间
      /// </summary>
      private DateTime cmdDetail_PlanDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_PlanDate_IsChanged=false;
      /// <summary>
      /// 计划完工时间
      /// </summary>
      public DateTime CmdDetail_PlanDate
      {
         get{ return cmdDetail_PlanDate; }
         set{ cmdDetail_PlanDate = value; cmdDetail_PlanDate_IsChanged=true; }
      }
      /// <summary>
      /// 计划完工时间
      /// </summary>
      public bool CmdDetail_PlanDate_IsChanged
      {
         get{ return cmdDetail_PlanDate_IsChanged; }
         set{ cmdDetail_PlanDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cmdDetail_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CmdDetail_Bak
      {
         get{ return cmdDetail_Bak; }
         set{ cmdDetail_Bak = value; cmdDetail_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CmdDetail_Bak_IsChanged
      {
         get{ return cmdDetail_Bak_IsChanged; }
         set{ cmdDetail_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 已下发数量
      /// </summary>
      private int cmdDetail_DNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_DNum_IsChanged=false;
      /// <summary>
      /// 已下发数量
      /// </summary>
      public int CmdDetail_DNum
      {
         get{ return cmdDetail_DNum; }
         set{ cmdDetail_DNum = value; cmdDetail_DNum_IsChanged=true; }
      }
      /// <summary>
      /// 已下发数量
      /// </summary>
      public bool CmdDetail_DNum_IsChanged
      {
         get{ return cmdDetail_DNum_IsChanged; }
         set{ cmdDetail_DNum_IsChanged = value; }
      }
      /// <summary>
      /// 已完工数量
      /// </summary>
      private int cmdDetail_FNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cmdDetail_FNum_IsChanged=false;
      /// <summary>
      /// 已完工数量
      /// </summary>
      public int CmdDetail_FNum
      {
         get{ return cmdDetail_FNum; }
         set{ cmdDetail_FNum = value; cmdDetail_FNum_IsChanged=true; }
      }
      /// <summary>
      /// 已完工数量
      /// </summary>
      public bool CmdDetail_FNum_IsChanged
      {
         get{ return cmdDetail_FNum_IsChanged; }
         set{ cmdDetail_FNum_IsChanged = value; }
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
      private string cmdDetail_PCode;
      private bool cmdDetail_PCode_IsChanged=false;
      public string CmdDetail_PCode
      {
         get{ return cmdDetail_PCode; }
         set{ cmdDetail_PCode = value; cmdDetail_PCode_IsChanged=true; }
      }
      public bool CmdDetail_PCode_IsChanged
      {
         get{ return cmdDetail_PCode_IsChanged; }
         set{ cmdDetail_PCode_IsChanged = value; }
      }
      private DateTime createTime;
      private bool createTime_IsChanged=false;
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
   }
}
