namespace QX.Plugin.InvInfo
{
    partial class InvInfo
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
            this.tabInv = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commonToolBar2 = new QX.Common.C_Form.CommonToolBar();
            this.tpOuting = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbOut = new QX.Common.C_Form.CommonToolBar();
            this.tpInHis = new System.Windows.Forms.TabPage();
            this.pnlHis = new System.Windows.Forms.Panel();
            this.tbHisIn = new QX.Common.C_Form.CommonToolBar();
            this.tabInv.SuspendLayout();
            this.tpList.SuspendLayout();
            this.tpOuting.SuspendLayout();
            this.tpInHis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInv
            // 
            this.tabInv.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabInv.Controls.Add(this.tpList);
            this.tabInv.Controls.Add(this.tpOuting);
            this.tabInv.Controls.Add(this.tpInHis);
            this.tabInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInv.Location = new System.Drawing.Point(0, 0);
            this.tabInv.Name = "tabInv";
            this.tabInv.SelectedIndex = 0;
            this.tabInv.Size = new System.Drawing.Size(891, 614);
            this.tabInv.TabIndex = 1;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.panel1);
            this.tpList.Controls.Add(this.commonToolBar2);
            this.tpList.Location = new System.Drawing.Point(4, 24);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(883, 586);
            this.tpList.TabIndex = 1;
            this.tpList.Text = "库存信息列表";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 542);
            this.panel1.TabIndex = 2;
            // 
            // commonToolBar2
            // 
            this.commonToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar2.Location = new System.Drawing.Point(3, 3);
            this.commonToolBar2.Name = "commonToolBar2";
            this.commonToolBar2.Size = new System.Drawing.Size(877, 40);
            this.commonToolBar2.TabIndex = 1;
            // 
            // tpOuting
            // 
            this.tpOuting.Controls.Add(this.panel2);
            this.tpOuting.Controls.Add(this.tbOut);
            this.tpOuting.Location = new System.Drawing.Point(4, 24);
            this.tpOuting.Name = "tpOuting";
            this.tpOuting.Size = new System.Drawing.Size(883, 586);
            this.tpOuting.TabIndex = 2;
            this.tpOuting.Text = "已出库列表";
            this.tpOuting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 542);
            this.panel2.TabIndex = 2;
            // 
            // tbOut
            // 
            this.tbOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOut.Location = new System.Drawing.Point(0, 0);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(883, 40);
            this.tbOut.TabIndex = 1;
            // 
            // tpInHis
            // 
            this.tpInHis.Controls.Add(this.pnlHis);
            this.tpInHis.Controls.Add(this.tbHisIn);
            this.tpInHis.Location = new System.Drawing.Point(4, 24);
            this.tpInHis.Name = "tpInHis";
            this.tpInHis.Size = new System.Drawing.Size(883, 586);
            this.tpInHis.TabIndex = 3;
            this.tpInHis.Text = "入库记录";
            this.tpInHis.UseVisualStyleBackColor = true;
            // 
            // pnlHis
            // 
            this.pnlHis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHis.Location = new System.Drawing.Point(3, 44);
            this.pnlHis.Name = "pnlHis";
            this.pnlHis.Size = new System.Drawing.Size(877, 542);
            this.pnlHis.TabIndex = 4;
            // 
            // tbHisIn
            // 
            this.tbHisIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHisIn.Location = new System.Drawing.Point(0, 0);
            this.tbHisIn.Name = "tbHisIn";
            this.tbHisIn.Size = new System.Drawing.Size(883, 40);
            this.tbHisIn.TabIndex = 3;
            // 
            // InvInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 614);
            this.Controls.Add(this.tabInv);
            this.Name = "InvInfo";
            this.Text = "库存";
            this.Load += new System.EventHandler(this.InvInfo_Load);
            this.tabInv.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.tpOuting.ResumeLayout(false);
            this.tpInHis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInv;
        private System.Windows.Forms.TabPage tpList;
        private QX.Common.C_Form.CommonToolBar commonToolBar2;
        private System.Windows.Forms.TabPage tpOuting;
        private QX.Common.C_Form.CommonToolBar tbOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tpInHis;
        private System.Windows.Forms.Panel pnlHis;
        private QX.Common.C_Form.CommonToolBar tbHisIn;
    }
}