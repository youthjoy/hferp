using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Inv_Information
   {
      private Int64 iInfor_ID;
      private bool iInfor_ID_IsChanged=false;
      public Int64 IInfor_ID
      {
         get{ return iInfor_ID; }
         set{ iInfor_ID = value; iInfor_ID_IsChanged=true; }
      }
      public bool IInfor_ID_IsChanged
      {
         get{ return iInfor_ID_IsChanged; }
         set{ iInfor_ID_IsChanged = value; }
      }
      private string iInfor_PartNo;
      private bool iInfor_PartNo_IsChanged=false;
      public string IInfor_PartNo
      {
         get{ return iInfor_PartNo; }
         set{ iInfor_PartNo = value; iInfor_PartNo_IsChanged=true; }
      }
      public bool IInfor_PartNo_IsChanged
      {
         get{ return iInfor_PartNo_IsChanged; }
         set{ iInfor_PartNo_IsChanged = value; }
      }
      private string iInfor_PartName;
      private bool iInfor_PartName_IsChanged=false;
      public string IInfor_PartName
      {
         get{ return iInfor_PartName; }
         set{ iInfor_PartName = value; iInfor_PartName_IsChanged=true; }
      }
      public bool IInfor_PartName_IsChanged
      {
         get{ return iInfor_PartName_IsChanged; }
         set{ iInfor_PartName_IsChanged = value; }
      }
      private string iInfor_TaskCode;
      private bool iInfor_TaskCode_IsChanged=false;
      public string IInfor_TaskCode
      {
         get{ return iInfor_TaskCode; }
         set{ iInfor_TaskCode = value; iInfor_TaskCode_IsChanged=true; }
      }
      public bool IInfor_TaskCode_IsChanged
      {
         get{ return iInfor_TaskCode_IsChanged; }
         set{ iInfor_TaskCode_IsChanged = value; }
      }
      private string iInfor_ProdCode;
      private bool iInfor_ProdCode_IsChanged=false;
      public string IInfor_ProdCode
      {
         get{ return iInfor_ProdCode; }
         set{ iInfor_ProdCode = value; iInfor_ProdCode_IsChanged=true; }
      }
      public bool IInfor_ProdCode_IsChanged
      {
         get{ return iInfor_ProdCode_IsChanged; }
         set{ iInfor_ProdCode_IsChanged = value; }
      }
      private string iInfor_PlanCode;
      private bool iInfor_PlanCode_IsChanged=false;
      public string IInfor_PlanCode
      {
         get{ return iInfor_PlanCode; }
         set{ iInfor_PlanCode = value; iInfor_PlanCode_IsChanged=true; }
      }
      public bool IInfor_PlanCode_IsChanged
      {
         get{ return iInfor_PlanCode_IsChanged; }
         set{ iInfor_PlanCode_IsChanged = value; }
      }
      private string iInfor_CmdCode;
      private bool iInfor_CmdCode_IsChanged=false;
      public string IInfor_CmdCode
      {
         get{ return iInfor_CmdCode; }
         set{ iInfor_CmdCode = value; iInfor_CmdCode_IsChanged=true; }
      }
      public bool IInfor_CmdCode_IsChanged
      {
         get{ return iInfor_CmdCode_IsChanged; }
         set{ iInfor_CmdCode_IsChanged = value; }
      }
      private DateTime iInfor_PlanBegin;
      private bool iInfor_PlanBegin_IsChanged=false;
      public DateTime IInfor_PlanBegin
      {
         get{ return iInfor_PlanBegin; }
         set{ iInfor_PlanBegin = value; iInfor_PlanBegin_IsChanged=true; }
      }
      public bool IInfor_PlanBegin_IsChanged
      {
         get{ return iInfor_PlanBegin_IsChanged; }
         set{ iInfor_PlanBegin_IsChanged = value; }
      }
      private DateTime iInfor_PlanEnd;
      private bool iInfor_PlanEnd_IsChanged=false;
      public DateTime IInfor_PlanEnd
      {
         get{ return iInfor_PlanEnd; }
         set{ iInfor_PlanEnd = value; iInfor_PlanEnd_IsChanged=true; }
      }
      public bool IInfor_PlanEnd_IsChanged
      {
         get{ return iInfor_PlanEnd_IsChanged; }
         set{ iInfor_PlanEnd_IsChanged = value; }
      }
      private DateTime iInfor_InTime;
      private bool iInfor_InTime_IsChanged=false;
      public DateTime IInfor_InTime
      {
         get{ return iInfor_InTime; }
         set{ iInfor_InTime = value; iInfor_InTime_IsChanged=true; }
      }
      public bool IInfor_InTime_IsChanged
      {
         get{ return iInfor_InTime_IsChanged; }
         set{ iInfor_InTime_IsChanged = value; }
      }
      private int iInfor_Num;
      private bool iInfor_Num_IsChanged=false;
      public int IInfor_Num
      {
         get{ return iInfor_Num; }
         set{ iInfor_Num = value; iInfor_Num_IsChanged=true; }
      }
      public bool IInfor_Num_IsChanged
      {
         get{ return iInfor_Num_IsChanged; }
         set{ iInfor_Num_IsChanged = value; }
      }
      private string iInfor_WareHouse;
      private bool iInfor_WareHouse_IsChanged=false;
      public string IInfor_WareHouse
      {
         get{ return iInfor_WareHouse; }
         set{ iInfor_WareHouse = value; iInfor_WareHouse_IsChanged=true; }
      }
      public bool IInfor_WareHouse_IsChanged
      {
         get{ return iInfor_WareHouse_IsChanged; }
         set{ iInfor_WareHouse_IsChanged = value; }
      }
      private string iInfor_InConfirm;
      private bool iInfor_InConfirm_IsChanged=false;
      public string IInfor_InConfirm
      {
         get{ return iInfor_InConfirm; }
         set{ iInfor_InConfirm = value; iInfor_InConfirm_IsChanged=true; }
      }
      public bool IInfor_InConfirm_IsChanged
      {
         get{ return iInfor_InConfirm_IsChanged; }
         set{ iInfor_InConfirm_IsChanged = value; }
      }
      private string iInfor_InPep;
      private bool iInfor_InPep_IsChanged=false;
      public string IInfor_InPep
      {
         get{ return iInfor_InPep; }
         set{ iInfor_InPep = value; iInfor_InPep_IsChanged=true; }
      }
      public bool IInfor_InPep_IsChanged
      {
         get{ return iInfor_InPep_IsChanged; }
         set{ iInfor_InPep_IsChanged = value; }
      }
      private DateTime iInfor_InDate;
      private bool iInfor_InDate_IsChanged=false;
      public DateTime IInfor_InDate
      {
         get{ return iInfor_InDate; }
         set{ iInfor_InDate = value; iInfor_InDate_IsChanged=true; }
      }
      public bool IInfor_InDate_IsChanged
      {
         get{ return iInfor_InDate_IsChanged; }
         set{ iInfor_InDate_IsChanged = value; }
      }
      private string iInfor_Stat;
      private bool iInfor_Stat_IsChanged=false;
      public string IInfor_Stat
      {
         get{ return iInfor_Stat; }
         set{ iInfor_Stat = value; iInfor_Stat_IsChanged=true; }
      }
      public bool IInfor_Stat_IsChanged
      {
         get{ return iInfor_Stat_IsChanged; }
         set{ iInfor_Stat_IsChanged = value; }
      }
      private string iInfor_ProdStat;
      private bool iInfor_ProdStat_IsChanged=false;
      public string IInfor_ProdStat
      {
         get{ return iInfor_ProdStat; }
         set{ iInfor_ProdStat = value; iInfor_ProdStat_IsChanged=true; }
      }
      public bool IInfor_ProdStat_IsChanged
      {
         get{ return iInfor_ProdStat_IsChanged; }
         set{ iInfor_ProdStat_IsChanged = value; }
      }
      private DateTime iInfor_OutDate;
      private bool iInfor_OutDate_IsChanged=false;
      public DateTime IInfor_OutDate
      {
         get{ return iInfor_OutDate; }
         set{ iInfor_OutDate = value; iInfor_OutDate_IsChanged=true; }
      }
      public bool IInfor_OutDate_IsChanged
      {
         get{ return iInfor_OutDate_IsChanged; }
         set{ iInfor_OutDate_IsChanged = value; }
      }
      private string iInfor_OutPep;
      private bool iInfor_OutPep_IsChanged=false;
      public string IInfor_OutPep
      {
         get{ return iInfor_OutPep; }
         set{ iInfor_OutPep = value; iInfor_OutPep_IsChanged=true; }
      }
      public bool IInfor_OutPep_IsChanged
      {
         get{ return iInfor_OutPep_IsChanged; }
         set{ iInfor_OutPep_IsChanged = value; }
      }
      private string iInfor_CustConfirmNo;
      private bool iInfor_CustConfirmNo_IsChanged=false;
      public string IInfor_CustConfirmNo
      {
         get{ return iInfor_CustConfirmNo; }
         set{ iInfor_CustConfirmNo = value; iInfor_CustConfirmNo_IsChanged=true; }
      }
      public bool IInfor_CustConfirmNo_IsChanged
      {
         get{ return iInfor_CustConfirmNo_IsChanged; }
         set{ iInfor_CustConfirmNo_IsChanged = value; }
      }
      private DateTime iInfor_CustConfirmDate;
      private bool iInfor_CustConfirmDate_IsChanged=false;
      public DateTime IInfor_CustConfirmDate
      {
         get{ return iInfor_CustConfirmDate; }
         set{ iInfor_CustConfirmDate = value; iInfor_CustConfirmDate_IsChanged=true; }
      }
      public bool IInfor_CustConfirmDate_IsChanged
      {
         get{ return iInfor_CustConfirmDate_IsChanged; }
         set{ iInfor_CustConfirmDate_IsChanged = value; }
      }
      private string iInfor_CustBak;
      private bool iInfor_CustBak_IsChanged=false;
      public string IInfor_CustBak
      {
         get{ return iInfor_CustBak; }
         set{ iInfor_CustBak = value; iInfor_CustBak_IsChanged=true; }
      }
      public bool IInfor_CustBak_IsChanged
      {
         get{ return iInfor_CustBak_IsChanged; }
         set{ iInfor_CustBak_IsChanged = value; }
      }
      private int iInfor_ProdType;
      private bool iInfor_ProdType_IsChanged=false;
      public int IInfor_ProdType
      {
         get{ return iInfor_ProdType; }
         set{ iInfor_ProdType = value; iInfor_ProdType_IsChanged=true; }
      }
      public bool IInfor_ProdType_IsChanged
      {
         get{ return iInfor_ProdType_IsChanged; }
         set{ iInfor_ProdType_IsChanged = value; }
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
      private DateTime deleteTime;
      private bool deleteTime_IsChanged=false;
      public DateTime DeleteTime
      {
         get{ return deleteTime; }
         set{ deleteTime = value; deleteTime_IsChanged=true; }
      }
      public bool DeleteTime_IsChanged
      {
         get{ return deleteTime_IsChanged; }
         set{ deleteTime_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private string iInfor_CmdReq;
      private bool iInfor_CmdReq_IsChanged=false;
      public string IInfor_CmdReq
      {
         get{ return iInfor_CmdReq; }
         set{ iInfor_CmdReq = value; iInfor_CmdReq_IsChanged=true; }
      }
      public bool IInfor_CmdReq_IsChanged
      {
         get{ return iInfor_CmdReq_IsChanged; }
         set{ iInfor_CmdReq_IsChanged = value; }
      }
   }
}
