using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QX.DataModel;
using QX.DataAceess;
using QX.Shared;
using System.Data;

namespace QX.BLL
{
    public class Bll_Raw_Detail
    {
        public ADORaw_Detail instance = new ADORaw_Detail();

        public Bll_Raw_Inv rnvInstance = new Bll_Raw_Inv();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<Raw_Detail> GetAll()
        {
            List<Raw_Detail> list = instance.GetAll();
            return list;
        }

        public DataTable GetDataForExport(List<Raw_Main> list)
        {
            StringBuilder sbDetail = new StringBuilder();
            StringBuilder sb = new StringBuilder();
            sb.Append(" AND  rm.rawmain_code in (");
            foreach (var s in list)
            {
                sbDetail.AppendFormat("'{0}',", s.RawMain_Code);
            }
            sb.Append(sbDetail.ToString().TrimEnd(','));
            sb.Append(")");
            string sql = string.Format("select * from raw_main rm,raw_detail rd where rm.rawmain_code=rd.rawmain_code and isnull(rm.stat,0)=0 and isnull(rd.stat,0)=0 {0}",sb.ToString());
            return new Bll_Comm().ListViewData(sql);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Raw_Detail model)
        {
            bool result = false;
            model.CreateTime = DateTime.Now;
            model.RDetail_OwnDate = DateTime.Now;
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
        public Raw_Detail GetModel(string strCondition)
        {
            List<Raw_Detail> list = instance.GetListByWhere(strCondition);
            Raw_Detail model = new Raw_Detail();
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
        /// 逻辑删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(string Code)
        {
            bool result = false;
            List<Raw_Detail> list = instance.GetListByWhere(" AND RDetail_Code='" + Code + "'");
            if (list.Count > 0)
            {
                Raw_Detail model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        public string GenerateRawDetailCode()
        {
            return new Bll_Comm().GenerateCode("RawDetail");
        }


        /// <summary>
        /// 根据主表编码获取明细
        /// </summary>
        /// <param name="MainCode"></param>
        /// <returns></returns>
        public List<Raw_Detail> GetByRawMainCode(string mainCode)
        {
            List<Raw_Detail> mList = new List<Raw_Detail>();
            mList = instance.GetListByWhere(string.Format(" and RawMain_Code='{0}'", mainCode));
            return mList;
        }

        public bool UpdateList(List<Raw_Detail> rawDetailList, Raw_Main main)
        {
            bool flag = true;

            List<Raw_Detail> oldSIList = GetByRawMainCode(main.RawMain_Code);

            try
            {
                foreach (Raw_Detail r in oldSIList)
                {
                    var temp = rawDetailList.FirstOrDefault(o => o.RDetail_ID == r.RDetail_ID);
                    //如果存在则更新
                    if (temp != null)
                    {
                        Update(temp);
                        rawDetailList.Remove(temp);

                    }//不存在则删除
                    else
                    {
                        Delete(temp);
                    }
                }

                foreach (Raw_Detail detail in rawDetailList)
                {
                    //如果有编码生成，则在此处完成
                    instance.Add(detail);
                }
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool UpdateDetailAndInv(List<Raw_Detail> rawDetailList, Raw_Main main)
        {
            bool flag = true;

            List<Raw_Detail> oldSIList = GetByRawMainCode(main.RawMain_Code);

            try
            {
                foreach (Raw_Detail r in oldSIList)
                {
                    var temp = rawDetailList.FirstOrDefault(o => o.RDetail_ID == r.RDetail_ID);
                    //如果存在则更新
                    if (temp != null)
                    {
                        Update(temp);
                        rawDetailList.Remove(temp);

                    }//不存在则删除
                    else
                    {
                        Delete(r);
                    }
                }

                foreach (Raw_Detail detail in rawDetailList)
                {
                    //采购的毛坯数量
                    int num= detail.RDetail_Num;
                    detail.RawMain_Code = main.RawMain_Code;
                    detail.RDetail_OwnDate = DateTime.Now;
                    detail.CreateTime = DateTime.Now;
                    //如果有编码生成，则在此处完成
                    var re=instance.Add(detail);
                }
            }
            catch(Exception e)
            {
                flag = false;
            }
            return flag;
        }


        public bool Delete(Raw_Detail detail)
        {
            bool flag = false;
            detail.Stat = 1;
            if (instance.Update(detail) > 0)
            {
                flag = true;
            }

            return flag;
        }
        public bool Update(Raw_Detail model)
        {
            bool result = false;
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
