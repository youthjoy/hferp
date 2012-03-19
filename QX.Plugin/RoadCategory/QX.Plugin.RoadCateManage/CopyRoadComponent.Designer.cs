namespace QX.Plugin.RoadCateManage
{
    partial class CopyRoadComponent
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
            this.gpCompt = new System.Windows.Forms.GroupBox();
            this.Comp_CatCode = new System.Windows.Forms.TextBox();
            this.Comp_Bak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Comp_CatName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Comp_Code = new System.Windows.Forms.TextBox();
            this.Comp_Name = new System.Windows.Forms.TextBox();
            this.gpCompt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCompt
            // 
            this.gpCompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpCompt.Controls.Add(this.Comp_CatCode);
            this.gpCompt.Controls.Add(this.Comp_Bak);
            this.gpCompt.Controls.Add(this.label1);
            this.gpCompt.Controls.Add(this.btnCancel);
            this.gpCompt.Controls.Add(this.label2);
            this.gpCompt.Controls.Add(this.btnConfirm);
            this.gpCompt.Controls.Add(this.label3);
            this.gpCompt.Controls.Add(this.Comp_CatName);
            this.gpCompt.Controls.Add(this.label4);
            this.gpCompt.Controls.Add(this.Comp_Code);
            this.gpCompt.Controls.Add(this.Comp_Name);
            this.gpCompt.Location = new System.Drawing.Point(12, 12);
            this.gpCompt.Name = "gpCompt";
            this.gpCompt.Size = new System.Drawing.Size(305, 272);
            this.gpCompt.TabIndex = 9;
            this.gpCompt.TabStop = false;
            this.gpCompt.Text = "零件图号信息维护";
            // 
            // Comp_CatCode
            // 
            this.Comp_CatCode.Location = new System.Drawing.Point(99, 108);
            this.Comp_CatCode.Name = "Comp_CatCode";
            this.Comp_CatCode.Size = new System.Drawing.Size(22, 21);
            this.Comp_CatCode.TabIndex = 8;
            this.Comp_CatCode.Visible = false;
            // 
            // Comp_Bak
            // 
            this.Comp_Bak.Location = new System.Drawing.Point(98, 135);
            this.Comp_Bak.Multiline = true;
            this.Comp_Bak.Name = "Comp_Bak";
            this.Comp_Bak.Size = new System.Drawing.Size(183, 81);
            this.Comp_Bak.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "零件图号";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(206, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "零件名称";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(125, 233);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "保存";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备注";
            // 
            // Comp_CatName
            // 
            this.Comp_CatName.Location = new System.Drawing.Point(98, 88);
            this.Comp_CatName.Name = "Comp_CatName";
            this.Comp_CatName.ReadOnly = true;
            this.Comp_CatName.Size = new System.Drawing.Size(183, 21);
            this.Comp_CatName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "产品类别";
            // 
            // Comp_Code
            // 
            this.Comp_Code.Location = new System.Drawing.Point(99, 25);
            this.Comp_Code.Name = "Comp_Code";
            this.Comp_Code.Size = new System.Drawing.Size(182, 21);
            this.Comp_Code.TabIndex = 4;
            // 
            // Comp_Name
            // 
            this.Comp_Name.Location = new System.Drawing.Point(99, 55);
            this.Comp_Name.Name = "Comp_Name";
            this.Comp_Name.Size = new System.Drawing.Size(182, 21);
            this.Comp_Name.TabIndex = 4;
            // 
            // CopyRoadComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(329, 294);
            this.Controls.Add(this.gpCompt);
            this.Name = "CopyRoadComponent";
            this.Text = "CopyRoadComponent";
            this.Load += new System.EventHandler(this.CopyRoadComponent_Load);
            this.gpCompt.ResumeLayout(false);
            this.gpCompt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCompt;
        private System.Windows.Forms.TextBox Comp_CatCode;
        private System.Windows.Forms.TextBox Comp_Bak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Comp_CatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Comp_Code;
        private System.Windows.Forms.TextBox Comp_Name;
    }
}