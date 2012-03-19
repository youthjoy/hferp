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
   public partial class ADOUserRelationData
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加UserRelationData对象(即:一条记录)
      /// </summary>
      public int Add(UserRelationData userRelationData)
      {
         string sql = "INSERT INTO UserRelationData (URD_Operator,URD_OpTime,URD_Module,URD_OpType,URD_DataCode) VALUES (@URD_Operator,@URD_OpTime,@URD_Module,@URD_OpType,@URD_DataCode)";
         if (string.IsNullOrEmpty(userRelationData.URD_Operator))
         {
            idb.AddParameter("@URD_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_Operator", userRelationData.URD_Operator);
         }
         if (userRelationData.URD_OpTime == DateTime.MinValue)
         {
            idb.AddParameter("@URD_OpTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_OpTime", userRelationData.URD_OpTime);
         }
         if (string.IsNullOrEmpty(userRelationData.URD_Module))
         {
            idb.AddParameter("@URD_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_Module", userRelationData.URD_Module);
         }
         if (string.IsNullOrEmpty(userRelationData.URD_OpType))
         {
            idb.AddParameter("@URD_OpType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_OpType", userRelationData.URD_OpType);
         }
         if (string.IsNullOrEmpty(userRelationData.URD_DataCode))
         {
            idb.AddParameter("@URD_DataCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_DataCode", userRelationData.URD_DataCode);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加UserRelationData对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(UserRelationData userRelationData)
      {
         string sql = "INSERT INTO UserRelationData (URD_Operator,URD_OpTime,URD_Module,URD_OpType,URD_DataCode) VALUES (@URD_Operator,@URD_OpTime,@URD_Module,@URD_OpType,@URD_DataCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(userRelationData.URD_Operator))
         {
            idb.AddParameter("@URD_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_Operator", userRelationData.URD_Operator);
         }
         if (userRelationData.URD_OpTime == DateTime.MinValue)
         {
            idb.AddParameter("@URD_OpTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_OpTime", userRelationData.URD_OpTime);
         }
         if (string.IsNullOrEmpty(userRelationData.URD_Module))
         {
            idb.AddParameter("@URD_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_Module", userRelationData.URD_Module);
         }
         if (string.IsNullOrEmpty(userRelationData.URD_OpType))
         {
            idb.AddParameter("@URD_OpType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_OpType", userRelationData.URD_OpType);
         }
         if (string.IsNullOrEmpty(userRelationData.URD_DataCode))
         {
            idb.AddParameter("@URD_DataCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_DataCode", userRelationData.URD_DataCode);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新UserRelationData对象(即:一条记录
      /// </summary>
      public int Update(UserRelationData userRelationData)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       UserRelationData       SET ");
            if(userRelationData.URD_Operator_IsChanged){sbParameter.Append("URD_Operator=@URD_Operator, ");}
      if(userRelationData.URD_OpTime_IsChanged){sbParameter.Append("URD_OpTime=@URD_OpTime, ");}
      if(userRelationData.URD_Module_IsChanged){sbParameter.Append("URD_Module=@URD_Module, ");}
      if(userRelationData.URD_OpType_IsChanged){sbParameter.Append("URD_OpType=@URD_OpType, ");}
      if(userRelationData.URD_DataCode_IsChanged){sbParameter.Append("URD_DataCode=@URD_DataCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and URD_ID=@URD_ID; " );
      string sql=sb.ToString();
         if(userRelationData.URD_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(userRelationData.URD_Operator))
         {
            idb.AddParameter("@URD_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_Operator", userRelationData.URD_Operator);
         }
          }
         if(userRelationData.URD_OpTime_IsChanged)
         {
         if (userRelationData.URD_OpTime == DateTime.MinValue)
         {
            idb.AddParameter("@URD_OpTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_OpTime", userRelationData.URD_OpTime);
         }
          }
         if(userRelationData.URD_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(userRelationData.URD_Module))
         {
            idb.AddParameter("@URD_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_Module", userRelationData.URD_Module);
         }
          }
         if(userRelationData.URD_OpType_IsChanged)
         {
         if (string.IsNullOrEmpty(userRelationData.URD_OpType))
         {
            idb.AddParameter("@URD_OpType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_OpType", userRelationData.URD_OpType);
         }
          }
         if(userRelationData.URD_DataCode_IsChanged)
         {
         if (string.IsNullOrEmpty(userRelationData.URD_DataCode))
         {
            idb.AddParameter("@URD_DataCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@URD_DataCode", userRelationData.URD_DataCode);
         }
          }

         idb.AddParameter("@URD_ID", userRelationData.URD_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除UserRelationData对象(即:一条记录
      /// </summary>
      public int Delete(int uRD_ID)
      {
         string sql = "DELETE UserRelationData WHERE 1=1  AND URD_ID=@URD_ID ";
         idb.AddParameter("@URD_ID", uRD_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的UserRelationData对象(即:一条记录
      /// </summary>
      public UserRelationData GetByKey(int uRD_ID)
      {
         UserRelationData userRelationData = new UserRelationData();
         string sql = "SELECT  URD_ID,URD_Operator,URD_OpTime,URD_Module,URD_OpType,URD_DataCode FROM UserRelationData WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND URD_ID=@URD_ID ";
         idb.AddParameter("@URD_ID", uRD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["URD_ID"] != DBNull.Value) userRelationData.URD_ID = Convert.ToInt32(dr["URD_ID"]);
            if (dr["URD_Operator"] != DBNull.Value) userRelationData.URD_Operator = Convert.ToString(dr["URD_Operator"]);
            if (dr["URD_OpTime"] != DBNull.Value) userRelationData.URD_OpTime = Convert.ToDateTime(dr["URD_OpTime"]);
            if (dr["URD_Module"] != DBNull.Value) userRelationData.URD_Module = Convert.ToString(dr["URD_Module"]);
            if (dr["URD_OpType"] != DBNull.Value) userRelationData.URD_OpType = Convert.ToString(dr["URD_OpType"]);
            if (dr["URD_DataCode"] != DBNull.Value) userRelationData.URD_DataCode = Convert.ToString(dr["URD_DataCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return userRelationData;
      }
      /// <summary>
      /// 获取指定的UserRelationData对象集合
      /// </summary>
      public List<UserRelationData> GetListByWhere(string strCondition)
      {
         List<UserRelationData> ret = new List<UserRelationData>();
         string sql = "SELECT  URD_ID,URD_Operator,URD_OpTime,URD_Module,URD_OpType,URD_DataCode FROM UserRelationData WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            UserRelationData userRelationData = new UserRelationData();
            if (dr["URD_ID"] != DBNull.Value) userRelationData.URD_ID = Convert.ToInt32(dr["URD_ID"]);
            if (dr["URD_Operator"] != DBNull.Value) userRelationData.URD_Operator = Convert.ToString(dr["URD_Operator"]);
            if (dr["URD_OpTime"] != DBNull.Value) userRelationData.URD_OpTime = Convert.ToDateTime(dr["URD_OpTime"]);
            if (dr["URD_Module"] != DBNull.Value) userRelationData.URD_Module = Convert.ToString(dr["URD_Module"]);
            if (dr["URD_OpType"] != DBNull.Value) userRelationData.URD_OpType = Convert.ToString(dr["URD_OpType"]);
            if (dr["URD_DataCode"] != DBNull.Value) userRelationData.URD_DataCode = Convert.ToString(dr["URD_DataCode"]);
            ret.Add(userRelationData);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的UserRelationData对象(即:一条记录
      /// </summary>
      public List<UserRelationData> GetAll()
      {
         List<UserRelationData> ret = new List<UserRelationData>();
         string sql = "SELECT  URD_ID,URD_Operator,URD_OpTime,URD_Module,URD_OpType,URD_DataCode FROM UserRelationData where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            UserRelationData userRelationData = new UserRelationData();
            if (dr["URD_ID"] != DBNull.Value) userRelationData.URD_ID = Convert.ToInt32(dr["URD_ID"]);
            if (dr["URD_Operator"] != DBNull.Value) userRelationData.URD_Operator = Convert.ToString(dr["URD_Operator"]);
            if (dr["URD_OpTime"] != DBNull.Value) userRelationData.URD_OpTime = Convert.ToDateTime(dr["URD_OpTime"]);
            if (dr["URD_Module"] != DBNull.Value) userRelationData.URD_Module = Convert.ToString(dr["URD_Module"]);
            if (dr["URD_OpType"] != DBNull.Value) userRelationData.URD_OpType = Convert.ToString(dr["URD_OpType"]);
            if (dr["URD_DataCode"] != DBNull.Value) userRelationData.URD_DataCode = Convert.ToString(dr["URD_DataCode"]);
            ret.Add(userRelationData);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
