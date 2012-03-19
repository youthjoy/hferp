using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;

namespace QX.BLL
{
    public class Bll_VerifyProcess_Records
    {
        private ADOVerifyProcess_Records instance = new ADOVerifyProcess_Records();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<VerifyProcess_Records> GetAll()
        {
            List<VerifyProcess_Records> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(VerifyProcess_Records model)
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
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public VerifyProcess_Records GetModel(string strCondition)
        {
            List<VerifyProcess_Records> list = instance.GetListByWhere(strCondition);
            VerifyProcess_Records model = new VerifyProcess_Records();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }
        /// <summary>
        /// 检查审核记录是否存在
        /// </summary>
        /// <param name="templateKey">模块枚举</param>
        /// <param name="ProcessNode">阶段名称</param>
        /// <param name="UserId">用户ID</param>
        /// <param name="type">审核状态枚举</param>
        /// <returns></returns>
        public bool CheckRecordExist(OperationTypeEnum.AuditTemplateEnum templateKey, 
            string ProcessNode,
            string PorcessBusinessCode,
            string UserId, 
            OperationTypeEnum.AudtiRecordsDataTypeEnum type)
        {
            bool result = false;
            List<VerifyProcess_Records> list =  GetListBy(templateKey, ProcessNode,PorcessBusinessCode, UserId, type);
            if (list!=null && list.Count>0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据条件查找数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<VerifyProcess_Records> GetListBy(OperationTypeEnum.AuditTemplateEnum templateKey, string ProcessNode, OperationTypeEnum.AudtiRecordsDataTypeEnum type)
        {
            string filter = " AND VRecord_Key='" + templateKey.ToString() + "' AND VRecord_Code='" + ProcessNode + "' AND VRecord_Flag='" + type.ToString() + "'";
            List<VerifyProcess_Records> list = instance.GetListByWhere(filter);
            VerifyProcess_Records model = new VerifyProcess_Records();
            return list;
        }
        /// <summary>
        /// 根据条件查找数据
        /// </summary>
        /// <param name="templateKey"></param>
        /// <param name="ProcessNode"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<VerifyProcess_Records> GetListBy(OperationTypeEnum.AuditTemplateEnum templateKey, string ProcessNode,string PorcessBusinessCode, string UserId, OperationTypeEnum.AudtiRecordsDataTypeEnum type)
        {
            string filter = " AND VRecord_Key='" + templateKey.ToString() + "' AND VRecord_Code='" + ProcessNode + "' AND VRecord_Flag='" + type.ToString() + "' AND VRecord_Owner='" + UserId + "' AND VRecord_BusinessCode='" + PorcessBusinessCode + "' ";
            List<VerifyProcess_Records> list = instance.GetListByWhere(filter);
            VerifyProcess_Records model = new VerifyProcess_Records();
            return list;
        }
        /// <summary>
        ///  根据条件查找数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public List<VerifyProcess_Records> GetListBy(string strCondition)
        {
            List<VerifyProcess_Records> list = instance.GetListByWhere(strCondition);
            VerifyProcess_Records model = new VerifyProcess_Records();
            return list;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(VerifyProcess_Records model)
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
        public bool Delete(string key,string code)
        {
            bool result = false;
            List<VerifyProcess_Records> list = instance.GetListByWhere(" AND VRecord_Key='" + key + "' AND VRecord_Code='"+code+"' ");
            if (list.Count > 0)
            {
                VerifyProcess_Records model = list[0];
                model.Stat =(int)OperationTypeEnum.DataStatEnum.Deleteed;
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
