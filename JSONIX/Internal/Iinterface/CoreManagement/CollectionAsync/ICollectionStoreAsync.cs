using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.CollectionAsync
{
    internal interface ICollectionStoreAsync
    {
        // ====================== APPEND Operations ======================
        Task APPEND(string key, int value);
        Task APPEND(string key, long value);
        Task APPEND(string key, double value);
        Task APPEND(string key, float value);
        Task APPEND(string key, decimal value);
        Task APPEND(string key, string value);
        Task APPEND(string key, char value);
        Task APPEND(string key, bool value);

        Task APPEND(string key, params int[] value);
        Task APPEND(string key, params long[] value);
        Task APPEND(string key, params double[] value);
        Task APPEND(string key, params float[] value);
        Task APPEND(string key, params decimal[] value);
        Task APPEND(string key, params string[] value);
        Task APPEND(string key, params char[] value);
        Task APPEND(string key, params bool[] value);

        // ====================== Delete ======================
        Task<bool> DEL(string key);
        Task<bool> LDEL(string key, int value);
        Task<bool> LDEL(string key, long value);
        Task<bool> LDEL(string key, double value);
        Task<bool> LDEL(string key, float value);
        Task<bool> LDEL(string key, decimal value);
        Task<bool> LDEL(string key, string value);
        Task<bool> LDEL(string key, char value);
        Task<bool> LDEL(string key, bool value);

        Task<bool> LDEL(string key, params int[] value);
        Task<bool> LDEL(string key, params long[] value);
        Task<bool> LDEL(string key, params double[] value);
        Task<bool> LDEL(string key, params float[] value);
        Task<bool> LDEL(string key, params decimal[] value);
        Task<bool> LDEL(string key, params string[] value);
        Task<bool> LDEL(string key, params char[] value);
        Task<bool> LDEL(string key, params bool[] value);

        // ====================== Read Operations ======================
        Task<List<object>> FETCH(string key);
        Task<List<string>> KEYS();
        Task<int> COUNT(string key);
        Task<int> LEN(string key);
        Task<bool> EXISTS(string key);
        Task<bool> EXISTS(string key, object value);

        // ====================== Rename ======================
        Task<bool> RENAME(string oldKey, string newKey);
    }
}
