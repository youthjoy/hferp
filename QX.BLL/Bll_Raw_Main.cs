using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using QX.DataModel;
using QX.DataAceess;
using QX.Common.C_Class;
using QX.Shared;

namespace QX.BLL
{
    public class Bll_Raw_Main
    {
        public ADORaw_Main instance = new ADORaw_Main();

        private Bll_Audit auditInstance = new Bll_Audit();

        public Bll_Raw_Inv rnvInstance = new Bll_Raw_Inv();

        public Bll_Raw_Detail rdInstance = new Bll_Raw_Detail();

        public Bll_Prod_CmdDetail pcInstance = new Bll_Prod_CmdDetail();

        public Bll_Prod_Command cmdInstance = new Bll_Prod_Command();

        public List<Raw_Main> GetRawPOList(string listType)
        {
            List<Raw_Main> list = new List<Raw_Main>();

            switch (listType)
            {
                case "myraw":
                    {

                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO' AND RawMain_Creator ='{0}'", SessionConfig.UserCode));

                        break;
                    }
                case "onaudit":
                    {
                        string fitlerWhere = auditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), SessionConfig.UserCode);

                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO'  AND AuditStat in('{1}','{2}') AND {0}", fitlerWhere, OperationTypeEnum.AudtiOperaTypeEnum.Auditing, OperationTypeEnum.AudtiOperaTypeEnum.OnAudit.ToString()));

                        break;
                    }
                case "lastaudit":
                    {
                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO'  AND AuditStat='{0}'", OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString()));
                        break;
                    }
                case "litter":
                    {
                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO'  AND AuditStat='{0}'", OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString()));
                        break;
                    }
            }


            return list;
        }

        /// <summary>
        /// 获取毛坯收货列表（待检验）
        /// </summary>
        /// <returns></returns>
        public List<Raw_Main> GetRawPIList()
        {
            return instance.GetListByWhere(string.Format(" AND RawMain_iType = '{0}' AND AuditStat !='{1}' order by RawMain_Id", OperationTypeEnum.RawMainStatEnum.PI,OperationTypeEnum.AudtiOperaTypeEnum.LastAudit));
        }

        /// <summary>
        /// 获取毛坯已入库列表
        /// </summary>
        /// <returns></returns>
        public List<Raw_Main> GetRawInPIList()
        {
            return instance.GetListByWhere(string.Format(" AND RawMain_iType = '{0}' AND AuditStat='{1}'", OperationTypeEnum.RawMainStatEnum.PI,OperationTypeEnum.AudtiOperaTypeEnum.LastAudit));
        }

        /// <summary>
        /// 检验入库
        /// </summary>
        /// <param name="main"></param>
        public void UpdateRaw(Raw_Main main)
        {
            #region 毛坯入库

            Raw_Main mainRaw = instance.GetByKey(main.RawMain_ID);
            main.RawMain_Checker = SessionConfig.UserCode;
            
            instance.Update(mainRaw);

            List<Raw_Detail> list = rdInstance.GetByRawMainCode(main.RawMain_Code);
           
            foreach (var detail in list)
            {

                detail.RDetail_OCmd = DateTime.Now;

                rdInstance.Update(detail);

                var dlist = pcInstance.GetMapListForCheck(detail.RDetail_Command, detail.RDetail_PartNo);

                foreach (var code in dlist)
                {
                    code.PMap_RawStat = "In";
                    code.PMap_RawDate = DateTime.Now;
                    code.PMap_RawMainCode = detail.RawMain_Code;
                    pcInstance.UpdateProdMap(code);
                }

                Prod_Command cmd = cmdInstance.GetModel(string.Format(" AND Cmd_Code='{0}'", detail.RDetail_Command));

                //采购的毛坯数量
                int num = detail.RDetail_Num;

                Raw_Inv rInv = new Raw_Inv();

                //库存记录参考的入库记录
                rInv.RI_RefRawCode = detail.RawMain_Code;
                rInv.RI_RefDetailCode = detail.RDetail_Code;
                rInv.RI_Code = rnvInstance.GenerateRawInvCode();
                rInv.RI_CmdCode = detail.RDetail_Command;
                rInv.RI_CompCode = detail.RDetail_PartNo;
                rInv.RI_RawCode = main.RawMain_Code;
                //rInv.RI_CompName=detail.RDetail_PartNo
                rInv.RI_InOperator = SessionConfig.UserCode;
                rInv.RI_InTime = DateTime.Now;
                rInv.RI_AvailableNum = num;
                rInv.RI_Sum = num;
                rInv.RI_UsedNum = 0;
                
                //Prod_Command command = cmdInstance.GetModel(string.Format(" AND Cmd_Code='{0}'", detail.RDetail_Command));
                rInv.RI_Customer = cmd.Cmd_Dep_Name;
                var re=rnvInstance.Add(rInv);


                #region 指令数量回写
                Prod_CmdDetail cmdDetail = pcInstance.GetModel(string.Format(" AND CmdDetail_ID='{0}'",detail.RDetail_DCommand));
                //采购入库数量回写
                cmdDetail.CmdDetail_DNum = cmdDetail.CmdDetail_DNum + num;
                pcInstance.Update(cmdDetail);

                int count=Common.C_Class.Utils.TypeConverter.ObjectToInt(cmd.Cmd_Udef3);
                cmd.Cmd_Udef3 =  (count+num).ToString();
                cmdInstance.Update(cmd);
                #endregion
            }

            
            #endregion

        }



        /// <summary>
        /// 获取待
        /// </summary>
        /// <returns></returns>
        public List<Raw_Main> GetRawAuditingPIList()
        {
            string where = auditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString(), SessionConfig.UserCode);
            if (string.IsNullOrEmpty(where))
            {
                return new List<Raw_Main>();
            }
            return instance.GetListByWhere(string.Format(" AND RawMain_iType = '{0}' AND AuditStat in ('{1}','{2}') AND {3}", OperationTypeEnum.RawMainStatEnum.PI, OperationTypeEnum.AudtiOperaTypeEnum.OnAudit, OperationTypeEnum.AudtiOperaTypeEnum.Auditing, where));
        }

        public List<Raw_Main> GetPOListByWhere(string bDate,string eDate,string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                string where = string.Format(" and RawMain_iType='PO' AND RawMain_AppDate between '{0}' and '{1}' ", bDate, eDate);
                return instance.GetListByWhere(where);
            }
            else
            {
                string where = string.Format(" and RawMain_iType='PO' AND RawMain_AppDate between '{0}' and '{1}' and (RawMain_Title like '%{2}%')", bDate, eDate, key);
                return instance.GetListByWhere(where);
            }
      
        }

        /// <summary>
        /// 获取订单（根据类型过滤）
        /// </summary>
        /// <param name="listType"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<Raw_Main> GetRawPOListWithFitler(string listType, string filter)
        {
            List<Raw_Main> list = new List<Raw_Main>();

            switch (listType)
            {
                case "myraw":
                    {

                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO' ", SessionConfig.UserCode));

                        break;
                    }
                case "onaudit":
                    {
                        string fitlerWhere = auditInstance.FilterWhere(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), SessionConfig.UserCode);

                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO'  AND {0}", fitlerWhere));

                        break;
                    }
                case "lastaudit":
                    {
                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO'  AND AuditStat='{0}' {1}", OperationTypeEnum.AudtiOperaTypeEnum.LastAudit.ToString(), filter));
                        break;
                    }
                case "litter":
                    {
                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PO'  AND AuditStat='{0}'", OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString()));
                        break;
                    }
            }


            return list;
        }


        public List<Raw_Main> GetRawPIListWithFitler(string listType, string filter)
        {
            List<Raw_Main> list = new List<Raw_Main>();

            switch (listType)
            {

                case "pi":
                    {
                        list = instance.GetListByWhere(string.Format("  and RawMain_iType='PI'  {0}", filter));
                        break;
                    }

            }


            return list;
        }


        public List<Raw_Main> GetRawInedPIListWithFitler(string listType, string filter)
        {
            List<Raw_Main> list = new List<Raw_Main>();

            switch (listType)
            {

                case "pi":
                    {
                        list = instance.GetListByWhere(string.Format(" and AuditStat='{1}'  and RawMain_iType='PI'  {0}", filter,OperationTypeEnum.AudtiOperaTypeEnum.LastAudit));
                        break;
                    }

            }


            return list;
        }

        #region 增删改


        public bool AddRawMain(Raw_Main main)
        {
            //姚淞文
            main.RawMain_Creator = SessionConfig.UserCode;

            //状态设置
            main.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

            Verify_TemplateConfig model = auditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString());

            if (model != null)
            {
                main.AuditCurAudit = model.VT_VerifyNode_Code;

                auditInstance.InsertNextAuditRecord(OperationTypeEnum.AuditTemplateEnum.RawMain_M001.ToString(), model.VT_VerifyNode_Code, main.RawMain_Code);
            }

            return Insert(main);
        }


        public bool AddRawMainInv(Raw_Main main)
        {
            //姚淞文
            main.RawMain_Creator = SessionConfig.UserCode;

            //状态设置
            main.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Auditing.ToString();

            Verify_TemplateConfig model = auditInstance.GetVerifyTemplateFirstNode(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString());

            if (model != null)
            {
                main.AuditCurAudit = model.VT_VerifyNode_Code;

                auditInstance.InsertNextAuditRecord(OperationTypeEnum.AuditTemplateEnum.PIRawMain.ToString(), model.VT_VerifyNode_Code, main.RawMain_Code);
            }
            else
            {
                main.AuditCurAudit = "100000000028";
            }

            return Insert(main);
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Insert(Raw_Main model)
        {
            bool result = false;
            try
            {
                int _result = instance.Add(model);
                if (_result > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        /// <summary>
        /// 获取实体数据
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public Raw_Main GetModel(string strCondition)
        {
            return instance.GetListByWhere(strCondition).FirstOrDefault();
        }


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Raw_Main model)
        {
            bool result = false;
            int _rseult = instance.Update(model);
            if (_rseult > 0)
            {
                result = true;
            }
            return result;
        }

        public bool TrashRaw(Raw_Main model)
        {
            model.AuditStat = OperationTypeEnum.AudtiOperaTypeEnum.Litter.ToString();
            return Update(model);
        }

        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Delete(string Code)
        {
            bool result = false;
            Raw_Main r = new Raw_Main();
            List<Raw_Main> list = instance.GetListByWhere(" AND RawMain_Code='" + Code + "'");
            if (list.Count > 0)
            {
                Raw_Main model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool Delete(Raw_Main model)
        {
            bool result = false;
            //Raw_Main r = new Raw_Main();
            //List<Raw_Main> list = instance.GetListByWhere(" AND RawMain_Code='" + Code + "'");
            //if (list.Count > 0)
            //{
            //    Raw_Main model = list[0];
                model.Stat = 1;
                int _rseult = instance.Update(model);
                if (_rseult > 0)
                {
                    result = true;
                }
            //}
            return result;
        }
        #endregion

        public string GenerateRawMainCode()
        {
            return new Bll_Comm().GenerateCode("Raw_Main");
        }
    }
}
