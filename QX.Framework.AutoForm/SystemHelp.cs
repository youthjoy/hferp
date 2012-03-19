using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.DataModel;

namespace QX.Framework.AutoForm
{
    public partial class SystemHelp : Form
    {
        Control ctr, ctrParent;
        public SystemHelp()
        {
            InitializeComponent();
        }

        public StringBuilder sInfomation = new StringBuilder();

        public SystemHelp(Control _ctr,Control _ctrParent)
        {
            ctr = _ctr;
            InitializeComponent();
           
            sInfomation.Append("Form Title:" + ctr.FindForm().Text);
            sInfomation.Append("Form Name:" + ctr.FindForm().Name);
            Sys_PD_Module module = _ctrParent.Tag as Sys_PD_Module;
            if (module != null)
            {
                sInfomation.Append("Module Title:" + module.SPM_Name);
                sInfomation.Append("Module Code:" + module.SPM_Module);
            }

        }
        public SystemHelp(Control _ctr)
        {
            ctr = _ctr;
            sInfomation.Append("Form Title:" + ctr.FindForm().Text);
            sInfomation.Append("Form Name:" + ctr.FindForm().Name);
            Sys_PD_Module module = ctr.Tag as Sys_PD_Module;
            if (module != null)
            {
                sInfomation.Append("Module Title:" + module.SPM_Name);
                sInfomation.Append("Module Code:" + module.SPM_Module);
            }
            this.uteSystemInformation.Text = sInfomation.ToString();
        }
        private void SystemHelp_Load(object sender, EventArgs e)
        {
            this.uteSystemInformation.Text = sInfomation.ToString();
        }
    }
}
