using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;
using QX.DataModel;
using Infragistics.Win.UltraWinGrid;

namespace QX.Plugin.InvInfo
{
    public partial class InvMaintain : Form
    {
        public InvMaintain()
        {
            InitializeComponent();
        }

        public InvMaintain(string code)
        {
            InitializeComponent();

            this.ProdCode = code;


        }

        private void InvMaintain_Load(object sender, EventArgs e)
        {
            BindEvent();

            InitData();
        }

        #region Member

        private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        private string _prodCode;
        //零件编号 
        public string ProdCode
        {
            get { return _prodCode; }
            set { _prodCode = value; }
        }

        private BindModelHelper _bmHelper=new BindModelHelper();
        /// <summary>
        /// 绑定数据Handler
        /// </summary>
        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }


        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }

        private Inv_Information InvInfor;

        #endregion

        private void BindEvent()
        {
            this.btnConfirm.Click += new EventHandler(btnConfirm_Click);

            this.btnCancel.Click += new EventHandler(btnCancel_Click);
        }



        public void InitData()
        {
            this.IInfor_ProdCode.ReadOnly = true;
            this.IInfor_PartNo.ReadOnly = true;
            
            InvInfor = invInstance.GetInvInfoByCode(ProdCode);

            bmHelper.BindModelToControl<Inv_Information>(InvInfor, gpInv.Controls);


            EventHandler handler = new EventHandler(this.contolValue_Changed);

            bmHelper.BindEventToControl(gpInv.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpInv.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpInv.Controls, typeof(DateTimePicker), handler);
        }

        /// <summary>
        /// 控件值发生变化时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contolValue_Changed(object sender, EventArgs e)
        {
            IsEdited = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (!ValidateData())
            {
                return;  
            }

            bool re = UpdateProde();
            if (re)
            {
                Alert.Show("更新零件库存信息成功！");
                this.Close();
            }
            else
            {
                Alert.Show("更新零件库存信息失败，请查证后重新输入确认!");
                //this.Close();
            }

        }

        private bool UpdateProde()
        {

            Inv_Information inv = InvInfor;
            bmHelper.BindControlToModel<Inv_Information>(inv, gpInv.Controls);
            //出库（成品进入带出库列表）
            int re = invInstance.UpdateInvInfo(inv);
            if (re > 0)
            {
                IsEdited = false;

                return true;
            }
            {
                return false;
            }
        }

        private bool ValidateData()
        {
            return true;

            #region 数据有效性验证

            //bool flag = true;

            //Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            //dict.Add("Comp_Code", new ValidateModel(true, 20, 0, new string[] { "零件", "设备编号字符数不能超过20个" }));
            //dict.Add("Comp_Name", new ValidateModel(true, 20, 0, new string[] { "；零件名称不能为空", "设备名称字符数不能超过20个" }));
            ////dict.Add("

            //Dictionary<string, string> re = ValidateControlHelper.Validate(gpCompt.Controls, dict);

            //if (re.Count != 0)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    foreach (KeyValuePair<string, string> k in re)
            //    {
            //        //Control c = this.Controls.Find("lb" + k, true);
            //        sb.AppendLine(k.Value);
            //    }

            //    Alert.Show(sb.ToString());

            //    flag = false;
            //}

            //return flag;

            #endregion
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        //关闭窗口处理方法
        private void CloseForm()
        {
            if (IsEdited)
            {

                DialogResult dialog = Alert.Show(MessageBoxButtons.OKCancel, "确定放弃保存当前编辑数据，关闭该窗口?");


                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }


    }
}
