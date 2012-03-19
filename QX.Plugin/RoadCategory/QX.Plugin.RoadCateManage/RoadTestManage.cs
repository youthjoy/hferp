using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.BseDict;

namespace QX.Plugin.RoadCateManage
{
    public partial class RoadTestManage :F_BseDic
    {
        public RoadTestManage()
        {
            InitializeComponent();
        }

        #region 窗体单例

        public static RoadTestManage NewForm = null;



        public static RoadTestManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new RoadTestManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void RoadTestManage_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(false, DictKeyEnum.RoadTest, SysWinEnum.DictWin);
        }
    }
}
