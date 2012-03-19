using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;

namespace QX.Plugin.InvInfo
{
    public partial class InvOut :F_BasicPop
    {
        public InvOut()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        public InvOut(Dictionary<int, string> list)
        {
            InitializeComponent();

            this.invList = list;
        }

        private Dictionary<int, string> invList = new Dictionary<int, string>();

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string ower = this.MV_Owner.Text;
            DateTime opDate = this.MV_Date.Value;
            if (string.IsNullOrEmpty(ower))
            {
                Alert.Show("经办人不能为空!");
            }
            else
            {
                string re = invInstance.UpdateInvInfoForList(invList, ower, opDate);
                if (string.IsNullOrEmpty(re) && re.Length == 0)
                {
                    Alert.Show("出库操作成功!");
                    this.Close();
                }
                else
                {
                    Alert.Show("以下零件图号未能入库:"+re);
                }

            }


        }

        private void InvOut_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }
    }
}
