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
   /// 零件工艺路线模板
   /// </summary>
   [Serializable]
   public partial class ADORoad_Nodes
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加零件工艺路线模板 Road_Nodes对象(即:一条记录)
      /// </summary>
      public int Add(Road_Nodes road_Nodes)
      {
         string sql = "INSERT INTO Road_Nodes (RNodes_PartCode,RNodes_PartName,RNodes_Code,RNodes_Name,RNodes_Order,RNodes_TimeCost,RNodes_Cost,RNodes_Value,RNodes_PriceStat,RNodes_Stat,RNodes_Dept_Code,RNodes_Dept_Name,RNodes_EquCode,RNodes_EquName,RNodes_EquTime,RNodes_Class_Code,RNodes_Class_Name,RNodes_Func,RNodes_CurPriceNode,Stat,UpdateTime,RNodes_Udef1,RNodes_Udef2,RNodes_Udef3) VALUES (@RNodes_PartCode,@RNodes_PartName,@RNodes_Code,@RNodes_Name,@RNodes_Order,@RNodes_TimeCost,@RNodes_Cost,@RNodes_Value,@RNodes_PriceStat,@RNodes_Stat,@RNodes_Dept_Code,@RNodes_Dept_Name,@RNodes_EquCode,@RNodes_EquName,@RNodes_EquTime,@RNodes_Class_Code,@RNodes_Class_Name,@RNodes_Func,@RNodes_CurPriceNode,@Stat,@UpdateTime,@RNodes_Udef1,@RNodes_Udef2,@RNodes_Udef3)";
         if (string.IsNullOrEmpty(road_Nodes.RNodes_PartCode))
         {
            idb.AddParameter("@RNodes_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_PartCode", road_Nodes.RNodes_PartCode);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_PartName))
         {
            idb.AddParameter("@RNodes_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_PartName", road_Nodes.RNodes_PartName);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Code))
         {
            idb.AddParameter("@RNodes_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Code", road_Nodes.RNodes_Code);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Name))
         {
            idb.AddParameter("@RNodes_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Name", road_Nodes.RNodes_Name);
         }
         if (road_Nodes.RNodes_Order == 0)
         {
            idb.AddParameter("@RNodes_Order", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Order", road_Nodes.RNodes_Order);
         }
         if (road_Nodes.RNodes_TimeCost == 0)
         {
            idb.AddParameter("@RNodes_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_TimeCost", road_Nodes.RNodes_TimeCost);
         }
         if (road_Nodes.RNodes_Cost == 0)
         {
            idb.AddParameter("@RNodes_Cost", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Cost", road_Nodes.RNodes_Cost);
         }
         if (road_Nodes.RNodes_Value == 0)
         {
            idb.AddParameter("@RNodes_Value", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Value", road_Nodes.RNodes_Value);
         }
         if (road_Nodes.RNodes_PriceStat == 0)
         {
            idb.AddParameter("@RNodes_PriceStat", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_PriceStat", road_Nodes.RNodes_PriceStat);
         }
         if (road_Nodes.RNodes_Stat == 0)
         {
            idb.AddParameter("@RNodes_Stat", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Stat", road_Nodes.RNodes_Stat);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Dept_Code))
         {
            idb.AddParameter("@RNodes_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Dept_Code", road_Nodes.RNodes_Dept_Code);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Dept_Name))
         {
            idb.AddParameter("@RNodes_Dept_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Dept_Name", road_Nodes.RNodes_Dept_Name);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_EquCode))
         {
            idb.AddParameter("@RNodes_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_EquCode", road_Nodes.RNodes_EquCode);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_EquName))
         {
            idb.AddParameter("@RNodes_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_EquName", road_Nodes.RNodes_EquName);
         }
         if (road_Nodes.RNodes_EquTime == 0)
         {
            idb.AddParameter("@RNodes_EquTime", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_EquTime", road_Nodes.RNodes_EquTime);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Class_Code))
         {
            idb.AddParameter("@RNodes_Class_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Class_Code", road_Nodes.RNodes_Class_Code);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Class_Name))
         {
            idb.AddParameter("@RNodes_Class_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Class_Name", road_Nodes.RNodes_Class_Name);
         }
         if (road_Nodes.RNodes_Func == 0)
         {
            idb.AddParameter("@RNodes_Func", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Func", road_Nodes.RNodes_Func);
         }
         if (road_Nodes.RNodes_CurPriceNode == 0)
         {
            idb.AddParameter("@RNodes_CurPriceNode", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_CurPriceNode", road_Nodes.RNodes_CurPriceNode);
         }
         if (road_Nodes.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_Nodes.Stat);
         }
         if (road_Nodes.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", road_Nodes.UpdateTime);
         }
         if (road_Nodes.RNodes_Udef1 == 0)
         {
            idb.AddParameter("@RNodes_Udef1", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef1", road_Nodes.RNodes_Udef1);
         }
         if (road_Nodes.RNodes_Udef2 == 0)
         {
            idb.AddParameter("@RNodes_Udef2", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef2", road_Nodes.RNodes_Udef2);
         }
         if (road_Nodes.RNodes_Udef3 == 0)
         {
            idb.AddParameter("@RNodes_Udef3", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef3", road_Nodes.RNodes_Udef3);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加零件工艺路线模板 Road_Nodes对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Road_Nodes road_Nodes)
      {
         string sql = "INSERT INTO Road_Nodes (RNodes_PartCode,RNodes_PartName,RNodes_Code,RNodes_Name,RNodes_Order,RNodes_TimeCost,RNodes_Cost,RNodes_Value,RNodes_PriceStat,RNodes_Stat,RNodes_Dept_Code,RNodes_Dept_Name,RNodes_EquCode,RNodes_EquName,RNodes_EquTime,RNodes_Class_Code,RNodes_Class_Name,RNodes_Func,RNodes_CurPriceNode,Stat,UpdateTime,RNodes_Udef1,RNodes_Udef2,RNodes_Udef3) VALUES (@RNodes_PartCode,@RNodes_PartName,@RNodes_Code,@RNodes_Name,@RNodes_Order,@RNodes_TimeCost,@RNodes_Cost,@RNodes_Value,@RNodes_PriceStat,@RNodes_Stat,@RNodes_Dept_Code,@RNodes_Dept_Name,@RNodes_EquCode,@RNodes_EquName,@RNodes_EquTime,@RNodes_Class_Code,@RNodes_Class_Name,@RNodes_Func,@RNodes_CurPriceNode,@Stat,@UpdateTime,@RNodes_Udef1,@RNodes_Udef2,@RNodes_Udef3);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(road_Nodes.RNodes_PartCode))
         {
            idb.AddParameter("@RNodes_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_PartCode", road_Nodes.RNodes_PartCode);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_PartName))
         {
            idb.AddParameter("@RNodes_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_PartName", road_Nodes.RNodes_PartName);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Code))
         {
            idb.AddParameter("@RNodes_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Code", road_Nodes.RNodes_Code);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Name))
         {
            idb.AddParameter("@RNodes_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Name", road_Nodes.RNodes_Name);
         }
         if (road_Nodes.RNodes_Order == 0)
         {
            idb.AddParameter("@RNodes_Order", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Order", road_Nodes.RNodes_Order);
         }
         if (road_Nodes.RNodes_TimeCost == 0)
         {
            idb.AddParameter("@RNodes_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_TimeCost", road_Nodes.RNodes_TimeCost);
         }
         if (road_Nodes.RNodes_Cost == 0)
         {
            idb.AddParameter("@RNodes_Cost", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Cost", road_Nodes.RNodes_Cost);
         }
         if (road_Nodes.RNodes_Value == 0)
         {
            idb.AddParameter("@RNodes_Value", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Value", road_Nodes.RNodes_Value);
         }
         if (road_Nodes.RNodes_PriceStat == 0)
         {
            idb.AddParameter("@RNodes_PriceStat", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_PriceStat", road_Nodes.RNodes_PriceStat);
         }
         if (road_Nodes.RNodes_Stat == 0)
         {
            idb.AddParameter("@RNodes_Stat", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Stat", road_Nodes.RNodes_Stat);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Dept_Code))
         {
            idb.AddParameter("@RNodes_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Dept_Code", road_Nodes.RNodes_Dept_Code);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Dept_Name))
         {
            idb.AddParameter("@RNodes_Dept_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Dept_Name", road_Nodes.RNodes_Dept_Name);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_EquCode))
         {
            idb.AddParameter("@RNodes_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_EquCode", road_Nodes.RNodes_EquCode);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_EquName))
         {
            idb.AddParameter("@RNodes_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_EquName", road_Nodes.RNodes_EquName);
         }
         if (road_Nodes.RNodes_EquTime == 0)
         {
            idb.AddParameter("@RNodes_EquTime", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_EquTime", road_Nodes.RNodes_EquTime);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Class_Code))
         {
            idb.AddParameter("@RNodes_Class_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Class_Code", road_Nodes.RNodes_Class_Code);
         }
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Class_Name))
         {
            idb.AddParameter("@RNodes_Class_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Class_Name", road_Nodes.RNodes_Class_Name);
         }
         if (road_Nodes.RNodes_Func == 0)
         {
            idb.AddParameter("@RNodes_Func", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Func", road_Nodes.RNodes_Func);
         }
         if (road_Nodes.RNodes_CurPriceNode == 0)
         {
            idb.AddParameter("@RNodes_CurPriceNode", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_CurPriceNode", road_Nodes.RNodes_CurPriceNode);
         }
         if (road_Nodes.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_Nodes.Stat);
         }
         if (road_Nodes.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", road_Nodes.UpdateTime);
         }
         if (road_Nodes.RNodes_Udef1 == 0)
         {
            idb.AddParameter("@RNodes_Udef1", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef1", road_Nodes.RNodes_Udef1);
         }
         if (road_Nodes.RNodes_Udef2 == 0)
         {
            idb.AddParameter("@RNodes_Udef2", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef2", road_Nodes.RNodes_Udef2);
         }
         if (road_Nodes.RNodes_Udef3 == 0)
         {
            idb.AddParameter("@RNodes_Udef3", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef3", road_Nodes.RNodes_Udef3);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新零件工艺路线模板 Road_Nodes对象(即:一条记录
      /// </summary>
      public int Update(Road_Nodes road_Nodes)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Road_Nodes       SET ");
            if(road_Nodes.RNodes_PartCode_IsChanged){sbParameter.Append("RNodes_PartCode=@RNodes_PartCode, ");}
      if(road_Nodes.RNodes_PartName_IsChanged){sbParameter.Append("RNodes_PartName=@RNodes_PartName, ");}
      if(road_Nodes.RNodes_Code_IsChanged){sbParameter.Append("RNodes_Code=@RNodes_Code, ");}
      if(road_Nodes.RNodes_Name_IsChanged){sbParameter.Append("RNodes_Name=@RNodes_Name, ");}
      if(road_Nodes.RNodes_Order_IsChanged){sbParameter.Append("RNodes_Order=@RNodes_Order, ");}
      if(road_Nodes.RNodes_TimeCost_IsChanged){sbParameter.Append("RNodes_TimeCost=@RNodes_TimeCost, ");}
      if(road_Nodes.RNodes_Cost_IsChanged){sbParameter.Append("RNodes_Cost=@RNodes_Cost, ");}
      if(road_Nodes.RNodes_Value_IsChanged){sbParameter.Append("RNodes_Value=@RNodes_Value, ");}
      if(road_Nodes.RNodes_PriceStat_IsChanged){sbParameter.Append("RNodes_PriceStat=@RNodes_PriceStat, ");}
      if(road_Nodes.RNodes_Stat_IsChanged){sbParameter.Append("RNodes_Stat=@RNodes_Stat, ");}
      if(road_Nodes.RNodes_Dept_Code_IsChanged){sbParameter.Append("RNodes_Dept_Code=@RNodes_Dept_Code, ");}
      if(road_Nodes.RNodes_Dept_Name_IsChanged){sbParameter.Append("RNodes_Dept_Name=@RNodes_Dept_Name, ");}
      if(road_Nodes.RNodes_EquCode_IsChanged){sbParameter.Append("RNodes_EquCode=@RNodes_EquCode, ");}
      if(road_Nodes.RNodes_EquName_IsChanged){sbParameter.Append("RNodes_EquName=@RNodes_EquName, ");}
      if(road_Nodes.RNodes_EquTime_IsChanged){sbParameter.Append("RNodes_EquTime=@RNodes_EquTime, ");}
      if(road_Nodes.RNodes_Class_Code_IsChanged){sbParameter.Append("RNodes_Class_Code=@RNodes_Class_Code, ");}
      if(road_Nodes.RNodes_Class_Name_IsChanged){sbParameter.Append("RNodes_Class_Name=@RNodes_Class_Name, ");}
      if(road_Nodes.RNodes_Func_IsChanged){sbParameter.Append("RNodes_Func=@RNodes_Func, ");}
      if(road_Nodes.RNodes_CurPriceNode_IsChanged){sbParameter.Append("RNodes_CurPriceNode=@RNodes_CurPriceNode, ");}
      if(road_Nodes.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(road_Nodes.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(road_Nodes.RNodes_Udef1_IsChanged){sbParameter.Append("RNodes_Udef1=@RNodes_Udef1, ");}
      if(road_Nodes.RNodes_Udef2_IsChanged){sbParameter.Append("RNodes_Udef2=@RNodes_Udef2, ");}
      if(road_Nodes.RNodes_Udef3_IsChanged){sbParameter.Append("RNodes_Udef3=@RNodes_Udef3 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and RNodes_ID=@RNodes_ID; " );
      string sql=sb.ToString();
         if(road_Nodes.RNodes_PartCode_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_PartCode))
         {
            idb.AddParameter("@RNodes_PartCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_PartCode", road_Nodes.RNodes_PartCode);
         }
          }
         if(road_Nodes.RNodes_PartName_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_PartName))
         {
            idb.AddParameter("@RNodes_PartName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_PartName", road_Nodes.RNodes_PartName);
         }
          }
         if(road_Nodes.RNodes_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Code))
         {
            idb.AddParameter("@RNodes_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Code", road_Nodes.RNodes_Code);
         }
          }
         if(road_Nodes.RNodes_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Name))
         {
            idb.AddParameter("@RNodes_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Name", road_Nodes.RNodes_Name);
         }
          }
         if(road_Nodes.RNodes_Order_IsChanged)
         {
         if (road_Nodes.RNodes_Order == 0)
         {
            idb.AddParameter("@RNodes_Order", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Order", road_Nodes.RNodes_Order);
         }
          }
         if(road_Nodes.RNodes_TimeCost_IsChanged)
         {
         if (road_Nodes.RNodes_TimeCost == 0)
         {
            idb.AddParameter("@RNodes_TimeCost", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_TimeCost", road_Nodes.RNodes_TimeCost);
         }
          }
         if(road_Nodes.RNodes_Cost_IsChanged)
         {
         if (road_Nodes.RNodes_Cost == 0)
         {
            idb.AddParameter("@RNodes_Cost", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Cost", road_Nodes.RNodes_Cost);
         }
          }
         if(road_Nodes.RNodes_Value_IsChanged)
         {
         if (road_Nodes.RNodes_Value == 0)
         {
            idb.AddParameter("@RNodes_Value", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Value", road_Nodes.RNodes_Value);
         }
          }
         if(road_Nodes.RNodes_PriceStat_IsChanged)
         {
         if (road_Nodes.RNodes_PriceStat == 0)
         {
            idb.AddParameter("@RNodes_PriceStat", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_PriceStat", road_Nodes.RNodes_PriceStat);
         }
          }
         if(road_Nodes.RNodes_Stat_IsChanged)
         {
         if (road_Nodes.RNodes_Stat == 0)
         {
            idb.AddParameter("@RNodes_Stat", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Stat", road_Nodes.RNodes_Stat);
         }
          }
         if(road_Nodes.RNodes_Dept_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Dept_Code))
         {
            idb.AddParameter("@RNodes_Dept_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Dept_Code", road_Nodes.RNodes_Dept_Code);
         }
          }
         if(road_Nodes.RNodes_Dept_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Dept_Name))
         {
            idb.AddParameter("@RNodes_Dept_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Dept_Name", road_Nodes.RNodes_Dept_Name);
         }
          }
         if(road_Nodes.RNodes_EquCode_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_EquCode))
         {
            idb.AddParameter("@RNodes_EquCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_EquCode", road_Nodes.RNodes_EquCode);
         }
          }
         if(road_Nodes.RNodes_EquName_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_EquName))
         {
            idb.AddParameter("@RNodes_EquName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_EquName", road_Nodes.RNodes_EquName);
         }
          }
         if(road_Nodes.RNodes_EquTime_IsChanged)
         {
         if (road_Nodes.RNodes_EquTime == 0)
         {
            idb.AddParameter("@RNodes_EquTime", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_EquTime", road_Nodes.RNodes_EquTime);
         }
          }
         if(road_Nodes.RNodes_Class_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Class_Code))
         {
            idb.AddParameter("@RNodes_Class_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Class_Code", road_Nodes.RNodes_Class_Code);
         }
          }
         if(road_Nodes.RNodes_Class_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Nodes.RNodes_Class_Name))
         {
            idb.AddParameter("@RNodes_Class_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@RNodes_Class_Name", road_Nodes.RNodes_Class_Name);
         }
          }
         if(road_Nodes.RNodes_Func_IsChanged)
         {
         if (road_Nodes.RNodes_Func == 0)
         {
            idb.AddParameter("@RNodes_Func", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Func", road_Nodes.RNodes_Func);
         }
          }
         if(road_Nodes.RNodes_CurPriceNode_IsChanged)
         {
         if (road_Nodes.RNodes_CurPriceNode == 0)
         {
            idb.AddParameter("@RNodes_CurPriceNode", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_CurPriceNode", road_Nodes.RNodes_CurPriceNode);
         }
          }
         if(road_Nodes.Stat_IsChanged)
         {
         if (road_Nodes.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_Nodes.Stat);
         }
          }
         if(road_Nodes.UpdateTime_IsChanged)
         {
         if (road_Nodes.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", road_Nodes.UpdateTime);
         }
          }
         if(road_Nodes.RNodes_Udef1_IsChanged)
         {
         if (road_Nodes.RNodes_Udef1 == 0)
         {
            idb.AddParameter("@RNodes_Udef1", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef1", road_Nodes.RNodes_Udef1);
         }
          }
         if(road_Nodes.RNodes_Udef2_IsChanged)
         {
         if (road_Nodes.RNodes_Udef2 == 0)
         {
            idb.AddParameter("@RNodes_Udef2", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef2", road_Nodes.RNodes_Udef2);
         }
          }
         if(road_Nodes.RNodes_Udef3_IsChanged)
         {
         if (road_Nodes.RNodes_Udef3 == 0)
         {
            idb.AddParameter("@RNodes_Udef3", 0);
         }
         else
         {
            idb.AddParameter("@RNodes_Udef3", road_Nodes.RNodes_Udef3);
         }
          }

         idb.AddParameter("@RNodes_ID", road_Nodes.RNodes_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除零件工艺路线模板 Road_Nodes对象(即:一条记录
      /// </summary>
      public int Delete(Int64 rNodes_ID)
      {
         string sql = "DELETE Road_Nodes WHERE 1=1  AND RNodes_ID=@RNodes_ID ";
         idb.AddParameter("@RNodes_ID", rNodes_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的零件工艺路线模板 Road_Nodes对象(即:一条记录
      /// </summary>
      public Road_Nodes GetByKey(Int64 rNodes_ID)
      {
         Road_Nodes road_Nodes = new Road_Nodes();
         string sql = "SELECT  RNodes_ID,RNodes_PartCode,RNodes_PartName,RNodes_Code,RNodes_Name,RNodes_Order,RNodes_TimeCost,RNodes_Cost,RNodes_Value,RNodes_PriceStat,RNodes_Stat,RNodes_Dept_Code,RNodes_Dept_Name,RNodes_EquCode,RNodes_EquName,RNodes_EquTime,RNodes_Class_Code,RNodes_Class_Name,RNodes_Func,RNodes_CurPriceNode,Stat,UpdateTime,RNodes_Udef1,RNodes_Udef2,RNodes_Udef3 FROM Road_Nodes WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND RNodes_ID=@RNodes_ID ";
         idb.AddParameter("@RNodes_ID", rNodes_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["RNodes_ID"] != DBNull.Value) road_Nodes.RNodes_ID = Convert.ToInt64(dr["RNodes_ID"]);
            if (dr["RNodes_PartCode"] != DBNull.Value) road_Nodes.RNodes_PartCode = Convert.ToString(dr["RNodes_PartCode"]);
            if (dr["RNodes_PartName"] != DBNull.Value) road_Nodes.RNodes_PartName = Convert.ToString(dr["RNodes_PartName"]);
            if (dr["RNodes_Code"] != DBNull.Value) road_Nodes.RNodes_Code = Convert.ToString(dr["RNodes_Code"]);
            if (dr["RNodes_Name"] != DBNull.Value) road_Nodes.RNodes_Name = Convert.ToString(dr["RNodes_Name"]);
            if (dr["RNodes_Order"] != DBNull.Value) road_Nodes.RNodes_Order = Convert.ToInt32(dr["RNodes_Order"]);
            if (dr["RNodes_TimeCost"] != DBNull.Value) road_Nodes.RNodes_TimeCost = Convert.ToDecimal(dr["RNodes_TimeCost"]);
            if (dr["RNodes_Cost"] != DBNull.Value) road_Nodes.RNodes_Cost = Convert.ToDecimal(dr["RNodes_Cost"]);
            if (dr["RNodes_Value"] != DBNull.Value) road_Nodes.RNodes_Value = Convert.ToDecimal(dr["RNodes_Value"]);
            if (dr["RNodes_PriceStat"] != DBNull.Value) road_Nodes.RNodes_PriceStat = Convert.ToInt32(dr["RNodes_PriceStat"]);
            if (dr["RNodes_Stat"] != DBNull.Value) road_Nodes.RNodes_Stat = Convert.ToInt32(dr["RNodes_Stat"]);
            if (dr["RNodes_Dept_Code"] != DBNull.Value) road_Nodes.RNodes_Dept_Code = Convert.ToString(dr["RNodes_Dept_Code"]);
            if (dr["RNodes_Dept_Name"] != DBNull.Value) road_Nodes.RNodes_Dept_Name = Convert.ToString(dr["RNodes_Dept_Name"]);
            if (dr["RNodes_EquCode"] != DBNull.Value) road_Nodes.RNodes_EquCode = Convert.ToString(dr["RNodes_EquCode"]);
            if (dr["RNodes_EquName"] != DBNull.Value) road_Nodes.RNodes_EquName = Convert.ToString(dr["RNodes_EquName"]);
            if (dr["RNodes_EquTime"] != DBNull.Value) road_Nodes.RNodes_EquTime = Convert.ToDecimal(dr["RNodes_EquTime"]);
            if (dr["RNodes_Class_Code"] != DBNull.Value) road_Nodes.RNodes_Class_Code = Convert.ToString(dr["RNodes_Class_Code"]);
            if (dr["RNodes_Class_Name"] != DBNull.Value) road_Nodes.RNodes_Class_Name = Convert.ToString(dr["RNodes_Class_Name"]);
            if (dr["RNodes_Func"] != DBNull.Value) road_Nodes.RNodes_Func = Convert.ToInt32(dr["RNodes_Func"]);
            if (dr["RNodes_CurPriceNode"] != DBNull.Value) road_Nodes.RNodes_CurPriceNode = Convert.ToInt32(dr["RNodes_CurPriceNode"]);
            if (dr["Stat"] != DBNull.Value) road_Nodes.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateTime"] != DBNull.Value) road_Nodes.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["RNodes_Udef1"] != DBNull.Value) road_Nodes.RNodes_Udef1 = Convert.ToDecimal(dr["RNodes_Udef1"]);
            if (dr["RNodes_Udef2"] != DBNull.Value) road_Nodes.RNodes_Udef2 = Convert.ToDecimal(dr["RNodes_Udef2"]);
            if (dr["RNodes_Udef3"] != DBNull.Value) road_Nodes.RNodes_Udef3 = Convert.ToDecimal(dr["RNodes_Udef3"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return road_Nodes;
      }
      /// <summary>
      /// 获取指定的零件工艺路线模板 Road_Nodes对象集合
      /// </summary>
      public List<Road_Nodes> GetListByWhere(string strCondition)
      {
         List<Road_Nodes> ret = new List<Road_Nodes>();
         string sql = "SELECT  RNodes_ID,RNodes_PartCode,RNodes_PartName,RNodes_Code,RNodes_Name,RNodes_Order,RNodes_TimeCost,RNodes_Cost,RNodes_Value,RNodes_PriceStat,RNodes_Stat,RNodes_Dept_Code,RNodes_Dept_Name,RNodes_EquCode,RNodes_EquName,RNodes_EquTime,RNodes_Class_Code,RNodes_Class_Name,RNodes_Func,RNodes_CurPriceNode,Stat,UpdateTime,RNodes_Udef1,RNodes_Udef2,RNodes_Udef3 FROM Road_Nodes WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Road_Nodes road_Nodes = new Road_Nodes();
            if (dr["RNodes_ID"] != DBNull.Value) road_Nodes.RNodes_ID = Convert.ToInt64(dr["RNodes_ID"]);
            if (dr["RNodes_PartCode"] != DBNull.Value) road_Nodes.RNodes_PartCode = Convert.ToString(dr["RNodes_PartCode"]);
            if (dr["RNodes_PartName"] != DBNull.Value) road_Nodes.RNodes_PartName = Convert.ToString(dr["RNodes_PartName"]);
            if (dr["RNodes_Code"] != DBNull.Value) road_Nodes.RNodes_Code = Convert.ToString(dr["RNodes_Code"]);
            if (dr["RNodes_Name"] != DBNull.Value) road_Nodes.RNodes_Name = Convert.ToString(dr["RNodes_Name"]);
            if (dr["RNodes_Order"] != DBNull.Value) road_Nodes.RNodes_Order = Convert.ToInt32(dr["RNodes_Order"]);
            if (dr["RNodes_TimeCost"] != DBNull.Value) road_Nodes.RNodes_TimeCost = Convert.ToDecimal(dr["RNodes_TimeCost"]);
            if (dr["RNodes_Cost"] != DBNull.Value) road_Nodes.RNodes_Cost = Convert.ToDecimal(dr["RNodes_Cost"]);
            if (dr["RNodes_Value"] != DBNull.Value) road_Nodes.RNodes_Value = Convert.ToDecimal(dr["RNodes_Value"]);
            if (dr["RNodes_PriceStat"] != DBNull.Value) road_Nodes.RNodes_PriceStat = Convert.ToInt32(dr["RNodes_PriceStat"]);
            if (dr["RNodes_Stat"] != DBNull.Value) road_Nodes.RNodes_Stat = Convert.ToInt32(dr["RNodes_Stat"]);
            if (dr["RNodes_Dept_Code"] != DBNull.Value) road_Nodes.RNodes_Dept_Code = Convert.ToString(dr["RNodes_Dept_Code"]);
            if (dr["RNodes_Dept_Name"] != DBNull.Value) road_Nodes.RNodes_Dept_Name = Convert.ToString(dr["RNodes_Dept_Name"]);
            if (dr["RNodes_EquCode"] != DBNull.Value) road_Nodes.RNodes_EquCode = Convert.ToString(dr["RNodes_EquCode"]);
            if (dr["RNodes_EquName"] != DBNull.Value) road_Nodes.RNodes_EquName = Convert.ToString(dr["RNodes_EquName"]);
            if (dr["RNodes_EquTime"] != DBNull.Value) road_Nodes.RNodes_EquTime = Convert.ToDecimal(dr["RNodes_EquTime"]);
            if (dr["RNodes_Class_Code"] != DBNull.Value) road_Nodes.RNodes_Class_Code = Convert.ToString(dr["RNodes_Class_Code"]);
            if (dr["RNodes_Class_Name"] != DBNull.Value) road_Nodes.RNodes_Class_Name = Convert.ToString(dr["RNodes_Class_Name"]);
            if (dr["RNodes_Func"] != DBNull.Value) road_Nodes.RNodes_Func = Convert.ToInt32(dr["RNodes_Func"]);
            if (dr["RNodes_CurPriceNode"] != DBNull.Value) road_Nodes.RNodes_CurPriceNode = Convert.ToInt32(dr["RNodes_CurPriceNode"]);
            if (dr["Stat"] != DBNull.Value) road_Nodes.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateTime"] != DBNull.Value) road_Nodes.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["RNodes_Udef1"] != DBNull.Value) road_Nodes.RNodes_Udef1 = Convert.ToDecimal(dr["RNodes_Udef1"]);
            if (dr["RNodes_Udef2"] != DBNull.Value) road_Nodes.RNodes_Udef2 = Convert.ToDecimal(dr["RNodes_Udef2"]);
            if (dr["RNodes_Udef3"] != DBNull.Value) road_Nodes.RNodes_Udef3 = Convert.ToDecimal(dr["RNodes_Udef3"]);
            ret.Add(road_Nodes);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的零件工艺路线模板 Road_Nodes对象(即:一条记录
      /// </summary>
      public List<Road_Nodes> GetAll()
      {
         List<Road_Nodes> ret = new List<Road_Nodes>();
         string sql = "SELECT  RNodes_ID,RNodes_PartCode,RNodes_PartName,RNodes_Code,RNodes_Name,RNodes_Order,RNodes_TimeCost,RNodes_Cost,RNodes_Value,RNodes_PriceStat,RNodes_Stat,RNodes_Dept_Code,RNodes_Dept_Name,RNodes_EquCode,RNodes_EquName,RNodes_EquTime,RNodes_Class_Code,RNodes_Class_Name,RNodes_Func,RNodes_CurPriceNode,Stat,UpdateTime,RNodes_Udef1,RNodes_Udef2,RNodes_Udef3 FROM Road_Nodes where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Road_Nodes road_Nodes = new Road_Nodes();
            if (dr["RNodes_ID"] != DBNull.Value) road_Nodes.RNodes_ID = Convert.ToInt64(dr["RNodes_ID"]);
            if (dr["RNodes_PartCode"] != DBNull.Value) road_Nodes.RNodes_PartCode = Convert.ToString(dr["RNodes_PartCode"]);
            if (dr["RNodes_PartName"] != DBNull.Value) road_Nodes.RNodes_PartName = Convert.ToString(dr["RNodes_PartName"]);
            if (dr["RNodes_Code"] != DBNull.Value) road_Nodes.RNodes_Code = Convert.ToString(dr["RNodes_Code"]);
            if (dr["RNodes_Name"] != DBNull.Value) road_Nodes.RNodes_Name = Convert.ToString(dr["RNodes_Name"]);
            if (dr["RNodes_Order"] != DBNull.Value) road_Nodes.RNodes_Order = Convert.ToInt32(dr["RNodes_Order"]);
            if (dr["RNodes_TimeCost"] != DBNull.Value) road_Nodes.RNodes_TimeCost = Convert.ToDecimal(dr["RNodes_TimeCost"]);
            if (dr["RNodes_Cost"] != DBNull.Value) road_Nodes.RNodes_Cost = Convert.ToDecimal(dr["RNodes_Cost"]);
            if (dr["RNodes_Value"] != DBNull.Value) road_Nodes.RNodes_Value = Convert.ToDecimal(dr["RNodes_Value"]);
            if (dr["RNodes_PriceStat"] != DBNull.Value) road_Nodes.RNodes_PriceStat = Convert.ToInt32(dr["RNodes_PriceStat"]);
            if (dr["RNodes_Stat"] != DBNull.Value) road_Nodes.RNodes_Stat = Convert.ToInt32(dr["RNodes_Stat"]);
            if (dr["RNodes_Dept_Code"] != DBNull.Value) road_Nodes.RNodes_Dept_Code = Convert.ToString(dr["RNodes_Dept_Code"]);
            if (dr["RNodes_Dept_Name"] != DBNull.Value) road_Nodes.RNodes_Dept_Name = Convert.ToString(dr["RNodes_Dept_Name"]);
            if (dr["RNodes_EquCode"] != DBNull.Value) road_Nodes.RNodes_EquCode = Convert.ToString(dr["RNodes_EquCode"]);
            if (dr["RNodes_EquName"] != DBNull.Value) road_Nodes.RNodes_EquName = Convert.ToString(dr["RNodes_EquName"]);
            if (dr["RNodes_EquTime"] != DBNull.Value) road_Nodes.RNodes_EquTime = Convert.ToDecimal(dr["RNodes_EquTime"]);
            if (dr["RNodes_Class_Code"] != DBNull.Value) road_Nodes.RNodes_Class_Code = Convert.ToString(dr["RNodes_Class_Code"]);
            if (dr["RNodes_Class_Name"] != DBNull.Value) road_Nodes.RNodes_Class_Name = Convert.ToString(dr["RNodes_Class_Name"]);
            if (dr["RNodes_Func"] != DBNull.Value) road_Nodes.RNodes_Func = Convert.ToInt32(dr["RNodes_Func"]);
            if (dr["RNodes_CurPriceNode"] != DBNull.Value) road_Nodes.RNodes_CurPriceNode = Convert.ToInt32(dr["RNodes_CurPriceNode"]);
            if (dr["Stat"] != DBNull.Value) road_Nodes.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["UpdateTime"] != DBNull.Value) road_Nodes.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["RNodes_Udef1"] != DBNull.Value) road_Nodes.RNodes_Udef1 = Convert.ToDecimal(dr["RNodes_Udef1"]);
            if (dr["RNodes_Udef2"] != DBNull.Value) road_Nodes.RNodes_Udef2 = Convert.ToDecimal(dr["RNodes_Udef2"]);
            if (dr["RNodes_Udef3"] != DBNull.Value) road_Nodes.RNodes_Udef3 = Convert.ToDecimal(dr["RNodes_Udef3"]);
            ret.Add(road_Nodes);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
