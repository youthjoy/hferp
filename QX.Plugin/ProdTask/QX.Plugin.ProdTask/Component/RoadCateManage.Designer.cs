namespace QX.Plugin.RoadCateManage
{
    partial class RoadCateManage
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
            this.components = new System.ComponentModel.Container();
            this.gpControls = new System.Windows.Forms.GroupBox();
            this.Cate_Code = new System.Windows.Forms.TextBox();
            this.Cate_Name = new System.Windows.Forms.TextBox();
            this.LB_Code = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.commonToolBar1 = new QX.Common.C_Form.CommonToolBar();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNode = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnLook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTvAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTvUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGridDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gpControls.SuspendLayout();
            this.cMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpControls
            // 
            this.gpControls.Controls.Add(this.Cate_Code);
            this.gpControls.Controls.Add(this.Cate_Name);
            this.gpControls.Controls.Add(this.LB_Code);
            this.gpControls.Controls.Add(this.LB_Name);
            this.gpControls.Controls.Add(this.btnConfirm);
            this.gpControls.Location = new System.Drawing.Point(227, 14);
            this.gpControls.Name = "gpControls";
            this.gpControls.Size = new System.Drawing.Size(305, 376);
            this.gpControls.TabIndex = 4;
            this.gpControls.TabStop = false;
            this.gpControls.Text = "信息维护";
            // 
            // Cate_Code
            // 
            this.Cate_Code.Location = new System.Drawing.Point(129, 67);
            this.Cate_Code.Name = "Cate_Code";
            this.Cate_Code.Size = new System.Drawing.Size(158, 21);
            this.Cate_Code.TabIndex = 2;
            // 
            // Cate_Name
            // 
            this.Cate_Name.Location = new System.Drawing.Point(129, 100);
            this.Cate_Name.Name = "Cate_Name";
            this.Cate_Name.Size = new System.Drawing.Size(158, 21);
            this.Cate_Name.TabIndex = 2;
            // 
            // LB_Code
            // 
            this.LB_Code.AutoSize = true;
            this.LB_Code.Location = new System.Drawing.Point(39, 70);
            this.LB_Code.Name = "LB_Code";
            this.LB_Code.Size = new System.Drawing.Size(53, 12);
            this.LB_Code.TabIndex = 1;
            this.LB_Code.Text = "节点编码";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(39, 103);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(53, 12);
            this.LB_Name.TabIndex = 1;
            this.LB_Name.Text = "节点名称";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(195, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // commonToolBar1
            // 
            this.commonToolBar1.Location = new System.Drawing.Point(12, 12);
            this.commonToolBar1.Name = "commonToolBar1";
            this.commonToolBar1.Size = new System.Drawing.Size(197, 47);
            this.commonToolBar1.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 65);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(197, 325);
            this.treeView1.TabIndex = 3;
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtNode,
            this.toolStripSeparator2,
            this.tbtnLook,
            this.btnTvAdd,
            this.btnTvUpdate,
            this.btnGridDelete});
            this.cMenu.Name = "contextMenuStrip1";
            this.cMenu.Size = new System.Drawing.Size(161, 121);
            // 
            // txtNode
            // 
            this.txtNode.Enabled = false;
            this.txtNode.Name = "txtNode";
            this.txtNode.ReadOnly = true;
            this.txtNode.Size = new System.Drawing.Size(100, 21);
            this.txtNode.Text = "当前节点:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // tbtnLook
            // 
            this.tbtnLook.Name = "tbtnLook";
            this.tbtnLook.Size = new System.Drawing.Size(160, 22);
            this.tbtnLook.Text = "查看";
            // 
            // btnTvAdd
            // 
            this.btnTvAdd.Name = "btnTvAdd";
            this.btnTvAdd.Size = new System.Drawing.Size(160, 22);
            this.btnTvAdd.Text = "添加";
            // 
            // btnTvUpdate
            // 
            this.btnTvUpdate.Name = "btnTvUpdate";
            this.btnTvUpdate.Size = new System.Drawing.Size(160, 22);
            this.btnTvUpdate.Text = "编辑";
            // 
            // btnGridDelete
            // 
            this.btnGridDelete.Name = "btnGridDelete";
            this.btnGridDelete.Size = new System.Drawing.Size(160, 22);
            this.btnGridDelete.Text = "删除";
            // 
            // RoadCateManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 395);
            this.Controls.Add(this.gpControls);
            this.Controls.Add(this.commonToolBar1);
            this.Controls.Add(this.treeView1);
            this.Name = "RoadCateManage";
            this.Text = "RoadCateManage";
            this.Load += new System.EventHandler(this.RoadCateManage_Load);
            this.gpControls.ResumeLayout(false);
            this.gpControls.PerformLayout();
            this.cMenu.ResumeLayout(false);
            this.cMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpControls;
        private System.Windows.Forms.TextBox Cate_Code;
        private System.Windows.Forms.TextBox Cate_Name;
        private System.Windows.Forms.Label LB_Code;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Button btnConfirm;
        private QX.Common.C_Form.CommonToolBar commonToolBar1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripTextBox txtNode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tbtnLook;
        private System.Windows.Forms.ToolStripMenuItem btnTvAdd;
        private System.Windows.Forms.ToolStripMenuItem btnTvUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnGridDelete;
    }
}