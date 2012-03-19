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
   /// 生产指令表
   /// </summary>
   [Serializable]
   public partial class ADOProd_Command
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产指令表 Prod_Command对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Command prod_Command)
      {
         string sql = "INSERT INTO Prod_Command (Cmd_Code,Cmd_Dep_Code2,Cmd_Dep_Name,Cmd_Contract_Code,Cmd_Type,Cmd_Supplier,Cmd_CBill,Cmd_CBillName,Cmd_CBillTime,Cmd_Bak,Cmd_Stat,Stat,AuditStat,AuditCurAudit,AuditDate,AuditOwner,CreateDate,UpdateDate,DeleteDate,Cmd_Udef1,Cmd_Udef2,Cmd_Udef3,Cmd_Udef4,Cmd_AllCount) VALUES (@Cmd_Code,@Cmd_Dep_Code2,@Cmd_Dep_Name,@Cmd_Contract_Code,@Cmd_Type,@Cmd_Supplier,@Cmd_CBill,@Cmd_CBillName,@Cmd_CBillTime,@Cmd_Bak,@Cmd_Stat,@Stat,@AuditStat,@AuditCurAudit,@AuditDate,@AuditOwner,@CreateDate,@UpdateDate,@DeleteDate,@Cmd_Udef1,@Cmd_Udef2,@Cmd_Udef3,@Cmd_Udef4,@Cmd_AllCount)";
         if (string.IsNullOrEmpty(prod_Command.Cmd_Code))
         {
            idb.AddParameter("@Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Code", prod_Command.Cmd_Code);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Dep_Code2))
         {
            idb.AddParameter("@Cmd_Dep_Code2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Dep_Code2", prod_Command.Cmd_Dep_Code2);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Dep_Name))
         {
            idb.AddParameter("@Cmd_Dep_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Dep_Name", prod_Command.Cmd_Dep_Name);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Contract_Code))
         {
            idb.AddParameter("@Cmd_Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Contract_Code", prod_Command.Cmd_Contract_Code);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Type))
         {
            idb.AddParameter("@Cmd_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Type", prod_Command.Cmd_Type);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Supplier))
         {
            idb.AddParameter("@Cmd_Supplier", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Supplier", prod_Command.Cmd_Supplier);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_CBill))
         {
            idb.AddParameter("@Cmd_CBill", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBill", prod_Command.Cmd_CBill);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_CBillName))
         {
            idb.AddParameter("@Cmd_CBillName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBillName", prod_Command.Cmd_CBillName);
         }
         if (prod_Command.Cmd_CBillTime == DateTime.MinValue)
         {
            idb.AddParameter("@Cmd_CBillTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBillTime", prod_Command.Cmd_CBillTime);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Bak))
         {
            idb.AddParameter("@Cmd_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Bak", prod_Command.Cmd_Bak);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Stat))
         {
            idb.AddParameter("@Cmd_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Stat", prod_Command.Cmd_Stat);
         }
         if (prod_Command.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Command.Stat);
         }
         if (string.IsNullOrEmpty(prod_Command.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", prod_Command.AuditStat);
         }
         if (string.IsNullOrEmpty(prod_Command.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", prod_Command.AuditCurAudit);
         }
         if (prod_Command.AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditDate", prod_Command.AuditDate);
         }
         if (string.IsNullOrEmpty(prod_Command.AuditOwner))
         {
            idb.AddParameter("@AuditOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditOwner", prod_Command.AuditOwner);
         }
         if (prod_Command.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", prod_Command.CreateDate);
         }
         if (prod_Command.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", prod_Command.UpdateDate);
         }
         if (prod_Command.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", prod_Command.DeleteDate);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef1))
         {
            idb.AddParameter("@Cmd_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef1", prod_Command.Cmd_Udef1);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef2))
         {
            idb.AddParameter("@Cmd_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef2", prod_Command.Cmd_Udef2);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef3))
         {
            idb.AddParameter("@Cmd_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef3", prod_Command.Cmd_Udef3);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef4))
         {
            idb.AddParameter("@Cmd_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef4", prod_Command.Cmd_Udef4);
         }
         if (prod_Command.Cmd_AllCount == 0)
         {
            idb.AddParameter("@Cmd_AllCount", 0);
         }
         else
         {
            idb.AddParameter("@Cmd_AllCount", prod_Command.Cmd_AllCount);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加生产指令表 Prod_Command对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Command prod_Command)
      {
         string sql = "INSERT INTO Prod_Command (Cmd_Code,Cmd_Dep_Code2,Cmd_Dep_Name,Cmd_Contract_Code,Cmd_Type,Cmd_Supplier,Cmd_CBill,Cmd_CBillName,Cmd_CBillTime,Cmd_Bak,Cmd_Stat,Stat,AuditStat,AuditCurAudit,AuditDate,AuditOwner,CreateDate,UpdateDate,DeleteDate,Cmd_Udef1,Cmd_Udef2,Cmd_Udef3,Cmd_Udef4,Cmd_AllCount) VALUES (@Cmd_Code,@Cmd_Dep_Code2,@Cmd_Dep_Name,@Cmd_Contract_Code,@Cmd_Type,@Cmd_Supplier,@Cmd_CBill,@Cmd_CBillName,@Cmd_CBillTime,@Cmd_Bak,@Cmd_Stat,@Stat,@AuditStat,@AuditCurAudit,@AuditDate,@AuditOwner,@CreateDate,@UpdateDate,@DeleteDate,@Cmd_Udef1,@Cmd_Udef2,@Cmd_Udef3,@Cmd_Udef4,@Cmd_AllCount);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Command.Cmd_Code))
         {
            idb.AddParameter("@Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Code", prod_Command.Cmd_Code);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Dep_Code2))
         {
            idb.AddParameter("@Cmd_Dep_Code2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Dep_Code2", prod_Command.Cmd_Dep_Code2);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Dep_Name))
         {
            idb.AddParameter("@Cmd_Dep_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Dep_Name", prod_Command.Cmd_Dep_Name);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Contract_Code))
         {
            idb.AddParameter("@Cmd_Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Contract_Code", prod_Command.Cmd_Contract_Code);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Type))
         {
            idb.AddParameter("@Cmd_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Type", prod_Command.Cmd_Type);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Supplier))
         {
            idb.AddParameter("@Cmd_Supplier", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Supplier", prod_Command.Cmd_Supplier);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_CBill))
         {
            idb.AddParameter("@Cmd_CBill", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBill", prod_Command.Cmd_CBill);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_CBillName))
         {
            idb.AddParameter("@Cmd_CBillName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBillName", prod_Command.Cmd_CBillName);
         }
         if (prod_Command.Cmd_CBillTime == DateTime.MinValue)
         {
            idb.AddParameter("@Cmd_CBillTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBillTime", prod_Command.Cmd_CBillTime);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Bak))
         {
            idb.AddParameter("@Cmd_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Bak", prod_Command.Cmd_Bak);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Stat))
         {
            idb.AddParameter("@Cmd_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Stat", prod_Command.Cmd_Stat);
         }
         if (prod_Command.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Command.Stat);
         }
         if (string.IsNullOrEmpty(prod_Command.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", prod_Command.AuditStat);
         }
         if (string.IsNullOrEmpty(prod_Command.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", prod_Command.AuditCurAudit);
         }
         if (prod_Command.AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditDate", prod_Command.AuditDate);
         }
         if (string.IsNullOrEmpty(prod_Command.AuditOwner))
         {
            idb.AddParameter("@AuditOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditOwner", prod_Command.AuditOwner);
         }
         if (prod_Command.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", prod_Command.CreateDate);
         }
         if (prod_Command.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", prod_Command.UpdateDate);
         }
         if (prod_Command.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", prod_Command.DeleteDate);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef1))
         {
            idb.AddParameter("@Cmd_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef1", prod_Command.Cmd_Udef1);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef2))
         {
            idb.AddParameter("@Cmd_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef2", prod_Command.Cmd_Udef2);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef3))
         {
            idb.AddParameter("@Cmd_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef3", prod_Command.Cmd_Udef3);
         }
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef4))
         {
            idb.AddParameter("@Cmd_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef4", prod_Command.Cmd_Udef4);
         }
         if (prod_Command.Cmd_AllCount == 0)
         {
            idb.AddParameter("@Cmd_AllCount", 0);
         }
         else
         {
            idb.AddParameter("@Cmd_AllCount", prod_Command.Cmd_AllCount);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新生产指令表 Prod_Command对象(即:一条记录
      /// </summary>
      public int Update(Prod_Command prod_Command)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Command       SET ");
            if(prod_Command.Cmd_Code_IsChanged){sbParameter.Append("Cmd_Code=@Cmd_Code, ");}
      if(prod_Command.Cmd_Dep_Code2_IsChanged){sbParameter.Append("Cmd_Dep_Code2=@Cmd_Dep_Code2, ");}
      if(prod_Command.Cmd_Dep_Name_IsChanged){sbParameter.Append("Cmd_Dep_Name=@Cmd_Dep_Name, ");}
      if(prod_Command.Cmd_Contract_Code_IsChanged){sbParameter.Append("Cmd_Contract_Code=@Cmd_Contract_Code, ");}
      if(prod_Command.Cmd_Type_IsChanged){sbParameter.Append("Cmd_Type=@Cmd_Type, ");}
      if(prod_Command.Cmd_Supplier_IsChanged){sbParameter.Append("Cmd_Supplier=@Cmd_Supplier, ");}
      if(prod_Command.Cmd_CBill_IsChanged){sbParameter.Append("Cmd_CBill=@Cmd_CBill, ");}
      if(prod_Command.Cmd_CBillName_IsChanged){sbParameter.Append("Cmd_CBillName=@Cmd_CBillName, ");}
      if(prod_Command.Cmd_CBillTime_IsChanged){sbParameter.Append("Cmd_CBillTime=@Cmd_CBillTime, ");}
      if(prod_Command.Cmd_Bak_IsChanged){sbParameter.Append("Cmd_Bak=@Cmd_Bak, ");}
      if(prod_Command.Cmd_Stat_IsChanged){sbParameter.Append("Cmd_Stat=@Cmd_Stat, ");}
      if(prod_Command.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_Command.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(prod_Command.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(prod_Command.AuditDate_IsChanged){sbParameter.Append("AuditDate=@AuditDate, ");}
      if(prod_Command.AuditOwner_IsChanged){sbParameter.Append("AuditOwner=@AuditOwner, ");}
      if(prod_Command.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(prod_Command.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(prod_Command.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(prod_Command.Cmd_Udef1_IsChanged){sbParameter.Append("Cmd_Udef1=@Cmd_Udef1, ");}
      if(prod_Command.Cmd_Udef2_IsChanged){sbParameter.Append("Cmd_Udef2=@Cmd_Udef2, ");}
      if(prod_Command.Cmd_Udef3_IsChanged){sbParameter.Append("Cmd_Udef3=@Cmd_Udef3, ");}
      if(prod_Command.Cmd_Udef4_IsChanged){sbParameter.Append("Cmd_Udef4=@Cmd_Udef4, ");}
      if(prod_Command.Cmd_AllCount_IsChanged){sbParameter.Append("Cmd_AllCount=@Cmd_AllCount ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Cmd_ID=@Cmd_ID; " );
      string sql=sb.ToString();
         if(prod_Command.Cmd_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Code))
         {
            idb.AddParameter("@Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Code", prod_Command.Cmd_Code);
         }
          }
         if(prod_Command.Cmd_Dep_Code2_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Dep_Code2))
         {
            idb.AddParameter("@Cmd_Dep_Code2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Dep_Code2", prod_Command.Cmd_Dep_Code2);
         }
          }
         if(prod_Command.Cmd_Dep_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Dep_Name))
         {
            idb.AddParameter("@Cmd_Dep_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Dep_Name", prod_Command.Cmd_Dep_Name);
         }
          }
         if(prod_Command.Cmd_Contract_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Contract_Code))
         {
            idb.AddParameter("@Cmd_Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Contract_Code", prod_Command.Cmd_Contract_Code);
         }
          }
         if(prod_Command.Cmd_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Type))
         {
            idb.AddParameter("@Cmd_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Type", prod_Command.Cmd_Type);
         }
          }
         if(prod_Command.Cmd_Supplier_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Supplier))
         {
            idb.AddParameter("@Cmd_Supplier", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Supplier", prod_Command.Cmd_Supplier);
         }
          }
         if(prod_Command.Cmd_CBill_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_CBill))
         {
            idb.AddParameter("@Cmd_CBill", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBill", prod_Command.Cmd_CBill);
         }
          }
         if(prod_Command.Cmd_CBillName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_CBillName))
         {
            idb.AddParameter("@Cmd_CBillName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBillName", prod_Command.Cmd_CBillName);
         }
          }
         if(prod_Command.Cmd_CBillTime_IsChanged)
         {
         if (prod_Command.Cmd_CBillTime == DateTime.MinValue)
         {
            idb.AddParameter("@Cmd_CBillTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_CBillTime", prod_Command.Cmd_CBillTime);
         }
          }
         if(prod_Command.Cmd_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Bak))
         {
            idb.AddParameter("@Cmd_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Bak", prod_Command.Cmd_Bak);
         }
          }
         if(prod_Command.Cmd_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Stat))
         {
            idb.AddParameter("@Cmd_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Stat", prod_Command.Cmd_Stat);
         }
          }
         if(prod_Command.Stat_IsChanged)
         {
         if (prod_Command.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Command.Stat);
         }
          }
         if(prod_Command.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", prod_Command.AuditStat);
         }
          }
         if(prod_Command.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", prod_Command.AuditCurAudit);
         }
          }
         if(prod_Command.AuditDate_IsChanged)
         {
         if (prod_Command.AuditDate == DateTime.MinValue)
         {
            idb.AddParameter("@AuditDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditDate", prod_Command.AuditDate);
         }
          }
         if(prod_Command.AuditOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.AuditOwner))
         {
            idb.AddParameter("@AuditOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditOwner", prod_Command.AuditOwner);
         }
          }
         if(prod_Command.CreateDate_IsChanged)
         {
         if (prod_Command.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", prod_Command.CreateDate);
         }
          }
         if(prod_Command.UpdateDate_IsChanged)
         {
         if (prod_Command.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", prod_Command.UpdateDate);
         }
          }
         if(prod_Command.DeleteDate_IsChanged)
         {
         if (prod_Command.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", prod_Command.DeleteDate);
         }
          }
         if(prod_Command.Cmd_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef1))
         {
            idb.AddParameter("@Cmd_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef1", prod_Command.Cmd_Udef1);
         }
          }
         if(prod_Command.Cmd_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef2))
         {
            idb.AddParameter("@Cmd_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef2", prod_Command.Cmd_Udef2);
         }
          }
         if(prod_Command.Cmd_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef3))
         {
            idb.AddParameter("@Cmd_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef3", prod_Command.Cmd_Udef3);
         }
          }
         if(prod_Command.Cmd_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Command.Cmd_Udef4))
         {
            idb.AddParameter("@Cmd_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Udef4", prod_Command.Cmd_Udef4);
         }
          }
         if(prod_Command.Cmd_AllCount_IsChanged)
         {
         if (prod_Command.Cmd_AllCount == 0)
         {
            idb.AddParameter("@Cmd_AllCount", 0);
         }
         else
         {
            idb.AddParameter("@Cmd_AllCount", prod_Command.Cmd_AllCount);
         }
          }

         idb.AddParameter("@Cmd_ID", prod_Command.Cmd_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除生产指令表 Prod_Command对象(即:一条记录
      /// </summary>
      public int Delete(Int64 cmd_ID)
      {
         string sql = "DELETE Prod_Command WHERE 1=1  AND Cmd_ID=@Cmd_ID ";
         idb.AddParameter("@Cmd_ID", cmd_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的生产指令表 Prod_Command对象(即:一条记录
      /// </summary>
      public Prod_Command GetByKey(Int64 cmd_ID)
      {
         Prod_Command prod_Command = new Prod_Command();
         string sql = "SELECT  Cmd_ID,Cmd_Code,Cmd_Dep_Code2,Cmd_Dep_Name,Cmd_Contract_Code,Cmd_Type,Cmd_Supplier,Cmd_CBill,Cmd_CBillName,Cmd_CBillTime,Cmd_Bak,Cmd_Stat,Stat,AuditStat,AuditCurAudit,AuditDate,AuditOwner,CreateDate,UpdateDate,DeleteDate,Cmd_Udef1,Cmd_Udef2,Cmd_Udef3,Cmd_Udef4,Cmd_AllCount FROM Prod_Command WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Cmd_ID=@Cmd_ID ";
         idb.AddParameter("@Cmd_ID", cmd_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Cmd_ID"] != DBNull.Value) prod_Command.Cmd_ID = Convert.ToInt64(dr["Cmd_ID"]);
            if (dr["Cmd_Code"] != DBNull.Value) prod_Command.Cmd_Code = Convert.ToString(dr["Cmd_Code"]);
            if (dr["Cmd_Dep_Code2"] != DBNull.Value) prod_Command.Cmd_Dep_Code2 = Convert.ToString(dr["Cmd_Dep_Code2"]);
            if (dr["Cmd_Dep_Name"] != DBNull.Value) prod_Command.Cmd_Dep_Name = Convert.ToString(dr["Cmd_Dep_Name"]);
            if (dr["Cmd_Contract_Code"] != DBNull.Value) prod_Command.Cmd_Contract_Code = Convert.ToString(dr["Cmd_Contract_Code"]);
            if (dr["Cmd_Type"] != DBNull.Value) prod_Command.Cmd_Type = Convert.ToString(dr["Cmd_Type"]);
            if (dr["Cmd_Supplier"] != DBNull.Value) prod_Command.Cmd_Supplier = Convert.ToString(dr["Cmd_Supplier"]);
            if (dr["Cmd_CBill"] != DBNull.Value) prod_Command.Cmd_CBill = Convert.ToString(dr["Cmd_CBill"]);
            if (dr["Cmd_CBillName"] != DBNull.Value) prod_Command.Cmd_CBillName = Convert.ToString(dr["Cmd_CBillName"]);
            if (dr["Cmd_CBillTime"] != DBNull.Value) prod_Command.Cmd_CBillTime = Convert.ToDateTime(dr["Cmd_CBillTime"]);
            if (dr["Cmd_Bak"] != DBNull.Value) prod_Command.Cmd_Bak = Convert.ToString(dr["Cmd_Bak"]);
            if (dr["Cmd_Stat"] != DBNull.Value) prod_Command.Cmd_Stat = Convert.ToString(dr["Cmd_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_Command.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) prod_Command.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) prod_Command.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditDate"] != DBNull.Value) prod_Command.AuditDate = Convert.ToDateTime(dr["AuditDate"]);
            if (dr["AuditOwner"] != DBNull.Value) prod_Command.AuditOwner = Convert.ToString(dr["AuditOwner"]);
            if (dr["CreateDate"] != DBNull.Value) prod_Command.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) prod_Command.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) prod_Command.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Cmd_Udef1"] != DBNull.Value) prod_Command.Cmd_Udef1 = Convert.ToString(dr["Cmd_Udef1"]);
            if (dr["Cmd_Udef2"] != DBNull.Value) prod_Command.Cmd_Udef2 = Convert.ToString(dr["Cmd_Udef2"]);
            if (dr["Cmd_Udef3"] != DBNull.Value) prod_Command.Cmd_Udef3 = Convert.ToString(dr["Cmd_Udef3"]);
            if (dr["Cmd_Udef4"] != DBNull.Value) prod_Command.Cmd_Udef4 = Convert.ToString(dr["Cmd_Udef4"]);
            if (dr["Cmd_AllCount"] != DBNull.Value) prod_Command.Cmd_AllCount = Convert.ToInt32(dr["Cmd_AllCount"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_Command;
      }
      /// <summary>
      /// 获取指定的生产指令表 Prod_Command对象集合
      /// </summary>
      public List<Prod_Command> GetListByWhere(string strCondition)
      {
         List<Prod_Command> ret = new List<Prod_Command>();
         string sql = "SELECT  Cmd_ID,Cmd_Code,Cmd_Dep_Code2,Cmd_Dep_Name,Cmd_Contract_Code,Cmd_Type,Cmd_Supplier,Cmd_CBill,Cmd_CBillName,Cmd_CBillTime,Cmd_Bak,Cmd_Stat,Stat,AuditStat,AuditCurAudit,AuditDate,AuditOwner,CreateDate,UpdateDate,DeleteDate,Cmd_Udef1,Cmd_Udef2,Cmd_Udef3,Cmd_Udef4,Cmd_AllCount FROM Prod_Command WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_Command prod_Command = new Prod_Command();
            if (dr["Cmd_ID"] != DBNull.Value) prod_Command.Cmd_ID = Convert.ToInt64(dr["Cmd_ID"]);
            if (dr["Cmd_Code"] != DBNull.Value) prod_Command.Cmd_Code = Convert.ToString(dr["Cmd_Code"]);
            if (dr["Cmd_Dep_Code2"] != DBNull.Value) prod_Command.Cmd_Dep_Code2 = Convert.ToString(dr["Cmd_Dep_Code2"]);
            if (dr["Cmd_Dep_Name"] != DBNull.Value) prod_Command.Cmd_Dep_Name = Convert.ToString(dr["Cmd_Dep_Name"]);
            if (dr["Cmd_Contract_Code"] != DBNull.Value) prod_Command.Cmd_Contract_Code = Convert.ToString(dr["Cmd_Contract_Code"]);
            if (dr["Cmd_Type"] != DBNull.Value) prod_Command.Cmd_Type = Convert.ToString(dr["Cmd_Type"]);
            if (dr["Cmd_Supplier"] != DBNull.Value) prod_Command.Cmd_Supplier = Convert.ToString(dr["Cmd_Supplier"]);
            if (dr["Cmd_CBill"] != DBNull.Value) prod_Command.Cmd_CBill = Convert.ToString(dr["Cmd_CBill"]);
            if (dr["Cmd_CBillName"] != DBNull.Value) prod_Command.Cmd_CBillName = Convert.ToString(dr["Cmd_CBillName"]);
            if (dr["Cmd_CBillTime"] != DBNull.Value) prod_Command.Cmd_CBillTime = Convert.ToDateTime(dr["Cmd_CBillTime"]);
            if (dr["Cmd_Bak"] != DBNull.Value) prod_Command.Cmd_Bak = Convert.ToString(dr["Cmd_Bak"]);
            if (dr["Cmd_Stat"] != DBNull.Value) prod_Command.Cmd_Stat = Convert.ToString(dr["Cmd_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_Command.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) prod_Command.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) prod_Command.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditDate"] != DBNull.Value) prod_Command.AuditDate = Convert.ToDateTime(dr["AuditDate"]);
            if (dr["AuditOwner"] != DBNull.Value) prod_Command.AuditOwner = Convert.ToString(dr["AuditOwner"]);
            if (dr["CreateDate"] != DBNull.Value) prod_Command.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) prod_Command.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) prod_Command.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Cmd_Udef1"] != DBNull.Value) prod_Command.Cmd_Udef1 = Convert.ToString(dr["Cmd_Udef1"]);
            if (dr["Cmd_Udef2"] != DBNull.Value) prod_Command.Cmd_Udef2 = Convert.ToString(dr["Cmd_Udef2"]);
            if (dr["Cmd_Udef3"] != DBNull.Value) prod_Command.Cmd_Udef3 = Convert.ToString(dr["Cmd_Udef3"]);
            if (dr["Cmd_Udef4"] != DBNull.Value) prod_Command.Cmd_Udef4 = Convert.ToString(dr["Cmd_Udef4"]);
            if (dr["Cmd_AllCount"] != DBNull.Value) prod_Command.Cmd_AllCount = Convert.ToInt32(dr["Cmd_AllCount"]);
            ret.Add(prod_Command);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产指令表 Prod_Command对象(即:一条记录
      /// </summary>
      public List<Prod_Command> GetAll()
      {
         List<Prod_Command> ret = new List<Prod_Command>();
         string sql = "SELECT  Cmd_ID,Cmd_Code,Cmd_Dep_Code2,Cmd_Dep_Name,Cmd_Contract_Code,Cmd_Type,Cmd_Supplier,Cmd_CBill,Cmd_CBillName,Cmd_CBillTime,Cmd_Bak,Cmd_Stat,Stat,AuditStat,AuditCurAudit,AuditDate,AuditOwner,CreateDate,UpdateDate,DeleteDate,Cmd_Udef1,Cmd_Udef2,Cmd_Udef3,Cmd_Udef4,Cmd_AllCount FROM Prod_Command where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Command prod_Command = new Prod_Command();
            if (dr["Cmd_ID"] != DBNull.Value) prod_Command.Cmd_ID = Convert.ToInt64(dr["Cmd_ID"]);
            if (dr["Cmd_Code"] != DBNull.Value) prod_Command.Cmd_Code = Convert.ToString(dr["Cmd_Code"]);
            if (dr["Cmd_Dep_Code2"] != DBNull.Value) prod_Command.Cmd_Dep_Code2 = Convert.ToString(dr["Cmd_Dep_Code2"]);
            if (dr["Cmd_Dep_Name"] != DBNull.Value) prod_Command.Cmd_Dep_Name = Convert.ToString(dr["Cmd_Dep_Name"]);
            if (dr["Cmd_Contract_Code"] != DBNull.Value) prod_Command.Cmd_Contract_Code = Convert.ToString(dr["Cmd_Contract_Code"]);
            if (dr["Cmd_Type"] != DBNull.Value) prod_Command.Cmd_Type = Convert.ToString(dr["Cmd_Type"]);
            if (dr["Cmd_Supplier"] != DBNull.Value) prod_Command.Cmd_Supplier = Convert.ToString(dr["Cmd_Supplier"]);
            if (dr["Cmd_CBill"] != DBNull.Value) prod_Command.Cmd_CBill = Convert.ToString(dr["Cmd_CBill"]);
            if (dr["Cmd_CBillName"] != DBNull.Value) prod_Command.Cmd_CBillName = Convert.ToString(dr["Cmd_CBillName"]);
            if (dr["Cmd_CBillTime"] != DBNull.Value) prod_Command.Cmd_CBillTime = Convert.ToDateTime(dr["Cmd_CBillTime"]);
            if (dr["Cmd_Bak"] != DBNull.Value) prod_Command.Cmd_Bak = Convert.ToString(dr["Cmd_Bak"]);
            if (dr["Cmd_Stat"] != DBNull.Value) prod_Command.Cmd_Stat = Convert.ToString(dr["Cmd_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_Command.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["AuditStat"] != DBNull.Value) prod_Command.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) prod_Command.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["AuditDate"] != DBNull.Value) prod_Command.AuditDate = Convert.ToDateTime(dr["AuditDate"]);
            if (dr["AuditOwner"] != DBNull.Value) prod_Command.AuditOwner = Convert.ToString(dr["AuditOwner"]);
            if (dr["CreateDate"] != DBNull.Value) prod_Command.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) prod_Command.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) prod_Command.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["Cmd_Udef1"] != DBNull.Value) prod_Command.Cmd_Udef1 = Convert.ToString(dr["Cmd_Udef1"]);
            if (dr["Cmd_Udef2"] != DBNull.Value) prod_Command.Cmd_Udef2 = Convert.ToString(dr["Cmd_Udef2"]);
            if (dr["Cmd_Udef3"] != DBNull.Value) prod_Command.Cmd_Udef3 = Convert.ToString(dr["Cmd_Udef3"]);
            if (dr["Cmd_Udef4"] != DBNull.Value) prod_Command.Cmd_Udef4 = Convert.ToString(dr["Cmd_Udef4"]);
            if (dr["Cmd_AllCount"] != DBNull.Value) prod_Command.Cmd_AllCount = Convert.ToInt32(dr["Cmd_AllCount"]);
            ret.Add(prod_Command);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
