using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.HashesAsync
{
    internal interface IHashesStoreAsync
    {
        // ====================== HSET Operations ======================
        Task HSET(string key, string field, int value);
        Task HSET(string key, string field, long value);
        Task HSET(string key, string field, double value);
        Task HSET(string key, string field, float value);
        Task HSET(string key, string field, decimal value);
        Task HSET(string key, string field, string value);
        Task HSET(string key, string field, char value);
        Task HSET(string key, string field, bool value);

        Task HSET(string key, string field, params int[] value);
        Task HSET(string key, string field, params long[] value);
        Task HSET(string key, string field, params double[] value);
        Task HSET(string key, string field, params float[] value);
        Task HSET(string key, string field, params decimal[] value);
        Task HSET(string key, string field, params string[] value);
        Task HSET(string key, string field, params char[] value);
        Task HSET(string key, string field, params bool[] value);

        // ====================== Delete ======================
        Task<bool> DEL(string key);
        Task<bool> DEL(string key, string field);
        Task<bool> DEL(string key, params string[] field);

        Task<bool> HDEL(string key, string field, int value);
        Task<bool> HDEL(string key, string field, long value);
        Task<bool> HDEL(string key, string field, double value);
        Task<bool> HDEL(string key, string field, float value);
        Task<bool> HDEL(string key, string field, decimal value);
        Task<bool> HDEL(string key, string field, string value);
        Task<bool> HDEL(string key, string field, char value);
        Task<bool> HDEL(string key, string field, bool value);

        Task<bool> HDEL(string key, string field, params int[] value);
        Task<bool> HDEL(string key, string field, params long[] value);
        Task<bool> HDEL(string key, string field, params double[] value);
        Task<bool> HDEL(string key, string field, params float[] value);
        Task<bool> HDEL(string key, string field, params decimal[] value);
        Task<bool> HDEL(string key, string field, params string[] value);
        Task<bool> HDEL(string key, string field, params char[] value);
        Task<bool> HDEL(string key, string field, params bool[] value);

        // ====================== Read Operations ======================
        Task<Dictionary<string, object>> GET(string key);

        Task<dynamic> HGET(string key, string field);
        Task<bool> EXISTS(string key);
        Task<bool> HEXISTS(string key, string field);

        Task<bool> HITEM_EXISTS(string key, string field, int value);
        Task<bool> HITEM_EXISTS(string key, string field, long value);
        Task<bool> HITEM_EXISTS(string key, string field, double value);
        Task<bool> HITEM_EXISTS(string key, string field, float value);
        Task<bool> HITEM_EXISTS(string key, string field, decimal value);
        Task<bool> HITEM_EXISTS(string key, string field, string value);
        Task<bool> HITEM_EXISTS(string key, string field, char value);
        Task<bool> HITEM_EXISTS(string key, string field, bool value);

        Task<List<string>> KEYS();
        Task<int> COUNT_KEYS();

        Task<List<string>> TOTAL_FIELDS();
        Task<int> COUNT_TOTAL_FIELDS();

        Task<List<string>> FIELDS(string key);
        Task<int> COUNT_FIELDS(string key);

        // ====================== Rename ======================
        Task<bool> RENAME(string oldKey, string newKey);
        Task<bool> HRENAME(string oldKey, string field, string newField);
    }
}
