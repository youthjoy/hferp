using System;
using System.Collections.Generic;
using System.Text;

namespace QX.Common
{
    public enum LogModule
    {
        /// <summary>
        /// 登陆
        /// </summary>
        LoginModule,
        /// <summary>
        /// 图号模板
        /// </summary>
        Components,
        /// <summary>
        /// 生产记录
        /// </summary>
        ProdRecordModule,
        /// <summary>
        /// 生产任务
        /// </summary>
        ProdTask,
        /// <summary>
        /// 生产指令
        /// </summary>
        ProdCmd,
        /// <summary>
        /// 毛坯
        /// </summary>
        Raw,
        /// <summary>
        /// 不合格品
        /// </summary>
        Failure,
        /// <summary>
        /// 外协
        /// </summary>
        FHelper,
        /// <summary>
        /// 合同
        /// </summary>
        Contract,
        /// <summary>
        /// 员工信息维护
        /// </summary>
        Employee,
        /// <summary>
        /// 部门信息
        /// </summary>
        Dept,
        /// <summary>
        /// 生产计划
        /// </summary>
        ProdPlan
    }

    public enum LogType
    {
        Edit,
        Add,
        Delete,
        Login,
        Audit,
        Copy,
    }

    public class MessageContent
    {

        private static MessageContent instance;

        private MessageContent()
        {

        }

        public static MessageContent GetInstance()
        {
            if (instance == null)
            {
                instance = new MessageContent();
            }
            return instance;
        }

        public string Employee
        {
            get { return "员工信息维护"; }
        }

        public string Dept
        {
            get { return "部门信息维护"; }
        }

        public string Components
        {
            get { return "零件图号模板维护"; }
        }

        public string Contract
        {
            get { return "合同维护"; }
        }

        public string ContractTrace
        {
            get { return "合同跟踪信息维护"; }
        }

        public string ContractProdRelation
        {
            get { return "合同关联指令及零件编号"; }
        }
        public string ContractProdOpen
        {
            get { return "开票"; }
        }
        public string ProdCmd
        {
            get { return "生产指令维护"; }
        }

        public string ProdCodeCmd
        {
            get { return "指令关联零件编号"; }
        }


        public string RawIn
        {
            get { return "毛坯入库"; }
        }

        public string RawProdCode
        {
            get { return "毛坯关联零件编号"; }
        }

        public string ProdTask
        {
            get { return "生产任务下达"; }
        }

        public string RollbackProdTask
        {
            get { return "生产任务回滚"; }
        }

        public string RollbackRawInv
        {
            get { return "毛坯库存回滚"; }
        }

        public string ProdPlan
        {
            get { return "生产计划下达"; }
        }

        public string ProdPlanFin
        {
            get { return "批量完工"; }
        }

        public string RollbackProd
        {
            get { return "撤销计划"; }
        }

        public string Failure
        {
            get { return "不合格单据维护"; }
        }

        public string FailureReturn
        {
            get { return "零件回用"; }
        }

        public string FailureChange
        {
            get { return "零件状态扭转"; }
        }

        public string BatchProdInfo
        {
            get { return "批量生产信息录入"; }
        }

        public string BatchProdNode
        {
            get { return "批量节点信息录入"; }
        }

        public string BatchFHelper
        {
            get { return "批量外协"; }
        }
    }
}
