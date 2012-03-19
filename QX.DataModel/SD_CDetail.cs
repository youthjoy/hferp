using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   /// <summary>
   /// 合同细目信息
   /// </summary>
   [Serializable]
   public partial class SD_CDetail
   {
      /// <summary>
      /// 合同详细信息序号
      /// </summary>
      private Int64 cDetail_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_ID_IsChanged=false;
      /// <summary>
      /// 合同详细信息序号
      /// </summary>
      public Int64 CDetail_ID
      {
         get{ return cDetail_ID; }
         set{ cDetail_ID = value; cDetail_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同详细信息序号
      /// </summary>
      public bool CDetail_ID_IsChanged
      {
         get{ return cDetail_ID_IsChanged; }
         set{ cDetail_ID_IsChanged = value; }
      }
      private string cDetail_Code;
      private bool cDetail_Code_IsChanged=false;
      public string CDetail_Code
      {
         get{ return cDetail_Code; }
         set{ cDetail_Code = value; cDetail_Code_IsChanged=true; }
      }
      public bool CDetail_Code_IsChanged
      {
         get{ return cDetail_Code_IsChanged; }
         set{ cDetail_Code_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string cDetail_PartNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_PartNo_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string CDetail_PartNo
      {
         get{ return cDetail_PartNo; }
         set{ cDetail_PartNo = value; cDetail_PartNo_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool CDetail_PartNo_IsChanged
      {
         get{ return cDetail_PartNo_IsChanged; }
         set{ cDetail_PartNo_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string cDetail_PartName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_PartName_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string CDetail_PartName
      {
         get{ return cDetail_PartName; }
         set{ cDetail_PartName = value; cDetail_PartName_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool CDetail_PartName_IsChanged
      {
         get{ return cDetail_PartName_IsChanged; }
         set{ cDetail_PartName_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int cDetail_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int CDetail_Num
      {
         get{ return cDetail_Num; }
         set{ cDetail_Num = value; cDetail_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool CDetail_Num_IsChanged
      {
         get{ return cDetail_Num_IsChanged; }
         set{ cDetail_Num_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal cDetail_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_Price_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal CDetail_Price
      {
         get{ return cDetail_Price; }
         set{ cDetail_Price = value; cDetail_Price_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool CDetail_Price_IsChanged
      {
         get{ return cDetail_Price_IsChanged; }
         set{ cDetail_Price_IsChanged = value; }
      }
      /// <summary>
      /// 工序说明
      /// </summary>
      private string cDetail_Intro;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_Intro_IsChanged=false;
      /// <summary>
      /// 工序说明
      /// </summary>
      public string CDetail_Intro
      {
         get{ return cDetail_Intro; }
         set{ cDetail_Intro = value; cDetail_Intro_IsChanged=true; }
      }
      /// <summary>
      /// 工序说明
      /// </summary>
      public bool CDetail_Intro_IsChanged
      {
         get{ return cDetail_Intro_IsChanged; }
         set{ cDetail_Intro_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cDetail_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CDetail_Bak
      {
         get{ return cDetail_Bak; }
         set{ cDetail_Bak = value; cDetail_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CDetail_Bak_IsChanged
      {
         get{ return cDetail_Bak_IsChanged; }
         set{ cDetail_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 在制数量
      /// </summary>
      private int cDetail_OnNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_OnNum_IsChanged=false;
      /// <summary>
      /// 在制数量
      /// </summary>
      public int CDetail_OnNum
      {
         get{ return cDetail_OnNum; }
         set{ cDetail_OnNum = value; cDetail_OnNum_IsChanged=true; }
      }
      /// <summary>
      /// 在制数量
      /// </summary>
      public bool CDetail_OnNum_IsChanged
      {
         get{ return cDetail_OnNum_IsChanged; }
         set{ cDetail_OnNum_IsChanged = value; }
      }
      /// <summary>
      /// 完成数量
      /// </summary>
      private int cDetail_FNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_FNum_IsChanged=false;
      /// <summary>
      /// 完成数量
      /// </summary>
      public int CDetail_FNum
      {
         get{ return cDetail_FNum; }
         set{ cDetail_FNum = value; cDetail_FNum_IsChanged=true; }
      }
      /// <summary>
      /// 完成数量
      /// </summary>
      public bool CDetail_FNum_IsChanged
      {
         get{ return cDetail_FNum_IsChanged; }
         set{ cDetail_FNum_IsChanged = value; }
      }
      /// <summary>
      /// 次品数量
      /// </summary>
      private int cDetail_DNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_DNum_IsChanged=false;
      /// <summary>
      /// 次品数量
      /// </summary>
      public int CDetail_DNum
      {
         get{ return cDetail_DNum; }
         set{ cDetail_DNum = value; cDetail_DNum_IsChanged=true; }
      }
      /// <summary>
      /// 次品数量
      /// </summary>
      public bool CDetail_DNum_IsChanged
      {
         get{ return cDetail_DNum_IsChanged; }
         set{ cDetail_DNum_IsChanged = value; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      private string cDetail_ContractNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_ContractNo_IsChanged=false;
      /// <summary>
      /// 合同编号
      /// </summary>
      public string CDetail_ContractNo
      {
         get{ return cDetail_ContractNo; }
         set{ cDetail_ContractNo = value; cDetail_ContractNo_IsChanged=true; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      public bool CDetail_ContractNo_IsChanged
      {
         get{ return cDetail_ContractNo_IsChanged; }
         set{ cDetail_ContractNo_IsChanged = value; }
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
      /// 合同细目修改时间
      /// </summary>
      private DateTime cDetail_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cDetail_Date_IsChanged=false;
      /// <summary>
      /// 合同细目修改时间
      /// </summary>
      public DateTime CDetail_Date
      {
         get{ return cDetail_Date; }
         set{ cDetail_Date = value; cDetail_Date_IsChanged=true; }
      }
      /// <summary>
      /// 合同细目修改时间
      /// </summary>
      public bool CDetail_Date_IsChanged
      {
         get{ return cDetail_Date_IsChanged; }
         set{ cDetail_Date_IsChanged = value; }
      }
      private string cDetail_Cmd;
      private bool cDetail_Cmd_IsChanged=false;
      public string CDetail_Cmd
      {
         get{ return cDetail_Cmd; }
         set{ cDetail_Cmd = value; cDetail_Cmd_IsChanged=true; }
      }
      public bool CDetail_Cmd_IsChanged
      {
         get{ return cDetail_Cmd_IsChanged; }
         set{ cDetail_Cmd_IsChanged = value; }
      }
      private string cDetail_Project;
      private bool cDetail_Project_IsChanged=false;
      public string CDetail_Project
      {
         get{ return cDetail_Project; }
         set{ cDetail_Project = value; cDetail_Project_IsChanged=true; }
      }
      public bool CDetail_Project_IsChanged
      {
         get{ return cDetail_Project_IsChanged; }
         set{ cDetail_Project_IsChanged = value; }
      }
      private decimal cDetail_Sum;
      private bool cDetail_Sum_IsChanged=false;
      public decimal CDetail_Sum
      {
         get{ return cDetail_Sum; }
         set{ cDetail_Sum = value; cDetail_Sum_IsChanged=true; }
      }
      public bool CDetail_Sum_IsChanged
      {
         get{ return cDetail_Sum_IsChanged; }
         set{ cDetail_Sum_IsChanged = value; }
      }
      private decimal cDetail_NoTax;
      private bool cDetail_NoTax_IsChanged=false;
      public decimal CDetail_NoTax
      {
         get{ return cDetail_NoTax; }
         set{ cDetail_NoTax = value; cDetail_NoTax_IsChanged=true; }
      }
      public bool CDetail_NoTax_IsChanged
      {
         get{ return cDetail_NoTax_IsChanged; }
         set{ cDetail_NoTax_IsChanged = value; }
      }
      private string cDetail_ProdCode;
      private bool cDetail_ProdCode_IsChanged=false;
      public string CDetail_ProdCode
      {
         get{ return cDetail_ProdCode; }
         set{ cDetail_ProdCode = value; cDetail_ProdCode_IsChanged=true; }
      }
      public bool CDetail_ProdCode_IsChanged
      {
         get{ return cDetail_ProdCode_IsChanged; }
         set{ cDetail_ProdCode_IsChanged = value; }
      }
      private string cDetail_Unit;
      private bool cDetail_Unit_IsChanged=false;
      public string CDetail_Unit
      {
         get{ return cDetail_Unit; }
         set{ cDetail_Unit = value; cDetail_Unit_IsChanged=true; }
      }
      public bool CDetail_Unit_IsChanged
      {
         get{ return cDetail_Unit_IsChanged; }
         set{ cDetail_Unit_IsChanged = value; }
      }
      private string cDetail_PRRelation;
      private bool cDetail_PRRelation_IsChanged=false;
      public string CDetail_PRRelation
      {
         get{ return cDetail_PRRelation; }
         set{ cDetail_PRRelation = value; cDetail_PRRelation_IsChanged=true; }
      }
      public bool CDetail_PRRelation_IsChanged
      {
         get{ return cDetail_PRRelation_IsChanged; }
         set{ cDetail_PRRelation_IsChanged = value; }
      }
      private string cDetail_Finance;
      private bool cDetail_Finance_IsChanged=false;
      public string CDetail_Finance
      {
         get{ return cDetail_Finance; }
         set{ cDetail_Finance = value; cDetail_Finance_IsChanged=true; }
      }
      public bool CDetail_Finance_IsChanged
      {
         get{ return cDetail_Finance_IsChanged; }
         set{ cDetail_Finance_IsChanged = value; }
      }
   }
}
