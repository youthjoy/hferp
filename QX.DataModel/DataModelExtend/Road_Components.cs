using System;
using System.Collections.Generic;
using System.Text;

namespace QX.DataModel
{
    public partial class Road_Components
    {
        private decimal _RComponents_TimeCost;

        public decimal RComponents_TimeCost
        {
            get { return _RComponents_TimeCost; }
            set { _RComponents_TimeCost = value; }
        }

        private string _RComponents_AuditStat;
        /// <summary>
        /// 审核状态名称
        /// </summary>
        public string RComponents_AuditStat
        {
            get { return _RComponents_AuditStat; }
            set { _RComponents_AuditStat = value; }
        }

    }
}
