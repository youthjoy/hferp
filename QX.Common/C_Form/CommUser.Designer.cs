namespace QX.Common.C_Form
{
    partial class CommUser<T1, T2, U1, U2>
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
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnFresh = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvDept = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_Main = new System.Windows.Forms.DataGridView();
            this.Emp_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearchText);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 36);
            this.panel1.TabIndex = 0;
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(9, 7);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(100, 21);
            this.tbSearchText.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOK.Location = new System.Drawing.Point(281, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(351, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFind,
            this.btnFresh,
            this.btnAdd});
            this.toolStrip1.Location = new System.Drawing.Point(112, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = global::QX.Common.Properties.Resources.search;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(23, 22);
            this.btnFind.Text = "查找";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // btnFresh
            // 
            this.btnFresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFresh.Image = global::QX.Common.Properties.Resources.refresh;
            this.btnFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(23, 22);
            this.btnFresh.Text = "刷新";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::QX.Common.Properties.Resources.add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "人员添加";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvDept);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 250);
            this.panel2.TabIndex = 1;
            // 
            // tvDept
            // 
            this.tvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDept.Location = new System.Drawing.Point(0, 0);
            this.tvDept.Name = "tvDept";
            this.tvDept.Size = new System.Drawing.Size(147, 250);
            this.tvDept.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(147, 36);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 250);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GV_Main);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(150, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 250);
            this.panel3.TabIndex = 3;
            // 
            // GV_Main
            // 
            this.GV_Main.AllowUserToAddRows = false;
            this.GV_Main.AllowUserToDeleteRows = false;
            this.GV_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_Main.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GV_Main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GV_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_Code,
            this.Emp_Name});
            this.GV_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_Main.Location = new System.Drawing.Point(0, 0);
            this.GV_Main.MultiSelect = false;
            this.GV_Main.Name = "GV_Main";
            this.GV_Main.ReadOnly = true;
            this.GV_Main.RowTemplate.Height = 23;
            this.GV_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_Main.Size = new System.Drawing.Size(347, 250);
            this.GV_Main.TabIndex = 5;
            this.GV_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_Main_CellDoubleClick);
            // 
            // Emp_Code
            // 
            this.Emp_Code.DataPropertyName = "Emp_Code";
            this.Emp_Code.HeaderText = "人员编号";
            this.Emp_Code.Name = "Emp_Code";
            this.Emp_Code.ReadOnly = true;
            // 
            // Emp_Name
            // 
            this.Emp_Name.DataPropertyName = "Emp_Name";
            this.Emp_Name.HeaderText = "人员名称";
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.ReadOnly = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(419, 7);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(62, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取 消(&C)";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // CommUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(497, 286);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CommUser";
            this.Text = "用户选择窗口";
            this.Load += new System.EventHandler(this.CommUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.TreeView tvDept;
        private System.Windows.Forms.DataGridView GV_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Name;
        private System.Windows.Forms.ToolStripButton btnFresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.Button btnCancle;

    }
}