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
   /// 外协信息记录
   /// </summary>
   [Serializable]
   public partial class ADOFHelper_Info
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加外协信息记录 FHelper_Info对象(即:一条记录)
      /// </summary>
      public int Add(FHelper_Info fHelper_Info)
      {
         string sql = "INSERT INTO FHelper_Info (FHelperInfo_Code,FHelperInfo_RefCode,FHelperInfo_PartCode,FHelperInfo_ProdCode,FHelperInfo_RoadNodes,FHelperInfo_FSup,FHelperInfo_PriceID,FHelperInfo_Price,FHelperInfo_Num,FHelperInfo_FNum,FHelperInfo_DNum,FHelperInfo_Owner,FHelperInfo_Date,FHelperInfo_Stat,FHelperInfo_Bak,Stat,FHelperInfo_FStat,FHelperInfo_iType,FHelperInfo_BackDate,FHelperInfo_OutDate,FHelperInfo_IsBatch) VALUES (@FHelperInfo_Code,@FHelperInfo_RefCode,@FHelperInfo_PartCode,@FHelperInfo_ProdCode,@FHelperInfo_RoadNodes,@FHelperInfo_FSup,@FHelperInfo_PriceID,@FHelperInfo_Price,@FHelperInfo_Num,@FHelperInfo_FNum,@FHelperInfo_DNum,@FHelperInfo_Owner,@FHelperInfo_Date,@FHelperInfo_Stat,@FHelperInfo_Bak,@Stat,@FHelperInfo_FStat,@FHelperInfo_iType,@FHelperInfo_BackDate,@FHelperInfo_OutDate,@FHelperInfo_IsBatch)";
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Code))
         {
            idb.AddParameter("@FHelperInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Code", fHelper_Info.FHelperInfo_Code);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_RefCode))
         {
            idb.AddParameter("@FHelperInfo_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_RefCode", fHelper_Info.FHelperInfo_RefCode);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_PartCode))
         {
            idb.AddParameter("@FHelperInfo_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_PartCode", fHelper_Info.FHelperInfo_PartCode);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_ProdCode))
         {
            idb.AddParameter("@FHelperInfo_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_ProdCode", fHelper_Info.FHelperInfo_ProdCode);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_RoadNodes))
         {
            idb.AddParameter("@FHelperInfo_RoadNodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_RoadNodes", fHelper_Info.FHelperInfo_RoadNodes);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_FSup))
         {
            idb.AddParameter("@FHelperInfo_FSup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FSup", fHelper_Info.FHelperInfo_FSup);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_PriceID))
         {
            idb.AddParameter("@FHelperInfo_PriceID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_PriceID", fHelper_Info.FHelperInfo_PriceID);
         }
         if (fHelper_Info.FHelperInfo_Price == 0)
         {
            idb.AddParameter("@FHelperInfo_Price", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Price", fHelper_Info.FHelperInfo_Price);
         }
         if (fHelper_Info.FHelperInfo_Num == 0)
         {
            idb.AddParameter("@FHelperInfo_Num", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Num", fHelper_Info.FHelperInfo_Num);
         }
         if (fHelper_Info.FHelperInfo_FNum == 0)
         {
            idb.AddParameter("@FHelperInfo_FNum", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FNum", fHelper_Info.FHelperInfo_FNum);
         }
         if (fHelper_Info.FHelperInfo_DNum == 0)
         {
            idb.AddParameter("@FHelperInfo_DNum", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_DNum", fHelper_Info.FHelperInfo_DNum);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Owner))
         {
            idb.AddParameter("@FHelperInfo_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Owner", fHelper_Info.FHelperInfo_Owner);
         }
         if (fHelper_Info.FHelperInfo_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Date", fHelper_Info.FHelperInfo_Date);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Stat))
         {
            idb.AddParameter("@FHelperInfo_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Stat", fHelper_Info.FHelperInfo_Stat);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Bak))
         {
            idb.AddParameter("@FHelperInfo_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Bak", fHelper_Info.FHelperInfo_Bak);
         }
         if (fHelper_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_Info.Stat);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_FStat))
         {
            idb.AddParameter("@FHelperInfo_FStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FStat", fHelper_Info.FHelperInfo_FStat);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_iType))
         {
            idb.AddParameter("@FHelperInfo_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_iType", fHelper_Info.FHelperInfo_iType);
         }
         if (fHelper_Info.FHelperInfo_BackDate == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_BackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_BackDate", fHelper_Info.FHelperInfo_BackDate);
         }
         if (fHelper_Info.FHelperInfo_OutDate == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_OutDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_OutDate", fHelper_Info.FHelperInfo_OutDate);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_IsBatch))
         {
            idb.AddParameter("@FHelperInfo_IsBatch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_IsBatch", fHelper_Info.FHelperInfo_IsBatch);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加外协信息记录 FHelper_Info对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(FHelper_Info fHelper_Info)
      {
         string sql = "INSERT INTO FHelper_Info (FHelperInfo_Code,FHelperInfo_RefCode,FHelperInfo_PartCode,FHelperInfo_ProdCode,FHelperInfo_RoadNodes,FHelperInfo_FSup,FHelperInfo_PriceID,FHelperInfo_Price,FHelperInfo_Num,FHelperInfo_FNum,FHelperInfo_DNum,FHelperInfo_Owner,FHelperInfo_Date,FHelperInfo_Stat,FHelperInfo_Bak,Stat,FHelperInfo_FStat,FHelperInfo_iType,FHelperInfo_BackDate,FHelperInfo_OutDate,FHelperInfo_IsBatch) VALUES (@FHelperInfo_Code,@FHelperInfo_RefCode,@FHelperInfo_PartCode,@FHelperInfo_ProdCode,@FHelperInfo_RoadNodes,@FHelperInfo_FSup,@FHelperInfo_PriceID,@FHelperInfo_Price,@FHelperInfo_Num,@FHelperInfo_FNum,@FHelperInfo_DNum,@FHelperInfo_Owner,@FHelperInfo_Date,@FHelperInfo_Stat,@FHelperInfo_Bak,@Stat,@FHelperInfo_FStat,@FHelperInfo_iType,@FHelperInfo_BackDate,@FHelperInfo_OutDate,@FHelperInfo_IsBatch);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Code))
         {
            idb.AddParameter("@FHelperInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Code", fHelper_Info.FHelperInfo_Code);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_RefCode))
         {
            idb.AddParameter("@FHelperInfo_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_RefCode", fHelper_Info.FHelperInfo_RefCode);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_PartCode))
         {
            idb.AddParameter("@FHelperInfo_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_PartCode", fHelper_Info.FHelperInfo_PartCode);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_ProdCode))
         {
            idb.AddParameter("@FHelperInfo_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_ProdCode", fHelper_Info.FHelperInfo_ProdCode);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_RoadNodes))
         {
            idb.AddParameter("@FHelperInfo_RoadNodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_RoadNodes", fHelper_Info.FHelperInfo_RoadNodes);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_FSup))
         {
            idb.AddParameter("@FHelperInfo_FSup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FSup", fHelper_Info.FHelperInfo_FSup);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_PriceID))
         {
            idb.AddParameter("@FHelperInfo_PriceID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_PriceID", fHelper_Info.FHelperInfo_PriceID);
         }
         if (fHelper_Info.FHelperInfo_Price == 0)
         {
            idb.AddParameter("@FHelperInfo_Price", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Price", fHelper_Info.FHelperInfo_Price);
         }
         if (fHelper_Info.FHelperInfo_Num == 0)
         {
            idb.AddParameter("@FHelperInfo_Num", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Num", fHelper_Info.FHelperInfo_Num);
         }
         if (fHelper_Info.FHelperInfo_FNum == 0)
         {
            idb.AddParameter("@FHelperInfo_FNum", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FNum", fHelper_Info.FHelperInfo_FNum);
         }
         if (fHelper_Info.FHelperInfo_DNum == 0)
         {
            idb.AddParameter("@FHelperInfo_DNum", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_DNum", fHelper_Info.FHelperInfo_DNum);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Owner))
         {
            idb.AddParameter("@FHelperInfo_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Owner", fHelper_Info.FHelperInfo_Owner);
         }
         if (fHelper_Info.FHelperInfo_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Date", fHelper_Info.FHelperInfo_Date);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Stat))
         {
            idb.AddParameter("@FHelperInfo_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Stat", fHelper_Info.FHelperInfo_Stat);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Bak))
         {
            idb.AddParameter("@FHelperInfo_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Bak", fHelper_Info.FHelperInfo_Bak);
         }
         if (fHelper_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_Info.Stat);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_FStat))
         {
            idb.AddParameter("@FHelperInfo_FStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FStat", fHelper_Info.FHelperInfo_FStat);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_iType))
         {
            idb.AddParameter("@FHelperInfo_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_iType", fHelper_Info.FHelperInfo_iType);
         }
         if (fHelper_Info.FHelperInfo_BackDate == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_BackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_BackDate", fHelper_Info.FHelperInfo_BackDate);
         }
         if (fHelper_Info.FHelperInfo_OutDate == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_OutDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_OutDate", fHelper_Info.FHelperInfo_OutDate);
         }
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_IsBatch))
         {
            idb.AddParameter("@FHelperInfo_IsBatch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_IsBatch", fHelper_Info.FHelperInfo_IsBatch);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新外协信息记录 FHelper_Info对象(即:一条记录
      /// </summary>
      public int Update(FHelper_Info fHelper_Info)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       FHelper_Info       SET ");
            if(fHelper_Info.FHelperInfo_Code_IsChanged){sbParameter.Append("FHelperInfo_Code=@FHelperInfo_Code, ");}
      if(fHelper_Info.FHelperInfo_RefCode_IsChanged){sbParameter.Append("FHelperInfo_RefCode=@FHelperInfo_RefCode, ");}
      if(fHelper_Info.FHelperInfo_PartCode_IsChanged){sbParameter.Append("FHelperInfo_PartCode=@FHelperInfo_PartCode, ");}
      if(fHelper_Info.FHelperInfo_ProdCode_IsChanged){sbParameter.Append("FHelperInfo_ProdCode=@FHelperInfo_ProdCode, ");}
      if(fHelper_Info.FHelperInfo_RoadNodes_IsChanged){sbParameter.Append("FHelperInfo_RoadNodes=@FHelperInfo_RoadNodes, ");}
      if(fHelper_Info.FHelperInfo_FSup_IsChanged){sbParameter.Append("FHelperInfo_FSup=@FHelperInfo_FSup, ");}
      if(fHelper_Info.FHelperInfo_PriceID_IsChanged){sbParameter.Append("FHelperInfo_PriceID=@FHelperInfo_PriceID, ");}
      if(fHelper_Info.FHelperInfo_Price_IsChanged){sbParameter.Append("FHelperInfo_Price=@FHelperInfo_Price, ");}
      if(fHelper_Info.FHelperInfo_Num_IsChanged){sbParameter.Append("FHelperInfo_Num=@FHelperInfo_Num, ");}
      if(fHelper_Info.FHelperInfo_FNum_IsChanged){sbParameter.Append("FHelperInfo_FNum=@FHelperInfo_FNum, ");}
      if(fHelper_Info.FHelperInfo_DNum_IsChanged){sbParameter.Append("FHelperInfo_DNum=@FHelperInfo_DNum, ");}
      if(fHelper_Info.FHelperInfo_Owner_IsChanged){sbParameter.Append("FHelperInfo_Owner=@FHelperInfo_Owner, ");}
      if(fHelper_Info.FHelperInfo_Date_IsChanged){sbParameter.Append("FHelperInfo_Date=@FHelperInfo_Date, ");}
      if(fHelper_Info.FHelperInfo_Stat_IsChanged){sbParameter.Append("FHelperInfo_Stat=@FHelperInfo_Stat, ");}
      if(fHelper_Info.FHelperInfo_Bak_IsChanged){sbParameter.Append("FHelperInfo_Bak=@FHelperInfo_Bak, ");}
      if(fHelper_Info.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(fHelper_Info.FHelperInfo_FStat_IsChanged){sbParameter.Append("FHelperInfo_FStat=@FHelperInfo_FStat, ");}
      if(fHelper_Info.FHelperInfo_iType_IsChanged){sbParameter.Append("FHelperInfo_iType=@FHelperInfo_iType, ");}
      if(fHelper_Info.FHelperInfo_BackDate_IsChanged){sbParameter.Append("FHelperInfo_BackDate=@FHelperInfo_BackDate, ");}
      if(fHelper_Info.FHelperInfo_OutDate_IsChanged){sbParameter.Append("FHelperInfo_OutDate=@FHelperInfo_OutDate, ");}
      if(fHelper_Info.FHelperInfo_IsBatch_IsChanged){sbParameter.Append("FHelperInfo_IsBatch=@FHelperInfo_IsBatch ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and FHelperInfo_ID=@FHelperInfo_ID; " );
      string sql=sb.ToString();
         if(fHelper_Info.FHelperInfo_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Code))
         {
            idb.AddParameter("@FHelperInfo_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Code", fHelper_Info.FHelperInfo_Code);
         }
          }
         if(fHelper_Info.FHelperInfo_RefCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_RefCode))
         {
            idb.AddParameter("@FHelperInfo_RefCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_RefCode", fHelper_Info.FHelperInfo_RefCode);
         }
          }
         if(fHelper_Info.FHelperInfo_PartCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_PartCode))
         {
            idb.AddParameter("@FHelperInfo_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_PartCode", fHelper_Info.FHelperInfo_PartCode);
         }
          }
         if(fHelper_Info.FHelperInfo_ProdCode_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_ProdCode))
         {
            idb.AddParameter("@FHelperInfo_ProdCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_ProdCode", fHelper_Info.FHelperInfo_ProdCode);
         }
          }
         if(fHelper_Info.FHelperInfo_RoadNodes_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_RoadNodes))
         {
            idb.AddParameter("@FHelperInfo_RoadNodes", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_RoadNodes", fHelper_Info.FHelperInfo_RoadNodes);
         }
          }
         if(fHelper_Info.FHelperInfo_FSup_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_FSup))
         {
            idb.AddParameter("@FHelperInfo_FSup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FSup", fHelper_Info.FHelperInfo_FSup);
         }
          }
         if(fHelper_Info.FHelperInfo_PriceID_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_PriceID))
         {
            idb.AddParameter("@FHelperInfo_PriceID", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_PriceID", fHelper_Info.FHelperInfo_PriceID);
         }
          }
         if(fHelper_Info.FHelperInfo_Price_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_Price == 0)
         {
            idb.AddParameter("@FHelperInfo_Price", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Price", fHelper_Info.FHelperInfo_Price);
         }
          }
         if(fHelper_Info.FHelperInfo_Num_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_Num == 0)
         {
            idb.AddParameter("@FHelperInfo_Num", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Num", fHelper_Info.FHelperInfo_Num);
         }
          }
         if(fHelper_Info.FHelperInfo_FNum_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_FNum == 0)
         {
            idb.AddParameter("@FHelperInfo_FNum", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FNum", fHelper_Info.FHelperInfo_FNum);
         }
          }
         if(fHelper_Info.FHelperInfo_DNum_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_DNum == 0)
         {
            idb.AddParameter("@FHelperInfo_DNum", 0);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_DNum", fHelper_Info.FHelperInfo_DNum);
         }
          }
         if(fHelper_Info.FHelperInfo_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Owner))
         {
            idb.AddParameter("@FHelperInfo_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Owner", fHelper_Info.FHelperInfo_Owner);
         }
          }
         if(fHelper_Info.FHelperInfo_Date_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_Date == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Date", fHelper_Info.FHelperInfo_Date);
         }
          }
         if(fHelper_Info.FHelperInfo_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Stat))
         {
            idb.AddParameter("@FHelperInfo_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Stat", fHelper_Info.FHelperInfo_Stat);
         }
          }
         if(fHelper_Info.FHelperInfo_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_Bak))
         {
            idb.AddParameter("@FHelperInfo_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_Bak", fHelper_Info.FHelperInfo_Bak);
         }
          }
         if(fHelper_Info.Stat_IsChanged)
         {
         if (fHelper_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", fHelper_Info.Stat);
         }
          }
         if(fHelper_Info.FHelperInfo_FStat_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_FStat))
         {
            idb.AddParameter("@FHelperInfo_FStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_FStat", fHelper_Info.FHelperInfo_FStat);
         }
          }
         if(fHelper_Info.FHelperInfo_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_iType))
         {
            idb.AddParameter("@FHelperInfo_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_iType", fHelper_Info.FHelperInfo_iType);
         }
          }
         if(fHelper_Info.FHelperInfo_BackDate_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_BackDate == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_BackDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_BackDate", fHelper_Info.FHelperInfo_BackDate);
         }
          }
         if(fHelper_Info.FHelperInfo_OutDate_IsChanged)
         {
         if (fHelper_Info.FHelperInfo_OutDate == DateTime.MinValue)
         {
            idb.AddParameter("@FHelperInfo_OutDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_OutDate", fHelper_Info.FHelperInfo_OutDate);
         }
          }
         if(fHelper_Info.FHelperInfo_IsBatch_IsChanged)
         {
         if (string.IsNullOrEmpty(fHelper_Info.FHelperInfo_IsBatch))
         {
            idb.AddParameter("@FHelperInfo_IsBatch", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@FHelperInfo_IsBatch", fHelper_Info.FHelperInfo_IsBatch);
         }
          }

         idb.AddParameter("@FHelperInfo_ID", fHelper_Info.FHelperInfo_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除外协信息记录 FHelper_Info对象(即:一条记录
      /// </summary>
      public int Delete(Int64 fHelperInfo_ID)
      {
         string sql = "DELETE FHelper_Info WHERE 1=1  AND FHelperInfo_ID=@FHelperInfo_ID ";
         idb.AddParameter("@FHelperInfo_ID", fHelperInfo_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的外协信息记录 FHelper_Info对象(即:一条记录
      /// </summary>
      public FHelper_Info GetByKey(Int64 fHelperInfo_ID)
      {
         FHelper_Info fHelper_Info = new FHelper_Info();
         string sql = "SELECT  FHelperInfo_ID,FHelperInfo_Code,FHelperInfo_RefCode,FHelperInfo_PartCode,FHelperInfo_ProdCode,FHelperInfo_RoadNodes,FHelperInfo_FSup,FHelperInfo_PriceID,FHelperInfo_Price,FHelperInfo_Num,FHelperInfo_FNum,FHelperInfo_DNum,FHelperInfo_Owner,FHelperInfo_Date,FHelperInfo_Stat,FHelperInfo_Bak,Stat,FHelperInfo_FStat,FHelperInfo_iType,FHelperInfo_BackDate,FHelperInfo_OutDate,FHelperInfo_IsBatch FROM FHelper_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND FHelperInfo_ID=@FHelperInfo_ID ";
         idb.AddParameter("@FHelperInfo_ID", fHelperInfo_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["FHelperInfo_ID"] != DBNull.Value) fHelper_Info.FHelperInfo_ID = Convert.ToInt64(dr["FHelperInfo_ID"]);
            if (dr["FHelperInfo_Code"] != DBNull.Value) fHelper_Info.FHelperInfo_Code = Convert.ToString(dr["FHelperInfo_Code"]);
            if (dr["FHelperInfo_RefCode"] != DBNull.Value) fHelper_Info.FHelperInfo_RefCode = Convert.ToString(dr["FHelperInfo_RefCode"]);
            if (dr["FHelperInfo_PartCode"] != DBNull.Value) fHelper_Info.FHelperInfo_PartCode = Convert.ToString(dr["FHelperInfo_PartCode"]);
            if (dr["FHelperInfo_ProdCode"] != DBNull.Value) fHelper_Info.FHelperInfo_ProdCode = Convert.ToString(dr["FHelperInfo_ProdCode"]);
            if (dr["FHelperInfo_RoadNodes"] != DBNull.Value) fHelper_Info.FHelperInfo_RoadNodes = Convert.ToString(dr["FHelperInfo_RoadNodes"]);
            if (dr["FHelperInfo_FSup"] != DBNull.Value) fHelper_Info.FHelperInfo_FSup = Convert.ToString(dr["FHelperInfo_FSup"]);
            if (dr["FHelperInfo_PriceID"] != DBNull.Value) fHelper_Info.FHelperInfo_PriceID = Convert.ToString(dr["FHelperInfo_PriceID"]);
            if (dr["FHelperInfo_Price"] != DBNull.Value) fHelper_Info.FHelperInfo_Price = Convert.ToDecimal(dr["FHelperInfo_Price"]);
            if (dr["FHelperInfo_Num"] != DBNull.Value) fHelper_Info.FHelperInfo_Num = Convert.ToInt32(dr["FHelperInfo_Num"]);
            if (dr["FHelperInfo_FNum"] != DBNull.Value) fHelper_Info.FHelperInfo_FNum = Convert.ToInt32(dr["FHelperInfo_FNum"]);
            if (dr["FHelperInfo_DNum"] != DBNull.Value) fHelper_Info.FHelperInfo_DNum = Convert.ToInt32(dr["FHelperInfo_DNum"]);
            if (dr["FHelperInfo_Owner"] != DBNull.Value) fHelper_Info.FHelperInfo_Owner = Convert.ToString(dr["FHelperInfo_Owner"]);
            if (dr["FHelperInfo_Date"] != DBNull.Value) fHelper_Info.FHelperInfo_Date = Convert.ToDateTime(dr["FHelperInfo_Date"]);
            if (dr["FHelperInfo_Stat"] != DBNull.Value) fHelper_Info.FHelperInfo_Stat = Convert.ToString(dr["FHelperInfo_Stat"]);
            if (dr["FHelperInfo_Bak"] != DBNull.Value) fHelper_Info.FHelperInfo_Bak = Convert.ToString(dr["FHelperInfo_Bak"]);
            if (dr["Stat"] != DBNull.Value) fHelper_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["FHelperInfo_FStat"] != DBNull.Value) fHelper_Info.FHelperInfo_FStat = Convert.ToString(dr["FHelperInfo_FStat"]);
            if (dr["FHelperInfo_iType"] != DBNull.Value) fHelper_Info.FHelperInfo_iType = Convert.ToString(dr["FHelperInfo_iType"]);
            if (dr["FHelperInfo_BackDate"] != DBNull.Value) fHelper_Info.FHelperInfo_BackDate = Convert.ToDateTime(dr["FHelperInfo_BackDate"]);
            if (dr["FHelperInfo_OutDate"] != DBNull.Value) fHelper_Info.FHelperInfo_OutDate = Convert.ToDateTime(dr["FHelperInfo_OutDate"]);
            if (dr["FHelperInfo_IsBatch"] != DBNull.Value) fHelper_Info.FHelperInfo_IsBatch = Convert.ToString(dr["FHelperInfo_IsBatch"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return fHelper_Info;
      }
      /// <summary>
      /// 获取指定的外协信息记录 FHelper_Info对象集合
      /// </summary>
      public List<FHelper_Info> GetListByWhere(string strCondition)
      {
         List<FHelper_Info> ret = new List<FHelper_Info>();
         string sql = "SELECT  FHelperInfo_ID,FHelperInfo_Code,FHelperInfo_RefCode,FHelperInfo_PartCode,FHelperInfo_ProdCode,FHelperInfo_RoadNodes,FHelperInfo_FSup,FHelperInfo_PriceID,FHelperInfo_Price,FHelperInfo_Num,FHelperInfo_FNum,FHelperInfo_DNum,FHelperInfo_Owner,FHelperInfo_Date,FHelperInfo_Stat,FHelperInfo_Bak,Stat,FHelperInfo_FStat,FHelperInfo_iType,FHelperInfo_BackDate,FHelperInfo_OutDate,FHelperInfo_IsBatch FROM FHelper_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            FHelper_Info fHelper_Info = new FHelper_Info();
            if (dr["FHelperInfo_ID"] != DBNull.Value) fHelper_Info.FHelperInfo_ID = Convert.ToInt64(dr["FHelperInfo_ID"]);
            if (dr["FHelperInfo_Code"] != DBNull.Value) fHelper_Info.FHelperInfo_Code = Convert.ToString(dr["FHelperInfo_Code"]);
            if (dr["FHelperInfo_RefCode"] != DBNull.Value) fHelper_Info.FHelperInfo_RefCode = Convert.ToString(dr["FHelperInfo_RefCode"]);
            if (dr["FHelperInfo_PartCode"] != DBNull.Value) fHelper_Info.FHelperInfo_PartCode = Convert.ToString(dr["FHelperInfo_PartCode"]);
            if (dr["FHelperInfo_ProdCode"] != DBNull.Value) fHelper_Info.FHelperInfo_ProdCode = Convert.ToString(dr["FHelperInfo_ProdCode"]);
            if (dr["FHelperInfo_RoadNodes"] != DBNull.Value) fHelper_Info.FHelperInfo_RoadNodes = Convert.ToString(dr["FHelperInfo_RoadNodes"]);
            if (dr["FHelperInfo_FSup"] != DBNull.Value) fHelper_Info.FHelperInfo_FSup = Convert.ToString(dr["FHelperInfo_FSup"]);
            if (dr["FHelperInfo_PriceID"] != DBNull.Value) fHelper_Info.FHelperInfo_PriceID = Convert.ToString(dr["FHelperInfo_PriceID"]);
            if (dr["FHelperInfo_Price"] != DBNull.Value) fHelper_Info.FHelperInfo_Price = Convert.ToDecimal(dr["FHelperInfo_Price"]);
            if (dr["FHelperInfo_Num"] != DBNull.Value) fHelper_Info.FHelperInfo_Num = Convert.ToInt32(dr["FHelperInfo_Num"]);
            if (dr["FHelperInfo_FNum"] != DBNull.Value) fHelper_Info.FHelperInfo_FNum = Convert.ToInt32(dr["FHelperInfo_FNum"]);
            if (dr["FHelperInfo_DNum"] != DBNull.Value) fHelper_Info.FHelperInfo_DNum = Convert.ToInt32(dr["FHelperInfo_DNum"]);
            if (dr["FHelperInfo_Owner"] != DBNull.Value) fHelper_Info.FHelperInfo_Owner = Convert.ToString(dr["FHelperInfo_Owner"]);
            if (dr["FHelperInfo_Date"] != DBNull.Value) fHelper_Info.FHelperInfo_Date = Convert.ToDateTime(dr["FHelperInfo_Date"]);
            if (dr["FHelperInfo_Stat"] != DBNull.Value) fHelper_Info.FHelperInfo_Stat = Convert.ToString(dr["FHelperInfo_Stat"]);
            if (dr["FHelperInfo_Bak"] != DBNull.Value) fHelper_Info.FHelperInfo_Bak = Convert.ToString(dr["FHelperInfo_Bak"]);
            if (dr["Stat"] != DBNull.Value) fHelper_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["FHelperInfo_FStat"] != DBNull.Value) fHelper_Info.FHelperInfo_FStat = Convert.ToString(dr["FHelperInfo_FStat"]);
            if (dr["FHelperInfo_iType"] != DBNull.Value) fHelper_Info.FHelperInfo_iType = Convert.ToString(dr["FHelperInfo_iType"]);
            if (dr["FHelperInfo_BackDate"] != DBNull.Value) fHelper_Info.FHelperInfo_BackDate = Convert.ToDateTime(dr["FHelperInfo_BackDate"]);
            if (dr["FHelperInfo_OutDate"] != DBNull.Value) fHelper_Info.FHelperInfo_OutDate = Convert.ToDateTime(dr["FHelperInfo_OutDate"]);
            if (dr["FHelperInfo_IsBatch"] != DBNull.Value) fHelper_Info.FHelperInfo_IsBatch = Convert.ToString(dr["FHelperInfo_IsBatch"]);
            ret.Add(fHelper_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的外协信息记录 FHelper_Info对象(即:一条记录
      /// </summary>
      public List<FHelper_Info> GetAll()
      {
         List<FHelper_Info> ret = new List<FHelper_Info>();
         string sql = "SELECT  FHelperInfo_ID,FHelperInfo_Code,FHelperInfo_RefCode,FHelperInfo_PartCode,FHelperInfo_ProdCode,FHelperInfo_RoadNodes,FHelperInfo_FSup,FHelperInfo_PriceID,FHelperInfo_Price,FHelperInfo_Num,FHelperInfo_FNum,FHelperInfo_DNum,FHelperInfo_Owner,FHelperInfo_Date,FHelperInfo_Stat,FHelperInfo_Bak,Stat,FHelperInfo_FStat,FHelperInfo_iType,FHelperInfo_BackDate,FHelperInfo_OutDate,FHelperInfo_IsBatch FROM FHelper_Info where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            FHelper_Info fHelper_Info = new FHelper_Info();
            if (dr["FHelperInfo_ID"] != DBNull.Value) fHelper_Info.FHelperInfo_ID = Convert.ToInt64(dr["FHelperInfo_ID"]);
            if (dr["FHelperInfo_Code"] != DBNull.Value) fHelper_Info.FHelperInfo_Code = Convert.ToString(dr["FHelperInfo_Code"]);
            if (dr["FHelperInfo_RefCode"] != DBNull.Value) fHelper_Info.FHelperInfo_RefCode = Convert.ToString(dr["FHelperInfo_RefCode"]);
            if (dr["FHelperInfo_PartCode"] != DBNull.Value) fHelper_Info.FHelperInfo_PartCode = Convert.ToString(dr["FHelperInfo_PartCode"]);
            if (dr["FHelperInfo_ProdCode"] != DBNull.Value) fHelper_Info.FHelperInfo_ProdCode = Convert.ToString(dr["FHelperInfo_ProdCode"]);
            if (dr["FHelperInfo_RoadNodes"] != DBNull.Value) fHelper_Info.FHelperInfo_RoadNodes = Convert.ToString(dr["FHelperInfo_RoadNodes"]);
            if (dr["FHelperInfo_FSup"] != DBNull.Value) fHelper_Info.FHelperInfo_FSup = Convert.ToString(dr["FHelperInfo_FSup"]);
            if (dr["FHelperInfo_PriceID"] != DBNull.Value) fHelper_Info.FHelperInfo_PriceID = Convert.ToString(dr["FHelperInfo_PriceID"]);
            if (dr["FHelperInfo_Price"] != DBNull.Value) fHelper_Info.FHelperInfo_Price = Convert.ToDecimal(dr["FHelperInfo_Price"]);
            if (dr["FHelperInfo_Num"] != DBNull.Value) fHelper_Info.FHelperInfo_Num = Convert.ToInt32(dr["FHelperInfo_Num"]);
            if (dr["FHelperInfo_FNum"] != DBNull.Value) fHelper_Info.FHelperInfo_FNum = Convert.ToInt32(dr["FHelperInfo_FNum"]);
            if (dr["FHelperInfo_DNum"] != DBNull.Value) fHelper_Info.FHelperInfo_DNum = Convert.ToInt32(dr["FHelperInfo_DNum"]);
            if (dr["FHelperInfo_Owner"] != DBNull.Value) fHelper_Info.FHelperInfo_Owner = Convert.ToString(dr["FHelperInfo_Owner"]);
            if (dr["FHelperInfo_Date"] != DBNull.Value) fHelper_Info.FHelperInfo_Date = Convert.ToDateTime(dr["FHelperInfo_Date"]);
            if (dr["FHelperInfo_Stat"] != DBNull.Value) fHelper_Info.FHelperInfo_Stat = Convert.ToString(dr["FHelperInfo_Stat"]);
            if (dr["FHelperInfo_Bak"] != DBNull.Value) fHelper_Info.FHelperInfo_Bak = Convert.ToString(dr["FHelperInfo_Bak"]);
            if (dr["Stat"] != DBNull.Value) fHelper_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["FHelperInfo_FStat"] != DBNull.Value) fHelper_Info.FHelperInfo_FStat = Convert.ToString(dr["FHelperInfo_FStat"]);
            if (dr["FHelperInfo_iType"] != DBNull.Value) fHelper_Info.FHelperInfo_iType = Convert.ToString(dr["FHelperInfo_iType"]);
            if (dr["FHelperInfo_BackDate"] != DBNull.Value) fHelper_Info.FHelperInfo_BackDate = Convert.ToDateTime(dr["FHelperInfo_BackDate"]);
            if (dr["FHelperInfo_OutDate"] != DBNull.Value) fHelper_Info.FHelperInfo_OutDate = Convert.ToDateTime(dr["FHelperInfo_OutDate"]);
            if (dr["FHelperInfo_IsBatch"] != DBNull.Value) fHelper_Info.FHelperInfo_IsBatch = Convert.ToString(dr["FHelperInfo_IsBatch"]);
            ret.Add(fHelper_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
