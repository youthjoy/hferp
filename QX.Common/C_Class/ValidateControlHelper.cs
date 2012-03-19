using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace QX.Common.C_Class
{
    public class ValidateControlHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="objDict">Key 要验证的控件ID,Value 提示信息</param>
        /// <returns>Dictionary  Key 控件ID，Value 提示信息</returns>
        //public static List<string> ValidateEmpty<T>(Control.ControlCollection controls)
        //{
        //    List<string> result = new List<string>();

        //    PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));

        //    //Prot typeof(T).GetProperties();

        //    foreach (Control item in controls)
        //    {
        //        //判断控件需否需要验证为空属性
        //        if (p[item.Name] != null)
        //        {
        //            if (string.IsNullOrEmpty(item.Text))
        //            {
        //                result.Add(item.Name);
        //            }
        //        }
        //    }
        //    return result;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="objDict">Key 要验证的控件ID,Value 提示信息</param>
        /// <returns>Dictionary  Key 控件ID，Value 提示信息</returns>
        public static Dictionary<string, string> Validate(Control.ControlCollection controls, Dictionary<string, ValidateModel> objDict)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (Control item in controls)
            {
                if (item.GetType() != typeof(TextBox) && item.GetType() != typeof(DateTimePicker)
                    && item.GetType() != typeof(ComboBox) && item.GetType() != typeof(CheckBox))
                {
                    continue;
                }
                if (objDict.ContainsKey(item.Name))
                {
                    ValidateModel v = objDict[item.Name];
                    //一次只验证一个属性，不一次性全部属性验证
                    bool IsOK = true;

                    if (v.IsNotAllowEmpty.HasValue)
                    {
                        //判断控件是否为空或长度为0
                        if (string.IsNullOrEmpty(item.Text) && item.Text.Length == 0)
                        {
                            if (v.IsEnableMsgArrary)
                            {
                                result.Add(item.Name, v.PromtMessageArray[0]);
                            }
                            else
                            {
                                result.Add(item.Name, v.PromtMessage);
                            }

                            IsOK = false;
                        }
                    }
                    //是否需要验证最大长度（前提条件：上一步需要验证的属性是否为有效数据）
                    if (v.MaxLength.HasValue && IsOK)
                    {
                        if (item.Text.Length > v.MaxLength.Value)
                        {
                            if (v.IsEnableMsgArrary)
                            {
                                result.Add(item.Name, v.PromtMessageArray[1]);
                            }
                            else
                            {
                                result.Add(item.Name, v.PromtMessage);
                            }
                            IsOK = false;
                        }
                    }

                    if (v.MinLength.HasValue && IsOK)
                    {
                        if (item.Text.Length < v.MinLength.Value)
                        {
                            if (v.IsEnableMsgArrary)
                            {
                                result.Add(item.Name, v.PromtMessageArray[1]);
                            }
                            else
                            {
                                result.Add(item.Name, v.PromtMessage);
                            }
                            IsOK = false;
                        }


                    }

                    if (!string.IsNullOrEmpty(v.RegPattern) && IsOK)
                    {
                        Regex reg = new Regex(v.RegPattern);
                        if (!reg.IsMatch(item.Text))
                        {
                            if (v.IsEnableMsgArrary)
                            {
                                result.Add(item.Name, v.PromtMessageArray[2]);
                            }
                            else
                            {
                                result.Add(item.Name, v.PromtMessage);
                            }
                            IsOK = false;
                        }


                    }
                }
            }
            //return result;

            return result;
        }

        //public static Dictionary<string, string> ValidateLength(Control.ControlCollection controls, Dictionary<string, string> objDict)
        //{
        //    Dictionary<string, string> result = new Dictionary<string, string>();
        //    foreach (Control item in controls)
        //    {
        //        //判断控件需否需要验证为空属性
        //        if (objDict.ContainsKey(item.Name))
        //        {
        //            if (string.IsNullOrEmpty(item.Text))
        //            {
        //                result.Add(item.Name, objDict[item.Name]);
        //            }
        //        }
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="controls"></param>
        ///// <param name="objDict">Key 要验证的控件ID,Value 提示信息</param>
        ///// <returns>Dictionary  Key 控件ID，Value 提示信息</returns>
        //public static List<string> ValidateEmpty<T>(CControl.ControlCollection controls, Dictionary<string, string> objDict)
        //{
        //    List<string> result = new List<string>();
        //    foreach (Control item in controls)
        //    {
        //        //判断控件需否需要验证为空属性
        //        if (objDict.ContainsKey(item.Name))
        //        {
        //            if (string.IsNullOrEmpty(item.Text))
        //            {
        //                result.Add(item.Name);
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public static Dictionary<string, string> ValidateControls(Control.ControlCollection controls, List<ValidateTypeEnum> typeList, Dictionary<string, string> objDict)
        //{
        //    foreach (ValidateTypeEnum vt in typeList)
        //    {
        //        switch (vt)
        //        {
        //            case ValidateTypeEnum.Empty:

        //                break;
        //            case ValidateTypeEnum.Length: break;
        //        }
        //    }
        //}

        //public static Dictionary<string, string> ValidateControl(Control.ControlCollection controls, Dictionary<string, string> objDict)
        //{
        //    Dictionary<string, string> result = new Dictionary<string, string>();
        //    foreach (Control item in controls)
        //    {
        //        //判断控件需否需要验证为空属性
        //        if (objDict.ContainsKey(item.Name))
        //        {
        //            if (string.IsNullOrEmpty(item.Text))
        //            {
        //                result.Add(item.Name, objDict[item.Name]);
        //            }
        //        }
        //    }
        //    return result;
        //}
    }

    public class ValidateModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isNotAllowEmpty">是否允许为空</param>
        /// <param name="msg">提示信息</param>
        public ValidateModel(bool isNotAllowEmpty, string msg)
        {
            this.IsNotAllowEmpty = isNotAllowEmpty;
            //this.MaxLength = maxLength;
            //this.MinLength = minLength;
            //this.RegPattern = regPattern;
            this.PromtMessage = msg;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPattern">格式正则表达式</param>
        /// <param name="msg">提示信息</param>
        public ValidateModel(string regPattern, string msg)
        {
            //this.IsAllowEmpty = IsAllowEmpty;
            //this.MaxLength = maxLength;
            //this.MinLength = minLength;
            this.RegPattern = regPattern;
            this.PromtMessage = msg;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxLength">最大长度</param>
        /// <param name="minLength">最小长度</param>
        /// <param name="msg"></param>
        public ValidateModel(int maxLength, int minLength, string msg)
        {
            //this.IsAllowEmpty = isAllowEmpty;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            //this.RegPattern = regPattern;
            this.PromtMessage = msg;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isNotAllowEmpty">是否允许为空</param>
        /// <param name="maxLength">最大长度</param>
        /// <param name="minLength">最小长度</param>
        /// <param name="msg">msgArray[0] 是否为空提示信息；msgArray[1] 长度验证提示信息 </param>
        public ValidateModel(bool isNotAllowEmpty, int maxLength, int minLength, string[] msgArray)
        {
            this.IsNotAllowEmpty = isNotAllowEmpty;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            //this.RegPattern = regPattern;
            this.PromtMessageArray = msgArray;

            this.IsEnableMsgArrary = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isAllowEmpty">是否允许为空</param>
        /// <param name="maxLength">为0 则表示不验证</param>
        /// <param name="minLength">为0 则表示不验证</param>
        /// <param name="regPattern"></param>
        /// <param name="msgArray">msgArray[0] 是否为空提示信息；msgArray[1] 长度验证提示信息 msgArray[2] 格式要求提示信息  </param>
        public ValidateModel(bool isAllowEmpty, int maxLength, int minLength, string regPattern, params string[] msgArray)
        {
            this.IsNotAllowEmpty = isAllowEmpty;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.RegPattern = regPattern;
            this.PromtMessageArray = msgArray;

            IsEnableMsgArrary = true;

        }


        private bool isEnableMsgArrary = false;


        public bool IsEnableMsgArrary
        {
            get { return isEnableMsgArrary; }
            set { isEnableMsgArrary = value; }
        }

        private bool? _IsNotAllowEmpty;

        /// <summary>
        /// 是否允许为空
        /// </summary>
        public bool? IsNotAllowEmpty
        {
            get { return _IsNotAllowEmpty; }
            set { _IsNotAllowEmpty = value; }
        }

        private int? _MaxLength;

        /// <summary>
        /// 允许最大长度
        /// </summary>
        public int? MaxLength
        {
            get { return _MaxLength; }
            set { _MaxLength = value; }
        }

        private int? _MinLength;

        /// <summary>
        /// 允许最小长度
        /// </summary>
        public int? MinLength
        {
            get { return _MinLength; }
            set { _MinLength = value; }
        }

        private string _RegPattern;

        /// <summary>
        /// 字符串格式
        /// </summary>
        public string RegPattern
        {
            get { return _RegPattern; }
            set { _RegPattern = value; }
        }

        private string _PromtMessage;

        private string[] _PromtMessageArray;

        /// <summary>
        /// 提示信息组
        /// </summary>
        public string[] PromtMessageArray
        {
            get { return _PromtMessageArray; }
            set { _PromtMessageArray = value; }
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        public string PromtMessage
        {
            get { return _PromtMessage; }
            set { _PromtMessage = value; }
        }

    }
}
