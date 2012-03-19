namespace QX.Plugin.RoadCateManage
{
    partial class RoadComptMaintain
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
            this.tabComponets = new System.Windows.Forms.TabControl();
            this.tpMyList = new System.Windows.Forms.TabPage();
            this.pnlAudting = new System.Windows.Forms.Panel();
            this.pnlMyList = new System.Windows.Forms.Panel();
            this.tbMyList = new QX.Common.C_Form.CommonToolBar();
            this.tpAuditing = new System.Windows.Forms.TabPage();
            this.pnlOnAudit = new System.Windows.Forms.Panel();
            this.tbAuditing = new QX.Common.C_Form.CommonToolBar();
            this.tpLast = new System.Windows.Forms.TabPage();
            this.tbLast = new QX.Common.C_Form.CommonToolBar();
            this.pnlLast = new System.Windows.Forms.Panel();
            this.commTreeTool = new QX.Common.C_Form.CommonToolBar();
            this.tvRoadCate = new System.Windows.Forms.TreeView();
            this.tpTrash = new System.Windows.Forms.TabPage();
            this.tbTrash = new QX.Common.C_Form.CommonToolBar();
            this.pnlTrash = new System.Windows.Forms.Panel();
            this.tabComponets.SuspendLayout();
            this.tpMyList.SuspendLayout();
            this.pnlAudting.SuspendLayout();
            this.tpAuditing.SuspendLayout();
            this.tpLast.SuspendLayout();
            this.tpTrash.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabComponets
            // 
            this.tabComponets.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabComponets.Controls.Add(this.tpMyList);
            this.tabComponets.Controls.Add(this.tpAuditing);
            this.tabComponets.Controls.Add(this.tpLast);
            this.tabComponets.Controls.Add(this.tpTrash);
            this.tabComponets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabComponets.Location = new System.Drawing.Point(0, 0);
            this.tabComponets.Name = "tabComponets";
            this.tabComponets.SelectedIndex = 0;
            this.tabComponets.Size = new System.Drawing.Size(792, 566);
            this.tabComponets.TabIndex = 0;
            // 
            // tpMyList
            // 
            this.tpMyList.Controls.Add(this.pnlAudting);
            this.tpMyList.Location = new System.Drawing.Point(4, 24);
            this.tpMyList.Name = "tpMyList";
            this.tpMyList.Padding = new System.Windows.Forms.Padding(3);
            this.tpMyList.Size = new System.Drawing.Size(784, 538);
            this.tpMyList.TabIndex = 1;
            this.tpMyList.Text = "我的申请单";
            this.tpMyList.UseVisualStyleBackColor = true;
            // 
            // pnlAudting
            // 
            this.pnlAudting.Controls.Add(this.pnlMyList);
            this.pnlAudting.Controls.Add(this.tbMyList);
            this.pnlAudting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAudting.Location = new System.Drawing.Point(3, 3);
            this.pnlAudting.Name = "pnlAudting";
            this.pnlAudting.Size = new System.Drawing.Size(778, 532);
            this.pnlAudting.TabIndex = 0;
            // 
            // pnlMyList
            // 
            this.pnlMyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMyList.Location = new System.Drawing.Point(3, 46);
            this.pnlMyList.Name = "pnlMyList";
            this.pnlMyList.Size = new System.Drawing.Size(775, 483);
            this.pnlMyList.TabIndex = 9;
            // 
            // tbMyList
            // 
            this.tbMyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMyList.Location = new System.Drawing.Point(0, 0);
            this.tbMyList.Name = "tbMyList";
            this.tbMyList.Size = new System.Drawing.Size(778, 40);
            this.tbMyList.TabIndex = 6;
            // 
            // tpAuditing
            // 
            this.tpAuditing.Controls.Add(this.pnlOnAudit);
            this.tpAuditing.Controls.Add(this.tbAuditing);
            this.tpAuditing.Location = new System.Drawing.Point(4, 24);
            this.tpAuditing.Name = "tpAuditing";
            this.tpAuditing.Size = new System.Drawing.Size(784, 538);
            this.tpAuditing.TabIndex = 4;
            this.tpAuditing.Text = "待审核清单";
            this.tpAuditing.UseVisualStyleBackColor = true;
            // 
            // pnlOnAudit
            // 
            this.pnlOnAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOnAudit.Location = new System.Drawing.Point(2, 44);
            this.pnlOnAudit.Name = "pnlOnAudit";
            this.pnlOnAudit.Size = new System.Drawing.Size(779, 491);
            this.pnlOnAudit.TabIndex = 2;
            // 
            // tbAuditing
            // 
            this.tbAuditing.Location = new System.Drawing.Point(3, 3);
            this.tbAuditing.Name = "tbAuditing";
            this.tbAuditing.Size = new System.Drawing.Size(607, 40);
            this.tbAuditing.TabIndex = 1;
            // 
            // tpLast
            // 
            this.tpLast.Controls.Add(this.tbLast);
            this.tpLast.Controls.Add(this.pnlLast);
            this.tpLast.Controls.Add(this.commTreeTool);
            this.tpLast.Controls.Add(this.tvRoadCate);
            this.tpLast.Location = new System.Drawing.Point(4, 24);
            this.tpLast.Name = "tpLast";
            this.tpLast.Size = new System.Drawing.Size(784, 538);
            this.tpLast.TabIndex = 2;
            this.tpLast.Text = "已通过终审清单";
            this.tpLast.UseVisualStyleBackColor = true;
            // 
            // tbLast
            // 
            this.tbLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLast.Location = new System.Drawing.Point(160, 2);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(621, 40);
            this.tbLast.TabIndex = 11;
            // 
            // pnlLast
            // 
            this.pnlLast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLast.Location = new System.Drawing.Point(160, 45);
            this.pnlLast.Name = "pnlLast";
            this.pnlLast.Size = new System.Drawing.Size(621, 490);
            this.pnlLast.TabIndex = 10;
            // 
            // commTreeTool
            // 
            this.commTreeTool.Location = new System.Drawing.Point(1, 1);
            this.commTreeTool.Name = "commTreeTool";
            this.commTreeTool.Size = new System.Drawing.Size(153, 40);
            this.commTreeTool.TabIndex = 9;
            // 
            // tvRoadCate
            // 
            this.tvRoadCate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvRoadCate.Location = new System.Drawing.Point(3, 45);
            this.tvRoadCate.Name = "tvRoadCate";
            this.tvRoadCate.Size = new System.Drawing.Size(153, 485);
            this.tvRoadCate.TabIndex = 8;
            // 
            // tpTrash
            // 
            this.tpTrash.Controls.Add(this.tbTrash);
            this.tpTrash.Controls.Add(this.pnlTrash);
            this.tpTrash.Location = new System.Drawing.Point(4, 24);
            this.tpTrash.Name = "tpTrash";
            this.tpTrash.Size = new System.Drawing.Size(784, 538);
            this.tpTrash.TabIndex = 3;
            this.tpTrash.Text = "已废弃清单";
            this.tpTrash.UseVisualStyleBackColor = true;
            // 
            // tbTrash
            // 
            this.tbTrash.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTrash.Location = new System.Drawing.Point(0, 0);
            this.tbTrash.Name = "tbTrash";
            this.tbTrash.Size = new System.Drawing.Size(784, 40);
            this.tbTrash.TabIndex = 1;
            // 
            // pnlTrash
            // 
            this.pnlTrash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTrash.Location = new System.Drawing.Point(1, 42);
            this.pnlTrash.Name = "pnlTrash";
            this.pnlTrash.Size = new System.Drawing.Size(783, 493);
            this.pnlTrash.TabIndex = 0;
            // 
            // RoadComptMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tabComponets);
            this.Name = "RoadComptMaintain";
            this.Text = "零件图号列表";
            this.Load += new System.EventHandler(this.RoadComptMaintain_Load);
            this.tabComponets.ResumeLayout(false);
            this.tpMyList.ResumeLayout(false);
            this.pnlAudting.ResumeLayout(false);
            this.tpAuditing.ResumeLayout(false);
            this.tpLast.ResumeLayout(false);
            this.tpTrash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabComponets;
        private System.Windows.Forms.TabPage tpMyList;
        private System.Windows.Forms.Panel pnlAudting;
        private QX.Common.C_Form.CommonToolBar tbMyList;
        private System.Windows.Forms.TabPage tpLast;
        private System.Windows.Forms.TabPage tpAuditing;
        private System.Windows.Forms.TabPage tpTrash;
        private QX.Common.C_Form.CommonToolBar commTreeTool;
        private System.Windows.Forms.TreeView tvRoadCate;
        private QX.Common.C_Form.CommonToolBar tbAuditing;
        private System.Windows.Forms.Panel pnlMyList;
        private System.Windows.Forms.Panel pnlOnAudit;
        private System.Windows.Forms.Panel pnlLast;
        private QX.Common.C_Form.CommonToolBar tbTrash;
        private System.Windows.Forms.Panel pnlTrash;
        private QX.Common.C_Form.CommonToolBar tbLast;

    }
}