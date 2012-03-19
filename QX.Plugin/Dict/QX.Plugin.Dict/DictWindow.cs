using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.DataModel;
using System.Reflection;
using System.Collections;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BseDict;


namespace QX.Plugin.Dict
{
    public partial class DictWindow :F_BseDic
    {
        public DictWindow()
        {
            InitializeComponent();
        }

        public DictWindow(string data)
        {
            InitializeComponent();

            DictKeyEnum keyEnum=(DictKeyEnum)DictKeyEnum.Parse(typeof(DictKeyEnum),data);
            base.Init(false, keyEnum, SysWinEnum.DictWin);
        }

        #region 窗体单例

        public static DictWindow NewForm = null;



        public static DictWindow Instance(string data)
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new DictWindow(data);
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void DictWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
