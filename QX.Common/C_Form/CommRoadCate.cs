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
    public partial class CommRoadCate : Form
    {
        public CommRoadCate()
        {
            InitializeComponent();
        }

        private void CommRoadCate_Load(object sender, EventArgs e)
        {

        }


        public delegate void DCallBackHandler(object sender, DataTable list);
        public event DCallBackHandler CallBack;

        //private string _pidFiled;
        //private string _pidValueFiled;
        private string _nameFiled;
        private string _tagFiled;
        //private DataTable _dtDept;
        //private DataTable _dtUser;
        private DataTable _dtData;

        public CommRoadCate(DataTable dt,Size size)
        {
            InitializeComponent();
            //GV_Main.AutoGenerateColumns = false;
            this.Size = size;
            //this._pidFiled = pidFiled;
            //this._pidValueFiled = pidValueFiled;
            //this._nameFiled = nameField;
            //this._tagFiled = tagField;
            //this._dtDept = dtDept;
            //this._dtUser = dtUser;
            _dtData=dt;
            //初始化
            Init();

            //tvDept.AfterSelect += new TreeViewEventHandler(tvDept_AfterSelect);
            //GV_Main.CellDoubleClick += new DataGridViewCellEventHandler(GV_Main_CellDoubleClick);
            //btnFind.Click += new EventHandler(btnFind_Click);
            //tbSearchText.TextChanged += new EventHandler(tbSearchText_TextChanged);
            btnOK.Click += new EventHandler(btnOK_Click);
            //btnFresh.Click += new EventHandler(btnFresh_Click);
        }

        private void Init()
        {
            //InitTree(this.tvMain.Nodes, null);


            if (_dtData.Rows.Count != 0)
            {
                InitTree(this.tvMain.Nodes, null);
                this.tvMain.Nodes[0].Expand();
            }
        }



        /// <summary>
        /// 初始化树控件
        /// </summary>
        /// <param name="Nds"></param>
        /// <param name="parentId"></param>
        private void InitTree(TreeNodeCollection Nds, string parentId)
        {
            DataView dv = new DataView();
            TreeNode tmpNd;
            string intId;
            dv.Table = _dtData;

            if (string.IsNullOrEmpty(parentId))
            {
                dv.RowFilter = "Dict_PCode is null";
            }
            else
            {
                dv.RowFilter = "Dict_PCode='" + parentId + "'";
            }

            foreach (DataRowView drv in dv)
            {
                tmpNd = new TreeNode();

                tmpNd.Tag = drv["Dict_Code"].ToString();
                tmpNd.Text = drv["Dict_Name"].ToString();

                Nds.Add(tmpNd);
                intId = drv["Dict_PCode"].ToString();
                InitTree(tmpNd.Nodes, tmpNd.Tag.ToString());
            }
        }



        //void btnFresh_Click(object sender, EventArgs e)
        //{
        //    this.Refresh();
        //}

        void btnOK_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode != null)
            {
                string filter =  "Dict_Code='" + tvMain.SelectedNode.Tag.ToString() + "'";
                DataTable tmpDt = new DataTable();
                tmpDt = _dtData.Clone();
                DataRow[] list = _dtData.Select(filter);
                for (int i = 0; i < list.Length; i++)
                {
                    tmpDt.ImportRow((DataRow)list[i]);
                }
                if (CallBack != null)
                {
                    CallBack(tvMain.SelectedNode, tmpDt);
                }
                this.Close();
            }
        }

        //void tbSearchText_TextChanged(object sender, EventArgs e)
        //{
        //    btnFind_Click(this, EventArgs.Empty);
        //}

        //void btnFind_Click(object sender, EventArgs e)
        //{
        //    string txt = tbSearchText.Text;
        //    if (!String.IsNullOrEmpty(txt))
        //    {
        //        DataTable tmp = FilterDataTable("Emp_Name like '%"+txt+"%'");
        //        GV_Main.DataSource = tmp.DefaultView;
        //    }
        //}

        //void GV_Main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    SelectUser();
        //}

        //void tvDept_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    string selectText = tvDept.SelectedNode.Tag != null ? tvDept.SelectedNode.Tag.ToString() : string.Empty;
        //    if (!string.IsNullOrEmpty(selectText))
        //    {
        //        string filter = "Emp_Dept_Code='"+selectText+"'";
        //        if (tvDept.SelectedNode.Level==0)
        //        {
        //            filter = "";
        //        }
        //        InitGrid(filter);                
        //    }
        //}

        ///// <summary>
        ///// 初始化人员
        ///// </summary>
        //private void InitGrid(string filter)
        //{           
        //    if (!String.IsNullOrEmpty(filter))
        //    {
        //        DataTable tmpDT = FilterDataTable(filter);
        //        GV_Main.DataSource = tmpDT.DefaultView;
        //    }
        //    else
        //    {
        //        GV_Main.DataSource = _dtUser.DefaultView;
        //    }            
        //}
        ///// <summary>
        ///// 筛选人员
        ///// </summary>
        ///// <param name="filter"></param>
        ///// <returns></returns>
        //private DataTable FilterDataTable(string filter)
        //{
        //    DataTable tmpDT = new DataTable();
        //    tmpDT = _dtUser.Clone();
        //    if (_dtUser!=null && _dtUser.Rows.Count>0)
        //    {
        //        DataRow[] rows = _dtUser.Select(filter);
        //        for (int i = 0; i < rows.Length; i++)
        //        {
        //            tmpDT.ImportRow(rows[i]);
        //        }
        //    }
            
        //    return tmpDT;
        //}

        //private void SelectUser()
        //{
        //    if (GV_Main.SelectedRows != null)
        //    {
        //        DataGridViewSelectedRowCollection RowColl = GV_Main.SelectedRows;
        //        if (RowColl.Count > 0)
        //        {
        //            string EmpolyeeCode = RowColl[0].Cells["Emp_Code"].Value.ToString();
        //            DataTable tmp = FilterDataTable("Emp_Code='" + EmpolyeeCode + "'");
        //            if (CallBack != null)
        //            {
        //                CallBack(this, _dtUser);
        //            }
        //            this.Close();
        //        }
        //    }      
        //}
    }
}
