using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Synchronous.CoreManagement.KeyValue
{
    public partial class KeyValueClass
    {
        internal Dictionary<string, object> data;
        internal bool flag = false;
        internal KeyValueClass(Dictionary<string, object> dataLoad)
        {
            data = dataLoad ?? new Dictionary<string, object>();
        }

        protected void Insert_KeyValueClass(string key, object value)
        {
            if (!flag)
            {
                flag = true;
            }
            data[key] = value;
        }

        protected bool Delete_KeyValueClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!data.ContainsKey(key)) return false;

            if (!IsKeyValue(data[key])) return false;

            data.Remove(key);
            return true;
        }

        protected string Read_KeyValueClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]) )) return null;
            return data[key]?.ToString();
        }

        protected bool Rename_KeyValueClass(string oldKey, string newKey)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!data.ContainsKey(oldKey)) return false;
            if (data.ContainsKey(newKey)) return false;
            if (!IsKeyValue(data[oldKey])) return false;
            var value = data[oldKey];
            data.Remove(oldKey);
            data[newKey] = value;
            return true;
        }

        protected bool Exists_KeyValueClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]) )) return false;
            return true;
        }

        protected (List<string> Lists,int Count) Keys_KeyValueClass()
        {
            if (!flag)
            {
                flag = true;
            }
            List<string> keys = new List<string>();
            foreach (var kvp in data)
            {
                if (IsKeyValue(kvp.Value))
                {
                    keys.Add(kvp.Key);
                }
            }
            return (keys, keys.Count);
        }
    }
}
