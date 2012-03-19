using System;
using System.Collections.Generic;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;
using QX.Common.C_Class;
using QX.DataAcess;

namespace QX.BLL
{
    public class Bll_FHelper_ManuList
    {
        private ADOFHelper_ManuList Instance = new ADOFHelper_ManuList();

        public List<FHelper_ManuList> GetManuList()
        {
            return Instance.GetAll();
        }
    }
}
