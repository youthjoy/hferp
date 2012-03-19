using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;
using System.Reflection;
using QX.Common.C_Class;
using QX.Framework.AutoForm;

namespace QX.Plugin.SystemInfo
{
    public partial class F_SystemInfo :Form
    {
        #region 窗体单例
        public static F_SystemInfo NewForm = null;
        public static F_SystemInfo Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new F_SystemInfo();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }
        #endregion

        private Bll_Bse_SysInfo instance = new Bll_Bse_SysInfo();
        private BSE_SysInfo GModel;
        
        public F_SystemInfo()
        {
            InitializeComponent();            
        }

        private void F_SystemInfo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            InitBind();
        }

        private BindModelHelper bmHelper = new BindModelHelper();

        /// <summary>
        /// 初始化绑定
        /// </summary>
        private void InitBind()
        {
            FormHelper gen = new FormHelper();

            gen.GenerateForm("BSE_SysInfo",this.groupBox1,new Point(30,20));

            gen.GenerateForm("FBank_SysInfo", this.panel1, new Point(30, 20));

            gen.GenerateForm("FAddr_SysInfo", this.panel2, new Point(30, 20));

            gen.GenerateForm("FOther_SysInfo", this.panel3, new Point(30, 20));




            GModel = instance.GetSysInfo();
            if (GModel != null)
            {
                bmHelper.BindModelToControl<BSE_SysInfo>(GModel, this.groupBox1.Controls, "");
                bmHelper.BindModelToControl<BSE_SysInfo>(GModel, this.panel1.Controls, "");
                bmHelper.BindModelToControl<BSE_SysInfo>(GModel, this.panel2.Controls, "");
                bmHelper.BindModelToControl<BSE_SysInfo>(GModel, this.panel3.Controls, "");
                //PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(BSE_SysInfo));
                //foreach (Control item in groupBox1.Controls)
                //{
                //    if (item.GetType() == typeof(TextBox))
                //    {
                //        if (p[item.Name].GetValue(oo)!=null)
                //        {
                //            item.Text = p[item.Name].GetValue(oo).ToString();
                //        }
                //    }
                //}
            }
        }

        /// <summary>
        /// 修改系统配置信息
        /// </summary>
        /// <returns></returns>
        private bool UpdateSysInfo()
        {
            bool result = false;
            try
            {
                if (GModel==null)
                    GModel = new BSE_SysInfo();

                bmHelper.BindControlToModel<BSE_SysInfo>(GModel, this.groupBox1.Controls,"");
                bmHelper.BindControlToModel<BSE_SysInfo>(GModel, this.panel1.Controls,"");
                bmHelper.BindControlToModel<BSE_SysInfo>(GModel, this.panel2.Controls,"");
                bmHelper.BindControlToModel<BSE_SysInfo>(GModel, this.panel3.Controls,"");
                //PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(BSE_SysInfo));
                //foreach (Control item in groupBox1.Controls)
                //{
                //    if (item.GetType() == typeof(TextBox))
                //    {
                //        p[item.Name].SetValue(model, item.Text);
                //    }
                //}
            }
            catch (Exception ex){
                
            }
            if (GModel != null)
            {
                result = instance.UpdateSysInfo(GModel);
            }
            return result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            bool result = UpdateSysInfo();
            if (result)
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
                this.Close();
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
            }        
            
        }

        private bool ValidateData()
        {
            #region 数据有效性验证
            bool flag = true;
            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("Sys_CName", new ValidateModel(true, 50, 0, new string[] { "单位名称不能为空", "单位名称不能超过50个字符" }));
            Dictionary<string, string> re = ValidateControlHelper.Validate(groupBox1.Controls, dict);
            if (re.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<string, string> k in re)
                {
                    sb.AppendLine(k.Value);
                }
                Alert.Show(sb.ToString());
                flag = false;
            }
            return flag;
            #endregion
        }

    }
}
