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
   public partial class ADOBse_Feedback
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Feedback对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Feedback bse_Feedback)
      {
         string sql = "INSERT INTO Bse_Feedback (FB_Code,FB_Customer,FB_CustomerName,FB_Contact,FB_Mobile,FB_Content,FB_Date,FB_RespDept,FB_RespDeptName,FB_Level,FB_Cate,FB_CateOther,FB_Reason,FB_ReasonOther,FB_Handle,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,FB_IsPrint,FB_Creator) VALUES (@FB_Code,@FB_Customer,@FB_CustomerName,@FB_Contact,@FB_Mobile,@FB_Content,@FB_Date,@FB_RespDept,@FB_RespDeptName,@FB_Level,@FB_Cate,@FB_CateOther,@FB_Reason,@FB_ReasonOther,@FB_Handle,@AuditStat,@AuditCurAudit,@Stat,@CreateTime,@UpdateTime,@FB_IsPrint,@FB_Creator)";
         if (string.IsNullOrEmpty(bse_Feedback.FB_Code))
         {
            idb.AddParameter("@FB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Code", bse_Feedback.FB_Code);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Customer))
         {
            idb.AddParameter("@FB_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Customer", bse_Feedback.FB_Customer);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_CustomerName))
         {
            idb.AddParameter("@FB_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_CustomerName", bse_Feedback.FB_CustomerName);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Contact))
         {
            idb.AddParameter("@FB_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Contact", bse_Feedback.FB_Contact);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Mobile))
         {
            idb.AddParameter("@FB_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Mobile", bse_Feedback.FB_Mobile);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Content))
         {
            idb.AddParameter("@FB_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Content", bse_Feedback.FB_Content);
         }
         if (bse_Feedback.FB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Date", bse_Feedback.FB_Date);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_RespDept))
         {
            idb.AddParameter("@FB_RespDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_RespDept", bse_Feedback.FB_RespDept);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_RespDeptName))
         {
            idb.AddParameter("@FB_RespDeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_RespDeptName", bse_Feedback.FB_RespDeptName);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Level))
         {
            idb.AddParameter("@FB_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Level", bse_Feedback.FB_Level);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Cate))
         {
            idb.AddParameter("@FB_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Cate", bse_Feedback.FB_Cate);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_CateOther))
         {
            idb.AddParameter("@FB_CateOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_CateOther", bse_Feedback.FB_CateOther);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Reason))
         {
            idb.AddParameter("@FB_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Reason", bse_Feedback.FB_Reason);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_ReasonOther))
         {
            idb.AddParameter("@FB_ReasonOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_ReasonOther", bse_Feedback.FB_ReasonOther);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Handle))
         {
            idb.AddParameter("@FB_Handle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Handle", bse_Feedback.FB_Handle);
         }
         if (string.IsNullOrEmpty(bse_Feedback.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_Feedback.AuditStat);
         }
         if (string.IsNullOrEmpty(bse_Feedback.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_Feedback.AuditCurAudit);
         }
         if (bse_Feedback.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Feedback.Stat);
         }
         if (bse_Feedback.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Feedback.CreateTime);
         }
         if (bse_Feedback.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Feedback.UpdateTime);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_IsPrint))
         {
            idb.AddParameter("@FB_IsPrint", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_IsPrint", bse_Feedback.FB_IsPrint);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Creator))
         {
            idb.AddParameter("@FB_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Creator", bse_Feedback.FB_Creator);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_Feedback对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Feedback bse_Feedback)
      {
         string sql = "INSERT INTO Bse_Feedback (FB_Code,FB_Customer,FB_CustomerName,FB_Contact,FB_Mobile,FB_Content,FB_Date,FB_RespDept,FB_RespDeptName,FB_Level,FB_Cate,FB_CateOther,FB_Reason,FB_ReasonOther,FB_Handle,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,FB_IsPrint,FB_Creator) VALUES (@FB_Code,@FB_Customer,@FB_CustomerName,@FB_Contact,@FB_Mobile,@FB_Content,@FB_Date,@FB_RespDept,@FB_RespDeptName,@FB_Level,@FB_Cate,@FB_CateOther,@FB_Reason,@FB_ReasonOther,@FB_Handle,@AuditStat,@AuditCurAudit,@Stat,@CreateTime,@UpdateTime,@FB_IsPrint,@FB_Creator);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Feedback.FB_Code))
         {
            idb.AddParameter("@FB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Code", bse_Feedback.FB_Code);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Customer))
         {
            idb.AddParameter("@FB_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Customer", bse_Feedback.FB_Customer);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_CustomerName))
         {
            idb.AddParameter("@FB_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_CustomerName", bse_Feedback.FB_CustomerName);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Contact))
         {
            idb.AddParameter("@FB_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Contact", bse_Feedback.FB_Contact);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Mobile))
         {
            idb.AddParameter("@FB_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Mobile", bse_Feedback.FB_Mobile);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Content))
         {
            idb.AddParameter("@FB_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Content", bse_Feedback.FB_Content);
         }
         if (bse_Feedback.FB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Date", bse_Feedback.FB_Date);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_RespDept))
         {
            idb.AddParameter("@FB_RespDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_RespDept", bse_Feedback.FB_RespDept);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_RespDeptName))
         {
            idb.AddParameter("@FB_RespDeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_RespDeptName", bse_Feedback.FB_RespDeptName);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Level))
         {
            idb.AddParameter("@FB_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Level", bse_Feedback.FB_Level);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Cate))
         {
            idb.AddParameter("@FB_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Cate", bse_Feedback.FB_Cate);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_CateOther))
         {
            idb.AddParameter("@FB_CateOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_CateOther", bse_Feedback.FB_CateOther);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Reason))
         {
            idb.AddParameter("@FB_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Reason", bse_Feedback.FB_Reason);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_ReasonOther))
         {
            idb.AddParameter("@FB_ReasonOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_ReasonOther", bse_Feedback.FB_ReasonOther);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Handle))
         {
            idb.AddParameter("@FB_Handle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Handle", bse_Feedback.FB_Handle);
         }
         if (string.IsNullOrEmpty(bse_Feedback.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_Feedback.AuditStat);
         }
         if (string.IsNullOrEmpty(bse_Feedback.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_Feedback.AuditCurAudit);
         }
         if (bse_Feedback.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Feedback.Stat);
         }
         if (bse_Feedback.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Feedback.CreateTime);
         }
         if (bse_Feedback.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Feedback.UpdateTime);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_IsPrint))
         {
            idb.AddParameter("@FB_IsPrint", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_IsPrint", bse_Feedback.FB_IsPrint);
         }
         if (string.IsNullOrEmpty(bse_Feedback.FB_Creator))
         {
            idb.AddParameter("@FB_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Creator", bse_Feedback.FB_Creator);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_Feedback对象(即:一条记录
      /// </summary>
      public int Update(Bse_Feedback bse_Feedback)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Feedback       SET ");
            if(bse_Feedback.FB_Code_IsChanged){sbParameter.Append("FB_Code=@FB_Code, ");}
      if(bse_Feedback.FB_Customer_IsChanged){sbParameter.Append("FB_Customer=@FB_Customer, ");}
      if(bse_Feedback.FB_CustomerName_IsChanged){sbParameter.Append("FB_CustomerName=@FB_CustomerName, ");}
      if(bse_Feedback.FB_Contact_IsChanged){sbParameter.Append("FB_Contact=@FB_Contact, ");}
      if(bse_Feedback.FB_Mobile_IsChanged){sbParameter.Append("FB_Mobile=@FB_Mobile, ");}
      if(bse_Feedback.FB_Content_IsChanged){sbParameter.Append("FB_Content=@FB_Content, ");}
      if(bse_Feedback.FB_Date_IsChanged){sbParameter.Append("FB_Date=@FB_Date, ");}
      if(bse_Feedback.FB_RespDept_IsChanged){sbParameter.Append("FB_RespDept=@FB_RespDept, ");}
      if(bse_Feedback.FB_RespDeptName_IsChanged){sbParameter.Append("FB_RespDeptName=@FB_RespDeptName, ");}
      if(bse_Feedback.FB_Level_IsChanged){sbParameter.Append("FB_Level=@FB_Level, ");}
      if(bse_Feedback.FB_Cate_IsChanged){sbParameter.Append("FB_Cate=@FB_Cate, ");}
      if(bse_Feedback.FB_CateOther_IsChanged){sbParameter.Append("FB_CateOther=@FB_CateOther, ");}
      if(bse_Feedback.FB_Reason_IsChanged){sbParameter.Append("FB_Reason=@FB_Reason, ");}
      if(bse_Feedback.FB_ReasonOther_IsChanged){sbParameter.Append("FB_ReasonOther=@FB_ReasonOther, ");}
      if(bse_Feedback.FB_Handle_IsChanged){sbParameter.Append("FB_Handle=@FB_Handle, ");}
      if(bse_Feedback.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(bse_Feedback.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(bse_Feedback.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Feedback.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_Feedback.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_Feedback.FB_IsPrint_IsChanged){sbParameter.Append("FB_IsPrint=@FB_IsPrint, ");}
      if(bse_Feedback.FB_Creator_IsChanged){sbParameter.Append("FB_Creator=@FB_Creator ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FB_ID=@FB_ID; " );
      string sql=sb.ToString();
         if(bse_Feedback.FB_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Code))
         {
            idb.AddParameter("@FB_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Code", bse_Feedback.FB_Code);
         }
          }
         if(bse_Feedback.FB_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Customer))
         {
            idb.AddParameter("@FB_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Customer", bse_Feedback.FB_Customer);
         }
          }
         if(bse_Feedback.FB_CustomerName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_CustomerName))
         {
            idb.AddParameter("@FB_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_CustomerName", bse_Feedback.FB_CustomerName);
         }
          }
         if(bse_Feedback.FB_Contact_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Contact))
         {
            idb.AddParameter("@FB_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Contact", bse_Feedback.FB_Contact);
         }
          }
         if(bse_Feedback.FB_Mobile_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Mobile))
         {
            idb.AddParameter("@FB_Mobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Mobile", bse_Feedback.FB_Mobile);
         }
          }
         if(bse_Feedback.FB_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Content))
         {
            idb.AddParameter("@FB_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Content", bse_Feedback.FB_Content);
         }
          }
         if(bse_Feedback.FB_Date_IsChanged)
         {
         if (bse_Feedback.FB_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FB_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Date", bse_Feedback.FB_Date);
         }
          }
         if(bse_Feedback.FB_RespDept_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_RespDept))
         {
            idb.AddParameter("@FB_RespDept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_RespDept", bse_Feedback.FB_RespDept);
         }
          }
         if(bse_Feedback.FB_RespDeptName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_RespDeptName))
         {
            idb.AddParameter("@FB_RespDeptName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_RespDeptName", bse_Feedback.FB_RespDeptName);
         }
          }
         if(bse_Feedback.FB_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Level))
         {
            idb.AddParameter("@FB_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Level", bse_Feedback.FB_Level);
         }
          }
         if(bse_Feedback.FB_Cate_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Cate))
         {
            idb.AddParameter("@FB_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Cate", bse_Feedback.FB_Cate);
         }
          }
         if(bse_Feedback.FB_CateOther_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_CateOther))
         {
            idb.AddParameter("@FB_CateOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_CateOther", bse_Feedback.FB_CateOther);
         }
          }
         if(bse_Feedback.FB_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Reason))
         {
            idb.AddParameter("@FB_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Reason", bse_Feedback.FB_Reason);
         }
          }
         if(bse_Feedback.FB_ReasonOther_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_ReasonOther))
         {
            idb.AddParameter("@FB_ReasonOther", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_ReasonOther", bse_Feedback.FB_ReasonOther);
         }
          }
         if(bse_Feedback.FB_Handle_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Handle))
         {
            idb.AddParameter("@FB_Handle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Handle", bse_Feedback.FB_Handle);
         }
          }
         if(bse_Feedback.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_Feedback.AuditStat);
         }
          }
         if(bse_Feedback.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_Feedback.AuditCurAudit);
         }
          }
         if(bse_Feedback.Stat_IsChanged)
         {
         if (bse_Feedback.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Feedback.Stat);
         }
          }
         if(bse_Feedback.CreateTime_IsChanged)
         {
         if (bse_Feedback.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Feedback.CreateTime);
         }
          }
         if(bse_Feedback.UpdateTime_IsChanged)
         {
         if (bse_Feedback.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Feedback.UpdateTime);
         }
          }
         if(bse_Feedback.FB_IsPrint_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_IsPrint))
         {
            idb.AddParameter("@FB_IsPrint", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_IsPrint", bse_Feedback.FB_IsPrint);
         }
          }
         if(bse_Feedback.FB_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Feedback.FB_Creator))
         {
            idb.AddParameter("@FB_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FB_Creator", bse_Feedback.FB_Creator);
         }
          }

         idb.AddParameter("@FB_ID", bse_Feedback.FB_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_Feedback对象(即:一条记录
      /// </summary>
      public int Delete(decimal fB_ID)
      {
         string sql = "DELETE Bse_Feedback WHERE 1=1  AND FB_ID=@FB_ID ";
         idb.AddParameter("@FB_ID", fB_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_Feedback对象(即:一条记录
      /// </summary>
      public Bse_Feedback GetByKey(decimal fB_ID)
      {
         Bse_Feedback bse_Feedback = new Bse_Feedback();
         string sql = "SELECT  FB_ID,FB_Code,FB_Customer,FB_CustomerName,FB_Contact,FB_Mobile,FB_Content,FB_Date,FB_RespDept,FB_RespDeptName,FB_Level,FB_Cate,FB_CateOther,FB_Reason,FB_ReasonOther,FB_Handle,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,FB_IsPrint,FB_Creator FROM Bse_Feedback WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FB_ID=@FB_ID ";
         idb.AddParameter("@FB_ID", fB_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FB_ID"] != DBNull.Value) bse_Feedback.FB_ID = Convert.ToDecimal(dr["FB_ID"]);
            if (dr["FB_Code"] != DBNull.Value) bse_Feedback.FB_Code = Convert.ToString(dr["FB_Code"]);
            if (dr["FB_Customer"] != DBNull.Value) bse_Feedback.FB_Customer = Convert.ToString(dr["FB_Customer"]);
            if (dr["FB_CustomerName"] != DBNull.Value) bse_Feedback.FB_CustomerName = Convert.ToString(dr["FB_CustomerName"]);
            if (dr["FB_Contact"] != DBNull.Value) bse_Feedback.FB_Contact = Convert.ToString(dr["FB_Contact"]);
            if (dr["FB_Mobile"] != DBNull.Value) bse_Feedback.FB_Mobile = Convert.ToString(dr["FB_Mobile"]);
            if (dr["FB_Content"] != DBNull.Value) bse_Feedback.FB_Content = Convert.ToString(dr["FB_Content"]);
            if (dr["FB_Date"] != DBNull.Value) bse_Feedback.FB_Date = Convert.ToDateTime(dr["FB_Date"]);
            if (dr["FB_RespDept"] != DBNull.Value) bse_Feedback.FB_RespDept = Convert.ToString(dr["FB_RespDept"]);
            if (dr["FB_RespDeptName"] != DBNull.Value) bse_Feedback.FB_RespDeptName = Convert.ToString(dr["FB_RespDeptName"]);
            if (dr["FB_Level"] != DBNull.Value) bse_Feedback.FB_Level = Convert.ToString(dr["FB_Level"]);
            if (dr["FB_Cate"] != DBNull.Value) bse_Feedback.FB_Cate = Convert.ToString(dr["FB_Cate"]);
            if (dr["FB_CateOther"] != DBNull.Value) bse_Feedback.FB_CateOther = Convert.ToString(dr["FB_CateOther"]);
            if (dr["FB_Reason"] != DBNull.Value) bse_Feedback.FB_Reason = Convert.ToString(dr["FB_Reason"]);
            if (dr["FB_ReasonOther"] != DBNull.Value) bse_Feedback.FB_ReasonOther = Convert.ToString(dr["FB_ReasonOther"]);
            if (dr["FB_Handle"] != DBNull.Value) bse_Feedback.FB_Handle = Convert.ToString(dr["FB_Handle"]);
            if (dr["AuditStat"] != DBNull.Value) bse_Feedback.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_Feedback.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) bse_Feedback.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Feedback.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Feedback.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["FB_IsPrint"] != DBNull.Value) bse_Feedback.FB_IsPrint = Convert.ToString(dr["FB_IsPrint"]);
            if (dr["FB_Creator"] != DBNull.Value) bse_Feedback.FB_Creator = Convert.ToString(dr["FB_Creator"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Feedback;
      }
      /// <summary>
      /// 获取指定的Bse_Feedback对象集合
      /// </summary>
      public List<Bse_Feedback> GetListByWhere(string strCondition)
      {
         List<Bse_Feedback> ret = new List<Bse_Feedback>();
         string sql = "SELECT  FB_ID,FB_Code,FB_Customer,FB_CustomerName,FB_Contact,FB_Mobile,FB_Content,FB_Date,FB_RespDept,FB_RespDeptName,FB_Level,FB_Cate,FB_CateOther,FB_Reason,FB_ReasonOther,FB_Handle,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,FB_IsPrint,FB_Creator FROM Bse_Feedback WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Feedback bse_Feedback = new Bse_Feedback();
            if (dr["FB_ID"] != DBNull.Value) bse_Feedback.FB_ID = Convert.ToDecimal(dr["FB_ID"]);
            if (dr["FB_Code"] != DBNull.Value) bse_Feedback.FB_Code = Convert.ToString(dr["FB_Code"]);
            if (dr["FB_Customer"] != DBNull.Value) bse_Feedback.FB_Customer = Convert.ToString(dr["FB_Customer"]);
            if (dr["FB_CustomerName"] != DBNull.Value) bse_Feedback.FB_CustomerName = Convert.ToString(dr["FB_CustomerName"]);
            if (dr["FB_Contact"] != DBNull.Value) bse_Feedback.FB_Contact = Convert.ToString(dr["FB_Contact"]);
            if (dr["FB_Mobile"] != DBNull.Value) bse_Feedback.FB_Mobile = Convert.ToString(dr["FB_Mobile"]);
            if (dr["FB_Content"] != DBNull.Value) bse_Feedback.FB_Content = Convert.ToString(dr["FB_Content"]);
            if (dr["FB_Date"] != DBNull.Value) bse_Feedback.FB_Date = Convert.ToDateTime(dr["FB_Date"]);
            if (dr["FB_RespDept"] != DBNull.Value) bse_Feedback.FB_RespDept = Convert.ToString(dr["FB_RespDept"]);
            if (dr["FB_RespDeptName"] != DBNull.Value) bse_Feedback.FB_RespDeptName = Convert.ToString(dr["FB_RespDeptName"]);
            if (dr["FB_Level"] != DBNull.Value) bse_Feedback.FB_Level = Convert.ToString(dr["FB_Level"]);
            if (dr["FB_Cate"] != DBNull.Value) bse_Feedback.FB_Cate = Convert.ToString(dr["FB_Cate"]);
            if (dr["FB_CateOther"] != DBNull.Value) bse_Feedback.FB_CateOther = Convert.ToString(dr["FB_CateOther"]);
            if (dr["FB_Reason"] != DBNull.Value) bse_Feedback.FB_Reason = Convert.ToString(dr["FB_Reason"]);
            if (dr["FB_ReasonOther"] != DBNull.Value) bse_Feedback.FB_ReasonOther = Convert.ToString(dr["FB_ReasonOther"]);
            if (dr["FB_Handle"] != DBNull.Value) bse_Feedback.FB_Handle = Convert.ToString(dr["FB_Handle"]);
            if (dr["AuditStat"] != DBNull.Value) bse_Feedback.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_Feedback.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) bse_Feedback.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Feedback.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Feedback.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["FB_IsPrint"] != DBNull.Value) bse_Feedback.FB_IsPrint = Convert.ToString(dr["FB_IsPrint"]);
            if (dr["FB_Creator"] != DBNull.Value) bse_Feedback.FB_Creator = Convert.ToString(dr["FB_Creator"]);
            ret.Add(bse_Feedback);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Feedback对象(即:一条记录
      /// </summary>
      public List<Bse_Feedback> GetAll()
      {
         List<Bse_Feedback> ret = new List<Bse_Feedback>();
         string sql = "SELECT  FB_ID,FB_Code,FB_Customer,FB_CustomerName,FB_Contact,FB_Mobile,FB_Content,FB_Date,FB_RespDept,FB_RespDeptName,FB_Level,FB_Cate,FB_CateOther,FB_Reason,FB_ReasonOther,FB_Handle,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,FB_IsPrint,FB_Creator FROM Bse_Feedback where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Feedback bse_Feedback = new Bse_Feedback();
            if (dr["FB_ID"] != DBNull.Value) bse_Feedback.FB_ID = Convert.ToDecimal(dr["FB_ID"]);
            if (dr["FB_Code"] != DBNull.Value) bse_Feedback.FB_Code = Convert.ToString(dr["FB_Code"]);
            if (dr["FB_Customer"] != DBNull.Value) bse_Feedback.FB_Customer = Convert.ToString(dr["FB_Customer"]);
            if (dr["FB_CustomerName"] != DBNull.Value) bse_Feedback.FB_CustomerName = Convert.ToString(dr["FB_CustomerName"]);
            if (dr["FB_Contact"] != DBNull.Value) bse_Feedback.FB_Contact = Convert.ToString(dr["FB_Contact"]);
            if (dr["FB_Mobile"] != DBNull.Value) bse_Feedback.FB_Mobile = Convert.ToString(dr["FB_Mobile"]);
            if (dr["FB_Content"] != DBNull.Value) bse_Feedback.FB_Content = Convert.ToString(dr["FB_Content"]);
            if (dr["FB_Date"] != DBNull.Value) bse_Feedback.FB_Date = Convert.ToDateTime(dr["FB_Date"]);
            if (dr["FB_RespDept"] != DBNull.Value) bse_Feedback.FB_RespDept = Convert.ToString(dr["FB_RespDept"]);
            if (dr["FB_RespDeptName"] != DBNull.Value) bse_Feedback.FB_RespDeptName = Convert.ToString(dr["FB_RespDeptName"]);
            if (dr["FB_Level"] != DBNull.Value) bse_Feedback.FB_Level = Convert.ToString(dr["FB_Level"]);
            if (dr["FB_Cate"] != DBNull.Value) bse_Feedback.FB_Cate = Convert.ToString(dr["FB_Cate"]);
            if (dr["FB_CateOther"] != DBNull.Value) bse_Feedback.FB_CateOther = Convert.ToString(dr["FB_CateOther"]);
            if (dr["FB_Reason"] != DBNull.Value) bse_Feedback.FB_Reason = Convert.ToString(dr["FB_Reason"]);
            if (dr["FB_ReasonOther"] != DBNull.Value) bse_Feedback.FB_ReasonOther = Convert.ToString(dr["FB_ReasonOther"]);
            if (dr["FB_Handle"] != DBNull.Value) bse_Feedback.FB_Handle = Convert.ToString(dr["FB_Handle"]);
            if (dr["AuditStat"] != DBNull.Value) bse_Feedback.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_Feedback.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) bse_Feedback.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Feedback.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Feedback.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["FB_IsPrint"] != DBNull.Value) bse_Feedback.FB_IsPrint = Convert.ToString(dr["FB_IsPrint"]);
            if (dr["FB_Creator"] != DBNull.Value) bse_Feedback.FB_Creator = Convert.ToString(dr["FB_Creator"]);
            ret.Add(bse_Feedback);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
