using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;

namespace QX.DataAceess
{
   /// <summary>
   /// 生产任务细表
   /// </summary>
   [Serializable]
   public partial class ADOProd_TaskDetail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产任务细表 Prod_TaskDetail对象(即:一条记录)
      /// </summary>
      public int Add(Prod_TaskDetail prod_TaskDetail)
      {
         string sql = "INSERT INTO Prod_TaskDetail (TaskDetail_Code,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,TaskDetail_Unit,TaskDetail_Num,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_DNum,Stat) VALUES (@TaskDetail_Code,@TaskDetail_CmdCode,@TaskDetail_PartNo,@TaskDetail_PartName,@TaskDetail_Unit,@TaskDetail_Num,@TaskDetail_ProdType,@TaskDetail_PlanBegin,@TaskDetail_PlanEnd,@TaskDetail_ActEnd,@Task_FNum,@Task_Roads,@Task_ProdCode,@Task_Stat,@Task_DNum,@Stat)";
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_Code))
         {
            idb.AddParameter("@TaskDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Code", prod_TaskDetail.TaskDetail_Code);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_CmdCode))
         {
            idb.AddParameter("@TaskDetail_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_CmdCode", prod_TaskDetail.TaskDetail_CmdCode);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_PartNo))
         {
            idb.AddParameter("@TaskDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartNo", prod_TaskDetail.TaskDetail_PartNo);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_PartName))
         {
            idb.AddParameter("@TaskDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartName", prod_TaskDetail.TaskDetail_PartName);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_Unit))
         {
            idb.AddParameter("@TaskDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Unit", prod_TaskDetail.TaskDetail_Unit);
         }
         if (prod_TaskDetail.TaskDetail_Num == 0)
         {
            idb.AddParameter("@TaskDetail_Num", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Num", prod_TaskDetail.TaskDetail_Num);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_ProdType))
         {
            idb.AddParameter("@TaskDetail_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ProdType", prod_TaskDetail.TaskDetail_ProdType);
         }
         if (prod_TaskDetail.TaskDetail_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanBegin", prod_TaskDetail.TaskDetail_PlanBegin);
         }
         if (prod_TaskDetail.TaskDetail_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanEnd", prod_TaskDetail.TaskDetail_PlanEnd);
         }
         if (prod_TaskDetail.TaskDetail_ActEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_ActEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ActEnd", prod_TaskDetail.TaskDetail_ActEnd);
         }
         if (prod_TaskDetail.Task_FNum == 0)
         {
            idb.AddParameter("@Task_FNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_FNum", prod_TaskDetail.Task_FNum);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.Task_Roads))
         {
            idb.AddParameter("@Task_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Roads", prod_TaskDetail.Task_Roads);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.Task_ProdCode))
         {
            idb.AddParameter("@Task_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_ProdCode", prod_TaskDetail.Task_ProdCode);
         }
         if (prod_TaskDetail.Task_Stat == 0)
         {
            idb.AddParameter("@Task_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Stat", prod_TaskDetail.Task_Stat);
         }
         if (prod_TaskDetail.Task_DNum == 0)
         {
            idb.AddParameter("@Task_DNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_DNum", prod_TaskDetail.Task_DNum);
         }
         if (prod_TaskDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", prod_TaskDetail.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加生产任务细表 Prod_TaskDetail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_TaskDetail prod_TaskDetail)
      {
         string sql = "INSERT INTO Prod_TaskDetail (TaskDetail_Code,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,TaskDetail_Unit,TaskDetail_Num,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_DNum,Stat) VALUES (@TaskDetail_Code,@TaskDetail_CmdCode,@TaskDetail_PartNo,@TaskDetail_PartName,@TaskDetail_Unit,@TaskDetail_Num,@TaskDetail_ProdType,@TaskDetail_PlanBegin,@TaskDetail_PlanEnd,@TaskDetail_ActEnd,@Task_FNum,@Task_Roads,@Task_ProdCode,@Task_Stat,@Task_DNum,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_Code))
         {
            idb.AddParameter("@TaskDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Code", prod_TaskDetail.TaskDetail_Code);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_CmdCode))
         {
            idb.AddParameter("@TaskDetail_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_CmdCode", prod_TaskDetail.TaskDetail_CmdCode);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_PartNo))
         {
            idb.AddParameter("@TaskDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartNo", prod_TaskDetail.TaskDetail_PartNo);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_PartName))
         {
            idb.AddParameter("@TaskDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartName", prod_TaskDetail.TaskDetail_PartName);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_Unit))
         {
            idb.AddParameter("@TaskDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Unit", prod_TaskDetail.TaskDetail_Unit);
         }
         if (prod_TaskDetail.TaskDetail_Num == 0)
         {
            idb.AddParameter("@TaskDetail_Num", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Num", prod_TaskDetail.TaskDetail_Num);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_ProdType))
         {
            idb.AddParameter("@TaskDetail_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ProdType", prod_TaskDetail.TaskDetail_ProdType);
         }
         if (prod_TaskDetail.TaskDetail_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanBegin", prod_TaskDetail.TaskDetail_PlanBegin);
         }
         if (prod_TaskDetail.TaskDetail_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanEnd", prod_TaskDetail.TaskDetail_PlanEnd);
         }
         if (prod_TaskDetail.TaskDetail_ActEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_ActEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ActEnd", prod_TaskDetail.TaskDetail_ActEnd);
         }
         if (prod_TaskDetail.Task_FNum == 0)
         {
            idb.AddParameter("@Task_FNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_FNum", prod_TaskDetail.Task_FNum);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.Task_Roads))
         {
            idb.AddParameter("@Task_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Roads", prod_TaskDetail.Task_Roads);
         }
         if (string.IsNullOrEmpty(prod_TaskDetail.Task_ProdCode))
         {
            idb.AddParameter("@Task_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_ProdCode", prod_TaskDetail.Task_ProdCode);
         }
         if (prod_TaskDetail.Task_Stat == 0)
         {
            idb.AddParameter("@Task_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Stat", prod_TaskDetail.Task_Stat);
         }
         if (prod_TaskDetail.Task_DNum == 0)
         {
            idb.AddParameter("@Task_DNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_DNum", prod_TaskDetail.Task_DNum);
         }
         if (prod_TaskDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", prod_TaskDetail.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新生产任务细表 Prod_TaskDetail对象(即:一条记录
      /// </summary>
      public int Update(Prod_TaskDetail prod_TaskDetail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_TaskDetail       SET ");
            if(prod_TaskDetail.TaskDetail_Code_IsChanged){sbParameter.Append("TaskDetail_Code=@TaskDetail_Code, ");}
      if(prod_TaskDetail.TaskDetail_CmdCode_IsChanged){sbParameter.Append("TaskDetail_CmdCode=@TaskDetail_CmdCode, ");}
      if(prod_TaskDetail.TaskDetail_PartNo_IsChanged){sbParameter.Append("TaskDetail_PartNo=@TaskDetail_PartNo, ");}
      if(prod_TaskDetail.TaskDetail_PartName_IsChanged){sbParameter.Append("TaskDetail_PartName=@TaskDetail_PartName, ");}
      if(prod_TaskDetail.TaskDetail_Unit_IsChanged){sbParameter.Append("TaskDetail_Unit=@TaskDetail_Unit, ");}
      if(prod_TaskDetail.TaskDetail_Num_IsChanged){sbParameter.Append("TaskDetail_Num=@TaskDetail_Num, ");}
      if(prod_TaskDetail.TaskDetail_ProdType_IsChanged){sbParameter.Append("TaskDetail_ProdType=@TaskDetail_ProdType, ");}
      if(prod_TaskDetail.TaskDetail_PlanBegin_IsChanged){sbParameter.Append("TaskDetail_PlanBegin=@TaskDetail_PlanBegin, ");}
      if(prod_TaskDetail.TaskDetail_PlanEnd_IsChanged){sbParameter.Append("TaskDetail_PlanEnd=@TaskDetail_PlanEnd, ");}
      if(prod_TaskDetail.TaskDetail_ActEnd_IsChanged){sbParameter.Append("TaskDetail_ActEnd=@TaskDetail_ActEnd, ");}
      if(prod_TaskDetail.Task_FNum_IsChanged){sbParameter.Append("Task_FNum=@Task_FNum, ");}
      if(prod_TaskDetail.Task_Roads_IsChanged){sbParameter.Append("Task_Roads=@Task_Roads, ");}
      if(prod_TaskDetail.Task_ProdCode_IsChanged){sbParameter.Append("Task_ProdCode=@Task_ProdCode, ");}
      if(prod_TaskDetail.Task_Stat_IsChanged){sbParameter.Append("Task_Stat=@Task_Stat, ");}
      if(prod_TaskDetail.Task_DNum_IsChanged){sbParameter.Append("Task_DNum=@Task_DNum, ");}
      if(prod_TaskDetail.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TaskDetail_ID=@TaskDetail_ID; " );
      string sql=sb.ToString();
         if(prod_TaskDetail.TaskDetail_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_Code))
         {
            idb.AddParameter("@TaskDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Code", prod_TaskDetail.TaskDetail_Code);
         }
          }
         if(prod_TaskDetail.TaskDetail_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_CmdCode))
         {
            idb.AddParameter("@TaskDetail_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_CmdCode", prod_TaskDetail.TaskDetail_CmdCode);
         }
          }
         if(prod_TaskDetail.TaskDetail_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_PartNo))
         {
            idb.AddParameter("@TaskDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartNo", prod_TaskDetail.TaskDetail_PartNo);
         }
          }
         if(prod_TaskDetail.TaskDetail_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_PartName))
         {
            idb.AddParameter("@TaskDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PartName", prod_TaskDetail.TaskDetail_PartName);
         }
          }
         if(prod_TaskDetail.TaskDetail_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_Unit))
         {
            idb.AddParameter("@TaskDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Unit", prod_TaskDetail.TaskDetail_Unit);
         }
          }
         if(prod_TaskDetail.TaskDetail_Num_IsChanged)
         {
         if (prod_TaskDetail.TaskDetail_Num == 0)
         {
            idb.AddParameter("@TaskDetail_Num", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_Num", prod_TaskDetail.TaskDetail_Num);
         }
          }
         if(prod_TaskDetail.TaskDetail_ProdType_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.TaskDetail_ProdType))
         {
            idb.AddParameter("@TaskDetail_ProdType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ProdType", prod_TaskDetail.TaskDetail_ProdType);
         }
          }
         if(prod_TaskDetail.TaskDetail_PlanBegin_IsChanged)
         {
         if (prod_TaskDetail.TaskDetail_PlanBegin == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanBegin", prod_TaskDetail.TaskDetail_PlanBegin);
         }
          }
         if(prod_TaskDetail.TaskDetail_PlanEnd_IsChanged)
         {
         if (prod_TaskDetail.TaskDetail_PlanEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_PlanEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_PlanEnd", prod_TaskDetail.TaskDetail_PlanEnd);
         }
          }
         if(prod_TaskDetail.TaskDetail_ActEnd_IsChanged)
         {
         if (prod_TaskDetail.TaskDetail_ActEnd == DateTime.MinValue)
         {
            idb.AddParameter("@TaskDetail_ActEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TaskDetail_ActEnd", prod_TaskDetail.TaskDetail_ActEnd);
         }
          }
         if(prod_TaskDetail.Task_FNum_IsChanged)
         {
         if (prod_TaskDetail.Task_FNum == 0)
         {
            idb.AddParameter("@Task_FNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_FNum", prod_TaskDetail.Task_FNum);
         }
          }
         if(prod_TaskDetail.Task_Roads_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.Task_Roads))
         {
            idb.AddParameter("@Task_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Roads", prod_TaskDetail.Task_Roads);
         }
          }
         if(prod_TaskDetail.Task_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TaskDetail.Task_ProdCode))
         {
            idb.AddParameter("@Task_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_ProdCode", prod_TaskDetail.Task_ProdCode);
         }
          }
         if(prod_TaskDetail.Task_Stat_IsChanged)
         {
         if (prod_TaskDetail.Task_Stat == 0)
         {
            idb.AddParameter("@Task_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_Stat", prod_TaskDetail.Task_Stat);
         }
          }
         if(prod_TaskDetail.Task_DNum_IsChanged)
         {
         if (prod_TaskDetail.Task_DNum == 0)
         {
            idb.AddParameter("@Task_DNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Task_DNum", prod_TaskDetail.Task_DNum);
         }
          }
         if(prod_TaskDetail.Stat_IsChanged)
         {
         if (prod_TaskDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", prod_TaskDetail.Stat);
         }
          }

         idb.AddParameter("@TaskDetail_ID", prod_TaskDetail.TaskDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除生产任务细表 Prod_TaskDetail对象(即:一条记录
      /// </summary>
      public int Delete(Int64 taskDetail_ID)
      {
         string sql = "DELETE Prod_TaskDetail WHERE 1=1  AND TaskDetail_ID=@TaskDetail_ID ";
         idb.AddParameter("@TaskDetail_ID", taskDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的生产任务细表 Prod_TaskDetail对象(即:一条记录
      /// </summary>
      public Prod_TaskDetail GetByKey(Int64 taskDetail_ID)
      {
         Prod_TaskDetail prod_TaskDetail = new Prod_TaskDetail();
         string sql = "SELECT  TaskDetail_ID,TaskDetail_Code,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,TaskDetail_Unit,TaskDetail_Num,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_DNum,Stat FROM Prod_TaskDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TaskDetail_ID=@TaskDetail_ID ";
         idb.AddParameter("@TaskDetail_ID", taskDetail_ID);

         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TaskDetail_ID"] != DBNull.Value) prod_TaskDetail.TaskDetail_ID = Convert.ToInt64(dr["TaskDetail_ID"]);
            if (dr["TaskDetail_Code"] != DBNull.Value) prod_TaskDetail.TaskDetail_Code = Convert.ToString(dr["TaskDetail_Code"]);
            if (dr["TaskDetail_CmdCode"] != DBNull.Value) prod_TaskDetail.TaskDetail_CmdCode = Convert.ToString(dr["TaskDetail_CmdCode"]);
            if (dr["TaskDetail_PartNo"] != DBNull.Value) prod_TaskDetail.TaskDetail_PartNo = Convert.ToString(dr["TaskDetail_PartNo"]);
            if (dr["TaskDetail_PartName"] != DBNull.Value) prod_TaskDetail.TaskDetail_PartName = Convert.ToString(dr["TaskDetail_PartName"]);
            if (dr["TaskDetail_Unit"] != DBNull.Value) prod_TaskDetail.TaskDetail_Unit = Convert.ToString(dr["TaskDetail_Unit"]);
            if (dr["TaskDetail_Num"] != DBNull.Value) prod_TaskDetail.TaskDetail_Num = Convert.ToInt32(dr["TaskDetail_Num"]);
            if (dr["TaskDetail_ProdType"] != DBNull.Value) prod_TaskDetail.TaskDetail_ProdType = Convert.ToString(dr["TaskDetail_ProdType"]);
            if (dr["TaskDetail_PlanBegin"] != DBNull.Value) prod_TaskDetail.TaskDetail_PlanBegin = Convert.ToDateTime(dr["TaskDetail_PlanBegin"]);
            if (dr["TaskDetail_PlanEnd"] != DBNull.Value) prod_TaskDetail.TaskDetail_PlanEnd = Convert.ToDateTime(dr["TaskDetail_PlanEnd"]);
            if (dr["TaskDetail_ActEnd"] != DBNull.Value) prod_TaskDetail.TaskDetail_ActEnd = Convert.ToDateTime(dr["TaskDetail_ActEnd"]);
            if (dr["Task_FNum"] != DBNull.Value) prod_TaskDetail.Task_FNum = Convert.ToInt32(dr["Task_FNum"]);
            if (dr["Task_Roads"] != DBNull.Value) prod_TaskDetail.Task_Roads = Convert.ToString(dr["Task_Roads"]);
            if (dr["Task_ProdCode"] != DBNull.Value) prod_TaskDetail.Task_ProdCode = Convert.ToString(dr["Task_ProdCode"]);
            if (dr["Task_Stat"] != DBNull.Value) prod_TaskDetail.Task_Stat = Convert.ToInt32(dr["Task_Stat"]);
            if (dr["Task_DNum"] != DBNull.Value) prod_TaskDetail.Task_DNum = Convert.ToInt32(dr["Task_DNum"]);
            if (dr["Stat"] != DBNull.Value) prod_TaskDetail.Stat = Convert.ToInt32(dr["Stat"]);
         }
          dr.Close(); 
         return prod_TaskDetail;
      }
      /// <summary>
      /// 获取指定的生产任务细表 Prod_TaskDetail对象集合
      /// </summary>
      public List<Prod_TaskDetail> GetListByWhere(string strCondition)
      {
         List<Prod_TaskDetail> ret = new List<Prod_TaskDetail>();
         string sql = "SELECT  TaskDetail_ID,TaskDetail_Code,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,TaskDetail_Unit,TaskDetail_Num,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_DNum,Stat FROM Prod_TaskDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_TaskDetail prod_TaskDetail = new Prod_TaskDetail();
            if (dr["TaskDetail_ID"] != DBNull.Value) prod_TaskDetail.TaskDetail_ID = Convert.ToInt64(dr["TaskDetail_ID"]);
            if (dr["TaskDetail_Code"] != DBNull.Value) prod_TaskDetail.TaskDetail_Code = Convert.ToString(dr["TaskDetail_Code"]);
            if (dr["TaskDetail_CmdCode"] != DBNull.Value) prod_TaskDetail.TaskDetail_CmdCode = Convert.ToString(dr["TaskDetail_CmdCode"]);
            if (dr["TaskDetail_PartNo"] != DBNull.Value) prod_TaskDetail.TaskDetail_PartNo = Convert.ToString(dr["TaskDetail_PartNo"]);
            if (dr["TaskDetail_PartName"] != DBNull.Value) prod_TaskDetail.TaskDetail_PartName = Convert.ToString(dr["TaskDetail_PartName"]);
            if (dr["TaskDetail_Unit"] != DBNull.Value) prod_TaskDetail.TaskDetail_Unit = Convert.ToString(dr["TaskDetail_Unit"]);
            if (dr["TaskDetail_Num"] != DBNull.Value) prod_TaskDetail.TaskDetail_Num = Convert.ToInt32(dr["TaskDetail_Num"]);
            if (dr["TaskDetail_ProdType"] != DBNull.Value) prod_TaskDetail.TaskDetail_ProdType = Convert.ToString(dr["TaskDetail_ProdType"]);
            if (dr["TaskDetail_PlanBegin"] != DBNull.Value) prod_TaskDetail.TaskDetail_PlanBegin = Convert.ToDateTime(dr["TaskDetail_PlanBegin"]);
            if (dr["TaskDetail_PlanEnd"] != DBNull.Value) prod_TaskDetail.TaskDetail_PlanEnd = Convert.ToDateTime(dr["TaskDetail_PlanEnd"]);
            if (dr["TaskDetail_ActEnd"] != DBNull.Value) prod_TaskDetail.TaskDetail_ActEnd = Convert.ToDateTime(dr["TaskDetail_ActEnd"]);
            if (dr["Task_FNum"] != DBNull.Value) prod_TaskDetail.Task_FNum = Convert.ToInt32(dr["Task_FNum"]);
            if (dr["Task_Roads"] != DBNull.Value) prod_TaskDetail.Task_Roads = Convert.ToString(dr["Task_Roads"]);
            if (dr["Task_ProdCode"] != DBNull.Value) prod_TaskDetail.Task_ProdCode = Convert.ToString(dr["Task_ProdCode"]);
            if (dr["Task_Stat"] != DBNull.Value) prod_TaskDetail.Task_Stat = Convert.ToInt32(dr["Task_Stat"]);
            if (dr["Task_DNum"] != DBNull.Value) prod_TaskDetail.Task_DNum = Convert.ToInt32(dr["Task_DNum"]);
            if (dr["Stat"] != DBNull.Value) prod_TaskDetail.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_TaskDetail);
         }
          dr.Close(); 
         return ret;
      }
      /// <summary>
      /// 获取所有的生产任务细表 Prod_TaskDetail对象(即:一条记录
      /// </summary>
      public List<Prod_TaskDetail> GetAll()
      {
         List<Prod_TaskDetail> ret = new List<Prod_TaskDetail>();
         string sql = "SELECT  TaskDetail_ID,TaskDetail_Code,TaskDetail_CmdCode,TaskDetail_PartNo,TaskDetail_PartName,TaskDetail_Unit,TaskDetail_Num,TaskDetail_ProdType,TaskDetail_PlanBegin,TaskDetail_PlanEnd,TaskDetail_ActEnd,Task_FNum,Task_Roads,Task_ProdCode,Task_Stat,Task_DNum,Stat FROM Prod_TaskDetail where 1=1 AND ((Stat is null) or (Stat=0) ) ";
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_TaskDetail prod_TaskDetail = new Prod_TaskDetail();
            if (dr["TaskDetail_ID"] != DBNull.Value) prod_TaskDetail.TaskDetail_ID = Convert.ToInt64(dr["TaskDetail_ID"]);
            if (dr["TaskDetail_Code"] != DBNull.Value) prod_TaskDetail.TaskDetail_Code = Convert.ToString(dr["TaskDetail_Code"]);
            if (dr["TaskDetail_CmdCode"] != DBNull.Value) prod_TaskDetail.TaskDetail_CmdCode = Convert.ToString(dr["TaskDetail_CmdCode"]);
            if (dr["TaskDetail_PartNo"] != DBNull.Value) prod_TaskDetail.TaskDetail_PartNo = Convert.ToString(dr["TaskDetail_PartNo"]);
            if (dr["TaskDetail_PartName"] != DBNull.Value) prod_TaskDetail.TaskDetail_PartName = Convert.ToString(dr["TaskDetail_PartName"]);
            if (dr["TaskDetail_Unit"] != DBNull.Value) prod_TaskDetail.TaskDetail_Unit = Convert.ToString(dr["TaskDetail_Unit"]);
            if (dr["TaskDetail_Num"] != DBNull.Value) prod_TaskDetail.TaskDetail_Num = Convert.ToInt32(dr["TaskDetail_Num"]);
            if (dr["TaskDetail_ProdType"] != DBNull.Value) prod_TaskDetail.TaskDetail_ProdType = Convert.ToString(dr["TaskDetail_ProdType"]);
            if (dr["TaskDetail_PlanBegin"] != DBNull.Value) prod_TaskDetail.TaskDetail_PlanBegin = Convert.ToDateTime(dr["TaskDetail_PlanBegin"]);
            if (dr["TaskDetail_PlanEnd"] != DBNull.Value) prod_TaskDetail.TaskDetail_PlanEnd = Convert.ToDateTime(dr["TaskDetail_PlanEnd"]);
            if (dr["TaskDetail_ActEnd"] != DBNull.Value) prod_TaskDetail.TaskDetail_ActEnd = Convert.ToDateTime(dr["TaskDetail_ActEnd"]);
            if (dr["Task_FNum"] != DBNull.Value) prod_TaskDetail.Task_FNum = Convert.ToInt32(dr["Task_FNum"]);
            if (dr["Task_Roads"] != DBNull.Value) prod_TaskDetail.Task_Roads = Convert.ToString(dr["Task_Roads"]);
            if (dr["Task_ProdCode"] != DBNull.Value) prod_TaskDetail.Task_ProdCode = Convert.ToString(dr["Task_ProdCode"]);
            if (dr["Task_Stat"] != DBNull.Value) prod_TaskDetail.Task_Stat = Convert.ToInt32(dr["Task_Stat"]);
            if (dr["Task_DNum"] != DBNull.Value) prod_TaskDetail.Task_DNum = Convert.ToInt32(dr["Task_DNum"]);
            if (dr["Stat"] != DBNull.Value) prod_TaskDetail.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_TaskDetail);
         }
          dr.Close(); 
         return ret;
      }
   }
}
