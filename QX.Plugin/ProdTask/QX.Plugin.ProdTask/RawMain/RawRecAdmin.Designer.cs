namespace QX.Plugin.Prod.RawMain
{
    partial class RawRecAdmin
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
            this.tool_bar_button = new QX.Common.C_Form.CommonToolBar();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.tbDetail = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // tool_bar_button
            // 
            this.tool_bar_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tool_bar_button.Location = new System.Drawing.Point(1, 3);
            this.tool_bar_button.Name = "tool_bar_button";
            this.tool_bar_button.Size = new System.Drawing.Size(799, 40);
            this.tool_bar_button.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Location = new System.Drawing.Point(6, 46);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(794, 153);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "毛坯单据信息";
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetail.Location = new System.Drawing.Point(6, 256);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(794, 319);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "毛坯单据内容";
            // 
            // tbDetail
            // 
            this.tbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDetail.Location = new System.Drawing.Point(6, 205);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(794, 40);
            this.tbDetail.TabIndex = 7;
            // 
            // RawRecAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 587);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.tool_bar_button);
            this.Name = "RawRecAdmin";
            this.Text = "毛坯采购订单";
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar tool_bar_button;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbDetail;
        private QX.Common.C_Form.CommonToolBar tbDetail;

    }
}