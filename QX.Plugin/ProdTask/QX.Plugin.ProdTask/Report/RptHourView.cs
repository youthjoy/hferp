using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.Shared;
using QX.BLL;

namespace QX.Plugin.Prod.Report
{
    public partial class RptHourView : Form
    {
        public RptHourView(string code)
        {
            InitializeComponent();
            DataCode = code;
            this.Load += new EventHandler(RptViewer_Load);
        }

        public string DataCode
        {
            get;
            set;
        }

        void RptViewer_Load(object sender, EventArgs e)
        {
            Rpt_Ticket_Hours rptDocument = new Rpt_Ticket_Hours();
            DataTable dt = new Bll_Comm().ListViewData(string.Format("select * from VRpt_TicketHours {0}",DataCode));
            rptDocument.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rptDocument;
        }
    }
}
