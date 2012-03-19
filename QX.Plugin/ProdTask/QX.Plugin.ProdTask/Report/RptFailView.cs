using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using QX.Plugin.Prod.Report;
using CrystalDecisions.Shared;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;

namespace QX.Plugin.Prod.Report
{
    public partial class RptFailView : Form
    {
        public RptFailView(Failure_Information fi)
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
            Finfo = fi;

            this.Load += new EventHandler(RptViewer_Load);
        }

        public delegate void DCallBackHandler(bool result,Failure_Information fi);
        public event DCallBackHandler CallBack;

        private Failure_Information Finfo
        {
            get;
            set;
        }

        void RptViewer_Load(object sender, EventArgs e)
        {
            ReplaceExportButton();
            Rpt_Failure_Audit rptDocument = new Rpt_Failure_Audit();


            //ParameterDiscreteValue crParameterDiscreteValue;
            //ParameterField crParameterField;
            //ParameterFields crParameterFields;


            //crParameterFields = new ParameterFields();

            ////crParameterFields = new ParameterFields();
            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_ProdNo;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_ProNo";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);

            ////crParameterFields = new ParameterFields();
            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_PartName;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_PartName";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);

            ////crParameterFields = new ParameterFields();
            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_PartNo;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_PartNo";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);

            ////crParameterFields = new ParameterFields();
            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_PartSpec;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_PartSpec";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);

            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_CmdCode;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_CmdCode";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);


            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_FindNodeName;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_FindNodeName";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);


            //crParameterDiscreteValue = new ParameterDiscreteValue();
            //crParameterDiscreteValue.Value = Finfo.FInfo_RespNode;
            //crParameterField = new ParameterField();
            //crParameterField.ParameterFieldName = "FInfo_RespNode";
            //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            //crParameterFields.Add(crParameterField);

            ////crParameterDiscreteValue = null;
            ////crParameterField = null;
            ////crParameterDiscreteValue = new ParameterDiscreteValue();
            ////crParameterDiscreteValue.Value = "这是登录人";
            ////crParameterField = new ParameterField();
            ////crParameterField.ParameterFieldName = "par2";
            ////crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            ////crParameterFields.Add(crParameterField);

            //this.crystalReportViewer1.ParameterFieldInfo = crParameterFields;
            ////List<Road_Components> list = new List<Road_Components>();
            ////BLL.Bll_Road_Components instance = new QX.BLL.Bll_Road_Components();
            ////list = instance.GetAll();

            ////rptDocument.SetDataSource(ConvertX.ToDataTable(list));

            List<VerifyProcess_Records> rlist1 = new Bll_Audit().GetVerfiyProcessRecords(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), Finfo.FInfo_Code);
            List<VerifyProcess_Records> rlist = rlist1.Where(o => o.VRecord_UDef5 != "Return").OrderBy(o=>o.VRecord_ID).ToList();

            ParameterDiscreteValue crParameterDiscreteValue;
            ParameterField crParameterField;
            ParameterFields crParameterFields;
            crParameterFields = new ParameterFields();

            if (rlist.Count < 5)
            {
                int count = 5 - rlist.Count;
                for (int i = 0; i < count; i++)
                {
                    rlist.Add(new VerifyProcess_Records());
                }

                if (rlist[rlist.Count-2].VRecord_VCode == "100000000040")
                {
                    var temp = rlist[3];
                    rlist[4] = temp;
                    rlist[3] = new VerifyProcess_Records();
                }
            }

            for (int i = 0; i < rlist.Count; i++)
            {
                if (i >= 5)
                {
                    break;
                }
                string name = "Content" + i;

                crParameterDiscreteValue = new ParameterDiscreteValue();
                string val = rlist[i].VRecord_Opinion;
                if (string.IsNullOrEmpty(val))
                {
                    crParameterDiscreteValue.Value = "";
                }
                else
                {
                    crParameterDiscreteValue.Value = val;
                }

                crParameterField = new ParameterField();
                crParameterField.ParameterFieldName = "Content" + i;
                crParameterField.ParameterValueType = ParameterValueKind.StringParameter; ;
                crParameterField.CurrentValues.Add(crParameterDiscreteValue);
                crParameterFields.Add(crParameterField);

                crParameterDiscreteValue = new ParameterDiscreteValue();
                string date = rlist[i].VRecord_Date.ToString();
                if (string.IsNullOrEmpty(date))
                {
                    date = " ";
                }
                crParameterDiscreteValue.Value = date;
                crParameterField = new ParameterField();
                crParameterField.ParameterFieldName = "Date" + i;
                crParameterField.ParameterValueType = ParameterValueKind.StringParameter; ;
                crParameterField.CurrentValues.Add(crParameterDiscreteValue);
                crParameterFields.Add(crParameterField);

                crParameterDiscreteValue = new ParameterDiscreteValue();
                string hand = rlist[i].VRecord_UDef3;
                if (string.IsNullOrEmpty(hand))
                {
                    hand = " ";
                }
                crParameterDiscreteValue.Value = hand;
                crParameterField = new ParameterField();
                crParameterField.ParameterFieldName = "Hand" + i;
                crParameterField.ParameterValueType = ParameterValueKind.StringParameter; ;
                crParameterField.CurrentValues.Add(crParameterDiscreteValue);
                crParameterFields.Add(crParameterField);


                crParameterDiscreteValue = new ParameterDiscreteValue();
                string owner = rlist[i].VRecord_Owner;
                if (string.IsNullOrEmpty(owner))
                {
                    crParameterDiscreteValue.Value = "";
                }
                else
                {
                    crParameterDiscreteValue.Value = owner;
                }
                
                crParameterField = new ParameterField();
                crParameterField.ParameterFieldName = "Owner" + i;
                crParameterField.ParameterValueType = ParameterValueKind.StringParameter; ;
                crParameterField.CurrentValues.Add(crParameterDiscreteValue);
                crParameterFields.Add(crParameterField);

            }

            this.crystalReportViewer1.ParameterFieldInfo = crParameterFields;
            //this.crystalReportViewer1.ParameterFieldInfo = crParameterFields;
            DataTable dt = new Bll_Comm().ListViewData(string.Format("select * from VRpt_FInformation where  FInfo_Code='{0}'", Finfo.FInfo_Code));
            rptDocument.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rptDocument;
        }

        //核心
        private void ReplaceExportButton()
        {
            //遍历crystalReportViewer1控件里的控件
            foreach (object ctl in crystalReportViewer1.Controls)
            {
                //取得控件名称
                string sControl = ctl.GetType().Name.ToString().ToLower();
                //取得工具条
                if (sControl == "toolstrip")
                {
                    ToolStrip tab1 = (ToolStrip)ctl;
                    //遍历工具条Item
                    for (int i = 0; i <= tab1.Items.Count - 1; i++)
                    {
                        //MessageBox.Show(tab1.Items[i].ToolTipText);
                        //如果是导出按钮
                        if (tab1.Items[i].ToolTipText == "打印报表")
                        {
                            tab1.Items[i].Click += new EventHandler(tbutton_Click);
                            ////先创建一个ToolStripButton准备替代现有Button
                            //ToolStripButton tbutton = new ToolStripButton();
                            ////获取原导出按钮的按钮图片
                            //Image img1 = tab1.Items[i].Image;
                            ////移除原导出按钮
                            //tab1.Items.Remove(tab1.Items[i]);
                            ////设置新button属性
                            //tbutton.Image = img1;
                            //tbutton.ToolTipText = "自定义导出报表按钮";
                            ////在原位置上插入新Button
                            //tab1.Items.Insert(0, tbutton);

                            ////绑定自定义事件
                            //tbutton.Click += new EventHandler(tbutton_Click);
                            break;
                        }

                    }
                }

            }
        }

        void tbutton_Click(object sender, EventArgs e)
        {
            if (CallBack != null)
            {
                CallBack(true, Finfo);
            }
        }
    }
}
