using System;
using System.Collections.Generic;
using System.Text;

namespace QX.Common.C_Class
{
    public class OperationTypeEnum
    {
        /// <summary>
        /// 设备状态
        /// </summary>
        public enum EquStat
        { 
            ENormal,
            EStop,
            ERepair,
            ETrash,
            EQuestion
        }

        /// <summary>
        /// 操作类型
        /// </summary>
        public enum OperationType
        { 
            /// <summary>
            /// 查看数据
            /// </summary>
            Look,
            /// <summary>
            /// 编辑
            /// </summary>
            Edit,
            /// <summary>
            /// 添加
            /// </summary>
            Add,
            /// <summary>
            /// 删除
            /// </summary>
            Delete,
            /// <summary>
            /// 查找
            /// </summary>
            Search,
            /// <summary>
            /// 复制
            /// </summary>
            Copy,
            /// <summary>
            /// 浏览数据,可编辑部分数据
            /// </summary>
            View
            
        }


        /// <summary>
        /// 产品库存状态
        /// </summary>
        public enum InvStatEnum
        {
            /// <summary>
            /// 待终检
            /// </summary>
            Testing,
            /// <summary>
            /// 成品（已入库）
            /// </summary>
            Prod,
            /// <summary>
            /// 待入库
            /// </summary>
            Entering,
            /// <summary>
            /// 已出库
            /// </summary>
            Outing,
            //不合格品
            InValid
        }

        /// <summary>
        /// 产品状态
        /// </summary>
        public enum ProdStatEnum
        { 
            /// <summary>
            /// 正常
            /// </summary>
            Normal,
            /// <summary>
            /// 次品
            /// </summary>
            Defective,
            /// <summary>
            /// 不合格品
            /// </summary>
            Unqualified,
            /// <summary>
            /// 终检
            /// </summary>
            Testing
        }


        public enum RawMainStatEnum
        { 
            /// <summary>
            /// 待收货（订单）
            /// </summary>
            PO,
            /// <summary>
            /// 已收货
            /// </summary>
            PI
        }

        /// <summary>
        /// 审核模块
        /// </summary>
        public enum AuditTemplateEnum
        { 
            /// <summary>
            /// 毛坯审核模板对应编码
            /// </summary>
            RawMain_M001,
            /// <summary>
            /// 零件工时审核模板对应编码
            /// </summary>
            Components_C001,
            // <summary>
            /// 退货单审核模板对应编码
            /// </summary>
            ReturnDoc_R001,
            /// <summary>
            /// 不合格品审理
            /// </summary>
            FailureAudit_F001,
            /// <summary>
            /// 客户反馈信息审理
            /// </summary>
            FeedbackAudit,
            /// <summary>
            /// 合同审核
            /// </summary>
            ContractAudit,
            /// <summary>
            /// 外协价格审核
            /// </summary>
            FHelperPriceAudit,
            /// <summary>
            /// 毛坯收货检验
            /// </summary>
            PIRawMain


        }

        /// <summary>
        /// 审核状态
        /// </summary>
        public enum AudtiOperaTypeEnum
        {
            /// <summary>
            /// 待审状态
            /// </summary>
            Auditing,
            /// <summary>
            /// 终审
            /// </summary>
            LastAudit,
    
            /// <summary>
            /// 审核进行中
            /// </summary>
            OnAudit,
            /// <summary>
            /// 废单
            /// </summary>
            Litter
        }

        public enum RoadHandlTypeEnum
        {
            ProdRoad,
            SRoad
        }

        public enum AudtiRecordsDataTypeEnum
        {
            /// <summary>
            /// 已审通过
            /// </summary>
            Audited,
            /// <summary>
            /// 驳回
            /// </summary>
            Reject,
            /// <summary>
            /// 终审
            /// </summary>
            LastAudit,

            /// <summary>
            /// 废单
            /// </summary>
            Litter
        }

        public enum FHelper_Stat
        { 
            /// <summary>
            /// 等待外协供应商确认
            /// </summary>
            ConfirmSup,
            /// <summary>
            /// 待出厂
            /// </summary>
            WaitOut,
            /// <summary>
            /// 待回厂
            /// </summary>
            WaitIn,
            /// <summary>
            /// 待检验
            /// </summary>
            WaitCheck,
            /// <summary>
            /// 已完成
            /// </summary>
            Done
        }

        public enum ProdTaskStatEnum
        { 
            /// <summary>
            /// 已下达
            /// </summary>
            Deploying,
            /// <summary>
            /// 已计划
            /// </summary>
            Planing,
            /// <summary>
            /// 已完成
            /// </summary>
            Finish
        }


        public enum ProdPlanStatEnum
        {
 
            /// <summary>
            /// 进行中
            /// </summary>
            Planing,
            /// <summary>
            /// 已完成
            /// </summary>
            Finish
        }

        public enum TableNameEnum
        {
            Road_Components
        }

        /// <summary>
        /// 数据状态
        /// </summary>
        public enum DataStatEnum
        {
            /// <summary>
            /// 删除状态
            /// </summary>
            Deleteed=1,
            /// <summary>
            /// 有效状态
            /// </summary>
            Enabled=0
        }

        /// <summary>
        /// 表关联数据
        /// </summary>
        public enum UserRelationDataType
        {
            /// <summary>
            /// 添加
            /// </summary>
            Insert,
            /// <summary>
            /// 修改
            /// </summary>
            Update,
            /// <summary>
            /// 删除
            /// </summary>
            Delete
        }


        public enum ProdKeyEnum
        { 
            /// <summary>
            /// 生产计划
            /// </summary>
            PL,
            /// <summary>
            /// 产品编号
            /// </summary>
            CP
        }

    }
}
