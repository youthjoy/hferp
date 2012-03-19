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
   public partial class ADOSD_Finance
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加SD_Finance对象(即:一条记录)
      /// </summary>
      public int Add(SD_Finance sD_Finance)
      {
         string sql = "INSERT INTO SD_Finance (SDF_Code,SDF_ContractCode,SDF_Customer,SDF_CustomerName,SDF_ContractDetail,SDF_CmdCode,SDF_PartNo,SDF_PartName,SDF_NodeCode,SDF_NodeName,SDF_Value,SDF_ProdType,SDF_Stat,Stat,CreatTime,SDF_Udef1,SDF_Udef2,SDF_Udef3) VALUES (@SDF_Code,@SDF_ContractCode,@SDF_Customer,@SDF_CustomerName,@SDF_ContractDetail,@SDF_CmdCode,@SDF_PartNo,@SDF_PartName,@SDF_NodeCode,@SDF_NodeName,@SDF_Value,@SDF_ProdType,@SDF_Stat,@Stat,@CreatTime,@SDF_Udef1,@SDF_Udef2,@SDF_Udef3)";
         if (string.IsNullOrEmpty(sD_Finance.SDF_Code))
         {
            idb.AddParameter("@SDF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Code", sD_Finance.SDF_Code);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_ContractCode))
         {
            idb.AddParameter("@SDF_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ContractCode", sD_Finance.SDF_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Customer))
         {
            idb.AddParameter("@SDF_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Customer", sD_Finance.SDF_Customer);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_CustomerName))
         {
            idb.AddParameter("@SDF_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CustomerName", sD_Finance.SDF_CustomerName);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_ContractDetail))
         {
            idb.AddParameter("@SDF_ContractDetail", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ContractDetail", sD_Finance.SDF_ContractDetail);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_CmdCode))
         {
            idb.AddParameter("@SDF_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CmdCode", sD_Finance.SDF_CmdCode);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_PartNo))
         {
            idb.AddParameter("@SDF_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_PartNo", sD_Finance.SDF_PartNo);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_PartName))
         {
            idb.AddParameter("@SDF_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_PartName", sD_Finance.SDF_PartName);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_NodeCode))
         {
            idb.AddParameter("@SDF_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_NodeCode", sD_Finance.SDF_NodeCode);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_NodeName))
         {
            idb.AddParameter("@SDF_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_NodeName", sD_Finance.SDF_NodeName);
         }
         if (sD_Finance.SDF_Value == 0)
         {
            idb.AddParameter("@SDF_Value", 0);
         }
         else
         {
            idb.AddParameter("@SDF_Value", sD_Finance.SDF_Value);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_ProdType))
         {
            idb.AddParameter("@SDF_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ProdType", sD_Finance.SDF_ProdType);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Stat))
         {
            idb.AddParameter("@SDF_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Stat", sD_Finance.SDF_Stat);
         }
         if (sD_Finance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Finance.Stat);
         }
         if (sD_Finance.CreatTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreatTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreatTime", sD_Finance.CreatTime);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef1))
         {
            idb.AddParameter("@SDF_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef1", sD_Finance.SDF_Udef1);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef2))
         {
            idb.AddParameter("@SDF_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef2", sD_Finance.SDF_Udef2);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef3))
         {
            idb.AddParameter("@SDF_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef3", sD_Finance.SDF_Udef3);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加SD_Finance对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Finance sD_Finance)
      {
         string sql = "INSERT INTO SD_Finance (SDF_Code,SDF_ContractCode,SDF_Customer,SDF_CustomerName,SDF_ContractDetail,SDF_CmdCode,SDF_PartNo,SDF_PartName,SDF_NodeCode,SDF_NodeName,SDF_Value,SDF_ProdType,SDF_Stat,Stat,CreatTime,SDF_Udef1,SDF_Udef2,SDF_Udef3) VALUES (@SDF_Code,@SDF_ContractCode,@SDF_Customer,@SDF_CustomerName,@SDF_ContractDetail,@SDF_CmdCode,@SDF_PartNo,@SDF_PartName,@SDF_NodeCode,@SDF_NodeName,@SDF_Value,@SDF_ProdType,@SDF_Stat,@Stat,@CreatTime,@SDF_Udef1,@SDF_Udef2,@SDF_Udef3);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Finance.SDF_Code))
         {
            idb.AddParameter("@SDF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Code", sD_Finance.SDF_Code);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_ContractCode))
         {
            idb.AddParameter("@SDF_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ContractCode", sD_Finance.SDF_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Customer))
         {
            idb.AddParameter("@SDF_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Customer", sD_Finance.SDF_Customer);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_CustomerName))
         {
            idb.AddParameter("@SDF_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CustomerName", sD_Finance.SDF_CustomerName);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_ContractDetail))
         {
            idb.AddParameter("@SDF_ContractDetail", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ContractDetail", sD_Finance.SDF_ContractDetail);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_CmdCode))
         {
            idb.AddParameter("@SDF_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CmdCode", sD_Finance.SDF_CmdCode);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_PartNo))
         {
            idb.AddParameter("@SDF_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_PartNo", sD_Finance.SDF_PartNo);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_PartName))
         {
            idb.AddParameter("@SDF_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_PartName", sD_Finance.SDF_PartName);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_NodeCode))
         {
            idb.AddParameter("@SDF_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_NodeCode", sD_Finance.SDF_NodeCode);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_NodeName))
         {
            idb.AddParameter("@SDF_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_NodeName", sD_Finance.SDF_NodeName);
         }
         if (sD_Finance.SDF_Value == 0)
         {
            idb.AddParameter("@SDF_Value", 0);
         }
         else
         {
            idb.AddParameter("@SDF_Value", sD_Finance.SDF_Value);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_ProdType))
         {
            idb.AddParameter("@SDF_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ProdType", sD_Finance.SDF_ProdType);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Stat))
         {
            idb.AddParameter("@SDF_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Stat", sD_Finance.SDF_Stat);
         }
         if (sD_Finance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Finance.Stat);
         }
         if (sD_Finance.CreatTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreatTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreatTime", sD_Finance.CreatTime);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef1))
         {
            idb.AddParameter("@SDF_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef1", sD_Finance.SDF_Udef1);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef2))
         {
            idb.AddParameter("@SDF_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef2", sD_Finance.SDF_Udef2);
         }
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef3))
         {
            idb.AddParameter("@SDF_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef3", sD_Finance.SDF_Udef3);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新SD_Finance对象(即:一条记录
      /// </summary>
      public int Update(SD_Finance sD_Finance)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Finance       SET ");
            if(sD_Finance.SDF_Code_IsChanged){sbParameter.Append("SDF_Code=@SDF_Code, ");}
      if(sD_Finance.SDF_ContractCode_IsChanged){sbParameter.Append("SDF_ContractCode=@SDF_ContractCode, ");}
      if(sD_Finance.SDF_Customer_IsChanged){sbParameter.Append("SDF_Customer=@SDF_Customer, ");}
      if(sD_Finance.SDF_CustomerName_IsChanged){sbParameter.Append("SDF_CustomerName=@SDF_CustomerName, ");}
      if(sD_Finance.SDF_ContractDetail_IsChanged){sbParameter.Append("SDF_ContractDetail=@SDF_ContractDetail, ");}
      if(sD_Finance.SDF_CmdCode_IsChanged){sbParameter.Append("SDF_CmdCode=@SDF_CmdCode, ");}
      if(sD_Finance.SDF_PartNo_IsChanged){sbParameter.Append("SDF_PartNo=@SDF_PartNo, ");}
      if(sD_Finance.SDF_PartName_IsChanged){sbParameter.Append("SDF_PartName=@SDF_PartName, ");}
      if(sD_Finance.SDF_NodeCode_IsChanged){sbParameter.Append("SDF_NodeCode=@SDF_NodeCode, ");}
      if(sD_Finance.SDF_NodeName_IsChanged){sbParameter.Append("SDF_NodeName=@SDF_NodeName, ");}
      if(sD_Finance.SDF_Value_IsChanged){sbParameter.Append("SDF_Value=@SDF_Value, ");}
      if(sD_Finance.SDF_ProdType_IsChanged){sbParameter.Append("SDF_ProdType=@SDF_ProdType, ");}
      if(sD_Finance.SDF_Stat_IsChanged){sbParameter.Append("SDF_Stat=@SDF_Stat, ");}
      if(sD_Finance.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Finance.CreatTime_IsChanged){sbParameter.Append("CreatTime=@CreatTime, ");}
      if(sD_Finance.SDF_Udef1_IsChanged){sbParameter.Append("SDF_Udef1=@SDF_Udef1, ");}
      if(sD_Finance.SDF_Udef2_IsChanged){sbParameter.Append("SDF_Udef2=@SDF_Udef2, ");}
      if(sD_Finance.SDF_Udef3_IsChanged){sbParameter.Append("SDF_Udef3=@SDF_Udef3 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDF_ID=@SDF_ID; " );
      string sql=sb.ToString();
         if(sD_Finance.SDF_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_Code))
         {
            idb.AddParameter("@SDF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Code", sD_Finance.SDF_Code);
         }
          }
         if(sD_Finance.SDF_ContractCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_ContractCode))
         {
            idb.AddParameter("@SDF_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ContractCode", sD_Finance.SDF_ContractCode);
         }
          }
         if(sD_Finance.SDF_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_Customer))
         {
            idb.AddParameter("@SDF_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Customer", sD_Finance.SDF_Customer);
         }
          }
         if(sD_Finance.SDF_CustomerName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_CustomerName))
         {
            idb.AddParameter("@SDF_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CustomerName", sD_Finance.SDF_CustomerName);
         }
          }
         if(sD_Finance.SDF_ContractDetail_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_ContractDetail))
         {
            idb.AddParameter("@SDF_ContractDetail", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ContractDetail", sD_Finance.SDF_ContractDetail);
         }
          }
         if(sD_Finance.SDF_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_CmdCode))
         {
            idb.AddParameter("@SDF_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_CmdCode", sD_Finance.SDF_CmdCode);
         }
          }
         if(sD_Finance.SDF_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_PartNo))
         {
            idb.AddParameter("@SDF_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_PartNo", sD_Finance.SDF_PartNo);
         }
          }
         if(sD_Finance.SDF_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_PartName))
         {
            idb.AddParameter("@SDF_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_PartName", sD_Finance.SDF_PartName);
         }
          }
         if(sD_Finance.SDF_NodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_NodeCode))
         {
            idb.AddParameter("@SDF_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_NodeCode", sD_Finance.SDF_NodeCode);
         }
          }
         if(sD_Finance.SDF_NodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_NodeName))
         {
            idb.AddParameter("@SDF_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_NodeName", sD_Finance.SDF_NodeName);
         }
          }
         if(sD_Finance.SDF_Value_IsChanged)
         {
         if (sD_Finance.SDF_Value == 0)
         {
            idb.AddParameter("@SDF_Value", 0);
         }
         else
         {
            idb.AddParameter("@SDF_Value", sD_Finance.SDF_Value);
         }
          }
         if(sD_Finance.SDF_ProdType_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_ProdType))
         {
            idb.AddParameter("@SDF_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_ProdType", sD_Finance.SDF_ProdType);
         }
          }
         if(sD_Finance.SDF_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_Stat))
         {
            idb.AddParameter("@SDF_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Stat", sD_Finance.SDF_Stat);
         }
          }
         if(sD_Finance.Stat_IsChanged)
         {
         if (sD_Finance.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Finance.Stat);
         }
          }
         if(sD_Finance.CreatTime_IsChanged)
         {
         if (sD_Finance.CreatTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreatTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreatTime", sD_Finance.CreatTime);
         }
          }
         if(sD_Finance.SDF_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef1))
         {
            idb.AddParameter("@SDF_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef1", sD_Finance.SDF_Udef1);
         }
          }
         if(sD_Finance.SDF_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef2))
         {
            idb.AddParameter("@SDF_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef2", sD_Finance.SDF_Udef2);
         }
          }
         if(sD_Finance.SDF_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Finance.SDF_Udef3))
         {
            idb.AddParameter("@SDF_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDF_Udef3", sD_Finance.SDF_Udef3);
         }
          }

         idb.AddParameter("@SDF_ID", sD_Finance.SDF_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除SD_Finance对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDF_ID)
      {
         string sql = "DELETE SD_Finance WHERE 1=1  AND SDF_ID=@SDF_ID ";
         idb.AddParameter("@SDF_ID", sDF_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的SD_Finance对象(即:一条记录
      /// </summary>
      public SD_Finance GetByKey(decimal sDF_ID)
      {
         SD_Finance sD_Finance = new SD_Finance();
         string sql = "SELECT  SDF_ID,SDF_Code,SDF_ContractCode,SDF_Customer,SDF_CustomerName,SDF_ContractDetail,SDF_CmdCode,SDF_PartNo,SDF_PartName,SDF_NodeCode,SDF_NodeName,SDF_Value,SDF_ProdType,SDF_Stat,Stat,CreatTime,SDF_Udef1,SDF_Udef2,SDF_Udef3 FROM SD_Finance WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDF_ID=@SDF_ID ";
         idb.AddParameter("@SDF_ID", sDF_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDF_ID"] != DBNull.Value) sD_Finance.SDF_ID = Convert.ToDecimal(dr["SDF_ID"]);
            if (dr["SDF_Code"] != DBNull.Value) sD_Finance.SDF_Code = Convert.ToString(dr["SDF_Code"]);
            if (dr["SDF_ContractCode"] != DBNull.Value) sD_Finance.SDF_ContractCode = Convert.ToString(dr["SDF_ContractCode"]);
            if (dr["SDF_Customer"] != DBNull.Value) sD_Finance.SDF_Customer = Convert.ToString(dr["SDF_Customer"]);
            if (dr["SDF_CustomerName"] != DBNull.Value) sD_Finance.SDF_CustomerName = Convert.ToString(dr["SDF_CustomerName"]);
            if (dr["SDF_ContractDetail"] != DBNull.Value) sD_Finance.SDF_ContractDetail = Convert.ToString(dr["SDF_ContractDetail"]);
            if (dr["SDF_CmdCode"] != DBNull.Value) sD_Finance.SDF_CmdCode = Convert.ToString(dr["SDF_CmdCode"]);
            if (dr["SDF_PartNo"] != DBNull.Value) sD_Finance.SDF_PartNo = Convert.ToString(dr["SDF_PartNo"]);
            if (dr["SDF_PartName"] != DBNull.Value) sD_Finance.SDF_PartName = Convert.ToString(dr["SDF_PartName"]);
            if (dr["SDF_NodeCode"] != DBNull.Value) sD_Finance.SDF_NodeCode = Convert.ToString(dr["SDF_NodeCode"]);
            if (dr["SDF_NodeName"] != DBNull.Value) sD_Finance.SDF_NodeName = Convert.ToString(dr["SDF_NodeName"]);
            if (dr["SDF_Value"] != DBNull.Value) sD_Finance.SDF_Value = Convert.ToDecimal(dr["SDF_Value"]);
            if (dr["SDF_ProdType"] != DBNull.Value) sD_Finance.SDF_ProdType = Convert.ToString(dr["SDF_ProdType"]);
            if (dr["SDF_Stat"] != DBNull.Value) sD_Finance.SDF_Stat = Convert.ToString(dr["SDF_Stat"]);
            if (dr["Stat"] != DBNull.Value) sD_Finance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreatTime"] != DBNull.Value) sD_Finance.CreatTime = Convert.ToDateTime(dr["CreatTime"]);
            if (dr["SDF_Udef1"] != DBNull.Value) sD_Finance.SDF_Udef1 = Convert.ToString(dr["SDF_Udef1"]);
            if (dr["SDF_Udef2"] != DBNull.Value) sD_Finance.SDF_Udef2 = Convert.ToString(dr["SDF_Udef2"]);
            if (dr["SDF_Udef3"] != DBNull.Value) sD_Finance.SDF_Udef3 = Convert.ToString(dr["SDF_Udef3"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Finance;
      }
      /// <summary>
      /// 获取指定的SD_Finance对象集合
      /// </summary>
      public List<SD_Finance> GetListByWhere(string strCondition)
      {
         List<SD_Finance> ret = new List<SD_Finance>();
         string sql = "SELECT  SDF_ID,SDF_Code,SDF_ContractCode,SDF_Customer,SDF_CustomerName,SDF_ContractDetail,SDF_CmdCode,SDF_PartNo,SDF_PartName,SDF_NodeCode,SDF_NodeName,SDF_Value,SDF_ProdType,SDF_Stat,Stat,CreatTime,SDF_Udef1,SDF_Udef2,SDF_Udef3 FROM SD_Finance WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Finance sD_Finance = new SD_Finance();
            if (dr["SDF_ID"] != DBNull.Value) sD_Finance.SDF_ID = Convert.ToDecimal(dr["SDF_ID"]);
            if (dr["SDF_Code"] != DBNull.Value) sD_Finance.SDF_Code = Convert.ToString(dr["SDF_Code"]);
            if (dr["SDF_ContractCode"] != DBNull.Value) sD_Finance.SDF_ContractCode = Convert.ToString(dr["SDF_ContractCode"]);
            if (dr["SDF_Customer"] != DBNull.Value) sD_Finance.SDF_Customer = Convert.ToString(dr["SDF_Customer"]);
            if (dr["SDF_CustomerName"] != DBNull.Value) sD_Finance.SDF_CustomerName = Convert.ToString(dr["SDF_CustomerName"]);
            if (dr["SDF_ContractDetail"] != DBNull.Value) sD_Finance.SDF_ContractDetail = Convert.ToString(dr["SDF_ContractDetail"]);
            if (dr["SDF_CmdCode"] != DBNull.Value) sD_Finance.SDF_CmdCode = Convert.ToString(dr["SDF_CmdCode"]);
            if (dr["SDF_PartNo"] != DBNull.Value) sD_Finance.SDF_PartNo = Convert.ToString(dr["SDF_PartNo"]);
            if (dr["SDF_PartName"] != DBNull.Value) sD_Finance.SDF_PartName = Convert.ToString(dr["SDF_PartName"]);
            if (dr["SDF_NodeCode"] != DBNull.Value) sD_Finance.SDF_NodeCode = Convert.ToString(dr["SDF_NodeCode"]);
            if (dr["SDF_NodeName"] != DBNull.Value) sD_Finance.SDF_NodeName = Convert.ToString(dr["SDF_NodeName"]);
            if (dr["SDF_Value"] != DBNull.Value) sD_Finance.SDF_Value = Convert.ToDecimal(dr["SDF_Value"]);
            if (dr["SDF_ProdType"] != DBNull.Value) sD_Finance.SDF_ProdType = Convert.ToString(dr["SDF_ProdType"]);
            if (dr["SDF_Stat"] != DBNull.Value) sD_Finance.SDF_Stat = Convert.ToString(dr["SDF_Stat"]);
            if (dr["Stat"] != DBNull.Value) sD_Finance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreatTime"] != DBNull.Value) sD_Finance.CreatTime = Convert.ToDateTime(dr["CreatTime"]);
            if (dr["SDF_Udef1"] != DBNull.Value) sD_Finance.SDF_Udef1 = Convert.ToString(dr["SDF_Udef1"]);
            if (dr["SDF_Udef2"] != DBNull.Value) sD_Finance.SDF_Udef2 = Convert.ToString(dr["SDF_Udef2"]);
            if (dr["SDF_Udef3"] != DBNull.Value) sD_Finance.SDF_Udef3 = Convert.ToString(dr["SDF_Udef3"]);
            ret.Add(sD_Finance);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的SD_Finance对象(即:一条记录
      /// </summary>
      public List<SD_Finance> GetAll()
      {
         List<SD_Finance> ret = new List<SD_Finance>();
         string sql = "SELECT  SDF_ID,SDF_Code,SDF_ContractCode,SDF_Customer,SDF_CustomerName,SDF_ContractDetail,SDF_CmdCode,SDF_PartNo,SDF_PartName,SDF_NodeCode,SDF_NodeName,SDF_Value,SDF_ProdType,SDF_Stat,Stat,CreatTime,SDF_Udef1,SDF_Udef2,SDF_Udef3 FROM SD_Finance where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Finance sD_Finance = new SD_Finance();
            if (dr["SDF_ID"] != DBNull.Value) sD_Finance.SDF_ID = Convert.ToDecimal(dr["SDF_ID"]);
            if (dr["SDF_Code"] != DBNull.Value) sD_Finance.SDF_Code = Convert.ToString(dr["SDF_Code"]);
            if (dr["SDF_ContractCode"] != DBNull.Value) sD_Finance.SDF_ContractCode = Convert.ToString(dr["SDF_ContractCode"]);
            if (dr["SDF_Customer"] != DBNull.Value) sD_Finance.SDF_Customer = Convert.ToString(dr["SDF_Customer"]);
            if (dr["SDF_CustomerName"] != DBNull.Value) sD_Finance.SDF_CustomerName = Convert.ToString(dr["SDF_CustomerName"]);
            if (dr["SDF_ContractDetail"] != DBNull.Value) sD_Finance.SDF_ContractDetail = Convert.ToString(dr["SDF_ContractDetail"]);
            if (dr["SDF_CmdCode"] != DBNull.Value) sD_Finance.SDF_CmdCode = Convert.ToString(dr["SDF_CmdCode"]);
            if (dr["SDF_PartNo"] != DBNull.Value) sD_Finance.SDF_PartNo = Convert.ToString(dr["SDF_PartNo"]);
            if (dr["SDF_PartName"] != DBNull.Value) sD_Finance.SDF_PartName = Convert.ToString(dr["SDF_PartName"]);
            if (dr["SDF_NodeCode"] != DBNull.Value) sD_Finance.SDF_NodeCode = Convert.ToString(dr["SDF_NodeCode"]);
            if (dr["SDF_NodeName"] != DBNull.Value) sD_Finance.SDF_NodeName = Convert.ToString(dr["SDF_NodeName"]);
            if (dr["SDF_Value"] != DBNull.Value) sD_Finance.SDF_Value = Convert.ToDecimal(dr["SDF_Value"]);
            if (dr["SDF_ProdType"] != DBNull.Value) sD_Finance.SDF_ProdType = Convert.ToString(dr["SDF_ProdType"]);
            if (dr["SDF_Stat"] != DBNull.Value) sD_Finance.SDF_Stat = Convert.ToString(dr["SDF_Stat"]);
            if (dr["Stat"] != DBNull.Value) sD_Finance.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreatTime"] != DBNull.Value) sD_Finance.CreatTime = Convert.ToDateTime(dr["CreatTime"]);
            if (dr["SDF_Udef1"] != DBNull.Value) sD_Finance.SDF_Udef1 = Convert.ToString(dr["SDF_Udef1"]);
            if (dr["SDF_Udef2"] != DBNull.Value) sD_Finance.SDF_Udef2 = Convert.ToString(dr["SDF_Udef2"]);
            if (dr["SDF_Udef3"] != DBNull.Value) sD_Finance.SDF_Udef3 = Convert.ToString(dr["SDF_Udef3"]);
            ret.Add(sD_Finance);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
