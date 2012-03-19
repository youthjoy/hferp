using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using QX.PluginFramework;

namespace QX_Common.C_Class
{
    public class DynCompile
    {

        private string _codeHeader = string.Empty;
        private string _codeBody = string.Empty;
        private string _namespace = string.Empty;
        private string[] _method;
        private string[] _reference;
        //private object[][] _params;

        /// <summary>
        /// 代码头部引用
        /// </summary>
        public string CodeHeader
        {
            get { return _codeHeader; }
            set { _codeHeader = value; }
        }
        /// <summary>
        /// 代码主体部分
        /// </summary>
        public string CodeBody
        {
            get { return _codeBody; }
            set { _codeBody = value; }
        }
        /// <summary>
        /// 动态调用的命名空间
        /// </summary>
        public string NameSpace
        {
            get { return _namespace; }
            set { _namespace = value; }
        }
        /// <summary>
        /// 动态调用的方法集合
        /// </summary>
        public string[] Method
        {
            get { return _method; }
            set { _method = value; }
        }
        /// <summary>
        /// 引用DLL文件集合
        /// </summary>
        public string[] Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }
        /// <summary>
        /// 动态调用法参数
        /// </summary>
        //public object[] Params
        //{
        //    get { return _params; }
        //    set { _params = value; }
        //}

        /// <summary>
        /// 组织源码
        /// </summary>
        /// <returns></returns>
        public string GetCode()
        {
            StringBuilder strCode = new StringBuilder();
            strCode.AppendLine(_codeHeader);
            strCode.AppendLine(_codeBody);
            return strCode.ToString();
        }

        /// <summary>
        /// 动态编译源码
        /// </summary>
        /// <returns></returns>
        public bool Compile()
        {
            bool result = false;
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameter = new CompilerParameters();
            for (int i = 0; i <_reference.Length; i++)
            {
                parameter.ReferencedAssemblies.Add(_reference[i]);
            }            
            parameter.GenerateExecutable = false;
            parameter.GenerateInMemory = true;

            CompilerResults compiResult = provider.CompileAssemblyFromSource(parameter, GetCode());
            if (compiResult.Errors.HasErrors)
            {
                result = false;
            }
            else
            {
                Assembly assmbly = compiResult.CompiledAssembly;
                Type _type = assmbly.GetType(_namespace);
                for (int i = 0; i < Method.Length; i++)
                {
                    MethodInfo method = _type.GetMethod(_method[i]);
                    method.Invoke(null,null);
                }
                result = true;
            }

            return result;
        }

        /// <summary>
        /// 根据path，class动态加载插件
        /// </summary>
        /// <param name="_path"></param>
        /// <param name="_class"></param>
        /// <param name="application"></param>
        public void FindAssbely(string _path, string _class,IApplication application)
        {
            ObjectCache Cache = new ObjectCache();
            Assembly assembly;
            Type type;
            IPlugin instance=null;
            if (Cache.ExistObject(_class))
            {
                instance = (IPlugin)Cache.GetObject(_class);
            }
            else
            {
                assembly = Assembly.LoadFile(_path);
                type = assembly.GetType(_class);
                instance = (IPlugin)Activator.CreateInstance(type);
                Cache.AddObject(_class, instance);
            }           
            instance.Application = application;
            instance.Load();        
        }

        /// <summary>
        /// 根据path，class动态加载插件
        /// </summary>
        /// <param name="_path"></param>
        /// <param name="_class"></param>
        /// <param name="application"></param>
        public void FindAssbely(string _path, string _class, IApplication application,string Name,string data)
        {
            try
            {
                ObjectCache Cache = new ObjectCache();
                Assembly assembly;
                Type type;
                IPlugin instance = null;
                if (Cache.ExistObject(_class))
                {
                    instance = (IPlugin)Cache.GetObject(_class);
                }
                else
                {
                    assembly = Assembly.LoadFile(_path);
                    type = assembly.GetType(_class);
                    instance = (IPlugin)Activator.CreateInstance(type);
                    Cache.AddObject(_class, instance);
                }
                instance.Application = application;
                instance.Name = Name;
                instance.Data = data;
                instance.Load();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// 从程序集中动态调用返回List<U>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="obj"></param>
        /// <param name="invokeName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<U> MemeberInvokeForList<T, U>(T obj,String invokeName,  params object[] param)
        {
            List<U> list = null;
            Type TType = obj.GetType();
            Object BindObj = TType.InvokeMember(null,
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance,
                null, null, null);
            list = (List<U>)TType.InvokeMember(invokeName,
                                        BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                                    null, BindObj, param);
            return list;
        }
        /// <summary>
        /// 从程序集中动态调用返回Model<U>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="obj"></param>
        /// <param name="invokeName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public U MemeberInvokeForModel<T, U>(T obj, String invokeName, params object[] param)
        {
            U model = default(U);
            Type TType = obj.GetType();
            Object BindObj = TType.InvokeMember(null,
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance,
                null, null, null);
            model = (U)TType.InvokeMember(invokeName,
                                        BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                                    null, BindObj, param);
            return model;
        }

        /// <summary>
        /// 从程序集中动态调用方法(Insert Update)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="obj"></param>
        /// <param name="invokeName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int MemeberInvokeIU<T, U>(T obj, String invokeName, params object[] param)
        {
            int result = 0;
            Type TType = obj.GetType();
            Object BindObj = TType.InvokeMember(null,
                BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance,
                null, null, null);
            result = (int)TType.InvokeMember(invokeName,
                                        BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                                    null, BindObj, param);
            return result;
        }

    }
}
