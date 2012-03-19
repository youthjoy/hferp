using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QX.Plugin.Prod
{
    public partial class TimeControl : Form
    {
        public TimeControl(string key)
        {
            InitializeComponent();
            Key = key;
            this.Width = 200;
            this.Height = 80;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            this.ultraDateTimeEditor1.BackColor = System.Drawing.SystemColors.Window;
            ultraDateTimeEditor1.MaskInput = "yyyy-mm-dd hh:mm";
            ultraDateTimeEditor1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            ultraDateTimeEditor1.Value = DateTime.Now;
            ultraDateTimeEditor1.PromptChar = ' ';
            ultraDateTimeEditor1.Nullable = true;
            ultraDateTimeEditor1.NullText = DateTime.Now.ToString();
        }

        public TimeControl(string key,string value)
        {
            InitializeComponent();
            Key = key;
            Time = value;
            this.Width = 200;
            this.Height = 80;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            this.ultraDateTimeEditor1.BackColor = System.Drawing.SystemColors.Window;
            ultraDateTimeEditor1.MaskInput = "yyyy-mm-dd hh:mm";
            ultraDateTimeEditor1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.OnMouseEnter;
            if (string.IsNullOrEmpty(Time))
            {
                ultraDateTimeEditor1.Value = DateTime.Now;
            }
            else
            {
                try
                {
                    ultraDateTimeEditor1.Value = DateTime.Parse(Time);
                }
                catch
                {
                    ultraDateTimeEditor1.Value = DateTime.Now;
                }
            }
            ultraDateTimeEditor1.PromptChar = ' ';
            ultraDateTimeEditor1.Nullable = true;
            ultraDateTimeEditor1.NullText = DateTime.Now.ToString();
        }

        public void ShowWin(int x, int y)
        {
            this.Location = new Point(x, y);

            int xpos = this.Location.X;
            int ypos = this.Location.Y;

            if (this.Location.X + 200 >= Screen.PrimaryScreen.Bounds.Width)
            {
                var tmp = this.Location;
                xpos = this.Location.X - 200;
            }

            if (this.Location.Y + 200 >= Screen.PrimaryScreen.Bounds.Height)
            {
                ypos = this.Location.Y - 200;
            }

            this.Location = new Point(xpos, ypos);

            this.Show();
        }

        private string Key
        {
            get;
            set;
        }

        private string Time
        {
            get;
            set;
        }

        public delegate void DCallBackHandler(string result, object val);

        public event DCallBackHandler CallBack;

        private void btnOK_Click(object sender, EventArgs e)
        {
            var val = this.ultraDateTimeEditor1.Value;
            if (CallBack != null)
            {
                CallBack(Key, val);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CallBack != null)
            {
                CallBack(Key, "0001-1-1");
            }
            this.Close();
            
        }

    }
}
