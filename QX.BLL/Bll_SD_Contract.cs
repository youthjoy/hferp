using System;
using System.Collections.Generic;
using System.Text;

using QX.DataModel;
using QX.DataAceess;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
    public class Bll_SD_Contract
    {
        public ADOSD_Contract instance = new ADOSD_Contract();

        private Bll_Audit auditInstance = new Bll_Audit();

        /// <summary>
        /// 获取已过终审合同
        /// </summary>
        /// <returns></returns>
        public List<SD_Contract> GetLastAudit()
        {
            string where = string.Format(" AND AuditStat='{0}'",OperationTypeEnum.AudtiOperaTypeEnum.LastAudit);
            List<SD_Contract> list = instance.GetListByWhere(where);
            return list;
        }

        public List<SD_Contract> GetMyList()
        {
            string where = string.Format(" ");
            List<SD_Contract> list = instance.GetListByWhere(where);
            return list;
        }


        public List<SD_Contract> GetContractListByWhere(string bDate,string eDate,string key)
        {

            string where = string.Format(" AND Contract_Date between '{1}' and '{2}' AND (Contract_Code like '%{0}%' OR Contract_CustName like '%{0}%' OR CDetail_PartName like '%{0}%' OR CDetail_PartNo like '%{0}%' OR CDetail_Intro like '%{0}%'  OR CDetail_Project like '%{0}%' OR CDetail_Cmd like '%{0}%' ) ", key, bDate, eDate);
            List<SD_Contract> list = instance.GetListByWhereExtend(where);
            return list;
        }


        public string GenerateContractCode()
        {
            return new Bll_Comm().GenerateCode("SD_Contract");
        }


        /// <summary>
        /// 获取当前用户待审核合同列表
        /// </summary>
        /// <returns></returns>
        public List<SD_Contract> GetAuditContract()
        {
            string where = auditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.ContractAudit.ToString(), SessionConfig.UserCode);

            List<SD_Contract> list = instance.GetListByWhere(string.Format(" AND AuditStat in ('{0}','{1}') AND {2}",OperationTypeEnum.AudtiOperaTypeEnum.OnAudit,OperationTypeEnum.AudtiOperaTypeEnum.Auditing,where));
            return list;
        }


        public bool AddContract(SD_Contract model)
        {
            model.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
            var node = auditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.ContractAudit.ToString());
            if (node != null)
            {
                model.AuditCurAudit = node.VT_VerifyNode_Code;

                auditInstance.InsertNextAuditRecord(OperationTypeEnum.AuditTemplateEnum.ContractAudit.ToString(), node.VT_VerifyNode_Code, model.Contract_Code);
            }

            return Insert(model);

        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(SD_Contract model)
        {
            bool result = false;
            try
            {
                //instance.idb.BeginTransaction();
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            catch (Exception)
            {
                //instance.idb.RollbackTransaction();
            }

            return result;
        }

        /// <summary>
        /// 插入数据 并返回数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public long InsertWithReturnId(SD_Contract model)
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
        public SD_Contract GetModel(string strCondition)
        {
            List<SD_Contract> list = instance.GetListByWhere(strCondition);
            SD_Contract model = new SD_Contract();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(SD_Contract model)
        {
            bool result = false;
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(string Code)
        {
            bool result = false;
            List<SD_Contract> list = instance.GetListByWhere(" AND Contract_Code='" + Code + "'");
            if (list.Count > 0)
            {
                SD_Contract model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public SD_Contract GetByKey(long Id)
        {
            SD_Contract model = new SD_Contract();
            model = instance.GetByKey(Id);
            return model;
        }
    }
}
