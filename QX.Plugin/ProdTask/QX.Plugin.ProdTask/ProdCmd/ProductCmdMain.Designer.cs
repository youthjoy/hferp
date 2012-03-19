namespace QX.Plugin.Cmd
{
    partial class ProductCmdMain
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
            this.tabControl1.SuspendLayout();
            this.ProductList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.ProductList);
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
            this.ProductList.Text = "生产指令列表";
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
            // ProductCmdMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 410);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductCmdMain";
            this.Text = "生产指令列表";
            this.tabControl1.ResumeLayout(false);
            this.ProductList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProductList;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar top_tool_0;
        private System.Windows.Forms.Panel panel2;
    }
}