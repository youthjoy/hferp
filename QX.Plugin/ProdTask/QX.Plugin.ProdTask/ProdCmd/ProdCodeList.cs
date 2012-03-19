using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using System.Collections;
using QX.DataModel;

namespace QX.Plugin.Cmd
{
    public partial class ProdCodeList : Form
    {
        public ProdCodeList(string cmdCode, string dCmdCode)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
        }

        private OperationTypeEnum.OperationType opType
        {
            get;
            set;
        }

        public ProdCodeList(string cmdCode, string dCmdCode, bool isLook)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
            if (isLook)
            {
                opType = OperationTypeEnum.OperationType.Look;

                this.panel1.Visible = false;
                this.btnConfirm.Visible = false;

            }
            else
            {
                opType = OperationTypeEnum.OperationType.Edit;
            }
        }


        public ProdCodeList(string cmdCode, string dCmdCode,OperationTypeEnum.OperationType op)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
            opType = op;
        }

        private List<Prod_CodeMap> InitSource
        {
            get;
            set;
        }

        private string CmdCode
        {
            get;
            set;
        }

        private string DetailCode
        {
            get;
            set;
        }

        private

        void ProdCodeList_Load(object sender, EventArgs e)
        {
            InitGrid();
            RefreshGrid();
        }

        UltraGrid comGrid = new UltraGrid();

        private BLL.Bll_Prod_CmdDetail pdInstance = new QX.BLL.Bll_Prod_CmdDetail();

        private BLL.Bll_Inv_Information iiInstance = new QX.BLL.Bll_Inv_Information();

        private GridHelper gen = new GridHelper();

        List<Prod_CodeMap> ExsistCode
        {
            get;
            set;
        }
        /// <summary>
        /// 已出库零件编号
        /// </summary>
        List<Inv_Information> OutCode
        {
            get;
            set;
        }

        public void InitGrid()
        {
            List<Prod_CodeMap> list = new List<Prod_CodeMap>();
            comGrid = gen.GenerateGrid("CList_CodeMap", this.pnlGrid, new Point(0, 0));
            BindingSource source = new BindingSource();
            InitSource = list;
            source.DataSource = list;
            comGrid.DataSource = source;

            ExsistCode = pdInstance.GetAllMapList(CmdCode, DetailCode);
            OutCode = iiInstance.GetOutInvInfoListFor();
            comGrid.InitializeRow += new InitializeRowEventHandler(comGrid_InitializeRow);


        }

        void comGrid_InitializeRow(object sender, InitializeRowEventArgs e)
        {

            Prod_CodeMap map = e.Row.ListObject as Prod_CodeMap;
            if (!string.IsNullOrEmpty(map.PMap_Stat))
            {
                e.Row.Appearance.BackColor = Color.Wheat;
            }



        }

        // public void IsExsitRepeat()
        //{
        //    foreach (var row in this.comGrid.Rows)
        //    {

        //    }
        // }

        public void RefreshGrid()
        {
            List<Prod_CodeMap> list = new List<Prod_CodeMap>();

            list = pdInstance.GetMapList(CmdCode, DetailCode);

            BindingSource source = new BindingSource();
            source.DataSource = list;
            InitSource = list;
            comGrid.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtStart.Text))
            {
                Alert.Show("起始编号不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtEnd.Text))
            {
                Alert.Show("结束编号不能为空!");
                return;
            }

            int start = Common.C_Class.Utils.TypeConverter.StrToInt(this.txtStart.Text);
            int end = Common.C_Class.Utils.TypeConverter.StrToInt(this.txtEnd.Text);

            if (start > end)
            {
                Alert.Show("起始编号不能小于结束编号!");
                return;
            }

            string prefix = this.txtPrefix.Text;

            for (int i = start; i <= end; i++)
            {
                var row = comGrid.DisplayLayout.Bands[0].AddNew();
                row.Cells["PMap_PCode"].Value = prefix + i.ToString();
                string code = prefix + i.ToString();

                if (ExsistCode.FirstOrDefault(o => code == o.PMap_PCode) != null && OutCode.FirstOrDefault(o => o.IInfor_ProdCode == code) == null)
                {
                    row.RowSelectorAppearance.BackColor = Color.Red;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Prod_CodeMap> list = new List<Prod_CodeMap>();

            StringBuilder sb = new StringBuilder();
            bool isRepeat = false;
            foreach (var row in comGrid.Rows)
            {
                Prod_CodeMap map = row.ListObject as Prod_CodeMap;
                map.PMap_MCode = DetailCode;
                map.PMap_PlanDate = DateTime.Now;
                //如果产品未出库并且已存在该编号
                if ((ExsistCode.FirstOrDefault(o => o.PMap_PCode == map.PMap_PCode) != null&&OutCode.FirstOrDefault(o=>o.IInfor_ProdCode==map.PMap_PCode)==null))
                {
                    isRepeat = true;
                    sb.Append(map.PMap_PCode).Append(",");
                    continue;
                }
                else if (list.FirstOrDefault(o => o.PMap_PCode == map.PMap_PCode) != null)
                {
                    isRepeat = true;
                    sb.Append(map.PMap_PCode).Append(",");
                    continue;
                }

                map.PMap_Module = CmdCode;
                list.Add(map);
            }
            if (isRepeat)
            {
                string repeatCode = sb.ToString().Trim(',');
                Alert.Show(string.Format("以下零件编号存在重复{0},",repeatCode));
                return;
            }
            var flag = pdInstance.AddOrUpdateProdCode(CmdCode, DetailCode, list);

            if (flag)
            {
                Alert.Show("数据更新完成!");

                this.Close();

            }
            else
            {
                Alert.Show("数据更新失败!");
            }
        }
    }
}
