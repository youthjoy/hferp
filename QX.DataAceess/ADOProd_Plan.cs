using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;

namespace QX.DataAceess
{
   /// <summary>
   /// 生产计划表(下达)
   /// </summary>
   [Serializable]
   public partial class ADOProd_Plan
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产计划表(下达) Prod_Plan对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Plan prod_Plan)
      {
         string sql = "INSERT INTO Prod_Plan (Plan_ID,Plan_Code,Plan_Task_Code,Plan_TaskDetail_Code,Plan_Name,Plan_CmdDetail_Code,Plan_Cmd_Code,Plan_PartCode,Plan_PartName,Plan_Unit,Plan_DNum,Plan_Begin,Plan_End,Plan_Roads,Plan_ProdCodes,Plan_Project,Plan_Owner,Plan_Date,Plan_Bak,Plan_Stat,Stat) VALUES (@Plan_ID,@Plan_Code,@Plan_Task_Code,@Plan_TaskDetail_Code,@Plan_Name,@Plan_CmdDetail_Code,@Plan_Cmd_Code,@Plan_PartCode,@Plan_PartName,@Plan_Unit,@Plan_DNum,@Plan_Begin,@Plan_End,@Plan_Roads,@Plan_ProdCodes,@Plan_Project,@Plan_Owner,@Plan_Date,@Plan_Bak,@Plan_Stat,@Stat)";
         if (string.IsNullOrEmpty(prod_Plan.Plan_Code))
         {
            idb.AddParameter("@Plan_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Code", prod_Plan.Plan_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Task_Code))
         {
            idb.AddParameter("@Plan_Task_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Task_Code", prod_Plan.Plan_Task_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_TaskDetail_Code))
         {
            idb.AddParameter("@Plan_TaskDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_TaskDetail_Code", prod_Plan.Plan_TaskDetail_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Name))
         {
            idb.AddParameter("@Plan_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Name", prod_Plan.Plan_Name);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_CmdDetail_Code))
         {
            idb.AddParameter("@Plan_CmdDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_CmdDetail_Code", prod_Plan.Plan_CmdDetail_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Cmd_Code))
         {
            idb.AddParameter("@Plan_Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Cmd_Code", prod_Plan.Plan_Cmd_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_PartCode))
         {
            idb.AddParameter("@Plan_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_PartCode", prod_Plan.Plan_PartCode);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_PartName))
         {
            idb.AddParameter("@Plan_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_PartName", prod_Plan.Plan_PartName);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Unit))
         {
            idb.AddParameter("@Plan_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Unit", prod_Plan.Plan_Unit);
         }
         if (prod_Plan.Plan_DNum == 0)
         {
            idb.AddParameter("@Plan_DNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_DNum", prod_Plan.Plan_DNum);
         }
         if (prod_Plan.Plan_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Begin", prod_Plan.Plan_Begin);
         }
         if (prod_Plan.Plan_End == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_End", prod_Plan.Plan_End);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Roads))
         {
            idb.AddParameter("@Plan_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Roads", prod_Plan.Plan_Roads);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_ProdCodes))
         {
            idb.AddParameter("@Plan_ProdCodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_ProdCodes", prod_Plan.Plan_ProdCodes);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Project))
         {
            idb.AddParameter("@Plan_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Project", prod_Plan.Plan_Project);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Owner))
         {
            idb.AddParameter("@Plan_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Owner", prod_Plan.Plan_Owner);
         }
         if (prod_Plan.Plan_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Date", prod_Plan.Plan_Date);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Bak))
         {
            idb.AddParameter("@Plan_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Bak", prod_Plan.Plan_Bak);
         }
         if (prod_Plan.Plan_Stat == 0)
         {
            idb.AddParameter("@Plan_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Stat", prod_Plan.Plan_Stat);
         }
         if (prod_Plan.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Plan.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加生产计划表(下达) Prod_Plan对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Plan prod_Plan)
      {
         string sql = "INSERT INTO Prod_Plan (Plan_ID,Plan_Code,Plan_Task_Code,Plan_TaskDetail_Code,Plan_Name,Plan_CmdDetail_Code,Plan_Cmd_Code,Plan_PartCode,Plan_PartName,Plan_Unit,Plan_DNum,Plan_Begin,Plan_End,Plan_Roads,Plan_ProdCodes,Plan_Project,Plan_Owner,Plan_Date,Plan_Bak,Plan_Stat,Stat) VALUES (@Plan_ID,@Plan_Code,@Plan_Task_Code,@Plan_TaskDetail_Code,@Plan_Name,@Plan_CmdDetail_Code,@Plan_Cmd_Code,@Plan_PartCode,@Plan_PartName,@Plan_Unit,@Plan_DNum,@Plan_Begin,@Plan_End,@Plan_Roads,@Plan_ProdCodes,@Plan_Project,@Plan_Owner,@Plan_Date,@Plan_Bak,@Plan_Stat,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Plan.Plan_Code))
         {
            idb.AddParameter("@Plan_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Code", prod_Plan.Plan_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Task_Code))
         {
            idb.AddParameter("@Plan_Task_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Task_Code", prod_Plan.Plan_Task_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_TaskDetail_Code))
         {
            idb.AddParameter("@Plan_TaskDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_TaskDetail_Code", prod_Plan.Plan_TaskDetail_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Name))
         {
            idb.AddParameter("@Plan_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Name", prod_Plan.Plan_Name);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_CmdDetail_Code))
         {
            idb.AddParameter("@Plan_CmdDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_CmdDetail_Code", prod_Plan.Plan_CmdDetail_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Cmd_Code))
         {
            idb.AddParameter("@Plan_Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Cmd_Code", prod_Plan.Plan_Cmd_Code);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_PartCode))
         {
            idb.AddParameter("@Plan_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_PartCode", prod_Plan.Plan_PartCode);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_PartName))
         {
            idb.AddParameter("@Plan_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_PartName", prod_Plan.Plan_PartName);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Unit))
         {
            idb.AddParameter("@Plan_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Unit", prod_Plan.Plan_Unit);
         }
         if (prod_Plan.Plan_DNum == 0)
         {
            idb.AddParameter("@Plan_DNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_DNum", prod_Plan.Plan_DNum);
         }
         if (prod_Plan.Plan_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Begin", prod_Plan.Plan_Begin);
         }
         if (prod_Plan.Plan_End == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_End", prod_Plan.Plan_End);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Roads))
         {
            idb.AddParameter("@Plan_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Roads", prod_Plan.Plan_Roads);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_ProdCodes))
         {
            idb.AddParameter("@Plan_ProdCodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_ProdCodes", prod_Plan.Plan_ProdCodes);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Project))
         {
            idb.AddParameter("@Plan_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Project", prod_Plan.Plan_Project);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Owner))
         {
            idb.AddParameter("@Plan_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Owner", prod_Plan.Plan_Owner);
         }
         if (prod_Plan.Plan_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Date", prod_Plan.Plan_Date);
         }
         if (string.IsNullOrEmpty(prod_Plan.Plan_Bak))
         {
            idb.AddParameter("@Plan_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Bak", prod_Plan.Plan_Bak);
         }
         if (prod_Plan.Plan_Stat == 0)
         {
            idb.AddParameter("@Plan_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Stat", prod_Plan.Plan_Stat);
         }
         if (prod_Plan.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Plan.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 更新生产计划表(下达) Prod_Plan对象(即:一条记录
      /// </summary>
      public int Update(Prod_Plan prod_Plan)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Plan       SET ");
            if(prod_Plan.Plan_Code_IsChanged){sbParameter.Append("Plan_Code=@Plan_Code, ");}
      if(prod_Plan.Plan_Task_Code_IsChanged){sbParameter.Append("Plan_Task_Code=@Plan_Task_Code, ");}
      if(prod_Plan.Plan_TaskDetail_Code_IsChanged){sbParameter.Append("Plan_TaskDetail_Code=@Plan_TaskDetail_Code, ");}
      if(prod_Plan.Plan_Name_IsChanged){sbParameter.Append("Plan_Name=@Plan_Name, ");}
      if(prod_Plan.Plan_CmdDetail_Code_IsChanged){sbParameter.Append("Plan_CmdDetail_Code=@Plan_CmdDetail_Code, ");}
      if(prod_Plan.Plan_Cmd_Code_IsChanged){sbParameter.Append("Plan_Cmd_Code=@Plan_Cmd_Code, ");}
      if(prod_Plan.Plan_PartCode_IsChanged){sbParameter.Append("Plan_PartCode=@Plan_PartCode, ");}
      if(prod_Plan.Plan_PartName_IsChanged){sbParameter.Append("Plan_PartName=@Plan_PartName, ");}
      if(prod_Plan.Plan_Unit_IsChanged){sbParameter.Append("Plan_Unit=@Plan_Unit, ");}
      if(prod_Plan.Plan_DNum_IsChanged){sbParameter.Append("Plan_DNum=@Plan_DNum, ");}
      if(prod_Plan.Plan_Begin_IsChanged){sbParameter.Append("Plan_Begin=@Plan_Begin, ");}
      if(prod_Plan.Plan_End_IsChanged){sbParameter.Append("Plan_End=@Plan_End, ");}
      if(prod_Plan.Plan_Roads_IsChanged){sbParameter.Append("Plan_Roads=@Plan_Roads, ");}
      if(prod_Plan.Plan_ProdCodes_IsChanged){sbParameter.Append("Plan_ProdCodes=@Plan_ProdCodes, ");}
      if(prod_Plan.Plan_Project_IsChanged){sbParameter.Append("Plan_Project=@Plan_Project, ");}
      if(prod_Plan.Plan_Owner_IsChanged){sbParameter.Append("Plan_Owner=@Plan_Owner, ");}
      if(prod_Plan.Plan_Date_IsChanged){sbParameter.Append("Plan_Date=@Plan_Date, ");}
      if(prod_Plan.Plan_Bak_IsChanged){sbParameter.Append("Plan_Bak=@Plan_Bak, ");}
      if(prod_Plan.Plan_Stat_IsChanged){sbParameter.Append("Plan_Stat=@Plan_Stat, ");}
      if(prod_Plan.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Plan_ID=@Plan_ID; " );
      string sql=sb.ToString();
         if(prod_Plan.Plan_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Code))
         {
            idb.AddParameter("@Plan_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Code", prod_Plan.Plan_Code);
         }
          }
         if(prod_Plan.Plan_Task_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Task_Code))
         {
            idb.AddParameter("@Plan_Task_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Task_Code", prod_Plan.Plan_Task_Code);
         }
          }
         if(prod_Plan.Plan_TaskDetail_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_TaskDetail_Code))
         {
            idb.AddParameter("@Plan_TaskDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_TaskDetail_Code", prod_Plan.Plan_TaskDetail_Code);
         }
          }
         if(prod_Plan.Plan_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Name))
         {
            idb.AddParameter("@Plan_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Name", prod_Plan.Plan_Name);
         }
          }
         if(prod_Plan.Plan_CmdDetail_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_CmdDetail_Code))
         {
            idb.AddParameter("@Plan_CmdDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_CmdDetail_Code", prod_Plan.Plan_CmdDetail_Code);
         }
          }
         if(prod_Plan.Plan_Cmd_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Cmd_Code))
         {
            idb.AddParameter("@Plan_Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Cmd_Code", prod_Plan.Plan_Cmd_Code);
         }
          }
         if(prod_Plan.Plan_PartCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_PartCode))
         {
            idb.AddParameter("@Plan_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_PartCode", prod_Plan.Plan_PartCode);
         }
          }
         if(prod_Plan.Plan_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_PartName))
         {
            idb.AddParameter("@Plan_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_PartName", prod_Plan.Plan_PartName);
         }
          }
         if(prod_Plan.Plan_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Unit))
         {
            idb.AddParameter("@Plan_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Unit", prod_Plan.Plan_Unit);
         }
          }
         if(prod_Plan.Plan_DNum_IsChanged)
         {
         if (prod_Plan.Plan_DNum == 0)
         {
            idb.AddParameter("@Plan_DNum", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_DNum", prod_Plan.Plan_DNum);
         }
          }
         if(prod_Plan.Plan_Begin_IsChanged)
         {
         if (prod_Plan.Plan_Begin == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_Begin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Begin", prod_Plan.Plan_Begin);
         }
          }
         if(prod_Plan.Plan_End_IsChanged)
         {
         if (prod_Plan.Plan_End == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_End", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_End", prod_Plan.Plan_End);
         }
          }
         if(prod_Plan.Plan_Roads_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Roads))
         {
            idb.AddParameter("@Plan_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Roads", prod_Plan.Plan_Roads);
         }
          }
         if(prod_Plan.Plan_ProdCodes_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_ProdCodes))
         {
            idb.AddParameter("@Plan_ProdCodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_ProdCodes", prod_Plan.Plan_ProdCodes);
         }
          }
         if(prod_Plan.Plan_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Project))
         {
            idb.AddParameter("@Plan_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Project", prod_Plan.Plan_Project);
         }
          }
         if(prod_Plan.Plan_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Owner))
         {
            idb.AddParameter("@Plan_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Owner", prod_Plan.Plan_Owner);
         }
          }
         if(prod_Plan.Plan_Date_IsChanged)
         {
         if (prod_Plan.Plan_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Plan_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Date", prod_Plan.Plan_Date);
         }
          }
         if(prod_Plan.Plan_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Plan.Plan_Bak))
         {
            idb.AddParameter("@Plan_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Bak", prod_Plan.Plan_Bak);
         }
          }
         if(prod_Plan.Plan_Stat_IsChanged)
         {
         if (prod_Plan.Plan_Stat == 0)
         {
            idb.AddParameter("@Plan_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Plan_Stat", prod_Plan.Plan_Stat);
         }
          }
         if(prod_Plan.Stat_IsChanged)
         {
         if (prod_Plan.Stat == 0)
         {
            idb.AddParameter("@Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Plan.Stat);
         }
          }

         idb.AddParameter("@Plan_ID", prod_Plan.Plan_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除生产计划表(下达) Prod_Plan对象(即:一条记录
      /// </summary>
      public int Delete(Int64 plan_ID)
      {
         string sql = "DELETE Prod_Plan WHERE 1=1  AND Plan_ID=@Plan_ID ";
         idb.AddParameter("@Plan_ID", plan_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的生产计划表(下达) Prod_Plan对象(即:一条记录
      /// </summary>
      public Prod_Plan GetByKey(Int64 plan_ID)
      {
         Prod_Plan prod_Plan = new Prod_Plan();
         string sql = "SELECT  Plan_ID,Plan_Code,Plan_Task_Code,Plan_TaskDetail_Code,Plan_Name,Plan_CmdDetail_Code,Plan_Cmd_Code,Plan_PartCode,Plan_PartName,Plan_Unit,Plan_DNum,Plan_Begin,Plan_End,Plan_Roads,Plan_ProdCodes,Plan_Project,Plan_Owner,Plan_Date,Plan_Bak,Plan_Stat,Stat FROM Prod_Plan WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Plan_ID=@Plan_ID ";
         idb.AddParameter("@Plan_ID", plan_ID);

         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Plan_ID"] != DBNull.Value) prod_Plan.Plan_ID = Convert.ToInt64(dr["Plan_ID"]);
            if (dr["Plan_Code"] != DBNull.Value) prod_Plan.Plan_Code = Convert.ToString(dr["Plan_Code"]);
            if (dr["Plan_Task_Code"] != DBNull.Value) prod_Plan.Plan_Task_Code = Convert.ToString(dr["Plan_Task_Code"]);
            if (dr["Plan_TaskDetail_Code"] != DBNull.Value) prod_Plan.Plan_TaskDetail_Code = Convert.ToString(dr["Plan_TaskDetail_Code"]);
            if (dr["Plan_Name"] != DBNull.Value) prod_Plan.Plan_Name = Convert.ToString(dr["Plan_Name"]);
            if (dr["Plan_CmdDetail_Code"] != DBNull.Value) prod_Plan.Plan_CmdDetail_Code = Convert.ToString(dr["Plan_CmdDetail_Code"]);
            if (dr["Plan_Cmd_Code"] != DBNull.Value) prod_Plan.Plan_Cmd_Code = Convert.ToString(dr["Plan_Cmd_Code"]);
            if (dr["Plan_PartCode"] != DBNull.Value) prod_Plan.Plan_PartCode = Convert.ToString(dr["Plan_PartCode"]);
            if (dr["Plan_PartName"] != DBNull.Value) prod_Plan.Plan_PartName = Convert.ToString(dr["Plan_PartName"]);
            if (dr["Plan_Unit"] != DBNull.Value) prod_Plan.Plan_Unit = Convert.ToString(dr["Plan_Unit"]);
            if (dr["Plan_DNum"] != DBNull.Value) prod_Plan.Plan_DNum = Convert.ToInt32(dr["Plan_DNum"]);
            if (dr["Plan_Begin"] != DBNull.Value) prod_Plan.Plan_Begin = Convert.ToDateTime(dr["Plan_Begin"]);
            if (dr["Plan_End"] != DBNull.Value) prod_Plan.Plan_End = Convert.ToDateTime(dr["Plan_End"]);
            if (dr["Plan_Roads"] != DBNull.Value) prod_Plan.Plan_Roads = Convert.ToString(dr["Plan_Roads"]);
            if (dr["Plan_ProdCodes"] != DBNull.Value) prod_Plan.Plan_ProdCodes = Convert.ToString(dr["Plan_ProdCodes"]);
            if (dr["Plan_Project"] != DBNull.Value) prod_Plan.Plan_Project = Convert.ToString(dr["Plan_Project"]);
            if (dr["Plan_Owner"] != DBNull.Value) prod_Plan.Plan_Owner = Convert.ToString(dr["Plan_Owner"]);
            if (dr["Plan_Date"] != DBNull.Value) prod_Plan.Plan_Date = Convert.ToDateTime(dr["Plan_Date"]);
            if (dr["Plan_Bak"] != DBNull.Value) prod_Plan.Plan_Bak = Convert.ToString(dr["Plan_Bak"]);
            if (dr["Plan_Stat"] != DBNull.Value) prod_Plan.Plan_Stat = Convert.ToInt32(dr["Plan_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_Plan.Stat = Convert.ToInt32(dr["Stat"]);
         }
          dr.Close(); 
         return prod_Plan;
      }
      /// <summary>
      /// 获取指定的生产计划表(下达) Prod_Plan对象集合
      /// </summary>
      public List<Prod_Plan> GetListByWhere(string strCondition)
      {
         List<Prod_Plan> ret = new List<Prod_Plan>();
         string sql = "SELECT  Plan_ID,Plan_Code,Plan_Task_Code,Plan_TaskDetail_Code,Plan_Name,Plan_CmdDetail_Code,Plan_Cmd_Code,Plan_PartCode,Plan_PartName,Plan_Unit,Plan_DNum,Plan_Begin,Plan_End,Plan_Roads,Plan_ProdCodes,Plan_Project,Plan_Owner,Plan_Date,Plan_Bak,Plan_Stat,Stat FROM Prod_Plan WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Plan prod_Plan = new Prod_Plan();
            if (dr["Plan_ID"] != DBNull.Value) prod_Plan.Plan_ID = Convert.ToInt64(dr["Plan_ID"]);
            if (dr["Plan_Code"] != DBNull.Value) prod_Plan.Plan_Code = Convert.ToString(dr["Plan_Code"]);
            if (dr["Plan_Task_Code"] != DBNull.Value) prod_Plan.Plan_Task_Code = Convert.ToString(dr["Plan_Task_Code"]);
            if (dr["Plan_TaskDetail_Code"] != DBNull.Value) prod_Plan.Plan_TaskDetail_Code = Convert.ToString(dr["Plan_TaskDetail_Code"]);
            if (dr["Plan_Name"] != DBNull.Value) prod_Plan.Plan_Name = Convert.ToString(dr["Plan_Name"]);
            if (dr["Plan_CmdDetail_Code"] != DBNull.Value) prod_Plan.Plan_CmdDetail_Code = Convert.ToString(dr["Plan_CmdDetail_Code"]);
            if (dr["Plan_Cmd_Code"] != DBNull.Value) prod_Plan.Plan_Cmd_Code = Convert.ToString(dr["Plan_Cmd_Code"]);
            if (dr["Plan_PartCode"] != DBNull.Value) prod_Plan.Plan_PartCode = Convert.ToString(dr["Plan_PartCode"]);
            if (dr["Plan_PartName"] != DBNull.Value) prod_Plan.Plan_PartName = Convert.ToString(dr["Plan_PartName"]);
            if (dr["Plan_Unit"] != DBNull.Value) prod_Plan.Plan_Unit = Convert.ToString(dr["Plan_Unit"]);
            if (dr["Plan_DNum"] != DBNull.Value) prod_Plan.Plan_DNum = Convert.ToInt32(dr["Plan_DNum"]);
            if (dr["Plan_Begin"] != DBNull.Value) prod_Plan.Plan_Begin = Convert.ToDateTime(dr["Plan_Begin"]);
            if (dr["Plan_End"] != DBNull.Value) prod_Plan.Plan_End = Convert.ToDateTime(dr["Plan_End"]);
            if (dr["Plan_Roads"] != DBNull.Value) prod_Plan.Plan_Roads = Convert.ToString(dr["Plan_Roads"]);
            if (dr["Plan_ProdCodes"] != DBNull.Value) prod_Plan.Plan_ProdCodes = Convert.ToString(dr["Plan_ProdCodes"]);
            if (dr["Plan_Project"] != DBNull.Value) prod_Plan.Plan_Project = Convert.ToString(dr["Plan_Project"]);
            if (dr["Plan_Owner"] != DBNull.Value) prod_Plan.Plan_Owner = Convert.ToString(dr["Plan_Owner"]);
            if (dr["Plan_Date"] != DBNull.Value) prod_Plan.Plan_Date = Convert.ToDateTime(dr["Plan_Date"]);
            if (dr["Plan_Bak"] != DBNull.Value) prod_Plan.Plan_Bak = Convert.ToString(dr["Plan_Bak"]);
            if (dr["Plan_Stat"] != DBNull.Value) prod_Plan.Plan_Stat = Convert.ToInt32(dr["Plan_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_Plan.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_Plan);
         }
          dr.Close(); 
         return ret;
      }
      /// <summary>
      /// 获取所有的生产计划表(下达) Prod_Plan对象(即:一条记录
      /// </summary>
      public List<Prod_Plan> GetAll()
      {
         List<Prod_Plan> ret = new List<Prod_Plan>();
         string sql = "SELECT  Plan_ID,Plan_Code,Plan_Task_Code,Plan_TaskDetail_Code,Plan_Name,Plan_CmdDetail_Code,Plan_Cmd_Code,Plan_PartCode,Plan_PartName,Plan_Unit,Plan_DNum,Plan_Begin,Plan_End,Plan_Roads,Plan_ProdCodes,Plan_Project,Plan_Owner,Plan_Date,Plan_Bak,Plan_Stat,Stat FROM Prod_Plan where 1=1 AND ((Stat is null) or (Stat=0) ) ";
         SqlDataReader dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Plan prod_Plan = new Prod_Plan();
            if (dr["Plan_ID"] != DBNull.Value) prod_Plan.Plan_ID = Convert.ToInt64(dr["Plan_ID"]);
            if (dr["Plan_Code"] != DBNull.Value) prod_Plan.Plan_Code = Convert.ToString(dr["Plan_Code"]);
            if (dr["Plan_Task_Code"] != DBNull.Value) prod_Plan.Plan_Task_Code = Convert.ToString(dr["Plan_Task_Code"]);
            if (dr["Plan_TaskDetail_Code"] != DBNull.Value) prod_Plan.Plan_TaskDetail_Code = Convert.ToString(dr["Plan_TaskDetail_Code"]);
            if (dr["Plan_Name"] != DBNull.Value) prod_Plan.Plan_Name = Convert.ToString(dr["Plan_Name"]);
            if (dr["Plan_CmdDetail_Code"] != DBNull.Value) prod_Plan.Plan_CmdDetail_Code = Convert.ToString(dr["Plan_CmdDetail_Code"]);
            if (dr["Plan_Cmd_Code"] != DBNull.Value) prod_Plan.Plan_Cmd_Code = Convert.ToString(dr["Plan_Cmd_Code"]);
            if (dr["Plan_PartCode"] != DBNull.Value) prod_Plan.Plan_PartCode = Convert.ToString(dr["Plan_PartCode"]);
            if (dr["Plan_PartName"] != DBNull.Value) prod_Plan.Plan_PartName = Convert.ToString(dr["Plan_PartName"]);
            if (dr["Plan_Unit"] != DBNull.Value) prod_Plan.Plan_Unit = Convert.ToString(dr["Plan_Unit"]);
            if (dr["Plan_DNum"] != DBNull.Value) prod_Plan.Plan_DNum = Convert.ToInt32(dr["Plan_DNum"]);
            if (dr["Plan_Begin"] != DBNull.Value) prod_Plan.Plan_Begin = Convert.ToDateTime(dr["Plan_Begin"]);
            if (dr["Plan_End"] != DBNull.Value) prod_Plan.Plan_End = Convert.ToDateTime(dr["Plan_End"]);
            if (dr["Plan_Roads"] != DBNull.Value) prod_Plan.Plan_Roads = Convert.ToString(dr["Plan_Roads"]);
            if (dr["Plan_ProdCodes"] != DBNull.Value) prod_Plan.Plan_ProdCodes = Convert.ToString(dr["Plan_ProdCodes"]);
            if (dr["Plan_Project"] != DBNull.Value) prod_Plan.Plan_Project = Convert.ToString(dr["Plan_Project"]);
            if (dr["Plan_Owner"] != DBNull.Value) prod_Plan.Plan_Owner = Convert.ToString(dr["Plan_Owner"]);
            if (dr["Plan_Date"] != DBNull.Value) prod_Plan.Plan_Date = Convert.ToDateTime(dr["Plan_Date"]);
            if (dr["Plan_Bak"] != DBNull.Value) prod_Plan.Plan_Bak = Convert.ToString(dr["Plan_Bak"]);
            if (dr["Plan_Stat"] != DBNull.Value) prod_Plan.Plan_Stat = Convert.ToInt32(dr["Plan_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_Plan.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_Plan);
         }
          dr.Close(); 
         return ret;
      }
   }
}
