using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QX_Common.C_Class;

namespace QX.Common.C_Class
{
    public class TreeHelper<T,U>
    {
        private TreeView _tv;
        private T _obj;
        private DataTable _table;
        private string _pidFiled;
        private string _pidValue;
        private string _nameFiled;
        private string _tagFiled;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="tv">treeview对象</param>
        /// <param name="table">datatable数据对象</param>
        /// <param name="pidFiled">分级字段</param>
        /// <param name="pidValueField">分级字段值字段</param>
        /// <param name="nameFiled">显示字段</param>
        /// <param name="tagFiled">tag字段</param>
        public TreeHelper(TreeView tv, T obj, 
            string pidFiled, string pidValueField, string nameFiled,string tagFiled,string invokename,params object[] param)
        {
            _tv = tv;
            _obj = obj;
            _pidFiled = pidFiled;
            _nameFiled = nameFiled;
            _tagFiled = tagFiled;
            _pidValue = pidValueField;
            DynCompile dyn = new DynCompile();
            List<U> list = dyn.MemeberInvokeForList<T, U>(_obj, invokename, param);
            _table = ConvertX.ToDataTable<U>(list);
        }

        /// <summary>
        /// 将datatable数据绑定到treeview
        /// </summary>
        /// <param name="nds"></param>
        /// <param name="pidValue"></param>
        public void DataTableToTree(TreeNodeCollection nds ,string pidValue)
        {
            
            if (_table!=null && _table.Rows.Count!=0)
            {
                DataView dv = new DataView();
                TreeNode treeNode;
                dv.Table = _table;
                dv.RowFilter = _pidFiled + "='" + pidValue + "'";
                foreach (DataRowView item in dv)
                {
                    string _text = item[_nameFiled].ToString();
                    string _tag = item[_tagFiled].ToString();
                    if (!string.IsNullOrEmpty(item[_pidValue].ToString()))
                    {
                        pidValue = item[_pidValue].ToString();
                    }
                    else
                    {
                        pidValue = "";
                    }
                    treeNode = new TreeNode();
                    treeNode.Text = _text;
                    treeNode.Tag = _tag;
                    treeNode.Name = _tag;
                    nds.Add(treeNode);
                    DataTableToTree(treeNode.Nodes, pidValue);
                }            
            }            
        }
    }
}
