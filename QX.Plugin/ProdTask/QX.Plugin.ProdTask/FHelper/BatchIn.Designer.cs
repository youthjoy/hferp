namespace QX.Plugin.Prod.FHelper
{
    partial class BatchIn
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gpMain = new System.Windows.Forms.GroupBox();
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Location = new System.Drawing.Point(8, 47);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(531, 142);
            this.pnlGrid.TabIndex = 7;
            // 
            // gpMain
            // 
            this.gpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpMain.Location = new System.Drawing.Point(8, 195);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(537, 334);
            this.gpMain.TabIndex = 6;
            this.gpMain.TabStop = false;
            this.gpMain.Text = "基本信息";
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.commonToolBar1.Location = new System.Drawing.Point(1, 1);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(549, 40);
            this.commonToolBar1.TabIndex = 5;
            // 
            // BatchIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 529);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.gpMain);
            this.Controls.Add(this.commonToolBar1);
            this.Name = "BatchIn";
            this.Text = "批量回厂确认";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.GroupBox gpMain;
        private QX.Common.C_Form.CommonToolBar commonToolBar1;
    }
}