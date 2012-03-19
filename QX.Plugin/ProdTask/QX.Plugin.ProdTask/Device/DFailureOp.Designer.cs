namespace QX.Plugin.DeviceManage
{
    partial class DFailureOp
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
            this.tbDF = new QX.Common.C_Form.CommonToolBar();
            this.gpBse = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tbDF
            // 
            this.tbDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDF.Location = new System.Drawing.Point(0, 0);
            this.tbDF.Name = "tbDF";
            this.tbDF.Size = new System.Drawing.Size(654, 40);
            this.tbDF.TabIndex = 0;
            // 
            // gpBse
            // 
            this.gpBse.Location = new System.Drawing.Point(12, 46);
            this.gpBse.Name = "gpBse";
            this.gpBse.Size = new System.Drawing.Size(630, 343);
            this.gpBse.TabIndex = 1;
            this.gpBse.TabStop = false;
            this.gpBse.Text = "故障信息";
            // 
            // DFailureOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 401);
            this.Controls.Add(this.gpBse);
            this.Controls.Add(this.tbDF);
            this.Name = "DFailureOp";
            this.Text = "DFailureOp";
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar tbDF;
        private System.Windows.Forms.GroupBox gpBse;
    }
}