namespace QX.Plugin.DeptManage
{
    partial class EmployeeExt
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
            this.tabBse = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.top_tool_0 = new QX.Common.C_Form.CommonToolBar();
            this.tabBse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBse
            // 
            this.tabBse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBse.Controls.Add(this.tabPage1);
            this.tabBse.Location = new System.Drawing.Point(0, 42);
            this.tabBse.Name = "tabBse";
            this.tabBse.SelectedIndex = 0;
            this.tabBse.Size = new System.Drawing.Size(792, 524);
            this.tabBse.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // top_tool_0
            // 
            this.top_tool_0.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_tool_0.Location = new System.Drawing.Point(0, 0);
            this.top_tool_0.Name = "top_tool_0";
            this.top_tool_0.Size = new System.Drawing.Size(792, 40);
            this.top_tool_0.TabIndex = 3;
            // 
            // EmployeeExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.top_tool_0);
            this.Controls.Add(this.tabBse);
            this.Name = "EmployeeExt";
            this.Text = "员工基本信息登记";
            this.tabBse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBse;
        private System.Windows.Forms.TabPage tabPage1;
        private QX.Common.C_Form.CommonToolBar top_tool_0;
    }
}