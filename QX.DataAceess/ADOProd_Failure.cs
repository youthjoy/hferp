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
   /// 设备故障记录
   /// </summary>
   [Serializable]
   public partial class ADOProd_Failure
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加设备故障记录 Prod_Failure对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Failure prod_Failure)
      {
         string sql = "INSERT INTO Prod_Failure (Failure_Code,Failure_NodeCode,Failure_PartNo,Failure_EquSpec,Failure_ProdCode,Failure_EquCode,Failure_EquName,Failure_Time,Failure_Owner,Failure_OPStat,Failure_MaintainPep,Failure_MaintainTel,Failure_FTime,Failure_Stat,Failure_Desp,Failure_CatCode,Failure_CatName,Failure_VerifyStat,Failure_VerifyDate,Failure_VerifyOwner,Failure_VerifySol,Stat) VALUES (@Failure_Code,@Failure_NodeCode,@Failure_PartNo,@Failure_EquSpec,@Failure_ProdCode,@Failure_EquCode,@Failure_EquName,@Failure_Time,@Failure_Owner,@Failure_OPStat,@Failure_MaintainPep,@Failure_MaintainTel,@Failure_FTime,@Failure_Stat,@Failure_Desp,@Failure_CatCode,@Failure_CatName,@Failure_VerifyStat,@Failure_VerifyDate,@Failure_VerifyOwner,@Failure_VerifySol,@Stat)";
         if (string.IsNullOrEmpty(prod_Failure.Failure_Code))
         {
            idb.AddParameter("@Failure_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Code", prod_Failure.Failure_Code);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_NodeCode))
         {
            idb.AddParameter("@Failure_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_NodeCode", prod_Failure.Failure_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_PartNo))
         {
            idb.AddParameter("@Failure_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_PartNo", prod_Failure.Failure_PartNo);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquSpec))
         {
            idb.AddParameter("@Failure_EquSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquSpec", prod_Failure.Failure_EquSpec);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_ProdCode))
         {
            idb.AddParameter("@Failure_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_ProdCode", prod_Failure.Failure_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquCode))
         {
            idb.AddParameter("@Failure_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquCode", prod_Failure.Failure_EquCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquName))
         {
            idb.AddParameter("@Failure_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquName", prod_Failure.Failure_EquName);
         }
         if (prod_Failure.Failure_Time == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_Time", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Time", prod_Failure.Failure_Time);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_Owner))
         {
            idb.AddParameter("@Failure_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Owner", prod_Failure.Failure_Owner);
         }
         if (prod_Failure.Failure_OPStat == 0)
         {
            idb.AddParameter("@Failure_OPStat", 0);
         }
         else
         {
            idb.AddParameter("@Failure_OPStat", prod_Failure.Failure_OPStat);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_MaintainPep))
         {
            idb.AddParameter("@Failure_MaintainPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_MaintainPep", prod_Failure.Failure_MaintainPep);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_MaintainTel))
         {
            idb.AddParameter("@Failure_MaintainTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_MaintainTel", prod_Failure.Failure_MaintainTel);
         }
         if (prod_Failure.Failure_FTime == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_FTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_FTime", prod_Failure.Failure_FTime);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_Stat))
         {
            idb.AddParameter("@Failure_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Stat", prod_Failure.Failure_Stat);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_Desp))
         {
            idb.AddParameter("@Failure_Desp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Desp", prod_Failure.Failure_Desp);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_CatCode))
         {
            idb.AddParameter("@Failure_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_CatCode", prod_Failure.Failure_CatCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_CatName))
         {
            idb.AddParameter("@Failure_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_CatName", prod_Failure.Failure_CatName);
         }
         if (prod_Failure.Failure_VerifyStat == 0)
         {
            idb.AddParameter("@Failure_VerifyStat", 0);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyStat", prod_Failure.Failure_VerifyStat);
         }
         if (prod_Failure.Failure_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyDate", prod_Failure.Failure_VerifyDate);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_VerifyOwner))
         {
            idb.AddParameter("@Failure_VerifyOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyOwner", prod_Failure.Failure_VerifyOwner);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_VerifySol))
         {
            idb.AddParameter("@Failure_VerifySol", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifySol", prod_Failure.Failure_VerifySol);
         }
         if (prod_Failure.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Failure.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加设备故障记录 Prod_Failure对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Failure prod_Failure)
      {
         string sql = "INSERT INTO Prod_Failure (Failure_Code,Failure_NodeCode,Failure_PartNo,Failure_EquSpec,Failure_ProdCode,Failure_EquCode,Failure_EquName,Failure_Time,Failure_Owner,Failure_OPStat,Failure_MaintainPep,Failure_MaintainTel,Failure_FTime,Failure_Stat,Failure_Desp,Failure_CatCode,Failure_CatName,Failure_VerifyStat,Failure_VerifyDate,Failure_VerifyOwner,Failure_VerifySol,Stat) VALUES (@Failure_Code,@Failure_NodeCode,@Failure_PartNo,@Failure_EquSpec,@Failure_ProdCode,@Failure_EquCode,@Failure_EquName,@Failure_Time,@Failure_Owner,@Failure_OPStat,@Failure_MaintainPep,@Failure_MaintainTel,@Failure_FTime,@Failure_Stat,@Failure_Desp,@Failure_CatCode,@Failure_CatName,@Failure_VerifyStat,@Failure_VerifyDate,@Failure_VerifyOwner,@Failure_VerifySol,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Failure.Failure_Code))
         {
            idb.AddParameter("@Failure_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Code", prod_Failure.Failure_Code);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_NodeCode))
         {
            idb.AddParameter("@Failure_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_NodeCode", prod_Failure.Failure_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_PartNo))
         {
            idb.AddParameter("@Failure_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_PartNo", prod_Failure.Failure_PartNo);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquSpec))
         {
            idb.AddParameter("@Failure_EquSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquSpec", prod_Failure.Failure_EquSpec);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_ProdCode))
         {
            idb.AddParameter("@Failure_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_ProdCode", prod_Failure.Failure_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquCode))
         {
            idb.AddParameter("@Failure_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquCode", prod_Failure.Failure_EquCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquName))
         {
            idb.AddParameter("@Failure_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquName", prod_Failure.Failure_EquName);
         }
         if (prod_Failure.Failure_Time == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_Time", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Time", prod_Failure.Failure_Time);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_Owner))
         {
            idb.AddParameter("@Failure_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Owner", prod_Failure.Failure_Owner);
         }
         if (prod_Failure.Failure_OPStat == 0)
         {
            idb.AddParameter("@Failure_OPStat", 0);
         }
         else
         {
            idb.AddParameter("@Failure_OPStat", prod_Failure.Failure_OPStat);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_MaintainPep))
         {
            idb.AddParameter("@Failure_MaintainPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_MaintainPep", prod_Failure.Failure_MaintainPep);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_MaintainTel))
         {
            idb.AddParameter("@Failure_MaintainTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_MaintainTel", prod_Failure.Failure_MaintainTel);
         }
         if (prod_Failure.Failure_FTime == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_FTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_FTime", prod_Failure.Failure_FTime);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_Stat))
         {
            idb.AddParameter("@Failure_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Stat", prod_Failure.Failure_Stat);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_Desp))
         {
            idb.AddParameter("@Failure_Desp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Desp", prod_Failure.Failure_Desp);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_CatCode))
         {
            idb.AddParameter("@Failure_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_CatCode", prod_Failure.Failure_CatCode);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_CatName))
         {
            idb.AddParameter("@Failure_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_CatName", prod_Failure.Failure_CatName);
         }
         if (prod_Failure.Failure_VerifyStat == 0)
         {
            idb.AddParameter("@Failure_VerifyStat", 0);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyStat", prod_Failure.Failure_VerifyStat);
         }
         if (prod_Failure.Failure_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyDate", prod_Failure.Failure_VerifyDate);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_VerifyOwner))
         {
            idb.AddParameter("@Failure_VerifyOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyOwner", prod_Failure.Failure_VerifyOwner);
         }
         if (string.IsNullOrEmpty(prod_Failure.Failure_VerifySol))
         {
            idb.AddParameter("@Failure_VerifySol", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifySol", prod_Failure.Failure_VerifySol);
         }
         if (prod_Failure.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Failure.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新设备故障记录 Prod_Failure对象(即:一条记录
      /// </summary>
      public int Update(Prod_Failure prod_Failure)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Failure       SET ");
            if(prod_Failure.Failure_Code_IsChanged){sbParameter.Append("Failure_Code=@Failure_Code, ");}
      if(prod_Failure.Failure_NodeCode_IsChanged){sbParameter.Append("Failure_NodeCode=@Failure_NodeCode, ");}
      if(prod_Failure.Failure_PartNo_IsChanged){sbParameter.Append("Failure_PartNo=@Failure_PartNo, ");}
      if(prod_Failure.Failure_EquSpec_IsChanged){sbParameter.Append("Failure_EquSpec=@Failure_EquSpec, ");}
      if(prod_Failure.Failure_ProdCode_IsChanged){sbParameter.Append("Failure_ProdCode=@Failure_ProdCode, ");}
      if(prod_Failure.Failure_EquCode_IsChanged){sbParameter.Append("Failure_EquCode=@Failure_EquCode, ");}
      if(prod_Failure.Failure_EquName_IsChanged){sbParameter.Append("Failure_EquName=@Failure_EquName, ");}
      if(prod_Failure.Failure_Time_IsChanged){sbParameter.Append("Failure_Time=@Failure_Time, ");}
      if(prod_Failure.Failure_Owner_IsChanged){sbParameter.Append("Failure_Owner=@Failure_Owner, ");}
      if(prod_Failure.Failure_OPStat_IsChanged){sbParameter.Append("Failure_OPStat=@Failure_OPStat, ");}
      if(prod_Failure.Failure_MaintainPep_IsChanged){sbParameter.Append("Failure_MaintainPep=@Failure_MaintainPep, ");}
      if(prod_Failure.Failure_MaintainTel_IsChanged){sbParameter.Append("Failure_MaintainTel=@Failure_MaintainTel, ");}
      if(prod_Failure.Failure_FTime_IsChanged){sbParameter.Append("Failure_FTime=@Failure_FTime, ");}
      if(prod_Failure.Failure_Stat_IsChanged){sbParameter.Append("Failure_Stat=@Failure_Stat, ");}
      if(prod_Failure.Failure_Desp_IsChanged){sbParameter.Append("Failure_Desp=@Failure_Desp, ");}
      if(prod_Failure.Failure_CatCode_IsChanged){sbParameter.Append("Failure_CatCode=@Failure_CatCode, ");}
      if(prod_Failure.Failure_CatName_IsChanged){sbParameter.Append("Failure_CatName=@Failure_CatName, ");}
      if(prod_Failure.Failure_VerifyStat_IsChanged){sbParameter.Append("Failure_VerifyStat=@Failure_VerifyStat, ");}
      if(prod_Failure.Failure_VerifyDate_IsChanged){sbParameter.Append("Failure_VerifyDate=@Failure_VerifyDate, ");}
      if(prod_Failure.Failure_VerifyOwner_IsChanged){sbParameter.Append("Failure_VerifyOwner=@Failure_VerifyOwner, ");}
      if(prod_Failure.Failure_VerifySol_IsChanged){sbParameter.Append("Failure_VerifySol=@Failure_VerifySol, ");}
      if(prod_Failure.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Failure_ID=@Failure_ID; " );
      string sql=sb.ToString();
         if(prod_Failure.Failure_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_Code))
         {
            idb.AddParameter("@Failure_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Code", prod_Failure.Failure_Code);
         }
          }
         if(prod_Failure.Failure_NodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_NodeCode))
         {
            idb.AddParameter("@Failure_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_NodeCode", prod_Failure.Failure_NodeCode);
         }
          }
         if(prod_Failure.Failure_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_PartNo))
         {
            idb.AddParameter("@Failure_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_PartNo", prod_Failure.Failure_PartNo);
         }
          }
         if(prod_Failure.Failure_EquSpec_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquSpec))
         {
            idb.AddParameter("@Failure_EquSpec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquSpec", prod_Failure.Failure_EquSpec);
         }
          }
         if(prod_Failure.Failure_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_ProdCode))
         {
            idb.AddParameter("@Failure_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_ProdCode", prod_Failure.Failure_ProdCode);
         }
          }
         if(prod_Failure.Failure_EquCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquCode))
         {
            idb.AddParameter("@Failure_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquCode", prod_Failure.Failure_EquCode);
         }
          }
         if(prod_Failure.Failure_EquName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_EquName))
         {
            idb.AddParameter("@Failure_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_EquName", prod_Failure.Failure_EquName);
         }
          }
         if(prod_Failure.Failure_Time_IsChanged)
         {
         if (prod_Failure.Failure_Time == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_Time", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Time", prod_Failure.Failure_Time);
         }
          }
         if(prod_Failure.Failure_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_Owner))
         {
            idb.AddParameter("@Failure_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Owner", prod_Failure.Failure_Owner);
         }
          }
         if(prod_Failure.Failure_OPStat_IsChanged)
         {
         if (prod_Failure.Failure_OPStat == 0)
         {
            idb.AddParameter("@Failure_OPStat", 0);
         }
         else
         {
            idb.AddParameter("@Failure_OPStat", prod_Failure.Failure_OPStat);
         }
          }
         if(prod_Failure.Failure_MaintainPep_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_MaintainPep))
         {
            idb.AddParameter("@Failure_MaintainPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_MaintainPep", prod_Failure.Failure_MaintainPep);
         }
          }
         if(prod_Failure.Failure_MaintainTel_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_MaintainTel))
         {
            idb.AddParameter("@Failure_MaintainTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_MaintainTel", prod_Failure.Failure_MaintainTel);
         }
          }
         if(prod_Failure.Failure_FTime_IsChanged)
         {
         if (prod_Failure.Failure_FTime == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_FTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_FTime", prod_Failure.Failure_FTime);
         }
          }
         if(prod_Failure.Failure_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_Stat))
         {
            idb.AddParameter("@Failure_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Stat", prod_Failure.Failure_Stat);
         }
          }
         if(prod_Failure.Failure_Desp_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_Desp))
         {
            idb.AddParameter("@Failure_Desp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_Desp", prod_Failure.Failure_Desp);
         }
          }
         if(prod_Failure.Failure_CatCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_CatCode))
         {
            idb.AddParameter("@Failure_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_CatCode", prod_Failure.Failure_CatCode);
         }
          }
         if(prod_Failure.Failure_CatName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_CatName))
         {
            idb.AddParameter("@Failure_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_CatName", prod_Failure.Failure_CatName);
         }
          }
         if(prod_Failure.Failure_VerifyStat_IsChanged)
         {
         if (prod_Failure.Failure_VerifyStat == 0)
         {
            idb.AddParameter("@Failure_VerifyStat", 0);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyStat", prod_Failure.Failure_VerifyStat);
         }
          }
         if(prod_Failure.Failure_VerifyDate_IsChanged)
         {
         if (prod_Failure.Failure_VerifyDate == DateTime.MinValue)
         {
            idb.AddParameter("@Failure_VerifyDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyDate", prod_Failure.Failure_VerifyDate);
         }
          }
         if(prod_Failure.Failure_VerifyOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_VerifyOwner))
         {
            idb.AddParameter("@Failure_VerifyOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifyOwner", prod_Failure.Failure_VerifyOwner);
         }
          }
         if(prod_Failure.Failure_VerifySol_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Failure.Failure_VerifySol))
         {
            idb.AddParameter("@Failure_VerifySol", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Failure_VerifySol", prod_Failure.Failure_VerifySol);
         }
          }
         if(prod_Failure.Stat_IsChanged)
         {
         if (prod_Failure.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Failure.Stat);
         }
          }

         idb.AddParameter("@Failure_ID", prod_Failure.Failure_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除设备故障记录 Prod_Failure对象(即:一条记录
      /// </summary>
      public int Delete(decimal failure_ID)
      {
         string sql = "DELETE Prod_Failure WHERE 1=1  AND Failure_ID=@Failure_ID ";
         idb.AddParameter("@Failure_ID", failure_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的设备故障记录 Prod_Failure对象(即:一条记录
      /// </summary>
      public Prod_Failure GetByKey(decimal failure_ID)
      {
         Prod_Failure prod_Failure = new Prod_Failure();
         string sql = "SELECT  Failure_ID,Failure_Code,Failure_NodeCode,Failure_PartNo,Failure_EquSpec,Failure_ProdCode,Failure_EquCode,Failure_EquName,Failure_Time,Failure_Owner,Failure_OPStat,Failure_MaintainPep,Failure_MaintainTel,Failure_FTime,Failure_Stat,Failure_Desp,Failure_CatCode,Failure_CatName,Failure_VerifyStat,Failure_VerifyDate,Failure_VerifyOwner,Failure_VerifySol,Stat FROM Prod_Failure WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Failure_ID=@Failure_ID ";
         idb.AddParameter("@Failure_ID", failure_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Failure_ID"] != DBNull.Value) prod_Failure.Failure_ID = Convert.ToDecimal(dr["Failure_ID"]);
            if (dr["Failure_Code"] != DBNull.Value) prod_Failure.Failure_Code = Convert.ToString(dr["Failure_Code"]);
            if (dr["Failure_NodeCode"] != DBNull.Value) prod_Failure.Failure_NodeCode = Convert.ToString(dr["Failure_NodeCode"]);
            if (dr["Failure_PartNo"] != DBNull.Value) prod_Failure.Failure_PartNo = Convert.ToString(dr["Failure_PartNo"]);
            if (dr["Failure_EquSpec"] != DBNull.Value) prod_Failure.Failure_EquSpec = Convert.ToString(dr["Failure_EquSpec"]);
            if (dr["Failure_ProdCode"] != DBNull.Value) prod_Failure.Failure_ProdCode = Convert.ToString(dr["Failure_ProdCode"]);
            if (dr["Failure_EquCode"] != DBNull.Value) prod_Failure.Failure_EquCode = Convert.ToString(dr["Failure_EquCode"]);
            if (dr["Failure_EquName"] != DBNull.Value) prod_Failure.Failure_EquName = Convert.ToString(dr["Failure_EquName"]);
            if (dr["Failure_Time"] != DBNull.Value) prod_Failure.Failure_Time = Convert.ToDateTime(dr["Failure_Time"]);
            if (dr["Failure_Owner"] != DBNull.Value) prod_Failure.Failure_Owner = Convert.ToString(dr["Failure_Owner"]);
            if (dr["Failure_OPStat"] != DBNull.Value) prod_Failure.Failure_OPStat = Convert.ToInt32(dr["Failure_OPStat"]);
            if (dr["Failure_MaintainPep"] != DBNull.Value) prod_Failure.Failure_MaintainPep = Convert.ToString(dr["Failure_MaintainPep"]);
            if (dr["Failure_MaintainTel"] != DBNull.Value) prod_Failure.Failure_MaintainTel = Convert.ToString(dr["Failure_MaintainTel"]);
            if (dr["Failure_FTime"] != DBNull.Value) prod_Failure.Failure_FTime = Convert.ToDateTime(dr["Failure_FTime"]);
            if (dr["Failure_Stat"] != DBNull.Value) prod_Failure.Failure_Stat = Convert.ToString(dr["Failure_Stat"]);
            if (dr["Failure_Desp"] != DBNull.Value) prod_Failure.Failure_Desp = Convert.ToString(dr["Failure_Desp"]);
            if (dr["Failure_CatCode"] != DBNull.Value) prod_Failure.Failure_CatCode = Convert.ToString(dr["Failure_CatCode"]);
            if (dr["Failure_CatName"] != DBNull.Value) prod_Failure.Failure_CatName = Convert.ToString(dr["Failure_CatName"]);
            if (dr["Failure_VerifyStat"] != DBNull.Value) prod_Failure.Failure_VerifyStat = Convert.ToInt32(dr["Failure_VerifyStat"]);
            if (dr["Failure_VerifyDate"] != DBNull.Value) prod_Failure.Failure_VerifyDate = Convert.ToDateTime(dr["Failure_VerifyDate"]);
            if (dr["Failure_VerifyOwner"] != DBNull.Value) prod_Failure.Failure_VerifyOwner = Convert.ToString(dr["Failure_VerifyOwner"]);
            if (dr["Failure_VerifySol"] != DBNull.Value) prod_Failure.Failure_VerifySol = Convert.ToString(dr["Failure_VerifySol"]);
            if (dr["Stat"] != DBNull.Value) prod_Failure.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_Failure;
      }
      /// <summary>
      /// 获取指定的设备故障记录 Prod_Failure对象集合
      /// </summary>
      public List<Prod_Failure> GetListByWhere(string strCondition)
      {
         List<Prod_Failure> ret = new List<Prod_Failure>();
         string sql = "SELECT  Failure_ID,Failure_Code,Failure_NodeCode,Failure_PartNo,Failure_EquSpec,Failure_ProdCode,Failure_EquCode,Failure_EquName,Failure_Time,Failure_Owner,Failure_OPStat,Failure_MaintainPep,Failure_MaintainTel,Failure_FTime,Failure_Stat,Failure_Desp,Failure_CatCode,Failure_CatName,Failure_VerifyStat,Failure_VerifyDate,Failure_VerifyOwner,Failure_VerifySol,Stat FROM Prod_Failure WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_Failure prod_Failure = new Prod_Failure();
            if (dr["Failure_ID"] != DBNull.Value) prod_Failure.Failure_ID = Convert.ToDecimal(dr["Failure_ID"]);
            if (dr["Failure_Code"] != DBNull.Value) prod_Failure.Failure_Code = Convert.ToString(dr["Failure_Code"]);
            if (dr["Failure_NodeCode"] != DBNull.Value) prod_Failure.Failure_NodeCode = Convert.ToString(dr["Failure_NodeCode"]);
            if (dr["Failure_PartNo"] != DBNull.Value) prod_Failure.Failure_PartNo = Convert.ToString(dr["Failure_PartNo"]);
            if (dr["Failure_EquSpec"] != DBNull.Value) prod_Failure.Failure_EquSpec = Convert.ToString(dr["Failure_EquSpec"]);
            if (dr["Failure_ProdCode"] != DBNull.Value) prod_Failure.Failure_ProdCode = Convert.ToString(dr["Failure_ProdCode"]);
            if (dr["Failure_EquCode"] != DBNull.Value) prod_Failure.Failure_EquCode = Convert.ToString(dr["Failure_EquCode"]);
            if (dr["Failure_EquName"] != DBNull.Value) prod_Failure.Failure_EquName = Convert.ToString(dr["Failure_EquName"]);
            if (dr["Failure_Time"] != DBNull.Value) prod_Failure.Failure_Time = Convert.ToDateTime(dr["Failure_Time"]);
            if (dr["Failure_Owner"] != DBNull.Value) prod_Failure.Failure_Owner = Convert.ToString(dr["Failure_Owner"]);
            if (dr["Failure_OPStat"] != DBNull.Value) prod_Failure.Failure_OPStat = Convert.ToInt32(dr["Failure_OPStat"]);
            if (dr["Failure_MaintainPep"] != DBNull.Value) prod_Failure.Failure_MaintainPep = Convert.ToString(dr["Failure_MaintainPep"]);
            if (dr["Failure_MaintainTel"] != DBNull.Value) prod_Failure.Failure_MaintainTel = Convert.ToString(dr["Failure_MaintainTel"]);
            if (dr["Failure_FTime"] != DBNull.Value) prod_Failure.Failure_FTime = Convert.ToDateTime(dr["Failure_FTime"]);
            if (dr["Failure_Stat"] != DBNull.Value) prod_Failure.Failure_Stat = Convert.ToString(dr["Failure_Stat"]);
            if (dr["Failure_Desp"] != DBNull.Value) prod_Failure.Failure_Desp = Convert.ToString(dr["Failure_Desp"]);
            if (dr["Failure_CatCode"] != DBNull.Value) prod_Failure.Failure_CatCode = Convert.ToString(dr["Failure_CatCode"]);
            if (dr["Failure_CatName"] != DBNull.Value) prod_Failure.Failure_CatName = Convert.ToString(dr["Failure_CatName"]);
            if (dr["Failure_VerifyStat"] != DBNull.Value) prod_Failure.Failure_VerifyStat = Convert.ToInt32(dr["Failure_VerifyStat"]);
            if (dr["Failure_VerifyDate"] != DBNull.Value) prod_Failure.Failure_VerifyDate = Convert.ToDateTime(dr["Failure_VerifyDate"]);
            if (dr["Failure_VerifyOwner"] != DBNull.Value) prod_Failure.Failure_VerifyOwner = Convert.ToString(dr["Failure_VerifyOwner"]);
            if (dr["Failure_VerifySol"] != DBNull.Value) prod_Failure.Failure_VerifySol = Convert.ToString(dr["Failure_VerifySol"]);
            if (dr["Stat"] != DBNull.Value) prod_Failure.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_Failure);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的设备故障记录 Prod_Failure对象(即:一条记录
      /// </summary>
      public List<Prod_Failure> GetAll()
      {
         List<Prod_Failure> ret = new List<Prod_Failure>();
         string sql = "SELECT  Failure_ID,Failure_Code,Failure_NodeCode,Failure_PartNo,Failure_EquSpec,Failure_ProdCode,Failure_EquCode,Failure_EquName,Failure_Time,Failure_Owner,Failure_OPStat,Failure_MaintainPep,Failure_MaintainTel,Failure_FTime,Failure_Stat,Failure_Desp,Failure_CatCode,Failure_CatName,Failure_VerifyStat,Failure_VerifyDate,Failure_VerifyOwner,Failure_VerifySol,Stat FROM Prod_Failure where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Failure prod_Failure = new Prod_Failure();
            if (dr["Failure_ID"] != DBNull.Value) prod_Failure.Failure_ID = Convert.ToDecimal(dr["Failure_ID"]);
            if (dr["Failure_Code"] != DBNull.Value) prod_Failure.Failure_Code = Convert.ToString(dr["Failure_Code"]);
            if (dr["Failure_NodeCode"] != DBNull.Value) prod_Failure.Failure_NodeCode = Convert.ToString(dr["Failure_NodeCode"]);
            if (dr["Failure_PartNo"] != DBNull.Value) prod_Failure.Failure_PartNo = Convert.ToString(dr["Failure_PartNo"]);
            if (dr["Failure_EquSpec"] != DBNull.Value) prod_Failure.Failure_EquSpec = Convert.ToString(dr["Failure_EquSpec"]);
            if (dr["Failure_ProdCode"] != DBNull.Value) prod_Failure.Failure_ProdCode = Convert.ToString(dr["Failure_ProdCode"]);
            if (dr["Failure_EquCode"] != DBNull.Value) prod_Failure.Failure_EquCode = Convert.ToString(dr["Failure_EquCode"]);
            if (dr["Failure_EquName"] != DBNull.Value) prod_Failure.Failure_EquName = Convert.ToString(dr["Failure_EquName"]);
            if (dr["Failure_Time"] != DBNull.Value) prod_Failure.Failure_Time = Convert.ToDateTime(dr["Failure_Time"]);
            if (dr["Failure_Owner"] != DBNull.Value) prod_Failure.Failure_Owner = Convert.ToString(dr["Failure_Owner"]);
            if (dr["Failure_OPStat"] != DBNull.Value) prod_Failure.Failure_OPStat = Convert.ToInt32(dr["Failure_OPStat"]);
            if (dr["Failure_MaintainPep"] != DBNull.Value) prod_Failure.Failure_MaintainPep = Convert.ToString(dr["Failure_MaintainPep"]);
            if (dr["Failure_MaintainTel"] != DBNull.Value) prod_Failure.Failure_MaintainTel = Convert.ToString(dr["Failure_MaintainTel"]);
            if (dr["Failure_FTime"] != DBNull.Value) prod_Failure.Failure_FTime = Convert.ToDateTime(dr["Failure_FTime"]);
            if (dr["Failure_Stat"] != DBNull.Value) prod_Failure.Failure_Stat = Convert.ToString(dr["Failure_Stat"]);
            if (dr["Failure_Desp"] != DBNull.Value) prod_Failure.Failure_Desp = Convert.ToString(dr["Failure_Desp"]);
            if (dr["Failure_CatCode"] != DBNull.Value) prod_Failure.Failure_CatCode = Convert.ToString(dr["Failure_CatCode"]);
            if (dr["Failure_CatName"] != DBNull.Value) prod_Failure.Failure_CatName = Convert.ToString(dr["Failure_CatName"]);
            if (dr["Failure_VerifyStat"] != DBNull.Value) prod_Failure.Failure_VerifyStat = Convert.ToInt32(dr["Failure_VerifyStat"]);
            if (dr["Failure_VerifyDate"] != DBNull.Value) prod_Failure.Failure_VerifyDate = Convert.ToDateTime(dr["Failure_VerifyDate"]);
            if (dr["Failure_VerifyOwner"] != DBNull.Value) prod_Failure.Failure_VerifyOwner = Convert.ToString(dr["Failure_VerifyOwner"]);
            if (dr["Failure_VerifySol"] != DBNull.Value) prod_Failure.Failure_VerifySol = Convert.ToString(dr["Failure_VerifySol"]);
            if (dr["Stat"] != DBNull.Value) prod_Failure.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_Failure);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
