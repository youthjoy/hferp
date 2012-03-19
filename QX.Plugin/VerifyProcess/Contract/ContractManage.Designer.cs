namespace QX.Plugin.Contract
{
    partial class ContractManage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlList = new System.Windows.Forms.Panel();
            this.tool_top = new QX.Common.C_Form.CommonToolBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlAudit = new System.Windows.Forms.Panel();
            this.tbAudit = new QX.Common.C_Form.CommonToolBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlLast = new System.Windows.Forms.Panel();
            this.tbLast = new QX.Common.C_Form.CommonToolBar();
            
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 482);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 482);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlList);
            this.tabPage1.Controls.Add(this.tool_top);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "合同列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Location = new System.Drawing.Point(3, 41);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(755, 413);
            this.pnlList.TabIndex = 2;
            // 
            // tool_top
            // 
            this.tool_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_top.Location = new System.Drawing.Point(3, 3);
            this.tool_top.Name = "tool_top";
            this.tool_top.Size = new System.Drawing.Size(755, 40);
            this.tool_top.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlAudit);
            this.tabPage2.Controls.Add(this.tbAudit);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "待审合同";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlAudit
            // 
            this.pnlAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAudit.Location = new System.Drawing.Point(3, 51);
            this.pnlAudit.Name = "pnlAudit";
            this.pnlAudit.Size = new System.Drawing.Size(755, 403);
            this.pnlAudit.TabIndex = 4;
            // 
            // tbAudit
            // 
            this.tbAudit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAudit.Location = new System.Drawing.Point(3, 3);
            this.tbAudit.Name = "tbAudit";
            this.tbAudit.Size = new System.Drawing.Size(755, 47);
            this.tbAudit.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlLast);
            this.tabPage3.Controls.Add(this.tbLast);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "终审合同列表";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlLast
            // 
            this.pnlLast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLast.Location = new System.Drawing.Point(3, 37);
            this.pnlLast.Name = "pnlLast";
            this.pnlLast.Size = new System.Drawing.Size(758, 417);
            this.pnlLast.TabIndex = 1;
            // 
            // tbLast
            // 
            this.tbLast.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLast.Location = new System.Drawing.Point(0, 0);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(761, 40);
            this.tbLast.TabIndex = 0;
            // 
            // ContractManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ContractManage";
            this.Text = "合同档案维护";
            this.Load += new System.EventHandler(this.ContractManage_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlList;
        private QX.Common.C_Form.CommonToolBar tool_top;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlAudit;
        private QX.Common.C_Form.CommonToolBar tbAudit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlLast;
        private QX.Common.C_Form.CommonToolBar tbLast;
        


    }
}