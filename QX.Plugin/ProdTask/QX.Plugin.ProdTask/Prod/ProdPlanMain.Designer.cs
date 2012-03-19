namespace QX.Plugin.Prod
{
    partial class ProdPlanMain
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
            this.pnlPlan = new System.Windows.Forms.Panel();
            this.splitSnapper = new System.Windows.Forms.SplitContainer();
            this.tabPlanTask = new System.Windows.Forms.TabControl();
            this.tpPlaningTask = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPlaningTask = new QX.Common.C_Form.CommonToolBar();
            this.tpPlanedTask = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPlanTask = new QX.Common.C_Form.CommonToolBar();
            this.splitHoriz = new System.Windows.Forms.SplitContainer();
            this.tbPlan = new QX.Common.C_Form.CommonToolBar();
            this.tbPlanNodes = new QX.Common.C_Form.CommonToolBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlPlan.SuspendLayout();
            this.splitSnapper.Panel1.SuspendLayout();
            this.splitSnapper.Panel2.SuspendLayout();
            this.splitSnapper.SuspendLayout();
            this.tabPlanTask.SuspendLayout();
            this.tpPlaningTask.SuspendLayout();
            this.tpPlanedTask.SuspendLayout();
            this.splitHoriz.Panel1.SuspendLayout();
            this.splitHoriz.Panel2.SuspendLayout();
            this.splitHoriz.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlan
            // 
            this.pnlPlan.Controls.Add(this.splitSnapper);
            this.pnlPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlPlan.Name = "pnlPlan";
            this.pnlPlan.Size = new System.Drawing.Size(792, 566);
            this.pnlPlan.TabIndex = 0;
            // 
            // splitSnapper
            // 
            this.splitSnapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitSnapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSnapper.Location = new System.Drawing.Point(0, 0);
            this.splitSnapper.Name = "splitSnapper";
            // 
            // splitSnapper.Panel1
            // 
            this.splitSnapper.Panel1.Controls.Add(this.tabPlanTask);
            // 
            // splitSnapper.Panel2
            // 
            this.splitSnapper.Panel2.Controls.Add(this.splitHoriz);
            this.splitSnapper.Size = new System.Drawing.Size(792, 566);
            this.splitSnapper.SplitterDistance = 395;
            this.splitSnapper.TabIndex = 0;
            // 
            // tabPlanTask
            // 
            this.tabPlanTask.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPlanTask.Controls.Add(this.tpPlaningTask);
            this.tabPlanTask.Controls.Add(this.tpPlanedTask);
            this.tabPlanTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlanTask.Location = new System.Drawing.Point(0, 0);
            this.tabPlanTask.Name = "tabPlanTask";
            this.tabPlanTask.SelectedIndex = 0;
            this.tabPlanTask.Size = new System.Drawing.Size(393, 564);
            this.tabPlanTask.TabIndex = 0;
            // 
            // tpPlaningTask
            // 
            this.tpPlaningTask.Controls.Add(this.panel1);
            this.tpPlaningTask.Controls.Add(this.tbPlaningTask);
            this.tpPlaningTask.Location = new System.Drawing.Point(4, 24);
            this.tpPlaningTask.Name = "tpPlaningTask";
            this.tpPlaningTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlaningTask.Size = new System.Drawing.Size(385, 536);
            this.tpPlaningTask.TabIndex = 0;
            this.tpPlaningTask.Text = "待计划列表";
            this.tpPlaningTask.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(4, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 487);
            this.panel1.TabIndex = 2;
            // 
            // tbPlaningTask
            // 
            this.tbPlaningTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPlaningTask.Location = new System.Drawing.Point(3, 3);
            this.tbPlaningTask.Name = "tbPlaningTask";
            this.tbPlaningTask.Size = new System.Drawing.Size(379, 40);
            this.tbPlaningTask.TabIndex = 1;
            // 
            // tpPlanedTask
            // 
            this.tpPlanedTask.Controls.Add(this.panel2);
            this.tpPlanedTask.Controls.Add(this.tbPlanTask);
            this.tpPlanedTask.Location = new System.Drawing.Point(4, 24);
            this.tpPlanedTask.Name = "tpPlanedTask";
            this.tpPlanedTask.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlanedTask.Size = new System.Drawing.Size(385, 536);
            this.tpPlanedTask.TabIndex = 1;
            this.tpPlanedTask.Text = "已计划列表";
            this.tpPlanedTask.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(3, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 484);
            this.panel2.TabIndex = 4;
            // 
            // tbPlanTask
            // 
            this.tbPlanTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPlanTask.Location = new System.Drawing.Point(3, 3);
            this.tbPlanTask.Name = "tbPlanTask";
            this.tbPlanTask.Size = new System.Drawing.Size(379, 40);
            this.tbPlanTask.TabIndex = 3;
            // 
            // splitHoriz
            // 
            this.splitHoriz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitHoriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHoriz.Location = new System.Drawing.Point(0, 0);
            this.splitHoriz.Name = "splitHoriz";
            this.splitHoriz.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitHoriz.Panel1
            // 
            this.splitHoriz.Panel1.Controls.Add(this.panel3);
            this.splitHoriz.Panel1.Controls.Add(this.tbPlan);
            // 
            // splitHoriz.Panel2
            // 
            this.splitHoriz.Panel2.Controls.Add(this.panel4);
            this.splitHoriz.Panel2.Controls.Add(this.tbPlanNodes);
            this.splitHoriz.Size = new System.Drawing.Size(393, 566);
            this.splitHoriz.SplitterDistance = 200;
            this.splitHoriz.SplitterWidth = 6;
            this.splitHoriz.TabIndex = 0;
            // 
            // tbPlan
            // 
            this.tbPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPlan.Location = new System.Drawing.Point(0, 0);
            this.tbPlan.Name = "tbPlan";
            this.tbPlan.Size = new System.Drawing.Size(391, 40);
            this.tbPlan.TabIndex = 1;
            // 
            // tbPlanNodes
            // 
            this.tbPlanNodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPlanNodes.Location = new System.Drawing.Point(0, 0);
            this.tbPlanNodes.Name = "tbPlanNodes";
            this.tbPlanNodes.Size = new System.Drawing.Size(391, 40);
            this.tbPlanNodes.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(4, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 154);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(3, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 313);
            this.panel4.TabIndex = 2;
            // 
            // ProdPlanMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.pnlPlan);
            this.Name = "ProdPlanMain";
            this.Text = "ProdPlanMain";
            this.Load += new System.EventHandler(this.ProdPlanMain_Load);
            this.pnlPlan.ResumeLayout(false);
            this.splitSnapper.Panel1.ResumeLayout(false);
            this.splitSnapper.Panel2.ResumeLayout(false);
            this.splitSnapper.ResumeLayout(false);
            this.tabPlanTask.ResumeLayout(false);
            this.tpPlaningTask.ResumeLayout(false);
            this.tpPlanedTask.ResumeLayout(false);
            this.splitHoriz.Panel1.ResumeLayout(false);
            this.splitHoriz.Panel2.ResumeLayout(false);
            this.splitHoriz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlan;
        private System.Windows.Forms.SplitContainer splitSnapper;
        private System.Windows.Forms.SplitContainer splitHoriz;
        private QX.Common.C_Form.CommonToolBar tbPlan;
        private QX.Common.C_Form.CommonToolBar tbPlanNodes;
        private System.Windows.Forms.TabControl tabPlanTask;
        private System.Windows.Forms.TabPage tpPlaningTask;
        private System.Windows.Forms.TabPage tpPlanedTask;
        private QX.Common.C_Form.CommonToolBar tbPlanTask;
        private QX.Common.C_Form.CommonToolBar tbPlaningTask;
        //private Infragistics.Win.UltraWinGrid.UltraGrid uGridPlaningTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}