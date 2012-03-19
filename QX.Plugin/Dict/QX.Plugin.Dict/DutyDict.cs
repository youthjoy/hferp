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
    public partial class DutyDict :F_BseDic
    {
        public DutyDict()
        {
            InitializeComponent();
        }

        public DutyDict(string data)
        {
            InitializeComponent();

            DictKeyEnum keyEnum=(DictKeyEnum)DictKeyEnum.Parse(typeof(DictKeyEnum),data);
            base.Init(false, keyEnum, SysWinEnum.DictWin);
        }

        #region 窗体单例

        public static DutyDict NewForm = null;



        public static DutyDict Instance(string data)
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {

                NewForm = new DutyDict(data);
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        private void DutyDict_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Size = new Size(548, 468);

            base.Init(true, DictKeyEnum.DutyCat, SysWinEnum.DictWin);
        }
    }
}
