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
   public partial class ADOSD_ContractValue
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加SD_ContractValue对象(即:一条记录)
      /// </summary>
      public int Add(SD_ContractValue sD_ContractValue)
      {
         string sql = "INSERT INTO SD_ContractValue (CPR_Code,CPR_ContractCode,CPR_Customer,CPR_CusomterName,CPR_CmdCode,CPR_PartNod,CPR_PartName,CPR_Node,CPR_Price,Stat) VALUES (@CPR_Code,@CPR_ContractCode,@CPR_Customer,@CPR_CusomterName,@CPR_CmdCode,@CPR_PartNod,@CPR_PartName,@CPR_Node,@CPR_Price,@Stat)";
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Code))
         {
            idb.AddParameter("@CPR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Code", sD_ContractValue.CPR_Code);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_ContractCode))
         {
            idb.AddParameter("@CPR_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_ContractCode", sD_ContractValue.CPR_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Customer))
         {
            idb.AddParameter("@CPR_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Customer", sD_ContractValue.CPR_Customer);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_CusomterName))
         {
            idb.AddParameter("@CPR_CusomterName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_CusomterName", sD_ContractValue.CPR_CusomterName);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_CmdCode))
         {
            idb.AddParameter("@CPR_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_CmdCode", sD_ContractValue.CPR_CmdCode);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_PartNod))
         {
            idb.AddParameter("@CPR_PartNod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_PartNod", sD_ContractValue.CPR_PartNod);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_PartName))
         {
            idb.AddParameter("@CPR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_PartName", sD_ContractValue.CPR_PartName);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Node))
         {
            idb.AddParameter("@CPR_Node", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Node", sD_ContractValue.CPR_Node);
         }
         if (sD_ContractValue.CPR_Price == 0)
         {
            idb.AddParameter("@CPR_Price", 0);
         }
         else
         {
            idb.AddParameter("@CPR_Price", sD_ContractValue.CPR_Price);
         }
         if (sD_ContractValue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ContractValue.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加SD_ContractValue对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_ContractValue sD_ContractValue)
      {
         string sql = "INSERT INTO SD_ContractValue (CPR_Code,CPR_ContractCode,CPR_Customer,CPR_CusomterName,CPR_CmdCode,CPR_PartNod,CPR_PartName,CPR_Node,CPR_Price,Stat) VALUES (@CPR_Code,@CPR_ContractCode,@CPR_Customer,@CPR_CusomterName,@CPR_CmdCode,@CPR_PartNod,@CPR_PartName,@CPR_Node,@CPR_Price,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Code))
         {
            idb.AddParameter("@CPR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Code", sD_ContractValue.CPR_Code);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_ContractCode))
         {
            idb.AddParameter("@CPR_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_ContractCode", sD_ContractValue.CPR_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Customer))
         {
            idb.AddParameter("@CPR_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Customer", sD_ContractValue.CPR_Customer);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_CusomterName))
         {
            idb.AddParameter("@CPR_CusomterName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_CusomterName", sD_ContractValue.CPR_CusomterName);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_CmdCode))
         {
            idb.AddParameter("@CPR_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_CmdCode", sD_ContractValue.CPR_CmdCode);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_PartNod))
         {
            idb.AddParameter("@CPR_PartNod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_PartNod", sD_ContractValue.CPR_PartNod);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_PartName))
         {
            idb.AddParameter("@CPR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_PartName", sD_ContractValue.CPR_PartName);
         }
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Node))
         {
            idb.AddParameter("@CPR_Node", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Node", sD_ContractValue.CPR_Node);
         }
         if (sD_ContractValue.CPR_Price == 0)
         {
            idb.AddParameter("@CPR_Price", 0);
         }
         else
         {
            idb.AddParameter("@CPR_Price", sD_ContractValue.CPR_Price);
         }
         if (sD_ContractValue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ContractValue.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新SD_ContractValue对象(即:一条记录
      /// </summary>
      public int Update(SD_ContractValue sD_ContractValue)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_ContractValue       SET ");
            if(sD_ContractValue.CPR_Code_IsChanged){sbParameter.Append("CPR_Code=@CPR_Code, ");}
      if(sD_ContractValue.CPR_ContractCode_IsChanged){sbParameter.Append("CPR_ContractCode=@CPR_ContractCode, ");}
      if(sD_ContractValue.CPR_Customer_IsChanged){sbParameter.Append("CPR_Customer=@CPR_Customer, ");}
      if(sD_ContractValue.CPR_CusomterName_IsChanged){sbParameter.Append("CPR_CusomterName=@CPR_CusomterName, ");}
      if(sD_ContractValue.CPR_CmdCode_IsChanged){sbParameter.Append("CPR_CmdCode=@CPR_CmdCode, ");}
      if(sD_ContractValue.CPR_PartNod_IsChanged){sbParameter.Append("CPR_PartNod=@CPR_PartNod, ");}
      if(sD_ContractValue.CPR_PartName_IsChanged){sbParameter.Append("CPR_PartName=@CPR_PartName, ");}
      if(sD_ContractValue.CPR_Node_IsChanged){sbParameter.Append("CPR_Node=@CPR_Node, ");}
      if(sD_ContractValue.CPR_Price_IsChanged){sbParameter.Append("CPR_Price=@CPR_Price, ");}
      if(sD_ContractValue.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CPR_ID=@CPR_ID; " );
      string sql=sb.ToString();
         if(sD_ContractValue.CPR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Code))
         {
            idb.AddParameter("@CPR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Code", sD_ContractValue.CPR_Code);
         }
          }
         if(sD_ContractValue.CPR_ContractCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_ContractCode))
         {
            idb.AddParameter("@CPR_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_ContractCode", sD_ContractValue.CPR_ContractCode);
         }
          }
         if(sD_ContractValue.CPR_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Customer))
         {
            idb.AddParameter("@CPR_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Customer", sD_ContractValue.CPR_Customer);
         }
          }
         if(sD_ContractValue.CPR_CusomterName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_CusomterName))
         {
            idb.AddParameter("@CPR_CusomterName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_CusomterName", sD_ContractValue.CPR_CusomterName);
         }
          }
         if(sD_ContractValue.CPR_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_CmdCode))
         {
            idb.AddParameter("@CPR_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_CmdCode", sD_ContractValue.CPR_CmdCode);
         }
          }
         if(sD_ContractValue.CPR_PartNod_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_PartNod))
         {
            idb.AddParameter("@CPR_PartNod", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_PartNod", sD_ContractValue.CPR_PartNod);
         }
          }
         if(sD_ContractValue.CPR_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_PartName))
         {
            idb.AddParameter("@CPR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_PartName", sD_ContractValue.CPR_PartName);
         }
          }
         if(sD_ContractValue.CPR_Node_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractValue.CPR_Node))
         {
            idb.AddParameter("@CPR_Node", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CPR_Node", sD_ContractValue.CPR_Node);
         }
          }
         if(sD_ContractValue.CPR_Price_IsChanged)
         {
         if (sD_ContractValue.CPR_Price == 0)
         {
            idb.AddParameter("@CPR_Price", 0);
         }
         else
         {
            idb.AddParameter("@CPR_Price", sD_ContractValue.CPR_Price);
         }
          }
         if(sD_ContractValue.Stat_IsChanged)
         {
         if (sD_ContractValue.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ContractValue.Stat);
         }
          }

         idb.AddParameter("@CPR_ID", sD_ContractValue.CPR_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除SD_ContractValue对象(即:一条记录
      /// </summary>
      public int Delete(decimal cPR_ID)
      {
         string sql = "DELETE SD_ContractValue WHERE 1=1  AND CPR_ID=@CPR_ID ";
         idb.AddParameter("@CPR_ID", cPR_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的SD_ContractValue对象(即:一条记录
      /// </summary>
      public SD_ContractValue GetByKey(decimal cPR_ID)
      {
         SD_ContractValue sD_ContractValue = new SD_ContractValue();
         string sql = "SELECT  CPR_ID,CPR_Code,CPR_ContractCode,CPR_Customer,CPR_CusomterName,CPR_CmdCode,CPR_PartNod,CPR_PartName,CPR_Node,CPR_Price,Stat FROM SD_ContractValue WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CPR_ID=@CPR_ID ";
         idb.AddParameter("@CPR_ID", cPR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CPR_ID"] != DBNull.Value) sD_ContractValue.CPR_ID = Convert.ToDecimal(dr["CPR_ID"]);
            if (dr["CPR_Code"] != DBNull.Value) sD_ContractValue.CPR_Code = Convert.ToString(dr["CPR_Code"]);
            if (dr["CPR_ContractCode"] != DBNull.Value) sD_ContractValue.CPR_ContractCode = Convert.ToString(dr["CPR_ContractCode"]);
            if (dr["CPR_Customer"] != DBNull.Value) sD_ContractValue.CPR_Customer = Convert.ToString(dr["CPR_Customer"]);
            if (dr["CPR_CusomterName"] != DBNull.Value) sD_ContractValue.CPR_CusomterName = Convert.ToString(dr["CPR_CusomterName"]);
            if (dr["CPR_CmdCode"] != DBNull.Value) sD_ContractValue.CPR_CmdCode = Convert.ToString(dr["CPR_CmdCode"]);
            if (dr["CPR_PartNod"] != DBNull.Value) sD_ContractValue.CPR_PartNod = Convert.ToString(dr["CPR_PartNod"]);
            if (dr["CPR_PartName"] != DBNull.Value) sD_ContractValue.CPR_PartName = Convert.ToString(dr["CPR_PartName"]);
            if (dr["CPR_Node"] != DBNull.Value) sD_ContractValue.CPR_Node = Convert.ToString(dr["CPR_Node"]);
            if (dr["CPR_Price"] != DBNull.Value) sD_ContractValue.CPR_Price = Convert.ToDecimal(dr["CPR_Price"]);
            if (dr["Stat"] != DBNull.Value) sD_ContractValue.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_ContractValue;
      }
      /// <summary>
      /// 获取指定的SD_ContractValue对象集合
      /// </summary>
      public List<SD_ContractValue> GetListByWhere(string strCondition)
      {
         List<SD_ContractValue> ret = new List<SD_ContractValue>();
         string sql = "SELECT  CPR_ID,CPR_Code,CPR_ContractCode,CPR_Customer,CPR_CusomterName,CPR_CmdCode,CPR_PartNod,CPR_PartName,CPR_Node,CPR_Price,Stat FROM SD_ContractValue WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_ContractValue sD_ContractValue = new SD_ContractValue();
            if (dr["CPR_ID"] != DBNull.Value) sD_ContractValue.CPR_ID = Convert.ToDecimal(dr["CPR_ID"]);
            if (dr["CPR_Code"] != DBNull.Value) sD_ContractValue.CPR_Code = Convert.ToString(dr["CPR_Code"]);
            if (dr["CPR_ContractCode"] != DBNull.Value) sD_ContractValue.CPR_ContractCode = Convert.ToString(dr["CPR_ContractCode"]);
            if (dr["CPR_Customer"] != DBNull.Value) sD_ContractValue.CPR_Customer = Convert.ToString(dr["CPR_Customer"]);
            if (dr["CPR_CusomterName"] != DBNull.Value) sD_ContractValue.CPR_CusomterName = Convert.ToString(dr["CPR_CusomterName"]);
            if (dr["CPR_CmdCode"] != DBNull.Value) sD_ContractValue.CPR_CmdCode = Convert.ToString(dr["CPR_CmdCode"]);
            if (dr["CPR_PartNod"] != DBNull.Value) sD_ContractValue.CPR_PartNod = Convert.ToString(dr["CPR_PartNod"]);
            if (dr["CPR_PartName"] != DBNull.Value) sD_ContractValue.CPR_PartName = Convert.ToString(dr["CPR_PartName"]);
            if (dr["CPR_Node"] != DBNull.Value) sD_ContractValue.CPR_Node = Convert.ToString(dr["CPR_Node"]);
            if (dr["CPR_Price"] != DBNull.Value) sD_ContractValue.CPR_Price = Convert.ToDecimal(dr["CPR_Price"]);
            if (dr["Stat"] != DBNull.Value) sD_ContractValue.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sD_ContractValue);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的SD_ContractValue对象(即:一条记录
      /// </summary>
      public List<SD_ContractValue> GetAll()
      {
         List<SD_ContractValue> ret = new List<SD_ContractValue>();
         string sql = "SELECT  CPR_ID,CPR_Code,CPR_ContractCode,CPR_Customer,CPR_CusomterName,CPR_CmdCode,CPR_PartNod,CPR_PartName,CPR_Node,CPR_Price,Stat FROM SD_ContractValue where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_ContractValue sD_ContractValue = new SD_ContractValue();
            if (dr["CPR_ID"] != DBNull.Value) sD_ContractValue.CPR_ID = Convert.ToDecimal(dr["CPR_ID"]);
            if (dr["CPR_Code"] != DBNull.Value) sD_ContractValue.CPR_Code = Convert.ToString(dr["CPR_Code"]);
            if (dr["CPR_ContractCode"] != DBNull.Value) sD_ContractValue.CPR_ContractCode = Convert.ToString(dr["CPR_ContractCode"]);
            if (dr["CPR_Customer"] != DBNull.Value) sD_ContractValue.CPR_Customer = Convert.ToString(dr["CPR_Customer"]);
            if (dr["CPR_CusomterName"] != DBNull.Value) sD_ContractValue.CPR_CusomterName = Convert.ToString(dr["CPR_CusomterName"]);
            if (dr["CPR_CmdCode"] != DBNull.Value) sD_ContractValue.CPR_CmdCode = Convert.ToString(dr["CPR_CmdCode"]);
            if (dr["CPR_PartNod"] != DBNull.Value) sD_ContractValue.CPR_PartNod = Convert.ToString(dr["CPR_PartNod"]);
            if (dr["CPR_PartName"] != DBNull.Value) sD_ContractValue.CPR_PartName = Convert.ToString(dr["CPR_PartName"]);
            if (dr["CPR_Node"] != DBNull.Value) sD_ContractValue.CPR_Node = Convert.ToString(dr["CPR_Node"]);
            if (dr["CPR_Price"] != DBNull.Value) sD_ContractValue.CPR_Price = Convert.ToDecimal(dr["CPR_Price"]);
            if (dr["Stat"] != DBNull.Value) sD_ContractValue.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sD_ContractValue);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
