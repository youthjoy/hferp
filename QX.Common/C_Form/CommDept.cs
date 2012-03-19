using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.Common.C_Class;
using QX_Common.C_Class;

namespace QX.Common.C_Form
{
    public partial class CommDept<T,U>: F_BasicPop
    {
        public delegate void DSynHandler();
        public delegate void DCallBackHandler(object sender, DataTable list);
        public event DCallBackHandler CallBack;
        private string _pidFiled;
        private string _pidValueFiled;
        private string _nameFiled;
        private string _tagFiled;
        private T _obj;
        private DataTable _dt;
        private string _invokename;
        private object[] _param;

        public CommDept(T obj, Size size)
        {
            //"Dept_PCode", "Dept_Code", "Dept_Name", "Dept_Code","GetAllDept"
            InitializeComponent();
            this.Size = size;
            this._pidFiled = "Dept_PCode";
            this._pidValueFiled = "Dept_Code";
            this._nameFiled = "Dept_Name";
            this._tagFiled = "Dept_Code";
            this._obj = obj;
            this._invokename = "GetAllDept";
            this._param = null;
            Init();
            btnFresh.Click += new EventHandler(btnFresh_Click);
            tvMain.MouseDoubleClick += new MouseEventHandler(tvMain_MouseDoubleClick);

            DynCompile dyn = new DynCompile();
            List<U> list = dyn.MemeberInvokeForList<T, U>(_obj, _invokename, _param);
            _dt = ConvertX.ToDataTable<U>(list);

        }

        void tvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                btnOK_Click(this, EventArgs.Empty);
            }
        }

        void btnFresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new DSynHandler(Init));
        }

        public void Init()
        {
            tvMain.Nodes.Clear();
            TreeHelper<T,U> treeHelper = new TreeHelper<T,U>(this.tvMain, _obj,
                _pidFiled, _pidValueFiled, _nameFiled, _tagFiled,_invokename,_param);
            treeHelper.DataTableToTree(this.tvMain.Nodes, "");
            if (tvMain.Nodes.Count > 0)
            {
                tvMain.Nodes[0].ExpandAll();
            }    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode!=null)
            {
                string filter = _tagFiled + "='" + tvMain.SelectedNode.Tag.ToString() + "'";
                DataTable tmpDt = new DataTable();
                tmpDt = _dt.Clone();
                DataRow[] list = _dt.Select(filter);
                for (int i = 0; i < list.Length; i++)
                {
                    tmpDt.ImportRow((DataRow)list[i]);
                }
                if (CallBack!=null)
                {
                    CallBack(tvMain.SelectedNode, tmpDt); 
                }
                this.Close();
            }
        }        
    }
}
