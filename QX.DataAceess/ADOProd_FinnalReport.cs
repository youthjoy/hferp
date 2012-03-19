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
   public partial class ADOProd_FinnalReport
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Prod_FinnalReport对象(即:一条记录)
      /// </summary>
      public int Add(Prod_FinnalReport prod_FinnalReport)
      {
         string sql = "INSERT INTO Prod_FinnalReport (FReport_ProdCode,FReport_Order,FReport_Name,FReport_Real,FReport_Report,FReport_High,FReport_Low,Stat) VALUES (@FReport_ProdCode,@FReport_Order,@FReport_Name,@FReport_Real,@FReport_Report,@FReport_High,@FReport_Low,@Stat)";
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_ProdCode))
         {
            idb.AddParameter("@FReport_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_ProdCode", prod_FinnalReport.FReport_ProdCode);
         }
         if (prod_FinnalReport.FReport_Order == 0)
         {
            idb.AddParameter("@FReport_Order", 0);
         }
         else
         {
            idb.AddParameter("@FReport_Order", prod_FinnalReport.FReport_Order);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Name))
         {
            idb.AddParameter("@FReport_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Name", prod_FinnalReport.FReport_Name);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Real))
         {
            idb.AddParameter("@FReport_Real", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Real", prod_FinnalReport.FReport_Real);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Report))
         {
            idb.AddParameter("@FReport_Report", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Report", prod_FinnalReport.FReport_Report);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_High))
         {
            idb.AddParameter("@FReport_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_High", prod_FinnalReport.FReport_High);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Low))
         {
            idb.AddParameter("@FReport_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Low", prod_FinnalReport.FReport_Low);
         }
         if (prod_FinnalReport.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_FinnalReport.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Prod_FinnalReport对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_FinnalReport prod_FinnalReport)
      {
         string sql = "INSERT INTO Prod_FinnalReport (FReport_ProdCode,FReport_Order,FReport_Name,FReport_Real,FReport_Report,FReport_High,FReport_Low,Stat) VALUES (@FReport_ProdCode,@FReport_Order,@FReport_Name,@FReport_Real,@FReport_Report,@FReport_High,@FReport_Low,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_ProdCode))
         {
            idb.AddParameter("@FReport_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_ProdCode", prod_FinnalReport.FReport_ProdCode);
         }
         if (prod_FinnalReport.FReport_Order == 0)
         {
            idb.AddParameter("@FReport_Order", 0);
         }
         else
         {
            idb.AddParameter("@FReport_Order", prod_FinnalReport.FReport_Order);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Name))
         {
            idb.AddParameter("@FReport_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Name", prod_FinnalReport.FReport_Name);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Real))
         {
            idb.AddParameter("@FReport_Real", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Real", prod_FinnalReport.FReport_Real);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Report))
         {
            idb.AddParameter("@FReport_Report", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Report", prod_FinnalReport.FReport_Report);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_High))
         {
            idb.AddParameter("@FReport_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_High", prod_FinnalReport.FReport_High);
         }
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Low))
         {
            idb.AddParameter("@FReport_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Low", prod_FinnalReport.FReport_Low);
         }
         if (prod_FinnalReport.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_FinnalReport.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Prod_FinnalReport对象(即:一条记录
      /// </summary>
      public int Update(Prod_FinnalReport prod_FinnalReport)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_FinnalReport       SET ");
            if(prod_FinnalReport.FReport_ProdCode_IsChanged){sbParameter.Append("FReport_ProdCode=@FReport_ProdCode, ");}
      if(prod_FinnalReport.FReport_Order_IsChanged){sbParameter.Append("FReport_Order=@FReport_Order, ");}
      if(prod_FinnalReport.FReport_Name_IsChanged){sbParameter.Append("FReport_Name=@FReport_Name, ");}
      if(prod_FinnalReport.FReport_Real_IsChanged){sbParameter.Append("FReport_Real=@FReport_Real, ");}
      if(prod_FinnalReport.FReport_Report_IsChanged){sbParameter.Append("FReport_Report=@FReport_Report, ");}
      if(prod_FinnalReport.FReport_High_IsChanged){sbParameter.Append("FReport_High=@FReport_High, ");}
      if(prod_FinnalReport.FReport_Low_IsChanged){sbParameter.Append("FReport_Low=@FReport_Low, ");}
      if(prod_FinnalReport.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FReport_ID=@FReport_ID; " );
      string sql=sb.ToString();
         if(prod_FinnalReport.FReport_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_ProdCode))
         {
            idb.AddParameter("@FReport_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_ProdCode", prod_FinnalReport.FReport_ProdCode);
         }
          }
         if(prod_FinnalReport.FReport_Order_IsChanged)
         {
         if (prod_FinnalReport.FReport_Order == 0)
         {
            idb.AddParameter("@FReport_Order", 0);
         }
         else
         {
            idb.AddParameter("@FReport_Order", prod_FinnalReport.FReport_Order);
         }
          }
         if(prod_FinnalReport.FReport_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Name))
         {
            idb.AddParameter("@FReport_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Name", prod_FinnalReport.FReport_Name);
         }
          }
         if(prod_FinnalReport.FReport_Real_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Real))
         {
            idb.AddParameter("@FReport_Real", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Real", prod_FinnalReport.FReport_Real);
         }
          }
         if(prod_FinnalReport.FReport_Report_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Report))
         {
            idb.AddParameter("@FReport_Report", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Report", prod_FinnalReport.FReport_Report);
         }
          }
         if(prod_FinnalReport.FReport_High_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_High))
         {
            idb.AddParameter("@FReport_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_High", prod_FinnalReport.FReport_High);
         }
          }
         if(prod_FinnalReport.FReport_Low_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_FinnalReport.FReport_Low))
         {
            idb.AddParameter("@FReport_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FReport_Low", prod_FinnalReport.FReport_Low);
         }
          }
         if(prod_FinnalReport.Stat_IsChanged)
         {
         if (prod_FinnalReport.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_FinnalReport.Stat);
         }
          }

         idb.AddParameter("@FReport_ID", prod_FinnalReport.FReport_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Prod_FinnalReport对象(即:一条记录
      /// </summary>
      public int Delete(Int64 fReport_ID)
      {
         string sql = "DELETE Prod_FinnalReport WHERE 1=1  AND FReport_ID=@FReport_ID ";
         idb.AddParameter("@FReport_ID", fReport_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Prod_FinnalReport对象(即:一条记录
      /// </summary>
      public Prod_FinnalReport GetByKey(Int64 fReport_ID)
      {
         Prod_FinnalReport prod_FinnalReport = new Prod_FinnalReport();
         string sql = "SELECT  FReport_ID,FReport_ProdCode,FReport_Order,FReport_Name,FReport_Real,FReport_Report,FReport_High,FReport_Low,Stat FROM Prod_FinnalReport WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FReport_ID=@FReport_ID ";
         idb.AddParameter("@FReport_ID", fReport_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FReport_ID"] != DBNull.Value) prod_FinnalReport.FReport_ID = Convert.ToInt64(dr["FReport_ID"]);
            if (dr["FReport_ProdCode"] != DBNull.Value) prod_FinnalReport.FReport_ProdCode = Convert.ToString(dr["FReport_ProdCode"]);
            if (dr["FReport_Order"] != DBNull.Value) prod_FinnalReport.FReport_Order = Convert.ToInt32(dr["FReport_Order"]);
            if (dr["FReport_Name"] != DBNull.Value) prod_FinnalReport.FReport_Name = Convert.ToString(dr["FReport_Name"]);
            if (dr["FReport_Real"] != DBNull.Value) prod_FinnalReport.FReport_Real = Convert.ToString(dr["FReport_Real"]);
            if (dr["FReport_Report"] != DBNull.Value) prod_FinnalReport.FReport_Report = Convert.ToString(dr["FReport_Report"]);
            if (dr["FReport_High"] != DBNull.Value) prod_FinnalReport.FReport_High = Convert.ToString(dr["FReport_High"]);
            if (dr["FReport_Low"] != DBNull.Value) prod_FinnalReport.FReport_Low = Convert.ToString(dr["FReport_Low"]);
            if (dr["Stat"] != DBNull.Value) prod_FinnalReport.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_FinnalReport;
      }
      /// <summary>
      /// 获取指定的Prod_FinnalReport对象集合
      /// </summary>
      public List<Prod_FinnalReport> GetListByWhere(string strCondition)
      {
         List<Prod_FinnalReport> ret = new List<Prod_FinnalReport>();
         string sql = "SELECT  FReport_ID,FReport_ProdCode,FReport_Order,FReport_Name,FReport_Real,FReport_Report,FReport_High,FReport_Low,Stat FROM Prod_FinnalReport WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_FinnalReport prod_FinnalReport = new Prod_FinnalReport();
            if (dr["FReport_ID"] != DBNull.Value) prod_FinnalReport.FReport_ID = Convert.ToInt64(dr["FReport_ID"]);
            if (dr["FReport_ProdCode"] != DBNull.Value) prod_FinnalReport.FReport_ProdCode = Convert.ToString(dr["FReport_ProdCode"]);
            if (dr["FReport_Order"] != DBNull.Value) prod_FinnalReport.FReport_Order = Convert.ToInt32(dr["FReport_Order"]);
            if (dr["FReport_Name"] != DBNull.Value) prod_FinnalReport.FReport_Name = Convert.ToString(dr["FReport_Name"]);
            if (dr["FReport_Real"] != DBNull.Value) prod_FinnalReport.FReport_Real = Convert.ToString(dr["FReport_Real"]);
            if (dr["FReport_Report"] != DBNull.Value) prod_FinnalReport.FReport_Report = Convert.ToString(dr["FReport_Report"]);
            if (dr["FReport_High"] != DBNull.Value) prod_FinnalReport.FReport_High = Convert.ToString(dr["FReport_High"]);
            if (dr["FReport_Low"] != DBNull.Value) prod_FinnalReport.FReport_Low = Convert.ToString(dr["FReport_Low"]);
            if (dr["Stat"] != DBNull.Value) prod_FinnalReport.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_FinnalReport);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Prod_FinnalReport对象(即:一条记录
      /// </summary>
      public List<Prod_FinnalReport> GetAll()
      {
         List<Prod_FinnalReport> ret = new List<Prod_FinnalReport>();
         string sql = "SELECT  FReport_ID,FReport_ProdCode,FReport_Order,FReport_Name,FReport_Real,FReport_Report,FReport_High,FReport_Low,Stat FROM Prod_FinnalReport where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_FinnalReport prod_FinnalReport = new Prod_FinnalReport();
            if (dr["FReport_ID"] != DBNull.Value) prod_FinnalReport.FReport_ID = Convert.ToInt64(dr["FReport_ID"]);
            if (dr["FReport_ProdCode"] != DBNull.Value) prod_FinnalReport.FReport_ProdCode = Convert.ToString(dr["FReport_ProdCode"]);
            if (dr["FReport_Order"] != DBNull.Value) prod_FinnalReport.FReport_Order = Convert.ToInt32(dr["FReport_Order"]);
            if (dr["FReport_Name"] != DBNull.Value) prod_FinnalReport.FReport_Name = Convert.ToString(dr["FReport_Name"]);
            if (dr["FReport_Real"] != DBNull.Value) prod_FinnalReport.FReport_Real = Convert.ToString(dr["FReport_Real"]);
            if (dr["FReport_Report"] != DBNull.Value) prod_FinnalReport.FReport_Report = Convert.ToString(dr["FReport_Report"]);
            if (dr["FReport_High"] != DBNull.Value) prod_FinnalReport.FReport_High = Convert.ToString(dr["FReport_High"]);
            if (dr["FReport_Low"] != DBNull.Value) prod_FinnalReport.FReport_Low = Convert.ToString(dr["FReport_Low"]);
            if (dr["Stat"] != DBNull.Value) prod_FinnalReport.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_FinnalReport);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
