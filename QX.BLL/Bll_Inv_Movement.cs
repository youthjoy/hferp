
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
   [Serializable]
   public partial class Bll_Inv_Movement
   {
        private ADOInv_Movement instance = new ADOInv_Movement();

        private Bll_Audit auditInstance = new Bll_Audit(OperationTypeEnum.AuditTemplateEnum.ReturnDoc_R001);

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns>list</returns>
        public List<Inv_Movement> GetAll()
        {
            List<Inv_Movement> list = instance.GetAll();
            return list;
        }

       /// <summary>
       /// 生成编码
       /// </summary>
       /// <returns></returns>
        public string GenerateCommandCode()
        {
            return new Bll_Comm().GenerateCode("Inv_Movement");
        }
             
        /// <summary>
        /// 根据条件获取List
        /// </summary>
        /// <param name='strCondition'>条件(' AND Code='11'')</param>
        /// <returns>list</returns>
        public List<Inv_Movement> GetListByCode(string strCondition)
        {
            return instance.GetListByWhere(strCondition);
        }

        /// <summary>
        /// 获取用户创建未审核的单据
        /// </summary>
        /// <returns>list</returns>
        public List<Inv_Movement> GetListByCreateUser(string mv_Type, string userId)
        {
            return instance.GetListByWhere(string.Format(" AND MV_Type='{0}' AND MV_Creator = '{1}' AND AuditStat = '{2}'", 
                mv_Type, userId, OperationTypeEnum.AudtiOperaTypeEnum.Auditing));
        }

        /// <summary>
        /// 获取待用户审核的单据
        /// </summary>
        /// <returns>list</returns>
        public List<Inv_Movement> GetListByIssueUser(string mv_Type, string userId)
        {
            
            string strCondition = auditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.ReturnDoc_R001.ToString(), userId);

            List<Inv_Movement> list = new List<Inv_Movement>();
            if (!string.IsNullOrEmpty(strCondition))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(" AND AuditStat IN ('{0}','{1}') ", OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString(), OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString());
                sb.AppendFormat(" AND {0} ", strCondition);
                sb.AppendFormat(" AND MV_Type = '{0}'", mv_Type);
                string where = sb.ToString();

                list = instance.GetListByWhere(where);
            }

            return list;
        }

        /// <summary>
        /// 获取已终审的单据
        /// </summary>
        /// <returns>list</returns>
        public List<Inv_Movement> GetListByIssued(string mv_Type)
        {
            return instance.GetListByWhere(string.Format(" AND MV_Type='{0}' AND AuditStat='{1}' ", mv_Type, OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString()));
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Insert(Inv_Movement model)
        {
            bool result = false;
            try
            {
                model.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

                Verify_TemplateConfig vt = auditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.ReturnDoc_R001.ToString());

                if (vt != null)
                {
                    model.AuditCurAudit = vt.VT_VerifyNode_Code;
                }

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
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <param name='model'>是否完成验证</param>
        /// <returns>bool</returns>
        public bool Insert(Inv_Movement model,bool IsValid)
        { 
            bool result = false;
            if (IsValid)
            {
                //完成了验证，开始更新数据库了
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }               
            }
            return result;
        }        
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Inv_Movement GetModel(string strCondition)
        {
            List<Inv_Movement> list = instance.GetListByWhere(strCondition);
            Inv_Movement model = new Inv_Movement();
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
        /// 获取实体数据
        /// </summary>
        /// <param name='strCondition'>条件(AND Code='11')</param>
        /// <returns>model</returns>
        public Inv_Movement GetModel(int id)
        {
            Inv_Movement model = instance.GetByKey(id);          
            return model;
        }    

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Update(Inv_Movement model)
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
        /// 更新数据
        /// </summary>
        /// <param name='model'>实体</param>
        /// <returns>bool</returns>
        public bool Update(Inv_Movement model,bool IsValid)
        {
            
            bool result = false;
            if(IsValid){
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name='model'>model</param>
        /// <returns>bool</returns>
        public bool Delete(string Condition)
        {
            bool result = false;
            List<Inv_Movement> list = instance.GetListByWhere(Condition);
            if (list.Count > 0)
            {
                Inv_Movement model = list[0];
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
