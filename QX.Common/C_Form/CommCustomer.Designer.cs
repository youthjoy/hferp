namespace QX.Common.C_Form
{
    partial class CommCustomer<T1, U1>
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnFresh = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GV_Main = new System.Windows.Forms.DataGridView();
            this.Cust_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_COwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_CMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(409, 7);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(62, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取 消(&C)";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(341, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(62, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确 定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSearchText,
            this.btnFind,
            this.btnFresh,
            this.btnAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbSearchText
            // 
            this.tbSearchText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(100, 36);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = global::QX.Common.Properties.Resources.search;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(23, 33);
            this.btnFind.Text = "查找";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // btnFresh
            // 
            this.btnFresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFresh.Image = global::QX.Common.Properties.Resources.refresh;
            this.btnFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(23, 33);
            this.btnFresh.Text = "刷新";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::QX.Common.Properties.Resources.add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 33);
            this.btnAdd.Text = "人员添加";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GV_Main);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 250);
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
            this.Cust_Code,
            this.Cust_Name,
            this.Cust_COwner,
            this.Cust_CMobile});
            this.GV_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GV_Main.Location = new System.Drawing.Point(0, 0);
            this.GV_Main.MultiSelect = false;
            this.GV_Main.Name = "GV_Main";
            this.GV_Main.ReadOnly = true;
            this.GV_Main.RowTemplate.Height = 23;
            this.GV_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_Main.Size = new System.Drawing.Size(497, 250);
            this.GV_Main.TabIndex = 0;
            this.GV_Main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_Main_CellDoubleClick);
            // 
            // Cust_Code
            // 
            this.Cust_Code.DataPropertyName = "Cust_Code";
            this.Cust_Code.HeaderText = "客户编号";
            this.Cust_Code.Name = "Cust_Code";
            this.Cust_Code.ReadOnly = true;
            // 
            // Cust_Name
            // 
            this.Cust_Name.DataPropertyName = "Cust_Name";
            this.Cust_Name.HeaderText = "客户名称";
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.ReadOnly = true;
            // 
            // Cust_COwner
            // 
            this.Cust_COwner.DataPropertyName = "Cust_COwner";
            this.Cust_COwner.HeaderText = "联系人";
            this.Cust_COwner.Name = "Cust_COwner";
            this.Cust_COwner.ReadOnly = true;
            // 
            // Cust_CMobile
            // 
            this.Cust_CMobile.DataPropertyName = "Cust_CMobile";
            this.Cust_CMobile.HeaderText = "联系方式";
            this.Cust_CMobile.Name = "Cust_CMobile";
            this.Cust_CMobile.ReadOnly = true;
            // 
            // CommCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancle;
            this.ClientSize = new System.Drawing.Size(497, 286);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CommCustomer";
            this.Text = "用户选择窗口";
            this.Load += new System.EventHandler(this.CommCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tbSearchText;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.DataGridView GV_Main;
        private System.Windows.Forms.ToolStripButton btnFresh;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_COwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_CMobile;

    }
}