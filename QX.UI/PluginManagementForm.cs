using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.PluginFramework;
using System.IO;
using System.Reflection;

namespace QX.UI
{
    public partial class PluginManagementForm : Form
    {
        private IApplication application = null;

        public PluginManagementForm(IApplication application)
        {
            InitializeComponent();
            this.application = application;
        }

        private void PluginManagementForm_Load(object sender, EventArgs e)
        {
            String pluginPath = Path.GetDirectoryName(Application.ExecutablePath)+"\\AddIns";
            DirectoryInfo di = new DirectoryInfo(pluginPath);
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo[] plugins = di.GetFiles("*.dll");
            listView1.Items.Clear();
            foreach (FileInfo plugin in plugins)
            {
                try
                {
                    FindPluginFromAssembly(plugin);
                }
                catch (Exception)
                {
                    continue;
                }
                
            }
            CheckExistedPlugin();
        }

        private void FindPluginFromAssembly(FileInfo file)
        {            
            Assembly assembly = System.Reflection.Assembly.LoadFile(file.FullName);
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.GetInterface("IPlugin") != null)
                {
                    ListViewItem lvi = new ListViewItem(type.Name);
                    lvi.SubItems.Add(type.FullName);
                    lvi.SubItems.Add(file.Name);
                    DescriptionAttribute da = (DescriptionAttribute)(TypeDescriptor.GetAttributes(type)[typeof(DescriptionAttribute)]);
                    lvi.SubItems.Add(da.Description);
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void CheckExistedPlugin()
        {
            IPluginService pluginService = (IPluginService)application.GetService(typeof(IPluginService));
            if (pluginService != null)
            {
                List<String> nameList=new List<string>();
                String[] pluginNames = pluginService.GetAllPluginNames();
                nameList.AddRange(pluginNames);
                foreach (ListViewItem item in listView1.Items)
                {
                    if (nameList.Contains(item.Text))
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPluginService pluginService = (IPluginService)application.GetService(typeof(IPluginService));
            if (pluginService != null)
            {
                List<String> nameList = new List<string>();
                String[] pluginNames = pluginService.GetAllPluginNames();
                nameList.AddRange(pluginNames);
                foreach (ListViewItem item in listView1.Items)
                {
                    if (!item.Checked)
                    {
                        if (nameList.Contains(item.Text))
                        {
                            pluginService.UnLoadPlugin(item.Text);
                            pluginService.RemovePlugin(item.Text);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (nameList.Contains(item.Text))
                        {
                            continue;
                        }
                        else
                        {
                            pluginService.AddPlugin(item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                            pluginService.LoadPlugin(item.Text);
                        }
                    }
                }
            }
            this.Close();
        }
    }
}

