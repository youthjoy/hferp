using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Framework.AutoForm
{
    public class CustCache
    {
        private SortedDictionary<string, object> dic = new SortedDictionary<string, object>();
        private static volatile CustCache instance = null;
        private static object lockHelper = new object();

        private CustCache()
        {

        }

        public void Add(string key, object value)
        {
            dic.Add(key, value);
        }
        public void Remove(string key)
        {
            dic.Remove(key);
        }

        public object this[string index]
        {
            get
            {
                if (dic.ContainsKey(index))
                    return dic[index];
                else
                    return null;
            }
            set { dic[index] = value; }
        }

        public static CustCache Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new CustCache();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
