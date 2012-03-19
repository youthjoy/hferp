using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DataAceess;
using QX.DataModel;
using QX.Common;
using QX.Common.C_Class;
namespace QX.BLL
{
    public class Bll_UserPermission
    {
        private ADOSys_UserPermission perInstance = new ADOSys_UserPermission();


        private ADOSys_Function funInstance = new ADOSys_Function();

        private ADOSys_Role roleInstance = new ADOSys_Role();

        /// <summary>
        /// 获取用户权限列表
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public List<Sys_UserPermission> GetUserPermissionList(string userName)
        {
            string where = string.Format(" AND PU_UserName='{0}'",userName);
            List<Sys_UserPermission> list = perInstance.GetListByWhere(where);
            return list;
        }

        public List<Sys_UserPermission> GetUserPermissionListByUserCode(string usercode)
        {
            string where = string.Format(" AND PU_UserCode='{0}'", usercode);
            List<Sys_UserPermission> list = perInstance.GetListByWhere(where);
            return list;
        }


        public List<Sys_Function> GetFunctionByPareCode(string type,string pcode)
        { 
                string where = string.Format(" AND Fun_PCode='{1}'  AND Fun_Flag={0} order by Fun_Order",type,pcode);
            return funInstance.GetListByWhere(where);
        }

        public List<Sys_Function> GetAllFunctionList(string type)
        {
            string where = string.Format(" AND Fun_Flag={0} order by Fun_Order",type);
            return funInstance.GetListByWhere(where);
        }

        public bool IsAdmin(string ucode)
        {
            string adminType = GlobalConfiguration.Admin;
            string where = string.Format(" AND SRole_UCode='{0}'",ucode);
            var list = roleInstance.GetListByWhere(where);
            if (list != null && list.Count > 0 && list.FirstOrDefault(o => o.SRole_iType == adminType) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsHavePermission(string userName, string fcode)
        {
            List<Sys_UserPermission> oldlist = GetUserPermissionList(userName);
            if (oldlist.FirstOrDefault(o => o.PU_FunCode == fcode) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddOrUpdatePermission(string userName,List<Sys_UserPermission> list)
        {
            List<Sys_UserPermission> oldlist = GetUserPermissionList(userName);
            foreach (Sys_UserPermission item in oldlist)
            {
                var temp = list.FirstOrDefault(o => o.PU_Code == item.PU_Code);
                if (temp != null)
                {
                    list.Remove(temp);
                }
                else
                {
                    DeleteUserPermission(item);
                }
            }

            foreach (var it in list)
            {
                Sys_UserPermission bs = new Sys_UserPermission();
                bs = it;
                bs.PU_Code = GeneratePermissioCode();
                AddUserPermission(bs);
            }

            return true;
        }

        public string GeneratePermissioCode()
        {
            return new Bll_Comm().GenerateCode("Sys_UserPermission");
        }

        public bool DeleteUserPermission(Sys_UserPermission p)
        {
            bool flag = false;

            p.Stat = 1;

            if (perInstance.Update(p) > 0)
            {
                flag = true;
            }

            return flag;

        }

        public bool AddUserPermission(Sys_UserPermission p)
        {
            bool flag = false;


            if (perInstance.Add(p) > 0)
            {
                flag = true;
            }

            return flag;

        }
    }
}
    