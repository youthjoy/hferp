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
   /// 毛坯采购主表
   /// </summary>
   [Serializable]
   public partial class ADORaw_Main
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加毛坯采购主表 Raw_Main对象(即:一条记录)
      /// </summary>
      public int Add(Raw_Main raw_Main)
      {
         string sql = "INSERT INTO Raw_Main (RawMain_Code,RawMain_Title,RawMain_AppDep,RawMain_BusOwn,RawMain_AppOwn,RawMain_AppDate,RawMain_Stat,RawMain_CurStat,Stat,RawMain_CmdCode,RawMain_SupCode,RawMain_SupName,RawMain_RefType,RawMain_RefCode,RawMain_iType,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,RawMain_Creator,RawMain_Checker,RawMain_Customer) VALUES (@RawMain_Code,@RawMain_Title,@RawMain_AppDep,@RawMain_BusOwn,@RawMain_AppOwn,@RawMain_AppDate,@RawMain_Stat,@RawMain_CurStat,@Stat,@RawMain_CmdCode,@RawMain_SupCode,@RawMain_SupName,@RawMain_RefType,@RawMain_RefCode,@RawMain_iType,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit,@RawMain_Creator,@RawMain_Checker,@RawMain_Customer)";
         if (string.IsNullOrEmpty(raw_Main.RawMain_Code))
         {
            idb.AddParameter("@RawMain_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Code", raw_Main.RawMain_Code);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Title))
         {
            idb.AddParameter("@RawMain_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Title", raw_Main.RawMain_Title);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_AppDep))
         {
            idb.AddParameter("@RawMain_AppDep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppDep", raw_Main.RawMain_AppDep);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_BusOwn))
         {
            idb.AddParameter("@RawMain_BusOwn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_BusOwn", raw_Main.RawMain_BusOwn);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_AppOwn))
         {
            idb.AddParameter("@RawMain_AppOwn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppOwn", raw_Main.RawMain_AppOwn);
         }
         if (raw_Main.RawMain_AppDate == DateTime.MinValue)
         {
            idb.AddParameter("@RawMain_AppDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppDate", raw_Main.RawMain_AppDate);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Stat))
         {
            idb.AddParameter("@RawMain_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Stat", raw_Main.RawMain_Stat);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_CurStat))
         {
            idb.AddParameter("@RawMain_CurStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_CurStat", raw_Main.RawMain_CurStat);
         }
         if (raw_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Main.Stat);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_CmdCode))
         {
            idb.AddParameter("@RawMain_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_CmdCode", raw_Main.RawMain_CmdCode);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_SupCode))
         {
            idb.AddParameter("@RawMain_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_SupCode", raw_Main.RawMain_SupCode);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_SupName))
         {
            idb.AddParameter("@RawMain_SupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_SupName", raw_Main.RawMain_SupName);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_RefType))
         {
            idb.AddParameter("@RawMain_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_RefType", raw_Main.RawMain_RefType);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_RefCode))
         {
            idb.AddParameter("@RawMain_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_RefCode", raw_Main.RawMain_RefCode);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_iType))
         {
            idb.AddParameter("@RawMain_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_iType", raw_Main.RawMain_iType);
         }
         if (raw_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", raw_Main.CreateDate);
         }
         if (raw_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", raw_Main.UpdateDate);
         }
         if (raw_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", raw_Main.DeleteDate);
         }
         if (string.IsNullOrEmpty(raw_Main.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", raw_Main.AuditStat);
         }
         if (string.IsNullOrEmpty(raw_Main.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", raw_Main.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Creator))
         {
            idb.AddParameter("@RawMain_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Creator", raw_Main.RawMain_Creator);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Checker))
         {
            idb.AddParameter("@RawMain_Checker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Checker", raw_Main.RawMain_Checker);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Customer))
         {
            idb.AddParameter("@RawMain_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Customer", raw_Main.RawMain_Customer);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加毛坯采购主表 Raw_Main对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Raw_Main raw_Main)
      {
         string sql = "INSERT INTO Raw_Main (RawMain_Code,RawMain_Title,RawMain_AppDep,RawMain_BusOwn,RawMain_AppOwn,RawMain_AppDate,RawMain_Stat,RawMain_CurStat,Stat,RawMain_CmdCode,RawMain_SupCode,RawMain_SupName,RawMain_RefType,RawMain_RefCode,RawMain_iType,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,RawMain_Creator,RawMain_Checker,RawMain_Customer) VALUES (@RawMain_Code,@RawMain_Title,@RawMain_AppDep,@RawMain_BusOwn,@RawMain_AppOwn,@RawMain_AppDate,@RawMain_Stat,@RawMain_CurStat,@Stat,@RawMain_CmdCode,@RawMain_SupCode,@RawMain_SupName,@RawMain_RefType,@RawMain_RefCode,@RawMain_iType,@CreateDate,@UpdateDate,@DeleteDate,@AuditStat,@AuditCurAudit,@RawMain_Creator,@RawMain_Checker,@RawMain_Customer);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(raw_Main.RawMain_Code))
         {
            idb.AddParameter("@RawMain_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Code", raw_Main.RawMain_Code);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Title))
         {
            idb.AddParameter("@RawMain_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Title", raw_Main.RawMain_Title);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_AppDep))
         {
            idb.AddParameter("@RawMain_AppDep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppDep", raw_Main.RawMain_AppDep);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_BusOwn))
         {
            idb.AddParameter("@RawMain_BusOwn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_BusOwn", raw_Main.RawMain_BusOwn);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_AppOwn))
         {
            idb.AddParameter("@RawMain_AppOwn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppOwn", raw_Main.RawMain_AppOwn);
         }
         if (raw_Main.RawMain_AppDate == DateTime.MinValue)
         {
            idb.AddParameter("@RawMain_AppDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppDate", raw_Main.RawMain_AppDate);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Stat))
         {
            idb.AddParameter("@RawMain_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Stat", raw_Main.RawMain_Stat);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_CurStat))
         {
            idb.AddParameter("@RawMain_CurStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_CurStat", raw_Main.RawMain_CurStat);
         }
         if (raw_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Main.Stat);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_CmdCode))
         {
            idb.AddParameter("@RawMain_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_CmdCode", raw_Main.RawMain_CmdCode);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_SupCode))
         {
            idb.AddParameter("@RawMain_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_SupCode", raw_Main.RawMain_SupCode);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_SupName))
         {
            idb.AddParameter("@RawMain_SupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_SupName", raw_Main.RawMain_SupName);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_RefType))
         {
            idb.AddParameter("@RawMain_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_RefType", raw_Main.RawMain_RefType);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_RefCode))
         {
            idb.AddParameter("@RawMain_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_RefCode", raw_Main.RawMain_RefCode);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_iType))
         {
            idb.AddParameter("@RawMain_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_iType", raw_Main.RawMain_iType);
         }
         if (raw_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", raw_Main.CreateDate);
         }
         if (raw_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", raw_Main.UpdateDate);
         }
         if (raw_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", raw_Main.DeleteDate);
         }
         if (string.IsNullOrEmpty(raw_Main.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", raw_Main.AuditStat);
         }
         if (string.IsNullOrEmpty(raw_Main.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", raw_Main.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Creator))
         {
            idb.AddParameter("@RawMain_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Creator", raw_Main.RawMain_Creator);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Checker))
         {
            idb.AddParameter("@RawMain_Checker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Checker", raw_Main.RawMain_Checker);
         }
         if (string.IsNullOrEmpty(raw_Main.RawMain_Customer))
         {
            idb.AddParameter("@RawMain_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Customer", raw_Main.RawMain_Customer);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新毛坯采购主表 Raw_Main对象(即:一条记录
      /// </summary>
      public int Update(Raw_Main raw_Main)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Raw_Main       SET ");
            if(raw_Main.RawMain_Code_IsChanged){sbParameter.Append("RawMain_Code=@RawMain_Code, ");}
      if(raw_Main.RawMain_Title_IsChanged){sbParameter.Append("RawMain_Title=@RawMain_Title, ");}
      if(raw_Main.RawMain_AppDep_IsChanged){sbParameter.Append("RawMain_AppDep=@RawMain_AppDep, ");}
      if(raw_Main.RawMain_BusOwn_IsChanged){sbParameter.Append("RawMain_BusOwn=@RawMain_BusOwn, ");}
      if(raw_Main.RawMain_AppOwn_IsChanged){sbParameter.Append("RawMain_AppOwn=@RawMain_AppOwn, ");}
      if(raw_Main.RawMain_AppDate_IsChanged){sbParameter.Append("RawMain_AppDate=@RawMain_AppDate, ");}
      if(raw_Main.RawMain_Stat_IsChanged){sbParameter.Append("RawMain_Stat=@RawMain_Stat, ");}
      if(raw_Main.RawMain_CurStat_IsChanged){sbParameter.Append("RawMain_CurStat=@RawMain_CurStat, ");}
      if(raw_Main.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(raw_Main.RawMain_CmdCode_IsChanged){sbParameter.Append("RawMain_CmdCode=@RawMain_CmdCode, ");}
      if(raw_Main.RawMain_SupCode_IsChanged){sbParameter.Append("RawMain_SupCode=@RawMain_SupCode, ");}
      if(raw_Main.RawMain_SupName_IsChanged){sbParameter.Append("RawMain_SupName=@RawMain_SupName, ");}
      if(raw_Main.RawMain_RefType_IsChanged){sbParameter.Append("RawMain_RefType=@RawMain_RefType, ");}
      if(raw_Main.RawMain_RefCode_IsChanged){sbParameter.Append("RawMain_RefCode=@RawMain_RefCode, ");}
      if(raw_Main.RawMain_iType_IsChanged){sbParameter.Append("RawMain_iType=@RawMain_iType, ");}
      if(raw_Main.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(raw_Main.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(raw_Main.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(raw_Main.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(raw_Main.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(raw_Main.RawMain_Creator_IsChanged){sbParameter.Append("RawMain_Creator=@RawMain_Creator, ");}
      if(raw_Main.RawMain_Checker_IsChanged){sbParameter.Append("RawMain_Checker=@RawMain_Checker, ");}
      if(raw_Main.RawMain_Customer_IsChanged){sbParameter.Append("RawMain_Customer=@RawMain_Customer ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RawMain_ID=@RawMain_ID; " );
      string sql=sb.ToString();
         if(raw_Main.RawMain_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_Code))
         {
            idb.AddParameter("@RawMain_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Code", raw_Main.RawMain_Code);
         }
          }
         if(raw_Main.RawMain_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_Title))
         {
            idb.AddParameter("@RawMain_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Title", raw_Main.RawMain_Title);
         }
          }
         if(raw_Main.RawMain_AppDep_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_AppDep))
         {
            idb.AddParameter("@RawMain_AppDep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppDep", raw_Main.RawMain_AppDep);
         }
          }
         if(raw_Main.RawMain_BusOwn_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_BusOwn))
         {
            idb.AddParameter("@RawMain_BusOwn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_BusOwn", raw_Main.RawMain_BusOwn);
         }
          }
         if(raw_Main.RawMain_AppOwn_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_AppOwn))
         {
            idb.AddParameter("@RawMain_AppOwn", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppOwn", raw_Main.RawMain_AppOwn);
         }
          }
         if(raw_Main.RawMain_AppDate_IsChanged)
         {
         if (raw_Main.RawMain_AppDate == DateTime.MinValue)
         {
            idb.AddParameter("@RawMain_AppDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_AppDate", raw_Main.RawMain_AppDate);
         }
          }
         if(raw_Main.RawMain_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_Stat))
         {
            idb.AddParameter("@RawMain_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Stat", raw_Main.RawMain_Stat);
         }
          }
         if(raw_Main.RawMain_CurStat_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_CurStat))
         {
            idb.AddParameter("@RawMain_CurStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_CurStat", raw_Main.RawMain_CurStat);
         }
          }
         if(raw_Main.Stat_IsChanged)
         {
         if (raw_Main.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Main.Stat);
         }
          }
         if(raw_Main.RawMain_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_CmdCode))
         {
            idb.AddParameter("@RawMain_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_CmdCode", raw_Main.RawMain_CmdCode);
         }
          }
         if(raw_Main.RawMain_SupCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_SupCode))
         {
            idb.AddParameter("@RawMain_SupCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_SupCode", raw_Main.RawMain_SupCode);
         }
          }
         if(raw_Main.RawMain_SupName_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_SupName))
         {
            idb.AddParameter("@RawMain_SupName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_SupName", raw_Main.RawMain_SupName);
         }
          }
         if(raw_Main.RawMain_RefType_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_RefType))
         {
            idb.AddParameter("@RawMain_RefType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_RefType", raw_Main.RawMain_RefType);
         }
          }
         if(raw_Main.RawMain_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_RefCode))
         {
            idb.AddParameter("@RawMain_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_RefCode", raw_Main.RawMain_RefCode);
         }
          }
         if(raw_Main.RawMain_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_iType))
         {
            idb.AddParameter("@RawMain_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_iType", raw_Main.RawMain_iType);
         }
          }
         if(raw_Main.CreateDate_IsChanged)
         {
         if (raw_Main.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", raw_Main.CreateDate);
         }
          }
         if(raw_Main.UpdateDate_IsChanged)
         {
         if (raw_Main.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", raw_Main.UpdateDate);
         }
          }
         if(raw_Main.DeleteDate_IsChanged)
         {
         if (raw_Main.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", raw_Main.DeleteDate);
         }
          }
         if(raw_Main.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", raw_Main.AuditStat);
         }
          }
         if(raw_Main.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", raw_Main.AuditCurAudit);
         }
          }
         if(raw_Main.RawMain_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_Creator))
         {
            idb.AddParameter("@RawMain_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Creator", raw_Main.RawMain_Creator);
         }
          }
         if(raw_Main.RawMain_Checker_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_Checker))
         {
            idb.AddParameter("@RawMain_Checker", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Checker", raw_Main.RawMain_Checker);
         }
          }
         if(raw_Main.RawMain_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Main.RawMain_Customer))
         {
            idb.AddParameter("@RawMain_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Customer", raw_Main.RawMain_Customer);
         }
          }

         idb.AddParameter("@RawMain_ID", raw_Main.RawMain_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除毛坯采购主表 Raw_Main对象(即:一条记录
      /// </summary>
      public int Delete(decimal rawMain_ID)
      {
         string sql = "DELETE Raw_Main WHERE 1=1  AND RawMain_ID=@RawMain_ID ";
         idb.AddParameter("@RawMain_ID", rawMain_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的毛坯采购主表 Raw_Main对象(即:一条记录
      /// </summary>
      public Raw_Main GetByKey(decimal rawMain_ID)
      {
         Raw_Main raw_Main = new Raw_Main();
         string sql = "SELECT  RawMain_ID,RawMain_Code,RawMain_Title,RawMain_AppDep,RawMain_BusOwn,RawMain_AppOwn,RawMain_AppDate,RawMain_Stat,RawMain_CurStat,Stat,RawMain_CmdCode,RawMain_SupCode,RawMain_SupName,RawMain_RefType,RawMain_RefCode,RawMain_iType,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,RawMain_Creator,RawMain_Checker,RawMain_Customer FROM Raw_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RawMain_ID=@RawMain_ID ";
         idb.AddParameter("@RawMain_ID", rawMain_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RawMain_ID"] != DBNull.Value) raw_Main.RawMain_ID = Convert.ToDecimal(dr["RawMain_ID"]);
            if (dr["RawMain_Code"] != DBNull.Value) raw_Main.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
            if (dr["RawMain_Title"] != DBNull.Value) raw_Main.RawMain_Title = Convert.ToString(dr["RawMain_Title"]);
            if (dr["RawMain_AppDep"] != DBNull.Value) raw_Main.RawMain_AppDep = Convert.ToString(dr["RawMain_AppDep"]);
            if (dr["RawMain_BusOwn"] != DBNull.Value) raw_Main.RawMain_BusOwn = Convert.ToString(dr["RawMain_BusOwn"]);
            if (dr["RawMain_AppOwn"] != DBNull.Value) raw_Main.RawMain_AppOwn = Convert.ToString(dr["RawMain_AppOwn"]);
            if (dr["RawMain_AppDate"] != DBNull.Value) raw_Main.RawMain_AppDate = Convert.ToDateTime(dr["RawMain_AppDate"]);
            if (dr["RawMain_Stat"] != DBNull.Value) raw_Main.RawMain_Stat = Convert.ToString(dr["RawMain_Stat"]);
            if (dr["RawMain_CurStat"] != DBNull.Value) raw_Main.RawMain_CurStat = Convert.ToString(dr["RawMain_CurStat"]);
            if (dr["Stat"] != DBNull.Value) raw_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RawMain_CmdCode"] != DBNull.Value) raw_Main.RawMain_CmdCode = Convert.ToString(dr["RawMain_CmdCode"]);
            if (dr["RawMain_SupCode"] != DBNull.Value) raw_Main.RawMain_SupCode = Convert.ToString(dr["RawMain_SupCode"]);
            if (dr["RawMain_SupName"] != DBNull.Value) raw_Main.RawMain_SupName = Convert.ToString(dr["RawMain_SupName"]);
            if (dr["RawMain_RefType"] != DBNull.Value) raw_Main.RawMain_RefType = Convert.ToString(dr["RawMain_RefType"]);
            if (dr["RawMain_RefCode"] != DBNull.Value) raw_Main.RawMain_RefCode = Convert.ToString(dr["RawMain_RefCode"]);
            if (dr["RawMain_iType"] != DBNull.Value) raw_Main.RawMain_iType = Convert.ToString(dr["RawMain_iType"]);
            if (dr["CreateDate"] != DBNull.Value) raw_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) raw_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) raw_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) raw_Main.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) raw_Main.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["RawMain_Creator"] != DBNull.Value) raw_Main.RawMain_Creator = Convert.ToString(dr["RawMain_Creator"]);
            if (dr["RawMain_Checker"] != DBNull.Value) raw_Main.RawMain_Checker = Convert.ToString(dr["RawMain_Checker"]);
            if (dr["RawMain_Customer"] != DBNull.Value) raw_Main.RawMain_Customer = Convert.ToString(dr["RawMain_Customer"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return raw_Main;
      }
      /// <summary>
      /// 获取指定的毛坯采购主表 Raw_Main对象集合
      /// </summary>
      public List<Raw_Main> GetListByWhere(string strCondition)
      {
         List<Raw_Main> ret = new List<Raw_Main>();
         string sql = "SELECT  RawMain_ID,RawMain_Code,RawMain_Title,RawMain_AppDep,RawMain_BusOwn,RawMain_AppOwn,RawMain_AppDate,RawMain_Stat,RawMain_CurStat,Stat,RawMain_CmdCode,RawMain_SupCode,RawMain_SupName,RawMain_RefType,RawMain_RefCode,RawMain_iType,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,RawMain_Creator,RawMain_Checker,RawMain_Customer FROM Raw_Main WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Raw_Main raw_Main = new Raw_Main();
            if (dr["RawMain_ID"] != DBNull.Value) raw_Main.RawMain_ID = Convert.ToDecimal(dr["RawMain_ID"]);
            if (dr["RawMain_Code"] != DBNull.Value) raw_Main.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
            if (dr["RawMain_Title"] != DBNull.Value) raw_Main.RawMain_Title = Convert.ToString(dr["RawMain_Title"]);
            if (dr["RawMain_AppDep"] != DBNull.Value) raw_Main.RawMain_AppDep = Convert.ToString(dr["RawMain_AppDep"]);
            if (dr["RawMain_BusOwn"] != DBNull.Value) raw_Main.RawMain_BusOwn = Convert.ToString(dr["RawMain_BusOwn"]);
            if (dr["RawMain_AppOwn"] != DBNull.Value) raw_Main.RawMain_AppOwn = Convert.ToString(dr["RawMain_AppOwn"]);
            if (dr["RawMain_AppDate"] != DBNull.Value) raw_Main.RawMain_AppDate = Convert.ToDateTime(dr["RawMain_AppDate"]);
            if (dr["RawMain_Stat"] != DBNull.Value) raw_Main.RawMain_Stat = Convert.ToString(dr["RawMain_Stat"]);
            if (dr["RawMain_CurStat"] != DBNull.Value) raw_Main.RawMain_CurStat = Convert.ToString(dr["RawMain_CurStat"]);
            if (dr["Stat"] != DBNull.Value) raw_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RawMain_CmdCode"] != DBNull.Value) raw_Main.RawMain_CmdCode = Convert.ToString(dr["RawMain_CmdCode"]);
            if (dr["RawMain_SupCode"] != DBNull.Value) raw_Main.RawMain_SupCode = Convert.ToString(dr["RawMain_SupCode"]);
            if (dr["RawMain_SupName"] != DBNull.Value) raw_Main.RawMain_SupName = Convert.ToString(dr["RawMain_SupName"]);
            if (dr["RawMain_RefType"] != DBNull.Value) raw_Main.RawMain_RefType = Convert.ToString(dr["RawMain_RefType"]);
            if (dr["RawMain_RefCode"] != DBNull.Value) raw_Main.RawMain_RefCode = Convert.ToString(dr["RawMain_RefCode"]);
            if (dr["RawMain_iType"] != DBNull.Value) raw_Main.RawMain_iType = Convert.ToString(dr["RawMain_iType"]);
            if (dr["CreateDate"] != DBNull.Value) raw_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) raw_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) raw_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) raw_Main.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) raw_Main.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["RawMain_Creator"] != DBNull.Value) raw_Main.RawMain_Creator = Convert.ToString(dr["RawMain_Creator"]);
            if (dr["RawMain_Checker"] != DBNull.Value) raw_Main.RawMain_Checker = Convert.ToString(dr["RawMain_Checker"]);
            if (dr["RawMain_Customer"] != DBNull.Value) raw_Main.RawMain_Customer = Convert.ToString(dr["RawMain_Customer"]);
            ret.Add(raw_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的毛坯采购主表 Raw_Main对象(即:一条记录
      /// </summary>
      public List<Raw_Main> GetAll()
      {
         List<Raw_Main> ret = new List<Raw_Main>();
         string sql = "SELECT  RawMain_ID,RawMain_Code,RawMain_Title,RawMain_AppDep,RawMain_BusOwn,RawMain_AppOwn,RawMain_AppDate,RawMain_Stat,RawMain_CurStat,Stat,RawMain_CmdCode,RawMain_SupCode,RawMain_SupName,RawMain_RefType,RawMain_RefCode,RawMain_iType,CreateDate,UpdateDate,DeleteDate,AuditStat,AuditCurAudit,RawMain_Creator,RawMain_Checker,RawMain_Customer FROM Raw_Main where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Raw_Main raw_Main = new Raw_Main();
            if (dr["RawMain_ID"] != DBNull.Value) raw_Main.RawMain_ID = Convert.ToDecimal(dr["RawMain_ID"]);
            if (dr["RawMain_Code"] != DBNull.Value) raw_Main.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
            if (dr["RawMain_Title"] != DBNull.Value) raw_Main.RawMain_Title = Convert.ToString(dr["RawMain_Title"]);
            if (dr["RawMain_AppDep"] != DBNull.Value) raw_Main.RawMain_AppDep = Convert.ToString(dr["RawMain_AppDep"]);
            if (dr["RawMain_BusOwn"] != DBNull.Value) raw_Main.RawMain_BusOwn = Convert.ToString(dr["RawMain_BusOwn"]);
            if (dr["RawMain_AppOwn"] != DBNull.Value) raw_Main.RawMain_AppOwn = Convert.ToString(dr["RawMain_AppOwn"]);
            if (dr["RawMain_AppDate"] != DBNull.Value) raw_Main.RawMain_AppDate = Convert.ToDateTime(dr["RawMain_AppDate"]);
            if (dr["RawMain_Stat"] != DBNull.Value) raw_Main.RawMain_Stat = Convert.ToString(dr["RawMain_Stat"]);
            if (dr["RawMain_CurStat"] != DBNull.Value) raw_Main.RawMain_CurStat = Convert.ToString(dr["RawMain_CurStat"]);
            if (dr["Stat"] != DBNull.Value) raw_Main.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RawMain_CmdCode"] != DBNull.Value) raw_Main.RawMain_CmdCode = Convert.ToString(dr["RawMain_CmdCode"]);
            if (dr["RawMain_SupCode"] != DBNull.Value) raw_Main.RawMain_SupCode = Convert.ToString(dr["RawMain_SupCode"]);
            if (dr["RawMain_SupName"] != DBNull.Value) raw_Main.RawMain_SupName = Convert.ToString(dr["RawMain_SupName"]);
            if (dr["RawMain_RefType"] != DBNull.Value) raw_Main.RawMain_RefType = Convert.ToString(dr["RawMain_RefType"]);
            if (dr["RawMain_RefCode"] != DBNull.Value) raw_Main.RawMain_RefCode = Convert.ToString(dr["RawMain_RefCode"]);
            if (dr["RawMain_iType"] != DBNull.Value) raw_Main.RawMain_iType = Convert.ToString(dr["RawMain_iType"]);
            if (dr["CreateDate"] != DBNull.Value) raw_Main.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) raw_Main.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) raw_Main.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["AuditStat"] != DBNull.Value) raw_Main.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) raw_Main.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["RawMain_Creator"] != DBNull.Value) raw_Main.RawMain_Creator = Convert.ToString(dr["RawMain_Creator"]);
            if (dr["RawMain_Checker"] != DBNull.Value) raw_Main.RawMain_Checker = Convert.ToString(dr["RawMain_Checker"]);
            if (dr["RawMain_Customer"] != DBNull.Value) raw_Main.RawMain_Customer = Convert.ToString(dr["RawMain_Customer"]);
            ret.Add(raw_Main);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
