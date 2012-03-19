namespace QX.Plugin.RawInfo
{
    partial class ProductCmdMain
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
            Infragistics.Win.Appearance appearance133 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance134 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance135 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance136 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance137 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance138 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance139 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance140 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance141 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance142 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance143 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance144 = new Infragistics.Win.Appearance();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProductList = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_tool_0 = new QX.Common.C_Form.CommonToolBar();
            this.ProductIssuedList = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gvMain_1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.top_tool_1 = new QX.Common.C_Form.CommonToolBar();
            this.tabControl1.SuspendLayout();
            this.ProductList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ProductIssuedList.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain_1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.ProductList);
            this.tabControl1.Controls.Add(this.ProductIssuedList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductList
            // 
            this.ProductList.Controls.Add(this.panel2);
            this.ProductList.Controls.Add(this.panel1);
            this.ProductList.Location = new System.Drawing.Point(4, 24);
            this.ProductList.Name = "ProductList";
            this.ProductList.Padding = new System.Windows.Forms.Padding(3);
            this.ProductList.Size = new System.Drawing.Size(708, 382);
            this.ProductList.TabIndex = 0;
            this.ProductList.Text = "生产指令列表";
            this.ProductList.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 329);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.top_tool_0);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 47);
            this.panel1.TabIndex = 0;
            // 
            // top_tool_0
            // 
            this.top_tool_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_tool_0.Location = new System.Drawing.Point(0, 0);
            this.top_tool_0.Name = "top_tool_0";
            this.top_tool_0.Size = new System.Drawing.Size(702, 47);
            this.top_tool_0.TabIndex = 0;
            // 
            // ProductIssuedList
            // 
            this.ProductIssuedList.Controls.Add(this.panel4);
            this.ProductIssuedList.Controls.Add(this.panel3);
            this.ProductIssuedList.Location = new System.Drawing.Point(4, 24);
            this.ProductIssuedList.Name = "ProductIssuedList";
            this.ProductIssuedList.Padding = new System.Windows.Forms.Padding(3);
            this.ProductIssuedList.Size = new System.Drawing.Size(708, 382);
            this.ProductIssuedList.TabIndex = 1;
            this.ProductIssuedList.Text = "已下发任务";
            this.ProductIssuedList.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gvMain_1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 329);
            this.panel4.TabIndex = 1;
            // 
            // gvMain_1
            // 
            appearance133.BackColor = System.Drawing.SystemColors.Window;
            appearance133.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.gvMain_1.DisplayLayout.Appearance = appearance133;
            this.gvMain_1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.gvMain_1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance134.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance134.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance134.BorderColor = System.Drawing.SystemColors.Window;
            this.gvMain_1.DisplayLayout.GroupByBox.Appearance = appearance134;
            appearance135.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gvMain_1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance135;
            this.gvMain_1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance136.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance136.BackColor2 = System.Drawing.SystemColors.Control;
            appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance136.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gvMain_1.DisplayLayout.GroupByBox.PromptAppearance = appearance136;
            this.gvMain_1.DisplayLayout.MaxColScrollRegions = 1;
            this.gvMain_1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance137.BackColor = System.Drawing.SystemColors.Window;
            appearance137.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvMain_1.DisplayLayout.Override.ActiveCellAppearance = appearance137;
            appearance138.BackColor = System.Drawing.SystemColors.Highlight;
            appearance138.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvMain_1.DisplayLayout.Override.ActiveRowAppearance = appearance138;
            this.gvMain_1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.gvMain_1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance139.BackColor = System.Drawing.SystemColors.Window;
            this.gvMain_1.DisplayLayout.Override.CardAreaAppearance = appearance139;
            appearance140.BorderColor = System.Drawing.Color.Silver;
            appearance140.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.gvMain_1.DisplayLayout.Override.CellAppearance = appearance140;
            this.gvMain_1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.gvMain_1.DisplayLayout.Override.CellPadding = 0;
            appearance141.BackColor = System.Drawing.SystemColors.Control;
            appearance141.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance141.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance141.BorderColor = System.Drawing.SystemColors.Window;
            this.gvMain_1.DisplayLayout.Override.GroupByRowAppearance = appearance141;
            appearance142.TextHAlignAsString = "Left";
            this.gvMain_1.DisplayLayout.Override.HeaderAppearance = appearance142;
            this.gvMain_1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.gvMain_1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance143.BackColor = System.Drawing.SystemColors.Window;
            appearance143.BorderColor = System.Drawing.Color.Silver;
            this.gvMain_1.DisplayLayout.Override.RowAppearance = appearance143;
            this.gvMain_1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance144.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gvMain_1.DisplayLayout.Override.TemplateAddRowAppearance = appearance144;
            this.gvMain_1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.gvMain_1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.gvMain_1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.gvMain_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMain_1.Location = new System.Drawing.Point(0, 0);
            this.gvMain_1.Name = "gvMain_1";
            this.gvMain_1.Size = new System.Drawing.Size(702, 329);
            this.gvMain_1.TabIndex = 4;
            this.gvMain_1.Text = "ultraGrid1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.top_tool_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 47);
            this.panel3.TabIndex = 0;
            // 
            // top_tool_1
            // 
            this.top_tool_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_tool_1.Location = new System.Drawing.Point(0, 0);
            this.top_tool_1.Name = "top_tool_1";
            this.top_tool_1.Size = new System.Drawing.Size(702, 47);
            this.top_tool_1.TabIndex = 0;
            // 
            // ProductCmdMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 410);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductCmdMain";
            this.Text = "ProductMain";
            this.tabControl1.ResumeLayout(false);
            this.ProductList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ProductIssuedList.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain_1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProductList;
        private System.Windows.Forms.TabPage ProductIssuedList;
        private System.Windows.Forms.Panel panel1;
        private QX.Common.C_Form.CommonToolBar top_tool_0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private QX.Common.C_Form.CommonToolBar top_tool_1;
        private System.Windows.Forms.Panel panel4;
        private Infragistics.Win.UltraWinGrid.UltraGrid gvMain_1;
    }
}