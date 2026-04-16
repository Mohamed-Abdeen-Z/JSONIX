using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.Collection
{
    internal interface ICollectionStore
    {
        // ====================== APPEND Operations ======================
        void APPEND(string key, int value);
        void APPEND(string key, long value);
        void APPEND(string key, double value);
        void APPEND(string key, float value);
        void APPEND(string key, decimal value);
        void APPEND(string key, string value);
        void APPEND(string key, char value);
        void APPEND(string key, bool value);

        void APPEND(string key, params int[] value);
        void APPEND(string key, params long[] value);
        void APPEND(string key, params double[] value);
        void APPEND(string key, params float[] value);
        void APPEND(string key, params decimal[] value);
        void APPEND(string key, params string[] value);
        void APPEND(string key, params char[] value);
        void APPEND(string key, params bool[] value);

        // ====================== Delete ======================
        bool DEL(string key);
        bool LDEL(string key, int value);
        bool LDEL(string key, long value);
        bool LDEL(string key, double value);
        bool LDEL(string key, float value);
        bool LDEL(string key, decimal value);
        bool LDEL(string key, string value);
        bool LDEL(string key, char value);
        bool LDEL(string key, bool value);

        bool LDEL(string key, params int[] value);
        bool LDEL(string key, params long[] value);
        bool LDEL(string key, params double[] value);
        bool LDEL(string key, params float[] value);
        bool LDEL(string key, params decimal[] value);
        bool LDEL(string key, params string[] value);
        bool LDEL(string key, params char[] value);
        bool LDEL(string key, params bool[] value);

        // ====================== Read Operations ======================
        List<object> FETCH(string key);
        List<string> KEYS();
        int COUNT(string key);
        int LEN(string key);
        bool EXISTS(string key);
        bool EXISTS(string key, object value);

        // ====================== Rename ======================
        bool RENAME(string oldKey, string newKey);

    }
}
