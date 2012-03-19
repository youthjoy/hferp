using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using QX.Framework.AutoForm;
using QX.DataModel;
using QX.Common.C_Class;

namespace QX.Plugin.Prod.ComControl
{
    public partial class FailureProdHandle : Form
    {
        public FailureProdHandle(Failure_Information fi)
        {
            InitializeComponent();
            FInfo = fi;
            BindTopTool();
            this.Load += new EventHandler(Form_Load);
        }


        void Form_Load(object sender, EventArgs e)
        {
            InitData();
        }

        public void BindTopTool()
        {
            this.tool_topbar.SaveClicked += new EventHandler(tool_topbar_SaveClicked);
        }

        void tool_topbar_SaveClicked(object sender, EventArgs e)
        {
            if (SaveData())
            {
                
                this.Close();
            }
        }

        public Failure_Information FInfo
        {
            get;
            set;
        }

        UltraGrid comGrid = new UltraGrid();

        GridHelper gHelper = new GridHelper();

        private BLL.Bll_Failure_Information fInstance = new QX.BLL.Bll_Failure_Information();

        public void InitData()
        {
            comGrid = gHelper.GenerateGrid("CList_FRelationCon", this.panel1, new Point(0, 0));
            comGrid.DisplayLayout.Override.AllowAddNew = AllowAddNew.No;
            List<Failure_Relation> list = fInstance.GetRelation(FInfo.FInfo_Code);
            comGrid.DataSource = list;
        }

        public bool SaveData()
        {
            List<Failure_Relation> list = new List<Failure_Relation>();

            StringBuilder sb = new StringBuilder();

            foreach (var row in this.comGrid.Rows)
            {
                Failure_Relation f = row.ListObject as Failure_Relation;

                sb.Append(f.FR_ProdCode).Append(",");

                if (f.FR_Udef1 == "Raw")
                {
                    return true;
                }
                list.Add(f);
            }

            if (!Alert.ShowIsConfirm(string.Format("确定对以下零件:{0} 进行状态扭转吗?",sb.ToString().TrimEnd(','))))
            {
                return false;
            }

            fInstance.BatchProdStatChange(list);

            QX.Log.PlateLog.WriteOp(QX.Shared.SessionConfig.UserCode
, QX.Shared.SessionConfig.UserName
, "localhost"
, this.Name
, DateTime.Now.ToString() + "," + QX.Shared.SessionConfig.UserName + QX.Common.MessageContent.GetInstance().Failure
, QX.Log.PlateLog.LogMessageType.Info, QX.Common.LogModule.Failure.ToString(), QX.Common.LogType.Audit.ToString());


            return true;
        }
    }
}
