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
   /// 零件部位检测模板
   /// </summary>
   [Serializable]
   public partial class ADORoad_TestRef
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加零件部位检测模板 Road_TestRef对象(即:一条记录)
      /// </summary>
      public int Add(Road_TestRef road_TestRef)
      {
         string sql = "INSERT INTO Road_TestRef (TestRef_RNodeID,TestRef_PartNo,TestRef_PartName,TestRef_RNodeCode,TestRef_RNodeName,TestRef_Code,TestRef_Name,TestRef_Value,TestRef_High,TestRef_Low,TestRef_Stat,TestRef_Order,TestRef_IsLast,Stat) VALUES (@TestRef_RNodeID,@TestRef_PartNo,@TestRef_PartName,@TestRef_RNodeCode,@TestRef_RNodeName,@TestRef_Code,@TestRef_Name,@TestRef_Value,@TestRef_High,@TestRef_Low,@TestRef_Stat,@TestRef_Order,@TestRef_IsLast,@Stat)";
         if (road_TestRef.TestRef_RNodeID == 0)
         {
            idb.AddParameter("@TestRef_RNodeID", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeID", road_TestRef.TestRef_RNodeID);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_PartNo))
         {
            idb.AddParameter("@TestRef_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_PartNo", road_TestRef.TestRef_PartNo);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_PartName))
         {
            idb.AddParameter("@TestRef_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_PartName", road_TestRef.TestRef_PartName);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_RNodeCode))
         {
            idb.AddParameter("@TestRef_RNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeCode", road_TestRef.TestRef_RNodeCode);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_RNodeName))
         {
            idb.AddParameter("@TestRef_RNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeName", road_TestRef.TestRef_RNodeName);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Code))
         {
            idb.AddParameter("@TestRef_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Code", road_TestRef.TestRef_Code);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Name))
         {
            idb.AddParameter("@TestRef_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Name", road_TestRef.TestRef_Name);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Value))
         {
            idb.AddParameter("@TestRef_Value", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Value", road_TestRef.TestRef_Value);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_High))
         {
            idb.AddParameter("@TestRef_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_High", road_TestRef.TestRef_High);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Low))
         {
            idb.AddParameter("@TestRef_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Low", road_TestRef.TestRef_Low);
         }
         if (road_TestRef.TestRef_Stat == 0)
         {
            idb.AddParameter("@TestRef_Stat", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_Stat", road_TestRef.TestRef_Stat);
         }
         if (road_TestRef.TestRef_Order == 0)
         {
            idb.AddParameter("@TestRef_Order", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_Order", road_TestRef.TestRef_Order);
         }
         if (road_TestRef.TestRef_IsLast == 0)
         {
            idb.AddParameter("@TestRef_IsLast", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_IsLast", road_TestRef.TestRef_IsLast);
         }
         if (road_TestRef.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_TestRef.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加零件部位检测模板 Road_TestRef对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Road_TestRef road_TestRef)
      {
         string sql = "INSERT INTO Road_TestRef (TestRef_RNodeID,TestRef_PartNo,TestRef_PartName,TestRef_RNodeCode,TestRef_RNodeName,TestRef_Code,TestRef_Name,TestRef_Value,TestRef_High,TestRef_Low,TestRef_Stat,TestRef_Order,TestRef_IsLast,Stat) VALUES (@TestRef_RNodeID,@TestRef_PartNo,@TestRef_PartName,@TestRef_RNodeCode,@TestRef_RNodeName,@TestRef_Code,@TestRef_Name,@TestRef_Value,@TestRef_High,@TestRef_Low,@TestRef_Stat,@TestRef_Order,@TestRef_IsLast,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (road_TestRef.TestRef_RNodeID == 0)
         {
            idb.AddParameter("@TestRef_RNodeID", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeID", road_TestRef.TestRef_RNodeID);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_PartNo))
         {
            idb.AddParameter("@TestRef_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_PartNo", road_TestRef.TestRef_PartNo);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_PartName))
         {
            idb.AddParameter("@TestRef_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_PartName", road_TestRef.TestRef_PartName);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_RNodeCode))
         {
            idb.AddParameter("@TestRef_RNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeCode", road_TestRef.TestRef_RNodeCode);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_RNodeName))
         {
            idb.AddParameter("@TestRef_RNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeName", road_TestRef.TestRef_RNodeName);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Code))
         {
            idb.AddParameter("@TestRef_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Code", road_TestRef.TestRef_Code);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Name))
         {
            idb.AddParameter("@TestRef_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Name", road_TestRef.TestRef_Name);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Value))
         {
            idb.AddParameter("@TestRef_Value", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Value", road_TestRef.TestRef_Value);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_High))
         {
            idb.AddParameter("@TestRef_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_High", road_TestRef.TestRef_High);
         }
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Low))
         {
            idb.AddParameter("@TestRef_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Low", road_TestRef.TestRef_Low);
         }
         if (road_TestRef.TestRef_Stat == 0)
         {
            idb.AddParameter("@TestRef_Stat", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_Stat", road_TestRef.TestRef_Stat);
         }
         if (road_TestRef.TestRef_Order == 0)
         {
            idb.AddParameter("@TestRef_Order", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_Order", road_TestRef.TestRef_Order);
         }
         if (road_TestRef.TestRef_IsLast == 0)
         {
            idb.AddParameter("@TestRef_IsLast", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_IsLast", road_TestRef.TestRef_IsLast);
         }
         if (road_TestRef.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_TestRef.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新零件部位检测模板 Road_TestRef对象(即:一条记录
      /// </summary>
      public int Update(Road_TestRef road_TestRef)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Road_TestRef       SET ");
            if(road_TestRef.TestRef_RNodeID_IsChanged){sbParameter.Append("TestRef_RNodeID=@TestRef_RNodeID, ");}
      if(road_TestRef.TestRef_PartNo_IsChanged){sbParameter.Append("TestRef_PartNo=@TestRef_PartNo, ");}
      if(road_TestRef.TestRef_PartName_IsChanged){sbParameter.Append("TestRef_PartName=@TestRef_PartName, ");}
      if(road_TestRef.TestRef_RNodeCode_IsChanged){sbParameter.Append("TestRef_RNodeCode=@TestRef_RNodeCode, ");}
      if(road_TestRef.TestRef_RNodeName_IsChanged){sbParameter.Append("TestRef_RNodeName=@TestRef_RNodeName, ");}
      if(road_TestRef.TestRef_Code_IsChanged){sbParameter.Append("TestRef_Code=@TestRef_Code, ");}
      if(road_TestRef.TestRef_Name_IsChanged){sbParameter.Append("TestRef_Name=@TestRef_Name, ");}
      if(road_TestRef.TestRef_Value_IsChanged){sbParameter.Append("TestRef_Value=@TestRef_Value, ");}
      if(road_TestRef.TestRef_High_IsChanged){sbParameter.Append("TestRef_High=@TestRef_High, ");}
      if(road_TestRef.TestRef_Low_IsChanged){sbParameter.Append("TestRef_Low=@TestRef_Low, ");}
      if(road_TestRef.TestRef_Stat_IsChanged){sbParameter.Append("TestRef_Stat=@TestRef_Stat, ");}
      if(road_TestRef.TestRef_Order_IsChanged){sbParameter.Append("TestRef_Order=@TestRef_Order, ");}
      if(road_TestRef.TestRef_IsLast_IsChanged){sbParameter.Append("TestRef_IsLast=@TestRef_IsLast, ");}
      if(road_TestRef.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and TestRef_ID=@TestRef_ID; " );
      string sql=sb.ToString();
         if(road_TestRef.TestRef_RNodeID_IsChanged)
         {
         if (road_TestRef.TestRef_RNodeID == 0)
         {
            idb.AddParameter("@TestRef_RNodeID", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeID", road_TestRef.TestRef_RNodeID);
         }
          }
         if(road_TestRef.TestRef_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_PartNo))
         {
            idb.AddParameter("@TestRef_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_PartNo", road_TestRef.TestRef_PartNo);
         }
          }
         if(road_TestRef.TestRef_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_PartName))
         {
            idb.AddParameter("@TestRef_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_PartName", road_TestRef.TestRef_PartName);
         }
          }
         if(road_TestRef.TestRef_RNodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_RNodeCode))
         {
            idb.AddParameter("@TestRef_RNodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeCode", road_TestRef.TestRef_RNodeCode);
         }
          }
         if(road_TestRef.TestRef_RNodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_RNodeName))
         {
            idb.AddParameter("@TestRef_RNodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_RNodeName", road_TestRef.TestRef_RNodeName);
         }
          }
         if(road_TestRef.TestRef_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Code))
         {
            idb.AddParameter("@TestRef_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Code", road_TestRef.TestRef_Code);
         }
          }
         if(road_TestRef.TestRef_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Name))
         {
            idb.AddParameter("@TestRef_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Name", road_TestRef.TestRef_Name);
         }
          }
         if(road_TestRef.TestRef_Value_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Value))
         {
            idb.AddParameter("@TestRef_Value", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Value", road_TestRef.TestRef_Value);
         }
          }
         if(road_TestRef.TestRef_High_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_High))
         {
            idb.AddParameter("@TestRef_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_High", road_TestRef.TestRef_High);
         }
          }
         if(road_TestRef.TestRef_Low_IsChanged)
         {
         if (string.IsNullOrEmpty(road_TestRef.TestRef_Low))
         {
            idb.AddParameter("@TestRef_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@TestRef_Low", road_TestRef.TestRef_Low);
         }
          }
         if(road_TestRef.TestRef_Stat_IsChanged)
         {
         if (road_TestRef.TestRef_Stat == 0)
         {
            idb.AddParameter("@TestRef_Stat", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_Stat", road_TestRef.TestRef_Stat);
         }
          }
         if(road_TestRef.TestRef_Order_IsChanged)
         {
         if (road_TestRef.TestRef_Order == 0)
         {
            idb.AddParameter("@TestRef_Order", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_Order", road_TestRef.TestRef_Order);
         }
          }
         if(road_TestRef.TestRef_IsLast_IsChanged)
         {
         if (road_TestRef.TestRef_IsLast == 0)
         {
            idb.AddParameter("@TestRef_IsLast", 0);
         }
         else
         {
            idb.AddParameter("@TestRef_IsLast", road_TestRef.TestRef_IsLast);
         }
          }
         if(road_TestRef.Stat_IsChanged)
         {
         if (road_TestRef.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_TestRef.Stat);
         }
          }

         idb.AddParameter("@TestRef_ID", road_TestRef.TestRef_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除零件部位检测模板 Road_TestRef对象(即:一条记录
      /// </summary>
      public int Delete(Int64 testRef_ID)
      {
         string sql = "DELETE Road_TestRef WHERE 1=1  AND TestRef_ID=@TestRef_ID ";
         idb.AddParameter("@TestRef_ID", testRef_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的零件部位检测模板 Road_TestRef对象(即:一条记录
      /// </summary>
      public Road_TestRef GetByKey(Int64 testRef_ID)
      {
         Road_TestRef road_TestRef = new Road_TestRef();
         string sql = "SELECT  TestRef_ID,TestRef_RNodeID,TestRef_PartNo,TestRef_PartName,TestRef_RNodeCode,TestRef_RNodeName,TestRef_Code,TestRef_Name,TestRef_Value,TestRef_High,TestRef_Low,TestRef_Stat,TestRef_Order,TestRef_IsLast,Stat FROM Road_TestRef WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND TestRef_ID=@TestRef_ID ";
         idb.AddParameter("@TestRef_ID", testRef_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["TestRef_ID"] != DBNull.Value) road_TestRef.TestRef_ID = Convert.ToInt64(dr["TestRef_ID"]);
            if (dr["TestRef_RNodeID"] != DBNull.Value) road_TestRef.TestRef_RNodeID = Convert.ToInt32(dr["TestRef_RNodeID"]);
            if (dr["TestRef_PartNo"] != DBNull.Value) road_TestRef.TestRef_PartNo = Convert.ToString(dr["TestRef_PartNo"]);
            if (dr["TestRef_PartName"] != DBNull.Value) road_TestRef.TestRef_PartName = Convert.ToString(dr["TestRef_PartName"]);
            if (dr["TestRef_RNodeCode"] != DBNull.Value) road_TestRef.TestRef_RNodeCode = Convert.ToString(dr["TestRef_RNodeCode"]);
            if (dr["TestRef_RNodeName"] != DBNull.Value) road_TestRef.TestRef_RNodeName = Convert.ToString(dr["TestRef_RNodeName"]);
            if (dr["TestRef_Code"] != DBNull.Value) road_TestRef.TestRef_Code = Convert.ToString(dr["TestRef_Code"]);
            if (dr["TestRef_Name"] != DBNull.Value) road_TestRef.TestRef_Name = Convert.ToString(dr["TestRef_Name"]);
            if (dr["TestRef_Value"] != DBNull.Value) road_TestRef.TestRef_Value = Convert.ToString(dr["TestRef_Value"]);
            if (dr["TestRef_High"] != DBNull.Value) road_TestRef.TestRef_High = Convert.ToString(dr["TestRef_High"]);
            if (dr["TestRef_Low"] != DBNull.Value) road_TestRef.TestRef_Low = Convert.ToString(dr["TestRef_Low"]);
            if (dr["TestRef_Stat"] != DBNull.Value) road_TestRef.TestRef_Stat = Convert.ToInt32(dr["TestRef_Stat"]);
            if (dr["TestRef_Order"] != DBNull.Value) road_TestRef.TestRef_Order = Convert.ToInt32(dr["TestRef_Order"]);
            if (dr["TestRef_IsLast"] != DBNull.Value) road_TestRef.TestRef_IsLast = Convert.ToInt32(dr["TestRef_IsLast"]);
            if (dr["Stat"] != DBNull.Value) road_TestRef.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return road_TestRef;
      }
      /// <summary>
      /// 获取指定的零件部位检测模板 Road_TestRef对象集合
      /// </summary>
      public List<Road_TestRef> GetListByWhere(string strCondition)
      {
         List<Road_TestRef> ret = new List<Road_TestRef>();
         string sql = "SELECT  TestRef_ID,TestRef_RNodeID,TestRef_PartNo,TestRef_PartName,TestRef_RNodeCode,TestRef_RNodeName,TestRef_Code,TestRef_Name,TestRef_Value,TestRef_High,TestRef_Low,TestRef_Stat,TestRef_Order,TestRef_IsLast,Stat FROM Road_TestRef WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Road_TestRef road_TestRef = new Road_TestRef();
            if (dr["TestRef_ID"] != DBNull.Value) road_TestRef.TestRef_ID = Convert.ToInt64(dr["TestRef_ID"]);
            if (dr["TestRef_RNodeID"] != DBNull.Value) road_TestRef.TestRef_RNodeID = Convert.ToInt32(dr["TestRef_RNodeID"]);
            if (dr["TestRef_PartNo"] != DBNull.Value) road_TestRef.TestRef_PartNo = Convert.ToString(dr["TestRef_PartNo"]);
            if (dr["TestRef_PartName"] != DBNull.Value) road_TestRef.TestRef_PartName = Convert.ToString(dr["TestRef_PartName"]);
            if (dr["TestRef_RNodeCode"] != DBNull.Value) road_TestRef.TestRef_RNodeCode = Convert.ToString(dr["TestRef_RNodeCode"]);
            if (dr["TestRef_RNodeName"] != DBNull.Value) road_TestRef.TestRef_RNodeName = Convert.ToString(dr["TestRef_RNodeName"]);
            if (dr["TestRef_Code"] != DBNull.Value) road_TestRef.TestRef_Code = Convert.ToString(dr["TestRef_Code"]);
            if (dr["TestRef_Name"] != DBNull.Value) road_TestRef.TestRef_Name = Convert.ToString(dr["TestRef_Name"]);
            if (dr["TestRef_Value"] != DBNull.Value) road_TestRef.TestRef_Value = Convert.ToString(dr["TestRef_Value"]);
            if (dr["TestRef_High"] != DBNull.Value) road_TestRef.TestRef_High = Convert.ToString(dr["TestRef_High"]);
            if (dr["TestRef_Low"] != DBNull.Value) road_TestRef.TestRef_Low = Convert.ToString(dr["TestRef_Low"]);
            if (dr["TestRef_Stat"] != DBNull.Value) road_TestRef.TestRef_Stat = Convert.ToInt32(dr["TestRef_Stat"]);
            if (dr["TestRef_Order"] != DBNull.Value) road_TestRef.TestRef_Order = Convert.ToInt32(dr["TestRef_Order"]);
            if (dr["TestRef_IsLast"] != DBNull.Value) road_TestRef.TestRef_IsLast = Convert.ToInt32(dr["TestRef_IsLast"]);
            if (dr["Stat"] != DBNull.Value) road_TestRef.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(road_TestRef);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的零件部位检测模板 Road_TestRef对象(即:一条记录
      /// </summary>
      public List<Road_TestRef> GetAll()
      {
         List<Road_TestRef> ret = new List<Road_TestRef>();
         string sql = "SELECT  TestRef_ID,TestRef_RNodeID,TestRef_PartNo,TestRef_PartName,TestRef_RNodeCode,TestRef_RNodeName,TestRef_Code,TestRef_Name,TestRef_Value,TestRef_High,TestRef_Low,TestRef_Stat,TestRef_Order,TestRef_IsLast,Stat FROM Road_TestRef where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Road_TestRef road_TestRef = new Road_TestRef();
            if (dr["TestRef_ID"] != DBNull.Value) road_TestRef.TestRef_ID = Convert.ToInt64(dr["TestRef_ID"]);
            if (dr["TestRef_RNodeID"] != DBNull.Value) road_TestRef.TestRef_RNodeID = Convert.ToInt32(dr["TestRef_RNodeID"]);
            if (dr["TestRef_PartNo"] != DBNull.Value) road_TestRef.TestRef_PartNo = Convert.ToString(dr["TestRef_PartNo"]);
            if (dr["TestRef_PartName"] != DBNull.Value) road_TestRef.TestRef_PartName = Convert.ToString(dr["TestRef_PartName"]);
            if (dr["TestRef_RNodeCode"] != DBNull.Value) road_TestRef.TestRef_RNodeCode = Convert.ToString(dr["TestRef_RNodeCode"]);
            if (dr["TestRef_RNodeName"] != DBNull.Value) road_TestRef.TestRef_RNodeName = Convert.ToString(dr["TestRef_RNodeName"]);
            if (dr["TestRef_Code"] != DBNull.Value) road_TestRef.TestRef_Code = Convert.ToString(dr["TestRef_Code"]);
            if (dr["TestRef_Name"] != DBNull.Value) road_TestRef.TestRef_Name = Convert.ToString(dr["TestRef_Name"]);
            if (dr["TestRef_Value"] != DBNull.Value) road_TestRef.TestRef_Value = Convert.ToString(dr["TestRef_Value"]);
            if (dr["TestRef_High"] != DBNull.Value) road_TestRef.TestRef_High = Convert.ToString(dr["TestRef_High"]);
            if (dr["TestRef_Low"] != DBNull.Value) road_TestRef.TestRef_Low = Convert.ToString(dr["TestRef_Low"]);
            if (dr["TestRef_Stat"] != DBNull.Value) road_TestRef.TestRef_Stat = Convert.ToInt32(dr["TestRef_Stat"]);
            if (dr["TestRef_Order"] != DBNull.Value) road_TestRef.TestRef_Order = Convert.ToInt32(dr["TestRef_Order"]);
            if (dr["TestRef_IsLast"] != DBNull.Value) road_TestRef.TestRef_IsLast = Convert.ToInt32(dr["TestRef_IsLast"]);
            if (dr["Stat"] != DBNull.Value) road_TestRef.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(road_TestRef);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
