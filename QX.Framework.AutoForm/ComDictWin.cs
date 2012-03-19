using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.DataAceess;
using QX.DataModel;
using QX.BLL;
using QX.Common.C_Class;

namespace QX.Framework.AutoForm
{
    public partial class ComDictWin : Form
    {
        private string _defaultModule = "CForm_BseDict";
        private string _defaultKey;
        private Bse_Dict GModel = new Bse_Dict();
        private Bll_Bse_Dict mainInstance = null;
        BindModelHelper bindHelper = new BindModelHelper();
        FormHelper formHelper = new FormHelper();

        public ComDictWin()
        {
            InitializeComponent();
        }
        public ComDictWin(string dictKey)
        {
            InitializeComponent();

            _defaultKey = dictKey;
        }

        #region CForm_BseDict工具栏初始化
        public void InitToolBar_CForm_BseDict()
        {
            //我的毛坯采购计划
            tool_bar_CForm_BseDict.AddClicked += new EventHandler(tool_bar_CForm_BseDict_AddClicked);
            tool_bar_CForm_BseDict.EditClicked += new EventHandler(tool_bar_CForm_BseDict_EditClicked);
            tool_bar_CForm_BseDict.DelClicked += new EventHandler(tool_bar_CForm_BseDict_DelClicked);
            tool_bar_CForm_BseDict.RefreshClicked += new EventHandler(tool_bar_CForm_BseDict_RefreshClicked);
        }

        void tool_bar_CForm_BseDict_DelClicked(object sender, EventArgs e)
        {
            //UltraGridRow row = this.ug_CForm_BseDict.ActiveRow;
            //if (row != null)
            //{
            //    Bse_Dict main = row.ListObject as Bse_Dict;
            //    if (instCForm_BseDict.Delete(main))
            //    {
            //        Alert.Show(GlobalConfiguration.CNLanguage[GlobalConfiguration.OperationMessage.comm_success.ToString()]);
            //        RefreshCForm_BseDict();
            //    }
            //    else
            //    {
            //        Alert.Show(GlobalConfiguration.CNLanguage[GlobalConfiguration.OperationMessage.comm_fail.ToString()]);
            //    }
            //}
        }

        void tool_bar_CForm_BseDict_RefreshClicked(object sender, EventArgs e)
        {
            //RefreshCForm_BseDict();
        }

        void tool_bar_CForm_BseDict_EditClicked(object sender, EventArgs e)
        {
            //UltraGridRow row = this.ug_CForm_BseDict.ActiveRow;
            //if (row != null)
            //{
            //    Bse_Dict main = row.ListObject as Bse_Dict;

            //    AA frm = new AA(instCForm_BseDict, main, false);
            //    frm.OperationType = OperationTypeEnum.OperationType.Edit;
            //    frm.ShowDialog();
            //}
        }

        void tool_bar_CForm_BseDict_AddClicked(object sender, EventArgs e)
        {
            //AA frm = new AA(instCForm_BseDict, null);
            //frm.OperationType = OperationTypeEnum.OperationType.Add;
            //frm.ShowDialog();
        }
        #endregion

        private void RefreshTreeViewControls()
        {
            List<Bse_Dict> list = new List<Bse_Dict>();
            list = this.mainInstance.GetListByDictKey(_defaultKey);
        }

        private void RefreshFormControls()
        {
            formHelper.GenerateForm(_defaultModule, this.groupBox1, new Point(6, 20));
            Sys_PD_Module module = groupBox1.Tag as Sys_PD_Module;
            bindHelper.BindModelToControl<Bse_Dict>(GModel, this.groupBox1.Controls, module.SPM_TPrefix);
        }
    }
}
