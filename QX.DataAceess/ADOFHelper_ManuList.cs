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
   public partial class ADOFHelper_ManuList
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加FHelper_ManuList对象(即:一条记录)
      /// </summary>
      public int Add(FHelper_ManuList fHelper_ManuList)
      {
         string sql = "INSERT INTO FHelper_ManuList (FM_ManuCode,FM_ManuName,FM_Telephone,FM_Contactor,FM_Address,FM_Remark,Stat) VALUES (@FM_ManuCode,@FM_ManuName,@FM_Telephone,@FM_Contactor,@FM_Address,@FM_Remark,@Stat)";
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_ManuCode))
         {
            idb.AddParameter("@FM_ManuCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_ManuCode", fHelper_ManuList.FM_ManuCode);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_ManuName))
         {
            idb.AddParameter("@FM_ManuName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_ManuName", fHelper_ManuList.FM_ManuName);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Telephone))
         {
            idb.AddParameter("@FM_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Telephone", fHelper_ManuList.FM_Telephone);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Contactor))
         {
            idb.AddParameter("@FM_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Contactor", fHelper_ManuList.FM_Contactor);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Address))
         {
            idb.AddParameter("@FM_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Address", fHelper_ManuList.FM_Address);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Remark))
         {
            idb.AddParameter("@FM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Remark", fHelper_ManuList.FM_Remark);
         }
         if (fHelper_ManuList.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_ManuList.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加FHelper_ManuList对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(FHelper_ManuList fHelper_ManuList)
      {
         string sql = "INSERT INTO FHelper_ManuList (FM_ManuCode,FM_ManuName,FM_Telephone,FM_Contactor,FM_Address,FM_Remark,Stat) VALUES (@FM_ManuCode,@FM_ManuName,@FM_Telephone,@FM_Contactor,@FM_Address,@FM_Remark,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_ManuCode))
         {
            idb.AddParameter("@FM_ManuCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_ManuCode", fHelper_ManuList.FM_ManuCode);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_ManuName))
         {
            idb.AddParameter("@FM_ManuName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_ManuName", fHelper_ManuList.FM_ManuName);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Telephone))
         {
            idb.AddParameter("@FM_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Telephone", fHelper_ManuList.FM_Telephone);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Contactor))
         {
            idb.AddParameter("@FM_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Contactor", fHelper_ManuList.FM_Contactor);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Address))
         {
            idb.AddParameter("@FM_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Address", fHelper_ManuList.FM_Address);
         }
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Remark))
         {
            idb.AddParameter("@FM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Remark", fHelper_ManuList.FM_Remark);
         }
         if (fHelper_ManuList.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_ManuList.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新FHelper_ManuList对象(即:一条记录
      /// </summary>
      public int Update(FHelper_ManuList fHelper_ManuList)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       FHelper_ManuList       SET ");
            if(fHelper_ManuList.FM_ManuCode_IsChanged){sbParameter.Append("FM_ManuCode=@FM_ManuCode, ");}
      if(fHelper_ManuList.FM_ManuName_IsChanged){sbParameter.Append("FM_ManuName=@FM_ManuName, ");}
      if(fHelper_ManuList.FM_Telephone_IsChanged){sbParameter.Append("FM_Telephone=@FM_Telephone, ");}
      if(fHelper_ManuList.FM_Contactor_IsChanged){sbParameter.Append("FM_Contactor=@FM_Contactor, ");}
      if(fHelper_ManuList.FM_Address_IsChanged){sbParameter.Append("FM_Address=@FM_Address, ");}
      if(fHelper_ManuList.FM_Remark_IsChanged){sbParameter.Append("FM_Remark=@FM_Remark, ");}
      if(fHelper_ManuList.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FM_ID=@FM_ID; " );
      string sql=sb.ToString();
         if(fHelper_ManuList.FM_ManuCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_ManuCode))
         {
            idb.AddParameter("@FM_ManuCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_ManuCode", fHelper_ManuList.FM_ManuCode);
         }
          }
         if(fHelper_ManuList.FM_ManuName_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_ManuName))
         {
            idb.AddParameter("@FM_ManuName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_ManuName", fHelper_ManuList.FM_ManuName);
         }
          }
         if(fHelper_ManuList.FM_Telephone_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Telephone))
         {
            idb.AddParameter("@FM_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Telephone", fHelper_ManuList.FM_Telephone);
         }
          }
         if(fHelper_ManuList.FM_Contactor_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Contactor))
         {
            idb.AddParameter("@FM_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Contactor", fHelper_ManuList.FM_Contactor);
         }
          }
         if(fHelper_ManuList.FM_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Address))
         {
            idb.AddParameter("@FM_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Address", fHelper_ManuList.FM_Address);
         }
          }
         if(fHelper_ManuList.FM_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_ManuList.FM_Remark))
         {
            idb.AddParameter("@FM_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FM_Remark", fHelper_ManuList.FM_Remark);
         }
          }
         if(fHelper_ManuList.Stat_IsChanged)
         {
         if (fHelper_ManuList.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_ManuList.Stat);
         }
          }

         idb.AddParameter("@FM_ID", fHelper_ManuList.FM_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除FHelper_ManuList对象(即:一条记录
      /// </summary>
      public int Delete(int fM_ID)
      {
         string sql = "DELETE FHelper_ManuList WHERE 1=1  AND FM_ID=@FM_ID ";
         idb.AddParameter("@FM_ID", fM_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的FHelper_ManuList对象(即:一条记录
      /// </summary>
      public FHelper_ManuList GetByKey(int fM_ID)
      {
         FHelper_ManuList fHelper_ManuList = new FHelper_ManuList();
         string sql = "SELECT  FM_ID,FM_ManuCode,FM_ManuName,FM_Telephone,FM_Contactor,FM_Address,FM_Remark,Stat FROM FHelper_ManuList WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FM_ID=@FM_ID ";
         idb.AddParameter("@FM_ID", fM_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FM_ID"] != DBNull.Value) fHelper_ManuList.FM_ID = Convert.ToInt32(dr["FM_ID"]);
            if (dr["FM_ManuCode"] != DBNull.Value) fHelper_ManuList.FM_ManuCode = Convert.ToString(dr["FM_ManuCode"]);
            if (dr["FM_ManuName"] != DBNull.Value) fHelper_ManuList.FM_ManuName = Convert.ToString(dr["FM_ManuName"]);
            if (dr["FM_Telephone"] != DBNull.Value) fHelper_ManuList.FM_Telephone = Convert.ToString(dr["FM_Telephone"]);
            if (dr["FM_Contactor"] != DBNull.Value) fHelper_ManuList.FM_Contactor = Convert.ToString(dr["FM_Contactor"]);
            if (dr["FM_Address"] != DBNull.Value) fHelper_ManuList.FM_Address = Convert.ToString(dr["FM_Address"]);
            if (dr["FM_Remark"] != DBNull.Value) fHelper_ManuList.FM_Remark = Convert.ToString(dr["FM_Remark"]);
            if (dr["Stat"] != DBNull.Value) fHelper_ManuList.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return fHelper_ManuList;
      }
      /// <summary>
      /// 获取指定的FHelper_ManuList对象集合
      /// </summary>
      public List<FHelper_ManuList> GetListByWhere(string strCondition)
      {
         List<FHelper_ManuList> ret = new List<FHelper_ManuList>();
         string sql = "SELECT  FM_ID,FM_ManuCode,FM_ManuName,FM_Telephone,FM_Contactor,FM_Address,FM_Remark,Stat FROM FHelper_ManuList WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            FHelper_ManuList fHelper_ManuList = new FHelper_ManuList();
            if (dr["FM_ID"] != DBNull.Value) fHelper_ManuList.FM_ID = Convert.ToInt32(dr["FM_ID"]);
            if (dr["FM_ManuCode"] != DBNull.Value) fHelper_ManuList.FM_ManuCode = Convert.ToString(dr["FM_ManuCode"]);
            if (dr["FM_ManuName"] != DBNull.Value) fHelper_ManuList.FM_ManuName = Convert.ToString(dr["FM_ManuName"]);
            if (dr["FM_Telephone"] != DBNull.Value) fHelper_ManuList.FM_Telephone = Convert.ToString(dr["FM_Telephone"]);
            if (dr["FM_Contactor"] != DBNull.Value) fHelper_ManuList.FM_Contactor = Convert.ToString(dr["FM_Contactor"]);
            if (dr["FM_Address"] != DBNull.Value) fHelper_ManuList.FM_Address = Convert.ToString(dr["FM_Address"]);
            if (dr["FM_Remark"] != DBNull.Value) fHelper_ManuList.FM_Remark = Convert.ToString(dr["FM_Remark"]);
            if (dr["Stat"] != DBNull.Value) fHelper_ManuList.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(fHelper_ManuList);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的FHelper_ManuList对象(即:一条记录
      /// </summary>
      public List<FHelper_ManuList> GetAll()
      {
         List<FHelper_ManuList> ret = new List<FHelper_ManuList>();
         string sql = "SELECT  FM_ID,FM_ManuCode,FM_ManuName,FM_Telephone,FM_Contactor,FM_Address,FM_Remark,Stat FROM FHelper_ManuList where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            FHelper_ManuList fHelper_ManuList = new FHelper_ManuList();
            if (dr["FM_ID"] != DBNull.Value) fHelper_ManuList.FM_ID = Convert.ToInt32(dr["FM_ID"]);
            if (dr["FM_ManuCode"] != DBNull.Value) fHelper_ManuList.FM_ManuCode = Convert.ToString(dr["FM_ManuCode"]);
            if (dr["FM_ManuName"] != DBNull.Value) fHelper_ManuList.FM_ManuName = Convert.ToString(dr["FM_ManuName"]);
            if (dr["FM_Telephone"] != DBNull.Value) fHelper_ManuList.FM_Telephone = Convert.ToString(dr["FM_Telephone"]);
            if (dr["FM_Contactor"] != DBNull.Value) fHelper_ManuList.FM_Contactor = Convert.ToString(dr["FM_Contactor"]);
            if (dr["FM_Address"] != DBNull.Value) fHelper_ManuList.FM_Address = Convert.ToString(dr["FM_Address"]);
            if (dr["FM_Remark"] != DBNull.Value) fHelper_ManuList.FM_Remark = Convert.ToString(dr["FM_Remark"]);
            if (dr["Stat"] != DBNull.Value) fHelper_ManuList.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(fHelper_ManuList);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
