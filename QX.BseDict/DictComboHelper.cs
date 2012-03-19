using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.DataModel;

namespace QX.BseDict
{
    public class DictComboHelper
    {

        private static Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        public static void BindComboData(ComboBox combox,DictKeyEnum dKey)
        {
            List<Bse_Dict> list = dcInstance.GetListByDictKeyByNoRoot(dKey);
            combox.DataSource = list;
            combox.DisplayMember = "Dict_Name";
            combox.ValueMember = "Dict_Code";
        }
    }
}
