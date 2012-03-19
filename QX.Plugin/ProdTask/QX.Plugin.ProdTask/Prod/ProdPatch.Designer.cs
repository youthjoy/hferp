namespace QX.Plugin.Prod
{
    partial class ProdPatch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // top_tool
            // 
            this.top_tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_tool.Location = new System.Drawing.Point(0, 0);
            this.top_tool.Name = "top_tool";
            this.top_tool.Size = new System.Drawing.Size(792, 40);
            this.top_tool.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 428);
            this.panel1.TabIndex = 1;
            // 
            // ProdPatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top_tool);
            this.Name = "ProdPatch";
            this.Text = "组合配对功能";
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar top_tool;
        private System.Windows.Forms.Panel panel1;
    }
}