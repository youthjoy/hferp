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
   public partial class ADOSys_Control
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Sys_Control对象(即:一条记录)
      /// </summary>
      public int Add(Sys_Control sys_Control)
      {
         string sql = "INSERT INTO Sys_Control (Sys_Win,Sys_Key,Sys_ControlName,Sys_ControlLabel,Sys_ControlDefault,Sys_DBTable,Sys_DBCol,Sys_IsDefault,Stat,Sys_TextBoxName,IsAllowEdit) VALUES (@Sys_Win,@Sys_Key,@Sys_ControlName,@Sys_ControlLabel,@Sys_ControlDefault,@Sys_DBTable,@Sys_DBCol,@Sys_IsDefault,@Stat,@Sys_TextBoxName,@IsAllowEdit)";
         if (string.IsNullOrEmpty(sys_Control.Sys_Win))
         {
            idb.AddParameter("@Sys_Win", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Win", sys_Control.Sys_Win);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_Key))
         {
            idb.AddParameter("@Sys_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Key", sys_Control.Sys_Key);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlName))
         {
            idb.AddParameter("@Sys_ControlName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlName", sys_Control.Sys_ControlName);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlLabel))
         {
            idb.AddParameter("@Sys_ControlLabel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlLabel", sys_Control.Sys_ControlLabel);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlDefault))
         {
            idb.AddParameter("@Sys_ControlDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlDefault", sys_Control.Sys_ControlDefault);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_DBTable))
         {
            idb.AddParameter("@Sys_DBTable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_DBTable", sys_Control.Sys_DBTable);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_DBCol))
         {
            idb.AddParameter("@Sys_DBCol", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_DBCol", sys_Control.Sys_DBCol);
         }
         if (sys_Control.Sys_IsDefault == 0)
         {
            idb.AddParameter("@Sys_IsDefault", 0);
         }
         else
         {
            idb.AddParameter("@Sys_IsDefault", sys_Control.Sys_IsDefault);
         }
         if (sys_Control.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Control.Stat);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_TextBoxName))
         {
            idb.AddParameter("@Sys_TextBoxName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_TextBoxName", sys_Control.Sys_TextBoxName);
         }
         if (sys_Control.IsAllowEdit == 0)
         {
            idb.AddParameter("@IsAllowEdit", 0);
         }
         else
         {
            idb.AddParameter("@IsAllowEdit", sys_Control.IsAllowEdit);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Sys_Control对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_Control sys_Control)
      {
         string sql = "INSERT INTO Sys_Control (Sys_Win,Sys_Key,Sys_ControlName,Sys_ControlLabel,Sys_ControlDefault,Sys_DBTable,Sys_DBCol,Sys_IsDefault,Stat,Sys_TextBoxName,IsAllowEdit) VALUES (@Sys_Win,@Sys_Key,@Sys_ControlName,@Sys_ControlLabel,@Sys_ControlDefault,@Sys_DBTable,@Sys_DBCol,@Sys_IsDefault,@Stat,@Sys_TextBoxName,@IsAllowEdit);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_Control.Sys_Win))
         {
            idb.AddParameter("@Sys_Win", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Win", sys_Control.Sys_Win);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_Key))
         {
            idb.AddParameter("@Sys_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Key", sys_Control.Sys_Key);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlName))
         {
            idb.AddParameter("@Sys_ControlName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlName", sys_Control.Sys_ControlName);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlLabel))
         {
            idb.AddParameter("@Sys_ControlLabel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlLabel", sys_Control.Sys_ControlLabel);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlDefault))
         {
            idb.AddParameter("@Sys_ControlDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlDefault", sys_Control.Sys_ControlDefault);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_DBTable))
         {
            idb.AddParameter("@Sys_DBTable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_DBTable", sys_Control.Sys_DBTable);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_DBCol))
         {
            idb.AddParameter("@Sys_DBCol", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_DBCol", sys_Control.Sys_DBCol);
         }
         if (sys_Control.Sys_IsDefault == 0)
         {
            idb.AddParameter("@Sys_IsDefault", 0);
         }
         else
         {
            idb.AddParameter("@Sys_IsDefault", sys_Control.Sys_IsDefault);
         }
         if (sys_Control.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Control.Stat);
         }
         if (string.IsNullOrEmpty(sys_Control.Sys_TextBoxName))
         {
            idb.AddParameter("@Sys_TextBoxName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_TextBoxName", sys_Control.Sys_TextBoxName);
         }
         if (sys_Control.IsAllowEdit == 0)
         {
            idb.AddParameter("@IsAllowEdit", 0);
         }
         else
         {
            idb.AddParameter("@IsAllowEdit", sys_Control.IsAllowEdit);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Sys_Control对象(即:一条记录
      /// </summary>
      public int Update(Sys_Control sys_Control)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_Control       SET ");
            if(sys_Control.Sys_Win_IsChanged){sbParameter.Append("Sys_Win=@Sys_Win, ");}
      if(sys_Control.Sys_Key_IsChanged){sbParameter.Append("Sys_Key=@Sys_Key, ");}
      if(sys_Control.Sys_ControlName_IsChanged){sbParameter.Append("Sys_ControlName=@Sys_ControlName, ");}
      if(sys_Control.Sys_ControlLabel_IsChanged){sbParameter.Append("Sys_ControlLabel=@Sys_ControlLabel, ");}
      if(sys_Control.Sys_ControlDefault_IsChanged){sbParameter.Append("Sys_ControlDefault=@Sys_ControlDefault, ");}
      if(sys_Control.Sys_DBTable_IsChanged){sbParameter.Append("Sys_DBTable=@Sys_DBTable, ");}
      if(sys_Control.Sys_DBCol_IsChanged){sbParameter.Append("Sys_DBCol=@Sys_DBCol, ");}
      if(sys_Control.Sys_IsDefault_IsChanged){sbParameter.Append("Sys_IsDefault=@Sys_IsDefault, ");}
      if(sys_Control.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sys_Control.Sys_TextBoxName_IsChanged){sbParameter.Append("Sys_TextBoxName=@Sys_TextBoxName, ");}
      if(sys_Control.IsAllowEdit_IsChanged){sbParameter.Append("IsAllowEdit=@IsAllowEdit ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Sys_ID=@Sys_ID; " );
      string sql=sb.ToString();
         if(sys_Control.Sys_Win_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_Win))
         {
            idb.AddParameter("@Sys_Win", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Win", sys_Control.Sys_Win);
         }
          }
         if(sys_Control.Sys_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_Key))
         {
            idb.AddParameter("@Sys_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Key", sys_Control.Sys_Key);
         }
          }
         if(sys_Control.Sys_ControlName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlName))
         {
            idb.AddParameter("@Sys_ControlName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlName", sys_Control.Sys_ControlName);
         }
          }
         if(sys_Control.Sys_ControlLabel_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlLabel))
         {
            idb.AddParameter("@Sys_ControlLabel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlLabel", sys_Control.Sys_ControlLabel);
         }
          }
         if(sys_Control.Sys_ControlDefault_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_ControlDefault))
         {
            idb.AddParameter("@Sys_ControlDefault", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_ControlDefault", sys_Control.Sys_ControlDefault);
         }
          }
         if(sys_Control.Sys_DBTable_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_DBTable))
         {
            idb.AddParameter("@Sys_DBTable", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_DBTable", sys_Control.Sys_DBTable);
         }
          }
         if(sys_Control.Sys_DBCol_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_DBCol))
         {
            idb.AddParameter("@Sys_DBCol", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_DBCol", sys_Control.Sys_DBCol);
         }
          }
         if(sys_Control.Sys_IsDefault_IsChanged)
         {
         if (sys_Control.Sys_IsDefault == 0)
         {
            idb.AddParameter("@Sys_IsDefault", 0);
         }
         else
         {
            idb.AddParameter("@Sys_IsDefault", sys_Control.Sys_IsDefault);
         }
          }
         if(sys_Control.Stat_IsChanged)
         {
         if (sys_Control.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_Control.Stat);
         }
          }
         if(sys_Control.Sys_TextBoxName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_Control.Sys_TextBoxName))
         {
            idb.AddParameter("@Sys_TextBoxName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_TextBoxName", sys_Control.Sys_TextBoxName);
         }
          }
         if(sys_Control.IsAllowEdit_IsChanged)
         {
         if (sys_Control.IsAllowEdit == 0)
         {
            idb.AddParameter("@IsAllowEdit", 0);
         }
         else
         {
            idb.AddParameter("@IsAllowEdit", sys_Control.IsAllowEdit);
         }
          }

         idb.AddParameter("@Sys_ID", sys_Control.Sys_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Sys_Control对象(即:一条记录
      /// </summary>
      public int Delete(Int64 sys_ID)
      {
         string sql = "DELETE Sys_Control WHERE 1=1  AND Sys_ID=@Sys_ID ";
         idb.AddParameter("@Sys_ID", sys_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Sys_Control对象(即:一条记录
      /// </summary>
      public Sys_Control GetByKey(Int64 sys_ID)
      {
         Sys_Control sys_Control = new Sys_Control();
         string sql = "SELECT  Sys_ID,Sys_Win,Sys_Key,Sys_ControlName,Sys_ControlLabel,Sys_ControlDefault,Sys_DBTable,Sys_DBCol,Sys_IsDefault,Stat,Sys_TextBoxName,IsAllowEdit FROM Sys_Control WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Sys_ID=@Sys_ID ";
         idb.AddParameter("@Sys_ID", sys_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Sys_ID"] != DBNull.Value) sys_Control.Sys_ID = Convert.ToInt64(dr["Sys_ID"]);
            if (dr["Sys_Win"] != DBNull.Value) sys_Control.Sys_Win = Convert.ToString(dr["Sys_Win"]);
            if (dr["Sys_Key"] != DBNull.Value) sys_Control.Sys_Key = Convert.ToString(dr["Sys_Key"]);
            if (dr["Sys_ControlName"] != DBNull.Value) sys_Control.Sys_ControlName = Convert.ToString(dr["Sys_ControlName"]);
            if (dr["Sys_ControlLabel"] != DBNull.Value) sys_Control.Sys_ControlLabel = Convert.ToString(dr["Sys_ControlLabel"]);
            if (dr["Sys_ControlDefault"] != DBNull.Value) sys_Control.Sys_ControlDefault = Convert.ToString(dr["Sys_ControlDefault"]);
            if (dr["Sys_DBTable"] != DBNull.Value) sys_Control.Sys_DBTable = Convert.ToString(dr["Sys_DBTable"]);
            if (dr["Sys_DBCol"] != DBNull.Value) sys_Control.Sys_DBCol = Convert.ToString(dr["Sys_DBCol"]);
            if (dr["Sys_IsDefault"] != DBNull.Value) sys_Control.Sys_IsDefault = Convert.ToInt32(dr["Sys_IsDefault"]);
            if (dr["Stat"] != DBNull.Value) sys_Control.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Sys_TextBoxName"] != DBNull.Value) sys_Control.Sys_TextBoxName = Convert.ToString(dr["Sys_TextBoxName"]);
            if (dr["IsAllowEdit"] != DBNull.Value) sys_Control.IsAllowEdit = Convert.ToInt32(dr["IsAllowEdit"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return sys_Control;
      }
      /// <summary>
      /// 获取指定的Sys_Control对象集合
      /// </summary>
      public List<Sys_Control> GetListByWhere(string strCondition)
      {
         List<Sys_Control> ret = new List<Sys_Control>();
         string sql = "SELECT  Sys_ID,Sys_Win,Sys_Key,Sys_ControlName,Sys_ControlLabel,Sys_ControlDefault,Sys_DBTable,Sys_DBCol,Sys_IsDefault,Stat,Sys_TextBoxName,IsAllowEdit FROM Sys_Control WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Sys_Control sys_Control = new Sys_Control();
            if (dr["Sys_ID"] != DBNull.Value) sys_Control.Sys_ID = Convert.ToInt64(dr["Sys_ID"]);
            if (dr["Sys_Win"] != DBNull.Value) sys_Control.Sys_Win = Convert.ToString(dr["Sys_Win"]);
            if (dr["Sys_Key"] != DBNull.Value) sys_Control.Sys_Key = Convert.ToString(dr["Sys_Key"]);
            if (dr["Sys_ControlName"] != DBNull.Value) sys_Control.Sys_ControlName = Convert.ToString(dr["Sys_ControlName"]);
            if (dr["Sys_ControlLabel"] != DBNull.Value) sys_Control.Sys_ControlLabel = Convert.ToString(dr["Sys_ControlLabel"]);
            if (dr["Sys_ControlDefault"] != DBNull.Value) sys_Control.Sys_ControlDefault = Convert.ToString(dr["Sys_ControlDefault"]);
            if (dr["Sys_DBTable"] != DBNull.Value) sys_Control.Sys_DBTable = Convert.ToString(dr["Sys_DBTable"]);
            if (dr["Sys_DBCol"] != DBNull.Value) sys_Control.Sys_DBCol = Convert.ToString(dr["Sys_DBCol"]);
            if (dr["Sys_IsDefault"] != DBNull.Value) sys_Control.Sys_IsDefault = Convert.ToInt32(dr["Sys_IsDefault"]);
            if (dr["Stat"] != DBNull.Value) sys_Control.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Sys_TextBoxName"] != DBNull.Value) sys_Control.Sys_TextBoxName = Convert.ToString(dr["Sys_TextBoxName"]);
            if (dr["IsAllowEdit"] != DBNull.Value) sys_Control.IsAllowEdit = Convert.ToInt32(dr["IsAllowEdit"]);
            ret.Add(sys_Control);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的Sys_Control对象(即:一条记录
      /// </summary>
      public List<Sys_Control> GetAll()
      {
         List<Sys_Control> ret = new List<Sys_Control>();
         string sql = "SELECT  Sys_ID,Sys_Win,Sys_Key,Sys_ControlName,Sys_ControlLabel,Sys_ControlDefault,Sys_DBTable,Sys_DBCol,Sys_IsDefault,Stat,Sys_TextBoxName,IsAllowEdit FROM Sys_Control where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_Control sys_Control = new Sys_Control();
            if (dr["Sys_ID"] != DBNull.Value) sys_Control.Sys_ID = Convert.ToInt64(dr["Sys_ID"]);
            if (dr["Sys_Win"] != DBNull.Value) sys_Control.Sys_Win = Convert.ToString(dr["Sys_Win"]);
            if (dr["Sys_Key"] != DBNull.Value) sys_Control.Sys_Key = Convert.ToString(dr["Sys_Key"]);
            if (dr["Sys_ControlName"] != DBNull.Value) sys_Control.Sys_ControlName = Convert.ToString(dr["Sys_ControlName"]);
            if (dr["Sys_ControlLabel"] != DBNull.Value) sys_Control.Sys_ControlLabel = Convert.ToString(dr["Sys_ControlLabel"]);
            if (dr["Sys_ControlDefault"] != DBNull.Value) sys_Control.Sys_ControlDefault = Convert.ToString(dr["Sys_ControlDefault"]);
            if (dr["Sys_DBTable"] != DBNull.Value) sys_Control.Sys_DBTable = Convert.ToString(dr["Sys_DBTable"]);
            if (dr["Sys_DBCol"] != DBNull.Value) sys_Control.Sys_DBCol = Convert.ToString(dr["Sys_DBCol"]);
            if (dr["Sys_IsDefault"] != DBNull.Value) sys_Control.Sys_IsDefault = Convert.ToInt32(dr["Sys_IsDefault"]);
            if (dr["Stat"] != DBNull.Value) sys_Control.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Sys_TextBoxName"] != DBNull.Value) sys_Control.Sys_TextBoxName = Convert.ToString(dr["Sys_TextBoxName"]);
            if (dr["IsAllowEdit"] != DBNull.Value) sys_Control.IsAllowEdit = Convert.ToInt32(dr["IsAllowEdit"]);
            ret.Add(sys_Control);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
