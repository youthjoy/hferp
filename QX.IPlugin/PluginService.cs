using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace QX.PluginFramework
{
    public class PluginService : IPluginService
    {
        private IApplication application = null;
        private PluginConfigurationSection config = null;
        private Dictionary<String, IPlugin> plugins = new Dictionary<string, IPlugin>();
        private XmlDocument doc = new XmlDocument();

        public PluginService()
        {

        }

        public PluginService(IApplication application)
        {
            this.application = application;

        }

        #region IPluginService Members

        public void AddPlugin(string pluginName, string pluginType, string assembly, string pluginDescription)
        {
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode pluginNode = doc.SelectSingleNode("/configuration/PluginSection");
            XmlElement ele = doc.CreateElement("add");
            XmlAttribute attr = doc.CreateAttribute("Name");
            attr.Value = pluginName;
            ele.SetAttributeNode(attr);
            XmlAttribute attrType = doc.CreateAttribute("Type");
            attrType.Value = pluginType;
            ele.SetAttributeNode(attrType);

            XmlAttribute attrAss = doc.CreateAttribute("Assembly");
            attrAss.Value = assembly;
            ele.SetAttributeNode(attrAss);

            XmlAttribute attrDes = doc.CreateAttribute("Description");
            attrDes.Value = pluginDescription;
            ele.SetAttributeNode(attrDes);
            pluginNode.AppendChild(ele);
            doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("PluginSection");
        }

        public void RemovePlugin(string pluginName)
        {
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode node = doc.SelectSingleNode("/configuration/PluginSection");
            foreach (XmlNode n in node.ChildNodes)
            {
                if (n.Attributes != null)
                {
                    if (n.Attributes[0].Value == pluginName)
                    {
                        node.RemoveChild(n);
                    }
                }
            }
            doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("PluginSection");
        }

        public string[] GetAllPluginNames()
        {
            config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            PluginConfigurationElement pe = new PluginConfigurationElement();
            ArrayList ps = new ArrayList();
            for (Int32 i = 0; i < config.PluginCollection.Count; i++)
            {
                pe = config.PluginCollection[i];
                ps.Add(pe.Name);
            }
            return (String[])ps.ToArray(typeof(String));
        }

        public bool Contains(string pluginName)
        {
            config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            PluginConfigurationElement pe = new PluginConfigurationElement();
            List<String> ps = new List<string>();
            for (Int32 i = 0; i < config.PluginCollection.Count; i++)
            {
                pe = config.PluginCollection[i];
                ps.Add(pe.Name);
            }
            return ps.Contains(pluginName);
        }

        public bool LoadPlugin(string pluginName)
        {
            Boolean result = false;
            config = (PluginConfigurationSection)ConfigurationManager.GetSection("PluginSection");
            PluginConfigurationElement pe = new PluginConfigurationElement();

            String path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\AddIns";
            try
            {
                for (Int32 i = 0; i < config.PluginCollection.Count; i++)
                {
                    pe = config.PluginCollection[i];
                    if (pe.Name == pluginName)
                    {
                        Assembly assembly = Assembly.LoadFile(path + "\\" + pe.Assembly);
                        Type type = assembly.GetType(pe.Type);
                        IPlugin instance = (IPlugin)Activator.CreateInstance(type);
                        instance.Application = application;
                        instance.Load();
                        plugins[pluginName] = instance;
                        result = true;
                        break;
                    }
                }
                if (!result)
                {
                    MessageBox.Show("Not Found the Plugin");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                result = false;
            }
            return result;
        }

        public bool UnLoadPlugin(string pluginName)
        {
            Boolean result = false;
            try
            {
                IPlugin plugin = GetPluginInstance(pluginName);
                plugin.UnLoad();
                result = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }


        public void LoadAllPlugin()
        {
            PluginConfigurationElement pe = new PluginConfigurationElement();
            config = ConfigurationManager.GetSection("PluginSection") as PluginConfigurationSection;
            String path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\AddIns";

            //���󻺴�
            ObjectCache Cache = new ObjectCache();         
            Assembly assembly;
            Type type;
            IPlugin instance;
            try
            {
                for (Int32 i = 0; i < config.PluginCollection.Count; i++)
                {
                    pe = config.PluginCollection[i];
                    if (pe.IsEnable.ToUpper()=="TRUE")
                    {
                        string PluginDll = path + "\\" + pe.Assembly;
                        if (File.Exists(PluginDll))
                        {
                            if (Cache.ExistObject(config.PluginCollection[i].Name))
                            {
                                instance = (IPlugin)Cache.GetObject(config.PluginCollection[i].Name);
                            }
                            else
                            {
                                assembly = Assembly.LoadFile(PluginDll);
                                type = assembly.GetType(pe.Type);
                                instance = (IPlugin)Activator.CreateInstance(type);
                                Cache.AddObject(config.PluginCollection[i].Name, instance);
                            }
                            instance.Application = application;
                            instance.Data = config.PluginCollection[i].Data;
                            instance.Description = config.PluginCollection[i].Description;
                            instance.Load();
                            plugins[pe.Name] = instance;
                        }                       
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public IApplication Application
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

        public IPlugin GetPluginInstance(string pluginName)
        {
            IPlugin plugin = null;
            if (plugins.ContainsKey(pluginName))
            {
                plugin = plugins[pluginName];
            }
            return plugin;
        }

        #endregion       
    }
}
