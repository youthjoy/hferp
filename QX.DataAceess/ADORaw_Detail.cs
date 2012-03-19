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
   public partial class ADORaw_Detail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Raw_Detail对象(即:一条记录)
      /// </summary>
      public int Add(Raw_Detail raw_Detail)
      {
         string sql = "INSERT INTO Raw_Detail (RawMain_Code,RDetail_Code,RDetail_PartNo,RDetail_Name,RDetail_Spec,RDetail_Unit,RDetail_Num,RDetail_Date,RDetail_Command,RDetail_DCommand,RDetail_Bak,RDetail_ReadyNum,RDetail_DisNum,Stat,RDetail_Nodes,RDetail_Customer,RDetail_CustomerName,RDetail_RDate,RDetail_Project,RDetail_OCmd,RDetail_Udef1,RDetail_Udef2,RDetail_OwnDate,CreateTime,RDetail_Udef3,RDetail_Udef4) VALUES (@RawMain_Code,@RDetail_Code,@RDetail_PartNo,@RDetail_Name,@RDetail_Spec,@RDetail_Unit,@RDetail_Num,@RDetail_Date,@RDetail_Command,@RDetail_DCommand,@RDetail_Bak,@RDetail_ReadyNum,@RDetail_DisNum,@Stat,@RDetail_Nodes,@RDetail_Customer,@RDetail_CustomerName,@RDetail_RDate,@RDetail_Project,@RDetail_OCmd,@RDetail_Udef1,@RDetail_Udef2,@RDetail_OwnDate,@CreateTime,@RDetail_Udef3,@RDetail_Udef4)";
         if (string.IsNullOrEmpty(raw_Detail.RawMain_Code))
         {
            idb.AddParameter("@RawMain_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Code", raw_Detail.RawMain_Code);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Code))
         {
            idb.AddParameter("@RDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Code", raw_Detail.RDetail_Code);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_PartNo))
         {
            idb.AddParameter("@RDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_PartNo", raw_Detail.RDetail_PartNo);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Name))
         {
            idb.AddParameter("@RDetail_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Name", raw_Detail.RDetail_Name);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Spec))
         {
            idb.AddParameter("@RDetail_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Spec", raw_Detail.RDetail_Spec);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Unit))
         {
            idb.AddParameter("@RDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Unit", raw_Detail.RDetail_Unit);
         }
         if (raw_Detail.RDetail_Num == 0)
         {
            idb.AddParameter("@RDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_Num", raw_Detail.RDetail_Num);
         }
         if (raw_Detail.RDetail_Date == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Date", raw_Detail.RDetail_Date);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Command))
         {
            idb.AddParameter("@RDetail_Command", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Command", raw_Detail.RDetail_Command);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_DCommand))
         {
            idb.AddParameter("@RDetail_DCommand", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_DCommand", raw_Detail.RDetail_DCommand);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Bak))
         {
            idb.AddParameter("@RDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Bak", raw_Detail.RDetail_Bak);
         }
         if (raw_Detail.RDetail_ReadyNum == 0)
         {
            idb.AddParameter("@RDetail_ReadyNum", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_ReadyNum", raw_Detail.RDetail_ReadyNum);
         }
         if (raw_Detail.RDetail_DisNum == 0)
         {
            idb.AddParameter("@RDetail_DisNum", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_DisNum", raw_Detail.RDetail_DisNum);
         }
         if (raw_Detail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Detail.Stat);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Nodes))
         {
            idb.AddParameter("@RDetail_Nodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Nodes", raw_Detail.RDetail_Nodes);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Customer))
         {
            idb.AddParameter("@RDetail_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Customer", raw_Detail.RDetail_Customer);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_CustomerName))
         {
            idb.AddParameter("@RDetail_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_CustomerName", raw_Detail.RDetail_CustomerName);
         }
         if (raw_Detail.RDetail_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_RDate", raw_Detail.RDetail_RDate);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Project))
         {
            idb.AddParameter("@RDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Project", raw_Detail.RDetail_Project);
         }
         if (raw_Detail.RDetail_OCmd == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_OCmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_OCmd", raw_Detail.RDetail_OCmd);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef1))
         {
            idb.AddParameter("@RDetail_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef1", raw_Detail.RDetail_Udef1);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef2))
         {
            idb.AddParameter("@RDetail_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef2", raw_Detail.RDetail_Udef2);
         }
         if (raw_Detail.RDetail_OwnDate == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_OwnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_OwnDate", raw_Detail.RDetail_OwnDate);
         }
         if (raw_Detail.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", raw_Detail.CreateTime);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef3))
         {
            idb.AddParameter("@RDetail_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef3", raw_Detail.RDetail_Udef3);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef4))
         {
            idb.AddParameter("@RDetail_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef4", raw_Detail.RDetail_Udef4);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Raw_Detail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Raw_Detail raw_Detail)
      {
         string sql = "INSERT INTO Raw_Detail (RawMain_Code,RDetail_Code,RDetail_PartNo,RDetail_Name,RDetail_Spec,RDetail_Unit,RDetail_Num,RDetail_Date,RDetail_Command,RDetail_DCommand,RDetail_Bak,RDetail_ReadyNum,RDetail_DisNum,Stat,RDetail_Nodes,RDetail_Customer,RDetail_CustomerName,RDetail_RDate,RDetail_Project,RDetail_OCmd,RDetail_Udef1,RDetail_Udef2,RDetail_OwnDate,CreateTime,RDetail_Udef3,RDetail_Udef4) VALUES (@RawMain_Code,@RDetail_Code,@RDetail_PartNo,@RDetail_Name,@RDetail_Spec,@RDetail_Unit,@RDetail_Num,@RDetail_Date,@RDetail_Command,@RDetail_DCommand,@RDetail_Bak,@RDetail_ReadyNum,@RDetail_DisNum,@Stat,@RDetail_Nodes,@RDetail_Customer,@RDetail_CustomerName,@RDetail_RDate,@RDetail_Project,@RDetail_OCmd,@RDetail_Udef1,@RDetail_Udef2,@RDetail_OwnDate,@CreateTime,@RDetail_Udef3,@RDetail_Udef4);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(raw_Detail.RawMain_Code))
         {
            idb.AddParameter("@RawMain_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Code", raw_Detail.RawMain_Code);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Code))
         {
            idb.AddParameter("@RDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Code", raw_Detail.RDetail_Code);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_PartNo))
         {
            idb.AddParameter("@RDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_PartNo", raw_Detail.RDetail_PartNo);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Name))
         {
            idb.AddParameter("@RDetail_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Name", raw_Detail.RDetail_Name);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Spec))
         {
            idb.AddParameter("@RDetail_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Spec", raw_Detail.RDetail_Spec);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Unit))
         {
            idb.AddParameter("@RDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Unit", raw_Detail.RDetail_Unit);
         }
         if (raw_Detail.RDetail_Num == 0)
         {
            idb.AddParameter("@RDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_Num", raw_Detail.RDetail_Num);
         }
         if (raw_Detail.RDetail_Date == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Date", raw_Detail.RDetail_Date);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Command))
         {
            idb.AddParameter("@RDetail_Command", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Command", raw_Detail.RDetail_Command);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_DCommand))
         {
            idb.AddParameter("@RDetail_DCommand", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_DCommand", raw_Detail.RDetail_DCommand);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Bak))
         {
            idb.AddParameter("@RDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Bak", raw_Detail.RDetail_Bak);
         }
         if (raw_Detail.RDetail_ReadyNum == 0)
         {
            idb.AddParameter("@RDetail_ReadyNum", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_ReadyNum", raw_Detail.RDetail_ReadyNum);
         }
         if (raw_Detail.RDetail_DisNum == 0)
         {
            idb.AddParameter("@RDetail_DisNum", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_DisNum", raw_Detail.RDetail_DisNum);
         }
         if (raw_Detail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Detail.Stat);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Nodes))
         {
            idb.AddParameter("@RDetail_Nodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Nodes", raw_Detail.RDetail_Nodes);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Customer))
         {
            idb.AddParameter("@RDetail_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Customer", raw_Detail.RDetail_Customer);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_CustomerName))
         {
            idb.AddParameter("@RDetail_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_CustomerName", raw_Detail.RDetail_CustomerName);
         }
         if (raw_Detail.RDetail_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_RDate", raw_Detail.RDetail_RDate);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Project))
         {
            idb.AddParameter("@RDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Project", raw_Detail.RDetail_Project);
         }
         if (raw_Detail.RDetail_OCmd == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_OCmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_OCmd", raw_Detail.RDetail_OCmd);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef1))
         {
            idb.AddParameter("@RDetail_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef1", raw_Detail.RDetail_Udef1);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef2))
         {
            idb.AddParameter("@RDetail_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef2", raw_Detail.RDetail_Udef2);
         }
         if (raw_Detail.RDetail_OwnDate == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_OwnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_OwnDate", raw_Detail.RDetail_OwnDate);
         }
         if (raw_Detail.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", raw_Detail.CreateTime);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef3))
         {
            idb.AddParameter("@RDetail_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef3", raw_Detail.RDetail_Udef3);
         }
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef4))
         {
            idb.AddParameter("@RDetail_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef4", raw_Detail.RDetail_Udef4);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Raw_Detail对象(即:一条记录
      /// </summary>
      public int Update(Raw_Detail raw_Detail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Raw_Detail       SET ");
            if(raw_Detail.RawMain_Code_IsChanged){sbParameter.Append("RawMain_Code=@RawMain_Code, ");}
      if(raw_Detail.RDetail_Code_IsChanged){sbParameter.Append("RDetail_Code=@RDetail_Code, ");}
      if(raw_Detail.RDetail_PartNo_IsChanged){sbParameter.Append("RDetail_PartNo=@RDetail_PartNo, ");}
      if(raw_Detail.RDetail_Name_IsChanged){sbParameter.Append("RDetail_Name=@RDetail_Name, ");}
      if(raw_Detail.RDetail_Spec_IsChanged){sbParameter.Append("RDetail_Spec=@RDetail_Spec, ");}
      if(raw_Detail.RDetail_Unit_IsChanged){sbParameter.Append("RDetail_Unit=@RDetail_Unit, ");}
      if(raw_Detail.RDetail_Num_IsChanged){sbParameter.Append("RDetail_Num=@RDetail_Num, ");}
      if(raw_Detail.RDetail_Date_IsChanged){sbParameter.Append("RDetail_Date=@RDetail_Date, ");}
      if(raw_Detail.RDetail_Command_IsChanged){sbParameter.Append("RDetail_Command=@RDetail_Command, ");}
      if(raw_Detail.RDetail_DCommand_IsChanged){sbParameter.Append("RDetail_DCommand=@RDetail_DCommand, ");}
      if(raw_Detail.RDetail_Bak_IsChanged){sbParameter.Append("RDetail_Bak=@RDetail_Bak, ");}
      if(raw_Detail.RDetail_ReadyNum_IsChanged){sbParameter.Append("RDetail_ReadyNum=@RDetail_ReadyNum, ");}
      if(raw_Detail.RDetail_DisNum_IsChanged){sbParameter.Append("RDetail_DisNum=@RDetail_DisNum, ");}
      if(raw_Detail.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(raw_Detail.RDetail_Nodes_IsChanged){sbParameter.Append("RDetail_Nodes=@RDetail_Nodes, ");}
      if(raw_Detail.RDetail_Customer_IsChanged){sbParameter.Append("RDetail_Customer=@RDetail_Customer, ");}
      if(raw_Detail.RDetail_CustomerName_IsChanged){sbParameter.Append("RDetail_CustomerName=@RDetail_CustomerName, ");}
      if(raw_Detail.RDetail_RDate_IsChanged){sbParameter.Append("RDetail_RDate=@RDetail_RDate, ");}
      if(raw_Detail.RDetail_Project_IsChanged){sbParameter.Append("RDetail_Project=@RDetail_Project, ");}
      if(raw_Detail.RDetail_OCmd_IsChanged){sbParameter.Append("RDetail_OCmd=@RDetail_OCmd, ");}
      if(raw_Detail.RDetail_Udef1_IsChanged){sbParameter.Append("RDetail_Udef1=@RDetail_Udef1, ");}
      if(raw_Detail.RDetail_Udef2_IsChanged){sbParameter.Append("RDetail_Udef2=@RDetail_Udef2, ");}
      if(raw_Detail.RDetail_OwnDate_IsChanged){sbParameter.Append("RDetail_OwnDate=@RDetail_OwnDate, ");}
      if(raw_Detail.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(raw_Detail.RDetail_Udef3_IsChanged){sbParameter.Append("RDetail_Udef3=@RDetail_Udef3, ");}
      if(raw_Detail.RDetail_Udef4_IsChanged){sbParameter.Append("RDetail_Udef4=@RDetail_Udef4 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RDetail_ID=@RDetail_ID; " );
      string sql=sb.ToString();
         if(raw_Detail.RawMain_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RawMain_Code))
         {
            idb.AddParameter("@RawMain_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RawMain_Code", raw_Detail.RawMain_Code);
         }
          }
         if(raw_Detail.RDetail_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Code))
         {
            idb.AddParameter("@RDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Code", raw_Detail.RDetail_Code);
         }
          }
         if(raw_Detail.RDetail_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_PartNo))
         {
            idb.AddParameter("@RDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_PartNo", raw_Detail.RDetail_PartNo);
         }
          }
         if(raw_Detail.RDetail_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Name))
         {
            idb.AddParameter("@RDetail_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Name", raw_Detail.RDetail_Name);
         }
          }
         if(raw_Detail.RDetail_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Spec))
         {
            idb.AddParameter("@RDetail_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Spec", raw_Detail.RDetail_Spec);
         }
          }
         if(raw_Detail.RDetail_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Unit))
         {
            idb.AddParameter("@RDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Unit", raw_Detail.RDetail_Unit);
         }
          }
         if(raw_Detail.RDetail_Num_IsChanged)
         {
         if (raw_Detail.RDetail_Num == 0)
         {
            idb.AddParameter("@RDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_Num", raw_Detail.RDetail_Num);
         }
          }
         if(raw_Detail.RDetail_Date_IsChanged)
         {
         if (raw_Detail.RDetail_Date == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Date", raw_Detail.RDetail_Date);
         }
          }
         if(raw_Detail.RDetail_Command_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Command))
         {
            idb.AddParameter("@RDetail_Command", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Command", raw_Detail.RDetail_Command);
         }
          }
         if(raw_Detail.RDetail_DCommand_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_DCommand))
         {
            idb.AddParameter("@RDetail_DCommand", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_DCommand", raw_Detail.RDetail_DCommand);
         }
          }
         if(raw_Detail.RDetail_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Bak))
         {
            idb.AddParameter("@RDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Bak", raw_Detail.RDetail_Bak);
         }
          }
         if(raw_Detail.RDetail_ReadyNum_IsChanged)
         {
         if (raw_Detail.RDetail_ReadyNum == 0)
         {
            idb.AddParameter("@RDetail_ReadyNum", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_ReadyNum", raw_Detail.RDetail_ReadyNum);
         }
          }
         if(raw_Detail.RDetail_DisNum_IsChanged)
         {
         if (raw_Detail.RDetail_DisNum == 0)
         {
            idb.AddParameter("@RDetail_DisNum", 0);
         }
         else
         {
            idb.AddParameter("@RDetail_DisNum", raw_Detail.RDetail_DisNum);
         }
          }
         if(raw_Detail.Stat_IsChanged)
         {
         if (raw_Detail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Detail.Stat);
         }
          }
         if(raw_Detail.RDetail_Nodes_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Nodes))
         {
            idb.AddParameter("@RDetail_Nodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Nodes", raw_Detail.RDetail_Nodes);
         }
          }
         if(raw_Detail.RDetail_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Customer))
         {
            idb.AddParameter("@RDetail_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Customer", raw_Detail.RDetail_Customer);
         }
          }
         if(raw_Detail.RDetail_CustomerName_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_CustomerName))
         {
            idb.AddParameter("@RDetail_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_CustomerName", raw_Detail.RDetail_CustomerName);
         }
          }
         if(raw_Detail.RDetail_RDate_IsChanged)
         {
         if (raw_Detail.RDetail_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_RDate", raw_Detail.RDetail_RDate);
         }
          }
         if(raw_Detail.RDetail_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Project))
         {
            idb.AddParameter("@RDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Project", raw_Detail.RDetail_Project);
         }
          }
         if(raw_Detail.RDetail_OCmd_IsChanged)
         {
         if (raw_Detail.RDetail_OCmd == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_OCmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_OCmd", raw_Detail.RDetail_OCmd);
         }
          }
         if(raw_Detail.RDetail_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef1))
         {
            idb.AddParameter("@RDetail_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef1", raw_Detail.RDetail_Udef1);
         }
          }
         if(raw_Detail.RDetail_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef2))
         {
            idb.AddParameter("@RDetail_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef2", raw_Detail.RDetail_Udef2);
         }
          }
         if(raw_Detail.RDetail_OwnDate_IsChanged)
         {
         if (raw_Detail.RDetail_OwnDate == DateTime.MinValue)
         {
            idb.AddParameter("@RDetail_OwnDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_OwnDate", raw_Detail.RDetail_OwnDate);
         }
          }
         if(raw_Detail.CreateTime_IsChanged)
         {
         if (raw_Detail.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", raw_Detail.CreateTime);
         }
          }
         if(raw_Detail.RDetail_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef3))
         {
            idb.AddParameter("@RDetail_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef3", raw_Detail.RDetail_Udef3);
         }
          }
         if(raw_Detail.RDetail_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Detail.RDetail_Udef4))
         {
            idb.AddParameter("@RDetail_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RDetail_Udef4", raw_Detail.RDetail_Udef4);
         }
          }

         idb.AddParameter("@RDetail_ID", raw_Detail.RDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Raw_Detail对象(即:一条记录
      /// </summary>
      public int Delete(decimal rDetail_ID)
      {
         string sql = "DELETE Raw_Detail WHERE 1=1  AND RDetail_ID=@RDetail_ID ";
         idb.AddParameter("@RDetail_ID", rDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Raw_Detail对象(即:一条记录
      /// </summary>
      public Raw_Detail GetByKey(decimal rDetail_ID)
      {
         Raw_Detail raw_Detail = new Raw_Detail();
         string sql = "SELECT  RDetail_ID,RawMain_Code,RDetail_Code,RDetail_PartNo,RDetail_Name,RDetail_Spec,RDetail_Unit,RDetail_Num,RDetail_Date,RDetail_Command,RDetail_DCommand,RDetail_Bak,RDetail_ReadyNum,RDetail_DisNum,Stat,RDetail_Nodes,RDetail_Customer,RDetail_CustomerName,RDetail_RDate,RDetail_Project,RDetail_OCmd,RDetail_Udef1,RDetail_Udef2,RDetail_OwnDate,CreateTime,RDetail_Udef3,RDetail_Udef4 FROM Raw_Detail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RDetail_ID=@RDetail_ID ";
         idb.AddParameter("@RDetail_ID", rDetail_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RDetail_ID"] != DBNull.Value) raw_Detail.RDetail_ID = Convert.ToDecimal(dr["RDetail_ID"]);
            if (dr["RawMain_Code"] != DBNull.Value) raw_Detail.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
            if (dr["RDetail_Code"] != DBNull.Value) raw_Detail.RDetail_Code = Convert.ToString(dr["RDetail_Code"]);
            if (dr["RDetail_PartNo"] != DBNull.Value) raw_Detail.RDetail_PartNo = Convert.ToString(dr["RDetail_PartNo"]);
            if (dr["RDetail_Name"] != DBNull.Value) raw_Detail.RDetail_Name = Convert.ToString(dr["RDetail_Name"]);
            if (dr["RDetail_Spec"] != DBNull.Value) raw_Detail.RDetail_Spec = Convert.ToString(dr["RDetail_Spec"]);
            if (dr["RDetail_Unit"] != DBNull.Value) raw_Detail.RDetail_Unit = Convert.ToString(dr["RDetail_Unit"]);
            if (dr["RDetail_Num"] != DBNull.Value) raw_Detail.RDetail_Num = Convert.ToInt32(dr["RDetail_Num"]);
            if (dr["RDetail_Date"] != DBNull.Value) raw_Detail.RDetail_Date = Convert.ToDateTime(dr["RDetail_Date"]);
            if (dr["RDetail_Command"] != DBNull.Value) raw_Detail.RDetail_Command = Convert.ToString(dr["RDetail_Command"]);
            if (dr["RDetail_DCommand"] != DBNull.Value) raw_Detail.RDetail_DCommand = Convert.ToString(dr["RDetail_DCommand"]);
            if (dr["RDetail_Bak"] != DBNull.Value) raw_Detail.RDetail_Bak = Convert.ToString(dr["RDetail_Bak"]);
            if (dr["RDetail_ReadyNum"] != DBNull.Value) raw_Detail.RDetail_ReadyNum = Convert.ToInt32(dr["RDetail_ReadyNum"]);
            if (dr["RDetail_DisNum"] != DBNull.Value) raw_Detail.RDetail_DisNum = Convert.ToInt32(dr["RDetail_DisNum"]);
            if (dr["Stat"] != DBNull.Value) raw_Detail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RDetail_Nodes"] != DBNull.Value) raw_Detail.RDetail_Nodes = Convert.ToString(dr["RDetail_Nodes"]);
            if (dr["RDetail_Customer"] != DBNull.Value) raw_Detail.RDetail_Customer = Convert.ToString(dr["RDetail_Customer"]);
            if (dr["RDetail_CustomerName"] != DBNull.Value) raw_Detail.RDetail_CustomerName = Convert.ToString(dr["RDetail_CustomerName"]);
            if (dr["RDetail_RDate"] != DBNull.Value) raw_Detail.RDetail_RDate = Convert.ToDateTime(dr["RDetail_RDate"]);
            if (dr["RDetail_Project"] != DBNull.Value) raw_Detail.RDetail_Project = Convert.ToString(dr["RDetail_Project"]);
            if (dr["RDetail_OCmd"] != DBNull.Value) raw_Detail.RDetail_OCmd = Convert.ToDateTime(dr["RDetail_OCmd"]);
            if (dr["RDetail_Udef1"] != DBNull.Value) raw_Detail.RDetail_Udef1 = Convert.ToString(dr["RDetail_Udef1"]);
            if (dr["RDetail_Udef2"] != DBNull.Value) raw_Detail.RDetail_Udef2 = Convert.ToString(dr["RDetail_Udef2"]);
            if (dr["RDetail_OwnDate"] != DBNull.Value) raw_Detail.RDetail_OwnDate = Convert.ToDateTime(dr["RDetail_OwnDate"]);
            if (dr["CreateTime"] != DBNull.Value) raw_Detail.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["RDetail_Udef3"] != DBNull.Value) raw_Detail.RDetail_Udef3 = Convert.ToString(dr["RDetail_Udef3"]);
            if (dr["RDetail_Udef4"] != DBNull.Value) raw_Detail.RDetail_Udef4 = Convert.ToString(dr["RDetail_Udef4"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return raw_Detail;
      }
      /// <summary>
      /// 获取指定的Raw_Detail对象集合
      /// </summary>
      public List<Raw_Detail> GetListByWhere(string strCondition)
      {
         List<Raw_Detail> ret = new List<Raw_Detail>();
         string sql = "SELECT  RDetail_ID,RawMain_Code,RDetail_Code,RDetail_PartNo,RDetail_Name,RDetail_Spec,RDetail_Unit,RDetail_Num,RDetail_Date,RDetail_Command,RDetail_DCommand,RDetail_Bak,RDetail_ReadyNum,RDetail_DisNum,Stat,RDetail_Nodes,RDetail_Customer,RDetail_CustomerName,RDetail_RDate,RDetail_Project,RDetail_OCmd,RDetail_Udef1,RDetail_Udef2,RDetail_OwnDate,CreateTime,RDetail_Udef3,RDetail_Udef4 FROM Raw_Detail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Raw_Detail raw_Detail = new Raw_Detail();
            if (dr["RDetail_ID"] != DBNull.Value) raw_Detail.RDetail_ID = Convert.ToDecimal(dr["RDetail_ID"]);
            if (dr["RawMain_Code"] != DBNull.Value) raw_Detail.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
            if (dr["RDetail_Code"] != DBNull.Value) raw_Detail.RDetail_Code = Convert.ToString(dr["RDetail_Code"]);
            if (dr["RDetail_PartNo"] != DBNull.Value) raw_Detail.RDetail_PartNo = Convert.ToString(dr["RDetail_PartNo"]);
            if (dr["RDetail_Name"] != DBNull.Value) raw_Detail.RDetail_Name = Convert.ToString(dr["RDetail_Name"]);
            if (dr["RDetail_Spec"] != DBNull.Value) raw_Detail.RDetail_Spec = Convert.ToString(dr["RDetail_Spec"]);
            if (dr["RDetail_Unit"] != DBNull.Value) raw_Detail.RDetail_Unit = Convert.ToString(dr["RDetail_Unit"]);
            if (dr["RDetail_Num"] != DBNull.Value) raw_Detail.RDetail_Num = Convert.ToInt32(dr["RDetail_Num"]);
            if (dr["RDetail_Date"] != DBNull.Value) raw_Detail.RDetail_Date = Convert.ToDateTime(dr["RDetail_Date"]);
            if (dr["RDetail_Command"] != DBNull.Value) raw_Detail.RDetail_Command = Convert.ToString(dr["RDetail_Command"]);
            if (dr["RDetail_DCommand"] != DBNull.Value) raw_Detail.RDetail_DCommand = Convert.ToString(dr["RDetail_DCommand"]);
            if (dr["RDetail_Bak"] != DBNull.Value) raw_Detail.RDetail_Bak = Convert.ToString(dr["RDetail_Bak"]);
            if (dr["RDetail_ReadyNum"] != DBNull.Value) raw_Detail.RDetail_ReadyNum = Convert.ToInt32(dr["RDetail_ReadyNum"]);
            if (dr["RDetail_DisNum"] != DBNull.Value) raw_Detail.RDetail_DisNum = Convert.ToInt32(dr["RDetail_DisNum"]);
            if (dr["Stat"] != DBNull.Value) raw_Detail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RDetail_Nodes"] != DBNull.Value) raw_Detail.RDetail_Nodes = Convert.ToString(dr["RDetail_Nodes"]);
            if (dr["RDetail_Customer"] != DBNull.Value) raw_Detail.RDetail_Customer = Convert.ToString(dr["RDetail_Customer"]);
            if (dr["RDetail_CustomerName"] != DBNull.Value) raw_Detail.RDetail_CustomerName = Convert.ToString(dr["RDetail_CustomerName"]);
            if (dr["RDetail_RDate"] != DBNull.Value) raw_Detail.RDetail_RDate = Convert.ToDateTime(dr["RDetail_RDate"]);
            if (dr["RDetail_Project"] != DBNull.Value) raw_Detail.RDetail_Project = Convert.ToString(dr["RDetail_Project"]);
            if (dr["RDetail_OCmd"] != DBNull.Value) raw_Detail.RDetail_OCmd = Convert.ToDateTime(dr["RDetail_OCmd"]);
            if (dr["RDetail_Udef1"] != DBNull.Value) raw_Detail.RDetail_Udef1 = Convert.ToString(dr["RDetail_Udef1"]);
            if (dr["RDetail_Udef2"] != DBNull.Value) raw_Detail.RDetail_Udef2 = Convert.ToString(dr["RDetail_Udef2"]);
            if (dr["RDetail_OwnDate"] != DBNull.Value) raw_Detail.RDetail_OwnDate = Convert.ToDateTime(dr["RDetail_OwnDate"]);
            if (dr["CreateTime"] != DBNull.Value) raw_Detail.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["RDetail_Udef3"] != DBNull.Value) raw_Detail.RDetail_Udef3 = Convert.ToString(dr["RDetail_Udef3"]);
            if (dr["RDetail_Udef4"] != DBNull.Value) raw_Detail.RDetail_Udef4 = Convert.ToString(dr["RDetail_Udef4"]);
            ret.Add(raw_Detail);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Raw_Detail对象(即:一条记录
      /// </summary>
      public List<Raw_Detail> GetAll()
      {
         List<Raw_Detail> ret = new List<Raw_Detail>();
         string sql = "SELECT  RDetail_ID,RawMain_Code,RDetail_Code,RDetail_PartNo,RDetail_Name,RDetail_Spec,RDetail_Unit,RDetail_Num,RDetail_Date,RDetail_Command,RDetail_DCommand,RDetail_Bak,RDetail_ReadyNum,RDetail_DisNum,Stat,RDetail_Nodes,RDetail_Customer,RDetail_CustomerName,RDetail_RDate,RDetail_Project,RDetail_OCmd,RDetail_Udef1,RDetail_Udef2,RDetail_OwnDate,CreateTime,RDetail_Udef3,RDetail_Udef4 FROM Raw_Detail where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Raw_Detail raw_Detail = new Raw_Detail();
            if (dr["RDetail_ID"] != DBNull.Value) raw_Detail.RDetail_ID = Convert.ToDecimal(dr["RDetail_ID"]);
            if (dr["RawMain_Code"] != DBNull.Value) raw_Detail.RawMain_Code = Convert.ToString(dr["RawMain_Code"]);
            if (dr["RDetail_Code"] != DBNull.Value) raw_Detail.RDetail_Code = Convert.ToString(dr["RDetail_Code"]);
            if (dr["RDetail_PartNo"] != DBNull.Value) raw_Detail.RDetail_PartNo = Convert.ToString(dr["RDetail_PartNo"]);
            if (dr["RDetail_Name"] != DBNull.Value) raw_Detail.RDetail_Name = Convert.ToString(dr["RDetail_Name"]);
            if (dr["RDetail_Spec"] != DBNull.Value) raw_Detail.RDetail_Spec = Convert.ToString(dr["RDetail_Spec"]);
            if (dr["RDetail_Unit"] != DBNull.Value) raw_Detail.RDetail_Unit = Convert.ToString(dr["RDetail_Unit"]);
            if (dr["RDetail_Num"] != DBNull.Value) raw_Detail.RDetail_Num = Convert.ToInt32(dr["RDetail_Num"]);
            if (dr["RDetail_Date"] != DBNull.Value) raw_Detail.RDetail_Date = Convert.ToDateTime(dr["RDetail_Date"]);
            if (dr["RDetail_Command"] != DBNull.Value) raw_Detail.RDetail_Command = Convert.ToString(dr["RDetail_Command"]);
            if (dr["RDetail_DCommand"] != DBNull.Value) raw_Detail.RDetail_DCommand = Convert.ToString(dr["RDetail_DCommand"]);
            if (dr["RDetail_Bak"] != DBNull.Value) raw_Detail.RDetail_Bak = Convert.ToString(dr["RDetail_Bak"]);
            if (dr["RDetail_ReadyNum"] != DBNull.Value) raw_Detail.RDetail_ReadyNum = Convert.ToInt32(dr["RDetail_ReadyNum"]);
            if (dr["RDetail_DisNum"] != DBNull.Value) raw_Detail.RDetail_DisNum = Convert.ToInt32(dr["RDetail_DisNum"]);
            if (dr["Stat"] != DBNull.Value) raw_Detail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RDetail_Nodes"] != DBNull.Value) raw_Detail.RDetail_Nodes = Convert.ToString(dr["RDetail_Nodes"]);
            if (dr["RDetail_Customer"] != DBNull.Value) raw_Detail.RDetail_Customer = Convert.ToString(dr["RDetail_Customer"]);
            if (dr["RDetail_CustomerName"] != DBNull.Value) raw_Detail.RDetail_CustomerName = Convert.ToString(dr["RDetail_CustomerName"]);
            if (dr["RDetail_RDate"] != DBNull.Value) raw_Detail.RDetail_RDate = Convert.ToDateTime(dr["RDetail_RDate"]);
            if (dr["RDetail_Project"] != DBNull.Value) raw_Detail.RDetail_Project = Convert.ToString(dr["RDetail_Project"]);
            if (dr["RDetail_OCmd"] != DBNull.Value) raw_Detail.RDetail_OCmd = Convert.ToDateTime(dr["RDetail_OCmd"]);
            if (dr["RDetail_Udef1"] != DBNull.Value) raw_Detail.RDetail_Udef1 = Convert.ToString(dr["RDetail_Udef1"]);
            if (dr["RDetail_Udef2"] != DBNull.Value) raw_Detail.RDetail_Udef2 = Convert.ToString(dr["RDetail_Udef2"]);
            if (dr["RDetail_OwnDate"] != DBNull.Value) raw_Detail.RDetail_OwnDate = Convert.ToDateTime(dr["RDetail_OwnDate"]);
            if (dr["CreateTime"] != DBNull.Value) raw_Detail.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["RDetail_Udef3"] != DBNull.Value) raw_Detail.RDetail_Udef3 = Convert.ToString(dr["RDetail_Udef3"]);
            if (dr["RDetail_Udef4"] != DBNull.Value) raw_Detail.RDetail_Udef4 = Convert.ToString(dr["RDetail_Udef4"]);
            ret.Add(raw_Detail);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
