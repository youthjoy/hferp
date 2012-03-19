namespace QX.Plugin.FeedBack
{
    partial class FeedBackOp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cblQA = new System.Windows.Forms.CheckedListBox();
            this.cblProcess = new System.Windows.Forms.CheckedListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool_bar_button
            // 
            this.tool_bar_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_bar_button.Location = new System.Drawing.Point(0, 0);
            this.tool_bar_button.Name = "tool_bar_button";
            this.tool_bar_button.Size = new System.Drawing.Size(649, 40);
            this.tool_bar_button.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户反馈信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cblQA);
            this.groupBox2.Controls.Add(this.cblProcess);
            this.groupBox2.Location = new System.Drawing.Point(0, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "原因归类";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "影响进度原因";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "影响质量的原因";
            // 
            // cblQA
            // 
            this.cblQA.FormattingEnabled = true;
            this.cblQA.Location = new System.Drawing.Point(453, 29);
            this.cblQA.Name = "cblQA";
            this.cblQA.Size = new System.Drawing.Size(166, 100);
            this.cblQA.TabIndex = 0;
            // 
            // cblProcess
            // 
            this.cblProcess.FormattingEnabled = true;
            this.cblProcess.Location = new System.Drawing.Point(122, 29);
            this.cblProcess.Name = "cblProcess";
            this.cblProcess.Size = new System.Drawing.Size(166, 100);
            this.cblProcess.TabIndex = 0;
            // 
            // FeedBackOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tool_bar_button);
            this.Name = "FeedBackOp";
            this.Text = "FeedBackOp";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QX.Common.C_Form.CommonToolBar tool_bar_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cblQA;
        private System.Windows.Forms.CheckedListBox cblProcess;
    }
}