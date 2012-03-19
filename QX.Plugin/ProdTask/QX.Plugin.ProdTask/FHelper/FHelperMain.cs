using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Form;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;

namespace QX.Plugin.Prod.FHelper
{
    public partial class FHelperMain : F_BasciForm
    {
        UltraGrid ug_ToBeDone;//未完成列表
        //UltraGrid ug_ToBeConfirmed; //待确认列表

        //UltraGrid ug_ToBeOut; //待出厂列表
        //UltraGrid ug_ToBeIn; //待回厂列表
        //UltraGrid ug_ToBeCheck; //待检验列表
        //UltraGrid ug_Done; //已完成列表


        GridHelper gridHelper = new GridHelper();
        BLL.Bll_FHelper_Info instance = new QX.BLL.Bll_FHelper_Info();

        private QX.Common.C_Class.OperationTypeEnum.OperationType operationType;
        /// <summary>
        /// 操作类型
        /// </summary>
        public QX.Common.C_Class.OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        public FHelperMain()
        {
            InitializeComponent();

            this.Load += new EventHandler(FHelperMain_Load);
            BindTopTool();


        }

        void FHelperMain_Load(object sender, EventArgs e)
        {
            //未完成列表
            this.ug_ToBeDone = gridHelper.GenerateGrid("CList_FHDone", panel_FH_1, new Point(6, 20));
            gridHelper.SetGridReadOnly(ug_ToBeDone, true);
            //待确认
            //this.ug_ToBeConfirmed = gridHelper.GenerateGrid("CList_FHInfo", this.panel_FH_2, new Point(6, 20));
            gridHelper.GenerateColumn("CList_FHInfo", this.ug_ToBeConfirmed, new Point(0, 0));
            gridHelper.SetGridReadOnly(ug_ToBeConfirmed, true);
            //待出厂列表
            //this.ug_ToBeOut = gridHelper.GenerateGrid("CList_FHInfo", this.panel_FH_3, new Point(6, 20));
            //gridHelper.SetGridReadOnly(ug_ToBeOut, true);
            //待回厂
            //this.ug_ToBeIn = gridHelper.GenerateGrid("CList_FHInfo", this.panel_FH_4, new Point(6, 20));
            gridHelper.GenerateColumn("CList_FHInfo", this.ug_ToBeIn, new Point(0, 0));
            gridHelper.SetGridReadOnly(ug_ToBeIn, true);

            //待检验
            //this.ug_ToBeCheck = gridHelper.GenerateGrid("CList_FHInfo", this.panel_FH_5, new Point(6, 20));
            //gridHelper.GenerateColumn("CList_FHInfo", this.ug_ToBeCheck, new Point(0, 0));
            //gridHelper.SetGridReadOnly(ug_ToBeCheck, true);
            //已完成
            //this.ug_Done = gridHelper.GenerateGrid("CList_FHDone", this.panel_FH_6, new Point(6, 20));
            gridHelper.GenerateColumn("CList_FHDone", this.ug_Done, new Point(0, 0));
            gridHelper.SetGridReadOnly(ug_Done, true);

            BindDataToGrid();
        }

        private void BindDataToGrid()
        {
            // 绑定未完成列表
            List<FHelper_Info> list_ToBeDone = new List<FHelper_Info>();
            list_ToBeDone = instance.GetFHelperList(string.Format(" AND isnull(FHelperInfo_Stat,'') <> '{0}' and isnull(FHelperInfo_RefCode,'')=''", OperationTypeEnum.FHelper_Stat.Done));

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = list_ToBeDone;
            ug_ToBeDone.DataSource = dataSource;

            // 绑定待确认列表
            List<FHelper_Info> list_ToBeConfirmed = new List<FHelper_Info>();
            list_ToBeConfirmed = instance.GetFHelperList(" and (isnull(FHelperInfo_Stat,'ConfirmSup') ='ConfirmSup' and isnull(FHelperInfo_iType,'FHelper') = 'FHelper')");

            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_ToBeConfirmed;
            ug_ToBeConfirmed.DataSource = dataSource1;
            AddCustomColumn(ug_ToBeConfirmed);
            // 绑定待出厂列表
            //List<FHelper_Info> list_ToBeOut = new List<FHelper_Info>();
            //list_ToBeOut = instance.GetFHelperList(string.Format(" and isnull(FHelperInfo_Stat,'No') <> 'Yes' AND isnull(FHelperInfo_iType,'ConfirmSup') = '{0}'", OperationTypeEnum.FHelper_Stat.WaitOut));

            //BindingSource dataSource2 = new BindingSource();
            //dataSource2.DataSource = list_ToBeOut;
            //ug_ToBeOut.DataSource = dataSource2;

            // 绑定待回厂列表
            List<FHelper_Info> list_ToBeIn = new List<FHelper_Info>();
            list_ToBeIn = instance.GetFHelperList(string.Format("and isnull(FHelperInfo_Stat,'No') <> 'Yes' AND isnull(FHelperInfo_iType,'ConfirmSup') = '{0}'", OperationTypeEnum.FHelper_Stat.WaitIn));

            BindingSource dataSource3 = new BindingSource();
            dataSource3.DataSource = list_ToBeIn;
            ug_ToBeIn.DataSource = dataSource3;
            AddCustomColumn(ug_ToBeIn);

            // 绑定待检验列表
            //List<FHelper_Info> list_ToBeCheck = new List<FHelper_Info>();
            //list_ToBeCheck = instance.GetFHelperList(string.Format("and isnull(FHelperInfo_Stat,'No') <> 'Yes' AND isnull(FHelperInfo_iType,'ConfirmSup') = '{0}'", OperationTypeEnum.FHelper_Stat.WaitCheck));

            //BindingSource dataSource4 = new BindingSource();
            //dataSource4.DataSource = list_ToBeCheck;
            //ug_ToBeCheck.DataSource = dataSource4;
            //AddCustomColumn(ug_ToBeCheck);
            // 已完成列表
            List<FHelper_Info> list_Done = new List<FHelper_Info>();
            list_Done = instance.GetFHelperList(string.Format(" AND isnull(FHelperInfo_Stat,'{0}') = '{0}' and isnull(FHelperInfo_RefCode,'')=''", OperationTypeEnum.FHelper_Stat.Done));

            BindingSource dataSource5 = new BindingSource();
            dataSource5.DataSource = list_Done;
            ug_Done.DataSource = dataSource5;
        }

        public void BindTopTool()
        {
            //commonToolBar_1.EditClicked += new EventHandler(commonToolBar_1_EditClicked); 
            //commonToolBar_1.DelClicked += new EventHandler(commonToolBar_1_DelClicked);
            ToolStripHelper TsHelper = new ToolStripHelper();

            //未完成
            commonToolBar_1.RefreshClicked += new EventHandler(commonToolBar_1_RefreshClicked);
            commonToolBar_1.QueryClicked += new EventHandler(commonToolBar_1_QueryClicked);
            commonToolBar_1.SearchClicked += new EventHandler(commonToolBar_1_SearchClicked);
            commonToolBar_1.AddSearchAllModule();

            //待确认
            commonToolBar_2.AddCustomControl(TsHelper.New("订单确认", global::QX.Common.Properties.Resources.finished, commonToolBar_2_EditClicked));
            commonToolBar_2.SearchClicked += new EventHandler(commonToolBar_2_SearchClicked);
            commonToolBar_2.AddSearchAllModule();

            //commonToolBar_2.EditClicked += new EventHandler(commonToolBar_2_EditClicked);
            commonToolBar_2.RefreshClicked += new EventHandler(commonToolBar_2_RefreshClicked);
            commonToolBar_2.QueryClicked += new EventHandler(commonToolBar_2_QueryClicked);
            ToolStripButton batchBtn = TsHelper.New("批量确认", QX.Common.Properties.Resources.batch, new EventHandler(batchBtn_Click));
            //batchBtn.Click += new EventHandler(batchBtn_Click);
            //batchConBtn.Click += new EventHandler(batchConBtn_Click);
            commonToolBar_2.AddCustomControl(batchBtn);



            //待出厂
            //commonToolBar_3.AddCustomControl(TsHelper.New("出厂", global::QX.Common.Properties.Resources.finished, commonToolBar_3_EditClicked));

            ////commonToolBar_3.EditClicked += new EventHandler(commonToolBar_3_EditClicked);
            //commonToolBar_3.RefreshClicked += new EventHandler(commonToolBar_3_RefreshClicked);
            //commonToolBar_3.QueryClicked += new EventHandler(commonToolBar_3_QueryClicked);


            //待回场
            //commonToolBar_4.AddCustomControl(TsHelper.New("回厂确认", global::QX.Common.Properties.Resources.finished, commonToolBar_4_EditClicked));
            commonToolBar_4.SearchClicked += new EventHandler(commonToolBar_4_SearchClicked);
            commonToolBar_4.AddSearchAllModule();
            //commonToolBar_4.EditClicked += new EventHandler(commonToolBar_4_EditClicked);
            commonToolBar_4.RefreshClicked += new EventHandler(commonToolBar_4_RefreshClicked);
            commonToolBar_4.QueryClicked += new EventHandler(commonToolBar_4_QueryClicked);

            ToolStripButton batchConBtn = TsHelper.New("批量回厂确认", QX.Common.Properties.Resources.batch, new EventHandler(batchConBtn_Click));
            //batchConBtn.Click += new EventHandler(batchConBtn_Click);
            commonToolBar_4.AddCustomControl(batchConBtn);


            ToolStripButton supChangeBtn = TsHelper.New("厂家编辑", QX.Common.Properties.Resources.edit, new EventHandler(supChangeBtn_Click));
            this.commonToolBar_4.AddCustomControl(supChangeBtn);

            //待检验
            //commonToolBar_5.AddCustomControl(TsHelper.New("检验确认", global::QX.Common.Properties.Resources.finished, commonToolBar_5_EditClicked));
            //commonToolBar_5.EditClicked += new EventHandler(commonToolBar_5_EditClicked);
            //commonToolBar_5.RefreshClicked += new EventHandler(commonToolBar_5_RefreshClicked);
            //commonToolBar_5.QueryClicked += new EventHandler(commonToolBar_5_QueryClicked);

            //ToolStripButton batchCheckConBtn = TsHelper.New("批量确认", QX.Common.Properties.Resources.batch, new EventHandler(batchCheckConBtn_Click));

            //commonToolBar_5.AddCustomControl(batchCheckConBtn);

            //commonToolBar_5.SearchClicked += new EventHandler(commonToolBar_5_SearchClicked);
            //commonToolBar_5.AddSearchAllModule();
            //已完成
            //commonToolBar_6.EditClicked += new EventHandler(commonToolBar_6_EditClicked);
            commonToolBar_6.RefreshClicked += new EventHandler(commonToolBar_6_RefreshClicked);
            commonToolBar_6.QueryClicked += new EventHandler(commonToolBar_6_QueryClicked);
            commonToolBar_6.SearchClicked += new EventHandler(commonToolBar_6_SearchClicked);
            commonToolBar_6.AddSearchAllModule();
        }

        void supChangeBtn_Click(object sender, EventArgs e)
        {
            UltraGridRow row = this.ug_ToBeIn.ActiveRow;
            if (row != null)
            {
                FHelper_Info finfo = row.ListObject as FHelper_Info;
                FHelperOp fhelperOp = new FHelperOp(new Bll_FHelper_Info(), finfo, finfo.FHelperInfo_iType, false);
                fhelperOp.ShowDialog();
            }
        }

        void commonToolBar_5_SearchClicked(object sender, EventArgs e)
        {
            //string bDate = this.commonToolBar_5.GetSearchValue("bDate", "Date");
            //string eDate = this.commonToolBar_5.GetSearchValue("eDate", "Date");
            //string key = this.commonToolBar_5.GetSearchValue("Key", "Text");


            //List<FHelper_Info> list_ToBeCheck = new List<FHelper_Info>();
            //list_ToBeCheck = instance.GetFHelperList(string.Format(" AND FHelperInfo_Date between '{0}' and '{1}' AND (FHelperInfo_PartCode like '%{2}%' OR FHelperInfo_ProdCode like '%{2}%') and isnull(FHelperInfo_Stat,'No') <> 'Yes' AND isnull(FHelperInfo_iType,'ConfirmSup') = '{3}'",bDate,eDate,key, OperationTypeEnum.FHelper_Stat.WaitCheck));

            //BindingSource dataSource4 = new BindingSource();
            //dataSource4.DataSource = list_ToBeCheck;
            //ug_ToBeCheck.DataSource = dataSource4;
            //AddCustomColumn(ug_ToBeCheck);
        }


        /// <summary>
        /// 已完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void commonToolBar_6_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.commonToolBar_6.GetSearchValue("bDate", "Date");
            string eDate = this.commonToolBar_6.GetSearchValue("eDate", "Date");
            string key = this.commonToolBar_6.GetSearchValue("Key", "Text");

            
            List<FHelper_Info> list_Done = new List<FHelper_Info>();
            list_Done = instance.GetFHelperList(string.Format(" AND FHelperInfo_Date between '{0}' and '{1}' AND (FHelperInfo_PartCode like '%{2}%' OR FHelperInfo_ProdCode like '%{2}%') AND isnull(FHelperInfo_Stat,'{3}') = '{3}' and isnull(FHelperInfo_RefCode,'')=''",bDate,eDate,key, OperationTypeEnum.FHelper_Stat.Done));

            BindingSource dataSource5 = new BindingSource();
            dataSource5.DataSource = list_Done;
            ug_Done.DataSource = dataSource5;
        }

        /// <summary>
        /// 待回厂
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void commonToolBar_4_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.commonToolBar_4.GetSearchValue("bDate", "Date");
            string eDate = this.commonToolBar_4.GetSearchValue("eDate", "Date");
            string key = this.commonToolBar_4.GetSearchValue("Key", "Text");

            List<FHelper_Info> list_ToBeIn = new List<FHelper_Info>();
            list_ToBeIn = instance.GetFHelperList(string.Format(" AND FHelperInfo_Date between '{0}' and '{1}' AND (FHelperInfo_PartCode like '%{2}%' OR FHelperInfo_ProdCode like '%{2}%') and isnull(FHelperInfo_Stat,'No') <> 'Yes' AND isnull(FHelperInfo_iType,'ConfirmSup') = '{3}'",bDate,eDate,key, OperationTypeEnum.FHelper_Stat.WaitIn));

            BindingSource dataSource3 = new BindingSource();
            dataSource3.DataSource = list_ToBeIn;
            ug_ToBeIn.DataSource = dataSource3;
            AddCustomColumn(ug_ToBeIn);
        }



        /// <summary>
        /// 待确认搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void commonToolBar_2_SearchClicked(object sender, EventArgs e)
        {
            string bDate = this.commonToolBar_2.GetSearchValue("bDate", "Date");
            string eDate = this.commonToolBar_2.GetSearchValue("eDate", "Date");
            string key = this.commonToolBar_2.GetSearchValue("Key", "Text");

            // 绑定待确认列表
            List<FHelper_Info> list_ToBeConfirmed = new List<FHelper_Info>();
            list_ToBeConfirmed = instance.GetFHelperList(string.Format(" AND FHelperInfo_Date between '{0}' and '{1}' AND (FHelperInfo_PartCode like '%{2}%' OR FHelperInfo_ProdCode like '%{2}%') and (isnull(FHelperInfo_Stat,'ConfirmSup') ='ConfirmSup' and isnull(FHelperInfo_iType,'FHelper') = 'FHelper')",bDate,eDate,key));

            BindingSource dataSource1 = new BindingSource();
            dataSource1.DataSource = list_ToBeConfirmed;
            ug_ToBeConfirmed.DataSource = dataSource1;
            AddCustomColumn(ug_ToBeConfirmed);
        }

        void commonToolBar_1_SearchClicked(object sender, EventArgs e)
        {
             string bDate = this.commonToolBar_1.GetSearchValue("bDate", "Date");
             string eDate = this.commonToolBar_1.GetSearchValue("eDate", "Date");
             string key = this.commonToolBar_1.GetSearchValue("Key", "Text");

             // 绑定未完成列表
             List<FHelper_Info> list_ToBeDone = new List<FHelper_Info>();
             list_ToBeDone = instance.GetFHelperList(string.Format(" AND FHelperInfo_Date between '{0}' and '{1}' AND (FHelperInfo_PartCode like '%{2}%' OR FHelperInfo_ProdCode like '%{2}%')  AND isnull(FHelperInfo_Stat,'') <> '{3}' and isnull(FHelperInfo_RefCode,'')=''",bDate ,eDate,key,OperationTypeEnum.FHelper_Stat.Done));

             BindingSource dataSource = new BindingSource();
             dataSource.DataSource = list_ToBeDone;
             ug_ToBeDone.DataSource = dataSource;
        }

        public void SearchData(string type)
        {
           

        }

        void batchBtn_Click(object sender, EventArgs e)
        {
            var list = GetGridCheckBoxData(ug_ToBeConfirmed);
            if (list.Count == 0)
            {
                return;
            }
            BatchConfirmSup csFrm = new BatchConfirmSup(new Bll_FHelper_Info(), list);
            csFrm.ShowDialog();

            BindDataToGrid();
        }

        private Bll_Prod_Record prInstance = new Bll_Prod_Record();
        //批量质检
        void batchCheckConBtn_Click(object sender, EventArgs e)
        {
            //List<FHelper_Info> list = GetGridCheckBoxData(ug_ToBeCheck);

            //if (list.Count != 0 && Alert.ShowIsConfirm("您确认要批量确认以下选中外协单据吗?"))
            //{
            //    foreach (var f in list)
            //    {

            //        //f.FHelperInfo_iType = OperationTypeEnum.FHelper_Stat.Done.ToString();
            //        f.FHelperInfo_Stat = "Yes";
            //        //f.FHelperInfo_RefCode = "";
            //        instance.Update(f);
            //        if (string.IsNullOrEmpty(f.FHelperInfo_IsBatch))
            //        {
            //            prInstance.SetFHelperFinish(f.FHelperInfo_ProdCode, f.FHelperInfo_RoadNodes);
            //        }
            //        else
            //        {
            //            prInstance.SetFHelperFinishForBatch(f.FHelperInfo_ProdCode, f.FHelperInfo_IsBatch);
            //        }
            //        var oldModel = instance.GetModel(string.Format(" AND FHelperInfo_Code='{0}'", f.FHelperInfo_RefCode));
            //        oldModel.FHelperInfo_Stat = "Done";
            //        instance.Update(oldModel);

            //        #region 参考数据插入

            //        f.FHelperInfo_Stat = "No";
            //        f.FHelperInfo_iType = "Done";
            //        f.FHelperInfo_Code = instance.GenerateCode();
            //        if (!instance.Insert(f))
            //        {
            //            Alert.Show("更新数据出错");

            //        }

            //        #endregion
            //    }

            //    BindDataToGrid();
            //}
        }

        /// <summary>
        /// 待回厂批量确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void batchConBtn_Click(object sender, EventArgs e)
        {
            List<FHelper_Info> list = GetGridCheckBoxData(ug_ToBeIn);
            //List<FHelper_Info> list = GetGridCheckBoxData(ug_ToBeCheck);

            if (list.Count != 0 && Alert.ShowIsConfirm("您确认要批量确认以下选中外协单据吗?"))
            {
                foreach (var f in list)
                {

                    //f.FHelperInfo_iType = OperationTypeEnum.FHelper_Stat.Done.ToString();
                    f.FHelperInfo_Stat = "Yes";
                    //f.FHelperInfo_RefCode = "";
                    instance.Update(f);
                    if (string.IsNullOrEmpty(f.FHelperInfo_IsBatch))
                    {
                        prInstance.SetFHelperFinish(f.FHelperInfo_ProdCode, f.FHelperInfo_RoadNodes);
                    }
                    else
                    {
                        prInstance.SetFHelperFinishForBatch(f.FHelperInfo_ProdCode, f.FHelperInfo_IsBatch);
                    }
                    var oldModel = instance.GetModel(string.Format(" AND FHelperInfo_Code='{0}'", f.FHelperInfo_RefCode));
                    oldModel.FHelperInfo_Stat = "Done";
                    instance.Update(oldModel);

                    #region 参考数据插入

                    f.FHelperInfo_Stat = "No";
                    f.FHelperInfo_iType = "Done";
                    f.FHelperInfo_Code = instance.GenerateCode();
                    if (!instance.Insert(f))
                    {
                        Alert.Show("更新数据出错");

                    }

                    #endregion
                }
                Alert.Show("数据更新完成!");
                BindDataToGrid();
                //if (list.Count != 0 && Alert.ShowIsConfirm("您确认要批量确认以下选中外协单据吗?"))
                //{
                //    //var list = GetGridCheckBoxData(ug_ToBeConfirmed);

                //    BatchIn csFrm = new BatchIn(new Bll_FHelper_Info(), list);
                //    csFrm.ShowDialog();

                //    BindDataToGrid();
                //    //string next = "WaitCheck";

                //    //foreach (var f in list)
                //    //{
                //    //    //当前单据

                //    //    //f.FHelperInfo_iType = next;

                //    //    f.FHelperInfo_Stat = "Yes";
                //    //    f.FHelperInfo_BackDate = DateTime.Now;
                //    //    instance.Update(f);

                //    //    var oldModel = instance.GetModel(string.Format(" AND FHelperInfo_Code='{0}'", f.FHelperInfo_RefCode));
                //    //    oldModel.FHelperInfo_Stat = next;
                //    //    instance.Update(oldModel);

                //    //    #region 参考数据插入  下一状态插入

                //    //    f.FHelperInfo_Stat = "No";
                //    //    f.FHelperInfo_iType = next;
                //    //    f.FHelperInfo_Code = instance.GenerateCode();
                //    //    if (!instance.Insert(f))
                //    //    {
                //    //        Alert.Show("更新数据出错");

                //    //    }

                //    //    #endregion

                //    //    BindDataToGrid();
                //    //}
                //}
            }
            else
            {
                Alert.Show("请选择要编辑的数据项!");
            }
        }

        private void AddCustomColumn(UltraGrid grid)
        {

            if (!grid.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = grid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.EditAndSelectText;

            }
            else
            {
                grid.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = grid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);

                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.EditAndSelectText;
            }


        }


        private List<FHelper_Info> GetGridCheckBoxData(UltraGrid grid)
        {
            List<FHelper_Info> list = new List<FHelper_Info>();

            foreach (UltraGridRow r in grid.DisplayLayout.Rows)
            {
                //过滤已配对的
                FHelper_Info d = r.ListObject as FHelper_Info;

                if (r.Cells["checkbox"].Value != null && r.Cells["checkbox"].Value.ToString() == "True")
                {
                    //Prod_PlanProd planProd = r.ListObject as Prod_PlanProd;
                    list.Add(d);
                }
            }

            return list;
        }




        #region bar 6
        void commonToolBar_6_QueryClicked(object sender, EventArgs e)
        {
            ViewHelper(ug_Done);
        }

        void commonToolBar_6_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }
        void commonToolBar_6_EditClicked(object sender, EventArgs e)
        {
            DoneFHelper(ug_Done);
        }
        #endregion

        #region bar5
        void commonToolBar_5_QueryClicked(object sender, EventArgs e)
        {
           // ViewHelper(ug_ToBeCheck);
        }

        void commonToolBar_5_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }
        void commonToolBar_5_EditClicked(object sender, EventArgs e)
        {
            //DoneFHelper(ug_ToBeCheck);
        }
        #endregion
        #region bar4
        void commonToolBar_4_QueryClicked(object sender, EventArgs e)
        {
            ViewHelper(ug_ToBeIn);
        }

        void commonToolBar_4_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        void commonToolBar_4_EditClicked(object sender, EventArgs e)
        {
            DoneFHelper(ug_ToBeIn);
        }
        #endregion

        #region bar 3

        void commonToolBar_3_QueryClicked(object sender, EventArgs e)
        {
            ViewHelper(ug_ToBeConfirmed);
        }

        void commonToolBar_3_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }
        void commonToolBar_3_EditClicked(object sender, EventArgs e)
        {
            DoneFHelper(ug_ToBeConfirmed);
        }
        #endregion

        #region bar2
        void commonToolBar_2_QueryClicked(object sender, EventArgs e)
        {
            ViewHelper(ug_ToBeConfirmed);
        }

        void commonToolBar_2_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }
        void commonToolBar_2_EditClicked(object sender, EventArgs e)
        {
            DoneFHelper(ug_ToBeConfirmed);
        }
        #endregion


        #region bar 1
        void commonToolBar_1_QueryClicked(object sender, EventArgs e)
        {
            ViewHelper(ug_ToBeDone);
        }

        void commonToolBar_1_RefreshClicked(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        void commonToolBar_1_DelClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void commonToolBar_1_EditClicked(object sender, EventArgs e)
        {
            DoneFHelper(ug_ToBeDone);
        }
        #endregion
        void DoneFHelper(UltraGrid ug_list)
        {
            if (ug_list.ActiveRow == null)
            {
                Alert.Show("请选择需要处理的数据项");
                return;
            }
            FHelper_Info model = new FHelper_Info();
            model = ug_list.ActiveRow.ListObject as FHelper_Info;
            if (model != null)
            {
                if (model.FHelperInfo_iType.ToString().ToLower() == "fhelper") //代表是主表
                {
                    model.FHelperInfo_iType = model.FHelperInfo_Stat;
                    model.FHelperInfo_Stat = "No";
                }

                //if (string.IsNullOrEmpty(model.FHelperInfo_iType))
                //{
                //    model.FHelperInfo_iType = "ConfirmSup";
                //}
                //else if (model.FHelperInfo_iType.ToString().ToLower() == "fhelper")
                //{
                //    model.FHelperInfo_iType = model.FHelperInfo_Stat;
                //}
                //OperationTypeEnum.FHelper_Stat f = (OperationTypeEnum.FHelper_Stat)Enum.Parse(typeof(OperationTypeEnum.FHelper_Stat), model.FHelperInfo_iType);
                FHelperAdmin frm = new FHelperAdmin(instance, model, model.FHelperInfo_iType, false);
                frm.OperationType = OperationTypeEnum.OperationType.Edit;
                frm.ShowDialog();

                BindDataToGrid();
            }
        }

        void ViewHelper(UltraGrid ug_list)
        {
            if (ug_list.ActiveRow == null)
            {
                Alert.Show("请选择需要处理的数据项");
                return;
            }
            FHelper_Info model = new FHelper_Info();
            model = ug_list.ActiveRow.ListObject as FHelper_Info;
            if (model != null)
            {
                if (model.FHelperInfo_iType.ToString().ToLower() == "fhelper") //代表是主表
                {
                    model.FHelperInfo_iType = model.FHelperInfo_Stat;
                    model.FHelperInfo_Stat = "No";
                }
                FHelperAdmin frm = new FHelperAdmin(instance, model);
                frm.OperationType = OperationTypeEnum.OperationType.Look;
                frm.ShowDialog();
            }
        }
    }
}
