using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QX.Common.C_Form
{
    public partial class F_About : Form
    {
        public F_About()
        {
            InitializeComponent();
        }

        private void F_About_Load(object sender, EventArgs e)
        {
            label2.Text = "欢迎使用江津禾丰机械有限公司信息管理系统";
            label1.Text = "版权所有 @ 群信信息";
        }

        private void ll_CloseWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
