using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace QX.PluginFramework
{
    /// <summary>
    /// 插件共享服务
    /// </summary>
    public class PluginShareServer
    {
        public event EventHandler<EventArgs> CallBack;

        /// <summary>
        /// 获取实例
        /// </summary>
        public void GetInstance(String Name,String Class,Object data)
        {
            String path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\AddIns\\";
            Assembly asm;
            Type type;
            IPligunShare instance;
            try
            {
                asm = Assembly.LoadFile(path+Name+".dll");
                type = asm.GetType(Class, true, false);
                instance = (IPligunShare)Activator.CreateInstance(type);
                instance.InData = data;
                instance.Start();                
            }
            catch (Exception)
            {                
                throw;
            }

        }
    }
}
