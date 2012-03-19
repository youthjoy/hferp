using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QX.Common.C_Form
{
    public partial class F_BasicPop : F_Basic
    {
        public bool isAudit = false;
        public F_BasicPop()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += new FormClosingEventHandler(F_BasicPop_FormClosing);

            if (this.Width > Screen.PrimaryScreen.Bounds.Width)
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width;
            }


            if (this.Height > Screen.PrimaryScreen.Bounds.Height)
            {
                this.Height = Screen.PrimaryScreen.Bounds.Height;
            }
        }

        void F_BasicPop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAudit == false)
            {
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
