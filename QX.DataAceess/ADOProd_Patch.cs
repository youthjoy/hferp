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
   public partial class ADOProd_Patch
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Prod_Patch对象(即:一条记录)
      /// </summary>
      public int Add(Prod_Patch prod_Patch)
      {
         string sql = "INSERT INTO Prod_Patch (PP_Module,PP_Code,PP_PlanCode,PP_ProdCode,PP_iType,PP_Type,PP_PartNo,PP_PartName,Stat,PP_IsMain) VALUES (@PP_Module,@PP_Code,@PP_PlanCode,@PP_ProdCode,@PP_iType,@PP_Type,@PP_PartNo,@PP_PartName,@Stat,@PP_IsMain)";
         if (string.IsNullOrEmpty(prod_Patch.PP_Module))
         {
            idb.AddParameter("@PP_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Module", prod_Patch.PP_Module);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_Code))
         {
            idb.AddParameter("@PP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Code", prod_Patch.PP_Code);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_PlanCode))
         {
            idb.AddParameter("@PP_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PlanCode", prod_Patch.PP_PlanCode);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_ProdCode))
         {
            idb.AddParameter("@PP_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_ProdCode", prod_Patch.PP_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_iType))
         {
            idb.AddParameter("@PP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_iType", prod_Patch.PP_iType);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_Type))
         {
            idb.AddParameter("@PP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Type", prod_Patch.PP_Type);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_PartNo))
         {
            idb.AddParameter("@PP_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PartNo", prod_Patch.PP_PartNo);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_PartName))
         {
            idb.AddParameter("@PP_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PartName", prod_Patch.PP_PartName);
         }
         if (prod_Patch.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Patch.Stat);
         }
         if (prod_Patch.PP_IsMain == 0)
         {
            idb.AddParameter("@PP_IsMain", 0);
         }
         else
         {
            idb.AddParameter("@PP_IsMain", prod_Patch.PP_IsMain);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Prod_Patch对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Prod_Patch prod_Patch)
      {
         string sql = "INSERT INTO Prod_Patch (PP_Module,PP_Code,PP_PlanCode,PP_ProdCode,PP_iType,PP_Type,PP_PartNo,PP_PartName,Stat,PP_IsMain) VALUES (@PP_Module,@PP_Code,@PP_PlanCode,@PP_ProdCode,@PP_iType,@PP_Type,@PP_PartNo,@PP_PartName,@Stat,@PP_IsMain);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(prod_Patch.PP_Module))
         {
            idb.AddParameter("@PP_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Module", prod_Patch.PP_Module);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_Code))
         {
            idb.AddParameter("@PP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Code", prod_Patch.PP_Code);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_PlanCode))
         {
            idb.AddParameter("@PP_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PlanCode", prod_Patch.PP_PlanCode);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_ProdCode))
         {
            idb.AddParameter("@PP_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_ProdCode", prod_Patch.PP_ProdCode);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_iType))
         {
            idb.AddParameter("@PP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_iType", prod_Patch.PP_iType);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_Type))
         {
            idb.AddParameter("@PP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Type", prod_Patch.PP_Type);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_PartNo))
         {
            idb.AddParameter("@PP_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PartNo", prod_Patch.PP_PartNo);
         }
         if (string.IsNullOrEmpty(prod_Patch.PP_PartName))
         {
            idb.AddParameter("@PP_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PartName", prod_Patch.PP_PartName);
         }
         if (prod_Patch.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Patch.Stat);
         }
         if (prod_Patch.PP_IsMain == 0)
         {
            idb.AddParameter("@PP_IsMain", 0);
         }
         else
         {
            idb.AddParameter("@PP_IsMain", prod_Patch.PP_IsMain);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Prod_Patch对象(即:一条记录
      /// </summary>
      public int Update(Prod_Patch prod_Patch)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Prod_Patch       SET ");
            if(prod_Patch.PP_Module_IsChanged){sbParameter.Append("PP_Module=@PP_Module, ");}
      if(prod_Patch.PP_Code_IsChanged){sbParameter.Append("PP_Code=@PP_Code, ");}
      if(prod_Patch.PP_PlanCode_IsChanged){sbParameter.Append("PP_PlanCode=@PP_PlanCode, ");}
      if(prod_Patch.PP_ProdCode_IsChanged){sbParameter.Append("PP_ProdCode=@PP_ProdCode, ");}
      if(prod_Patch.PP_iType_IsChanged){sbParameter.Append("PP_iType=@PP_iType, ");}
      if(prod_Patch.PP_Type_IsChanged){sbParameter.Append("PP_Type=@PP_Type, ");}
      if(prod_Patch.PP_PartNo_IsChanged){sbParameter.Append("PP_PartNo=@PP_PartNo, ");}
      if(prod_Patch.PP_PartName_IsChanged){sbParameter.Append("PP_PartName=@PP_PartName, ");}
      if(prod_Patch.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(prod_Patch.PP_IsMain_IsChanged){sbParameter.Append("PP_IsMain=@PP_IsMain ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PP_ID=@PP_ID; " );
      string sql=sb.ToString();
         if(prod_Patch.PP_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_Module))
         {
            idb.AddParameter("@PP_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Module", prod_Patch.PP_Module);
         }
          }
         if(prod_Patch.PP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_Code))
         {
            idb.AddParameter("@PP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Code", prod_Patch.PP_Code);
         }
          }
         if(prod_Patch.PP_PlanCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_PlanCode))
         {
            idb.AddParameter("@PP_PlanCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PlanCode", prod_Patch.PP_PlanCode);
         }
          }
         if(prod_Patch.PP_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_ProdCode))
         {
            idb.AddParameter("@PP_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_ProdCode", prod_Patch.PP_ProdCode);
         }
          }
         if(prod_Patch.PP_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_iType))
         {
            idb.AddParameter("@PP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_iType", prod_Patch.PP_iType);
         }
          }
         if(prod_Patch.PP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_Type))
         {
            idb.AddParameter("@PP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_Type", prod_Patch.PP_Type);
         }
          }
         if(prod_Patch.PP_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_PartNo))
         {
            idb.AddParameter("@PP_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PartNo", prod_Patch.PP_PartNo);
         }
          }
         if(prod_Patch.PP_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(prod_Patch.PP_PartName))
         {
            idb.AddParameter("@PP_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PP_PartName", prod_Patch.PP_PartName);
         }
          }
         if(prod_Patch.Stat_IsChanged)
         {
         if (prod_Patch.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", prod_Patch.Stat);
         }
          }
         if(prod_Patch.PP_IsMain_IsChanged)
         {
         if (prod_Patch.PP_IsMain == 0)
         {
            idb.AddParameter("@PP_IsMain", 0);
         }
         else
         {
            idb.AddParameter("@PP_IsMain", prod_Patch.PP_IsMain);
         }
          }

         idb.AddParameter("@PP_ID", prod_Patch.PP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Prod_Patch对象(即:一条记录
      /// </summary>
      public int Delete(decimal pP_ID)
      {
         string sql = "DELETE Prod_Patch WHERE 1=1  AND PP_ID=@PP_ID ";
         idb.AddParameter("@PP_ID", pP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Prod_Patch对象(即:一条记录
      /// </summary>
      public Prod_Patch GetByKey(decimal pP_ID)
      {
         Prod_Patch prod_Patch = new Prod_Patch();
         string sql = "SELECT  PP_ID,PP_Module,PP_Code,PP_PlanCode,PP_ProdCode,PP_iType,PP_Type,PP_PartNo,PP_PartName,Stat,PP_IsMain FROM Prod_Patch WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PP_ID=@PP_ID ";
         idb.AddParameter("@PP_ID", pP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PP_ID"] != DBNull.Value) prod_Patch.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_Module"] != DBNull.Value) prod_Patch.PP_Module = Convert.ToString(dr["PP_Module"]);
            if (dr["PP_Code"] != DBNull.Value) prod_Patch.PP_Code = Convert.ToString(dr["PP_Code"]);
            if (dr["PP_PlanCode"] != DBNull.Value) prod_Patch.PP_PlanCode = Convert.ToString(dr["PP_PlanCode"]);
            if (dr["PP_ProdCode"] != DBNull.Value) prod_Patch.PP_ProdCode = Convert.ToString(dr["PP_ProdCode"]);
            if (dr["PP_iType"] != DBNull.Value) prod_Patch.PP_iType = Convert.ToString(dr["PP_iType"]);
            if (dr["PP_Type"] != DBNull.Value) prod_Patch.PP_Type = Convert.ToString(dr["PP_Type"]);
            if (dr["PP_PartNo"] != DBNull.Value) prod_Patch.PP_PartNo = Convert.ToString(dr["PP_PartNo"]);
            if (dr["PP_PartName"] != DBNull.Value) prod_Patch.PP_PartName = Convert.ToString(dr["PP_PartName"]);
            if (dr["Stat"] != DBNull.Value) prod_Patch.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PP_IsMain"] != DBNull.Value) prod_Patch.PP_IsMain = Convert.ToInt32(dr["PP_IsMain"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return prod_Patch;
      }
      /// <summary>
      /// 获取指定的Prod_Patch对象集合
      /// </summary>
      public List<Prod_Patch> GetListByWhere(string strCondition)
      {
         List<Prod_Patch> ret = new List<Prod_Patch>();
         string sql = "SELECT  PP_ID,PP_Module,PP_Code,PP_PlanCode,PP_ProdCode,PP_iType,PP_Type,PP_PartNo,PP_PartName,Stat,PP_IsMain FROM Prod_Patch WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Prod_Patch prod_Patch = new Prod_Patch();
            if (dr["PP_ID"] != DBNull.Value) prod_Patch.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_Module"] != DBNull.Value) prod_Patch.PP_Module = Convert.ToString(dr["PP_Module"]);
            if (dr["PP_Code"] != DBNull.Value) prod_Patch.PP_Code = Convert.ToString(dr["PP_Code"]);
            if (dr["PP_PlanCode"] != DBNull.Value) prod_Patch.PP_PlanCode = Convert.ToString(dr["PP_PlanCode"]);
            if (dr["PP_ProdCode"] != DBNull.Value) prod_Patch.PP_ProdCode = Convert.ToString(dr["PP_ProdCode"]);
            if (dr["PP_iType"] != DBNull.Value) prod_Patch.PP_iType = Convert.ToString(dr["PP_iType"]);
            if (dr["PP_Type"] != DBNull.Value) prod_Patch.PP_Type = Convert.ToString(dr["PP_Type"]);
            if (dr["PP_PartNo"] != DBNull.Value) prod_Patch.PP_PartNo = Convert.ToString(dr["PP_PartNo"]);
            if (dr["PP_PartName"] != DBNull.Value) prod_Patch.PP_PartName = Convert.ToString(dr["PP_PartName"]);
            if (dr["Stat"] != DBNull.Value) prod_Patch.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PP_IsMain"] != DBNull.Value) prod_Patch.PP_IsMain = Convert.ToInt32(dr["PP_IsMain"]);
            ret.Add(prod_Patch);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Prod_Patch对象(即:一条记录
      /// </summary>
      public List<Prod_Patch> GetAll()
      {
         List<Prod_Patch> ret = new List<Prod_Patch>();
         string sql = "SELECT  PP_ID,PP_Module,PP_Code,PP_PlanCode,PP_ProdCode,PP_iType,PP_Type,PP_PartNo,PP_PartName,Stat,PP_IsMain FROM Prod_Patch where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Prod_Patch prod_Patch = new Prod_Patch();
            if (dr["PP_ID"] != DBNull.Value) prod_Patch.PP_ID = Convert.ToDecimal(dr["PP_ID"]);
            if (dr["PP_Module"] != DBNull.Value) prod_Patch.PP_Module = Convert.ToString(dr["PP_Module"]);
            if (dr["PP_Code"] != DBNull.Value) prod_Patch.PP_Code = Convert.ToString(dr["PP_Code"]);
            if (dr["PP_PlanCode"] != DBNull.Value) prod_Patch.PP_PlanCode = Convert.ToString(dr["PP_PlanCode"]);
            if (dr["PP_ProdCode"] != DBNull.Value) prod_Patch.PP_ProdCode = Convert.ToString(dr["PP_ProdCode"]);
            if (dr["PP_iType"] != DBNull.Value) prod_Patch.PP_iType = Convert.ToString(dr["PP_iType"]);
            if (dr["PP_Type"] != DBNull.Value) prod_Patch.PP_Type = Convert.ToString(dr["PP_Type"]);
            if (dr["PP_PartNo"] != DBNull.Value) prod_Patch.PP_PartNo = Convert.ToString(dr["PP_PartNo"]);
            if (dr["PP_PartName"] != DBNull.Value) prod_Patch.PP_PartName = Convert.ToString(dr["PP_PartName"]);
            if (dr["Stat"] != DBNull.Value) prod_Patch.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PP_IsMain"] != DBNull.Value) prod_Patch.PP_IsMain = Convert.ToInt32(dr["PP_IsMain"]);
            ret.Add(prod_Patch);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
