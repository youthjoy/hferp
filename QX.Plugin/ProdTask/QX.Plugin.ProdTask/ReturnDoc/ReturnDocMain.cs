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
using QX.Framework.AutoForm;
using QX.BseDict;
using QX.BLL;
using QX.Shared;

namespace QX.Plugin.ReturnDoc
{
    public partial class ReturnDocMain : F_BasciForm
    {
        private BLL.Bll_Inv_Movement instance = new QX.BLL.Bll_Inv_Movement();

        UltraGrid ug_list = null;
        UltraGrid issue_ug_list = null;
        UltraGrid issued_ug_list = null;
             
        public ReturnDocMain()
        {
            InitializeComponent();
            this.Load += new EventHandler(ProductMain_Load);
            BindTopTool();
        }

        void ProductMain_Load(object sender, EventArgs e)
        {
            LoadControls();
        }

        #region 绑定工具栏及事件
        public void BindTopTool()
        {
            top_tool_0.AddClicked += new EventHandler(top_tool_0_AddClicked);
            top_tool_0.EditClicked += new EventHandler(top_tool_0_EditClicked);
            top_tool_0.DelClicked += new EventHandler(top_tool_0_DelClicked);
            top_tool_0.RefreshClicked += new EventHandler(top_tool_0_RefreshClicked);

            //待审核工具条
            ToolStripButton tButton2 = new ToolStripButton();
            tButton2.Text = "审核";
            Image image2 = global::QX.Common.Properties.Resources.audit;　　　　//从资源文件中引用
            tButton2.Image = image2;
            tButton2.Size = new Size(43, 28);
            tButton2.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            this.top_tool_1.AddCustomControl(tButton2);

            tButton2.Click += new EventHandler(this.btnAudit_Click);
        }

        void btnAudit_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.issue_ug_list.ActiveRow;
            if (row != null)
            {
                string mv_Code = row.Cells["MV_Code"].Value.ToString();
                Inv_Movement returnDoc = row.ListObject as Inv_Movement;

                ComAuditMain frm = new ComAuditMain(OperationTypeEnum.AuditTemplateEnum.ReturnDoc_R001.ToString(), mv_Code, returnDoc.AuditCurAudit);
                frm.CallBack += new ComAuditMain.DCallBackHandler(frm_CallBack);
                frm.ShowDialog();
            }
        }

        void frm_CallBack(AuditReturnResultEnum re, string AStat)
        {
            //审核行
            switch (re)
            {
                case AuditReturnResultEnum.Success:

                    Alert.Show("审核完成");

                    // 退货单审核完成后，添加库存
                    UltraGridRow row = this.issue_ug_list.ActiveRow;
                    Inv_Movement model = instance.GetListByCode(
                        string.Format(" AND MV_Code = '{0}'", row.Cells["MV_Code"].Value.ToString()))[0];

                    if (model.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
                    {
                        Inv_Information info = new Inv_Information();
                        info.CreateTime = DateTime.Now;
                        info.IInfor_InConfirm = model.MV_Owner;
                        info.IInfor_InDate = model.MV_Date;
                        info.IInfor_InPep = SessionConfig.UserCode;
                        info.IInfor_Num = model.MV_Num;
                        info.IInfor_PartName = model.MV_PartName;
                        info.IInfor_PartNo = model.MV_PartNo;
                        info.IInfor_ProdCode = model.MV_ProdCode;
                        info.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
                        info.UpdateTime = DateTime.Now;
                        Bll_Inv_Information info_Instance = new Bll_Inv_Information();
                        info_Instance.AddInv(info);
                    }
                    
                    BindDataToGrid();

                    break;
                case AuditReturnResultEnum.Fail:
                    Alert.Show("审核失败!");
                    break;
            }
        }


        void top_tool_0_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        void top_tool_0_DelClicked(object sender, EventArgs e)
        {
            if (ug_list.ActiveRow != null)
            {
                if (DialogResult.OK == Alert.Show(MessageBoxButtons.OKCancel, GlobalConfiguration.CNLanguage["comm_askdel"]))
                {
                    string code = ug_list.ActiveRow.Cells["MV_Code"].Value.ToString();
                    bool result = instance.Delete(string.Format(" AND MV_Code = '{0}'", code));
                    if (result)
                    {
                        top_tool_0_RefreshClicked(this, EventArgs.Empty);
                    }
                }
            }
            else
            {
                Alert.Show(GlobalConfiguration.CNLanguage["dept_selectdeptnode"]);
            }
        }

        void top_tool_0_EditClicked(object sender, EventArgs e)
        {
            if (ug_list.ActiveRow != null)
            {
                string MV_Code = ug_list.ActiveRow.Cells["MV_Code"].Value.ToString();
                Inv_Movement model = instance.GetModel(" AND MV_Code='" + MV_Code + "' ");
                ReturnDocAdmin frm = new ReturnDocAdmin(instance, model);
                frm.OperationType = OperationTypeEnum.OperationType.Edit;
                frm.ShowDialog();
            }

            this.BindDataToGrid();
        }

        void top_tool_0_AddClicked(object sender, EventArgs e)
        {
            ReturnDocAdmin frm = new ReturnDocAdmin(instance, null);
            frm.OperationType = OperationTypeEnum.OperationType.Add;
            frm.ShowDialog();

            this.BindDataToGrid();
        }
        #endregion

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <param name="filter"></param>
        private void LoadControls()
        {
            InitGrid();

            BindDataToGrid();
        }

        private void BindDataToGrid()
        {
            BindMyDocList();

            BindMyIssueList();

            BindIssuedList();
        }

        private void InitGrid()
        {
            GridHelper grid = new GridHelper();
            ug_list = grid.GenerateGrid("CList_ReturnDoc", panel2, new Point(6, 20));
            issue_ug_list = grid.GenerateGrid("CList_ReturnDoc", panel4, new Point(6, 20));
            issued_ug_list = grid.GenerateGrid("CList_ReturnDoc", panel5, new Point(6, 20));

            grid.SetGridReadOnly(ug_list, true);
            grid.SetGridReadOnly(issue_ug_list, true);
            grid.SetGridReadOnly(issued_ug_list, true);
        }

        private void BindMyDocList()
        {
            List<Inv_Movement> list = new List<Inv_Movement>();
            list = instance.GetListByCreateUser("退货单", SessionConfig.UserCode);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            ug_list.DataSource = dataSource;
        }  

        private void BindMyIssueList()
        {
            List<Inv_Movement> list = new List<Inv_Movement>();
            list = instance.GetListByIssueUser("退货单",SessionConfig.UserCode);

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            issue_ug_list.DataSource = dataSource;
        }

        private void BindIssuedList()
        {
            List<Inv_Movement> list = new List<Inv_Movement>();
            list = instance.GetListByIssued("退货单");

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list;
            issued_ug_list.DataSource = dataSource;
        }
    }
}
