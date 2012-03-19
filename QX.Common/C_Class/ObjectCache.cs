using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace QX.PluginFramework
{
    /// <summary>
    /// 对象缓存
    /// </summary>
    internal class ObjectCache
    {
        private Hashtable htObj;

        public ObjectCache()
        {
            htObj = Hashtable.Synchronized(new Hashtable());
        }

        /// <summary>
        /// 添加对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="instance"></param>
        public void AddObject(string name, Object instance)
        {
            if (!htObj.ContainsKey(name))
            {
                htObj.Add(name, instance);
            }
        }

        /// <summary>
        /// 删除对象实例
        /// </summary>
        /// <param name="name"></param>
        public void DeleteObject(string name)
        {
            if (htObj.ContainsKey(name))
                htObj.Remove(name);
        }
        /// <summary>
        /// 获取对应的对象
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object GetObject(string name)
        {
            if (htObj.ContainsKey(name))
            {
                return htObj[name];
            }
            return null;
        }
        /// <summary>
        /// 对象是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistObject(string name)
        {
            return htObj.ContainsKey(name);
        }
        /// <summary>
        /// 清除所有对象实例
        /// </summary>
        public void ClearObject()
        {
            htObj.Clear();
        }
    }
}
