using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.Common.C_Class;
using QX.DataModel;

namespace QX.Plugin.Contract
{
    public partial class ContractDeaitl : F_BasicPop
    {
        public delegate void DDataChangeHandler(OperationTypeEnum.OperationType Type, SD_CDetail SDetalModel);
        public event DDataChangeHandler CallBack;
        private BLL.Bll_Road_Components RoadInstance = new QX.BLL.Bll_Road_Components();
        private SD_CDetail gDetailModel=new SD_CDetail();
        public SD_CDetail GDetailModel
        {
            get { return gDetailModel; }
            set { gDetailModel = value; }
        }

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }
        private SD_Contract gContractModel=new SD_Contract();
        public ContractDeaitl(SD_Contract _gContractModel,SD_CDetail _gCDetailModel)
        {
            InitializeComponent();
            this.gContractModel = _gContractModel;
            this.gDetailModel = _gCDetailModel;
            btnOk.Click += new EventHandler(btnOk_Click);
            btnSave.Click += new EventHandler(btnSave_Click);
            CDetail_PartNo.DataSource = RoadInstance.GetAll();
            CDetail_PartNo.DisplayMember = "Comp_Name";
            CDetail_PartNo.ValueMember = "Comp_Code";           
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        /// <summary>
        /// 应用操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnOk_Click(object sender, EventArgs e)
        {
            Save();   
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        private void Save()
        {
            BindModelHelper hepler = new BindModelHelper();
            if (gDetailModel == null) gDetailModel = new SD_CDetail();
            hepler.BindControlToModel<SD_CDetail>(gDetailModel, this.Controls);
            if (gDetailModel != null)
            {
                if (CallBack != null)
                {
                    CallBack(operationType, gDetailModel);
                }
            }
            Alert.Show(GlobalConfiguration.CNLanguage["comm_success"]);
        }

        private void ContractDeaitl_Load(object sender, EventArgs e)
        {
            //if (gContractModel == null) gContractModel = new SD_Contract();
            CDetail_ContractNo.Text = gContractModel.Contract_Code;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    BindModelHelper helper = new BindModelHelper();
                    helper.BindModelToControl(gDetailModel, this.Controls);
                    this.CDetail_PartNo.Enabled = false;
                    break;
                case OperationTypeEnum.OperationType.Add:
                    break;
                case OperationTypeEnum.OperationType.Delete:
                    break;
                case OperationTypeEnum.OperationType.Search:
                    break;
                default:
                    break;
            }
        }

   }
}
