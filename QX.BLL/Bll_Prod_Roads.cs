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
    public class Bll_Prod_Roads
    {
        public DataAceess.ADOProd_Roads Instance = new ADOProd_Roads();
        private Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();
        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();



        private Bll_Inv_Information invInstance = new Bll_Inv_Information();
        #region old

        /// <summary>
        /// 根据计划编码获取工序节点列表（升序 ASC）
        /// </summary>
        /// <param name="planCode"></param>
        /// <returns></returns>
        public List<Prod_Roads> GetPlanRoadList(string planCode)
        {
            string where = string.Format(" AND PRoad_PlanCode='{0}' Order by PRoad_Order asc", planCode);
            return Instance.GetListByWhere(where);
        }


        /// <summary>
        /// 根据计划编码获取工序节点列表（升序 ASC）
        /// </summary>
        /// <param name="planCode"></param>
        /// <returns></returns>
        public List<Prod_Roads> GetPlanRoadListByProdCode(string prodCode)
        {
            string where = string.Format(" AND PRoad_ProdCode='{0}' Order by PRoad_Order asc", prodCode);
            return Instance.GetListByWhere(where);
        }


        public List<Prod_Roads> GetPlanRoadListByPlanCode(string plancode)
        {
            string where = string.Format(" AND PRoad_PlanCode='{0}' Order by PRoad_Order asc", plancode);
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 根据零件图号获取工艺路线模板--》Proad  不推荐使用
        /// </summary>
        /// <param name="compCode"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
        [Obsolete]
        public List<Prod_Roads> GetTemplateProdRoadsByComptCode(string compCode, DateTime startDate)
        {
            List<Road_Nodes> rnList = rnInstance.GetRoadNodesByComponents(compCode);
            List<Prod_Roads> prList = new List<Prod_Roads>();


            DateTime tmpDate = startDate;

            foreach (var rn in rnList)
            {
                Prod_Roads pr = new Prod_Roads();
                //工艺节点工时
                decimal timeCost = rn.RNodes_TimeCost;

                pr.PRoad_NodeCode = rn.RNodes_Code;
                pr.PRoad_NodeName = rn.RNodes_Name;
                pr.PRoad_NodeDepCode = rn.RNodes_Dept_Code;
                pr.PRoad_NodeDepName = rn.RNodes_Dept_Name;
                pr.PRoad_Order = rn.RNodes_Order;
                pr.PRoad_TimeCost = rn.RNodes_TimeCost;
                pr.PRoad_Date = DateTime.Now;

                //设备负荷时长
                pr.PRoad_EquCode = rn.RNodes_EquCode;
                pr.PRoad_EquName = rn.RNodes_EquName;
                pr.PRoad_EquTimeCost = (int)rn.RNodes_EquTime;
                int equTimeCost =(int) pr.PRoad_EquTimeCost;

                //时间安排（自动调整 开始时间）
                pr.PRoad_Begin = tmpDate;

                //前置条件  上一工序完成后的时间是否可以直接递推（另起一天）

                //工序工时超过设备负荷时间-->时间递推条件以设备能完成的时间为主
                if (timeCost > equTimeCost)
                {
                    double days = (Convert.ToDouble(timeCost) % Convert.ToDouble(equTimeCost));
                    double hours = (Convert.ToDouble(timeCost) / Convert.ToDouble(equTimeCost));
                    tmpDate = tmpDate.AddDays(days + hours);

                }//工序工时所需设备满足负荷时间-->时间递推条件以工时为主
                else if (timeCost > 8)
                {
                    tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
                }

                pr.PRoad_End = tmpDate;


                prList.Add(pr);
            }

            return prList;
        }

        /// <summary>
        /// 批量更新生产计划相关工艺路线
        /// </summary>
        /// <param name="planList"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool BatchUpdateProdRoads(List<Prod_PlanProd> planList, List<Prod_Roads> list)
        {
            bool flag = true;
            try
            {
                Prod_Roads firstNode = list.OrderBy(o => o.PRoad_Order).FirstOrDefault();
                foreach (Prod_PlanProd plan in planList)
                {
                    //先清空原生产计划工艺节点路线
                    DeletePRoadsByPlanCode(plan.PlanProd_PlanCode);

                    foreach (Prod_Roads pr in list)
                    {
                        //生产计划编码
                        pr.PRoad_PlanCode = plan.PlanProd_PlanCode;
                        // 产品编码
                        pr.PRoad_ProdCode = plan.PlanProd_Code;
                        //零件图号
                        pr.PRoad_CompCode = plan.PlanProd_PartNo;
                        //编制时间
                        pr.PRoad_Date = DateTime.Now;

                        this.Insert(pr);


                    }


                    if (firstNode != null)
                    {
                        var invModel = invInstance.GetInvByPlanCode(plan.PlanProd_PlanCode);
                        invModel.IInfor_Stat = firstNode.PRoad_NodeCode;
                        invInstance.Update(invModel);

                    }
                }

            }
            catch (Exception e)
            {
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 删除对应生产计划对应工艺路线
        /// </summary>
        /// <param name="planCode"></param>
        public void DeletePRoadsByPlanCode(string planCode)
        {
            List<Prod_Roads> list = this.GetPlanRoadList(planCode);
            foreach (Prod_Roads pr in list)
            {
                this.Delete(pr);
            }
        }



        public bool IsNeedFHelper(string deptCode)
        {
            //如果选了经营处，则表示该节点需要外协，则该节点进入外协处理流程
            if (deptCode == GlobalConfiguration.MarketDept)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pr"></param>
        /// <param name="type">0 表示正常 1表示需要外协处理</param>
        /// <returns></returns>
        public bool UpdateDept(Prod_Roads pr, int type)
        {


            bool flag = true;
            try
            {
                //Instance.idb.BeginTransaction();
                //infoInstance.instance.idb.BeginTransaction(Instance.idb.GetTransaction());
                //pInstance.instance.idb.BeginTransaction(Instance.idb.GetTransaction());
                switch (type)
                {
                    case 0:
                        Instance.Update(pr);
                        break;
                    case 1:

                        //更新部门信息
                        var re1 = Instance.Update(pr);
                        break;
                }

                //Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                //Instance.idb.RollbackTransaction();
            }
            return flag;


        }



        /// <summary>
        /// 工序节点导入
        /// </summary>
        /// <param name="pp"></param>
        /// <param name="rnList"></param>
        /// <returns></returns>
        public int ImportPlanRoads(Prod_PlanProd pp, List<Road_Nodes> rnList)
        {
            //第一个节点从当天8点开始计算
            DateTime planBegin = pp.PlanProd_Begin.AddHours(8);
            DateTime planEnd = pp.PlanProd_End;
            DateTime tmpDate = pp.PlanProd_Begin;
            for (int i = 0; i < rnList.Count; i++)
            {
                Road_Nodes rn = rnList[i];
                Prod_Roads pr = new Prod_Roads();
                if (i == 0)
                {
                    pr.PRoad_IsCurrent = 1;
                    pr.PRoad_ActRTime = DateTime.Now;
                }
                //工艺节点工时
                decimal timeCost = rn.RNodes_TimeCost;

                pr.PRoad_PlanCode = pp.PlanProd_PlanCode;
                pr.PRoad_ProdCode = pp.PlanProd_Code;
                //零件图号
                pr.PRoad_CompCode = pp.PlanProd_PartNo;
                pr.PRoad_NodeCode = rn.RNodes_Code;
                pr.PRoad_NodeName = rn.RNodes_Name;
                pr.PRoad_NodeDepCode = rn.RNodes_Dept_Code;
                pr.PRoad_NodeDepName = rn.RNodes_Dept_Name;
                pr.PRoad_Order = rn.RNodes_Order;
                pr.PRoad_TimeCost = rn.RNodes_TimeCost;
                pr.PRoad_Date = DateTime.Now;

                //设备负荷时长
                pr.PRoad_EquCode = rn.RNodes_EquCode;
                pr.PRoad_EquName = rn.RNodes_EquName;
                pr.PRoad_EquTimeCost = (int)rn.RNodes_EquTime;
                int equTimeCost = pr.PRoad_EquTimeCost;

                //时间安排（自动调整 开始时间）
                pr.PRoad_Begin = tmpDate;

                //前置条件  上一工序完成后的时间是否可以直接递推（另起一天）

                //工序工时超过设备负荷时间-->时间递推条件以设备能完成的时间为主
                if (timeCost > equTimeCost)
                {
                    if (equTimeCost == 0)
                    {
                        equTimeCost = 1;
                    }
                    double days = (Convert.ToDouble(timeCost) % Convert.ToDouble(equTimeCost));
                    double hours = (Convert.ToDouble(timeCost) / Convert.ToDouble(equTimeCost));
                    tmpDate = tmpDate.AddDays(days + hours);

                }//工序工时所需设备满足负荷时间-->时间递推条件以工时为主
                else if (timeCost > 8)
                {
                    tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
                }

                pr.PRoad_End = tmpDate;

                Instance.Add(pr);
            }
            return 1;
        }


        //public Prod_Roads GetNextNode(Prod_Roads pr)
        //{
        //    List<Prod_Roads> list = GetPlanRoadList(pr.PRoad_PlanCode);

        //    var temp = list.Where(o => o.PRoad_Order > pr.PRoad_Order).OrderBy(o=>o.PRoad_Order).FirstOrDefault();

        //    return temp;
        //}

        /// <summary>
        /// 更新或添加工序节点
        /// </summary>
        /// <param name="prodPlan"></param>
        /// <param name="nodeDict"></param>
        /// <param name="timeCostDict"></param>
        /// <returns></returns>
        public int AddOrUpdatePlanRoads(Prod_PlanProd prodPlan, Dictionary<string, int> nodeDict, Dictionary<string, string> timeCostDict)
        {
            int flag = 1;
            try
            {
                Instance.idb.BeginTransaction();


                //获取该零件图号原来对应的工艺路线
                List<Prod_Roads> roadNodesList = this.GetPlanRoadList(prodPlan.PlanProd_PlanCode);

                foreach (Prod_Roads r in roadNodesList)
                {

                    //Bse_Dict roadNode=dcInstance.GetDictByKey(DictKeyEnum.RoadNode,

                    //如果存在则更新
                    if (nodeDict.ContainsKey(r.PRoad_NodeCode))
                    {
                        r.PRoad_Order = nodeDict[r.PRoad_NodeCode];
                        //额定工时
                        r.PRoad_TimeCost = Convert.ToDecimal(timeCostDict[r.PRoad_NodeCode]);
                        //编制时间
                        r.PRoad_Date = DateTime.Now;

                        this.Update(r);
                        //更新完后移除该该工艺节点
                        nodeDict.Remove(r.PRoad_NodeCode);
                    }//不存在则删除
                    else
                    {
                        this.Delete(r);
                    }

                }

                foreach (KeyValuePair<string, int> kv in nodeDict)
                {
                    Prod_Roads pr = new Prod_Roads();
                    pr.PRoad_NodeCode = kv.Key;

                    //设置工艺路线
                    Bse_Dict roadNode = dcInstance.GetDictByKey(DictKeyEnum.RoadNode.ToString(), kv.Key);
                    pr.PRoad_NodeName = roadNode.Dict_Name;

                    pr.PRoad_ClassCode = roadNode.Dict_UDef1;
                    pr.PRoad_ClassName = roadNode.Dict_UDef2;

                    //额定工时
                    pr.PRoad_TimeCost = Convert.ToDecimal(timeCostDict[kv.Key]);
                    //零件图号
                    pr.PRoad_CompCode = prodPlan.PlanProd_PartNo;
                    pr.PRoad_Order = kv.Value;
                    //生产计划编码
                    pr.PRoad_PlanCode = prodPlan.PlanProd_PlanCode;
                    //产品编码
                    pr.PRoad_ProdCode = prodPlan.PlanProd_Code;

                    //默认生技处
                    pr.PRoad_NodeDepCode = GlobalConfiguration.ProdDept;
                    pr.PRoad_NodeDepName = GlobalConfiguration.ProdDeptName;


                    //时间安排（自动调整 开始时间）
                    pr.PRoad_Begin = prodPlan.PlanProd_Begin;
                    pr.PRoad_End = prodPlan.PlanProd_End;

                    //编制时间
                    pr.PRoad_Date = DateTime.Now;

                    Instance.Add(pr);
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

        public bool AddOrUpdatePlanRoads(Prod_PlanProd planProd, List<Prod_Roads> list, Dictionary<string, int> nodeDict, Dictionary<string, string> timeCostDict)
        {

            bool flag = true;

            try
            {


                foreach (var n in list)
                {
                    var re1 = Update(n);
                }

                foreach (KeyValuePair<string, int> kv in nodeDict)
                {
                    Prod_Roads pr = new Prod_Roads();
                    pr.PRoad_NodeCode = kv.Key;

                    //设置工艺路线
                    Bse_Dict roadNode = dcInstance.GetDictByKey(DictKeyEnum.RoadNode.ToString(), kv.Key);
                    pr.PRoad_NodeName = roadNode.Dict_Name;

                    pr.PRoad_ClassCode = roadNode.Dict_UDef1;
                    pr.PRoad_ClassName = roadNode.Dict_UDef2;
                    //额定工时
                    pr.PRoad_TimeCost = Convert.ToDecimal(timeCostDict[kv.Key]);
                    //零件图号
                    pr.PRoad_CompCode = planProd.PlanProd_PartNo;
                    pr.PRoad_Order = kv.Value;
                    //生产计划编码
                    pr.PRoad_PlanCode = planProd.PlanProd_PlanCode;
                    //产品编码
                    pr.PRoad_ProdCode = planProd.PlanProd_Code;

                    //默认生技处
                    pr.PRoad_NodeDepCode = GlobalConfiguration.ProdDept;
                    pr.PRoad_NodeDepName = GlobalConfiguration.ProdDeptName;


                    //时间安排（自动调整 开始时间）
                    pr.PRoad_Begin = planProd.PlanProd_Begin;
                    pr.PRoad_End = planProd.PlanProd_End;

                    //编制时间
                    pr.PRoad_Date = DateTime.Now;

                    Instance.Add(pr);
                }

            }
            catch (Exception e)
            {
                flag = false;
            }

            return flag;

        }



        /// <summary>
        /// 批量更新数据
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddOrUpdatePRoads(List<Prod_Roads> list)
        {
            foreach (var item in list)
            {
                Update(item);

            }

            return true;
        }




        /// <summary>
        /// 批量工序调整
        /// </summary>
        /// <param name="roadNodesList"></param>
        /// <param name="nodeDict"></param>
        /// <param name="timeCostDict"></param>
        /// <returns></returns>
        public List<Prod_Roads> AddOrUpdatePlanRoadsWithNoSubmit(List<Prod_Roads> roadNodesList, Dictionary<string, int> nodeDict, Dictionary<string, string> timeCostDict)
        {
            List<Prod_Roads> result = new List<Prod_Roads>();
            List<Prod_Roads> list = new List<Prod_Roads>();
            try
            {
                //foreach (Prod_Roads r in roadNodesList)
                //{

                //    //如果存在则更新信息并添加到集合,不存在则不处理（相当于删除）
                //    if (nodeDict.ContainsKey(r.PRoad_NodeCode))
                //    {
                //        r.PRoad_Order = nodeDict[r.PRoad_NodeCode];
                //        //额定工时
                //        r.PRoad_TimeCost = Convert.ToDecimal(timeCostDict[r.PRoad_NodeCode]);


                //        //编制时间
                //        r.PRoad_Date = DateTime.Now;

                //        result.Add(r);
                //        //更新完后移除该该工艺节点
                //        nodeDict.Remove(r.PRoad_NodeCode);
                //    }

                //}



                foreach (KeyValuePair<string, int> kv in nodeDict)
                {
                    Prod_Roads pr = new Prod_Roads();
                    pr.PRoad_NodeCode = kv.Key;

                    //设置工艺路线
                    Bse_Dict roadNode = dcInstance.GetDictByKey(DictKeyEnum.RoadNode.ToString(), kv.Key);
                    pr.PRoad_NodeName = roadNode.Dict_Name;

                    pr.PRoad_ClassCode = roadNode.Dict_UDef1;
                    pr.PRoad_ClassName = roadNode.Dict_UDef2;
                    //额定工时
                    pr.PRoad_TimeCost = Convert.ToDecimal(timeCostDict[kv.Key]);

                    pr.PRoad_Order = kv.Value;
                    ////生产计划编码
                    //pr.PRoad_PlanCode = prodPlan.PlanProd_PlanCode;
                    ////产品编码
                    //pr.PRoad_ProdCode = prodPlan.PlanProd_Code;

                    //默认生技处
                    pr.PRoad_NodeDepCode = GlobalConfiguration.ProdDept;
                    pr.PRoad_NodeDepName = GlobalConfiguration.ProdDeptName;


                    //时间安排（自动调整 开始时间）
                    pr.PRoad_Begin = DateTime.Now;
                    pr.PRoad_End = DateTime.Now;

                    //编制时间
                    pr.PRoad_Date = DateTime.Now;

                    list.Add(pr);
                }


            }
            catch (Exception e)
            {
                //如果出现异常则置空结果
                //roadNodesList = new List<Prod_Roads>();
            }

            return roadNodesList.Union(list).OrderBy(o => o.PRoad_Order).ToList();
        }



        /// <summary>
        /// 自动调整工序节点时间排期
        /// </summary>
        /// <param name="pp"></param>
        /// <returns></returns>
        public int AjustPlanRoadsTimeCost(Prod_PlanProd pp)
        {
            var flag = 1;

            try
            {
                List<Prod_Roads> prList = this.GetPlanRoadList(pp.PlanProd_PlanCode);
                DateTime planBegin = pp.PlanProd_Begin;
                DateTime planEnd = pp.PlanProd_End;
                DateTime tmpDate = pp.PlanProd_Begin;

                foreach (var pr in prList)
                {

                    int equTimeCost = pr.PRoad_EquTimeCost;
                    //工艺节点工时
                    decimal timeCost = pr.PRoad_TimeCost;

                    //如果设备额定工时为0，则表示不作时间限制
                    if (equTimeCost == 0)
                    {
                        equTimeCost = int.MaxValue;
                    }

                    //时间安排（自动调整 开始时间）
                    pr.PRoad_Begin = tmpDate;

                    //前置条件  上一工序完成后的时间是否可以直接递推（另起一天）

                    //工序工时超过设备负荷时间-->时间递推条件以设备能完成的时间为主
                    if (timeCost > equTimeCost)
                    {
                        double days = (Convert.ToDouble(timeCost) % Convert.ToDouble(equTimeCost));
                        double hours = (Convert.ToDouble(timeCost) / Convert.ToDouble(equTimeCost));
                        tmpDate = tmpDate.AddDays(days + hours);

                    }//工序工时所需设备满足负荷时间-->时间递推条件以工时为主
                    else if (timeCost > 8)
                    {
                        //问题 递推一天的条件？ AddDay？
                        tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
                    }
                    else
                    {
                        tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
                    }

                    pr.PRoad_End = tmpDate;

                    Instance.Update(pr);
                }
            }
            catch (Exception e)
            {
                flag = 0;
            }

            return flag;
        }

        /// <summary>
        /// 获取当前工艺节点之后的节点列表
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public List<Prod_Roads> GetProdRoadsForAjust(Prod_Roads pr)
        {
            string where = string.Format(" AND PRoad_PlanCode='{0}' AND PRoad_Order>{1} Order by PRoad_Order", pr.PRoad_PlanCode, pr.PRoad_Order);
            return Instance.GetListByWhere(where);
        }

        public void IncrementalAjustPlanRoads(Prod_Roads curPRoad)
        {
            //获取当前节点之后的节点列表
            List<Prod_Roads> prList = GetProdRoadsForAjust(curPRoad);
            //后续节点开始调整的时间即为当前节点调整后的结束时间
            DateTime tmpDate = ScheduleDate(curPRoad.PRoad_Begin, curPRoad.PRoad_EquTimeCost, curPRoad.PRoad_TimeCost);
            curPRoad.PRoad_End = tmpDate;
            Instance.Update(curPRoad);

            foreach (Prod_Roads pr in prList)
            {
                pr.PRoad_Begin = tmpDate;

                tmpDate = ScheduleDate(tmpDate, pr.PRoad_EquTimeCost, pr.PRoad_TimeCost);

                pr.PRoad_End = tmpDate;

                Instance.Update(pr);
            }

        }

        /// <summary>
        /// 设置当前所处工序
        /// </summary>
        /// <param name="oldNode"></param>
        /// <param name="newNode"></param>
        public void SetCurrentNode(Prod_Roads oldNode, Prod_Roads newNode)
        {
            newNode.PRoad_IsCurrent = 1;
            var f1 = Instance.Update(newNode);
            if (oldNode != null)
            {
                oldNode.PRoad_IsCurrent = 0;
                oldNode.PRoad_IsDone = true;
                oldNode.PRoad_ActCTime = DateTime.Now;
                oldNode.PRoad_FDate = DateTime.Now;

                var f2 = Instance.Update(oldNode);

            }

            SetInvNodeStat(newNode);

        }

        /// <summary>
        /// 设置当前产品所处节点状态
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public void SetInvNodeStat(Prod_Roads pr)
        {
            Inv_Information inv = invInstance.GetInvByProdCode(pr);
            //更新库存表 状态
            inv.IInfor_Stat = pr.PRoad_NodeCode;
            var re1 = invInstance.Update(inv);
        }

        public bool SetProdNodeFinish(Prod_Roads pr)
        {

            bool flag = true;

            ////设置生产状态
            //pr.PRoad_IsDone = true;

            //pr.PRoad_ActCTime = DateTime.Now;

            //pr.PRoad_FDate = DateTime.Now;

            //Update(pr);


            //获取库存表对应零件信息
            Inv_Information inv = invInstance.GetInvByProdCode(pr);
            Prod_Roads nextNode = GetNextNode(pr);
            //如果为空则表示当前节点是最后一个工艺节点
            if (nextNode != null)
            {
                //更新库存表 状态
                inv.IInfor_Stat = nextNode.PRoad_NodeCode;
                var re1 = invInstance.Update(inv);


            }
            else
            {

                //更新库存表 状态
                inv.IInfor_Stat = OperationTypeEnum.InvStatEnum.Entering.ToString();
                invInstance.Update(inv);
            }


            return flag;
        }

        /// <summary>
        /// 获取当前节点下一结点
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public Prod_Roads GetNextNode(Prod_Roads pr)
        {
            string where = string.Format(" AND PRoad_PlanCode='{0}' AND PRoad_Order>{1} order by PRoad_Order", pr.PRoad_PlanCode, pr.PRoad_Order);
            List<Prod_Roads> prList = GetProadRoadsByWhere(where);

            if (prList != null && prList.Count > 0)
            {
                //列表中第一个节点就是当前节点下一结点
                return prList[0];
            }
            else
            {
                return null;
            }



        }

        public Prod_Roads GetCurrentNode(string plancode)
        {
            List<Prod_Roads> list = GetPlanRoadList(plancode);
           var r =list.FirstOrDefault(o => o.PRoad_IsCurrent == 1);
            return r;
        }

        public List<Prod_Roads> IncrementalAjustPlanRoadsWithNoSubmit(Prod_Roads curPRoad, List<Prod_Roads> prList)
        {

            //后续节点开始调整的时间即为当前节点调整后的结束时间
            //DateTime tmpDate = ScheduleDate(curPRoad.PRoad_Begin, curPRoad.PRoad_EquTimeCost, curPRoad.PRoad_TimeCost);
            //curPRoad.PRoad_End = tmpDate;
            DateTime tmpDate = curPRoad.PRoad_Begin;

            foreach (Prod_Roads pr in prList)
            {
                if (pr.PRoad_Order >= curPRoad.PRoad_Order)
                {
                    pr.PRoad_Begin = tmpDate;

                    tmpDate = ScheduleDate(tmpDate, pr.PRoad_EquTimeCost, pr.PRoad_TimeCost);

                    pr.PRoad_End = tmpDate;
                }

            }

            return prList;

        }


        /// <summary>
        /// 排期
        /// </summary>
        /// <param name="startDate">起始时间点</param>
        /// <param name="equTimeCost">设备额定工时</param>
        /// <param name="nodeTimeCost">工艺节点额定工时</param>
        /// <returns>返回自动排期后的结束时间</returns>
        public DateTime ScheduleDate(DateTime startDate, int equTimeCost, decimal nodeTimeCost)
        {
            DateTime tmpDate = startDate;

            //if (equTimeCost == 0)
            //{
            //    equTimeCost = 1;
            //}

            //工艺节点工时
            decimal timeCost = nodeTimeCost;

            //前置条件  上一工序完成后的时间是否可以直接递推（另起一天）

            //工序工时超过设备负荷时间-->时间递推条件以设备能完成的时间为主
            if (timeCost > equTimeCost && equTimeCost != 0)
            {
                double days = (Convert.ToDouble(timeCost) % Convert.ToDouble(equTimeCost));
                double hours = (Convert.ToDouble(timeCost) / Convert.ToDouble(equTimeCost));
                tmpDate = tmpDate.AddDays(days + hours);

            }//工序工时所需设备满足负荷时间-->时间递推条件以工时为主
            else if (timeCost > 8)
            {
                //问题 递推一天的条件？ AddDay？
                tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
            }
            else
            {
                tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
            }

            return tmpDate;
        }

        /// <summary>
        /// 自动调整工序节点时间排期
        /// </summary>
        /// <param name="pp"></param>
        /// <returns></returns>
        public List<Prod_Roads> AjustPlanRoadsTimeCostWithNoSubmit(List<Prod_Roads> prList, DateTime startDate)
        {
            try
            {

                DateTime planBegin = startDate;
                //DateTime planEnd = pp.PlanProd_End;
                DateTime tmpDate = startDate;

                foreach (var pr in prList)
                {

                    int equTimeCost = pr.PRoad_EquTimeCost;
                    //工艺节点工时
                    decimal timeCost = pr.PRoad_TimeCost;

                    //如果设备额定工时为0，则表示不作时间限制
                    if (equTimeCost == 0)
                    {
                        equTimeCost = int.MaxValue;
                    }

                    //时间安排（自动调整 开始时间）
                    pr.PRoad_Begin = tmpDate;

                    //前置条件  上一工序完成后的时间是否可以直接递推（另起一天）

                    //工序工时超过设备负荷时间-->时间递推条件以设备能完成的时间为主
                    if (timeCost > equTimeCost)
                    {
                        double days = (Convert.ToDouble(timeCost) % Convert.ToDouble(equTimeCost));
                        double hours = (Convert.ToDouble(timeCost) / Convert.ToDouble(equTimeCost));
                        tmpDate = tmpDate.AddDays(days + hours);

                    }//工序工时所需设备满足负荷时间-->时间递推条件以工时为主
                    else if (timeCost > 8)
                    {
                        //问题 递推一天的条件？ AddDay？
                        tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
                    }
                    else
                    {
                        tmpDate = tmpDate.AddHours(Convert.ToDouble(timeCost));
                    }

                    pr.PRoad_End = tmpDate;


                }
            }
            catch (Exception e)
            {

            }

            return prList;
        }


        /// <summary>
        /// 根据条件获取工艺节点路线列表
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Prod_Roads> GetProadRoadsByWhere(string condition)
        {
            return Instance.GetListByWhere(condition);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Prod_Roads model)
        {
            bool result = false;
            try
            {
                int _result = Instance.Add(model);
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
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public Prod_Roads GetModel(string strCondition)
        {
            List<Prod_Roads> list = Instance.GetListByWhere(strCondition);
            Prod_Roads model = new Prod_Roads();
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
        public bool Update(Prod_Roads model)
        {
            bool result = false;
            int _rseult = Instance.Update(model);
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
        public bool Delete(Prod_Roads pr)
        {
            bool result = false;
            pr.Stat = 1;
            if (Instance.Update(pr) > 0)
            {
                result = true;
            }

            //List<Prod_Roads> list = Instance.GetListByWhere(" AND RDetail_Code='" + Code + "'");
            //if (list.Count > 0)
            //{
            //    Prod_Roads model = list[0];
            //    model.Stat = 1;
            //    int _rseult = Instance.Update(model);
            //    if (_rseult > 0)
            //    {
            //        result = true;
            //    }
            //}
            return result;
        }

        #endregion

        #region new 

        public List<Prod_Roads> GetProdNodeList(string bdate,string edate,string key)
        {
            List<Prod_Roads> list = new List<Prod_Roads>();
            string where = string.Format(" and Proad_plancode in (select planprod_plancode from prod_planprod where isnull(stat,0)=0) AND (Proad_ProdCode like '%{0}%' OR Proad_NodeName like '%{0}%')",key);
            list = Instance.GetListByWhere(where);

            return list;
        }

        /// <summary>
        /// 更新零件生产工艺信息
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool UpdateNodeList(List<Prod_Roads> list)
        {
            foreach (var p in list)
            {
                if (p.PRoad_ID != 0)
                {
                    Instance.Update(p);
                }
              
            }

            return true;
        }

        #endregion
    }
}
