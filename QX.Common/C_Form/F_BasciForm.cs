using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QX.Common.C_Form
{
    public partial class F_BasciForm : F_Basic
    {
        public F_BasciForm()
        {
            InitializeComponent();
        }

        private void F_BasciForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
