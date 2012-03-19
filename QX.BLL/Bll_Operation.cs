using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DataAcess;
using QX.DataModel;
using QX.DataAceess;

namespace QX.BLL
{
    public enum OpLogTypeEnum
    {
        /// <summary>
        /// 零件维护
        /// </summary>
        Comp,
    }

    public class Bll_Operation
    {
        /// <summary>
        /// 写操作日志
        /// </summary>
        /// <param name="module"></param>
        /// <param name="optor"></param>
        /// <param name="content"></param>
        public void WriteLog(string module, string optor, OpLogTypeEnum type, string content)
        {
            ADOBse_OpLog logInst = new ADOBse_OpLog();

            Bse_OpLog log = new Bse_OpLog();
            log.BOL_Code = GenerateLogCode();
            log.BOL_Module = module;
            log.BOL_Date = DateTime.Now;
            log.BOL_Operator = optor;
            log.BOL_Type = type.ToString();
            log.BOL_Operation = content;

            logInst.Add(log);
        }

        public string GenerateLogCode()
        {
            return new Bll_Comm().GenerateCode("Bse_OpLog");
        }

        private ADOBse_OpLog opLog = new ADOBse_OpLog();

        /// <summary>
        /// 获取操作日志列表
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public List<Bse_OpLog> GetOpLog(string module)
        {

            string where = string.Format(" AND BOL_Module='{0}'", module);
            List<Bse_OpLog> list = opLog.GetListByWhere(where);
            return list;
        }
    }
}
