using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;
using QX.Common.C_Class;
using QX.DataAcess;
using QX.Shared;
using System.Threading;
using System.Windows.Forms;

namespace QX.BLL
{
    public class Bll_Prod_Record
    {
        private Bll_ProdTask ptInstance = new Bll_ProdTask();

        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();

        private Bll_Prod_Roads prInstance = new Bll_Prod_Roads();

        private Bll_Inv_Information invInstance = new Bll_Inv_Information();

        private Bll_Audit auInstance = new Bll_Audit();



        private Bll_FHelper_Info infoInstance = new Bll_FHelper_Info();

        private Bll_FHelper_Price pInstance = new Bll_FHelper_Price();

        private Bll_TestRef trInstance = new Bll_TestRef();

        //不合格品
        private Bll_Failure_Information fiInstance = new Bll_Failure_Information();

        /// <summary>
        /// 获取待处理的生产任务（即在生产的零件）
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetDoingTask()
        {
            List<Prod_Task> list = ptInstance.GetProdTaskByStat(OperationTypeEnum.ProdTaskStatEnum.Planing.ToString());

            return list;
        }



        /// <summary>
        /// 获取待处理的生产任务（即在生产的零件）
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetDoingTaskByWhere(string filter)
        {
            string where = string.Format(" AND Task_Stat IN('{0}') {1} Order By Task_ID asc", OperationTypeEnum.ProdTaskStatEnum.Planing.ToString(), filter);
            return ptInstance.GetProdTaskByWhereExtend(where);
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Prod_Task> GetFinTaskByWhere(string filter)
        {
            string where = string.Format(" AND Task_Stat IN('{0}') {1} Order By Task_ID asc", OperationTypeEnum.ProdTaskStatEnum.Finish.ToString(), filter);
            return ptInstance.GetProdTaskByWhereExtend(where);
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
        /// 获取当前节点下一结点
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public Prod_Roads GetNextNode(Prod_Roads pr)
        {
            string where = string.Format(" AND PRoad_PlanCode='{0}' AND PRoad_Order>{1} order by PRoad_Order", pr.PRoad_PlanCode, pr.PRoad_Order);
            List<Prod_Roads> prList = prInstance.GetProadRoadsByWhere(where);

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

        /// <summary>
        /// 设置已完成工序
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public bool SetProdNodeFinish(Prod_Roads pr)
        {

            bool flag = true;

            //设置生产状态
            pr.PRoad_IsDone = true;

            pr.PRoad_ActCTime = DateTime.Now;

            pr.PRoad_FDate = DateTime.Now;

            prInstance.Update(pr);


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
        /// 设置工艺节点检测状态
        /// </summary>
        /// <param name="pr">当前工艺节点</param>
        /// <returns></returns>
        public bool SetProdNodeChecked(bool isPass, Prod_Roads pr, List<Road_TestRef> testlist)
        {

            bool flag = true;

            if (isPass)
            {
                //设置生产状态
                pr.PRoad_IsQuality = true;
                prInstance.Update(pr);

                //foreach (Road_TestRef t in testlist)
                //{
                //    //添加检测记录
                //    Prod_TestRef test = new Prod_TestRef();
                //    //产品编码
                //    test.PTestRef_ProdCode =pr.PRoad_ProdCode;

                //    test.PTestRef_Code = trInstance.GenerateTestRefCode();
                //    test.PTestRef_NodeCode = pr.PRoad_NodeCode;
                //    test.PTestRef_NodeName = pr.PRoad_NodeName;

                //    test.PTestRef_RefValue = t.TestRef_Value;
                //    test.PTestRef_TestName = t.TestRef_Name;
                //    test.PTestRef_TestNode = t.TestRef_Code;
                //    test.PTestRef_High = t.TestRef_High;
                //    test.PTestRef_Low = t.TestRef_Low;
                //    test.PTestRef_IsLast = t.TestRef_IsLast;
                //    test.PTestRef_Order = t.TestRef_Order;

                //    var d=trInstance.AddTestRef(test);
                //}

                //判断是否最后一个质检
                List<Prod_Roads> list = prInstance.GetPlanRoadList(pr.PRoad_PlanCode);

                var checkedList = list.Where(o => o.PRoad_IsQuality);

                //如果已全部质检,则更新计划状态(库存表)
                if (checkedList.Count() == list.Count)
                {
                    //判断是否存在终检
                    var model = invInstance.GetInvByProdCode(pr);
                    model.IInfor_Stat = OperationTypeEnum.InvStatEnum.Entering.ToString();
                    invInstance.Update(model);

                    var model1 = ppInstance.GetModelByKey(pr.PRoad_PlanCode);
                    model1.PlanProd_FDate = DateTime.Now;
                    ppInstance.UpdatePlan(model1);

                    var temp = ppInstance.GetModelByProdCode(pr.PRoad_ProdCode);
                    IsFinTask(temp.PlanProd_TaskCode);
                    ////获取所有计划列表
                    //var planList = ppInstance.GetFinPlanProdList(temp.PlanProd_TaskCode);
                    //var task = ptInstance.GetTaskByCode(temp.PlanProd_TaskCode);

                    //if (planList.Count == task.TaskDetail_Num)
                    //{
                    //    task.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Finish.ToString();
                    //    ptInstance.UpdateProdTaskStat(task);
                    //}
                }
            }
            else
            {
                pr.PRoad_IsQuality = false;
                prInstance.Update(pr);
                //库存更新
                var model = invInstance.GetInvByProdCode(pr);
                model.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
                invInstance.Update(model);

                //foreach (Road_TestRef t in testlist)
                //{
                //    //添加检测记录
                //    Prod_TestRef test = new Prod_TestRef();
                //    test.PTestRef_Code = trInstance.GenerateTestRefCode();
                //    test.PTestRef_NodeCode = pr.PRoad_NodeCode;
                //    test.PTestRef_NodeName = pr.PRoad_NodeName;
                //    test.PTestRef_ProdCode = pr.PRoad_ProdCode;

                //    test.PTestRef_RefValue = t.TestRef_Value;
                //    test.PTestRef_TestName = t.TestRef_Name;
                //    test.PTestRef_TestNode = t.TestRef_Code;
                //    test.PTestRef_High = t.TestRef_High;
                //    test.PTestRef_Low = t.TestRef_Low;
                //    test.PTestRef_IsLast = t.TestRef_IsLast;
                //    test.PTestRef_Order = t.TestRef_Order;

                //    var d=trInstance.AddTestRef(test);
                //}


                var plan = ppInstance.GetModelByKey(pr.PRoad_PlanCode);

                //进入不合格品流程
                Failure_Information fi = new Failure_Information();
                fi.FInfo_Code = fiInstance.GenerateFailureInfor();
                fi.FInfo_PartNo = plan.PlanProd_PartNo;
                fi.FInfo_PartName = plan.PlanProd_Code;
                fi.FInfo_CmdCode = plan.PlanProd_CmdCode;
                fi.FInfo_PartName = plan.PlanProd_PartName;
                fi.FInfo_Num = 1;
                fi.FInfo_ProdNo = plan.PlanProd_Code;
                fi.FInfo_FindNode = pr.PRoad_NodeCode;
                fi.FInfo_FindNodeName = pr.PRoad_NodeName;
                fi.FInfo_RespEntity = pr.PRoad_NodeDepName;
                fi.FInfo_Date = DateTime.Now;
                fi.FInfo_Stat = OperationTypeEnum.ProdStatEnum.Defective.ToString();
                fi.FInfo_Owner = SessionConfig.UserCode;

                //状态设置
                fi.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

                Verify_TemplateConfig config = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString());

                if (config != null)
                {
                    fi.AuditCurAudit = config.VT_VerifyNode_Code;
                }

                fiInstance.AddFailure(fi);
            }

            return flag;
        }

        public Failure_Information SetProdNodeChecked(bool isPass, Prod_Roads pr)
        {

            //bool flag = true;
            //进入不合格品流程
            Failure_Information fi = null;
            if (isPass)
            {
                //设置生产状态
                pr.PRoad_IsQuality = true;
                prInstance.Update(pr);


                //判断是否最后一个质检
                List<Prod_Roads> list = prInstance.GetPlanRoadList(pr.PRoad_PlanCode);

                var checkedList = list.Where(o => o.PRoad_IsQuality);

                //如果已全部质检,则更新计划状态(库存表)
                if (checkedList.Count() == list.Count)
                {
                    //判断是否存在终检
                    var model = invInstance.GetInvByProdCode(pr);
                    model.IInfor_Stat = OperationTypeEnum.InvStatEnum.Entering.ToString();
                    //实际完工时间
                    model.IInfor_InTime = DateTime.Now;
                    invInstance.Update(model);

                    var temp = ppInstance.GetModelByKey(pr.PRoad_PlanCode);

                    temp.PlanProd_FStat = OperationTypeEnum.ProdPlanStatEnum.Finish.ToString();
                    temp.PlanProd_FDate = DateTime.Now;

                    ppInstance.UpdatePlan(temp);

                    IsFinTask(temp.PlanProd_TaskCode);
                }
            }
            else
            {
                pr.PRoad_IsQuality = false;
                prInstance.Update(pr);
                //库存更新
                var model = invInstance.GetInvByProdCode(pr);
                model.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Unqualified.ToString();
                invInstance.Update(model);
                //计划更新
                var plan = ppInstance.GetModelByKey(pr.PRoad_PlanCode);

                fi = new Failure_Information();
                fi.FInfo_Code = fiInstance.GenerateFailureInfor();
                fi.FInfo_PartNo = plan.PlanProd_PartNo;
                fi.FInfo_PartName = plan.PlanProd_Code;
                fi.FInfo_CmdCode = plan.PlanProd_CmdCode;
                fi.FInfo_PartName = plan.PlanProd_PartName;
                fi.FInfo_Num = 1;
                fi.FInfo_ProdNo = plan.PlanProd_Code;
                fi.FInfo_FindNode = pr.PRoad_NodeCode;
                fi.FInfo_FindNodeName = pr.PRoad_NodeName;
                fi.FInfo_RespEntity = pr.PRoad_NodeDepName;
                fi.FInfo_Date = DateTime.Now;
                fi.FInfo_Stat = OperationTypeEnum.ProdStatEnum.Defective.ToString();
                fi.FInfo_Owner = SessionConfig.UserCode;

                //状态设置
                fi.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

                Verify_TemplateConfig config = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FailureAudit_F001.ToString());

                if (config != null)
                {
                    fi.AuditCurAudit = config.VT_VerifyNode_Code;
                }

                int id = fiInstance.AddFailureWithReturn(fi);
                fi.FInfo_ID = id;
            }

            return fi;
        }


        public void SetProdNodeChecked(Prod_Roads pr)
        {
            //Prod_Roads pr = new Prod_Roads();

            //设置生产状态
            //pr.PRoad_IsQuality = true;
            //prInstance.Update(pr);


            //判断是否最后一个质检
            List<Prod_Roads> list = prInstance.GetPlanRoadList(pr.PRoad_PlanCode);

            var checkedList = list.Where(o => o.PRoad_IsQuality);

            //如果已全部质检,则更新计划状态(库存表)
            if (checkedList.Count() == list.Count)
            {
                //判断是否存在终检
                var model = invInstance.GetInvByPlanCode(pr.PRoad_PlanCode);
                model.IInfor_Stat = OperationTypeEnum.InvStatEnum.Entering.ToString();
                //实际完工时间
                model.IInfor_InTime = DateTime.Now;
                invInstance.Update(model);

                var temp = ppInstance.GetModelByKey(pr.PRoad_PlanCode);
                temp.PlanProd_FStat = OperationTypeEnum.ProdPlanStatEnum.Finish.ToString();
                ppInstance.UpdatePlan(temp);
                IsFinTask(temp.PlanProd_TaskCode);
            }


        }

        /// <summary>
        /// 批量质检
        /// </summary>
        /// <param name="list"></param>
        public void BatchCheck(List<Prod_PlanProd> list)
        {
            foreach (var l in list)
            {

                //零件相关工序列表
                List<Prod_Roads> rlist = prInstance.GetPlanRoadList(l.PlanProd_PlanCode);
                ///批量置质检通过
                foreach (var r in rlist)
                {
                    r.PRoad_IsQuality = true;
                    r.PRoad_IsDone = true;
                    prInstance.Update(r);
                }

                l.PlanProd_FStat = OperationTypeEnum.ProdPlanStatEnum.Finish.ToString();
                l.PlanProd_FDate = DateTime.Now;

                ppInstance.UpdatePlan(l);

                var model = invInstance.GetInvByPlanCode(l.PlanProd_PlanCode);
                model.IInfor_Stat = OperationTypeEnum.InvStatEnum.Entering.ToString();
                model.IInfor_InTime = DateTime.Now;
                invInstance.Update(model);
            }

            if (list != null && list.Count > 0)
            {
                IsFinTask(list[0].PlanProd_TaskCode);
            }
        }

        public void IsFinTask(string taskCode)
        {
            //var temp = ppInstance.GetModelByProdCode(pr.PRoad_ProdCode);
            //获取所有计划列表
            var planList = ppInstance.GetFinPlanProdList(taskCode);
            var task = ptInstance.GetTaskByCode(taskCode);

            if (planList.Count == task.TaskDetail_Num)
            {
                task.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Finish.ToString();
                ptInstance.UpdateProdTaskStat(task);
            }

        }

        /// <summary>
        /// 单个节点进入外协
        /// </summary>
        /// <param name="pr"></param>
        /// <returns></returns>
        public bool EnterFHelper(Prod_Roads pr)
        {
            //外协处理流程
            FHelper_Info info1 = infoInstance.GetModel(string.Format(" AND FHelperInfo_ProdCode='{0}' AND isnull(FHelperInfo_Stat,'')<>'Done' ", pr.PRoad_ProdCode));
            if (info1 != null)
            {
                return false;
            }
            //外协处理流程
            FHelper_Info info = new FHelper_Info();

            info.FHelperInfo_Code = infoInstance.GenerateCode();

            //零件图号
            info.FHelperInfo_PartCode = pr.PRoad_CompCode;

            //info.FHelperInfo_RoadNodeName = pr.PRoad_NodeName;
            //产品编码/零件编码
            info.FHelperInfo_ProdCode = pr.PRoad_ProdCode;

            info.FHelperInfo_RoadNodes = pr.PRoad_NodeCode;
            info.FHelperInfo_Date = DateTime.Now;
            info.FHelperInfo_Owner = SessionConfig.UserCode;
            info.FHelperInfo_Num = 1;

            //如果有记录则不走价格否则价格审核流程(添加一条价格信息)
            //FHelper_Price price = pInstance.GetFHelperPrice(pr.PRoad_CompCode, pr.PRoad_NodeCode);
            //if (price == null)
            //{
            FHelper_Price price = new FHelper_Price();
            //info.FHelperInfo_Price = Convert.ToInt32(price.FP_Price);
            //info.FHelperInfo_FSup = price.FP_ManuCode;
            price.FP_CompCode = info.FHelperInfo_PartCode;
            price.FP_PNodeCode = pr.PRoad_NodeCode;
            price.FP_NodeName = pr.PRoad_NodeName;

            MethodInvoker mi = delegate
            {
                Bll_Road_Components rcInst = new Bll_Road_Components();
                var dd = rcInst.GetRoadComponentByCode(pr.PRoad_CompCode);
                price.FP_CompName = dd.Comp_Name;
                BLL.Bll_FHelper_Price fpInst = new Bll_FHelper_Price();
                price.FP_Code = fpInst.GenerateFPCode();
                fpInst.AddPrice(price);
            };

            var asysn = mi.BeginInvoke(null, null);

            try
            {
                mi.EndInvoke(asysn);
            }
            catch (Exception ee)
            {

            }
            //}
            info.FHelperInfo_Stat = OperationTypeEnum.FHelper_Stat.ConfirmSup.ToString();
            info.FHelperInfo_iType = "FHelper";
            var re = infoInstance.Insert(info);

            return re;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plan"></param>
        /// <param name="inf"></param>
        /// <param name="nodestr"></param>
        /// <param name="nodelist"></param>
        /// <returns></returns>
        public bool BatchEnterFHelper(Prod_PlanProd plan, FHelper_Info inf, string nodestr, string nodelist)
        {
            ////外协处理流程
            //FHelper_Info info1 = infoInstance.GetModel(string.Format(" AND FHelperInfo_ProdCode='{0}' AND isnull(FHelperInfo_Stat,'')<>'Done' ", pr.PRoad_ProdCode));
            //if (info1 != null)
            //{
            //    return false;
            //}

            //外协处理流程
            FHelper_Info info = new FHelper_Info();
            info.FHelperInfo_FSup = inf.FHelperInfo_FSup;

            info.FHelperInfo_Code = infoInstance.GenerateCode();

            //零件图号
            info.FHelperInfo_PartCode = plan.PlanProd_PartNo;

            //info.FHelperInfo_RoadNodeName = pr.PRoad_NodeName;
            //产品编码/零件编码
            info.FHelperInfo_ProdCode = plan.PlanProd_Code;

            info.FHelperInfo_RoadNodes = nodestr;
            info.FHelperInfo_Date = DateTime.Now;
            info.FHelperInfo_Owner = SessionConfig.UserCode;
            info.FHelperInfo_Num = 1;
            info.FHelperInfo_IsBatch = nodelist;
            //如果有记录则不走价格否则价格审核流程(添加一条价格信息)
            //FHelper_Price price = pInstance.GetFHelperPrice(pr.PRoad_CompCode, pr.PRoad_NodeCode);
            //if (price == null)
            //{
            FHelper_Price price = new FHelper_Price();
            //info.FHelperInfo_Price = Convert.ToInt32(price.FP_Price);
            //info.FHelperInfo_FSup = price.FP_ManuCode;
            price.FP_CompCode = info.FHelperInfo_PartCode;
            price.FP_PNodeCode = nodestr;
            price.FP_NodeName = nodestr;

            MethodInvoker mi = delegate
            {


                price.FP_CompName = plan.PlanProd_PartName;
                BLL.Bll_FHelper_Price fpInst = new Bll_FHelper_Price();
                price.FP_Code = fpInst.GenerateFPCode();
                fpInst.AddPrice(price);
            };

            var asysn = mi.BeginInvoke(null, null);

            try
            {
                mi.EndInvoke(asysn);
            }
            catch (Exception ee)
            {

            }
            //}
            info.FHelperInfo_Stat = OperationTypeEnum.FHelper_Stat.ConfirmSup.ToString();
            info.FHelperInfo_iType = "FHelper";
            var re = infoInstance.Insert(info);

            return re;
        }

        /// <summary>
        /// 设置外协完成状态
        /// </summary>
        /// <param name="prodCode"></param>
        /// <param name="nodeCode"></param>
        public void SetFHelperFinish(string prodCode, string nodeCode)
        {
            Prod_PlanProd plan = ppInstance.GetProdModel(string.Format(" AND PlanProd_Code='{0}' AND isnull(PlanProd_FStat,'')='Planing'", prodCode));
            if (plan == null)
            {
                return;
            }

            var roads = prInstance.GetPlanRoadList(plan.PlanProd_PlanCode);
            Inv_Information inv = invInstance.GetInvByPlanCode(plan.PlanProd_PlanCode);
            if (roads != null && roads.Count > 0)
            {
                var pr = roads.FirstOrDefault(o => o.PRoad_NodeCode == nodeCode);
                var nextRoad = roads.FirstOrDefault(o => o.PRoad_Order > pr.PRoad_Order);

                //如果存在下一阶段
                if (nextRoad != null)
                {
                    pr.PRoad_IsDone = true;
                    pr.PRoad_IsQuality = true;
                    pr.PRoad_IsCurrent = 0;
                    prInstance.Update(pr);
                    nextRoad.PRoad_IsCurrent = 1;
                    prInstance.Update(nextRoad);
                    inv.IInfor_Stat = pr.PRoad_NodeCode;
                    invInstance.Update(inv);
                }
                else
                {
                    pr.PRoad_IsDone = true;
                    pr.PRoad_IsQuality = true;
                    prInstance.Update(pr);
                }

            }

        }


        public void SetFHelperFinishForBatch(string prodCode, string nodeCode)
        {
            Prod_PlanProd plan = ppInstance.GetProdModel(string.Format(" AND PlanProd_Code='{0}' AND isnull(PlanProd_FStat,'')='Planing'", prodCode));
            if (plan == null)
            {
                return;
            }
            string[] dd = nodeCode.Split(',');

            var roads = prInstance.GetPlanRoadList(plan.PlanProd_PlanCode);

            if (roads != null && roads.Count > 0)
            {
                foreach (var d in dd)
                {
                    var pr = roads.FirstOrDefault(o => o.PRoad_NodeCode == d);
                    //var nextRoad = roads.FirstOrDefault(o => o.PRoad_Order > pr.PRoad_Order);
                    ////如果存在下一阶段
                    //if (nextRoad != null)
                    //{
                    //    pr.PRoad_IsDone = true;
                    //    pr.PRoad_IsQuality = true;
                    //    pr.PRoad_IsCurrent = 0;
                    //    prInstance.Update(pr);
                    //    nextRoad.PRoad_IsCurrent = 1;
                    //    prInstance.Update(nextRoad);
                    //}
                    //else
                    //{
                    pr.PRoad_ActETime = DateTime.Now;
                    pr.PRoad_IsDone = true;
                    pr.PRoad_IsQuality = true;
                    prInstance.Update(pr);
                    //}
                }


            }

        }

        /// <summary>
        /// 配对组件入库---需重点重新改造
        /// </summary>
        /// <param name="list"></param>
        public void EnterStockForPatchProd(List<Inv_Information> list)
        {
            foreach (var inv in list)
            {
                var p = ppInstance.GetProdModel(string.Format(" AND PlanProd_PlanCode='{0}'", inv.IInfor_PlanCode));
                //零件关联的模块编码
               // var plist = ppInstance.GetPlanProdListForPatch(p.PlanProd_PlanCode);
                //question  如何遍历？ 策略

                if (!string.IsNullOrEmpty(p.PlanProd_Patch))
                {
                    List<Prod_PlanProd> list1 = ppInstance.GetPatchList(p.PlanProd_Patch);
                    //把其余几个零件一起做入库操作
                    foreach (var pp in list1)
                    {

                        if (pp.PlanProd_MPatchCode != p.PlanProd_Code)
                        {
                            var inv1 = invInstance.GetInvByPlanCode(pp.PlanProd_PlanCode);
                            invInstance.InventoryInvInfo(inv1);
                        }
                    }
                }
            }
        }
    }
}
