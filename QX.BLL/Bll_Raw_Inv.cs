using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using System.Linq;
namespace QX.BLL
{
    public class Bll_Raw_Inv
    {
        public DataAceess.ADORaw_Inv Instance = new ADORaw_Inv();

        public List<Raw_Inv> GetAvailableRawList()
        {
            string where = string.Format(" AND RI_AvailableNum!=0");
            return Instance.GetListByWhereExtend(where);
        }

        public List<Raw_Inv> GetAll()
        {
            return Instance.GetListByWhere("");
        }
        /// <summary>
        /// 库存信息 搜索
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Raw_Inv> GetInvByWhere(string where)
        {
            return Instance.GetListByWhere(where);
        }

        public List<Raw_Inv> GetInvByCmdAndPartNo(string cmdCode, string partno)
        {
            string where = string.Format(" AND RI_CompCode='{0}' AND RI_CmdCode='{1}'",partno,cmdCode);
            List<Raw_Inv> list = Instance.GetListByWhere(where);
            return list;
        }

        public Raw_Inv GetModel(string where)
        {
            return Instance.GetListByWhere(where).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawCode">库存编码</param>
        /// <param name="delpoyNum">使用数量</param>
        /// <returns></returns>
        public int DeployRawInv(string rawCode,int delpoyNum)
        {
            Raw_Inv rawInv= GetByKey(rawCode);
            rawInv.RI_AvailableNum = rawInv.RI_AvailableNum - delpoyNum;
            rawInv.RI_UsedNum = rawInv.RI_UsedNum + delpoyNum;
            return Update(rawInv);
        }

        public int Update(Raw_Inv obj)
        {
            return Instance.Update(obj);
        }

        public Raw_Inv GetByKey(string RawCode)
        {
            string where = string.Format(" AND RI_Code='{0}'",RawCode);
            List<Raw_Inv> list=Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public bool Add(Raw_Inv inv)
        {
            bool flag = false;
             
            if (Instance.Add(inv) > 0)
            {
                flag = true;
            }

            return flag;
        }

        public string GenerateRawInvCode()
        {
            return new Bll_Comm().GenerateCode("Raw_Inv");
        }
    }
}
