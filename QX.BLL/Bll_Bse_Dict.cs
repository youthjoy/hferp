using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using QX.Common.C_Class.Utils;

namespace QX.BLL
{
    public enum DictKeyEnum
    {
        Root,
        /// <summary>
        /// 故障分类
        /// </summary>
        FailureCat,
        /// <summary>
        /// 职称
        /// </summary>
        TitleCat,
        /// <summary>
        /// 职务
        /// </summary>
        DutyCat,
        /// <summary>
        /// 性别
        /// </summary>
        GenderCat,
        /// <summary>
        /// 设备状态
        /// </summary>
        EquStat,
        /// <summary>
        /// 设备分类
        /// </summary>
        EquCate,
        /// <summary>
        /// 产品类别
        /// </summary>
        RoadCate,
        /// <summary>
        /// 工序节点
        /// </summary>
        RoadNode,
        /// <summary>
        /// 检测参数
        /// </summary>
        RoadTest,
        /// <summary>
        /// 产品状态
        /// </summary>
        IInfor_Stat,
        /// <summary>
        /// 客户类型
        /// </summary>
        CustType,
        /// <summary>
        /// 供应商
        /// </summary>
        SupType,
        /// <summary>
        /// 外协
        /// </summary>
        FHelperType,
        /// <summary>
        /// 合同类型
        /// </summary>
        ContractType,
        /// <summary>
        /// 加工类型
        /// </summary>
        RoadHandle,
        /// <summary>
        /// 不合格品处理方法
        /// </summary>
        FailHandType,
        /// <summary>
        /// 指令类型
        /// </summary>
        Command,
        /// <summary>
        /// 配对类型
        /// </summary>
        PatchType
    }

    public enum SysWinEnum
    {
        DictWin
    }

    public class Bll_Bse_Dict
    {
        private DataAceess.ADOBse_Equ _instance;

        //private DataAceess.ADOBse_Equ Instance
        //{
        //    get
        //    {

        //        _instance = new QX.DataAceess.ADOBse_Equ();
        //        return _instance;

        //    }
        //}

        public DataAceess.ADOBse_Dict Instance = new QX.DataAceess.ADOBse_Dict();


        public DataAceess.ADOSys_Control CInstance = new ADOSys_Control();

        /// <summary>
        /// 是否拥有子节点
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public bool IsHaveChild(Bse_Dict dict, DictKeyEnum key)
        {
            List<Bse_Dict> list = this.GetByParent(dict.Dict_Code, key)
 ;
            if (list != null && list.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 是否重复编码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsRepeatCode(Bse_Dict dict)
        {

            Bse_Dict dic = this.GetDictByKey(dict.Dict_Key, dict.Dict_Code);
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
        /// 获取所有字典信息
        /// </summary>
        /// <returns></returns>
        public List<Bse_Dict> GetAll()
        {
            return Instance.GetAll();
        }

        public string GenerateDictCode(string key)
        {


            DataTable dt = Instance.idb.RunProcReturnDatatable("qx_find_dictkeycode", new List<SqlParameter>() { new SqlParameter("@sTable", key) }.ToArray());
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }


        }

        /// <summary>
        /// 根据字典编码获取字典相关信息
        /// </summary>
        /// <param name="dictKey">字典关键字</param>
        /// <param name="key">编码</param>
        /// <returns>如果不存在则返回一个没有任何数据的Bse_Dict对象实体</returns>
        public Bse_Dict GetDictByKey(string dictKey, string code)
        {
            string where = string.Empty;
            where = string.Format("AND Dict_Key='{0}' AND Dict_Code='{1}'", dictKey, code);
            List<Bse_Dict> list = Instance.GetListByWhere(where);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }



        /// <summary>
        /// 获取某关键字相关的字典信息列表
        /// </summary>
        /// <param name="dictKey"></param>
        /// <returns></returns>
        public List<Bse_Dict> GetListByDictKey(DictKeyEnum dictKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND Dict_Key = '{0}' ", dictKey.ToString());
            return Instance.GetListByWhere(sb.ToString());
        }

        public List<Bse_Dict> GetListByDictKey(string dictKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND Dict_Key = '{0}' ", dictKey);
            return Instance.GetListByWhere(sb.ToString());
        }

        /// <summary>
        /// 获取某关键字相关的字典信息列表(不包含根节点)
        /// </summary>
        /// <param name="dictKey"></param>
        /// <returns></returns>
        public List<Bse_Dict> GetListByDictKeyByNoRoot(DictKeyEnum dictKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND Dict_Key = '{0}' AND Dict_PCode is not null", dictKey.ToString());
            return Instance.GetListByWhere(sb.ToString());
        }

        public List<Bse_Dict> GetListByDictKeyByNoRoot(string dictKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND Dict_Key = '{0}' AND Dict_PCode is not null order by Dict_Order", dictKey);
            return Instance.GetListByWhere(sb.ToString());
        }

        /// <summary>
        /// 字典更新
        /// </summary>
        /// <param name="key"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddOrUpdateDict(string key, List<Bse_Dict> list)
        {
            List<Bse_Dict> oldlist = GetListByDictKey(key);

            foreach (Bse_Dict item in oldlist)
            {
                var temp = list.FirstOrDefault(o => o.Dict_Code == item.Dict_Code);
                if (temp != null)
                {
                    temp.Dict_ID = item.Dict_ID;

                    UpdateDict(temp);

                    list.Remove(temp);

                }
                else
                {
                    DeleteDict(item);
                }
            }

            foreach (var it in list)
            {
                Bse_Dict bs = new Bse_Dict();
                bs = it;
                int order = 0;

                bs.Dict_Key = key;

                bs.Dict_Code = GenerateDictCode(key, ref order);
                bs.Dict_Order = order;
                bs.Dict_PCode = key;

                AddDict(bs);
            }

            return true;

        }

        public bool IsExsistDictKey(string key)
        {
            string where = string.Format(" AND Dict_Key='{0}'", key);
            List<Bse_Dict> list = Instance.GetListByWhere(where);
            if (list.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GenerateDictCode(string key, ref int order)
        {
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            int maxNum = TypeConverter.ObjectToInt(Instance.GetMax("Dict_ID", key)) + 1;

            DataTable dt = Instance.GenerateCode(key);

            string code = string.Empty;

            if (dt != null && dt.Rows.Count > 0)
            {
                //code = string.Format("{0}{1}", dt.Rows[0][0], maxNum);
                code = dt.Rows[0][0].ToString();
            }
            else
            {
                code = string.Format("{0}{1}", key, maxNum);
            }
            order = maxNum;
            return code;
        }

        /// <summary>
        /// 更新字典
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public int UpdateDict(Bse_Dict dict)
        {
            return Instance.Update(dict);
        }

        /// <summary>
        /// 添加字典信息
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public object AddDictForReturn(Bse_Dict dict, DictKeyEnum key)
        {
            //默认添加为有效状态
            dict.Stat = 0;


            string dDepth = Instance.GetMaxByWhere("Dict_Level", key.ToString(), "").ToString();

            if (!string.IsNullOrEmpty(dDepth))
            {
                int depth = Convert.ToInt32(dDepth) + 1;
                dict.Dict_Code = key.ToString() + "_" + depth.ToString();
                dict.Dict_Level = depth;
            }
            object re = Instance.AddForReturn(dict);
            return re;
        }

        /// <summary>
        /// 添加字典信息
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public int AddDict(Bse_Dict dict)
        {

            return Instance.Add(dict);

        }
        /// <summary>
        /// 添加字典信息
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public int AddDict(Bse_Dict dict, DictKeyEnum key)
        {
            //默认添加为有效状态
            dict.Stat = 0;



            //string dDepth = Instance.GetMaxByWhere("Dict_Level", key.ToString(), "").ToString();

            //if (!string.IsNullOrEmpty(dDepth))
            //{
            //    int depth = Convert.ToInt32(dDepth) + 1;


            //    //dict.Dict_Code = key.ToString() + "_" + depth.ToString();
            dict.Dict_Code = GenerateDictCode(key.ToString());
            dict.Dict_Key = key.ToString();
            //dict.Dict_Level = depth;
            //}

            return Instance.Add(dict);

        }


        public string GetDefaultCode(DictKeyEnum key)
        {
            string dDepth = Instance.GetMaxByWhere("Dict_Level", key.ToString(), "").ToString();
            int depth = Convert.ToInt32(dDepth) + 1;
            string dCode = key.ToString() + "_" + depth.ToString();
            return dCode;
        }

        public int DeleteDict(Bse_Dict dict)
        {
            //Instance.Delete(dict.Dict_ID);
            dict.Stat = 1;
            return Instance.Update(dict);
            //return 0;
        }

        public List<Bse_Dict> GetLevel1List(DictKeyEnum dictKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND Dict_PCode = '{0}' AND Dict_Key = '{1}' ", "", dictKey.ToString());
            return Instance.GetListByWhere(sb.ToString());
            //return null;
        }

        public List<Bse_Dict> GetByParent(string parentCode, DictKeyEnum dictKey)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" AND Dict_PCode = '{0}' AND Dict_Key='{1}' ", parentCode, dictKey.ToString());
            return Instance.GetListByWhere(sb.ToString());
            //return null;
        }


        public List<Sys_Control> GetControlMapForDict(DictKeyEnum dictKey, SysWinEnum winKey)
        {
            string where = string.Format(" AND Sys_Key='{0}' AND Sys_Win='{1}'", dictKey.ToString(), winKey.ToString());
            List<Sys_Control> list = CInstance.GetListByWhere(where);

            return list;
        }

    }
}
