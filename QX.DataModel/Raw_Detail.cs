using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Raw_Detail
   {
      /// <summary>
      /// 明细序号
      /// </summary>
      private decimal rDetail_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_ID_IsChanged=false;
      /// <summary>
      /// 明细序号
      /// </summary>
      public decimal RDetail_ID
      {
         get{ return rDetail_ID; }
         set{ rDetail_ID = value; rDetail_ID_IsChanged=true; }
      }
      /// <summary>
      /// 明细序号
      /// </summary>
      public bool RDetail_ID_IsChanged
      {
         get{ return rDetail_ID_IsChanged; }
         set{ rDetail_ID_IsChanged = value; }
      }
      /// <summary>
      /// 毛坯申请编号
      /// </summary>
      private string rawMain_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rawMain_Code_IsChanged=false;
      /// <summary>
      /// 毛坯申请编号
      /// </summary>
      public string RawMain_Code
      {
         get{ return rawMain_Code; }
         set{ rawMain_Code = value; rawMain_Code_IsChanged=true; }
      }
      /// <summary>
      /// 毛坯申请编号
      /// </summary>
      public bool RawMain_Code_IsChanged
      {
         get{ return rawMain_Code_IsChanged; }
         set{ rawMain_Code_IsChanged = value; }
      }
      /// <summary>
      /// 采购编号
      /// </summary>
      private string rDetail_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Code_IsChanged=false;
      /// <summary>
      /// 采购编号
      /// </summary>
      public string RDetail_Code
      {
         get{ return rDetail_Code; }
         set{ rDetail_Code = value; rDetail_Code_IsChanged=true; }
      }
      /// <summary>
      /// 采购编号
      /// </summary>
      public bool RDetail_Code_IsChanged
      {
         get{ return rDetail_Code_IsChanged; }
         set{ rDetail_Code_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string rDetail_PartNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_PartNo_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string RDetail_PartNo
      {
         get{ return rDetail_PartNo; }
         set{ rDetail_PartNo = value; rDetail_PartNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool RDetail_PartNo_IsChanged
      {
         get{ return rDetail_PartNo_IsChanged; }
         set{ rDetail_PartNo_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string rDetail_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Name_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string RDetail_Name
      {
         get{ return rDetail_Name; }
         set{ rDetail_Name = value; rDetail_Name_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool RDetail_Name_IsChanged
      {
         get{ return rDetail_Name_IsChanged; }
         set{ rDetail_Name_IsChanged = value; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      private string rDetail_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Spec_IsChanged=false;
      /// <summary>
      /// 规格型号
      /// </summary>
      public string RDetail_Spec
      {
         get{ return rDetail_Spec; }
         set{ rDetail_Spec = value; rDetail_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 规格型号
      /// </summary>
      public bool RDetail_Spec_IsChanged
      {
         get{ return rDetail_Spec_IsChanged; }
         set{ rDetail_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string rDetail_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string RDetail_Unit
      {
         get{ return rDetail_Unit; }
         set{ rDetail_Unit = value; rDetail_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool RDetail_Unit_IsChanged
      {
         get{ return rDetail_Unit_IsChanged; }
         set{ rDetail_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int rDetail_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int RDetail_Num
      {
         get{ return rDetail_Num; }
         set{ rDetail_Num = value; rDetail_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool RDetail_Num_IsChanged
      {
         get{ return rDetail_Num_IsChanged; }
         set{ rDetail_Num_IsChanged = value; }
      }
      /// <summary>
      /// 要求到货时间
      /// </summary>
      private DateTime rDetail_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Date_IsChanged=false;
      /// <summary>
      /// 要求到货时间
      /// </summary>
      public DateTime RDetail_Date
      {
         get{ return rDetail_Date; }
         set{ rDetail_Date = value; rDetail_Date_IsChanged=true; }
      }
      /// <summary>
      /// 要求到货时间
      /// </summary>
      public bool RDetail_Date_IsChanged
      {
         get{ return rDetail_Date_IsChanged; }
         set{ rDetail_Date_IsChanged = value; }
      }
      /// <summary>
      /// 生产指令号
      /// </summary>
      private string rDetail_Command;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Command_IsChanged=false;
      /// <summary>
      /// 生产指令号
      /// </summary>
      public string RDetail_Command
      {
         get{ return rDetail_Command; }
         set{ rDetail_Command = value; rDetail_Command_IsChanged=true; }
      }
      /// <summary>
      /// 生产指令号
      /// </summary>
      public bool RDetail_Command_IsChanged
      {
         get{ return rDetail_Command_IsChanged; }
         set{ rDetail_Command_IsChanged = value; }
      }
      private string rDetail_DCommand;
      private bool rDetail_DCommand_IsChanged=false;
      public string RDetail_DCommand
      {
         get{ return rDetail_DCommand; }
         set{ rDetail_DCommand = value; rDetail_DCommand_IsChanged=true; }
      }
      public bool RDetail_DCommand_IsChanged
      {
         get{ return rDetail_DCommand_IsChanged; }
         set{ rDetail_DCommand_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string rDetail_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string RDetail_Bak
      {
         get{ return rDetail_Bak; }
         set{ rDetail_Bak = value; rDetail_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool RDetail_Bak_IsChanged
      {
         get{ return rDetail_Bak_IsChanged; }
         set{ rDetail_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 已到货数量
      /// </summary>
      private int rDetail_ReadyNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_ReadyNum_IsChanged=false;
      /// <summary>
      /// 已到货数量
      /// </summary>
      public int RDetail_ReadyNum
      {
         get{ return rDetail_ReadyNum; }
         set{ rDetail_ReadyNum = value; rDetail_ReadyNum_IsChanged=true; }
      }
      /// <summary>
      /// 已到货数量
      /// </summary>
      public bool RDetail_ReadyNum_IsChanged
      {
         get{ return rDetail_ReadyNum_IsChanged; }
         set{ rDetail_ReadyNum_IsChanged = value; }
      }
      /// <summary>
      /// 已下发数量
      /// </summary>
      private int rDetail_DisNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool rDetail_DisNum_IsChanged=false;
      /// <summary>
      /// 已下发数量
      /// </summary>
      public int RDetail_DisNum
      {
         get{ return rDetail_DisNum; }
         set{ rDetail_DisNum = value; rDetail_DisNum_IsChanged=true; }
      }
      /// <summary>
      /// 已下发数量
      /// </summary>
      public bool RDetail_DisNum_IsChanged
      {
         get{ return rDetail_DisNum_IsChanged; }
         set{ rDetail_DisNum_IsChanged = value; }
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
      private string rDetail_Nodes;
      private bool rDetail_Nodes_IsChanged=false;
      public string RDetail_Nodes
      {
         get{ return rDetail_Nodes; }
         set{ rDetail_Nodes = value; rDetail_Nodes_IsChanged=true; }
      }
      public bool RDetail_Nodes_IsChanged
      {
         get{ return rDetail_Nodes_IsChanged; }
         set{ rDetail_Nodes_IsChanged = value; }
      }
      private string rDetail_Customer;
      private bool rDetail_Customer_IsChanged=false;
      public string RDetail_Customer
      {
         get{ return rDetail_Customer; }
         set{ rDetail_Customer = value; rDetail_Customer_IsChanged=true; }
      }
      public bool RDetail_Customer_IsChanged
      {
         get{ return rDetail_Customer_IsChanged; }
         set{ rDetail_Customer_IsChanged = value; }
      }
      private string rDetail_CustomerName;
      private bool rDetail_CustomerName_IsChanged=false;
      public string RDetail_CustomerName
      {
         get{ return rDetail_CustomerName; }
         set{ rDetail_CustomerName = value; rDetail_CustomerName_IsChanged=true; }
      }
      public bool RDetail_CustomerName_IsChanged
      {
         get{ return rDetail_CustomerName_IsChanged; }
         set{ rDetail_CustomerName_IsChanged = value; }
      }
      private DateTime rDetail_RDate;
      private bool rDetail_RDate_IsChanged=false;
      public DateTime RDetail_RDate
      {
         get{ return rDetail_RDate; }
         set{ rDetail_RDate = value; rDetail_RDate_IsChanged=true; }
      }
      public bool RDetail_RDate_IsChanged
      {
         get{ return rDetail_RDate_IsChanged; }
         set{ rDetail_RDate_IsChanged = value; }
      }
      private string rDetail_Project;
      private bool rDetail_Project_IsChanged=false;
      public string RDetail_Project
      {
         get{ return rDetail_Project; }
         set{ rDetail_Project = value; rDetail_Project_IsChanged=true; }
      }
      public bool RDetail_Project_IsChanged
      {
         get{ return rDetail_Project_IsChanged; }
         set{ rDetail_Project_IsChanged = value; }
      }
      private DateTime rDetail_OCmd;
      private bool rDetail_OCmd_IsChanged=false;
      public DateTime RDetail_OCmd
      {
         get{ return rDetail_OCmd; }
         set{ rDetail_OCmd = value; rDetail_OCmd_IsChanged=true; }
      }
      public bool RDetail_OCmd_IsChanged
      {
         get{ return rDetail_OCmd_IsChanged; }
         set{ rDetail_OCmd_IsChanged = value; }
      }
      private string rDetail_Udef1;
      private bool rDetail_Udef1_IsChanged=false;
      public string RDetail_Udef1
      {
         get{ return rDetail_Udef1; }
         set{ rDetail_Udef1 = value; rDetail_Udef1_IsChanged=true; }
      }
      public bool RDetail_Udef1_IsChanged
      {
         get{ return rDetail_Udef1_IsChanged; }
         set{ rDetail_Udef1_IsChanged = value; }
      }
      private string rDetail_Udef2;
      private bool rDetail_Udef2_IsChanged=false;
      public string RDetail_Udef2
      {
         get{ return rDetail_Udef2; }
         set{ rDetail_Udef2 = value; rDetail_Udef2_IsChanged=true; }
      }
      public bool RDetail_Udef2_IsChanged
      {
         get{ return rDetail_Udef2_IsChanged; }
         set{ rDetail_Udef2_IsChanged = value; }
      }
      private DateTime rDetail_OwnDate;
      private bool rDetail_OwnDate_IsChanged=false;
      public DateTime RDetail_OwnDate
      {
         get{ return rDetail_OwnDate; }
         set{ rDetail_OwnDate = value; rDetail_OwnDate_IsChanged=true; }
      }
      public bool RDetail_OwnDate_IsChanged
      {
         get{ return rDetail_OwnDate_IsChanged; }
         set{ rDetail_OwnDate_IsChanged = value; }
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
      private string rDetail_Udef3;
      private bool rDetail_Udef3_IsChanged=false;
      public string RDetail_Udef3
      {
         get{ return rDetail_Udef3; }
         set{ rDetail_Udef3 = value; rDetail_Udef3_IsChanged=true; }
      }
      public bool RDetail_Udef3_IsChanged
      {
         get{ return rDetail_Udef3_IsChanged; }
         set{ rDetail_Udef3_IsChanged = value; }
      }
      private string rDetail_Udef4;
      private bool rDetail_Udef4_IsChanged=false;
      public string RDetail_Udef4
      {
         get{ return rDetail_Udef4; }
         set{ rDetail_Udef4 = value; rDetail_Udef4_IsChanged=true; }
      }
      public bool RDetail_Udef4_IsChanged
      {
         get{ return rDetail_Udef4_IsChanged; }
         set{ rDetail_Udef4_IsChanged = value; }
      }
   }
}
