using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
    public class Bll_Prod_PlanProd
    {

        private Bll_ProdTask ptInstance;

        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        private DataAceess.ADOProd_PlanProd Instance;

        private Bll_Prod_Roads prInstance;

        private Bll_Inv_Information invInstance;

        private ADOProd_Patch ppaInstance = new ADOProd_Patch();

        private ADOSD_CRProdCode crInstance = new ADOSD_CRProdCode();
        public Bll_Prod_PlanProd()
        {
            Instance = new ADOProd_PlanProd();

            prInstance = new Bll_Prod_Roads();
            ptInstance = new Bll_ProdTask();
            invInstance = new Bll_Inv_Information();

            ptInstance.Instance.idb.SetConnection(Instance.idb.GetConnection());
            prInstance.Instance.idb.SetConnection(Instance.idb.GetConnection());
            invInstance.Instance.idb.SetConnection(Instance.idb.GetConnection());
        }

        /// <summary>
        /// 获取待计划任务列表
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetPlanTaskList()
        {
            return ptInstance.GetProdTaskByStat(OperationTypeEnum.ProdTaskStatEnum.Deploying.ToString());

        }

        /// <summary>
        /// 获取已计划任务列表
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetPlanedTaskList()
        {
            return ptInstance.GetProdTaskByStat(OperationTypeEnum.ProdTaskStatEnum.Planing.ToString());

        }

        /// <summary>
        /// 获取已计划任务列表
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Prod_Task> GetPlanedTaskListWithFitler(string filter)
        {
            string where = string.Format(" {0}", filter);
            return ptInstance.GetProdTaskByStat(OperationTypeEnum.ProdTaskStatEnum.Planing.ToString(), where);


        }

        /// <summary>
        /// 获取已完成任务列表
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetFinishTaskList()
        {
            return ptInstance.GetFinProdTask();
            //return ptInstance.GetProdTaskByStat(OperationTypeEnum.ProdTaskStatEnum.Planing.ToString());

        }

        /// <summary>
        /// 根据任务编码获取计划列表
        /// </summary>
        /// <param name="taskCode"></param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetPlanProdList(string taskCode)
        {
            string where = string.Format(" AND PlanProd_TaskCode='{0}' order by PlanProd_Code", taskCode);

            return Instance.GetListByWherePatch(where);
        }

        public List<Prod_PlanProd> GetPlanProdListForContract(string condit)
        {
            string where = string.Format(" {0} order by PlanProd_Code", condit);

            return Instance.GetListByWhereForContract(where);
        }

        

        public List<Prod_PlanProd> GetPlanProdListForSearch(string key)
        {
            string where = string.Format(" AND (PlanProd_CmdCode like '%{0}%' OR PlanProd_Code like '%{0}%' OR PlanProd_PartName like '%{0}%' OR PlanProd_PartNo like '%{0}%')",key);
            return Instance.GetListByWherePatch(where);
        }

        public List<Prod_PlanProd> GetPlanProdListForSearch(string bDate,string eDate,string key)
        {
            string where = string.Format(" AND Task_Date between '{1}' and '{2}' AND (PlanProd_CmdCode like '%{0}%' OR PlanProd_Code like '%{0}%' OR PlanProd_PartName like '%{0}%' OR PlanProd_PartNo like '%{0}%')", key,bDate,eDate);
            return Instance.GetListByWherePatch(where);
        }

        /// <summary>
        /// 根据条件获取零件编号
        /// </summary>
        /// <param name="bDate"></param>
        /// <param name="eDate"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetPlanList(string bDate, string eDate, string key)
        {
            string where = string.Format(" AND PlanProd_Date between '{1}' and '{2}' AND (PlanProd_CmdCode like '%{0}%' OR PlanProd_Code like '%{0}%' OR PlanProd_PartName like '%{0}%' OR PlanProd_PartNo like '%{0}%')", key, bDate, eDate);
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取合同细目关联的零件
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetTracePlanList(string key)
        {
            string where = string.Format("AND SDR_DetailCode ='{0}'", key);

            List<SD_CRProdCode> list= crInstance.GetListByWhere(where);

            List<Prod_PlanProd> list1 = new List<Prod_PlanProd>();

            foreach (var p in list)
            {
                Prod_PlanProd p1 = new Prod_PlanProd();
                p1.PlanProd_Code = p.SDR_ProdCode;
                p1.PlanProd_PlanCode = p.SDR_PlanCode;
                p1.PlanProd_CmdCode = p.SDR_CmdCode;
                p1.PlanProd_PartNo = p.SDR_PartNo;
                p1.PlanProd_PartName = p.SDR_PartName;
                list1.Add(p1);
            }

            return list1;
        }

        /// <summary>
        /// 根据任务编码获取计划列表(过滤已配对的)
        /// </summary>
        /// <param name="taskCode"></param>
        /// <returns></returns>
        //public List<Prod_Patch> GetPlanProdListFilterPatch(string taskCode)
        //{
        //    string where = string.Format(" AND PP_PlanCode='{0}'  order by PlanProd_Code", taskCode);

        //    return ppaInstance.GetListByWhere(where);
        //}

        /// <summary>
        /// 获取组合配对的产品列表
        /// </summary>
        /// <returns></returns>
        public List<Prod_Patch> GetPlanProdListForPatch(string code)
        {

            string where = string.Format(" AND PP_PlanCode='{0}' ", code);

            return ppaInstance.GetListByWhere(where);

            //string where = string.Format(" AND PlanProd_Code!='{0}'  AND IInfor_Stat<>'Outing' order by PlanProd_ID",code);

            //return Instance.GetListByWherePatch(where);
        }

        public string GenerateProdPatchCode()
        {
            return new BLL.Bll_Comm().GenerateCode("Prod_Patch");
        }


        /// <summary>
        /// 组合配对
        /// </summary>
        /// <param name="module"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddOrUpdateProdPath(string module, List<Prod_Patch> list)
        {
            int count = list.Count;
            List<Prod_Patch> oldList = GetPlanProdListForPatchByModule(module);
            var mainProd=list.FirstOrDefault(o=>o.PP_Type=="PatchType002");
            foreach (var n in oldList)
            {
                var temp = list.FirstOrDefault(o => o.PP_ID == n.PP_ID);

                if (temp != null)
                {
                    temp.PP_ID = n.PP_ID;
                    ppaInstance.Update(temp);
                    list.Remove(temp);
                }
                else
                {
                    n.Stat = 1;
                
                    ppaInstance.Update(n);

                    Prod_PlanProd p = GetModelByKey(n.PP_PlanCode);
                    p.PlanProd_Patch = string.Empty;
                    p.PlanProd_MPatchCode = string.Empty;
                    UpdatePlan(p);
                }
            }

            foreach (var t in list)
            {
                t.PP_Module = module;
                ppaInstance.Add(t);


                Prod_PlanProd p = GetModelByKey(t.PP_PlanCode);
                p.PlanProd_Patch = module;
                //住零件编号
                if (mainProd != null)
                {
                    p.PlanProd_MPatchCode = mainProd.PP_PlanCode;
                    //p.PlanProd_MPatchCode = mainProd.PP_PlanCode;
                }
                UpdatePlan(p);

            }

            //如果只剩一个 表示取消配对信息
            if (count == 1)
            {

                Prod_Patch n = mainProd;
                n.Stat = 1;

                UpdatePatch(n);

                Prod_PlanProd p = GetModelByKey(n.PP_PlanCode);
                p.PlanProd_Patch = string.Empty;
                p.PlanProd_MPatchCode = string.Empty;
                UpdatePlan(p);
            }

            return true;
        }

        public bool UpdatePatch(Prod_Patch p)
        {
            if (ppaInstance.Update(p)>0)
            {
                return true;
            }

            return false;
        }

        public List<Prod_Patch> GetPlanProdListForPatchByModule(string modulecode)
        {

            string where = string.Format(" AND PP_Module='{0}'", modulecode);

            return ppaInstance.GetListByWhere(where);

            //string where = string.Format(" AND PlanProd_Code!='{0}'  AND IInfor_Stat<>'Outing' order by PlanProd_ID",code);

            //return Instance.GetListByWherePatch(where);
        }

        /// <summary>
        /// 作废零件
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        public bool TrashProd(Prod_PlanProd plan)
        {
            var inv=invInstance.GetInvByPlanCode(plan.PlanProd_PlanCode);
            inv.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Defective.ToString();
            inv.IInfor_CustBak = SessionConfig.EmpName + "手动作废  " + DateTime.Now.ToString();
            plan.PlanProd_Bak = SessionConfig.EmpName + "手动作废  "+ DateTime.Now.ToString();

            Instance.Update(plan);

            return invInstance.Update(inv);
        }

        public bool UpdatePatch(string code,List<Prod_PlanProd> list)
        {
            List<Prod_PlanProd> oldlist = GetPatchList(code);
            foreach (var d in oldlist)
            {
                var temp = list.FirstOrDefault(o => o.PlanProd_Code == d.PlanProd_Code);
                //如果不存在则去除该配对
                if (temp == null)
                {
                    d.PlanProd_Patch = "";
                    UpdatePlan(d);
                }
                else
                {
                    list.Remove(temp);
                }
            }

            foreach (var d in list)
            {
                d.PlanProd_Patch = code;
                UpdatePlan(d);
            }

            return true;
        }

        /// <summary>
        /// 获取配对零件列表
        /// </summary>
        /// <param name="code">配对零件对应记录编码</param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetPatchList(string code)
        {

            string where = string.Format(" AND isnull(PlanProd_Patch,'')='{0}'  order by PlanProd_Code",code);

            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取所有零件
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetPatchListByTask()
        {

            string where = string.Format("   order by PlanProd_Code");

            return Instance.GetListByWhereForPatch(where);
        }

        public bool UpdatePlan(Prod_PlanProd plan)
        {
            if (Instance.Update(plan) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 根据任务编码获取已完成计划列表(过滤已配对的零件)
        /// </summary>
        /// <param name="taskCode"></param>
        /// <returns></returns>
        public List<Prod_PlanProd> GetFinPlanProdList(string taskCode)
        {
            string where = string.Format(" AND PlanProd_TaskCode='{0}' AND ( isnull(PlanProd_Patch,'')!='' OR isnull(PlanProd_FStat,'Planing')='{1}')", taskCode, OperationTypeEnum.ProdPlanStatEnum.Finish.ToString());

            return Instance.GetListByWhereExtend(where);
        }

        /// <summary>
        /// 根据计划编码获取是实体
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Prod_PlanProd GetModelByKey(string code)
        {
            string where = string.Empty;
            where = string.Format(" AND PlanProd_PlanCode='{0}'", code);
            List<Prod_PlanProd> list = Instance.GetListByWhere(where);
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
        /// 根据产品编码获取实体
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Prod_PlanProd GetModelByProdCode(string pcode)
        {
            string where = string.Empty;
            where = string.Format(" AND PlanProd_Code='{0}'", pcode);
            List<Prod_PlanProd> list = Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }


        public Prod_PlanProd GetProdModel(string where)
        {
            List<Prod_PlanProd> list = Instance.GetListByWhere(where);
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
        /// 是否有重复产品编码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsRepeatProdCode(string code)
        {
            Prod_PlanProd pp = GetPlanProdByProdCode(code);
            if (pp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 根据产品编码（零件编码）获取生产计划内容
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private Prod_PlanProd GetPlanProdByProdCode(string code)
        {
            string where = string.Empty;
            where = string.Format(" AND PlanProd_Code='{0}' AND PlanProd_FStat='Planing'", code);
            List<Prod_PlanProd> list = Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }


        public List<Prod_PlanProd> DeployPlanWithNoSubmit(Prod_Task prodTask, int DeployNum)
        {
            List<Prod_PlanProd> planList = new List<Prod_PlanProd>();
            for (int i = 0; i < DeployNum; i++)
            {
                //生产计划
                Prod_PlanProd prodPlan = new Prod_PlanProd();
                //prodPlan.PlanProd_Code = invInstance.CreateInvCode();
                //prodPlan.PlanProd_PlanCode = CreateProdPlanCode();

                //任务编码
                prodPlan.PlanProd_TaskCode = prodTask.Task_Code;
                //生产命令编码
                prodPlan.PlanProd_CmdCode = prodTask.TaskDetail_CmdCode;
                //零件图号
                prodPlan.PlanProd_PartNo = prodTask.TaskDetail_PartNo;
                //零件名称
                prodPlan.PlanProd_PartName = prodTask.TaskDetail_PartName;
                //数量
                prodPlan.PlanProd_Num = 1;
                prodPlan.PlanProd_Begin = prodTask.TaskDetail_PlanBegin;
                prodPlan.PlanProd_End = prodTask.TaskDetail_PlanEnd;
                //编制人 完工数量  长票编号 确认人 等未赋值
                prodPlan.PlanProd_FStat = OperationTypeEnum.ProdPlanStatEnum.Planing.ToString();
                planList.Add(prodPlan);
            }

            return planList;
        }

        public Prod_PlanProd CreateProdPlanWithNoPersist(Prod_Task prodTask)
        {
            //生产计划
            Prod_PlanProd prodPlan = new Prod_PlanProd();
            //prodPlan.PlanProd_Code = invInstance.CreateInvCode();
            //prodPlan.PlanProd_PlanCode = CreateProdPlanCode();

            //任务编码
            prodPlan.PlanProd_TaskCode = prodTask.Task_Code;
            //生产命令编码
            prodPlan.PlanProd_CmdCode = prodTask.TaskDetail_CmdCode;
            //零件图号
            prodPlan.PlanProd_PartNo = prodTask.TaskDetail_PartNo;
            //零件名称
            prodPlan.PlanProd_PartName = prodTask.TaskDetail_PartName;
            //数量
            prodPlan.PlanProd_Num = 1;
            prodPlan.PlanProd_Begin = prodTask.TaskDetail_PlanBegin;
            prodPlan.PlanProd_End = prodTask.TaskDetail_PlanEnd;
            //编制人 完工数量  长票编号 确认人 等未赋值

            return prodPlan;
        }

        /// <summary>
        /// 下发生产计划
        /// </summary>
        /// <param name="prodTask"></param>
        /// <param name="ppList"></param>
        /// <returns></returns>
        public bool DeployPlanAndRoadNodes(Prod_Task prodTask, List<Prod_PlanProd> ppList)
        {
            bool flag = true;
            //工艺路线模板列表
            List<Road_Nodes> nodeList = rnInstance.GetRoadNodesByComponents(prodTask.TaskDetail_PartNo);

            try
            {
                Instance.idb.BeginTransaction();
                ptInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());
                invInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());
                prInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());


                
                int oldNum = prodTask.Task_DNum;
                //如果下发完了则到已计划列表中区
                if (prodTask.TaskDetail_Num <= prodTask.Task_DNum)
                {
                    prodTask.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Planing.ToString();
                }
                else
                {
                    prodTask.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Deploying.ToString();
                }
                //下达的计划数量
                //prodTask.Task_DNum = oldNum+ppList.Count;

                ptInstance.Update(prodTask);

                foreach (Prod_PlanProd pp in ppList)
                {

                    //生产计划编码
                    pp.PlanProd_PlanCode = CreateProdPlanCode();

                    pp.PlanProd_Owner = SessionConfig.UserCode;
                    pp.PlanProd_Date = DateTime.Now;
                    //状态
                    pp.PlanProd_FStat = OperationTypeEnum.ProdPlanStatEnum.Planing.ToString();
                    Instance.Add(pp);
                    //添加库存信息
                    invInstance.AddInventoryInfor(pp, nodeList);
                    //工艺路线导入
                    prInstance.ImportPlanRoads(pp, nodeList);

                }

                Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                flag = false;
                Instance.idb.RollbackTransaction();
            }
            return flag;
        }




        /// <summary>
        ///  下发计划    需修改
        /// </summary>
        /// <param name="prodTask">待计划任务</param>
        /// <returns></returns>
        public int DeployPlan(Prod_Task prodTask)
        {
            //设置任务状态--Planing
            //生成计划列表
            //写入库存
            //导入对应工序

            int flag = 1;

            try
            {
                //下达任务数量
                int compCount = prodTask.Task_DNum;
                List<Road_Nodes> nodeList = rnInstance.GetRoadNodesByComponents(prodTask.TaskDetail_PartNo);


                Instance.idb.BeginTransaction();
                ptInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());
                prInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());
                invInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());

                prodTask.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Planing.ToString();
                ptInstance.Update(prodTask);

                for (int i = 0; i < compCount; i++)
                {
                    //生产计划
                    Prod_PlanProd prodPlan = new Prod_PlanProd();
                    //产品编码
                    prodPlan.PlanProd_Code = invInstance.CreateInvCode();
                    prodPlan.PlanProd_PlanCode = CreateProdPlanCode();
                    prodPlan.PlanProd_TaskCode = prodTask.Task_Code;
                    prodPlan.PlanProd_CmdCode = prodTask.TaskDetail_CmdCode;
                    prodPlan.PlanProd_PartNo = prodTask.TaskDetail_PartNo;
                    prodPlan.PlanProd_PartName = prodTask.TaskDetail_PartName;
                    prodPlan.PlanProd_Num = 1;
                    prodPlan.PlanProd_Begin = prodTask.TaskDetail_PlanBegin;
                    prodPlan.PlanProd_End = prodTask.TaskDetail_PlanEnd;
                    //编制人 完工数量  长票编号 确认人 等未赋值
                    prodPlan.PlanProd_FStat = OperationTypeEnum.ProdPlanStatEnum.Planing.ToString();

                    //添加生产计划
                    Instance.Add(prodPlan);
                    //添加库存信息
                    invInstance.AddInventoryInfor(prodPlan, nodeList);
                    //工艺路线导入
                    prInstance.ImportPlanRoads(prodPlan, nodeList);



                }

                Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                Instance.idb.RollbackTransaction();
            }

            return flag;
        }

        /// <summary>
        /// 生成计划编号
        /// </summary>
        /// <returns></returns>
        public string CreateProdPlanCode()
        {
            return new Bll_Comm().GenerateCode("Prod_PlanProd");
        }

        public List<Prod_PlanProd> GetTrashList(string bdate, string edate, string key)
        {
            List<Prod_PlanProd> list = new List<Prod_PlanProd>();
            var where=string.Format(" ");
            list=Instance.GetListByWhere(where);
            return list;
        }
    }
}
