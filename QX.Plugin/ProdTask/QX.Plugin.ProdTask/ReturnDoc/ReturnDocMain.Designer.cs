namespace QX.Plugin.ReturnDoc
{
    partial class ReturnDocMain
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
            this.ProductList = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_tool_0 = new QX.Common.C_Form.CommonToolBar();
            this.ProductIssueList = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.top_tool_1 = new QX.Common.C_Form.CommonToolBar();
            this.ProductIssuedList = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.ProductList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ProductIssueList.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ProductIssuedList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.ProductList);
            this.tabControl1.Controls.Add(this.ProductIssueList);
            this.tabControl1.Controls.Add(this.ProductIssuedList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductList
            // 
            this.ProductList.Controls.Add(this.panel2);
            this.ProductList.Controls.Add(this.panel1);
            this.ProductList.Location = new System.Drawing.Point(4, 24);
            this.ProductList.Name = "ProductList";
            this.ProductList.Padding = new System.Windows.Forms.Padding(3);
            this.ProductList.Size = new System.Drawing.Size(708, 382);
            this.ProductList.TabIndex = 0;
            this.ProductList.Text = "我的退货单";
            this.ProductList.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 329);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.top_tool_0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 47);
            this.panel1.TabIndex = 0;
            // 
            // top_tool_0
            // 
            this.top_tool_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_tool_0.Location = new System.Drawing.Point(0, 0);
            this.top_tool_0.Name = "top_tool_0";
            this.top_tool_0.Size = new System.Drawing.Size(702, 47);
            this.top_tool_0.TabIndex = 0;
            // 
            // ProductIssueList
            // 
            this.ProductIssueList.Controls.Add(this.panel4);
            this.ProductIssueList.Controls.Add(this.panel3);
            this.ProductIssueList.Location = new System.Drawing.Point(4, 24);
            this.ProductIssueList.Name = "ProductIssueList";
            this.ProductIssueList.Padding = new System.Windows.Forms.Padding(3);
            this.ProductIssueList.Size = new System.Drawing.Size(708, 382);
            this.ProductIssueList.TabIndex = 1;
            this.ProductIssueList.Text = "待审核的退货单";
            this.ProductIssueList.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 329);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.top_tool_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 47);
            this.panel3.TabIndex = 0;
            // 
            // top_tool_1
            // 
            this.top_tool_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_tool_1.Location = new System.Drawing.Point(0, 0);
            this.top_tool_1.Name = "top_tool_1";
            this.top_tool_1.Size = new System.Drawing.Size(702, 47);
            this.top_tool_1.TabIndex = 0;
            // 
            // ProductIssuedList
            // 
            this.ProductIssuedList.Controls.Add(this.panel5);
            this.ProductIssuedList.Location = new System.Drawing.Point(4, 24);
            this.ProductIssuedList.Name = "ProductIssuedList";
            this.ProductIssuedList.Size = new System.Drawing.Size(708, 382);
            this.ProductIssuedList.TabIndex = 2;
            this.ProductIssuedList.Text = "已审核的退货单";
            this.ProductIssuedList.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 382);
            this.panel5.TabIndex = 3;
            // 
            // ReturnDocMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 410);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReturnDocMain";
            this.Text = "退货管理";
            this.tabControl1.ResumeLayout(false);
            this.ProductList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ProductIssueList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ProductIssuedList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProductList;
        private System.Windows.Forms.TabPage ProductIssueList;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar top_tool_0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private QX.Common.C_Form.CommonToolBar top_tool_1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage ProductIssuedList;
        private System.Windows.Forms.Panel panel5;
    }
}