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
   /// 生产指令细表
   /// </summary>
   [Serializable]
   public partial class ADOProd_CmdDetail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产指令细表 Prod_CmdDetail对象(即:一条记录)
      /// </summary>
      public int Add(Prod_CmdDetail prod_CmdDetail)
      {
         string sql = "INSERT INTO Prod_CmdDetail (Cmd_Code,CmdDetail_Project,CmdDetail_PartNo,CmdDetail_PartName,CmdDetail_Unit,CmdDetail_Num,CmdDetail_Roads,CmdDetail_Pur,CmdDetail_PlanDate,CmdDetail_Bak,CmdDetail_DNum,CmdDetail_FNum,Stat,CmdDetail_PCode,CreateTime) VALUES (@Cmd_Code,@CmdDetail_Project,@CmdDetail_PartNo,@CmdDetail_PartName,@CmdDetail_Unit,@CmdDetail_Num,@CmdDetail_Roads,@CmdDetail_Pur,@CmdDetail_PlanDate,@CmdDetail_Bak,@CmdDetail_DNum,@CmdDetail_FNum,@Stat,@CmdDetail_PCode,@CreateTime)";
         if (string.IsNullOrEmpty(prod_CmdDetail.Cmd_Code))
         {
            idb.AddParameter("@Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Code", prod_CmdDetail.Cmd_Code);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Project))
         {
            idb.AddParameter("@CmdDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Project", prod_CmdDetail.CmdDetail_Project);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PartNo))
         {
            idb.AddParameter("@CmdDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PartNo", prod_CmdDetail.CmdDetail_PartNo);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PartName))
         {
            idb.AddParameter("@CmdDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PartName", prod_CmdDetail.CmdDetail_PartName);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Unit))
         {
            idb.AddParameter("@CmdDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Unit", prod_CmdDetail.CmdDetail_Unit);
         }
         if (prod_CmdDetail.CmdDetail_Num == 0)
         {
            idb.AddParameter("@CmdDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Num", prod_CmdDetail.CmdDetail_Num);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Roads))
         {
            idb.AddParameter("@CmdDetail_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Roads", prod_CmdDetail.CmdDetail_Roads);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Pur))
         {
            idb.AddParameter("@CmdDetail_Pur", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Pur", prod_CmdDetail.CmdDetail_Pur);
         }
         if (prod_CmdDetail.CmdDetail_PlanDate == DateTime.MinValue)
         {
            idb.AddParameter("@CmdDetail_PlanDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PlanDate", prod_CmdDetail.CmdDetail_PlanDate);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Bak))
         {
            idb.AddParameter("@CmdDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Bak", prod_CmdDetail.CmdDetail_Bak);
         }
         if (prod_CmdDetail.CmdDetail_DNum == 0)
         {
            idb.AddParameter("@CmdDetail_DNum", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_DNum", prod_CmdDetail.CmdDetail_DNum);
         }
         if (prod_CmdDetail.CmdDetail_FNum == 0)
         {
            idb.AddParameter("@CmdDetail_FNum", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_FNum", prod_CmdDetail.CmdDetail_FNum);
         }
         if (prod_CmdDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_CmdDetail.Stat);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PCode))
         {
            idb.AddParameter("@CmdDetail_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PCode", prod_CmdDetail.CmdDetail_PCode);
         }
         if (prod_CmdDetail.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", prod_CmdDetail.CreateTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加生产指令细表 Prod_CmdDetail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_CmdDetail prod_CmdDetail)
      {
         string sql = "INSERT INTO Prod_CmdDetail (Cmd_Code,CmdDetail_Project,CmdDetail_PartNo,CmdDetail_PartName,CmdDetail_Unit,CmdDetail_Num,CmdDetail_Roads,CmdDetail_Pur,CmdDetail_PlanDate,CmdDetail_Bak,CmdDetail_DNum,CmdDetail_FNum,Stat,CmdDetail_PCode,CreateTime) VALUES (@Cmd_Code,@CmdDetail_Project,@CmdDetail_PartNo,@CmdDetail_PartName,@CmdDetail_Unit,@CmdDetail_Num,@CmdDetail_Roads,@CmdDetail_Pur,@CmdDetail_PlanDate,@CmdDetail_Bak,@CmdDetail_DNum,@CmdDetail_FNum,@Stat,@CmdDetail_PCode,@CreateTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_CmdDetail.Cmd_Code))
         {
            idb.AddParameter("@Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Code", prod_CmdDetail.Cmd_Code);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Project))
         {
            idb.AddParameter("@CmdDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Project", prod_CmdDetail.CmdDetail_Project);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PartNo))
         {
            idb.AddParameter("@CmdDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PartNo", prod_CmdDetail.CmdDetail_PartNo);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PartName))
         {
            idb.AddParameter("@CmdDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PartName", prod_CmdDetail.CmdDetail_PartName);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Unit))
         {
            idb.AddParameter("@CmdDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Unit", prod_CmdDetail.CmdDetail_Unit);
         }
         if (prod_CmdDetail.CmdDetail_Num == 0)
         {
            idb.AddParameter("@CmdDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Num", prod_CmdDetail.CmdDetail_Num);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Roads))
         {
            idb.AddParameter("@CmdDetail_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Roads", prod_CmdDetail.CmdDetail_Roads);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Pur))
         {
            idb.AddParameter("@CmdDetail_Pur", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Pur", prod_CmdDetail.CmdDetail_Pur);
         }
         if (prod_CmdDetail.CmdDetail_PlanDate == DateTime.MinValue)
         {
            idb.AddParameter("@CmdDetail_PlanDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PlanDate", prod_CmdDetail.CmdDetail_PlanDate);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Bak))
         {
            idb.AddParameter("@CmdDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Bak", prod_CmdDetail.CmdDetail_Bak);
         }
         if (prod_CmdDetail.CmdDetail_DNum == 0)
         {
            idb.AddParameter("@CmdDetail_DNum", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_DNum", prod_CmdDetail.CmdDetail_DNum);
         }
         if (prod_CmdDetail.CmdDetail_FNum == 0)
         {
            idb.AddParameter("@CmdDetail_FNum", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_FNum", prod_CmdDetail.CmdDetail_FNum);
         }
         if (prod_CmdDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_CmdDetail.Stat);
         }
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PCode))
         {
            idb.AddParameter("@CmdDetail_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PCode", prod_CmdDetail.CmdDetail_PCode);
         }
         if (prod_CmdDetail.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", prod_CmdDetail.CreateTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新生产指令细表 Prod_CmdDetail对象(即:一条记录
      /// </summary>
      public int Update(Prod_CmdDetail prod_CmdDetail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_CmdDetail       SET ");
            if(prod_CmdDetail.Cmd_Code_IsChanged){sbParameter.Append("Cmd_Code=@Cmd_Code, ");}
      if(prod_CmdDetail.CmdDetail_Project_IsChanged){sbParameter.Append("CmdDetail_Project=@CmdDetail_Project, ");}
      if(prod_CmdDetail.CmdDetail_PartNo_IsChanged){sbParameter.Append("CmdDetail_PartNo=@CmdDetail_PartNo, ");}
      if(prod_CmdDetail.CmdDetail_PartName_IsChanged){sbParameter.Append("CmdDetail_PartName=@CmdDetail_PartName, ");}
      if(prod_CmdDetail.CmdDetail_Unit_IsChanged){sbParameter.Append("CmdDetail_Unit=@CmdDetail_Unit, ");}
      if(prod_CmdDetail.CmdDetail_Num_IsChanged){sbParameter.Append("CmdDetail_Num=@CmdDetail_Num, ");}
      if(prod_CmdDetail.CmdDetail_Roads_IsChanged){sbParameter.Append("CmdDetail_Roads=@CmdDetail_Roads, ");}
      if(prod_CmdDetail.CmdDetail_Pur_IsChanged){sbParameter.Append("CmdDetail_Pur=@CmdDetail_Pur, ");}
      if(prod_CmdDetail.CmdDetail_PlanDate_IsChanged){sbParameter.Append("CmdDetail_PlanDate=@CmdDetail_PlanDate, ");}
      if(prod_CmdDetail.CmdDetail_Bak_IsChanged){sbParameter.Append("CmdDetail_Bak=@CmdDetail_Bak, ");}
      if(prod_CmdDetail.CmdDetail_DNum_IsChanged){sbParameter.Append("CmdDetail_DNum=@CmdDetail_DNum, ");}
      if(prod_CmdDetail.CmdDetail_FNum_IsChanged){sbParameter.Append("CmdDetail_FNum=@CmdDetail_FNum, ");}
      if(prod_CmdDetail.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_CmdDetail.CmdDetail_PCode_IsChanged){sbParameter.Append("CmdDetail_PCode=@CmdDetail_PCode, ");}
      if(prod_CmdDetail.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CmdDetail_ID=@CmdDetail_ID; " );
      string sql=sb.ToString();
         if(prod_CmdDetail.Cmd_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.Cmd_Code))
         {
            idb.AddParameter("@Cmd_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cmd_Code", prod_CmdDetail.Cmd_Code);
         }
          }
         if(prod_CmdDetail.CmdDetail_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Project))
         {
            idb.AddParameter("@CmdDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Project", prod_CmdDetail.CmdDetail_Project);
         }
          }
         if(prod_CmdDetail.CmdDetail_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PartNo))
         {
            idb.AddParameter("@CmdDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PartNo", prod_CmdDetail.CmdDetail_PartNo);
         }
          }
         if(prod_CmdDetail.CmdDetail_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PartName))
         {
            idb.AddParameter("@CmdDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PartName", prod_CmdDetail.CmdDetail_PartName);
         }
          }
         if(prod_CmdDetail.CmdDetail_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Unit))
         {
            idb.AddParameter("@CmdDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Unit", prod_CmdDetail.CmdDetail_Unit);
         }
          }
         if(prod_CmdDetail.CmdDetail_Num_IsChanged)
         {
         if (prod_CmdDetail.CmdDetail_Num == 0)
         {
            idb.AddParameter("@CmdDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Num", prod_CmdDetail.CmdDetail_Num);
         }
          }
         if(prod_CmdDetail.CmdDetail_Roads_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Roads))
         {
            idb.AddParameter("@CmdDetail_Roads", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Roads", prod_CmdDetail.CmdDetail_Roads);
         }
          }
         if(prod_CmdDetail.CmdDetail_Pur_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Pur))
         {
            idb.AddParameter("@CmdDetail_Pur", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Pur", prod_CmdDetail.CmdDetail_Pur);
         }
          }
         if(prod_CmdDetail.CmdDetail_PlanDate_IsChanged)
         {
         if (prod_CmdDetail.CmdDetail_PlanDate == DateTime.MinValue)
         {
            idb.AddParameter("@CmdDetail_PlanDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PlanDate", prod_CmdDetail.CmdDetail_PlanDate);
         }
          }
         if(prod_CmdDetail.CmdDetail_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_Bak))
         {
            idb.AddParameter("@CmdDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_Bak", prod_CmdDetail.CmdDetail_Bak);
         }
          }
         if(prod_CmdDetail.CmdDetail_DNum_IsChanged)
         {
         if (prod_CmdDetail.CmdDetail_DNum == 0)
         {
            idb.AddParameter("@CmdDetail_DNum", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_DNum", prod_CmdDetail.CmdDetail_DNum);
         }
          }
         if(prod_CmdDetail.CmdDetail_FNum_IsChanged)
         {
         if (prod_CmdDetail.CmdDetail_FNum == 0)
         {
            idb.AddParameter("@CmdDetail_FNum", 0);
         }
         else
         {
            idb.AddParameter("@CmdDetail_FNum", prod_CmdDetail.CmdDetail_FNum);
         }
          }
         if(prod_CmdDetail.Stat_IsChanged)
         {
         if (prod_CmdDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_CmdDetail.Stat);
         }
          }
         if(prod_CmdDetail.CmdDetail_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_CmdDetail.CmdDetail_PCode))
         {
            idb.AddParameter("@CmdDetail_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CmdDetail_PCode", prod_CmdDetail.CmdDetail_PCode);
         }
          }
         if(prod_CmdDetail.CreateTime_IsChanged)
         {
         if (prod_CmdDetail.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", prod_CmdDetail.CreateTime);
         }
          }

         idb.AddParameter("@CmdDetail_ID", prod_CmdDetail.CmdDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除生产指令细表 Prod_CmdDetail对象(即:一条记录
      /// </summary>
      public int Delete(Int64 cmdDetail_ID)
      {
         string sql = "DELETE Prod_CmdDetail WHERE 1=1  AND CmdDetail_ID=@CmdDetail_ID ";
         idb.AddParameter("@CmdDetail_ID", cmdDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的生产指令细表 Prod_CmdDetail对象(即:一条记录
      /// </summary>
      public Prod_CmdDetail GetByKey(Int64 cmdDetail_ID)
      {
         Prod_CmdDetail prod_CmdDetail = new Prod_CmdDetail();
         string sql = "SELECT  CmdDetail_ID,Cmd_Code,CmdDetail_Project,CmdDetail_PartNo,CmdDetail_PartName,CmdDetail_Unit,CmdDetail_Num,CmdDetail_Roads,CmdDetail_Pur,CmdDetail_PlanDate,CmdDetail_Bak,CmdDetail_DNum,CmdDetail_FNum,Stat,CmdDetail_PCode,CreateTime FROM Prod_CmdDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CmdDetail_ID=@CmdDetail_ID ";
         idb.AddParameter("@CmdDetail_ID", cmdDetail_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CmdDetail_ID"] != DBNull.Value) prod_CmdDetail.CmdDetail_ID = Convert.ToInt64(dr["CmdDetail_ID"]);
            if (dr["Cmd_Code"] != DBNull.Value) prod_CmdDetail.Cmd_Code = Convert.ToString(dr["Cmd_Code"]);
            if (dr["CmdDetail_Project"] != DBNull.Value) prod_CmdDetail.CmdDetail_Project = Convert.ToString(dr["CmdDetail_Project"]);
            if (dr["CmdDetail_PartNo"] != DBNull.Value) prod_CmdDetail.CmdDetail_PartNo = Convert.ToString(dr["CmdDetail_PartNo"]);
            if (dr["CmdDetail_PartName"] != DBNull.Value) prod_CmdDetail.CmdDetail_PartName = Convert.ToString(dr["CmdDetail_PartName"]);
            if (dr["CmdDetail_Unit"] != DBNull.Value) prod_CmdDetail.CmdDetail_Unit = Convert.ToString(dr["CmdDetail_Unit"]);
            if (dr["CmdDetail_Num"] != DBNull.Value) prod_CmdDetail.CmdDetail_Num = Convert.ToInt32(dr["CmdDetail_Num"]);
            if (dr["CmdDetail_Roads"] != DBNull.Value) prod_CmdDetail.CmdDetail_Roads = Convert.ToString(dr["CmdDetail_Roads"]);
            if (dr["CmdDetail_Pur"] != DBNull.Value) prod_CmdDetail.CmdDetail_Pur = Convert.ToString(dr["CmdDetail_Pur"]);
            if (dr["CmdDetail_PlanDate"] != DBNull.Value) prod_CmdDetail.CmdDetail_PlanDate = Convert.ToDateTime(dr["CmdDetail_PlanDate"]);
            if (dr["CmdDetail_Bak"] != DBNull.Value) prod_CmdDetail.CmdDetail_Bak = Convert.ToString(dr["CmdDetail_Bak"]);
            if (dr["CmdDetail_DNum"] != DBNull.Value) prod_CmdDetail.CmdDetail_DNum = Convert.ToInt32(dr["CmdDetail_DNum"]);
            if (dr["CmdDetail_FNum"] != DBNull.Value) prod_CmdDetail.CmdDetail_FNum = Convert.ToInt32(dr["CmdDetail_FNum"]);
            if (dr["Stat"] != DBNull.Value) prod_CmdDetail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CmdDetail_PCode"] != DBNull.Value) prod_CmdDetail.CmdDetail_PCode = Convert.ToString(dr["CmdDetail_PCode"]);
            if (dr["CreateTime"] != DBNull.Value) prod_CmdDetail.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_CmdDetail;
      }
      /// <summary>
      /// 获取指定的生产指令细表 Prod_CmdDetail对象集合
      /// </summary>
      public List<Prod_CmdDetail> GetListByWhere(string strCondition)
      {
         List<Prod_CmdDetail> ret = new List<Prod_CmdDetail>();
         string sql = "SELECT  CmdDetail_ID,Cmd_Code,CmdDetail_Project,CmdDetail_PartNo,CmdDetail_PartName,CmdDetail_Unit,CmdDetail_Num,CmdDetail_Roads,CmdDetail_Pur,CmdDetail_PlanDate,CmdDetail_Bak,CmdDetail_DNum,CmdDetail_FNum,Stat,CmdDetail_PCode,CreateTime FROM Prod_CmdDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_CmdDetail prod_CmdDetail = new Prod_CmdDetail();
            if (dr["CmdDetail_ID"] != DBNull.Value) prod_CmdDetail.CmdDetail_ID = Convert.ToInt64(dr["CmdDetail_ID"]);
            if (dr["Cmd_Code"] != DBNull.Value) prod_CmdDetail.Cmd_Code = Convert.ToString(dr["Cmd_Code"]);
            if (dr["CmdDetail_Project"] != DBNull.Value) prod_CmdDetail.CmdDetail_Project = Convert.ToString(dr["CmdDetail_Project"]);
            if (dr["CmdDetail_PartNo"] != DBNull.Value) prod_CmdDetail.CmdDetail_PartNo = Convert.ToString(dr["CmdDetail_PartNo"]);
            if (dr["CmdDetail_PartName"] != DBNull.Value) prod_CmdDetail.CmdDetail_PartName = Convert.ToString(dr["CmdDetail_PartName"]);
            if (dr["CmdDetail_Unit"] != DBNull.Value) prod_CmdDetail.CmdDetail_Unit = Convert.ToString(dr["CmdDetail_Unit"]);
            if (dr["CmdDetail_Num"] != DBNull.Value) prod_CmdDetail.CmdDetail_Num = Convert.ToInt32(dr["CmdDetail_Num"]);
            if (dr["CmdDetail_Roads"] != DBNull.Value) prod_CmdDetail.CmdDetail_Roads = Convert.ToString(dr["CmdDetail_Roads"]);
            if (dr["CmdDetail_Pur"] != DBNull.Value) prod_CmdDetail.CmdDetail_Pur = Convert.ToString(dr["CmdDetail_Pur"]);
            if (dr["CmdDetail_PlanDate"] != DBNull.Value) prod_CmdDetail.CmdDetail_PlanDate = Convert.ToDateTime(dr["CmdDetail_PlanDate"]);
            if (dr["CmdDetail_Bak"] != DBNull.Value) prod_CmdDetail.CmdDetail_Bak = Convert.ToString(dr["CmdDetail_Bak"]);
            if (dr["CmdDetail_DNum"] != DBNull.Value) prod_CmdDetail.CmdDetail_DNum = Convert.ToInt32(dr["CmdDetail_DNum"]);
            if (dr["CmdDetail_FNum"] != DBNull.Value) prod_CmdDetail.CmdDetail_FNum = Convert.ToInt32(dr["CmdDetail_FNum"]);
            if (dr["Stat"] != DBNull.Value) prod_CmdDetail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CmdDetail_PCode"] != DBNull.Value) prod_CmdDetail.CmdDetail_PCode = Convert.ToString(dr["CmdDetail_PCode"]);
            if (dr["CreateTime"] != DBNull.Value) prod_CmdDetail.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(prod_CmdDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产指令细表 Prod_CmdDetail对象(即:一条记录
      /// </summary>
      public List<Prod_CmdDetail> GetAll()
      {
         List<Prod_CmdDetail> ret = new List<Prod_CmdDetail>();
         string sql = "SELECT  CmdDetail_ID,Cmd_Code,CmdDetail_Project,CmdDetail_PartNo,CmdDetail_PartName,CmdDetail_Unit,CmdDetail_Num,CmdDetail_Roads,CmdDetail_Pur,CmdDetail_PlanDate,CmdDetail_Bak,CmdDetail_DNum,CmdDetail_FNum,Stat,CmdDetail_PCode,CreateTime FROM Prod_CmdDetail where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_CmdDetail prod_CmdDetail = new Prod_CmdDetail();
            if (dr["CmdDetail_ID"] != DBNull.Value) prod_CmdDetail.CmdDetail_ID = Convert.ToInt64(dr["CmdDetail_ID"]);
            if (dr["Cmd_Code"] != DBNull.Value) prod_CmdDetail.Cmd_Code = Convert.ToString(dr["Cmd_Code"]);
            if (dr["CmdDetail_Project"] != DBNull.Value) prod_CmdDetail.CmdDetail_Project = Convert.ToString(dr["CmdDetail_Project"]);
            if (dr["CmdDetail_PartNo"] != DBNull.Value) prod_CmdDetail.CmdDetail_PartNo = Convert.ToString(dr["CmdDetail_PartNo"]);
            if (dr["CmdDetail_PartName"] != DBNull.Value) prod_CmdDetail.CmdDetail_PartName = Convert.ToString(dr["CmdDetail_PartName"]);
            if (dr["CmdDetail_Unit"] != DBNull.Value) prod_CmdDetail.CmdDetail_Unit = Convert.ToString(dr["CmdDetail_Unit"]);
            if (dr["CmdDetail_Num"] != DBNull.Value) prod_CmdDetail.CmdDetail_Num = Convert.ToInt32(dr["CmdDetail_Num"]);
            if (dr["CmdDetail_Roads"] != DBNull.Value) prod_CmdDetail.CmdDetail_Roads = Convert.ToString(dr["CmdDetail_Roads"]);
            if (dr["CmdDetail_Pur"] != DBNull.Value) prod_CmdDetail.CmdDetail_Pur = Convert.ToString(dr["CmdDetail_Pur"]);
            if (dr["CmdDetail_PlanDate"] != DBNull.Value) prod_CmdDetail.CmdDetail_PlanDate = Convert.ToDateTime(dr["CmdDetail_PlanDate"]);
            if (dr["CmdDetail_Bak"] != DBNull.Value) prod_CmdDetail.CmdDetail_Bak = Convert.ToString(dr["CmdDetail_Bak"]);
            if (dr["CmdDetail_DNum"] != DBNull.Value) prod_CmdDetail.CmdDetail_DNum = Convert.ToInt32(dr["CmdDetail_DNum"]);
            if (dr["CmdDetail_FNum"] != DBNull.Value) prod_CmdDetail.CmdDetail_FNum = Convert.ToInt32(dr["CmdDetail_FNum"]);
            if (dr["Stat"] != DBNull.Value) prod_CmdDetail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CmdDetail_PCode"] != DBNull.Value) prod_CmdDetail.CmdDetail_PCode = Convert.ToString(dr["CmdDetail_PCode"]);
            if (dr["CreateTime"] != DBNull.Value) prod_CmdDetail.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            ret.Add(prod_CmdDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
