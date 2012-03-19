using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QX.PluginFramework;
using QX.Common.C_Class;
using System.Data;
using System.Reflection;
using System.Drawing;

namespace QX.Plugin.TopMenuStrip
{
    public class TopMenuStrip:IPlugin
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
            Form MainFrm = (Form)application;
            Panel TopPanel = application.TopToolPanel;
            Panel ToolStripPanel = new Panel();
            ToolStripPanel.Dock = DockStyle.Fill;            
            ToolStrip tool_strip = new ToolStrip();
            tool_strip.Dock = DockStyle.Top;
            tool_strip.Location = new Point(0, 22);
            //tool_strip.Items.Add("");
            //加载XML数据
            string path = GlobalConfiguration.PLUGIN_DATA_PATH + "\\" + data;
            XmlHelper xmlhepler = new XmlHelper(path);
            DataView DvList = xmlhepler.GetData("TopMenu", "pid=''", null);            
            MenuStrip TopMenuStrip = new MenuStrip();
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Text = "TopMenuStrip";
            TopMenuStrip.Dock = DockStyle.Top;
            TopMenuStrip.Location = new Point(0, 0);
            for (int i = 0; i < DvList.Table.Rows.Count; i++)
            {                
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = DvList.Table.Rows[i]["id"].ToString();
                item.Size = new System.Drawing.Size(58, 21);
                item.Text = DvList.Table.Rows[i]["label"].ToString();

                DataView DvSubItem = xmlhepler.GetData("TopMenu", "pid='" + DvList.Table.Rows[i]["id"] + "'", null);
                if (DvSubItem.Table.Rows.Count>0)
                {
                    for (int j = 0; j < DvSubItem.Table.Rows.Count; j++)
                    {                      
                        
                        ToolStripMenuItem subitem = new ToolStripMenuItem();
                        subitem.Name = DvSubItem.Table.Rows[j]["id"].ToString();
                        subitem.Size = new System.Drawing.Size(58, 21);
                        subitem.Text = DvSubItem.Table.Rows[j]["label"].ToString();
                        subitem.Tag = DvSubItem.Table.Rows[j]["path"].ToString() + "," + DvSubItem.Table.Rows[j]["class"].ToString();
                        subitem.Click += new EventHandler(subitem_Click);
                        if (!string.IsNullOrEmpty(DvSubItem.Table.Rows[j]["icon"].ToString()))
                        {
                            Assembly asm = Assembly.GetExecutingAssembly();
                            System.IO.Stream stream = asm.GetManifestResourceStream("QX.Plugin.TopMenuStrip.icon." +
                                DvSubItem.Table.Rows[j]["icon"].ToString());
                            if (stream != null)
                            {
                                Image icon = Image.FromStream(stream);
                                if (icon != null)
                                {
                                    subitem.Image = icon;
                                }
                            }         
                        }
                                                           
                        item.DropDownItems.Add(subitem);
                    }                    
                }
                TopMenuStrip.Items.Add(item);
            }
            ToolStripPanel.Controls.Add(tool_strip);
            TopPanel.Controls.Add(tool_strip);
            TopPanel.Controls.Add(TopMenuStrip);
            MainFrm.MainMenuStrip = TopMenuStrip;            
        }

        void subitem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item=(ToolStripMenuItem)sender;
            try
            {
                if (item.Tag.ToString().Contains(",") && item.Tag.ToString().Length>3 )
                {
                    string[] str = item.Tag.ToString().Split(',');
                    if (str.Length==2)
                    {
                        QX_Common.C_Class.DynCompile dyncompile = new QX_Common.C_Class.DynCompile();
                        dyncompile.FindAssbely(GlobalConfiguration.PLUGIN_DLL_PATH + "\\" + str[0], str[1], application);
                    }
                }                
            }
            catch (Exception ex)
            {
                //throw;
                MessageBox.Show(ex.Message+"\r\n"+"如需解决此问题,请联系开发商","错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> Loading;

        #endregion
                
    }
}
