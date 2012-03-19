using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;
using QX.Common.C_Class;
using QX.DataAcess;
using QX.Shared;
using QX.Common.C_Class.Utils;
using System.Data;

namespace QX.BLL
{
    public class Bll_Failure_Information
    {
        private ADOFailure_Information instance = new ADOFailure_Information();

        private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        private Bll_Audit auditInstance = new Bll_Audit();

        private ADOFailure_Relation frInstance = new ADOFailure_Relation();

        public bool InsertNewFailure(Failure_Information item)
        {
            bool flag = false;
            item.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
            var model = auditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString());
            if (model != null)
            {
                item.AuditCurAudit = model.VT_VerifyNode_Code;
            }
            if (instance.Add(item) > 0)
            {
                flag = true;
            }

            return flag;
        }

        public bool AddFailure(Failure_Information item)
        {
            bool flag = false;
            if (instance.Add(item) > 0)
            {
                flag = true;
            }

            return flag;
        }

        public int AddFailureWithReturn(Failure_Information item)
        {
            //bool flag = false;
            var obj = instance.AddWithReturn(item);
            return TypeConverter.ObjectToInt(obj);

        }

        public bool UpdateFailure(Failure_Information item)
        {
            bool flag = false;
            if (instance.Update(item) > 0)
            {
                flag = true;
            }

            return flag;
        }

        /// <summary>
        /// 获取待审核不合格品记录
        /// </summary>
        /// <returns></returns>
        public List<Failure_Information> GetAuditingFailureInforList()
        {
            string filter = auditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString(), SessionConfig.UserCode);
            string where = string.Format(" and AuditStat in ('Auditing','OnAudit') AND {0} ", filter);
            return instance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取历史记录
        /// </summary>
        /// <returns></returns>
        public List<Failure_Information> GetFailureInforList()
        {

            string where = string.Format(" ");
            return instance.GetListByWhere(where);
        }

        public List<Failure_Information> GetFailureInforList(string bDate, string eDate, string key)
        {

            string where = string.Format(" AND FInfo_CreateTime between '{0}' and '{1}' AND  (FInfo_ProdNo like '%{2}%' OR FInfo_PartNo like '%{2}%' OR FInfo_Code like '%{2}%' OR Finfo_CmdCode like '%{2}%' OR FInfo_PartNo like '%{2}%' OR  FInfo_Creator like '%{2}%' OR (select top 1 emp_code from bse_employee where emp_name ='{2}') like '%{2}%') ", bDate, eDate, key);
            return instance.GetListByWhere(where);
        }


        public DataTable GetFailureForExport(List<Failure_Information> list)
        {
            StringBuilder sbDetail = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append(" AND  FInfo_Code in (");
            foreach (var s in list)
            {
                if (!string.IsNullOrEmpty(s.FInfo_Code))
                {
                    sbDetail.AppendFormat("'{0}',", s.FInfo_Code);
                }
            }
            if (string.IsNullOrEmpty(sbDetail.ToString()))
            {
                sbDetail.Append("''");
            }
            sb.Append(sbDetail.ToString().TrimEnd(','));
            sb.Append(")");
            string where = string.Format(" {0}", sb.ToString());
            return instance.GetListByWhereExtend(where);
        }


        /// <summary>
        /// 生成不合格品单据编码
        /// </summary>
        /// <returns></returns>
        public string GenerateFailureInfor()
        {
            return new Bll_Comm().GenerateCode("Failure_Information");
        }

        public string GenearateFailureRelationCode()
        {
            return new Bll_Comm().GenerateCode("Failure_Relation");
        }


        /// <summary>
        /// '获取实体
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public Failure_Information GetModel(string condition)
        {
            List<Failure_Information> list = instance.GetListByWhere(condition);
            Failure_Information model = new Failure_Information();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }

        /// <summary>
        /// 设置不合格单据状态
        /// </summary>
        /// <param name="finfo"></param>
        public Prod_Roads CheckProdStat(Failure_Information finfo)
        {
            //bool flag = false;
            Prod_Roads pr = new Prod_Roads();
            string stat = finfo.FInfo_Stat;

            //如果检验合格，则更新库存状态和工序节点
            if (stat == QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Normal.ToString() || stat == "MoreUse")
            {

                finfo.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString();
                //更新单据状态
                var re1 = UpdateFailure(finfo);

                //库存
                var model = invInstance.GetInvByProdCode(finfo.FInfo_CmdCode, finfo.FInfo_ProdNo);
                model.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Normal.ToString();
                var re2 = invInstance.Update(model);

                //更新工序节点
                pr = prInstance.GetModel(string.Format(" AND PRoad_PlanCode='{0}' AND PRoad_NodeCode='{1}'", model.IInfor_PlanCode, finfo.FInfo_FindNode));
                if (pr != null)
                {
                    pr.PRoad_IsQuality = true;
                    var re3 = prInstance.Update(pr);
                }
            }

            //如果已终审并为能处理合格，则产品进入次品处理
            if (finfo.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString() && stat == QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Defective.ToString())
            {
                //库存
                var model = invInstance.GetInvByProdCode(finfo.FInfo_CmdCode, finfo.FInfo_ProdNo);
                model.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Defective.ToString();
                var re2 = invInstance.Update(model);

            }
            return pr;
        }

        public void ResetProdStat(Failure_Information finfo)
        {
            finfo.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
            var model = auditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString());
            if (model != null)
            {
                finfo.AuditCurAudit = model.VT_VerifyNode_Code;
            }

            var re1 = UpdateFailure(finfo);
        }
        #region 批量数据

        public bool StatChange(Failure_Relation current)
        {
            //记录其上一次状态记录编码
            string refcode = current.FR_Code;
            current.FR_Code = GenearateFailureRelationCode();
            current.FR_IsCurrent = 1;
            current.FR_RefCode = refcode;
            AddFR(current);

            Failure_Relation old = frInstance.GetByKey(current.FR_ID);
            old.FR_IsCurrent = 0;
            UpdateFR(old);

            return true;
        }


        public Failure_Relation GetFRModel(string where)
        {
            return frInstance.GetListByWhere(where).FirstOrDefault();
        }

        /// <summary>
        /// 获取不合格单据关联的零件编号
        /// </summary>
        /// <param name="finfocode">单据编号</param>
        /// <returns></returns>
        public List<Failure_Relation> GetRelation(string finfocode)
        {
            return frInstance.GetListByWhere(string.Format(" AND FR_FailureCode='{0}' AND isnull(FR_IsCurrent,0)=1", finfocode));
        }

        public void BatchProdStatChange(Failure_Information fi,string stat)
        {
            List<Sys_Map> mapsource = new BLL.Bll_Sys_Map().GetListByCode(string.Format("AND Map_module='ProdStatSource' AND Map_Source='NormalUse'"));
            var relations=GetRelation(fi.FInfo_Code);
            foreach (var d in relations)
            {
                d.FR_Stat = stat;
                //如果符合扭转为正常状态的
                if (mapsource.Exists(o => o.Map_Object1 == d.FR_Stat))
                {
                    //零件产品状态更改
                    Inv_Information inv = invInstance.GetInvByPlanCode(d.FR_PlanCode);
                    inv.IInfor_ProdStat = QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Normal.ToString();
                    invInstance.Update(inv);
                }

                UpdateFR(d);
            }


        }

        /// <summary>
        /// 更新产品状态
        /// </summary>
        /// <param name="list"></param>
        public void BatchProdStatChange(List<Failure_Relation> list)
        {
            List<Sys_Map> mapsource = new BLL.Bll_Sys_Map().GetListByCode(string.Format("AND Map_module='ProdStatSource'"));
            
            foreach (var d in list)
            {
                var map = mapsource.FirstOrDefault(o => o.Map_Object1 == d.FR_Stat);

                //如果符合扭转为正常状态的
                if (map!=null&&"1".Equals(map.Map_Object3))
                {
                    //零件产品状态更改
                    Inv_Information inv = invInstance.GetInvByPlanCode(d.FR_PlanCode);
                    inv.IInfor_ProdStat = QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Normal.ToString();
                    invInstance.Update(inv);
                }
                else
                {
                    if (map!=null||"0".Equals(map.Map_Object3))
                    {
                        //零件产品状态更改  报废
                        Inv_Information inv = invInstance.GetInvByPlanCode(d.FR_PlanCode);
                        inv.IInfor_ProdStat = QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Defective.ToString();
                        invInstance.Update(inv);
                    }
                    else
                    {
                        //零件产品状态更改
                        Inv_Information inv = invInstance.GetInvByPlanCode(d.FR_PlanCode);
                        inv.IInfor_ProdStat = QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
                        invInstance.Update(inv);
                    }
                }

                UpdateFR(d);
            }
        }

        public bool UpdateFR(Failure_Relation fr)
        {
            if (frInstance.Update(fr) > 0)
            {
                return true;
            }

            return false;
        }

        public bool AddFR(Failure_Relation fr)
        {
            if (frInstance.Add(fr) > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteFR(Failure_Relation fr)
        {
            fr.Stat = 1;
            if (frInstance.Update(fr) > 0)
            {
                return true;
            }

            return false;
        }

        #endregion
    }


}
