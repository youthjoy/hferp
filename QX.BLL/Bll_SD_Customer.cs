using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;

namespace QX.BLL
{
    public class Bll_SD_Customer
    {
        private ADOSD_Customer instance = new ADOSD_Customer();

        /// <summary>
        /// 获取所有的客户信息
        /// </summary>
        /// <returns></returns>
        public List<SD_Customer> GetAll()
        {
            List<SD_Customer> list = instance.GetAll();
            return list;
        }


        public List<SD_Customer> GetCustomerByType(string type)
        {
            List<SD_Customer> list = new List<SD_Customer>();
            string where = string.Format(" AND Cust_Type='{0}'",type);
            list = instance.GetListByWhere(where);
            return list;
        }
        public List<SD_Customer> GetCustomerByWhere(string filter)
        {
            List<SD_Customer> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(SD_Customer model)
        {
            bool result = false;
            int _result = instance.Add(model);
            if (_result > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 生成客户编码
        /// </summary>
        /// <returns></returns>
        public string GenerateCustCode()
        {
            return new Bll_Comm().GenerateCode("SD_Customer");
        }

        public bool CreateToSup(SD_Customer cust)
        {
            if (instance.Add(cust) > 0)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public SD_Customer GetModel(string strCondition)
        {
            List<SD_Customer> list = instance.GetListByWhere(strCondition);
            SD_Customer model = new SD_Customer();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(SD_Customer model)
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
            List<SD_Customer> list = instance.GetListByWhere(" AND Cust_Code='" + Code + "'");
            if (list.Count > 0)
            {
                SD_Customer model = list[0];
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
