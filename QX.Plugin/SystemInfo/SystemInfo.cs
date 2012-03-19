using System;
using System.Collections.Generic;
using System.Text;
using QX.PluginFramework;

namespace QX.Plugin.SystemInfo
{
    public class SystemInfo:IPlugin
    {
        private IApplication application = null;
        private String name = string.Empty;
        private String description = string.Empty;
        private String data = string.Empty;

        #region IPlugin 成员

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
            F_SystemInfo frm = F_SystemInfo.Instance();
            frm.Text = name;
            //frm.MdiParent = application as System.Windows.Forms.Form;
            frm.ShowDialog();
        }

        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> Loading;

        #endregion
    }
}
