namespace QX.Plugin.Prod.RawMain
{
    partial class RawInvOp
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
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tool_bar_button = new QX.Common.C_Form.CommonToolBar();
            this.tbDetail = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.Location = new System.Drawing.Point(6, 263);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(794, 316);
            this.gbDetail.TabIndex = 5;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "毛坯单据内容";
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Location = new System.Drawing.Point(6, 50);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(794, 161);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "毛坯单据信息";
            // 
            // tool_bar_button
            // 
            this.tool_bar_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tool_bar_button.Location = new System.Drawing.Point(1, 7);
            this.tool_bar_button.Name = "tool_bar_button";
            this.tool_bar_button.Size = new System.Drawing.Size(799, 40);
            this.tool_bar_button.TabIndex = 3;
            // 
            // tbDetail
            // 
            this.tbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDetail.Location = new System.Drawing.Point(6, 217);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(794, 40);
            this.tbDetail.TabIndex = 6;
            // 
            // RawInvOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 587);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.tool_bar_button);
            this.Name = "RawInvOp";
            this.Text = "毛坯入库";
            this.Load += new System.EventHandler(this.RawInvOp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbMain;
        private QX.Common.C_Form.CommonToolBar tool_bar_button;
        private QX.Common.C_Form.CommonToolBar tbDetail;
    }
}