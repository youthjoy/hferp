using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq;
using System.Data;
using System.Linq;
using QX.PluginFramework;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX.Shared;
using QX.DataModel;
using Infragistics.Win.UltraWinExplorerBar;

namespace QX.Plugin.LeftMenu
{
    public class LeftMenu : IPlugin
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

        public void SetChinese()
        {
            Infragistics.Shared.ResourceCustomizer rc = Infragistics.Win.UltraWinExplorerBar.Resources.Customizer;//Resources.Customizer;

            rc.SetCustomizedString("NavigationQuickCustomizeMenu_ShowMoreButtons", "更多");
            rc.SetCustomizedString("NavigationQuickCustomizeMenu_ShowFewerButtons", "隐藏");
            rc.SetCustomizedString("NavigationQuickCustomizeMenu_NavigationPaneOptions", "自定义设置");
            rc.SetCustomizedString("NavigationQuickCustomizeMenu_AddOrRemoveButtons", "增加或去除按钮");

            rc.SetCustomizedString("NavigationPaneOptionsDialog_Caption", "自定义设置");
            rc.SetCustomizedString("NavigationPaneOptionsDialog_CancelButton", "取消");
            rc.SetCustomizedString("NavigationPaneOptionsDialog_ResetButton", "重置");
            rc.SetCustomizedString("NavigationPaneOptionsDialog_OKButton", "确定");
            rc.SetCustomizedString("NavigationPaneOptionsDialog_MoveUpButton", "上移");
            rc.SetCustomizedString("NavigationPaneOptionsDialog_MoveDownButton", "下移");
            rc.SetCustomizedString("NavigationPaneOptionsDialog_Label", "选项");
        }

        public void Load()
        {
            SetChinese();
            Panel LeftPanel = application.LeftToolPanel;

            #region 树形控件菜单
            //TreeView tree = new TreeView();
            //tree.Dock = DockStyle.Fill;
            //TreeNode root = new TreeNode("根目录");
            //string path = GlobalConfiguration.PLUGIN_DATA_PATH + "\\" + data;
            //XmlHelper xmlhepler = new XmlHelper(path);
            //DataView DvList = xmlhepler.GetData("LeftMenu", "pid=''", null);
            //for (int i = 0; i < DvList.Table.Rows.Count; i++)
            //{
            //    TreeNode SubNode = new TreeNode();
            //    SubNode.Name = DvList.Table.Rows[i]["id"].ToString();
            //    SubNode.Text = DvList.Table.Rows[i]["label"].ToString();
            //    SubNode.Tag = DvList.Table.Rows[i]["path"].ToString() + ","
            //        + DvList.Table.Rows[i]["class"].ToString() + ","
            //        + DvList.Table.Rows[i]["label"].ToString() + ","
            //        + DvList.Table.Rows[i]["data"].ToString();
            //    root.Nodes.Add(SubNode);
            //    DataView DvSubItem = xmlhepler.GetData("LeftMenu", "pid='" + DvList.Table.Rows[i]["id"] + "'", null);
            //    if (DvSubItem.Table.Rows.Count > 0)
            //    {
            //        for (int j = 0; j < DvSubItem.Table.Rows.Count; j++)
            //        {
            //            TreeNode SubItemNode = new TreeNode();
            //            SubItemNode.Name = DvSubItem.Table.Rows[j]["id"].ToString();


            //            //if (SessionConfig.PermissionList.FirstOrDefault(o => o.PU_FunCode == SubItemNode.Name) != null)
            //            //{

            //                SubItemNode.Text = DvSubItem.Table.Rows[j]["label"].ToString();

            //                SubItemNode.Tag = DvSubItem.Table.Rows[j]["path"].ToString() + "," + DvSubItem.Table.Rows[j]["class"].ToString() + ","
            //                + DvSubItem.Table.Rows[j]["label"].ToString() + "," + DvSubItem.Table.Rows[j]["data"].ToString();
            //                SubNode.Nodes.Add(SubItemNode);
            //            //}
            //        }
            //    }
            //}
            //tree.Nodes.Add(root);
            //tree.ExpandAll();
            //tree.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(tree_NodeMouseDoubleClick);
            #endregion

            #region OutLook菜单
            //Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar Sys_LMenu;
            UltraExplorerBar Sys_LMenu = new UltraExplorerBar();
            Sys_LMenu.Dock = DockStyle.Fill;
            Sys_LMenu.Style = UltraExplorerBarStyle.OutlookNavigationPane;
            Sys_LMenu.ViewStyle = UltraExplorerBarViewStyle.Office2007;
            Sys_LMenu.Name = "Sys_LMenu";

            string path = GlobalConfiguration.PLUGIN_DATA_PATH + "\\" + data;
            XmlHelper xmlhepler = new XmlHelper(path);


            DataView DvList = xmlhepler.GetData("LeftMenu", "pid=''", null);
            for (int i = 0; i < DvList.Table.Rows.Count; i++)
            {
                UltraExplorerBarGroup group = new UltraExplorerBarGroup();
                group.Key = DvList.Table.Rows[i]["id"].ToString();
                group.Text = DvList.Table.Rows[i]["label"].ToString();
                group.Tag = DvList.Table.Rows[i]["path"].ToString() + ","
                    + DvList.Table.Rows[i]["class"].ToString() + ","
                    + DvList.Table.Rows[i]["label"].ToString() + ","
                    + DvList.Table.Rows[i]["data"].ToString();
               

                DataView DvSubItem = xmlhepler.GetData("LeftMenu", "pid='" + DvList.Table.Rows[i]["id"] + "'", null);
                if (DvSubItem.Table.Rows.Count > 0)
                {
                    for (int j = 0; j < DvSubItem.Table.Rows.Count; j++)
                    {
                        var temp = SessionConfig.PermissionList.FirstOrDefault(o => o.Fun_Code == DvSubItem.Table.Rows[j]["id"].ToString());
                        if (temp != null)
                        {
                            UltraExplorerBarItem item = new UltraExplorerBarItem();
                            item.Key = DvSubItem.Table.Rows[j]["id"].ToString();
                            item.Text = DvSubItem.Table.Rows[j]["label"].ToString();
                            item.Tag = DvSubItem.Table.Rows[j]["path"].ToString() + "," + DvSubItem.Table.Rows[j]["class"].ToString() + ","
                            + DvSubItem.Table.Rows[j]["label"].ToString() + "," + DvSubItem.Table.Rows[j]["data"].ToString();
                            group.Items.Add(item);
                        }
                    }
                    if (group.Items.Count > 0)
                    {
                        Sys_LMenu.Groups.Add(group);
                    }
                }
            }
            Sys_LMenu.ItemClick += new ItemClickEventHandler(Sys_LMenu_ItemClick);
            LeftPanel.Controls.Add(Sys_LMenu);
            #endregion
        }

        #region OutLook菜单
        void Sys_LMenu_ItemClick(object sender, ItemEventArgs e)
        {
            if (e.Item != null)
            {
                string data = e.Item.Tag.ToString();
                try
                {
                    if (data.Contains(",") && data.Length > 5)
                    {
                        string[] str = data.Split(',');
                        if (str.Length == 4)
                        {
                            QX_Common.C_Class.DynCompile dyncompile = new QX_Common.C_Class.DynCompile();
                            dyncompile.FindAssbely(GlobalConfiguration.PLUGIN_DLL_PATH + "\\" + str[0], str[1],
                                application, str[2], str[3]);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        #region 树菜单
        void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeView Tree = sender as TreeView;
                if (Tree.SelectedNode.Tag == null) return;
                string data = Tree.SelectedNode.Tag.ToString();
                try
                {
                    if (data.Contains(",") && data.Length > 5)
                    {
                        string[] str = data.Split(',');
                        if (str.Length == 4)
                        {
                            QX_Common.C_Class.DynCompile dyncompile = new QX_Common.C_Class.DynCompile();
                            dyncompile.FindAssbely(GlobalConfiguration.PLUGIN_DLL_PATH + "\\" + str[0], str[1], application, str[2], str[3]);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> Loading;

        #endregion
    }
}
