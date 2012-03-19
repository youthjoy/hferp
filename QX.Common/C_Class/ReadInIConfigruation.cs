using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace QX.Common.C_Class
{
    public class ReadInIConfigruation
    {
        private string path = "";
        public ReadInIConfigruation(string Path)
        {
            this.path = Path;
        }

        /// <summary>
        /// 加载提示信息INI文件
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> LoadInIConfigruation()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            StreamReader sr=null;
            try
            {
                sr = File.OpenText(this.path);
                string txt = "";
                string[] filter = null;
                while ((txt = sr.ReadLine()) != null)
                {
                    if (txt.Contains("="))
                    {
                        filter = txt.Split('=');
                        dic.Add(filter[0], filter[1]);                        
                    }
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                if (sr!=null)
	            {
                    sr.Close();
                    sr.Dispose();
	            }
               
            }
            return dic;
        }
        
    }
}
