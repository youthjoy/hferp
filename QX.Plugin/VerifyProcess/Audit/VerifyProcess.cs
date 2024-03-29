﻿using System;
using System.Collections.Generic;
using System.Text;
using QX.PluginFramework;
using QX.Common.C_Class;
using QX.BLL;
using QX.DataModel;

namespace QX.Plugin.VerifyProcess
{
    public class VerifyProcess:IPlugin
    {
        private IApplication application = null;
        private String name = string.Empty;
        private String description = string.Empty;
        private String data = string.Empty;

        #region IPlugin 成员

        public QX.PluginFramework.IApplication Application
        {
            get
            {
                return application;
            }
            set
            {
                application = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public void Load()
        {
            //Bll_VerifyProcess s = new Bll_VerifyProcess();
            //string pKey="PartPrice", pCode="1",uID = "admin";
            //int pCurNode = 0;

            //QX.DataModel.VerifyProcess_Records pRecords = new VerifyProcess_Records();
            //pRecords.VRecord_Key = pKey;

            //pRecords.VRecord_Code = "";
            //Alert.Show(s.Verify(uID,pKey,pCode,pCurNode,pRecords));

            VerifyMain frm = new VerifyMain();
            frm.MdiParent = application as System.Windows.Forms.Form;
            frm.Show();           

        }

        public void UnLoad()
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EventArgs> Loading;

        #endregion
    }
}
