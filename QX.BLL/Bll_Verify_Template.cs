using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAceess;

namespace QX.BLL
{
    public class Bll_Verify_Template
    {
        //private ADOVerify_Template Instance = new ADOVerify_Template();

        private ADOVerify_TemplateConfig Instance = new ADOVerify_TemplateConfig();

        private ADOAudit_Template atInstance = new ADOAudit_Template();

        #region 审核模板相关

        /// <summary>
        /// 获取审核模板列表
        /// </summary>
        /// <returns></returns>
        public List<Audit_Template> GetTemlateList()
        {
            //0 为模板树节点
            string where = string.Format(" ");

            return atInstance.GetListByWhere(where);
        }

   

        /// <summary>
        /// 根据编码获取对应模板信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Audit_Template GetTemplateByCode(string code)
        {
            string where = string.Format(" AND Template_Key='{0}'",code);
            
            List<Audit_Template> list = atInstance.GetListByWhere(where);
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
        /// 更新审核模板
        /// </summary>
        /// <param name="vt"></param>
        /// <returns></returns>
        public int UpdateTemplate(Audit_Template vt)
        {
            return atInstance.Update(vt);
        }

        #endregion
        /// <summary>
        /// 获取某模板对应配置阶段节点列表(按VT_NodeOrder 升序)
        /// </summary>
        /// <param name="code">模板编码</param>
        /// <returns></returns>
        public List<Verify_TemplateConfig> GetNodesForTemplateCode(string code)
        {
            //0 为模板树节点
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND VT_Key='{0}' ", code);
            sb.Append(" Order by VT_VerifyNode_Order ASC");
            //关联Verify_node表
            return Instance.GetListByWhere(sb.ToString());
        }

        /// <summary>
        /// 添加或更新工艺节点列表信息
        /// </summary>
        /// <param name="comptCode">零件图号</param>
        /// <param name="nodeDict">Key-工艺节点编码 value-order（顺序）</param>
        /// <returns></returns>
        public int AddOrUpdateConfig(Audit_Template curTemplate,Dictionary<string,Verify_TemplateConfig> list)
        {
            int flag = 1;
            try
            {

                List<Verify_TemplateConfig> oldTempList = this.GetNodesForTemplateCode(curTemplate.Template_Key);
                
                //获取该零件图号原来对应的工艺路线
     

                foreach (Verify_TemplateConfig vt in oldTempList)
                {
                    

                    //如果不存在则删除
                    if (!list.ContainsKey(vt.VT_VerifyNode_Code))
                    {
                        this.DeleteTempldateNode(vt);
                    }//如果存在则把其从模板阶段列表众移除,并更新其信息
                    else
                    {

                        var tmp = list[vt.VT_VerifyNode_Code];

                        tmp.VT_ID = vt.VT_ID;

                        UpdateTemplateConfig(tmp);

                        list.Remove(tmp.VT_VerifyNode_Code);
                    }

                }
                //添加
                foreach (KeyValuePair<string,Verify_TemplateConfig> kv in list)
                {
                    Verify_TemplateConfig config = kv.Value;
                    config.VT_Template_Code = GenerateConfigCode();
                    var re=AddTemplateNode(kv.Value);
                }

            
            }
            catch (Exception e)
            {
                flag = 0;
            }


            return flag;

        }

        public int UpdateTemplateConfig(Verify_TemplateConfig config)
        {
            return Instance.Update(config);
        }

        public string GenerateConfigCode()
        {
            return new Bll_Comm().GenerateCode("Verify_TemplateConfig");
        }

        public int AddTemplateNode(Verify_TemplateConfig node)
        {

            return Instance.Add(node);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int DeleteTempldateNode(Verify_TemplateConfig node)
        {
            node.Stat = 1;
            return Instance.Update(node);
        }

    }
}
