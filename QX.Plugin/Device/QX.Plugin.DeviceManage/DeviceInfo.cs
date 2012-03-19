using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.DataModel;
using QX.BLL;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BseDict;

namespace QX.Plugin.DeviceManage
{

    /// <summary>
    /// 操作类型
    /// </summary>
    //public enum OperationTypeEnum
    //{
    //    Add,
    //    Edit
    //}

    public partial class DeviceInfo : Form
    {
        public DeviceInfo()
        {
            InitializeComponent();
        }

        public DeviceInfo(Bll_Bse_Equ instance)
        {
            InitializeComponent();
            //默认为添加
            OperationType = OperationTypeEnum.OperationType.Add;
            equInstance = instance;
        }


        private BindModelHelper _bmHelper;

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }

        private Bll_Bse_Equ _equInstance;

        public Bll_Bse_Equ equInstance
        {
            get { return _equInstance; }
            set { _equInstance = value; }
        }


        #region 窗体单例

        public static DeviceInfo NewForm = null;




        public static DeviceInfo Instance()
        {
            if (NewForm == null || NewForm.IsDisposed == true)
            {
                NewForm = new DeviceInfo();
            }
            else
            {
                NewForm.Activate();
            }
            return NewForm;
        }

        #endregion

        /// <summary>
        /// 操作类型
        /// </summary>
        private OperationTypeEnum.OperationType _OperationType;

        public OperationTypeEnum.OperationType OperationType
        {
            get { return _OperationType; }
            set { _OperationType = value; }
        }


        //设备ID
        private string DeviceID
        {
            get;
            set;
        }

        private Bse_Equ _bseEqu = null;

        /// <summary>
        /// 当前窗体对应的编辑实体对象（）
        /// </summary>
        public Bse_Equ CurrentBseEqu
        {
            get { return _bseEqu; }
            set { _bseEqu = value; }
        }

        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }



        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type"></param>
        /// <param name="DevId"></param>
        public DeviceInfo(Bll_Bse_Equ instance, OperationTypeEnum.OperationType type, string DevId)
        {
            InitializeComponent();
            equInstance = instance;
            OperationType = type;
            DeviceID = DevId;
        }

        private void DeviceInfo_Load(object sender, EventArgs e)
        {
            Init();

        }

        private class ComboxBindData
        {
            public object Text
            {
                get;
                set;
            }

            public object Value
            {
                get;
                set;
            }
        }

        #region 数据初始化

        private void InitCombo()
        {
            DictComboHelper.BindComboData(this.Equ_Stat, DictKeyEnum.EquStat);

        }

        public void Init()
        {
            InitCombo();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {

                InitEditBind(DeviceID);
            }
            else
            {
                InitAddData();
            }
        }

        /// <summary>
        /// 添加模式初始化
        /// </summary>
        private void InitAddData()
        {
            bmHelper = new BindModelHelper();
            //如果为添加状态则不需要显示“应用”按钮
            this.btnApply.Visible = false;
        }



        /// <summary>
        /// 编辑模式初始化绑定
        /// </summary>
        private void InitEditBind(string id)
        {
            Bse_Equ equ = equInstance.GetEntiyByKey(id);
            bmHelper = new BindModelHelper();
            bmHelper.BindModelToControl<Bse_Equ>(equ, gpDevice.Controls);
            EventHandler handler = new EventHandler(this.contolValue_Changed);
            bmHelper.BindEventToControl(gpDevice.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpDevice.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpDevice.Controls, typeof(DateTimePicker), handler);
        }


        #endregion



        #region 按钮控件事件

        /// <summary>
        /// 控件值发生变化时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contolValue_Changed(object sender, EventArgs e)
        {
            IsEdited = true;
        }

        //确定按钮事件
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //数据是否有效，否则返回
            if (!ValidateData())
            {
                return;
            }


            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {
                //Bse_Equ equ = new Bse_Equ();

                ////ValidateControlHelper.ValidateEmpty<Bse_Equ>(gpDevice.Controls, equ);

                //equ.Equ_ID = long.Parse(DeviceID);

                //bmHelper.BindControlToModel<Bse_Equ>(equ, gpDevice.Controls);


                //if (equInstance.ModifyDeviceInfo(equ) >= 1)
                //{
                //    BseEqu = equ;
                //    //编辑成功后的处理
                //    MessageBox.Show("保存成功");
                //    IsEdited = false;
                //    this.Close();
                //    //this.Close();
                //}
                //else
                //{
                //    //失败原因显示
                //    //todo
                //}


                if (EditDevice())
                {
                    Alert.Show("编辑成功!");
                    this.Close();
                }
                else
                {
                    Alert.Show("编辑失败!");
                }

            }//添加处理
            else
            {
                //Bse_Equ equ = new Bse_Equ();
                //bmHelper.BindControlToModel<Bse_Equ>(equ, gpDevice.Controls);



                //CurrentBseEqu = equInstance.AddDevice(equ);
                //if (CurrentBseEqu != null && CurrentBseEqu.Equ_ID != 0)
                //{
                //    //BseEqu = equ;
                //    //添加成功后的处理
                //    MessageBox.Show("添加成功");
                //    this.Close();
                //}
                //else
                //{
                //    //失败原因显示
                //    //todo
                //}

                if (AddDevice())
                {
                    Alert.Show("添加成功!");
                    this.Close();
                }
                else
                {
                    Alert.Show("添加失败!");
                }

            }
        }

        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //MSGCon msg = new MSGCon("是否需要保存当前编辑数据?");
            //msg.ShowDialog();
            CloseForm();
        }

        //关闭窗口处理方法
        private void CloseForm()
        {
            if (IsEdited)
            {
                //MSGCon msg = new MSGCon("确定放弃保存当前编辑数据，关闭该窗口?");
                //msg.StartPosition = FormStartPosition.CenterParent;
                //msg.ShowDialog();

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

        private void DeviceInfo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            //数据是否有效，否则返回
            if (!ValidateData())
            {
                return;
            }

            if (OperationType == OperationTypeEnum.OperationType.Edit)
            {


                if (EditDevice())
                {
                    Alert.Show("编辑成功!");
                }
                else
                {
                    Alert.Show("编辑失败!");
                }


            }//添加处理
            else
            {
                if (AddDevice())
                {
                    Alert.Show("添加成功!");
                }
                else
                {
                    Alert.Show("添加失败!");
                }

            }
        }

        private bool ValidateData()
        {
            #region 数据有效性验证

            bool flag = true;

            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("Equ_Code", new ValidateModel(true, 20, 0, new string[] { "设备编号不能为空", "设备编号字符数不能超过20个" }));
            dict.Add("Equ_Name", new ValidateModel(true, 20, 0, new string[] { "设备名称不能为空", "设备名称字符数不能超过20个" }));
            //dict.Add("

            Dictionary<string, string> re = ValidateControlHelper.Validate(gpDevice.Controls, dict);

            if (re.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<string, string> k in re)
                {
                    //Control c = this.Controls.Find("lb" + k, true);
                    sb.AppendLine(k.Value);
                }

                Alert.Show(sb.ToString());

                flag = false;
            }

            return flag;

            #endregion
        }

        private bool EditDevice()
        {
            Bse_Equ equ = new Bse_Equ();
            //List<string> re=ValidateControlHelper.ValidateEmpty<Bse_Equ>(gpDevice.Controls, equ);


            equ.Equ_ID = long.Parse(DeviceID);

            bmHelper.BindControlToModel<Bse_Equ>(equ, gpDevice.Controls);


            if (equInstance.ModifyDeviceInfo(equ) >= 1)
            {
                CurrentBseEqu = equ;
                //编辑成功后的处理
                //MessageBox.Show("编辑成功");
                IsEdited = false;
                //this.Close();
                return true;
            }
            else
            {
                //失败原因显示
                //todo
                return false;
            }

        }


        public bool AddDevice()
        {
            Bse_Equ equ = new Bse_Equ();
            bmHelper.BindControlToModel<Bse_Equ>(equ, gpDevice.Controls);

            CurrentBseEqu = equInstance.AddDevice(equ);
            if (CurrentBseEqu != null && CurrentBseEqu.Equ_ID != 0)
            {
                //BseEqu = equ;
                //添加成功后的处理
                //MessageBox.Show("添加成功");
                //this.Close();
                return true;
            }
            else
            {
                //失败原因显示
                //todo
                return false;
            }
        }

        #endregion
    }
}
