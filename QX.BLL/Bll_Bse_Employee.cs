using System;
using System.Collections.Generic;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common.C_Class;
using System.Linq;
namespace QX.BLL
{
    public class Bll_Bse_Employee
    {
        private ADOBse_Employee instance = new ADOBse_Employee();
        private ADOBse_EmployeeExt eInstance = new ADOBse_EmployeeExt();
        /// <summary>
        /// 获取所有的员工
        /// </summary>
        /// <returns></returns>
        public List<Bse_Employee> GetAllEmployee()
        {
            string where = string.Format("  and isnull(Emp_LoginID,'')<>'{0}'", GlobalConfiguration.Admin);
            List<Bse_Employee> list = instance.GetListByWhere(where);
            return list;
        }


        public List<Bse_EmployeeExt> GetEmployeeExtend(string empCode)
        {
            string where = string.Format("  and EmpE_EmpCode='{0}'", empCode);
            List<Bse_EmployeeExt> list = eInstance.GetListByWhere(where);
            return list;
        }

        public bool AddExt(Bse_EmployeeExt model)
        {
            if (eInstance.Add(model) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateExt(Bse_EmployeeExt model)
        {
            if (eInstance.Update(model) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateEmployeeExtList(Bse_Employee model, List<Bse_EmployeeExt> list)
        {
            var oldlist = GetEmployeeExtend(model.Emp_Code);
            oldlist.RemoveAll(o => o.EmpE_Module == "bse");
            foreach (Bse_EmployeeExt r in oldlist)
            {
                var temp = list.FirstOrDefault(o => o.EmpE_ID == r.EmpE_ID);
                //如果存在则更新
                if (temp != null)
                {
                    //temp.CreateDate = DateTime.Now;

                    temp.EmpE_ID = r.EmpE_ID;

                    eInstance.Update(temp);

                    list.Remove(temp);

                }//不存在则删除
                else
                {
                    r.Stat = 1;
                    eInstance.Update(r);
                }
            }

            foreach (Bse_EmployeeExt detail in list)
            {
                //如果有编码生成，则在此处完成
                eInstance.Add(detail);
            }
        }

        /// <summary>
        /// 根据条件获取员工
        /// </summary>
        /// <returns></returns>
        public List<Bse_Employee> GetEmpByDept(string where)
        {
            List<Bse_Employee> list = instance.GetListByWhere(string.Format(" and  isnull(Emp_LoginID,'')<>'{1}'  AND ((Emp_Dept_Code='{0}') or (Emp_Dept_Code in (SELECT     Dept_Code FROM  Bse_Department WHERE     (Dept_PCode = '{0}'))))", where.Replace("'", " ").Trim(), GlobalConfiguration.Admin));
            return list;
        }

        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertEmployee(Bse_Employee model)
        {
            //model.Emp_Code = GenerateEmpCode();

            bool result = false;
            int _result = instance.Add(model);
            if (_result > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 生成员工编码
        /// </summary>
        /// <returns></returns>
        public string GenerateEmpCode()
        {
            var val = new Bll_Comm().GetMax("Bse_Employee", "Emp_ID");
            int re=Common.C_Class.Utils.TypeConverter.ObjectToInt(val)+1;
            return re.ToString();

        }


        /// <summary>
        /// '获取实体
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public Bse_Employee GetModel(string condition)
        {
            List<Bse_Employee> list = instance.GetListByWhere(condition);
            Bse_Employee model = new Bse_Employee();
            if (list != null && list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateEmployee(Bse_Employee model)
        {
            bool result = false;
            int _result = instance.Update(model);
            if (_result > 0)
            {
                result = true;
            }
            return result;
        }

        public bool DeleteEmployee(Bse_Employee model)
        {
            bool result = false;
            model.Stat = 1;
            int _result = instance.Update(model);
            if (_result > 0)
            {
                result = true;
            }
            return result;
        }

    }
}
