namespace QX.Plugin.RawInfo
{
    partial class RawManage
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.gp_top = new System.Windows.Forms.GroupBox();
            this.RawMain_ID = new System.Windows.Forms.TextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.RawMain_Title = new System.Windows.Forms.TextBox();
            this.RawMain_AppOwn = new System.Windows.Forms.TextBox();
            this.RawMain_SupDep = new System.Windows.Forms.TextBox();
            this.RawMain_AppDep = new System.Windows.Forms.TextBox();
            this.RawMain_Code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_button = new System.Windows.Forms.GroupBox();
            this.gvMain = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tool_top = new QX.Common.C_Form.CommonToolBar();
            this.RawMain_AppDate = new System.Windows.Forms.DateTimePicker();
            this.gp_top.SuspendLayout();
            this.gp_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_top
            // 
            this.gp_top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_top.Controls.Add(this.RawMain_AppDate);
            this.gp_top.Controls.Add(this.RawMain_ID);
            this.gp_top.Controls.Add(this.btnCancle);
            this.gp_top.Controls.Add(this.btnSave);
            this.gp_top.Controls.Add(this.btnOk);
            this.gp_top.Controls.Add(this.btnDel);
            this.gp_top.Controls.Add(this.btnAdd);
            this.gp_top.Controls.Add(this.RawMain_Title);
            this.gp_top.Controls.Add(this.RawMain_AppOwn);
            this.gp_top.Controls.Add(this.RawMain_SupDep);
            this.gp_top.Controls.Add(this.RawMain_AppDep);
            this.gp_top.Controls.Add(this.RawMain_Code);
            this.gp_top.Controls.Add(this.label6);
            this.gp_top.Controls.Add(this.label5);
            this.gp_top.Controls.Add(this.label4);
            this.gp_top.Controls.Add(this.label3);
            this.gp_top.Controls.Add(this.label2);
            this.gp_top.Controls.Add(this.label1);
            this.gp_top.Location = new System.Drawing.Point(13, 7);
            this.gp_top.Name = "gp_top";
            this.gp_top.Size = new System.Drawing.Size(654, 201);
            this.gp_top.TabIndex = 0;
            this.gp_top.TabStop = false;
            this.gp_top.Text = "基本信息";
            // 
            // RawMain_ID
            // 
            this.RawMain_ID.Location = new System.Drawing.Point(135, 164);
            this.RawMain_ID.Name = "RawMain_ID";
            this.RawMain_ID.Size = new System.Drawing.Size(39, 21);
            this.RawMain_ID.TabIndex = 86;
            this.RawMain_ID.Visible = false;
            // 
            // btnCancle
            // 
            this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancle.Location = new System.Drawing.Point(529, 162);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 85;
            this.btnCancle.Text = "取消(&C)";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(443, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(357, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 83;
            this.btnOk.Text = "应用(&A)";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(271, 162);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 82;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "新增(&N)";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // RawMain_Title
            // 
            this.RawMain_Title.Location = new System.Drawing.Point(418, 118);
            this.RawMain_Title.Name = "RawMain_Title";
            this.RawMain_Title.Size = new System.Drawing.Size(185, 21);
            this.RawMain_Title.TabIndex = 17;
            // 
            // RawMain_AppOwn
            // 
            this.RawMain_AppOwn.Location = new System.Drawing.Point(418, 36);
            this.RawMain_AppOwn.Name = "RawMain_AppOwn";
            this.RawMain_AppOwn.Size = new System.Drawing.Size(185, 21);
            this.RawMain_AppOwn.TabIndex = 15;
            // 
            // RawMain_SupDep
            // 
            this.RawMain_SupDep.Location = new System.Drawing.Point(109, 122);
            this.RawMain_SupDep.Name = "RawMain_SupDep";
            this.RawMain_SupDep.Size = new System.Drawing.Size(185, 21);
            this.RawMain_SupDep.TabIndex = 14;
            // 
            // RawMain_AppDep
            // 
            this.RawMain_AppDep.Location = new System.Drawing.Point(109, 79);
            this.RawMain_AppDep.Name = "RawMain_AppDep";
            this.RawMain_AppDep.Size = new System.Drawing.Size(185, 21);
            this.RawMain_AppDep.TabIndex = 13;
            // 
            // RawMain_Code
            // 
            this.RawMain_Code.Location = new System.Drawing.Point(109, 36);
            this.RawMain_Code.Name = "RawMain_Code";
            this.RawMain_Code.Size = new System.Drawing.Size(185, 21);
            this.RawMain_Code.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "供应部门";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "申请标题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "申请日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "申请人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "申请部门";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "申请编号";
            // 
            // gp_button
            // 
            this.gp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_button.Controls.Add(this.gvMain);
            this.gp_button.Controls.Add(this.tool_top);
            this.gp_button.Location = new System.Drawing.Point(13, 216);
            this.gp_button.Name = "gp_button";
            this.gp_button.Size = new System.Drawing.Size(654, 305);
            this.gp_button.TabIndex = 1;
            this.gp_button.TabStop = false;
            this.gp_button.Text = "毛坯明细";
            // 
            // gvMain
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.gvMain.DisplayLayout.Appearance = appearance1;
            this.gvMain.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.gvMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.gvMain.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gvMain.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.gvMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gvMain.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.gvMain.DisplayLayout.MaxColScrollRegions = 1;
            this.gvMain.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvMain.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvMain.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.gvMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.gvMain.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.gvMain.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.gvMain.DisplayLayout.Override.CellAppearance = appearance8;
            this.gvMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.gvMain.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.gvMain.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.gvMain.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.gvMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.gvMain.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.gvMain.DisplayLayout.Override.RowAppearance = appearance11;
            this.gvMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gvMain.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.gvMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.gvMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.gvMain.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.gvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMain.Location = new System.Drawing.Point(3, 54);
            this.gvMain.Name = "gvMain";
            this.gvMain.Size = new System.Drawing.Size(648, 248);
            this.gvMain.TabIndex = 1;
            this.gvMain.Text = "gvMain";
            // 
            // tool_top
            // 
            this.tool_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool_top.Location = new System.Drawing.Point(3, 17);
            this.tool_top.Name = "tool_top";
            this.tool_top.Size = new System.Drawing.Size(648, 37);
            this.tool_top.TabIndex = 0;
            // 
            // RawMain_AppDate
            // 
            this.RawMain_AppDate.Location = new System.Drawing.Point(418, 75);
            this.RawMain_AppDate.Name = "RawMain_AppDate";
            this.RawMain_AppDate.Size = new System.Drawing.Size(186, 21);
            this.RawMain_AppDate.TabIndex = 87;
            // 
            // RawManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 525);
            this.Controls.Add(this.gp_button);
            this.Controls.Add(this.gp_top);
            this.Name = "RawManage";
            this.Text = "RawManage";
            this.Load += new System.EventHandler(this.RawManage_Load);
            this.gp_top.ResumeLayout(false);
            this.gp_top.PerformLayout();
            this.gp_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_top;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_button;
        private Infragistics.Win.UltraWinGrid.UltraGrid gvMain;
        private QX.Common.C_Form.CommonToolBar tool_top;
        private System.Windows.Forms.TextBox RawMain_Title;
        private System.Windows.Forms.TextBox RawMain_AppOwn;
        private System.Windows.Forms.TextBox RawMain_SupDep;
        private System.Windows.Forms.TextBox RawMain_AppDep;
        private System.Windows.Forms.TextBox RawMain_Code;
        private System.Windows.Forms.TextBox RawMain_ID;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker RawMain_AppDate;

    }
}