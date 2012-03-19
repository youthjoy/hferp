using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.PluginFramework;
using QX.Common.C_Class;
using System.Windows.Forms;
using QX.Plugin.Prod.Report;
namespace QX.Plugin.Report
{
    public class ComRptContract : IPlugin
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
            CommRptContract contract = new CommRptContract(data);
            contract.MdiParent = this.application as Form;
            contract.Show();
        }

        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> Loading;

        #endregion
    }
}
