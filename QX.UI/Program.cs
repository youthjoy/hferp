using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;
using QX.Common.C_Class;

namespace QX.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            string proc = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(proc);
            //加载中文语言包
            ReadInIConfigruation language = new ReadInIConfigruation(GlobalConfiguration.ChineseLanguage);
            GlobalConfiguration.CNLanguage = language.LoadInIConfigruation();

            //if (processes.Length > 1)
            //{
            //    Alert.Show(GlobalConfiguration.CNLanguage["comm_allowoneapp"]);
            //    return;
            //}
            //else
            //{
            QX.Log.PlateLog.Init();

            Application.Run(new F_Main());
            //}
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Alert.Show(e.Exception.Message + "\r" + "error:" + sender.ToString());
        }
    }
}
