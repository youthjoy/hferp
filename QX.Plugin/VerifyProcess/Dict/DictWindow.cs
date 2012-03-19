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
    public partial class DictWindow : F_BseDic
    {
        public DictWindow()
        {
            InitializeComponent();
        }

        public DictWindow(string data)
        {
            try
            {
                InitializeComponent();

                string[] s = data.Split('|');

                if (s.Length == 1)
                {
                    DictKeyEnum keyEnum = (DictKeyEnum)DictKeyEnum.Parse(typeof(DictKeyEnum), data);
                    base.Init(false, keyEnum, SysWinEnum.DictWin);
                }
                else
                {
                    DictKeyEnum keyEnum = (DictKeyEnum)DictKeyEnum.Parse(typeof(DictKeyEnum), s[0]);
                    base.Init(false, keyEnum, SysWinEnum.DictWin);
                    this.Text = s[1];
                }


            }
            catch (Exception e)
            {

            }
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
