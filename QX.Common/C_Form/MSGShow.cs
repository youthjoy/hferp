using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QX.Common.C_Form
{
    public partial class MSGShow : Form
    {
        public MSGShow()
        {
            InitializeComponent();
        }

        public MSGShow(string msg)
        {
            InitializeComponent();
            this.lblMsg.Text = msg;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
