using System;
using System.Collections.Generic;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;
using QX.Common.C_Class;
using QX.DataAcess;
using QX.Shared;

namespace QX.BLL
{
    public class Bll_FHelper_Price
    {
        public ADOFHelper_Price instance = new ADOFHelper_Price();


        public Bll_Audit AuditInstance = new Bll_Audit();

        /// <summary>
        /// 根据零件图号和工序编码获取已通过审核的外协价格信息(默认取第一条)
        /// </summary>
        /// <param name="compCode"></param>
        /// <param name="nodeCode"></param>
        /// <returns></returns>
        public FHelper_Price GetFHelperPrice(string compCode, string nodeCode)
        {
            string where = string.Format(" AND FP_CompCode='{0}' AND FP_PNodeCode='{1}' AND AuditStat='{2}' Order by FP_Price ", compCode, nodeCode, OperationTypeEnum.AudtiOperaTypeEnum.LastAudit);
            List<FHelper_Price> list = instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public List<FHelper_Price> GetFHelperPrice(string filter)
        {
            string where = string.Format(filter);
            List<FHelper_Price> list = instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list;
            }
            else
            {
                return new List<FHelper_Price>();
            }
        }


        public List<FHelper_Price> GetAuditingList()
        {
            //string strCondition = AuditInstance.GetUserPorcesForStrCondition();
            string strCondition = AuditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.FHelperPriceAudit.ToString(), SessionConfig.UserCode);

            StringBuilder sb = new StringBuilder();
            List<FHelper_Price> re = new List<FHelper_Price>();
            //如果strCondition为空即表示没有待用户审核的列表
            if (!string.IsNullOrEmpty(strCondition))
            {
                sb.AppendFormat(" And AuditStat IN ('{0}','{1}') ", OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString(), OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString());
                sb.AppendFormat(" AND {0} ", strCondition);
                string where = sb.ToString();

                re = instance.GetListByWhere(where);
            }
          
            return re;
        }

        /// <summary>
        /// 根据供应商编码和零件图号和工序编码获取已通过审核的外协价格信息
        /// </summary>
        /// <param name="compCode"></param>
        /// <param name="nodeCode"></param>
        /// <returns></returns>
        public FHelper_Price GetFHelperPrice(string manuCode, string compCode, string nodeCode)
        {
            string where = string.Format(" AND FP_ManuCode='{2}' AND FP_CompCode='{0}' AND FP_PNodeCode='{1}'  Order by FP_Price ", compCode, nodeCode, manuCode);
            List<FHelper_Price> list = instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取待审核外协价格信息列表
        /// </summary>
        /// <returns></returns>
        public List<FHelper_Price> GetHandingPriceList()
        {
            //string filter = AuditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.FHelperPriceAudit.ToString(), SessionConfig.UserCode);

            string where = string.Format(" Order by FP_ID desc");
            return instance.GetListByWhere(where);
        }

        public List<FHelper_Price> GetFHelperPriceListForSearch(string bDate, string eDate, string key)
        {
            string where = string.Format(" AND FP_CreaTime between '{0}' and '{1}' AND (FP_CompCode like '%{2}%' OR FP_ManuCode like '%{2}%' OR FP_ManuName like '%{2}%') Order by FP_ID desc",bDate,eDate,key);
            return instance.GetListByWhere(where);
        }


        public string GenerateFPCode()
        {
            return new Bll_Comm().GenerateCode("FHelper_Price");
        }

        public bool AddPrice(FHelper_Price model)
        {
            model.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

            var node = AuditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FHelperPriceAudit.ToString());

            if (node != null)
            {
                model.AuditCurAudit = node.VT_VerifyNode_Code;
            }

            return Insert(model);
        }


        public bool AddPriceList(List<FHelper_Price> list)
        {
            var node = AuditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FHelperPriceAudit.ToString());

            foreach (var model in list)
            {
                model.FP_Code = GenerateFPCode();
                model.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
                model.FP_Creatime = DateTime.Now;
                if (node != null)
                {
                    model.AuditCurAudit = node.VT_VerifyNode_Code;
                }
                Insert(model);
            }
            return true;
        }


        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(FHelper_Price model)
        {
            bool result = false;
            try
            {
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public FHelper_Price GetModelByCode(string code)
        {
            return GetModel(string.Format(" AND FP_Code='{0}'", code));
        }

        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public FHelper_Price GetModel(string strCondition)
        {
            List<FHelper_Price> list = instance.GetListByWhere(strCondition);
            FHelper_Price model = new FHelper_Price();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            else
            {
                model = null;
            }
            return model;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(FHelper_Price model)
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
            List<FHelper_Price> list = instance.GetListByWhere(" AND FP_Code='" + Code + "'");
            if (list.Count > 0)
            {
                FHelper_Price model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
