namespace QX.Plugin.BaseModule.Permission
{
    partial class PermissionMain
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
            this.tbGrid = new QX.Common.C_Form.CommonToolBar();
            this.tabPer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpSys = new System.Windows.Forms.GroupBox();
            this.pnlPerm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGrid
            // 
            this.tbGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGrid.Location = new System.Drawing.Point(0, 0);
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.Size = new System.Drawing.Size(899, 40);
            this.tbGrid.TabIndex = 0;
            // 
            // tabPer
            // 
            this.tabPer.Controls.Add(this.tabPage1);
            this.tabPer.Controls.Add(this.tabPage2);
            this.tabPer.Location = new System.Drawing.Point(1, 42);
            this.tabPer.Name = "tabPer";
            this.tabPer.SelectedIndex = 0;
            this.tabPer.Size = new System.Drawing.Size(899, 447);
            this.tabPer.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpSys);
            this.tabPage1.Controls.Add(this.pnlPerm);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "菜单权限";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "功能权限";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gpSys
            // 
            this.gpSys.Location = new System.Drawing.Point(4, 6);
            this.gpSys.Name = "gpSys";
            this.gpSys.Size = new System.Drawing.Size(884, 62);
            this.gpSys.TabIndex = 4;
            this.gpSys.TabStop = false;
            this.gpSys.Text = "系统用户信息";
            // 
            // pnlPerm
            // 
            this.pnlPerm.Location = new System.Drawing.Point(2, 71);
            this.pnlPerm.Name = "pnlPerm";
            this.pnlPerm.Size = new System.Drawing.Size(891, 354);
            this.pnlPerm.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 415);
            this.panel1.TabIndex = 0;
            // 
            // PermissionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 491);
            this.Controls.Add(this.tabPer);
            this.Controls.Add(this.tbGrid);
            this.Name = "PermissionMain";
            this.Text = "权限管理";
            this.Load += new System.EventHandler(this.PermissionMain_Load);
            this.tabPer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar tbGrid;
        private System.Windows.Forms.TabControl tabPer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpSys;
        private System.Windows.Forms.Panel pnlPerm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
    }
}