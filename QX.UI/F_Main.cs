using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.PluginFramework;
using System.ComponentModel.Design;
using QX.Shared;
using System.Threading;
using QX.UpdateHelper;

namespace QX.UI
{
    public partial class F_Main : F_BasciForm, IApplication
    {

        private ServiceContainer serviceContainer = new ServiceContainer();
        private PluginService pluginService;

        public F_Main()
        {
            InitializeComponent();
            pluginService = new PluginService(this);
            serviceContainer.AddService(typeof(IPluginService), pluginService);
            SetPanel(false);

        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            try
            {
                Thread t = new Thread(CheckUpdate);
                t.Start();

                SetPanel(false);
                MethodInvoker mInvoker = new MethodInvoker(this.InitData);

                F_LogOn logFrm = new F_LogOn(mInvoker);
                logFrm.MdiParent = this;
                logFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CheckUpdate()
        {
            AutoUpdater up = new AutoUpdater();
            up.Update();
        }

        private void SetPanel(bool flag)
        {


            if (flag)
            {
                if (top_panel.InvokeRequired)
                {
                    MethodInvoker m = delegate { top_panel.Visible = true; };
                    this.Invoke(m);
                }
                else
                {
                    top_panel.Visible = true;
                }
                if (pbSwitch.InvokeRequired)
                {
                    MethodInvoker m = delegate { pbSwitch.Visible = true; };
                    this.Invoke(m);
                }
                else
                {
                    pbSwitch.Visible = true;
                }
                if (left_panel.InvokeRequired)
                {
                    MethodInvoker m = delegate { left_panel.Visible = true; };
                    this.Invoke(m);
                }
                else
                {
                    left_panel.Visible = true;
                }

            }
            else
            {


                if (top_panel.InvokeRequired)
                {
                    MethodInvoker m = delegate { top_panel.Visible = false; };
                    this.Invoke(m);
                }
                else
                {
                    top_panel.Visible = false;
                }
                if (left_panel.InvokeRequired)
                {
                    MethodInvoker m = delegate { left_panel.Visible = false; };
                    this.Invoke(m);
                }
                else
                {
                    left_panel.Visible = false;
                }
                if (pbSwitch.InvokeRequired)
                {
                    MethodInvoker m = delegate { pbSwitch.Visible = false; };
                    this.Invoke(m);
                }
                else
                {
                    pbSwitch.Visible = false;
                }

            }
        }

        public void InitData()
        {
            try
            {
                MethodInvoker m = delegate
                {

                    SetPanel(true);
                    pluginService.LoadAllPlugin();

                    F_ToDo toDo = new F_ToDo();
                    toDo.MdiParent = this;
                    toDo.Show();
                };

                this.Invoke(m);
            }
            catch (Exception ex)
            {
                string ee = ex.Message;
            };

            Label lab = new Label();
            lab.Text = string.Format("当前登录人:{0} 部门: {1}", SessionConfig.EmpName, SessionConfig.DeptName);
            lab.Width = 300;
            if (button_panel.InvokeRequired)
            {
                MethodInvoker mm = delegate
                {

                    this.button_panel.Controls.Add(lab);
                    lab.Top = 5;
                };

                this.Invoke(mm);
            }
            else
            {
                this.button_panel.Controls.Add(lab);
            }
        }



        #region IApplication 成员

        public Panel LeftToolPanel
        {
            get { return left_panel; }
        }

        public Panel RightToolPanel
        {
            get { throw new NotImplementedException(); }
        }

        public Panel TopToolPanel
        {
            get { return top_panel; }
        }

        public Panel BottomToolPanel
        {
            get { throw new NotImplementedException(); }
        }

        public StatusStrip StatusBar
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IServiceContainer 成员

        public void AddService(Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote)
        {
            serviceContainer.AddService(serviceType, callback, promote);
        }

        public void AddService(Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback)
        {
            serviceContainer.AddService(serviceType, callback);
        }

        public void AddService(Type serviceType, object serviceInstance, bool promote)
        {
            serviceContainer.AddService(serviceType, serviceInstance, promote);
        }

        public void AddService(Type serviceType, object serviceInstance)
        {
            serviceContainer.AddService(serviceType, serviceInstance);
        }

        public void RemoveService(Type serviceType, bool promote)
        {
            serviceContainer.RemoveService(serviceType, promote);
        }

        public void RemoveService(Type serviceType)
        {
            serviceContainer.RemoveService(serviceType);
        }

        #endregion

        #region IServiceProvider 成员
        //由于Form类型本身间接的继承了IServiceProvider接口，所以我们要覆盖掉Form本身的实现
        //所以我们使用了new关键字
        public new object GetService(Type serviceType)
        {
            return serviceContainer.GetService(serviceType);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            PluginManagementForm pmf = new PluginManagementForm(this);
            pmf.MdiParent = this;
            pmf.Show();
        }

        #region 自动伸缩控件事件
        private void pbSwitch_Click_1(object sender, EventArgs e)
        {
            if (left_panel.Width > 0)
            {
                left_panel.Width = 0;
                pbSwitch.Image = global::QX.UI.Properties.Resources.r;
            }
            else
            {
                left_panel.Width = 180;
                pbSwitch.Image = global::QX.UI.Properties.Resources.l;
            }
            left_panel.Refresh();
        }

        private void pbSwitch_MouseEnter(object sender, EventArgs e)
        {
            if (left_panel.Width > 0)
            {
                pbSwitch.Image = global::QX.UI.Properties.Resources.r_h;
            }
            else
            {
                pbSwitch.Image = global::QX.UI.Properties.Resources.l_h;
            }
        }

        private void pbSwitch_MouseLeave(object sender, EventArgs e)
        {
            if (left_panel.Width > 0)
            {
                pbSwitch.Image = global::QX.UI.Properties.Resources.r;
            }
            else
            {
                pbSwitch.Image = global::QX.UI.Properties.Resources.l;
            }
        }
        #endregion

        #region IApplication 成员


        public MenuStrip TopMenuStrip
        {
            get { return menuStrip1; }
        }

        #endregion
    }
}
