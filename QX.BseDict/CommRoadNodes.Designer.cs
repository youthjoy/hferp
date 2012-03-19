namespace QX.BseDict
{
    partial class CommRoadNodes
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvRoadNodes = new System.Windows.Forms.DataGridView();
            this.pnlNodes = new System.Windows.Forms.Panel();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dict_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dict_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoadNodes)).BeginInit();
            this.pnlNodes.SuspendLayout();
            this.SuspendLayout();
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
            this.TimeCost,
            this.Dict_Code,
            this.Dict_Name});
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
            // pnlNodes
            // 
            this.pnlNodes.Controls.Add(this.gvRoadNodes);
            this.pnlNodes.Controls.Add(this.btnCancel);
            this.pnlNodes.Controls.Add(this.btnConfirm);
            this.pnlNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNodes.Location = new System.Drawing.Point(0, 0);
            this.pnlNodes.Name = "pnlNodes";
            this.pnlNodes.Size = new System.Drawing.Size(792, 566);
            this.pnlNodes.TabIndex = 3;
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
            // TimeCost
            // 
            this.TimeCost.HeaderText = "额定工时";
            this.TimeCost.Name = "TimeCost";
            this.TimeCost.ReadOnly = true;
            this.TimeCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dict_Code
            // 
            this.Dict_Code.DataPropertyName = "Dict_Code";
            this.Dict_Code.HeaderText = "工艺节点编码";
            this.Dict_Code.Name = "Dict_Code";
            this.Dict_Code.ReadOnly = true;
            this.Dict_Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dict_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dict_Name
            // 
            this.Dict_Name.DataPropertyName = "Dict_Name";
            this.Dict_Name.HeaderText = "工艺节点名称";
            this.Dict_Name.Name = "Dict_Name";
            this.Dict_Name.ReadOnly = true;
            this.Dict_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dict_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CommRoadNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.pnlNodes);
            this.Name = "CommRoadNodes";
            this.Text = "CommRoadNodes";
            this.Load += new System.EventHandler(this.CommRoadNodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoadNodes)).EndInit();
            this.pnlNodes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView gvRoadNodes;
        private System.Windows.Forms.Panel pnlNodes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dict_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dict_Name;
    }
}