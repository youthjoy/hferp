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
   public partial class ADOFailure_Relation
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Failure_Relation对象(即:一条记录)
      /// </summary>
      public int Add(Failure_Relation failure_Relation)
      {
         string sql = "INSERT INTO Failure_Relation (FR_Code,FR_ModuleCode,FR_PlanCode,FR_ProdCode,FR_PartNo,FR_PartName,FR_FailureCode,FR_Stat,FR_IsCurrent,FR_RefCode,Stat,FR_Udef1,FR_Udef2,FR_Udef3,FR_Udef4,FR_Udef5,FR_Udef6,FR_Udef7,FR_Udef8) VALUES (@FR_Code,@FR_ModuleCode,@FR_PlanCode,@FR_ProdCode,@FR_PartNo,@FR_PartName,@FR_FailureCode,@FR_Stat,@FR_IsCurrent,@FR_RefCode,@Stat,@FR_Udef1,@FR_Udef2,@FR_Udef3,@FR_Udef4,@FR_Udef5,@FR_Udef6,@FR_Udef7,@FR_Udef8)";
         if (string.IsNullOrEmpty(failure_Relation.FR_Code))
         {
            idb.AddParameter("@FR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Code", failure_Relation.FR_Code);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_ModuleCode))
         {
            idb.AddParameter("@FR_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_ModuleCode", failure_Relation.FR_ModuleCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_PlanCode))
         {
            idb.AddParameter("@FR_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PlanCode", failure_Relation.FR_PlanCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_ProdCode))
         {
            idb.AddParameter("@FR_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_ProdCode", failure_Relation.FR_ProdCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_PartNo))
         {
            idb.AddParameter("@FR_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PartNo", failure_Relation.FR_PartNo);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_PartName))
         {
            idb.AddParameter("@FR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PartName", failure_Relation.FR_PartName);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_FailureCode))
         {
            idb.AddParameter("@FR_FailureCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_FailureCode", failure_Relation.FR_FailureCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Stat))
         {
            idb.AddParameter("@FR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Stat", failure_Relation.FR_Stat);
         }
         if (failure_Relation.FR_IsCurrent == 0)
         {
            idb.AddParameter("@FR_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@FR_IsCurrent", failure_Relation.FR_IsCurrent);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_RefCode))
         {
            idb.AddParameter("@FR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_RefCode", failure_Relation.FR_RefCode);
         }
         if (failure_Relation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", failure_Relation.Stat);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef1))
         {
            idb.AddParameter("@FR_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef1", failure_Relation.FR_Udef1);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef2))
         {
            idb.AddParameter("@FR_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef2", failure_Relation.FR_Udef2);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef3))
         {
            idb.AddParameter("@FR_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef3", failure_Relation.FR_Udef3);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef4))
         {
            idb.AddParameter("@FR_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef4", failure_Relation.FR_Udef4);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef5))
         {
            idb.AddParameter("@FR_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef5", failure_Relation.FR_Udef5);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef6))
         {
            idb.AddParameter("@FR_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef6", failure_Relation.FR_Udef6);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef7))
         {
            idb.AddParameter("@FR_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef7", failure_Relation.FR_Udef7);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef8))
         {
            idb.AddParameter("@FR_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef8", failure_Relation.FR_Udef8);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Failure_Relation对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Failure_Relation failure_Relation)
      {
         string sql = "INSERT INTO Failure_Relation (FR_Code,FR_ModuleCode,FR_PlanCode,FR_ProdCode,FR_PartNo,FR_PartName,FR_FailureCode,FR_Stat,FR_IsCurrent,FR_RefCode,Stat,FR_Udef1,FR_Udef2,FR_Udef3,FR_Udef4,FR_Udef5,FR_Udef6,FR_Udef7,FR_Udef8) VALUES (@FR_Code,@FR_ModuleCode,@FR_PlanCode,@FR_ProdCode,@FR_PartNo,@FR_PartName,@FR_FailureCode,@FR_Stat,@FR_IsCurrent,@FR_RefCode,@Stat,@FR_Udef1,@FR_Udef2,@FR_Udef3,@FR_Udef4,@FR_Udef5,@FR_Udef6,@FR_Udef7,@FR_Udef8);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(failure_Relation.FR_Code))
         {
            idb.AddParameter("@FR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Code", failure_Relation.FR_Code);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_ModuleCode))
         {
            idb.AddParameter("@FR_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_ModuleCode", failure_Relation.FR_ModuleCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_PlanCode))
         {
            idb.AddParameter("@FR_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PlanCode", failure_Relation.FR_PlanCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_ProdCode))
         {
            idb.AddParameter("@FR_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_ProdCode", failure_Relation.FR_ProdCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_PartNo))
         {
            idb.AddParameter("@FR_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PartNo", failure_Relation.FR_PartNo);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_PartName))
         {
            idb.AddParameter("@FR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PartName", failure_Relation.FR_PartName);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_FailureCode))
         {
            idb.AddParameter("@FR_FailureCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_FailureCode", failure_Relation.FR_FailureCode);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Stat))
         {
            idb.AddParameter("@FR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Stat", failure_Relation.FR_Stat);
         }
         if (failure_Relation.FR_IsCurrent == 0)
         {
            idb.AddParameter("@FR_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@FR_IsCurrent", failure_Relation.FR_IsCurrent);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_RefCode))
         {
            idb.AddParameter("@FR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_RefCode", failure_Relation.FR_RefCode);
         }
         if (failure_Relation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", failure_Relation.Stat);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef1))
         {
            idb.AddParameter("@FR_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef1", failure_Relation.FR_Udef1);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef2))
         {
            idb.AddParameter("@FR_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef2", failure_Relation.FR_Udef2);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef3))
         {
            idb.AddParameter("@FR_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef3", failure_Relation.FR_Udef3);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef4))
         {
            idb.AddParameter("@FR_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef4", failure_Relation.FR_Udef4);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef5))
         {
            idb.AddParameter("@FR_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef5", failure_Relation.FR_Udef5);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef6))
         {
            idb.AddParameter("@FR_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef6", failure_Relation.FR_Udef6);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef7))
         {
            idb.AddParameter("@FR_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef7", failure_Relation.FR_Udef7);
         }
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef8))
         {
            idb.AddParameter("@FR_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef8", failure_Relation.FR_Udef8);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Failure_Relation对象(即:一条记录
      /// </summary>
      public int Update(Failure_Relation failure_Relation)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Failure_Relation       SET ");
            if(failure_Relation.FR_Code_IsChanged){sbParameter.Append("FR_Code=@FR_Code, ");}
      if(failure_Relation.FR_ModuleCode_IsChanged){sbParameter.Append("FR_ModuleCode=@FR_ModuleCode, ");}
      if(failure_Relation.FR_PlanCode_IsChanged){sbParameter.Append("FR_PlanCode=@FR_PlanCode, ");}
      if(failure_Relation.FR_ProdCode_IsChanged){sbParameter.Append("FR_ProdCode=@FR_ProdCode, ");}
      if(failure_Relation.FR_PartNo_IsChanged){sbParameter.Append("FR_PartNo=@FR_PartNo, ");}
      if(failure_Relation.FR_PartName_IsChanged){sbParameter.Append("FR_PartName=@FR_PartName, ");}
      if(failure_Relation.FR_FailureCode_IsChanged){sbParameter.Append("FR_FailureCode=@FR_FailureCode, ");}
      if(failure_Relation.FR_Stat_IsChanged){sbParameter.Append("FR_Stat=@FR_Stat, ");}
      if(failure_Relation.FR_IsCurrent_IsChanged){sbParameter.Append("FR_IsCurrent=@FR_IsCurrent, ");}
      if(failure_Relation.FR_RefCode_IsChanged){sbParameter.Append("FR_RefCode=@FR_RefCode, ");}
      if(failure_Relation.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(failure_Relation.FR_Udef1_IsChanged){sbParameter.Append("FR_Udef1=@FR_Udef1, ");}
      if(failure_Relation.FR_Udef2_IsChanged){sbParameter.Append("FR_Udef2=@FR_Udef2, ");}
      if(failure_Relation.FR_Udef3_IsChanged){sbParameter.Append("FR_Udef3=@FR_Udef3, ");}
      if(failure_Relation.FR_Udef4_IsChanged){sbParameter.Append("FR_Udef4=@FR_Udef4, ");}
      if(failure_Relation.FR_Udef5_IsChanged){sbParameter.Append("FR_Udef5=@FR_Udef5, ");}
      if(failure_Relation.FR_Udef6_IsChanged){sbParameter.Append("FR_Udef6=@FR_Udef6, ");}
      if(failure_Relation.FR_Udef7_IsChanged){sbParameter.Append("FR_Udef7=@FR_Udef7, ");}
      if(failure_Relation.FR_Udef8_IsChanged){sbParameter.Append("FR_Udef8=@FR_Udef8 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FR_ID=@FR_ID; " );
      string sql=sb.ToString();
         if(failure_Relation.FR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Code))
         {
            idb.AddParameter("@FR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Code", failure_Relation.FR_Code);
         }
          }
         if(failure_Relation.FR_ModuleCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_ModuleCode))
         {
            idb.AddParameter("@FR_ModuleCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_ModuleCode", failure_Relation.FR_ModuleCode);
         }
          }
         if(failure_Relation.FR_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_PlanCode))
         {
            idb.AddParameter("@FR_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PlanCode", failure_Relation.FR_PlanCode);
         }
          }
         if(failure_Relation.FR_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_ProdCode))
         {
            idb.AddParameter("@FR_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_ProdCode", failure_Relation.FR_ProdCode);
         }
          }
         if(failure_Relation.FR_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_PartNo))
         {
            idb.AddParameter("@FR_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PartNo", failure_Relation.FR_PartNo);
         }
          }
         if(failure_Relation.FR_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_PartName))
         {
            idb.AddParameter("@FR_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_PartName", failure_Relation.FR_PartName);
         }
          }
         if(failure_Relation.FR_FailureCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_FailureCode))
         {
            idb.AddParameter("@FR_FailureCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_FailureCode", failure_Relation.FR_FailureCode);
         }
          }
         if(failure_Relation.FR_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Stat))
         {
            idb.AddParameter("@FR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Stat", failure_Relation.FR_Stat);
         }
          }
         if(failure_Relation.FR_IsCurrent_IsChanged)
         {
         if (failure_Relation.FR_IsCurrent == 0)
         {
            idb.AddParameter("@FR_IsCurrent", 0);
         }
         else
         {
            idb.AddParameter("@FR_IsCurrent", failure_Relation.FR_IsCurrent);
         }
          }
         if(failure_Relation.FR_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_RefCode))
         {
            idb.AddParameter("@FR_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_RefCode", failure_Relation.FR_RefCode);
         }
          }
         if(failure_Relation.Stat_IsChanged)
         {
         if (failure_Relation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", failure_Relation.Stat);
         }
          }
         if(failure_Relation.FR_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef1))
         {
            idb.AddParameter("@FR_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef1", failure_Relation.FR_Udef1);
         }
          }
         if(failure_Relation.FR_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef2))
         {
            idb.AddParameter("@FR_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef2", failure_Relation.FR_Udef2);
         }
          }
         if(failure_Relation.FR_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef3))
         {
            idb.AddParameter("@FR_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef3", failure_Relation.FR_Udef3);
         }
          }
         if(failure_Relation.FR_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef4))
         {
            idb.AddParameter("@FR_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef4", failure_Relation.FR_Udef4);
         }
          }
         if(failure_Relation.FR_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef5))
         {
            idb.AddParameter("@FR_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef5", failure_Relation.FR_Udef5);
         }
          }
         if(failure_Relation.FR_Udef6_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef6))
         {
            idb.AddParameter("@FR_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef6", failure_Relation.FR_Udef6);
         }
          }
         if(failure_Relation.FR_Udef7_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef7))
         {
            idb.AddParameter("@FR_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef7", failure_Relation.FR_Udef7);
         }
          }
         if(failure_Relation.FR_Udef8_IsChanged)
         {
         if (string.IsNullOrEmpty(failure_Relation.FR_Udef8))
         {
            idb.AddParameter("@FR_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FR_Udef8", failure_Relation.FR_Udef8);
         }
          }

         idb.AddParameter("@FR_ID", failure_Relation.FR_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Failure_Relation对象(即:一条记录
      /// </summary>
      public int Delete(decimal fR_ID)
      {
         string sql = "DELETE Failure_Relation WHERE 1=1  AND FR_ID=@FR_ID ";
         idb.AddParameter("@FR_ID", fR_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Failure_Relation对象(即:一条记录
      /// </summary>
      public Failure_Relation GetByKey(decimal fR_ID)
      {
         Failure_Relation failure_Relation = new Failure_Relation();
         string sql = "SELECT  FR_ID,FR_Code,FR_ModuleCode,FR_PlanCode,FR_ProdCode,FR_PartNo,FR_PartName,FR_FailureCode,FR_Stat,FR_IsCurrent,FR_RefCode,Stat,FR_Udef1,FR_Udef2,FR_Udef3,FR_Udef4,FR_Udef5,FR_Udef6,FR_Udef7,FR_Udef8 FROM Failure_Relation WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FR_ID=@FR_ID ";
         idb.AddParameter("@FR_ID", fR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FR_ID"] != DBNull.Value) failure_Relation.FR_ID = Convert.ToDecimal(dr["FR_ID"]);
            if (dr["FR_Code"] != DBNull.Value) failure_Relation.FR_Code = Convert.ToString(dr["FR_Code"]);
            if (dr["FR_ModuleCode"] != DBNull.Value) failure_Relation.FR_ModuleCode = Convert.ToString(dr["FR_ModuleCode"]);
            if (dr["FR_PlanCode"] != DBNull.Value) failure_Relation.FR_PlanCode = Convert.ToString(dr["FR_PlanCode"]);
            if (dr["FR_ProdCode"] != DBNull.Value) failure_Relation.FR_ProdCode = Convert.ToString(dr["FR_ProdCode"]);
            if (dr["FR_PartNo"] != DBNull.Value) failure_Relation.FR_PartNo = Convert.ToString(dr["FR_PartNo"]);
            if (dr["FR_PartName"] != DBNull.Value) failure_Relation.FR_PartName = Convert.ToString(dr["FR_PartName"]);
            if (dr["FR_FailureCode"] != DBNull.Value) failure_Relation.FR_FailureCode = Convert.ToString(dr["FR_FailureCode"]);
            if (dr["FR_Stat"] != DBNull.Value) failure_Relation.FR_Stat = Convert.ToString(dr["FR_Stat"]);
            if (dr["FR_IsCurrent"] != DBNull.Value) failure_Relation.FR_IsCurrent = Convert.ToInt32(dr["FR_IsCurrent"]);
            if (dr["FR_RefCode"] != DBNull.Value) failure_Relation.FR_RefCode = Convert.ToString(dr["FR_RefCode"]);
            if (dr["Stat"] != DBNull.Value) failure_Relation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["FR_Udef1"] != DBNull.Value) failure_Relation.FR_Udef1 = Convert.ToString(dr["FR_Udef1"]);
            if (dr["FR_Udef2"] != DBNull.Value) failure_Relation.FR_Udef2 = Convert.ToString(dr["FR_Udef2"]);
            if (dr["FR_Udef3"] != DBNull.Value) failure_Relation.FR_Udef3 = Convert.ToString(dr["FR_Udef3"]);
            if (dr["FR_Udef4"] != DBNull.Value) failure_Relation.FR_Udef4 = Convert.ToString(dr["FR_Udef4"]);
            if (dr["FR_Udef5"] != DBNull.Value) failure_Relation.FR_Udef5 = Convert.ToString(dr["FR_Udef5"]);
            if (dr["FR_Udef6"] != DBNull.Value) failure_Relation.FR_Udef6 = Convert.ToString(dr["FR_Udef6"]);
            if (dr["FR_Udef7"] != DBNull.Value) failure_Relation.FR_Udef7 = Convert.ToString(dr["FR_Udef7"]);
            if (dr["FR_Udef8"] != DBNull.Value) failure_Relation.FR_Udef8 = Convert.ToString(dr["FR_Udef8"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return failure_Relation;
      }
      /// <summary>
      /// 获取指定的Failure_Relation对象集合
      /// </summary>
      public List<Failure_Relation> GetListByWhere(string strCondition)
      {
         List<Failure_Relation> ret = new List<Failure_Relation>();
         string sql = "SELECT  FR_ID,FR_Code,FR_ModuleCode,FR_PlanCode,FR_ProdCode,FR_PartNo,FR_PartName,FR_FailureCode,FR_Stat,FR_IsCurrent,FR_RefCode,Stat,FR_Udef1,FR_Udef2,FR_Udef3,FR_Udef4,FR_Udef5,FR_Udef6,FR_Udef7,FR_Udef8 FROM Failure_Relation WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Failure_Relation failure_Relation = new Failure_Relation();
            if (dr["FR_ID"] != DBNull.Value) failure_Relation.FR_ID = Convert.ToDecimal(dr["FR_ID"]);
            if (dr["FR_Code"] != DBNull.Value) failure_Relation.FR_Code = Convert.ToString(dr["FR_Code"]);
            if (dr["FR_ModuleCode"] != DBNull.Value) failure_Relation.FR_ModuleCode = Convert.ToString(dr["FR_ModuleCode"]);
            if (dr["FR_PlanCode"] != DBNull.Value) failure_Relation.FR_PlanCode = Convert.ToString(dr["FR_PlanCode"]);
            if (dr["FR_ProdCode"] != DBNull.Value) failure_Relation.FR_ProdCode = Convert.ToString(dr["FR_ProdCode"]);
            if (dr["FR_PartNo"] != DBNull.Value) failure_Relation.FR_PartNo = Convert.ToString(dr["FR_PartNo"]);
            if (dr["FR_PartName"] != DBNull.Value) failure_Relation.FR_PartName = Convert.ToString(dr["FR_PartName"]);
            if (dr["FR_FailureCode"] != DBNull.Value) failure_Relation.FR_FailureCode = Convert.ToString(dr["FR_FailureCode"]);
            if (dr["FR_Stat"] != DBNull.Value) failure_Relation.FR_Stat = Convert.ToString(dr["FR_Stat"]);
            if (dr["FR_IsCurrent"] != DBNull.Value) failure_Relation.FR_IsCurrent = Convert.ToInt32(dr["FR_IsCurrent"]);
            if (dr["FR_RefCode"] != DBNull.Value) failure_Relation.FR_RefCode = Convert.ToString(dr["FR_RefCode"]);
            if (dr["Stat"] != DBNull.Value) failure_Relation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["FR_Udef1"] != DBNull.Value) failure_Relation.FR_Udef1 = Convert.ToString(dr["FR_Udef1"]);
            if (dr["FR_Udef2"] != DBNull.Value) failure_Relation.FR_Udef2 = Convert.ToString(dr["FR_Udef2"]);
            if (dr["FR_Udef3"] != DBNull.Value) failure_Relation.FR_Udef3 = Convert.ToString(dr["FR_Udef3"]);
            if (dr["FR_Udef4"] != DBNull.Value) failure_Relation.FR_Udef4 = Convert.ToString(dr["FR_Udef4"]);
            if (dr["FR_Udef5"] != DBNull.Value) failure_Relation.FR_Udef5 = Convert.ToString(dr["FR_Udef5"]);
            if (dr["FR_Udef6"] != DBNull.Value) failure_Relation.FR_Udef6 = Convert.ToString(dr["FR_Udef6"]);
            if (dr["FR_Udef7"] != DBNull.Value) failure_Relation.FR_Udef7 = Convert.ToString(dr["FR_Udef7"]);
            if (dr["FR_Udef8"] != DBNull.Value) failure_Relation.FR_Udef8 = Convert.ToString(dr["FR_Udef8"]);
            ret.Add(failure_Relation);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Failure_Relation对象(即:一条记录
      /// </summary>
      public List<Failure_Relation> GetAll()
      {
         List<Failure_Relation> ret = new List<Failure_Relation>();
         string sql = "SELECT  FR_ID,FR_Code,FR_ModuleCode,FR_PlanCode,FR_ProdCode,FR_PartNo,FR_PartName,FR_FailureCode,FR_Stat,FR_IsCurrent,FR_RefCode,Stat,FR_Udef1,FR_Udef2,FR_Udef3,FR_Udef4,FR_Udef5,FR_Udef6,FR_Udef7,FR_Udef8 FROM Failure_Relation where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Failure_Relation failure_Relation = new Failure_Relation();
            if (dr["FR_ID"] != DBNull.Value) failure_Relation.FR_ID = Convert.ToDecimal(dr["FR_ID"]);
            if (dr["FR_Code"] != DBNull.Value) failure_Relation.FR_Code = Convert.ToString(dr["FR_Code"]);
            if (dr["FR_ModuleCode"] != DBNull.Value) failure_Relation.FR_ModuleCode = Convert.ToString(dr["FR_ModuleCode"]);
            if (dr["FR_PlanCode"] != DBNull.Value) failure_Relation.FR_PlanCode = Convert.ToString(dr["FR_PlanCode"]);
            if (dr["FR_ProdCode"] != DBNull.Value) failure_Relation.FR_ProdCode = Convert.ToString(dr["FR_ProdCode"]);
            if (dr["FR_PartNo"] != DBNull.Value) failure_Relation.FR_PartNo = Convert.ToString(dr["FR_PartNo"]);
            if (dr["FR_PartName"] != DBNull.Value) failure_Relation.FR_PartName = Convert.ToString(dr["FR_PartName"]);
            if (dr["FR_FailureCode"] != DBNull.Value) failure_Relation.FR_FailureCode = Convert.ToString(dr["FR_FailureCode"]);
            if (dr["FR_Stat"] != DBNull.Value) failure_Relation.FR_Stat = Convert.ToString(dr["FR_Stat"]);
            if (dr["FR_IsCurrent"] != DBNull.Value) failure_Relation.FR_IsCurrent = Convert.ToInt32(dr["FR_IsCurrent"]);
            if (dr["FR_RefCode"] != DBNull.Value) failure_Relation.FR_RefCode = Convert.ToString(dr["FR_RefCode"]);
            if (dr["Stat"] != DBNull.Value) failure_Relation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["FR_Udef1"] != DBNull.Value) failure_Relation.FR_Udef1 = Convert.ToString(dr["FR_Udef1"]);
            if (dr["FR_Udef2"] != DBNull.Value) failure_Relation.FR_Udef2 = Convert.ToString(dr["FR_Udef2"]);
            if (dr["FR_Udef3"] != DBNull.Value) failure_Relation.FR_Udef3 = Convert.ToString(dr["FR_Udef3"]);
            if (dr["FR_Udef4"] != DBNull.Value) failure_Relation.FR_Udef4 = Convert.ToString(dr["FR_Udef4"]);
            if (dr["FR_Udef5"] != DBNull.Value) failure_Relation.FR_Udef5 = Convert.ToString(dr["FR_Udef5"]);
            if (dr["FR_Udef6"] != DBNull.Value) failure_Relation.FR_Udef6 = Convert.ToString(dr["FR_Udef6"]);
            if (dr["FR_Udef7"] != DBNull.Value) failure_Relation.FR_Udef7 = Convert.ToString(dr["FR_Udef7"]);
            if (dr["FR_Udef8"] != DBNull.Value) failure_Relation.FR_Udef8 = Convert.ToString(dr["FR_Udef8"]);
            ret.Add(failure_Relation);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
