using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.Common.C_Class;
using QX.DataModel;
using QX.DataAceess;
using System.Data;

namespace QX.BLL
{
    /// <summary>
    /// 判定当前用户在模块所处的审核状态
    /// </summary>
    public class Bll_Audit
    {


        /// <summary>
        /// <summary>
        /// 模板配置实例
        /// </summary>
        public ADOVerify_TemplateConfig AuditTemplateConfigInstance = new ADOVerify_TemplateConfig();
        /// <summary>
        /// 审核阶段配置实例 
        /// </summary>
        public ADOVerify_Nodes AuditNodesInstance = new ADOVerify_Nodes();
        /// <summary>
        /// 审核阶段用户实例
        /// </summary>
        public ADOVerify_Users AuditUserInstance = new ADOVerify_Users();
        /// <summary>
        /// 审核记录配置实例
        /// </summary>
        public ADOVerifyProcess_Records AuditProcessRecordsInstance = new ADOVerifyProcess_Records();
        /// 模板实例
        /// </summary>
        public ADOAudit_Template AuditTemplateInstance = new ADOAudit_Template();

        #region Old
        /// <summary>
        /// 模块类型
        /// </summary>
        private OperationTypeEnum.AuditTemplateEnum _templateKey;
        private string UserId = GlobalConfiguration.UserId;

        public Bll_Audit()
        {

        }


        public Bll_Audit(OperationTypeEnum.AuditTemplateEnum TemplateKey)
        {
            this._templateKey = TemplateKey;
        }



        public ADOBse_Audti instance = new ADOBse_Audti();

        /// <summary>
        /// 得到当前用户,当前模块所有的阶段
        /// </summary>
        public List<Audit_info> GetUserPorces()
        {
            List<Audit_info> list = new List<Audit_info>();
            //List<Audit_info> list = instance.GetAllPocess(GlobalConfiguration.UserId, _templateKey);
            return list;
        }

        /// <summary>
        /// 得到当前用户，当前模块所有阶段，并组合成查询字符串
        /// </summary>
        /// <returns></returns>
        public string GetUserPorcesForStrCondition()
        {
            string strCondition = "";
            List<Audit_info> list = GetUserPorces();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string str = i == list.Count - 1 ? "" : ",";
                    strCondition += "'" + list[i].VerifyNode_Code + "'" + str;
                }
            }
            return strCondition;
        }

        ///// <summary>
        ///// 当前阶段是否审核完成
        ///// </summary>
        ///// <returns></returns>
        //public bool CurrentProcessIsPass(string ProcessNode)
        //{
        //    bool result = false;
        //    //当前阶段需要审核的人数
        //    Verify_Nodes model = new BLL.Bll_Verify_Nodes().GetVerifyNodeByCode(ProcessNode);
        //    if (model == null)
        //    {
        //        return false;
        //    }
        //    Int32 ProcessNo = model.VerifyNode_AuditNum;
        //    //当前阶段审核的人数是否满足要求
        //    BLL.Bll_VerifyProcess_Records records = new Bll_VerifyProcess_Records();
        //    List<VerifyProcess_Records> recordslist = records.GetListBy(_templateKey,
        //        ProcessNode,
        //        OperationTypeEnum.AudtiRecordsDataTypeEnum.Audited);
        //    if (recordslist != null && recordslist.Count == ProcessNo)
        //    {
        //        result = true;
        //    }
        //    return result;
        //}


        /// <summary>
        /// 判断节点是不是终节点
        /// </summary>
        /// <param name="AuditTemplateType"></param>
        /// <param name="ProcessNode"></param>
        /// <param name="IsLast"></param>
        /// <returns></returns>
        //public Verify_Template CheckIsLastNode(string ProcessNode, ref bool IsLast)
        //{
        //    IsLast = false;
        //    Bll_Verify_Template TemplateInstance = new Bll_Verify_Template();
        //    List<Verify_Template> list = TemplateInstance.GetNodesForTemplateCode(_templateKey.ToString());
        //    Int32 LastNodeIndex = list.Count - 1;
        //    Int32 CurrentNodeIndex = 0;
        //    if (list != null && list.Count > 0)
        //    {
        //        CurrentNodeIndex = list.FindIndex(delegate(Verify_Template p) { return p.VerifyNode_Code == ProcessNode; });
        //    }
        //    if (CurrentNodeIndex == LastNodeIndex)
        //    {
        //        IsLast = true;
        //    }
        //    return list[CurrentNodeIndex];
        //}

        /// <summary>
        /// 取当前模块第一个审核节点
        /// </summary>
        /// <returns></returns>
        //public Verify_Template GetFirstNode()
        //{
        //    Verify_Template model = new Verify_Template();
        //    Bll_Verify_Template TemplateInstance = new Bll_Verify_Template();
        //    List<Verify_Template> list = TemplateInstance.GetNodesForTemplateCode(_templateKey.ToString());
        //    if (list != null && list.Count > 0)
        //    {
        //        model = list[0];
        //    }
        //    else
        //    {
        //        model = null;
        //    }
        //    return model;
        //}

        /// <summary>
        /// 审核成功后流转到下一个
        /// </summary>
        /// <returns></returns>
        public bool AuditPassNext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 审核驳回后流转到下一个
        /// </summary>
        /// <returns></returns>
        public bool AuditFailNext()
        {
            throw new NotImplementedException();
        }

        public OperationTypeEnum.AudtiOperaTypeEnum CheckOnAudit()
        {
            throw new NotImplementedException();
        }

        #endregion

        private ADO_Audit aInstance = new ADO_Audit();


        public string GenerateVRecordCode()
        {
            return new Bll_Comm().GenerateCode("VerifyProcess_Records");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleCode">审核模块编码</param>
        /// <param name="userId">用户名</param>
        /// <param name="keyCode">逻辑主键名称</param>
        /// <returns></returns>
        public string FilterWhere(string moduleCode, string userCode)
        {
            //string a = string.Format("");
            //string b = string.Format("");

            string filterWhere = aInstance.AuditFilterWhere(moduleCode, userCode);
            return filterWhere;
        }


        /// <summary>
        /// 返回模块审核记录信息
        /// </summary>
        /// <param name="VerfiyKey">模块关键字</param>
        /// <param name="TemplateCode">流程配置模板编码</param>
        /// <param name="DataCode">单据编码</param>
        /// <returns></returns>
        public List<VerifyProcess_Records> VerfiyProcessRecords(string VerfiyKey, string DataCode)
        {
            //IEnumerable<VerifyProcess_Records> result = AuditProcessRecordsInstance.GetAll()
            //    .Where(o => o.Module_Code == VerfiyKey.ToString() && o.Record_ID == DataCode);
            List<VerifyProcess_Records> result = AuditProcessRecordsInstance.GetListByWhere(string.Format(" AND Module_Code='{0}' AND Record_ID='{1}' order by Vrecord_Date desc",VerfiyKey,DataCode));
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ModuleCode">模块关键字</param>
        /// <param name="CurNodeCode">阶段编码</param>
        /// <param name="RecordCode">单据编码（对应表的逻辑主键编码）</param>
        /// <returns></returns>
        public string Audit(VerifyProcess_Records vpRecord)
        {
            string re = string.Empty;
            //添加审核记录  先置其Stat为1  如果该次审核生效则回置其Stat值
            vpRecord.Stat = 2;

            if (AuditProcessRecordsInstance.Add(vpRecord) > 0)
            {
                re = aInstance.Audit(vpRecord.VRecord_Code);
            }

            return re;
        }

        /// <summary>
        /// 获取模板第一个审核节点
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <returns></returns>
        public Verify_TemplateConfig GetVerifyTemplateNextNode(string moduleCode,string nodeCode)
        {
            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetListByWhere(string.Format(" AND VT_Key='{0}' Order by VT_VerifyNode_Order asc", moduleCode));
            var model = list.FirstOrDefault(o=>o.VT_VerifyNode_Code==nodeCode);
            if (model!=null)
            {
                
                var temp = list.Where(o => o.VT_VerifyNode_Order > model.VT_VerifyNode_Order).OrderBy(o => o.VT_VerifyNode_Order);
                return temp.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }


        public Verify_TemplateConfig GetVerifyTemplateNode(string moduleCode, string nodeCode)
        {
            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetListByWhere(string.Format(" AND VT_Key='{0}' Order by VT_VerifyNode_Order asc", moduleCode));
            var model = list.FirstOrDefault(o => o.VT_VerifyNode_Code == nodeCode);
            if (model != null)
            {

                return model;
            }
            else
            {
                return null;
            }
        }


        public List<Verify_Users> GetRelationUsers(string node)
        {
            string where = string.Format(" AND VU_VerifyNode_Code='{0}' AND VU_VerifyTempldate_Code is NULL",node);
            return AuditUserInstance.GetListByWhere(where);
        }

        public Verify_TemplateConfig GetVerifyTemplateRejectBack(string moduleCode, string nodeCode)
        {

            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetListByWhere(string.Format(" AND VT_Key='{0}' Order by VT_VerifyNode_Order asc", moduleCode));
            var model = list.FirstOrDefault(o => o.VT_VerifyNode_Code == nodeCode);
            return model;
        }

        public Audit_Template GetTemplateModel(string code)
        {
            return AuditTemplateInstance.GetListByWhere(string.Format(" AND Template_Key='{0}'",code)).FirstOrDefault();
        }

        public DataTable GetNextVerifyUser(string node,string curUser)
        {
            DataTable dt = new DataTable();
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("Node", node);
            dic.Add("User", curUser);
            dt = new Bll_Comm().GetDataTablebyProc("qx_sp_nextuser", dic);
            return dt;
        }

        /// <summary>
        /// 获取模板第一个审核节点
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <returns></returns>
        public Verify_TemplateConfig GetVerifyTemplateFirstNode(string moduleCode)
        {
            List<Verify_TemplateConfig> list = AuditTemplateConfigInstance.GetListByWhere(string.Format(" AND VT_Key='{0}' Order by VT_VerifyNode_Order asc", moduleCode));
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }


        public List<VerifyProcess_Records> GetVerfiyProcessRecords(string VerfiyKey, string RecordCode)
        {
            List<VerifyProcess_Records> list = AuditProcessRecordsInstance.GetListByWhereExtend(string.Format(" AND Module_Code='{0}' AND Record_ID='{1}' order by vrecord_date", VerfiyKey, RecordCode));
            return list;
        }


        public void InsertNextAuditRecord(string module, string node, string record)
        {
            try
            {
                VerifyProcess_Records r = new VerifyProcess_Records();
                r.Module_Code = module;
                r.Record_ID = record;
                r.VRecord_VCode = node;
                r.Stat = 2;
                AuditProcessRecordsInstance.Add(r);
            }
            catch { }
        }
    }
}
