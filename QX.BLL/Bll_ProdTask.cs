using System;
using System.Collections.Generic;
using System.Text;
using QX.Common;
using QX.DataModel;
using QX.DataAceess;
using QX.Common.C_Class;

namespace QX.BLL
{
    public class Bll_ProdTask
    {
        public DataAceess.ADOProd_Task Instance = new QX.DataAceess.ADOProd_Task();

        private Bll_Raw_Inv riInstance ;

        private Bll_Prod_CmdDetail pcInstance = new Bll_Prod_CmdDetail();

        public Bll_ProdTask()
        {
            riInstance = new Bll_Raw_Inv();
            //riInstance.Instance.idb.SetConnection(Instance.idb.GetConnection());
        }

        /// <summary>
        /// 获取待使用的毛坯列表（即可下达生产任务的毛坯列表）
        /// </summary>
        /// <returns></returns>
        public List<Raw_Inv> GetBeUseRawList()
        {
            return riInstance.GetAvailableRawList();
        }

        /// <summary>
        /// 获取已下达生产任务列表
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetProdTask()
        {
            string where = string.Format(" AND Task_Stat IN('{0}','{1}') Order by Task_ID asc", OperationTypeEnum.ProdTaskStatEnum.Deploying.ToString(), OperationTypeEnum.ProdTaskStatEnum.Planing.ToString());
            return Instance.GetListByWhereExtend(where);
        }

        public List<Prod_Task> GetProdTaskWithContract(string bdate,string edate,string key)
        {
            string where = string.Format(" AND Task_Date between '{0}' and '{1}' and (Cmd_CBill like '%{2}%' OR Cmd_CBillName like '%{2}%' OR TaskDetail_CmdCode like '%{2}%' OR TaskDetail_PartNo like '%{2}%' OR SDR_ContractCode like '%{2}%')", bdate, edate, key);

            return Instance.GetListByWhereWithContract(where);
        }

        /// <summary>
        /// 根据状态获取数据
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<Prod_Task> GetProdTaskByStat(string code)
        {
            string where = string.Format(" AND Task_Stat IN('{0}') Order By Task_ID ASC", code);
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 根据状态获取数据
        /// </summary>
        /// <param name="code"></param>
        /// <param name="filter">过滤条件</param>
        /// <returns></returns>
        public List<Prod_Task> GetProdTaskByStat(string code,string filter)
        {
            string where = string.Format(" AND Task_Stat IN('{0}') {1} Order By Task_ID ASC", code,filter);
            return Instance.GetListByWhereExtend(where);
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Prod_Task> GetProdTaskByWhere(string filter)
        {
            string where = string.Format(" AND Task_Stat IN('{0}','{1}')  {2}", OperationTypeEnum.ProdTaskStatEnum.Deploying.ToString(), OperationTypeEnum.ProdTaskStatEnum.Planing.ToString(),filter);
            return Instance.GetListByWhereExtend(where);
        }

        public List<Prod_Task> GetProdTaskByWhereExtend(string filter)
        {
            string where = string.Format(" {0}",filter);
            return Instance.GetListByWhereExtend(where);
        }


        public List<Prod_Task> GetFinProdTaskByWhere(string filter)
        {
            string where = string.Format(" AND Task_Stat ='{0}'  {1}", OperationTypeEnum.ProdTaskStatEnum.Finish.ToString(), filter);
            return Instance.GetListByWhereExtend(where);
        }

        /// <summary>
        /// 获取已完成生产任务列表
        /// </summary>
        /// <returns></returns>
        public List<Prod_Task> GetFinProdTask()
        {
            string where = string.Format(" AND Task_Stat='{0}'", OperationTypeEnum.ProdTaskStatEnum.Finish.ToString());
            return Instance.GetListByWhere(where);
        }



        /// <summary>
        /// 下达部署生产任务
        /// </summary>
        /// <param name="ri">待生产的毛坯（其是下达生产任务的依据）</param>
        /// <param name="prodTask">待下达生产任务相关基本信息</param>
        /// <returns></returns>
        public int DeployProdTask(Raw_Inv rawInv, Prod_Task prodTask)
        {
            int flag = 0;

            Prod_CmdDetail pc = pcInstance.GetModel(string.Format(" AND Cmd_Code='{0}'",prodTask.TaskDetail_CmdCode));

            try
            {
                //Instance.idb.BeginTransaction();

                //riInstance.Instance.idb.BeginTransaction(Instance.idb.GetTransaction());

                prodTask.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Deploying.ToString();
                //下达任务数量  --》与生产命令所需数量 不一定相等
                //prodTask.TaskDetail_Num = pc.CmdDetail_Num;

                if (AddProdTask(prodTask) > 0)
                {
                    //下达任务成功后回写毛坯库存表
                    riInstance.DeployRawInv(rawInv.RI_Code, prodTask.TaskDetail_Num);
                    flag= 1;
                }

                //Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                Instance.idb.RollbackTransaction();
            }

            return flag;

        }

        public int AddProdTask(Prod_Task pt)
        {


            pt.Stat = 0;
            return Instance.Add(pt);
        }

        public string CreateProdTaskCode()
        {
            return new Bll_Comm().GenerateCode("Prod_Task");
            //int maxNum = ConvertX.ConvertObj2Int(Instance.GetMax("Task_ID"));

            //DateTime time = DateTime.Now;
            //string code = string.Format("RW{0}{1}{2}", time.Month, time.Day, maxNum + 1);
            //return code;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptList"></param>
        /// <returns>返回未能成功更新状态的ProdTask</returns>
        public List<Prod_Task> UpdateProdTaskListStat(List<Prod_Task> ptList)
        {
            List<Prod_Task> re = new List<Prod_Task>();
            foreach (Prod_Task pt in ptList)
            {
                if (UpdateProdTaskStat(pt) <= 0)
                {
                    re.Add(pt);
                }
             
            }
            return re;
        }

        public int UpdateProdTaskStat(Prod_Task pt)
        {
            return Update(pt);
        }

        public Prod_Task GetTaskByCode(string tCode)
        {
            string where = string.Format(" AND Task_Code='{0}'",tCode);

            List<Prod_Task> list = Instance.GetListByWhere(where);

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
        /// 下发生产计划
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>

        public int DeployPlanTask(Prod_Task pt,List<Prod_PlanProd> ppList)
        {
            pt.Task_Stat = OperationTypeEnum.ProdTaskStatEnum.Planing.ToString();
            return Instance.Update(pt);
        }

        public int Update(Prod_Task pt)
        {
            return Instance.Update(pt);
        }
    }
}
