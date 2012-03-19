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
   public partial class ADOBse_FeedDetail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_FeedDetail对象(即:一条记录)
      /// </summary>
      public int Add(Bse_FeedDetail bse_FeedDetail)
      {
         string sql = "INSERT INTO Bse_FeedDetail (FBI_MCode,FBI_DCode,FBI_DName,FBI_itype,Stat) VALUES (@FBI_MCode,@FBI_DCode,@FBI_DName,@FBI_itype,@Stat)";
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_MCode))
         {
            idb.AddParameter("@FBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_MCode", bse_FeedDetail.FBI_MCode);
         }
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_DCode))
         {
            idb.AddParameter("@FBI_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_DCode", bse_FeedDetail.FBI_DCode);
         }
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_DName))
         {
            idb.AddParameter("@FBI_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_DName", bse_FeedDetail.FBI_DName);
         }
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_itype))
         {
            idb.AddParameter("@FBI_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_itype", bse_FeedDetail.FBI_itype);
         }
         if (bse_FeedDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_FeedDetail.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_FeedDetail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_FeedDetail bse_FeedDetail)
      {
         string sql = "INSERT INTO Bse_FeedDetail (FBI_MCode,FBI_DCode,FBI_DName,FBI_itype,Stat) VALUES (@FBI_MCode,@FBI_DCode,@FBI_DName,@FBI_itype,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_MCode))
         {
            idb.AddParameter("@FBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_MCode", bse_FeedDetail.FBI_MCode);
         }
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_DCode))
         {
            idb.AddParameter("@FBI_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_DCode", bse_FeedDetail.FBI_DCode);
         }
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_DName))
         {
            idb.AddParameter("@FBI_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_DName", bse_FeedDetail.FBI_DName);
         }
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_itype))
         {
            idb.AddParameter("@FBI_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_itype", bse_FeedDetail.FBI_itype);
         }
         if (bse_FeedDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_FeedDetail.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_FeedDetail对象(即:一条记录
      /// </summary>
      public int Update(Bse_FeedDetail bse_FeedDetail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_FeedDetail       SET ");
            if(bse_FeedDetail.FBI_MCode_IsChanged){sbParameter.Append("FBI_MCode=@FBI_MCode, ");}
      if(bse_FeedDetail.FBI_DCode_IsChanged){sbParameter.Append("FBI_DCode=@FBI_DCode, ");}
      if(bse_FeedDetail.FBI_DName_IsChanged){sbParameter.Append("FBI_DName=@FBI_DName, ");}
      if(bse_FeedDetail.FBI_itype_IsChanged){sbParameter.Append("FBI_itype=@FBI_itype, ");}
      if(bse_FeedDetail.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FBI_ID=@FBI_ID; " );
      string sql=sb.ToString();
         if(bse_FeedDetail.FBI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_MCode))
         {
            idb.AddParameter("@FBI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_MCode", bse_FeedDetail.FBI_MCode);
         }
          }
         if(bse_FeedDetail.FBI_DCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_DCode))
         {
            idb.AddParameter("@FBI_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_DCode", bse_FeedDetail.FBI_DCode);
         }
          }
         if(bse_FeedDetail.FBI_DName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_DName))
         {
            idb.AddParameter("@FBI_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_DName", bse_FeedDetail.FBI_DName);
         }
          }
         if(bse_FeedDetail.FBI_itype_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_FeedDetail.FBI_itype))
         {
            idb.AddParameter("@FBI_itype", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FBI_itype", bse_FeedDetail.FBI_itype);
         }
          }
         if(bse_FeedDetail.Stat_IsChanged)
         {
         if (bse_FeedDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_FeedDetail.Stat);
         }
          }

         idb.AddParameter("@FBI_ID", bse_FeedDetail.FBI_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_FeedDetail对象(即:一条记录
      /// </summary>
      public int Delete(decimal fBI_ID)
      {
         string sql = "DELETE Bse_FeedDetail WHERE 1=1  AND FBI_ID=@FBI_ID ";
         idb.AddParameter("@FBI_ID", fBI_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_FeedDetail对象(即:一条记录
      /// </summary>
      public Bse_FeedDetail GetByKey(decimal fBI_ID)
      {
         Bse_FeedDetail bse_FeedDetail = new Bse_FeedDetail();
         string sql = "SELECT  FBI_ID,FBI_MCode,FBI_DCode,FBI_DName,FBI_itype,Stat FROM Bse_FeedDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FBI_ID=@FBI_ID ";
         idb.AddParameter("@FBI_ID", fBI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FBI_ID"] != DBNull.Value) bse_FeedDetail.FBI_ID = Convert.ToDecimal(dr["FBI_ID"]);
            if (dr["FBI_MCode"] != DBNull.Value) bse_FeedDetail.FBI_MCode = Convert.ToString(dr["FBI_MCode"]);
            if (dr["FBI_DCode"] != DBNull.Value) bse_FeedDetail.FBI_DCode = Convert.ToString(dr["FBI_DCode"]);
            if (dr["FBI_DName"] != DBNull.Value) bse_FeedDetail.FBI_DName = Convert.ToString(dr["FBI_DName"]);
            if (dr["FBI_itype"] != DBNull.Value) bse_FeedDetail.FBI_itype = Convert.ToString(dr["FBI_itype"]);
            if (dr["Stat"] != DBNull.Value) bse_FeedDetail.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_FeedDetail;
      }
      /// <summary>
      /// 获取指定的Bse_FeedDetail对象集合
      /// </summary>
      public List<Bse_FeedDetail> GetListByWhere(string strCondition)
      {
         List<Bse_FeedDetail> ret = new List<Bse_FeedDetail>();
         string sql = "SELECT  FBI_ID,FBI_MCode,FBI_DCode,FBI_DName,FBI_itype,Stat FROM Bse_FeedDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_FeedDetail bse_FeedDetail = new Bse_FeedDetail();
            if (dr["FBI_ID"] != DBNull.Value) bse_FeedDetail.FBI_ID = Convert.ToDecimal(dr["FBI_ID"]);
            if (dr["FBI_MCode"] != DBNull.Value) bse_FeedDetail.FBI_MCode = Convert.ToString(dr["FBI_MCode"]);
            if (dr["FBI_DCode"] != DBNull.Value) bse_FeedDetail.FBI_DCode = Convert.ToString(dr["FBI_DCode"]);
            if (dr["FBI_DName"] != DBNull.Value) bse_FeedDetail.FBI_DName = Convert.ToString(dr["FBI_DName"]);
            if (dr["FBI_itype"] != DBNull.Value) bse_FeedDetail.FBI_itype = Convert.ToString(dr["FBI_itype"]);
            if (dr["Stat"] != DBNull.Value) bse_FeedDetail.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_FeedDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_FeedDetail对象(即:一条记录
      /// </summary>
      public List<Bse_FeedDetail> GetAll()
      {
         List<Bse_FeedDetail> ret = new List<Bse_FeedDetail>();
         string sql = "SELECT  FBI_ID,FBI_MCode,FBI_DCode,FBI_DName,FBI_itype,Stat FROM Bse_FeedDetail where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_FeedDetail bse_FeedDetail = new Bse_FeedDetail();
            if (dr["FBI_ID"] != DBNull.Value) bse_FeedDetail.FBI_ID = Convert.ToDecimal(dr["FBI_ID"]);
            if (dr["FBI_MCode"] != DBNull.Value) bse_FeedDetail.FBI_MCode = Convert.ToString(dr["FBI_MCode"]);
            if (dr["FBI_DCode"] != DBNull.Value) bse_FeedDetail.FBI_DCode = Convert.ToString(dr["FBI_DCode"]);
            if (dr["FBI_DName"] != DBNull.Value) bse_FeedDetail.FBI_DName = Convert.ToString(dr["FBI_DName"]);
            if (dr["FBI_itype"] != DBNull.Value) bse_FeedDetail.FBI_itype = Convert.ToString(dr["FBI_itype"]);
            if (dr["Stat"] != DBNull.Value) bse_FeedDetail.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_FeedDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
