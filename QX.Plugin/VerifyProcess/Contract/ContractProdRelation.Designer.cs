namespace QX.Plugin.Contract
{
    partial class ContractProdRelation
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
            this.splitSnapper = new System.Windows.Forms.SplitContainer();
            this.tabPlanTask = new System.Windows.Forms.TabControl();
            this.tpDoing = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTask = new QX.Common.C_Form.CommonToolBar();
            this.splitHoriz = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPlan = new QX.Common.C_Form.CommonToolBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbPlanNodes = new QX.Common.C_Form.CommonToolBar();
            this.splitSnapper.Panel1.SuspendLayout();
            this.splitSnapper.Panel2.SuspendLayout();
            this.splitSnapper.SuspendLayout();
            this.tabPlanTask.SuspendLayout();
            this.tpDoing.SuspendLayout();
            this.splitHoriz.Panel1.SuspendLayout();
            this.splitHoriz.Panel2.SuspendLayout();
            this.splitHoriz.SuspendLayout();
            this.SuspendLayout();
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
            this.splitSnapper.Size = new System.Drawing.Size(992, 528);
            this.splitSnapper.SplitterDistance = 695;
            this.splitSnapper.TabIndex = 1;
            // 
            // tabPlanTask
            // 
            this.tabPlanTask.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabPlanTask.Controls.Add(this.tpDoing);
            this.tabPlanTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlanTask.Location = new System.Drawing.Point(0, 0);
            this.tabPlanTask.Name = "tabPlanTask";
            this.tabPlanTask.SelectedIndex = 0;
            this.tabPlanTask.Size = new System.Drawing.Size(693, 526);
            this.tabPlanTask.TabIndex = 0;
            // 
            // tpDoing
            // 
            this.tpDoing.Controls.Add(this.panel1);
            this.tpDoing.Controls.Add(this.tbTask);
            this.tpDoing.Location = new System.Drawing.Point(4, 25);
            this.tpDoing.Name = "tpDoing";
            this.tpDoing.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoing.Size = new System.Drawing.Size(685, 497);
            this.tpDoing.TabIndex = 0;
            this.tpDoing.Text = "任务列表";
            this.tpDoing.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 448);
            this.panel1.TabIndex = 2;
            // 
            // tbTask
            // 
            this.tbTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTask.Location = new System.Drawing.Point(3, 0);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(679, 40);
            this.tbTask.TabIndex = 1;
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
            this.splitHoriz.Size = new System.Drawing.Size(293, 528);
            this.splitHoriz.SplitterDistance = 185;
            this.splitHoriz.SplitterWidth = 6;
            this.splitHoriz.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(2, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 139);
            this.panel3.TabIndex = 2;
            // 
            // tbPlan
            // 
            this.tbPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPlan.Location = new System.Drawing.Point(0, 0);
            this.tbPlan.Name = "tbPlan";
            this.tbPlan.Size = new System.Drawing.Size(291, 40);
            this.tbPlan.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(3, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 292);
            this.panel4.TabIndex = 2;
            // 
            // tbPlanNodes
            // 
            this.tbPlanNodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPlanNodes.Location = new System.Drawing.Point(0, 0);
            this.tbPlanNodes.Name = "tbPlanNodes";
            this.tbPlanNodes.Size = new System.Drawing.Size(291, 40);
            this.tbPlanNodes.TabIndex = 1;
            // 
            // ContractProdRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 528);
            this.Controls.Add(this.splitSnapper);
            this.Name = "ContractProdRelation";
            this.Text = "ContractProdRelation";
            this.splitSnapper.Panel1.ResumeLayout(false);
            this.splitSnapper.Panel2.ResumeLayout(false);
            this.splitSnapper.ResumeLayout(false);
            this.tabPlanTask.ResumeLayout(false);
            this.tpDoing.ResumeLayout(false);
            this.splitHoriz.Panel1.ResumeLayout(false);
            this.splitHoriz.Panel2.ResumeLayout(false);
            this.splitHoriz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitSnapper;
        private System.Windows.Forms.TabControl tabPlanTask;
        private System.Windows.Forms.TabPage tpDoing;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar tbTask;
        private System.Windows.Forms.SplitContainer splitHoriz;
        private System.Windows.Forms.Panel panel3;
        private QX.Common.C_Form.CommonToolBar tbPlan;
        private System.Windows.Forms.Panel panel4;
        private QX.Common.C_Form.CommonToolBar tbPlanNodes;
    }
}