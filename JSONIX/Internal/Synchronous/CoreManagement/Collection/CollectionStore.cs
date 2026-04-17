using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Internal.Synchronous.CoreManagement.Collection
{
    public partial class CollectionClass
    {
        internal Dictionary<string, object> data;
        internal bool flag = false;
        internal CollectionClass(Dictionary<string, object> dataLoad)
        {
            data = dataLoad ?? new Dictionary<string, object>();
        }

        protected void Insert_CollectionClass<T>(string key, T value)
        {
            if (!flag)
            {
                flag = true;
            }
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

        }

        protected bool Delete_CollectionClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!data.ContainsKey(key)) return false;

            if (!IsCollection(data[key])) return false;

            data.Remove(key);

            return true;
        }

        protected bool Delete_item_CollectionClass<T>(string key, T value)
        {
            if (!flag)
            {
                flag = true;
            }

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

            return Found;
        }

        protected List<object> Read_CollectionClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return null;
            return ConvertToList(data[key]);
        }

        protected bool Exists_CollectionClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return false;
            return true;
        }

        protected bool Exists_Item_CollectionClass<T>(string key, T value)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return false;
            var dataList = ConvertToList(data[key]);
            int NumRemoved = numFound(dataList, value);
            if (NumRemoved != -1)
            {
                return true;
            }
            return false;
        }

        protected bool Rename_CollectionClass(string oldKey, string newKey)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!data.ContainsKey(oldKey)) return false;
            if (data.ContainsKey(newKey)) return false;
            if (!IsCollection(data[oldKey])) return false;
            var value = data[oldKey];
            data.Remove(oldKey);
            data[newKey] = value;

            return true;
        }

        protected (List<string> Lists, int Count) Keys_CollectionClass()
        {
            if (!flag)
            {
                flag = true;
            }
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

        protected int Len_CollectionClass(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsCollection(data[key]))) return -1;
            var dataList = ConvertToList(data[key]);
            return dataList.Count;
        }
    }
}