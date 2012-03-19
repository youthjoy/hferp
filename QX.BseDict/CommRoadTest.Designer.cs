namespace QX.BseDict
{
    partial class CommRoadTest
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
            this.gvRoadTest = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlNodes = new System.Windows.Forms.Panel();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dict_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dict_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestRef_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestRef_High = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestRef_Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestRef_IsLast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoadTest)).BeginInit();
            this.pnlNodes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvRoadTest
            // 
            this.gvRoadTest.AllowUserToAddRows = false;
            this.gvRoadTest.AllowUserToDeleteRows = false;
            this.gvRoadTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRoadTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRoadTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRoadTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.Dict_Code,
            this.Dict_Name,
            this.TestRef_Value,
            this.TestRef_High,
            this.TestRef_Low,
            this.TestRef_IsLast});
            this.gvRoadTest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvRoadTest.Location = new System.Drawing.Point(5, 50);
            this.gvRoadTest.MultiSelect = false;
            this.gvRoadTest.Name = "gvRoadTest";
            this.gvRoadTest.ReadOnly = true;
            this.gvRoadTest.RowTemplate.Height = 23;
            this.gvRoadTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvRoadTest.Size = new System.Drawing.Size(915, 539);
            this.gvRoadTest.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(829, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(719, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "导入";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // pnlNodes
            // 
            this.pnlNodes.Controls.Add(this.gvRoadTest);
            this.pnlNodes.Controls.Add(this.btnCancel);
            this.pnlNodes.Controls.Add(this.btnConfirm);
            this.pnlNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNodes.Location = new System.Drawing.Point(0, 0);
            this.pnlNodes.Name = "pnlNodes";
            this.pnlNodes.Size = new System.Drawing.Size(923, 592);
            this.pnlNodes.TabIndex = 4;
            // 
            // checkbox
            // 
            this.checkbox.FalseValue = "false";
            this.checkbox.HeaderText = "选择";
            this.checkbox.Name = "checkbox";
            this.checkbox.ReadOnly = true;
            this.checkbox.TrueValue = "true";
            // 
            // Dict_Code
            // 
            this.Dict_Code.DataPropertyName = "Dict_Code";
            this.Dict_Code.HeaderText = "检测参数编码";
            this.Dict_Code.Name = "Dict_Code";
            this.Dict_Code.ReadOnly = true;
            this.Dict_Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dict_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dict_Name
            // 
            this.Dict_Name.DataPropertyName = "Dict_Name";
            this.Dict_Name.HeaderText = "检测参数名称";
            this.Dict_Name.Name = "Dict_Name";
            this.Dict_Name.ReadOnly = true;
            this.Dict_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dict_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TestRef_Value
            // 
            this.TestRef_Value.HeaderText = "检测参数参考值";
            this.TestRef_Value.Name = "TestRef_Value";
            this.TestRef_Value.ReadOnly = true;
            // 
            // TestRef_High
            // 
            this.TestRef_High.HeaderText = "检测上限";
            this.TestRef_High.Name = "TestRef_High";
            this.TestRef_High.ReadOnly = true;
            // 
            // TestRef_Low
            // 
            this.TestRef_Low.HeaderText = "检测下限";
            this.TestRef_Low.Name = "TestRef_Low";
            this.TestRef_Low.ReadOnly = true;
            // 
            // TestRef_IsLast
            // 
            this.TestRef_IsLast.HeaderText = "是否存在终检参数";
            this.TestRef_IsLast.Name = "TestRef_IsLast";
            this.TestRef_IsLast.ReadOnly = true;
            this.TestRef_IsLast.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TestRef_IsLast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CommRoadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 592);
            this.Controls.Add(this.pnlNodes);
            this.Name = "CommRoadTest";
            this.Text = "CommRoadTest";
            this.Load += new System.EventHandler(this.CommRoadTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoadTest)).EndInit();
            this.pnlNodes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRoadTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlNodes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dict_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dict_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestRef_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestRef_High;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestRef_Low;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TestRef_IsLast;
    }
}