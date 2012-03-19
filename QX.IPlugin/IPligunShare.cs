using System;
using System.Collections.Generic;
using System.Text;

namespace QX.PluginFramework
{
    /// <summary>
    /// 插件间共享
    /// </summary>
    public interface IPligunShare
    {
        /// <summary>
        /// 传进来的数据对象
        /// </summary>
        Object InData { get; set; }  
        /// <summary>
        /// 启动
        /// </summary>
        void Start();

        /// <summary>
        /// 回传事件
        /// </summary>
        event EventHandler<EventArgs> CallBack;
    }
}
