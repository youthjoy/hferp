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
   /// 系统注册信息
   /// </summary>
   [Serializable]
   public partial class ADOBSE_SysInfo
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加系统注册信息 BSE_SysInfo对象(即:一条记录)
      /// </summary>
      public int Add(BSE_SysInfo bSE_SysInfo)
      {
         string sql = "INSERT INTO BSE_SysInfo (Sys_ID,Sys_CName,Sys_CSName,Sys_SName,Sys_COwner,Sys_OCompany,Sys_CCategory,Sys_CType,Sys_Province,Sys_City,Sys_Addr,Sys_PostCode,Sys_Tel,Sys_Fax,Sys_Email,Sys_BankName,Sys_BankAcc,Sys_Tax,Stat,Sys_EnglishName,Sys_EnglishAddr,Sys_EnglishContract,Sys_BankAccName) VALUES (@Sys_ID,@Sys_CName,@Sys_CSName,@Sys_SName,@Sys_COwner,@Sys_OCompany,@Sys_CCategory,@Sys_CType,@Sys_Province,@Sys_City,@Sys_Addr,@Sys_PostCode,@Sys_Tel,@Sys_Fax,@Sys_Email,@Sys_BankName,@Sys_BankAcc,@Sys_Tax,@Stat,@Sys_EnglishName,@Sys_EnglishAddr,@Sys_EnglishContract,@Sys_BankAccName)";
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CName))
         {
            idb.AddParameter("@Sys_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CName", bSE_SysInfo.Sys_CName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CSName))
         {
            idb.AddParameter("@Sys_CSName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CSName", bSE_SysInfo.Sys_CSName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_SName))
         {
            idb.AddParameter("@Sys_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_SName", bSE_SysInfo.Sys_SName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_COwner))
         {
            idb.AddParameter("@Sys_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_COwner", bSE_SysInfo.Sys_COwner);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_OCompany))
         {
            idb.AddParameter("@Sys_OCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_OCompany", bSE_SysInfo.Sys_OCompany);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CCategory))
         {
            idb.AddParameter("@Sys_CCategory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CCategory", bSE_SysInfo.Sys_CCategory);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CType))
         {
            idb.AddParameter("@Sys_CType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CType", bSE_SysInfo.Sys_CType);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Province))
         {
            idb.AddParameter("@Sys_Province", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Province", bSE_SysInfo.Sys_Province);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_City))
         {
            idb.AddParameter("@Sys_City", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_City", bSE_SysInfo.Sys_City);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Addr))
         {
            idb.AddParameter("@Sys_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Addr", bSE_SysInfo.Sys_Addr);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_PostCode))
         {
            idb.AddParameter("@Sys_PostCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_PostCode", bSE_SysInfo.Sys_PostCode);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Tel))
         {
            idb.AddParameter("@Sys_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Tel", bSE_SysInfo.Sys_Tel);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Fax))
         {
            idb.AddParameter("@Sys_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Fax", bSE_SysInfo.Sys_Fax);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Email))
         {
            idb.AddParameter("@Sys_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Email", bSE_SysInfo.Sys_Email);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankName))
         {
            idb.AddParameter("@Sys_BankName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankName", bSE_SysInfo.Sys_BankName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankAcc))
         {
            idb.AddParameter("@Sys_BankAcc", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankAcc", bSE_SysInfo.Sys_BankAcc);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Tax))
         {
            idb.AddParameter("@Sys_Tax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Tax", bSE_SysInfo.Sys_Tax);
         }
         if (bSE_SysInfo.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bSE_SysInfo.Stat);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishName))
         {
            idb.AddParameter("@Sys_EnglishName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishName", bSE_SysInfo.Sys_EnglishName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishAddr))
         {
            idb.AddParameter("@Sys_EnglishAddr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishAddr", bSE_SysInfo.Sys_EnglishAddr);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishContract))
         {
            idb.AddParameter("@Sys_EnglishContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishContract", bSE_SysInfo.Sys_EnglishContract);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankAccName))
         {
            idb.AddParameter("@Sys_BankAccName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankAccName", bSE_SysInfo.Sys_BankAccName);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加系统注册信息 BSE_SysInfo对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(BSE_SysInfo bSE_SysInfo)
      {
         string sql = "INSERT INTO BSE_SysInfo (Sys_ID,Sys_CName,Sys_CSName,Sys_SName,Sys_COwner,Sys_OCompany,Sys_CCategory,Sys_CType,Sys_Province,Sys_City,Sys_Addr,Sys_PostCode,Sys_Tel,Sys_Fax,Sys_Email,Sys_BankName,Sys_BankAcc,Sys_Tax,Stat,Sys_EnglishName,Sys_EnglishAddr,Sys_EnglishContract,Sys_BankAccName) VALUES (@Sys_ID,@Sys_CName,@Sys_CSName,@Sys_SName,@Sys_COwner,@Sys_OCompany,@Sys_CCategory,@Sys_CType,@Sys_Province,@Sys_City,@Sys_Addr,@Sys_PostCode,@Sys_Tel,@Sys_Fax,@Sys_Email,@Sys_BankName,@Sys_BankAcc,@Sys_Tax,@Stat,@Sys_EnglishName,@Sys_EnglishAddr,@Sys_EnglishContract,@Sys_BankAccName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CName))
         {
            idb.AddParameter("@Sys_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CName", bSE_SysInfo.Sys_CName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CSName))
         {
            idb.AddParameter("@Sys_CSName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CSName", bSE_SysInfo.Sys_CSName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_SName))
         {
            idb.AddParameter("@Sys_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_SName", bSE_SysInfo.Sys_SName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_COwner))
         {
            idb.AddParameter("@Sys_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_COwner", bSE_SysInfo.Sys_COwner);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_OCompany))
         {
            idb.AddParameter("@Sys_OCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_OCompany", bSE_SysInfo.Sys_OCompany);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CCategory))
         {
            idb.AddParameter("@Sys_CCategory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CCategory", bSE_SysInfo.Sys_CCategory);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CType))
         {
            idb.AddParameter("@Sys_CType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CType", bSE_SysInfo.Sys_CType);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Province))
         {
            idb.AddParameter("@Sys_Province", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Province", bSE_SysInfo.Sys_Province);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_City))
         {
            idb.AddParameter("@Sys_City", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_City", bSE_SysInfo.Sys_City);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Addr))
         {
            idb.AddParameter("@Sys_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Addr", bSE_SysInfo.Sys_Addr);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_PostCode))
         {
            idb.AddParameter("@Sys_PostCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_PostCode", bSE_SysInfo.Sys_PostCode);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Tel))
         {
            idb.AddParameter("@Sys_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Tel", bSE_SysInfo.Sys_Tel);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Fax))
         {
            idb.AddParameter("@Sys_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Fax", bSE_SysInfo.Sys_Fax);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Email))
         {
            idb.AddParameter("@Sys_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Email", bSE_SysInfo.Sys_Email);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankName))
         {
            idb.AddParameter("@Sys_BankName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankName", bSE_SysInfo.Sys_BankName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankAcc))
         {
            idb.AddParameter("@Sys_BankAcc", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankAcc", bSE_SysInfo.Sys_BankAcc);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Tax))
         {
            idb.AddParameter("@Sys_Tax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Tax", bSE_SysInfo.Sys_Tax);
         }
         if (bSE_SysInfo.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bSE_SysInfo.Stat);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishName))
         {
            idb.AddParameter("@Sys_EnglishName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishName", bSE_SysInfo.Sys_EnglishName);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishAddr))
         {
            idb.AddParameter("@Sys_EnglishAddr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishAddr", bSE_SysInfo.Sys_EnglishAddr);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishContract))
         {
            idb.AddParameter("@Sys_EnglishContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishContract", bSE_SysInfo.Sys_EnglishContract);
         }
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankAccName))
         {
            idb.AddParameter("@Sys_BankAccName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankAccName", bSE_SysInfo.Sys_BankAccName);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新系统注册信息 BSE_SysInfo对象(即:一条记录
      /// </summary>
      public int Update(BSE_SysInfo bSE_SysInfo)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       BSE_SysInfo       SET ");
            if(bSE_SysInfo.Sys_CName_IsChanged){sbParameter.Append("Sys_CName=@Sys_CName, ");}
      if(bSE_SysInfo.Sys_CSName_IsChanged){sbParameter.Append("Sys_CSName=@Sys_CSName, ");}
      if(bSE_SysInfo.Sys_SName_IsChanged){sbParameter.Append("Sys_SName=@Sys_SName, ");}
      if(bSE_SysInfo.Sys_COwner_IsChanged){sbParameter.Append("Sys_COwner=@Sys_COwner, ");}
      if(bSE_SysInfo.Sys_OCompany_IsChanged){sbParameter.Append("Sys_OCompany=@Sys_OCompany, ");}
      if(bSE_SysInfo.Sys_CCategory_IsChanged){sbParameter.Append("Sys_CCategory=@Sys_CCategory, ");}
      if(bSE_SysInfo.Sys_CType_IsChanged){sbParameter.Append("Sys_CType=@Sys_CType, ");}
      if(bSE_SysInfo.Sys_Province_IsChanged){sbParameter.Append("Sys_Province=@Sys_Province, ");}
      if(bSE_SysInfo.Sys_City_IsChanged){sbParameter.Append("Sys_City=@Sys_City, ");}
      if(bSE_SysInfo.Sys_Addr_IsChanged){sbParameter.Append("Sys_Addr=@Sys_Addr, ");}
      if(bSE_SysInfo.Sys_PostCode_IsChanged){sbParameter.Append("Sys_PostCode=@Sys_PostCode, ");}
      if(bSE_SysInfo.Sys_Tel_IsChanged){sbParameter.Append("Sys_Tel=@Sys_Tel, ");}
      if(bSE_SysInfo.Sys_Fax_IsChanged){sbParameter.Append("Sys_Fax=@Sys_Fax, ");}
      if(bSE_SysInfo.Sys_Email_IsChanged){sbParameter.Append("Sys_Email=@Sys_Email, ");}
      if(bSE_SysInfo.Sys_BankName_IsChanged){sbParameter.Append("Sys_BankName=@Sys_BankName, ");}
      if(bSE_SysInfo.Sys_BankAcc_IsChanged){sbParameter.Append("Sys_BankAcc=@Sys_BankAcc, ");}
      if(bSE_SysInfo.Sys_Tax_IsChanged){sbParameter.Append("Sys_Tax=@Sys_Tax, ");}
      if(bSE_SysInfo.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bSE_SysInfo.Sys_EnglishName_IsChanged){sbParameter.Append("Sys_EnglishName=@Sys_EnglishName, ");}
      if(bSE_SysInfo.Sys_EnglishAddr_IsChanged){sbParameter.Append("Sys_EnglishAddr=@Sys_EnglishAddr, ");}
      if(bSE_SysInfo.Sys_EnglishContract_IsChanged){sbParameter.Append("Sys_EnglishContract=@Sys_EnglishContract, ");}
      if(bSE_SysInfo.Sys_BankAccName_IsChanged){sbParameter.Append("Sys_BankAccName=@Sys_BankAccName ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Sys_ID=@Sys_ID; " );
      string sql=sb.ToString();
         if(bSE_SysInfo.Sys_CName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CName))
         {
            idb.AddParameter("@Sys_CName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CName", bSE_SysInfo.Sys_CName);
         }
          }
         if(bSE_SysInfo.Sys_CSName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CSName))
         {
            idb.AddParameter("@Sys_CSName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CSName", bSE_SysInfo.Sys_CSName);
         }
          }
         if(bSE_SysInfo.Sys_SName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_SName))
         {
            idb.AddParameter("@Sys_SName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_SName", bSE_SysInfo.Sys_SName);
         }
          }
         if(bSE_SysInfo.Sys_COwner_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_COwner))
         {
            idb.AddParameter("@Sys_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_COwner", bSE_SysInfo.Sys_COwner);
         }
          }
         if(bSE_SysInfo.Sys_OCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_OCompany))
         {
            idb.AddParameter("@Sys_OCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_OCompany", bSE_SysInfo.Sys_OCompany);
         }
          }
         if(bSE_SysInfo.Sys_CCategory_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CCategory))
         {
            idb.AddParameter("@Sys_CCategory", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CCategory", bSE_SysInfo.Sys_CCategory);
         }
          }
         if(bSE_SysInfo.Sys_CType_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_CType))
         {
            idb.AddParameter("@Sys_CType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_CType", bSE_SysInfo.Sys_CType);
         }
          }
         if(bSE_SysInfo.Sys_Province_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Province))
         {
            idb.AddParameter("@Sys_Province", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Province", bSE_SysInfo.Sys_Province);
         }
          }
         if(bSE_SysInfo.Sys_City_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_City))
         {
            idb.AddParameter("@Sys_City", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_City", bSE_SysInfo.Sys_City);
         }
          }
         if(bSE_SysInfo.Sys_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Addr))
         {
            idb.AddParameter("@Sys_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Addr", bSE_SysInfo.Sys_Addr);
         }
          }
         if(bSE_SysInfo.Sys_PostCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_PostCode))
         {
            idb.AddParameter("@Sys_PostCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_PostCode", bSE_SysInfo.Sys_PostCode);
         }
          }
         if(bSE_SysInfo.Sys_Tel_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Tel))
         {
            idb.AddParameter("@Sys_Tel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Tel", bSE_SysInfo.Sys_Tel);
         }
          }
         if(bSE_SysInfo.Sys_Fax_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Fax))
         {
            idb.AddParameter("@Sys_Fax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Fax", bSE_SysInfo.Sys_Fax);
         }
          }
         if(bSE_SysInfo.Sys_Email_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Email))
         {
            idb.AddParameter("@Sys_Email", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Email", bSE_SysInfo.Sys_Email);
         }
          }
         if(bSE_SysInfo.Sys_BankName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankName))
         {
            idb.AddParameter("@Sys_BankName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankName", bSE_SysInfo.Sys_BankName);
         }
          }
         if(bSE_SysInfo.Sys_BankAcc_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankAcc))
         {
            idb.AddParameter("@Sys_BankAcc", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankAcc", bSE_SysInfo.Sys_BankAcc);
         }
          }
         if(bSE_SysInfo.Sys_Tax_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_Tax))
         {
            idb.AddParameter("@Sys_Tax", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_Tax", bSE_SysInfo.Sys_Tax);
         }
          }
         if(bSE_SysInfo.Stat_IsChanged)
         {
         if (bSE_SysInfo.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bSE_SysInfo.Stat);
         }
          }
         if(bSE_SysInfo.Sys_EnglishName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishName))
         {
            idb.AddParameter("@Sys_EnglishName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishName", bSE_SysInfo.Sys_EnglishName);
         }
          }
         if(bSE_SysInfo.Sys_EnglishAddr_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishAddr))
         {
            idb.AddParameter("@Sys_EnglishAddr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishAddr", bSE_SysInfo.Sys_EnglishAddr);
         }
          }
         if(bSE_SysInfo.Sys_EnglishContract_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_EnglishContract))
         {
            idb.AddParameter("@Sys_EnglishContract", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_EnglishContract", bSE_SysInfo.Sys_EnglishContract);
         }
          }
         if(bSE_SysInfo.Sys_BankAccName_IsChanged)
         {
         if (string.IsNullOrEmpty(bSE_SysInfo.Sys_BankAccName))
         {
            idb.AddParameter("@Sys_BankAccName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Sys_BankAccName", bSE_SysInfo.Sys_BankAccName);
         }
          }

         idb.AddParameter("@Sys_ID", bSE_SysInfo.Sys_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除系统注册信息 BSE_SysInfo对象(即:一条记录
      /// </summary>
      public int Delete(string sys_ID)
      {
         string sql = "DELETE BSE_SysInfo WHERE 1=1  AND Sys_ID=@Sys_ID ";
         idb.AddParameter("@Sys_ID", sys_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的系统注册信息 BSE_SysInfo对象(即:一条记录
      /// </summary>
      public BSE_SysInfo GetByKey(string sys_ID)
      {
         BSE_SysInfo bSE_SysInfo = new BSE_SysInfo();
         string sql = "SELECT  Sys_ID,Sys_CName,Sys_CSName,Sys_SName,Sys_COwner,Sys_OCompany,Sys_CCategory,Sys_CType,Sys_Province,Sys_City,Sys_Addr,Sys_PostCode,Sys_Tel,Sys_Fax,Sys_Email,Sys_BankName,Sys_BankAcc,Sys_Tax,Stat,Sys_EnglishName,Sys_EnglishAddr,Sys_EnglishContract,Sys_BankAccName FROM BSE_SysInfo WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Sys_ID=@Sys_ID ";
         idb.AddParameter("@Sys_ID", sys_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Sys_ID"] != DBNull.Value) bSE_SysInfo.Sys_ID = Convert.ToString(dr["Sys_ID"]);
            if (dr["Sys_CName"] != DBNull.Value) bSE_SysInfo.Sys_CName = Convert.ToString(dr["Sys_CName"]);
            if (dr["Sys_CSName"] != DBNull.Value) bSE_SysInfo.Sys_CSName = Convert.ToString(dr["Sys_CSName"]);
            if (dr["Sys_SName"] != DBNull.Value) bSE_SysInfo.Sys_SName = Convert.ToString(dr["Sys_SName"]);
            if (dr["Sys_COwner"] != DBNull.Value) bSE_SysInfo.Sys_COwner = Convert.ToString(dr["Sys_COwner"]);
            if (dr["Sys_OCompany"] != DBNull.Value) bSE_SysInfo.Sys_OCompany = Convert.ToString(dr["Sys_OCompany"]);
            if (dr["Sys_CCategory"] != DBNull.Value) bSE_SysInfo.Sys_CCategory = Convert.ToString(dr["Sys_CCategory"]);
            if (dr["Sys_CType"] != DBNull.Value) bSE_SysInfo.Sys_CType = Convert.ToString(dr["Sys_CType"]);
            if (dr["Sys_Province"] != DBNull.Value) bSE_SysInfo.Sys_Province = Convert.ToString(dr["Sys_Province"]);
            if (dr["Sys_City"] != DBNull.Value) bSE_SysInfo.Sys_City = Convert.ToString(dr["Sys_City"]);
            if (dr["Sys_Addr"] != DBNull.Value) bSE_SysInfo.Sys_Addr = Convert.ToString(dr["Sys_Addr"]);
            if (dr["Sys_PostCode"] != DBNull.Value) bSE_SysInfo.Sys_PostCode = Convert.ToString(dr["Sys_PostCode"]);
            if (dr["Sys_Tel"] != DBNull.Value) bSE_SysInfo.Sys_Tel = Convert.ToString(dr["Sys_Tel"]);
            if (dr["Sys_Fax"] != DBNull.Value) bSE_SysInfo.Sys_Fax = Convert.ToString(dr["Sys_Fax"]);
            if (dr["Sys_Email"] != DBNull.Value) bSE_SysInfo.Sys_Email = Convert.ToString(dr["Sys_Email"]);
            if (dr["Sys_BankName"] != DBNull.Value) bSE_SysInfo.Sys_BankName = Convert.ToString(dr["Sys_BankName"]);
            if (dr["Sys_BankAcc"] != DBNull.Value) bSE_SysInfo.Sys_BankAcc = Convert.ToString(dr["Sys_BankAcc"]);
            if (dr["Sys_Tax"] != DBNull.Value) bSE_SysInfo.Sys_Tax = Convert.ToString(dr["Sys_Tax"]);
            if (dr["Stat"] != DBNull.Value) bSE_SysInfo.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Sys_EnglishName"] != DBNull.Value) bSE_SysInfo.Sys_EnglishName = Convert.ToString(dr["Sys_EnglishName"]);
            if (dr["Sys_EnglishAddr"] != DBNull.Value) bSE_SysInfo.Sys_EnglishAddr = Convert.ToString(dr["Sys_EnglishAddr"]);
            if (dr["Sys_EnglishContract"] != DBNull.Value) bSE_SysInfo.Sys_EnglishContract = Convert.ToString(dr["Sys_EnglishContract"]);
            if (dr["Sys_BankAccName"] != DBNull.Value) bSE_SysInfo.Sys_BankAccName = Convert.ToString(dr["Sys_BankAccName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return bSE_SysInfo;
      }
      /// <summary>
      /// 获取指定的系统注册信息 BSE_SysInfo对象集合
      /// </summary>
      public List<BSE_SysInfo> GetListByWhere(string strCondition)
      {
         List<BSE_SysInfo> ret = new List<BSE_SysInfo>();
         string sql = "SELECT  Sys_ID,Sys_CName,Sys_CSName,Sys_SName,Sys_COwner,Sys_OCompany,Sys_CCategory,Sys_CType,Sys_Province,Sys_City,Sys_Addr,Sys_PostCode,Sys_Tel,Sys_Fax,Sys_Email,Sys_BankName,Sys_BankAcc,Sys_Tax,Stat,Sys_EnglishName,Sys_EnglishAddr,Sys_EnglishContract,Sys_BankAccName FROM BSE_SysInfo WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            BSE_SysInfo bSE_SysInfo = new BSE_SysInfo();
            if (dr["Sys_ID"] != DBNull.Value) bSE_SysInfo.Sys_ID = Convert.ToString(dr["Sys_ID"]);
            if (dr["Sys_CName"] != DBNull.Value) bSE_SysInfo.Sys_CName = Convert.ToString(dr["Sys_CName"]);
            if (dr["Sys_CSName"] != DBNull.Value) bSE_SysInfo.Sys_CSName = Convert.ToString(dr["Sys_CSName"]);
            if (dr["Sys_SName"] != DBNull.Value) bSE_SysInfo.Sys_SName = Convert.ToString(dr["Sys_SName"]);
            if (dr["Sys_COwner"] != DBNull.Value) bSE_SysInfo.Sys_COwner = Convert.ToString(dr["Sys_COwner"]);
            if (dr["Sys_OCompany"] != DBNull.Value) bSE_SysInfo.Sys_OCompany = Convert.ToString(dr["Sys_OCompany"]);
            if (dr["Sys_CCategory"] != DBNull.Value) bSE_SysInfo.Sys_CCategory = Convert.ToString(dr["Sys_CCategory"]);
            if (dr["Sys_CType"] != DBNull.Value) bSE_SysInfo.Sys_CType = Convert.ToString(dr["Sys_CType"]);
            if (dr["Sys_Province"] != DBNull.Value) bSE_SysInfo.Sys_Province = Convert.ToString(dr["Sys_Province"]);
            if (dr["Sys_City"] != DBNull.Value) bSE_SysInfo.Sys_City = Convert.ToString(dr["Sys_City"]);
            if (dr["Sys_Addr"] != DBNull.Value) bSE_SysInfo.Sys_Addr = Convert.ToString(dr["Sys_Addr"]);
            if (dr["Sys_PostCode"] != DBNull.Value) bSE_SysInfo.Sys_PostCode = Convert.ToString(dr["Sys_PostCode"]);
            if (dr["Sys_Tel"] != DBNull.Value) bSE_SysInfo.Sys_Tel = Convert.ToString(dr["Sys_Tel"]);
            if (dr["Sys_Fax"] != DBNull.Value) bSE_SysInfo.Sys_Fax = Convert.ToString(dr["Sys_Fax"]);
            if (dr["Sys_Email"] != DBNull.Value) bSE_SysInfo.Sys_Email = Convert.ToString(dr["Sys_Email"]);
            if (dr["Sys_BankName"] != DBNull.Value) bSE_SysInfo.Sys_BankName = Convert.ToString(dr["Sys_BankName"]);
            if (dr["Sys_BankAcc"] != DBNull.Value) bSE_SysInfo.Sys_BankAcc = Convert.ToString(dr["Sys_BankAcc"]);
            if (dr["Sys_Tax"] != DBNull.Value) bSE_SysInfo.Sys_Tax = Convert.ToString(dr["Sys_Tax"]);
            if (dr["Stat"] != DBNull.Value) bSE_SysInfo.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Sys_EnglishName"] != DBNull.Value) bSE_SysInfo.Sys_EnglishName = Convert.ToString(dr["Sys_EnglishName"]);
            if (dr["Sys_EnglishAddr"] != DBNull.Value) bSE_SysInfo.Sys_EnglishAddr = Convert.ToString(dr["Sys_EnglishAddr"]);
            if (dr["Sys_EnglishContract"] != DBNull.Value) bSE_SysInfo.Sys_EnglishContract = Convert.ToString(dr["Sys_EnglishContract"]);
            if (dr["Sys_BankAccName"] != DBNull.Value) bSE_SysInfo.Sys_BankAccName = Convert.ToString(dr["Sys_BankAccName"]);
            ret.Add(bSE_SysInfo);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }}  
         return ret;
      }
      /// <summary>
      /// 获取所有的系统注册信息 BSE_SysInfo对象(即:一条记录
      /// </summary>
      public List<BSE_SysInfo> GetAll()
      {
         List<BSE_SysInfo> ret = new List<BSE_SysInfo>();
         string sql = "SELECT  Sys_ID,Sys_CName,Sys_CSName,Sys_SName,Sys_COwner,Sys_OCompany,Sys_CCategory,Sys_CType,Sys_Province,Sys_City,Sys_Addr,Sys_PostCode,Sys_Tel,Sys_Fax,Sys_Email,Sys_BankName,Sys_BankAcc,Sys_Tax,Stat,Sys_EnglishName,Sys_EnglishAddr,Sys_EnglishContract,Sys_BankAccName FROM BSE_SysInfo where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            BSE_SysInfo bSE_SysInfo = new BSE_SysInfo();
            if (dr["Sys_ID"] != DBNull.Value) bSE_SysInfo.Sys_ID = Convert.ToString(dr["Sys_ID"]);
            if (dr["Sys_CName"] != DBNull.Value) bSE_SysInfo.Sys_CName = Convert.ToString(dr["Sys_CName"]);
            if (dr["Sys_CSName"] != DBNull.Value) bSE_SysInfo.Sys_CSName = Convert.ToString(dr["Sys_CSName"]);
            if (dr["Sys_SName"] != DBNull.Value) bSE_SysInfo.Sys_SName = Convert.ToString(dr["Sys_SName"]);
            if (dr["Sys_COwner"] != DBNull.Value) bSE_SysInfo.Sys_COwner = Convert.ToString(dr["Sys_COwner"]);
            if (dr["Sys_OCompany"] != DBNull.Value) bSE_SysInfo.Sys_OCompany = Convert.ToString(dr["Sys_OCompany"]);
            if (dr["Sys_CCategory"] != DBNull.Value) bSE_SysInfo.Sys_CCategory = Convert.ToString(dr["Sys_CCategory"]);
            if (dr["Sys_CType"] != DBNull.Value) bSE_SysInfo.Sys_CType = Convert.ToString(dr["Sys_CType"]);
            if (dr["Sys_Province"] != DBNull.Value) bSE_SysInfo.Sys_Province = Convert.ToString(dr["Sys_Province"]);
            if (dr["Sys_City"] != DBNull.Value) bSE_SysInfo.Sys_City = Convert.ToString(dr["Sys_City"]);
            if (dr["Sys_Addr"] != DBNull.Value) bSE_SysInfo.Sys_Addr = Convert.ToString(dr["Sys_Addr"]);
            if (dr["Sys_PostCode"] != DBNull.Value) bSE_SysInfo.Sys_PostCode = Convert.ToString(dr["Sys_PostCode"]);
            if (dr["Sys_Tel"] != DBNull.Value) bSE_SysInfo.Sys_Tel = Convert.ToString(dr["Sys_Tel"]);
            if (dr["Sys_Fax"] != DBNull.Value) bSE_SysInfo.Sys_Fax = Convert.ToString(dr["Sys_Fax"]);
            if (dr["Sys_Email"] != DBNull.Value) bSE_SysInfo.Sys_Email = Convert.ToString(dr["Sys_Email"]);
            if (dr["Sys_BankName"] != DBNull.Value) bSE_SysInfo.Sys_BankName = Convert.ToString(dr["Sys_BankName"]);
            if (dr["Sys_BankAcc"] != DBNull.Value) bSE_SysInfo.Sys_BankAcc = Convert.ToString(dr["Sys_BankAcc"]);
            if (dr["Sys_Tax"] != DBNull.Value) bSE_SysInfo.Sys_Tax = Convert.ToString(dr["Sys_Tax"]);
            if (dr["Stat"] != DBNull.Value) bSE_SysInfo.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Sys_EnglishName"] != DBNull.Value) bSE_SysInfo.Sys_EnglishName = Convert.ToString(dr["Sys_EnglishName"]);
            if (dr["Sys_EnglishAddr"] != DBNull.Value) bSE_SysInfo.Sys_EnglishAddr = Convert.ToString(dr["Sys_EnglishAddr"]);
            if (dr["Sys_EnglishContract"] != DBNull.Value) bSE_SysInfo.Sys_EnglishContract = Convert.ToString(dr["Sys_EnglishContract"]);
            if (dr["Sys_BankAccName"] != DBNull.Value) bSE_SysInfo.Sys_BankAccName = Convert.ToString(dr["Sys_BankAccName"]);
            ret.Add(bSE_SysInfo);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); }} 
         return ret;
      }
   }
}
