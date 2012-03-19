using System;
using System.Collections.Generic;
using System.Text;

namespace QX.Common.C_Class
{
    public enum PermissionModuleEnum
    { 
        /// <summary>
        /// 部门
        /// </summary>
        Dept,
        /// <summary>
        /// 人员
        /// </summary>
        Employee,
        /// <summary>
        /// 员工信息登记保存
        /// </summary>
        EmployeeExt,
        /// <summary>
        /// 设备
        /// </summary>
        DeviceOp,
        /// <summary>
        /// 库存
        /// </summary>
        Inv,
        /// <summary>
        /// 故障设备记录
        /// </summary>
        DeviceFailOp,
        /// <summary>
        /// 零件图号
        /// </summary>
        Components,
        /// <summary>
        /// 工艺节点
        /// </summary>
        RoadNode,
        /// <summary>
        /// 检测参数
        /// </summary>
        RoadTest,
        /// <summary>
        /// 合同
        /// </summary>
        Contract,
        /// <summary>
        /// 毛坯采购
        /// </summary>
        RawMain,
        /// <summary>
        /// 毛坯入库
        /// </summary>
        RawInv,
        /// <summary>
        /// 生产指令
        /// </summary>
        ProdCmd,
        /// <summary>
        /// 生产任务
        /// </summary>
        ProdTask,
        /// <summary>
        /// 生产计划
        /// </summary>
        ProdPlan,
        /// <summary>
        /// 生产进度
        /// </summary>
        ProdRecord,
        /// <summary>
        /// 终检
        /// </summary>
        LastCheck,
        /// <summary>
        /// 不合格品
        /// </summary>
        Failure,
        /// <summary>
        /// 外协
        /// </summary>
        FHelper,
        /// <summary>
        /// 客户反馈
        /// </summary>
        Feedback

    }
}
