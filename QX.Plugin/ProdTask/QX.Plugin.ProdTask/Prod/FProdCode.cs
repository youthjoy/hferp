using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;
using QX.Plugin.Prod.Prod;

namespace QX.Plugin.Prod.Prod
{
    public partial class FProdCode : Form
    {
        public FProdCode()
        {
            InitializeComponent();

            IsConfirm = false;

            this.txtPre.Text = "hf";
        }

        public string GCode
        {
            get;
            set;
        }

        public string Prefix
        {
            get;
            set;
        }

        public bool IsConfirm
        {
            get;
            set;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            GCode = this.txtCode.Text;
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                Alert.Show("请输入编号!");
                return;
            }
            Prefix = this.txtPre.Text;
            IsConfirm = true;

            this.Close();
        }
    }
}
