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
   public partial class ADOProd_TestRef
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Prod_TestRef对象(即:一条记录)
      /// </summary>
      public int Add(Prod_TestRef prod_TestRef)
      {
         string sql = "INSERT INTO Prod_TestRef (PTestRef_Code,PTestRef_ProdCode,PTestRef_NodeCode,PTestRef_NodeName,PTestRef_TestNode,PTestRef_TestName,PTestRef_RefValue,PTestRef_High,PTestRef_Low,PTestRef_Order,PTestRef_IsLast,PTestRef_PartCode,PTestRef_PartName,PTestRef_Stat,Stat) VALUES (@PTestRef_Code,@PTestRef_ProdCode,@PTestRef_NodeCode,@PTestRef_NodeName,@PTestRef_TestNode,@PTestRef_TestName,@PTestRef_RefValue,@PTestRef_High,@PTestRef_Low,@PTestRef_Order,@PTestRef_IsLast,@PTestRef_PartCode,@PTestRef_PartName,@PTestRef_Stat,@Stat)";
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_Code))
         {
            idb.AddParameter("@PTestRef_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_Code", prod_TestRef.PTestRef_Code);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_ProdCode))
         {
            idb.AddParameter("@PTestRef_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_ProdCode", prod_TestRef.PTestRef_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_NodeCode))
         {
            idb.AddParameter("@PTestRef_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_NodeCode", prod_TestRef.PTestRef_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_NodeName))
         {
            idb.AddParameter("@PTestRef_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_NodeName", prod_TestRef.PTestRef_NodeName);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_TestNode))
         {
            idb.AddParameter("@PTestRef_TestNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_TestNode", prod_TestRef.PTestRef_TestNode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_TestName))
         {
            idb.AddParameter("@PTestRef_TestName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_TestName", prod_TestRef.PTestRef_TestName);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_RefValue))
         {
            idb.AddParameter("@PTestRef_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_RefValue", prod_TestRef.PTestRef_RefValue);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_High))
         {
            idb.AddParameter("@PTestRef_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_High", prod_TestRef.PTestRef_High);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_Low))
         {
            idb.AddParameter("@PTestRef_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_Low", prod_TestRef.PTestRef_Low);
         }
         if (prod_TestRef.PTestRef_Order == 0)
         {
            idb.AddParameter("@PTestRef_Order", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_Order", prod_TestRef.PTestRef_Order);
         }
         if (prod_TestRef.PTestRef_IsLast == 0)
         {
            idb.AddParameter("@PTestRef_IsLast", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_IsLast", prod_TestRef.PTestRef_IsLast);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_PartCode))
         {
            idb.AddParameter("@PTestRef_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_PartCode", prod_TestRef.PTestRef_PartCode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_PartName))
         {
            idb.AddParameter("@PTestRef_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_PartName", prod_TestRef.PTestRef_PartName);
         }
         if (prod_TestRef.PTestRef_Stat == 0)
         {
            idb.AddParameter("@PTestRef_Stat", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_Stat", prod_TestRef.PTestRef_Stat);
         }
         if (prod_TestRef.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_TestRef.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Prod_TestRef对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_TestRef prod_TestRef)
      {
         string sql = "INSERT INTO Prod_TestRef (PTestRef_Code,PTestRef_ProdCode,PTestRef_NodeCode,PTestRef_NodeName,PTestRef_TestNode,PTestRef_TestName,PTestRef_RefValue,PTestRef_High,PTestRef_Low,PTestRef_Order,PTestRef_IsLast,PTestRef_PartCode,PTestRef_PartName,PTestRef_Stat,Stat) VALUES (@PTestRef_Code,@PTestRef_ProdCode,@PTestRef_NodeCode,@PTestRef_NodeName,@PTestRef_TestNode,@PTestRef_TestName,@PTestRef_RefValue,@PTestRef_High,@PTestRef_Low,@PTestRef_Order,@PTestRef_IsLast,@PTestRef_PartCode,@PTestRef_PartName,@PTestRef_Stat,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_Code))
         {
            idb.AddParameter("@PTestRef_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_Code", prod_TestRef.PTestRef_Code);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_ProdCode))
         {
            idb.AddParameter("@PTestRef_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_ProdCode", prod_TestRef.PTestRef_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_NodeCode))
         {
            idb.AddParameter("@PTestRef_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_NodeCode", prod_TestRef.PTestRef_NodeCode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_NodeName))
         {
            idb.AddParameter("@PTestRef_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_NodeName", prod_TestRef.PTestRef_NodeName);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_TestNode))
         {
            idb.AddParameter("@PTestRef_TestNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_TestNode", prod_TestRef.PTestRef_TestNode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_TestName))
         {
            idb.AddParameter("@PTestRef_TestName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_TestName", prod_TestRef.PTestRef_TestName);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_RefValue))
         {
            idb.AddParameter("@PTestRef_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_RefValue", prod_TestRef.PTestRef_RefValue);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_High))
         {
            idb.AddParameter("@PTestRef_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_High", prod_TestRef.PTestRef_High);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_Low))
         {
            idb.AddParameter("@PTestRef_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_Low", prod_TestRef.PTestRef_Low);
         }
         if (prod_TestRef.PTestRef_Order == 0)
         {
            idb.AddParameter("@PTestRef_Order", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_Order", prod_TestRef.PTestRef_Order);
         }
         if (prod_TestRef.PTestRef_IsLast == 0)
         {
            idb.AddParameter("@PTestRef_IsLast", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_IsLast", prod_TestRef.PTestRef_IsLast);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_PartCode))
         {
            idb.AddParameter("@PTestRef_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_PartCode", prod_TestRef.PTestRef_PartCode);
         }
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_PartName))
         {
            idb.AddParameter("@PTestRef_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_PartName", prod_TestRef.PTestRef_PartName);
         }
         if (prod_TestRef.PTestRef_Stat == 0)
         {
            idb.AddParameter("@PTestRef_Stat", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_Stat", prod_TestRef.PTestRef_Stat);
         }
         if (prod_TestRef.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_TestRef.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Prod_TestRef对象(即:一条记录
      /// </summary>
      public int Update(Prod_TestRef prod_TestRef)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_TestRef       SET ");
            if(prod_TestRef.PTestRef_Code_IsChanged){sbParameter.Append("PTestRef_Code=@PTestRef_Code, ");}
      if(prod_TestRef.PTestRef_ProdCode_IsChanged){sbParameter.Append("PTestRef_ProdCode=@PTestRef_ProdCode, ");}
      if(prod_TestRef.PTestRef_NodeCode_IsChanged){sbParameter.Append("PTestRef_NodeCode=@PTestRef_NodeCode, ");}
      if(prod_TestRef.PTestRef_NodeName_IsChanged){sbParameter.Append("PTestRef_NodeName=@PTestRef_NodeName, ");}
      if(prod_TestRef.PTestRef_TestNode_IsChanged){sbParameter.Append("PTestRef_TestNode=@PTestRef_TestNode, ");}
      if(prod_TestRef.PTestRef_TestName_IsChanged){sbParameter.Append("PTestRef_TestName=@PTestRef_TestName, ");}
      if(prod_TestRef.PTestRef_RefValue_IsChanged){sbParameter.Append("PTestRef_RefValue=@PTestRef_RefValue, ");}
      if(prod_TestRef.PTestRef_High_IsChanged){sbParameter.Append("PTestRef_High=@PTestRef_High, ");}
      if(prod_TestRef.PTestRef_Low_IsChanged){sbParameter.Append("PTestRef_Low=@PTestRef_Low, ");}
      if(prod_TestRef.PTestRef_Order_IsChanged){sbParameter.Append("PTestRef_Order=@PTestRef_Order, ");}
      if(prod_TestRef.PTestRef_IsLast_IsChanged){sbParameter.Append("PTestRef_IsLast=@PTestRef_IsLast, ");}
      if(prod_TestRef.PTestRef_PartCode_IsChanged){sbParameter.Append("PTestRef_PartCode=@PTestRef_PartCode, ");}
      if(prod_TestRef.PTestRef_PartName_IsChanged){sbParameter.Append("PTestRef_PartName=@PTestRef_PartName, ");}
      if(prod_TestRef.PTestRef_Stat_IsChanged){sbParameter.Append("PTestRef_Stat=@PTestRef_Stat, ");}
      if(prod_TestRef.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PTestRef_ID=@PTestRef_ID; " );
      string sql=sb.ToString();
         if(prod_TestRef.PTestRef_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_Code))
         {
            idb.AddParameter("@PTestRef_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_Code", prod_TestRef.PTestRef_Code);
         }
          }
         if(prod_TestRef.PTestRef_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_ProdCode))
         {
            idb.AddParameter("@PTestRef_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_ProdCode", prod_TestRef.PTestRef_ProdCode);
         }
          }
         if(prod_TestRef.PTestRef_NodeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_NodeCode))
         {
            idb.AddParameter("@PTestRef_NodeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_NodeCode", prod_TestRef.PTestRef_NodeCode);
         }
          }
         if(prod_TestRef.PTestRef_NodeName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_NodeName))
         {
            idb.AddParameter("@PTestRef_NodeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_NodeName", prod_TestRef.PTestRef_NodeName);
         }
          }
         if(prod_TestRef.PTestRef_TestNode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_TestNode))
         {
            idb.AddParameter("@PTestRef_TestNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_TestNode", prod_TestRef.PTestRef_TestNode);
         }
          }
         if(prod_TestRef.PTestRef_TestName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_TestName))
         {
            idb.AddParameter("@PTestRef_TestName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_TestName", prod_TestRef.PTestRef_TestName);
         }
          }
         if(prod_TestRef.PTestRef_RefValue_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_RefValue))
         {
            idb.AddParameter("@PTestRef_RefValue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_RefValue", prod_TestRef.PTestRef_RefValue);
         }
          }
         if(prod_TestRef.PTestRef_High_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_High))
         {
            idb.AddParameter("@PTestRef_High", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_High", prod_TestRef.PTestRef_High);
         }
          }
         if(prod_TestRef.PTestRef_Low_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_Low))
         {
            idb.AddParameter("@PTestRef_Low", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_Low", prod_TestRef.PTestRef_Low);
         }
          }
         if(prod_TestRef.PTestRef_Order_IsChanged)
         {
         if (prod_TestRef.PTestRef_Order == 0)
         {
            idb.AddParameter("@PTestRef_Order", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_Order", prod_TestRef.PTestRef_Order);
         }
          }
         if(prod_TestRef.PTestRef_IsLast_IsChanged)
         {
         if (prod_TestRef.PTestRef_IsLast == 0)
         {
            idb.AddParameter("@PTestRef_IsLast", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_IsLast", prod_TestRef.PTestRef_IsLast);
         }
          }
         if(prod_TestRef.PTestRef_PartCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_PartCode))
         {
            idb.AddParameter("@PTestRef_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_PartCode", prod_TestRef.PTestRef_PartCode);
         }
          }
         if(prod_TestRef.PTestRef_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_TestRef.PTestRef_PartName))
         {
            idb.AddParameter("@PTestRef_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PTestRef_PartName", prod_TestRef.PTestRef_PartName);
         }
          }
         if(prod_TestRef.PTestRef_Stat_IsChanged)
         {
         if (prod_TestRef.PTestRef_Stat == 0)
         {
            idb.AddParameter("@PTestRef_Stat", 0);
         }
         else
         {
            idb.AddParameter("@PTestRef_Stat", prod_TestRef.PTestRef_Stat);
         }
          }
         if(prod_TestRef.Stat_IsChanged)
         {
         if (prod_TestRef.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_TestRef.Stat);
         }
          }

         idb.AddParameter("@PTestRef_ID", prod_TestRef.PTestRef_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Prod_TestRef对象(即:一条记录
      /// </summary>
      public int Delete(Int64 pTestRef_ID)
      {
         string sql = "DELETE Prod_TestRef WHERE 1=1  AND PTestRef_ID=@PTestRef_ID ";
         idb.AddParameter("@PTestRef_ID", pTestRef_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Prod_TestRef对象(即:一条记录
      /// </summary>
      public Prod_TestRef GetByKey(Int64 pTestRef_ID)
      {
         Prod_TestRef prod_TestRef = new Prod_TestRef();
         string sql = "SELECT  PTestRef_ID,PTestRef_Code,PTestRef_ProdCode,PTestRef_NodeCode,PTestRef_NodeName,PTestRef_TestNode,PTestRef_TestName,PTestRef_RefValue,PTestRef_High,PTestRef_Low,PTestRef_Order,PTestRef_IsLast,PTestRef_PartCode,PTestRef_PartName,PTestRef_Stat,Stat FROM Prod_TestRef WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PTestRef_ID=@PTestRef_ID ";
         idb.AddParameter("@PTestRef_ID", pTestRef_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PTestRef_ID"] != DBNull.Value) prod_TestRef.PTestRef_ID = Convert.ToInt64(dr["PTestRef_ID"]);
            if (dr["PTestRef_Code"] != DBNull.Value) prod_TestRef.PTestRef_Code = Convert.ToString(dr["PTestRef_Code"]);
            if (dr["PTestRef_ProdCode"] != DBNull.Value) prod_TestRef.PTestRef_ProdCode = Convert.ToString(dr["PTestRef_ProdCode"]);
            if (dr["PTestRef_NodeCode"] != DBNull.Value) prod_TestRef.PTestRef_NodeCode = Convert.ToString(dr["PTestRef_NodeCode"]);
            if (dr["PTestRef_NodeName"] != DBNull.Value) prod_TestRef.PTestRef_NodeName = Convert.ToString(dr["PTestRef_NodeName"]);
            if (dr["PTestRef_TestNode"] != DBNull.Value) prod_TestRef.PTestRef_TestNode = Convert.ToString(dr["PTestRef_TestNode"]);
            if (dr["PTestRef_TestName"] != DBNull.Value) prod_TestRef.PTestRef_TestName = Convert.ToString(dr["PTestRef_TestName"]);
            if (dr["PTestRef_RefValue"] != DBNull.Value) prod_TestRef.PTestRef_RefValue = Convert.ToString(dr["PTestRef_RefValue"]);
            if (dr["PTestRef_High"] != DBNull.Value) prod_TestRef.PTestRef_High = Convert.ToString(dr["PTestRef_High"]);
            if (dr["PTestRef_Low"] != DBNull.Value) prod_TestRef.PTestRef_Low = Convert.ToString(dr["PTestRef_Low"]);
            if (dr["PTestRef_Order"] != DBNull.Value) prod_TestRef.PTestRef_Order = Convert.ToInt32(dr["PTestRef_Order"]);
            if (dr["PTestRef_IsLast"] != DBNull.Value) prod_TestRef.PTestRef_IsLast = Convert.ToInt32(dr["PTestRef_IsLast"]);
            if (dr["PTestRef_PartCode"] != DBNull.Value) prod_TestRef.PTestRef_PartCode = Convert.ToString(dr["PTestRef_PartCode"]);
            if (dr["PTestRef_PartName"] != DBNull.Value) prod_TestRef.PTestRef_PartName = Convert.ToString(dr["PTestRef_PartName"]);
            if (dr["PTestRef_Stat"] != DBNull.Value) prod_TestRef.PTestRef_Stat = Convert.ToInt32(dr["PTestRef_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_TestRef.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_TestRef;
      }
      /// <summary>
      /// 获取指定的Prod_TestRef对象集合
      /// </summary>
      public List<Prod_TestRef> GetListByWhere(string strCondition)
      {
         List<Prod_TestRef> ret = new List<Prod_TestRef>();
         string sql = "SELECT  PTestRef_ID,PTestRef_Code,PTestRef_ProdCode,PTestRef_NodeCode,PTestRef_NodeName,PTestRef_TestNode,PTestRef_TestName,PTestRef_RefValue,PTestRef_High,PTestRef_Low,PTestRef_Order,PTestRef_IsLast,PTestRef_PartCode,PTestRef_PartName,PTestRef_Stat,Stat FROM Prod_TestRef WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_TestRef prod_TestRef = new Prod_TestRef();
            if (dr["PTestRef_ID"] != DBNull.Value) prod_TestRef.PTestRef_ID = Convert.ToInt64(dr["PTestRef_ID"]);
            if (dr["PTestRef_Code"] != DBNull.Value) prod_TestRef.PTestRef_Code = Convert.ToString(dr["PTestRef_Code"]);
            if (dr["PTestRef_ProdCode"] != DBNull.Value) prod_TestRef.PTestRef_ProdCode = Convert.ToString(dr["PTestRef_ProdCode"]);
            if (dr["PTestRef_NodeCode"] != DBNull.Value) prod_TestRef.PTestRef_NodeCode = Convert.ToString(dr["PTestRef_NodeCode"]);
            if (dr["PTestRef_NodeName"] != DBNull.Value) prod_TestRef.PTestRef_NodeName = Convert.ToString(dr["PTestRef_NodeName"]);
            if (dr["PTestRef_TestNode"] != DBNull.Value) prod_TestRef.PTestRef_TestNode = Convert.ToString(dr["PTestRef_TestNode"]);
            if (dr["PTestRef_TestName"] != DBNull.Value) prod_TestRef.PTestRef_TestName = Convert.ToString(dr["PTestRef_TestName"]);
            if (dr["PTestRef_RefValue"] != DBNull.Value) prod_TestRef.PTestRef_RefValue = Convert.ToString(dr["PTestRef_RefValue"]);
            if (dr["PTestRef_High"] != DBNull.Value) prod_TestRef.PTestRef_High = Convert.ToString(dr["PTestRef_High"]);
            if (dr["PTestRef_Low"] != DBNull.Value) prod_TestRef.PTestRef_Low = Convert.ToString(dr["PTestRef_Low"]);
            if (dr["PTestRef_Order"] != DBNull.Value) prod_TestRef.PTestRef_Order = Convert.ToInt32(dr["PTestRef_Order"]);
            if (dr["PTestRef_IsLast"] != DBNull.Value) prod_TestRef.PTestRef_IsLast = Convert.ToInt32(dr["PTestRef_IsLast"]);
            if (dr["PTestRef_PartCode"] != DBNull.Value) prod_TestRef.PTestRef_PartCode = Convert.ToString(dr["PTestRef_PartCode"]);
            if (dr["PTestRef_PartName"] != DBNull.Value) prod_TestRef.PTestRef_PartName = Convert.ToString(dr["PTestRef_PartName"]);
            if (dr["PTestRef_Stat"] != DBNull.Value) prod_TestRef.PTestRef_Stat = Convert.ToInt32(dr["PTestRef_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_TestRef.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_TestRef);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Prod_TestRef对象(即:一条记录
      /// </summary>
      public List<Prod_TestRef> GetAll()
      {
         List<Prod_TestRef> ret = new List<Prod_TestRef>();
         string sql = "SELECT  PTestRef_ID,PTestRef_Code,PTestRef_ProdCode,PTestRef_NodeCode,PTestRef_NodeName,PTestRef_TestNode,PTestRef_TestName,PTestRef_RefValue,PTestRef_High,PTestRef_Low,PTestRef_Order,PTestRef_IsLast,PTestRef_PartCode,PTestRef_PartName,PTestRef_Stat,Stat FROM Prod_TestRef where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_TestRef prod_TestRef = new Prod_TestRef();
            if (dr["PTestRef_ID"] != DBNull.Value) prod_TestRef.PTestRef_ID = Convert.ToInt64(dr["PTestRef_ID"]);
            if (dr["PTestRef_Code"] != DBNull.Value) prod_TestRef.PTestRef_Code = Convert.ToString(dr["PTestRef_Code"]);
            if (dr["PTestRef_ProdCode"] != DBNull.Value) prod_TestRef.PTestRef_ProdCode = Convert.ToString(dr["PTestRef_ProdCode"]);
            if (dr["PTestRef_NodeCode"] != DBNull.Value) prod_TestRef.PTestRef_NodeCode = Convert.ToString(dr["PTestRef_NodeCode"]);
            if (dr["PTestRef_NodeName"] != DBNull.Value) prod_TestRef.PTestRef_NodeName = Convert.ToString(dr["PTestRef_NodeName"]);
            if (dr["PTestRef_TestNode"] != DBNull.Value) prod_TestRef.PTestRef_TestNode = Convert.ToString(dr["PTestRef_TestNode"]);
            if (dr["PTestRef_TestName"] != DBNull.Value) prod_TestRef.PTestRef_TestName = Convert.ToString(dr["PTestRef_TestName"]);
            if (dr["PTestRef_RefValue"] != DBNull.Value) prod_TestRef.PTestRef_RefValue = Convert.ToString(dr["PTestRef_RefValue"]);
            if (dr["PTestRef_High"] != DBNull.Value) prod_TestRef.PTestRef_High = Convert.ToString(dr["PTestRef_High"]);
            if (dr["PTestRef_Low"] != DBNull.Value) prod_TestRef.PTestRef_Low = Convert.ToString(dr["PTestRef_Low"]);
            if (dr["PTestRef_Order"] != DBNull.Value) prod_TestRef.PTestRef_Order = Convert.ToInt32(dr["PTestRef_Order"]);
            if (dr["PTestRef_IsLast"] != DBNull.Value) prod_TestRef.PTestRef_IsLast = Convert.ToInt32(dr["PTestRef_IsLast"]);
            if (dr["PTestRef_PartCode"] != DBNull.Value) prod_TestRef.PTestRef_PartCode = Convert.ToString(dr["PTestRef_PartCode"]);
            if (dr["PTestRef_PartName"] != DBNull.Value) prod_TestRef.PTestRef_PartName = Convert.ToString(dr["PTestRef_PartName"]);
            if (dr["PTestRef_Stat"] != DBNull.Value) prod_TestRef.PTestRef_Stat = Convert.ToInt32(dr["PTestRef_Stat"]);
            if (dr["Stat"] != DBNull.Value) prod_TestRef.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(prod_TestRef);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
