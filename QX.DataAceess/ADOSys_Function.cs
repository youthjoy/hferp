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
   public partial class ADOSys_Function
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Function对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Function sys_Function)
      {
         string sql = "INSERT INTO Sys_Function (Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_Flag,Fun_Remark,Stat) VALUES (@Fun_Code,@Fun_Name,@Fun_PCode,@Fun_Order,@Fun_Flag,@Fun_Remark,@Stat)";
         if (string.IsNullOrEmpty(sys_Function.Fun_Code))
         {
            idb.AddParameter("@Fun_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Code", sys_Function.Fun_Code);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Name))
         {
            idb.AddParameter("@Fun_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Name", sys_Function.Fun_Name);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_PCode))
         {
            idb.AddParameter("@Fun_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_PCode", sys_Function.Fun_PCode);
         }
         if (sys_Function.Fun_Order == 0)
         {
            idb.AddParameter("@Fun_Order", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Order", sys_Function.Fun_Order);
         }
         if (sys_Function.Fun_Flag == 0)
         {
            idb.AddParameter("@Fun_Flag", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Flag", sys_Function.Fun_Flag);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Remark))
         {
            idb.AddParameter("@Fun_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Remark", sys_Function.Fun_Remark);
         }
         if (sys_Function.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Function.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_Function对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Function sys_Function)
      {
         string sql = "INSERT INTO Sys_Function (Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_Flag,Fun_Remark,Stat) VALUES (@Fun_Code,@Fun_Name,@Fun_PCode,@Fun_Order,@Fun_Flag,@Fun_Remark,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Function.Fun_Code))
         {
            idb.AddParameter("@Fun_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Code", sys_Function.Fun_Code);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Name))
         {
            idb.AddParameter("@Fun_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Name", sys_Function.Fun_Name);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_PCode))
         {
            idb.AddParameter("@Fun_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_PCode", sys_Function.Fun_PCode);
         }
         if (sys_Function.Fun_Order == 0)
         {
            idb.AddParameter("@Fun_Order", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Order", sys_Function.Fun_Order);
         }
         if (sys_Function.Fun_Flag == 0)
         {
            idb.AddParameter("@Fun_Flag", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Flag", sys_Function.Fun_Flag);
         }
         if (string.IsNullOrEmpty(sys_Function.Fun_Remark))
         {
            idb.AddParameter("@Fun_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Remark", sys_Function.Fun_Remark);
         }
         if (sys_Function.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Function.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_Function对象(即:一条记录
      /// </summary>
      public int Update(Sys_Function sys_Function)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Function       SET ");
            if(sys_Function.Fun_Code_IsChanged){sbParameter.Append("Fun_Code=@Fun_Code, ");}
      if(sys_Function.Fun_Name_IsChanged){sbParameter.Append("Fun_Name=@Fun_Name, ");}
      if(sys_Function.Fun_PCode_IsChanged){sbParameter.Append("Fun_PCode=@Fun_PCode, ");}
      if(sys_Function.Fun_Order_IsChanged){sbParameter.Append("Fun_Order=@Fun_Order, ");}
      if(sys_Function.Fun_Flag_IsChanged){sbParameter.Append("Fun_Flag=@Fun_Flag, ");}
      if(sys_Function.Fun_Remark_IsChanged){sbParameter.Append("Fun_Remark=@Fun_Remark, ");}
      if(sys_Function.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Fun_ID=@Fun_ID; " );
      string sql=sb.ToString();
         if(sys_Function.Fun_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_Code))
         {
            idb.AddParameter("@Fun_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Code", sys_Function.Fun_Code);
         }
          }
         if(sys_Function.Fun_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_Name))
         {
            idb.AddParameter("@Fun_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Name", sys_Function.Fun_Name);
         }
          }
         if(sys_Function.Fun_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_PCode))
         {
            idb.AddParameter("@Fun_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_PCode", sys_Function.Fun_PCode);
         }
          }
         if(sys_Function.Fun_Order_IsChanged)
         {
         if (sys_Function.Fun_Order == 0)
         {
            idb.AddParameter("@Fun_Order", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Order", sys_Function.Fun_Order);
         }
          }
         if(sys_Function.Fun_Flag_IsChanged)
         {
         if (sys_Function.Fun_Flag == 0)
         {
            idb.AddParameter("@Fun_Flag", 0);
         }
         else
         {
            idb.AddParameter("@Fun_Flag", sys_Function.Fun_Flag);
         }
          }
         if(sys_Function.Fun_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Function.Fun_Remark))
         {
            idb.AddParameter("@Fun_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Fun_Remark", sys_Function.Fun_Remark);
         }
          }
         if(sys_Function.Stat_IsChanged)
         {
         if (sys_Function.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Function.Stat);
         }
          }

         idb.AddParameter("@Fun_ID", sys_Function.Fun_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_Function对象(即:一条记录
      /// </summary>
      public int Delete(decimal fun_ID)
      {
         string sql = "DELETE Sys_Function WHERE 1=1  AND Fun_ID=@Fun_ID ";
         idb.AddParameter("@Fun_ID", fun_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_Function对象(即:一条记录
      /// </summary>
      public Sys_Function GetByKey(decimal fun_ID)
      {
         Sys_Function sys_Function = new Sys_Function();
         string sql = "SELECT  Fun_ID,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_Flag,Fun_Remark,Stat FROM Sys_Function WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Fun_ID=@Fun_ID ";
         idb.AddParameter("@Fun_ID", fun_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Fun_ID"] != DBNull.Value) sys_Function.Fun_ID = Convert.ToDecimal(dr["Fun_ID"]);
            if (dr["Fun_Code"] != DBNull.Value) sys_Function.Fun_Code = Convert.ToString(dr["Fun_Code"]);
            if (dr["Fun_Name"] != DBNull.Value) sys_Function.Fun_Name = Convert.ToString(dr["Fun_Name"]);
            if (dr["Fun_PCode"] != DBNull.Value) sys_Function.Fun_PCode = Convert.ToString(dr["Fun_PCode"]);
            if (dr["Fun_Order"] != DBNull.Value) sys_Function.Fun_Order = Convert.ToInt32(dr["Fun_Order"]);
            if (dr["Fun_Flag"] != DBNull.Value) sys_Function.Fun_Flag = Convert.ToInt32(dr["Fun_Flag"]);
            if (dr["Fun_Remark"] != DBNull.Value) sys_Function.Fun_Remark = Convert.ToString(dr["Fun_Remark"]);
            if (dr["Stat"] != DBNull.Value) sys_Function.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_Function;
      }
      /// <summary>
      /// 获取指定的Sys_Function对象集合
      /// </summary>
      public List<Sys_Function> GetListByWhere(string strCondition)
      {
         List<Sys_Function> ret = new List<Sys_Function>();
         string sql = "SELECT  Fun_ID,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_Flag,Fun_Remark,Stat FROM Sys_Function WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Function sys_Function = new Sys_Function();
            if (dr["Fun_ID"] != DBNull.Value) sys_Function.Fun_ID = Convert.ToDecimal(dr["Fun_ID"]);
            if (dr["Fun_Code"] != DBNull.Value) sys_Function.Fun_Code = Convert.ToString(dr["Fun_Code"]);
            if (dr["Fun_Name"] != DBNull.Value) sys_Function.Fun_Name = Convert.ToString(dr["Fun_Name"]);
            if (dr["Fun_PCode"] != DBNull.Value) sys_Function.Fun_PCode = Convert.ToString(dr["Fun_PCode"]);
            if (dr["Fun_Order"] != DBNull.Value) sys_Function.Fun_Order = Convert.ToInt32(dr["Fun_Order"]);
            if (dr["Fun_Flag"] != DBNull.Value) sys_Function.Fun_Flag = Convert.ToInt32(dr["Fun_Flag"]);
            if (dr["Fun_Remark"] != DBNull.Value) sys_Function.Fun_Remark = Convert.ToString(dr["Fun_Remark"]);
            if (dr["Stat"] != DBNull.Value) sys_Function.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Function);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Function对象(即:一条记录
      /// </summary>
      public List<Sys_Function> GetAll()
      {
         List<Sys_Function> ret = new List<Sys_Function>();
         string sql = "SELECT  Fun_ID,Fun_Code,Fun_Name,Fun_PCode,Fun_Order,Fun_Flag,Fun_Remark,Stat FROM Sys_Function where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Function sys_Function = new Sys_Function();
            if (dr["Fun_ID"] != DBNull.Value) sys_Function.Fun_ID = Convert.ToDecimal(dr["Fun_ID"]);
            if (dr["Fun_Code"] != DBNull.Value) sys_Function.Fun_Code = Convert.ToString(dr["Fun_Code"]);
            if (dr["Fun_Name"] != DBNull.Value) sys_Function.Fun_Name = Convert.ToString(dr["Fun_Name"]);
            if (dr["Fun_PCode"] != DBNull.Value) sys_Function.Fun_PCode = Convert.ToString(dr["Fun_PCode"]);
            if (dr["Fun_Order"] != DBNull.Value) sys_Function.Fun_Order = Convert.ToInt32(dr["Fun_Order"]);
            if (dr["Fun_Flag"] != DBNull.Value) sys_Function.Fun_Flag = Convert.ToInt32(dr["Fun_Flag"]);
            if (dr["Fun_Remark"] != DBNull.Value) sys_Function.Fun_Remark = Convert.ToString(dr["Fun_Remark"]);
            if (dr["Stat"] != DBNull.Value) sys_Function.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_Function);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
