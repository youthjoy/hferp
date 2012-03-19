using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.InvInfo
{
    public partial class InvOut : F_BasicPop
    {
        public InvOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        public InvOut(List<Inv_Information> list)
        {
            InitializeComponent();

            this.dataSource = list;

            ToolBarInit();

        }


        private void ToolBarInit()
        {
            ToolStripHelper helper = new ToolStripHelper();

            this.tbOut.SaveClicked += new EventHandler(btnConfirm_Click);

            this.tbOut.AddCustomControl(helper.New("取消", QX.Common.Properties.Resources.cancel, new EventHandler(btnCancel_Click)));
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvOut_Load(object sender, EventArgs e)
        {

            InitData();

        }

        UltraGrid comGrid = new UltraGrid();
        GridHelper gen = new GridHelper();
        FormHelper formHelper = new FormHelper();
        private void InitData()
        {
            comGrid = gen.GenerateGrid("GInvOut", this.panel1, new Point(0, 0));
            formHelper.GenerateForm("CForm_InvOut", this.groupBox1, new Point(6, 20));

            this.comGrid.DataSource = dataSource;
            gen.SetExcelStyleFilter(comGrid);
            gen.SetGridReadOnly(comGrid, false);
            comGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            gen.SetGridColumnStyle(comGrid, AutoFitStyle.ExtendLastColumn);

        }

        private Dictionary<int, string> invList = new Dictionary<int, string>();


        private List<Inv_Information> dataSource = new List<Inv_Information>();

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SaveData();

        }
        private BindModelHelper bmHelper = new BindModelHelper();
        private void SaveData()
        {
            List<Inv_Information> list=SaveGrid();

            var MV_Owner = bmHelper.FindCtl<UltraCombo>(this.groupBox1.Controls, "MV_Owner");
            string ower = MV_Owner.Text;
            var MV_Date = bmHelper.FindCtl<UltraDateTimeEditor>(this.groupBox1.Controls, "MV_Date");

            DateTime opDate = DateTime.Parse(MV_Date.Value.ToString());

            if (string.IsNullOrEmpty(ower))
            {
                Alert.Show("经办人不能为空!");
            }
            else
            {


                string re = invInstance.UpdateInvInfoForList(list, ower, opDate);

                if (string.IsNullOrEmpty(re) && re.Length == 0)
                {
                    Alert.Show("出库操作成功!");
                    this.Close();
                }
                else
                {
                    Alert.Show("以下零件图号未能入库:" + re);
                }

            }

        }

        private List<Inv_Information> SaveGrid()
        {
            List<Inv_Information> list = new List<Inv_Information>();

            foreach (UltraGridRow row in this.comGrid.Rows)
            {
                var p = row.ListObject as Inv_Information;
                p.IInfor_Num = 1;
                list.Add(p);
            }

            return list;
        }
    }
}
