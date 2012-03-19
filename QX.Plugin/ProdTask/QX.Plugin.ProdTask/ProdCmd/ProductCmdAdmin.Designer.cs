namespace QX.Plugin.Cmd
{
    partial class ProductCmdAdmin
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
            this.gp_top = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gp_button = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gp_top.SuspendLayout();
            this.gp_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_top
            // 
            this.gp_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_top.Controls.Add(this.btnCancle);
            this.gp_top.Controls.Add(this.btnSave);
            this.gp_top.Controls.Add(this.btnOk);
            this.gp_top.Location = new System.Drawing.Point(12, 12);
            this.gp_top.Name = "gp_top";
            this.gp_top.Size = new System.Drawing.Size(750, 211);
            this.gp_top.TabIndex = 0;
            this.gp_top.TabStop = false;
            this.gp_top.Text = "生产指令基本信息";
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(670, 178);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(64, 23);
            this.btnCancle.TabIndex = 88;
            this.btnCancle.Text = "取消(&C)";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(602, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(533, 178);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 23);
            this.btnOk.TabIndex = 86;
            this.btnOk.Text = "应用(&A)";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // gp_button
            // 
            this.gp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_button.Controls.Add(this.panel2);
            this.gp_button.Location = new System.Drawing.Point(12, 229);
            this.gp_button.Name = "gp_button";
            this.gp_button.Size = new System.Drawing.Size(750, 325);
            this.gp_button.TabIndex = 1;
            this.gp_button.TabStop = false;
            this.gp_button.Text = "生产指令明细";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 305);
            this.panel2.TabIndex = 2;
            // 
            // ProductCmdAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 566);
            this.Controls.Add(this.gp_button);
            this.Controls.Add(this.gp_top);
            this.Name = "ProductCmdAdmin";
            this.Text = "生产指令维护";
            this.gp_top.ResumeLayout(false);
            this.gp_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_top;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gp_button;
        private System.Windows.Forms.Panel panel2;
    }
}