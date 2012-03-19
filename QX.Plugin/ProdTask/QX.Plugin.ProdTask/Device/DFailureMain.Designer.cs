namespace QX.Plugin.DeviceManage
{
    partial class DFailureMain
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.tbGrid = new QX.Common.C_Form.CommonToolBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlHis = new System.Windows.Forms.Panel();
            this.tbHis = new QX.Common.C_Form.CommonToolBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlList);
            this.tabPage1.Controls.Add(this.tbGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "停机记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Location = new System.Drawing.Point(-4, 42);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(680, 299);
            this.pnlList.TabIndex = 3;
            // 
            // tbGrid
            // 
            this.tbGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGrid.Location = new System.Drawing.Point(3, 3);
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.Size = new System.Drawing.Size(666, 40);
            this.tbGrid.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlHis);
            this.tabPage2.Controls.Add(this.tbHis);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "历史记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlHis
            // 
            this.pnlHis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHis.Location = new System.Drawing.Point(3, 44);
            this.pnlHis.Name = "pnlHis";
            this.pnlHis.Size = new System.Drawing.Size(666, 284);
            this.pnlHis.TabIndex = 1;
            // 
            // tbHis
            // 
            this.tbHis.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHis.Location = new System.Drawing.Point(3, 3);
            this.tbHis.Name = "tbHis";
            this.tbHis.Size = new System.Drawing.Size(666, 40);
            this.tbHis.TabIndex = 0;
            // 
            // DFailureMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 356);
            this.Controls.Add(this.tabControl1);
            this.Name = "DFailureMain";
            this.Text = "DFailureMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlList;
        private QX.Common.C_Form.CommonToolBar tbGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlHis;
        private QX.Common.C_Form.CommonToolBar tbHis;

    }
}