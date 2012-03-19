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
   /// 审核模板列表
   /// </summary>
   [Serializable]
   public partial class ADOAudit_Template
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加审核模板列表 Audit_Template对象(即:一条记录)
      /// </summary>
      public int Add(Audit_Template audit_Template)
      {
         string sql = "INSERT INTO Audit_Template (Template_Code,Template_Key,Template_Name,Template_Remark,Stat,Template_Table,Template_Column,Template_ColumnType) VALUES (@Template_Code,@Template_Key,@Template_Name,@Template_Remark,@Stat,@Template_Table,@Template_Column,@Template_ColumnType)";
         if (string.IsNullOrEmpty(audit_Template.Template_Code))
         {
            idb.AddParameter("@Template_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Code", audit_Template.Template_Code);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Key))
         {
            idb.AddParameter("@Template_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Key", audit_Template.Template_Key);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Name))
         {
            idb.AddParameter("@Template_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Name", audit_Template.Template_Name);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Remark))
         {
            idb.AddParameter("@Template_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Remark", audit_Template.Template_Remark);
         }
         if (audit_Template.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", audit_Template.Stat);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Table))
         {
            idb.AddParameter("@Template_Table", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Table", audit_Template.Template_Table);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Column))
         {
            idb.AddParameter("@Template_Column", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Column", audit_Template.Template_Column);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_ColumnType))
         {
            idb.AddParameter("@Template_ColumnType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_ColumnType", audit_Template.Template_ColumnType);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加审核模板列表 Audit_Template对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Audit_Template audit_Template)
      {
         string sql = "INSERT INTO Audit_Template (Template_Code,Template_Key,Template_Name,Template_Remark,Stat,Template_Table,Template_Column,Template_ColumnType) VALUES (@Template_Code,@Template_Key,@Template_Name,@Template_Remark,@Stat,@Template_Table,@Template_Column,@Template_ColumnType);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(audit_Template.Template_Code))
         {
            idb.AddParameter("@Template_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Code", audit_Template.Template_Code);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Key))
         {
            idb.AddParameter("@Template_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Key", audit_Template.Template_Key);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Name))
         {
            idb.AddParameter("@Template_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Name", audit_Template.Template_Name);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Remark))
         {
            idb.AddParameter("@Template_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Remark", audit_Template.Template_Remark);
         }
         if (audit_Template.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", audit_Template.Stat);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Table))
         {
            idb.AddParameter("@Template_Table", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Table", audit_Template.Template_Table);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_Column))
         {
            idb.AddParameter("@Template_Column", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Column", audit_Template.Template_Column);
         }
         if (string.IsNullOrEmpty(audit_Template.Template_ColumnType))
         {
            idb.AddParameter("@Template_ColumnType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_ColumnType", audit_Template.Template_ColumnType);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新审核模板列表 Audit_Template对象(即:一条记录
      /// </summary>
      public int Update(Audit_Template audit_Template)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Audit_Template       SET ");
            if(audit_Template.Template_Code_IsChanged){sbParameter.Append("Template_Code=@Template_Code, ");}
      if(audit_Template.Template_Key_IsChanged){sbParameter.Append("Template_Key=@Template_Key, ");}
      if(audit_Template.Template_Name_IsChanged){sbParameter.Append("Template_Name=@Template_Name, ");}
      if(audit_Template.Template_Remark_IsChanged){sbParameter.Append("Template_Remark=@Template_Remark, ");}
      if(audit_Template.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(audit_Template.Template_Table_IsChanged){sbParameter.Append("Template_Table=@Template_Table, ");}
      if(audit_Template.Template_Column_IsChanged){sbParameter.Append("Template_Column=@Template_Column, ");}
      if(audit_Template.Template_ColumnType_IsChanged){sbParameter.Append("Template_ColumnType=@Template_ColumnType ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Template_ID=@Template_ID; " );
      string sql=sb.ToString();
         if(audit_Template.Template_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_Code))
         {
            idb.AddParameter("@Template_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Code", audit_Template.Template_Code);
         }
          }
         if(audit_Template.Template_Key_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_Key))
         {
            idb.AddParameter("@Template_Key", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Key", audit_Template.Template_Key);
         }
          }
         if(audit_Template.Template_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_Name))
         {
            idb.AddParameter("@Template_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Name", audit_Template.Template_Name);
         }
          }
         if(audit_Template.Template_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_Remark))
         {
            idb.AddParameter("@Template_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Remark", audit_Template.Template_Remark);
         }
          }
         if(audit_Template.Stat_IsChanged)
         {
         if (audit_Template.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", audit_Template.Stat);
         }
          }
         if(audit_Template.Template_Table_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_Table))
         {
            idb.AddParameter("@Template_Table", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Table", audit_Template.Template_Table);
         }
          }
         if(audit_Template.Template_Column_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_Column))
         {
            idb.AddParameter("@Template_Column", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_Column", audit_Template.Template_Column);
         }
          }
         if(audit_Template.Template_ColumnType_IsChanged)
         {
         if (string.IsNullOrEmpty(audit_Template.Template_ColumnType))
         {
            idb.AddParameter("@Template_ColumnType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Template_ColumnType", audit_Template.Template_ColumnType);
         }
          }

         idb.AddParameter("@Template_ID", audit_Template.Template_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除审核模板列表 Audit_Template对象(即:一条记录
      /// </summary>
      public int Delete(decimal template_ID)
      {
         string sql = "DELETE Audit_Template WHERE 1=1  AND Template_ID=@Template_ID ";
         idb.AddParameter("@Template_ID", template_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的审核模板列表 Audit_Template对象(即:一条记录
      /// </summary>
      public Audit_Template GetByKey(decimal template_ID)
      {
         Audit_Template audit_Template = new Audit_Template();
         string sql = "SELECT  Template_ID,Template_Code,Template_Key,Template_Name,Template_Remark,Stat,Template_Table,Template_Column,Template_ColumnType FROM Audit_Template WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Template_ID=@Template_ID ";
         idb.AddParameter("@Template_ID", template_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Template_ID"] != DBNull.Value) audit_Template.Template_ID = Convert.ToDecimal(dr["Template_ID"]);
            if (dr["Template_Code"] != DBNull.Value) audit_Template.Template_Code = Convert.ToString(dr["Template_Code"]);
            if (dr["Template_Key"] != DBNull.Value) audit_Template.Template_Key = Convert.ToString(dr["Template_Key"]);
            if (dr["Template_Name"] != DBNull.Value) audit_Template.Template_Name = Convert.ToString(dr["Template_Name"]);
            if (dr["Template_Remark"] != DBNull.Value) audit_Template.Template_Remark = Convert.ToString(dr["Template_Remark"]);
            if (dr["Stat"] != DBNull.Value) audit_Template.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Template_Table"] != DBNull.Value) audit_Template.Template_Table = Convert.ToString(dr["Template_Table"]);
            if (dr["Template_Column"] != DBNull.Value) audit_Template.Template_Column = Convert.ToString(dr["Template_Column"]);
            if (dr["Template_ColumnType"] != DBNull.Value) audit_Template.Template_ColumnType = Convert.ToString(dr["Template_ColumnType"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return audit_Template;
      }
      /// <summary>
      /// 获取指定的审核模板列表 Audit_Template对象集合
      /// </summary>
      public List<Audit_Template> GetListByWhere(string strCondition)
      {
         List<Audit_Template> ret = new List<Audit_Template>();
         string sql = "SELECT  Template_ID,Template_Code,Template_Key,Template_Name,Template_Remark,Stat,Template_Table,Template_Column,Template_ColumnType FROM Audit_Template WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Audit_Template audit_Template = new Audit_Template();
            if (dr["Template_ID"] != DBNull.Value) audit_Template.Template_ID = Convert.ToDecimal(dr["Template_ID"]);
            if (dr["Template_Code"] != DBNull.Value) audit_Template.Template_Code = Convert.ToString(dr["Template_Code"]);
            if (dr["Template_Key"] != DBNull.Value) audit_Template.Template_Key = Convert.ToString(dr["Template_Key"]);
            if (dr["Template_Name"] != DBNull.Value) audit_Template.Template_Name = Convert.ToString(dr["Template_Name"]);
            if (dr["Template_Remark"] != DBNull.Value) audit_Template.Template_Remark = Convert.ToString(dr["Template_Remark"]);
            if (dr["Stat"] != DBNull.Value) audit_Template.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Template_Table"] != DBNull.Value) audit_Template.Template_Table = Convert.ToString(dr["Template_Table"]);
            if (dr["Template_Column"] != DBNull.Value) audit_Template.Template_Column = Convert.ToString(dr["Template_Column"]);
            if (dr["Template_ColumnType"] != DBNull.Value) audit_Template.Template_ColumnType = Convert.ToString(dr["Template_ColumnType"]);
            ret.Add(audit_Template);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的审核模板列表 Audit_Template对象(即:一条记录
      /// </summary>
      public List<Audit_Template> GetAll()
      {
         List<Audit_Template> ret = new List<Audit_Template>();
         string sql = "SELECT  Template_ID,Template_Code,Template_Key,Template_Name,Template_Remark,Stat,Template_Table,Template_Column,Template_ColumnType FROM Audit_Template where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Audit_Template audit_Template = new Audit_Template();
            if (dr["Template_ID"] != DBNull.Value) audit_Template.Template_ID = Convert.ToDecimal(dr["Template_ID"]);
            if (dr["Template_Code"] != DBNull.Value) audit_Template.Template_Code = Convert.ToString(dr["Template_Code"]);
            if (dr["Template_Key"] != DBNull.Value) audit_Template.Template_Key = Convert.ToString(dr["Template_Key"]);
            if (dr["Template_Name"] != DBNull.Value) audit_Template.Template_Name = Convert.ToString(dr["Template_Name"]);
            if (dr["Template_Remark"] != DBNull.Value) audit_Template.Template_Remark = Convert.ToString(dr["Template_Remark"]);
            if (dr["Stat"] != DBNull.Value) audit_Template.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Template_Table"] != DBNull.Value) audit_Template.Template_Table = Convert.ToString(dr["Template_Table"]);
            if (dr["Template_Column"] != DBNull.Value) audit_Template.Template_Column = Convert.ToString(dr["Template_Column"]);
            if (dr["Template_ColumnType"] != DBNull.Value) audit_Template.Template_ColumnType = Convert.ToString(dr["Template_ColumnType"]);
            ret.Add(audit_Template);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
