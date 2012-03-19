namespace QX.Plugin.DeptManage
{
    partial class DeptInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tv_left = new System.Windows.Forms.TreeView();
            this.panel_ltop = new System.Windows.Forms.Panel();
            this.tool_left = new QX.Common.C_Form.CommonToolBar();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_rtop = new System.Windows.Forms.Panel();
            this.tool_right = new QX.Common.C_Form.CommonToolBar();
            this.panel1.SuspendLayout();
            this.panel_ltop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_rtop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tv_left);
            this.panel1.Controls.Add(this.panel_ltop);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 456);
            this.panel1.TabIndex = 0;
            // 
            // tv_left
            // 
            this.tv_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_left.Location = new System.Drawing.Point(0, 38);
            this.tv_left.Name = "tv_left";
            this.tv_left.Size = new System.Drawing.Size(191, 418);
            this.tv_left.TabIndex = 5;
            this.tv_left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tv_left_MouseClick);
            this.tv_left.DoubleClick += new System.EventHandler(this.tv_left_DoubleClick);
            // 
            // panel_ltop
            // 
            this.panel_ltop.Controls.Add(this.tool_left);
            this.panel_ltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ltop.Location = new System.Drawing.Point(0, 0);
            this.panel_ltop.Name = "panel_ltop";
            this.panel_ltop.Size = new System.Drawing.Size(191, 40);
            this.panel_ltop.TabIndex = 4;
            // 
            // tool_left
            // 
            this.tool_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tool_left.Location = new System.Drawing.Point(0, 0);
            this.tool_left.Name = "tool_left";
            this.tool_left.Size = new System.Drawing.Size(191, 40);
            this.tool_left.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 456);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel_rtop);
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 456);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(0, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 418);
            this.panel5.TabIndex = 2;
            // 
            // panel_rtop
            // 
            this.panel_rtop.Controls.Add(this.tool_right);
            this.panel_rtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_rtop.Location = new System.Drawing.Point(0, 0);
            this.panel_rtop.Name = "panel_rtop";
            this.panel_rtop.Size = new System.Drawing.Size(585, 32);
            this.panel_rtop.TabIndex = 1;
            // 
            // tool_right
            // 
            this.tool_right.Location = new System.Drawing.Point(0, 0);
            this.tool_right.Name = "tool_right";
            this.tool_right.Size = new System.Drawing.Size(585, 40);
            this.tool_right.TabIndex = 0;
            // 
            // DeptInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "DeptInfo";
            this.Text = "部门人员维护";
            this.Load += new System.EventHandler(this.DeptInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel_ltop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_rtop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tv_left;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_rtop;
        private System.Windows.Forms.Panel panel_ltop;
        private QX.Common.C_Form.CommonToolBar tool_left;
        private QX.Common.C_Form.CommonToolBar tool_right;



    }
}