namespace QX.Common.C_Form
{
    partial class SystemHelp
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
            this.uteSystemInfomation = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.uteSystemInfomation)).BeginInit();
            this.SuspendLayout();
            // 
            // uteSystemInfomation
            // 
            this.uteSystemInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uteSystemInfomation.Location = new System.Drawing.Point(0, 0);
            this.uteSystemInfomation.Multiline = true;
            this.uteSystemInfomation.Name = "uteSystemInfomation";
            this.uteSystemInfomation.Size = new System.Drawing.Size(486, 418);
            this.uteSystemInfomation.TabIndex = 0;
            // 
            // SystemHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 418);
            this.Controls.Add(this.uteSystemInfomation);
            this.Name = "SystemHelp";
            this.Text = "SystemHelp";
            ((System.ComponentModel.ISupportInitialize)(this.uteSystemInfomation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor uteSystemInfomation;
    }
}