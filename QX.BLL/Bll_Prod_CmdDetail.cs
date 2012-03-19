using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using System.Linq;

namespace QX.BLL
{
    public class Bll_Prod_CmdDetail
    {
        public ADOProd_CmdDetail instance = new ADOProd_CmdDetail();
        public ADOProd_Command cmdInstance = new ADOProd_Command();

        #region 零件编号维护

        private ADOProd_CodeMap pcmInstance = new ADOProd_CodeMap();

        public bool AddOrUpdateProdCode(string cmdCode, string detailCode, List<Prod_CodeMap> list)
        {
            List<Prod_CodeMap> oldList = GetMapList(cmdCode, detailCode);

            foreach (var n in oldList)
            {
                var temp = list.FirstOrDefault(o => o.PMap_Code == n.PMap_Code);

                if (temp != null)
                {
                    temp.PMap_ID = n.PMap_ID;
                    UpdateProdMap(temp);
                    list.Remove(temp);
                }
                else
                {
                    DeleteProdMap(n);
                }
            }

            foreach (var t in list)
            {
                t.PMap_Code = GenerateProdCode();
                AddProdMap(t);
            }

            return true;
        }

        public bool UpdateProdCodeStat(List<Prod_CodeMap> list)
        {
            foreach (var p in list)
            {
                pcmInstance.Update(p);
            }

            return true;
        }

        public void UpdateProdCodeMapStat(string cmdCode, string detailCode, List<Prod_PlanProd> list)
        {
            List<Prod_CodeMap> oldList = GetMapList(cmdCode, detailCode);
            foreach (var p in oldList)
            {
                var temp = list.FirstOrDefault(o => o.PlanProd_Code == p.PMap_PCode);
                if (temp != null)
                {
                    p.PMap_Stat = "Deploy";
                    UpdateProdMap(p);
                }
            }
        }

        public bool AddProdMap(Prod_CodeMap model)
        {
            if (pcmInstance.Add(model) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateProdMap(Prod_CodeMap model)
        {
            if (pcmInstance.Update(model) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteProdMap(Prod_CodeMap model)
        {
            model.Stat = 1;
            if (pcmInstance.Update(model) > 0)
            {
                return true;
            }
            return false;
        }

        public string GenerateProdCode()
        {
            return new Bll_Comm().GenerateCode("Prod_CodeMap");
        }

        /// <summary>
        /// 获取指令相关的零件编号
        /// </summary>
        /// <param name="cmdCode"></param>
        /// <param name="detailCode"></param>
        /// <returns></returns>
        public List<Prod_CodeMap> GetMapList(string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_Module='{0}' AND PMap_MCode='{1}'", cmdCode, detailCode);

            return pcmInstance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取与毛坯入库相关的数据
        /// </summary>
        /// <param name="cmdCode"></param>
        /// <param name="detailCode"></param>
        /// <returns></returns>
        public List<Prod_CodeMap> GetMapList(string rawcode,string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_RawMainCode='{2}' AND PMap_Module='{0}' AND PMap_MCode='{1}'", cmdCode, detailCode,rawcode);

            return pcmInstance.GetListByWhere(where);
        }


        /// <summary>
        /// 获取与毛坯入库相关的数据（为检验与未下达 零件编号）
        /// </summary>
        /// <param name="cmdCode"></param>
        /// <param name="detailCode"></param>
        /// <returns></returns>
        public List<Prod_CodeMap> GetMapListForValidate(string rawcode, string cmdCode, string detailCode)
        {
            string where = string.Format(" AND isnull(PMap_Stat,'')='' AND isnull(PMap_RawStat,'') not in ('In','') AND  PMap_RawMainCode='{2}' AND PMap_Module='{0}' AND PMap_MCode='{1}'", cmdCode, detailCode, rawcode);

            return pcmInstance.GetListByWhere(where);
        }

        public List<Prod_CodeMap> GetMapListForCheck(string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_Module='{0}' AND PMap_MCode='{1}' AND PMap_RawStat='Check' AND isnull(PMap_Stat,'')=''", cmdCode, detailCode);

            return pcmInstance.GetListByWhere(where);
        }

        public List<Prod_CodeMap> GetMapListForCheck(string rawcode,string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_RawMainCode ='{2}' AND PMap_Module='{0}' AND PMap_MCode='{1}' AND PMap_RawStat='Check' AND isnull(PMap_Stat,'')=''", cmdCode, detailCode,rawcode);

            return pcmInstance.GetListByWhere(where);
        }    

        public List<Prod_CodeMap> GetAllMapList(string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_Module<>'{0}'", cmdCode, detailCode);
            //string where = string.Format("");
            return pcmInstance.GetListByWhereExtend(where);
            //return pcmInstance.GetListByWhere(where);
        }

        public Prod_CodeMap GetPMapModel(string prodCode,string cmdcode)
        {
            string where = string.Format(" AND PMap_PCode='{0}' AND PMap_Module='{1}'",prodCode,cmdcode);
            var list= pcmInstance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            return null;
        }

        public List<Prod_CodeMap> GetMapListByTask(string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_Module='{0}' AND PMap_MCode='{1}' AND isnull(PMap_Stat,'')=''", cmdCode, detailCode);

            return pcmInstance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取待下达的零件编号（已有毛坯）
        /// </summary>
        /// <param name="cmdCode"></param>
        /// <param name="detailCode"></param>
        /// <returns></returns>
        public List<Prod_CodeMap> GetMapListByTaskForDeploy(string cmdCode, string detailCode)
        {
            string where = string.Format(" AND PMap_Module='{0}' AND PMap_MCode='{1}' AND isnull(PMap_Stat,'')='' AND (isnull(PMap_RawStat,'')='Check' OR isnull(PMap_RawStat,'')='In')", cmdCode, detailCode);

            return pcmInstance.GetListByWhere(where);
        }

 public List<Prod_CodeMap> GetMapListByTaskForDeploy(string cmdCode, string partno,string rawmaincode)
        {
            string where = string.Format(" AND PMap_Module='{0}' AND PMap_RawMainCode='{2}' AND PMap_MCode='{1}' AND isnull(PMap_Stat,'')='' AND (isnull(PMap_RawStat,'')='Check' OR isnull(PMap_RawStat,'')='In')", cmdCode, partno, rawmaincode);

            return pcmInstance.GetListByWhere(where);
        }


 public List<Prod_CodeMap> GetMapListByTaskForPlanDeploy(string cmdCode, string partno, string taskcode)
 {
     string where = string.Format(" AND PMap_Module='{0}' AND PMap_TaskCode='{2}' AND PMap_MCode='{1}' AND isnull(PMap_Stat,'')='' AND (isnull(PMap_RawStat,'')='Check' OR isnull(PMap_RawStat,'')='In')", cmdCode, partno, taskcode);

     return pcmInstance.GetListByWhere(where);
 }
        #endregion

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<Prod_CmdDetail> GetAll()
        {
            List<Prod_CmdDetail> list = instance.GetAll();
            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Prod_CmdDetail model)
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
        /// 插入数据 并返回数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public long InsertWithReturnId(Prod_CmdDetail model)
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
        public Prod_CmdDetail GetModel(string strCondition)
        {
            List<Prod_CmdDetail> list = instance.GetListByWhere(strCondition);
            Prod_CmdDetail model = new Prod_CmdDetail();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }


        /// <summary>
        /// 根据Key获取数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Prod_CmdDetail GetByKey(long Id)
        {
            Prod_CmdDetail model = new Prod_CmdDetail();
            model = instance.GetByKey(Id);
            return model;
        }

        public List<Prod_CmdDetail> GetByCommand(string CommandCode)
        {
            List<Prod_CmdDetail> mList = new List<Prod_CmdDetail>();
            mList = instance.GetListByWhere(string.Format(" and Cmd_Code='{0}'", CommandCode));
            return mList;
        }

        public List<Prod_CmdDetail> GetCmdDetailForContract(string bdate, string edate, string key)
        {
            List<Prod_CmdDetail> list = new List<Prod_CmdDetail>();
            string where = string.Format("AND (CreateTime between '{0}' and '{1}' OR CreateTime is null) AND (CmdDetail_PartNo like '%{2}%' OR Cmd_Code like '%{2}%')",bdate,edate,key);
            list = instance.GetListByWhere(where);
            return list;
        }

        public Prod_Command GetCommand(string code)
        {

            var mList = cmdInstance.GetListByWhere(string.Format(" and Cmd_Code='{0}'", code));
            return mList.FirstOrDefault();
        }

        public bool UpdateList(List<Prod_CmdDetail> cmdDetailList, Prod_Command command)
        {
            bool flag = true;

            List<Prod_CmdDetail> oldSIList = GetByCommand(command.Cmd_Code);

            try
            {
                foreach (Prod_CmdDetail r in oldSIList)
                {
                    var temp = cmdDetailList.FirstOrDefault(o => o.CmdDetail_ID == r.CmdDetail_ID);
                    //如果存在则更新
                    if (temp != null)
                    {
                        Update(temp);
                        cmdDetailList.Remove(temp);

                    }//不存在则删除
                    else
                    {
                        Delete(r);
                    }
                }

                foreach (Prod_CmdDetail detail in cmdDetailList)
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

        public bool AddCmdList(List<Prod_CmdDetail> cmdDetailList, Prod_Command command)
        {
            bool flag = true;

            List<Prod_CmdDetail> oldSIList = GetByCommand(command.Cmd_Code);

            try
            {
                foreach (Prod_CmdDetail r in oldSIList)
                {
                    var temp = cmdDetailList.FirstOrDefault(o => o.CmdDetail_ID == r.CmdDetail_ID);
                    //如果存在则更新
                    if (temp != null)
                    {
                        Update(temp);
                        cmdDetailList.Remove(temp);

                    }//不存在则删除
                    else
                    {
                        Delete(r);
                    }
                }

                foreach (Prod_CmdDetail detail in cmdDetailList)
                {
                    detail.CreateTime = DateTime.Now;
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

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Prod_CmdDetail model)
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
        public bool Delete(Prod_CmdDetail detail)
        {
            bool flag = false;
            detail.Stat = 1;
            if (instance.Update(detail) > 0)
            {
                flag = true;
            }

            return flag;
        }
        public void DeleteByCommandCode(string cmd_code)
        {
            List<Prod_CmdDetail> prodCmdDetailList = new List<Prod_CmdDetail>();
            prodCmdDetailList = instance.GetListByWhere(" and cmd_code='" + cmd_code + "'");
            foreach (Prod_CmdDetail detail in prodCmdDetailList)
            {
                detail.Stat = 1;
                Update(detail);
            }
        }
    }
}
