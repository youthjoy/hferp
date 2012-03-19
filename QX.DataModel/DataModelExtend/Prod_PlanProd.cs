using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.DataModel
{
    public partial class Prod_PlanProd
    {
        /// <summary>
        /// 当前节点状态（处于哪个工序）
        /// </summary>
        public string IInfor_Stat
        {
            get;
            set;
        }

        public string IInfor_ProdStat
        {
            get;
            set;
        }
    }
}
