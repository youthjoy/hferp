using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;
using QX.Common.C_Class;
namespace QX.BLL
{
    public class Bll_TestRef
    {
        private ADOProd_TestRef instance = new ADOProd_TestRef();

        private Bll_Inv_Information inInstance = new Bll_Inv_Information();

        private Bll_Prod_PlanProd ppInstance = new Bll_Prod_PlanProd();

        private Bll_ProdTask taskInstance = new Bll_ProdTask();

        /// <summary>
        /// 获取检测列表
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public List<Prod_TestRef> GetTestRefList(string pCode)
        {
            string where = string.Format(" AND PTestRef_ProdCode='{0}'", pCode);
            return instance.GetListByWhere(where);
        }

        public string GenerateTestRefCode()
        {
            return new Bll_Comm().GenerateCode("Prod_TestRef");
        }

        public bool AddTestRef(Prod_TestRef model)
        {
            bool flag = false;
            if (instance.Add(model) > 0)
            {
                flag = true;
            }

            return flag;
        }

        public void ConfirmTest(string prodCode)
        {
            var model = inInstance.GetInvByPlanCode(prodCode);

            model.IInfor_Stat = OperationTypeEnum.InvStatEnum.Entering.ToString();

            inInstance.Update(model);

            //判断产品相对应生产任务是否已完成
            Prod_PlanProd plan = ppInstance.GetModelByProdCode(prodCode);
            Prod_Task task = taskInstance.GetTaskByCode(plan.PlanProd_TaskCode);
            string stat = string.Format(" '{0}','{1}','{2}','{3}'", OperationTypeEnum.InvStatEnum.Prod.ToString(),OperationTypeEnum.InvStatEnum.Testing,OperationTypeEnum.InvStatEnum.Entering,OperationTypeEnum.InvStatEnum.Outing);
            var list = inInstance.GetInvByTaskCode(plan.PlanProd_TaskCode,stat);
            if (list.Count == task.TaskDetail_Num)
            {
                task.Task_Stat = QX.Common.C_Class.OperationTypeEnum.ProdTaskStatEnum.Finish.ToString();

                taskInstance.UpdateProdTaskStat(task);
            }


        }
    }
}
