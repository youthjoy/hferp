using System;
using System.Collections.Generic;
using System.Text;
using QX.PluginFramework;
using QX.Common.C_Class;
using System.Windows.Forms;

namespace QX.Plugin.Contract
{
    /// <summary>
    /// 合同管理
    /// </summary>
    public class Contract:IPlugin
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
            ContractManage contract = new ContractManage();
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
    /// <summary>
    /// 加工价值
    /// </summary>
    public class RoadValue : IPlugin
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
            ContractValue contract = new ContractValue(data);
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
    /// <summary>
    /// 客户管理
    /// </summary>
    public class Customers : IPlugin
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
            CustomersManage customer = new CustomersManage(data);
            customer.MdiParent = this.application as Form;
            customer.Show();
        }

        public void UnLoad()
        {
            
        }

        public event EventHandler<EventArgs> Loading;

        #endregion
    }
}
