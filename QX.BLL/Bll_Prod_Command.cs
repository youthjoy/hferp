using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;

namespace QX.BLL
{
    public class Bll_Prod_Command
    {
        public ADOProd_Command instance = new ADOProd_Command();

        private ADOProd_CodeMap pcInstance = new ADOProd_CodeMap();


        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<Prod_Command> GetAll()
        {
            string where = string.Format(" order by Cmd_ID ");
            List<Prod_Command> list = instance.GetListByWhere(where);
            return list;
        }

        public bool DeleteCodeMapByCommand(string cmd)
        {
            //List<Prod_CodeMap> list = new List<Prod_CodeMap>();
            string where = string.Format(" AND PMap_Module='{0}'",cmd);
            List<Prod_CodeMap> list = pcInstance.GetListByWhere(where);
            foreach (var p in list)
            {
                p.Stat = 1;
                pcInstance.Update(p);
            }

            return true;
        }

        public List<Prod_Command> GetCmdListByWhere()
        {
            string where = string.Format(" order by Cmd_ID ");
            List<Prod_Command> list = instance.GetListByWhere(where);
            return list;
        }

        /// <summary>
        /// 获取购成品的信息
        /// </summary>
        /// <returns></returns>
        public List<Prod_Command> GetProdCmd()
        {
            string where = string.Format(" AND Cmd_Udef2='{0}'", OperationTypeEnum.RoadHandlTypeEnum.ProdRoad);

            List<Prod_Command> list = instance.GetListByWhere(where);

            return list;
        }

        public List<Prod_Command> GetListByWhere(string filter)
        {
            string where = string.Format(" AND (Cmd_Bak like '%{0}%' OR Cmd_Code like '%{0}%' OR Cmd_Dep_Name like '%{0}%' OR Cmd_Supplier  like '%{0}%' ) ", filter);
            List<Prod_Command> list = instance.GetListByWhere(where);
            return list;
        }


        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Prod_Command model)
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
            }
            return result;
        }

        /// <summary>
        /// 插入数据 并返回数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public long InsertWithReturnId(Prod_Command model)
        {
            long result = 0;
            object _result = instance.AddWithReturn(model);
            if (_result != null)
            {
                long.TryParse(_result.ToString(), out result);
            }
            return result;
        }

        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public Prod_Command GetModel(string strCondition)
        {
            List<Prod_Command> list = instance.GetListByWhere(strCondition);
            Prod_Command model = new Prod_Command();
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
        public bool Update(Prod_Command model)
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
            List<Prod_Command> list = instance.GetListByWhere(" AND Cmd_Code='" + Code + "'");
            if (list.Count > 0)
            {
                Prod_Command model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                    Bll_Prod_CmdDetail detailInstance = new Bll_Prod_CmdDetail();
                    detailInstance.DeleteByCommandCode(Code);
                }
            }
            return result;
        }
        /// <summary>
        /// 根据Key获取数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Prod_Command GetByKey(long Id)
        {
            Prod_Command model = new Prod_Command();
            model = instance.GetByKey(Id);
            return model;
        }
        public string GenerateCommandCode()
        {
            return new Bll_Comm().GenerateCode("ProdCommand");
        }
    }
}
