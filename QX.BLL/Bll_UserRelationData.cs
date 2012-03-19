using System;
using System.Collections.Generic;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
    public enum URD_TypeEnum
    {
        Insert,
        Update,
        Delete
    }

    public enum URD_ModuleEnum
    {
        /// <summary>
        /// 零件图号
        /// </summary>
        Road_Components
    }

    public class Bll_UserRelationData
    {
        private DataAceess.ADOUserRelationData Instance = new ADOUserRelationData();

        /// <summary>
        /// 添加一条添加记录
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public int AddInsertRecord(URD_ModuleEnum module,string datacode)
        {
            string uid=SessionConfig.UserCode;
            return AddInsertRecord(uid, module,datacode);
        }
        /// <summary>
        /// 添加一条添加记录
        /// </summary>
        public int AddInsertRecord(string uid, URD_ModuleEnum module,string datacode)
        {
            UserRelationData urd = new UserRelationData();
            urd.URD_Operator = uid;
            urd.URD_OpTime = DateTime.Now;
            urd.URD_OpType = URD_TypeEnum.Insert.ToString();
            urd.URD_Module = module.ToString();
            urd.URD_DataCode = datacode;
            return AddInsertRecord(urd);
        }
        /// <summary>
        /// 添加一条添加记录
        /// </summary>
        public int AddInsertRecord(UserRelationData urd)
        {
   
            return Instance.Add(urd);
        }


        /// <summary>
        /// 添加一条更新记录
        /// </summary>
        public int AddUpdateRecord(URD_ModuleEnum module,string datacode)
        {
            string uid = SessionConfig.UserCode;
            
            return AddUpdateRecord(uid, module,datacode);
        }
        /// <summary>
        /// 添加一条更新记录
        /// </summary>
        public int AddUpdateRecord(string uid, URD_ModuleEnum module,string datacode)
        {
            UserRelationData urd = new UserRelationData();
            urd.URD_Operator = uid;
            urd.URD_OpTime = DateTime.Now;
            urd.URD_OpType = URD_TypeEnum.Update.ToString();
            urd.URD_Module = module.ToString();
            urd.URD_DataCode = datacode;
            return AddUpdateRecord(urd);
        }

        /// <summary>
        /// 添加一条更新记录
        /// </summary>
        public int AddUpdateRecord(UserRelationData urd)
        {
            return Instance.Add(urd);
        }


        public int AddDeleteRecord(URD_ModuleEnum module,string datacode)
        {
            string uid = SessionConfig.UserCode;
            return AddDeleteRecord(uid, module,datacode);
        }

        public int AddDeleteRecord(string uid, URD_ModuleEnum module,string datacode)
        {
            UserRelationData urd = new UserRelationData();
            urd.URD_Operator = uid;
            urd.URD_OpTime = DateTime.Now;
            urd.URD_OpType = URD_TypeEnum.Delete.ToString();
            urd.URD_Module = module.ToString();
            urd.URD_DataCode = datacode;
            return AddDeleteRecord(urd);
        }


        public int AddDeleteRecord(UserRelationData urd)
        {
            return Instance.Add(urd);
        }



        public int Update(UserRelationData urd)
        {
            return Instance.Update(urd);
        }

        public UserRelationData GetByKey(string key)
        {
            return Instance.GetByKey(int.Parse(key));
        }
    }
}
