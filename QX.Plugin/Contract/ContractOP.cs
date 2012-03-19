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
using Infragistics.Win.UltraWinGrid;
using QX.BLL;

namespace QX.Plugin.Contract
{
    public partial class ContractOP : F_BasicPop
    {
        public delegate void DDataChangeHandler(object sender, EventArgs e);
        public event DDataChangeHandler CallBack;

        private BLL.Bll_ContractManage ContractManageInstance = new QX.BLL.Bll_ContractManage();
        private BLL.Bll_Bse_Attachments AttacheMentsInstance = new QX.BLL.Bll_Bse_Attachments();
        
        private SD_Contract contractModel=new SD_Contract();
        private SD_CDetail cdetailModel=new SD_CDetail();
        private List<SD_CDetail> cdDetailList = new List<SD_CDetail>();
        private Bse_Attachments attachmentModel=new Bse_Attachments();
        private Dictionary<string, string> gDic = new Dictionary<string,string>();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }
        private BLL.Bll_SD_Contract contractInstance;

        public BLL.Bll_SD_Contract ContractInstance
        {
            get { return contractInstance; }
            set { contractInstance = value; }
        }
        private BLL.Bll_SD_CDetail cdetailInstance;

        public BLL.Bll_SD_CDetail CdetailInstance
        {
            get { return cdetailInstance; }
            set { cdetailInstance = value; }
        }
        private BLL.Bll_Bse_Attachments attachementsInstance;

        public BLL.Bll_Bse_Attachments AttachementsInstance
        {
            get { return attachementsInstance; }
            set { attachementsInstance = value; }
        }

        public ContractOP(SD_Contract _contractModel, List<SD_CDetail> _cdDetailList)
        {
            InitializeComponent();
            this.contractModel = _contractModel;
            this.cdDetailList = _cdDetailList;
            InitGrid();
            //绑定合同基本信息
            BindModelHelper helper = new BindModelHelper();
            helper.BindModelToControl<SD_Contract>(contractModel, this.gpBasic.Controls);
            tool_detail.SetButtonStyle("image");
            btnOk.Click += new EventHandler(btnOk_Click);
            btnSave.Click += new EventHandler(btnSave_Click);
            //合同细目tool事件
            tool_detail.AddClicked += new EventHandler(tool_detail_AddClicked);
            tool_detail.EditClicked += new EventHandler(tool_detail_EditClicked);
            tool_detail.DelClicked += new EventHandler(tool_detail_DelClicked);
            gv_contractdeail.DoubleClickRow += new DoubleClickRowEventHandler(gv_contractdeail_DoubleClickRow);

            List<Bse_Attachments> list = AttacheMentsInstance.GetAll();
            commAttachments1.At_Key = "contract";
            commAttachments1.At_Code = contractModel.Contract_Code;
            commAttachments1.Load(list);
            commAttachments1.FileUploadComplate += new CommAttachments.DFileUploadComplated(commAttachments1_FileUploadComplate);
        }

        /// <summary>
        /// 附件处理完成后合同数据
        /// </summary>
        /// <param name="_complateno"></param>
        /// <param name="_complatetotal"></param>
        void commAttachments1_FileUploadComplate(int _complateno, int _complatetotal)
        {
            if (_complateno==_complatetotal)
            {
                ContractModel();
                bool result = ContractManageInstance.SaveContract(contractModel, CDetailList());
                if (result)
                {
                    if (CallBack != null)
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
            else
            {
                Alert.Show("存在附件未上传完成");
            }            
        }

        void gv_contractdeail_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
        {
            tool_detail_EditClicked(this, EventArgs.Empty);
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveContract();
            this.Close();
        }

        private void InitGrid()
        {
            MetaReflection<SD_CDetail> meta = new MetaReflection<SD_CDetail>();
            gDic = meta.GetMeta();
            gHandler = new GridHandler(this.gv_contractdeail);
            if (cdDetailList != null && cdDetailList.Count > 0)
            {
                gHandler.BindData(cdDetailList, gDic, false);
            }
            gHandler.SetDefaultStyle();
            gHandler.SetExcelStyleFilter();            
            AddCustomizeCol();
            //隐藏标题栏
            gv_contractdeail.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
        }

        public void AddCustomizeCol()
        {
            this.gv_contractdeail.DisplayLayout.Bands[0].Columns.Add("delcheck", "");
            UltraGridColumn col = this.gv_contractdeail.DisplayLayout.Bands[0].Columns["delcheck"];
            col.Hidden = true;
            //col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ////col.NullText = "0";
            //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            col.DataType = typeof(bool);
            col.DefaultCellValue = false;
            //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
            //col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
            //col.AllowRowFiltering = DefaultableBoolean.False;
            //col.Swap(this.Grid.DisplayLayout.Bands[0].Columns[0]);
            //col.CellClickAction = CellClickAction.EditAndSelectText;
        }

        void tool_detail_DelClicked(object sender, EventArgs e)
        {
            if (gv_contractdeail.ActiveRow!=null)
            {
                if (DialogResult.Yes == Alert.Show(MessageBoxButtons.YesNo, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    if (gv_contractdeail.ActiveRow.Cells["delcheck"].Value != null)
                    {
                        string _CDetail_PartNo = gv_contractdeail.ActiveRow.Cells["CDetail_PartNo"].Value != null ?
                        gv_contractdeail.ActiveRow.Cells["CDetail_PartNo"].Value.ToString() : string.Empty;
                        Int32 tmpInedex = cdDetailList.FindIndex(delegate(SD_CDetail obj) { return obj.CDetail_PartNo == _CDetail_PartNo; });
                        cdDetailList[tmpInedex].Stat=1;
                        InitGrid();
                        gv_contractdeail.ActiveRow.Cells["delcheck"].Value = true;
                        gv_contractdeail.ActiveRow.RowSelectorAppearance.Image = global::QX.Common.Properties.Resources.remove;                        
                    }    
                }                            
            }
        }

        void tool_detail_EditClicked(object sender, EventArgs e)
        {
            bool flag = Validata();
            if (flag)
            {
                BindModelHelper helper = new BindModelHelper();
                helper.BindControlToModel<SD_Contract>(contractModel, this.gpBasic.Controls);
                if (gv_contractdeail.ActiveRow!=null)
                {
                    string _CDetail_PartNo = gv_contractdeail.ActiveRow.Cells["CDetail_PartNo"].Value != null ?
                        gv_contractdeail.ActiveRow.Cells["CDetail_PartNo"].Value.ToString() : string.Empty;
                    Int32 tmpInedex = cdDetailList.FindIndex(delegate(SD_CDetail obj) { return obj.CDetail_PartNo == _CDetail_PartNo; });
                    cdetailModel = cdDetailList[tmpInedex];
                    ContractDeaitl frmDetail = new ContractDeaitl(contractModel, cdetailModel);
                    frmDetail.OperationType = OperationTypeEnum.OperationType.Edit;
                    frmDetail.CallBack += new ContractDeaitl.DDataChangeHandler(frmDetail_CallBack);
                    frmDetail.ShowDialog();
                }                
            }    
        }

        void tool_detail_AddClicked(object sender, EventArgs e)
        {
            bool flag = Validata();
            if (flag)
            {
                if (contractModel == null) contractModel = new SD_Contract();
                BindModelHelper helper = new BindModelHelper();
                helper.BindControlToModel<SD_Contract>(contractModel, this.gpBasic.Controls);
                ContractDeaitl frmDetail = new ContractDeaitl(contractModel,null);
                frmDetail.OperationType = OperationTypeEnum.OperationType.Add;
                frmDetail.CallBack += new ContractDeaitl.DDataChangeHandler(frmDetail_CallBack);
                frmDetail.ShowDialog();
            }            
        }
        void frmDetail_CallBack(OperationTypeEnum.OperationType Type, SD_CDetail SDetalModel)
        {
            switch (Type)
            {
                case OperationTypeEnum.OperationType.Look:
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    if (SDetalModel!=null)
                    {
                        Int32 tmpIndex = cdDetailList.FindIndex(delegate(SD_CDetail obj) { 
                            return obj.CDetail_PartNo == SDetalModel.CDetail_PartNo; }
                            );
                        if (tmpIndex>=0)
                        {
                            cdDetailList[tmpIndex] = SDetalModel;
                        }
                        else
                        {
                            cdDetailList.Add(SDetalModel);       
                        }
                        InitGrid();
                    }
                    break;
                case OperationTypeEnum.OperationType.Add:
                    if (SDetalModel!=null)
                    {
                        cdDetailList.Add(SDetalModel);                        
                    }
                    InitGrid();
                    break;
                case OperationTypeEnum.OperationType.Delete:
                    break;
                case OperationTypeEnum.OperationType.Search:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <returns></returns>
        private bool Validata()
        {
            bool flag = true;
            Dictionary<string, ValidateModel> dict = new Dictionary<string, ValidateModel>();
            dict.Add("Contract_CustCode", new ValidateModel(true, 50, 0, new string[] { "客户编码不能为空", "客户编码不能超过50个字符" }));
            dict.Add("Contract_CustName", new ValidateModel(true, 50, 0, new string[] { "客户名称不能为空", "客户名称不能超过50个字符" }));
            dict.Add("Contract_Code", new ValidateModel(true, 50, 0, new string[] { "合同编号不能为空", "合同编号不能超过50个字符" }));
            Dictionary<string, string> re = ValidateControlHelper.Validate(this.gpBasic.Controls, dict);
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
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            SaveContract();
        }
        

        /// <summary>
        /// 获取合同基本实体
        /// </summary>
        private void ContractModel()
        {
            contractModel = new SD_Contract();
            BindModelHelper bind = new BindModelHelper();
            bind.BindControlToModel<SD_Contract>(contractModel, this.gpBasic.Controls);            
        }

        /// <summary>
        /// 获取合同细目List
        /// </summary>
        /// <returns></returns>
        private List<SD_CDetail> CDetailList()
        {
            List<SD_CDetail> list = new List<SD_CDetail>();
            if (gv_contractdeail.Rows.Count>0)
            {                
                for (int i = 0; i < gv_contractdeail.Rows.Count; i++)
                {
                    SD_CDetail tmp = new SD_CDetail();
                    #region grid绑定model                    
                    tmp.CDetail_Bak = gv_contractdeail.Rows[i].Cells["CDetail_Bak"].Value
                         != null ? gv_contractdeail.Rows[i].Cells["CDetail_Bak"].Value.ToString() : string.Empty;

                    tmp.CDetail_ContractNo = gv_contractdeail.Rows[i].Cells["CDetail_ContractNo"].Value
                         != null ? gv_contractdeail.Rows[i].Cells["CDetail_ContractNo"].Value.ToString() : string.Empty;
                    if (gv_contractdeail.Rows[i].Cells["CDetail_Date"].Value!=null)
                    {
                        tmp.CDetail_Date = DateTime.Parse(gv_contractdeail.Rows[i].Cells["CDetail_Date"].Value.ToString());
                    }

                    if (gv_contractdeail.Rows[i].Cells["CDetail_DNum"].Value!=null)
                    {
                        tmp.CDetail_DNum = Int32.Parse(gv_contractdeail.Rows[i].Cells["CDetail_DNum"].Value.ToString());
                    }
                    if (gv_contractdeail.Rows[i].Cells["CDetail_FNum"]!=null)
                    {
                        tmp.CDetail_DNum = Int32.Parse(gv_contractdeail.Rows[i].Cells["CDetail_FNum"].Value.ToString());
                    }
                    if (gv_contractdeail.Rows[i].Cells["CDetail_ID"] != null)
                    {
                        tmp.CDetail_ID = Int32.Parse(gv_contractdeail.Rows[i].Cells["CDetail_ID"].Value.ToString());
                    }
                    tmp.CDetail_Intro = gv_contractdeail.Rows[i].Cells["CDetail_Intro"].Value
                         != null ? gv_contractdeail.Rows[i].Cells["CDetail_Intro"].Value.ToString() : string.Empty;
                    if (gv_contractdeail.Rows[i].Cells["CDetail_Num"]!=null)
                    {
                        tmp.CDetail_Num = Int32.Parse(gv_contractdeail.Rows[i].Cells["CDetail_Num"].Value.ToString());
                    }
                    if (gv_contractdeail.Rows[i].Cells["CDetail_OnNum"]!=null)
                    {
                        tmp.CDetail_OnNum = Int32.Parse(gv_contractdeail.Rows[i].Cells["CDetail_OnNum"].Value.ToString());
                    }
                    if (gv_contractdeail.Rows[i].Cells["CDetail_PartNo"]!=null)
                    {
                        tmp.CDetail_PartNo = gv_contractdeail.Rows[i].Cells["CDetail_PartNo"].Value.ToString();
                    }
                    if (gv_contractdeail.Rows[i].Cells["CDetail_Price"]!=null)
                    {
                        tmp.CDetail_Price = Decimal.Parse(gv_contractdeail.Rows[i].Cells["CDetail_Price"].Value.ToString());
                    }
                    if (gv_contractdeail.Rows[i].Cells["Stat"] != null)
                    {
                        tmp.Stat = int.Parse(gv_contractdeail.Rows[i].Cells["Stat"].Value.ToString());
                    }
                    #endregion
                    list.Add(tmp);
                }
                
            }
            return list;
        }

        /// <summary>
        /// 保存合同信息
        /// </summary>
        private void SaveContract()
        {
            //保存附件
            commAttachments1.SaveFile<BLL.Bll_Bse_Attachments, Bse_Attachments>(AttacheMentsInstance);            
        }

        private void Contract_CustCode_Click(object sender, EventArgs e)
        {
            Bll_SD_Customer instance = new Bll_SD_Customer();
            CommCustomer<Bll_SD_Customer, SD_Customer> user =
                new CommCustomer<Bll_SD_Customer, SD_Customer>(instance,
                    new Size(460, 380));
            user.CallBack += new CommCustomer<Bll_SD_Customer, SD_Customer>.DCallBackHandler(user_CallBack);
            user.ShowDialog();
        }

        void user_CallBack(object sender, DataTable list)
        {
            if (list != null && list.Rows.Count > 0)
            {
                Contract_CustCode.Text = list.Rows[0]["Cust_Code"] != null ? list.Rows[0]["Cust_Code"].ToString() : string.Empty;
                Contract_CustName.Text = list.Rows[0]["Cust_Name"] != null ? list.Rows[0]["Cust_Name"].ToString() : string.Empty;
                Contract_CustOwner.Text = list.Rows[0]["Cust_Cowner"] != null ? list.Rows[0]["Cust_Cowner"].ToString() : string.Empty;
                Contract_CustLink.Text = list.Rows[0]["Cust_CMobile"] != null ? list.Rows[0]["Cust_CMobile"].ToString() : string.Empty;
            }
        }

    }
}
