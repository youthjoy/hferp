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
   public partial class ADOSD_ContractTrace
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加SD_ContractTrace对象(即:一条记录)
      /// </summary>
      public int Add(SD_ContractTrace sD_ContractTrace)
      {
         string sql = "INSERT INTO SD_ContractTrace (SDT_Code,SDT_MainCode,SDT_ContractCode,SDT_PartNo,SDT_PartName,SDT_ODate,SDT_Num,SDT_Owner,SDT_OwnerName,SDT_Remark,SDT_FOwner,SDT_FOwnerName,Stat,SDT_ProdCode) VALUES (@SDT_Code,@SDT_MainCode,@SDT_ContractCode,@SDT_PartNo,@SDT_PartName,@SDT_ODate,@SDT_Num,@SDT_Owner,@SDT_OwnerName,@SDT_Remark,@SDT_FOwner,@SDT_FOwnerName,@Stat,@SDT_ProdCode)";
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Code))
         {
            idb.AddParameter("@SDT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Code", sD_ContractTrace.SDT_Code);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_MainCode))
         {
            idb.AddParameter("@SDT_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_MainCode", sD_ContractTrace.SDT_MainCode);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_ContractCode))
         {
            idb.AddParameter("@SDT_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ContractCode", sD_ContractTrace.SDT_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_PartNo))
         {
            idb.AddParameter("@SDT_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PartNo", sD_ContractTrace.SDT_PartNo);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_PartName))
         {
            idb.AddParameter("@SDT_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PartName", sD_ContractTrace.SDT_PartName);
         }
         if (sD_ContractTrace.SDT_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ODate", sD_ContractTrace.SDT_ODate);
         }
         if (sD_ContractTrace.SDT_Num == 0)
         {
            idb.AddParameter("@SDT_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Num", sD_ContractTrace.SDT_Num);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Owner))
         {
            idb.AddParameter("@SDT_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Owner", sD_ContractTrace.SDT_Owner);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_OwnerName))
         {
            idb.AddParameter("@SDT_OwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_OwnerName", sD_ContractTrace.SDT_OwnerName);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Remark))
         {
            idb.AddParameter("@SDT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Remark", sD_ContractTrace.SDT_Remark);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_FOwner))
         {
            idb.AddParameter("@SDT_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_FOwner", sD_ContractTrace.SDT_FOwner);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_FOwnerName))
         {
            idb.AddParameter("@SDT_FOwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_FOwnerName", sD_ContractTrace.SDT_FOwnerName);
         }
         if (sD_ContractTrace.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ContractTrace.Stat);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_ProdCode))
         {
            idb.AddParameter("@SDT_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ProdCode", sD_ContractTrace.SDT_ProdCode);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加SD_ContractTrace对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_ContractTrace sD_ContractTrace)
      {
         string sql = "INSERT INTO SD_ContractTrace (SDT_Code,SDT_MainCode,SDT_ContractCode,SDT_PartNo,SDT_PartName,SDT_ODate,SDT_Num,SDT_Owner,SDT_OwnerName,SDT_Remark,SDT_FOwner,SDT_FOwnerName,Stat,SDT_ProdCode) VALUES (@SDT_Code,@SDT_MainCode,@SDT_ContractCode,@SDT_PartNo,@SDT_PartName,@SDT_ODate,@SDT_Num,@SDT_Owner,@SDT_OwnerName,@SDT_Remark,@SDT_FOwner,@SDT_FOwnerName,@Stat,@SDT_ProdCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Code))
         {
            idb.AddParameter("@SDT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Code", sD_ContractTrace.SDT_Code);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_MainCode))
         {
            idb.AddParameter("@SDT_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_MainCode", sD_ContractTrace.SDT_MainCode);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_ContractCode))
         {
            idb.AddParameter("@SDT_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ContractCode", sD_ContractTrace.SDT_ContractCode);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_PartNo))
         {
            idb.AddParameter("@SDT_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PartNo", sD_ContractTrace.SDT_PartNo);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_PartName))
         {
            idb.AddParameter("@SDT_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PartName", sD_ContractTrace.SDT_PartName);
         }
         if (sD_ContractTrace.SDT_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ODate", sD_ContractTrace.SDT_ODate);
         }
         if (sD_ContractTrace.SDT_Num == 0)
         {
            idb.AddParameter("@SDT_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Num", sD_ContractTrace.SDT_Num);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Owner))
         {
            idb.AddParameter("@SDT_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Owner", sD_ContractTrace.SDT_Owner);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_OwnerName))
         {
            idb.AddParameter("@SDT_OwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_OwnerName", sD_ContractTrace.SDT_OwnerName);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Remark))
         {
            idb.AddParameter("@SDT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Remark", sD_ContractTrace.SDT_Remark);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_FOwner))
         {
            idb.AddParameter("@SDT_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_FOwner", sD_ContractTrace.SDT_FOwner);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_FOwnerName))
         {
            idb.AddParameter("@SDT_FOwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_FOwnerName", sD_ContractTrace.SDT_FOwnerName);
         }
         if (sD_ContractTrace.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ContractTrace.Stat);
         }
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_ProdCode))
         {
            idb.AddParameter("@SDT_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ProdCode", sD_ContractTrace.SDT_ProdCode);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新SD_ContractTrace对象(即:一条记录
      /// </summary>
      public int Update(SD_ContractTrace sD_ContractTrace)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_ContractTrace       SET ");
            if(sD_ContractTrace.SDT_Code_IsChanged){sbParameter.Append("SDT_Code=@SDT_Code, ");}
      if(sD_ContractTrace.SDT_MainCode_IsChanged){sbParameter.Append("SDT_MainCode=@SDT_MainCode, ");}
      if(sD_ContractTrace.SDT_ContractCode_IsChanged){sbParameter.Append("SDT_ContractCode=@SDT_ContractCode, ");}
      if(sD_ContractTrace.SDT_PartNo_IsChanged){sbParameter.Append("SDT_PartNo=@SDT_PartNo, ");}
      if(sD_ContractTrace.SDT_PartName_IsChanged){sbParameter.Append("SDT_PartName=@SDT_PartName, ");}
      if(sD_ContractTrace.SDT_ODate_IsChanged){sbParameter.Append("SDT_ODate=@SDT_ODate, ");}
      if(sD_ContractTrace.SDT_Num_IsChanged){sbParameter.Append("SDT_Num=@SDT_Num, ");}
      if(sD_ContractTrace.SDT_Owner_IsChanged){sbParameter.Append("SDT_Owner=@SDT_Owner, ");}
      if(sD_ContractTrace.SDT_OwnerName_IsChanged){sbParameter.Append("SDT_OwnerName=@SDT_OwnerName, ");}
      if(sD_ContractTrace.SDT_Remark_IsChanged){sbParameter.Append("SDT_Remark=@SDT_Remark, ");}
      if(sD_ContractTrace.SDT_FOwner_IsChanged){sbParameter.Append("SDT_FOwner=@SDT_FOwner, ");}
      if(sD_ContractTrace.SDT_FOwnerName_IsChanged){sbParameter.Append("SDT_FOwnerName=@SDT_FOwnerName, ");}
      if(sD_ContractTrace.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_ContractTrace.SDT_ProdCode_IsChanged){sbParameter.Append("SDT_ProdCode=@SDT_ProdCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and SDT_ID=@SDT_ID; " );
      string sql=sb.ToString();
         if(sD_ContractTrace.SDT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Code))
         {
            idb.AddParameter("@SDT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Code", sD_ContractTrace.SDT_Code);
         }
          }
         if(sD_ContractTrace.SDT_MainCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_MainCode))
         {
            idb.AddParameter("@SDT_MainCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_MainCode", sD_ContractTrace.SDT_MainCode);
         }
          }
         if(sD_ContractTrace.SDT_ContractCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_ContractCode))
         {
            idb.AddParameter("@SDT_ContractCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ContractCode", sD_ContractTrace.SDT_ContractCode);
         }
          }
         if(sD_ContractTrace.SDT_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_PartNo))
         {
            idb.AddParameter("@SDT_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PartNo", sD_ContractTrace.SDT_PartNo);
         }
          }
         if(sD_ContractTrace.SDT_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_PartName))
         {
            idb.AddParameter("@SDT_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_PartName", sD_ContractTrace.SDT_PartName);
         }
          }
         if(sD_ContractTrace.SDT_ODate_IsChanged)
         {
         if (sD_ContractTrace.SDT_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@SDT_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ODate", sD_ContractTrace.SDT_ODate);
         }
          }
         if(sD_ContractTrace.SDT_Num_IsChanged)
         {
         if (sD_ContractTrace.SDT_Num == 0)
         {
            idb.AddParameter("@SDT_Num", 0);
         }
         else
         {
            idb.AddParameter("@SDT_Num", sD_ContractTrace.SDT_Num);
         }
          }
         if(sD_ContractTrace.SDT_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Owner))
         {
            idb.AddParameter("@SDT_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Owner", sD_ContractTrace.SDT_Owner);
         }
          }
         if(sD_ContractTrace.SDT_OwnerName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_OwnerName))
         {
            idb.AddParameter("@SDT_OwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_OwnerName", sD_ContractTrace.SDT_OwnerName);
         }
          }
         if(sD_ContractTrace.SDT_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_Remark))
         {
            idb.AddParameter("@SDT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_Remark", sD_ContractTrace.SDT_Remark);
         }
          }
         if(sD_ContractTrace.SDT_FOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_FOwner))
         {
            idb.AddParameter("@SDT_FOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_FOwner", sD_ContractTrace.SDT_FOwner);
         }
          }
         if(sD_ContractTrace.SDT_FOwnerName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_FOwnerName))
         {
            idb.AddParameter("@SDT_FOwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_FOwnerName", sD_ContractTrace.SDT_FOwnerName);
         }
          }
         if(sD_ContractTrace.Stat_IsChanged)
         {
         if (sD_ContractTrace.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_ContractTrace.Stat);
         }
          }
         if(sD_ContractTrace.SDT_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_ContractTrace.SDT_ProdCode))
         {
            idb.AddParameter("@SDT_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@SDT_ProdCode", sD_ContractTrace.SDT_ProdCode);
         }
          }

         idb.AddParameter("@SDT_ID", sD_ContractTrace.SDT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除SD_ContractTrace对象(即:一条记录
      /// </summary>
      public int Delete(decimal sDT_ID)
      {
         string sql = "DELETE SD_ContractTrace WHERE 1=1  AND SDT_ID=@SDT_ID ";
         idb.AddParameter("@SDT_ID", sDT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的SD_ContractTrace对象(即:一条记录
      /// </summary>
      public SD_ContractTrace GetByKey(decimal sDT_ID)
      {
         SD_ContractTrace sD_ContractTrace = new SD_ContractTrace();
         string sql = "SELECT  SDT_ID,SDT_Code,SDT_MainCode,SDT_ContractCode,SDT_PartNo,SDT_PartName,SDT_ODate,SDT_Num,SDT_Owner,SDT_OwnerName,SDT_Remark,SDT_FOwner,SDT_FOwnerName,Stat,SDT_ProdCode FROM SD_ContractTrace WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND SDT_ID=@SDT_ID ";
         idb.AddParameter("@SDT_ID", sDT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["SDT_ID"] != DBNull.Value) sD_ContractTrace.SDT_ID = Convert.ToDecimal(dr["SDT_ID"]);
            if (dr["SDT_Code"] != DBNull.Value) sD_ContractTrace.SDT_Code = Convert.ToString(dr["SDT_Code"]);
            if (dr["SDT_MainCode"] != DBNull.Value) sD_ContractTrace.SDT_MainCode = Convert.ToString(dr["SDT_MainCode"]);
            if (dr["SDT_ContractCode"] != DBNull.Value) sD_ContractTrace.SDT_ContractCode = Convert.ToString(dr["SDT_ContractCode"]);
            if (dr["SDT_PartNo"] != DBNull.Value) sD_ContractTrace.SDT_PartNo = Convert.ToString(dr["SDT_PartNo"]);
            if (dr["SDT_PartName"] != DBNull.Value) sD_ContractTrace.SDT_PartName = Convert.ToString(dr["SDT_PartName"]);
            if (dr["SDT_ODate"] != DBNull.Value) sD_ContractTrace.SDT_ODate = Convert.ToDateTime(dr["SDT_ODate"]);
            if (dr["SDT_Num"] != DBNull.Value) sD_ContractTrace.SDT_Num = Convert.ToInt32(dr["SDT_Num"]);
            if (dr["SDT_Owner"] != DBNull.Value) sD_ContractTrace.SDT_Owner = Convert.ToString(dr["SDT_Owner"]);
            if (dr["SDT_OwnerName"] != DBNull.Value) sD_ContractTrace.SDT_OwnerName = Convert.ToString(dr["SDT_OwnerName"]);
            if (dr["SDT_Remark"] != DBNull.Value) sD_ContractTrace.SDT_Remark = Convert.ToString(dr["SDT_Remark"]);
            if (dr["SDT_FOwner"] != DBNull.Value) sD_ContractTrace.SDT_FOwner = Convert.ToString(dr["SDT_FOwner"]);
            if (dr["SDT_FOwnerName"] != DBNull.Value) sD_ContractTrace.SDT_FOwnerName = Convert.ToString(dr["SDT_FOwnerName"]);
            if (dr["Stat"] != DBNull.Value) sD_ContractTrace.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDT_ProdCode"] != DBNull.Value) sD_ContractTrace.SDT_ProdCode = Convert.ToString(dr["SDT_ProdCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_ContractTrace;
      }
      /// <summary>
      /// 获取指定的SD_ContractTrace对象集合
      /// </summary>
      public List<SD_ContractTrace> GetListByWhere(string strCondition)
      {
         List<SD_ContractTrace> ret = new List<SD_ContractTrace>();
         string sql = "SELECT  SDT_ID,SDT_Code,SDT_MainCode,SDT_ContractCode,SDT_PartNo,SDT_PartName,SDT_ODate,SDT_Num,SDT_Owner,SDT_OwnerName,SDT_Remark,SDT_FOwner,SDT_FOwnerName,Stat,SDT_ProdCode FROM SD_ContractTrace WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_ContractTrace sD_ContractTrace = new SD_ContractTrace();
            if (dr["SDT_ID"] != DBNull.Value) sD_ContractTrace.SDT_ID = Convert.ToDecimal(dr["SDT_ID"]);
            if (dr["SDT_Code"] != DBNull.Value) sD_ContractTrace.SDT_Code = Convert.ToString(dr["SDT_Code"]);
            if (dr["SDT_MainCode"] != DBNull.Value) sD_ContractTrace.SDT_MainCode = Convert.ToString(dr["SDT_MainCode"]);
            if (dr["SDT_ContractCode"] != DBNull.Value) sD_ContractTrace.SDT_ContractCode = Convert.ToString(dr["SDT_ContractCode"]);
            if (dr["SDT_PartNo"] != DBNull.Value) sD_ContractTrace.SDT_PartNo = Convert.ToString(dr["SDT_PartNo"]);
            if (dr["SDT_PartName"] != DBNull.Value) sD_ContractTrace.SDT_PartName = Convert.ToString(dr["SDT_PartName"]);
            if (dr["SDT_ODate"] != DBNull.Value) sD_ContractTrace.SDT_ODate = Convert.ToDateTime(dr["SDT_ODate"]);
            if (dr["SDT_Num"] != DBNull.Value) sD_ContractTrace.SDT_Num = Convert.ToInt32(dr["SDT_Num"]);
            if (dr["SDT_Owner"] != DBNull.Value) sD_ContractTrace.SDT_Owner = Convert.ToString(dr["SDT_Owner"]);
            if (dr["SDT_OwnerName"] != DBNull.Value) sD_ContractTrace.SDT_OwnerName = Convert.ToString(dr["SDT_OwnerName"]);
            if (dr["SDT_Remark"] != DBNull.Value) sD_ContractTrace.SDT_Remark = Convert.ToString(dr["SDT_Remark"]);
            if (dr["SDT_FOwner"] != DBNull.Value) sD_ContractTrace.SDT_FOwner = Convert.ToString(dr["SDT_FOwner"]);
            if (dr["SDT_FOwnerName"] != DBNull.Value) sD_ContractTrace.SDT_FOwnerName = Convert.ToString(dr["SDT_FOwnerName"]);
            if (dr["Stat"] != DBNull.Value) sD_ContractTrace.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDT_ProdCode"] != DBNull.Value) sD_ContractTrace.SDT_ProdCode = Convert.ToString(dr["SDT_ProdCode"]);
            ret.Add(sD_ContractTrace);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的SD_ContractTrace对象(即:一条记录
      /// </summary>
      public List<SD_ContractTrace> GetAll()
      {
         List<SD_ContractTrace> ret = new List<SD_ContractTrace>();
         string sql = "SELECT  SDT_ID,SDT_Code,SDT_MainCode,SDT_ContractCode,SDT_PartNo,SDT_PartName,SDT_ODate,SDT_Num,SDT_Owner,SDT_OwnerName,SDT_Remark,SDT_FOwner,SDT_FOwnerName,Stat,SDT_ProdCode FROM SD_ContractTrace where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_ContractTrace sD_ContractTrace = new SD_ContractTrace();
            if (dr["SDT_ID"] != DBNull.Value) sD_ContractTrace.SDT_ID = Convert.ToDecimal(dr["SDT_ID"]);
            if (dr["SDT_Code"] != DBNull.Value) sD_ContractTrace.SDT_Code = Convert.ToString(dr["SDT_Code"]);
            if (dr["SDT_MainCode"] != DBNull.Value) sD_ContractTrace.SDT_MainCode = Convert.ToString(dr["SDT_MainCode"]);
            if (dr["SDT_ContractCode"] != DBNull.Value) sD_ContractTrace.SDT_ContractCode = Convert.ToString(dr["SDT_ContractCode"]);
            if (dr["SDT_PartNo"] != DBNull.Value) sD_ContractTrace.SDT_PartNo = Convert.ToString(dr["SDT_PartNo"]);
            if (dr["SDT_PartName"] != DBNull.Value) sD_ContractTrace.SDT_PartName = Convert.ToString(dr["SDT_PartName"]);
            if (dr["SDT_ODate"] != DBNull.Value) sD_ContractTrace.SDT_ODate = Convert.ToDateTime(dr["SDT_ODate"]);
            if (dr["SDT_Num"] != DBNull.Value) sD_ContractTrace.SDT_Num = Convert.ToInt32(dr["SDT_Num"]);
            if (dr["SDT_Owner"] != DBNull.Value) sD_ContractTrace.SDT_Owner = Convert.ToString(dr["SDT_Owner"]);
            if (dr["SDT_OwnerName"] != DBNull.Value) sD_ContractTrace.SDT_OwnerName = Convert.ToString(dr["SDT_OwnerName"]);
            if (dr["SDT_Remark"] != DBNull.Value) sD_ContractTrace.SDT_Remark = Convert.ToString(dr["SDT_Remark"]);
            if (dr["SDT_FOwner"] != DBNull.Value) sD_ContractTrace.SDT_FOwner = Convert.ToString(dr["SDT_FOwner"]);
            if (dr["SDT_FOwnerName"] != DBNull.Value) sD_ContractTrace.SDT_FOwnerName = Convert.ToString(dr["SDT_FOwnerName"]);
            if (dr["Stat"] != DBNull.Value) sD_ContractTrace.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["SDT_ProdCode"] != DBNull.Value) sD_ContractTrace.SDT_ProdCode = Convert.ToString(dr["SDT_ProdCode"]);
            ret.Add(sD_ContractTrace);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
