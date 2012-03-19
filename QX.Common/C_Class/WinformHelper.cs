using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QX.Common.C_Class
{
    public class WinformHelper
    {
        private static Control.ControlCollection controls = null;

        public WinformHelper(Control.ControlCollection _controls)
        {
            controls = _controls;
        }
        public WinformHelper(){
            controls = new Control.ControlCollection(new Control());
        }

        /// <summary>
        /// 在窗体中查找控件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="controlName"></param>
        /// <returns></returns>
        public Control FindControl(Control control, string controlName)
        {
            Control c1;
            foreach (Control c in control.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                else if (c.Controls.Count > 0)
                {
                    c1 = FindControl(c, controlName);
                    if (c1 != null)
                    {
                        return c1;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 检查子窗体是否已经存在
        /// </summary>
        /// <param name="mainFrm"></param>
        /// <param name="frmName"></param>
        /// <returns></returns>
        public bool CheckChildFormExists(Form mainFrm, string frmName)
        {
            foreach (Form childFrm in mainFrm.MdiChildren)
            {
                if (childFrm.Name.ToLower()==frmName.ToLower())
                {
                    if (childFrm.WindowState!= FormWindowState.Maximized)
                    {
                        childFrm.WindowState = FormWindowState.Maximized;
                    }
                    childFrm.Activate();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 获取窗体上所有控件
        /// </summary>
        /// <param name="_controls"></param>
        /// <returns></returns>
        public Control.ControlCollection GetAllControl(Control.ControlCollection _controls)
        {
            foreach (Control item in _controls)
            {
                if (item.HasChildren)
                {
                    controls.Add(item);
                    GetAllControl(item.Controls);
                }
                else
                {
                    controls.Add(item);
                }
            }
            return controls;
        }

    }
}
