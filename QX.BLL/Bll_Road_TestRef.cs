using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;

namespace QX.BLL
{
    public class Bll_Road_TestRef
    {
        public DataAceess.ADORoad_TestRef Instance = new QX.DataAceess.ADORoad_TestRef();

        public Bll_Road_Nodes rnInstance = new Bll_Road_Nodes();

        public Bll_Road_Components rcInstance = new Bll_Road_Components();

        /// <summary>
        /// 获取检测参数列表
        /// </summary>
        /// <param name="comptCode">零件图号</param>
        /// <param name="nodeCode">工艺路线节点编码</param>
        /// <returns></returns>
        public List<Road_TestRef> GetTestRefListByNodeCode(string comptCode,string nodeCode)
        {
            string where = string.Format("AND TestRef_PartNo='{0}'  AND TestRef_RNodeCode='{1}'",comptCode,nodeCode);

            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 获取特定零件图号下特定工艺节点对应检测参数
        /// </summary>
        /// <param name="comptCode"></param>
        /// <param name="rNodeCode"></param>
        /// <param name="testRefCode"></param>
        /// <returns></returns>
        public Road_TestRef GetTestRefByKey(string comptCode, string rNodeCode, string testRefCode)
        {
            string where = string.Format(" AND TestRef_PartNo='{0}' AND TestRef_RNodeCode='{1}' AND TestRef_Code='{2}'",comptCode,rNodeCode,testRefCode);
            List<Road_TestRef> list = Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            return null;
        }

        public List<Road_TestRef> GetTestRefList(string comptCode)
        {
            string where = string.Format(" AND TestRef_PartNo='{0}'",comptCode);
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 添加或更新工艺节点列表信息
        /// </summary>
        /// <param name="comptCode">零件图号</param>
        /// <param name="nodeDict">Key-检测参数编码 value-order（顺序）</param>
        /// <returns></returns>
        public int AddOrUpdateRoadNodesTestRef(string comptCode,string nodeCode, Dictionary<string, Road_TestRef> nodeDict)
        {
            Road_Nodes rn = rnInstance.GetRoadNodeByCode(comptCode, nodeCode);
            Road_Components rc = rcInstance.GetRoadComponentByCode(comptCode);

            try
            {
                Instance.idb.BeginTransaction();

                List<Road_TestRef> roadTestList = this.GetTestRefListByNodeCode(comptCode, nodeCode);

                foreach (Road_TestRef r in roadTestList)
                {
                    //如果存在则更新
                    if (nodeDict.ContainsKey(r.TestRef_Code))
                    { 
              

                        Road_TestRef rt = nodeDict[r.TestRef_Code];
                        rt.TestRef_ID = r.TestRef_ID;
                        //冗余字段赋值
                        rt.TestRef_RNodeName = rn.RNodes_Name;
                        rt.TestRef_PartName = rc.Comp_Name;
      
                        this.UpdateRoadTestRef(rt);
                        nodeDict.Remove(rt.TestRef_Code);
                        //this.UpdateRoadCompt(r);
                        ////更新完后移除该该工艺节点
                        //nodeDict.Remove(r.RNodes_Code);
                    }//不存在则删除
                    else
                    {
                        this.DeleteRoadTestRef(r);
                    }

                }

                foreach (KeyValuePair<string, Road_TestRef> kv in nodeDict)
                {
                    Road_TestRef rt = kv.Value;

               
                    //冗余字段赋值
                    rt.TestRef_RNodeName = rn.RNodes_Name;
                    rt.TestRef_PartName = rc.Comp_Name;

                    Instance.Add(rt);
                    
                }

                Instance.idb.CommitTransaction();

            }
            catch (Exception e)
            {
                Instance.idb.RollbackTransaction();
            }

            return 0;

        }


        

        /// <summary>
        /// 更新检测参数模板数据
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public int UpdateRoadTestRef(Road_TestRef rt)
        {
            return Instance.Update(rt);
        }

        /// <summary>
        /// 逻辑删除检测参数模板数据
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public int DeleteRoadTestRef(Road_TestRef rt)
        {
            rt.Stat = 1;
            return Instance.Update(rt);
        }

        /// <summary>
        /// 添加检测参数模板数据
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        public int AddRoadTestRef(Road_TestRef rt)
        {
            return Instance.Add(rt);
        }
    }
}
