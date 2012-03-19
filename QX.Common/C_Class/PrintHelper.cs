using System;
using System.Collections.Generic;
using System.Text;
using Infragistics.Win.UltraWinGrid;

namespace QX.Common.C_Class
{
    public class PrintHelper
    {
        private Infragistics.Win.UltraWinGrid.UltraGridPrintDocument uGridPrintDocument;
        private Infragistics.Win.Printing.UltraPrintPreviewDialog uPrintPreviewDialog;
        UltraGrid uGridPrint;

        public PrintHelper()
        { }

        public PrintHelper(UltraGrid ug)
        {
            this.uGridPrint = ug;
            this.uGridPrintDocument = new Infragistics.Win.UltraWinGrid.UltraGridPrintDocument();
            this.uPrintPreviewDialog = new Infragistics.Win.Printing.UltraPrintPreviewDialog();
            // 
            // uPrintPreviewDialog
            // 
            this.uPrintPreviewDialog.Name = "uPrintPreviewDialog";
        }

        public void Show()
        {
            //this.uGridPrint.BeginUpdate();
            ////this.uGridPrint.DisplayLayout.Bands[0].Columns["
            ////this.uGridPrint.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns;
            //this.uGridPrint.EndUpdate();

            this.uGridPrintDocument.Grid = this.uGridPrint;
            this.uPrintPreviewDialog.Document = this.uGridPrintDocument;
            //int c=this.uPrintPreviewDialog.Container.Components.Count;
            SetChineselocalisation();
            this.uPrintPreviewDialog.ShowDialog();
        }

        public void SetChineselocalisation ()
        {
            Infragistics.Shared.ResourceCustomizer rc = Infragistics.Win.Printing.Resources.Customizer;//Resources.Customizer;
          
            rc.SetCustomizedString("PrintPreview_DialogCaption", "打印预览");
            rc.SetCustomizedString("PrintPreview_Tool_Print", "打印(&P)");
            rc.SetCustomizedString("PrintPreview_Tool_ClosePreview", "关闭(&C)");
            rc.SetCustomizedString("PrintPreview_Tool_ContextMenuPreviewZoom", "显示比例");
            rc.SetCustomizedString("PrintPreview_Tool_Current_Page", "当前页");
            rc.SetCustomizedString("PrintPreview_Tool_Exit", "退出(&X)");
            rc.SetCustomizedString("PrintPreview_Tool_First_Page", "第一页");
            rc.SetCustomizedString("PrintPreview_Tool_Go_To", "跳至");
            rc.SetCustomizedString("PrintPreview_Tool_Last_Page", "最后一页");
            rc.SetCustomizedString("PrintPreview_Tool_Next_Page", "下一页");
            rc.SetCustomizedString("PrintPreview_Tool_Previous_Page", "前一页");
            rc.SetCustomizedString("PrintPreview_Tool_Next_View", "下一视图(&N)");
            rc.SetCustomizedString("PrintPreview_Tool_Previous_View", "前一视图(&P)");
            rc.SetCustomizedString("PrintPreview_Tool_Hand_Tool", "手型工具(&H)");
            rc.SetCustomizedString("PrintPreview_Tool_Page_Setup", "页面设置(&U)");
            rc.SetCustomizedString("PrintPreview_Tool_Snapshot_Tool", "快照工具(&S)");
            rc.SetCustomizedString("PrintPreview_Tool_View", "视图(&V)");
            rc.SetCustomizedString("PrintPreview_Tool_Whole_Page", "合适页");
            rc.SetCustomizedString("PrintPreview_Tool_Zoom", "缩放(&Z)");
            rc.SetCustomizedString("PrintPreview_Tool_Zoom_In", "放大");

            rc.SetCustomizedString("PrintPreview_Tool_Zoom_Out", "缩小");

            rc.SetCustomizedString("PrintPreview_ToolCategory_Context_Menus", "上下文菜单");
            rc.SetCustomizedString("PrintPreview_ToolCategory_File", "文件");
            rc.SetCustomizedString("PrintPreview_ToolCategory_Menus", "菜单");
            rc.SetCustomizedString("PrintPreview_ToolCategory_Tools", "工具栏");
            rc.SetCustomizedString("PrintPreview_ToolCategory_View", "视图");
            rc.SetCustomizedString("PrintPreview_ToolCategory_Zoom_Mode", "缩放模式");

            rc.SetCustomizedString("PrintPreview_ToolTip_ClosePreview", "关闭");
            rc.SetCustomizedString("PrintPreview_ToolTip_Zoom", "缩放");
            rc.SetCustomizedString("StatusBar_Page_X_OF_X", "页:{0}/{1}");

            rc.SetCustomizedString("CustomizeImg_ToolBar_MenuBar", "菜单");
            rc.SetCustomizedString("CustomizeImg_ToolBar_Standard", "标准");
            rc.SetCustomizedString("CustomizeImg_ToolBar_View", "视图");
            rc.SetCustomizedString("PrintPreview_Tool_File", "文件(&F)");
            rc.SetCustomizedString("PrintPreview_Tool_Tools", "工具(&T)");
            rc.SetCustomizedString("PrintPreview_Tool_Dynamic_Zoom_Tool", "动态缩放工具(&D)");
            rc.SetCustomizedString("PrintPreview_Tool_Zoom_Out_Tool", "缩小工具");
            rc.SetCustomizedString("PrintPreview_Tool_Zoom_In_Tool", "放大工具");
            // rc.SetCustomizedString("PrintPreview_Tool_Page_Layout","菜单");
            rc.SetCustomizedString("PreviewRowColSelection_Cancel", "取消");
            rc.SetCustomizedString("PreviewRowColSelection_SelectedPages", "{0} x {1} 页");

            rc.SetCustomizedString("PreviewRowColSelection_Cancel", "取消");
            rc.SetCustomizedString("PrintPreview_Tool_Page_Width", "页宽");
            rc.SetCustomizedString("PrintPreview_ZoomListItem_MarginWidth", "文字宽度");
            rc.SetCustomizedString("PrintPreview_ZoomListItem_PageWidth", "页宽");
            rc.SetCustomizedString("PrintPreview_ZoomListItem_WholePage", "合适页");
            rc.SetCustomizedString("PrintPreview_Tool_Page_Layout", "页面布局");
            rc.SetCustomizedString("PrintPreview_Tool_Margin_Width", "文字宽度");
            rc.SetCustomizedString("ContextMenuPreviewHand", "缩放视图");


            rc.SetCustomizedString("PrintPreview_Tool_Reduce_Page_Thumbnails", "缩小");
            rc.SetCustomizedString("PrintPreview_Tool_Show_Page_Numbers", "显示页号");
            rc.SetCustomizedString("PrintPreview_Tool_ContextMenuThumbnail", "缩略图");
            rc.SetCustomizedString("PrintPreview_Tool_Enlarge_Page_Thumbnails", "放大");
            rc.SetCustomizedString("PrintPreview_Tool_Thumbnails", "缩略图");
            rc.SetCustomizedString("PrintPreview_Tool_Continuous", "连续排序");
            //说明
            rc.SetCustomizedString("StatusBar_DynamicZoom_Instructions", "单击并拖动进行缩放操作");
            rc.SetCustomizedString("StatusBar_Page_X_OF_X", "当前页: {0} / {1}");
            rc.SetCustomizedString("StatusBar_SnapShot_Instructions", "单击并拖动,系统将选定矩型区域复制到剪帖板");
            rc.SetCustomizedString("StatusBar_ZoomIn_Instructions", "单击并拖动,系统将放大选定矩型区域");
            rc.SetCustomizedString("StatusBar_ZoomOut_Instructions", "单击并拖动,系统将缩小选定矩型区域");
            rc.SetCustomizedString("StatusBar_Hand_Instructions", "单击并拖动以便显示更多内容");
        }
    }
}
