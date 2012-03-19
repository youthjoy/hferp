using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;


namespace QX.Plugin.RawInfo
{
    public partial class RawDetail : F_BasicPop
    {
        public delegate void DataChangeHandler(object sender, EventArgs e);
        public event DataChangeHandler CallBack;
                
        private BLL.Bll_Raw_Detail RawDetailInstance = null;
        private Raw_Detail GDetailModel = null;
        private Raw_Main GMainModel = null;
        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public RawDetail(BLL.Bll_Raw_Detail _instance, Raw_Detail _GDetailModel,Raw_Main _GMainModel)
        {
            InitializeComponent();
            this.RawDetailInstance = _instance;
            this.GDetailModel = _GDetailModel;
            this.GMainModel = _GMainModel;
            this.Load += new EventHandler(RawDetail_Load);
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        private void SaveData()
        {
            #region  保存数据
            bool result = false;
            Raw_Detail model = new Raw_Detail();
            BindModelHelper helper = new BindModelHelper();
            helper.BindControlToModel(model, this.gp_top.Controls);
            if (model == null)
            {
                return;
            }
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    if (model.RawMain_Code != GDetailModel.RawMain_Code)
                    {
                        if (!CheckIsExist(model.RawMain_Code, model.RDetail_Code))
                        {
                            result = RawDetailInstance.Update(model);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        result = RawDetailInstance.Update(model);
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    if (!CheckIsExist(model.RawMain_Code,model.RDetail_Code))
                    {
                        result = RawDetailInstance.Insert(model);
                    }
                    else
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }
            #endregion
            MessageShow(result);
        }

        /// <summary>
        /// 操作提示
        /// </summary>
        /// <param name="result"></param>
        public void MessageShow(bool result)
        {
            if (result)
            {
                if (CallBack!=null)
                {
                    CallBack(this, EventArgs.Empty);
                }
                Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["comm_fail"]);
            }
        }

        /// <summary>
        /// 检查部是否存在
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool CheckIsExist(string NodeCode,string DetailCode)
        {
            bool result = false;
            Raw_Detail model = RawDetailInstance.GetModel(" AND RawMain_Code='" + NodeCode + "' AND RDetail_Code='" + DetailCode + "'");
            if (model!=null && !String.IsNullOrEmpty(model.RawMain_Code))
            {
                result = true;
                Alert.Show(GlobalConfiguration.CNLanguage["dept_codeone"]);
            }
            return result;
        }

        private void RawDetail_Load(object sender, EventArgs e)
        {
            btnSave.Click += new EventHandler(btnSave_Click);
            btnOk.Click += new EventHandler(btnOk_Click);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            BindModelHelper modelHepler = new BindModelHelper();
            //操作类型
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:                    
                    modelHepler.BindModelToControl<Raw_Detail>(GDetailModel, this.gp_top.Controls);
                    this.RawMain_Code.Text = GMainModel.RawMain_Code;
                    break;
                case OperationTypeEnum.OperationType.Add:
                    this.RawMain_Code.Text = GMainModel.RawMain_Code;
                    break;
                default:
                    break;
            }
        }
    }
}
