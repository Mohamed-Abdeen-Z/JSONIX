using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.Hashes
{
    internal interface IHashesStore
    {
        // ====================== HSET Operations ======================
        void HSET(string key, string field, int value);
        void HSET(string key, string field, long value);
        void HSET(string key, string field, double value);
        void HSET(string key, string field, float value);
        void HSET(string key, string field, decimal value);
        void HSET(string key, string field, string value);
        void HSET(string key, string field, char value);
        void HSET(string key, string field, bool value);

        void HSET(string key, string field, params int[] value);
        void HSET(string key, string field, params long[] value);
        void HSET(string key, string field, params double[] value);
        void HSET(string key, string field, params float[] value);
        void HSET(string key, string field, params decimal[] value);
        void HSET(string key, string field, params string[] value);
        void HSET(string key, string field, params char[] value);
        void HSET(string key, string field, params bool[] value);

        // ====================== Delete ======================
        bool DEL(string key);
        bool DEL(string key, string field);
        bool DEL(string key, params string[] field);

        bool HDEL(string key, string field, int value);
        bool HDEL(string key, string field, long value);
        bool HDEL(string key, string field, double value);
        bool HDEL(string key, string field, float value);
        bool HDEL(string key, string field, decimal value);
        bool HDEL(string key, string field, string value);
        bool HDEL(string key, string field, char value);
        bool HDEL(string key, string field, bool value);

        bool HDEL(string key, string field, params int[] value);
        bool HDEL(string key, string field, params long[] value);
        bool HDEL(string key, string field, params double[] value);
        bool HDEL(string key, string field, params float[] value);
        bool HDEL(string key, string field, params decimal[] value);
        bool HDEL(string key, string field, params string[] value);
        bool HDEL(string key, string field, params char[] value);
        bool HDEL(string key, string field, params bool[] value);

        // ====================== Read Operations ======================
        Dictionary<string, object> GET(string key);

        dynamic HGET(string key, string field);
        bool EXISTS(string key);
        bool HEXISTS(string key, string field);

        bool HITEM_EXISTS(string key, string field, int value);
        bool HITEM_EXISTS(string key, string field, long value);
        bool HITEM_EXISTS(string key, string field, double value);
        bool HITEM_EXISTS(string key, string field, float value);
        bool HITEM_EXISTS(string key, string field, decimal value);
        bool HITEM_EXISTS(string key, string field, string value);
        bool HITEM_EXISTS(string key, string field, char value);
        bool HITEM_EXISTS(string key, string field, bool value);

        List<string> KEYS();
        int COUNT_KEYS();

        List<string> TOTAL_FIELDS();
        int COUNT_TOTAL_FIELDS();

        List<string> FIELDS(string key);
        int COUNT_FIELDS(string key);

        // ====================== Rename ======================
        bool RENAME(string oldKey, string newKey);
        bool HRENAME(string oldKey, string field, string newField);
    }
}
