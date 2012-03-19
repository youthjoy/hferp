namespace QX.Plugin.Report
{
    partial class CommRptFinNode
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
            this.tool_bar_CContract_List = new QX.Common.C_Form.CommonToolBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 399);
            this.panel1.TabIndex = 7;
            // 
            // tool_bar_CContract_List
            // 
            this.tool_bar_CContract_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_bar_CContract_List.Location = new System.Drawing.Point(0, 0);
            this.tool_bar_CContract_List.Name = "tool_bar_CContract_List";
            this.tool_bar_CContract_List.Size = new System.Drawing.Size(644, 40);
            this.tool_bar_CContract_List.TabIndex = 6;
            // 
            // CommRptFinNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool_bar_CContract_List);
            this.Name = "CommRptFinNode";
            this.Text = "工序计件查询";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar tool_bar_CContract_List;
    }
}