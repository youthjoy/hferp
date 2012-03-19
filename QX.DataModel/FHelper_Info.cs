using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 外协信息记录
   /// </summary>
   [Serializable]
   public partial class FHelper_Info
   {
      /// <summary>
      /// 序号
      /// </summary>
      private Int64 fHelperInfo_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_ID_IsChanged=false;
      /// <summary>
      /// 序号
      /// </summary>
      public Int64 FHelperInfo_ID
      {
         get{ return fHelperInfo_ID; }
         set{ fHelperInfo_ID = value; fHelperInfo_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序号
      /// </summary>
      public bool FHelperInfo_ID_IsChanged
      {
         get{ return fHelperInfo_ID_IsChanged; }
         set{ fHelperInfo_ID_IsChanged = value; }
      }
      /// <summary>
      /// 外协编码
      /// </summary>
      private string fHelperInfo_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Code_IsChanged=false;
      /// <summary>
      /// 外协编码
      /// </summary>
      public string FHelperInfo_Code
      {
         get{ return fHelperInfo_Code; }
         set{ fHelperInfo_Code = value; fHelperInfo_Code_IsChanged=true; }
      }
      /// <summary>
      /// 外协编码
      /// </summary>
      public bool FHelperInfo_Code_IsChanged
      {
         get{ return fHelperInfo_Code_IsChanged; }
         set{ fHelperInfo_Code_IsChanged = value; }
      }
      /// <summary>
      /// 参考编码
      /// </summary>
      private string fHelperInfo_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_RefCode_IsChanged=false;
      /// <summary>
      /// 参考编码
      /// </summary>
      public string FHelperInfo_RefCode
      {
         get{ return fHelperInfo_RefCode; }
         set{ fHelperInfo_RefCode = value; fHelperInfo_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考编码
      /// </summary>
      public bool FHelperInfo_RefCode_IsChanged
      {
         get{ return fHelperInfo_RefCode_IsChanged; }
         set{ fHelperInfo_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string fHelperInfo_PartCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_PartCode_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string FHelperInfo_PartCode
      {
         get{ return fHelperInfo_PartCode; }
         set{ fHelperInfo_PartCode = value; fHelperInfo_PartCode_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool FHelperInfo_PartCode_IsChanged
      {
         get{ return fHelperInfo_PartCode_IsChanged; }
         set{ fHelperInfo_PartCode_IsChanged = value; }
      }
      /// <summary>
      /// 产品编码
      /// </summary>
      private string fHelperInfo_ProdCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_ProdCode_IsChanged=false;
      /// <summary>
      /// 产品编码
      /// </summary>
      public string FHelperInfo_ProdCode
      {
         get{ return fHelperInfo_ProdCode; }
         set{ fHelperInfo_ProdCode = value; fHelperInfo_ProdCode_IsChanged=true; }
      }
      /// <summary>
      /// 产品编码
      /// </summary>
      public bool FHelperInfo_ProdCode_IsChanged
      {
         get{ return fHelperInfo_ProdCode_IsChanged; }
         set{ fHelperInfo_ProdCode_IsChanged = value; }
      }
      /// <summary>
      /// 工序说明
      /// </summary>
      private string fHelperInfo_RoadNodes;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_RoadNodes_IsChanged=false;
      /// <summary>
      /// 工序说明
      /// </summary>
      public string FHelperInfo_RoadNodes
      {
         get{ return fHelperInfo_RoadNodes; }
         set{ fHelperInfo_RoadNodes = value; fHelperInfo_RoadNodes_IsChanged=true; }
      }
      /// <summary>
      /// 工序说明
      /// </summary>
      public bool FHelperInfo_RoadNodes_IsChanged
      {
         get{ return fHelperInfo_RoadNodes_IsChanged; }
         set{ fHelperInfo_RoadNodes_IsChanged = value; }
      }
      /// <summary>
      /// 外协厂商
      /// </summary>
      private string fHelperInfo_FSup;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_FSup_IsChanged=false;
      /// <summary>
      /// 外协厂商
      /// </summary>
      public string FHelperInfo_FSup
      {
         get{ return fHelperInfo_FSup; }
         set{ fHelperInfo_FSup = value; fHelperInfo_FSup_IsChanged=true; }
      }
      /// <summary>
      /// 外协厂商
      /// </summary>
      public bool FHelperInfo_FSup_IsChanged
      {
         get{ return fHelperInfo_FSup_IsChanged; }
         set{ fHelperInfo_FSup_IsChanged = value; }
      }
      /// <summary>
      /// 价格序号
      /// </summary>
      private string fHelperInfo_PriceID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_PriceID_IsChanged=false;
      /// <summary>
      /// 价格序号
      /// </summary>
      public string FHelperInfo_PriceID
      {
         get{ return fHelperInfo_PriceID; }
         set{ fHelperInfo_PriceID = value; fHelperInfo_PriceID_IsChanged=true; }
      }
      /// <summary>
      /// 价格序号
      /// </summary>
      public bool FHelperInfo_PriceID_IsChanged
      {
         get{ return fHelperInfo_PriceID_IsChanged; }
         set{ fHelperInfo_PriceID_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal fHelperInfo_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Price_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal FHelperInfo_Price
      {
         get{ return fHelperInfo_Price; }
         set{ fHelperInfo_Price = value; fHelperInfo_Price_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool FHelperInfo_Price_IsChanged
      {
         get{ return fHelperInfo_Price_IsChanged; }
         set{ fHelperInfo_Price_IsChanged = value; }
      }
      /// <summary>
      /// 外协数量
      /// </summary>
      private int fHelperInfo_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Num_IsChanged=false;
      /// <summary>
      /// 外协数量
      /// </summary>
      public int FHelperInfo_Num
      {
         get{ return fHelperInfo_Num; }
         set{ fHelperInfo_Num = value; fHelperInfo_Num_IsChanged=true; }
      }
      /// <summary>
      /// 外协数量
      /// </summary>
      public bool FHelperInfo_Num_IsChanged
      {
         get{ return fHelperInfo_Num_IsChanged; }
         set{ fHelperInfo_Num_IsChanged = value; }
      }
      /// <summary>
      /// 完成数量
      /// </summary>
      private int fHelperInfo_FNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_FNum_IsChanged=false;
      /// <summary>
      /// 完成数量
      /// </summary>
      public int FHelperInfo_FNum
      {
         get{ return fHelperInfo_FNum; }
         set{ fHelperInfo_FNum = value; fHelperInfo_FNum_IsChanged=true; }
      }
      /// <summary>
      /// 完成数量
      /// </summary>
      public bool FHelperInfo_FNum_IsChanged
      {
         get{ return fHelperInfo_FNum_IsChanged; }
         set{ fHelperInfo_FNum_IsChanged = value; }
      }
      /// <summary>
      /// 次品数量
      /// </summary>
      private int fHelperInfo_DNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_DNum_IsChanged=false;
      /// <summary>
      /// 次品数量
      /// </summary>
      public int FHelperInfo_DNum
      {
         get{ return fHelperInfo_DNum; }
         set{ fHelperInfo_DNum = value; fHelperInfo_DNum_IsChanged=true; }
      }
      /// <summary>
      /// 次品数量
      /// </summary>
      public bool FHelperInfo_DNum_IsChanged
      {
         get{ return fHelperInfo_DNum_IsChanged; }
         set{ fHelperInfo_DNum_IsChanged = value; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      private string fHelperInfo_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Owner_IsChanged=false;
      /// <summary>
      /// 业务负责人
      /// </summary>
      public string FHelperInfo_Owner
      {
         get{ return fHelperInfo_Owner; }
         set{ fHelperInfo_Owner = value; fHelperInfo_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      public bool FHelperInfo_Owner_IsChanged
      {
         get{ return fHelperInfo_Owner_IsChanged; }
         set{ fHelperInfo_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 时间
      /// </summary>
      private DateTime fHelperInfo_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Date_IsChanged=false;
      /// <summary>
      /// 时间
      /// </summary>
      public DateTime FHelperInfo_Date
      {
         get{ return fHelperInfo_Date; }
         set{ fHelperInfo_Date = value; fHelperInfo_Date_IsChanged=true; }
      }
      /// <summary>
      /// 时间
      /// </summary>
      public bool FHelperInfo_Date_IsChanged
      {
         get{ return fHelperInfo_Date_IsChanged; }
         set{ fHelperInfo_Date_IsChanged = value; }
      }
      /// <summary>
      /// 外协状态
      /// </summary>
      private string fHelperInfo_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Stat_IsChanged=false;
      /// <summary>
      /// 外协状态
      /// </summary>
      public string FHelperInfo_Stat
      {
         get{ return fHelperInfo_Stat; }
         set{ fHelperInfo_Stat = value; fHelperInfo_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 外协状态
      /// </summary>
      public bool FHelperInfo_Stat_IsChanged
      {
         get{ return fHelperInfo_Stat_IsChanged; }
         set{ fHelperInfo_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string fHelperInfo_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string FHelperInfo_Bak
      {
         get{ return fHelperInfo_Bak; }
         set{ fHelperInfo_Bak = value; fHelperInfo_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool FHelperInfo_Bak_IsChanged
      {
         get{ return fHelperInfo_Bak_IsChanged; }
         set{ fHelperInfo_Bak_IsChanged = value; }
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
      /// 外协完成情况状态
      /// </summary>
      private string fHelperInfo_FStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_FStat_IsChanged=false;
      /// <summary>
      /// 外协完成情况状态
      /// </summary>
      public string FHelperInfo_FStat
      {
         get{ return fHelperInfo_FStat; }
         set{ fHelperInfo_FStat = value; fHelperInfo_FStat_IsChanged=true; }
      }
      /// <summary>
      /// 外协完成情况状态
      /// </summary>
      public bool FHelperInfo_FStat_IsChanged
      {
         get{ return fHelperInfo_FStat_IsChanged; }
         set{ fHelperInfo_FStat_IsChanged = value; }
      }
      /// <summary>
      /// 内部状态
      /// </summary>
      private string fHelperInfo_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool fHelperInfo_iType_IsChanged=false;
      /// <summary>
      /// 内部状态
      /// </summary>
      public string FHelperInfo_iType
      {
         get{ return fHelperInfo_iType; }
         set{ fHelperInfo_iType = value; fHelperInfo_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部状态
      /// </summary>
      public bool FHelperInfo_iType_IsChanged
      {
         get{ return fHelperInfo_iType_IsChanged; }
         set{ fHelperInfo_iType_IsChanged = value; }
      }
      private DateTime fHelperInfo_BackDate;
      private bool fHelperInfo_BackDate_IsChanged=false;
      public DateTime FHelperInfo_BackDate
      {
         get{ return fHelperInfo_BackDate; }
         set{ fHelperInfo_BackDate = value; fHelperInfo_BackDate_IsChanged=true; }
      }
      public bool FHelperInfo_BackDate_IsChanged
      {
         get{ return fHelperInfo_BackDate_IsChanged; }
         set{ fHelperInfo_BackDate_IsChanged = value; }
      }
      private DateTime fHelperInfo_OutDate;
      private bool fHelperInfo_OutDate_IsChanged=false;
      public DateTime FHelperInfo_OutDate
      {
         get{ return fHelperInfo_OutDate; }
         set{ fHelperInfo_OutDate = value; fHelperInfo_OutDate_IsChanged=true; }
      }
      public bool FHelperInfo_OutDate_IsChanged
      {
         get{ return fHelperInfo_OutDate_IsChanged; }
         set{ fHelperInfo_OutDate_IsChanged = value; }
      }
      private string fHelperInfo_IsBatch;
      private bool fHelperInfo_IsBatch_IsChanged=false;
      public string FHelperInfo_IsBatch
      {
         get{ return fHelperInfo_IsBatch; }
         set{ fHelperInfo_IsBatch = value; fHelperInfo_IsBatch_IsChanged=true; }
      }
      public bool FHelperInfo_IsBatch_IsChanged
      {
         get{ return fHelperInfo_IsBatch_IsChanged; }
         set{ fHelperInfo_IsBatch_IsChanged = value; }
      }
   }
}
