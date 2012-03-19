using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
    public class Bll_Road_Components
    {
        private DataAceess.ADORoad_Components _Instance;

        public DataAceess.ADORoad_Components Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QX.DataAceess.ADORoad_Components();
                    return _Instance;
                }
                return _Instance;
            }
        }
        private DataAceess.ADORoad_Nodes RnInstance;

        private DataAceess.ADORoad_TestRef RtInstance;

        private Bll_Audit auInstance;


        Bll_Audit AuditInstance = new Bll_Audit(OperationTypeEnum.AuditTemplateEnum.Components_C001);

        public Bll_Road_Components()
        {
            RnInstance = new ADORoad_Nodes();

            RtInstance = new ADORoad_TestRef();

            //auInstance = new Bll_Audit(OperationTypeEnum.AuditTemplateEnum.Components_C001);
            auInstance = new Bll_Audit();

            //RnInstance.idb.SetConnection(Instance.idb.GetConnection());
            //RtInstance.idb.SetConnection(Instance.idb.GetConnection());
            //auInstance.instance.idb.SetConnection(Instance.idb.GetConnection());
        }



        /// <summary>
        /// 获取所有零件图号
        /// </summary>
        /// <returns></returns>
        public List<Road_Components> GetAll()
        {
            return Instance.GetAll();
        }

        /// <summary>
        /// 获取与当前用户相关的零件图号(创建)
        /// </summary>
        /// <returns></returns>
        public List<Road_Components> GetComponentsByUser()
        {

            //string where = string.Format(" AND Comp_Creator='{0}' Order by Comp_ID desc", SessionConfig.UserCode);
            string where = string.Format("  Order by Comp_ID desc");

            return Instance.GetListByWhereWithUserData(where);
        }

    


        /// <summary>
        /// 获取待审核列表（待当前用户审核）
        /// </summary>
        /// <returns></returns>
        public List<Road_Components> GetComponentsForAuditingStat()
        {

            //string strCondition = AuditInstance.GetUserPorcesForStrCondition();
            string strCondition = AuditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), SessionConfig.UserCode);

            StringBuilder sb = new StringBuilder();
            List<Road_Components> re = new List<Road_Components>();
            //如果strCondition为空即表示没有待用户审核的列表
            if (!string.IsNullOrEmpty(strCondition))
            {
                sb.AppendFormat(" And AuditStat IN ('{0}','{1}') ", OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString(), OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString());
                sb.AppendFormat(" AND {0} ", strCondition);
                string where = sb.ToString();

                re = Instance.GetListByWhere(where);
            }
            return re;

        }

        /// <summary>
        /// 获取与当前用户相关的已审核列表
        /// </summary>
        /// <returns></returns>
        public List<Road_Components> GetComponentsForAudted()
        {

            Bll_Audit AuditInstance = new Bll_Audit(OperationTypeEnum.AuditTemplateEnum.Components_C001);
            //string strCondition = AuditInstance.GetUserPorcesForStrCondition();
            StringBuilder sb = new StringBuilder();
            //sb.AppendFormat(" AND Comp_Stat IN ('{0}','{1}','{2}') ",OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString(),OperationTypeEnum.AudtiOperaTypeEnum.OnAudit,OperationTypeEnum.AudtiOperaTypeEnum.LastAudit);

            sb.AppendFormat(" AND Module_Code='{0}'", OperationTypeEnum.AuditTemplateEnum.Components_C001);
            //sb.AppendFormat(" AND Comp_CurNode IN ({0})", strCondition);
            string where = sb.ToString();
            return Instance.GetListByWhereWithUserAudited(where);
        }

        /// <summary>
        /// 获取已通过终审的零件图号列表
        /// </summary>
        /// <returns></returns>
        public List<Road_Components> GetComponentsForLastAuditStat()
        {
            return this.GetComponentsByAuditStat(OperationTypeEnum.AudtiOperaTypeEnum.LastAudit);
        }

        public List<Road_Components> GetComponentsByAuditStat(OperationTypeEnum.AudtiOperaTypeEnum auditStat)
        {
            string where = string.Format(" AND AuditStat='{0}' Order by Comp_ID desc", auditStat.ToString());
            return Instance.GetListByWhereExtend(where);
        }

        public List<Road_Components> GetAllComponents()
        {
            string where = string.Format(" ");
            return Instance.GetListByWhereExtend(where);
        }

        public string GenerateComponentsCode()
        {
            return new Bll_Comm().GenerateCode("Road_Components");
        }

        /// <summary>
        /// 获取已废弃的零件图号
        /// </summary>
        /// <returns></returns>
        public List<Road_Components> GetComponentsForTrash()
        {
            string where = string.Format(" AND AuditStat='{0}'", OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString());

            return Instance.GetListByWhereExtend(where);
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        public decimal GetComponentTimeCost(string comptCode)
        {
            //设置零件图号
            string where = string.Format(" AND RNodes_PartCode='{0}'", comptCode);
            object obj = Instance.GetComponentsTimeCost(where);
            if (obj != null)
            {
                return Convert.ToDecimal(obj);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 判断当前零件图号是否可以编辑（是否在审核中）
        /// </summary>
        /// <param name="componetCode"></param>
        /// <returns></returns>
        public bool IsAllowEdit(string componetCode)
        {
            Road_Components comp = this.GetRoadComponentByCode(componetCode);
            if (comp.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString() || comp.AuditStat == OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 根据产品类别获取其下所有对应零件图号(已审核)
        /// </summary>
        /// <param name="roadCateList"></param>
        /// <returns></returns>
        public List<Road_Components> GetListByRoadCate(List<string> roadCateList)
        {
            StringBuilder sb = new StringBuilder();
            string whereSql = string.Empty;

            sb.AppendFormat(" AND AuditStat='{0}'", OperationTypeEnum.AudtiOperaTypeEnum.LastAudit);

            if (roadCateList.Count > 0)
            {
                sb.Append(" AND Comp_CatCode IN ( ");
                foreach (string r in roadCateList)
                {
                    sb.AppendFormat("'{0}'", r).Append(",");
                }

                whereSql = sb.ToString().TrimEnd(',') + " )";
            }
            //string whereSql = sb.ToString();

            return Instance.GetListByWhere(whereSql);
        }

        /// <summary>
        /// 添加和复制零件图号
        /// </summary>
        /// <param name="oldRoadComptCode"></param>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int AddAndCopycomponent(string oldRoadComptCode, Road_Components rc)
        {
            if (CopyComponent(oldRoadComptCode, rc))
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        /// <summary>
        /// 获取零件图号对应的工艺节点路线列表
        /// </summary>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        private List<Road_Nodes> GetRoadNodesByComponents(string comptCode)
        {
            StringBuilder sb = new StringBuilder();
            string whereSql = string.Format(" AND RNodes_PartCode='{0}'", comptCode);
            return RnInstance.GetListByWhere(whereSql);
        }

        /// <summary>
        /// 获取检测参数列表
        /// </summary>
        /// <param name="comptCode">零件图号</param>
        /// <param name="nodeCode">工艺路线节点编码</param>
        /// <returns></returns>
        private List<Road_TestRef> GetTestRefListByNodeCode(string comptCode, string nodeCode)
        {
            string where = string.Format("AND TestRef_PartNo='{0}'  AND TestRef_RNodeCode='{1}'", comptCode, nodeCode);

            return RtInstance.GetListByWhere(where);
        }

        /// <summary>
        /// 复制零件
        /// </summary>
        /// <param name="oldComptCode"></param>
        /// <param name="newCompt"></param>
        /// <returns></returns>
        public bool CopyComponent(string oldComptCode, Road_Components newCompt)
        {
            bool flag = false;

            try
            {

                //Instance.idb.BeginTransaction();
                //RnInstance.idb.BeginTransaction(Instance.idb.GetTransaction());
                //RtInstance.idb.BeginTransaction(Instance.idb.GetTransaction());
                //auInstance.instance.idb.BeginTransaction(Instance.idb.GetTransaction());

                //添加零件图号成功后才开始工艺路线和节点检测参数复制操作
                //设置节点进入第一个审核阶段
                //newCompt.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
                //newCompt.AuditCurAudit = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString()).VT_VerifyNode_Code;
                ////创建人
                //newCompt.Comp_Creator = SessionConfig.UserID;
                //newCompt.Comp_CreatTime = DateTime.Now;
                var model=GetRoadComponentByCode(newCompt.Comp_Code);
                //if (AddRoadComptForCopy(newCompt) > 0)
                if(model!=null)
                {
                    List<Road_Nodes> rnList = GetRoadNodesByComponents(oldComptCode);

                    foreach (Road_Nodes rn in rnList)
                    {
                        //工艺路线模板对应零件图号更改为新图号
                        //rn.RNodes_PartCode = newCompt.Comp_Code;
                        //rn.RNodes_PartName = newCompt.Comp_Name;

                        rn.RNodes_PartCode = model.Comp_Code;
                        rn.RNodes_PartName = model.Comp_Name;

                        //为该零件图号添加工艺路线节点
                        RnInstance.Add(rn);

                        //List<Road_TestRef> rtList = GetTestRefListByNodeCode(oldComptCode, rn.RNodes_Code);

                        //foreach (Road_TestRef rt in rtList)
                        //{
                        //    //工艺节点检测参数对应零件图号更改为新图号
                        //    rt.TestRef_PartNo = newCompt.Comp_Code;
                        //    rt.TestRef_PartName = newCompt.Comp_Name;
                        //    //为该零件图号和工艺节点添加检测参数
                        //    RtInstance.Add(rt);
                        //}
                    }
                }
                flag = true;
                //Instance.idb.CommitTransaction();

            }
            catch (Exception e)
            {
                flag = false;
                Instance.idb.RollbackTransaction();
            }


            return flag;
        }


        /// <summary>
        /// 根据Code获取对应实体
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Road_Components GetRoadComponentByCode(string code)
        {
            string where = string.Empty;
            where = string.Format(" AND Comp_Code='{0}'", code);
            List<Road_Components> list = Instance.GetListByWhere(where);
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
        /// 是否重复编码
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public bool IsRepeatCode(Road_Components rc)
        {
            Road_Components dic = this.GetRoadComponentByCode(rc.Comp_Code);
            if (dic != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int UpdateRoadCompt(Road_Components rc)
        {
            if (rc.AuditStat ==OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString())
            {
                var model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString());

                if (model != null)
                {
                    rc.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
                    rc.AuditCurAudit = model.VT_VerifyNode_Code;
                }
            }
            return Instance.Update(rc);
            //return 0;
        }

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int AddRoadCompt(Road_Components rc)
        {


            rc.Stat = 0;
            //创建人
            rc.Comp_Creator = SessionConfig.UserCode;

            rc.Comp_CreatTime = DateTime.Now;

            //状态设置
            rc.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

            Verify_TemplateConfig model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString());

            if (model != null)
            {
                rc.AuditCurAudit = model.VT_VerifyNode_Code;

                auInstance.InsertNextAuditRecord(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString(), model.VT_VerifyNode_Code, rc.Comp_Code);
            }

            return Instance.Add(rc);

            //return 0;
        }

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int AddRoadComptForCopy(Road_Components rc)
        {

            rc.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
            
            Verify_TemplateConfig model = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.Components_C001.ToString());

            if (model != null)
            {
                rc.AuditCurAudit = model.VT_VerifyNode_Code;
            }
            rc.Stat = 0;

            rc.Comp_Creator = SessionConfig.UserCode;

            rc.Comp_CreatTime = DateTime.Now;

            return Instance.Add(rc);

            //return 0;
        }


        /// <summary>
        /// 逻辑删除对应实体(慎用)
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int DeleteCompt(Road_Components rc)
        {

            //零件图号关联-->1、合同  2、库存  3、工艺路线模板和检测参数 4、生产

            int flag = 1;

            try
            {

                Instance.idb.BeginTransaction();
                RnInstance.idb.BeginTransaction(Instance.idb.GetTransaction());
                RtInstance.idb.BeginTransaction(Instance.idb.GetTransaction());

                rc.Stat = 1;

                Instance.Update(rc);
                //逻辑删除其对应的工艺节点及检测参数
                List<Road_Nodes> rnList = GetRoadNodesByComponents(rc.Comp_Code);
                foreach (Road_Nodes rn in rnList)
                {
                    rn.Stat = 1;

                    RnInstance.Update(rn);

                    List<Road_TestRef> rtList = GetTestRefListByNodeCode(rc.Comp_Code, rn.RNodes_Code);
                    foreach (Road_TestRef rt in rtList)
                    {
                        rt.Stat = 1;
                        RtInstance.Update(rt);
                    }
                }

                Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                flag = 0;
                Instance.idb.RollbackTransaction();
            }
            return flag;
        }


        public int RemoveCompt(Road_Components rc)
        {
            rc.Stat = 1;
            return Instance.Update(rc);
            //return this.DeleteCompt(rc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyList">Key -   value 零件图号编码</param>
        /// <returns>1 成功批量删除  否则返回未能删除的ID</returns>
        public string RemoveCompts(Dictionary<int, string> keyList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, string> k in keyList)
            {
                Road_Components tmpRc = this.GetRoadComponentByCode(k.Value);
                int re = RemoveCompt(tmpRc);
                if (re <= 0)
                {   //如果删除失败则记录对应的零件图号编码
                    sb.AppendLine(tmpRc.Comp_Code + ":" + tmpRc.Comp_Name);
                }

            }

            string result = sb.ToString();

            if (string.IsNullOrEmpty(result))
            {
                result = "1";
            }
            return result;
        }
    }
}
