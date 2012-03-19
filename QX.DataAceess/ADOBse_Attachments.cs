using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAcess;

namespace QX.DataAceess
{
   /// <summary>
   /// 附件信息
   /// </summary>
   [Serializable]
   public partial class ADOBse_Attachments
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加附件信息 Bse_Attachments对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Attachments bse_Attachments)
      {
         string sql = "INSERT INTO Bse_Attachments (AT_Key,AT_Code,AT_Name,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_tmpPath) VALUES (@AT_Key,@AT_Code,@AT_Name,@AT_CDate,@AT_UDate,@AT_Creator,@AT_Updator,@Stat,@AT_tmpPath)";
         if (string.IsNullOrEmpty(bse_Attachments.AT_Key))
         {
            idb.AddParameter("@AT_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Key", bse_Attachments.AT_Key);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Code))
         {
            idb.AddParameter("@AT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Code", bse_Attachments.AT_Code);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Name))
         {
            idb.AddParameter("@AT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Name", bse_Attachments.AT_Name);
         }
         if (bse_Attachments.AT_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_CDate", bse_Attachments.AT_CDate);
         }
         if (bse_Attachments.AT_UDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_UDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_UDate", bse_Attachments.AT_UDate);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Creator))
         {
            idb.AddParameter("@AT_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Creator", bse_Attachments.AT_Creator);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Updator))
         {
            idb.AddParameter("@AT_Updator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Updator", bse_Attachments.AT_Updator);
         }
         if (bse_Attachments.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Attachments.Stat);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_tmpPath))
         {
            idb.AddParameter("@AT_tmpPath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_tmpPath", bse_Attachments.AT_tmpPath);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加附件信息 Bse_Attachments对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Attachments bse_Attachments)
      {
         string sql = "INSERT INTO Bse_Attachments (AT_Key,AT_Code,AT_Name,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_tmpPath) VALUES (@AT_Key,@AT_Code,@AT_Name,@AT_CDate,@AT_UDate,@AT_Creator,@AT_Updator,@Stat,@AT_tmpPath);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Attachments.AT_Key))
         {
            idb.AddParameter("@AT_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Key", bse_Attachments.AT_Key);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Code))
         {
            idb.AddParameter("@AT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Code", bse_Attachments.AT_Code);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Name))
         {
            idb.AddParameter("@AT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Name", bse_Attachments.AT_Name);
         }
         if (bse_Attachments.AT_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_CDate", bse_Attachments.AT_CDate);
         }
         if (bse_Attachments.AT_UDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_UDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_UDate", bse_Attachments.AT_UDate);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Creator))
         {
            idb.AddParameter("@AT_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Creator", bse_Attachments.AT_Creator);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_Updator))
         {
            idb.AddParameter("@AT_Updator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Updator", bse_Attachments.AT_Updator);
         }
         if (bse_Attachments.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Attachments.Stat);
         }
         if (string.IsNullOrEmpty(bse_Attachments.AT_tmpPath))
         {
            idb.AddParameter("@AT_tmpPath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_tmpPath", bse_Attachments.AT_tmpPath);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public int Update(Bse_Attachments bse_Attachments)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Attachments       SET ");
            if(bse_Attachments.AT_Key_IsChanged){sbParameter.Append("AT_Key=@AT_Key, ");}
      if(bse_Attachments.AT_Code_IsChanged){sbParameter.Append("AT_Code=@AT_Code, ");}
      if(bse_Attachments.AT_Name_IsChanged){sbParameter.Append("AT_Name=@AT_Name, ");}
      if(bse_Attachments.AT_CDate_IsChanged){sbParameter.Append("AT_CDate=@AT_CDate, ");}
      if(bse_Attachments.AT_UDate_IsChanged){sbParameter.Append("AT_UDate=@AT_UDate, ");}
      if(bse_Attachments.AT_Creator_IsChanged){sbParameter.Append("AT_Creator=@AT_Creator, ");}
      if(bse_Attachments.AT_Updator_IsChanged){sbParameter.Append("AT_Updator=@AT_Updator, ");}
      if(bse_Attachments.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Attachments.AT_tmpPath_IsChanged){sbParameter.Append("AT_tmpPath=@AT_tmpPath ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and AT_ID=@AT_ID; " );
      string sql=sb.ToString();
         if(bse_Attachments.AT_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Key))
         {
            idb.AddParameter("@AT_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Key", bse_Attachments.AT_Key);
         }
          }
         if(bse_Attachments.AT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Code))
         {
            idb.AddParameter("@AT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Code", bse_Attachments.AT_Code);
         }
          }
         if(bse_Attachments.AT_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Name))
         {
            idb.AddParameter("@AT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Name", bse_Attachments.AT_Name);
         }
          }
         if(bse_Attachments.AT_CDate_IsChanged)
         {
         if (bse_Attachments.AT_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_CDate", bse_Attachments.AT_CDate);
         }
          }
         if(bse_Attachments.AT_UDate_IsChanged)
         {
         if (bse_Attachments.AT_UDate == DateTime.MinValue)
         {
            idb.AddParameter("@AT_UDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_UDate", bse_Attachments.AT_UDate);
         }
          }
         if(bse_Attachments.AT_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Creator))
         {
            idb.AddParameter("@AT_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Creator", bse_Attachments.AT_Creator);
         }
          }
         if(bse_Attachments.AT_Updator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_Updator))
         {
            idb.AddParameter("@AT_Updator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_Updator", bse_Attachments.AT_Updator);
         }
          }
         if(bse_Attachments.Stat_IsChanged)
         {
         if (bse_Attachments.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Attachments.Stat);
         }
          }
         if(bse_Attachments.AT_tmpPath_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Attachments.AT_tmpPath))
         {
            idb.AddParameter("@AT_tmpPath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AT_tmpPath", bse_Attachments.AT_tmpPath);
         }
          }

         idb.AddParameter("@AT_ID", bse_Attachments.AT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public int Delete(Int64 aT_ID)
      {
         string sql = "DELETE Bse_Attachments WHERE 1=1  AND AT_ID=@AT_ID ";
         idb.AddParameter("@AT_ID", aT_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public Bse_Attachments GetByKey(Int64 aT_ID)
      {
         Bse_Attachments bse_Attachments = new Bse_Attachments();
         string sql = "SELECT  AT_ID,AT_Key,AT_Code,AT_Name,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_tmpPath FROM Bse_Attachments WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND AT_ID=@AT_ID ";
         idb.AddParameter("@AT_ID", aT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["AT_ID"] != DBNull.Value) bse_Attachments.AT_ID = Convert.ToInt64(dr["AT_ID"]);
            if (dr["AT_Key"] != DBNull.Value) bse_Attachments.AT_Key = Convert.ToString(dr["AT_Key"]);
            if (dr["AT_Code"] != DBNull.Value) bse_Attachments.AT_Code = Convert.ToString(dr["AT_Code"]);
            if (dr["AT_Name"] != DBNull.Value) bse_Attachments.AT_Name = Convert.ToString(dr["AT_Name"]);
            if (dr["AT_CDate"] != DBNull.Value) bse_Attachments.AT_CDate = Convert.ToDateTime(dr["AT_CDate"]);
            if (dr["AT_UDate"] != DBNull.Value) bse_Attachments.AT_UDate = Convert.ToDateTime(dr["AT_UDate"]);
            if (dr["AT_Creator"] != DBNull.Value) bse_Attachments.AT_Creator = Convert.ToString(dr["AT_Creator"]);
            if (dr["AT_Updator"] != DBNull.Value) bse_Attachments.AT_Updator = Convert.ToString(dr["AT_Updator"]);
            if (dr["Stat"] != DBNull.Value) bse_Attachments.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AT_tmpPath"] != DBNull.Value) bse_Attachments.AT_tmpPath = Convert.ToString(dr["AT_tmpPath"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return bse_Attachments;
      }
      /// <summary>
      /// 获取指定的附件信息 Bse_Attachments对象集合
      /// </summary>
      public List<Bse_Attachments> GetListByWhere(string strCondition)
      {
         List<Bse_Attachments> ret = new List<Bse_Attachments>();
         string sql = "SELECT  AT_ID,AT_Key,AT_Code,AT_Name,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_tmpPath FROM Bse_Attachments WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Attachments bse_Attachments = new Bse_Attachments();
            if (dr["AT_ID"] != DBNull.Value) bse_Attachments.AT_ID = Convert.ToInt64(dr["AT_ID"]);
            if (dr["AT_Key"] != DBNull.Value) bse_Attachments.AT_Key = Convert.ToString(dr["AT_Key"]);
            if (dr["AT_Code"] != DBNull.Value) bse_Attachments.AT_Code = Convert.ToString(dr["AT_Code"]);
            if (dr["AT_Name"] != DBNull.Value) bse_Attachments.AT_Name = Convert.ToString(dr["AT_Name"]);
            if (dr["AT_CDate"] != DBNull.Value) bse_Attachments.AT_CDate = Convert.ToDateTime(dr["AT_CDate"]);
            if (dr["AT_UDate"] != DBNull.Value) bse_Attachments.AT_UDate = Convert.ToDateTime(dr["AT_UDate"]);
            if (dr["AT_Creator"] != DBNull.Value) bse_Attachments.AT_Creator = Convert.ToString(dr["AT_Creator"]);
            if (dr["AT_Updator"] != DBNull.Value) bse_Attachments.AT_Updator = Convert.ToString(dr["AT_Updator"]);
            if (dr["Stat"] != DBNull.Value) bse_Attachments.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AT_tmpPath"] != DBNull.Value) bse_Attachments.AT_tmpPath = Convert.ToString(dr["AT_tmpPath"]);
            ret.Add(bse_Attachments);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的附件信息 Bse_Attachments对象(即:一条记录
      /// </summary>
      public List<Bse_Attachments> GetAll()
      {
         List<Bse_Attachments> ret = new List<Bse_Attachments>();
         string sql = "SELECT  AT_ID,AT_Key,AT_Code,AT_Name,AT_CDate,AT_UDate,AT_Creator,AT_Updator,Stat,AT_tmpPath FROM Bse_Attachments where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Attachments bse_Attachments = new Bse_Attachments();
            if (dr["AT_ID"] != DBNull.Value) bse_Attachments.AT_ID = Convert.ToInt64(dr["AT_ID"]);
            if (dr["AT_Key"] != DBNull.Value) bse_Attachments.AT_Key = Convert.ToString(dr["AT_Key"]);
            if (dr["AT_Code"] != DBNull.Value) bse_Attachments.AT_Code = Convert.ToString(dr["AT_Code"]);
            if (dr["AT_Name"] != DBNull.Value) bse_Attachments.AT_Name = Convert.ToString(dr["AT_Name"]);
            if (dr["AT_CDate"] != DBNull.Value) bse_Attachments.AT_CDate = Convert.ToDateTime(dr["AT_CDate"]);
            if (dr["AT_UDate"] != DBNull.Value) bse_Attachments.AT_UDate = Convert.ToDateTime(dr["AT_UDate"]);
            if (dr["AT_Creator"] != DBNull.Value) bse_Attachments.AT_Creator = Convert.ToString(dr["AT_Creator"]);
            if (dr["AT_Updator"] != DBNull.Value) bse_Attachments.AT_Updator = Convert.ToString(dr["AT_Updator"]);
            if (dr["Stat"] != DBNull.Value) bse_Attachments.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AT_tmpPath"] != DBNull.Value) bse_Attachments.AT_tmpPath = Convert.ToString(dr["AT_tmpPath"]);
            ret.Add(bse_Attachments);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
