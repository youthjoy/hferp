using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;

namespace QX.DataAceess
{
   [Serializable]
   public partial class ADOFailure_Process
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Failure_Process对象(即:一条记录)
      /// </summary>
      public int Add(Failure_Process failure_Process)
      {
         string sql = "INSERT INTO Failure_Process (FProcess_ID,FInfo_ID,FProcess_ProdCode,FProcess_PartNo,FProcess_PartName,FProcess_Key,FProcess_RespPep,FProcess_RespSup,FProcess_Introduction,FProcess_Method,FProcess_Owner,FProcess_Date) VALUES (@FProcess_ID,@FInfo_ID,@FProcess_ProdCode,@FProcess_PartNo,@FProcess_PartName,@FProcess_Key,@FProcess_RespPep,@FProcess_RespSup,@FProcess_Introduction,@FProcess_Method,@FProcess_Owner,@FProcess_Date)";
         if (failure_Process.FInfo_ID == 0)
         {
            idb.AddParameter("@FInfo_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ID", failure_Process.FInfo_ID);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_ProdCode))
         {
            idb.AddParameter("@FProcess_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_ProdCode", failure_Process.FProcess_ProdCode);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_PartNo))
         {
            idb.AddParameter("@FProcess_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_PartNo", failure_Process.FProcess_PartNo);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_PartName))
         {
            idb.AddParameter("@FProcess_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_PartName", failure_Process.FProcess_PartName);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Key))
         {
            idb.AddParameter("@FProcess_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Key", failure_Process.FProcess_Key);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_RespPep))
         {
            idb.AddParameter("@FProcess_RespPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_RespPep", failure_Process.FProcess_RespPep);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_RespSup))
         {
            idb.AddParameter("@FProcess_RespSup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_RespSup", failure_Process.FProcess_RespSup);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Introduction))
         {
            idb.AddParameter("@FProcess_Introduction", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Introduction", failure_Process.FProcess_Introduction);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Method))
         {
            idb.AddParameter("@FProcess_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Method", failure_Process.FProcess_Method);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Owner))
         {
            idb.AddParameter("@FProcess_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Owner", failure_Process.FProcess_Owner);
         }
         if (failure_Process.FProcess_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FProcess_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Date", failure_Process.FProcess_Date);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Failure_Process对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Failure_Process failure_Process)
      {
         string sql = "INSERT INTO Failure_Process (FProcess_ID,FInfo_ID,FProcess_ProdCode,FProcess_PartNo,FProcess_PartName,FProcess_Key,FProcess_RespPep,FProcess_RespSup,FProcess_Introduction,FProcess_Method,FProcess_Owner,FProcess_Date) VALUES (@FProcess_ID,@FInfo_ID,@FProcess_ProdCode,@FProcess_PartNo,@FProcess_PartName,@FProcess_Key,@FProcess_RespPep,@FProcess_RespSup,@FProcess_Introduction,@FProcess_Method,@FProcess_Owner,@FProcess_Date);SELECT @@IDENTITY AS ReturnID;";
         if (failure_Process.FInfo_ID == 0)
         {
            idb.AddParameter("@FInfo_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ID", failure_Process.FInfo_ID);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_ProdCode))
         {
            idb.AddParameter("@FProcess_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_ProdCode", failure_Process.FProcess_ProdCode);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_PartNo))
         {
            idb.AddParameter("@FProcess_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_PartNo", failure_Process.FProcess_PartNo);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_PartName))
         {
            idb.AddParameter("@FProcess_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_PartName", failure_Process.FProcess_PartName);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Key))
         {
            idb.AddParameter("@FProcess_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Key", failure_Process.FProcess_Key);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_RespPep))
         {
            idb.AddParameter("@FProcess_RespPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_RespPep", failure_Process.FProcess_RespPep);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_RespSup))
         {
            idb.AddParameter("@FProcess_RespSup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_RespSup", failure_Process.FProcess_RespSup);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Introduction))
         {
            idb.AddParameter("@FProcess_Introduction", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Introduction", failure_Process.FProcess_Introduction);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Method))
         {
            idb.AddParameter("@FProcess_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Method", failure_Process.FProcess_Method);
         }
         if (string.IsNullOrEmpty(failure_Process.FProcess_Owner))
         {
            idb.AddParameter("@FProcess_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Owner", failure_Process.FProcess_Owner);
         }
         if (failure_Process.FProcess_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FProcess_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Date", failure_Process.FProcess_Date);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新Failure_Process对象(即:一条记录
      /// </summary>
      public int Update(Failure_Process failure_Process)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Failure_Process       SET ");
            if(failure_Process.FInfo_ID_IsChanged){sbParameter.Append("FInfo_ID=@FInfo_ID, ");}
      if(failure_Process.FProcess_ProdCode_IsChanged){sbParameter.Append("FProcess_ProdCode=@FProcess_ProdCode, ");}
      if(failure_Process.FProcess_PartNo_IsChanged){sbParameter.Append("FProcess_PartNo=@FProcess_PartNo, ");}
      if(failure_Process.FProcess_PartName_IsChanged){sbParameter.Append("FProcess_PartName=@FProcess_PartName, ");}
      if(failure_Process.FProcess_Key_IsChanged){sbParameter.Append("FProcess_Key=@FProcess_Key, ");}
      if(failure_Process.FProcess_RespPep_IsChanged){sbParameter.Append("FProcess_RespPep=@FProcess_RespPep, ");}
      if(failure_Process.FProcess_RespSup_IsChanged){sbParameter.Append("FProcess_RespSup=@FProcess_RespSup, ");}
      if(failure_Process.FProcess_Introduction_IsChanged){sbParameter.Append("FProcess_Introduction=@FProcess_Introduction, ");}
      if(failure_Process.FProcess_Method_IsChanged){sbParameter.Append("FProcess_Method=@FProcess_Method, ");}
      if(failure_Process.FProcess_Owner_IsChanged){sbParameter.Append("FProcess_Owner=@FProcess_Owner, ");}
      if(failure_Process.FProcess_Date_IsChanged){sbParameter.Append("FProcess_Date=@FProcess_Date ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FProcess_ID=@FProcess_ID; " );
      string sql=sb.ToString();
         if(failure_Process.FInfo_ID_IsChanged)
         {
         if (failure_Process.FInfo_ID == 0)
         {
            idb.AddParameter("@FInfo_ID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FInfo_ID", failure_Process.FInfo_ID);
         }
          }
         if(failure_Process.FProcess_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_ProdCode))
         {
            idb.AddParameter("@FProcess_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_ProdCode", failure_Process.FProcess_ProdCode);
         }
          }
         if(failure_Process.FProcess_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_PartNo))
         {
            idb.AddParameter("@FProcess_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_PartNo", failure_Process.FProcess_PartNo);
         }
          }
         if(failure_Process.FProcess_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_PartName))
         {
            idb.AddParameter("@FProcess_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_PartName", failure_Process.FProcess_PartName);
         }
          }
         if(failure_Process.FProcess_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_Key))
         {
            idb.AddParameter("@FProcess_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Key", failure_Process.FProcess_Key);
         }
          }
         if(failure_Process.FProcess_RespPep_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_RespPep))
         {
            idb.AddParameter("@FProcess_RespPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_RespPep", failure_Process.FProcess_RespPep);
         }
          }
         if(failure_Process.FProcess_RespSup_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_RespSup))
         {
            idb.AddParameter("@FProcess_RespSup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_RespSup", failure_Process.FProcess_RespSup);
         }
          }
         if(failure_Process.FProcess_Introduction_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_Introduction))
         {
            idb.AddParameter("@FProcess_Introduction", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Introduction", failure_Process.FProcess_Introduction);
         }
          }
         if(failure_Process.FProcess_Method_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_Method))
         {
            idb.AddParameter("@FProcess_Method", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Method", failure_Process.FProcess_Method);
         }
          }
         if(failure_Process.FProcess_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Process.FProcess_Owner))
         {
            idb.AddParameter("@FProcess_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Owner", failure_Process.FProcess_Owner);
         }
          }
         if(failure_Process.FProcess_Date_IsChanged)
         {
         if (failure_Process.FProcess_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FProcess_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FProcess_Date", failure_Process.FProcess_Date);
         }
          }

         idb.AddParameter("@FProcess_ID", failure_Process.FProcess_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Failure_Process对象(即:一条记录
      /// </summary>
      public int Delete(Int64 fProcess_ID)
      {
         string sql = "DELETE Failure_Process WHERE 1=1  AND FProcess_ID=@FProcess_ID ";
         idb.AddParameter("@FProcess_ID", fProcess_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Failure_Process对象(即:一条记录
      /// </summary>
      public Failure_Process GetByKey(Int64 fProcess_ID)
      {
         Failure_Process failure_Process = new Failure_Process();
         string sql = "SELECT  FProcess_ID,FInfo_ID,FProcess_ProdCode,FProcess_PartNo,FProcess_PartName,FProcess_Key,FProcess_RespPep,FProcess_RespSup,FProcess_Introduction,FProcess_Method,FProcess_Owner,FProcess_Date FROM Failure_Process WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FProcess_ID=@FProcess_ID ";
         idb.AddParameter("@FProcess_ID", fProcess_ID);

         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FProcess_ID"] != DBNull.Value) failure_Process.FProcess_ID = Convert.ToInt64(dr["FProcess_ID"]);
            if (dr["FInfo_ID"] != DBNull.Value) failure_Process.FInfo_ID = Convert.ToInt64(dr["FInfo_ID"]);
            if (dr["FProcess_ProdCode"] != DBNull.Value) failure_Process.FProcess_ProdCode = Convert.ToString(dr["FProcess_ProdCode"]);
            if (dr["FProcess_PartNo"] != DBNull.Value) failure_Process.FProcess_PartNo = Convert.ToString(dr["FProcess_PartNo"]);
            if (dr["FProcess_PartName"] != DBNull.Value) failure_Process.FProcess_PartName = Convert.ToString(dr["FProcess_PartName"]);
            if (dr["FProcess_Key"] != DBNull.Value) failure_Process.FProcess_Key = Convert.ToString(dr["FProcess_Key"]);
            if (dr["FProcess_RespPep"] != DBNull.Value) failure_Process.FProcess_RespPep = Convert.ToString(dr["FProcess_RespPep"]);
            if (dr["FProcess_RespSup"] != DBNull.Value) failure_Process.FProcess_RespSup = Convert.ToString(dr["FProcess_RespSup"]);
            if (dr["FProcess_Introduction"] != DBNull.Value) failure_Process.FProcess_Introduction = Convert.ToString(dr["FProcess_Introduction"]);
            if (dr["FProcess_Method"] != DBNull.Value) failure_Process.FProcess_Method = Convert.ToString(dr["FProcess_Method"]);
            if (dr["FProcess_Owner"] != DBNull.Value) failure_Process.FProcess_Owner = Convert.ToString(dr["FProcess_Owner"]);
            if (dr["FProcess_Date"] != DBNull.Value) failure_Process.FProcess_Date = Convert.ToDateTime(dr["FProcess_Date"]);
         }
          dr.Close(); 
         return failure_Process;
      }
      /// <summary>
      /// 获取指定的Failure_Process对象集合
      /// </summary>
      public List<Failure_Process> GetListByWhere(string strCondition)
      {
         List<Failure_Process> ret = new List<Failure_Process>();
         string sql = "SELECT  FProcess_ID,FInfo_ID,FProcess_ProdCode,FProcess_PartNo,FProcess_PartName,FProcess_Key,FProcess_RespPep,FProcess_RespSup,FProcess_Introduction,FProcess_Method,FProcess_Owner,FProcess_Date FROM Failure_Process WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Failure_Process failure_Process = new Failure_Process();
            if (dr["FProcess_ID"] != DBNull.Value) failure_Process.FProcess_ID = Convert.ToInt64(dr["FProcess_ID"]);
            if (dr["FInfo_ID"] != DBNull.Value) failure_Process.FInfo_ID = Convert.ToInt64(dr["FInfo_ID"]);
            if (dr["FProcess_ProdCode"] != DBNull.Value) failure_Process.FProcess_ProdCode = Convert.ToString(dr["FProcess_ProdCode"]);
            if (dr["FProcess_PartNo"] != DBNull.Value) failure_Process.FProcess_PartNo = Convert.ToString(dr["FProcess_PartNo"]);
            if (dr["FProcess_PartName"] != DBNull.Value) failure_Process.FProcess_PartName = Convert.ToString(dr["FProcess_PartName"]);
            if (dr["FProcess_Key"] != DBNull.Value) failure_Process.FProcess_Key = Convert.ToString(dr["FProcess_Key"]);
            if (dr["FProcess_RespPep"] != DBNull.Value) failure_Process.FProcess_RespPep = Convert.ToString(dr["FProcess_RespPep"]);
            if (dr["FProcess_RespSup"] != DBNull.Value) failure_Process.FProcess_RespSup = Convert.ToString(dr["FProcess_RespSup"]);
            if (dr["FProcess_Introduction"] != DBNull.Value) failure_Process.FProcess_Introduction = Convert.ToString(dr["FProcess_Introduction"]);
            if (dr["FProcess_Method"] != DBNull.Value) failure_Process.FProcess_Method = Convert.ToString(dr["FProcess_Method"]);
            if (dr["FProcess_Owner"] != DBNull.Value) failure_Process.FProcess_Owner = Convert.ToString(dr["FProcess_Owner"]);
            if (dr["FProcess_Date"] != DBNull.Value) failure_Process.FProcess_Date = Convert.ToDateTime(dr["FProcess_Date"]);
            ret.Add(failure_Process);
         }
          dr.Close(); 
         return ret;
      }
      /// <summary>
      /// 获取所有的Failure_Process对象(即:一条记录
      /// </summary>
      public List<Failure_Process> GetAll()
      {
         List<Failure_Process> ret = new List<Failure_Process>();
         string sql = "SELECT  FProcess_ID,FInfo_ID,FProcess_ProdCode,FProcess_PartNo,FProcess_PartName,FProcess_Key,FProcess_RespPep,FProcess_RespSup,FProcess_Introduction,FProcess_Method,FProcess_Owner,FProcess_Date FROM Failure_Process where 1=1 AND ((Stat is null) or (Stat=0) ) ";
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Failure_Process failure_Process = new Failure_Process();
            if (dr["FProcess_ID"] != DBNull.Value) failure_Process.FProcess_ID = Convert.ToInt64(dr["FProcess_ID"]);
            if (dr["FInfo_ID"] != DBNull.Value) failure_Process.FInfo_ID = Convert.ToInt64(dr["FInfo_ID"]);
            if (dr["FProcess_ProdCode"] != DBNull.Value) failure_Process.FProcess_ProdCode = Convert.ToString(dr["FProcess_ProdCode"]);
            if (dr["FProcess_PartNo"] != DBNull.Value) failure_Process.FProcess_PartNo = Convert.ToString(dr["FProcess_PartNo"]);
            if (dr["FProcess_PartName"] != DBNull.Value) failure_Process.FProcess_PartName = Convert.ToString(dr["FProcess_PartName"]);
            if (dr["FProcess_Key"] != DBNull.Value) failure_Process.FProcess_Key = Convert.ToString(dr["FProcess_Key"]);
            if (dr["FProcess_RespPep"] != DBNull.Value) failure_Process.FProcess_RespPep = Convert.ToString(dr["FProcess_RespPep"]);
            if (dr["FProcess_RespSup"] != DBNull.Value) failure_Process.FProcess_RespSup = Convert.ToString(dr["FProcess_RespSup"]);
            if (dr["FProcess_Introduction"] != DBNull.Value) failure_Process.FProcess_Introduction = Convert.ToString(dr["FProcess_Introduction"]);
            if (dr["FProcess_Method"] != DBNull.Value) failure_Process.FProcess_Method = Convert.ToString(dr["FProcess_Method"]);
            if (dr["FProcess_Owner"] != DBNull.Value) failure_Process.FProcess_Owner = Convert.ToString(dr["FProcess_Owner"]);
            if (dr["FProcess_Date"] != DBNull.Value) failure_Process.FProcess_Date = Convert.ToDateTime(dr["FProcess_Date"]);
            ret.Add(failure_Process);
         }
          dr.Close(); 
         return ret;
      }
   }
}
