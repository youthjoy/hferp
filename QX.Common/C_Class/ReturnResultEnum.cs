using System;
using System.Collections.Generic;
using System.Text;

namespace QX.Common.C_Class
{
    public enum ReturnResultEnum
    {
        /// <summary>
        /// 失败
        /// </summary>
        Failure,
        /// <summary>
        /// 成功
        /// </summary>
        Success,
        
        #region 审核模板配置模块使用
        /// <summary>
        /// 审核用户重复
        /// </summary>
        UserRepeat,
        /// <summary>
        /// 阶段编码重复
        /// </summary>
        CodeRepeat,
        /// <summary>
        /// 审核用户数量未达最低审核用户数量
        /// </summary>
        NotFit,
        #endregion
        /// <summary>
        /// 允许编辑
        /// </summary>
        AllowEdit,
        /// <summary>
        /// 不允许编辑
        /// </summary>
        NotAllowEdit

    }
}
