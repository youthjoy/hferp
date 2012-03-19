namespace QX.Plugin.RoadCateManage
{
    partial class RoadComptInfo
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
            this.gpCompt = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.commonToolBar2 = new QX.Common.C_Form.CommonToolBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCompt
            // 
            this.gpCompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCompt.Location = new System.Drawing.Point(4, 46);
            this.gpCompt.Name = "gpCompt";
            this.gpCompt.Size = new System.Drawing.Size(982, 116);
            this.gpCompt.TabIndex = 8;
            this.gpCompt.TabStop = false;
            this.gpCompt.Text = "零件图号信息维护";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pnlGrid);
            this.panel1.Controls.Add(this.commonToolBar1);
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 446);
            this.panel1.TabIndex = 9;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.Location = new System.Drawing.Point(2, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(967, 406);
            this.pnlGrid.TabIndex = 2;
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar1.Location = new System.Drawing.Point(0, 0);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(970, 40);
            this.commonToolBar1.TabIndex = 1;
            // 
            // commonToolBar2
            // 
            this.commonToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar2.Location = new System.Drawing.Point(0, 0);
            this.commonToolBar2.Name = "commonToolBar2";
            this.commonToolBar2.Size = new System.Drawing.Size(994, 40);
            this.commonToolBar2.TabIndex = 10;
            // 
            // RoadComptInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 619);
            this.Controls.Add(this.commonToolBar2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpCompt);
            this.Name = "RoadComptInfo";
            this.Text = "零件图号维护";
            this.Load += new System.EventHandler(this.RoadComptInfo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCompt;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar commonToolBar1;
        private QX.Common.C_Form.CommonToolBar commonToolBar2;
        private System.Windows.Forms.Panel pnlGrid;
    }
}