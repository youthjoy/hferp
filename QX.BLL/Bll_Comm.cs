using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace QX.BLL
{
    public class Bll_Comm
    {
        private ADOComm instance = new ADOComm();

        /// <summary>
        /// 获取自增编码
        /// </summary>
        /// <param name="NameSapce"></param>
        /// <returns></returns>
        public string GenerateCode(string NameSapce)
        {
           
            return instance.GetTableKeyCode(NameSapce);
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public DataTable ListViewData(string sql)
        {
            return instance.ExcuteSql(sql);
        }

        public object GetMax(string tableName, string col)
        {
            return instance.GetMax(tableName, col);
        }

        public object GetCount(string tableName, string where)
        {
            return instance.GetCount(tableName, where);
        }

        public DataTable GetComDataTableByCode(string code)
        {
            DataTable dt = new DataTable();
            dt=instance.ExcuteProc(code);
            return dt;
        }

        public DataTable GetDataTablebyProc(string sql,Dictionary<string,object> list)
        {
            DataTable dt = new DataTable();
            int count = list.Count;
            SqlParameter[] paras = new SqlParameter[count];
            int i = 0;
            foreach(var d in list)
            {
                SqlParameter pa = new SqlParameter();
                pa.ParameterName = "@"+d.Key;
                pa.Value = d.Value;
                paras[i] = pa;
                i++;
            }

            IDbDataParameter[] parames = paras as IDbDataParameter[];
            
            dt = instance.ExcuteProc(sql, parames);

            return dt;
        }

        public DataTable GetComDataTableByCode(string module,string code, ArrayList list)
        {
            DataTable dt = new DataTable();
            if (list.Count > 0)
            {
                SqlParameter x0 = new SqlParameter("@Module", SqlDbType.VarChar);

                x0.Value = module;

                SqlParameter x1 = new SqlParameter("@bDate", SqlDbType.DateTime);

                x1.Value = list[0];

                SqlParameter x2 = new SqlParameter("@eDate", SqlDbType.DateTime);

                x2.Value = list[1];

                SqlParameter x3 = new SqlParameter("@Key", SqlDbType.VarChar);

                x3.Value = list[2];


                SqlParameter x4 = new SqlParameter("@Dept", SqlDbType.VarChar);

                x4.Value = list[3];


                SqlParameter x5 = new SqlParameter("@Udef1", SqlDbType.VarChar);

                x5.Value = list[4];

                SqlParameter x6 = new SqlParameter("@Udef2", SqlDbType.VarChar);

                x6.Value = list[5];


                //SqlParameter x7 = new SqlParameter("@Key", SqlDbType.VarChar);

                //x7.Value = list[6];

                SqlParameter[] param = new SqlParameter[] {x0, x1, x2, x3,x4,x5,x6 };
                IDbDataParameter[] parames = param as IDbDataParameter[];
                dt = instance.ExcuteProc(code, parames);
            }
            else
            {
                SqlParameter x0 = new SqlParameter("@Module", SqlDbType.VarChar);

                x0.Value = module;

                SqlParameter x1 = new SqlParameter("@bDate", SqlDbType.DateTime);

                x1.Value = "1970-01-01";

                SqlParameter x2 = new SqlParameter("@eDate", SqlDbType.DateTime);

                x2.Value = "3000-01-01";

                SqlParameter x3 = new SqlParameter("@Key", SqlDbType.VarChar);

                x3.Value = "";


                SqlParameter x4 = new SqlParameter("@Dept", SqlDbType.VarChar);

                x4.Value = "";


                SqlParameter x5 = new SqlParameter("@Udef1", SqlDbType.VarChar);

                x5.Value = "";

                SqlParameter x6 = new SqlParameter("@Udef2", SqlDbType.VarChar);

                x6.Value = "";



                SqlParameter[] param = new SqlParameter[] { x0, x1, x2, x3, x4, x5, x6 };
                IDbDataParameter[] parames = param as IDbDataParameter[];
                dt = instance.ExcuteProc(code, parames);
            }

         
            return dt;
        }

        

    }
}
