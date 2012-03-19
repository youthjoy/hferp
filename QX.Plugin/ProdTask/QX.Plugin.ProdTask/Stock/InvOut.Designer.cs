namespace QX.Plugin.InvInfo
{
    partial class InvOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbOut = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 278);
            this.panel1.TabIndex = 6;
            // 
            // tbOut
            // 
            this.tbOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOut.Location = new System.Drawing.Point(0, 0);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(930, 40);
            this.tbOut.TabIndex = 7;
            // 
            // InvOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 460);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "InvOut";
            this.Text = "出库单据信息";
            this.Load += new System.EventHandler(this.InvOut_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar tbOut;
    }
}