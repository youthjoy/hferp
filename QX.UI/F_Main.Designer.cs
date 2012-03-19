namespace QX.UI
{
    partial class F_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_panel = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // button_panel
            // 
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_panel.Location = new System.Drawing.Point(0, 437);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(724, 26);
            this.button_panel.TabIndex = 16;
            // 
            // left_panel
            // 
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 59);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(180, 378);
            this.left_panel.TabIndex = 17;
            this.left_panel.Text = "ultraPanel2";
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.menuStrip1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(724, 59);
            this.top_panel.TabIndex = 0;
            this.top_panel.TabStop = true;
            this.top_panel.Text = "ultraPanel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // pbSwitch
            // 
            this.pbSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSwitch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbSwitch.Image = global::QX.UI.Properties.Resources.r;
            this.pbSwitch.Location = new System.Drawing.Point(180, 59);
            this.pbSwitch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(6, 378);
            this.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSwitch.TabIndex = 20;
            this.pbSwitch.TabStop = false;
            this.pbSwitch.MouseLeave += new System.EventHandler(this.pbSwitch_MouseLeave);
            this.pbSwitch.Click += new System.EventHandler(this.pbSwitch_Click_1);
            this.pbSwitch.MouseEnter += new System.EventHandler(this.pbSwitch_MouseEnter);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(724, 463);
            this.Controls.Add(this.pbSwitch);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.button_panel);
            this.Controls.Add(this.top_panel);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重庆市江津区禾丰机械有限公司ERP管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbSwitch;
    }
}
