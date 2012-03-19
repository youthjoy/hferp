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
   public partial class ADOProd_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Prod_Record对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Record prod_Record)
      {
         string sql = "INSERT INTO Prod_Record (PRD_Code,PRD_NodeCode,PRD_NodeName,PRD_FNum,PRD_EquCode,PRD_EquName,PRD_Operator,PRD_Begin,PRD_End,PRD_TimeCost,PRD_ProDept,PRD_PlanBegin,PRD_PlanEnd,PRD_Specialty,PRD_Num,PRD_ConfirmMen,PRD_Deployor,PRD_DeployDate,PRD_NodeContent,PRD_Remark,Stat,CreateTime) VALUES (@PRD_Code,@PRD_NodeCode,@PRD_NodeName,@PRD_FNum,@PRD_EquCode,@PRD_EquName,@PRD_Operator,@PRD_Begin,@PRD_End,@PRD_TimeCost,@PRD_ProDept,@PRD_PlanBegin,@PRD_PlanEnd,@PRD_Specialty,@PRD_Num,@PRD_ConfirmMen,@PRD_Deployor,@PRD_DeployDate,@PRD_NodeContent,@PRD_Remark,@Stat,@CreateTime)";
         if (string.IsNullOrEmpty(prod_Record.PRD_Code))
         {
            idb.AddParameter("@PRD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Code", prod_Record.PRD_Code);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeCode))
         {
            idb.AddParameter("@PRD_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeCode", prod_Record.PRD_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeName))
         {
            idb.AddParameter("@PRD_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeName", prod_Record.PRD_NodeName);
         }
         if (prod_Record.PRD_FNum == 0)
         {
            idb.AddParameter("@PRD_FNum", 0);
         }
         else
         {
            idb.AddParameter("@PRD_FNum", prod_Record.PRD_FNum);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_EquCode))
         {
            idb.AddParameter("@PRD_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_EquCode", prod_Record.PRD_EquCode);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_EquName))
         {
            idb.AddParameter("@PRD_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_EquName", prod_Record.PRD_EquName);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Operator))
         {
            idb.AddParameter("@PRD_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Operator", prod_Record.PRD_Operator);
         }
         if (prod_Record.PRD_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Begin", prod_Record.PRD_Begin);
         }
         if (prod_Record.PRD_End == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_End", prod_Record.PRD_End);
         }
         if (prod_Record.PRD_TimeCost == 0)
         {
            idb.AddParameter("@PRD_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRD_TimeCost", prod_Record.PRD_TimeCost);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_ProDept))
         {
            idb.AddParameter("@PRD_ProDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_ProDept", prod_Record.PRD_ProDept);
         }
         if (prod_Record.PRD_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_PlanBegin", prod_Record.PRD_PlanBegin);
         }
         if (prod_Record.PRD_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_PlanEnd", prod_Record.PRD_PlanEnd);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Specialty))
         {
            idb.AddParameter("@PRD_Specialty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Specialty", prod_Record.PRD_Specialty);
         }
         if (prod_Record.PRD_Num == 0)
         {
            idb.AddParameter("@PRD_Num", 0);
         }
         else
         {
            idb.AddParameter("@PRD_Num", prod_Record.PRD_Num);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_ConfirmMen))
         {
            idb.AddParameter("@PRD_ConfirmMen", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_ConfirmMen", prod_Record.PRD_ConfirmMen);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Deployor))
         {
            idb.AddParameter("@PRD_Deployor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Deployor", prod_Record.PRD_Deployor);
         }
         if (prod_Record.PRD_DeployDate == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_DeployDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_DeployDate", prod_Record.PRD_DeployDate);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeContent))
         {
            idb.AddParameter("@PRD_NodeContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeContent", prod_Record.PRD_NodeContent);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Remark))
         {
            idb.AddParameter("@PRD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Remark", prod_Record.PRD_Remark);
         }
         if (prod_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Record.Stat);
         }
         if (prod_Record.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", prod_Record.CreateTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Prod_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Record prod_Record)
      {
         string sql = "INSERT INTO Prod_Record (PRD_Code,PRD_NodeCode,PRD_NodeName,PRD_FNum,PRD_EquCode,PRD_EquName,PRD_Operator,PRD_Begin,PRD_End,PRD_TimeCost,PRD_ProDept,PRD_PlanBegin,PRD_PlanEnd,PRD_Specialty,PRD_Num,PRD_ConfirmMen,PRD_Deployor,PRD_DeployDate,PRD_NodeContent,PRD_Remark,Stat,CreateTime) VALUES (@PRD_Code,@PRD_NodeCode,@PRD_NodeName,@PRD_FNum,@PRD_EquCode,@PRD_EquName,@PRD_Operator,@PRD_Begin,@PRD_End,@PRD_TimeCost,@PRD_ProDept,@PRD_PlanBegin,@PRD_PlanEnd,@PRD_Specialty,@PRD_Num,@PRD_ConfirmMen,@PRD_Deployor,@PRD_DeployDate,@PRD_NodeContent,@PRD_Remark,@Stat,@CreateTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Record.PRD_Code))
         {
            idb.AddParameter("@PRD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Code", prod_Record.PRD_Code);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeCode))
         {
            idb.AddParameter("@PRD_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeCode", prod_Record.PRD_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeName))
         {
            idb.AddParameter("@PRD_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeName", prod_Record.PRD_NodeName);
         }
         if (prod_Record.PRD_FNum == 0)
         {
            idb.AddParameter("@PRD_FNum", 0);
         }
         else
         {
            idb.AddParameter("@PRD_FNum", prod_Record.PRD_FNum);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_EquCode))
         {
            idb.AddParameter("@PRD_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_EquCode", prod_Record.PRD_EquCode);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_EquName))
         {
            idb.AddParameter("@PRD_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_EquName", prod_Record.PRD_EquName);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Operator))
         {
            idb.AddParameter("@PRD_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Operator", prod_Record.PRD_Operator);
         }
         if (prod_Record.PRD_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Begin", prod_Record.PRD_Begin);
         }
         if (prod_Record.PRD_End == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_End", prod_Record.PRD_End);
         }
         if (prod_Record.PRD_TimeCost == 0)
         {
            idb.AddParameter("@PRD_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRD_TimeCost", prod_Record.PRD_TimeCost);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_ProDept))
         {
            idb.AddParameter("@PRD_ProDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_ProDept", prod_Record.PRD_ProDept);
         }
         if (prod_Record.PRD_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_PlanBegin", prod_Record.PRD_PlanBegin);
         }
         if (prod_Record.PRD_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_PlanEnd", prod_Record.PRD_PlanEnd);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Specialty))
         {
            idb.AddParameter("@PRD_Specialty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Specialty", prod_Record.PRD_Specialty);
         }
         if (prod_Record.PRD_Num == 0)
         {
            idb.AddParameter("@PRD_Num", 0);
         }
         else
         {
            idb.AddParameter("@PRD_Num", prod_Record.PRD_Num);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_ConfirmMen))
         {
            idb.AddParameter("@PRD_ConfirmMen", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_ConfirmMen", prod_Record.PRD_ConfirmMen);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Deployor))
         {
            idb.AddParameter("@PRD_Deployor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Deployor", prod_Record.PRD_Deployor);
         }
         if (prod_Record.PRD_DeployDate == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_DeployDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_DeployDate", prod_Record.PRD_DeployDate);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeContent))
         {
            idb.AddParameter("@PRD_NodeContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeContent", prod_Record.PRD_NodeContent);
         }
         if (string.IsNullOrEmpty(prod_Record.PRD_Remark))
         {
            idb.AddParameter("@PRD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Remark", prod_Record.PRD_Remark);
         }
         if (prod_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Record.Stat);
         }
         if (prod_Record.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", prod_Record.CreateTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Prod_Record对象(即:一条记录
      /// </summary>
      public int Update(Prod_Record prod_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Record       SET ");
            if(prod_Record.PRD_Code_IsChanged){sbParameter.Append("PRD_Code=@PRD_Code, ");}
      if(prod_Record.PRD_NodeCode_IsChanged){sbParameter.Append("PRD_NodeCode=@PRD_NodeCode, ");}
      if(prod_Record.PRD_NodeName_IsChanged){sbParameter.Append("PRD_NodeName=@PRD_NodeName, ");}
      if(prod_Record.PRD_FNum_IsChanged){sbParameter.Append("PRD_FNum=@PRD_FNum, ");}
      if(prod_Record.PRD_EquCode_IsChanged){sbParameter.Append("PRD_EquCode=@PRD_EquCode, ");}
      if(prod_Record.PRD_EquName_IsChanged){sbParameter.Append("PRD_EquName=@PRD_EquName, ");}
      if(prod_Record.PRD_Operator_IsChanged){sbParameter.Append("PRD_Operator=@PRD_Operator, ");}
      if(prod_Record.PRD_Begin_IsChanged){sbParameter.Append("PRD_Begin=@PRD_Begin, ");}
      if(prod_Record.PRD_End_IsChanged){sbParameter.Append("PRD_End=@PRD_End, ");}
      if(prod_Record.PRD_TimeCost_IsChanged){sbParameter.Append("PRD_TimeCost=@PRD_TimeCost, ");}
      if(prod_Record.PRD_ProDept_IsChanged){sbParameter.Append("PRD_ProDept=@PRD_ProDept, ");}
      if(prod_Record.PRD_PlanBegin_IsChanged){sbParameter.Append("PRD_PlanBegin=@PRD_PlanBegin, ");}
      if(prod_Record.PRD_PlanEnd_IsChanged){sbParameter.Append("PRD_PlanEnd=@PRD_PlanEnd, ");}
      if(prod_Record.PRD_Specialty_IsChanged){sbParameter.Append("PRD_Specialty=@PRD_Specialty, ");}
      if(prod_Record.PRD_Num_IsChanged){sbParameter.Append("PRD_Num=@PRD_Num, ");}
      if(prod_Record.PRD_ConfirmMen_IsChanged){sbParameter.Append("PRD_ConfirmMen=@PRD_ConfirmMen, ");}
      if(prod_Record.PRD_Deployor_IsChanged){sbParameter.Append("PRD_Deployor=@PRD_Deployor, ");}
      if(prod_Record.PRD_DeployDate_IsChanged){sbParameter.Append("PRD_DeployDate=@PRD_DeployDate, ");}
      if(prod_Record.PRD_NodeContent_IsChanged){sbParameter.Append("PRD_NodeContent=@PRD_NodeContent, ");}
      if(prod_Record.PRD_Remark_IsChanged){sbParameter.Append("PRD_Remark=@PRD_Remark, ");}
      if(prod_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_Record.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PRD_ID=@PRD_ID; " );
      string sql=sb.ToString();
         if(prod_Record.PRD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_Code))
         {
            idb.AddParameter("@PRD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Code", prod_Record.PRD_Code);
         }
          }
         if(prod_Record.PRD_NodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeCode))
         {
            idb.AddParameter("@PRD_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeCode", prod_Record.PRD_NodeCode);
         }
          }
         if(prod_Record.PRD_NodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeName))
         {
            idb.AddParameter("@PRD_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeName", prod_Record.PRD_NodeName);
         }
          }
         if(prod_Record.PRD_FNum_IsChanged)
         {
         if (prod_Record.PRD_FNum == 0)
         {
            idb.AddParameter("@PRD_FNum", 0);
         }
         else
         {
            idb.AddParameter("@PRD_FNum", prod_Record.PRD_FNum);
         }
          }
         if(prod_Record.PRD_EquCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_EquCode))
         {
            idb.AddParameter("@PRD_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_EquCode", prod_Record.PRD_EquCode);
         }
          }
         if(prod_Record.PRD_EquName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_EquName))
         {
            idb.AddParameter("@PRD_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_EquName", prod_Record.PRD_EquName);
         }
          }
         if(prod_Record.PRD_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_Operator))
         {
            idb.AddParameter("@PRD_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Operator", prod_Record.PRD_Operator);
         }
          }
         if(prod_Record.PRD_Begin_IsChanged)
         {
         if (prod_Record.PRD_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Begin", prod_Record.PRD_Begin);
         }
          }
         if(prod_Record.PRD_End_IsChanged)
         {
         if (prod_Record.PRD_End == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_End", prod_Record.PRD_End);
         }
          }
         if(prod_Record.PRD_TimeCost_IsChanged)
         {
         if (prod_Record.PRD_TimeCost == 0)
         {
            idb.AddParameter("@PRD_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@PRD_TimeCost", prod_Record.PRD_TimeCost);
         }
          }
         if(prod_Record.PRD_ProDept_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_ProDept))
         {
            idb.AddParameter("@PRD_ProDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_ProDept", prod_Record.PRD_ProDept);
         }
          }
         if(prod_Record.PRD_PlanBegin_IsChanged)
         {
         if (prod_Record.PRD_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_PlanBegin", prod_Record.PRD_PlanBegin);
         }
          }
         if(prod_Record.PRD_PlanEnd_IsChanged)
         {
         if (prod_Record.PRD_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_PlanEnd", prod_Record.PRD_PlanEnd);
         }
          }
         if(prod_Record.PRD_Specialty_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_Specialty))
         {
            idb.AddParameter("@PRD_Specialty", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Specialty", prod_Record.PRD_Specialty);
         }
          }
         if(prod_Record.PRD_Num_IsChanged)
         {
         if (prod_Record.PRD_Num == 0)
         {
            idb.AddParameter("@PRD_Num", 0);
         }
         else
         {
            idb.AddParameter("@PRD_Num", prod_Record.PRD_Num);
         }
          }
         if(prod_Record.PRD_ConfirmMen_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_ConfirmMen))
         {
            idb.AddParameter("@PRD_ConfirmMen", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_ConfirmMen", prod_Record.PRD_ConfirmMen);
         }
          }
         if(prod_Record.PRD_Deployor_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_Deployor))
         {
            idb.AddParameter("@PRD_Deployor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Deployor", prod_Record.PRD_Deployor);
         }
          }
         if(prod_Record.PRD_DeployDate_IsChanged)
         {
         if (prod_Record.PRD_DeployDate == DateTime.MinValue)
         {
            idb.AddParameter("@PRD_DeployDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_DeployDate", prod_Record.PRD_DeployDate);
         }
          }
         if(prod_Record.PRD_NodeContent_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_NodeContent))
         {
            idb.AddParameter("@PRD_NodeContent", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_NodeContent", prod_Record.PRD_NodeContent);
         }
          }
         if(prod_Record.PRD_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Record.PRD_Remark))
         {
            idb.AddParameter("@PRD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PRD_Remark", prod_Record.PRD_Remark);
         }
          }
         if(prod_Record.Stat_IsChanged)
         {
         if (prod_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Record.Stat);
         }
          }
         if(prod_Record.CreateTime_IsChanged)
         {
         if (prod_Record.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", prod_Record.CreateTime);
         }
          }

         idb.AddParameter("@PRD_ID", prod_Record.PRD_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Prod_Record对象(即:一条记录
      /// </summary>
      public int Delete(int pRD_ID)
      {
         string sql = "DELETE Prod_Record WHERE 1=1  AND PRD_ID=@PRD_ID ";
         idb.AddParameter("@PRD_ID", pRD_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Prod_Record对象(即:一条记录
      /// </summary>
      public Prod_Record GetByKey(int pRD_ID)
      {
         Prod_Record prod_Record = new Prod_Record();
         string sql = "SELECT  PRD_ID,PRD_Code,PRD_NodeCode,PRD_NodeName,PRD_FNum,PRD_EquCode,PRD_EquName,PRD_Operator,PRD_Begin,PRD_End,PRD_TimeCost,PRD_ProDept,PRD_PlanBegin,PRD_PlanEnd,PRD_Specialty,PRD_Num,PRD_ConfirmMen,PRD_Deployor,PRD_DeployDate,PRD_NodeContent,PRD_Remark,Stat,CreateTime FROM Prod_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PRD_ID=@PRD_ID ";
         idb.AddParameter("@PRD_ID", pRD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PRD_ID"] != DBNull.Value) prod_Record.PRD_ID = Convert.ToInt32(dr["PRD_ID"]);
            if (dr["PRD_Code"] != DBNull.Value) prod_Record.PRD_Code = Convert.ToString(dr["PRD_Code"]);
            if (dr["PRD_NodeCode"] != DBNull.Value) prod_Record.PRD_NodeCode = Convert.ToString(dr["PRD_NodeCode"]);
            if (dr["PRD_NodeName"] != DBNull.Value) prod_Record.PRD_NodeName = Convert.ToString(dr["PRD_NodeName"]);
            if (dr["PRD_FNum"] != DBNull.Value) prod_Record.PRD_FNum = Convert.ToInt32(dr["PRD_FNum"]);
            if (dr["PRD_EquCode"] != DBNull.Value) prod_Record.PRD_EquCode = Convert.ToString(dr["PRD_EquCode"]);
            if (dr["PRD_EquName"] != DBNull.Value) prod_Record.PRD_EquName = Convert.ToString(dr["PRD_EquName"]);
            if (dr["PRD_Operator"] != DBNull.Value) prod_Record.PRD_Operator = Convert.ToString(dr["PRD_Operator"]);
            if (dr["PRD_Begin"] != DBNull.Value) prod_Record.PRD_Begin = Convert.ToDateTime(dr["PRD_Begin"]);
            if (dr["PRD_End"] != DBNull.Value) prod_Record.PRD_End = Convert.ToDateTime(dr["PRD_End"]);
            if (dr["PRD_TimeCost"] != DBNull.Value) prod_Record.PRD_TimeCost = Convert.ToInt32(dr["PRD_TimeCost"]);
            if (dr["PRD_ProDept"] != DBNull.Value) prod_Record.PRD_ProDept = Convert.ToString(dr["PRD_ProDept"]);
            if (dr["PRD_PlanBegin"] != DBNull.Value) prod_Record.PRD_PlanBegin = Convert.ToDateTime(dr["PRD_PlanBegin"]);
            if (dr["PRD_PlanEnd"] != DBNull.Value) prod_Record.PRD_PlanEnd = Convert.ToDateTime(dr["PRD_PlanEnd"]);
            if (dr["PRD_Specialty"] != DBNull.Value) prod_Record.PRD_Specialty = Convert.ToString(dr["PRD_Specialty"]);
            if (dr["PRD_Num"] != DBNull.Value) prod_Record.PRD_Num = Convert.ToInt32(dr["PRD_Num"]);
            if (dr["PRD_ConfirmMen"] != DBNull.Value) prod_Record.PRD_ConfirmMen = Convert.ToString(dr["PRD_ConfirmMen"]);
            if (dr["PRD_Deployor"] != DBNull.Value) prod_Record.PRD_Deployor = Convert.ToString(dr["PRD_Deployor"]);
            if (dr["PRD_DeployDate"] != DBNull.Value) prod_Record.PRD_DeployDate = Convert.ToDateTime(dr["PRD_DeployDate"]);
            if (dr["PRD_NodeContent"] != DBNull.Value) prod_Record.PRD_NodeContent = Convert.ToString(dr["PRD_NodeContent"]);
            if (dr["PRD_Remark"] != DBNull.Value) prod_Record.PRD_Remark = Convert.ToString(dr["PRD_Remark"]);
            if (dr["Stat"] != DBNull.Value) prod_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) prod_Record.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return prod_Record;
      }
      /// <summary>
      /// 获取指定的Prod_Record对象集合
      /// </summary>
      public List<Prod_Record> GetListByWhere(string strCondition)
      {
         List<Prod_Record> ret = new List<Prod_Record>();
         string sql = "SELECT  PRD_ID,PRD_Code,PRD_NodeCode,PRD_NodeName,PRD_FNum,PRD_EquCode,PRD_EquName,PRD_Operator,PRD_Begin,PRD_End,PRD_TimeCost,PRD_ProDept,PRD_PlanBegin,PRD_PlanEnd,PRD_Specialty,PRD_Num,PRD_ConfirmMen,PRD_Deployor,PRD_DeployDate,PRD_NodeContent,PRD_Remark,Stat,CreateTime FROM Prod_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_Record prod_Record = new Prod_Record();
            if (dr["PRD_ID"] != DBNull.Value) prod_Record.PRD_ID = Convert.ToInt32(dr["PRD_ID"]);
            if (dr["PRD_Code"] != DBNull.Value) prod_Record.PRD_Code = Convert.ToString(dr["PRD_Code"]);
            if (dr["PRD_NodeCode"] != DBNull.Value) prod_Record.PRD_NodeCode = Convert.ToString(dr["PRD_NodeCode"]);
            if (dr["PRD_NodeName"] != DBNull.Value) prod_Record.PRD_NodeName = Convert.ToString(dr["PRD_NodeName"]);
            if (dr["PRD_FNum"] != DBNull.Value) prod_Record.PRD_FNum = Convert.ToInt32(dr["PRD_FNum"]);
            if (dr["PRD_EquCode"] != DBNull.Value) prod_Record.PRD_EquCode = Convert.ToString(dr["PRD_EquCode"]);
            if (dr["PRD_EquName"] != DBNull.Value) prod_Record.PRD_EquName = Convert.ToString(dr["PRD_EquName"]);
            if (dr["PRD_Operator"] != DBNull.Value) prod_Record.PRD_Operator = Convert.ToString(dr["PRD_Operator"]);
            if (dr["PRD_Begin"] != DBNull.Value) prod_Record.PRD_Begin = Convert.ToDateTime(dr["PRD_Begin"]);
            if (dr["PRD_End"] != DBNull.Value) prod_Record.PRD_End = Convert.ToDateTime(dr["PRD_End"]);
            if (dr["PRD_TimeCost"] != DBNull.Value) prod_Record.PRD_TimeCost = Convert.ToInt32(dr["PRD_TimeCost"]);
            if (dr["PRD_ProDept"] != DBNull.Value) prod_Record.PRD_ProDept = Convert.ToString(dr["PRD_ProDept"]);
            if (dr["PRD_PlanBegin"] != DBNull.Value) prod_Record.PRD_PlanBegin = Convert.ToDateTime(dr["PRD_PlanBegin"]);
            if (dr["PRD_PlanEnd"] != DBNull.Value) prod_Record.PRD_PlanEnd = Convert.ToDateTime(dr["PRD_PlanEnd"]);
            if (dr["PRD_Specialty"] != DBNull.Value) prod_Record.PRD_Specialty = Convert.ToString(dr["PRD_Specialty"]);
            if (dr["PRD_Num"] != DBNull.Value) prod_Record.PRD_Num = Convert.ToInt32(dr["PRD_Num"]);
            if (dr["PRD_ConfirmMen"] != DBNull.Value) prod_Record.PRD_ConfirmMen = Convert.ToString(dr["PRD_ConfirmMen"]);
            if (dr["PRD_Deployor"] != DBNull.Value) prod_Record.PRD_Deployor = Convert.ToString(dr["PRD_Deployor"]);
            if (dr["PRD_DeployDate"] != DBNull.Value) prod_Record.PRD_DeployDate = Convert.ToDateTime(dr["PRD_DeployDate"]);
            if (dr["PRD_NodeContent"] != DBNull.Value) prod_Record.PRD_NodeContent = Convert.ToString(dr["PRD_NodeContent"]);
            if (dr["PRD_Remark"] != DBNull.Value) prod_Record.PRD_Remark = Convert.ToString(dr["PRD_Remark"]);
            if (dr["Stat"] != DBNull.Value) prod_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) prod_Record.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(prod_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的Prod_Record对象(即:一条记录
      /// </summary>
      public List<Prod_Record> GetAll()
      {
         List<Prod_Record> ret = new List<Prod_Record>();
         string sql = "SELECT  PRD_ID,PRD_Code,PRD_NodeCode,PRD_NodeName,PRD_FNum,PRD_EquCode,PRD_EquName,PRD_Operator,PRD_Begin,PRD_End,PRD_TimeCost,PRD_ProDept,PRD_PlanBegin,PRD_PlanEnd,PRD_Specialty,PRD_Num,PRD_ConfirmMen,PRD_Deployor,PRD_DeployDate,PRD_NodeContent,PRD_Remark,Stat,CreateTime FROM Prod_Record where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Record prod_Record = new Prod_Record();
            if (dr["PRD_ID"] != DBNull.Value) prod_Record.PRD_ID = Convert.ToInt32(dr["PRD_ID"]);
            if (dr["PRD_Code"] != DBNull.Value) prod_Record.PRD_Code = Convert.ToString(dr["PRD_Code"]);
            if (dr["PRD_NodeCode"] != DBNull.Value) prod_Record.PRD_NodeCode = Convert.ToString(dr["PRD_NodeCode"]);
            if (dr["PRD_NodeName"] != DBNull.Value) prod_Record.PRD_NodeName = Convert.ToString(dr["PRD_NodeName"]);
            if (dr["PRD_FNum"] != DBNull.Value) prod_Record.PRD_FNum = Convert.ToInt32(dr["PRD_FNum"]);
            if (dr["PRD_EquCode"] != DBNull.Value) prod_Record.PRD_EquCode = Convert.ToString(dr["PRD_EquCode"]);
            if (dr["PRD_EquName"] != DBNull.Value) prod_Record.PRD_EquName = Convert.ToString(dr["PRD_EquName"]);
            if (dr["PRD_Operator"] != DBNull.Value) prod_Record.PRD_Operator = Convert.ToString(dr["PRD_Operator"]);
            if (dr["PRD_Begin"] != DBNull.Value) prod_Record.PRD_Begin = Convert.ToDateTime(dr["PRD_Begin"]);
            if (dr["PRD_End"] != DBNull.Value) prod_Record.PRD_End = Convert.ToDateTime(dr["PRD_End"]);
            if (dr["PRD_TimeCost"] != DBNull.Value) prod_Record.PRD_TimeCost = Convert.ToInt32(dr["PRD_TimeCost"]);
            if (dr["PRD_ProDept"] != DBNull.Value) prod_Record.PRD_ProDept = Convert.ToString(dr["PRD_ProDept"]);
            if (dr["PRD_PlanBegin"] != DBNull.Value) prod_Record.PRD_PlanBegin = Convert.ToDateTime(dr["PRD_PlanBegin"]);
            if (dr["PRD_PlanEnd"] != DBNull.Value) prod_Record.PRD_PlanEnd = Convert.ToDateTime(dr["PRD_PlanEnd"]);
            if (dr["PRD_Specialty"] != DBNull.Value) prod_Record.PRD_Specialty = Convert.ToString(dr["PRD_Specialty"]);
            if (dr["PRD_Num"] != DBNull.Value) prod_Record.PRD_Num = Convert.ToInt32(dr["PRD_Num"]);
            if (dr["PRD_ConfirmMen"] != DBNull.Value) prod_Record.PRD_ConfirmMen = Convert.ToString(dr["PRD_ConfirmMen"]);
            if (dr["PRD_Deployor"] != DBNull.Value) prod_Record.PRD_Deployor = Convert.ToString(dr["PRD_Deployor"]);
            if (dr["PRD_DeployDate"] != DBNull.Value) prod_Record.PRD_DeployDate = Convert.ToDateTime(dr["PRD_DeployDate"]);
            if (dr["PRD_NodeContent"] != DBNull.Value) prod_Record.PRD_NodeContent = Convert.ToString(dr["PRD_NodeContent"]);
            if (dr["PRD_Remark"] != DBNull.Value) prod_Record.PRD_Remark = Convert.ToString(dr["PRD_Remark"]);
            if (dr["Stat"] != DBNull.Value) prod_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) prod_Record.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(prod_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
