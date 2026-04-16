using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.CoreManagement.KeyValueAsync
{
    internal interface IKeyValueStoreAsync
    {
        // ====================== SET Operations ======================
        Task SET(string key, int value);
        Task SET(string key, long value);
        Task SET(string key, double value);
        Task SET(string key, float value);
        Task SET(string key, decimal value);
        Task SET(string key, string value);
        Task SET(string key, char value);
        Task SET(string key, bool value);

        // ====================== Delete ======================
        Task<bool> DEL(string key);

        // ====================== Read Operations ======================
        Task<string?> GET(string key);
        Task<bool> EXISTS(string key);
        Task<List<string>> KEYS();
        Task<int> COUNT();

        // ====================== Rename ======================
        Task<bool> RENAME(string oldKey, string newKey);
    }
}
