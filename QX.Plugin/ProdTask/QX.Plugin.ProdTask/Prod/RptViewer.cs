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

namespace QX.Plugin.Prod.Prod
{
    public partial class RptViewer : Form
    {
        public RptViewer()
        {
            InitializeComponent();

            this.Load += new EventHandler(RptViewer_Load);
        }

        void RptViewer_Load(object sender, EventArgs e)
        {
            RPTTest rptDocument = new RPTTest();
            ParameterDiscreteValue crParameterDiscreteValue;
            ParameterField crParameterField;
            ParameterFields crParameterFields;


            crParameterFields = new ParameterFields();
            crParameterDiscreteValue = new ParameterDiscreteValue();
            crParameterDiscreteValue.Value = "不合格品";
            crParameterField = new ParameterField();
            crParameterField.ParameterFieldName = "par1";
            crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            crParameterFields.Add(crParameterField);


            crParameterDiscreteValue = null;
            crParameterField = null;
            crParameterDiscreteValue = new ParameterDiscreteValue();
            crParameterDiscreteValue.Value = "这是登录人";
            crParameterField = new ParameterField();
            crParameterField.ParameterFieldName = "par2";
            crParameterField.CurrentValues.Add(crParameterDiscreteValue);
            crParameterFields.Add(crParameterField);

            this.crystalReportViewer1.ParameterFieldInfo = crParameterFields;
            List<Road_Components> list = new List<Road_Components>();
            BLL.Bll_Road_Components instance = new QX.BLL.Bll_Road_Components();
            list = instance.GetAll();
            
            rptDocument.SetDataSource(ConvertX.ToDataTable(list));
            crystalReportViewer1.ReportSource = rptDocument;
        }
    }
}
