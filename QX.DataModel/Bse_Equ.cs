using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.DataModel
{
   [Serializable]
   public partial class Bse_Equ
   {
      /// <summary>
      /// 设备序号
      /// </summary>
      private Int64 equ_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_ID_IsChanged=false;
      /// <summary>
      /// 设备序号
      /// </summary>
      public Int64 Equ_ID
      {
         get{ return equ_ID; }
         set{ equ_ID = value; equ_ID_IsChanged=true; }
      }
      /// <summary>
      /// 设备序号
      /// </summary>
      public bool Equ_ID_IsChanged
      {
         get{ return equ_ID_IsChanged; }
         set{ equ_ID_IsChanged = value; }
      }
      /// <summary>
      /// 设备编号
      /// </summary>
      private string equ_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Code_IsChanged=false;
      /// <summary>
      /// 设备编号
      /// </summary>
      public string Equ_Code
      {
         get{ return equ_Code; }
         set{ equ_Code = value; equ_Code_IsChanged=true; }
      }
      /// <summary>
      /// 设备编号
      /// </summary>
      public bool Equ_Code_IsChanged
      {
         get{ return equ_Code_IsChanged; }
         set{ equ_Code_IsChanged = value; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      private string equ_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Name_IsChanged=false;
      /// <summary>
      /// 设备名称
      /// </summary>
      public string Equ_Name
      {
         get{ return equ_Name; }
         set{ equ_Name = value; equ_Name_IsChanged=true; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      public bool Equ_Name_IsChanged
      {
         get{ return equ_Name_IsChanged; }
         set{ equ_Name_IsChanged = value; }
      }
      /// <summary>
      /// 固定资产编号
      /// </summary>
      private string equ_FixNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_FixNo_IsChanged=false;
      /// <summary>
      /// 固定资产编号
      /// </summary>
      public string Equ_FixNo
      {
         get{ return equ_FixNo; }
         set{ equ_FixNo = value; equ_FixNo_IsChanged=true; }
      }
      /// <summary>
      /// 固定资产编号
      /// </summary>
      public bool Equ_FixNo_IsChanged
      {
         get{ return equ_FixNo_IsChanged; }
         set{ equ_FixNo_IsChanged = value; }
      }
      /// <summary>
      /// 设备分类编号
      /// </summary>
      private string equ_CatCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_CatCode_IsChanged=false;
      /// <summary>
      /// 设备分类编号
      /// </summary>
      public string Equ_CatCode
      {
         get{ return equ_CatCode; }
         set{ equ_CatCode = value; equ_CatCode_IsChanged=true; }
      }
      /// <summary>
      /// 设备分类编号
      /// </summary>
      public bool Equ_CatCode_IsChanged
      {
         get{ return equ_CatCode_IsChanged; }
         set{ equ_CatCode_IsChanged = value; }
      }
      /// <summary>
      /// 设备分类名称
      /// </summary>
      private string equ_CatName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_CatName_IsChanged=false;
      /// <summary>
      /// 设备分类名称
      /// </summary>
      public string Equ_CatName
      {
         get{ return equ_CatName; }
         set{ equ_CatName = value; equ_CatName_IsChanged=true; }
      }
      /// <summary>
      /// 设备分类名称
      /// </summary>
      public bool Equ_CatName_IsChanged
      {
         get{ return equ_CatName_IsChanged; }
         set{ equ_CatName_IsChanged = value; }
      }
      /// <summary>
      /// 设备负责人
      /// </summary>
      private string equ_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Owner_IsChanged=false;
      /// <summary>
      /// 设备负责人
      /// </summary>
      public string Equ_Owner
      {
         get{ return equ_Owner; }
         set{ equ_Owner = value; equ_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 设备负责人
      /// </summary>
      public bool Equ_Owner_IsChanged
      {
         get{ return equ_Owner_IsChanged; }
         set{ equ_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 设备负责人电话
      /// </summary>
      private string equ_OwnerTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_OwnerTel_IsChanged=false;
      /// <summary>
      /// 设备负责人电话
      /// </summary>
      public string Equ_OwnerTel
      {
         get{ return equ_OwnerTel; }
         set{ equ_OwnerTel = value; equ_OwnerTel_IsChanged=true; }
      }
      /// <summary>
      /// 设备负责人电话
      /// </summary>
      public bool Equ_OwnerTel_IsChanged
      {
         get{ return equ_OwnerTel_IsChanged; }
         set{ equ_OwnerTel_IsChanged = value; }
      }
      /// <summary>
      /// 设备规格
      /// </summary>
      private string equ_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Spec_IsChanged=false;
      /// <summary>
      /// 设备规格
      /// </summary>
      public string Equ_Spec
      {
         get{ return equ_Spec; }
         set{ equ_Spec = value; equ_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 设备规格
      /// </summary>
      public bool Equ_Spec_IsChanged
      {
         get{ return equ_Spec_IsChanged; }
         set{ equ_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 设备型号
      /// </summary>
      private string equ_Model;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Model_IsChanged=false;
      /// <summary>
      /// 设备型号
      /// </summary>
      public string Equ_Model
      {
         get{ return equ_Model; }
         set{ equ_Model = value; equ_Model_IsChanged=true; }
      }
      /// <summary>
      /// 设备型号
      /// </summary>
      public bool Equ_Model_IsChanged
      {
         get{ return equ_Model_IsChanged; }
         set{ equ_Model_IsChanged = value; }
      }
      private int equ_TimeCost;
      private bool equ_TimeCost_IsChanged=false;
      public int Equ_TimeCost
      {
         get{ return equ_TimeCost; }
         set{ equ_TimeCost = value; equ_TimeCost_IsChanged=true; }
      }
      public bool Equ_TimeCost_IsChanged
      {
         get{ return equ_TimeCost_IsChanged; }
         set{ equ_TimeCost_IsChanged = value; }
      }
      private decimal equ_TimePrice;
      private bool equ_TimePrice_IsChanged=false;
      public decimal Equ_TimePrice
      {
         get{ return equ_TimePrice; }
         set{ equ_TimePrice = value; equ_TimePrice_IsChanged=true; }
      }
      public bool Equ_TimePrice_IsChanged
      {
         get{ return equ_TimePrice_IsChanged; }
         set{ equ_TimePrice_IsChanged = value; }
      }
      /// <summary>
      /// 生产厂家
      /// </summary>
      private string equ_Manu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Manu_IsChanged=false;
      /// <summary>
      /// 生产厂家
      /// </summary>
      public string Equ_Manu
      {
         get{ return equ_Manu; }
         set{ equ_Manu = value; equ_Manu_IsChanged=true; }
      }
      /// <summary>
      /// 生产厂家
      /// </summary>
      public bool Equ_Manu_IsChanged
      {
         get{ return equ_Manu_IsChanged; }
         set{ equ_Manu_IsChanged = value; }
      }
      /// <summary>
      /// 购买时间
      /// </summary>
      private DateTime equ_BuyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_BuyDate_IsChanged=false;
      /// <summary>
      /// 购买时间
      /// </summary>
      public DateTime Equ_BuyDate
      {
         get{ return equ_BuyDate; }
         set{ equ_BuyDate = value; equ_BuyDate_IsChanged=true; }
      }
      /// <summary>
      /// 购买时间
      /// </summary>
      public bool Equ_BuyDate_IsChanged
      {
         get{ return equ_BuyDate_IsChanged; }
         set{ equ_BuyDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string equ_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Equ_Bak
      {
         get{ return equ_Bak; }
         set{ equ_Bak = value; equ_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Equ_Bak_IsChanged
      {
         get{ return equ_Bak_IsChanged; }
         set{ equ_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 维修联系人
      /// </summary>
      private string equ_MaintainPep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_MaintainPep_IsChanged=false;
      /// <summary>
      /// 维修联系人
      /// </summary>
      public string Equ_MaintainPep
      {
         get{ return equ_MaintainPep; }
         set{ equ_MaintainPep = value; equ_MaintainPep_IsChanged=true; }
      }
      /// <summary>
      /// 维修联系人
      /// </summary>
      public bool Equ_MaintainPep_IsChanged
      {
         get{ return equ_MaintainPep_IsChanged; }
         set{ equ_MaintainPep_IsChanged = value; }
      }
      /// <summary>
      /// 维修联系电话
      /// </summary>
      private string equ_MaintainTel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_MaintainTel_IsChanged=false;
      /// <summary>
      /// 维修联系电话
      /// </summary>
      public string Equ_MaintainTel
      {
         get{ return equ_MaintainTel; }
         set{ equ_MaintainTel = value; equ_MaintainTel_IsChanged=true; }
      }
      /// <summary>
      /// 维修联系电话
      /// </summary>
      public bool Equ_MaintainTel_IsChanged
      {
         get{ return equ_MaintainTel_IsChanged; }
         set{ equ_MaintainTel_IsChanged = value; }
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
      /// 设备状态
      /// </summary>
      private string equ_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equ_Stat_IsChanged=false;
      /// <summary>
      /// 设备状态
      /// </summary>
      public string Equ_Stat
      {
         get{ return equ_Stat; }
         set{ equ_Stat = value; equ_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 设备状态
      /// </summary>
      public bool Equ_Stat_IsChanged
      {
         get{ return equ_Stat_IsChanged; }
         set{ equ_Stat_IsChanged = value; }
      }
   }
}
