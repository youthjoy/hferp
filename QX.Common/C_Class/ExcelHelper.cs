using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QX.Common.C_Class
{
    public class ExcelHelper
    {

        //Excel导入到数据库Access中

        //filePath  你的Excel文件路径

        public static DataTable Import(string filePath)
        {
            DataTable dt = new DataTable();
            DataSet OleDsExcle = new DataSet();
            try
            {


                //Excel就好比一个数据源一般使用

                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + "Extended Properties='Excel 8.0;HDR=False;IMEX=1'";

                OleDbConnection con = new OleDbConnection(strConn);
                con.Open();

                //返回Excel的架构，包括各个sheet表的名称,类型，创建时间和修改时间等 
                DataTable dtSheetName = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });

                string sheet = "sheet1$";

                //包含excel中表名的字符串数组
                if (dtSheetName.Rows.Count >= 1)
                {
                    sheet = dtSheetName.Rows[0]["TABLE_NAME"].ToString();
                }

                string sql = string.Format(" select * from [{0}]", sheet);

                OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, con);
    
                OleDaExcel.Fill(OleDsExcle, "Sheet1");

                con.Close();


                return OleDsExcle.Tables[0];
            }
            catch (Exception)
            {
                return dt;
            }

        }
    }
}
