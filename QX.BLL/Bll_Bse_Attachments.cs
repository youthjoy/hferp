using System;
using System.Collections.Generic;
using System.Text;

using QX.DataModel;
using QX.DataAceess;

namespace QX.BLL
{
    public class Bll_Bse_Attachments
    {
        public ADOBse_Attachments instance = new ADOBse_Attachments();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<Bse_Attachments> GetAll()
        {
            List<Bse_Attachments> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Bse_Attachments model)
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
        public Bse_Attachments GetModel(string strCondition)
        {
            List<Bse_Attachments> list = instance.GetListByWhere(strCondition);
            Bse_Attachments model = new Bse_Attachments();
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
        public bool Update(Bse_Attachments model)
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
            List<Bse_Attachments> list = instance.GetListByWhere(" AND AT_Name='" + Code + "'");
            if (list.Count > 0)
            {
                Bse_Attachments model = list[0];
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
