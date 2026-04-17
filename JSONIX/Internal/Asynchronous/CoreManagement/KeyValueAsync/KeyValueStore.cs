using Internal.Asynchronous.EngineAsync;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Asynchronous.CoreManagement.KeyValueAsync
{
    public partial class KeyValueClassAsync
    {
        internal Dictionary<string, object> data;
        internal bool flag = false;
        internal KeyValueClassAsync(Task<Dictionary<string, object>> dataLoad)
        {
            data = dataLoad.Result ?? new Dictionary<string, object>();
        }

        protected async Task Insert_KeyValueClassAsync(string key, object value)
        {
            if (!flag)
            {
                flag = true;
            }
            data[key] = value;
        }

        protected async Task<bool> Delete_KeyValueClassAsync(string key)
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

        protected async Task<string?> Read_KeyValueClassAsync(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]))) return null;
            return data[key]?.ToString();
        }

        protected async Task<bool> Rename_KeyValueClassAsync(string oldKey, string newKey)
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

        protected async Task<bool> Exists_KeyValueClassAsync(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]))) return false;

            return true;
        }

        protected async Task<(List<string> Lists, int Count)> Keys_KeyValueClassAsync()
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
