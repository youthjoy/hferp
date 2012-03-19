using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Framework.AutoForm;
using QX.Common.C_Class;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.Prod.ComControl
{
    public partial class ProdStatSel : Form
    {
        public ProdStatSel()
        {
            InitializeComponent();
            BindEvent();
            this.Load += new EventHandler(ProdStatSel_Load);
        }

        void ProdStatSel_Load(object sender, EventArgs e)
        {
            InitData();
        }

        public void BindEvent()
        {
            this.btn_OK.Click += new EventHandler(btn_OK_Click);
            this.btn_Cancel.Click += new EventHandler(btn_Cancel_Click);
        }

        void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btn_OK_Click(object sender, EventArgs e)
        {
            if (CallBack != null)
            {
                if (comboEditor != null)
                {
                    CallBack(null, comboEditor.Value);
                }
                this.Close();
            }
        }

        private FormHelper fheler = new FormHelper();
        private BindModelHelper helper = new BindModelHelper();

        public delegate void DCallBackHandler(object sender, object stat);
        public event DCallBackHandler CallBack;
        UltraComboEditor comboEditor;
        public void InitData()
        {
            fheler.GenerateForm("CForm_ProdStat", this.panel1, new Point(20, 20));
            comboEditor=helper.FindCtl<UltraComboEditor>(this.panel1.Controls, "ProdStat");
            
        }
    }
}