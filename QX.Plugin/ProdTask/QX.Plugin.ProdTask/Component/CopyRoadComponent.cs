using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.BLL;
using QX.Common.C_Class;
using QX.DataModel;
using QX.Common.C_Form;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinEditors;

namespace QX.Plugin.RoadCateManage
{
    public partial class CopyRoadComponent :F_BasicPop
    {
        public CopyRoadComponent()
        {
            InitializeComponent();
        }

        private FormHelper gen = new FormHelper();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">窗体对应模态（添加，修改，复制）</param>
        /// <param name="code">对应零件图号编码</param>
        public CopyRoadComponent(OperationTypeEnum.OperationType type, string code)
        {
            InitializeComponent();
            //rcInstance = instance;
            OperationType = type;
            CompCode = code;

            BindEvent();
        }

        private void BindEvent()
        { 
            this.btnConfirm.Click+=new EventHandler(btnConfirm_Click);
            this.btnCancel.Click+=new EventHandler(btnCancel_Click);
            //this.Comp_CatName.Click += new EventHandler(this.roadCate_Click);
        }

        private void CopyRoadComponent_Load(object sender, EventArgs e)
        {
            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Copy:
                    InitCopyData(CompCode);
                    break;
            }
        }

        #region Member



        /// <summary>
        /// Bll层操作对象
        /// </summary>
        //private Bll_Road_Components rcInstance = new Bll_Road_Components();

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

      
        private BindModelHelper _bmHelper;

        private BindModelHelper bmHelper
        {
            get { return _bmHelper; }
            set { _bmHelper = value; }
        }



        /// <summary>
        /// Bll层操作对象
        /// </summary>
        private Bll_Road_Components rcInstance = new Bll_Road_Components();

        //private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        /// <summary>
        /// 操作类型
        /// </summary>
        private OperationTypeEnum.OperationType _OperationType;

        public OperationTypeEnum.OperationType OperationType
        {
            get { return _OperationType; }
            set { _OperationType = value; }
        }


        //零件图号编码（复制状态下其表示当前复制目标对象编码）
        private string _CompCode;

        public string CompCode
        {
            get { return _CompCode; }
            set { _CompCode = value; }
        }


        private Road_Components _RoadCompt = null;

        /// <summary>
        /// 当前窗体对应的编辑实体对象（）
        /// </summary>
        public Road_Components CurrentRoadCompt
        {
            get { return _RoadCompt; }
            set { _RoadCompt = value; }
        }

        private bool _IsEdited = false;

        public bool IsEdited
        {
            get { return _IsEdited; }
            set { _IsEdited = value; }
        }




        #region 数据初始化







        /// <summary>
        /// 添加模式初始化
        /// </summary>
        private void InitAddData()
        {
            //bmHelper = new BindModelHelper();

            //CurrentRoadCompt = new Road_Components();

            //EventHandler handler = new EventHandler(this.contolValue_Changed);

            //bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            //bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            //bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);

            //如果为添加状态则不需要显示“应用”按钮
            //this.btnApply.Visible = false;
        }



        /// <summary>
        /// 编辑模式初始化绑定
        /// </summary>
        private void InitEditBind(string code)
        {
            //Road_Components rc = rcInstance.GetRoadComponentByCode(code);

            //CurrentRoadCompt = rc;

            //bmHelper = new BindModelHelper();
            //bmHelper.BindModelToControl<Road_Components>(rc, gpCompt.Controls);

            //EventHandler handler = new EventHandler(this.contolValue_Changed);

            //bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            //bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            //bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);
        }

        private void InitCopyData(string Code)
        {
            gen.GenerateForm("CForm_Copy", this.gpCompt, new Point(6, 20));


            Road_Components rc = rcInstance.GetRoadComponentByCode(Code);

            CurrentRoadCompt = rc;

            bmHelper = new BindModelHelper();
            bmHelper.BindModelToControl<Road_Components>(rc, gpCompt.Controls);

            EventHandler handler = new EventHandler(this.contolValue_Changed);

            bmHelper.BindEventToControl(gpCompt.Controls, typeof(TextBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(ComboBox), handler);
            bmHelper.BindEventToControl(gpCompt.Controls, typeof(DateTimePicker), handler);

            SetMode(OperationTypeEnum.OperationType.Copy);
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


        private void roadCate_Callback(object sender, DataTable list)
        {
            //if (list != null && list.Rows.Count > 0)
            //{
            //    this.Comp_CatName.Text = list.Rows[0]["Dict_Name"] != null ? list.Rows[0]["Dict_Name"].ToString() : string.Empty;
            //    this.Comp_CatCode.Text = list.Rows[0]["Dict_Code"] != null ? list.Rows[0]["Dict_Code"].ToString() : string.Empty;
            //}
        }

        private void roadCate_Click(object sender, EventArgs e)
        {
            DataTable dtRoad = ConvertX.ToDataTable(dcInstance.GetListByDictKey(DictKeyEnum.RoadCate));
            dtRoad.TableName = "roadCateList";
            //DataTable dtUser = ConvertX.ToDataTable(employeeInstance.GetAllEmployee());
            //dtUser.TableName = "userlist";
            CommRoadCate rCate = new CommRoadCate(dtRoad, new Size(460, 380));
            rCate.CallBack += new CommRoadCate.DCallBackHandler(this.roadCate_Callback);
            rCate.ShowDialog();
        }




        //确定按钮事件
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //数据是否有效，否则返回
            if (!ValidateData())
            {
                return;
            }

            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Copy:

                    QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
                         , QX.Shared.SessionConfig.UserName
                         , "localhost"
                         , this.Name
                         , DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Components
                         , QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Components.ToString(), QX.Common.LogType.Edit.ToString());

                    if (AddAndCopyComponents() > 0)
                    {
                        Alert.Show("复制成功");
                        this.Close();
                    }

                    break;
            }

            //if (OperationType == OperationTypeEnum.OperationType.Edit)
            //{



            //    switch (EditEntity())
            //    {
            //        case 0: Alert.Show("编辑失败"); break;
            //        case 1:
            //            Alert.Show("编辑成功");
            //            //this.Close(); 
            //            break;
            //        case 2: Alert.Show("零件图号已重复，请重新输入!"); break;
            //    }


            //}//添加处理
            //else
            //{
            //    switch (AddEntity())
            //    {
            //        case 0: Alert.Show("添加失败"); break;
            //        case 1:
            //            Alert.Show("添加成功");
    
            //            ////添加成功后设置不可用，即一次添加一个不允许重复添加
            //            //this.btnConfirm.Enabled = false;
            //            //this.btnCancel.Enabled = false;

            //            //添加成功后转成编辑模式
            //            SetMode(OperationTypeEnum.OperationType.Edit);

            //            break;
            //        case 2: Alert.Show("零件图号已重复，请重新输入!"); break;
            //    }


            //}

        }

        //取消按钮事件
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

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }


        private bool ValidateData()
        {
            #region 数据有效性验证

            bool flag = true;

            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("Comp_Code", new ValidateModel(true, 20, 0, new string[] { "零件图号不能为空", "编号字符数不能超过20个" }));
            dict.Add("Comp_Name", new ValidateModel(true, 20, 0, new string[] { "；零件名称不能为空", "名称字符数不能超过20个" }));
            //dict.Add("

            Dictionary<string, string> re = ValidateControlHelper.Validate(gpCompt.Controls, dict);

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

        public bool IsRepeatCode(Road_Components rc)
        {
            return rcInstance.IsRepeatCode(rc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rc">新增加的零件图好</param>
        /// <returns></returns>
        private int AddAndCopyComponents()
        {
            

            Road_Components rc = CurrentRoadCompt;
            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls,"");

            var model = rcInstance.GetRoadComponentByCode(rc.Comp_Code);
            if (model.AuditStat != OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString())
            {
                Alert.Show("您要复制到的零件图号已终审或正在审核中！");
                return 0;
            }

            if (rcInstance.AddAndCopycomponent(CompCode,rc) >= 1)
            {
                CurrentRoadCompt = rc;
                //编辑成功后的处理
                IsEdited = false;
                //Alert.Show("编辑成功!");
                return 1;

            }
            else
            {
                Alert.Show("复制失败，请查证输入数据是否有误!");
                return 0;
            }
            //return rcInstance.AddAndCopycomponent(CompCode, rc);
        }

        private int EditEntity()
        {
            Road_Components rc = CurrentRoadCompt;

            string code = rc.Comp_Code;

            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls);

            //判断是否更改编码，如果更改则判断其是否重复
            if (!code.Equals(rc.Comp_Code) && this.IsRepeatCode(rc))
            {
                return 2;
            }


            if (rcInstance.UpdateRoadCompt(rc) >= 1)
            {
                CurrentRoadCompt = rc;
                //编辑成功后的处理
                IsEdited = false;
                //Alert.Show("编辑成功!");
                return 1;

            }
            else
            {
                //失败原因显示
                //todo
                return 0;
            }

        }


        public int AddEntity()
        {
            Road_Components rc = CurrentRoadCompt;

            bmHelper.BindControlToModel<Road_Components>(rc, gpCompt.Controls);

            if (this.IsRepeatCode(rc))
            {
                //Alert.Show("零件图号已重复，请重新输入");
                return 2;
            }

            int re = rcInstance.AddRoadCompt(rc);



            if (re > 0)
            {
                //添加成功后设置当前Comp_Code为其最新编码
       
                return 1;

            }
            else
            {
                //失败原因显示
                //todo
                return 0;
            }
        }

        #endregion

        private OperationTypeEnum.OperationType _currentMode;

        public OperationTypeEnum.OperationType CurrentMode
        {
            get { return _currentMode; }
            set { _currentMode = value; }
        }

        public void SetMode(OperationTypeEnum.OperationType mode)
        {
            switch (mode)
            {
                case OperationTypeEnum.OperationType.Look:
                    //ClearTextBox();
                    //EnableEditMode(false);
                    OperationType = OperationTypeEnum.OperationType.Look;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    //ClearTextBox();
                    //EnableEditMode(true);
        
                    OperationType = OperationTypeEnum.OperationType.Edit;
                    break;
                case OperationTypeEnum.OperationType.Add:
                    //ClearTextBox();
                    //EnableEditMode(true);
                 
                    OperationType = OperationTypeEnum.OperationType.Add;
                    break;
                case OperationTypeEnum.OperationType.Copy:
                    //this.Comp_Bak.Text = "复制零件图号:" + CompCode;
                    //this.Comp_Code.Text = string.Empty;
                    var compBak=bmHelper.FindCtl<UltraTextEditor>(this.gpCompt.Controls, "Comp_Bak");
                    compBak.Text="复制零件图号:" + CompCode;
                    //var compCode = bmHelper.FindCtl<UltraTextEditor>(this.gpCompt.Controls, "Comp_Code");
                    //compCode.Text = string.Empty;
                        
                    OperationType = OperationTypeEnum.OperationType.Copy;
                    break;
            }
        }


        public void EnableEditMode(bool flag)
        {
            if (flag)
            {
                foreach (Control item in gpCompt.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {

                        ((TextBox)item).ReadOnly = false;

                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control item in gpCompt.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).ReadOnly = true;
                    }
                    else if (item.GetType() == typeof(Button))
                    {
                        ((Button)item).Visible = false;
                    }
                }
            }
        }

        public void ClearTextBox()
        {

            foreach (Control item in gpCompt.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Text = string.Empty;
                    }
                }
            }

        }


        #endregion
    }
}
