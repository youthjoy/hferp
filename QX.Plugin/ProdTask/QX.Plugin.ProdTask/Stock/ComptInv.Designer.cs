namespace QX.Plugin.InvInfo
{
    partial class ComptInv
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabInvList = new System.Windows.Forms.TabControl();
            this.tpInvList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabComptInv = new System.Windows.Forms.TabControl();
            this.tabInvOut = new System.Windows.Forms.TabPage();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.MV_Owner = new System.Windows.Forms.TextBox();
            this.btnInvOut = new System.Windows.Forms.Button();
            this.MV_Date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.MV_Count = new System.Windows.Forms.ComboBox();
            this.lblProdCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.tpEntering = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.commonToolBar2 = new QX.Common.C_Form.CommonToolBar();
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.groupBox1.SuspendLayout();
            this.tabInvList.SuspendLayout();
            this.tpInvList.SuspendLayout();
            this.tabComptInv.SuspendLayout();
            this.tabInvOut.SuspendLayout();
            this.tpEntering.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabInvList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 619);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "`";
            // 
            // tabInvList
            // 
            this.tabInvList.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabInvList.Controls.Add(this.tpInvList);
            this.tabInvList.Controls.Add(this.tpEntering);
            this.tabInvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInvList.Location = new System.Drawing.Point(3, 17);
            this.tabInvList.Name = "tabInvList";
            this.tabInvList.SelectedIndex = 0;
            this.tabInvList.Size = new System.Drawing.Size(890, 599);
            this.tabInvList.TabIndex = 2;
            // 
            // tpInvList
            // 
            this.tpInvList.Controls.Add(this.commonToolBar1);
            this.tpInvList.Controls.Add(this.panel1);
            this.tpInvList.Controls.Add(this.tabComptInv);
            this.tpInvList.Location = new System.Drawing.Point(4, 24);
            this.tpInvList.Name = "tpInvList";
            this.tpInvList.Padding = new System.Windows.Forms.Padding(3);
            this.tpInvList.Size = new System.Drawing.Size(882, 571);
            this.tpInvList.TabIndex = 0;
            this.tpInvList.Text = "库存列表";
            this.tpInvList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 366);
            this.panel1.TabIndex = 4;
            // 
            // tabComptInv
            // 
            this.tabComptInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabComptInv.Controls.Add(this.tabInvOut);
            this.tabComptInv.Location = new System.Drawing.Point(6, 415);
            this.tabComptInv.Name = "tabComptInv";
            this.tabComptInv.SelectedIndex = 0;
            this.tabComptInv.Size = new System.Drawing.Size(871, 150);
            this.tabComptInv.TabIndex = 3;
            // 
            // tabInvOut
            // 
            this.tabInvOut.Controls.Add(this.txtProdCode);
            this.tabInvOut.Controls.Add(this.MV_Owner);
            this.tabInvOut.Controls.Add(this.btnInvOut);
            this.tabInvOut.Controls.Add(this.MV_Date);
            this.tabInvOut.Controls.Add(this.label8);
            this.tabInvOut.Controls.Add(this.MV_Count);
            this.tabInvOut.Controls.Add(this.lblProdCode);
            this.tabInvOut.Controls.Add(this.label2);
            this.tabInvOut.Controls.Add(this.lblNum);
            this.tabInvOut.Location = new System.Drawing.Point(4, 21);
            this.tabInvOut.Name = "tabInvOut";
            this.tabInvOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvOut.Size = new System.Drawing.Size(863, 125);
            this.tabInvOut.TabIndex = 1;
            this.tabInvOut.Text = "出库";
            this.tabInvOut.UseVisualStyleBackColor = true;
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(126, 13);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(100, 21);
            this.txtProdCode.TabIndex = 42;
            // 
            // MV_Owner
            // 
            this.MV_Owner.Location = new System.Drawing.Point(126, 42);
            this.MV_Owner.Name = "MV_Owner";
            this.MV_Owner.Size = new System.Drawing.Size(200, 21);
            this.MV_Owner.TabIndex = 39;
            // 
            // btnInvOut
            // 
            this.btnInvOut.Location = new System.Drawing.Point(492, 91);
            this.btnInvOut.Name = "btnInvOut";
            this.btnInvOut.Size = new System.Drawing.Size(75, 23);
            this.btnInvOut.TabIndex = 41;
            this.btnInvOut.Text = "确认出库";
            this.btnInvOut.UseVisualStyleBackColor = true;
            // 
            // MV_Date
            // 
            this.MV_Date.Location = new System.Drawing.Point(126, 73);
            this.MV_Date.Name = "MV_Date";
            this.MV_Date.Size = new System.Drawing.Size(200, 21);
            this.MV_Date.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "出库时间";
            // 
            // MV_Count
            // 
            this.MV_Count.FormattingEnabled = true;
            this.MV_Count.Location = new System.Drawing.Point(446, 43);
            this.MV_Count.Name = "MV_Count";
            this.MV_Count.Size = new System.Drawing.Size(121, 20);
            this.MV_Count.TabIndex = 38;
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.Location = new System.Drawing.Point(39, 16);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(53, 12);
            this.lblProdCode.TabIndex = 37;
            this.lblProdCode.Text = "零件编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "经办人";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(373, 46);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(53, 12);
            this.lblNum.TabIndex = 37;
            this.lblNum.Text = "出库数量";
            // 
            // tpEntering
            // 
            this.tpEntering.Controls.Add(this.panel2);
            this.tpEntering.Controls.Add(this.commonToolBar2);
            this.tpEntering.Location = new System.Drawing.Point(4, 24);
            this.tpEntering.Name = "tpEntering";
            this.tpEntering.Padding = new System.Windows.Forms.Padding(3);
            this.tpEntering.Size = new System.Drawing.Size(882, 571);
            this.tpEntering.TabIndex = 1;
            this.tpEntering.Text = "待入库列表";
            this.tpEntering.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 523);
            this.panel2.TabIndex = 2;
            // 
            // commonToolBar2
            // 
            this.commonToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar2.Location = new System.Drawing.Point(3, 3);
            this.commonToolBar2.Name = "commonToolBar2";
            this.commonToolBar2.Size = new System.Drawing.Size(876, 40);
            this.commonToolBar2.TabIndex = 1;
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonToolBar1.Location = new System.Drawing.Point(3, 3);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(876, 40);
            this.commonToolBar1.TabIndex = 5;
            // 
            // ComptInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 619);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComptInv";
            this.Text = "ComptInv";
            this.Load += new System.EventHandler(this.ComptInv_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabInvList.ResumeLayout(false);
            this.tpInvList.ResumeLayout(false);
            this.tabComptInv.ResumeLayout(false);
            this.tabInvOut.ResumeLayout(false);
            this.tabInvOut.PerformLayout();
            this.tpEntering.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabInvList;
        private System.Windows.Forms.TabPage tpInvList;
        private System.Windows.Forms.TabPage tpEntering;
        private QX.Common.C_Form.CommonToolBar commonToolBar2;
        private System.Windows.Forms.TabControl tabComptInv;
        private System.Windows.Forms.TabPage tabInvOut;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.TextBox MV_Owner;
        private System.Windows.Forms.Button btnInvOut;
        private System.Windows.Forms.DateTimePicker MV_Date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MV_Count;
        private System.Windows.Forms.Label lblProdCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private QX.Common.C_Form.CommonToolBar commonToolBar1;
    }
}