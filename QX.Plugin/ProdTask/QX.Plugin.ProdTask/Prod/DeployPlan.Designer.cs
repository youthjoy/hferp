namespace QX.Plugin.Prod
{
    partial class DeployPlan
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
            this.gbDeployPlan = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDeployPlan
            // 
            this.gbDeployPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDeployPlan.Location = new System.Drawing.Point(3, 12);
            this.gbDeployPlan.Name = "gbDeployPlan";
            this.gbDeployPlan.Size = new System.Drawing.Size(786, 302);
            this.gbDeployPlan.TabIndex = 0;
            this.gbDeployPlan.TabStop = false;
            this.gbDeployPlan.Text = "下达计划信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commonToolBar1);
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 271);
            this.panel1.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(597, 608);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(698, 608);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar1.Location = new System.Drawing.Point(0, 0);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(782, 40);
            this.commonToolBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 230);
            this.panel2.TabIndex = 1;
            // 
            // DeployPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDeployPlan);
            this.Name = "DeployPlan";
            this.Text = "计划下发";
            this.Load += new System.EventHandler(this.DeployPlan_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeployPlan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private QX.Common.C_Form.CommonToolBar commonToolBar1;
        private System.Windows.Forms.Panel panel2;
    }
}