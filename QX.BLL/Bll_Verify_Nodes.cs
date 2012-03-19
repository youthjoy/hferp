using System;
using System.Collections.Generic;
using System.Text;

using QX.DataModel;
using QX.DataAceess;

namespace QX.BLL
{
    public class Bll_Verify_Nodes
    {
        public ADOVerify_Nodes Instance = new ADOVerify_Nodes();
        public ADOVerify_Users vuInstance = new ADOVerify_Users();


        public Bll_Verify_Nodes()
        {
            vuInstance.idb.SetConnection(Instance.idb.GetConnection());
        }

        public void AddVerifyUsers(List<Verify_Users> listUser)
        {

            foreach (Verify_Users u in listUser)
            {
                AddVerifyUser(u);
            }

        }

        /// <summary>
        /// 添加阶段审核用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddVerifyUser(Verify_Users user)
        {
            return vuInstance.Add(user);
        }
        /// <summary>
        /// 根据阶段节点编码获取阶段信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Verify_Nodes GetVerifyNodeByCode(string code)
        {
            string where = string.Empty;
            where = string.Format(" AND VerifyNode_Code='{0}'", code);
            List<Verify_Nodes> list = Instance.GetListByWhere(where);

            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public string GenerateVerifyNodeCode()
        {
            return new Bll_Comm().GenerateCode("Verify_Nodes");
        }

        /// <summary>
        /// 获取阶段节点列表
        /// </summary>
        /// <returns></returns>
        public List<Verify_Nodes> GetVerifyNodeList()
        {
            return Instance.GetAll();
        }


        /// <summary>
        /// 获取阶段节点列表(排除某一阶段节点)
        /// </summary>
        /// <returns></returns>
        public List<Verify_Nodes> GetVerifyNodeListExcludedNode(string vn)
        {
            string where = string.Format(" AND VerifyNode_Code !='{0}'", vn);
            return Instance.GetListByWhere(where);
        }

        /// <summary>
        /// 添加阶段节点
        /// </summary>
        /// <param name="vn"></param>
        /// <returns></returns>
        public int AddVerifyNode(Verify_Nodes vn)
        {
            return Instance.Add(vn);
        }

        public string GenerateNodeCode()
        {
            return new Bll_Comm().GenerateCode("Verify_Nodes");
        }

        public bool IsRepeatCode(string code)
        {
            string where = string.Format(" AND VerifyNode_Code='{0}'",code);
            List<Verify_Nodes> list = Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 添加阶段节点
        /// </summary>
        /// <param name="vn"></param>
        public int AddVerifyNodeAndUsers(Verify_Nodes vn,Dictionary<string,Verify_Users> list)
        {
            int flag =1;
            try
            {
                Instance.idb.BeginTransaction();

                vuInstance.idb.BeginTransaction(Instance.idb.GetTransaction());

                Instance.Add(vn);


                foreach (KeyValuePair<string,Verify_Users> vu in list)
                {
                    vuInstance.Add(vu.Value);
                }

                Instance.idb.CommitTransaction();
            }
            catch (Exception e)
            {
                flag = 0;
                Instance.idb.RollbackTransaction();
            }

            return flag;
           
        }

        public int UpdateVerifyNode(Verify_Nodes vn)
        {
            return Instance.Update(vn);
        }
        //public int AddOrUpdateNodeUsers(Verify_Nodes vn, List<Verify_Users> list)
        //{
        //    int flag = 1;
        //    try
        //    {
        //        Instance.idb.BeginTransaction();

        //        vuInstance.idb.BeginTransaction(Instance.idb.GetTransaction());

        //        Instance.Add(vn);


        //        foreach (Verify_Users vu in list)
        //        {
        //            vuInstance.Add(vu);
        //        }

        //        Instance.idb.CommitTransaction();
        //    }
        //    catch (Exception e)
        //    {
        //        flag = 0;
        //        Instance.idb.RollbackTransaction();
        //    }

        //    return flag;

        //}
    }
}
