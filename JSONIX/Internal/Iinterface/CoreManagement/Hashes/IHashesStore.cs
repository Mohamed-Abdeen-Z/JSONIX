using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.Hashes
{
    internal interface IHashesStore
    {
        public void HSET(string key, string field, int value);
        public void HSET(string key, string field, long value);
        public void HSET(string key, string field, double value);
        public void HSET(string key, string field, float value);
        public void HSET(string key, string field, decimal value);
        public void HSET(string key, string field, string value);
        public void HSET(string key, string field, char value);
        public void HSET(string key, string field, bool value);

        public void HSET(string key, string field, params int[] value);
        public void HSET(string key, string field, params long[] value);
        public void HSET(string key, string field, params double[] value);
        public void HSET(string key, string field, params float[] value);
        public void HSET(string key, string field, params decimal[] value);
        public void HSET(string key, string field, params string[] value);
        public void HSET(string key, string field, params char[] value);
        public void HSET(string key, string field, params bool[] value);

        //==================================
        //==================================

        public bool DEL(string key);

        public bool DEL(string key, string field);
        public bool DEL(string key, params string[] field);

        public bool HDEL(string key, string field, int value);
        public bool HDEL(string key, string field, long value);
        public bool HDEL(string key, string field, double value);
        public bool HDEL(string key, string field, float value);
        public bool HDEL(string key, string field, decimal value);
        public bool HDEL(string key, string field, string value);
        public bool HDEL(string key, string field, char value);
        public bool HDEL(string key, string field, bool value);

        public bool HDEL(string key, string field, params int[] value);
        public bool HDEL(string key, string field, params long[] value);
        public bool HDEL(string key, string field, params double[] value);
        public bool HDEL(string key, string field, params float[] value);
        public bool HDEL(string key, string field, params decimal[] value);
        public bool HDEL(string key, string field, params string[] value);
        public bool HDEL(string key, string field, params char[] value);
        public bool HDEL(string key, string field, params bool[] value);

        public Dictionary<string, object> GET(string key);

        public dynamic HGET(string key, string field);

        public bool EXISTS(string key);
        public bool HEXISTS(string key, string field);

        public bool HITEM_EXISTS(string key, string field, int value);
        public bool HITEM_EXISTS(string key, string field, long value);
        public bool HITEM_EXISTS(string key, string field, double value);
        public bool HITEM_EXISTS(string key, string field, float value);
        public bool HITEM_EXISTS(string key, string field, decimal value);
        public bool HITEM_EXISTS(string key, string field, string value);
        public bool HITEM_EXISTS(string key, string field, char value);
        public bool HITEM_EXISTS(string key, string field, bool value);

        public List<string> KEYS();

        public List<string> TOTAL_FIELDS();

        public int COUNT_KEYS();
        public int COUNT_TOTAL_FIELDS();

        public List<string> FIELDS(string key);

        public int COUNT_FIELDS(string key);

        public bool RENAME(string oldKey, string newKey);

        public bool HRENAME(string oldKey, string field, string newField);

    }
}
