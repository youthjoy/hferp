using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using QX.DataModel;
using QX.Common.C_Class;
using QX.Framework.AutoForm;
using QX.BLL;

namespace QX.Plugin.Prod.ProdCmd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public Form1(Prod_Command cmd)
        {
            DataModel = cmd;
            //工具栏初始化
            ToolBarInit();
            //窗体On_load事件
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
        }

        #region 操作句柄

        private OperationTypeEnum.OperationType operationType = OperationTypeEnum.OperationType.Add;
        /// <summary>
        /// 操作类型
        /// </summary>
        public OperationTypeEnum.OperationType OperationType
        {
            get { return operationType; }
            set { operationType = value; }
        }

        private  BindModelHelper bmHelper = new BindModelHelper();

        private GridHelper gHelper = new GridHelper();

        private FormHelper fHelper = new FormHelper();

        private Bll_Prod_Command instance = new Bll_Prod_Command();

        private Prod_Command DataModel
        {
            get;
            set;
        }

        #endregion 

        private void ToolBarInit()
        {

        }

        public void InitData()
        {


            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    {
                        DataModel.Cmd_Code = instance.GenerateCommandCode();

                        break;
                    }
                case OperationTypeEnum.OperationType.Edit:
                    {
                        break;
                    }
                case OperationTypeEnum.OperationType.Look:
                    {
                        break;
                    }
            }

            fHelper.GenerateForm("CForm_ProdCommand", this.panel1, new Point(0, 0));

            Sys_PD_Module module = panel1.Tag as Sys_PD_Module;

            if (module != null)
            {
                bmHelper.BindModelToControl<Prod_Command>(DataModel, panel1.Controls, module.SPM_TPrefix);
            }

        }

        private void SaveData()
        {
            switch (OperationType)
            {
                case OperationTypeEnum.OperationType.Add:
                    {
                        DataModel.Cmd_Code = instance.GenerateCommandCode();

                        break;
                    }
                case OperationTypeEnum.OperationType.Edit:
                    {
                        break;
                    }
                case OperationTypeEnum.OperationType.Look:
                    {
                        break;
                    }
            }
        }

    }
}
