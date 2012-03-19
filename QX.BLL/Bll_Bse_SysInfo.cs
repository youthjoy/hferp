using System;
using System.Collections.Generic;
using System.Text;

using QX.DataAceess;
using QX.DataModel;
using System.Collections;

namespace QX.BLL
{
    public  class Bll_Bse_SysInfo
    {
        private ADOBSE_SysInfo instance = new QX.DataAceess.ADOBSE_SysInfo();

        /// <summary>
        /// 获取系统信息
        /// </summary>
        /// <returns></returns>
        public BSE_SysInfo GetSysInfo()
        {
            BSE_SysInfo entity=null;
            List<BSE_SysInfo> list = instance.GetAll();
            if (list!=null && list.Count!=0)
            {
                entity = list[0];
            }
            
            return entity;
        }

        /// <summary>
        /// 更新系统信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysInfo(BSE_SysInfo model)
        {
            int result = instance.Update(model);
            if (result==1)
            {
                return true;
            }
            return false;
        }
    }
}
