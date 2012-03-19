using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.Common.C_Class;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using System.Collections;
using QX.DataModel;

namespace QX.Plugin.Prod.RawMain
{
    public partial class RawProdCode : Form
    {
        public RawProdCode(string cmdCode, string dCmdCode)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
        }

        private OperationTypeEnum.OperationType opType
        {
            get;
            set;
        }

        public string RawMainCode
        {
            get;
            set;
        }

        public RawProdCode(string cmdCode, string dCmdCode, bool isLook)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
            if (isLook)
            {
                opType = OperationTypeEnum.OperationType.Look;

                this.btnConfirm.Visible = false;

            }
            else
            {
                opType = OperationTypeEnum.OperationType.Edit;
            }
        }


        public RawProdCode(string rawmain,string cmdCode, string dCmdCode, OperationTypeEnum.OperationType op)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
            opType = op;
            RawMainCode = rawmain;
        }


        public RawProdCode(string cmdCode, string dCmdCode, OperationTypeEnum.OperationType op)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CmdCode = cmdCode;
            DetailCode = dCmdCode;
            this.Load += new EventHandler(ProdCodeList_Load);
            opType = op;
        }


        private List<Prod_CodeMap> InitSource
        {
            get;
            set;
        }

        private string CmdCode
        {
            get;
            set;
        }

        private string DetailCode
        {
            get;
            set;
        }

        private

        void ProdCodeList_Load(object sender, EventArgs e)
        {
            switch (opType)
            {
                case OperationTypeEnum.OperationType.View:
                    this.btnConfirm.Visible = false;
                    break;
                case OperationTypeEnum.OperationType.Look:
                    //this.btnConfirm.Visible = false;
                    break;
                case OperationTypeEnum.OperationType.Edit:

                    break;
            }
            InitGrid();
            RefreshGrid();
        }

        UltraGrid comGrid = new UltraGrid();

        private BLL.Bll_Prod_CmdDetail pdInstance = new QX.BLL.Bll_Prod_CmdDetail();

        private BLL.Bll_Inv_Information iiInstance = new QX.BLL.Bll_Inv_Information();

        private GridHelper gen = new GridHelper();

        List<Prod_CodeMap> ExsistCode
        {
            get;
            set;
        }
        /// <summary>
        /// 已出库零件编号
        /// </summary>
        List<Inv_Information> OutCode
        {
            get;
            set;
        }

        public void InitGrid()
        {
            List<Prod_CodeMap> list = new List<Prod_CodeMap>();
            comGrid = gen.GenerateGrid("CList_RawCodeMap", this.pnlGrid, new Point(0, 0));
            BindingSource source = new BindingSource();
            InitSource = list;
            source.DataSource = list;
            comGrid.DataSource = source;
            gen.SetGridReadOnly(comGrid, true);
            comGrid.DisplayLayout.Bands[0].Columns["IsCheck"].CellClickAction = CellClickAction.EditAndSelectText;
            comGrid.BeforeEnterEditMode += new CancelEventHandler(comGrid_BeforeEnterEditMode);
        }

        void comGrid_BeforeEnterEditMode(object sender, CancelEventArgs e)
        {
            UltraGridRow row = this.comGrid.ActiveRow;
            if (row != null)
            {
                Prod_CodeMap map = row.ListObject as Prod_CodeMap;
                if (!string.IsNullOrEmpty(map.PMap_Stat))
                {
                    map.IsCheck = true;
                    e.Cancel = true;
                }
                else if (map.PMap_RawStat == "In")
                {
                    map.IsCheck = true;
                    e.Cancel = true;
                }
            }
        }



        void InitRow()
        {
            foreach (var row in comGrid.Rows)
            {
                Prod_CodeMap map = row.ListObject as Prod_CodeMap;
                if (map != null)
                {
                    ///如果已经下达任务 则不能更新其状态
                    if (!string.IsNullOrEmpty(map.PMap_Stat))
                    {
                        map.IsCheck = true;
                    }
                    else if (!string.IsNullOrEmpty(map.PMap_RawStat))
                    {
                        map.IsCheck = true;
                    }
                }
            }

        }

        private void AddCustomColumn()
        {

            if (!this.comGrid.DisplayLayout.Bands[0].Columns.Exists("checkbox"))
            {
                var col = comGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;

            }
            else
            {
                comGrid.DisplayLayout.Bands[0].Columns.Remove("checkbox");
                var col = comGrid.DisplayLayout.Bands[0].Columns.Add("checkbox", "");
                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.Header.VisiblePosition = 0;
                col.CellClickAction = CellClickAction.Edit;
            }


        }

        // public void IsExsitRepeat()
        //{
        //    foreach (var row in this.comGrid.Rows)
        //    {

        //    }
        // }

        public void RefreshGrid()
        {
            List<Prod_CodeMap> list = new List<Prod_CodeMap>();
            switch (opType)
            {
                    //获取所有关联零件编号
                case OperationTypeEnum.OperationType.Edit:
                    {
                        //if (!string.IsNullOrEmpty(RawMainCode))
                        //{
                        //    list = pdInstance.GetMapList(RawMainCode, CmdCode, DetailCode);
                        //}
                        //如果根据入库编号毛坯无法取得数据则直接根据指令号获取数据
                        if (list != null && list.Count == 0)
                        {
                            //获取所有零件编号
                            list = pdInstance.GetMapList(CmdCode, DetailCode);
                        }
                    }
                    break;
                case OperationTypeEnum.OperationType.Look:
                    {
                        //获取待检验的零件编号
                        list = pdInstance.GetMapListForCheck(CmdCode, DetailCode);
                    }
                    break;//
                case OperationTypeEnum.OperationType.View:
                    {
                        if (!string.IsNullOrEmpty(RawMainCode))
                        {
                            list = pdInstance.GetMapList(RawMainCode, CmdCode, DetailCode);
                        }
                        //如果根据入库编号毛坯无法取得数据则直接根据质量号获取数据
                        if (list != null && list.Count == 0)
                        {
                            //获取所有零件编号
                            list = pdInstance.GetMapList(CmdCode, DetailCode);
                        }
                    }
                    break;
            }


            BindingSource source = new BindingSource();
            source.DataSource = list;
            InitSource = list;
            comGrid.DataSource = source;
            InitRow();
            //AddCustomColumn();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool flag = false;

            switch (opType)
            {
                case OperationTypeEnum.OperationType.Edit:
                    {
                        List<Prod_CodeMap> list = new List<Prod_CodeMap>();
                        List<Prod_CodeMap> noInList = new List<Prod_CodeMap>();
                        StringBuilder sb = new StringBuilder();

                        foreach (var row in comGrid.Rows)
                        {
                            Prod_CodeMap map = row.ListObject as Prod_CodeMap;
                            if (row.Cells["IsCheck"].Value.ToString() == "True")
                            {

                                if (string.IsNullOrEmpty(map.PMap_Stat))
                                {
                                     //如果已经入库或者下达了 则不管
                                    if (map.PMap_RawStat == "In" || !string.IsNullOrEmpty(map.PMap_Stat))
                                    {
                                        continue;
                                    }
                                    //map.PMap_MCode = DetailCode;
                                    map.PMap_RawDate = DateTime.Now;
                                    map.PMap_RawStat = "Check";
                                    map.PMap_RawMainCode = RawMainCode;
                                    list.Add(map);
                                }

                            }
                            else if (row.Cells["IsCheck"].Value.ToString() == "False" && map.PMap_RawStat == "Check")
                            {
                                map.PMap_RawMainCode = string.Empty;
                                map.PMap_RawStat = string.Empty;
                                noInList.Add(map);
                            }

                        }//end  foreach

                        flag = pdInstance.UpdateProdCodeStat(list);

                        pdInstance.UpdateProdCodeStat(noInList);
                    }
                    break;///
                case OperationTypeEnum.OperationType.Look:
                    {
                        flag = true;
                        //List<Prod_CodeMap> list = new List<Prod_CodeMap>();
                        //foreach (var row in comGrid.Rows)
                        //{
                        //    Prod_CodeMap map = row.ListObject as Prod_CodeMap;
                        //    if (row.Cells["IsCheck"].Value.ToString() == "True")
                        //    {

                        //        //map.PMap_RawDate = DateTime.Now;
                        //        map.PMap_RawStat = "In";
                        //        map.PMap_RawMainCode = RawMainCode;
                        //        list.Add(map);
                        //    }

                        //}
                        //flag = pdInstance.UpdateProdCodeStat(list);
                    }
                    break;
            }


            if (flag)
            {
                Alert.Show("数据更新完成!");

                this.Close();

            }
            else
            {
                Alert.Show("数据更新失败!");
            }
        }
    }
}
