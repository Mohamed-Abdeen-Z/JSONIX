using Internal.Asynchronous.EngineAsync;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Asynchronous.CoreManagement.KeyValueAsync
{
    public partial class KeyValueClassAsync
    {
        private ClassEngineAsync _Engine;
        internal KeyValueClassAsync(ClassEngineAsync engine)
        {
            _Engine = engine;
        }

        protected async Task Insert_KeyValueClassAsync(string key, object value)
        {
            var data = await _Engine.LoadAsync();
            data[key] = value;
            await _Engine.InsertAsync(data);
        }

        protected async Task<bool> Delete_KeyValueClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!data.ContainsKey(key)) return false;

            if (!IsKeyValue(data[key])) return false;

            data.Remove(key);
            await _Engine.InsertAsync(data);
            return true;
        }

        protected async Task<string?> Read_KeyValueClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]) )) return null;
            return data[key]?.ToString();
        }

        protected async Task<bool> Rename_KeyValueClassAsync(string oldKey, string newKey)
        {
            var data = await _Engine.LoadAsync();
            if (!data.ContainsKey(oldKey)) return false;
            if (data.ContainsKey(newKey)) return false;
            if (!IsKeyValue(data[oldKey])) return false;
            var value = data[oldKey];
            data.Remove(oldKey);
            data[newKey] = value;
            await _Engine.InsertAsync(data);
            return true;
        }

        protected async Task<bool> Exists_KeyValueClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!(data.ContainsKey(key) && IsKeyValue(data[key]) )) return false;

            return true;
        }

        protected async Task<(List<string> Lists, int Count)> Keys_KeyValueClassAsync()
        {
            var data = await _Engine.LoadAsync();
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
