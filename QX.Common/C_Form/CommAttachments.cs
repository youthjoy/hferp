using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using QX.Common.C_Class;
using System.Net;
using QX.Common.C_Class.Utils;
using System.Reflection;
using Infragistics.Win.UltraWinGrid;

namespace QX.Common.C_Form
{
    public partial class CommAttachments : UserControl
    {
        public delegate void DFileUploadComplated(int _complateno,int _complatetotal);
        public event DFileUploadComplated FileUploadComplate;

        private FTP ftp = new FTP(new Uri("ftp://192.168.1.100") , "qbll", "7221322");
        private string[] FileNames;
        private ToolStripLabel lblProgress = new ToolStripLabel();
        private ToolStripProgressBar toolProgress = new ToolStripProgressBar("上传进度");
        private GridHandler _gHandler;
        public GridHandler gHandler
        {
            get { return _gHandler; }
            set { _gHandler = value; }
        }
        private DataTable dt;
        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        private string at_Key;
        public string At_Key
        {
            get { return at_Key; }
            set { at_Key = value; }
        }
        private string at_Code;
        public string At_Code
        {
            get { return at_Code; }
            set { at_Code = value; }
        }
        private static int ComplateNo = 0;
        private static int ComplateTotal=0;
        private static string[] FileNameList;
        public CommAttachments()
        {
            InitializeComponent();
            ftp.UploadProgressChanged += new FTP.De_UploadProgressChanged(ftp_UploadProgressChanged);
            ftp.UploadFileCompleted += new FTP.De_UploadFileCompleted(ftp_UploadFileCompleted);
            ToolTOP.SetButtonStyle("image");
            ToolTOP.AddClicked += new EventHandler(ToolTOP_AddClicked);
            ToolTOP.DelClicked += new EventHandler(ToolTOP_DelClicked);
            ToolTOP.AddCustomControl(lblProgress);
            ToolTOP.AddCustomControl(toolProgress);           
        }

        /// <summary>
        /// 初始化Grid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public new void Load<T>(List<T> obj) 
        {
            InitGrid(obj);
        }

        /// <summary>
        /// 读取附件信息
        /// </summary>
        public void InitGrid<T>(List<T> list)
        {
            gHandler = new GridHandler(this.GvMain);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("AT_Key", "属性");
            dic.Add("AT_Code", "编码");
            dic.Add("AT_Name", "名字");
            dic.Add("AT_CDate", "日期");
            dic.Add("Stat", "有效");
            dic.Add("AT_tmpPath", "本地路径");
            gHandler.BindData(list, dic, false);
            gHandler.SetDefaultStyle();
            gHandler.SetExcelStyleFilter();
        }

        /// <summary>
        /// 最后保存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="obj">BLL实例</param>
        /// <param name="model">实体</param>
        public void  SaveFile<T,U>(T obj)
        {
            if (GvMain.Rows.Count>0)
            {
                Type type = obj.GetType();
                Type tmptype = typeof(U);
                Object _obj = type.InvokeMember(null,
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |BindingFlags.Instance | BindingFlags.CreateInstance, 
                null, null,null);
                ComplateNo = 0;
                ComplateTotal = GvMain.Rows.Count;
                for (int i = 0; i < GvMain.Rows.Count; i++)
                {
                    try
                    {
                        string at_name = GvMain.Rows[i].Cells["AT_Name"].Value.ToString();
                        int stat = QX.Common.C_Class.Utils.TypeConverter.StrToInt(
                            GvMain.Rows[i].Cells["Stat"].Value.ToString());
                        string at_key = GvMain.Rows[i].Cells["AT_Key"].Value.ToString();
                        string at_code = GvMain.Rows[i].Cells["AT_Code"].Value.ToString();
                        string at_tmppath = GvMain.Rows[i].Cells["AT_tmpPath"].Value.ToString();
                        string TmpFileName = at_name;                      
                        if (stat != 1)
                        {                            
                            if (!ftp.FileExist(TmpFileName))
                            {
                                if (at_tmppath.IndexOf('\\') > 0)
                                    ftp.UploadFileAsync(at_tmppath);
                                //如果数据不存在，则插入，否则更新
                                U _model = (U)type.InvokeMember("GetModel",
                                        BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                                    null, _obj, new object[] { " AND AT_Key='" + at_key + "' AND AT_Code='" + at_code + "' AND AT_Name='"+at_name+"' " });
                                if (_model == null)
                                {
                                    U u = (U)Activator.CreateInstance(tmptype);
                                    PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(U));
                                    for (int j = 0; j < GvMain.Rows[i].Cells.Count; j++)
                                    {
                                        p[GvMain.DisplayLayout.Bands[0].Columns[j].Key].SetValue(u, GvMain.Rows[i].Cells[j].Value);
                                    }
                                    bool result = (bool)type.InvokeMember("Insert",
                                        BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                                        null, _obj, new object[] { u });
                                }
                            }
                        }
                        else
                        {
                            if (ftp.FileExist(TmpFileName))
                            {
                                ftp.DeleteFile(at_name);                                
                            }
                            type.InvokeMember("Delete",
                                    BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                                    null, _obj, new object[] { at_name });
                        }
                        ComplateNo++;
                        GvMain.Rows[i].RowSelectorAppearance.Image = global::QX.Common.Properties.Resources.OK;
                    }
                    catch (Exception)
                    {
                        GvMain.Rows[i].RowSelectorAppearance.Image = global::QX.Common.Properties.Resources.gantan;                       
                    }
                }               
            }
            if (FileUploadComplate != null)
            {
                FileUploadComplate(ComplateNo, ComplateTotal);
            }
        }

        void ftp_UploadFileCompleted(object sender, System.Net.UploadFileCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (FileUploadComplate!=null)
                {
                    bool result = false;
                    if (ComplateNo==FileNames.Length)
                    {
                        result = true;
                    }
                    
                }
                ComplateNo++;
            }
        }
        
        void ftp_UploadProgressChanged(object sender, System.Net.UploadProgressChangedEventArgs e)
        {
            toolProgress.Maximum = (int)e.TotalBytesToSend;
            toolProgress.Minimum = 0;
            toolProgress.Value = (int)e.BytesSent;
            int per=(int)(((float)e.BytesSent / (float)e.TotalBytesToSend) * 100);
            lblProgress.Text = per.ToString()+"%" ;
        }

        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ToolTOP_DelClicked(object sender, EventArgs e)
        {
            if (GvMain.ActiveRow != null)
            {
                GvMain.ActiveRow.Cells["Stat"].Value = true;
                GvMain.ActiveRow.RowSelectorAppearance.Image = 
                    global::QX.Common.Properties.Resources.remove;
            }
        }

        /// <summary>
        /// 添加附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ToolTOP_AddClicked(object sender, EventArgs e)
        {
            OpenFileDialog FDialog = new OpenFileDialog();
            FDialog.InitialDirectory = "c:\\";
            FDialog.RestoreDirectory = false;
            FDialog.FilterIndex = 0;
            FDialog.Title = "文件选择器";
            FDialog.Multiselect = true;
            FDialog.CheckPathExists = true;
            FDialog.CheckFileExists = true;
            FDialog.Filter = "所有文件|*.*|文本文件|*.txt|Word文件|*.doc|Excel文件|*.xls|Rar文件|*.rar";
            if (FDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = FDialog.FileNames;
                if (files.Length>0)
                {
                    FileNames = files;
                    for (int i = 0; i < files.Length; i++)
                    {
                        string tmpFileName= QX.Common.C_Class.Utils.Utils.GetFileName(
                        files[i].ToString());                     
                        UltraGridRow row = GvMain.DisplayLayout.Bands[0].AddNew();
                        row.Cells["AT_Key"].Value = this.at_Key;
                        row.Cells["AT_Code"].Value = this.at_Code;
                        row.Cells["AT_Name"].Value = tmpFileName;
                        row.Cells["Stat"].Value = 0;
                        row.Cells["AT_tmpPath"].Value = files[i].ToString();
                    }
                }
            }
        }
    }
}
