namespace QX.Plugin.InvInfo
{
    partial class StockIn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tool_bar_GInv = new QX.Common.C_Form.CommonToolBar();
            this.gbGrid = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tool_bar_GInv);
            this.tabPage1.Controls.Add(this.gbGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "待入库列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tool_bar_GInv
            // 
            this.tool_bar_GInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_bar_GInv.Location = new System.Drawing.Point(3, 3);
            this.tool_bar_GInv.Name = "tool_bar_GInv";
            this.tool_bar_GInv.Size = new System.Drawing.Size(674, 40);
            this.tool_bar_GInv.TabIndex = 1;
            // 
            // gbGrid
            // 
            this.gbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGrid.Location = new System.Drawing.Point(0, 44);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(677, 368);
            this.gbGrid.TabIndex = 0;
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "StockIn";
            this.Text = "零件产品入库";
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private QX.Common.C_Form.CommonToolBar tool_bar_GInv;
        private System.Windows.Forms.Panel gbGrid;
    }
}