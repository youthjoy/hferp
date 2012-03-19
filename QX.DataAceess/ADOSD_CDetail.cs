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
   /// 合同细目信息
   /// </summary>
   [Serializable]
   public partial class ADOSD_CDetail
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加合同细目信息 SD_CDetail对象(即:一条记录)
      /// </summary>
      public int Add(SD_CDetail sD_CDetail)
      {
         string sql = "INSERT INTO SD_CDetail (CDetail_Code,CDetail_PartNo,CDetail_PartName,CDetail_Num,CDetail_Price,CDetail_Intro,CDetail_Bak,CDetail_OnNum,CDetail_FNum,CDetail_DNum,CDetail_ContractNo,Stat,CDetail_Date,CDetail_Cmd,CDetail_Project,CDetail_Sum,CDetail_NoTax,CDetail_ProdCode,CDetail_Unit,CDetail_PRRelation,CDetail_Finance) VALUES (@CDetail_Code,@CDetail_PartNo,@CDetail_PartName,@CDetail_Num,@CDetail_Price,@CDetail_Intro,@CDetail_Bak,@CDetail_OnNum,@CDetail_FNum,@CDetail_DNum,@CDetail_ContractNo,@Stat,@CDetail_Date,@CDetail_Cmd,@CDetail_Project,@CDetail_Sum,@CDetail_NoTax,@CDetail_ProdCode,@CDetail_Unit,@CDetail_PRRelation,@CDetail_Finance)";
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Code))
         {
            idb.AddParameter("@CDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Code", sD_CDetail.CDetail_Code);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PartNo))
         {
            idb.AddParameter("@CDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PartNo", sD_CDetail.CDetail_PartNo);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PartName))
         {
            idb.AddParameter("@CDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PartName", sD_CDetail.CDetail_PartName);
         }
         if (sD_CDetail.CDetail_Num == 0)
         {
            idb.AddParameter("@CDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Num", sD_CDetail.CDetail_Num);
         }
         if (sD_CDetail.CDetail_Price == 0)
         {
            idb.AddParameter("@CDetail_Price", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Price", sD_CDetail.CDetail_Price);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Intro))
         {
            idb.AddParameter("@CDetail_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Intro", sD_CDetail.CDetail_Intro);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Bak))
         {
            idb.AddParameter("@CDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Bak", sD_CDetail.CDetail_Bak);
         }
         if (sD_CDetail.CDetail_OnNum == 0)
         {
            idb.AddParameter("@CDetail_OnNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_OnNum", sD_CDetail.CDetail_OnNum);
         }
         if (sD_CDetail.CDetail_FNum == 0)
         {
            idb.AddParameter("@CDetail_FNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_FNum", sD_CDetail.CDetail_FNum);
         }
         if (sD_CDetail.CDetail_DNum == 0)
         {
            idb.AddParameter("@CDetail_DNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_DNum", sD_CDetail.CDetail_DNum);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_ContractNo))
         {
            idb.AddParameter("@CDetail_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_ContractNo", sD_CDetail.CDetail_ContractNo);
         }
         if (sD_CDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CDetail.Stat);
         }
         if (sD_CDetail.CDetail_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CDetail_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Date", sD_CDetail.CDetail_Date);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Cmd))
         {
            idb.AddParameter("@CDetail_Cmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Cmd", sD_CDetail.CDetail_Cmd);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Project))
         {
            idb.AddParameter("@CDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Project", sD_CDetail.CDetail_Project);
         }
         if (sD_CDetail.CDetail_Sum == 0)
         {
            idb.AddParameter("@CDetail_Sum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Sum", sD_CDetail.CDetail_Sum);
         }
         if (sD_CDetail.CDetail_NoTax == 0)
         {
            idb.AddParameter("@CDetail_NoTax", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_NoTax", sD_CDetail.CDetail_NoTax);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_ProdCode))
         {
            idb.AddParameter("@CDetail_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_ProdCode", sD_CDetail.CDetail_ProdCode);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Unit))
         {
            idb.AddParameter("@CDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Unit", sD_CDetail.CDetail_Unit);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PRRelation))
         {
            idb.AddParameter("@CDetail_PRRelation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PRRelation", sD_CDetail.CDetail_PRRelation);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Finance))
         {
            idb.AddParameter("@CDetail_Finance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Finance", sD_CDetail.CDetail_Finance);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加合同细目信息 SD_CDetail对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_CDetail sD_CDetail)
      {
         string sql = "INSERT INTO SD_CDetail (CDetail_Code,CDetail_PartNo,CDetail_PartName,CDetail_Num,CDetail_Price,CDetail_Intro,CDetail_Bak,CDetail_OnNum,CDetail_FNum,CDetail_DNum,CDetail_ContractNo,Stat,CDetail_Date,CDetail_Cmd,CDetail_Project,CDetail_Sum,CDetail_NoTax,CDetail_ProdCode,CDetail_Unit,CDetail_PRRelation,CDetail_Finance) VALUES (@CDetail_Code,@CDetail_PartNo,@CDetail_PartName,@CDetail_Num,@CDetail_Price,@CDetail_Intro,@CDetail_Bak,@CDetail_OnNum,@CDetail_FNum,@CDetail_DNum,@CDetail_ContractNo,@Stat,@CDetail_Date,@CDetail_Cmd,@CDetail_Project,@CDetail_Sum,@CDetail_NoTax,@CDetail_ProdCode,@CDetail_Unit,@CDetail_PRRelation,@CDetail_Finance);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Code))
         {
            idb.AddParameter("@CDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Code", sD_CDetail.CDetail_Code);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PartNo))
         {
            idb.AddParameter("@CDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PartNo", sD_CDetail.CDetail_PartNo);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PartName))
         {
            idb.AddParameter("@CDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PartName", sD_CDetail.CDetail_PartName);
         }
         if (sD_CDetail.CDetail_Num == 0)
         {
            idb.AddParameter("@CDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Num", sD_CDetail.CDetail_Num);
         }
         if (sD_CDetail.CDetail_Price == 0)
         {
            idb.AddParameter("@CDetail_Price", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Price", sD_CDetail.CDetail_Price);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Intro))
         {
            idb.AddParameter("@CDetail_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Intro", sD_CDetail.CDetail_Intro);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Bak))
         {
            idb.AddParameter("@CDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Bak", sD_CDetail.CDetail_Bak);
         }
         if (sD_CDetail.CDetail_OnNum == 0)
         {
            idb.AddParameter("@CDetail_OnNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_OnNum", sD_CDetail.CDetail_OnNum);
         }
         if (sD_CDetail.CDetail_FNum == 0)
         {
            idb.AddParameter("@CDetail_FNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_FNum", sD_CDetail.CDetail_FNum);
         }
         if (sD_CDetail.CDetail_DNum == 0)
         {
            idb.AddParameter("@CDetail_DNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_DNum", sD_CDetail.CDetail_DNum);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_ContractNo))
         {
            idb.AddParameter("@CDetail_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_ContractNo", sD_CDetail.CDetail_ContractNo);
         }
         if (sD_CDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CDetail.Stat);
         }
         if (sD_CDetail.CDetail_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CDetail_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Date", sD_CDetail.CDetail_Date);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Cmd))
         {
            idb.AddParameter("@CDetail_Cmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Cmd", sD_CDetail.CDetail_Cmd);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Project))
         {
            idb.AddParameter("@CDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Project", sD_CDetail.CDetail_Project);
         }
         if (sD_CDetail.CDetail_Sum == 0)
         {
            idb.AddParameter("@CDetail_Sum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Sum", sD_CDetail.CDetail_Sum);
         }
         if (sD_CDetail.CDetail_NoTax == 0)
         {
            idb.AddParameter("@CDetail_NoTax", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_NoTax", sD_CDetail.CDetail_NoTax);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_ProdCode))
         {
            idb.AddParameter("@CDetail_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_ProdCode", sD_CDetail.CDetail_ProdCode);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Unit))
         {
            idb.AddParameter("@CDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Unit", sD_CDetail.CDetail_Unit);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PRRelation))
         {
            idb.AddParameter("@CDetail_PRRelation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PRRelation", sD_CDetail.CDetail_PRRelation);
         }
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Finance))
         {
            idb.AddParameter("@CDetail_Finance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Finance", sD_CDetail.CDetail_Finance);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新合同细目信息 SD_CDetail对象(即:一条记录
      /// </summary>
      public int Update(SD_CDetail sD_CDetail)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_CDetail       SET ");
            if(sD_CDetail.CDetail_Code_IsChanged){sbParameter.Append("CDetail_Code=@CDetail_Code, ");}
      if(sD_CDetail.CDetail_PartNo_IsChanged){sbParameter.Append("CDetail_PartNo=@CDetail_PartNo, ");}
      if(sD_CDetail.CDetail_PartName_IsChanged){sbParameter.Append("CDetail_PartName=@CDetail_PartName, ");}
      if(sD_CDetail.CDetail_Num_IsChanged){sbParameter.Append("CDetail_Num=@CDetail_Num, ");}
      if(sD_CDetail.CDetail_Price_IsChanged){sbParameter.Append("CDetail_Price=@CDetail_Price, ");}
      if(sD_CDetail.CDetail_Intro_IsChanged){sbParameter.Append("CDetail_Intro=@CDetail_Intro, ");}
      if(sD_CDetail.CDetail_Bak_IsChanged){sbParameter.Append("CDetail_Bak=@CDetail_Bak, ");}
      if(sD_CDetail.CDetail_OnNum_IsChanged){sbParameter.Append("CDetail_OnNum=@CDetail_OnNum, ");}
      if(sD_CDetail.CDetail_FNum_IsChanged){sbParameter.Append("CDetail_FNum=@CDetail_FNum, ");}
      if(sD_CDetail.CDetail_DNum_IsChanged){sbParameter.Append("CDetail_DNum=@CDetail_DNum, ");}
      if(sD_CDetail.CDetail_ContractNo_IsChanged){sbParameter.Append("CDetail_ContractNo=@CDetail_ContractNo, ");}
      if(sD_CDetail.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_CDetail.CDetail_Date_IsChanged){sbParameter.Append("CDetail_Date=@CDetail_Date, ");}
      if(sD_CDetail.CDetail_Cmd_IsChanged){sbParameter.Append("CDetail_Cmd=@CDetail_Cmd, ");}
      if(sD_CDetail.CDetail_Project_IsChanged){sbParameter.Append("CDetail_Project=@CDetail_Project, ");}
      if(sD_CDetail.CDetail_Sum_IsChanged){sbParameter.Append("CDetail_Sum=@CDetail_Sum, ");}
      if(sD_CDetail.CDetail_NoTax_IsChanged){sbParameter.Append("CDetail_NoTax=@CDetail_NoTax, ");}
      if(sD_CDetail.CDetail_ProdCode_IsChanged){sbParameter.Append("CDetail_ProdCode=@CDetail_ProdCode, ");}
      if(sD_CDetail.CDetail_Unit_IsChanged){sbParameter.Append("CDetail_Unit=@CDetail_Unit, ");}
      if(sD_CDetail.CDetail_PRRelation_IsChanged){sbParameter.Append("CDetail_PRRelation=@CDetail_PRRelation, ");}
      if(sD_CDetail.CDetail_Finance_IsChanged){sbParameter.Append("CDetail_Finance=@CDetail_Finance ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CDetail_ID=@CDetail_ID; " );
      string sql=sb.ToString();
         if(sD_CDetail.CDetail_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Code))
         {
            idb.AddParameter("@CDetail_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Code", sD_CDetail.CDetail_Code);
         }
          }
         if(sD_CDetail.CDetail_PartNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PartNo))
         {
            idb.AddParameter("@CDetail_PartNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PartNo", sD_CDetail.CDetail_PartNo);
         }
          }
         if(sD_CDetail.CDetail_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PartName))
         {
            idb.AddParameter("@CDetail_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PartName", sD_CDetail.CDetail_PartName);
         }
          }
         if(sD_CDetail.CDetail_Num_IsChanged)
         {
         if (sD_CDetail.CDetail_Num == 0)
         {
            idb.AddParameter("@CDetail_Num", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Num", sD_CDetail.CDetail_Num);
         }
          }
         if(sD_CDetail.CDetail_Price_IsChanged)
         {
         if (sD_CDetail.CDetail_Price == 0)
         {
            idb.AddParameter("@CDetail_Price", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Price", sD_CDetail.CDetail_Price);
         }
          }
         if(sD_CDetail.CDetail_Intro_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Intro))
         {
            idb.AddParameter("@CDetail_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Intro", sD_CDetail.CDetail_Intro);
         }
          }
         if(sD_CDetail.CDetail_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Bak))
         {
            idb.AddParameter("@CDetail_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Bak", sD_CDetail.CDetail_Bak);
         }
          }
         if(sD_CDetail.CDetail_OnNum_IsChanged)
         {
         if (sD_CDetail.CDetail_OnNum == 0)
         {
            idb.AddParameter("@CDetail_OnNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_OnNum", sD_CDetail.CDetail_OnNum);
         }
          }
         if(sD_CDetail.CDetail_FNum_IsChanged)
         {
         if (sD_CDetail.CDetail_FNum == 0)
         {
            idb.AddParameter("@CDetail_FNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_FNum", sD_CDetail.CDetail_FNum);
         }
          }
         if(sD_CDetail.CDetail_DNum_IsChanged)
         {
         if (sD_CDetail.CDetail_DNum == 0)
         {
            idb.AddParameter("@CDetail_DNum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_DNum", sD_CDetail.CDetail_DNum);
         }
          }
         if(sD_CDetail.CDetail_ContractNo_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_ContractNo))
         {
            idb.AddParameter("@CDetail_ContractNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_ContractNo", sD_CDetail.CDetail_ContractNo);
         }
          }
         if(sD_CDetail.Stat_IsChanged)
         {
         if (sD_CDetail.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_CDetail.Stat);
         }
          }
         if(sD_CDetail.CDetail_Date_IsChanged)
         {
         if (sD_CDetail.CDetail_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CDetail_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Date", sD_CDetail.CDetail_Date);
         }
          }
         if(sD_CDetail.CDetail_Cmd_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Cmd))
         {
            idb.AddParameter("@CDetail_Cmd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Cmd", sD_CDetail.CDetail_Cmd);
         }
          }
         if(sD_CDetail.CDetail_Project_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Project))
         {
            idb.AddParameter("@CDetail_Project", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Project", sD_CDetail.CDetail_Project);
         }
          }
         if(sD_CDetail.CDetail_Sum_IsChanged)
         {
         if (sD_CDetail.CDetail_Sum == 0)
         {
            idb.AddParameter("@CDetail_Sum", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_Sum", sD_CDetail.CDetail_Sum);
         }
          }
         if(sD_CDetail.CDetail_NoTax_IsChanged)
         {
         if (sD_CDetail.CDetail_NoTax == 0)
         {
            idb.AddParameter("@CDetail_NoTax", 0);
         }
         else
         {
            idb.AddParameter("@CDetail_NoTax", sD_CDetail.CDetail_NoTax);
         }
          }
         if(sD_CDetail.CDetail_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_ProdCode))
         {
            idb.AddParameter("@CDetail_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_ProdCode", sD_CDetail.CDetail_ProdCode);
         }
          }
         if(sD_CDetail.CDetail_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Unit))
         {
            idb.AddParameter("@CDetail_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Unit", sD_CDetail.CDetail_Unit);
         }
          }
         if(sD_CDetail.CDetail_PRRelation_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_PRRelation))
         {
            idb.AddParameter("@CDetail_PRRelation", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_PRRelation", sD_CDetail.CDetail_PRRelation);
         }
          }
         if(sD_CDetail.CDetail_Finance_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_CDetail.CDetail_Finance))
         {
            idb.AddParameter("@CDetail_Finance", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CDetail_Finance", sD_CDetail.CDetail_Finance);
         }
          }

         idb.AddParameter("@CDetail_ID", sD_CDetail.CDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除合同细目信息 SD_CDetail对象(即:一条记录
      /// </summary>
      public int Delete(Int64 cDetail_ID)
      {
         string sql = "DELETE SD_CDetail WHERE 1=1  AND CDetail_ID=@CDetail_ID ";
         idb.AddParameter("@CDetail_ID", cDetail_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的合同细目信息 SD_CDetail对象(即:一条记录
      /// </summary>
      public SD_CDetail GetByKey(Int64 cDetail_ID)
      {
         SD_CDetail sD_CDetail = new SD_CDetail();
         string sql = "SELECT  CDetail_ID,CDetail_Code,CDetail_PartNo,CDetail_PartName,CDetail_Num,CDetail_Price,CDetail_Intro,CDetail_Bak,CDetail_OnNum,CDetail_FNum,CDetail_DNum,CDetail_ContractNo,Stat,CDetail_Date,CDetail_Cmd,CDetail_Project,CDetail_Sum,CDetail_NoTax,CDetail_ProdCode,CDetail_Unit,CDetail_PRRelation,CDetail_Finance FROM SD_CDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CDetail_ID=@CDetail_ID ";
         idb.AddParameter("@CDetail_ID", cDetail_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CDetail_ID"] != DBNull.Value) sD_CDetail.CDetail_ID = Convert.ToInt64(dr["CDetail_ID"]);
            if (dr["CDetail_Code"] != DBNull.Value) sD_CDetail.CDetail_Code = Convert.ToString(dr["CDetail_Code"]);
            if (dr["CDetail_PartNo"] != DBNull.Value) sD_CDetail.CDetail_PartNo = Convert.ToString(dr["CDetail_PartNo"]);
            if (dr["CDetail_PartName"] != DBNull.Value) sD_CDetail.CDetail_PartName = Convert.ToString(dr["CDetail_PartName"]);
            if (dr["CDetail_Num"] != DBNull.Value) sD_CDetail.CDetail_Num = Convert.ToInt32(dr["CDetail_Num"]);
            if (dr["CDetail_Price"] != DBNull.Value) sD_CDetail.CDetail_Price = Convert.ToDecimal(dr["CDetail_Price"]);
            if (dr["CDetail_Intro"] != DBNull.Value) sD_CDetail.CDetail_Intro = Convert.ToString(dr["CDetail_Intro"]);
            if (dr["CDetail_Bak"] != DBNull.Value) sD_CDetail.CDetail_Bak = Convert.ToString(dr["CDetail_Bak"]);
            if (dr["CDetail_OnNum"] != DBNull.Value) sD_CDetail.CDetail_OnNum = Convert.ToInt32(dr["CDetail_OnNum"]);
            if (dr["CDetail_FNum"] != DBNull.Value) sD_CDetail.CDetail_FNum = Convert.ToInt32(dr["CDetail_FNum"]);
            if (dr["CDetail_DNum"] != DBNull.Value) sD_CDetail.CDetail_DNum = Convert.ToInt32(dr["CDetail_DNum"]);
            if (dr["CDetail_ContractNo"] != DBNull.Value) sD_CDetail.CDetail_ContractNo = Convert.ToString(dr["CDetail_ContractNo"]);
            if (dr["Stat"] != DBNull.Value) sD_CDetail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CDetail_Date"] != DBNull.Value) sD_CDetail.CDetail_Date = Convert.ToDateTime(dr["CDetail_Date"]);
            if (dr["CDetail_Cmd"] != DBNull.Value) sD_CDetail.CDetail_Cmd = Convert.ToString(dr["CDetail_Cmd"]);
            if (dr["CDetail_Project"] != DBNull.Value) sD_CDetail.CDetail_Project = Convert.ToString(dr["CDetail_Project"]);
            if (dr["CDetail_Sum"] != DBNull.Value) sD_CDetail.CDetail_Sum = Convert.ToDecimal(dr["CDetail_Sum"]);
            if (dr["CDetail_NoTax"] != DBNull.Value) sD_CDetail.CDetail_NoTax = Convert.ToDecimal(dr["CDetail_NoTax"]);
            if (dr["CDetail_ProdCode"] != DBNull.Value) sD_CDetail.CDetail_ProdCode = Convert.ToString(dr["CDetail_ProdCode"]);
            if (dr["CDetail_Unit"] != DBNull.Value) sD_CDetail.CDetail_Unit = Convert.ToString(dr["CDetail_Unit"]);
            if (dr["CDetail_PRRelation"] != DBNull.Value) sD_CDetail.CDetail_PRRelation = Convert.ToString(dr["CDetail_PRRelation"]);
            if (dr["CDetail_Finance"] != DBNull.Value) sD_CDetail.CDetail_Finance = Convert.ToString(dr["CDetail_Finance"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_CDetail;
      }
      /// <summary>
      /// 获取指定的合同细目信息 SD_CDetail对象集合
      /// </summary>
      public List<SD_CDetail> GetListByWhere(string strCondition)
      {
         List<SD_CDetail> ret = new List<SD_CDetail>();
         string sql = "SELECT  CDetail_ID,CDetail_Code,CDetail_PartNo,CDetail_PartName,CDetail_Num,CDetail_Price,CDetail_Intro,CDetail_Bak,CDetail_OnNum,CDetail_FNum,CDetail_DNum,CDetail_ContractNo,Stat,CDetail_Date,CDetail_Cmd,CDetail_Project,CDetail_Sum,CDetail_NoTax,CDetail_ProdCode,CDetail_Unit,CDetail_PRRelation,CDetail_Finance FROM SD_CDetail WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            SD_CDetail sD_CDetail = new SD_CDetail();
            if (dr["CDetail_ID"] != DBNull.Value) sD_CDetail.CDetail_ID = Convert.ToInt64(dr["CDetail_ID"]);
            if (dr["CDetail_Code"] != DBNull.Value) sD_CDetail.CDetail_Code = Convert.ToString(dr["CDetail_Code"]);
            if (dr["CDetail_PartNo"] != DBNull.Value) sD_CDetail.CDetail_PartNo = Convert.ToString(dr["CDetail_PartNo"]);
            if (dr["CDetail_PartName"] != DBNull.Value) sD_CDetail.CDetail_PartName = Convert.ToString(dr["CDetail_PartName"]);
            if (dr["CDetail_Num"] != DBNull.Value) sD_CDetail.CDetail_Num = Convert.ToInt32(dr["CDetail_Num"]);
            if (dr["CDetail_Price"] != DBNull.Value) sD_CDetail.CDetail_Price = Convert.ToDecimal(dr["CDetail_Price"]);
            if (dr["CDetail_Intro"] != DBNull.Value) sD_CDetail.CDetail_Intro = Convert.ToString(dr["CDetail_Intro"]);
            if (dr["CDetail_Bak"] != DBNull.Value) sD_CDetail.CDetail_Bak = Convert.ToString(dr["CDetail_Bak"]);
            if (dr["CDetail_OnNum"] != DBNull.Value) sD_CDetail.CDetail_OnNum = Convert.ToInt32(dr["CDetail_OnNum"]);
            if (dr["CDetail_FNum"] != DBNull.Value) sD_CDetail.CDetail_FNum = Convert.ToInt32(dr["CDetail_FNum"]);
            if (dr["CDetail_DNum"] != DBNull.Value) sD_CDetail.CDetail_DNum = Convert.ToInt32(dr["CDetail_DNum"]);
            if (dr["CDetail_ContractNo"] != DBNull.Value) sD_CDetail.CDetail_ContractNo = Convert.ToString(dr["CDetail_ContractNo"]);
            if (dr["Stat"] != DBNull.Value) sD_CDetail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CDetail_Date"] != DBNull.Value) sD_CDetail.CDetail_Date = Convert.ToDateTime(dr["CDetail_Date"]);
            if (dr["CDetail_Cmd"] != DBNull.Value) sD_CDetail.CDetail_Cmd = Convert.ToString(dr["CDetail_Cmd"]);
            if (dr["CDetail_Project"] != DBNull.Value) sD_CDetail.CDetail_Project = Convert.ToString(dr["CDetail_Project"]);
            if (dr["CDetail_Sum"] != DBNull.Value) sD_CDetail.CDetail_Sum = Convert.ToDecimal(dr["CDetail_Sum"]);
            if (dr["CDetail_NoTax"] != DBNull.Value) sD_CDetail.CDetail_NoTax = Convert.ToDecimal(dr["CDetail_NoTax"]);
            if (dr["CDetail_ProdCode"] != DBNull.Value) sD_CDetail.CDetail_ProdCode = Convert.ToString(dr["CDetail_ProdCode"]);
            if (dr["CDetail_Unit"] != DBNull.Value) sD_CDetail.CDetail_Unit = Convert.ToString(dr["CDetail_Unit"]);
            if (dr["CDetail_PRRelation"] != DBNull.Value) sD_CDetail.CDetail_PRRelation = Convert.ToString(dr["CDetail_PRRelation"]);
            if (dr["CDetail_Finance"] != DBNull.Value) sD_CDetail.CDetail_Finance = Convert.ToString(dr["CDetail_Finance"]);
            ret.Add(sD_CDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的合同细目信息 SD_CDetail对象(即:一条记录
      /// </summary>
      public List<SD_CDetail> GetAll()
      {
         List<SD_CDetail> ret = new List<SD_CDetail>();
         string sql = "SELECT  CDetail_ID,CDetail_Code,CDetail_PartNo,CDetail_PartName,CDetail_Num,CDetail_Price,CDetail_Intro,CDetail_Bak,CDetail_OnNum,CDetail_FNum,CDetail_DNum,CDetail_ContractNo,Stat,CDetail_Date,CDetail_Cmd,CDetail_Project,CDetail_Sum,CDetail_NoTax,CDetail_ProdCode,CDetail_Unit,CDetail_PRRelation,CDetail_Finance FROM SD_CDetail where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_CDetail sD_CDetail = new SD_CDetail();
            if (dr["CDetail_ID"] != DBNull.Value) sD_CDetail.CDetail_ID = Convert.ToInt64(dr["CDetail_ID"]);
            if (dr["CDetail_Code"] != DBNull.Value) sD_CDetail.CDetail_Code = Convert.ToString(dr["CDetail_Code"]);
            if (dr["CDetail_PartNo"] != DBNull.Value) sD_CDetail.CDetail_PartNo = Convert.ToString(dr["CDetail_PartNo"]);
            if (dr["CDetail_PartName"] != DBNull.Value) sD_CDetail.CDetail_PartName = Convert.ToString(dr["CDetail_PartName"]);
            if (dr["CDetail_Num"] != DBNull.Value) sD_CDetail.CDetail_Num = Convert.ToInt32(dr["CDetail_Num"]);
            if (dr["CDetail_Price"] != DBNull.Value) sD_CDetail.CDetail_Price = Convert.ToDecimal(dr["CDetail_Price"]);
            if (dr["CDetail_Intro"] != DBNull.Value) sD_CDetail.CDetail_Intro = Convert.ToString(dr["CDetail_Intro"]);
            if (dr["CDetail_Bak"] != DBNull.Value) sD_CDetail.CDetail_Bak = Convert.ToString(dr["CDetail_Bak"]);
            if (dr["CDetail_OnNum"] != DBNull.Value) sD_CDetail.CDetail_OnNum = Convert.ToInt32(dr["CDetail_OnNum"]);
            if (dr["CDetail_FNum"] != DBNull.Value) sD_CDetail.CDetail_FNum = Convert.ToInt32(dr["CDetail_FNum"]);
            if (dr["CDetail_DNum"] != DBNull.Value) sD_CDetail.CDetail_DNum = Convert.ToInt32(dr["CDetail_DNum"]);
            if (dr["CDetail_ContractNo"] != DBNull.Value) sD_CDetail.CDetail_ContractNo = Convert.ToString(dr["CDetail_ContractNo"]);
            if (dr["Stat"] != DBNull.Value) sD_CDetail.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CDetail_Date"] != DBNull.Value) sD_CDetail.CDetail_Date = Convert.ToDateTime(dr["CDetail_Date"]);
            if (dr["CDetail_Cmd"] != DBNull.Value) sD_CDetail.CDetail_Cmd = Convert.ToString(dr["CDetail_Cmd"]);
            if (dr["CDetail_Project"] != DBNull.Value) sD_CDetail.CDetail_Project = Convert.ToString(dr["CDetail_Project"]);
            if (dr["CDetail_Sum"] != DBNull.Value) sD_CDetail.CDetail_Sum = Convert.ToDecimal(dr["CDetail_Sum"]);
            if (dr["CDetail_NoTax"] != DBNull.Value) sD_CDetail.CDetail_NoTax = Convert.ToDecimal(dr["CDetail_NoTax"]);
            if (dr["CDetail_ProdCode"] != DBNull.Value) sD_CDetail.CDetail_ProdCode = Convert.ToString(dr["CDetail_ProdCode"]);
            if (dr["CDetail_Unit"] != DBNull.Value) sD_CDetail.CDetail_Unit = Convert.ToString(dr["CDetail_Unit"]);
            if (dr["CDetail_PRRelation"] != DBNull.Value) sD_CDetail.CDetail_PRRelation = Convert.ToString(dr["CDetail_PRRelation"]);
            if (dr["CDetail_Finance"] != DBNull.Value) sD_CDetail.CDetail_Finance = Convert.ToString(dr["CDetail_Finance"]);
            ret.Add(sD_CDetail);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
