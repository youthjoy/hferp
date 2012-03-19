using System;
using System.Collections.Generic;
using System.Text;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.SupportDialogs.FilterUIProvider;
using Infragistics.Win;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;
namespace QX.Common.C_Class
{
    public class GridHandler
    {
        public GridHandler()
        { }

        private UltraGrid Grid
        {
            get;
            set;
        }
        //public Infragistics.Win.Appearance DefaultActiveAppearance
        //{
        //    get;
        //    set;
        //}
        public GridHandler(UltraGrid grid)
        {
            SetChineselocalisation();
            this.Grid = grid;
        }


        
        //private bool _IsEnableCheckbox;

        //public bool IsEnableCheckbox
        //{
        //    get { return _IsEnableCheckbox; }
        //    set { _IsEnableCheckbox = value; }
        //}

        #region 资源文件
        public void SetChineselocalisation()
        {

            #region Grid
            Infragistics.Shared.ResourceCustomizer rc = Infragistics.Win.UltraWinGrid.Resources.Customizer;//Resources.Customizer;

            rc.SetCustomizedString("DeleteSingleRowPrompt", "您确定删除该信息吗？");
            rc.SetCustomizedString("DeleteSingleRowMessageTitle", "提示");

            #endregion

            #region 筛选框

            Infragistics.Shared.ResourceCustomizer filterRc=Infragistics.Win.UltraWinGrid.Resources.Customizer;
            filterRc.SetCustomizedString("RowFilterDropDownAllItem","所有");
            filterRc.SetCustomizedString("RowFilterDropDownBlanksItem","空");
            //filterRc.SetCustomizedString("RowFilterDropDownCustomItem","自定义");
            //filterRc.SetCustomizedString("RowFilterDropDownNonBlanksItem","非空");
            //filterRc.SetCustomizedString("RowFilterDropDownAllItem","所有");
            //filterRc.SetCustomizedString("RowFilterDialogTitlePrefix","输入过滤准则为");
            //filterRc.SetCustomizedString("FilterDialogAndRadioText","并且");
            //filterRc.SetCustomizedString("FilterDialogOrRadioText","或者");
            //filterRc.SetCustomizedString("FilterDialogAddConditionButtonText","增加一个条件(&N)");
            //filterRc.SetCustomizedString("FilterDialogDeleteButtonText","删除一个条件");
            //filterRc.SetCustomizedString("FilterDialogOkButtonText","确定(&O)");
            //filterRc.SetCustomizedString("FilterDialogCancelButtonText","取消(&C)");
            //filterRc.SetCustomizedString("FilterDialogOkButtonNoFiltersText","不过滤");
            //filterRc.SetCustomizedString("RowFilterDialogOperatorHeadefilterRcaption","比较运算符");
            //filterRc.SetCustomizedString("RowFilterDialogOperandHeadefilterRcaption","准则");
            //filterRc.SetCustomizedString("RowFilterDropDownEquals","等于");
            //filterRc.SetCustomizedString("RowFilterDropDownNotEquals","不等于");
            //filterRc.SetCustomizedString("RowFilterDropDownLessThan","小于");
            //filterRc.SetCustomizedString("RowFilterDropDownLessThanOrEqualTo","小于等于");
            //filterRc.SetCustomizedString("RowFilterDropDownGreaterThan","大于");
            //filterRc.SetCustomizedString("RowFilterDropDownGreaterThanOrEqualTo","大于等于");
            //filterRc.SetCustomizedString("RowFilterDropDownMatch","自定义规则表达式");
            //filterRc.SetCustomizedString("RowFilterDropDownLike","模糊查找");

            //filterRc.SetCustomizedString("RowFilterDialogBlanksItem","空白");
            //filterRc.SetCustomizedString("RowFilterDialogDBNullItem","无值");
            //filterRc.SetCustomizedString("RowFilterDialogEmptyTextItem","空字符");

            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_Equals","等于");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_NotEquals","不等于");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_LessThan","小于");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_LessThanOrEqualTo","小于等于");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_GreaterThan","大于");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_GreaterThanOrEqualTo","大于等于");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_Match","自定义规则表达式");
            //filterRc.SetCustomizedString("RowFilterDropDown_Operator_Like","模糊查找");

            //filterRc.SetCustomizedString("RowFilterPatternCaption","无效查找模式");
            //filterRc.SetCustomizedString("RowFilterPatternError","错误的解析模式{0}. 请输入一个有效的表达式");
            //filterRc.SetCustomizedString("RowFilterPatternException","无效查找模式{0}");
            //filterRc.SetCustomizedString("RowFilterRegexError","无效的规则表达式{0}.请输入一个有效的表达式");
            //filterRc.SetCustomizedString("RowFilterRegexErrofilterRcaption","无效规则表达式");
            //filterRc.SetCustomizedString("RowFilterRegexException","无效规则表达式{0}");


            #endregion

        }

        #endregion


        #region 样式设置

        private UltraGridFilterUIProvider filterUIProvider = null;

        /// <summary>
        /// 设置列宽度
        /// </summary>
        /// <param name="columnNum">第几列</param>        
        /// <param name="bands">维度（如果没有嵌套Grid，则默认传0）</param>
        /// <param name="width">宽度</param>
        public void SetColumnWidth(int columnNum, int bands, int width)
        {
            this.Grid.DisplayLayout.Bands[bands].Columns[columnNum].Width = width;
        }

        /// <summary>
        /// 设置列宽度
        /// </summary>
        /// <param name="columnNum">第几列</param>        
        /// <param name="bands">维度（如果没有嵌套Grid，则默认传0）</param>
        /// <param name="width">宽度</param>
        public void SetColumnWidth(string key, int bands, int width)
        {
            this.Grid.DisplayLayout.Bands[bands].Columns[key].Width = width;
        }

        /// <summary>
        /// 设置列排序方式
        /// </summary>
        /// <param name="columnNum"></param>
        /// <param name="bands"></param>
        /// <param name="sort">ASC OR DES</param>
        public void SetColumnSort(int columnNum, int bands, string sort)
        {

            switch (sort.ToUpper())
            {
                case "ASC": this.Grid.DisplayLayout.Bands[bands].Columns[columnNum].SortIndicator = SortIndicator.Ascending; break;
                case "DES": this.Grid.DisplayLayout.Bands[bands].Columns[columnNum].SortIndicator = SortIndicator.Descending; break;
            }
        }

        public void SetColSizingOrSwap()
        {
            this.Grid.DisplayLayout.Override.AllowRowLayoutCellSizing = RowLayoutSizing.None;
        }

        public void SetGridCaption(string caption)
        {
            if (this.Grid.DisplayLayout.CaptionVisible == DefaultableBoolean.False)
            {
                this.Grid.DisplayLayout.CaptionVisible = DefaultableBoolean.True;
            }
            this.Grid.Text = caption;
        }


        /// <summary>
        /// 设置UltraGrid 行过滤器
        /// </summary>
        public void SetExcelStyleFilter()
        {
            //  Create a new UltraGridFilterUIProvider
            //this.filterUIProvider = new UltraGridFilterUIProvider(this.components);
            this.filterUIProvider = new UltraGridFilterUIProvider(this.Grid.Parent.Container);
            //  Assign the UltraGridFilterUIProvider component to the
            //  FilterUIProvider property of the layout's Override, so
            //  it is used by all columns.
            this.Grid.DisplayLayout.Override.FilterUIProvider = this.filterUIProvider;


            //  Set the AllowRowFiltering property of the layout's
            //  Override to true to enable row filtering.
            this.Grid.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True;


            //  Handle the AfterMenuPopulate event so we can control which menu items appear.
            this.filterUIProvider.AfterMenuPopulate += new AfterMenuPopulateEventHandler(this.filterUIProvider_AfterMenuPopulate);

        }
        #region filterUIProvider_AfterMenuPopulate
        /// <summary>
        /// Handles the UltraGridFilterUIProvider's AfterMenuPopulate event.
        /// </summary>
        private void filterUIProvider_AfterMenuPopulate(object sender, AfterMenuPopulateEventArgs e)
        {
            UltraGridFilterUIProvider provider = sender as UltraGridFilterUIProvider;
            UltraGridColumn column = e.ColumnFilter != null ? e.ColumnFilter.Column : null;
            string columnKey = column != null ? column.Key : string.Empty;
            ////this.SetupFilterTools(columnKey, e.MenuItems);

            //if (string.Equals(columnKey, "33"))
            //{
            foreach (FilterTool tool in e.MenuItems)
            {
                if (string.Equals(tool.Id, "Clear Filter"))
                {
                    tool.DisplayText = "清除过滤条件";
                }
                if (string.Equals(tool.Id, "Number Filters") || string.Equals(tool.Id, "Text Filters") || string.Equals(tool.Id, "Date Filters"))
                {
                    e.MenuItems.Remove(tool);
                    break;
                }

            }
            //}

            //this.currentColumnFilecter = e.ColumnFilter;
        }
        #endregion filterUIProvider_AfterMenuPopulate

        public void SetAlternateRowStyle()
        {
            this.Grid.DisplayLayout.Override.RowAlternateAppearance.BackColor = Color.Orange;
            this.Grid.DisplayLayout.Override.RowAlternateAppearance.BackColor2 =
              Color.OrangeRed;
            this.Grid.DisplayLayout.Override.RowAlternateAppearance.BackGradientStyle =
              Infragistics.Win.GradientStyle.Vertical;
        }

        


        #endregion

        #region 单元格单击事件

        public enum ClickActionEnum
        {
            DefaulttMode = 0,
            Edit,
            EditAndSelectText,
            CellSelect,
            RowSelect
        }

        /// <summary>
        /// 设置单元格选中后的模态
        /// </summary>
        /// <param name="ck"></param>
        public void SetCellClickAction(ClickActionEnum ck)
        {
            switch (ck)
            {
                case ClickActionEnum.CellSelect:
                    this.Grid.DisplayLayout.Override.CellClickAction =
       CellClickAction.CellSelect;
                    break;
                case ClickActionEnum.DefaulttMode:
                    this.Grid.DisplayLayout.Override.CellClickAction =
        CellClickAction.CellSelect;
                    break;
                case ClickActionEnum.Edit:
                    this.Grid.DisplayLayout.Override.CellClickAction =
       CellClickAction.CellSelect;
                    break;
                case ClickActionEnum.EditAndSelectText:
                    this.Grid.DisplayLayout.Override.CellClickAction =
        CellClickAction.CellSelect;
                    break;
                case ClickActionEnum.RowSelect:
                    this.Grid.DisplayLayout.Override.CellClickAction =
       CellClickAction.CellSelect;
                    break;
            }
            //     this.Grid.DisplayLayout.Override.CellClickAction =
            //CellClickAction.CellSelect;

        }

        #endregion



        //private void Set_Alternate_Row_Colors_Load(object sender, EventArgs e)
        //{
        //    this.Grid.DisplayLayout.Override.RowAlternateAppearance.BackColor = Color.Orange;
        //    this.Grid.DisplayLayout.Override.RowAlternateAppearance.BackColor2 =
        //      Color.OrangeRed;
        //    this.Grid.DisplayLayout.Override.RowAlternateAppearance.BackGradientStyle =
        //      Infragistics.Win.GradientStyle.Vertical;
        //}

        #region 初始化样式

        public void SetDefaultStyle()
        {
            #region AddNewRow Style

            //this.Grid.DisplayLayout.Override.AddRowAppearance.BackColor = Color.Black;

            #endregion

            #region RowSelector

            this.Grid.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True;
            this.Grid.DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.RowIndex;



            #endregion


            this.Grid.DisplayLayout.CaptionVisible = DefaultableBoolean.True;
            this.Grid.Text = "";

            #region Column

            this.Grid.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;

            this.Grid.DisplayLayout.Override.SelectTypeRow = SelectType.Single;

            this.Grid.DisplayLayout.Override.SelectTypeCell = SelectType.Single;

            //列宽度自适应
            this.Grid.DisplayLayout.AutoFitStyle = AutoFitStyle.ExtendLastColumn;
            //this.Grid.DisplayLayout.Override.GroupByRowExpansionStyle = GroupByRowExpansionStyle.Disabled;


            #endregion


            #region 样式


            //if (this.Grid.ActiveCell == null && this.Grid.ActiveRow !=null)
            //{
            //this.Grid.DisplayLayout.Override.ActiveRowAppearance = this.Grid.DisplayLayout.Override.RowAppearance;

            //this.Grid.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.Blue;
            //}

            //EmptyRow
            this.Grid.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
            this.Grid.DisplayLayout.EmptyRowSettings.Style = EmptyRowStyle.ExtendRowSelector;

            //隐藏头部Groupbox
            this.Grid.DisplayLayout.GroupByBox.Hidden = false;
            this.Grid.DisplayLayout.Override.HeaderCheckBoxVisibility = HeaderCheckBoxVisibility.Never;


            //this.Grid.DisplayLayout.Override.HeaderCheckBoxVisibility = HeaderCheckBoxVisibility.WhenUsingCheckEditor;
            //this.Grid.DisplayLayout.Override.HeaderCheckBoxAlignment = HeaderCheckBoxAlignment.Center;

            this.Grid.DisplayLayout.Override.HeaderAppearance.TextHAlign = HAlign.Center;
            this.Grid.DisplayLayout.Override.HeaderAppearance.TextVAlign = VAlign.Middle;


            this.Grid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid;

            this.Grid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid;

            this.Grid.DisplayLayout.Override.RowAppearance.BorderColor = Color.Black;
            this.Grid.DisplayLayout.Override.CellAppearance.BorderColor = Color.Black;

            this.Grid.DisplayLayout.Override.HeaderStyle = HeaderStyle.Standard;

            this.Grid.DisplayLayout.Override.RowSelectorStyle = HeaderStyle.Standard;


            #endregion
            //this.Grid.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButtonFixedSize;




            //this.Grid.DisplayLayout.Bands[0].Columns[0].Header.Fixed = true;
            //this.Grid.DisplayLayout.Bands[0].Header.FixOnRight = DefaultableBoolean.True;
        }



        #endregion

        #region  存取数据

        public void BindData(object source)
        {
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;
        }

        /// <summary>
        /// 默认band=0
        /// </summary>
        /// <param name="source"></param>
        /// <param name="colCollection"></param>
        public void BindData(object source, Dictionary<string, string> colCollection, bool enableCheckbox)
        {

            this.Grid.DisplayLayout.Bands[0].Columns.ClearUnbound();

            //IsEnableCheckbox = enableCheckbox;
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {

                if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }



            if (enableCheckbox)
            {

                //if (this.Grid.DisplayLayout.Bands[0].Columns[0].Key != "checkbox")
                //{

                this.Grid.DisplayLayout.Bands[0].Columns.Add("checkbox", "操作");
                UltraGridColumn col = this.Grid.DisplayLayout.Bands[0].Columns["checkbox"];

                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                //col.NullText = "0";
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.DataType = typeof(bool);
                col.DefaultCellValue = false;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;
                col.Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always;
                col.AllowRowFiltering = DefaultableBoolean.False;

                col.Header.VisiblePosition = 0;

                //col.Swap(this.Grid.DisplayLayout.Bands[0].Columns[0]);
                col.CellClickAction = CellClickAction.EditAndSelectText;
                //}
            }
        }


        public void BindData(object source, Dictionary<string, string> colCollection)
        {
            this.Grid.DisplayLayout.Bands[0].Columns.ClearUnbound();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {

                if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }
        }



        public void BindHierarchicalData(object source, Dictionary<string, string> band0Col,Dictionary<string,string> band1Col)
        {
            this.Grid.DisplayLayout.Bands[0].Columns.ClearUnbound();

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {

                if (band0Col.ContainsKey(column.Key))
                {
                    column.Header.Caption = band0Col[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[1].Columns)
            {

                if (band1Col.ContainsKey(column.Key))
                {
                    column.Header.Caption = band1Col[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }
        }


        public void BindHierarchicalData<T1,T2>(object source, Dictionary<string, string> band0Col, Dictionary<string, string> band1Col)
        {
            QX.Common.C_Class.MetaReflection<T1> mt = new QX.Common.C_Class.MetaReflection<T1>();

            Dictionary<string, string> colCollection = mt.GetMeta();

            QX.Common.C_Class.MetaReflection<T2> mt1 = new QX.Common.C_Class.MetaReflection<T2>();

            Dictionary<string, string> colCollection1 = mt1.GetMeta();

            this.Grid.DisplayLayout.Bands[0].Reset();

            //IsEnableCheckbox = enableCheckbox;
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {
                if (band0Col.ContainsKey(column.Key))
                {
                    column.Hidden = true;
                }
                else if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }



            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {
                if (band1Col.ContainsKey(column.Key))
                {
                    column.Hidden = true;
                }
                else if (colCollection1.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">对应要绑定的实体</typeparam>
        /// <param name="source"></param>
        /// <param name="hideCols"></param>
        /// <param name="enableCheckbox"></param>
        public void BindData<T>(object source, Dictionary<string, string> hideCols, bool enableCheckbox)
        {

            QX.Common.C_Class.MetaReflection<T> mt = new QX.Common.C_Class.MetaReflection<T>();

            Dictionary<string, string> colCollection = mt.GetMeta();
            this.Grid.DisplayLayout.Bands[0].Reset();

            //IsEnableCheckbox = enableCheckbox;
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {
                if (hideCols.ContainsKey(column.Key))
                {
                    column.Hidden = true;
                }
                else if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">对应要绑定的实体</typeparam>
        /// <param name="source"></param>
        /// <param name="hideCols">要隐藏的列 Key</param>
        /// <param name="enableCheckbox"></param>
        public void BindData<T>(object source, List<string> hideCols, bool enableCheckbox)
        {

            QX.Common.C_Class.MetaReflection<T> mt = new QX.Common.C_Class.MetaReflection<T>();

            Dictionary<string, string> colCollection = mt.GetMeta();
            this.Grid.DisplayLayout.Bands[0].Reset();

            //IsEnableCheckbox = enableCheckbox;
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {
                if (hideCols.Contains(column.Key))
                {
                    column.Hidden = true;
                }
                else if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="enableCheckbox"></param>
        public void BindData<T>(object source, bool enableCheckbox)
        {

            QX.Common.C_Class.MetaReflection<T> mt = new QX.Common.C_Class.MetaReflection<T>();

            Dictionary<string, string> colCollection = mt.GetMeta();
            this.Grid.DisplayLayout.Bands[0].Reset();

            //IsEnableCheckbox = enableCheckbox;
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {

                if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }

        }

        public void RefreshData(object source, Dictionary<string, string> colCollection)
        {
            //IsEnableCheckbox = enableCheckbox;
            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {

                if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }

        }


        public void BindData(object source, Dictionary<string, string> colCollection, bool enableCheckbox, string key)
        {

            BindingSource dataSource = new BindingSource();
            dataSource.DataSource = source;

            this.Grid.DataSource = dataSource;

            foreach (UltraGridColumn column in this.Grid.DisplayLayout.Bands[0].Columns)
            {

                if (colCollection.ContainsKey(column.Key))
                {
                    column.Header.Caption = colCollection[column.Key];
                }
                else
                {
                    column.Hidden = true;
                }

            }


            if (enableCheckbox)
            {
                this.Grid.DisplayLayout.Bands[0].Columns.Add("checkbox", "操作");
                UltraGridColumn col = this.Grid.DisplayLayout.Bands[0].Columns["checkbox"];

                col.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                col.Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Center;

                col.DefaultCellValue = false;

                col.AllowRowFiltering = DefaultableBoolean.False;
                //默认第一个位置即为主键
                col.Swap(this.Grid.DisplayLayout.Bands[0].Columns[key]);
                //this.Grid.DisplayLayout.Bands[0].Columns[key].Hidden = true;
                //this.Grid.DisplayLayout.Bands[0].Columns.Add("button", "操作");
                //this.Grid.DisplayLayout.Bands[0].Columns["button"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                //this.Grid.DisplayLayout.Bands[0].Columns["button"].AllowRowFiltering = DefaultableBoolean.False;

                col.CellClickAction = CellClickAction.EditAndSelectText;
            }
            //foreach (KeyValuePair<string, string> d in colCollection)
            //{
            //    this.Grid.DisplayLayout.Bands[0].Columns.Add(d.Key, d.Value);
            //}


        }

        /// <summary>
        /// 获取选中的checkbox行列表
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public Dictionary<int, string> GetGridCheckBoxData(string Key)
        {
            return GetGridCheckBoxData("checkbox", Key);
        }


        /// <summary>
        /// 获取选中的checkbox行列表
        /// </summary>
        /// <param name="checkboxCol">checkbox所在列表（关键字）</param>
        /// <param name="Key">要获取的列值的关键字</param>
        /// <returns></returns>
        public Dictionary<int, string> GetGridCheckBoxData(string checkboxCol, string Key)
        {
            Dictionary<int, string> list = new Dictionary<int, string>();

            foreach (UltraGridRow r in this.Grid.DisplayLayout.Rows)
            {
                if (r.Cells[checkboxCol].Value != null && r.Cells[checkboxCol].Value.ToString() == "True")
                {
                    if (r.Cells[Key].Value != null)
                    {
                        list.Add(r.Index, r.Cells[Key].Value.ToString());
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="colCollection">要显示的列字典</param>
        /// <param name="obj">该行对应的数据集合对象</param>
        public void AddNewRow<T>(Dictionary<string, string> colCollection, T obj)
        {
            #region 行为
            this.Grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;
            #endregion
            UltraGridRow row = this.Grid.DisplayLayout.Bands[0].AddNew();

            //row.Appearance.BackColor = Color.Black;
            //row.Appearance.ForeColor = Color.Green;

            //this.ultraGrid1.DisplayLayout.Override.AddRowAppearance = this.ultraGrid1.DisplayLayout.Override.RowAppearance;

            if (obj != null)
            {
                PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));
                foreach (KeyValuePair<string, string> item in colCollection)
                {
                    object value = p[item.Key].GetValue(obj);
                    if (value != null)
                    {
                        row.Cells[item.Key].Value = value;
                    }
                }
            }

        }




        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="colCollection">要显示的列字典</param>
        /// <param name="obj">该行对应的数据集合对象</param>
        /// <param name="key">标示（对应主键名称）</param>
        public void AddNewRow<T>(Dictionary<string, string> colCollection, T obj, string key)
        {
            #region 行为
            //this.Grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;

            this.Grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;


            #endregion

            UltraGridRow row = this.Grid.DisplayLayout.Bands[0].AddNew();

            //row.Appearance.BackColor = Color.Black;
            //row.Appearance.ForeColor = Color.Green;

            //this.ultraGrid1.DisplayLayout.Override.AddRowAppearance = this.ultraGrid1.DisplayLayout.Override.RowAppearance;

            if (obj != null)
            {

               
                PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));

                foreach (UltraGridCell cell in row.Cells)
                {
                    object value = p[cell.Column.Key].GetValue(obj);
                    if (value != null)
                    {
                        row.Cells[cell.Column.Key].Value = value;
                    }
                }


                //如果未设置显示主键，则用指定Key
                if (!colCollection.ContainsKey(key))
                {
                    object value = p[key].GetValue(obj);
                    if (value != null)
                    {
                        row.Cells[key].Value = value;
                    }
                }
                foreach (KeyValuePair<string, string> item in colCollection)
                {
                    object value = p[item.Key].GetValue(obj);
                    if (value != null)
                    {
                        row.Cells[item.Key].Value = value;
                    }
                }
            }

        }

        public void AddNewRow<T>(T obj)
        {
            #region 行为

            this.Grid.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes;

            #endregion

            UltraGridRow row = this.Grid.DisplayLayout.Bands[0].AddNew();

            if (obj != null)
            {
                PropertyDescriptorCollection pc = TypeDescriptor.GetProperties(typeof(T));

                foreach (UltraGridCell cell in row.Cells)
                {
                    if (cell.Column.IsBound)
                    {
                        object value = pc[cell.Column.Key].GetValue(obj);
                        if (value != null)
                        {
                            row.Cells[cell.Column.Key].Value = value;
                        }
                    }
                }

                row.Activate();
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="colCollection"></param>
        /// <param name="obj"></param>
        public void UpdateRow<T>(UltraGridRow row,T obj)
        {
            if (obj != null)
            {
                PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));

                foreach (UltraGridCell cell in row.Cells)
                {
                    if (cell.Column.IsBound)
                    {
                        object value = p[cell.Column.Key].GetValue(obj);
                        if (value != null)
                        {
                            row.Cells[cell.Column.Key].Value = value;
                        }
                    }
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="colCollection"></param>
        /// <param name="obj"></param>
        public void UpdateRow<T>(UltraGridRow row, Dictionary<string, string> colCollection, T obj)
        {
            //row.Appearance.BackColor = Color.Black;
            //row.Appearance.ForeColor = Color.Green;

            //this.ultraGrid1.DisplayLayout.Override.AddRowAppearance = this.ultraGrid1.DisplayLayout.Override.RowAppearance;

            if (obj != null)
            {
                PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));
                foreach (KeyValuePair<string, string> item in colCollection)
                {
                    object value = p[item.Key].GetValue(obj);
                    if (value != null)
                    {
                        row.Cells[item.Key].Value = value;
                    }
                    else
                    {
                        row.Cells[item.Key].Value = "";
                    }
                }
            }

        }


        public object GetGridCellData(int band, int row, int column)
        {
            //维度（总共有几维）
            int bandCount = this.Grid.DisplayLayout.Bands.Count;

            object GridData = null;

            if (bandCount >= band)
            {
                int rowCount = this.Grid.DisplayLayout.Rows.Count;
                int columnCount = this.Grid.DisplayLayout.Bands[band].Columns.Count;
                //选择的列或者行不能超出数据范围
                if (rowCount > row && columnCount > column)
                {
                    GridData = this.Grid.DisplayLayout.Rows[row].Cells[column].Value;
                }
            }

            return GridData;
        }

        public List<object> GetGridCellsData(int band, int row)
        {
            //维度（总共有几维）
            int bandCount = this.Grid.DisplayLayout.Bands.Count;

            List<object> list = new List<object>();

            if (bandCount >= band)
            {
                int rowCount = this.Grid.DisplayLayout.Rows.Count;
                int columnCount = this.Grid.DisplayLayout.Bands[band].Columns.Count;
                //选择的列或者行不能超出数据范围
                if (rowCount > row)
                {
                    foreach (UltraGridCell o in this.Grid.DisplayLayout.Rows[row].Cells)
                    {
                        list.Add(o);
                    }
                }
            }

            return list;
        }

        public int SetGridCellData(int band, int row, int column, object value)
        {
            //维度（总共有几维）
            int bandCount = this.Grid.DisplayLayout.Bands.Count;

            int result = 0;




            if (bandCount >= band)
            {

                result = 1;

                int rowCount = this.Grid.DisplayLayout.Rows.Count;
                int columnCount = this.Grid.DisplayLayout.Bands[band].Columns.Count;

                //选择的列或者行不能超出数据范围
                if (rowCount > row && columnCount > column)
                {
                    this.Grid.DisplayLayout.Rows[row].Cells[column].Value = value;
                    result = 2;
                }

            }

            return result;

        }

        #endregion

        /// <summary>
        /// 根据显示列字典对Grid显示列顺序进行调整
        /// </summary>
        /// <param name="dic"></param>
        public void AdjustGridColumn(Dictionary<string, string> dic)
        {
            //ColumnsCollection columns = this.Grid.DisplayLayout.Bands[0].Columns;
            //int i = 1;
            //foreach (KeyValuePair<string, string> kv in dic)
            //{
            //    if (columns.Exists(kv.Key))
            //    {
            //        columns[kv.Key].Header.VisiblePosition = i;
            //    }
            //    i++;
            //}
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bands"></param>
        /// <param name="columnNum"></param>
        /// <param name="column">UltraGridColumn对象（Column相关属性集合类）</param>
        [Obsolete]
        public void SetColumn(int bands, int columnNum, UltraGridColumn column)
        {

            this.Grid.DisplayLayout.Bands[bands].Columns[columnNum].Width = column.Width;


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
