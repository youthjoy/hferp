namespace QX.Plugin.Contract
{
    partial class CustomersManage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tool_top = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 444);
            this.panel2.TabIndex = 1;
            // 
            // tool_top
            // 
            this.tool_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_top.Location = new System.Drawing.Point(0, 0);
            this.tool_top.Name = "tool_top";
            this.tool_top.Size = new System.Drawing.Size(848, 47);
            this.tool_top.TabIndex = 2;
            // 
            // CustomersManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 498);
            this.Controls.Add(this.tool_top);
            this.Controls.Add(this.panel2);
            this.Name = "CustomersManage";
            this.Text = "客户维护";
            this.Load += new System.EventHandler(this.CustomersManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private QX.Common.C_Form.CommonToolBar tool_top;
    }
}