using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
    public class Bll_FeedBack
    {
        private ADOBse_Feedback fbInstance = new ADOBse_Feedback();
        private ADOBse_FeedDetail fdInstance = new ADOBse_FeedDetail();
        private Bll_Audit auInstance = new Bll_Audit();
        /// <summary>
        /// 获取客户反馈信息列表
        /// </summary>
        /// <returns></returns>
        public List<Bse_Feedback> GetFeedBackList()
        {
            string where = string.Format("");
            return fbInstance.GetListByWhere(where);
        }

        public List<Bse_Feedback> GetAuditFeedBackList()
        {
            string filter = auInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(),SessionConfig.UserCode);
            if (string.IsNullOrEmpty(filter))
            {
                return new List<Bse_Feedback>();
            }
            else
            {
                string where = string.Format(" AND AuditStat<>'LastAudit' AND {0} ", filter);
                return fbInstance.GetListByWhere(where);
            }
        }

        /// <summary>
        /// 获取客户反馈信息细表
        /// </summary>
        /// <param name="main"></param>
        /// <returns></returns>
        public List<Bse_FeedDetail> GetFeedDetailList(string main)
        {
            string where = string.Format(" AND FBI_MCode='{0}'",main);
            return fdInstance.GetListByWhere(where);
        }

        public bool AddFeedBackModel(Bse_Feedback model)
        {
            model.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();
            var item = auInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString());
            if (item != null)
            {
                model.AuditCurAudit = item.VT_VerifyNode_Code;
                auInstance.InsertNextAuditRecord(OperationTypeEnum.AuditTemplateEnum.FeedbackAudit.ToString(), item.VT_VerifyNode_Code, model.FB_Code);
            }

            return AddFeedBack(model);
        }

        #region 增删改

        public bool AddFeedBack(Bse_Feedback model)
        {
            if (fbInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateFeedBack(Bse_Feedback model)
        {
            if (fbInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteFeedBack(Bse_Feedback model)
        {
            model.Stat = 1;
            if (fbInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }
        #endregion

        public string GenerateFeedBack()
        {
            return new Bll_Comm().GenerateCode("Bse_Feedback");
        }

        #region 增删改

        public bool AddOrUpdateDetail(string key,Bse_Feedback main, List<Bse_FeedDetail> list)
        {
            List<Bse_FeedDetail> oldlist = GetFeedDetailList(main.FB_Code);
            foreach (var d in oldlist)
            {
                var temp = list.FirstOrDefault(o => o.FBI_DCode == d.FBI_DCode && o.FBI_itype == d.FBI_itype);
                if (temp != null)
                {
                    temp.FBI_ID = d.FBI_ID;
                    UpdateFeedDetail(temp);
                    list.Remove(temp);
                }
                else
                {
                    DeleteFeedDetail(d);
                }
            }


            foreach (var o in list)
            {
                AddFeedDetail(o);
            }

            return true ;
        }


        public bool AddFeedDetail(Bse_FeedDetail model)
        {
            if (fdInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateFeedDetail(Bse_FeedDetail model)
        {
            if (fdInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteFeedDetail(Bse_FeedDetail model)
        {
            model.Stat = 1;
            if (fdInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
