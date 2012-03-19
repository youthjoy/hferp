namespace QX.Plugin.Prod
{
    partial class FailureMain
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
            this.pInv = new System.Windows.Forms.Panel();
            this.tbFAudit = new QX.Common.C_Form.CommonToolBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pInList = new System.Windows.Forms.Panel();
            this.tbList = new QX.Common.C_Form.CommonToolBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 524);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pInv);
            this.tabPage1.Controls.Add(this.tbFAudit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "待审核列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pInv
            // 
            this.pInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pInv.Location = new System.Drawing.Point(0, 45);
            this.pInv.Name = "pInv";
            this.pInv.Size = new System.Drawing.Size(808, 447);
            this.pInv.TabIndex = 1;
            // 
            // tbFAudit
            // 
            this.tbFAudit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFAudit.Location = new System.Drawing.Point(3, 3);
            this.tbFAudit.Name = "tbFAudit";
            this.tbFAudit.Size = new System.Drawing.Size(805, 40);
            this.tbFAudit.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pInList);
            this.tabPage2.Controls.Add(this.tbList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "不合格品列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pInList
            // 
            this.pInList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pInList.Location = new System.Drawing.Point(1, 42);
            this.pInList.Name = "pInList";
            this.pInList.Size = new System.Drawing.Size(808, 447);
            this.pInList.TabIndex = 2;
            // 
            // tbList
            // 
            this.tbList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbList.Location = new System.Drawing.Point(1, 3);
            this.tbList.Name = "tbList";
            this.tbList.Size = new System.Drawing.Size(808, 40);
            this.tbList.TabIndex = 0;
            // 
            // FailureMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 524);
            this.Controls.Add(this.tabControl1);
            this.Name = "FailureMain";
            this.Text = "FailureMain";
            this.Load += new System.EventHandler(this.FailureMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pInv;
        private QX.Common.C_Form.CommonToolBar tbFAudit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pInList;
        private QX.Common.C_Form.CommonToolBar tbList;
    }
}