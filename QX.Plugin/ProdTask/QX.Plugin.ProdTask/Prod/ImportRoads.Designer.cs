namespace QX.Plugin.Prod
{
    partial class ImportRoads
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
            this.pnlNodes = new System.Windows.Forms.Panel();
            this.gvRoadNodes = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNodes_TimeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNodes_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNodes_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNodes_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoadNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNodes
            // 
            this.pnlNodes.Controls.Add(this.gvRoadNodes);
            this.pnlNodes.Controls.Add(this.btnCancel);
            this.pnlNodes.Controls.Add(this.btnConfirm);
            this.pnlNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNodes.Location = new System.Drawing.Point(0, 0);
            this.pnlNodes.Name = "pnlNodes";
            this.pnlNodes.Size = new System.Drawing.Size(792, 566);
            this.pnlNodes.TabIndex = 4;
            // 
            // gvRoadNodes
            // 
            this.gvRoadNodes.AllowUserToAddRows = false;
            this.gvRoadNodes.AllowUserToDeleteRows = false;
            this.gvRoadNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRoadNodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRoadNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRoadNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.Order,
            this.RNodes_TimeCost,
            this.RNodes_Value,
            this.RNodes_Code,
            this.RNodes_Name});
            this.gvRoadNodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvRoadNodes.Location = new System.Drawing.Point(5, 50);
            this.gvRoadNodes.MultiSelect = false;
            this.gvRoadNodes.Name = "gvRoadNodes";
            this.gvRoadNodes.ReadOnly = true;
            this.gvRoadNodes.RowTemplate.Height = 23;
            this.gvRoadNodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvRoadNodes.Size = new System.Drawing.Size(784, 513);
            this.gvRoadNodes.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(698, 7);
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
            this.btnConfirm.Location = new System.Drawing.Point(583, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "导入";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // checkbox
            // 
            this.checkbox.FalseValue = "false";
            this.checkbox.HeaderText = "选择";
            this.checkbox.Name = "checkbox";
            this.checkbox.ReadOnly = true;
            this.checkbox.TrueValue = "true";
            // 
            // Order
            // 
            this.Order.HeaderText = "顺序";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // RNodes_TimeCost
            // 
            this.RNodes_TimeCost.DataPropertyName = "RNodes_TimeCost";
            this.RNodes_TimeCost.HeaderText = "额定工时";
            this.RNodes_TimeCost.Name = "RNodes_TimeCost";
            this.RNodes_TimeCost.ReadOnly = true;
            this.RNodes_TimeCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RNodes_Value
            // 
            this.RNodes_Value.DataPropertyName = "RNodes_Value";
            this.RNodes_Value.HeaderText = "工时单价";
            this.RNodes_Value.Name = "RNodes_Value";
            this.RNodes_Value.ReadOnly = true;
            // 
            // RNodes_Code
            // 
            this.RNodes_Code.DataPropertyName = "RNodes_Code";
            this.RNodes_Code.HeaderText = "工艺节点编码";
            this.RNodes_Code.Name = "RNodes_Code";
            this.RNodes_Code.ReadOnly = true;
            this.RNodes_Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RNodes_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RNodes_Name
            // 
            this.RNodes_Name.DataPropertyName = "RNodes_Name";
            this.RNodes_Name.HeaderText = "工艺节点名称";
            this.RNodes_Name.Name = "RNodes_Name";
            this.RNodes_Name.ReadOnly = true;
            this.RNodes_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RNodes_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ImportRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.pnlNodes);
            this.Name = "ImportRoads";
            this.Text = "ImportRoads";
            this.pnlNodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoadNodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNodes;
        private System.Windows.Forms.DataGridView gvRoadNodes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNodes_TimeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNodes_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNodes_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNodes_Name;
    }
}