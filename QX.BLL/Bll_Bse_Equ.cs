using System;
using System.Collections.Generic;
using System.Text;
using QX.DataModel;
using QX.DataAceess;
using System.Linq;
using QX.Common.C_Class;

namespace QX.BLL
{
    public class Bll_Bse_Equ
    {
        private DataAceess.ADOBse_Equ _instance;


        private ADOProd_Failure pfInstance = new ADOProd_Failure();

        //private DataAceess.ADOBse_Equ Instance
        //{
        //    get
        //    {

        //        _instance = new QX.DataAceess.ADOBse_Equ();
        //        return _instance;

        //    }
        //}

        public DataAceess.ADOBse_Equ Instance = new QX.DataAceess.ADOBse_Equ();

        public List<Bse_Equ> GetListForPage()
        {
            List<Bse_Equ> list = Instance.GetAll();
            return list;
        }

        public List<Bse_Equ> GetListForPage(string bdate,string edate,string key)
        {
            List<Bse_Equ> list = Instance.GetListByWhere(string.Format(" AND Equ_BuyDate bewteen '{0}' and '{1}' and (Equ_Code like '%{2}%' OR Equ_Name like '%{2}%')",bdate,edate,key));
            return list;
        }
        public Bse_Equ GetModelByCode(string code)
        {
            return Instance.GetListByWhere(string.Format(" AND Equ_Code='{0}'",code)).FirstOrDefault();
        }

        public Bse_Equ GetEntiyByKey(string key)
        {
            Bse_Equ entity = Instance.GetByKey(long.Parse(key));
            return entity;
        }

        public string GenerateEquCode()
        {
            return new Bll_Comm().GenerateCode("Bse_Equ");
        }

        public int ModifyDeviceInfo(Bse_Equ equ)
        {
            if (equ == null)
            {
                return 0;
            }
            equ.Stat = 0;
            return Instance.Update(equ);
        }

        public int AddDeviceInfo(Bse_Equ equ)
        {
            return Instance.Add(equ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="equ"></param>
        /// <returns></returns>
        public Bse_Equ AddDevice(Bse_Equ equ)
        {
            //Bse_Equ tempEqu = new Bse_Equ();
            //添加后默认为有效状态
            equ.Stat = 0;
            object obj = Instance.AddWithReturn(equ);
            equ = Instance.GetByKey(long.Parse(obj.ToString()));
            return equ;
            //return null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyList"></param>
        /// <returns>1 成功批量删除  否则返回未能删除的ID</returns>
        public string RemoveDevices(Dictionary<int,string> keyList)
        {
            //StringBuilder sb = new StringBuilder();
            //foreach (KeyValuePair<int,string> k in keyList)
            //{
            //    int re=RemoveDevice(k.Value);
            //    if (re <= 0)
            //    {
            //        sb.Append(k).Append(";");    
            //    }

            //}

            

            //string result = sb.ToString();
            //if (string.IsNullOrEmpty(result))
            //{
            //    result = "1";
            //}
            return "";
        }

        public int RemoveDevice(Bse_Equ model)
        {
            //Bse_Equ tmpEqu=Instance.GetByKey(long.Parse(key));
            model.Stat = 1;
            return Instance.Update(model);
            //return Instance.Delete(long.Parse(key));
        }


        #region 设备故障

        public List<Prod_Failure> GetPFailureList()
        {
            string where = string.Format(" AND Failure_Stat!='{0}'",OperationTypeEnum.EquStat.ENormal);
            return pfInstance.GetListByWhere(where);
        }

        public List<Prod_Failure> GetPFailureListHis()
        {
            string where = string.Format(" AND Failure_Stat='{0}'", OperationTypeEnum.EquStat.ENormal);
            return pfInstance.GetListByWhere(where);
        }

        public bool UpdatePFailure(Prod_Failure item)
        {
            if (pfInstance.Update(item) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDFailure(Prod_Failure item)
        {
            Bse_Equ equ = GetModelByCode(item.Failure_EquCode);
            if (equ != null)
            {
                equ.Equ_Stat = item.Failure_Stat;
            }

            ModifyDeviceInfo(equ);

            return UpdatePFailure(item);
        }

        public bool AddPFailure(Prod_Failure item)
        {
            Bse_Equ equ = GetModelByCode(item.Failure_EquCode);
            if (equ != null)
            {
                equ.Equ_Stat = OperationTypeEnum.EquStat.EQuestion.ToString();
            }

            ModifyDeviceInfo(equ);

            return InsertPFailure(item);
        }

        public bool InsertPFailure(Prod_Failure item)
        {
            if (pfInstance.Add(item) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 故障更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddOrUpdatePFailure(List<Prod_Failure> list)
        {
            List<Prod_Failure> oldList = GetPFailureList();

            foreach (var item in oldList)
            {

                var obj = list.Find(o => o.Failure_Code == item.Failure_Code);

                //存在更新，不存在则删除
                if (obj != null)
                {

                    obj.Failure_ID = item.Failure_ID;
                    //obj.whioi_mai = item.PUD_RType;


                    pfInstance.Update(obj);
                    //更新完毕从新列表中移除
                    list.Remove(obj);
                }
                else
                {
                    item.Stat = 1;
                    pfInstance.Update(item);
                }
            }

            //list中剩下的即为新添加的明细
            foreach (var detail in list)
            {

                detail.Failure_Code = GeneratePFailureCode();

                pfInstance.Add(detail);
            }


            return true;
        }

        public string GeneratePFailureCode()
        {
            return new Bll_Comm().GenerateCode("Prod_Failure");
        }

        #endregion
    }
}
