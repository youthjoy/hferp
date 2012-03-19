namespace QX.Plugin.LeftMenu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
            this.Sys_LMenu = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            ((System.ComponentModel.ISupportInitialize)(this.Sys_LMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Sys_LMenu
            // 
            ultraExplorerBarGroup1.Text = "New Group";
            ultraExplorerBarItem1.Text = "New Item";
            ultraExplorerBarItem2.Text = "New Item";
            ultraExplorerBarGroup2.Items.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem[] {
            ultraExplorerBarItem1,
            ultraExplorerBarItem2});
            ultraExplorerBarGroup2.Text = "New Group";
            this.Sys_LMenu.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.Sys_LMenu.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImages;
            this.Sys_LMenu.ItemSettings.Style = Infragistics.Win.UltraWinExplorerBar.ItemStyle.Label;
            this.Sys_LMenu.Location = new System.Drawing.Point(21, 26);
            this.Sys_LMenu.Name = "Sys_LMenu";
            this.Sys_LMenu.SaveSettings = true;
            this.Sys_LMenu.SettingsKey = "Form1.Sys_LMenu";
            this.Sys_LMenu.Size = new System.Drawing.Size(175, 230);
            this.Sys_LMenu.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.OutlookNavigationPane;
            this.Sys_LMenu.TabIndex = 0;
            this.Sys_LMenu.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.Office2007;
            this.Sys_LMenu.ItemDoubleClick += new Infragistics.Win.UltraWinExplorerBar.ItemDoubleClickEventHandler(this.Sys_LMenu_ItemDoubleClick);
            this.Sys_LMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Sys_LMenu_MouseDoubleClick);
            this.Sys_LMenu.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 320);
            this.Controls.Add(this.Sys_LMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.Configuration.IPersistComponentSettings)(this.Sys_LMenu)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.Sys_LMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar Sys_LMenu;
    }
}