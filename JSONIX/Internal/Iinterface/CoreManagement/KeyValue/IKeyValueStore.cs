using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.KeyValue
{
    internal interface IKeyValueStore
    {
        void SET(string key, int value);
        void SET(string key, long value);
        void SET(string key, double value);
        void SET(string key, float value);
        void SET(string key, decimal value);
        //==================================
        void SET(string key, string value);
        void SET(string key, char value);
        //==================================
        void SET(string key, bool value);
        //==================================
        //==================================
        bool DEL(string key);
        //==================================
        //==================================
        string GET(string key);
        bool EXISTS(string key);
        List<string> KEYS();
        int COUNT();
        //==================================
        //==================================
        bool RENAME(string oldKey, string newKey);
    }
}
