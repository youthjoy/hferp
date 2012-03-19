using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace QX.Common.C_Class
{
    /// <summary>
    /// 全局配置
    /// </summary>
    public static class GlobalConfiguration
    {
        /// <summary>
        /// 插件数据目录
        /// </summary>
        public static readonly string PLUGIN_DATA_PATH = Path.GetDirectoryName(Application.ExecutablePath) + "\\Data";
        /// <summary>
        /// 插件DLL目录
        /// </summary>
        public static readonly string PLUGIN_DLL_PATH = Path.GetDirectoryName(Application.ExecutablePath) + "\\AddIns";
        /// <summary>
        /// 程序根目录
        /// </summary>
        public static readonly string APPLICATION_PATH = Path.GetDirectoryName(Application.ExecutablePath);
        /// <summary>
        /// 加密因子
        /// </summary>
        public static readonly string EncrypStringKey = "!@#$%^&*()_)((**&&^$!@#$%^TFE";
        /// <summary>
        /// 中文信息文件路径
        /// </summary>
        public static readonly string ChineseLanguage = PLUGIN_DATA_PATH + "\\chinese.ini";
        /// <summary>
        /// 中文信息文件包
        /// </summary>
        public static Dictionary<string, string> CNLanguage;
        /// <summary>
        /// 当前用户登录名
        /// </summary>
        public static string UserName = "admin";
        /// <summary>
        /// 当前用户ID
        /// </summary>
        public static string UserId = "099003";

        public static string ProdDept = "0114";

        public static string ProdDeptName = "生产车间";

        public static string MarketDept = "104000000076";

        public static string MarketName = "外协";

        public static string RootDept = "root";

        public static string RootDeptName = "重庆市江津区禾丰机械有限公司";

        public static string Admin = "admin";

        public static Color[] AuditColor = new Color[]{Color.Wheat,Color.SkyBlue,Color.Pink ,Color.Empty};
    }
}
