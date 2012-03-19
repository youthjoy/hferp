using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.DataModel;
using QX.Framework.AutoForm;
using Infragistics.Win.UltraWinGrid;
using QX.Common.C_Class;
using QX.Common.C_Form;
using QX.BLL;

namespace QX.Plugin.BaseModule.Dict
{
    public partial class ComDict : F_BasciForm
    {
        public ComDict()
        {
            InitializeComponent();
        }

        public ComDict(string data)
        {
            InitializeComponent();

            EventInit();

            string[] arr = data.Split('|');
            if (arr != null && arr.Length > 1)
            {
                DataCode = arr[0];
                DataName = arr[1];
                ModuleCode = arr[2];
                this.Text = DataName;
            }
            else
            {
                DataCode = data;
            }

            this.Load += new EventHandler(ComDict_Load);
        }

        private void ComDict_Load(object sender, EventArgs e)
        {
            InitData();
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string DataName
        {
            get;
            set;
        }
        public string ModuleCode
        {
            get;
            set;
        }
        /// <summary>
        /// 字典关键字
        /// </summary>
        public string DataCode
        {
            get;
            set;
        }


        public void EventInit()
        {
            this.tbGrid.SaveClicked += new EventHandler(pSaveBtn_Click);
            //, new EventHandler(pSaveBtn_Click));

            //        this.tbGrid.AddCustomControl(pSaveBtn);

            this.tbGrid.RefreshClicked += new EventHandler(tbGrid_RefreshClicked);

        }

        void tbGrid_RefreshClicked(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        void pSaveBtn_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                RefreshGrid();
                Alert.Show("数据更新完成");
            }
        }

        private bool SaveData()
        {
            bool flag = false;
            List<Bse_Dict> list = new List<Bse_Dict>();
            foreach (UltraGridRow row in comGrid.Rows)
            {
                Bse_Dict line = row.ListObject as Bse_Dict;
                if (ModuleCode == "RoadNode")
                {
                    if (list.FirstOrDefault(o => o.Dict_Name == line.Dict_Name) != null)
                    {
                        Alert.Show("您输入的工序存在重复，请确认后重新输入!");
                        return false;
                    }
                }

                list.Add(line);
            }


            dcInstance.AddOrUpdateDict(DataCode, list);

            return true;
        }

        private void InitData()
        {
            if (!dcInstance.IsExsistDictKey(DataCode))
            {
                Bse_Dict dict = new Bse_Dict();
                dict.Dict_Code = DataCode;
                dict.Dict_Key = DataCode;
                dict.Dict_Name = DataName;
                dcInstance.AddDict(dict);
            }


            GridInit();
        }

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();

        UltraGrid comGrid = new UltraGrid();

        private void GridInit()
        {
            GridHelper gen = new GridHelper();

            List<Bse_Dict> bsList = new List<Bse_Dict>();
            string moduleCode = DataCode;
            bsList = dcInstance.GetListByDictKeyByNoRoot(DataCode);

            //ADOSys_PD_Module moduleInstance = new ADOSys_PD_Module();
            //Sys_PD_Module module = new Sys_PD_Module();
            //module = moduleInstance.GetListByWhere(" and SPM_Module='" + DataCode + "'").FirstOrDefault();
            //if (module == null)
            //{
            
            //moduleCode = DataCode;
            //}

            comGrid = gen.GenerateGrid(ModuleCode, this.pnlGrid, new Point(6, 20));

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = bsList.OrderBy(o=>o.Dict_ID).ToList();

            comGrid.DataSource = dataSource;

            //SetGridEditMode(false, StationGrid);

            //列宽度自适应
            comGrid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;
            comGrid.Text = this.Text;
        }

        private void RefreshGrid()
        {
            List<Bse_Dict> bsList = new List<Bse_Dict>();

            bsList = dcInstance.GetListByDictKeyByNoRoot(DataCode);
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = bsList.OrderBy(o => o.Dict_ID).ToList();
            comGrid.DataSource = dataSource;
        }

        public void SetGridEditMode(bool flag, UltraGrid grid)
        {
            if (flag)
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.Edit;
            }
            else
            {
                grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
                grid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
            }

        }
    }
}
