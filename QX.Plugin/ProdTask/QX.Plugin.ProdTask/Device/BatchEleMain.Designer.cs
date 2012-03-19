namespace QX.Plugin.DeviceManage
{
    partial class BatchEleMain
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
            this.gpMain = new System.Windows.Forms.GroupBox();
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gpMain
            // 
            this.gpMain.Location = new System.Drawing.Point(12, 187);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(694, 244);
            this.gpMain.TabIndex = 3;
            this.gpMain.TabStop = false;
            this.gpMain.Text = "故障信息";
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar1.Location = new System.Drawing.Point(0, 0);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(718, 40);
            this.commonToolBar1.TabIndex = 2;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Location = new System.Drawing.Point(12, 46);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(694, 135);
            this.pnlGrid.TabIndex = 4;
            // 
            // BatchEleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 432);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.gpMain);
            this.Controls.Add(this.commonToolBar1);
            this.Name = "BatchEleMain";
            this.Text = "BatchEleMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMain;
        private QX.Common.C_Form.CommonToolBar commonToolBar1;
        private System.Windows.Forms.Panel pnlGrid;
    }
}