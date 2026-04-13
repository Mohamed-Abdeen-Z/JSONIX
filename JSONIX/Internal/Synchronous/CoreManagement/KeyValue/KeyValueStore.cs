using Internal.Iinterface.Engine;
using Internal.Synchronous.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Synchronous.CoreManagement.KeyValue
{
    public partial class KeyValueClass
    {
        private ClassEngine _Engine;
        internal KeyValueClass(ClassEngine engine)
        {
            _Engine = engine;
        }

        protected void Insert_KeyValueClass(string key, object value)
        {
            var data = _Engine.Load();
            data[key] = value;
            _Engine.Insert(data);
        }

        protected bool Delete_KeyValueClass(string key)
        {
            var data = _Engine.Load();
            if (!data.ContainsKey(key)) return false;

            if (!IsKeyValue(data[key])) return false;

            data.Remove(key);
            _Engine.Insert(data);
            return true;
        }

        protected string Read_KeyValueClass(string key)
        {
            var data = _Engine.Load();
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]) )) return null;
            return data[key]?.ToString();
        }

        protected bool Rename_KeyValueClass(string oldKey, string newKey)
        {
            var data = _Engine.Load();
            if (!data.ContainsKey(oldKey)) return false;
            if (data.ContainsKey(newKey)) return false;
            if (!IsKeyValue(data[oldKey])) return false;
            var value = data[oldKey];
            data.Remove(oldKey);
            data[newKey] = value;
            _Engine.Insert(data);
            return true;
        }

        protected bool Exists_KeyValueClass(string key)
        {
            var data = _Engine.Load();
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]) )) return false;

            return true;
        }

        protected (List<string> Lists,int Count) Keys_KeyValueClass()
        {
            var data = _Engine.Load();
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
