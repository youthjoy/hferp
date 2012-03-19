using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;

namespace QX.Plugin.Prod
{
    public partial class SetFinishTask : F_BasicPop
    {
        public SetFinishTask()
        {
            InitializeComponent();
        }

        public SetFinishTask(Dictionary<string,Prod_Task> list)
        {
            InitializeComponent();
            FinTaskList = list;
        }



        private void SetFinishTask_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            InitShowText();
        }

        public void InitShowText()
        {
            //// 
            //// label1
            //// 
            //this.label1.AutoSize = true;
            //this.label1.Location = new System.Drawing.Point(42, 16);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(41, 12);
            //this.label1.TabIndex = 2;
            //this.label1.Text = "label1";
            //// 
            //// dateTimePicker1
            //// 
            //this.dateTimePicker1.Location = new System.Drawing.Point(200, 12);
            //this.dateTimePicker1.Name = "dateTimePicker1";
            //this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            //this.dateTimePicker1.TabIndex = 3;

            if (FinTaskList != null && FinTaskList.Count > 0)
            {
                //StringBuilder sb = new StringBuilder();
                int i = 2;
                //int startPositinX = 42;
                int startPositinY = 16;
                int height = 80;
                foreach (KeyValuePair<string,Prod_Task> kv in FinTaskList)
                {
                    Prod_Task pt = kv.Value;
                    i++;
                    Label label = new Label();
                    label.Name = "LB" + pt.Task_Code;
                    label.Location = new System.Drawing.Point(42, startPositinY);
                    label.Size = new System.Drawing.Size(100, 20);
                    label.TabIndex = i;
                    label.Text = pt.Task_Code + "  " + pt.Task_Name ;

                    DateTimePicker dateTimePicker1=new DateTimePicker();
                    dateTimePicker1.Name=pt.Task_Code;

                    dateTimePicker1.Location = new System.Drawing.Point(200, startPositinY);
                    dateTimePicker1.Size = new System.Drawing.Size(200, 20);
                    dateTimePicker1.TabIndex = i+1;

                    startPositinY=startPositinY + 50;
                    height = height + 50;
                    pnlTask.Controls.Add(label);
                    pnlTask.Controls.Add(dateTimePicker1);
                }

                this.Height = height;
            }
        }

        public delegate void DCallBackHandler(bool result, object sender);
        public event DCallBackHandler CallBack;

        private Bll_ProdTask ptInstance = new Bll_ProdTask();

        private Dictionary<string, Prod_Task> FinTaskList;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //ptInstance.UpdateProdTaskStat
            UpdateStat();
        }


        private void UpdateStat()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Control item in this.pnlTask.Controls)
            {
                if (item.GetType() == typeof(DateTimePicker))
                {
                    Prod_Task prodTask= FinTaskList[item.Name];
                   prodTask.TaskDetail_ActEnd = ((DateTimePicker)item).Value;
                    prodTask.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Finish.ToString();

                    if (ptInstance.UpdateProdTaskStat(prodTask)<=0)
                    {
                        sb.AppendLine(prodTask.Task_Name + "  " + prodTask.Task_Code);
                    }
                }
            }

            if (!string.IsNullOrEmpty(sb.ToString()))
            {
                Alert.Show("以下生产任务未能设置成功:" + sb.ToString());
                if (CallBack != null)
                {
                    CallBack(true, null);
                }
                this.Close();
            }
            else
            {
                if (CallBack != null)
                {
                    CallBack(true, null);
                }
                Alert.Show("设置成功!");
                this.Close();
            }

        }


    }
}
