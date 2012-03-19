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
   public partial class ADORaw_Inv
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Raw_Inv对象(即:一条记录)
      /// </summary>
      public int Add(Raw_Inv raw_Inv)
      {
         string sql = "INSERT INTO Raw_Inv (RI_Code,RI_RawCode,RI_Sum,RI_AvailableNum,RI_UsedNum,RI_CompCode,RI_CmdCode,RI_InOperator,RI_InTime,RI_OutOperator,RI_OutTime,RI_Remark,Stat,RI_Customer,RI_RefRawCode,RI_RefDetailCode,RI_Udef1,RI_Udef2) VALUES (@RI_Code,@RI_RawCode,@RI_Sum,@RI_AvailableNum,@RI_UsedNum,@RI_CompCode,@RI_CmdCode,@RI_InOperator,@RI_InTime,@RI_OutOperator,@RI_OutTime,@RI_Remark,@Stat,@RI_Customer,@RI_RefRawCode,@RI_RefDetailCode,@RI_Udef1,@RI_Udef2)";
         if (string.IsNullOrEmpty(raw_Inv.RI_Code))
         {
            idb.AddParameter("@RI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Code", raw_Inv.RI_Code);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_RawCode))
         {
            idb.AddParameter("@RI_RawCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RawCode", raw_Inv.RI_RawCode);
         }
         if (raw_Inv.RI_Sum == 0)
         {
            idb.AddParameter("@RI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@RI_Sum", raw_Inv.RI_Sum);
         }
         if (raw_Inv.RI_AvailableNum == 0)
         {
            idb.AddParameter("@RI_AvailableNum", 0);
         }
         else
         {
            idb.AddParameter("@RI_AvailableNum", raw_Inv.RI_AvailableNum);
         }
         if (raw_Inv.RI_UsedNum == 0)
         {
            idb.AddParameter("@RI_UsedNum", 0);
         }
         else
         {
            idb.AddParameter("@RI_UsedNum", raw_Inv.RI_UsedNum);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_CompCode))
         {
            idb.AddParameter("@RI_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_CompCode", raw_Inv.RI_CompCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_CmdCode))
         {
            idb.AddParameter("@RI_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_CmdCode", raw_Inv.RI_CmdCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_InOperator))
         {
            idb.AddParameter("@RI_InOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_InOperator", raw_Inv.RI_InOperator);
         }
         if (raw_Inv.RI_InTime == DateTime.MinValue)
         {
            idb.AddParameter("@RI_InTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_InTime", raw_Inv.RI_InTime);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_OutOperator))
         {
            idb.AddParameter("@RI_OutOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_OutOperator", raw_Inv.RI_OutOperator);
         }
         if (raw_Inv.RI_OutTime == DateTime.MinValue)
         {
            idb.AddParameter("@RI_OutTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_OutTime", raw_Inv.RI_OutTime);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Remark))
         {
            idb.AddParameter("@RI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Remark", raw_Inv.RI_Remark);
         }
         if (raw_Inv.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Inv.Stat);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Customer))
         {
            idb.AddParameter("@RI_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Customer", raw_Inv.RI_Customer);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_RefRawCode))
         {
            idb.AddParameter("@RI_RefRawCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RefRawCode", raw_Inv.RI_RefRawCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_RefDetailCode))
         {
            idb.AddParameter("@RI_RefDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RefDetailCode", raw_Inv.RI_RefDetailCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Udef1))
         {
            idb.AddParameter("@RI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Udef1", raw_Inv.RI_Udef1);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Udef2))
         {
            idb.AddParameter("@RI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Udef2", raw_Inv.RI_Udef2);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Raw_Inv对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Raw_Inv raw_Inv)
      {
         string sql = "INSERT INTO Raw_Inv (RI_Code,RI_RawCode,RI_Sum,RI_AvailableNum,RI_UsedNum,RI_CompCode,RI_CmdCode,RI_InOperator,RI_InTime,RI_OutOperator,RI_OutTime,RI_Remark,Stat,RI_Customer,RI_RefRawCode,RI_RefDetailCode,RI_Udef1,RI_Udef2) VALUES (@RI_Code,@RI_RawCode,@RI_Sum,@RI_AvailableNum,@RI_UsedNum,@RI_CompCode,@RI_CmdCode,@RI_InOperator,@RI_InTime,@RI_OutOperator,@RI_OutTime,@RI_Remark,@Stat,@RI_Customer,@RI_RefRawCode,@RI_RefDetailCode,@RI_Udef1,@RI_Udef2);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(raw_Inv.RI_Code))
         {
            idb.AddParameter("@RI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Code", raw_Inv.RI_Code);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_RawCode))
         {
            idb.AddParameter("@RI_RawCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RawCode", raw_Inv.RI_RawCode);
         }
         if (raw_Inv.RI_Sum == 0)
         {
            idb.AddParameter("@RI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@RI_Sum", raw_Inv.RI_Sum);
         }
         if (raw_Inv.RI_AvailableNum == 0)
         {
            idb.AddParameter("@RI_AvailableNum", 0);
         }
         else
         {
            idb.AddParameter("@RI_AvailableNum", raw_Inv.RI_AvailableNum);
         }
         if (raw_Inv.RI_UsedNum == 0)
         {
            idb.AddParameter("@RI_UsedNum", 0);
         }
         else
         {
            idb.AddParameter("@RI_UsedNum", raw_Inv.RI_UsedNum);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_CompCode))
         {
            idb.AddParameter("@RI_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_CompCode", raw_Inv.RI_CompCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_CmdCode))
         {
            idb.AddParameter("@RI_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_CmdCode", raw_Inv.RI_CmdCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_InOperator))
         {
            idb.AddParameter("@RI_InOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_InOperator", raw_Inv.RI_InOperator);
         }
         if (raw_Inv.RI_InTime == DateTime.MinValue)
         {
            idb.AddParameter("@RI_InTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_InTime", raw_Inv.RI_InTime);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_OutOperator))
         {
            idb.AddParameter("@RI_OutOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_OutOperator", raw_Inv.RI_OutOperator);
         }
         if (raw_Inv.RI_OutTime == DateTime.MinValue)
         {
            idb.AddParameter("@RI_OutTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_OutTime", raw_Inv.RI_OutTime);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Remark))
         {
            idb.AddParameter("@RI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Remark", raw_Inv.RI_Remark);
         }
         if (raw_Inv.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Inv.Stat);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Customer))
         {
            idb.AddParameter("@RI_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Customer", raw_Inv.RI_Customer);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_RefRawCode))
         {
            idb.AddParameter("@RI_RefRawCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RefRawCode", raw_Inv.RI_RefRawCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_RefDetailCode))
         {
            idb.AddParameter("@RI_RefDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RefDetailCode", raw_Inv.RI_RefDetailCode);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Udef1))
         {
            idb.AddParameter("@RI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Udef1", raw_Inv.RI_Udef1);
         }
         if (string.IsNullOrEmpty(raw_Inv.RI_Udef2))
         {
            idb.AddParameter("@RI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Udef2", raw_Inv.RI_Udef2);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Raw_Inv对象(即:一条记录
      /// </summary>
      public int Update(Raw_Inv raw_Inv)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Raw_Inv       SET ");
            if(raw_Inv.RI_Code_IsChanged){sbParameter.Append("RI_Code=@RI_Code, ");}
      if(raw_Inv.RI_RawCode_IsChanged){sbParameter.Append("RI_RawCode=@RI_RawCode, ");}
      if(raw_Inv.RI_Sum_IsChanged){sbParameter.Append("RI_Sum=@RI_Sum, ");}
      if(raw_Inv.RI_AvailableNum_IsChanged){sbParameter.Append("RI_AvailableNum=@RI_AvailableNum, ");}
      if(raw_Inv.RI_UsedNum_IsChanged){sbParameter.Append("RI_UsedNum=@RI_UsedNum, ");}
      if(raw_Inv.RI_CompCode_IsChanged){sbParameter.Append("RI_CompCode=@RI_CompCode, ");}
      if(raw_Inv.RI_CmdCode_IsChanged){sbParameter.Append("RI_CmdCode=@RI_CmdCode, ");}
      if(raw_Inv.RI_InOperator_IsChanged){sbParameter.Append("RI_InOperator=@RI_InOperator, ");}
      if(raw_Inv.RI_InTime_IsChanged){sbParameter.Append("RI_InTime=@RI_InTime, ");}
      if(raw_Inv.RI_OutOperator_IsChanged){sbParameter.Append("RI_OutOperator=@RI_OutOperator, ");}
      if(raw_Inv.RI_OutTime_IsChanged){sbParameter.Append("RI_OutTime=@RI_OutTime, ");}
      if(raw_Inv.RI_Remark_IsChanged){sbParameter.Append("RI_Remark=@RI_Remark, ");}
      if(raw_Inv.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(raw_Inv.RI_Customer_IsChanged){sbParameter.Append("RI_Customer=@RI_Customer, ");}
      if(raw_Inv.RI_RefRawCode_IsChanged){sbParameter.Append("RI_RefRawCode=@RI_RefRawCode, ");}
      if(raw_Inv.RI_RefDetailCode_IsChanged){sbParameter.Append("RI_RefDetailCode=@RI_RefDetailCode, ");}
      if(raw_Inv.RI_Udef1_IsChanged){sbParameter.Append("RI_Udef1=@RI_Udef1, ");}
      if(raw_Inv.RI_Udef2_IsChanged){sbParameter.Append("RI_Udef2=@RI_Udef2 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RI_ID=@RI_ID; " );
      string sql=sb.ToString();
         if(raw_Inv.RI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_Code))
         {
            idb.AddParameter("@RI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Code", raw_Inv.RI_Code);
         }
          }
         if(raw_Inv.RI_RawCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_RawCode))
         {
            idb.AddParameter("@RI_RawCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RawCode", raw_Inv.RI_RawCode);
         }
          }
         if(raw_Inv.RI_Sum_IsChanged)
         {
         if (raw_Inv.RI_Sum == 0)
         {
            idb.AddParameter("@RI_Sum", 0);
         }
         else
         {
            idb.AddParameter("@RI_Sum", raw_Inv.RI_Sum);
         }
          }
         if(raw_Inv.RI_AvailableNum_IsChanged)
         {
         if (raw_Inv.RI_AvailableNum == 0)
         {
            idb.AddParameter("@RI_AvailableNum", 0);
         }
         else
         {
            idb.AddParameter("@RI_AvailableNum", raw_Inv.RI_AvailableNum);
         }
          }
         if(raw_Inv.RI_UsedNum_IsChanged)
         {
         if (raw_Inv.RI_UsedNum == 0)
         {
            idb.AddParameter("@RI_UsedNum", 0);
         }
         else
         {
            idb.AddParameter("@RI_UsedNum", raw_Inv.RI_UsedNum);
         }
          }
         if(raw_Inv.RI_CompCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_CompCode))
         {
            idb.AddParameter("@RI_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_CompCode", raw_Inv.RI_CompCode);
         }
          }
         if(raw_Inv.RI_CmdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_CmdCode))
         {
            idb.AddParameter("@RI_CmdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_CmdCode", raw_Inv.RI_CmdCode);
         }
          }
         if(raw_Inv.RI_InOperator_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_InOperator))
         {
            idb.AddParameter("@RI_InOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_InOperator", raw_Inv.RI_InOperator);
         }
          }
         if(raw_Inv.RI_InTime_IsChanged)
         {
         if (raw_Inv.RI_InTime == DateTime.MinValue)
         {
            idb.AddParameter("@RI_InTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_InTime", raw_Inv.RI_InTime);
         }
          }
         if(raw_Inv.RI_OutOperator_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_OutOperator))
         {
            idb.AddParameter("@RI_OutOperator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_OutOperator", raw_Inv.RI_OutOperator);
         }
          }
         if(raw_Inv.RI_OutTime_IsChanged)
         {
         if (raw_Inv.RI_OutTime == DateTime.MinValue)
         {
            idb.AddParameter("@RI_OutTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_OutTime", raw_Inv.RI_OutTime);
         }
          }
         if(raw_Inv.RI_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_Remark))
         {
            idb.AddParameter("@RI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Remark", raw_Inv.RI_Remark);
         }
          }
         if(raw_Inv.Stat_IsChanged)
         {
         if (raw_Inv.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", raw_Inv.Stat);
         }
          }
         if(raw_Inv.RI_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_Customer))
         {
            idb.AddParameter("@RI_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Customer", raw_Inv.RI_Customer);
         }
          }
         if(raw_Inv.RI_RefRawCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_RefRawCode))
         {
            idb.AddParameter("@RI_RefRawCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RefRawCode", raw_Inv.RI_RefRawCode);
         }
          }
         if(raw_Inv.RI_RefDetailCode_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_RefDetailCode))
         {
            idb.AddParameter("@RI_RefDetailCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_RefDetailCode", raw_Inv.RI_RefDetailCode);
         }
          }
         if(raw_Inv.RI_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_Udef1))
         {
            idb.AddParameter("@RI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Udef1", raw_Inv.RI_Udef1);
         }
          }
         if(raw_Inv.RI_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(raw_Inv.RI_Udef2))
         {
            idb.AddParameter("@RI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RI_Udef2", raw_Inv.RI_Udef2);
         }
          }

         idb.AddParameter("@RI_ID", raw_Inv.RI_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Raw_Inv对象(即:一条记录
      /// </summary>
      public int Delete(decimal rI_ID)
      {
         string sql = "DELETE Raw_Inv WHERE 1=1  AND RI_ID=@RI_ID ";
         idb.AddParameter("@RI_ID", rI_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Raw_Inv对象(即:一条记录
      /// </summary>
      public Raw_Inv GetByKey(decimal rI_ID)
      {
         Raw_Inv raw_Inv = new Raw_Inv();
         string sql = "SELECT  RI_ID,RI_Code,RI_RawCode,RI_Sum,RI_AvailableNum,RI_UsedNum,RI_CompCode,RI_CmdCode,RI_InOperator,RI_InTime,RI_OutOperator,RI_OutTime,RI_Remark,Stat,RI_Customer,RI_RefRawCode,RI_RefDetailCode,RI_Udef1,RI_Udef2 FROM Raw_Inv WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RI_ID=@RI_ID ";
         idb.AddParameter("@RI_ID", rI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RI_ID"] != DBNull.Value) raw_Inv.RI_ID = Convert.ToDecimal(dr["RI_ID"]);
            if (dr["RI_Code"] != DBNull.Value) raw_Inv.RI_Code = Convert.ToString(dr["RI_Code"]);
            if (dr["RI_RawCode"] != DBNull.Value) raw_Inv.RI_RawCode = Convert.ToString(dr["RI_RawCode"]);
            if (dr["RI_Sum"] != DBNull.Value) raw_Inv.RI_Sum = Convert.ToInt32(dr["RI_Sum"]);
            if (dr["RI_AvailableNum"] != DBNull.Value) raw_Inv.RI_AvailableNum = Convert.ToInt32(dr["RI_AvailableNum"]);
            if (dr["RI_UsedNum"] != DBNull.Value) raw_Inv.RI_UsedNum = Convert.ToInt32(dr["RI_UsedNum"]);
            if (dr["RI_CompCode"] != DBNull.Value) raw_Inv.RI_CompCode = Convert.ToString(dr["RI_CompCode"]);
            if (dr["RI_CmdCode"] != DBNull.Value) raw_Inv.RI_CmdCode = Convert.ToString(dr["RI_CmdCode"]);
            if (dr["RI_InOperator"] != DBNull.Value) raw_Inv.RI_InOperator = Convert.ToString(dr["RI_InOperator"]);
            if (dr["RI_InTime"] != DBNull.Value) raw_Inv.RI_InTime = Convert.ToDateTime(dr["RI_InTime"]);
            if (dr["RI_OutOperator"] != DBNull.Value) raw_Inv.RI_OutOperator = Convert.ToString(dr["RI_OutOperator"]);
            if (dr["RI_OutTime"] != DBNull.Value) raw_Inv.RI_OutTime = Convert.ToDateTime(dr["RI_OutTime"]);
            if (dr["RI_Remark"] != DBNull.Value) raw_Inv.RI_Remark = Convert.ToString(dr["RI_Remark"]);
            if (dr["Stat"] != DBNull.Value) raw_Inv.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RI_Customer"] != DBNull.Value) raw_Inv.RI_Customer = Convert.ToString(dr["RI_Customer"]);
            if (dr["RI_RefRawCode"] != DBNull.Value) raw_Inv.RI_RefRawCode = Convert.ToString(dr["RI_RefRawCode"]);
            if (dr["RI_RefDetailCode"] != DBNull.Value) raw_Inv.RI_RefDetailCode = Convert.ToString(dr["RI_RefDetailCode"]);
            if (dr["RI_Udef1"] != DBNull.Value) raw_Inv.RI_Udef1 = Convert.ToString(dr["RI_Udef1"]);
            if (dr["RI_Udef2"] != DBNull.Value) raw_Inv.RI_Udef2 = Convert.ToString(dr["RI_Udef2"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return raw_Inv;
      }
      /// <summary>
      /// 获取指定的Raw_Inv对象集合
      /// </summary>
      public List<Raw_Inv> GetListByWhere(string strCondition)
      {
         List<Raw_Inv> ret = new List<Raw_Inv>();
         string sql = "SELECT  RI_ID,RI_Code,RI_RawCode,RI_Sum,RI_AvailableNum,RI_UsedNum,RI_CompCode,RI_CmdCode,RI_InOperator,RI_InTime,RI_OutOperator,RI_OutTime,RI_Remark,Stat,RI_Customer,RI_RefRawCode,RI_RefDetailCode,RI_Udef1,RI_Udef2 FROM Raw_Inv WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Raw_Inv raw_Inv = new Raw_Inv();
            if (dr["RI_ID"] != DBNull.Value) raw_Inv.RI_ID = Convert.ToDecimal(dr["RI_ID"]);
            if (dr["RI_Code"] != DBNull.Value) raw_Inv.RI_Code = Convert.ToString(dr["RI_Code"]);
            if (dr["RI_RawCode"] != DBNull.Value) raw_Inv.RI_RawCode = Convert.ToString(dr["RI_RawCode"]);
            if (dr["RI_Sum"] != DBNull.Value) raw_Inv.RI_Sum = Convert.ToInt32(dr["RI_Sum"]);
            if (dr["RI_AvailableNum"] != DBNull.Value) raw_Inv.RI_AvailableNum = Convert.ToInt32(dr["RI_AvailableNum"]);
            if (dr["RI_UsedNum"] != DBNull.Value) raw_Inv.RI_UsedNum = Convert.ToInt32(dr["RI_UsedNum"]);
            if (dr["RI_CompCode"] != DBNull.Value) raw_Inv.RI_CompCode = Convert.ToString(dr["RI_CompCode"]);
            if (dr["RI_CmdCode"] != DBNull.Value) raw_Inv.RI_CmdCode = Convert.ToString(dr["RI_CmdCode"]);
            if (dr["RI_InOperator"] != DBNull.Value) raw_Inv.RI_InOperator = Convert.ToString(dr["RI_InOperator"]);
            if (dr["RI_InTime"] != DBNull.Value) raw_Inv.RI_InTime = Convert.ToDateTime(dr["RI_InTime"]);
            if (dr["RI_OutOperator"] != DBNull.Value) raw_Inv.RI_OutOperator = Convert.ToString(dr["RI_OutOperator"]);
            if (dr["RI_OutTime"] != DBNull.Value) raw_Inv.RI_OutTime = Convert.ToDateTime(dr["RI_OutTime"]);
            if (dr["RI_Remark"] != DBNull.Value) raw_Inv.RI_Remark = Convert.ToString(dr["RI_Remark"]);
            if (dr["Stat"] != DBNull.Value) raw_Inv.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RI_Customer"] != DBNull.Value) raw_Inv.RI_Customer = Convert.ToString(dr["RI_Customer"]);
            if (dr["RI_RefRawCode"] != DBNull.Value) raw_Inv.RI_RefRawCode = Convert.ToString(dr["RI_RefRawCode"]);
            if (dr["RI_RefDetailCode"] != DBNull.Value) raw_Inv.RI_RefDetailCode = Convert.ToString(dr["RI_RefDetailCode"]);
            if (dr["RI_Udef1"] != DBNull.Value) raw_Inv.RI_Udef1 = Convert.ToString(dr["RI_Udef1"]);
            if (dr["RI_Udef2"] != DBNull.Value) raw_Inv.RI_Udef2 = Convert.ToString(dr["RI_Udef2"]);
            ret.Add(raw_Inv);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Raw_Inv对象(即:一条记录
      /// </summary>
      public List<Raw_Inv> GetAll()
      {
         List<Raw_Inv> ret = new List<Raw_Inv>();
         string sql = "SELECT  RI_ID,RI_Code,RI_RawCode,RI_Sum,RI_AvailableNum,RI_UsedNum,RI_CompCode,RI_CmdCode,RI_InOperator,RI_InTime,RI_OutOperator,RI_OutTime,RI_Remark,Stat,RI_Customer,RI_RefRawCode,RI_RefDetailCode,RI_Udef1,RI_Udef2 FROM Raw_Inv where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Raw_Inv raw_Inv = new Raw_Inv();
            if (dr["RI_ID"] != DBNull.Value) raw_Inv.RI_ID = Convert.ToDecimal(dr["RI_ID"]);
            if (dr["RI_Code"] != DBNull.Value) raw_Inv.RI_Code = Convert.ToString(dr["RI_Code"]);
            if (dr["RI_RawCode"] != DBNull.Value) raw_Inv.RI_RawCode = Convert.ToString(dr["RI_RawCode"]);
            if (dr["RI_Sum"] != DBNull.Value) raw_Inv.RI_Sum = Convert.ToInt32(dr["RI_Sum"]);
            if (dr["RI_AvailableNum"] != DBNull.Value) raw_Inv.RI_AvailableNum = Convert.ToInt32(dr["RI_AvailableNum"]);
            if (dr["RI_UsedNum"] != DBNull.Value) raw_Inv.RI_UsedNum = Convert.ToInt32(dr["RI_UsedNum"]);
            if (dr["RI_CompCode"] != DBNull.Value) raw_Inv.RI_CompCode = Convert.ToString(dr["RI_CompCode"]);
            if (dr["RI_CmdCode"] != DBNull.Value) raw_Inv.RI_CmdCode = Convert.ToString(dr["RI_CmdCode"]);
            if (dr["RI_InOperator"] != DBNull.Value) raw_Inv.RI_InOperator = Convert.ToString(dr["RI_InOperator"]);
            if (dr["RI_InTime"] != DBNull.Value) raw_Inv.RI_InTime = Convert.ToDateTime(dr["RI_InTime"]);
            if (dr["RI_OutOperator"] != DBNull.Value) raw_Inv.RI_OutOperator = Convert.ToString(dr["RI_OutOperator"]);
            if (dr["RI_OutTime"] != DBNull.Value) raw_Inv.RI_OutTime = Convert.ToDateTime(dr["RI_OutTime"]);
            if (dr["RI_Remark"] != DBNull.Value) raw_Inv.RI_Remark = Convert.ToString(dr["RI_Remark"]);
            if (dr["Stat"] != DBNull.Value) raw_Inv.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["RI_Customer"] != DBNull.Value) raw_Inv.RI_Customer = Convert.ToString(dr["RI_Customer"]);
            if (dr["RI_RefRawCode"] != DBNull.Value) raw_Inv.RI_RefRawCode = Convert.ToString(dr["RI_RefRawCode"]);
            if (dr["RI_RefDetailCode"] != DBNull.Value) raw_Inv.RI_RefDetailCode = Convert.ToString(dr["RI_RefDetailCode"]);
            if (dr["RI_Udef1"] != DBNull.Value) raw_Inv.RI_Udef1 = Convert.ToString(dr["RI_Udef1"]);
            if (dr["RI_Udef2"] != DBNull.Value) raw_Inv.RI_Udef2 = Convert.ToString(dr["RI_Udef2"]);
            ret.Add(raw_Inv);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
