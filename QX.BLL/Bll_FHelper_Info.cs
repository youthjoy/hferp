using System;
using System.Collections.Generic;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;
using QX.Common.C_Class;
using QX.DataAcess;


namespace QX.BLL
{
    public class Bll_FHelper_Info
    {
        internal ADOFHelper_Info instance = new ADOFHelper_Info();

        private Bll_FHelper_Price pInstance = new Bll_FHelper_Price();
        
        private GetMaxHandler handler;

        public Bll_FHelper_Info()
        {
            handler = new GetMaxHandler();
        }

        public List<FHelper_Info> GetFHelperOutingList()
        {
            string where = string.Format(" AND FHelperInfo_Stat='{0}'",OperationTypeEnum.FHelper_Stat.WaitOut.ToString());

            return instance.GetListByWhere(where);
        }

        public List<FHelper_Info> GetFHelperList(string condition)
        {
            return instance.GetListByWhere(condition);
        }


        /// <summary>
        /// 处理外协出厂信息（进入价格审核、或可以出厂）
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public FHelper_Info HandingInfo(FHelper_Info info)
        {
            FHelper_Price price= pInstance.GetFHelperPrice(info.FHelperInfo_FSup, info.FHelperInfo_PartCode, info.FHelperInfo_RoadNodes);
            if (price != null)
            {
                info.FHelperInfo_Price = (int)price.FP_Price;
            }
            else
            { 
                //info.FHelperInfo_Stat = OperationTypeEnum.FHelper_Stat.PriceAudit.ToString();
                
                FHelper_Price newPrice = new FHelper_Price();
                //newPrice.FP_Code = pInstance.GenerateFPCode();
                //newPrice.FP_Creatime = DateTime.Now;
                //newPrice.FP_Creator = GlobalConfiguration.UserName;

                //newPrice.FP_ManuCode=info.FHelperInfo_FSup;
                //newPrice.FP_ManuName = info.FHelperInfo_FSupName;

                //newPrice.FP_PNodeCode = info.FHelperInfo_RoadNodes;
                //newPrice.FP_NodeName = info.FHelperInfo_RoadNodeName;
                ////产品编码
                //newPrice.FP_RefComptCode = info.FHelperInfo_ProdCode;
                ////零件图号
                //newPrice.FP_CompCode = info.FHelperInfo_PartCode;
                
                //newPrice.FP_Stat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

                pInstance.Insert(newPrice);
            }


            instance.Update(info);

            return info;
        }


        public string GenerateCode()
        {
            return new Bll_Comm().GenerateCode("FHelper_Info");
            //int maxNum = ConvertX.ConvertObj2Int(handler.GetMax("FHelperInfo_ID","FHelper_Info" ));

            //DateTime time = DateTime.Now;
            //string code = string.Format("FH{0}{1}{2}", time.Month, time.Day, maxNum + 1);
            //return code;
        }


        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(FHelper_Info model)
        {
            bool result = false;
            try
            {
                int _result = instance.Add(model);
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
        public FHelper_Info GetModel(string strCondition)
        {
            List<FHelper_Info> list = instance.GetListByWhere(strCondition);
            FHelper_Info model = new FHelper_Info();
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
        public bool Update(FHelper_Info model)
        {
            bool result = false;
            int _rseult = instance.Update(model);
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
        public bool Delete(string Code)
        {
            bool result = false;
            List<FHelper_Info> list = instance.GetListByWhere(" AND FHelperInfo_Code='" + Code + "'");
            if (list.Count > 0)
            {
                FHelper_Info model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
