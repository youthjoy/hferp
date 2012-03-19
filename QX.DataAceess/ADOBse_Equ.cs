using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAcess;

namespace QX.DataAceess
{
   [Serializable]
   public partial class ADOBse_Equ
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Equ对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Equ bse_Equ)
      {
         string sql = "INSERT INTO Bse_Equ (Equ_Code,Equ_Name,Equ_FixNo,Equ_CatCode,Equ_CatName,Equ_Owner,Equ_OwnerTel,Equ_Spec,Equ_Model,Equ_TimeCost,Equ_TimePrice,Equ_Manu,Equ_BuyDate,Equ_Bak,Equ_MaintainPep,Equ_MaintainTel,Stat,Equ_Stat) VALUES (@Equ_Code,@Equ_Name,@Equ_FixNo,@Equ_CatCode,@Equ_CatName,@Equ_Owner,@Equ_OwnerTel,@Equ_Spec,@Equ_Model,@Equ_TimeCost,@Equ_TimePrice,@Equ_Manu,@Equ_BuyDate,@Equ_Bak,@Equ_MaintainPep,@Equ_MaintainTel,@Stat,@Equ_Stat)";
         if (string.IsNullOrEmpty(bse_Equ.Equ_Code))
         {
            idb.AddParameter("@Equ_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Code", bse_Equ.Equ_Code);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Name))
         {
            idb.AddParameter("@Equ_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Name", bse_Equ.Equ_Name);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_FixNo))
         {
            idb.AddParameter("@Equ_FixNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_FixNo", bse_Equ.Equ_FixNo);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_CatCode))
         {
            idb.AddParameter("@Equ_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_CatCode", bse_Equ.Equ_CatCode);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_CatName))
         {
            idb.AddParameter("@Equ_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_CatName", bse_Equ.Equ_CatName);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Owner))
         {
            idb.AddParameter("@Equ_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Owner", bse_Equ.Equ_Owner);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_OwnerTel))
         {
            idb.AddParameter("@Equ_OwnerTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_OwnerTel", bse_Equ.Equ_OwnerTel);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Spec))
         {
            idb.AddParameter("@Equ_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Spec", bse_Equ.Equ_Spec);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Model))
         {
            idb.AddParameter("@Equ_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Model", bse_Equ.Equ_Model);
         }
         if (bse_Equ.Equ_TimeCost == 0)
         {
            idb.AddParameter("@Equ_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@Equ_TimeCost", bse_Equ.Equ_TimeCost);
         }
         if (bse_Equ.Equ_TimePrice == 0)
         {
            idb.AddParameter("@Equ_TimePrice", 0);
         }
         else
         {
            idb.AddParameter("@Equ_TimePrice", bse_Equ.Equ_TimePrice);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Manu))
         {
            idb.AddParameter("@Equ_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Manu", bse_Equ.Equ_Manu);
         }
         if (bse_Equ.Equ_BuyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Equ_BuyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_BuyDate", bse_Equ.Equ_BuyDate);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Bak))
         {
            idb.AddParameter("@Equ_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Bak", bse_Equ.Equ_Bak);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainPep))
         {
            idb.AddParameter("@Equ_MaintainPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_MaintainPep", bse_Equ.Equ_MaintainPep);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainTel))
         {
            idb.AddParameter("@Equ_MaintainTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_MaintainTel", bse_Equ.Equ_MaintainTel);
         }
         if (bse_Equ.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Equ.Stat);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Stat))
         {
            idb.AddParameter("@Equ_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Stat", bse_Equ.Equ_Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_Equ对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Equ bse_Equ)
      {
         string sql = "INSERT INTO Bse_Equ (Equ_Code,Equ_Name,Equ_FixNo,Equ_CatCode,Equ_CatName,Equ_Owner,Equ_OwnerTel,Equ_Spec,Equ_Model,Equ_TimeCost,Equ_TimePrice,Equ_Manu,Equ_BuyDate,Equ_Bak,Equ_MaintainPep,Equ_MaintainTel,Stat,Equ_Stat) VALUES (@Equ_Code,@Equ_Name,@Equ_FixNo,@Equ_CatCode,@Equ_CatName,@Equ_Owner,@Equ_OwnerTel,@Equ_Spec,@Equ_Model,@Equ_TimeCost,@Equ_TimePrice,@Equ_Manu,@Equ_BuyDate,@Equ_Bak,@Equ_MaintainPep,@Equ_MaintainTel,@Stat,@Equ_Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Equ.Equ_Code))
         {
            idb.AddParameter("@Equ_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Code", bse_Equ.Equ_Code);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Name))
         {
            idb.AddParameter("@Equ_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Name", bse_Equ.Equ_Name);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_FixNo))
         {
            idb.AddParameter("@Equ_FixNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_FixNo", bse_Equ.Equ_FixNo);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_CatCode))
         {
            idb.AddParameter("@Equ_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_CatCode", bse_Equ.Equ_CatCode);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_CatName))
         {
            idb.AddParameter("@Equ_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_CatName", bse_Equ.Equ_CatName);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Owner))
         {
            idb.AddParameter("@Equ_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Owner", bse_Equ.Equ_Owner);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_OwnerTel))
         {
            idb.AddParameter("@Equ_OwnerTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_OwnerTel", bse_Equ.Equ_OwnerTel);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Spec))
         {
            idb.AddParameter("@Equ_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Spec", bse_Equ.Equ_Spec);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Model))
         {
            idb.AddParameter("@Equ_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Model", bse_Equ.Equ_Model);
         }
         if (bse_Equ.Equ_TimeCost == 0)
         {
            idb.AddParameter("@Equ_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@Equ_TimeCost", bse_Equ.Equ_TimeCost);
         }
         if (bse_Equ.Equ_TimePrice == 0)
         {
            idb.AddParameter("@Equ_TimePrice", 0);
         }
         else
         {
            idb.AddParameter("@Equ_TimePrice", bse_Equ.Equ_TimePrice);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Manu))
         {
            idb.AddParameter("@Equ_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Manu", bse_Equ.Equ_Manu);
         }
         if (bse_Equ.Equ_BuyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Equ_BuyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_BuyDate", bse_Equ.Equ_BuyDate);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Bak))
         {
            idb.AddParameter("@Equ_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Bak", bse_Equ.Equ_Bak);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainPep))
         {
            idb.AddParameter("@Equ_MaintainPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_MaintainPep", bse_Equ.Equ_MaintainPep);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainTel))
         {
            idb.AddParameter("@Equ_MaintainTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_MaintainTel", bse_Equ.Equ_MaintainTel);
         }
         if (bse_Equ.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Equ.Stat);
         }
         if (string.IsNullOrEmpty(bse_Equ.Equ_Stat))
         {
            idb.AddParameter("@Equ_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Stat", bse_Equ.Equ_Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_Equ对象(即:一条记录
      /// </summary>
      public int Update(Bse_Equ bse_Equ)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Equ       SET ");
            if(bse_Equ.Equ_Code_IsChanged){sbParameter.Append("Equ_Code=@Equ_Code, ");}
      if(bse_Equ.Equ_Name_IsChanged){sbParameter.Append("Equ_Name=@Equ_Name, ");}
      if(bse_Equ.Equ_FixNo_IsChanged){sbParameter.Append("Equ_FixNo=@Equ_FixNo, ");}
      if(bse_Equ.Equ_CatCode_IsChanged){sbParameter.Append("Equ_CatCode=@Equ_CatCode, ");}
      if(bse_Equ.Equ_CatName_IsChanged){sbParameter.Append("Equ_CatName=@Equ_CatName, ");}
      if(bse_Equ.Equ_Owner_IsChanged){sbParameter.Append("Equ_Owner=@Equ_Owner, ");}
      if(bse_Equ.Equ_OwnerTel_IsChanged){sbParameter.Append("Equ_OwnerTel=@Equ_OwnerTel, ");}
      if(bse_Equ.Equ_Spec_IsChanged){sbParameter.Append("Equ_Spec=@Equ_Spec, ");}
      if(bse_Equ.Equ_Model_IsChanged){sbParameter.Append("Equ_Model=@Equ_Model, ");}
      if(bse_Equ.Equ_TimeCost_IsChanged){sbParameter.Append("Equ_TimeCost=@Equ_TimeCost, ");}
      if(bse_Equ.Equ_TimePrice_IsChanged){sbParameter.Append("Equ_TimePrice=@Equ_TimePrice, ");}
      if(bse_Equ.Equ_Manu_IsChanged){sbParameter.Append("Equ_Manu=@Equ_Manu, ");}
      if(bse_Equ.Equ_BuyDate_IsChanged){sbParameter.Append("Equ_BuyDate=@Equ_BuyDate, ");}
      if(bse_Equ.Equ_Bak_IsChanged){sbParameter.Append("Equ_Bak=@Equ_Bak, ");}
      if(bse_Equ.Equ_MaintainPep_IsChanged){sbParameter.Append("Equ_MaintainPep=@Equ_MaintainPep, ");}
      if(bse_Equ.Equ_MaintainTel_IsChanged){sbParameter.Append("Equ_MaintainTel=@Equ_MaintainTel, ");}
      if(bse_Equ.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Equ.Equ_Stat_IsChanged){sbParameter.Append("Equ_Stat=@Equ_Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Equ_ID=@Equ_ID; " );
      string sql=sb.ToString();
         if(bse_Equ.Equ_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Code))
         {
            idb.AddParameter("@Equ_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Code", bse_Equ.Equ_Code);
         }
          }
         if(bse_Equ.Equ_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Name))
         {
            idb.AddParameter("@Equ_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Name", bse_Equ.Equ_Name);
         }
          }
         if(bse_Equ.Equ_FixNo_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_FixNo))
         {
            idb.AddParameter("@Equ_FixNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_FixNo", bse_Equ.Equ_FixNo);
         }
          }
         if(bse_Equ.Equ_CatCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_CatCode))
         {
            idb.AddParameter("@Equ_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_CatCode", bse_Equ.Equ_CatCode);
         }
          }
         if(bse_Equ.Equ_CatName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_CatName))
         {
            idb.AddParameter("@Equ_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_CatName", bse_Equ.Equ_CatName);
         }
          }
         if(bse_Equ.Equ_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Owner))
         {
            idb.AddParameter("@Equ_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Owner", bse_Equ.Equ_Owner);
         }
          }
         if(bse_Equ.Equ_OwnerTel_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_OwnerTel))
         {
            idb.AddParameter("@Equ_OwnerTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_OwnerTel", bse_Equ.Equ_OwnerTel);
         }
          }
         if(bse_Equ.Equ_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Spec))
         {
            idb.AddParameter("@Equ_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Spec", bse_Equ.Equ_Spec);
         }
          }
         if(bse_Equ.Equ_Model_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Model))
         {
            idb.AddParameter("@Equ_Model", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Model", bse_Equ.Equ_Model);
         }
          }
         if(bse_Equ.Equ_TimeCost_IsChanged)
         {
         if (bse_Equ.Equ_TimeCost == 0)
         {
            idb.AddParameter("@Equ_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@Equ_TimeCost", bse_Equ.Equ_TimeCost);
         }
          }
         if(bse_Equ.Equ_TimePrice_IsChanged)
         {
         if (bse_Equ.Equ_TimePrice == 0)
         {
            idb.AddParameter("@Equ_TimePrice", 0);
         }
         else
         {
            idb.AddParameter("@Equ_TimePrice", bse_Equ.Equ_TimePrice);
         }
          }
         if(bse_Equ.Equ_Manu_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Manu))
         {
            idb.AddParameter("@Equ_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Manu", bse_Equ.Equ_Manu);
         }
          }
         if(bse_Equ.Equ_BuyDate_IsChanged)
         {
         if (bse_Equ.Equ_BuyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Equ_BuyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_BuyDate", bse_Equ.Equ_BuyDate);
         }
          }
         if(bse_Equ.Equ_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Bak))
         {
            idb.AddParameter("@Equ_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Bak", bse_Equ.Equ_Bak);
         }
          }
         if(bse_Equ.Equ_MaintainPep_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainPep))
         {
            idb.AddParameter("@Equ_MaintainPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_MaintainPep", bse_Equ.Equ_MaintainPep);
         }
          }
         if(bse_Equ.Equ_MaintainTel_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_MaintainTel))
         {
            idb.AddParameter("@Equ_MaintainTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_MaintainTel", bse_Equ.Equ_MaintainTel);
         }
          }
         if(bse_Equ.Stat_IsChanged)
         {
         if (bse_Equ.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Equ.Stat);
         }
          }
         if(bse_Equ.Equ_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Equ.Equ_Stat))
         {
            idb.AddParameter("@Equ_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Equ_Stat", bse_Equ.Equ_Stat);
         }
          }

         idb.AddParameter("@Equ_ID", bse_Equ.Equ_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_Equ对象(即:一条记录
      /// </summary>
      public int Delete(Int64 equ_ID)
      {
         string sql = "DELETE Bse_Equ WHERE 1=1  AND Equ_ID=@Equ_ID ";
         idb.AddParameter("@Equ_ID", equ_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_Equ对象(即:一条记录
      /// </summary>
      public Bse_Equ GetByKey(Int64 equ_ID)
      {
         Bse_Equ bse_Equ = new Bse_Equ();
         string sql = "SELECT  Equ_ID,Equ_Code,Equ_Name,Equ_FixNo,Equ_CatCode,Equ_CatName,Equ_Owner,Equ_OwnerTel,Equ_Spec,Equ_Model,Equ_TimeCost,Equ_TimePrice,Equ_Manu,Equ_BuyDate,Equ_Bak,Equ_MaintainPep,Equ_MaintainTel,Stat,Equ_Stat FROM Bse_Equ WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Equ_ID=@Equ_ID ";
         idb.AddParameter("@Equ_ID", equ_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Equ_ID"] != DBNull.Value) bse_Equ.Equ_ID = Convert.ToInt64(dr["Equ_ID"]);
            if (dr["Equ_Code"] != DBNull.Value) bse_Equ.Equ_Code = Convert.ToString(dr["Equ_Code"]);
            if (dr["Equ_Name"] != DBNull.Value) bse_Equ.Equ_Name = Convert.ToString(dr["Equ_Name"]);
            if (dr["Equ_FixNo"] != DBNull.Value) bse_Equ.Equ_FixNo = Convert.ToString(dr["Equ_FixNo"]);
            if (dr["Equ_CatCode"] != DBNull.Value) bse_Equ.Equ_CatCode = Convert.ToString(dr["Equ_CatCode"]);
            if (dr["Equ_CatName"] != DBNull.Value) bse_Equ.Equ_CatName = Convert.ToString(dr["Equ_CatName"]);
            if (dr["Equ_Owner"] != DBNull.Value) bse_Equ.Equ_Owner = Convert.ToString(dr["Equ_Owner"]);
            if (dr["Equ_OwnerTel"] != DBNull.Value) bse_Equ.Equ_OwnerTel = Convert.ToString(dr["Equ_OwnerTel"]);
            if (dr["Equ_Spec"] != DBNull.Value) bse_Equ.Equ_Spec = Convert.ToString(dr["Equ_Spec"]);
            if (dr["Equ_Model"] != DBNull.Value) bse_Equ.Equ_Model = Convert.ToString(dr["Equ_Model"]);
            if (dr["Equ_TimeCost"] != DBNull.Value) bse_Equ.Equ_TimeCost = Convert.ToInt32(dr["Equ_TimeCost"]);
            if (dr["Equ_TimePrice"] != DBNull.Value) bse_Equ.Equ_TimePrice = Convert.ToDecimal(dr["Equ_TimePrice"]);
            if (dr["Equ_Manu"] != DBNull.Value) bse_Equ.Equ_Manu = Convert.ToString(dr["Equ_Manu"]);
            if (dr["Equ_BuyDate"] != DBNull.Value) bse_Equ.Equ_BuyDate = Convert.ToDateTime(dr["Equ_BuyDate"]);
            if (dr["Equ_Bak"] != DBNull.Value) bse_Equ.Equ_Bak = Convert.ToString(dr["Equ_Bak"]);
            if (dr["Equ_MaintainPep"] != DBNull.Value) bse_Equ.Equ_MaintainPep = Convert.ToString(dr["Equ_MaintainPep"]);
            if (dr["Equ_MaintainTel"] != DBNull.Value) bse_Equ.Equ_MaintainTel = Convert.ToString(dr["Equ_MaintainTel"]);
            if (dr["Stat"] != DBNull.Value) bse_Equ.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Equ_Stat"] != DBNull.Value) bse_Equ.Equ_Stat = Convert.ToString(dr["Equ_Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Equ;
      }
      /// <summary>
      /// 获取指定的Bse_Equ对象集合
      /// </summary>
      public List<Bse_Equ> GetListByWhere(string strCondition)
      {
         List<Bse_Equ> ret = new List<Bse_Equ>();
         string sql = "SELECT  Equ_ID,Equ_Code,Equ_Name,Equ_FixNo,Equ_CatCode,Equ_CatName,Equ_Owner,Equ_OwnerTel,Equ_Spec,Equ_Model,Equ_TimeCost,Equ_TimePrice,Equ_Manu,Equ_BuyDate,Equ_Bak,Equ_MaintainPep,Equ_MaintainTel,Stat,Equ_Stat FROM Bse_Equ WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Equ bse_Equ = new Bse_Equ();
            if (dr["Equ_ID"] != DBNull.Value) bse_Equ.Equ_ID = Convert.ToInt64(dr["Equ_ID"]);
            if (dr["Equ_Code"] != DBNull.Value) bse_Equ.Equ_Code = Convert.ToString(dr["Equ_Code"]);
            if (dr["Equ_Name"] != DBNull.Value) bse_Equ.Equ_Name = Convert.ToString(dr["Equ_Name"]);
            if (dr["Equ_FixNo"] != DBNull.Value) bse_Equ.Equ_FixNo = Convert.ToString(dr["Equ_FixNo"]);
            if (dr["Equ_CatCode"] != DBNull.Value) bse_Equ.Equ_CatCode = Convert.ToString(dr["Equ_CatCode"]);
            if (dr["Equ_CatName"] != DBNull.Value) bse_Equ.Equ_CatName = Convert.ToString(dr["Equ_CatName"]);
            if (dr["Equ_Owner"] != DBNull.Value) bse_Equ.Equ_Owner = Convert.ToString(dr["Equ_Owner"]);
            if (dr["Equ_OwnerTel"] != DBNull.Value) bse_Equ.Equ_OwnerTel = Convert.ToString(dr["Equ_OwnerTel"]);
            if (dr["Equ_Spec"] != DBNull.Value) bse_Equ.Equ_Spec = Convert.ToString(dr["Equ_Spec"]);
            if (dr["Equ_Model"] != DBNull.Value) bse_Equ.Equ_Model = Convert.ToString(dr["Equ_Model"]);
            if (dr["Equ_TimeCost"] != DBNull.Value) bse_Equ.Equ_TimeCost = Convert.ToInt32(dr["Equ_TimeCost"]);
            if (dr["Equ_TimePrice"] != DBNull.Value) bse_Equ.Equ_TimePrice = Convert.ToDecimal(dr["Equ_TimePrice"]);
            if (dr["Equ_Manu"] != DBNull.Value) bse_Equ.Equ_Manu = Convert.ToString(dr["Equ_Manu"]);
            if (dr["Equ_BuyDate"] != DBNull.Value) bse_Equ.Equ_BuyDate = Convert.ToDateTime(dr["Equ_BuyDate"]);
            if (dr["Equ_Bak"] != DBNull.Value) bse_Equ.Equ_Bak = Convert.ToString(dr["Equ_Bak"]);
            if (dr["Equ_MaintainPep"] != DBNull.Value) bse_Equ.Equ_MaintainPep = Convert.ToString(dr["Equ_MaintainPep"]);
            if (dr["Equ_MaintainTel"] != DBNull.Value) bse_Equ.Equ_MaintainTel = Convert.ToString(dr["Equ_MaintainTel"]);
            if (dr["Stat"] != DBNull.Value) bse_Equ.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Equ_Stat"] != DBNull.Value) bse_Equ.Equ_Stat = Convert.ToString(dr["Equ_Stat"]);
            ret.Add(bse_Equ);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Equ对象(即:一条记录
      /// </summary>
      public List<Bse_Equ> GetAll()
      {
         List<Bse_Equ> ret = new List<Bse_Equ>();
         string sql = "SELECT  Equ_ID,Equ_Code,Equ_Name,Equ_FixNo,Equ_CatCode,Equ_CatName,Equ_Owner,Equ_OwnerTel,Equ_Spec,Equ_Model,Equ_TimeCost,Equ_TimePrice,Equ_Manu,Equ_BuyDate,Equ_Bak,Equ_MaintainPep,Equ_MaintainTel,Stat,Equ_Stat FROM Bse_Equ where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Equ bse_Equ = new Bse_Equ();
            if (dr["Equ_ID"] != DBNull.Value) bse_Equ.Equ_ID = Convert.ToInt64(dr["Equ_ID"]);
            if (dr["Equ_Code"] != DBNull.Value) bse_Equ.Equ_Code = Convert.ToString(dr["Equ_Code"]);
            if (dr["Equ_Name"] != DBNull.Value) bse_Equ.Equ_Name = Convert.ToString(dr["Equ_Name"]);
            if (dr["Equ_FixNo"] != DBNull.Value) bse_Equ.Equ_FixNo = Convert.ToString(dr["Equ_FixNo"]);
            if (dr["Equ_CatCode"] != DBNull.Value) bse_Equ.Equ_CatCode = Convert.ToString(dr["Equ_CatCode"]);
            if (dr["Equ_CatName"] != DBNull.Value) bse_Equ.Equ_CatName = Convert.ToString(dr["Equ_CatName"]);
            if (dr["Equ_Owner"] != DBNull.Value) bse_Equ.Equ_Owner = Convert.ToString(dr["Equ_Owner"]);
            if (dr["Equ_OwnerTel"] != DBNull.Value) bse_Equ.Equ_OwnerTel = Convert.ToString(dr["Equ_OwnerTel"]);
            if (dr["Equ_Spec"] != DBNull.Value) bse_Equ.Equ_Spec = Convert.ToString(dr["Equ_Spec"]);
            if (dr["Equ_Model"] != DBNull.Value) bse_Equ.Equ_Model = Convert.ToString(dr["Equ_Model"]);
            if (dr["Equ_TimeCost"] != DBNull.Value) bse_Equ.Equ_TimeCost = Convert.ToInt32(dr["Equ_TimeCost"]);
            if (dr["Equ_TimePrice"] != DBNull.Value) bse_Equ.Equ_TimePrice = Convert.ToDecimal(dr["Equ_TimePrice"]);
            if (dr["Equ_Manu"] != DBNull.Value) bse_Equ.Equ_Manu = Convert.ToString(dr["Equ_Manu"]);
            if (dr["Equ_BuyDate"] != DBNull.Value) bse_Equ.Equ_BuyDate = Convert.ToDateTime(dr["Equ_BuyDate"]);
            if (dr["Equ_Bak"] != DBNull.Value) bse_Equ.Equ_Bak = Convert.ToString(dr["Equ_Bak"]);
            if (dr["Equ_MaintainPep"] != DBNull.Value) bse_Equ.Equ_MaintainPep = Convert.ToString(dr["Equ_MaintainPep"]);
            if (dr["Equ_MaintainTel"] != DBNull.Value) bse_Equ.Equ_MaintainTel = Convert.ToString(dr["Equ_MaintainTel"]);
            if (dr["Stat"] != DBNull.Value) bse_Equ.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Equ_Stat"] != DBNull.Value) bse_Equ.Equ_Stat = Convert.ToString(dr["Equ_Stat"]);
            ret.Add(bse_Equ);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
