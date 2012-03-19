using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.DataModel;
using CrystalDecisions.Shared;
using QX.BLL;
using QX.Common.C_Class;

namespace QX.Plugin.Prod.Report
{
    public partial class RptFBView : Form
    {
        public RptFBView(Bse_Feedback feed)
        {
            InitializeComponent();

            FInfo = feed;

            this.Load += new EventHandler(RptFBView_Load);
        }

        private Bse_Feedback FInfo
        {
            get;
            set;
        }

        void RptFBView_Load(object sender, EventArgs e)
        {
            List<VerifyProcess_Records> rlist = new Bll_Audit().GetVerfiyProcessRecords(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(), FInfo.FB_Code);
            ParameterDiscreteValue crParameterDiscreteValue;
            ParameterField crParameterField;
            ParameterFields crParameterFields;
            crParameterFields = new ParameterFields();

            Rpt_Customers_Feedback rptDocument = new Rpt_Customers_Feedback();
            if (rlist.Count < 4)
            {
                int count = 4 - rlist.Count;
                for (int i = 0; i < count; i++)
                {
                    rlist.Add(new VerifyProcess_Records());
                }
            }

            for (int i = 0; i < rlist.Count; i++)
            {

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
                //string hand = rlist[i].VRecord_UDef3;
                //if (string.IsNullOrEmpty(hand))
                //{
                //    hand = " ";
                //}
                //crParameterDiscreteValue.Value = hand;
                //crParameterField = new ParameterField();
                //crParameterField.ParameterFieldName = "Hand" + i;
                //crParameterField.ParameterValueType = ParameterValueKind.StringParameter; ;
                //crParameterField.CurrentValues.Add(crParameterDiscreteValue);
                //crParameterFields.Add(crParameterField);


            }

            this.crystalReportViewer1.ParameterFieldInfo = crParameterFields;
            //this.crystalReportViewer1.ParameterFieldInfo = crParameterFields;
            DataTable dt = new Bll_Comm().ListViewData(string.Format("select * from VRpt_FeedBack where  FB_Code='{0}'", FInfo.FB_Code));
            rptDocument.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rptDocument;
        }
    }
}
