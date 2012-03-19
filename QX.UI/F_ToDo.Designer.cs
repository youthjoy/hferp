namespace QX.UI
{
    partial class F_ToDo
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
            this.top_tool = new QX.Common.C_Form.CommonToolBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAudit = new System.Windows.Forms.Panel();
            this.gpProd = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProd = new System.Windows.Forms.Panel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_tool
            // 
            this.top_tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_tool.Location = new System.Drawing.Point(0, 0);
            this.top_tool.Name = "top_tool";
            this.top_tool.Size = new System.Drawing.Size(970, 40);
            this.top_tool.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlAudit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpProd);
            this.splitContainer1.Size = new System.Drawing.Size(970, 370);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnlAudit
            // 
            this.pnlAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAudit.Location = new System.Drawing.Point(0, 0);
            this.pnlAudit.Name = "pnlAudit";
            this.pnlAudit.Size = new System.Drawing.Size(970, 164);
            this.pnlAudit.TabIndex = 5;
            // 
            // gpProd
            // 
            this.gpProd.Controls.Add(this.panel3);
            this.gpProd.Controls.Add(this.panel2);
            this.gpProd.Controls.Add(this.panel1);
            this.gpProd.Controls.Add(this.pnlProd);
            this.gpProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpProd.Location = new System.Drawing.Point(0, 0);
            this.gpProd.Name = "gpProd";
            this.gpProd.Size = new System.Drawing.Size(970, 202);
            this.gpProd.TabIndex = 5;
            this.gpProd.TabStop = false;
            this.gpProd.Text = "当前生产情况";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(768, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 187);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Location = new System.Drawing.Point(512, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 187);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(256, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 187);
            this.panel1.TabIndex = 0;
            // 
            // pnlProd
            // 
            this.pnlProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProd.Location = new System.Drawing.Point(0, 15);
            this.pnlProd.Name = "pnlProd";
            this.pnlProd.Size = new System.Drawing.Size(250, 187);
            this.pnlProd.TabIndex = 0;
            // 
            // F_ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 410);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.top_tool);
            this.Name = "F_ToDo";
            this.Text = "生产情况汇总";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gpProd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar top_tool;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAudit;
        private System.Windows.Forms.GroupBox gpProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProd;
    }
}