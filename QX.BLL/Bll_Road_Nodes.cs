using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAceess;
using QX.Common.C_Class;
using System.Linq;
using QX.Shared;
namespace QX.BLL
{
    public class Bll_Road_Nodes
    {
        public DataAceess.ADORoad_Nodes Instance = new QX.DataAceess.ADORoad_Nodes();
        private Bll_Road_Components rcInstance = new Bll_Road_Components();

        private Bll_Bse_Dict dcInstance = new Bll_Bse_Dict();



        private DataAceess.ADORoad_TestRef RtInstance;

        public Bll_Road_Nodes()
        {

            RtInstance = new ADORoad_TestRef();

            RtInstance.idb.SetConnection(Instance.idb.GetConnection());
        }

        public List<Road_Nodes> GetNodeListForBatchPrice(string comp, string node)
        { 
            return Instance.GetListByWhere(string.Format("AND RNodes_PartCode like '%{0}%' AND RNodes_Name like '%{1}%'",comp,node));
        }

        public bool BatchUpdateNodes(List<Road_Nodes> list)
        {
            foreach (var d in list)
            {
               // d.RNodes_Udef3 +=DateTime.Now.ToString("yyyy-MM-dd")+"  "+SessionConfig.EmpName+" 批量调整价格";
                Instance.Update(d);
            }

            return true;
        }

        public List<Road_Nodes> GetAll()
        {
            return Instance.GetAll();
        }

        /// <summary>
        ///  零件图号列表
        /// </summary>
        /// <returns></returns>
        public List<Road_Nodes> GetPageList()
        {
            return Instance.GetAll();
        }

        /// <summary>
        /// 获取零件图号对应的工艺节点路线列表
        /// </summary>
        /// <param name="comptCode"></param>
        /// <returns></returns>
        public List<Road_Nodes> GetRoadNodesByComponents(string comptCode)
        {
            StringBuilder sb = new StringBuilder();
            string whereSql = string.Format(" AND RNodes_PartCode='{0}' Order by RNodes_Order ASC", comptCode);
            return Instance.GetListByWhere(whereSql);
        }

        public List<Road_Nodes> GetRoadNodesList()
        {
            return Instance.GetListByWhere(string.Format("AND RNodes_PartCode in (select Comp_Code from road_components where  AuditStat='{0}') order by rnodes_partcode,rnodes_order", OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString()));
        }

        /// <summary>
        /// 根据Code获取对应实体
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Road_Nodes GetRoadNodeByCode(string comptCode, string RNodes_Code)
        {
            string where = string.Empty;
            where = string.Format("AND RNodes_PartCode='{0}'  AND RNodes_Code='{1}'", comptCode, RNodes_Code);
            List<Road_Nodes> list = Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public int UpdateDept(string comptCode, string nodeCode, string deptCode, string deptName)
        {
            Road_Nodes rn = this.GetRoadNodeByCode(comptCode, nodeCode);
            rn.RNodes_Dept_Code = deptCode;
            rn.RNodes_Dept_Name = deptName;

            return this.UpdateRoadCompt(rn);
        }

        /// <summary>
        /// 添加或更新工艺节点列表信息
        /// </summary>
        /// <param name="comptCode">零件图号</param>
        /// <param name="nodeDict">Key-工艺节点编码 value-order（顺序）</param>
        /// <returns></returns>
        public bool AddOrUpdateRoadNodes(string comptCode,List<Road_Nodes> list, Dictionary<string, int> nodeDict, Dictionary<string, string> timeCostDict)
        {
            bool flag = true;

            Road_Components rc = rcInstance.GetRoadComponentByCode(comptCode);

            try
            {
                Instance.idb.BeginTransaction();

                RtInstance.idb.BeginTransaction(Instance.idb.GetTransaction());

                //获取该零件图号原来对应的工艺路线
                List<Road_Nodes> roadNodesList = this.GetRoadNodesByComponents(comptCode);

                foreach (Road_Nodes r in roadNodesList)
                {

                    //如果存在则更新
                    if (nodeDict.ContainsKey(r.RNodes_Code))
                    {
                        r.RNodes_Order = nodeDict[r.RNodes_Code];
                        //额定工时
                        r.RNodes_TimeCost = Convert.ToDecimal(timeCostDict[r.RNodes_Code]);

                        r.RNodes_Dept_Code = GlobalConfiguration.ProdDept;
                        r.RNodes_Dept_Name = GlobalConfiguration.ProdDeptName;

                        this.UpdateRoadCompt(r);
                        //更新完后移除该该工艺节点
                        nodeDict.Remove(r.RNodes_Code);
                    }//不存在则删除
                    else
                    {
                        this.DeleteRoadNode(r);
                    }

                }

                foreach (KeyValuePair<string, int> kv in nodeDict)
                {
                    Road_Nodes rn = new Road_Nodes();
                    rn.RNodes_Code = kv.Key;
                    //设置工艺路线
                    Bse_Dict roadNode = dcInstance.GetDictByKey(DictKeyEnum.RoadNode.ToString(), kv.Key);
                    rn.RNodes_Name = roadNode.Dict_Name;

                    //额定工时
                    rn.RNodes_TimeCost = Convert.ToDecimal(timeCostDict[kv.Key]);

                    rn.RNodes_Order = kv.Value;
                    rn.RNodes_PartCode = rc.Comp_Code;
                    rn.RNodes_PartName = rc.Comp_Name;

                    Instance.Add(rn);
                }

                Instance.idb.CommitTransaction();

            }
            catch (Exception e)
            {
                flag = false;
                Instance.idb.RollbackTransaction();
            }

            return flag;

        }

        /// <summary>
        /// 添加新工艺节点
        /// </summary>
        /// <param name="comptCode"></param>
        /// <param name="nodeDict"></param>
        /// <param name="timeCostDict"></param>
        /// <returns></returns>
        public bool AddNewRoadNodes(string comptCode,List<Road_Nodes> list,Dictionary<string, int> nodeDict, Dictionary<string, string> timeCostDict)
        {
            bool flag = true;

            try
            {
                Road_Components rc = rcInstance.GetRoadComponentByCode(comptCode);
                //获取该零件图号原来对应的工艺路线
                //List<Road_Nodes> roadNodesList = this.GetRoadNodesByComponents(comptCode);

                foreach (var n in list)
                {
                    var re1=UpdateRoadNode(n);
                }

                foreach (KeyValuePair<string, int> kv in nodeDict)
                {
                    Road_Nodes rn = new Road_Nodes();
                    rn.RNodes_Code = kv.Key;
                    //设置工艺路线
                    Bse_Dict roadNode = dcInstance.GetDictByKey(DictKeyEnum.RoadNode.ToString(), kv.Key);
                    rn.RNodes_Name = roadNode.Dict_Name;

                    //额定工时
                    rn.RNodes_TimeCost = Convert.ToDecimal(timeCostDict[kv.Key]);
                    rn.RNodes_Dept_Code = GlobalConfiguration.ProdDept;
                    rn.RNodes_Dept_Name = GlobalConfiguration.ProdDeptName;
                    rn.RNodes_Order = kv.Value;
                    rn.RNodes_PartCode = rc.Comp_Code;
                    rn.RNodes_PartName = rc.Comp_Name;
                    rn.RNodes_Class_Code = roadNode.Dict_UDef1;
                    rn.RNodes_Class_Name = roadNode.Dict_UDef2;
                    //新增加图号 状态为1
                    rn.RNodes_Stat = 1;
                    Instance.Add(rn);
                }

            }
            catch (Exception e)
            {
                flag = false;
            }

            return flag;

        }

        public void SetNodeFinish(string comptCode)
        {
            List<Road_Nodes> list=GetRoadNodesByComponents(comptCode);
            foreach (var n in list)
            {
                n.RNodes_Stat = 0; 
                n.UpdateTime = DateTime.Now;
                UpdateRoadNode(n);
            }
        }

        /// <summary>
        /// 更新工序
        /// </summary>
        /// <param name="comp"></param>
        /// <param name="roads"></param>
        /// <returns></returns>
        public bool AddOrUpdateRoadNodes(Road_Components comp, List<Road_Nodes> roads)
        {
            bool flag = true;

            List<Road_Nodes> list = GetRoadNodesByComponents(comp.Comp_Code);
            foreach (Road_Nodes n in list)
            {
                var temp = roads.FirstOrDefault(o => o.RNodes_ID == n.RNodes_ID);
                if (temp != null)
                {
                    temp.RNodes_ID = n.RNodes_ID;
                    temp.RNodes_PartCode = comp.Comp_Code;
                    temp.RNodes_PartName = comp.Comp_Name;
                    UpdateRoadNode(temp);
                    roads.Remove(temp);
                }
                else
                {
                    DeleteRoadNode(n);
                }
            }

            foreach (Road_Nodes r in roads)
            {
                r.RNodes_PartCode = comp.Comp_Code;
                r.RNodes_PartName = comp.Comp_Name;
                r.RNodes_Dept_Code = GlobalConfiguration.ProdDept;
                r.RNodes_Dept_Name = GlobalConfiguration.ProdDeptName;
                AddRoadNode(r);
            }

            return flag;
        }

        public bool DeleteNode(Road_Nodes n)
        {
            bool flag = false;
            n.Stat = 1;
            if (Instance.Update(n) > 0)
            {
                flag = true;
            }
            return flag;
        }

        public bool AddRoadNode(Road_Nodes n)
        {
            bool flag = false;
            if (Instance.Add(n) > 0)
            {
                flag = true;
            }
            return flag;
        }

        public bool UpdateRoadNode(Road_Nodes n)
        {
            bool flag = false;
            if (Instance.Update(n) > 0)
            {
                flag = true;
            }
            return flag;
        }

        /// <summary>
        /// 是否重复编码
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public bool IsRepeatCode(Road_Nodes rc)
        {
            Road_Nodes dic = this.GetRoadNodeByCode(rc.RNodes_PartCode, rc.RNodes_Code);
            if (dic != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新工艺路线模板节点实体
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int UpdateRoadCompt(Road_Nodes rc)
        {
            return Instance.Update(rc);
            //return 0;
        }

        /// <summary>
        /// 添加工艺路线模板节点实体
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int AddRoadCompt(Road_Nodes rc)
        {
            rc.Stat = 0;

            return Instance.Add(rc);

            //return 0;
        }

        //public Road_Nodes AddRoadComptForReturn(Road_Nodes rc)
        //{
        //    rc.Stat = 0;

        //    object re = Instance.AddForReturn(rc);


        //    //return 0;
        //}


        /// <summary>
        /// 获取检测参数列表
        /// </summary>
        /// <param name="comptCode">零件图号</param>
        /// <param name="nodeCode">工艺路线节点编码</param>
        /// <returns></returns>
        private List<Road_TestRef> GetTestRefListByNodeCode(string comptCode, string nodeCode)
        {
            string where = string.Format("AND TestRef_PartNo='{0}'  AND TestRef_RNodeCode='{1}'", comptCode, nodeCode);

            return RtInstance.GetListByWhere(where);
        }


        /// <summary>
        /// 逻辑删除对应实体
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public int DeleteCompt(Road_Nodes rn)
        {
            int flag = 1;

            try
            {

                Instance.idb.BeginTransaction();
                //RnInstance.idb.BeginTransaction(Instance.idb.GetTransaction());
                RtInstance.idb.BeginTransaction(Instance.idb.GetTransaction());

                rn.Stat = 1;

                Instance.Update(rn);
                List<Road_TestRef> rtList = GetTestRefListByNodeCode(rn.RNodes_PartCode, rn.RNodes_Code);
                foreach (Road_TestRef rt in rtList)
                {
                    rt.Stat = 1;
                    RtInstance.Update(rt);
                }

                Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                flag = 0;
                Instance.idb.RollbackTransaction();
            }

            return flag;
            //return 0;
        }


        /// <summary>
        /// 逻辑删除对应实体(为事务里面调用删除方法使用)
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        private void DeleteRoadNode(Road_Nodes rn)
        {
            int flag = 1;

            rn.Stat = 1;

            Instance.Update(rn);
            //List<Road_TestRef> rtList = GetTestRefListByNodeCode(rn.RNodes_PartCode, rn.RNodes_Code);
            //foreach (Road_TestRef rt in rtList)
            //{
            //    rt.Stat = 1;
            //    RtInstance.Update(rt);
            //}


            //return flag;
            //return 0;
        }

        //public int RemoveNode(string key)
        //{
        //    Road_Nodes tmpEqu = this.GetRoadNodeByCode(key);
        //    tmpEqu.Stat = 1;
        //    return Instance.Update(tmpEqu);
        //    //return Instance.Delete(long.Parse(key));
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="keyList"></param>
        ///// <returns>1 成功批量删除  否则返回未能删除的ID</returns>
        //public string RemoveNodes(Dictionary<int, string> keyList)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (KeyValuePair<int, string> k in keyList)
        //    {
        //        int re = RemoveNode(k.Value);
        //        if (re <= 0)
        //        {
        //            sb.Append(k).Append(";");
        //        }

        //    }

        //    string result = sb.ToString();
        //    if (string.IsNullOrEmpty(result))
        //    {
        //        result = "1";
        //    }
        //    return result;
        //}
    }
}
