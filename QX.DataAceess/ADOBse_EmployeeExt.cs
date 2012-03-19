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
   public partial class ADOBse_EmployeeExt
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_EmployeeExt对象(即:一条记录)
      /// </summary>
      public int Add(Bse_EmployeeExt bse_EmployeeExt)
      {
         string sql = "INSERT INTO Bse_EmployeeExt (EmpE_Module,EmpE_EmpCode,EmpE_Udef1,EmpE_Udef2,EmpE_Udef3,EmpE_Udef4,EmpE_Udef5,EmpE_Udef6,EmpE_Udef7,EmpE_Udef8,EmpE_Udef9,EmpE_Udef10,EmpE_Udef11,EmpE_Udef12,EmpE_Udef13,EmpE_Udef14,EmpE_Udef15,EmpE_Udef16,EmpE_Udef17,EmpE_Udef18,EmpE_Udef19,EmpE_Udef20,EmpE_Udef21,EmpE_Udef22,EmpE_Udef23,EmpE_Udef24,EmpE_Udef25,EmpE_Udef26,EmpE_Udef27,EmpE_Udef28,EmpE_Udef29,EmpE_Udef30,EmpE_BeginTime,EmpE_EndTime,Stat) VALUES (@EmpE_Module,@EmpE_EmpCode,@EmpE_Udef1,@EmpE_Udef2,@EmpE_Udef3,@EmpE_Udef4,@EmpE_Udef5,@EmpE_Udef6,@EmpE_Udef7,@EmpE_Udef8,@EmpE_Udef9,@EmpE_Udef10,@EmpE_Udef11,@EmpE_Udef12,@EmpE_Udef13,@EmpE_Udef14,@EmpE_Udef15,@EmpE_Udef16,@EmpE_Udef17,@EmpE_Udef18,@EmpE_Udef19,@EmpE_Udef20,@EmpE_Udef21,@EmpE_Udef22,@EmpE_Udef23,@EmpE_Udef24,@EmpE_Udef25,@EmpE_Udef26,@EmpE_Udef27,@EmpE_Udef28,@EmpE_Udef29,@EmpE_Udef30,@EmpE_BeginTime,@EmpE_EndTime,@Stat)";
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Module))
         {
            idb.AddParameter("@EmpE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Module", bse_EmployeeExt.EmpE_Module);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_EmpCode))
         {
            idb.AddParameter("@EmpE_EmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_EmpCode", bse_EmployeeExt.EmpE_EmpCode);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef1))
         {
            idb.AddParameter("@EmpE_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef1", bse_EmployeeExt.EmpE_Udef1);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef2))
         {
            idb.AddParameter("@EmpE_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef2", bse_EmployeeExt.EmpE_Udef2);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef3))
         {
            idb.AddParameter("@EmpE_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef3", bse_EmployeeExt.EmpE_Udef3);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef4))
         {
            idb.AddParameter("@EmpE_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef4", bse_EmployeeExt.EmpE_Udef4);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef5))
         {
            idb.AddParameter("@EmpE_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef5", bse_EmployeeExt.EmpE_Udef5);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef6))
         {
            idb.AddParameter("@EmpE_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef6", bse_EmployeeExt.EmpE_Udef6);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef7))
         {
            idb.AddParameter("@EmpE_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef7", bse_EmployeeExt.EmpE_Udef7);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef8))
         {
            idb.AddParameter("@EmpE_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef8", bse_EmployeeExt.EmpE_Udef8);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef9))
         {
            idb.AddParameter("@EmpE_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef9", bse_EmployeeExt.EmpE_Udef9);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef10))
         {
            idb.AddParameter("@EmpE_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef10", bse_EmployeeExt.EmpE_Udef10);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef11))
         {
            idb.AddParameter("@EmpE_Udef11", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef11", bse_EmployeeExt.EmpE_Udef11);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef12))
         {
            idb.AddParameter("@EmpE_Udef12", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef12", bse_EmployeeExt.EmpE_Udef12);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef13))
         {
            idb.AddParameter("@EmpE_Udef13", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef13", bse_EmployeeExt.EmpE_Udef13);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef14))
         {
            idb.AddParameter("@EmpE_Udef14", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef14", bse_EmployeeExt.EmpE_Udef14);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef15))
         {
            idb.AddParameter("@EmpE_Udef15", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef15", bse_EmployeeExt.EmpE_Udef15);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef16))
         {
            idb.AddParameter("@EmpE_Udef16", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef16", bse_EmployeeExt.EmpE_Udef16);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef17))
         {
            idb.AddParameter("@EmpE_Udef17", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef17", bse_EmployeeExt.EmpE_Udef17);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef18))
         {
            idb.AddParameter("@EmpE_Udef18", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef18", bse_EmployeeExt.EmpE_Udef18);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef19))
         {
            idb.AddParameter("@EmpE_Udef19", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef19", bse_EmployeeExt.EmpE_Udef19);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef20))
         {
            idb.AddParameter("@EmpE_Udef20", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef20", bse_EmployeeExt.EmpE_Udef20);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef21))
         {
            idb.AddParameter("@EmpE_Udef21", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef21", bse_EmployeeExt.EmpE_Udef21);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef22))
         {
            idb.AddParameter("@EmpE_Udef22", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef22", bse_EmployeeExt.EmpE_Udef22);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef23))
         {
            idb.AddParameter("@EmpE_Udef23", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef23", bse_EmployeeExt.EmpE_Udef23);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef24))
         {
            idb.AddParameter("@EmpE_Udef24", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef24", bse_EmployeeExt.EmpE_Udef24);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef25))
         {
            idb.AddParameter("@EmpE_Udef25", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef25", bse_EmployeeExt.EmpE_Udef25);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef26))
         {
            idb.AddParameter("@EmpE_Udef26", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef26", bse_EmployeeExt.EmpE_Udef26);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef27))
         {
            idb.AddParameter("@EmpE_Udef27", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef27", bse_EmployeeExt.EmpE_Udef27);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef28))
         {
            idb.AddParameter("@EmpE_Udef28", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef28", bse_EmployeeExt.EmpE_Udef28);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef29))
         {
            idb.AddParameter("@EmpE_Udef29", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef29", bse_EmployeeExt.EmpE_Udef29);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef30))
         {
            idb.AddParameter("@EmpE_Udef30", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef30", bse_EmployeeExt.EmpE_Udef30);
         }
         if (bse_EmployeeExt.EmpE_BeginTime == DateTime.MinValue)
         {
            idb.AddParameter("@EmpE_BeginTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_BeginTime", bse_EmployeeExt.EmpE_BeginTime);
         }
         if (bse_EmployeeExt.EmpE_EndTime == DateTime.MinValue)
         {
            idb.AddParameter("@EmpE_EndTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_EndTime", bse_EmployeeExt.EmpE_EndTime);
         }
         if (bse_EmployeeExt.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_EmployeeExt.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_EmployeeExt对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_EmployeeExt bse_EmployeeExt)
      {
         string sql = "INSERT INTO Bse_EmployeeExt (EmpE_Module,EmpE_EmpCode,EmpE_Udef1,EmpE_Udef2,EmpE_Udef3,EmpE_Udef4,EmpE_Udef5,EmpE_Udef6,EmpE_Udef7,EmpE_Udef8,EmpE_Udef9,EmpE_Udef10,EmpE_Udef11,EmpE_Udef12,EmpE_Udef13,EmpE_Udef14,EmpE_Udef15,EmpE_Udef16,EmpE_Udef17,EmpE_Udef18,EmpE_Udef19,EmpE_Udef20,EmpE_Udef21,EmpE_Udef22,EmpE_Udef23,EmpE_Udef24,EmpE_Udef25,EmpE_Udef26,EmpE_Udef27,EmpE_Udef28,EmpE_Udef29,EmpE_Udef30,EmpE_BeginTime,EmpE_EndTime,Stat) VALUES (@EmpE_Module,@EmpE_EmpCode,@EmpE_Udef1,@EmpE_Udef2,@EmpE_Udef3,@EmpE_Udef4,@EmpE_Udef5,@EmpE_Udef6,@EmpE_Udef7,@EmpE_Udef8,@EmpE_Udef9,@EmpE_Udef10,@EmpE_Udef11,@EmpE_Udef12,@EmpE_Udef13,@EmpE_Udef14,@EmpE_Udef15,@EmpE_Udef16,@EmpE_Udef17,@EmpE_Udef18,@EmpE_Udef19,@EmpE_Udef20,@EmpE_Udef21,@EmpE_Udef22,@EmpE_Udef23,@EmpE_Udef24,@EmpE_Udef25,@EmpE_Udef26,@EmpE_Udef27,@EmpE_Udef28,@EmpE_Udef29,@EmpE_Udef30,@EmpE_BeginTime,@EmpE_EndTime,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Module))
         {
            idb.AddParameter("@EmpE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Module", bse_EmployeeExt.EmpE_Module);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_EmpCode))
         {
            idb.AddParameter("@EmpE_EmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_EmpCode", bse_EmployeeExt.EmpE_EmpCode);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef1))
         {
            idb.AddParameter("@EmpE_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef1", bse_EmployeeExt.EmpE_Udef1);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef2))
         {
            idb.AddParameter("@EmpE_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef2", bse_EmployeeExt.EmpE_Udef2);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef3))
         {
            idb.AddParameter("@EmpE_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef3", bse_EmployeeExt.EmpE_Udef3);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef4))
         {
            idb.AddParameter("@EmpE_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef4", bse_EmployeeExt.EmpE_Udef4);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef5))
         {
            idb.AddParameter("@EmpE_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef5", bse_EmployeeExt.EmpE_Udef5);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef6))
         {
            idb.AddParameter("@EmpE_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef6", bse_EmployeeExt.EmpE_Udef6);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef7))
         {
            idb.AddParameter("@EmpE_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef7", bse_EmployeeExt.EmpE_Udef7);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef8))
         {
            idb.AddParameter("@EmpE_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef8", bse_EmployeeExt.EmpE_Udef8);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef9))
         {
            idb.AddParameter("@EmpE_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef9", bse_EmployeeExt.EmpE_Udef9);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef10))
         {
            idb.AddParameter("@EmpE_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef10", bse_EmployeeExt.EmpE_Udef10);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef11))
         {
            idb.AddParameter("@EmpE_Udef11", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef11", bse_EmployeeExt.EmpE_Udef11);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef12))
         {
            idb.AddParameter("@EmpE_Udef12", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef12", bse_EmployeeExt.EmpE_Udef12);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef13))
         {
            idb.AddParameter("@EmpE_Udef13", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef13", bse_EmployeeExt.EmpE_Udef13);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef14))
         {
            idb.AddParameter("@EmpE_Udef14", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef14", bse_EmployeeExt.EmpE_Udef14);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef15))
         {
            idb.AddParameter("@EmpE_Udef15", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef15", bse_EmployeeExt.EmpE_Udef15);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef16))
         {
            idb.AddParameter("@EmpE_Udef16", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef16", bse_EmployeeExt.EmpE_Udef16);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef17))
         {
            idb.AddParameter("@EmpE_Udef17", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef17", bse_EmployeeExt.EmpE_Udef17);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef18))
         {
            idb.AddParameter("@EmpE_Udef18", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef18", bse_EmployeeExt.EmpE_Udef18);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef19))
         {
            idb.AddParameter("@EmpE_Udef19", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef19", bse_EmployeeExt.EmpE_Udef19);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef20))
         {
            idb.AddParameter("@EmpE_Udef20", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef20", bse_EmployeeExt.EmpE_Udef20);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef21))
         {
            idb.AddParameter("@EmpE_Udef21", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef21", bse_EmployeeExt.EmpE_Udef21);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef22))
         {
            idb.AddParameter("@EmpE_Udef22", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef22", bse_EmployeeExt.EmpE_Udef22);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef23))
         {
            idb.AddParameter("@EmpE_Udef23", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef23", bse_EmployeeExt.EmpE_Udef23);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef24))
         {
            idb.AddParameter("@EmpE_Udef24", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef24", bse_EmployeeExt.EmpE_Udef24);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef25))
         {
            idb.AddParameter("@EmpE_Udef25", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef25", bse_EmployeeExt.EmpE_Udef25);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef26))
         {
            idb.AddParameter("@EmpE_Udef26", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef26", bse_EmployeeExt.EmpE_Udef26);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef27))
         {
            idb.AddParameter("@EmpE_Udef27", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef27", bse_EmployeeExt.EmpE_Udef27);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef28))
         {
            idb.AddParameter("@EmpE_Udef28", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef28", bse_EmployeeExt.EmpE_Udef28);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef29))
         {
            idb.AddParameter("@EmpE_Udef29", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef29", bse_EmployeeExt.EmpE_Udef29);
         }
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef30))
         {
            idb.AddParameter("@EmpE_Udef30", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef30", bse_EmployeeExt.EmpE_Udef30);
         }
         if (bse_EmployeeExt.EmpE_BeginTime == DateTime.MinValue)
         {
            idb.AddParameter("@EmpE_BeginTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_BeginTime", bse_EmployeeExt.EmpE_BeginTime);
         }
         if (bse_EmployeeExt.EmpE_EndTime == DateTime.MinValue)
         {
            idb.AddParameter("@EmpE_EndTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_EndTime", bse_EmployeeExt.EmpE_EndTime);
         }
         if (bse_EmployeeExt.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_EmployeeExt.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_EmployeeExt对象(即:一条记录
      /// </summary>
      public int Update(Bse_EmployeeExt bse_EmployeeExt)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_EmployeeExt       SET ");
            if(bse_EmployeeExt.EmpE_Module_IsChanged){sbParameter.Append("EmpE_Module=@EmpE_Module, ");}
      if(bse_EmployeeExt.EmpE_EmpCode_IsChanged){sbParameter.Append("EmpE_EmpCode=@EmpE_EmpCode, ");}
      if(bse_EmployeeExt.EmpE_Udef1_IsChanged){sbParameter.Append("EmpE_Udef1=@EmpE_Udef1, ");}
      if(bse_EmployeeExt.EmpE_Udef2_IsChanged){sbParameter.Append("EmpE_Udef2=@EmpE_Udef2, ");}
      if(bse_EmployeeExt.EmpE_Udef3_IsChanged){sbParameter.Append("EmpE_Udef3=@EmpE_Udef3, ");}
      if(bse_EmployeeExt.EmpE_Udef4_IsChanged){sbParameter.Append("EmpE_Udef4=@EmpE_Udef4, ");}
      if(bse_EmployeeExt.EmpE_Udef5_IsChanged){sbParameter.Append("EmpE_Udef5=@EmpE_Udef5, ");}
      if(bse_EmployeeExt.EmpE_Udef6_IsChanged){sbParameter.Append("EmpE_Udef6=@EmpE_Udef6, ");}
      if(bse_EmployeeExt.EmpE_Udef7_IsChanged){sbParameter.Append("EmpE_Udef7=@EmpE_Udef7, ");}
      if(bse_EmployeeExt.EmpE_Udef8_IsChanged){sbParameter.Append("EmpE_Udef8=@EmpE_Udef8, ");}
      if(bse_EmployeeExt.EmpE_Udef9_IsChanged){sbParameter.Append("EmpE_Udef9=@EmpE_Udef9, ");}
      if(bse_EmployeeExt.EmpE_Udef10_IsChanged){sbParameter.Append("EmpE_Udef10=@EmpE_Udef10, ");}
      if(bse_EmployeeExt.EmpE_Udef11_IsChanged){sbParameter.Append("EmpE_Udef11=@EmpE_Udef11, ");}
      if(bse_EmployeeExt.EmpE_Udef12_IsChanged){sbParameter.Append("EmpE_Udef12=@EmpE_Udef12, ");}
      if(bse_EmployeeExt.EmpE_Udef13_IsChanged){sbParameter.Append("EmpE_Udef13=@EmpE_Udef13, ");}
      if(bse_EmployeeExt.EmpE_Udef14_IsChanged){sbParameter.Append("EmpE_Udef14=@EmpE_Udef14, ");}
      if(bse_EmployeeExt.EmpE_Udef15_IsChanged){sbParameter.Append("EmpE_Udef15=@EmpE_Udef15, ");}
      if(bse_EmployeeExt.EmpE_Udef16_IsChanged){sbParameter.Append("EmpE_Udef16=@EmpE_Udef16, ");}
      if(bse_EmployeeExt.EmpE_Udef17_IsChanged){sbParameter.Append("EmpE_Udef17=@EmpE_Udef17, ");}
      if(bse_EmployeeExt.EmpE_Udef18_IsChanged){sbParameter.Append("EmpE_Udef18=@EmpE_Udef18, ");}
      if(bse_EmployeeExt.EmpE_Udef19_IsChanged){sbParameter.Append("EmpE_Udef19=@EmpE_Udef19, ");}
      if(bse_EmployeeExt.EmpE_Udef20_IsChanged){sbParameter.Append("EmpE_Udef20=@EmpE_Udef20, ");}
      if(bse_EmployeeExt.EmpE_Udef21_IsChanged){sbParameter.Append("EmpE_Udef21=@EmpE_Udef21, ");}
      if(bse_EmployeeExt.EmpE_Udef22_IsChanged){sbParameter.Append("EmpE_Udef22=@EmpE_Udef22, ");}
      if(bse_EmployeeExt.EmpE_Udef23_IsChanged){sbParameter.Append("EmpE_Udef23=@EmpE_Udef23, ");}
      if(bse_EmployeeExt.EmpE_Udef24_IsChanged){sbParameter.Append("EmpE_Udef24=@EmpE_Udef24, ");}
      if(bse_EmployeeExt.EmpE_Udef25_IsChanged){sbParameter.Append("EmpE_Udef25=@EmpE_Udef25, ");}
      if(bse_EmployeeExt.EmpE_Udef26_IsChanged){sbParameter.Append("EmpE_Udef26=@EmpE_Udef26, ");}
      if(bse_EmployeeExt.EmpE_Udef27_IsChanged){sbParameter.Append("EmpE_Udef27=@EmpE_Udef27, ");}
      if(bse_EmployeeExt.EmpE_Udef28_IsChanged){sbParameter.Append("EmpE_Udef28=@EmpE_Udef28, ");}
      if(bse_EmployeeExt.EmpE_Udef29_IsChanged){sbParameter.Append("EmpE_Udef29=@EmpE_Udef29, ");}
      if(bse_EmployeeExt.EmpE_Udef30_IsChanged){sbParameter.Append("EmpE_Udef30=@EmpE_Udef30, ");}
      if(bse_EmployeeExt.EmpE_BeginTime_IsChanged){sbParameter.Append("EmpE_BeginTime=@EmpE_BeginTime, ");}
      if(bse_EmployeeExt.EmpE_EndTime_IsChanged){sbParameter.Append("EmpE_EndTime=@EmpE_EndTime, ");}
      if(bse_EmployeeExt.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EmpE_ID=@EmpE_ID; " );
      string sql=sb.ToString();
         if(bse_EmployeeExt.EmpE_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Module))
         {
            idb.AddParameter("@EmpE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Module", bse_EmployeeExt.EmpE_Module);
         }
          }
         if(bse_EmployeeExt.EmpE_EmpCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_EmpCode))
         {
            idb.AddParameter("@EmpE_EmpCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_EmpCode", bse_EmployeeExt.EmpE_EmpCode);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef1))
         {
            idb.AddParameter("@EmpE_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef1", bse_EmployeeExt.EmpE_Udef1);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef2))
         {
            idb.AddParameter("@EmpE_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef2", bse_EmployeeExt.EmpE_Udef2);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef3))
         {
            idb.AddParameter("@EmpE_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef3", bse_EmployeeExt.EmpE_Udef3);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef4))
         {
            idb.AddParameter("@EmpE_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef4", bse_EmployeeExt.EmpE_Udef4);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef5))
         {
            idb.AddParameter("@EmpE_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef5", bse_EmployeeExt.EmpE_Udef5);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef6_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef6))
         {
            idb.AddParameter("@EmpE_Udef6", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef6", bse_EmployeeExt.EmpE_Udef6);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef7_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef7))
         {
            idb.AddParameter("@EmpE_Udef7", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef7", bse_EmployeeExt.EmpE_Udef7);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef8_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef8))
         {
            idb.AddParameter("@EmpE_Udef8", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef8", bse_EmployeeExt.EmpE_Udef8);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef9_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef9))
         {
            idb.AddParameter("@EmpE_Udef9", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef9", bse_EmployeeExt.EmpE_Udef9);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef10_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef10))
         {
            idb.AddParameter("@EmpE_Udef10", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef10", bse_EmployeeExt.EmpE_Udef10);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef11_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef11))
         {
            idb.AddParameter("@EmpE_Udef11", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef11", bse_EmployeeExt.EmpE_Udef11);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef12_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef12))
         {
            idb.AddParameter("@EmpE_Udef12", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef12", bse_EmployeeExt.EmpE_Udef12);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef13_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef13))
         {
            idb.AddParameter("@EmpE_Udef13", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef13", bse_EmployeeExt.EmpE_Udef13);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef14_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef14))
         {
            idb.AddParameter("@EmpE_Udef14", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef14", bse_EmployeeExt.EmpE_Udef14);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef15_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef15))
         {
            idb.AddParameter("@EmpE_Udef15", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef15", bse_EmployeeExt.EmpE_Udef15);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef16_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef16))
         {
            idb.AddParameter("@EmpE_Udef16", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef16", bse_EmployeeExt.EmpE_Udef16);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef17_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef17))
         {
            idb.AddParameter("@EmpE_Udef17", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef17", bse_EmployeeExt.EmpE_Udef17);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef18_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef18))
         {
            idb.AddParameter("@EmpE_Udef18", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef18", bse_EmployeeExt.EmpE_Udef18);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef19_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef19))
         {
            idb.AddParameter("@EmpE_Udef19", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef19", bse_EmployeeExt.EmpE_Udef19);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef20_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef20))
         {
            idb.AddParameter("@EmpE_Udef20", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef20", bse_EmployeeExt.EmpE_Udef20);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef21_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef21))
         {
            idb.AddParameter("@EmpE_Udef21", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef21", bse_EmployeeExt.EmpE_Udef21);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef22_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef22))
         {
            idb.AddParameter("@EmpE_Udef22", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef22", bse_EmployeeExt.EmpE_Udef22);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef23_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef23))
         {
            idb.AddParameter("@EmpE_Udef23", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef23", bse_EmployeeExt.EmpE_Udef23);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef24_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef24))
         {
            idb.AddParameter("@EmpE_Udef24", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef24", bse_EmployeeExt.EmpE_Udef24);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef25_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef25))
         {
            idb.AddParameter("@EmpE_Udef25", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef25", bse_EmployeeExt.EmpE_Udef25);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef26_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef26))
         {
            idb.AddParameter("@EmpE_Udef26", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef26", bse_EmployeeExt.EmpE_Udef26);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef27_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef27))
         {
            idb.AddParameter("@EmpE_Udef27", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef27", bse_EmployeeExt.EmpE_Udef27);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef28_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef28))
         {
            idb.AddParameter("@EmpE_Udef28", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef28", bse_EmployeeExt.EmpE_Udef28);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef29_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef29))
         {
            idb.AddParameter("@EmpE_Udef29", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef29", bse_EmployeeExt.EmpE_Udef29);
         }
          }
         if(bse_EmployeeExt.EmpE_Udef30_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_EmployeeExt.EmpE_Udef30))
         {
            idb.AddParameter("@EmpE_Udef30", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_Udef30", bse_EmployeeExt.EmpE_Udef30);
         }
          }
         if(bse_EmployeeExt.EmpE_BeginTime_IsChanged)
         {
         if (bse_EmployeeExt.EmpE_BeginTime == DateTime.MinValue)
         {
            idb.AddParameter("@EmpE_BeginTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_BeginTime", bse_EmployeeExt.EmpE_BeginTime);
         }
          }
         if(bse_EmployeeExt.EmpE_EndTime_IsChanged)
         {
         if (bse_EmployeeExt.EmpE_EndTime == DateTime.MinValue)
         {
            idb.AddParameter("@EmpE_EndTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EmpE_EndTime", bse_EmployeeExt.EmpE_EndTime);
         }
          }
         if(bse_EmployeeExt.Stat_IsChanged)
         {
         if (bse_EmployeeExt.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_EmployeeExt.Stat);
         }
          }

         idb.AddParameter("@EmpE_ID", bse_EmployeeExt.EmpE_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_EmployeeExt对象(即:一条记录
      /// </summary>
      public int Delete(decimal empE_ID)
      {
         string sql = "DELETE Bse_EmployeeExt WHERE 1=1  AND EmpE_ID=@EmpE_ID ";
         idb.AddParameter("@EmpE_ID", empE_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_EmployeeExt对象(即:一条记录
      /// </summary>
      public Bse_EmployeeExt GetByKey(decimal empE_ID)
      {
         Bse_EmployeeExt bse_EmployeeExt = new Bse_EmployeeExt();
         string sql = "SELECT  EmpE_ID,EmpE_Module,EmpE_EmpCode,EmpE_Udef1,EmpE_Udef2,EmpE_Udef3,EmpE_Udef4,EmpE_Udef5,EmpE_Udef6,EmpE_Udef7,EmpE_Udef8,EmpE_Udef9,EmpE_Udef10,EmpE_Udef11,EmpE_Udef12,EmpE_Udef13,EmpE_Udef14,EmpE_Udef15,EmpE_Udef16,EmpE_Udef17,EmpE_Udef18,EmpE_Udef19,EmpE_Udef20,EmpE_Udef21,EmpE_Udef22,EmpE_Udef23,EmpE_Udef24,EmpE_Udef25,EmpE_Udef26,EmpE_Udef27,EmpE_Udef28,EmpE_Udef29,EmpE_Udef30,EmpE_BeginTime,EmpE_EndTime,Stat FROM Bse_EmployeeExt WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EmpE_ID=@EmpE_ID ";
         idb.AddParameter("@EmpE_ID", empE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EmpE_ID"] != DBNull.Value) bse_EmployeeExt.EmpE_ID = Convert.ToDecimal(dr["EmpE_ID"]);
            if (dr["EmpE_Module"] != DBNull.Value) bse_EmployeeExt.EmpE_Module = Convert.ToString(dr["EmpE_Module"]);
            if (dr["EmpE_EmpCode"] != DBNull.Value) bse_EmployeeExt.EmpE_EmpCode = Convert.ToString(dr["EmpE_EmpCode"]);
            if (dr["EmpE_Udef1"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef1 = Convert.ToString(dr["EmpE_Udef1"]);
            if (dr["EmpE_Udef2"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef2 = Convert.ToString(dr["EmpE_Udef2"]);
            if (dr["EmpE_Udef3"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef3 = Convert.ToString(dr["EmpE_Udef3"]);
            if (dr["EmpE_Udef4"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef4 = Convert.ToString(dr["EmpE_Udef4"]);
            if (dr["EmpE_Udef5"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef5 = Convert.ToString(dr["EmpE_Udef5"]);
            if (dr["EmpE_Udef6"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef6 = Convert.ToString(dr["EmpE_Udef6"]);
            if (dr["EmpE_Udef7"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef7 = Convert.ToString(dr["EmpE_Udef7"]);
            if (dr["EmpE_Udef8"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef8 = Convert.ToString(dr["EmpE_Udef8"]);
            if (dr["EmpE_Udef9"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef9 = Convert.ToString(dr["EmpE_Udef9"]);
            if (dr["EmpE_Udef10"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef10 = Convert.ToString(dr["EmpE_Udef10"]);
            if (dr["EmpE_Udef11"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef11 = Convert.ToString(dr["EmpE_Udef11"]);
            if (dr["EmpE_Udef12"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef12 = Convert.ToString(dr["EmpE_Udef12"]);
            if (dr["EmpE_Udef13"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef13 = Convert.ToString(dr["EmpE_Udef13"]);
            if (dr["EmpE_Udef14"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef14 = Convert.ToString(dr["EmpE_Udef14"]);
            if (dr["EmpE_Udef15"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef15 = Convert.ToString(dr["EmpE_Udef15"]);
            if (dr["EmpE_Udef16"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef16 = Convert.ToString(dr["EmpE_Udef16"]);
            if (dr["EmpE_Udef17"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef17 = Convert.ToString(dr["EmpE_Udef17"]);
            if (dr["EmpE_Udef18"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef18 = Convert.ToString(dr["EmpE_Udef18"]);
            if (dr["EmpE_Udef19"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef19 = Convert.ToString(dr["EmpE_Udef19"]);
            if (dr["EmpE_Udef20"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef20 = Convert.ToString(dr["EmpE_Udef20"]);
            if (dr["EmpE_Udef21"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef21 = Convert.ToString(dr["EmpE_Udef21"]);
            if (dr["EmpE_Udef22"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef22 = Convert.ToString(dr["EmpE_Udef22"]);
            if (dr["EmpE_Udef23"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef23 = Convert.ToString(dr["EmpE_Udef23"]);
            if (dr["EmpE_Udef24"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef24 = Convert.ToString(dr["EmpE_Udef24"]);
            if (dr["EmpE_Udef25"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef25 = Convert.ToString(dr["EmpE_Udef25"]);
            if (dr["EmpE_Udef26"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef26 = Convert.ToString(dr["EmpE_Udef26"]);
            if (dr["EmpE_Udef27"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef27 = Convert.ToString(dr["EmpE_Udef27"]);
            if (dr["EmpE_Udef28"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef28 = Convert.ToString(dr["EmpE_Udef28"]);
            if (dr["EmpE_Udef29"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef29 = Convert.ToString(dr["EmpE_Udef29"]);
            if (dr["EmpE_Udef30"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef30 = Convert.ToString(dr["EmpE_Udef30"]);
            if (dr["EmpE_BeginTime"] != DBNull.Value) bse_EmployeeExt.EmpE_BeginTime = Convert.ToDateTime(dr["EmpE_BeginTime"]);
            if (dr["EmpE_EndTime"] != DBNull.Value) bse_EmployeeExt.EmpE_EndTime = Convert.ToDateTime(dr["EmpE_EndTime"]);
            if (dr["Stat"] != DBNull.Value) bse_EmployeeExt.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_EmployeeExt;
      }
      /// <summary>
      /// 获取指定的Bse_EmployeeExt对象集合
      /// </summary>
      public List<Bse_EmployeeExt> GetListByWhere(string strCondition)
      {
         List<Bse_EmployeeExt> ret = new List<Bse_EmployeeExt>();
         string sql = "SELECT  EmpE_ID,EmpE_Module,EmpE_EmpCode,EmpE_Udef1,EmpE_Udef2,EmpE_Udef3,EmpE_Udef4,EmpE_Udef5,EmpE_Udef6,EmpE_Udef7,EmpE_Udef8,EmpE_Udef9,EmpE_Udef10,EmpE_Udef11,EmpE_Udef12,EmpE_Udef13,EmpE_Udef14,EmpE_Udef15,EmpE_Udef16,EmpE_Udef17,EmpE_Udef18,EmpE_Udef19,EmpE_Udef20,EmpE_Udef21,EmpE_Udef22,EmpE_Udef23,EmpE_Udef24,EmpE_Udef25,EmpE_Udef26,EmpE_Udef27,EmpE_Udef28,EmpE_Udef29,EmpE_Udef30,EmpE_BeginTime,EmpE_EndTime,Stat FROM Bse_EmployeeExt WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_EmployeeExt bse_EmployeeExt = new Bse_EmployeeExt();
            if (dr["EmpE_ID"] != DBNull.Value) bse_EmployeeExt.EmpE_ID = Convert.ToDecimal(dr["EmpE_ID"]);
            if (dr["EmpE_Module"] != DBNull.Value) bse_EmployeeExt.EmpE_Module = Convert.ToString(dr["EmpE_Module"]);
            if (dr["EmpE_EmpCode"] != DBNull.Value) bse_EmployeeExt.EmpE_EmpCode = Convert.ToString(dr["EmpE_EmpCode"]);
            if (dr["EmpE_Udef1"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef1 = Convert.ToString(dr["EmpE_Udef1"]);
            if (dr["EmpE_Udef2"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef2 = Convert.ToString(dr["EmpE_Udef2"]);
            if (dr["EmpE_Udef3"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef3 = Convert.ToString(dr["EmpE_Udef3"]);
            if (dr["EmpE_Udef4"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef4 = Convert.ToString(dr["EmpE_Udef4"]);
            if (dr["EmpE_Udef5"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef5 = Convert.ToString(dr["EmpE_Udef5"]);
            if (dr["EmpE_Udef6"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef6 = Convert.ToString(dr["EmpE_Udef6"]);
            if (dr["EmpE_Udef7"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef7 = Convert.ToString(dr["EmpE_Udef7"]);
            if (dr["EmpE_Udef8"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef8 = Convert.ToString(dr["EmpE_Udef8"]);
            if (dr["EmpE_Udef9"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef9 = Convert.ToString(dr["EmpE_Udef9"]);
            if (dr["EmpE_Udef10"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef10 = Convert.ToString(dr["EmpE_Udef10"]);
            if (dr["EmpE_Udef11"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef11 = Convert.ToString(dr["EmpE_Udef11"]);
            if (dr["EmpE_Udef12"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef12 = Convert.ToString(dr["EmpE_Udef12"]);
            if (dr["EmpE_Udef13"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef13 = Convert.ToString(dr["EmpE_Udef13"]);
            if (dr["EmpE_Udef14"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef14 = Convert.ToString(dr["EmpE_Udef14"]);
            if (dr["EmpE_Udef15"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef15 = Convert.ToString(dr["EmpE_Udef15"]);
            if (dr["EmpE_Udef16"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef16 = Convert.ToString(dr["EmpE_Udef16"]);
            if (dr["EmpE_Udef17"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef17 = Convert.ToString(dr["EmpE_Udef17"]);
            if (dr["EmpE_Udef18"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef18 = Convert.ToString(dr["EmpE_Udef18"]);
            if (dr["EmpE_Udef19"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef19 = Convert.ToString(dr["EmpE_Udef19"]);
            if (dr["EmpE_Udef20"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef20 = Convert.ToString(dr["EmpE_Udef20"]);
            if (dr["EmpE_Udef21"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef21 = Convert.ToString(dr["EmpE_Udef21"]);
            if (dr["EmpE_Udef22"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef22 = Convert.ToString(dr["EmpE_Udef22"]);
            if (dr["EmpE_Udef23"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef23 = Convert.ToString(dr["EmpE_Udef23"]);
            if (dr["EmpE_Udef24"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef24 = Convert.ToString(dr["EmpE_Udef24"]);
            if (dr["EmpE_Udef25"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef25 = Convert.ToString(dr["EmpE_Udef25"]);
            if (dr["EmpE_Udef26"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef26 = Convert.ToString(dr["EmpE_Udef26"]);
            if (dr["EmpE_Udef27"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef27 = Convert.ToString(dr["EmpE_Udef27"]);
            if (dr["EmpE_Udef28"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef28 = Convert.ToString(dr["EmpE_Udef28"]);
            if (dr["EmpE_Udef29"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef29 = Convert.ToString(dr["EmpE_Udef29"]);
            if (dr["EmpE_Udef30"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef30 = Convert.ToString(dr["EmpE_Udef30"]);
            if (dr["EmpE_BeginTime"] != DBNull.Value) bse_EmployeeExt.EmpE_BeginTime = Convert.ToDateTime(dr["EmpE_BeginTime"]);
            if (dr["EmpE_EndTime"] != DBNull.Value) bse_EmployeeExt.EmpE_EndTime = Convert.ToDateTime(dr["EmpE_EndTime"]);
            if (dr["Stat"] != DBNull.Value) bse_EmployeeExt.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_EmployeeExt);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_EmployeeExt对象(即:一条记录
      /// </summary>
      public List<Bse_EmployeeExt> GetAll()
      {
         List<Bse_EmployeeExt> ret = new List<Bse_EmployeeExt>();
         string sql = "SELECT  EmpE_ID,EmpE_Module,EmpE_EmpCode,EmpE_Udef1,EmpE_Udef2,EmpE_Udef3,EmpE_Udef4,EmpE_Udef5,EmpE_Udef6,EmpE_Udef7,EmpE_Udef8,EmpE_Udef9,EmpE_Udef10,EmpE_Udef11,EmpE_Udef12,EmpE_Udef13,EmpE_Udef14,EmpE_Udef15,EmpE_Udef16,EmpE_Udef17,EmpE_Udef18,EmpE_Udef19,EmpE_Udef20,EmpE_Udef21,EmpE_Udef22,EmpE_Udef23,EmpE_Udef24,EmpE_Udef25,EmpE_Udef26,EmpE_Udef27,EmpE_Udef28,EmpE_Udef29,EmpE_Udef30,EmpE_BeginTime,EmpE_EndTime,Stat FROM Bse_EmployeeExt where 1=1 AND ((Stat is null) or (Stat=0) ) ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_EmployeeExt bse_EmployeeExt = new Bse_EmployeeExt();
            if (dr["EmpE_ID"] != DBNull.Value) bse_EmployeeExt.EmpE_ID = Convert.ToDecimal(dr["EmpE_ID"]);
            if (dr["EmpE_Module"] != DBNull.Value) bse_EmployeeExt.EmpE_Module = Convert.ToString(dr["EmpE_Module"]);
            if (dr["EmpE_EmpCode"] != DBNull.Value) bse_EmployeeExt.EmpE_EmpCode = Convert.ToString(dr["EmpE_EmpCode"]);
            if (dr["EmpE_Udef1"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef1 = Convert.ToString(dr["EmpE_Udef1"]);
            if (dr["EmpE_Udef2"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef2 = Convert.ToString(dr["EmpE_Udef2"]);
            if (dr["EmpE_Udef3"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef3 = Convert.ToString(dr["EmpE_Udef3"]);
            if (dr["EmpE_Udef4"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef4 = Convert.ToString(dr["EmpE_Udef4"]);
            if (dr["EmpE_Udef5"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef5 = Convert.ToString(dr["EmpE_Udef5"]);
            if (dr["EmpE_Udef6"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef6 = Convert.ToString(dr["EmpE_Udef6"]);
            if (dr["EmpE_Udef7"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef7 = Convert.ToString(dr["EmpE_Udef7"]);
            if (dr["EmpE_Udef8"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef8 = Convert.ToString(dr["EmpE_Udef8"]);
            if (dr["EmpE_Udef9"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef9 = Convert.ToString(dr["EmpE_Udef9"]);
            if (dr["EmpE_Udef10"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef10 = Convert.ToString(dr["EmpE_Udef10"]);
            if (dr["EmpE_Udef11"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef11 = Convert.ToString(dr["EmpE_Udef11"]);
            if (dr["EmpE_Udef12"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef12 = Convert.ToString(dr["EmpE_Udef12"]);
            if (dr["EmpE_Udef13"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef13 = Convert.ToString(dr["EmpE_Udef13"]);
            if (dr["EmpE_Udef14"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef14 = Convert.ToString(dr["EmpE_Udef14"]);
            if (dr["EmpE_Udef15"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef15 = Convert.ToString(dr["EmpE_Udef15"]);
            if (dr["EmpE_Udef16"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef16 = Convert.ToString(dr["EmpE_Udef16"]);
            if (dr["EmpE_Udef17"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef17 = Convert.ToString(dr["EmpE_Udef17"]);
            if (dr["EmpE_Udef18"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef18 = Convert.ToString(dr["EmpE_Udef18"]);
            if (dr["EmpE_Udef19"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef19 = Convert.ToString(dr["EmpE_Udef19"]);
            if (dr["EmpE_Udef20"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef20 = Convert.ToString(dr["EmpE_Udef20"]);
            if (dr["EmpE_Udef21"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef21 = Convert.ToString(dr["EmpE_Udef21"]);
            if (dr["EmpE_Udef22"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef22 = Convert.ToString(dr["EmpE_Udef22"]);
            if (dr["EmpE_Udef23"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef23 = Convert.ToString(dr["EmpE_Udef23"]);
            if (dr["EmpE_Udef24"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef24 = Convert.ToString(dr["EmpE_Udef24"]);
            if (dr["EmpE_Udef25"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef25 = Convert.ToString(dr["EmpE_Udef25"]);
            if (dr["EmpE_Udef26"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef26 = Convert.ToString(dr["EmpE_Udef26"]);
            if (dr["EmpE_Udef27"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef27 = Convert.ToString(dr["EmpE_Udef27"]);
            if (dr["EmpE_Udef28"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef28 = Convert.ToString(dr["EmpE_Udef28"]);
            if (dr["EmpE_Udef29"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef29 = Convert.ToString(dr["EmpE_Udef29"]);
            if (dr["EmpE_Udef30"] != DBNull.Value) bse_EmployeeExt.EmpE_Udef30 = Convert.ToString(dr["EmpE_Udef30"]);
            if (dr["EmpE_BeginTime"] != DBNull.Value) bse_EmployeeExt.EmpE_BeginTime = Convert.ToDateTime(dr["EmpE_BeginTime"]);
            if (dr["EmpE_EndTime"] != DBNull.Value) bse_EmployeeExt.EmpE_EndTime = Convert.ToDateTime(dr["EmpE_EndTime"]);
            if (dr["Stat"] != DBNull.Value) bse_EmployeeExt.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(bse_EmployeeExt);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
