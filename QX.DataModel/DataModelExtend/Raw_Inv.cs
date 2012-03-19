using System;
using System.Collections.Generic;
using System.Text;

namespace QX.DataModel
{
    public partial class Raw_Inv
    {
        private string rI_CompName;
        public string RI_CompName
        {
            get { return rI_CompName; }
            set { rI_CompName = value; }
        }

        private string rI_Comp_CatName;
        public string RI_Comp_CatName
        {
            get { return rI_Comp_CatName; }
            set { rI_Comp_CatName = value; }
        }
    }
}
