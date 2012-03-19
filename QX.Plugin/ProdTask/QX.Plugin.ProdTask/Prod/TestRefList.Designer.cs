namespace QX.Plugin.Prod
{
    partial class TestRefList
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
            this.tpTest = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_tool_0 = new QX.Common.C_Form.CommonToolBar();
            this.tabControl1.SuspendLayout();
            this.tpTest.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tpTest);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 568);
            this.tabControl1.TabIndex = 1;
            // 
            // tpTest
            // 
            this.tpTest.Controls.Add(this.panel2);
            this.tpTest.Controls.Add(this.panel1);
            this.tpTest.Location = new System.Drawing.Point(4, 24);
            this.tpTest.Name = "tpTest";
            this.tpTest.Padding = new System.Windows.Forms.Padding(3);
            this.tpTest.Size = new System.Drawing.Size(786, 540);
            this.tpTest.TabIndex = 0;
            this.tpTest.Text = "检测结果列表";
            this.tpTest.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 487);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.top_tool_0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 47);
            this.panel1.TabIndex = 0;
            // 
            // top_tool_0
            // 
            this.top_tool_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_tool_0.Location = new System.Drawing.Point(0, 0);
            this.top_tool_0.Name = "top_tool_0";
            this.top_tool_0.Size = new System.Drawing.Size(780, 47);
            this.top_tool_0.TabIndex = 0;
            // 
            // TestRefList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestRefList";
            this.Text = "检测结果列表";
            this.tabControl1.ResumeLayout(false);
            this.tpTest.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar top_tool_0;
    }
}