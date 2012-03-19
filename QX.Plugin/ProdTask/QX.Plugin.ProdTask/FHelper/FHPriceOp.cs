using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.DataModel;
using QX.BLL;
using QX.Framework.AutoForm;
using QX.Common.C_Class;
using QX.Shared;
using Infragistics.Win.UltraWinGrid;

namespace QX.Plugin.Prod
{
    public partial class FHPriceOp : F_BasicPop
    {
        public FHPriceOp()
        {
            InitializeComponent();
        }

        private void FHPriceOp_Load(object sender, EventArgs e)
        {

        }

        private BLL.Bll_FHelper_Price MainInstance = new Bll_FHelper_Price();
        private DataModel.FHelper_Price GModel = new DataModel.FHelper_Price();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        private QX.Common.C_Class.OperationTypeEnum.FHelper_Stat fHelperInnerType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.FHelper_Stat FHelperInnerType
        {
            get { return fHelperInnerType; }
            set { fHelperInnerType = value; }
        }

        public FHPriceOp(DataModel.FHelper_Price _gmodel, OperationTypeEnum.OperationType op, bool _isAudit)
        {
            InitializeComponent();


            this.GModel = _gmodel;
            //GModel.FHelperInfo_Code = MainInstance.GenerateCode();
            //GModel.FHelperInfo_iType = fHelperInnerType.ToString();
            operationType = op;
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    GModel.FP_Code = MainInstance.GenerateFPCode(); ;
                    GModel.FP_Creator = SessionConfig.UserCode;
                    GModel.FP_Creatime = DateTime.Now;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    this.Height = 250;
                    break;
            }

            BindTopTool();

            LoadWindowControl();
        }

        public void BindTopTool()
        {
            this.commonToolBar1.SaveClicked += new EventHandler(commonToolBar1_SaveClicked);
            //commonToolBar1.DelClicked += new EventHandler(commonToolBar1_DelClicked);
            ToolStripButton btn = new ToolStripHelper().New("取消", global::QX.Common.Properties.Resources.cancel, commonToolBar1_DelClicked);
            commonToolBar1.AddCustomControl(btn);
        }

        void commonToolBar1_SaveClicked(object sender, EventArgs e)
        {
            BindModelHelper helper = new BindModelHelper();
            Sys_PD_Module module = this.groupBox1.Tag as Sys_PD_Module;
            if (module == null)
            {
                Alert.Show("保存失败");
                return;
            }
            helper.BindControlToModel(GModel, this.groupBox1.Controls, module.SPM_TPrefix);
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Add:

                    var list = SaveGrid();
                    MainInstance.AddPriceList(list);
                    Alert.Show("数据更新完成!");
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    MainInstance.Update(GModel);
                    Alert.Show("数据更新完成!");
                    break;
                case OperationTypeEnum.OperationType.Look:
                    Alert.Show("当前单据不能编辑");
                    break;
            }

 
            this.Close();

        }

        public List<FHelper_Price> SaveGrid()
        {
            List<FHelper_Price> list = new List<FHelper_Price>();

            foreach (UltraGridRow row in this.comGrid.Rows)
            {
                FHelper_Price p = row.ListObject as FHelper_Price;
                p.FP_CompCode = GModel.FP_CompCode;
                p.FP_CompName = GModel.FP_CompName;
                
                list.Add(p);
            }
            return list;
        }

        void commonToolBar1_DelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        UltraGrid comGrid = new UltraGrid();

        private void LoadWindowControl()
        {
            FormHelper helper = new FormHelper();


            GridHelper gen = new GridHelper();
            BindModelHelper bindHelper = new BindModelHelper();
            switch (operationType)
            {
                case OperationTypeEnum.OperationType.Add:

                    helper.GenerateForm("CForm_FPriceAdd", groupBox1, new Point(6, 20));
                    bindHelper.BindModelToControl<DataModel.FHelper_Price>(GModel, this.groupBox1.Controls, "");

                    //GModel.FP_Code = MainInstance.GenerateFPCode(); ;
                    //GModel.FP_Creator = SessionConfig.UserCode;
                    //GModel.FP_Creatime = DateTime.Now;
                    comGrid = gen.GenerateGrid("CForm_FPriceGrid", this.panel1, new Point(0, 0));
                    List<FHelper_Price> list = new List<FHelper_Price>();
                    BindingSource dataSourc = new BindingSource();
                    dataSourc.DataSource = list;
                    comGrid.DataSource = dataSourc;
                    break;
                case OperationTypeEnum.OperationType.Edit:
                    //BindModelHelper bindHelper = new BindModelHelper();
                    helper.GenerateForm("CForm_FHelper_Price", groupBox1, new Point(6, 20));
                    bindHelper.BindModelToControl<DataModel.FHelper_Price>(GModel, this.groupBox1.Controls, "");

                    break;
                case OperationTypeEnum.OperationType.Look:
                    helper.GenerateForm("CForm_FHelper_Price", groupBox1, new Point(6, 20));
                    bindHelper.BindModelToControl<DataModel.FHelper_Price>(GModel, this.groupBox1.Controls, "");
                    break;
            }
        }
    }
}
