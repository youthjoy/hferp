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
   public partial class ADOInv_Movement
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Inv_Movement对象(即:一条记录)
      /// </summary>
      public int Add(Inv_Movement inv_Movement)
      {
         string sql = "INSERT INTO Inv_Movement (MV_Code,MV_ProdCode,MV_PartNo,MV_PartName,MV_Owner,MV_Date,MV_OutNo,MV_Stat,MV_Num,MV_CheckStat,CreateTime,UpdateTime,DeleteTime,MV_IsPrint,Stat,MV_Type,AuditStat,AuditCurAudit,MV_Creator) VALUES (@MV_Code,@MV_ProdCode,@MV_PartNo,@MV_PartName,@MV_Owner,@MV_Date,@MV_OutNo,@MV_Stat,@MV_Num,@MV_CheckStat,@CreateTime,@UpdateTime,@DeleteTime,@MV_IsPrint,@Stat,@MV_Type,@AuditStat,@AuditCurAudit,@MV_Creator)";
         if (string.IsNullOrEmpty(inv_Movement.MV_Code))
         {
            idb.AddParameter("@MV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Code", inv_Movement.MV_Code);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_ProdCode))
         {
            idb.AddParameter("@MV_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ProdCode", inv_Movement.MV_ProdCode);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_PartNo))
         {
            idb.AddParameter("@MV_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_PartNo", inv_Movement.MV_PartNo);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_PartName))
         {
            idb.AddParameter("@MV_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_PartName", inv_Movement.MV_PartName);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_Owner))
         {
            idb.AddParameter("@MV_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Owner", inv_Movement.MV_Owner);
         }
         if (inv_Movement.MV_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MV_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Date", inv_Movement.MV_Date);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_OutNo))
         {
            idb.AddParameter("@MV_OutNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_OutNo", inv_Movement.MV_OutNo);
         }
         if (inv_Movement.MV_Stat == 0)
         {
            idb.AddParameter("@MV_Stat", 0);
         }
         else
         {
            idb.AddParameter("@MV_Stat", inv_Movement.MV_Stat);
         }
         if (inv_Movement.MV_Num == 0)
         {
            idb.AddParameter("@MV_Num", 0);
         }
         else
         {
            idb.AddParameter("@MV_Num", inv_Movement.MV_Num);
         }
         if (inv_Movement.MV_CheckStat == 0)
         {
            idb.AddParameter("@MV_CheckStat", 0);
         }
         else
         {
            idb.AddParameter("@MV_CheckStat", inv_Movement.MV_CheckStat);
         }
         if (inv_Movement.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", inv_Movement.CreateTime);
         }
         if (inv_Movement.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", inv_Movement.UpdateTime);
         }
         if (inv_Movement.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", inv_Movement.DeleteTime);
         }
         if (inv_Movement.MV_IsPrint == 0)
         {
            idb.AddParameter("@MV_IsPrint", 0);
         }
         else
         {
            idb.AddParameter("@MV_IsPrint", inv_Movement.MV_IsPrint);
         }
         if (inv_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", inv_Movement.Stat);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_Type))
         {
            idb.AddParameter("@MV_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Type", inv_Movement.MV_Type);
         }
         if (string.IsNullOrEmpty(inv_Movement.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", inv_Movement.AuditStat);
         }
         if (string.IsNullOrEmpty(inv_Movement.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", inv_Movement.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_Creator))
         {
            idb.AddParameter("@MV_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Creator", inv_Movement.MV_Creator);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Inv_Movement对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Inv_Movement inv_Movement)
      {
         string sql = "INSERT INTO Inv_Movement (MV_Code,MV_ProdCode,MV_PartNo,MV_PartName,MV_Owner,MV_Date,MV_OutNo,MV_Stat,MV_Num,MV_CheckStat,CreateTime,UpdateTime,DeleteTime,MV_IsPrint,Stat,MV_Type,AuditStat,AuditCurAudit,MV_Creator) VALUES (@MV_Code,@MV_ProdCode,@MV_PartNo,@MV_PartName,@MV_Owner,@MV_Date,@MV_OutNo,@MV_Stat,@MV_Num,@MV_CheckStat,@CreateTime,@UpdateTime,@DeleteTime,@MV_IsPrint,@Stat,@MV_Type,@AuditStat,@AuditCurAudit,@MV_Creator);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(inv_Movement.MV_Code))
         {
            idb.AddParameter("@MV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Code", inv_Movement.MV_Code);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_ProdCode))
         {
            idb.AddParameter("@MV_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ProdCode", inv_Movement.MV_ProdCode);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_PartNo))
         {
            idb.AddParameter("@MV_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_PartNo", inv_Movement.MV_PartNo);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_PartName))
         {
            idb.AddParameter("@MV_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_PartName", inv_Movement.MV_PartName);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_Owner))
         {
            idb.AddParameter("@MV_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Owner", inv_Movement.MV_Owner);
         }
         if (inv_Movement.MV_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MV_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Date", inv_Movement.MV_Date);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_OutNo))
         {
            idb.AddParameter("@MV_OutNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_OutNo", inv_Movement.MV_OutNo);
         }
         if (inv_Movement.MV_Stat == 0)
         {
            idb.AddParameter("@MV_Stat", 0);
         }
         else
         {
            idb.AddParameter("@MV_Stat", inv_Movement.MV_Stat);
         }
         if (inv_Movement.MV_Num == 0)
         {
            idb.AddParameter("@MV_Num", 0);
         }
         else
         {
            idb.AddParameter("@MV_Num", inv_Movement.MV_Num);
         }
         if (inv_Movement.MV_CheckStat == 0)
         {
            idb.AddParameter("@MV_CheckStat", 0);
         }
         else
         {
            idb.AddParameter("@MV_CheckStat", inv_Movement.MV_CheckStat);
         }
         if (inv_Movement.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", inv_Movement.CreateTime);
         }
         if (inv_Movement.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", inv_Movement.UpdateTime);
         }
         if (inv_Movement.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", inv_Movement.DeleteTime);
         }
         if (inv_Movement.MV_IsPrint == 0)
         {
            idb.AddParameter("@MV_IsPrint", 0);
         }
         else
         {
            idb.AddParameter("@MV_IsPrint", inv_Movement.MV_IsPrint);
         }
         if (inv_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", inv_Movement.Stat);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_Type))
         {
            idb.AddParameter("@MV_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Type", inv_Movement.MV_Type);
         }
         if (string.IsNullOrEmpty(inv_Movement.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", inv_Movement.AuditStat);
         }
         if (string.IsNullOrEmpty(inv_Movement.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", inv_Movement.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(inv_Movement.MV_Creator))
         {
            idb.AddParameter("@MV_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Creator", inv_Movement.MV_Creator);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Inv_Movement对象(即:一条记录
      /// </summary>
      public int Update(Inv_Movement inv_Movement)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Inv_Movement       SET ");
            if(inv_Movement.MV_Code_IsChanged){sbParameter.Append("MV_Code=@MV_Code, ");}
      if(inv_Movement.MV_ProdCode_IsChanged){sbParameter.Append("MV_ProdCode=@MV_ProdCode, ");}
      if(inv_Movement.MV_PartNo_IsChanged){sbParameter.Append("MV_PartNo=@MV_PartNo, ");}
      if(inv_Movement.MV_PartName_IsChanged){sbParameter.Append("MV_PartName=@MV_PartName, ");}
      if(inv_Movement.MV_Owner_IsChanged){sbParameter.Append("MV_Owner=@MV_Owner, ");}
      if(inv_Movement.MV_Date_IsChanged){sbParameter.Append("MV_Date=@MV_Date, ");}
      if(inv_Movement.MV_OutNo_IsChanged){sbParameter.Append("MV_OutNo=@MV_OutNo, ");}
      if(inv_Movement.MV_Stat_IsChanged){sbParameter.Append("MV_Stat=@MV_Stat, ");}
      if(inv_Movement.MV_Num_IsChanged){sbParameter.Append("MV_Num=@MV_Num, ");}
      if(inv_Movement.MV_CheckStat_IsChanged){sbParameter.Append("MV_CheckStat=@MV_CheckStat, ");}
      if(inv_Movement.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(inv_Movement.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(inv_Movement.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime, ");}
      if(inv_Movement.MV_IsPrint_IsChanged){sbParameter.Append("MV_IsPrint=@MV_IsPrint, ");}
      if(inv_Movement.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(inv_Movement.MV_Type_IsChanged){sbParameter.Append("MV_Type=@MV_Type, ");}
      if(inv_Movement.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(inv_Movement.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(inv_Movement.MV_Creator_IsChanged){sbParameter.Append("MV_Creator=@MV_Creator ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MV_ID=@MV_ID; " );
      string sql=sb.ToString();
         if(inv_Movement.MV_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_Code))
         {
            idb.AddParameter("@MV_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Code", inv_Movement.MV_Code);
         }
          }
         if(inv_Movement.MV_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_ProdCode))
         {
            idb.AddParameter("@MV_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_ProdCode", inv_Movement.MV_ProdCode);
         }
          }
         if(inv_Movement.MV_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_PartNo))
         {
            idb.AddParameter("@MV_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_PartNo", inv_Movement.MV_PartNo);
         }
          }
         if(inv_Movement.MV_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_PartName))
         {
            idb.AddParameter("@MV_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_PartName", inv_Movement.MV_PartName);
         }
          }
         if(inv_Movement.MV_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_Owner))
         {
            idb.AddParameter("@MV_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Owner", inv_Movement.MV_Owner);
         }
          }
         if(inv_Movement.MV_Date_IsChanged)
         {
         if (inv_Movement.MV_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MV_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Date", inv_Movement.MV_Date);
         }
          }
         if(inv_Movement.MV_OutNo_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_OutNo))
         {
            idb.AddParameter("@MV_OutNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_OutNo", inv_Movement.MV_OutNo);
         }
          }
         if(inv_Movement.MV_Stat_IsChanged)
         {
         if (inv_Movement.MV_Stat == 0)
         {
            idb.AddParameter("@MV_Stat", 0);
         }
         else
         {
            idb.AddParameter("@MV_Stat", inv_Movement.MV_Stat);
         }
          }
         if(inv_Movement.MV_Num_IsChanged)
         {
         if (inv_Movement.MV_Num == 0)
         {
            idb.AddParameter("@MV_Num", 0);
         }
         else
         {
            idb.AddParameter("@MV_Num", inv_Movement.MV_Num);
         }
          }
         if(inv_Movement.MV_CheckStat_IsChanged)
         {
         if (inv_Movement.MV_CheckStat == 0)
         {
            idb.AddParameter("@MV_CheckStat", 0);
         }
         else
         {
            idb.AddParameter("@MV_CheckStat", inv_Movement.MV_CheckStat);
         }
          }
         if(inv_Movement.CreateTime_IsChanged)
         {
         if (inv_Movement.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", inv_Movement.CreateTime);
         }
          }
         if(inv_Movement.UpdateTime_IsChanged)
         {
         if (inv_Movement.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", inv_Movement.UpdateTime);
         }
          }
         if(inv_Movement.DeleteTime_IsChanged)
         {
         if (inv_Movement.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", inv_Movement.DeleteTime);
         }
          }
         if(inv_Movement.MV_IsPrint_IsChanged)
         {
         if (inv_Movement.MV_IsPrint == 0)
         {
            idb.AddParameter("@MV_IsPrint", 0);
         }
         else
         {
            idb.AddParameter("@MV_IsPrint", inv_Movement.MV_IsPrint);
         }
          }
         if(inv_Movement.Stat_IsChanged)
         {
         if (inv_Movement.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", inv_Movement.Stat);
         }
          }
         if(inv_Movement.MV_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_Type))
         {
            idb.AddParameter("@MV_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Type", inv_Movement.MV_Type);
         }
          }
         if(inv_Movement.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", inv_Movement.AuditStat);
         }
          }
         if(inv_Movement.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", inv_Movement.AuditCurAudit);
         }
          }
         if(inv_Movement.MV_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Movement.MV_Creator))
         {
            idb.AddParameter("@MV_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MV_Creator", inv_Movement.MV_Creator);
         }
          }

         idb.AddParameter("@MV_ID", inv_Movement.MV_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Inv_Movement对象(即:一条记录
      /// </summary>
      public int Delete(Int64 mV_ID)
      {
         string sql = "DELETE Inv_Movement WHERE 1=1  AND MV_ID=@MV_ID ";
         idb.AddParameter("@MV_ID", mV_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Inv_Movement对象(即:一条记录
      /// </summary>
      public Inv_Movement GetByKey(Int64 mV_ID)
      {
         Inv_Movement inv_Movement = new Inv_Movement();
         string sql = "SELECT  MV_ID,MV_Code,MV_ProdCode,MV_PartNo,MV_PartName,MV_Owner,MV_Date,MV_OutNo,MV_Stat,MV_Num,MV_CheckStat,CreateTime,UpdateTime,DeleteTime,MV_IsPrint,Stat,MV_Type,AuditStat,AuditCurAudit,MV_Creator FROM Inv_Movement WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MV_ID=@MV_ID ";
         idb.AddParameter("@MV_ID", mV_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MV_ID"] != DBNull.Value) inv_Movement.MV_ID = Convert.ToInt64(dr["MV_ID"]);
            if (dr["MV_Code"] != DBNull.Value) inv_Movement.MV_Code = Convert.ToString(dr["MV_Code"]);
            if (dr["MV_ProdCode"] != DBNull.Value) inv_Movement.MV_ProdCode = Convert.ToString(dr["MV_ProdCode"]);
            if (dr["MV_PartNo"] != DBNull.Value) inv_Movement.MV_PartNo = Convert.ToString(dr["MV_PartNo"]);
            if (dr["MV_PartName"] != DBNull.Value) inv_Movement.MV_PartName = Convert.ToString(dr["MV_PartName"]);
            if (dr["MV_Owner"] != DBNull.Value) inv_Movement.MV_Owner = Convert.ToString(dr["MV_Owner"]);
            if (dr["MV_Date"] != DBNull.Value) inv_Movement.MV_Date = Convert.ToDateTime(dr["MV_Date"]);
            if (dr["MV_OutNo"] != DBNull.Value) inv_Movement.MV_OutNo = Convert.ToString(dr["MV_OutNo"]);
            if (dr["MV_Stat"] != DBNull.Value) inv_Movement.MV_Stat = Convert.ToInt32(dr["MV_Stat"]);
            if (dr["MV_Num"] != DBNull.Value) inv_Movement.MV_Num = Convert.ToInt32(dr["MV_Num"]);
            if (dr["MV_CheckStat"] != DBNull.Value) inv_Movement.MV_CheckStat = Convert.ToInt32(dr["MV_CheckStat"]);
            if (dr["CreateTime"] != DBNull.Value) inv_Movement.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) inv_Movement.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) inv_Movement.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["MV_IsPrint"] != DBNull.Value) inv_Movement.MV_IsPrint = Convert.ToInt32(dr["MV_IsPrint"]);
            if (dr["Stat"] != DBNull.Value) inv_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_Type"] != DBNull.Value) inv_Movement.MV_Type = Convert.ToString(dr["MV_Type"]);
            if (dr["AuditStat"] != DBNull.Value) inv_Movement.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) inv_Movement.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["MV_Creator"] != DBNull.Value) inv_Movement.MV_Creator = Convert.ToString(dr["MV_Creator"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return inv_Movement;
      }
      /// <summary>
      /// 获取指定的Inv_Movement对象集合
      /// </summary>
      public List<Inv_Movement> GetListByWhere(string strCondition)
      {
         List<Inv_Movement> ret = new List<Inv_Movement>();
         string sql = "SELECT  MV_ID,MV_Code,MV_ProdCode,MV_PartNo,MV_PartName,MV_Owner,MV_Date,MV_OutNo,MV_Stat,MV_Num,MV_CheckStat,CreateTime,UpdateTime,DeleteTime,MV_IsPrint,Stat,MV_Type,AuditStat,AuditCurAudit,MV_Creator FROM Inv_Movement WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Inv_Movement inv_Movement = new Inv_Movement();
            if (dr["MV_ID"] != DBNull.Value) inv_Movement.MV_ID = Convert.ToInt64(dr["MV_ID"]);
            if (dr["MV_Code"] != DBNull.Value) inv_Movement.MV_Code = Convert.ToString(dr["MV_Code"]);
            if (dr["MV_ProdCode"] != DBNull.Value) inv_Movement.MV_ProdCode = Convert.ToString(dr["MV_ProdCode"]);
            if (dr["MV_PartNo"] != DBNull.Value) inv_Movement.MV_PartNo = Convert.ToString(dr["MV_PartNo"]);
            if (dr["MV_PartName"] != DBNull.Value) inv_Movement.MV_PartName = Convert.ToString(dr["MV_PartName"]);
            if (dr["MV_Owner"] != DBNull.Value) inv_Movement.MV_Owner = Convert.ToString(dr["MV_Owner"]);
            if (dr["MV_Date"] != DBNull.Value) inv_Movement.MV_Date = Convert.ToDateTime(dr["MV_Date"]);
            if (dr["MV_OutNo"] != DBNull.Value) inv_Movement.MV_OutNo = Convert.ToString(dr["MV_OutNo"]);
            if (dr["MV_Stat"] != DBNull.Value) inv_Movement.MV_Stat = Convert.ToInt32(dr["MV_Stat"]);
            if (dr["MV_Num"] != DBNull.Value) inv_Movement.MV_Num = Convert.ToInt32(dr["MV_Num"]);
            if (dr["MV_CheckStat"] != DBNull.Value) inv_Movement.MV_CheckStat = Convert.ToInt32(dr["MV_CheckStat"]);
            if (dr["CreateTime"] != DBNull.Value) inv_Movement.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) inv_Movement.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) inv_Movement.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["MV_IsPrint"] != DBNull.Value) inv_Movement.MV_IsPrint = Convert.ToInt32(dr["MV_IsPrint"]);
            if (dr["Stat"] != DBNull.Value) inv_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_Type"] != DBNull.Value) inv_Movement.MV_Type = Convert.ToString(dr["MV_Type"]);
            if (dr["AuditStat"] != DBNull.Value) inv_Movement.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) inv_Movement.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["MV_Creator"] != DBNull.Value) inv_Movement.MV_Creator = Convert.ToString(dr["MV_Creator"]);
            ret.Add(inv_Movement);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的Inv_Movement对象(即:一条记录
      /// </summary>
      public List<Inv_Movement> GetAll()
      {
         List<Inv_Movement> ret = new List<Inv_Movement>();
         string sql = "SELECT  MV_ID,MV_Code,MV_ProdCode,MV_PartNo,MV_PartName,MV_Owner,MV_Date,MV_OutNo,MV_Stat,MV_Num,MV_CheckStat,CreateTime,UpdateTime,DeleteTime,MV_IsPrint,Stat,MV_Type,AuditStat,AuditCurAudit,MV_Creator FROM Inv_Movement where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Inv_Movement inv_Movement = new Inv_Movement();
            if (dr["MV_ID"] != DBNull.Value) inv_Movement.MV_ID = Convert.ToInt64(dr["MV_ID"]);
            if (dr["MV_Code"] != DBNull.Value) inv_Movement.MV_Code = Convert.ToString(dr["MV_Code"]);
            if (dr["MV_ProdCode"] != DBNull.Value) inv_Movement.MV_ProdCode = Convert.ToString(dr["MV_ProdCode"]);
            if (dr["MV_PartNo"] != DBNull.Value) inv_Movement.MV_PartNo = Convert.ToString(dr["MV_PartNo"]);
            if (dr["MV_PartName"] != DBNull.Value) inv_Movement.MV_PartName = Convert.ToString(dr["MV_PartName"]);
            if (dr["MV_Owner"] != DBNull.Value) inv_Movement.MV_Owner = Convert.ToString(dr["MV_Owner"]);
            if (dr["MV_Date"] != DBNull.Value) inv_Movement.MV_Date = Convert.ToDateTime(dr["MV_Date"]);
            if (dr["MV_OutNo"] != DBNull.Value) inv_Movement.MV_OutNo = Convert.ToString(dr["MV_OutNo"]);
            if (dr["MV_Stat"] != DBNull.Value) inv_Movement.MV_Stat = Convert.ToInt32(dr["MV_Stat"]);
            if (dr["MV_Num"] != DBNull.Value) inv_Movement.MV_Num = Convert.ToInt32(dr["MV_Num"]);
            if (dr["MV_CheckStat"] != DBNull.Value) inv_Movement.MV_CheckStat = Convert.ToInt32(dr["MV_CheckStat"]);
            if (dr["CreateTime"] != DBNull.Value) inv_Movement.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) inv_Movement.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) inv_Movement.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["MV_IsPrint"] != DBNull.Value) inv_Movement.MV_IsPrint = Convert.ToInt32(dr["MV_IsPrint"]);
            if (dr["Stat"] != DBNull.Value) inv_Movement.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["MV_Type"] != DBNull.Value) inv_Movement.MV_Type = Convert.ToString(dr["MV_Type"]);
            if (dr["AuditStat"] != DBNull.Value) inv_Movement.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) inv_Movement.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["MV_Creator"] != DBNull.Value) inv_Movement.MV_Creator = Convert.ToString(dr["MV_Creator"]);
            ret.Add(inv_Movement);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
