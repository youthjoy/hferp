using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QX.BLL;

namespace QX.BseDict
{
    public class LogHelper
    {
        public static void WriteLog(string module, string optor, OpLogTypeEnum type, string content)
        {
            MethodInvoker m = new MethodInvoker(delegate
            {
                BLL.Bll_Operation opInst = new QX.BLL.Bll_Operation();
                opInst.WriteLog(module, optor, type, content);
            });
            m.BeginInvoke(null, null);
        }
    }
}
