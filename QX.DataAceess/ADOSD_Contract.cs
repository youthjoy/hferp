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
   /// 经营处合同信息
   /// </summary>
   [Serializable]
   public partial class ADOSD_Contract
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加经营处合同信息 SD_Contract对象(即:一条记录)
      /// </summary>
      public int Add(SD_Contract sD_Contract)
      {
         string sql = "INSERT INTO SD_Contract (Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,Stat,Contract_Stat,Contract_Date,Contract_VerifyStat,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat,AuditCurAudit,Contract_Bak,Contract_Creator,Contract_Cmd,Contract_Project) VALUES (@Contract_Code,@Contract_Name,@Contract_CDate,@Contract_EffectDate,@Contract_OwnerName,@Contract_Owner,@Contract_CustOwner,@Contract_CustLink,@Contract_Type,@Contract_CustCode,@Contract_CustName,@Stat,@Contract_Stat,@Contract_Date,@Contract_VerifyStat,@Contract_VerifyDate,@Contract_VerifyNextNode,@AuditStat,@AuditCurAudit,@Contract_Bak,@Contract_Creator,@Contract_Cmd,@Contract_Project)";
         if (string.IsNullOrEmpty(sD_Contract.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", sD_Contract.Contract_Code);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Name))
         {
            idb.AddParameter("@Contract_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Name", sD_Contract.Contract_Name);
         }
         if (sD_Contract.Contract_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CDate", sD_Contract.Contract_CDate);
         }
         if (sD_Contract.Contract_EffectDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_EffectDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_EffectDate", sD_Contract.Contract_EffectDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_OwnerName))
         {
            idb.AddParameter("@Contract_OwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_OwnerName", sD_Contract.Contract_OwnerName);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Owner))
         {
            idb.AddParameter("@Contract_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Owner", sD_Contract.Contract_Owner);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustOwner))
         {
            idb.AddParameter("@Contract_CustOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustOwner", sD_Contract.Contract_CustOwner);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustLink))
         {
            idb.AddParameter("@Contract_CustLink", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustLink", sD_Contract.Contract_CustLink);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Type))
         {
            idb.AddParameter("@Contract_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Type", sD_Contract.Contract_Type);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustCode))
         {
            idb.AddParameter("@Contract_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustCode", sD_Contract.Contract_CustCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustName))
         {
            idb.AddParameter("@Contract_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustName", sD_Contract.Contract_CustName);
         }
         if (sD_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Contract.Stat);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Stat))
         {
            idb.AddParameter("@Contract_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Stat", sD_Contract.Contract_Stat);
         }
         if (sD_Contract.Contract_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Date", sD_Contract.Contract_Date);
         }
         if (sD_Contract.Contract_VerifyStat == 0)
         {
            idb.AddParameter("@Contract_VerifyStat", 0);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyStat", sD_Contract.Contract_VerifyStat);
         }
         if (sD_Contract.Contract_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyDate", sD_Contract.Contract_VerifyDate);
         }
         if (sD_Contract.Contract_VerifyNextNode == 0)
         {
            idb.AddParameter("@Contract_VerifyNextNode", 0);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyNextNode", sD_Contract.Contract_VerifyNextNode);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", sD_Contract.AuditStat);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", sD_Contract.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Bak))
         {
            idb.AddParameter("@Contract_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Bak", sD_Contract.Contract_Bak);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Creator))
         {
            idb.AddParameter("@Contract_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Creator", sD_Contract.Contract_Creator);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Cmd))
         {
            idb.AddParameter("@Contract_Cmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Cmd", sD_Contract.Contract_Cmd);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Project))
         {
            idb.AddParameter("@Contract_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Project", sD_Contract.Contract_Project);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加经营处合同信息 SD_Contract对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Contract sD_Contract)
      {
         string sql = "INSERT INTO SD_Contract (Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,Stat,Contract_Stat,Contract_Date,Contract_VerifyStat,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat,AuditCurAudit,Contract_Bak,Contract_Creator,Contract_Cmd,Contract_Project) VALUES (@Contract_Code,@Contract_Name,@Contract_CDate,@Contract_EffectDate,@Contract_OwnerName,@Contract_Owner,@Contract_CustOwner,@Contract_CustLink,@Contract_Type,@Contract_CustCode,@Contract_CustName,@Stat,@Contract_Stat,@Contract_Date,@Contract_VerifyStat,@Contract_VerifyDate,@Contract_VerifyNextNode,@AuditStat,@AuditCurAudit,@Contract_Bak,@Contract_Creator,@Contract_Cmd,@Contract_Project);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Contract.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", sD_Contract.Contract_Code);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Name))
         {
            idb.AddParameter("@Contract_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Name", sD_Contract.Contract_Name);
         }
         if (sD_Contract.Contract_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CDate", sD_Contract.Contract_CDate);
         }
         if (sD_Contract.Contract_EffectDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_EffectDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_EffectDate", sD_Contract.Contract_EffectDate);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_OwnerName))
         {
            idb.AddParameter("@Contract_OwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_OwnerName", sD_Contract.Contract_OwnerName);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Owner))
         {
            idb.AddParameter("@Contract_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Owner", sD_Contract.Contract_Owner);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustOwner))
         {
            idb.AddParameter("@Contract_CustOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustOwner", sD_Contract.Contract_CustOwner);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustLink))
         {
            idb.AddParameter("@Contract_CustLink", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustLink", sD_Contract.Contract_CustLink);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Type))
         {
            idb.AddParameter("@Contract_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Type", sD_Contract.Contract_Type);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustCode))
         {
            idb.AddParameter("@Contract_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustCode", sD_Contract.Contract_CustCode);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustName))
         {
            idb.AddParameter("@Contract_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustName", sD_Contract.Contract_CustName);
         }
         if (sD_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Contract.Stat);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Stat))
         {
            idb.AddParameter("@Contract_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Stat", sD_Contract.Contract_Stat);
         }
         if (sD_Contract.Contract_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Date", sD_Contract.Contract_Date);
         }
         if (sD_Contract.Contract_VerifyStat == 0)
         {
            idb.AddParameter("@Contract_VerifyStat", 0);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyStat", sD_Contract.Contract_VerifyStat);
         }
         if (sD_Contract.Contract_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyDate", sD_Contract.Contract_VerifyDate);
         }
         if (sD_Contract.Contract_VerifyNextNode == 0)
         {
            idb.AddParameter("@Contract_VerifyNextNode", 0);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyNextNode", sD_Contract.Contract_VerifyNextNode);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", sD_Contract.AuditStat);
         }
         if (string.IsNullOrEmpty(sD_Contract.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", sD_Contract.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Bak))
         {
            idb.AddParameter("@Contract_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Bak", sD_Contract.Contract_Bak);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Creator))
         {
            idb.AddParameter("@Contract_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Creator", sD_Contract.Contract_Creator);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Cmd))
         {
            idb.AddParameter("@Contract_Cmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Cmd", sD_Contract.Contract_Cmd);
         }
         if (string.IsNullOrEmpty(sD_Contract.Contract_Project))
         {
            idb.AddParameter("@Contract_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Project", sD_Contract.Contract_Project);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新经营处合同信息 SD_Contract对象(即:一条记录
      /// </summary>
      public int Update(SD_Contract sD_Contract)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Contract       SET ");
            if(sD_Contract.Contract_Code_IsChanged){sbParameter.Append("Contract_Code=@Contract_Code, ");}
      if(sD_Contract.Contract_Name_IsChanged){sbParameter.Append("Contract_Name=@Contract_Name, ");}
      if(sD_Contract.Contract_CDate_IsChanged){sbParameter.Append("Contract_CDate=@Contract_CDate, ");}
      if(sD_Contract.Contract_EffectDate_IsChanged){sbParameter.Append("Contract_EffectDate=@Contract_EffectDate, ");}
      if(sD_Contract.Contract_OwnerName_IsChanged){sbParameter.Append("Contract_OwnerName=@Contract_OwnerName, ");}
      if(sD_Contract.Contract_Owner_IsChanged){sbParameter.Append("Contract_Owner=@Contract_Owner, ");}
      if(sD_Contract.Contract_CustOwner_IsChanged){sbParameter.Append("Contract_CustOwner=@Contract_CustOwner, ");}
      if(sD_Contract.Contract_CustLink_IsChanged){sbParameter.Append("Contract_CustLink=@Contract_CustLink, ");}
      if(sD_Contract.Contract_Type_IsChanged){sbParameter.Append("Contract_Type=@Contract_Type, ");}
      if(sD_Contract.Contract_CustCode_IsChanged){sbParameter.Append("Contract_CustCode=@Contract_CustCode, ");}
      if(sD_Contract.Contract_CustName_IsChanged){sbParameter.Append("Contract_CustName=@Contract_CustName, ");}
      if(sD_Contract.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Contract.Contract_Stat_IsChanged){sbParameter.Append("Contract_Stat=@Contract_Stat, ");}
      if(sD_Contract.Contract_Date_IsChanged){sbParameter.Append("Contract_Date=@Contract_Date, ");}
      if(sD_Contract.Contract_VerifyStat_IsChanged){sbParameter.Append("Contract_VerifyStat=@Contract_VerifyStat, ");}
      if(sD_Contract.Contract_VerifyDate_IsChanged){sbParameter.Append("Contract_VerifyDate=@Contract_VerifyDate, ");}
      if(sD_Contract.Contract_VerifyNextNode_IsChanged){sbParameter.Append("Contract_VerifyNextNode=@Contract_VerifyNextNode, ");}
      if(sD_Contract.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(sD_Contract.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(sD_Contract.Contract_Bak_IsChanged){sbParameter.Append("Contract_Bak=@Contract_Bak, ");}
      if(sD_Contract.Contract_Creator_IsChanged){sbParameter.Append("Contract_Creator=@Contract_Creator, ");}
      if(sD_Contract.Contract_Cmd_IsChanged){sbParameter.Append("Contract_Cmd=@Contract_Cmd, ");}
      if(sD_Contract.Contract_Project_IsChanged){sbParameter.Append("Contract_Project=@Contract_Project ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Contract_ID=@Contract_ID; " );
      string sql=sb.ToString();
         if(sD_Contract.Contract_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Code))
         {
            idb.AddParameter("@Contract_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Code", sD_Contract.Contract_Code);
         }
          }
         if(sD_Contract.Contract_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Name))
         {
            idb.AddParameter("@Contract_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Name", sD_Contract.Contract_Name);
         }
          }
         if(sD_Contract.Contract_CDate_IsChanged)
         {
         if (sD_Contract.Contract_CDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_CDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CDate", sD_Contract.Contract_CDate);
         }
          }
         if(sD_Contract.Contract_EffectDate_IsChanged)
         {
         if (sD_Contract.Contract_EffectDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_EffectDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_EffectDate", sD_Contract.Contract_EffectDate);
         }
          }
         if(sD_Contract.Contract_OwnerName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_OwnerName))
         {
            idb.AddParameter("@Contract_OwnerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_OwnerName", sD_Contract.Contract_OwnerName);
         }
          }
         if(sD_Contract.Contract_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Owner))
         {
            idb.AddParameter("@Contract_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Owner", sD_Contract.Contract_Owner);
         }
          }
         if(sD_Contract.Contract_CustOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustOwner))
         {
            idb.AddParameter("@Contract_CustOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustOwner", sD_Contract.Contract_CustOwner);
         }
          }
         if(sD_Contract.Contract_CustLink_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustLink))
         {
            idb.AddParameter("@Contract_CustLink", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustLink", sD_Contract.Contract_CustLink);
         }
          }
         if(sD_Contract.Contract_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Type))
         {
            idb.AddParameter("@Contract_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Type", sD_Contract.Contract_Type);
         }
          }
         if(sD_Contract.Contract_CustCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustCode))
         {
            idb.AddParameter("@Contract_CustCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustCode", sD_Contract.Contract_CustCode);
         }
          }
         if(sD_Contract.Contract_CustName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_CustName))
         {
            idb.AddParameter("@Contract_CustName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_CustName", sD_Contract.Contract_CustName);
         }
          }
         if(sD_Contract.Stat_IsChanged)
         {
         if (sD_Contract.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Contract.Stat);
         }
          }
         if(sD_Contract.Contract_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Stat))
         {
            idb.AddParameter("@Contract_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Stat", sD_Contract.Contract_Stat);
         }
          }
         if(sD_Contract.Contract_Date_IsChanged)
         {
         if (sD_Contract.Contract_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Date", sD_Contract.Contract_Date);
         }
          }
         if(sD_Contract.Contract_VerifyStat_IsChanged)
         {
         if (sD_Contract.Contract_VerifyStat == 0)
         {
            idb.AddParameter("@Contract_VerifyStat", 0);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyStat", sD_Contract.Contract_VerifyStat);
         }
          }
         if(sD_Contract.Contract_VerifyDate_IsChanged)
         {
         if (sD_Contract.Contract_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Contract_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyDate", sD_Contract.Contract_VerifyDate);
         }
          }
         if(sD_Contract.Contract_VerifyNextNode_IsChanged)
         {
         if (sD_Contract.Contract_VerifyNextNode == 0)
         {
            idb.AddParameter("@Contract_VerifyNextNode", 0);
         }
         else
         {
            idb.AddParameter("@Contract_VerifyNextNode", sD_Contract.Contract_VerifyNextNode);
         }
          }
         if(sD_Contract.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", sD_Contract.AuditStat);
         }
          }
         if(sD_Contract.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", sD_Contract.AuditCurAudit);
         }
          }
         if(sD_Contract.Contract_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Bak))
         {
            idb.AddParameter("@Contract_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Bak", sD_Contract.Contract_Bak);
         }
          }
         if(sD_Contract.Contract_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Creator))
         {
            idb.AddParameter("@Contract_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Creator", sD_Contract.Contract_Creator);
         }
          }
         if(sD_Contract.Contract_Cmd_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Cmd))
         {
            idb.AddParameter("@Contract_Cmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Cmd", sD_Contract.Contract_Cmd);
         }
          }
         if(sD_Contract.Contract_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Contract.Contract_Project))
         {
            idb.AddParameter("@Contract_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Contract_Project", sD_Contract.Contract_Project);
         }
          }

         idb.AddParameter("@Contract_ID", sD_Contract.Contract_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除经营处合同信息 SD_Contract对象(即:一条记录
      /// </summary>
      public int Delete(Int64 contract_ID)
      {
         string sql = "DELETE SD_Contract WHERE 1=1  AND Contract_ID=@Contract_ID ";
         idb.AddParameter("@Contract_ID", contract_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的经营处合同信息 SD_Contract对象(即:一条记录
      /// </summary>
      public SD_Contract GetByKey(Int64 contract_ID)
      {
         SD_Contract sD_Contract = new SD_Contract();
         string sql = "SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,Stat,Contract_Stat,Contract_Date,Contract_VerifyStat,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat,AuditCurAudit,Contract_Bak,Contract_Creator,Contract_Cmd,Contract_Project FROM SD_Contract WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Contract_ID=@Contract_ID ";
         idb.AddParameter("@Contract_ID", contract_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Contract_ID"] != DBNull.Value) sD_Contract.Contract_ID = Convert.ToInt64(dr["Contract_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) sD_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Contract_Name"] != DBNull.Value) sD_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
            if (dr["Contract_CDate"] != DBNull.Value) sD_Contract.Contract_CDate = Convert.ToDateTime(dr["Contract_CDate"]);
            if (dr["Contract_EffectDate"] != DBNull.Value) sD_Contract.Contract_EffectDate = Convert.ToDateTime(dr["Contract_EffectDate"]);
            if (dr["Contract_OwnerName"] != DBNull.Value) sD_Contract.Contract_OwnerName = Convert.ToString(dr["Contract_OwnerName"]);
            if (dr["Contract_Owner"] != DBNull.Value) sD_Contract.Contract_Owner = Convert.ToString(dr["Contract_Owner"]);
            if (dr["Contract_CustOwner"] != DBNull.Value) sD_Contract.Contract_CustOwner = Convert.ToString(dr["Contract_CustOwner"]);
            if (dr["Contract_CustLink"] != DBNull.Value) sD_Contract.Contract_CustLink = Convert.ToString(dr["Contract_CustLink"]);
            if (dr["Contract_Type"] != DBNull.Value) sD_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
            if (dr["Contract_CustCode"] != DBNull.Value) sD_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
            if (dr["Contract_CustName"] != DBNull.Value) sD_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
            if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Contract_Stat"] != DBNull.Value) sD_Contract.Contract_Stat = Convert.ToString(dr["Contract_Stat"]);
            if (dr["Contract_Date"] != DBNull.Value) sD_Contract.Contract_Date = Convert.ToDateTime(dr["Contract_Date"]);
            if (dr["Contract_VerifyStat"] != DBNull.Value) sD_Contract.Contract_VerifyStat = Convert.ToInt32(dr["Contract_VerifyStat"]);
            if (dr["Contract_VerifyDate"] != DBNull.Value) sD_Contract.Contract_VerifyDate = Convert.ToDateTime(dr["Contract_VerifyDate"]);
            if (dr["Contract_VerifyNextNode"] != DBNull.Value) sD_Contract.Contract_VerifyNextNode = Convert.ToInt32(dr["Contract_VerifyNextNode"]);
            if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Contract_Bak"] != DBNull.Value) sD_Contract.Contract_Bak = Convert.ToString(dr["Contract_Bak"]);
            if (dr["Contract_Creator"] != DBNull.Value) sD_Contract.Contract_Creator = Convert.ToString(dr["Contract_Creator"]);
            if (dr["Contract_Cmd"] != DBNull.Value) sD_Contract.Contract_Cmd = Convert.ToString(dr["Contract_Cmd"]);
            if (dr["Contract_Project"] != DBNull.Value) sD_Contract.Contract_Project = Convert.ToString(dr["Contract_Project"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Contract;
      }
      /// <summary>
      /// 获取指定的经营处合同信息 SD_Contract对象集合
      /// </summary>
      public List<SD_Contract> GetListByWhere(string strCondition)
      {
         List<SD_Contract> ret = new List<SD_Contract>();
         string sql = "SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,Stat,Contract_Stat,Contract_Date,Contract_VerifyStat,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat,AuditCurAudit,Contract_Bak,Contract_Creator,Contract_Cmd,Contract_Project FROM SD_Contract WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_Contract sD_Contract = new SD_Contract();
            if (dr["Contract_ID"] != DBNull.Value) sD_Contract.Contract_ID = Convert.ToInt64(dr["Contract_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) sD_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Contract_Name"] != DBNull.Value) sD_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
            if (dr["Contract_CDate"] != DBNull.Value) sD_Contract.Contract_CDate = Convert.ToDateTime(dr["Contract_CDate"]);
            if (dr["Contract_EffectDate"] != DBNull.Value) sD_Contract.Contract_EffectDate = Convert.ToDateTime(dr["Contract_EffectDate"]);
            if (dr["Contract_OwnerName"] != DBNull.Value) sD_Contract.Contract_OwnerName = Convert.ToString(dr["Contract_OwnerName"]);
            if (dr["Contract_Owner"] != DBNull.Value) sD_Contract.Contract_Owner = Convert.ToString(dr["Contract_Owner"]);
            if (dr["Contract_CustOwner"] != DBNull.Value) sD_Contract.Contract_CustOwner = Convert.ToString(dr["Contract_CustOwner"]);
            if (dr["Contract_CustLink"] != DBNull.Value) sD_Contract.Contract_CustLink = Convert.ToString(dr["Contract_CustLink"]);
            if (dr["Contract_Type"] != DBNull.Value) sD_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
            if (dr["Contract_CustCode"] != DBNull.Value) sD_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
            if (dr["Contract_CustName"] != DBNull.Value) sD_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
            if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Contract_Stat"] != DBNull.Value) sD_Contract.Contract_Stat = Convert.ToString(dr["Contract_Stat"]);
            if (dr["Contract_Date"] != DBNull.Value) sD_Contract.Contract_Date = Convert.ToDateTime(dr["Contract_Date"]);
            if (dr["Contract_VerifyStat"] != DBNull.Value) sD_Contract.Contract_VerifyStat = Convert.ToInt32(dr["Contract_VerifyStat"]);
            if (dr["Contract_VerifyDate"] != DBNull.Value) sD_Contract.Contract_VerifyDate = Convert.ToDateTime(dr["Contract_VerifyDate"]);
            if (dr["Contract_VerifyNextNode"] != DBNull.Value) sD_Contract.Contract_VerifyNextNode = Convert.ToInt32(dr["Contract_VerifyNextNode"]);
            if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Contract_Bak"] != DBNull.Value) sD_Contract.Contract_Bak = Convert.ToString(dr["Contract_Bak"]);
            if (dr["Contract_Creator"] != DBNull.Value) sD_Contract.Contract_Creator = Convert.ToString(dr["Contract_Creator"]);
            if (dr["Contract_Cmd"] != DBNull.Value) sD_Contract.Contract_Cmd = Convert.ToString(dr["Contract_Cmd"]);
            if (dr["Contract_Project"] != DBNull.Value) sD_Contract.Contract_Project = Convert.ToString(dr["Contract_Project"]);
            ret.Add(sD_Contract);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的经营处合同信息 SD_Contract对象(即:一条记录
      /// </summary>
      public List<SD_Contract> GetAll()
      {
         List<SD_Contract> ret = new List<SD_Contract>();
         string sql = "SELECT  Contract_ID,Contract_Code,Contract_Name,Contract_CDate,Contract_EffectDate,Contract_OwnerName,Contract_Owner,Contract_CustOwner,Contract_CustLink,Contract_Type,Contract_CustCode,Contract_CustName,Stat,Contract_Stat,Contract_Date,Contract_VerifyStat,Contract_VerifyDate,Contract_VerifyNextNode,AuditStat,AuditCurAudit,Contract_Bak,Contract_Creator,Contract_Cmd,Contract_Project FROM SD_Contract where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Contract sD_Contract = new SD_Contract();
            if (dr["Contract_ID"] != DBNull.Value) sD_Contract.Contract_ID = Convert.ToInt64(dr["Contract_ID"]);
            if (dr["Contract_Code"] != DBNull.Value) sD_Contract.Contract_Code = Convert.ToString(dr["Contract_Code"]);
            if (dr["Contract_Name"] != DBNull.Value) sD_Contract.Contract_Name = Convert.ToString(dr["Contract_Name"]);
            if (dr["Contract_CDate"] != DBNull.Value) sD_Contract.Contract_CDate = Convert.ToDateTime(dr["Contract_CDate"]);
            if (dr["Contract_EffectDate"] != DBNull.Value) sD_Contract.Contract_EffectDate = Convert.ToDateTime(dr["Contract_EffectDate"]);
            if (dr["Contract_OwnerName"] != DBNull.Value) sD_Contract.Contract_OwnerName = Convert.ToString(dr["Contract_OwnerName"]);
            if (dr["Contract_Owner"] != DBNull.Value) sD_Contract.Contract_Owner = Convert.ToString(dr["Contract_Owner"]);
            if (dr["Contract_CustOwner"] != DBNull.Value) sD_Contract.Contract_CustOwner = Convert.ToString(dr["Contract_CustOwner"]);
            if (dr["Contract_CustLink"] != DBNull.Value) sD_Contract.Contract_CustLink = Convert.ToString(dr["Contract_CustLink"]);
            if (dr["Contract_Type"] != DBNull.Value) sD_Contract.Contract_Type = Convert.ToString(dr["Contract_Type"]);
            if (dr["Contract_CustCode"] != DBNull.Value) sD_Contract.Contract_CustCode = Convert.ToString(dr["Contract_CustCode"]);
            if (dr["Contract_CustName"] != DBNull.Value) sD_Contract.Contract_CustName = Convert.ToString(dr["Contract_CustName"]);
            if (dr["Stat"] != DBNull.Value) sD_Contract.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Contract_Stat"] != DBNull.Value) sD_Contract.Contract_Stat = Convert.ToString(dr["Contract_Stat"]);
            if (dr["Contract_Date"] != DBNull.Value) sD_Contract.Contract_Date = Convert.ToDateTime(dr["Contract_Date"]);
            if (dr["Contract_VerifyStat"] != DBNull.Value) sD_Contract.Contract_VerifyStat = Convert.ToInt32(dr["Contract_VerifyStat"]);
            if (dr["Contract_VerifyDate"] != DBNull.Value) sD_Contract.Contract_VerifyDate = Convert.ToDateTime(dr["Contract_VerifyDate"]);
            if (dr["Contract_VerifyNextNode"] != DBNull.Value) sD_Contract.Contract_VerifyNextNode = Convert.ToInt32(dr["Contract_VerifyNextNode"]);
            if (dr["AuditStat"] != DBNull.Value) sD_Contract.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) sD_Contract.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Contract_Bak"] != DBNull.Value) sD_Contract.Contract_Bak = Convert.ToString(dr["Contract_Bak"]);
            if (dr["Contract_Creator"] != DBNull.Value) sD_Contract.Contract_Creator = Convert.ToString(dr["Contract_Creator"]);
            if (dr["Contract_Cmd"] != DBNull.Value) sD_Contract.Contract_Cmd = Convert.ToString(dr["Contract_Cmd"]);
            if (dr["Contract_Project"] != DBNull.Value) sD_Contract.Contract_Project = Convert.ToString(dr["Contract_Project"]);
            ret.Add(sD_Contract);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
