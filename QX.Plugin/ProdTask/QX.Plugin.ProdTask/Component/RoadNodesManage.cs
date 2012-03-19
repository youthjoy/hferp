using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BseDict;
using QX.BLL;

namespace QX.Plugin.RoadCateManage
{
    public partial class RoadNodesManage :F_BseDic
    {
        public RoadNodesManage()
        {
            InitializeComponent();
        }


        #region 窗体单例

        public static RoadNodesManage NewForm = null;



        public static RoadNodesManage Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new RoadNodesManage();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void RoadNodesManage_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(false, DictKeyEnum.RoadNode, SysWinEnum.DictWin);
        }
    }
}
