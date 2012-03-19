using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;

namespace QX.Common.C_Form
{
    public partial class MSGCon : Form
    {
        public MSGCon()
        {
            InitializeComponent();
        }

        public string sReturn = "";

        /// <summary>
        /// 带确定取消按钮弹出框（调用使用ShowDialog（）方法）
        /// </summary>
        /// <param name="msg"></param>
        public MSGCon(string msg)
        {
            InitializeComponent();
            this.lblMsg.Text = msg;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.sReturn = StringHelper.CONRESULT_OK;
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.sReturn = StringHelper.CONRESULT_CANCEL;
            this.Close();
        }
    }
}
