using Internal.Asynchronous.EngineAsync;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Internal.Asynchronous.CoreManagement.CollectionAsync
{
    public partial class CollectionClassAsync
    {
        private ClassEngineAsync _Engine;
        internal CollectionClassAsync(ClassEngineAsync engine)
        {
            _Engine = engine;
        }

        protected async Task Insert_CollectionClassAsync<T>(string key, T value)
        {
            var data = await _Engine.LoadAsync();
            var dataList = (data.ContainsKey(key) && IsCollection(data[key])) ? ConvertToList(data[key]) : new List<object>();

            if (value is IEnumerable enumerable && value is not string)
            {
                foreach (var item in enumerable)
                    dataList.Add(item);
            }
            else
            {
                dataList.Add(value);
            }

            data[key] = dataList;
            await _Engine.InsertAsync(data);
        }

        protected async Task<bool> Delete_CollectionClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!data.ContainsKey(key)) return false;

            if (!IsCollection(data[key])) return false;

            data.Remove(key);
            await _Engine.InsertAsync(data);
            return true;
        }

        protected async Task<bool> Delete_item_CollectionClassAsync<T>(string key, T value)
        {
            var data = await _Engine.LoadAsync();

            if (!(data.ContainsKey(key) && IsCollection(data[key])))
            {
                return false;
            }

            var dataList = ConvertToList(data[key]);
            bool Found = false;

            if (value is IEnumerable enumerable && value is not string)
            {
                foreach (var item in enumerable)
                {
                    int NumRemoved = numFound(dataList, item);
                    if (NumRemoved != -1)
                    {
                        dataList.RemoveAt(NumRemoved);
                        Found = true;
                    }
                }
            }
            else
            {
                int NumRemoved = numFound(dataList, value);
                if (NumRemoved != -1)
                {
                    dataList.RemoveAt(NumRemoved);
                    Found = true;
                }
            }
            data[key] = dataList;
            await _Engine.InsertAsync(data);
            return Found;
        }

        protected async Task<List<object>> Read_CollectionClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return null;
            return ConvertToList(data[key]);
        }

        protected async Task<bool> Exists_CollectionClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return false;
            return true;
        }

        protected async Task<bool> Exists_Item_CollectionClassAsync<T>(string key, T value)
        {
            var data = await _Engine.LoadAsync();
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return false;
            var dataList = ConvertToList(data[key]);
            int NumRemoved = numFound(dataList, value);
            if (NumRemoved != -1)
            {
                return true;
            }
            return false;
        }

        protected async Task<bool> Rename_CollectionClassAsync(string oldKey, string newKey)
        {
            var data = await _Engine.LoadAsync();
            if (!data.ContainsKey(oldKey)) return false;
            if (data.ContainsKey(newKey)) return false;
            if (!IsCollection(data[oldKey])) return false;
            var value = data[oldKey];
            data.Remove(oldKey);
            data[newKey] = value;
            await _Engine.InsertAsync(data);
            return true;
        }

        protected async Task<(List<string> Lists, int Count)> Keys_CollectionClassAsync()
        {
            var data = await _Engine.LoadAsync();
            List<string> keys = new List<string>();
            foreach (var kvp in data)
            {
                if (IsCollection(kvp.Value))
                {
                    keys.Add(kvp.Key);
                }
            }
            return (keys, keys.Count);
        }

        protected async Task<int> Len_CollectionClassAsync(string key)
        {
            var data = await _Engine.LoadAsync();
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return -1;
            var dataList = ConvertToList(data[key]);
            return dataList.Count;
        }
    }
}
