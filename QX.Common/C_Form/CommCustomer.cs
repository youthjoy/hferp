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
    public partial class CommCustomer<T1,U1> : F_BasicPop
    {
        public delegate void DCallBackHandler(object sender, DataTable list);
        public event DCallBackHandler CallBack;

        private T1 _obj1;
        private DataTable _dtCustomer;
        private string _invokename1;
        private object[] _param;
        //private object[] _param2;

        public CommCustomer(T1 obj1, 
            Size size)
        {
            InitializeComponent();
            GV_Main.AutoGenerateColumns = false;
            this.Size = size;
            this._obj1 = obj1;
            this._invokename1 = "GetAll";
            this._param = null;
            
            GV_Main.CellDoubleClick += new DataGridViewCellEventHandler(GV_Main_CellDoubleClick);
            btnFind.Click += new EventHandler(btnFind_Click);
            tbSearchText.TextChanged += new EventHandler(tbSearchText_TextChanged);
            btnOK.Click += new EventHandler(btnOK_Click);
            btnFresh.Click += new EventHandler(btnFresh_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);           

            //初始化
            Init();

        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            PluginFramework.PluginShareServer pluginshare = new QX.PluginFramework.PluginShareServer();
            pluginshare.GetInstance("QX.Plugin.Contract", "QX.Plugin.Contract.Customer", null);
            
        }

        private void Init()
        {
            DynCompile dyn = new DynCompile();
            List<U1> list1 = dyn.MemeberInvokeForList<T1, U1>(_obj1, _invokename1, _param);
            _dtCustomer = ConvertX.ToDataTable<U1>(list1);

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
                DataTable tmp = FilterDataTable("Cust_Name like '%" + txt + "%'");
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

        /// <summary>
        /// 初始化人员
        /// </summary>
        private void InitGrid(string filter)
        {           
            if (!String.IsNullOrEmpty(filter))
            {
                DataTable tmpCS = FilterDataTable(filter);
                GV_Main.DataSource = tmpCS.DefaultView;
            }
            else
            {
                GV_Main.DataSource = _dtCustomer.DefaultView;
            }            
        }
        /// <summary>
        /// 筛选人员
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private DataTable FilterDataTable(string filter)
        {
            DataTable tmpCS = new DataTable();
            tmpCS = _dtCustomer.Clone();
            if (_dtCustomer != null && _dtCustomer.Rows.Count > 0)
            {
                DataRow[] rows = _dtCustomer.Select(filter);
                for (int i = 0; i < rows.Length; i++)
                {
                    tmpCS.ImportRow(rows[i]);
                }
            }

            return tmpCS;
        }

        private void SelectUser()
        {
            if (GV_Main.SelectedRows != null)
            {
                DataGridViewSelectedRowCollection RowColl = GV_Main.SelectedRows;
                if (RowColl.Count > 0)
                {
                    string CustomerCode = RowColl[0].Cells["Cust_Code"].Value.ToString();
                    DataTable tmp = FilterDataTable("Cust_Code='" + CustomerCode + "'");
                    if (CallBack != null)
                    {
                        CallBack(this, tmp);
                    }
                    this.Close();
                }
            }      
        }

        private void CommCustomer_Load(object sender, EventArgs e)
        {

        }     
    }
}
