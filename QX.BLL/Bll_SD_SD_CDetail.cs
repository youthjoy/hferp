using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QX.DataModel;
using QX.DataAceess;
using System.Data.SqlClient;
using System.Data;

namespace QX.BLL
{
    public class Bll_SD_CDetail
    {
        public ADOSD_CDetail instance = new ADOSD_CDetail();

        public ADOSD_ContractTrace sdtInstance = new ADOSD_ContractTrace();

        public ADOSD_Finance sfInstance = new ADOSD_Finance();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<SD_CDetail> GetAll()
        {
            List<SD_CDetail> list = instance.GetAll();
            return list;
        }


        public List<SD_CDetail> GetCDetailByContract(string cCode)
        {
            string where = string.Format(" AND CDetail_ContractNo='{0}'", cCode);
            return instance.GetListByWhere(where);
        }


        public List<SD_ContractTrace> GetTraceContractList(string cCode)
        {
            string where = string.Format(" AND SDT_MainCode='{0}'", cCode);
            return sdtInstance.GetListByWhere(where);
        }

        public bool AddOrUpdateContractTrace(SD_CDetail main, List<SD_ContractTrace> list)
        {
            bool result = false;
            //long ContractId = 0;
            try
            {

                List<SD_ContractTrace> oldList = GetTraceContractList(main.CDetail_Code);

                //保存合同细目
                for (int i = 0; i < oldList.Count; i++)
                {
                    var temp = list.FirstOrDefault(o => o.SDT_Code == oldList[i].SDT_Code);

                    if (temp != null)
                    {
                        //var item = SDetailList[i];
                        var item = oldList[i];
                        //if (bllCdetail.CheckExist(SDetailList[i].CDetail_ContractNo, SDetailList[i].CDetail_PartNo))
                        //{
                        temp.SDT_ID = item.SDT_ID;
                        Update(temp);
                        list.Remove(temp);

                    }
                    else
                    {
                        Delete(oldList[i]);
                    }
                }

                foreach (var it in list)
                {

                    it.SDT_Code = GenerateCTraceCode();
                    it.SDT_MainCode = main.CDetail_Code;
                    it.SDT_ContractCode = main.CDetail_ContractNo;
                    it.SDT_PartNo = main.CDetail_PartNo;
                    it.SDT_PartName = main.CDetail_PartName;
                    Insert(it);
                }

                //bllContract.instance.idb.CommitTransaction();
                result = true;
            }
            catch (Exception ex)
            {
                //bllContract.instance.idb.RollbackTransaction();
                throw ex;
            }

            return result;
        }

        public string GenerateCTraceCode()
        {
            return new Bll_Comm().GenerateCode("SD_ContractTrace");

        }

        public bool Insert(SD_ContractTrace model)
        {
            if (sdtInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(SD_ContractTrace model)
        {
            if (sdtInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }


        public bool Delete(SD_ContractTrace model)
        {
            model.Stat = 1;
            if (sdtInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }



        public DataTable GetCDetailForExport(List<SD_Contract> list)
        {
            StringBuilder sbDetail = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append(" AND  CDetail_ContractNo in (");
            foreach (var s in list)
            {
                sbDetail.AppendFormat("'{0}',", s.Contract_Code);
            }
            sb.Append(sbDetail.ToString().TrimEnd(','));
            sb.Append(")");
            string where = string.Format(" {0}", sb.ToString());
            return instance.GetListByWhereForExport(where);
        }

        public List<Prod_CmdDetail> GetCmdDetailByContract(string cCode)
        {
            string where = string.Format(" AND CDetail_ContractNo='{0}'", cCode);
            var list = instance.GetListByWhere(where);
            List<Prod_CmdDetail> cmdList = new List<Prod_CmdDetail>();
            foreach (SD_CDetail d in list)
            {
                Prod_CmdDetail item = new Prod_CmdDetail();
                item.CmdDetail_PartName = d.CDetail_PartName;
                item.CmdDetail_PartNo = d.CDetail_PartNo;
                item.CmdDetail_Roads = d.CDetail_Intro;
                item.CmdDetail_Num = d.CDetail_Num;
                //施工号
                item.CmdDetail_PCode = d.CDetail_Project;
                cmdList.Add(item);
            }

            return cmdList;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(SD_CDetail model)
        {
            bool result = false;
            int _result = instance.Add(model);
            if (_result > 0)
            {
                result = true;
            }
            return result;
        }


        /// <summary>
        /// 插入数据 并返回数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public long InsertWithReturnId(SD_CDetail model)
        {
            long result = 0;
            object _result = instance.AddWithReturn(model);
            if (_result != null)
            {
                long.TryParse(_result.ToString(), out result);
            }
            return result;
        }

        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public SD_CDetail GetModel(string strCondition)
        {
            List<SD_CDetail> list = instance.GetListByWhere(strCondition);
            SD_CDetail model = new SD_CDetail();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }

        public List<SD_CDetail> GetList(string strCondition)
        {
            List<SD_CDetail> list = instance.GetListByWhere(strCondition);
            return list;
        }

        public List<SD_CDetail> GetDetailListByCust(string cust)
        {
            string where = string.Format(" AND Contract_CustCode='{0}' group by CDetail_PartNo,CDetail_PartName", cust);
            List<SD_CDetail> list = instance.GetListByWhereForCust(where);
            return list;
        }

        public string GenerateCDetailCode()
        {
            return new Bll_Comm().GenerateCode("SD_CDetail");
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(SD_CDetail model)
        {
            bool result = false;
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }

        public bool Delete(SD_CDetail sc)
        {
            bool flag = false;
            sc.Stat = 1;
            if (instance.Update(sc) > 0)
            {
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(string Code)
        {
            bool result = false;
            List<SD_CDetail> list = instance.GetListByWhere(" AND Contract_Code='" + Code + "'");
            if (list.Count > 0)
            {
                SD_CDetail model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// 检查细则中是否存在
        /// </summary>
        /// <param name="CDetail_ContractNo"></param>
        /// <param name="CDetail_PartNo"></param>
        /// <returns></returns>
        public bool CheckExist(string CDetail_ContractNo, string CDetail_PartNo)
        {
            bool result = false;
            string str = " AND CDetail_ContractNo='" + CDetail_ContractNo + "' AND CDetail_PartNo='" + CDetail_PartNo + "'";
            SD_CDetail model = GetModel(str);
            if (model != null && !String.IsNullOrEmpty(model.CDetail_PartNo))
            {
                result = true;
            }
            return result;
        }



        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public bool BathDelete(string strCondition)
        {
            bool result = false;
            int _result = instance.idb.ExeCmd("update SD_CDetail Set Stat=1 Where 1=1  " + strCondition);
            if (_result > 0)
            {
                result = true;
            }
            return result;
        }



        #region 零件编号关联

        private ADOSD_CRProdCode sdrInstance = new ADOSD_CRProdCode();

        public List<SD_CRProdCode> GetCDetailRelation(string detailcode)
        {
            string where = string.Format(" AND SDR_DetailCode='{0}'",detailcode);
            return sdrInstance.GetListByWhere(where);
        }

        public List<SD_ContractTrace> GetContractTraceList(string detailcode)
        {
            string where = string.Format("AND SDT_MainCode='{0}'",detailcode);
            return sdtInstance.GetListByWhere(where);
        }

        public bool AddOrUpdateSDRelation(SD_CDetail detail,List<SD_CRProdCode> list)
        {
            var oldlist=GetCDetailRelation(detail.CDetail_Code);
            foreach (var d in oldlist)
            {
                var model=list.FirstOrDefault(o => o.SDR_Code == d.SDR_Code);
                if (model != null)
                {
                    model.SDR_ID = d.SDR_ID;
                    model.SDR_DetailCode = detail.CDetail_Code;
                    UpdateSDRelation(model);
                    list.Remove(model);
                }
                else
                {
                    DeleteSDRelation(d);
                }
            }

            foreach (var d in list)
            {
                d.SDR_Code = GenerateSDRelationCode();
                d.SDR_ContractCode = detail.CDetail_ContractNo;
                d.SDR_DetailCode = detail.CDetail_Code;
                AddSDRelation(d);
            }

            return true;
        }
        private BLL.Bll_Comm comInstance = new Bll_Comm();
        public string GenerateSDRelationCode()
        {
            return comInstance.GenerateCode("SD_CDRelation");
        }

        public string GenerateSDFinance()
        {
            return comInstance.GenerateCode("SD_Finance");
        }
        public bool AddSDRelation(SD_CRProdCode sd)
        {
            if (sdrInstance.Add(sd) > 0)
            {
                return true;
            }
            return false;

        }

        public bool UpdateSDRelation(SD_CRProdCode sd)
        {
            if (sdrInstance.Update(sd) > 0)
            {
                return true;
            }
            return false;

        }

        public bool DeleteSDRelation(SD_CRProdCode sd)
        {
            sd.Stat = 1;
            if (sdrInstance.Update(sd) > 0)
            {
                return true;
            }
            return false;

        }

        #endregion

        #region 产值

        public List<SD_Finance> GetFinanceListByContract(SD_CDetail sd)
        {
            string where = string.Format(" AND SDF_ContractCode='{0}' AND SDF_PartNo='{1}'",sd.CDetail_ContractNo,sd.CDetail_PartNo);
            var list = sfInstance.GetListByWhere(where);
            return list;
        }

        public List<SD_Finance> GetFinanceList(string bdate,string edate,string key)
        {
            //string where = string.Format(" AND SDF_ContractCode='{0}' AND SDF_PartNo='{1}'", sd.CDetail_ContractNo, sd.CDetail_PartNo);
            //var list = sfInstance.GetListByWhere(where);
            return sfInstance.GetAll();
        }

        public List<SD_Finance> GetFinanceListForPatch(string custcode, string partno, string prodtype)
        {
            string where = string.Format("AND SDF_PartNo='{0}' AND SDF_Customer='{1}' AND SDF_ProdType='{2}'", partno, custcode, prodtype);
            return sfInstance.GetListByWhere(where);
        }

        public bool AddOrUpdateFinance(SD_CDetail sd,List<SD_Finance> list)
        {
            List<SD_Finance> oldlist = GetFinanceListByContract(sd);
            
            foreach (var d in oldlist)
            {
                var model = list.FirstOrDefault(o => o.SDF_Code == d.SDF_Code);
                if (model != null)
                {
                    model.SDF_ID = d.SDF_ID;
                    
                    UpdateFinance(model);
                    list.Remove(model);
                }
                else
                {
                    DeleteFinance(d);
                }
            }

            foreach (var d in list)
            {
                d.SDF_Code = GenerateSDFinance();
               
                AddFinance(d);
            }

            return true;
        }

        public bool UpdateFinance(SD_Finance d)
        {
            if (sfInstance.Update(d)>0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteFinance(SD_Finance d)
        {
            d.Stat = 1;
            if (sfInstance.Update(d) > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddFinance(SD_Finance d)
        {
            if (sfInstance.Add(d) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
