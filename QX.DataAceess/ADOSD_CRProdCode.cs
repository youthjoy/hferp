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
   public partial class ADOSD_CRProdCode
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加SD_CRProdCode对象(即:一条记录)
      /// </summary>
      public int Add(SD_CRProdCode sD_CRProdCode)
      {
         string sql = "INSERT INTO SD_CRProdCode (SDR_Code,SDR_ContractCode,SDR_DetailCode,SDR_CmdCode,SDR_TaskCode,SDR_PartNo,SDR_PartName,SDR_ProdCode,SDR_PlanCode,SDR_Sum,SDR_Price,Stat) VALUES (@SDR_Code,@SDR_ContractCode,@SDR_DetailCode,@SDR_CmdCode,@SDR_TaskCode,@SDR_PartNo,@SDR_PartName,@SDR_ProdCode,@SDR_PlanCode,@SDR_Sum,@SDR_Price,@Stat)";
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_Code))
         {
            idb.AddParameter("@SDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Code", sD_CRProdCode.SDR_Code);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_ContractCode))
         {
            idb.AddParameter("@SDR_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_ContractCode", sD_CRProdCode.SDR_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_DetailCode))
         {
            idb.AddParameter("@SDR_DetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_DetailCode", sD_CRProdCode.SDR_DetailCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_CmdCode))
         {
            idb.AddParameter("@SDR_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CmdCode", sD_CRProdCode.SDR_CmdCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_TaskCode))
         {
            idb.AddParameter("@SDR_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_TaskCode", sD_CRProdCode.SDR_TaskCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PartNo))
         {
            idb.AddParameter("@SDR_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PartNo", sD_CRProdCode.SDR_PartNo);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PartName))
         {
            idb.AddParameter("@SDR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PartName", sD_CRProdCode.SDR_PartName);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_ProdCode))
         {
            idb.AddParameter("@SDR_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_ProdCode", sD_CRProdCode.SDR_ProdCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PlanCode))
         {
            idb.AddParameter("@SDR_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PlanCode", sD_CRProdCode.SDR_PlanCode);
         }
         if (sD_CRProdCode.SDR_Sum == 0)
         {
            idb.AddParameter("@SDR_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Sum", sD_CRProdCode.SDR_Sum);
         }
         if (sD_CRProdCode.SDR_Price == 0)
         {
            idb.AddParameter("@SDR_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Price", sD_CRProdCode.SDR_Price);
         }
         if (sD_CRProdCode.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CRProdCode.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加SD_CRProdCode对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_CRProdCode sD_CRProdCode)
      {
         string sql = "INSERT INTO SD_CRProdCode (SDR_Code,SDR_ContractCode,SDR_DetailCode,SDR_CmdCode,SDR_TaskCode,SDR_PartNo,SDR_PartName,SDR_ProdCode,SDR_PlanCode,SDR_Sum,SDR_Price,Stat) VALUES (@SDR_Code,@SDR_ContractCode,@SDR_DetailCode,@SDR_CmdCode,@SDR_TaskCode,@SDR_PartNo,@SDR_PartName,@SDR_ProdCode,@SDR_PlanCode,@SDR_Sum,@SDR_Price,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_Code))
         {
            idb.AddParameter("@SDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Code", sD_CRProdCode.SDR_Code);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_ContractCode))
         {
            idb.AddParameter("@SDR_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_ContractCode", sD_CRProdCode.SDR_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_DetailCode))
         {
            idb.AddParameter("@SDR_DetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_DetailCode", sD_CRProdCode.SDR_DetailCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_CmdCode))
         {
            idb.AddParameter("@SDR_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CmdCode", sD_CRProdCode.SDR_CmdCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_TaskCode))
         {
            idb.AddParameter("@SDR_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_TaskCode", sD_CRProdCode.SDR_TaskCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PartNo))
         {
            idb.AddParameter("@SDR_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PartNo", sD_CRProdCode.SDR_PartNo);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PartName))
         {
            idb.AddParameter("@SDR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PartName", sD_CRProdCode.SDR_PartName);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_ProdCode))
         {
            idb.AddParameter("@SDR_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_ProdCode", sD_CRProdCode.SDR_ProdCode);
         }
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PlanCode))
         {
            idb.AddParameter("@SDR_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PlanCode", sD_CRProdCode.SDR_PlanCode);
         }
         if (sD_CRProdCode.SDR_Sum == 0)
         {
            idb.AddParameter("@SDR_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Sum", sD_CRProdCode.SDR_Sum);
         }
         if (sD_CRProdCode.SDR_Price == 0)
         {
            idb.AddParameter("@SDR_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Price", sD_CRProdCode.SDR_Price);
         }
         if (sD_CRProdCode.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CRProdCode.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新SD_CRProdCode对象(即:一条记录
      /// </summary>
      public int Update(SD_CRProdCode sD_CRProdCode)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_CRProdCode       SET ");
            if(sD_CRProdCode.SDR_Code_IsChanged){sbParameter.Append("SDR_Code=@SDR_Code, ");}
      if(sD_CRProdCode.SDR_ContractCode_IsChanged){sbParameter.Append("SDR_ContractCode=@SDR_ContractCode, ");}
      if(sD_CRProdCode.SDR_DetailCode_IsChanged){sbParameter.Append("SDR_DetailCode=@SDR_DetailCode, ");}
      if(sD_CRProdCode.SDR_CmdCode_IsChanged){sbParameter.Append("SDR_CmdCode=@SDR_CmdCode, ");}
      if(sD_CRProdCode.SDR_TaskCode_IsChanged){sbParameter.Append("SDR_TaskCode=@SDR_TaskCode, ");}
      if(sD_CRProdCode.SDR_PartNo_IsChanged){sbParameter.Append("SDR_PartNo=@SDR_PartNo, ");}
      if(sD_CRProdCode.SDR_PartName_IsChanged){sbParameter.Append("SDR_PartName=@SDR_PartName, ");}
      if(sD_CRProdCode.SDR_ProdCode_IsChanged){sbParameter.Append("SDR_ProdCode=@SDR_ProdCode, ");}
      if(sD_CRProdCode.SDR_PlanCode_IsChanged){sbParameter.Append("SDR_PlanCode=@SDR_PlanCode, ");}
      if(sD_CRProdCode.SDR_Sum_IsChanged){sbParameter.Append("SDR_Sum=@SDR_Sum, ");}
      if(sD_CRProdCode.SDR_Price_IsChanged){sbParameter.Append("SDR_Price=@SDR_Price, ");}
      if(sD_CRProdCode.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDR_ID=@SDR_ID; " );
      string sql=sb.ToString();
         if(sD_CRProdCode.SDR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_Code))
         {
            idb.AddParameter("@SDR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_Code", sD_CRProdCode.SDR_Code);
         }
          }
         if(sD_CRProdCode.SDR_ContractCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_ContractCode))
         {
            idb.AddParameter("@SDR_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_ContractCode", sD_CRProdCode.SDR_ContractCode);
         }
          }
         if(sD_CRProdCode.SDR_DetailCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_DetailCode))
         {
            idb.AddParameter("@SDR_DetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_DetailCode", sD_CRProdCode.SDR_DetailCode);
         }
          }
         if(sD_CRProdCode.SDR_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_CmdCode))
         {
            idb.AddParameter("@SDR_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_CmdCode", sD_CRProdCode.SDR_CmdCode);
         }
          }
         if(sD_CRProdCode.SDR_TaskCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_TaskCode))
         {
            idb.AddParameter("@SDR_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_TaskCode", sD_CRProdCode.SDR_TaskCode);
         }
          }
         if(sD_CRProdCode.SDR_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PartNo))
         {
            idb.AddParameter("@SDR_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PartNo", sD_CRProdCode.SDR_PartNo);
         }
          }
         if(sD_CRProdCode.SDR_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PartName))
         {
            idb.AddParameter("@SDR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PartName", sD_CRProdCode.SDR_PartName);
         }
          }
         if(sD_CRProdCode.SDR_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_ProdCode))
         {
            idb.AddParameter("@SDR_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_ProdCode", sD_CRProdCode.SDR_ProdCode);
         }
          }
         if(sD_CRProdCode.SDR_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CRProdCode.SDR_PlanCode))
         {
            idb.AddParameter("@SDR_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDR_PlanCode", sD_CRProdCode.SDR_PlanCode);
         }
          }
         if(sD_CRProdCode.SDR_Sum_IsChanged)
         {
         if (sD_CRProdCode.SDR_Sum == 0)
         {
            idb.AddParameter("@SDR_Sum", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Sum", sD_CRProdCode.SDR_Sum);
         }
          }
         if(sD_CRProdCode.SDR_Price_IsChanged)
         {
         if (sD_CRProdCode.SDR_Price == 0)
         {
            idb.AddParameter("@SDR_Price", 0);
         }
         else
         {
            idb.AddParameter("@SDR_Price", sD_CRProdCode.SDR_Price);
         }
          }
         if(sD_CRProdCode.Stat_IsChanged)
         {
         if (sD_CRProdCode.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CRProdCode.Stat);
         }
          }

         idb.AddParameter("@SDR_ID", sD_CRProdCode.SDR_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除SD_CRProdCode对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDR_ID)
      {
         string sql = "DELETE SD_CRProdCode WHERE 1=1  AND SDR_ID=@SDR_ID ";
         idb.AddParameter("@SDR_ID", sDR_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的SD_CRProdCode对象(即:一条记录
      /// </summary>
      public SD_CRProdCode GetByKey(decimal sDR_ID)
      {
         SD_CRProdCode sD_CRProdCode = new SD_CRProdCode();
         string sql = "SELECT  SDR_ID,SDR_Code,SDR_ContractCode,SDR_DetailCode,SDR_CmdCode,SDR_TaskCode,SDR_PartNo,SDR_PartName,SDR_ProdCode,SDR_PlanCode,SDR_Sum,SDR_Price,Stat FROM SD_CRProdCode WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDR_ID=@SDR_ID ";
         idb.AddParameter("@SDR_ID", sDR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDR_ID"] != DBNull.Value) sD_CRProdCode.SDR_ID = Convert.ToDecimal(dr["SDR_ID"]);
            if (dr["SDR_Code"] != DBNull.Value) sD_CRProdCode.SDR_Code = Convert.ToString(dr["SDR_Code"]);
            if (dr["SDR_ContractCode"] != DBNull.Value) sD_CRProdCode.SDR_ContractCode = Convert.ToString(dr["SDR_ContractCode"]);
            if (dr["SDR_DetailCode"] != DBNull.Value) sD_CRProdCode.SDR_DetailCode = Convert.ToString(dr["SDR_DetailCode"]);
            if (dr["SDR_CmdCode"] != DBNull.Value) sD_CRProdCode.SDR_CmdCode = Convert.ToString(dr["SDR_CmdCode"]);
            if (dr["SDR_TaskCode"] != DBNull.Value) sD_CRProdCode.SDR_TaskCode = Convert.ToString(dr["SDR_TaskCode"]);
            if (dr["SDR_PartNo"] != DBNull.Value) sD_CRProdCode.SDR_PartNo = Convert.ToString(dr["SDR_PartNo"]);
            if (dr["SDR_PartName"] != DBNull.Value) sD_CRProdCode.SDR_PartName = Convert.ToString(dr["SDR_PartName"]);
            if (dr["SDR_ProdCode"] != DBNull.Value) sD_CRProdCode.SDR_ProdCode = Convert.ToString(dr["SDR_ProdCode"]);
            if (dr["SDR_PlanCode"] != DBNull.Value) sD_CRProdCode.SDR_PlanCode = Convert.ToString(dr["SDR_PlanCode"]);
            if (dr["SDR_Sum"] != DBNull.Value) sD_CRProdCode.SDR_Sum = Convert.ToDecimal(dr["SDR_Sum"]);
            if (dr["SDR_Price"] != DBNull.Value) sD_CRProdCode.SDR_Price = Convert.ToDecimal(dr["SDR_Price"]);
            if (dr["Stat"] != DBNull.Value) sD_CRProdCode.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_CRProdCode;
      }
      /// <summary>
      /// 获取指定的SD_CRProdCode对象集合
      /// </summary>
      public List<SD_CRProdCode> GetListByWhere(string strCondition)
      {
         List<SD_CRProdCode> ret = new List<SD_CRProdCode>();
         string sql = "SELECT  SDR_ID,SDR_Code,SDR_ContractCode,SDR_DetailCode,SDR_CmdCode,SDR_TaskCode,SDR_PartNo,SDR_PartName,SDR_ProdCode,SDR_PlanCode,SDR_Sum,SDR_Price,Stat FROM SD_CRProdCode WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_CRProdCode sD_CRProdCode = new SD_CRProdCode();
            if (dr["SDR_ID"] != DBNull.Value) sD_CRProdCode.SDR_ID = Convert.ToDecimal(dr["SDR_ID"]);
            if (dr["SDR_Code"] != DBNull.Value) sD_CRProdCode.SDR_Code = Convert.ToString(dr["SDR_Code"]);
            if (dr["SDR_ContractCode"] != DBNull.Value) sD_CRProdCode.SDR_ContractCode = Convert.ToString(dr["SDR_ContractCode"]);
            if (dr["SDR_DetailCode"] != DBNull.Value) sD_CRProdCode.SDR_DetailCode = Convert.ToString(dr["SDR_DetailCode"]);
            if (dr["SDR_CmdCode"] != DBNull.Value) sD_CRProdCode.SDR_CmdCode = Convert.ToString(dr["SDR_CmdCode"]);
            if (dr["SDR_TaskCode"] != DBNull.Value) sD_CRProdCode.SDR_TaskCode = Convert.ToString(dr["SDR_TaskCode"]);
            if (dr["SDR_PartNo"] != DBNull.Value) sD_CRProdCode.SDR_PartNo = Convert.ToString(dr["SDR_PartNo"]);
            if (dr["SDR_PartName"] != DBNull.Value) sD_CRProdCode.SDR_PartName = Convert.ToString(dr["SDR_PartName"]);
            if (dr["SDR_ProdCode"] != DBNull.Value) sD_CRProdCode.SDR_ProdCode = Convert.ToString(dr["SDR_ProdCode"]);
            if (dr["SDR_PlanCode"] != DBNull.Value) sD_CRProdCode.SDR_PlanCode = Convert.ToString(dr["SDR_PlanCode"]);
            if (dr["SDR_Sum"] != DBNull.Value) sD_CRProdCode.SDR_Sum = Convert.ToDecimal(dr["SDR_Sum"]);
            if (dr["SDR_Price"] != DBNull.Value) sD_CRProdCode.SDR_Price = Convert.ToDecimal(dr["SDR_Price"]);
            if (dr["Stat"] != DBNull.Value) sD_CRProdCode.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sD_CRProdCode);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的SD_CRProdCode对象(即:一条记录
      /// </summary>
      public List<SD_CRProdCode> GetAll()
      {
         List<SD_CRProdCode> ret = new List<SD_CRProdCode>();
         string sql = "SELECT  SDR_ID,SDR_Code,SDR_ContractCode,SDR_DetailCode,SDR_CmdCode,SDR_TaskCode,SDR_PartNo,SDR_PartName,SDR_ProdCode,SDR_PlanCode,SDR_Sum,SDR_Price,Stat FROM SD_CRProdCode where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_CRProdCode sD_CRProdCode = new SD_CRProdCode();
            if (dr["SDR_ID"] != DBNull.Value) sD_CRProdCode.SDR_ID = Convert.ToDecimal(dr["SDR_ID"]);
            if (dr["SDR_Code"] != DBNull.Value) sD_CRProdCode.SDR_Code = Convert.ToString(dr["SDR_Code"]);
            if (dr["SDR_ContractCode"] != DBNull.Value) sD_CRProdCode.SDR_ContractCode = Convert.ToString(dr["SDR_ContractCode"]);
            if (dr["SDR_DetailCode"] != DBNull.Value) sD_CRProdCode.SDR_DetailCode = Convert.ToString(dr["SDR_DetailCode"]);
            if (dr["SDR_CmdCode"] != DBNull.Value) sD_CRProdCode.SDR_CmdCode = Convert.ToString(dr["SDR_CmdCode"]);
            if (dr["SDR_TaskCode"] != DBNull.Value) sD_CRProdCode.SDR_TaskCode = Convert.ToString(dr["SDR_TaskCode"]);
            if (dr["SDR_PartNo"] != DBNull.Value) sD_CRProdCode.SDR_PartNo = Convert.ToString(dr["SDR_PartNo"]);
            if (dr["SDR_PartName"] != DBNull.Value) sD_CRProdCode.SDR_PartName = Convert.ToString(dr["SDR_PartName"]);
            if (dr["SDR_ProdCode"] != DBNull.Value) sD_CRProdCode.SDR_ProdCode = Convert.ToString(dr["SDR_ProdCode"]);
            if (dr["SDR_PlanCode"] != DBNull.Value) sD_CRProdCode.SDR_PlanCode = Convert.ToString(dr["SDR_PlanCode"]);
            if (dr["SDR_Sum"] != DBNull.Value) sD_CRProdCode.SDR_Sum = Convert.ToDecimal(dr["SDR_Sum"]);
            if (dr["SDR_Price"] != DBNull.Value) sD_CRProdCode.SDR_Price = Convert.ToDecimal(dr["SDR_Price"]);
            if (dr["Stat"] != DBNull.Value) sD_CRProdCode.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sD_CRProdCode);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
