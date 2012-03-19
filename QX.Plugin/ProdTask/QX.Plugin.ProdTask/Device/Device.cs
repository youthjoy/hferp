using System;
using System.Collections.Generic;
using System.Text;
using QX.PluginFramework;
namespace QX.Plugin.DeviceManage
{
    public class Device:IPlugin
    {
      
            private IApplication application = null;
            private String name = string.Empty;
            private String description = string.Empty;
            private String data = string.Empty;


            public QX.PluginFramework.IApplication Application
            {
                get
                {
                    return application;
                }
                set
                {
                    application = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public string Description
            {
                get
                {
                    return description;
                }
                set
                {
                    description = value;
                }
            }

            public string Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }

            public void Load()
            {
                //System.Diagnostics.Stopwatch watch1 = new System.Diagnostics.Stopwatch();
                //watch1.Start();
                DeviceManage frm1 = DeviceManage.Instance();
                frm1.MdiParent = (System.Windows.Forms.Form)application;
                //watch1.Stop();
                frm1.Show();
         
                
                
            }

            public void UnLoad()
            {
                throw new NotImplementedException();
            }

            public event EventHandler<EventArgs> Loading;

        
    }
}
