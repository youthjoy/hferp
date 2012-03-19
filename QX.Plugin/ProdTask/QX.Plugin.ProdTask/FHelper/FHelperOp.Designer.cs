namespace QX.Plugin.Prod.FHelper
{
    partial class FHelperOp
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
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.gpMain = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.commonToolBar1.Location = new System.Drawing.Point(0, -2);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(549, 40);
            this.commonToolBar1.TabIndex = 0;
            // 
            // gpMain
            // 
            this.gpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpMain.Location = new System.Drawing.Point(7, 44);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(537, 449);
            this.gpMain.TabIndex = 1;
            this.gpMain.TabStop = false;
            this.gpMain.Text = "基本信息";
            // 
            // FHelperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 496);
            this.Controls.Add(this.gpMain);
            this.Controls.Add(this.commonToolBar1);
            this.Name = "FHelperAdmin";
            this.Text = "FHelperAdmin";
            this.Load += new System.EventHandler(this.FHelperAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar commonToolBar1;
        private System.Windows.Forms.GroupBox gpMain;
    }
}