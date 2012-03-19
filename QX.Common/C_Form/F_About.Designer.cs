namespace QX.Common.C_Form
{
    partial class F_About
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ll_CloseWindow = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(95, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "版权所有◎2005  用友软件";
            // 
            // ll_CloseWindow
            // 
            this.ll_CloseWindow.AutoSize = true;
            this.ll_CloseWindow.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ll_CloseWindow.Location = new System.Drawing.Point(292, 159);
            this.ll_CloseWindow.Name = "ll_CloseWindow";
            this.ll_CloseWindow.Size = new System.Drawing.Size(53, 12);
            this.ll_CloseWindow.TabIndex = 3;
            this.ll_CloseWindow.TabStop = true;
            this.ll_CloseWindow.Text = "关闭窗口";
            this.ll_CloseWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_CloseWindow_LinkClicked);
            // 
            // F_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 216);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ll_CloseWindow);
            this.Name = "F_About";
            this.Text = "F_About";
            this.Load += new System.EventHandler(this.F_About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ll_CloseWindow;
    }
}