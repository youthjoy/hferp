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
    public partial class TitleDict :F_BseDic
    {
        public TitleDict()
        {
            InitializeComponent();
        }

        public TitleDict(string data)
        {
            InitializeComponent();

            DictKeyEnum keyEnum=(DictKeyEnum)DictKeyEnum.Parse(typeof(DictKeyEnum),data);
            base.Init(false, keyEnum, SysWinEnum.DictWin);
        }

        #region 窗体单例

        public static TitleDict NewForm = null;



        public static TitleDict Instance(string data)
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new TitleDict(data);
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void TitleDict_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(true, DictKeyEnum.TitleCat, SysWinEnum.DictWin);
        }
    }
}
