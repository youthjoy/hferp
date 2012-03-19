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
   public partial class ADOFHelper_Price
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加FHelper_Price对象(即:一条记录)
      /// </summary>
      public int Add(FHelper_Price fHelper_Price)
      {
         string sql = "INSERT INTO FHelper_Price (FP_Code,FP_ManuName,FP_ManuCode,FP_CompName,FP_CompCode,FP_RefComptCode,FP_NodeName,FP_PNodeCode,FP_Price,FP_Creator,FP_Creatime,FP_CurNode,FP_Stat,Stat,AuditStat,AuditCurAudit) VALUES (@FP_Code,@FP_ManuName,@FP_ManuCode,@FP_CompName,@FP_CompCode,@FP_RefComptCode,@FP_NodeName,@FP_PNodeCode,@FP_Price,@FP_Creator,@FP_Creatime,@FP_CurNode,@FP_Stat,@Stat,@AuditStat,@AuditCurAudit)";
         if (string.IsNullOrEmpty(fHelper_Price.FP_Code))
         {
            idb.AddParameter("@FP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Code", fHelper_Price.FP_Code);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_ManuName))
         {
            idb.AddParameter("@FP_ManuName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_ManuName", fHelper_Price.FP_ManuName);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_ManuCode))
         {
            idb.AddParameter("@FP_ManuCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_ManuCode", fHelper_Price.FP_ManuCode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_CompName))
         {
            idb.AddParameter("@FP_CompName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CompName", fHelper_Price.FP_CompName);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_CompCode))
         {
            idb.AddParameter("@FP_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CompCode", fHelper_Price.FP_CompCode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_RefComptCode))
         {
            idb.AddParameter("@FP_RefComptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_RefComptCode", fHelper_Price.FP_RefComptCode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_NodeName))
         {
            idb.AddParameter("@FP_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_NodeName", fHelper_Price.FP_NodeName);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_PNodeCode))
         {
            idb.AddParameter("@FP_PNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_PNodeCode", fHelper_Price.FP_PNodeCode);
         }
         if (fHelper_Price.FP_Price == 0)
         {
            idb.AddParameter("@FP_Price", 0);
         }
         else
         {
            idb.AddParameter("@FP_Price", fHelper_Price.FP_Price);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_Creator))
         {
            idb.AddParameter("@FP_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Creator", fHelper_Price.FP_Creator);
         }
         if (fHelper_Price.FP_Creatime == DateTime.MinValue)
         {
            idb.AddParameter("@FP_Creatime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Creatime", fHelper_Price.FP_Creatime);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_CurNode))
         {
            idb.AddParameter("@FP_CurNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CurNode", fHelper_Price.FP_CurNode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_Stat))
         {
            idb.AddParameter("@FP_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Stat", fHelper_Price.FP_Stat);
         }
         if (fHelper_Price.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_Price.Stat);
         }
         if (string.IsNullOrEmpty(fHelper_Price.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", fHelper_Price.AuditStat);
         }
         if (string.IsNullOrEmpty(fHelper_Price.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", fHelper_Price.AuditCurAudit);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加FHelper_Price对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(FHelper_Price fHelper_Price)
      {
         string sql = "INSERT INTO FHelper_Price (FP_Code,FP_ManuName,FP_ManuCode,FP_CompName,FP_CompCode,FP_RefComptCode,FP_NodeName,FP_PNodeCode,FP_Price,FP_Creator,FP_Creatime,FP_CurNode,FP_Stat,Stat,AuditStat,AuditCurAudit) VALUES (@FP_Code,@FP_ManuName,@FP_ManuCode,@FP_CompName,@FP_CompCode,@FP_RefComptCode,@FP_NodeName,@FP_PNodeCode,@FP_Price,@FP_Creator,@FP_Creatime,@FP_CurNode,@FP_Stat,@Stat,@AuditStat,@AuditCurAudit);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(fHelper_Price.FP_Code))
         {
            idb.AddParameter("@FP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Code", fHelper_Price.FP_Code);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_ManuName))
         {
            idb.AddParameter("@FP_ManuName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_ManuName", fHelper_Price.FP_ManuName);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_ManuCode))
         {
            idb.AddParameter("@FP_ManuCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_ManuCode", fHelper_Price.FP_ManuCode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_CompName))
         {
            idb.AddParameter("@FP_CompName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CompName", fHelper_Price.FP_CompName);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_CompCode))
         {
            idb.AddParameter("@FP_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CompCode", fHelper_Price.FP_CompCode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_RefComptCode))
         {
            idb.AddParameter("@FP_RefComptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_RefComptCode", fHelper_Price.FP_RefComptCode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_NodeName))
         {
            idb.AddParameter("@FP_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_NodeName", fHelper_Price.FP_NodeName);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_PNodeCode))
         {
            idb.AddParameter("@FP_PNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_PNodeCode", fHelper_Price.FP_PNodeCode);
         }
         if (fHelper_Price.FP_Price == 0)
         {
            idb.AddParameter("@FP_Price", 0);
         }
         else
         {
            idb.AddParameter("@FP_Price", fHelper_Price.FP_Price);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_Creator))
         {
            idb.AddParameter("@FP_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Creator", fHelper_Price.FP_Creator);
         }
         if (fHelper_Price.FP_Creatime == DateTime.MinValue)
         {
            idb.AddParameter("@FP_Creatime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Creatime", fHelper_Price.FP_Creatime);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_CurNode))
         {
            idb.AddParameter("@FP_CurNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CurNode", fHelper_Price.FP_CurNode);
         }
         if (string.IsNullOrEmpty(fHelper_Price.FP_Stat))
         {
            idb.AddParameter("@FP_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Stat", fHelper_Price.FP_Stat);
         }
         if (fHelper_Price.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_Price.Stat);
         }
         if (string.IsNullOrEmpty(fHelper_Price.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", fHelper_Price.AuditStat);
         }
         if (string.IsNullOrEmpty(fHelper_Price.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", fHelper_Price.AuditCurAudit);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新FHelper_Price对象(即:一条记录
      /// </summary>
      public int Update(FHelper_Price fHelper_Price)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       FHelper_Price       SET ");
            if(fHelper_Price.FP_Code_IsChanged){sbParameter.Append("FP_Code=@FP_Code, ");}
      if(fHelper_Price.FP_ManuName_IsChanged){sbParameter.Append("FP_ManuName=@FP_ManuName, ");}
      if(fHelper_Price.FP_ManuCode_IsChanged){sbParameter.Append("FP_ManuCode=@FP_ManuCode, ");}
      if(fHelper_Price.FP_CompName_IsChanged){sbParameter.Append("FP_CompName=@FP_CompName, ");}
      if(fHelper_Price.FP_CompCode_IsChanged){sbParameter.Append("FP_CompCode=@FP_CompCode, ");}
      if(fHelper_Price.FP_RefComptCode_IsChanged){sbParameter.Append("FP_RefComptCode=@FP_RefComptCode, ");}
      if(fHelper_Price.FP_NodeName_IsChanged){sbParameter.Append("FP_NodeName=@FP_NodeName, ");}
      if(fHelper_Price.FP_PNodeCode_IsChanged){sbParameter.Append("FP_PNodeCode=@FP_PNodeCode, ");}
      if(fHelper_Price.FP_Price_IsChanged){sbParameter.Append("FP_Price=@FP_Price, ");}
      if(fHelper_Price.FP_Creator_IsChanged){sbParameter.Append("FP_Creator=@FP_Creator, ");}
      if(fHelper_Price.FP_Creatime_IsChanged){sbParameter.Append("FP_Creatime=@FP_Creatime, ");}
      if(fHelper_Price.FP_CurNode_IsChanged){sbParameter.Append("FP_CurNode=@FP_CurNode, ");}
      if(fHelper_Price.FP_Stat_IsChanged){sbParameter.Append("FP_Stat=@FP_Stat, ");}
      if(fHelper_Price.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(fHelper_Price.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(fHelper_Price.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FP_ID=@FP_ID; " );
      string sql=sb.ToString();
         if(fHelper_Price.FP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_Code))
         {
            idb.AddParameter("@FP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Code", fHelper_Price.FP_Code);
         }
          }
         if(fHelper_Price.FP_ManuName_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_ManuName))
         {
            idb.AddParameter("@FP_ManuName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_ManuName", fHelper_Price.FP_ManuName);
         }
          }
         if(fHelper_Price.FP_ManuCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_ManuCode))
         {
            idb.AddParameter("@FP_ManuCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_ManuCode", fHelper_Price.FP_ManuCode);
         }
          }
         if(fHelper_Price.FP_CompName_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_CompName))
         {
            idb.AddParameter("@FP_CompName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CompName", fHelper_Price.FP_CompName);
         }
          }
         if(fHelper_Price.FP_CompCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_CompCode))
         {
            idb.AddParameter("@FP_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CompCode", fHelper_Price.FP_CompCode);
         }
          }
         if(fHelper_Price.FP_RefComptCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_RefComptCode))
         {
            idb.AddParameter("@FP_RefComptCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_RefComptCode", fHelper_Price.FP_RefComptCode);
         }
          }
         if(fHelper_Price.FP_NodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_NodeName))
         {
            idb.AddParameter("@FP_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_NodeName", fHelper_Price.FP_NodeName);
         }
          }
         if(fHelper_Price.FP_PNodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_PNodeCode))
         {
            idb.AddParameter("@FP_PNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_PNodeCode", fHelper_Price.FP_PNodeCode);
         }
          }
         if(fHelper_Price.FP_Price_IsChanged)
         {
         if (fHelper_Price.FP_Price == 0)
         {
            idb.AddParameter("@FP_Price", 0);
         }
         else
         {
            idb.AddParameter("@FP_Price", fHelper_Price.FP_Price);
         }
          }
         if(fHelper_Price.FP_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_Creator))
         {
            idb.AddParameter("@FP_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Creator", fHelper_Price.FP_Creator);
         }
          }
         if(fHelper_Price.FP_Creatime_IsChanged)
         {
         if (fHelper_Price.FP_Creatime == DateTime.MinValue)
         {
            idb.AddParameter("@FP_Creatime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Creatime", fHelper_Price.FP_Creatime);
         }
          }
         if(fHelper_Price.FP_CurNode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_CurNode))
         {
            idb.AddParameter("@FP_CurNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_CurNode", fHelper_Price.FP_CurNode);
         }
          }
         if(fHelper_Price.FP_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.FP_Stat))
         {
            idb.AddParameter("@FP_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FP_Stat", fHelper_Price.FP_Stat);
         }
          }
         if(fHelper_Price.Stat_IsChanged)
         {
         if (fHelper_Price.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_Price.Stat);
         }
          }
         if(fHelper_Price.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", fHelper_Price.AuditStat);
         }
          }
         if(fHelper_Price.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Price.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", fHelper_Price.AuditCurAudit);
         }
          }

         idb.AddParameter("@FP_ID", fHelper_Price.FP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除FHelper_Price对象(即:一条记录
      /// </summary>
      public int Delete(int fP_ID)
      {
         string sql = "DELETE FHelper_Price WHERE 1=1  AND FP_ID=@FP_ID ";
         idb.AddParameter("@FP_ID", fP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的FHelper_Price对象(即:一条记录
      /// </summary>
      public FHelper_Price GetByKey(int fP_ID)
      {
         FHelper_Price fHelper_Price = new FHelper_Price();
         string sql = "SELECT  FP_ID,FP_Code,FP_ManuName,FP_ManuCode,FP_CompName,FP_CompCode,FP_RefComptCode,FP_NodeName,FP_PNodeCode,FP_Price,FP_Creator,FP_Creatime,FP_CurNode,FP_Stat,Stat,AuditStat,AuditCurAudit FROM FHelper_Price WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FP_ID=@FP_ID ";
         idb.AddParameter("@FP_ID", fP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FP_ID"] != DBNull.Value) fHelper_Price.FP_ID = Convert.ToInt32(dr["FP_ID"]);
            if (dr["FP_Code"] != DBNull.Value) fHelper_Price.FP_Code = Convert.ToString(dr["FP_Code"]);
            if (dr["FP_ManuName"] != DBNull.Value) fHelper_Price.FP_ManuName = Convert.ToString(dr["FP_ManuName"]);
            if (dr["FP_ManuCode"] != DBNull.Value) fHelper_Price.FP_ManuCode = Convert.ToString(dr["FP_ManuCode"]);
            if (dr["FP_CompName"] != DBNull.Value) fHelper_Price.FP_CompName = Convert.ToString(dr["FP_CompName"]);
            if (dr["FP_CompCode"] != DBNull.Value) fHelper_Price.FP_CompCode = Convert.ToString(dr["FP_CompCode"]);
            if (dr["FP_RefComptCode"] != DBNull.Value) fHelper_Price.FP_RefComptCode = Convert.ToString(dr["FP_RefComptCode"]);
            if (dr["FP_NodeName"] != DBNull.Value) fHelper_Price.FP_NodeName = Convert.ToString(dr["FP_NodeName"]);
            if (dr["FP_PNodeCode"] != DBNull.Value) fHelper_Price.FP_PNodeCode = Convert.ToString(dr["FP_PNodeCode"]);
            if (dr["FP_Price"] != DBNull.Value) fHelper_Price.FP_Price = Convert.ToDecimal(dr["FP_Price"]);
            if (dr["FP_Creator"] != DBNull.Value) fHelper_Price.FP_Creator = Convert.ToString(dr["FP_Creator"]);
            if (dr["FP_Creatime"] != DBNull.Value) fHelper_Price.FP_Creatime = Convert.ToDateTime(dr["FP_Creatime"]);
            if (dr["FP_CurNode"] != DBNull.Value) fHelper_Price.FP_CurNode = Convert.ToString(dr["FP_CurNode"]);
            if (dr["FP_Stat"] != DBNull.Value) fHelper_Price.FP_Stat = Convert.ToString(dr["FP_Stat"]);
            if (dr["Stat"] != DBNull.Value) fHelper_Price.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) fHelper_Price.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) fHelper_Price.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return fHelper_Price;
      }
      /// <summary>
      /// 获取指定的FHelper_Price对象集合
      /// </summary>
      public List<FHelper_Price> GetListByWhere(string strCondition)
      {
         List<FHelper_Price> ret = new List<FHelper_Price>();
         string sql = "SELECT  FP_ID,FP_Code,FP_ManuName,FP_ManuCode,FP_CompName,FP_CompCode,FP_RefComptCode,FP_NodeName,FP_PNodeCode,FP_Price,FP_Creator,FP_Creatime,FP_CurNode,FP_Stat,Stat,AuditStat,AuditCurAudit FROM FHelper_Price WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            FHelper_Price fHelper_Price = new FHelper_Price();
            if (dr["FP_ID"] != DBNull.Value) fHelper_Price.FP_ID = Convert.ToInt32(dr["FP_ID"]);
            if (dr["FP_Code"] != DBNull.Value) fHelper_Price.FP_Code = Convert.ToString(dr["FP_Code"]);
            if (dr["FP_ManuName"] != DBNull.Value) fHelper_Price.FP_ManuName = Convert.ToString(dr["FP_ManuName"]);
            if (dr["FP_ManuCode"] != DBNull.Value) fHelper_Price.FP_ManuCode = Convert.ToString(dr["FP_ManuCode"]);
            if (dr["FP_CompName"] != DBNull.Value) fHelper_Price.FP_CompName = Convert.ToString(dr["FP_CompName"]);
            if (dr["FP_CompCode"] != DBNull.Value) fHelper_Price.FP_CompCode = Convert.ToString(dr["FP_CompCode"]);
            if (dr["FP_RefComptCode"] != DBNull.Value) fHelper_Price.FP_RefComptCode = Convert.ToString(dr["FP_RefComptCode"]);
            if (dr["FP_NodeName"] != DBNull.Value) fHelper_Price.FP_NodeName = Convert.ToString(dr["FP_NodeName"]);
            if (dr["FP_PNodeCode"] != DBNull.Value) fHelper_Price.FP_PNodeCode = Convert.ToString(dr["FP_PNodeCode"]);
            if (dr["FP_Price"] != DBNull.Value) fHelper_Price.FP_Price = Convert.ToDecimal(dr["FP_Price"]);
            if (dr["FP_Creator"] != DBNull.Value) fHelper_Price.FP_Creator = Convert.ToString(dr["FP_Creator"]);
            if (dr["FP_Creatime"] != DBNull.Value) fHelper_Price.FP_Creatime = Convert.ToDateTime(dr["FP_Creatime"]);
            if (dr["FP_CurNode"] != DBNull.Value) fHelper_Price.FP_CurNode = Convert.ToString(dr["FP_CurNode"]);
            if (dr["FP_Stat"] != DBNull.Value) fHelper_Price.FP_Stat = Convert.ToString(dr["FP_Stat"]);
            if (dr["Stat"] != DBNull.Value) fHelper_Price.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) fHelper_Price.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) fHelper_Price.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(fHelper_Price);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的FHelper_Price对象(即:一条记录
      /// </summary>
      public List<FHelper_Price> GetAll()
      {
         List<FHelper_Price> ret = new List<FHelper_Price>();
         string sql = "SELECT  FP_ID,FP_Code,FP_ManuName,FP_ManuCode,FP_CompName,FP_CompCode,FP_RefComptCode,FP_NodeName,FP_PNodeCode,FP_Price,FP_Creator,FP_Creatime,FP_CurNode,FP_Stat,Stat,AuditStat,AuditCurAudit FROM FHelper_Price where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            FHelper_Price fHelper_Price = new FHelper_Price();
            if (dr["FP_ID"] != DBNull.Value) fHelper_Price.FP_ID = Convert.ToInt32(dr["FP_ID"]);
            if (dr["FP_Code"] != DBNull.Value) fHelper_Price.FP_Code = Convert.ToString(dr["FP_Code"]);
            if (dr["FP_ManuName"] != DBNull.Value) fHelper_Price.FP_ManuName = Convert.ToString(dr["FP_ManuName"]);
            if (dr["FP_ManuCode"] != DBNull.Value) fHelper_Price.FP_ManuCode = Convert.ToString(dr["FP_ManuCode"]);
            if (dr["FP_CompName"] != DBNull.Value) fHelper_Price.FP_CompName = Convert.ToString(dr["FP_CompName"]);
            if (dr["FP_CompCode"] != DBNull.Value) fHelper_Price.FP_CompCode = Convert.ToString(dr["FP_CompCode"]);
            if (dr["FP_RefComptCode"] != DBNull.Value) fHelper_Price.FP_RefComptCode = Convert.ToString(dr["FP_RefComptCode"]);
            if (dr["FP_NodeName"] != DBNull.Value) fHelper_Price.FP_NodeName = Convert.ToString(dr["FP_NodeName"]);
            if (dr["FP_PNodeCode"] != DBNull.Value) fHelper_Price.FP_PNodeCode = Convert.ToString(dr["FP_PNodeCode"]);
            if (dr["FP_Price"] != DBNull.Value) fHelper_Price.FP_Price = Convert.ToDecimal(dr["FP_Price"]);
            if (dr["FP_Creator"] != DBNull.Value) fHelper_Price.FP_Creator = Convert.ToString(dr["FP_Creator"]);
            if (dr["FP_Creatime"] != DBNull.Value) fHelper_Price.FP_Creatime = Convert.ToDateTime(dr["FP_Creatime"]);
            if (dr["FP_CurNode"] != DBNull.Value) fHelper_Price.FP_CurNode = Convert.ToString(dr["FP_CurNode"]);
            if (dr["FP_Stat"] != DBNull.Value) fHelper_Price.FP_Stat = Convert.ToString(dr["FP_Stat"]);
            if (dr["Stat"] != DBNull.Value) fHelper_Price.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) fHelper_Price.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) fHelper_Price.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            ret.Add(fHelper_Price);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
