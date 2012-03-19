using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace QX.PluginFramework
{
    public class PluginConfigurationElement : ConfigurationElement
    {
        public PluginConfigurationElement()
        {
        }

        [ConfigurationProperty("Name")]
        public String Name
        {
            get
            {
                return (String)this["Name"];
            }
            set
            {
                this["Name"] = value;
            }
        }

        [ConfigurationProperty("Type")]
        public String Type
        {
            get
            {
                return (String)this["Type"];
            }
            set
            {
                this["Type"] = value;
            }
        }

        [ConfigurationProperty("Assembly")]
        public String Assembly
        {
            get
            {
                return (String)this["Assembly"];
            }
            set
            {
                this["Assembly"] = value;
            }
        }

        [ConfigurationProperty("Description")]
        public String Description
        {
            get
            {
                return (String)this["Description"];
            }
            set
            {
                this["Description"] = value;
            }
        }

        [ConfigurationProperty("IsEnable")]
        public String IsEnable
        {

            get
            {
                return (String)this["IsEnable"];
            }
            set
            {
                this["IsEnable"] = value;
            }
        }
        [ConfigurationProperty("Data")]
        public String Data
        {
            get
            {
                return (String)this["Data"];
            }
            set
            {
                this["Data"] = value;
            }
        }
    }
}
