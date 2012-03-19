namespace QX.Plugin.Prod.Report
{
    partial class CommPRoads
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
            this.tbGrid = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Location = new System.Drawing.Point(2, 44);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(671, 297);
            this.pnlGrid.TabIndex = 15;
            // 
            // tbGrid
            // 
            this.tbGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGrid.Location = new System.Drawing.Point(0, 0);
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.Size = new System.Drawing.Size(676, 40);
            this.tbGrid.TabIndex = 14;
            // 
            // CommPRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 342);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.tbGrid);
            this.Name = "CommPRoads";
            this.Text = "CommPRoads";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private QX.Common.C_Form.CommonToolBar tbGrid;
    }
}