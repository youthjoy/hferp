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
   public partial class ADOInv_Information
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Inv_Information对象(即:一条记录)
      /// </summary>
      public int Add(Inv_Information inv_Information)
      {
         string sql = "INSERT INTO Inv_Information (IInfor_PartNo,IInfor_PartName,IInfor_TaskCode,IInfor_ProdCode,IInfor_PlanCode,IInfor_CmdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_ProdStat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime,Stat,IInfor_CmdReq) VALUES (@IInfor_PartNo,@IInfor_PartName,@IInfor_TaskCode,@IInfor_ProdCode,@IInfor_PlanCode,@IInfor_CmdCode,@IInfor_PlanBegin,@IInfor_PlanEnd,@IInfor_InTime,@IInfor_Num,@IInfor_WareHouse,@IInfor_InConfirm,@IInfor_InPep,@IInfor_InDate,@IInfor_Stat,@IInfor_ProdStat,@IInfor_OutDate,@IInfor_OutPep,@IInfor_CustConfirmNo,@IInfor_CustConfirmDate,@IInfor_CustBak,@IInfor_ProdType,@CreateTime,@UpdateTime,@DeleteTime,@Stat,@IInfor_CmdReq)";
         if (string.IsNullOrEmpty(inv_Information.IInfor_PartNo))
         {
            idb.AddParameter("@IInfor_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PartNo", inv_Information.IInfor_PartNo);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_PartName))
         {
            idb.AddParameter("@IInfor_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PartName", inv_Information.IInfor_PartName);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_TaskCode))
         {
            idb.AddParameter("@IInfor_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_TaskCode", inv_Information.IInfor_TaskCode);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_ProdCode))
         {
            idb.AddParameter("@IInfor_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdCode", inv_Information.IInfor_ProdCode);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_PlanCode))
         {
            idb.AddParameter("@IInfor_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanCode", inv_Information.IInfor_PlanCode);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CmdCode))
         {
            idb.AddParameter("@IInfor_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CmdCode", inv_Information.IInfor_CmdCode);
         }
         if (inv_Information.IInfor_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanBegin", inv_Information.IInfor_PlanBegin);
         }
         if (inv_Information.IInfor_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanEnd", inv_Information.IInfor_PlanEnd);
         }
         if (inv_Information.IInfor_InTime == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_InTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InTime", inv_Information.IInfor_InTime);
         }
         if (inv_Information.IInfor_Num == 0)
         {
            idb.AddParameter("@IInfor_Num", 0);
         }
         else
         {
            idb.AddParameter("@IInfor_Num", inv_Information.IInfor_Num);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_WareHouse))
         {
            idb.AddParameter("@IInfor_WareHouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_WareHouse", inv_Information.IInfor_WareHouse);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_InConfirm))
         {
            idb.AddParameter("@IInfor_InConfirm", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InConfirm", inv_Information.IInfor_InConfirm);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_InPep))
         {
            idb.AddParameter("@IInfor_InPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InPep", inv_Information.IInfor_InPep);
         }
         if (inv_Information.IInfor_InDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_InDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InDate", inv_Information.IInfor_InDate);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_Stat))
         {
            idb.AddParameter("@IInfor_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_Stat", inv_Information.IInfor_Stat);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_ProdStat))
         {
            idb.AddParameter("@IInfor_ProdStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdStat", inv_Information.IInfor_ProdStat);
         }
         if (inv_Information.IInfor_OutDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_OutDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_OutDate", inv_Information.IInfor_OutDate);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_OutPep))
         {
            idb.AddParameter("@IInfor_OutPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_OutPep", inv_Information.IInfor_OutPep);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CustConfirmNo))
         {
            idb.AddParameter("@IInfor_CustConfirmNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustConfirmNo", inv_Information.IInfor_CustConfirmNo);
         }
         if (inv_Information.IInfor_CustConfirmDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_CustConfirmDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustConfirmDate", inv_Information.IInfor_CustConfirmDate);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CustBak))
         {
            idb.AddParameter("@IInfor_CustBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustBak", inv_Information.IInfor_CustBak);
         }
         if (inv_Information.IInfor_ProdType == 0)
         {
            idb.AddParameter("@IInfor_ProdType", 0);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdType", inv_Information.IInfor_ProdType);
         }
         if (inv_Information.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", inv_Information.CreateTime);
         }
         if (inv_Information.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", inv_Information.UpdateTime);
         }
         if (inv_Information.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", inv_Information.DeleteTime);
         }
         if (inv_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", inv_Information.Stat);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CmdReq))
         {
            idb.AddParameter("@IInfor_CmdReq", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CmdReq", inv_Information.IInfor_CmdReq);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Inv_Information对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Inv_Information inv_Information)
      {
         string sql = "INSERT INTO Inv_Information (IInfor_PartNo,IInfor_PartName,IInfor_TaskCode,IInfor_ProdCode,IInfor_PlanCode,IInfor_CmdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_ProdStat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime,Stat,IInfor_CmdReq) VALUES (@IInfor_PartNo,@IInfor_PartName,@IInfor_TaskCode,@IInfor_ProdCode,@IInfor_PlanCode,@IInfor_CmdCode,@IInfor_PlanBegin,@IInfor_PlanEnd,@IInfor_InTime,@IInfor_Num,@IInfor_WareHouse,@IInfor_InConfirm,@IInfor_InPep,@IInfor_InDate,@IInfor_Stat,@IInfor_ProdStat,@IInfor_OutDate,@IInfor_OutPep,@IInfor_CustConfirmNo,@IInfor_CustConfirmDate,@IInfor_CustBak,@IInfor_ProdType,@CreateTime,@UpdateTime,@DeleteTime,@Stat,@IInfor_CmdReq);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(inv_Information.IInfor_PartNo))
         {
            idb.AddParameter("@IInfor_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PartNo", inv_Information.IInfor_PartNo);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_PartName))
         {
            idb.AddParameter("@IInfor_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PartName", inv_Information.IInfor_PartName);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_TaskCode))
         {
            idb.AddParameter("@IInfor_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_TaskCode", inv_Information.IInfor_TaskCode);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_ProdCode))
         {
            idb.AddParameter("@IInfor_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdCode", inv_Information.IInfor_ProdCode);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_PlanCode))
         {
            idb.AddParameter("@IInfor_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanCode", inv_Information.IInfor_PlanCode);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CmdCode))
         {
            idb.AddParameter("@IInfor_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CmdCode", inv_Information.IInfor_CmdCode);
         }
         if (inv_Information.IInfor_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanBegin", inv_Information.IInfor_PlanBegin);
         }
         if (inv_Information.IInfor_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanEnd", inv_Information.IInfor_PlanEnd);
         }
         if (inv_Information.IInfor_InTime == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_InTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InTime", inv_Information.IInfor_InTime);
         }
         if (inv_Information.IInfor_Num == 0)
         {
            idb.AddParameter("@IInfor_Num", 0);
         }
         else
         {
            idb.AddParameter("@IInfor_Num", inv_Information.IInfor_Num);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_WareHouse))
         {
            idb.AddParameter("@IInfor_WareHouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_WareHouse", inv_Information.IInfor_WareHouse);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_InConfirm))
         {
            idb.AddParameter("@IInfor_InConfirm", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InConfirm", inv_Information.IInfor_InConfirm);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_InPep))
         {
            idb.AddParameter("@IInfor_InPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InPep", inv_Information.IInfor_InPep);
         }
         if (inv_Information.IInfor_InDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_InDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InDate", inv_Information.IInfor_InDate);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_Stat))
         {
            idb.AddParameter("@IInfor_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_Stat", inv_Information.IInfor_Stat);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_ProdStat))
         {
            idb.AddParameter("@IInfor_ProdStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdStat", inv_Information.IInfor_ProdStat);
         }
         if (inv_Information.IInfor_OutDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_OutDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_OutDate", inv_Information.IInfor_OutDate);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_OutPep))
         {
            idb.AddParameter("@IInfor_OutPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_OutPep", inv_Information.IInfor_OutPep);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CustConfirmNo))
         {
            idb.AddParameter("@IInfor_CustConfirmNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustConfirmNo", inv_Information.IInfor_CustConfirmNo);
         }
         if (inv_Information.IInfor_CustConfirmDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_CustConfirmDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustConfirmDate", inv_Information.IInfor_CustConfirmDate);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CustBak))
         {
            idb.AddParameter("@IInfor_CustBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustBak", inv_Information.IInfor_CustBak);
         }
         if (inv_Information.IInfor_ProdType == 0)
         {
            idb.AddParameter("@IInfor_ProdType", 0);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdType", inv_Information.IInfor_ProdType);
         }
         if (inv_Information.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", inv_Information.CreateTime);
         }
         if (inv_Information.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", inv_Information.UpdateTime);
         }
         if (inv_Information.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", inv_Information.DeleteTime);
         }
         if (inv_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", inv_Information.Stat);
         }
         if (string.IsNullOrEmpty(inv_Information.IInfor_CmdReq))
         {
            idb.AddParameter("@IInfor_CmdReq", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CmdReq", inv_Information.IInfor_CmdReq);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Inv_Information对象(即:一条记录
      /// </summary>
      public int Update(Inv_Information inv_Information)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Inv_Information       SET ");
            if(inv_Information.IInfor_PartNo_IsChanged){sbParameter.Append("IInfor_PartNo=@IInfor_PartNo, ");}
      if(inv_Information.IInfor_PartName_IsChanged){sbParameter.Append("IInfor_PartName=@IInfor_PartName, ");}
      if(inv_Information.IInfor_TaskCode_IsChanged){sbParameter.Append("IInfor_TaskCode=@IInfor_TaskCode, ");}
      if(inv_Information.IInfor_ProdCode_IsChanged){sbParameter.Append("IInfor_ProdCode=@IInfor_ProdCode, ");}
      if(inv_Information.IInfor_PlanCode_IsChanged){sbParameter.Append("IInfor_PlanCode=@IInfor_PlanCode, ");}
      if(inv_Information.IInfor_CmdCode_IsChanged){sbParameter.Append("IInfor_CmdCode=@IInfor_CmdCode, ");}
      if(inv_Information.IInfor_PlanBegin_IsChanged){sbParameter.Append("IInfor_PlanBegin=@IInfor_PlanBegin, ");}
      if(inv_Information.IInfor_PlanEnd_IsChanged){sbParameter.Append("IInfor_PlanEnd=@IInfor_PlanEnd, ");}
      if(inv_Information.IInfor_InTime_IsChanged){sbParameter.Append("IInfor_InTime=@IInfor_InTime, ");}
      if(inv_Information.IInfor_Num_IsChanged){sbParameter.Append("IInfor_Num=@IInfor_Num, ");}
      if(inv_Information.IInfor_WareHouse_IsChanged){sbParameter.Append("IInfor_WareHouse=@IInfor_WareHouse, ");}
      if(inv_Information.IInfor_InConfirm_IsChanged){sbParameter.Append("IInfor_InConfirm=@IInfor_InConfirm, ");}
      if(inv_Information.IInfor_InPep_IsChanged){sbParameter.Append("IInfor_InPep=@IInfor_InPep, ");}
      if(inv_Information.IInfor_InDate_IsChanged){sbParameter.Append("IInfor_InDate=@IInfor_InDate, ");}
      if(inv_Information.IInfor_Stat_IsChanged){sbParameter.Append("IInfor_Stat=@IInfor_Stat, ");}
      if(inv_Information.IInfor_ProdStat_IsChanged){sbParameter.Append("IInfor_ProdStat=@IInfor_ProdStat, ");}
      if(inv_Information.IInfor_OutDate_IsChanged){sbParameter.Append("IInfor_OutDate=@IInfor_OutDate, ");}
      if(inv_Information.IInfor_OutPep_IsChanged){sbParameter.Append("IInfor_OutPep=@IInfor_OutPep, ");}
      if(inv_Information.IInfor_CustConfirmNo_IsChanged){sbParameter.Append("IInfor_CustConfirmNo=@IInfor_CustConfirmNo, ");}
      if(inv_Information.IInfor_CustConfirmDate_IsChanged){sbParameter.Append("IInfor_CustConfirmDate=@IInfor_CustConfirmDate, ");}
      if(inv_Information.IInfor_CustBak_IsChanged){sbParameter.Append("IInfor_CustBak=@IInfor_CustBak, ");}
      if(inv_Information.IInfor_ProdType_IsChanged){sbParameter.Append("IInfor_ProdType=@IInfor_ProdType, ");}
      if(inv_Information.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(inv_Information.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(inv_Information.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime, ");}
      if(inv_Information.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(inv_Information.IInfor_CmdReq_IsChanged){sbParameter.Append("IInfor_CmdReq=@IInfor_CmdReq ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and IInfor_ID=@IInfor_ID; " );
      string sql=sb.ToString();
         if(inv_Information.IInfor_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_PartNo))
         {
            idb.AddParameter("@IInfor_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PartNo", inv_Information.IInfor_PartNo);
         }
          }
         if(inv_Information.IInfor_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_PartName))
         {
            idb.AddParameter("@IInfor_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PartName", inv_Information.IInfor_PartName);
         }
          }
         if(inv_Information.IInfor_TaskCode_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_TaskCode))
         {
            idb.AddParameter("@IInfor_TaskCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_TaskCode", inv_Information.IInfor_TaskCode);
         }
          }
         if(inv_Information.IInfor_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_ProdCode))
         {
            idb.AddParameter("@IInfor_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdCode", inv_Information.IInfor_ProdCode);
         }
          }
         if(inv_Information.IInfor_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_PlanCode))
         {
            idb.AddParameter("@IInfor_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanCode", inv_Information.IInfor_PlanCode);
         }
          }
         if(inv_Information.IInfor_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_CmdCode))
         {
            idb.AddParameter("@IInfor_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CmdCode", inv_Information.IInfor_CmdCode);
         }
          }
         if(inv_Information.IInfor_PlanBegin_IsChanged)
         {
         if (inv_Information.IInfor_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanBegin", inv_Information.IInfor_PlanBegin);
         }
          }
         if(inv_Information.IInfor_PlanEnd_IsChanged)
         {
         if (inv_Information.IInfor_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_PlanEnd", inv_Information.IInfor_PlanEnd);
         }
          }
         if(inv_Information.IInfor_InTime_IsChanged)
         {
         if (inv_Information.IInfor_InTime == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_InTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InTime", inv_Information.IInfor_InTime);
         }
          }
         if(inv_Information.IInfor_Num_IsChanged)
         {
         if (inv_Information.IInfor_Num == 0)
         {
            idb.AddParameter("@IInfor_Num", 0);
         }
         else
         {
            idb.AddParameter("@IInfor_Num", inv_Information.IInfor_Num);
         }
          }
         if(inv_Information.IInfor_WareHouse_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_WareHouse))
         {
            idb.AddParameter("@IInfor_WareHouse", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_WareHouse", inv_Information.IInfor_WareHouse);
         }
          }
         if(inv_Information.IInfor_InConfirm_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_InConfirm))
         {
            idb.AddParameter("@IInfor_InConfirm", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InConfirm", inv_Information.IInfor_InConfirm);
         }
          }
         if(inv_Information.IInfor_InPep_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_InPep))
         {
            idb.AddParameter("@IInfor_InPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InPep", inv_Information.IInfor_InPep);
         }
          }
         if(inv_Information.IInfor_InDate_IsChanged)
         {
         if (inv_Information.IInfor_InDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_InDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_InDate", inv_Information.IInfor_InDate);
         }
          }
         if(inv_Information.IInfor_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_Stat))
         {
            idb.AddParameter("@IInfor_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_Stat", inv_Information.IInfor_Stat);
         }
          }
         if(inv_Information.IInfor_ProdStat_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_ProdStat))
         {
            idb.AddParameter("@IInfor_ProdStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdStat", inv_Information.IInfor_ProdStat);
         }
          }
         if(inv_Information.IInfor_OutDate_IsChanged)
         {
         if (inv_Information.IInfor_OutDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_OutDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_OutDate", inv_Information.IInfor_OutDate);
         }
          }
         if(inv_Information.IInfor_OutPep_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_OutPep))
         {
            idb.AddParameter("@IInfor_OutPep", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_OutPep", inv_Information.IInfor_OutPep);
         }
          }
         if(inv_Information.IInfor_CustConfirmNo_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_CustConfirmNo))
         {
            idb.AddParameter("@IInfor_CustConfirmNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustConfirmNo", inv_Information.IInfor_CustConfirmNo);
         }
          }
         if(inv_Information.IInfor_CustConfirmDate_IsChanged)
         {
         if (inv_Information.IInfor_CustConfirmDate == DateTime.MinValue)
         {
            idb.AddParameter("@IInfor_CustConfirmDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustConfirmDate", inv_Information.IInfor_CustConfirmDate);
         }
          }
         if(inv_Information.IInfor_CustBak_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_CustBak))
         {
            idb.AddParameter("@IInfor_CustBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CustBak", inv_Information.IInfor_CustBak);
         }
          }
         if(inv_Information.IInfor_ProdType_IsChanged)
         {
         if (inv_Information.IInfor_ProdType == 0)
         {
            idb.AddParameter("@IInfor_ProdType", 0);
         }
         else
         {
            idb.AddParameter("@IInfor_ProdType", inv_Information.IInfor_ProdType);
         }
          }
         if(inv_Information.CreateTime_IsChanged)
         {
         if (inv_Information.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", inv_Information.CreateTime);
         }
          }
         if(inv_Information.UpdateTime_IsChanged)
         {
         if (inv_Information.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", inv_Information.UpdateTime);
         }
          }
         if(inv_Information.DeleteTime_IsChanged)
         {
         if (inv_Information.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", inv_Information.DeleteTime);
         }
          }
         if(inv_Information.Stat_IsChanged)
         {
         if (inv_Information.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", inv_Information.Stat);
         }
          }
         if(inv_Information.IInfor_CmdReq_IsChanged)
         {
         if (string.IsNullOrEmpty(inv_Information.IInfor_CmdReq))
         {
            idb.AddParameter("@IInfor_CmdReq", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IInfor_CmdReq", inv_Information.IInfor_CmdReq);
         }
          }

         idb.AddParameter("@IInfor_ID", inv_Information.IInfor_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Inv_Information对象(即:一条记录
      /// </summary>
      public int Delete(Int64 iInfor_ID)
      {
         string sql = "DELETE Inv_Information WHERE 1=1  AND IInfor_ID=@IInfor_ID ";
         idb.AddParameter("@IInfor_ID", iInfor_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Inv_Information对象(即:一条记录
      /// </summary>
      public Inv_Information GetByKey(Int64 iInfor_ID)
      {
         Inv_Information inv_Information = new Inv_Information();
         string sql = "SELECT  IInfor_ID,IInfor_PartNo,IInfor_PartName,IInfor_TaskCode,IInfor_ProdCode,IInfor_PlanCode,IInfor_CmdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_ProdStat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime,Stat,IInfor_CmdReq FROM Inv_Information WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND IInfor_ID=@IInfor_ID ";
         idb.AddParameter("@IInfor_ID", iInfor_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["IInfor_ID"] != DBNull.Value) inv_Information.IInfor_ID = Convert.ToInt64(dr["IInfor_ID"]);
            if (dr["IInfor_PartNo"] != DBNull.Value) inv_Information.IInfor_PartNo = Convert.ToString(dr["IInfor_PartNo"]);
            if (dr["IInfor_PartName"] != DBNull.Value) inv_Information.IInfor_PartName = Convert.ToString(dr["IInfor_PartName"]);
            if (dr["IInfor_TaskCode"] != DBNull.Value) inv_Information.IInfor_TaskCode = Convert.ToString(dr["IInfor_TaskCode"]);
            if (dr["IInfor_ProdCode"] != DBNull.Value) inv_Information.IInfor_ProdCode = Convert.ToString(dr["IInfor_ProdCode"]);
            if (dr["IInfor_PlanCode"] != DBNull.Value) inv_Information.IInfor_PlanCode = Convert.ToString(dr["IInfor_PlanCode"]);
            if (dr["IInfor_CmdCode"] != DBNull.Value) inv_Information.IInfor_CmdCode = Convert.ToString(dr["IInfor_CmdCode"]);
            if (dr["IInfor_PlanBegin"] != DBNull.Value) inv_Information.IInfor_PlanBegin = Convert.ToDateTime(dr["IInfor_PlanBegin"]);
            if (dr["IInfor_PlanEnd"] != DBNull.Value) inv_Information.IInfor_PlanEnd = Convert.ToDateTime(dr["IInfor_PlanEnd"]);
            if (dr["IInfor_InTime"] != DBNull.Value) inv_Information.IInfor_InTime = Convert.ToDateTime(dr["IInfor_InTime"]);
            if (dr["IInfor_Num"] != DBNull.Value) inv_Information.IInfor_Num = Convert.ToInt32(dr["IInfor_Num"]);
            if (dr["IInfor_WareHouse"] != DBNull.Value) inv_Information.IInfor_WareHouse = Convert.ToString(dr["IInfor_WareHouse"]);
            if (dr["IInfor_InConfirm"] != DBNull.Value) inv_Information.IInfor_InConfirm = Convert.ToString(dr["IInfor_InConfirm"]);
            if (dr["IInfor_InPep"] != DBNull.Value) inv_Information.IInfor_InPep = Convert.ToString(dr["IInfor_InPep"]);
            if (dr["IInfor_InDate"] != DBNull.Value) inv_Information.IInfor_InDate = Convert.ToDateTime(dr["IInfor_InDate"]);
            if (dr["IInfor_Stat"] != DBNull.Value) inv_Information.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
            if (dr["IInfor_ProdStat"] != DBNull.Value) inv_Information.IInfor_ProdStat = Convert.ToString(dr["IInfor_ProdStat"]);
            if (dr["IInfor_OutDate"] != DBNull.Value) inv_Information.IInfor_OutDate = Convert.ToDateTime(dr["IInfor_OutDate"]);
            if (dr["IInfor_OutPep"] != DBNull.Value) inv_Information.IInfor_OutPep = Convert.ToString(dr["IInfor_OutPep"]);
            if (dr["IInfor_CustConfirmNo"] != DBNull.Value) inv_Information.IInfor_CustConfirmNo = Convert.ToString(dr["IInfor_CustConfirmNo"]);
            if (dr["IInfor_CustConfirmDate"] != DBNull.Value) inv_Information.IInfor_CustConfirmDate = Convert.ToDateTime(dr["IInfor_CustConfirmDate"]);
            if (dr["IInfor_CustBak"] != DBNull.Value) inv_Information.IInfor_CustBak = Convert.ToString(dr["IInfor_CustBak"]);
            if (dr["IInfor_ProdType"] != DBNull.Value) inv_Information.IInfor_ProdType = Convert.ToInt32(dr["IInfor_ProdType"]);
            if (dr["CreateTime"] != DBNull.Value) inv_Information.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) inv_Information.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) inv_Information.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stat"] != DBNull.Value) inv_Information.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["IInfor_CmdReq"] != DBNull.Value) inv_Information.IInfor_CmdReq = Convert.ToString(dr["IInfor_CmdReq"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return inv_Information;
      }
      /// <summary>
      /// 获取指定的Inv_Information对象集合
      /// </summary>
      public List<Inv_Information> GetListByWhere(string strCondition)
      {
         List<Inv_Information> ret = new List<Inv_Information>();
         string sql = "SELECT  IInfor_ID,IInfor_PartNo,IInfor_PartName,IInfor_TaskCode,IInfor_ProdCode,IInfor_PlanCode,IInfor_CmdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_ProdStat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime,Stat,IInfor_CmdReq FROM Inv_Information WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Inv_Information inv_Information = new Inv_Information();
            if (dr["IInfor_ID"] != DBNull.Value) inv_Information.IInfor_ID = Convert.ToInt64(dr["IInfor_ID"]);
            if (dr["IInfor_PartNo"] != DBNull.Value) inv_Information.IInfor_PartNo = Convert.ToString(dr["IInfor_PartNo"]);
            if (dr["IInfor_PartName"] != DBNull.Value) inv_Information.IInfor_PartName = Convert.ToString(dr["IInfor_PartName"]);
            if (dr["IInfor_TaskCode"] != DBNull.Value) inv_Information.IInfor_TaskCode = Convert.ToString(dr["IInfor_TaskCode"]);
            if (dr["IInfor_ProdCode"] != DBNull.Value) inv_Information.IInfor_ProdCode = Convert.ToString(dr["IInfor_ProdCode"]);
            if (dr["IInfor_PlanCode"] != DBNull.Value) inv_Information.IInfor_PlanCode = Convert.ToString(dr["IInfor_PlanCode"]);
            if (dr["IInfor_CmdCode"] != DBNull.Value) inv_Information.IInfor_CmdCode = Convert.ToString(dr["IInfor_CmdCode"]);
            if (dr["IInfor_PlanBegin"] != DBNull.Value) inv_Information.IInfor_PlanBegin = Convert.ToDateTime(dr["IInfor_PlanBegin"]);
            if (dr["IInfor_PlanEnd"] != DBNull.Value) inv_Information.IInfor_PlanEnd = Convert.ToDateTime(dr["IInfor_PlanEnd"]);
            if (dr["IInfor_InTime"] != DBNull.Value) inv_Information.IInfor_InTime = Convert.ToDateTime(dr["IInfor_InTime"]);
            if (dr["IInfor_Num"] != DBNull.Value) inv_Information.IInfor_Num = Convert.ToInt32(dr["IInfor_Num"]);
            if (dr["IInfor_WareHouse"] != DBNull.Value) inv_Information.IInfor_WareHouse = Convert.ToString(dr["IInfor_WareHouse"]);
            if (dr["IInfor_InConfirm"] != DBNull.Value) inv_Information.IInfor_InConfirm = Convert.ToString(dr["IInfor_InConfirm"]);
            if (dr["IInfor_InPep"] != DBNull.Value) inv_Information.IInfor_InPep = Convert.ToString(dr["IInfor_InPep"]);
            if (dr["IInfor_InDate"] != DBNull.Value) inv_Information.IInfor_InDate = Convert.ToDateTime(dr["IInfor_InDate"]);
            if (dr["IInfor_Stat"] != DBNull.Value) inv_Information.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
            if (dr["IInfor_ProdStat"] != DBNull.Value) inv_Information.IInfor_ProdStat = Convert.ToString(dr["IInfor_ProdStat"]);
            if (dr["IInfor_OutDate"] != DBNull.Value) inv_Information.IInfor_OutDate = Convert.ToDateTime(dr["IInfor_OutDate"]);
            if (dr["IInfor_OutPep"] != DBNull.Value) inv_Information.IInfor_OutPep = Convert.ToString(dr["IInfor_OutPep"]);
            if (dr["IInfor_CustConfirmNo"] != DBNull.Value) inv_Information.IInfor_CustConfirmNo = Convert.ToString(dr["IInfor_CustConfirmNo"]);
            if (dr["IInfor_CustConfirmDate"] != DBNull.Value) inv_Information.IInfor_CustConfirmDate = Convert.ToDateTime(dr["IInfor_CustConfirmDate"]);
            if (dr["IInfor_CustBak"] != DBNull.Value) inv_Information.IInfor_CustBak = Convert.ToString(dr["IInfor_CustBak"]);
            if (dr["IInfor_ProdType"] != DBNull.Value) inv_Information.IInfor_ProdType = Convert.ToInt32(dr["IInfor_ProdType"]);
            if (dr["CreateTime"] != DBNull.Value) inv_Information.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) inv_Information.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) inv_Information.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stat"] != DBNull.Value) inv_Information.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["IInfor_CmdReq"] != DBNull.Value) inv_Information.IInfor_CmdReq = Convert.ToString(dr["IInfor_CmdReq"]);
            ret.Add(inv_Information);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Inv_Information对象(即:一条记录
      /// </summary>
      public List<Inv_Information> GetAll()
      {
         List<Inv_Information> ret = new List<Inv_Information>();
         string sql = "SELECT  IInfor_ID,IInfor_PartNo,IInfor_PartName,IInfor_TaskCode,IInfor_ProdCode,IInfor_PlanCode,IInfor_CmdCode,IInfor_PlanBegin,IInfor_PlanEnd,IInfor_InTime,IInfor_Num,IInfor_WareHouse,IInfor_InConfirm,IInfor_InPep,IInfor_InDate,IInfor_Stat,IInfor_ProdStat,IInfor_OutDate,IInfor_OutPep,IInfor_CustConfirmNo,IInfor_CustConfirmDate,IInfor_CustBak,IInfor_ProdType,CreateTime,UpdateTime,DeleteTime,Stat,IInfor_CmdReq FROM Inv_Information where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Inv_Information inv_Information = new Inv_Information();
            if (dr["IInfor_ID"] != DBNull.Value) inv_Information.IInfor_ID = Convert.ToInt64(dr["IInfor_ID"]);
            if (dr["IInfor_PartNo"] != DBNull.Value) inv_Information.IInfor_PartNo = Convert.ToString(dr["IInfor_PartNo"]);
            if (dr["IInfor_PartName"] != DBNull.Value) inv_Information.IInfor_PartName = Convert.ToString(dr["IInfor_PartName"]);
            if (dr["IInfor_TaskCode"] != DBNull.Value) inv_Information.IInfor_TaskCode = Convert.ToString(dr["IInfor_TaskCode"]);
            if (dr["IInfor_ProdCode"] != DBNull.Value) inv_Information.IInfor_ProdCode = Convert.ToString(dr["IInfor_ProdCode"]);
            if (dr["IInfor_PlanCode"] != DBNull.Value) inv_Information.IInfor_PlanCode = Convert.ToString(dr["IInfor_PlanCode"]);
            if (dr["IInfor_CmdCode"] != DBNull.Value) inv_Information.IInfor_CmdCode = Convert.ToString(dr["IInfor_CmdCode"]);
            if (dr["IInfor_PlanBegin"] != DBNull.Value) inv_Information.IInfor_PlanBegin = Convert.ToDateTime(dr["IInfor_PlanBegin"]);
            if (dr["IInfor_PlanEnd"] != DBNull.Value) inv_Information.IInfor_PlanEnd = Convert.ToDateTime(dr["IInfor_PlanEnd"]);
            if (dr["IInfor_InTime"] != DBNull.Value) inv_Information.IInfor_InTime = Convert.ToDateTime(dr["IInfor_InTime"]);
            if (dr["IInfor_Num"] != DBNull.Value) inv_Information.IInfor_Num = Convert.ToInt32(dr["IInfor_Num"]);
            if (dr["IInfor_WareHouse"] != DBNull.Value) inv_Information.IInfor_WareHouse = Convert.ToString(dr["IInfor_WareHouse"]);
            if (dr["IInfor_InConfirm"] != DBNull.Value) inv_Information.IInfor_InConfirm = Convert.ToString(dr["IInfor_InConfirm"]);
            if (dr["IInfor_InPep"] != DBNull.Value) inv_Information.IInfor_InPep = Convert.ToString(dr["IInfor_InPep"]);
            if (dr["IInfor_InDate"] != DBNull.Value) inv_Information.IInfor_InDate = Convert.ToDateTime(dr["IInfor_InDate"]);
            if (dr["IInfor_Stat"] != DBNull.Value) inv_Information.IInfor_Stat = Convert.ToString(dr["IInfor_Stat"]);
            if (dr["IInfor_ProdStat"] != DBNull.Value) inv_Information.IInfor_ProdStat = Convert.ToString(dr["IInfor_ProdStat"]);
            if (dr["IInfor_OutDate"] != DBNull.Value) inv_Information.IInfor_OutDate = Convert.ToDateTime(dr["IInfor_OutDate"]);
            if (dr["IInfor_OutPep"] != DBNull.Value) inv_Information.IInfor_OutPep = Convert.ToString(dr["IInfor_OutPep"]);
            if (dr["IInfor_CustConfirmNo"] != DBNull.Value) inv_Information.IInfor_CustConfirmNo = Convert.ToString(dr["IInfor_CustConfirmNo"]);
            if (dr["IInfor_CustConfirmDate"] != DBNull.Value) inv_Information.IInfor_CustConfirmDate = Convert.ToDateTime(dr["IInfor_CustConfirmDate"]);
            if (dr["IInfor_CustBak"] != DBNull.Value) inv_Information.IInfor_CustBak = Convert.ToString(dr["IInfor_CustBak"]);
            if (dr["IInfor_ProdType"] != DBNull.Value) inv_Information.IInfor_ProdType = Convert.ToInt32(dr["IInfor_ProdType"]);
            if (dr["CreateTime"] != DBNull.Value) inv_Information.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) inv_Information.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) inv_Information.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["Stat"] != DBNull.Value) inv_Information.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["IInfor_CmdReq"] != DBNull.Value) inv_Information.IInfor_CmdReq = Convert.ToString(dr["IInfor_CmdReq"]);
            ret.Add(inv_Information);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
