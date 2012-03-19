using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX_Common.C_Class;

namespace QX.Common.C_Form
{
    public partial class CommUser<T1,T2,U1,U2> : F_BasicPop
    {
        public delegate void DCallBackHandler(object sender, DataTable list);
        public event DCallBackHandler CallBack;

        private string _pidFiled;
        private string _pidValueFiled;
        private string _nameFiled;
        private string _tagFiled;
        private T1 _obj1;
        private T2 _obj2;
        private DataTable _dtDept;
        private DataTable _dtUser;
        private string _invokename1;
        private string _invokename2;
        private object[] _param;
        //private object[] _param2;
        //ToolStripTextBox tbSearchText = new ToolStripTextBox();
        //TextBox tbSearchText = new TextBox();

        public CommUser(T1 obj1,T2 obj2, 
            Size size)
        {
            InitializeComponent();
         
            
            //this.toolStrip1.Items.Insert(0, tbSearchText);
   

            GV_Main.AutoGenerateColumns = false;
            this.Size = size;
            this._pidFiled = "Dept_PCode";
            this._pidValueFiled = "Dept_Code";
            this._nameFiled = "Dept_Name";
            this._tagFiled = "Dept_Code";
            this._obj1 = obj1;
            this._obj2 = obj2;
            this._invokename1 = "GetAllDept";
            this._invokename2 = "GetAllEmployee";
            this._param = null;
            
            tvDept.AfterSelect += new TreeViewEventHandler(tvDept_AfterSelect);
            GV_Main.CellDoubleClick += new DataGridViewCellEventHandler(GV_Main_CellDoubleClick);
            btnFind.Click += new EventHandler(btnFind_Click);
            tbSearchText.TextChanged += new EventHandler(tbSearchText_TextChanged);
            btnOK.Click += new EventHandler(btnOK_Click);
            btnFresh.Click += new EventHandler(btnFresh_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnClear.Click += new EventHandler(btnClear_Click);
            //初始化
            Init();
            this.KeyPreview = true;
            this.Load+=new EventHandler(CommUser_Load);
            
            this.KeyUp += new KeyEventHandler(CommUser_KeyUp);
        }

        void btnClear_Click(object sender, EventArgs e)
        {
            if (CallBack != null)
            {
                CallBack(this, null);
                this.Close();
            }
        }

        void CommUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOK.Focus();
            }
        }



        void btnAdd_Click(object sender, EventArgs e)
        {
            PluginFramework.PluginShareServer pluginshare = new QX.PluginFramework.PluginShareServer();
            pluginshare.GetInstance("QX.Plugin.DeptManage", "QX.Plugin.DeptManage.Employee", null);
            
        }

        private void Init()
        {
            DynCompile dyn = new DynCompile();
            List<U1> list1 = dyn.MemeberInvokeForList<T1, U1>(_obj1, _invokename1, _param);
            _dtDept = ConvertX.ToDataTable<U1>(list1);

            List<U2> list2 = dyn.MemeberInvokeForList<T2, U2>(_obj2, _invokename2, _param);
            _dtUser = ConvertX.ToDataTable<U2>(list2);

            tvDept.Nodes.Clear();
            //初始化左边部门
            TreeHelper<T1, U1> treeHelper = new TreeHelper<T1, U1>(this.tvDept,_obj1, 
                _pidFiled, _pidValueFiled, _nameFiled, _tagFiled,_invokename1,_param);
            treeHelper.DataTableToTree(this.tvDept.Nodes, "");
            if (tvDept.Nodes.Count > 0)
            {
                tvDept.Nodes[0].ExpandAll();
                tvDept.SelectedNode = tvDept.Nodes[0];
            }
            //初始化Grid
            InitGrid("");
        }

        void btnFresh_Click(object sender, EventArgs e)
        {
            Init();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            SelectUser();         
        }

        void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            btnFind_Click(this, EventArgs.Empty);
        }

        void btnFind_Click(object sender, EventArgs e)
        {
            string txt = tbSearchText.Text;
            if (!String.IsNullOrEmpty(txt))
            {
                DataTable tmp = FilterDataTable(string.Format(" Emp_Name like '%{0}%' Or Emp_Code like '%{0}%'",txt));
                GV_Main.DataSource = tmp.DefaultView;
            }
            else
            {
                DataTable tmp = FilterDataTable("1=1");
                GV_Main.DataSource = tmp.DefaultView;
            }
        }

        void GV_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectUser();
        }

        void tvDept_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectText = tvDept.SelectedNode.Tag != null ? tvDept.SelectedNode.Tag.ToString() : string.Empty;
            if (!string.IsNullOrEmpty(selectText))
            {
                string filter = "Emp_Dept_Code='"+selectText+"'";
                if (tvDept.SelectedNode.Level==0)
                {
                    filter = "";
                }
                InitGrid(filter);                
            }
        }

        /// <summary>
        /// 初始化人员
        /// </summary>
        private void InitGrid(string filter)
        {           
            if (!String.IsNullOrEmpty(filter))
            {
                DataTable tmpDT = FilterDataTable(filter);
                GV_Main.DataSource = tmpDT.DefaultView;
            }
            else
            {
                GV_Main.DataSource = _dtUser.DefaultView;
            }            
        }
        /// <summary>
        /// 筛选人员
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private DataTable FilterDataTable(string filter)
        {
            DataTable tmpDT = new DataTable();
            tmpDT = _dtUser.Clone();
            if (_dtUser!=null && _dtUser.Rows.Count>0)
            {
                DataRow[] rows = _dtUser.Select(filter);
                for (int i = 0; i < rows.Length; i++)
                {
                    tmpDT.ImportRow(rows[i]);
                }
            }
            
            return tmpDT;
        }

        private void SelectUser()
        {
            if (GV_Main.SelectedRows != null)
            {
                DataGridViewSelectedRowCollection RowColl = GV_Main.SelectedRows;
                if (RowColl.Count > 0)
                {
                    string EmpolyeeCode = RowColl[0].Cells["Emp_Code"].Value.ToString();
                    DataTable tmp = FilterDataTable("Emp_Code='" + EmpolyeeCode + "'");
                    if (CallBack != null)
                    {
                        CallBack(this, tmp);
                    }
                    this.Close();
                }
            }      
        }

        private void CommUser_Load(object sender, EventArgs e)
        {
            //toolStrip1.Focus();
            //toolStrip1.Select();
            //tbSearchText.Select();
            //tbSearchText.Focus();
            //var d = tbSearchText.Focused;
        }
   
    }
}
