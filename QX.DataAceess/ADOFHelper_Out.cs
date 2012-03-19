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
   public partial class ADOFHelper_Out
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加FHelper_Out对象(即:一条记录)
      /// </summary>
      public int Add(FHelper_Out fHelper_Out)
      {
         string sql = "INSERT INTO FHelper_Out (FOut_ID,FOut_Owner,FOut_Date,Fout_IsPrint,FOut_Num,FOut_OPType,FOut_Stat) VALUES (@FOut_ID,@FOut_Owner,@FOut_Date,@Fout_IsPrint,@FOut_Num,@FOut_OPType,@FOut_Stat)";
         if (string.IsNullOrEmpty(fHelper_Out.FOut_Owner))
         {
            idb.AddParameter("@FOut_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_Owner", fHelper_Out.FOut_Owner);
         }
         if (fHelper_Out.FOut_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FOut_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_Date", fHelper_Out.FOut_Date);
         }
         if (fHelper_Out.Fout_IsPrint == 0)
         {
            idb.AddParameter("@Fout_IsPrint", 0);
         }
         else
         {
            idb.AddParameter("@Fout_IsPrint", fHelper_Out.Fout_IsPrint);
         }
         if (fHelper_Out.FOut_Num == 0)
         {
            idb.AddParameter("@FOut_Num", 0);
         }
         else
         {
            idb.AddParameter("@FOut_Num", fHelper_Out.FOut_Num);
         }
         if (string.IsNullOrEmpty(fHelper_Out.FOut_OPType))
         {
            idb.AddParameter("@FOut_OPType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_OPType", fHelper_Out.FOut_OPType);
         }
         if (fHelper_Out.FOut_Stat == 0)
         {
            idb.AddParameter("@FOut_Stat", 0);
         }
         else
         {
            idb.AddParameter("@FOut_Stat", fHelper_Out.FOut_Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加FHelper_Out对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(FHelper_Out fHelper_Out)
      {
         string sql = "INSERT INTO FHelper_Out (FOut_ID,FOut_Owner,FOut_Date,Fout_IsPrint,FOut_Num,FOut_OPType,FOut_Stat) VALUES (@FOut_ID,@FOut_Owner,@FOut_Date,@Fout_IsPrint,@FOut_Num,@FOut_OPType,@FOut_Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(fHelper_Out.FOut_Owner))
         {
            idb.AddParameter("@FOut_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_Owner", fHelper_Out.FOut_Owner);
         }
         if (fHelper_Out.FOut_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FOut_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_Date", fHelper_Out.FOut_Date);
         }
         if (fHelper_Out.Fout_IsPrint == 0)
         {
            idb.AddParameter("@Fout_IsPrint", 0);
         }
         else
         {
            idb.AddParameter("@Fout_IsPrint", fHelper_Out.Fout_IsPrint);
         }
         if (fHelper_Out.FOut_Num == 0)
         {
            idb.AddParameter("@FOut_Num", 0);
         }
         else
         {
            idb.AddParameter("@FOut_Num", fHelper_Out.FOut_Num);
         }
         if (string.IsNullOrEmpty(fHelper_Out.FOut_OPType))
         {
            idb.AddParameter("@FOut_OPType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_OPType", fHelper_Out.FOut_OPType);
         }
         if (fHelper_Out.FOut_Stat == 0)
         {
            idb.AddParameter("@FOut_Stat", 0);
         }
         else
         {
            idb.AddParameter("@FOut_Stat", fHelper_Out.FOut_Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新FHelper_Out对象(即:一条记录
      /// </summary>
      public int Update(FHelper_Out fHelper_Out)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       FHelper_Out       SET ");
            if(fHelper_Out.FOut_Owner_IsChanged){sbParameter.Append("FOut_Owner=@FOut_Owner, ");}
      if(fHelper_Out.FOut_Date_IsChanged){sbParameter.Append("FOut_Date=@FOut_Date, ");}
      if(fHelper_Out.Fout_IsPrint_IsChanged){sbParameter.Append("Fout_IsPrint=@Fout_IsPrint, ");}
      if(fHelper_Out.FOut_Num_IsChanged){sbParameter.Append("FOut_Num=@FOut_Num, ");}
      if(fHelper_Out.FOut_OPType_IsChanged){sbParameter.Append("FOut_OPType=@FOut_OPType, ");}
      if(fHelper_Out.FOut_Stat_IsChanged){sbParameter.Append("FOut_Stat=@FOut_Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FOut_ID=@FOut_ID; " );
      string sql=sb.ToString();
         if(fHelper_Out.FOut_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Out.FOut_Owner))
         {
            idb.AddParameter("@FOut_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_Owner", fHelper_Out.FOut_Owner);
         }
          }
         if(fHelper_Out.FOut_Date_IsChanged)
         {
         if (fHelper_Out.FOut_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FOut_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_Date", fHelper_Out.FOut_Date);
         }
          }
         if(fHelper_Out.Fout_IsPrint_IsChanged)
         {
         if (fHelper_Out.Fout_IsPrint == 0)
         {
            idb.AddParameter("@Fout_IsPrint", 0);
         }
         else
         {
            idb.AddParameter("@Fout_IsPrint", fHelper_Out.Fout_IsPrint);
         }
          }
         if(fHelper_Out.FOut_Num_IsChanged)
         {
         if (fHelper_Out.FOut_Num == 0)
         {
            idb.AddParameter("@FOut_Num", 0);
         }
         else
         {
            idb.AddParameter("@FOut_Num", fHelper_Out.FOut_Num);
         }
          }
         if(fHelper_Out.FOut_OPType_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Out.FOut_OPType))
         {
            idb.AddParameter("@FOut_OPType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FOut_OPType", fHelper_Out.FOut_OPType);
         }
          }
         if(fHelper_Out.FOut_Stat_IsChanged)
         {
         if (fHelper_Out.FOut_Stat == 0)
         {
            idb.AddParameter("@FOut_Stat", 0);
         }
         else
         {
            idb.AddParameter("@FOut_Stat", fHelper_Out.FOut_Stat);
         }
          }

         idb.AddParameter("@FOut_ID", fHelper_Out.FOut_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除FHelper_Out对象(即:一条记录
      /// </summary>
      public int Delete(Int64 fOut_ID)
      {
         string sql = "DELETE FHelper_Out WHERE 1=1  AND FOut_ID=@FOut_ID ";
         idb.AddParameter("@FOut_ID", fOut_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的FHelper_Out对象(即:一条记录
      /// </summary>
      public FHelper_Out GetByKey(Int64 fOut_ID)
      {
         FHelper_Out fHelper_Out = new FHelper_Out();
         string sql = "SELECT  FOut_ID,FOut_Owner,FOut_Date,Fout_IsPrint,FOut_Num,FOut_OPType,FOut_Stat FROM FHelper_Out WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FOut_ID=@FOut_ID ";
         idb.AddParameter("@FOut_ID", fOut_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FOut_ID"] != DBNull.Value) fHelper_Out.FOut_ID = Convert.ToInt64(dr["FOut_ID"]);
            if (dr["FOut_Owner"] != DBNull.Value) fHelper_Out.FOut_Owner = Convert.ToString(dr["FOut_Owner"]);
            if (dr["FOut_Date"] != DBNull.Value) fHelper_Out.FOut_Date = Convert.ToDateTime(dr["FOut_Date"]);
            if (dr["Fout_IsPrint"] != DBNull.Value) fHelper_Out.Fout_IsPrint = Convert.ToInt32(dr["Fout_IsPrint"]);
            if (dr["FOut_Num"] != DBNull.Value) fHelper_Out.FOut_Num = Convert.ToInt32(dr["FOut_Num"]);
            if (dr["FOut_OPType"] != DBNull.Value) fHelper_Out.FOut_OPType = Convert.ToString(dr["FOut_OPType"]);
            if (dr["FOut_Stat"] != DBNull.Value) fHelper_Out.FOut_Stat = Convert.ToInt32(dr["FOut_Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return fHelper_Out;
      }
      /// <summary>
      /// 获取指定的FHelper_Out对象集合
      /// </summary>
      public List<FHelper_Out> GetListByWhere(string strCondition)
      {
         List<FHelper_Out> ret = new List<FHelper_Out>();
         string sql = "SELECT  FOut_ID,FOut_Owner,FOut_Date,Fout_IsPrint,FOut_Num,FOut_OPType,FOut_Stat FROM FHelper_Out WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            FHelper_Out fHelper_Out = new FHelper_Out();
            if (dr["FOut_ID"] != DBNull.Value) fHelper_Out.FOut_ID = Convert.ToInt64(dr["FOut_ID"]);
            if (dr["FOut_Owner"] != DBNull.Value) fHelper_Out.FOut_Owner = Convert.ToString(dr["FOut_Owner"]);
            if (dr["FOut_Date"] != DBNull.Value) fHelper_Out.FOut_Date = Convert.ToDateTime(dr["FOut_Date"]);
            if (dr["Fout_IsPrint"] != DBNull.Value) fHelper_Out.Fout_IsPrint = Convert.ToInt32(dr["Fout_IsPrint"]);
            if (dr["FOut_Num"] != DBNull.Value) fHelper_Out.FOut_Num = Convert.ToInt32(dr["FOut_Num"]);
            if (dr["FOut_OPType"] != DBNull.Value) fHelper_Out.FOut_OPType = Convert.ToString(dr["FOut_OPType"]);
            if (dr["FOut_Stat"] != DBNull.Value) fHelper_Out.FOut_Stat = Convert.ToInt32(dr["FOut_Stat"]);
            ret.Add(fHelper_Out);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的FHelper_Out对象(即:一条记录
      /// </summary>
      public List<FHelper_Out> GetAll()
      {
         List<FHelper_Out> ret = new List<FHelper_Out>();
         string sql = "SELECT  FOut_ID,FOut_Owner,FOut_Date,Fout_IsPrint,FOut_Num,FOut_OPType,FOut_Stat FROM FHelper_Out where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            FHelper_Out fHelper_Out = new FHelper_Out();
            if (dr["FOut_ID"] != DBNull.Value) fHelper_Out.FOut_ID = Convert.ToInt64(dr["FOut_ID"]);
            if (dr["FOut_Owner"] != DBNull.Value) fHelper_Out.FOut_Owner = Convert.ToString(dr["FOut_Owner"]);
            if (dr["FOut_Date"] != DBNull.Value) fHelper_Out.FOut_Date = Convert.ToDateTime(dr["FOut_Date"]);
            if (dr["Fout_IsPrint"] != DBNull.Value) fHelper_Out.Fout_IsPrint = Convert.ToInt32(dr["Fout_IsPrint"]);
            if (dr["FOut_Num"] != DBNull.Value) fHelper_Out.FOut_Num = Convert.ToInt32(dr["FOut_Num"]);
            if (dr["FOut_OPType"] != DBNull.Value) fHelper_Out.FOut_OPType = Convert.ToString(dr["FOut_OPType"]);
            if (dr["FOut_Stat"] != DBNull.Value) fHelper_Out.FOut_Stat = Convert.ToInt32(dr["FOut_Stat"]);
            ret.Add(fHelper_Out);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
