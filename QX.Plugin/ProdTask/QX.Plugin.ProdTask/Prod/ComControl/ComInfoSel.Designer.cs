namespace QX.Plugin.Prod.ComControl
{
    partial class ComInfoSel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tool_bar = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 522);
            this.panel1.TabIndex = 5;
            // 
            // tool_bar
            // 
            this.tool_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_bar.Location = new System.Drawing.Point(0, 0);
            this.tool_bar.Name = "tool_bar";
            this.tool_bar.Size = new System.Drawing.Size(784, 40);
            this.tool_bar.TabIndex = 4;
            // 
            // ComInfoSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool_bar);
            this.Name = "ComInfoSel";
            this.Text = "ComInfoSel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar tool_bar;
    }
}