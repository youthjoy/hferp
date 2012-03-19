using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
namespace QX.BLL
{
    public class Bll_Verify_Users
    {
        public ADOVerify_Users Instance = new ADOVerify_Users();

        public int AddVerifyUsers(List<Verify_Users> listUser)
        {
            int flag = 1;

            try
            {
                Instance.idb.BeginTransaction();

                foreach (Verify_Users u in listUser)
                {
                    AddVerifyUser(u);
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

        /// <summary>
        /// 添加阶段审核用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddVerifyUser(Verify_Users user)
        {
            return Instance.Add(user);
        }

        public List<Verify_Users> GetCreatorListByTemplateCode(string templateCode)
        {
            string where = string.Format(" AND VU_VerifyTempldate_Code='{0}'", templateCode);
            return Instance.GetListByWhere(where);
        }

        public int AddOrUpdateCreatorVerifyUser(string templateCode,Dictionary<string, Verify_Users> list)
        {
            int flag = 1;
            try
            {
                Instance.idb.BeginTransaction();


                List<Verify_Users> oldCreatorList = this.GetCreatorListByTemplateCode(templateCode);

                //获取该零件图号原来对应的工艺路线


                foreach (Verify_Users vu in oldCreatorList)
                {
                    //如果不存在则删除
                    if (!list.ContainsKey(vu.VU_User))
                    {
                        this.DeleteVerifyUser(vu);
                    }//如果存在则把其从模板阶段列表众移除,并更新其信息
                    else
                    {
                        list.Remove(vu.VU_User);
                    }

                }
                //添加
                foreach (KeyValuePair<string, Verify_Users> kv in list)
                {
                    this.AddVerifyUser(kv.Value);
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




        public int AddOrUpdateVerifyUser(string verifyCode, Dictionary<string, Verify_Users> list)
        {
            int flag = 1;
            try
            {
                Instance.idb.BeginTransaction();

                //获取与该阶段编码相关的用户列表
                List<Verify_Users> oldCreatorList = this.GetUsersByVerifyCode(verifyCode);

                //获取该零件图号原来对应的工艺路线


                foreach (Verify_Users vu in oldCreatorList)
                {
                    //如果不存在则删除
                    if (!list.ContainsKey(vu.VU_User))
                    {
                        this.DeleteVerifyUser(vu);
                    }//如果存在则把其从模板阶段列表众移除,并更新其信息
                    else
                    {
                        //todo   更新一下  
                        list.Remove(vu.VU_User);
                    }

                }
                //添加
                foreach (KeyValuePair<string, Verify_Users> kv in list)
                {
                    this.AddVerifyUser(kv.Value);
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

        /// <summary>
        /// 根据阶段编码获取相关审核用户列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<Verify_Users> GetUsersByVerifyCode(string code)
        {
            string where = string.Format(" AND VU_VerifyNode_Code='{0}'", code);

            return Instance.GetListByWhere(where);
        }

        public int DeleteVerifyUser(Verify_Users vu)
        {
            vu.Stat = 1;
            return Instance.Update(vu);
        }

        /// <summary>
        /// 获取与用户相关的审核阶段
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns>返回与用户相关的审核阶段</returns>
        public List<Verify_Users> GetVerifyListByUser(string userId)
        {
            string where = string.Format("VU_User='{0}'", userId);

            return Instance.GetListByWhere(where);
        }
    }
}
