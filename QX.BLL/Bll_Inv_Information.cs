using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.Common.C_Class;
using System.Linq;
using QX.Shared;
namespace QX.BLL
{



    public class Bll_Inv_Information
    {
        private DataAceess.ADOInv_Information _Instance;

        private DataAceess.ADOInv_Movement mvInstance = new QX.DataAceess.ADOInv_Movement();

        public DataAceess.ADOInv_Information Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QX.DataAceess.ADOInv_Information();
                    return _Instance;
                }
                return _Instance;
            }
        }

        public Bll_Inv_Information()
        {


        }

        /// <summary>
        /// 获取库存零件列表（Road_Components做连接库存信息表  以零件图号为左连接）
        /// </summary>
        /// <returns></returns>
        public List<Inv_Information> GetInvInfoListForCompt()
        {
            //string where = string.Format(" AND IInfor_ProdType={0}",(int)prodType);
            string where = string.Empty;
            //where = string.Format(" AND IInfor_Stat='{0}'", ProdStatEnum.Prod.ToString());
            return Instance.GetListByWhereExtend(where);
        }

        /// <summary>
        /// 获取库存零件列表（Road_Components做连接库存信息表）--
        /// </summary>
        /// <returns></returns>
        public List<Inv_Information> GetInvInfoList()
        {
            //string where = string.Format(" AND IInfor_ProdType={0}",(int)prodType);
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}'", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString());
            return Instance.GetListByWhere(where);
        }
        /// <summary>
        /// 根据条件模糊匹配获取库存数据列表
        /// </summary>
        /// <param name="prodType"></param>
        /// <param name="invNo"></param>
        /// <returns></returns>
        public List<Inv_Information> GetInvInfoListByWhere(string fitler)
        {
            //string where = string.Format(" AND IInfor_ProdType={0}",(int)prodType);
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}' {1}", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString(), fitler);
            return Instance.GetListByWhere(where);
        }


        /// <summary>
        /// 获取待出库零件列表（Road_Components做连接库存信息表）--
        /// </summary>
        /// <returns></returns>
        public List<Inv_Information> GetOutingInvInfoList()
        {
            //string where = string.Format(" AND IInfor_ProdType={0}",(int)prodType);
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}'", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString());
            return Instance.GetInvListByWhere(where);
        }

        public List<Inv_Information> GetOutInvInfoListFor()
        {
            //string where = string.Format(" AND IInfor_ProdType={0}",(int)prodType);
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}'", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString());
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取已入库历史记录
        /// </summary>
        /// <returns></returns>
        public List<Inv_Information> GetInHisInvList()
        {
            string where = string.Empty;
            where = string.Format("and iinfor_stat in ('Prod','Outing') and iinfor_plancode in (select planprod_plancode from prod_planprod where isnull(stat,0)=0) AND isnull(IINfor_InDate,'')<>''");
            return Instance.GetInvListByWhere(where);
        }

        /// <summary>
        /// 根据条件过滤已入库数据
        /// </summary>
        /// <returns></returns>
        public List<Inv_Information> GetInHisInvListByWhere(string filter)
        {
            string where = string.Empty;
            where = string.Format(" AND isnull(IINfor_InDate,'')<>'' {0}",filter);
            return Instance.GetInvListByWhere(where);
        }

        public List<Inv_Information> GetOutingInvInfoListByWhere(string filter)
        {
            //string where = string.Format(" AND IInfor_ProdType={0}",(int)prodType);
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}' {1}", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString(), filter);
            return Instance.GetInvListByWhere(where);
        }


        /// <summary>
        /// 获取某零件库存信息
        /// </summary>
        /// <param name="code">库存零件编号</param>
        /// <returns></returns>
        public Inv_Information GetInvInfoByCode(string code)
        {
            string where = string.Empty;
            where = string.Format(" AND IInfor_ProdCode='{0}'", code);
            List<Inv_Information> list = Instance.GetListByWhere(where);
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
        /// 获取某零件图号对应的库存信息列表(成品)
        /// </summary>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        public List<Inv_Information> GetInvInfoListByComptCode(string comptCode)
        {
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{1}'  AND IInfor_PartNo='{0}'", comptCode, QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString());
            List<Inv_Information> list = Instance.GetInvListByWhere(where);
            return list;
        }



        /// <summary>
        /// 获取某零件图号对应待入库的零件列表
        /// </summary>
        /// <param name="prodStat"></param>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        public List<Inv_Information> GetEnteringInvInfoListByComptCode(string comptCode)
        {
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}' AND IInfor_PartNo='{1}'", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Entering.ToString(), comptCode);
            List<Inv_Information> list = Instance.GetInvListByWhere(where);
            return list;
        }


        /// <summary>
        /// 获取某零件图号对应待入库的零件列表
        /// </summary>
        /// <param name="prodStat"></param>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        public List<Inv_Information> GetEnteringInvInfoList()
        {
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}' ", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Entering.ToString());
            List<Inv_Information> list = Instance.GetInvListByWhere(where);
            return list;
        }

        /// <summary>
        /// 获取待终审产品列表
        /// </summary>
        /// <param name="prodStat"></param>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        public List<Inv_Information> GetLastCheckInvInfoList()
        {
            string where = string.Empty;
            where = string.Format(" AND IInfor_Stat='{0}' ", QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Testing.ToString());
            List<Inv_Information> list = Instance.GetInvListByWhere(where);
            return list;
        }

        /// <summary>
        /// 根据零件编号获取对应库存信息（零件编号在库存表中唯一）
        /// </summary>
        /// <param name="prodCode"></param>
        /// <returns></returns>
        public Inv_Information GetInvByProdCode(Prod_Roads pr)
        {

            string strCondition = string.Format(" AND IInfor_PlanCode='{0}'", pr.PRoad_PlanCode);
            List<Inv_Information> list = Instance.GetListByWhere(strCondition);
            Inv_Information model = new Inv_Information();
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
        /// 根据零件编号获取对应库存信息（零件编号在库存表中唯一）
        /// </summary>
        /// <param name="prodCode"></param>
        /// <returns></returns>
        public Inv_Information GetInvByPlanCode(string plancode)
        {

            string strCondition = string.Format(" AND IInfor_PlanCode='{0}'", plancode);
            List<Inv_Information> list = Instance.GetListByWhere(strCondition);
            Inv_Information model = new Inv_Information();
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

        public Inv_Information GetInvByProdCode(string cmd,string pcode)
        {

            string strCondition = string.Format(" AND IInfor_ProdCode='{0}' AND IInfor_CmdCode='{1}'", pcode, cmd);
            List<Inv_Information> list = Instance.GetListByWhere(strCondition);
            Inv_Information model = new Inv_Information();
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


        public List<Inv_Information> GetInvByTaskCode(string taskCode, string stat)
        {
            string where = string.Format(" AND IInfor_TaskCode='{0}' AND IInfor_Stat in ({1}) AND IInfor_ProdStat='{2}' "
                , taskCode, stat
                , QX.Common.C_Class.OperationTypeEnum.ProdStatEnum.Normal
                );
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 添加库存信息
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public int AddInv(Inv_Information iInfo)
        {
            return Instance.Add(iInfo);
        }

        #region 出库

        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public int UpdateInvInfoForList(Dictionary<int, string> list)
        {
            foreach (KeyValuePair<int, string> kv in list)
            {
                Inv_Information inv = this.GetInvInfoByCode(kv.Value);

                UpdateInvInfo(inv);
            }

            return 1;
        }


        /// <summary>
        /// 出库
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public string UpdateInvInfoForList(List<Inv_Information> list, string opUser, DateTime opDate)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var inv in list)
            {
                //Inv_Information inv = this.GetInvInfoByCode(kv.Value);

                inv.IInfor_Num = 1;
                inv.IInfor_Stat = OperationTypeEnum.InvStatEnum.Outing.ToString();
                inv.IInfor_OutDate = opDate;
                inv.IInfor_OutPep = opUser;
                
                //如果出库失败则记录失败编号
                if (UpdateInvInfo(inv) <= 0)
                {
                    sb.AppendLine(inv.IInfor_ProdCode);
                }
            }

            return sb.ToString();
        }


        /// <summary>
        /// 更新库存信息（更新库存信息表，添加库存移动信息表（出库）
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public int UpdateInvInfo(Inv_Information iInfo)
        {

            iInfo.IInfor_Num = iInfo.IInfor_Num == 0 ? 0 : iInfo.IInfor_Num - 1;

            iInfo.IInfor_Stat = QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Outing.ToString();


            //两个表(移动 和 信息表)信息的更新
            Inv_Movement mv = new Inv_Movement();

            mv.MV_Code = GenerateMovCode();
            mv.MV_PartNo = iInfo.IInfor_PartNo;
            mv.MV_PartName = iInfo.IInfor_PartName;
            mv.MV_ProdCode = iInfo.IInfor_ProdCode;
            mv.MV_Owner = iInfo.IInfor_OutPep;
            mv.MV_Date = iInfo.IInfor_OutDate;
            mv.MV_Type = OperationTypeEnum.InvStatEnum.Outing.ToString();
            //增加一条产品移动信息
            int re1 = mvInstance.Add(mv);
            //更新库存信息表记录
            int re2 = Instance.Update(iInfo);

            if (re1 > 0 && re2 > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region 入库
        /// <summary>
        /// 更新库存信息
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public int AddInvInfoForList(List<Inv_Information> list)
        {
            foreach (var  kv in list)
            {
                //Inv_Information inv = this.GetInvInfoByCode(kv.Value);
                kv.IInfor_Num = 1;
                InventoryInvInfo(kv);
            }

            return 1;
        }

        /// <summary>
        /// 入库操作
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public int InventoryInvInfo(Inv_Information iInfo)
        {
            iInfo.IInfor_Num = 1;
            iInfo.IInfor_Stat = QX.Common.C_Class.OperationTypeEnum.InvStatEnum.Prod.ToString();
            //入库时间--》编制时间
            iInfo.IInfor_InDate = DateTime.Now;
            //用户编码
            //iInfo.IInfor_InConfirm = SessionConfig.UserCode;
            //iInfo.IInfor_InDate = DateTime.Now;

            //两个表(移动 和 信息表)信息的更新
            Inv_Movement mv = new Inv_Movement();
            mv.MV_Code = GenerateMovCode();
            mv.MV_PartNo = iInfo.IInfor_PartNo;
            mv.MV_PartName = iInfo.IInfor_PartName;
            mv.MV_ProdCode = iInfo.IInfor_ProdCode;
            mv.MV_Owner = iInfo.IInfor_InPep;
            mv.MV_Date = iInfo.IInfor_InDate;

            mv.CreateTime = DateTime.Now;
            mv.UpdateTime = DateTime.Now;
            mv.MV_Type = OperationTypeEnum.InvStatEnum.Prod.ToString();
            //增加一条产品移动信息
            int re1 = mvInstance.Add(mv);
            //更新库存信息表记录
            int re2 = Instance.Update(iInfo);

            if (re1 > 0 && re2 > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public string GenerateMovCode()
        {
            return new Bll_Comm().GenerateCode("Inv_Movement");
        }
        #endregion

        /// <summary>
        /// 新增库存信息（虚拟库存）
        /// </summary>
        /// <param name="planProd">计划生产的零件</param>
        /// <returns></returns>
        public string AddInventoryInfor(Prod_PlanProd planProd, List<Road_Nodes> nodeslist)
        {
            Inv_Information inv = new Inv_Information();
            inv.IInfor_ProdCode = planProd.PlanProd_Code;
            inv.IInfor_PartNo = planProd.PlanProd_PartNo;
            inv.IInfor_PartName = planProd.PlanProd_PartName;
            inv.IInfor_PlanBegin = planProd.PlanProd_Begin;
            inv.IInfor_PlanEnd = planProd.PlanProd_End;
            //计划编码
            inv.IInfor_PlanCode = planProd.PlanProd_PlanCode;
            //指令编码
            inv.IInfor_CmdCode = planProd.PlanProd_CmdCode;
            inv.IInfor_ProdStat = OperationTypeEnum.ProdStatEnum.Normal.ToString();
            //任务编码
            inv.IInfor_TaskCode = planProd.PlanProd_TaskCode;

            inv.IInfor_Num = 1;
            inv.CreateTime = DateTime.Now;

            if (nodeslist != null && nodeslist.Count > 0)
            {
                //var temp = nodeslist.OrderBy(o => o.RNodes_Order);
                inv.IInfor_Stat = nodeslist[0].RNodes_Code;
            }
            //实际完成时间  库存状态  编制人等信息之后实时更新

            //仅添加一条虚拟库存记录，不做出入库操作
            Instance.Add(inv);

            return inv.IInfor_ProdCode;
        }


        public bool Update(Inv_Information inv)
        {
            if (Instance.Update(inv) > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public string CreateInvCode()
        {

            int maxNum = ConvertX.ConvertObj2Int(Instance.GetMax("IInfor_ID"));

            DateTime time = DateTime.Now;
            string code = string.Format("{0}{1}{2}{3}", OperationTypeEnum.ProdKeyEnum.CP.ToString(), time.Month, time.Day, maxNum + 1);
            return code;
        }

        /// <summary>
        /// 逻辑删除库存信息
        /// </summary>
        /// <param name="iInfo"></param>
        /// <returns></returns>
        public int DeleteInvInfo(Inv_Information iInfo)
        {
            iInfo.Stat = 1;
            return Instance.Update(iInfo);
        }

    }
}
