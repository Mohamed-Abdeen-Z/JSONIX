using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Internal.Asynchronous.CoreManagement.HashesAsync
{
    public partial class HashesClassAsync
    {
        internal Dictionary<string, object> data;
        internal bool flag = false;
        internal HashesClassAsync(Task<Dictionary<string, object>> dataLoad)
        {
            data = dataLoad.Result ?? new Dictionary<string, object>();
        }

        protected async Task Insert_HashesClassAsync<T>(string key, string field, T value)
        {
            if (!flag)
            {
                flag = true;
            }

            var dataDic = (data.ContainsKey(key) && IsHashes(data[key])) ? ConvertToDictionary(data[key]) : new Dictionary<string, object>();

            if (dataDic.ContainsKey(field))
            {
                if (IsCollection(dataDic[field]))
                {
                    var dataList = ConvertToList(dataDic[field]);

                    if (value is IEnumerable enumerable && value is not string)
                    {
                        foreach (var item in enumerable)
                            dataList.Add(item);
                    }
                    else
                    {
                        dataList.Add(value);
                    }
                    dataDic[field] = dataList;
                }
                else
                {
                    if (value is not IEnumerable enumerable)
                        dataDic[field] = value;
                }
            }
            else
            {
                if (value is IEnumerable enumerable && value is not string)
                {
                    var dataList = new List<object>();
                    foreach (var item in enumerable)
                        dataList.Add(item);
                    dataDic[field] = dataList;
                }
                else
                {
                    dataDic[field] = value;
                }
            }

            data[key] = dataDic;
        }

        protected async Task<bool> Delete_HashesClassAsync(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!data.ContainsKey(key)) return false;

            if (!IsHashes(data[key])) return false;

            data.Remove(key);
            return true;
        }

        protected async Task<bool> Delete_Hashes_HashesClassAsync<T>(string key, T field)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return false;

            var dataDic = ConvertToDictionary(data[key]);

            bool isRemoved = false;
            if (field is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if (dataDic.Remove(item.ToString()))
                    {
                        isRemoved = true;
                    }
                }
            }
            else
            {
                if (dataDic.Remove(field.ToString()))
                {
                    isRemoved = true;
                }
            }

            data[key] = dataDic;
            return isRemoved;
        }

        protected async Task<bool> Delete_item_HashesClassAsync<T>(string key, string field, T value)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return false;

            var dataDic = ConvertToDictionary(data[key]);

            if (!dataDic.ContainsKey(field)) return false;

            bool Found = false;

            if (value is IEnumerable enumerable && value is not string)
            {
                var dataList = dataDic.ContainsKey(field) && IsCollection(dataDic[field]) ? ConvertToList(dataDic[field]) : new List<object>();
                foreach (var item in enumerable)
                {
                    int NumRemoved = numFound(dataList, item);
                    if (NumRemoved != -1)
                    {
                        dataList.RemoveAt(NumRemoved);
                        Found = true;
                    }
                }
                if (Found)
                {
                    dataDic[field] = dataList;
                }
            }
            else
            {
                if (dataDic.ContainsKey(field) && IsCollection(dataDic[field]))
                {
                    var dataList = ConvertToList(dataDic[field]);
                    int NumRemoved = numFound(dataList, value);
                    if (NumRemoved != -1)
                    {
                        dataList.RemoveAt(NumRemoved);
                        dataDic[field] = dataList;
                        Found = true;
                    }
                }
                else
                {
                    dataDic[field] = "NULL";
                }
            }

            data[key] = dataDic;

            return Found;
        }

        protected async Task<Dictionary<string, object>> ReadKey_HashesClassAsync(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return null;
            return ConvertToDictionary(data[key]);
        }

        protected async Task<dynamic> ReadKeyField_HashesClassAsync(string key, string field)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return null;
            var dataDic = ConvertToDictionary(data[key]);
            if (!dataDic.ContainsKey(field)) return null;

            if (IsCollection(dataDic[field]))
            {
                return ConvertToList(dataDic[field]);
            }
            return (dataDic[field]).ToString();
        }

        protected async Task<bool> KeyExists_HashesClassAsync(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            return data.ContainsKey(key) && IsHashes(data[key]);
        }

        protected async Task<bool> FieldExists_HashesClassAsync(string key, string field)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return false;
            var dataDic = ConvertToDictionary(data[key]);
            return dataDic.ContainsKey(field);
        }

        protected async Task<bool> ItemExists_HashesClassAsync(string key, string field, object value)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return false;
            var dataDic = ConvertToDictionary(data[key]);
            if (!dataDic.ContainsKey(field)) return false;
            if (IsCollection(dataDic[field]))
            {
                var dataList = ConvertToList(dataDic[field]);
                return numFound(dataList, value) != -1;
            }
            return (dataDic[field]).ToString() == value.ToString();
        }

        protected async Task<(List<string> keys, List<string> fields, int countKeys, int countFields)> Search_HashesClassAsync()
        {
            if (!flag)
            {
                flag = true;
            }
            var keys = new List<string>();
            var fields = new List<string>();
            int countKeys = 0;
            int countFields = 0;
            foreach (var kvp in data)
            {
                if (IsHashes(kvp.Value))
                {
                    keys.Add(kvp.Key);

                    var dataDic = ConvertToDictionary(kvp.Value);

                    foreach (var field in dataDic)
                    {
                        fields.Add(field.Key);
                    }
                }
            }
            return (keys, fields, keys.Count, fields.Count);
        }

        protected async Task<(List<string> field, int count)> SearchField_HashesClassAsync(string key)
        {
            if (!flag)
            {
                flag = true;
            }
            var fields = new List<string>();
            int countFields = 0;
            if (data.ContainsKey(key) && IsHashes(data[key]))
            {
                var dataDic = ConvertToDictionary(data[key]);
                foreach (var field in dataDic)
                {
                    fields.Add(field.Key);
                }
            }
            return (fields, fields.Count);
        }

        protected async Task<bool> Rename_HashesClassAsync(string oldKey, string newKey)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!data.ContainsKey(oldKey) || data.ContainsKey(newKey)) return false;
            if (!IsHashes(data[oldKey])) return false;
            var value = data[oldKey];
            data.Remove(oldKey);
            data[newKey] = value;
            return true;
        }

        protected async Task<bool> RenameField_HashesClassAsync(string key, string oldField, string newField)
        {
            if (!flag)
            {
                flag = true;
            }
            if (!(data.ContainsKey(key) && IsHashes(data[key]))) return false;
            var dataDic = ConvertToDictionary(data[key]);
            if (!dataDic.ContainsKey(oldField) || dataDic.ContainsKey(newField)) return false;
            var value = dataDic[oldField];
            dataDic.Remove(oldField);
            dataDic[newField] = value;
            data[key] = dataDic;
            return true;
        }
    }
}
