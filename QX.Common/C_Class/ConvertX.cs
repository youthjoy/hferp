using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;

namespace QX.Common.C_Class
{
    public class ConvertX
    {
        /// <summary>
        /// 将泛型集合类转换成DataTable
        /// </summary>
        /// <typeparam name="T">集合项类型</typeparam>
        /// <param name="list">集合</param>
        /// <param name="propertyName">需要返回的列的列名</param>
        /// <returns>数据集(表)</returns>
        public static DataTable ToDataTable<T>(IList<T> list, params string[] propertyName)
        {
            List<string> propertyNameList = new List<string>();
            if (propertyName != null)
            {
                propertyNameList.AddRange(propertyName);
            }

            DataTable result = new DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    if (propertyNameList.Count == 0)
                    {
                        result.Columns.Add(pi.Name, pi.PropertyType);
                    }
                    else
                    {
                        if (propertyNameList.Contains(pi.Name))
                            result.Columns.Add(pi.Name, pi.PropertyType);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        if (propertyNameList.Count == 0)
                        {
                            object obj = pi.GetValue(list[i], null);
                            tempList.Add(obj);
                        }
                        else
                        {
                            if (propertyNameList.Contains(pi.Name))
                            {
                                object obj = pi.GetValue(list[i], null);
                                tempList.Add(obj);
                            }
                        }
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            result.TableName = "tablesort";
            return result;
        }

        /// <summary>
        /// 将泛型集合类转换成DataTable
        /// </summary>
        /// <typeparam name="T">集合项类型</typeparam>
        /// <param name="list">集合</param>
        /// <returns>数据集(表)</returns>
        public static DataTable ToDataTable<T>(IList<T> list)
        {
            return ToDataTable<T>(list, null);
        }


        #region 类型转换
        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="iBool">需要转化的数字</param>
        /// <returns>已转换的bool值</returns>
        public static bool ConvertInt2Bool(int iBool)
        {
            if (iBool < 1)
            {
                return false;
            }
            else
                return true;
        }
        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="bInt">需要转化的bool变量</param>
        /// <returns>已转换的数字</returns>
        public static int ConvertBool2Int(bool bInt)
        {
            if (bInt)
            {
                return 1;
            }
            else
                return 0;
        }
        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="obj">需要转换的object</param>
        /// <returns>已转换的double变量</returns>
        public static double ConvertObj2Double(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            try
            {
                return double.Parse(obj.ToString());
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="obj">需要转换的object</param>
        /// <returns>已转换的datetime变量</returns>
        public static DateTime ConvertObj2DT(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return DateTime.Now;
            }
            try
            {
                return DateTime.Parse(obj.ToString());
            }
            catch
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="obj">需要转换的object</param>
        /// <returns>已转换的int变量</returns>
        public static int ConvertObj2Int(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            try
            {
                return int.Parse(obj.ToString());
            }
            catch
            {
                return 0;
            }
        }
        #endregion

    }
}
