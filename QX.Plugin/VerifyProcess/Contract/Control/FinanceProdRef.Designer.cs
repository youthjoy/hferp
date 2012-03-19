namespace QX.Plugin.Contract.ComControl
{
    partial class FinanceProdRef
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
            this.tool_bar = new QX.Common.C_Form.CommonToolBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_left = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tool_bar
            // 
            this.tool_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_bar.Location = new System.Drawing.Point(0, 0);
            this.tool_bar.Name = "tool_bar";
            this.tool_bar.Size = new System.Drawing.Size(784, 40);
            this.tool_bar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 243);
            this.panel1.TabIndex = 1;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(20, 292);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(102, 23);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "确定选择";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(429, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 243);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Location = new System.Drawing.Point(0, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 243);
            this.panel3.TabIndex = 2;
            // 
            // FinanceProdRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool_bar);
            this.Name = "FinanceProdRef";
            this.Text = "产值关联";
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar tool_bar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}