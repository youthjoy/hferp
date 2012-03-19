using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using QX.PluginFramework;

namespace QX.Common.C_Class
{
    public class Plugin
    {

        List<String[]> ClassPaths = new List<String[]>();
        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns></returns>
        public List<String[]> ReadProfile(string path)
        {
            DataSet ds = new DataSet();
            if (System.IO.File.Exists(path))
            {
                ds.ReadXml(path);
                DataTable dt;
                try
                {
                    dt = ds.Tables[0];
                }
                catch
                {
                    return null;
                }
                for (Int32 i = 0; i < dt.Rows.Count; i++)
                {
                    String[] Stemp = new String[4];
                    Stemp[0] = dt.Rows[i]["ClassName"].ToString();
                    Stemp[1] = dt.Rows[i]["FilePath"].ToString();
                    Stemp[2] = dt.Rows[i]["Description"].ToString();
                    Stemp[3] = dt.Rows[i]["Name"].ToString();
                    Stemp[4] = dt.Rows[i]["IsEnable"].ToString();
                    this.ClassPaths.Add(Stemp);                   
                }
            }
            return ClassPaths;
        }

        /// <summary>
        /// 运行所有有效插件
        /// </summary>
        /// <param name="MainForm"></param>
        public void RunPlugin(System.Windows.Forms.Form MainForm)
        {
            
        }

        /// <summary>
        /// 判断类是否实现了接口
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private bool IsValidPlugin(Type t)
        {
            Type[] Interfaces = t.GetInterfaces();
            foreach (Type Ifs in Interfaces)
            {
                if (Ifs.FullName == "QX_WinformInterFace")
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 判断是否有重复的类型和文件名
        /// </summary>
        /// <param name="classname"></param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private bool IsContains(String classname)
        {
            foreach (String[] ss in ClassPaths)
            {
                if (ss[0] == classname)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
