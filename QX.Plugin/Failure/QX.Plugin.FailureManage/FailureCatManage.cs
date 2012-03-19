using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BseDict;
using QX.BLL;

namespace QX.Plugin.FailureManage
{
    public partial class FailureCatManage : F_BseDic
    {
        public FailureCatManage()
        {
            InitializeComponent();
        }
        #region 窗体单例

        public static FailureCatManage NewForm = null;

        public static FailureCatManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new FailureCatManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void FailureCatManage_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(true, DictKeyEnum.FailureCat, SysWinEnum.DictWin);
        }
    }
}
