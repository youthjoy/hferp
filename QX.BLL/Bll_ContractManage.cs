using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QX.DataModel;
using QX.Common.C_Class;
namespace QX.BLL
{
    public class Bll_ContractManage
    {
        private Bll_SD_Contract bllContract=new Bll_SD_Contract();
        private Bll_SD_CDetail bllCdetail=new Bll_SD_CDetail();
        private Bll_Bse_Attachments bllAttachements;

        private Bll_Audit auInstance = new Bll_Audit();

        public Bll_ContractManage()
        {
            //bllContract = new Bll_SD_Contract();
            //bllCdetail = new Bll_SD_CDetail();
            //bllAttachements = new Bll_Bse_Attachments();
            //bllCdetail.instance.idb.SetConnection(bllContract.instance.idb.GetConnection());
            //bllAttachements.instance.idb.SetConnection(bllContract.instance.idb.GetConnection());
        }

        /// <summary>
        /// 保存合同
        /// </summary>
        /// <param name="model"></param>
        /// <param name="SDetailList"></param>
        /// <returns></returns>
        public bool SaveContract(SD_Contract model, List<SD_CDetail> SDetailList)
        {
            bool result = false;
            long ContractId = 0;
            try
            {
       
                List<SD_CDetail> oldList = bllCdetail.GetCDetailByContract(model.Contract_Code);

                //保存合同细目
                for (int i = 0; i < oldList.Count; i++)
                {
                    var temp = SDetailList.FirstOrDefault(o => o.CDetail_Code == oldList[i].CDetail_Code);

                    if (temp != null)
                    {
                        //var item = SDetailList[i];
                        var item = oldList[i];
                        //if (bllCdetail.CheckExist(SDetailList[i].CDetail_ContractNo, SDetailList[i].CDetail_PartNo))
                        //{
                        temp.CDetail_ID = item.CDetail_ID;
                        bllCdetail.Update(temp);
                        SDetailList.Remove(temp);

                    }
                    else
                    {
                        bllCdetail.Delete(oldList[i]);
                    }
                }

                foreach (var it in SDetailList)
                {

                    it.CDetail_Code = bllCdetail.GenerateCDetailCode();

                    bllCdetail.Insert(it);
                }

                //bllContract.instance.idb.CommitTransaction();
                result = true;
            }
            catch (Exception)
            {
                //bllContract.instance.idb.RollbackTransaction();
                throw;
            }

            return result;
        }

        /// <summary>
        /// 删除合同
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public bool DeleteContract(string Code)
        {
            bool result = false;
            try
            {
                //bllContract.instance.idb.BeginTransaction();
                //bllCdetail.instance.idb.BeginTransaction(bllContract.instance.idb.GetTransaction());
                result = bllContract.Delete(Code);
                //批量删除合同细目
                bllCdetail.BathDelete(" AND CDetail_ContractNo='" + Code + "' ");
                //bllContract.instance.idb.CommitTransaction();
                result = true;
            }
            catch (Exception)
            {
                //bllContract.instance.idb.RollbackTransaction();
                throw;
            }

            return result;
        }

        //public List<Bse_Attachments> GetAll()
        //{

        //}

    }
}
