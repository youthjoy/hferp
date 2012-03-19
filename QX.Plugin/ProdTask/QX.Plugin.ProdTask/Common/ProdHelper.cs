using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.Common.C_Form;
using QX.DataModel;
using QX.Common.C_Class;
using QX.BLL;
using Infragistics.Win.UltraWinGrid;
using QX.BseDict;
using Infragistics.Win;
using QX.Framework.AutoForm;
using QX.Plugin.Prod.Report;
using QX.Shared;
using System.Collections;

namespace QX.Plugin.Prod.Common
{
    public class ProdHelper
    {

        #region 计划回滚助手

        public Bll_Prod_PlanProd planInstance = new Bll_Prod_PlanProd();
        public Bll_Prod_Roads prInstance = new Bll_Prod_Roads();
        public Bll_ProdTask ptInstance = new Bll_ProdTask();
        public Bll_Raw_Detail rdInstance = new Bll_Raw_Detail();
        public Bll_Raw_Inv rvInstance = new Bll_Raw_Inv();
        public Bll_Prod_CmdDetail pcdInstance = new Bll_Prod_CmdDetail();
        public Bll_Inv_Information invInstance = new Bll_Inv_Information();
        public Bll_Prod_Command pcInstance = new Bll_Prod_Command();
        public class Tips
        {
            public int index
            {
                get;
                set;
            }

            public string key
            {
                get;
                set;
            }
        }

        List<Tips> refList = new List<Tips>();

        public bool RollBackBefore(string step)
        {

            return true;
        }

        /// <summary>
        /// 撤销入库记录
        /// </summary>
        public void RollBackRaw(Raw_Inv inv)
        {
            if (string.IsNullOrEmpty(inv.RI_RefDetailCode))
            {
                Raw_Detail rdetail = rdInstance.GetModel(string.Format(" AND RDetail_Command='{0}' and RDetail_PartNo='{1}' and isnull(RDetail_Num,0)={2}", inv.RI_CmdCode, inv.RI_CompCode, inv.RI_Sum));

                if (rdetail != null)
                {
                    //hack 以前入库的毛坯未与入库记录联系（把数量一致回滚至）
                    inv.Stat = 2;
                    rvInstance.Update(inv);
                    //入库记录
                    rdetail.Stat = 2;
                    rdInstance.Update(rdetail);
                    //指令明细
                    var detail = pcdInstance.GetModel(string.Format(" AND Cmd_Code='{0}' AND CmdDetail_PartNo='{1}'", inv.RI_CmdCode, inv.RI_CompCode));
                    detail.CmdDetail_DNum = detail.CmdDetail_DNum - rdetail.RDetail_Num;
                    pcdInstance.Update(detail);
                    //生产指令
                    var cmd = pcdInstance.GetCommand(inv.RI_CmdCode);
                    int temp = 0;
                    int.TryParse(cmd.Cmd_Udef3, out temp);
                    int left = (temp - detail.CmdDetail_DNum);
                    cmd.Cmd_Udef3 = left.ToString();
                    var d = pcInstance.Update(cmd);
                }
            }
            else
            {
                //库存记录
                inv.Stat = 2;
                rvInstance.Update(inv);
                //入库明细
                var rdetail = rdInstance.GetModel(string.Format(" AND RDetail_Code='{0}'", inv.RI_RefDetailCode));
                rdetail.Stat = 2;
                rdInstance.Update(rdetail);
                //指令明细
                var detail = pcdInstance.GetModel(string.Format(" AND Cmd_Code='{0}' AND CmdDetail_PartNo='{1}'", inv.RI_CmdCode, inv.RI_CompCode));
                detail.CmdDetail_DNum = detail.CmdDetail_DNum - rdetail.RDetail_Num;
                pcdInstance.Update(detail);
                //指令总数量
                var cmd = pcdInstance.GetCommand(inv.RI_CmdCode);
                int temp = 0;
                int.TryParse(cmd.Cmd_Udef3, out temp);
                int left = (temp - detail.CmdDetail_DNum);
                cmd.Cmd_Udef3 = left.ToString();
                var d = pcInstance.Update(cmd);
            }

        }

        /// <summary>
        /// 撤销生产任务
        /// </summary>
        public void RollBackProdTask(string taskcode)
        {
            var task = ptInstance.GetTaskByCode(taskcode);
            var list = planInstance.GetPlanProdList(taskcode);

            foreach (var d in list)
            {
                RollBackProdPlan(d);
            }
            int tasknum = task.TaskDetail_Num;

            Raw_Inv inv = rvInstance.GetModel(string.Format(" AND RI_Code='{0}'", task.Task_RefInv));
            //hack 如果不是新数据，则进行通过生产指令+零件编号取数据
            if (inv != null)
            {


                //已下达任务的撤销
                inv.RI_AvailableNum = inv.RI_AvailableNum + tasknum;
                inv.RI_UsedNum = inv.RI_UsedNum - tasknum;
                rvInstance.Update(inv);
            }
            else
            {

                List<Raw_Inv> list1 = rvInstance.GetInvByCmdAndPartNo(task.TaskDetail_CmdCode, task.TaskDetail_PartNo);
                if (list1 != null && list1.Count > 0)
                {

                    int temp = tasknum;
                    //逐步遍历数据回滚（仅减去数量）以前没有硬性关联的毛坯库存数据，直到把对应任务的数量减完为止
                    foreach (var r in list1)
                    {
                        if (r.RI_Sum >= temp)
                        {
                            r.RI_AvailableNum = r.RI_AvailableNum + temp;
                            r.RI_UsedNum = r.RI_UsedNum - temp;
                            rvInstance.Update(r);
                            temp = 0;
                        }
                        else if (r.RI_Sum < temp)
                        {

                            r.RI_AvailableNum = r.RI_Sum;
                            r.RI_UsedNum = 0;
                            temp = temp - r.RI_Sum;
                            rvInstance.Update(r);
                        }

                        if (temp == 0)
                        {
                            break;
                        }

                    }
                }
            }

            task.Stat = 2;
            ptInstance.Update(task);
        }

        /// <summary>
        /// 撤销下发计划(Prod_PlanProd,Prod_Roads,Inv_Information,Prod_Task,Prod_PMap)
        /// </summary>
        public void RollBackProdPlan(string plancode)
        {
            Prod_PlanProd prod = planInstance.GetModelByKey(plancode);
            List<Prod_Roads> prList = prInstance.GetPlanRoadListByPlanCode(prod.PlanProd_PlanCode);

            prod.Stat = 2;
            //prod_planprod
            planInstance.UpdatePlan(prod);

            foreach (var p in prList)
            {
                p.Stat = 2;
                prInstance.Update(p);
            }
           
            //prod_task
            Prod_Task pt = ptInstance.GetTaskByCode(prod.PlanProd_TaskCode);
            if (pt != null)
            {
                //任务数量
                pt.Task_DNum = pt.Task_DNum - 1;

                ptInstance.Update(pt);
            }


            //inv_information
            Inv_Information inv = invInstance.GetInvByPlanCode(prod.PlanProd_PlanCode);
            if (inv != null)
            {
                inv.Stat = 2;
                invInstance.Update(inv);
            }
            RollbackPMap(prod.PlanProd_Code, prod.PlanProd_CmdCode);
        }

        /// <summary>
        /// 生产计划回滚(Prod_PlanProd,Prod_Roads,Inv_Information,Prod_Task,Prod_PMap)
        /// </summary>
        /// <param name="prod"></param>
        public void RollBackProdPlan(Prod_PlanProd prod)
        {
            List<Prod_Roads> prList = prInstance.GetPlanRoadListByPlanCode(prod.PlanProd_PlanCode);
            //Prod_PlanProd prod = planInstance.GetModelByKey(plancode);

            prod.Stat = 2;
            //prod_planprod
            planInstance.UpdatePlan(prod);

            foreach (var p in prList)
            {
                p.Stat = 2;
                prInstance.Update(p);
            }

            

            //prod_task
            Prod_Task pt = ptInstance.GetTaskByCode(prod.PlanProd_TaskCode);
            //任务数量
            pt.Task_DNum = pt.Task_DNum - 1;

            ptInstance.Update(pt);

            //inv_information
            Inv_Information inv = invInstance.GetInvByPlanCode(prod.PlanProd_PlanCode);
            inv.Stat = 2;
            invInstance.Update(inv);

            RollbackPMap(prod.PlanProd_Code, prod.PlanProd_CmdCode);
        }

        /// <summary>
        /// 生产状态回滚（下达时间）
        /// </summary>
        /// <param name="prodCode"></param>
        /// <param name="cmdCode"></param>
        public void RollbackPMap(string prodCode, string cmdCode)
        {
            var pmap = pcdInstance.GetPMapModel(prodCode, cmdCode);
            pmap.PMap_Stat = string.Empty;
            pmap.PMap_RawStat="In";
            pcdInstance.UpdateProdMap(pmap);
        }

        #endregion
    }
}
