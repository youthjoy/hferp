using System;
using System.Collections.Generic;
using System.Text;

namespace QX.DataModel
{
    public partial class Prod_Task
    {
        private int task_PlanNum;

        /// <summary>
        /// 已计划数量
        /// </summary>
        public int Task_PlanNum
        {
            get { return task_PlanNum; }
            set { task_PlanNum = value;}
        }

        /// <summary>
        /// 关联合同编号
        /// </summary>
        public string SDR_ContractCode
        {
            get;
            set;
        }

        public string Cmd_Creator
        {
            get;
            set;
        }
    }
}
