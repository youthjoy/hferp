using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.BLL;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Form;
using QX.Common.C_Class;
using QX.Framework.AutoForm;
using QX.Shared;

namespace QX.BseDict
{
    public partial class AuditUserSel : Form
    {
        public AuditUserSel(string module, string node)
        {
            InitializeComponent();
            AuditNode = node;
            ModuleCode = module;
            this.Load += new EventHandler(AuditUserSel_Load);

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public string AuditNode
        {
            get;
            set;
        }

        public string ModuleCode
        {
            get;
            set;
        }

        void AuditUserSel_Load(object sender, EventArgs e)
        {
            Init();
        }

        private Bll_Audit adInstance = new Bll_Audit();


        private BindModelHelper bmHelper = new BindModelHelper();

        UltraGrid uGridUser = new UltraGrid();

        private Sys_Map Map
        {
            get;
            set;
        }

        private Audit_Template TemlateKey
        {
            get;
            set;
        }

        private void Init()
        {
            Bll_Sys_Map mapInst = new Bll_Sys_Map();
            Map = mapInst.GetModel(string.Format(" AND Map_Module='{0}' AND Map_Source='{0}'", "SmsTemplate"));

            Bll_Audit auditInst = new Bll_Audit();
            TemlateKey = auditInst.GetTemplateModel(ModuleCode);

            GridHelper gen = new GridHelper();
            uGridUser = gen.GenerateGrid("CList_VUser", this.panel1, new Point(6, 20));

            var dt = adInstance.GetNextVerifyUser(AuditNode, SessionConfig.UserCode);
            uGridUser.DataSource = dt;
            uGridUser.DoubleClickRow += new DoubleClickRowEventHandler(uGridUser_DoubleClickRow);
            gen.SetGridReadOnly(uGridUser, true);
            gen.SetGridColumnStyle(uGridUser, AutoFitStyle.ResizeAllColumns);

            AddCustomCol();
        }

        public delegate void DCallBackHandler(bool re, string result);

        public event DCallBackHandler CallBack;

        void uGridUser_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            var val = e.Row.Cells["Emp_Mobile"].Value;

            if (val != null)
            {
                string mobile = val.ToString();
                SendMsg(mobile);
                this.Close();
                //GSMModem modem = new GSMModem();
                //modem.ComPort = System.Configuration.ConfigurationSettings.AppSettings["COMStr"];
                //modem.BaudRate = 9600;
                //try
                //{
                //    if (!modem.IsOpen)
                //    {
                //        modem.Open();
                //        modem.SendMsg(mobile, string.Format(Map.Map_Object1, TemlateKey.Template_Name));
                //        modem.Close();
                //        this.Close();
                //    }
                //    else
                //    {
                //        modem.SendMsg(mobile, string.Format(Map.Map_Object1, TemlateKey.Template_Name));
                //        modem.Close();
                //        this.Close();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    modem.Close();
                //    this.Close();
                //    //throw ex;
                //}
            }
            else
            {
                this.Close();
            }

        }

        public void AddCustomCol()
        {

            if (!uGridUser.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = uGridUser.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;

            }
            else
            {
                uGridUser.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = uGridUser.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<string> mobileList = new List<string>();
            foreach (UltraGridRow row in this.uGridUser.Rows)
            {
                if (row.Cells["checkbox"] != null && row.Cells["checkbox"].Value.ToString() == "True")
                {
                    if (row.Cells["Emp_Mobile"].Value != null)
                    {
                        mobileList.Add(row.Cells["Emp_Mobile"].Value.ToString());
                        SendMsg(row.Cells["Emp_Mobile"].Value.ToString());
                    }
                }
            }

            this.Close();
        }

        public void SendMsg(string val)
        {
            string mobile = val;
            string content = string.Format(Map.Map_Object1, TemlateKey.Template_Name,SessionConfig.EmpName);
            MethodInvoker mi = delegate
            {
                GSMHelper.SendMessage(mobile, content);
            };
            mi.BeginInvoke(null, null);
          
        }
    }
}
