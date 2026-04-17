using Internal.Iinterface.CoreManagement.KeyValue;
using Internal.Synchronous.CoreManagement.KeyValue;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValue
{
    public class KeyValueF : KeyValueClass, IKeyValueStore
    {
        internal KeyValueF(Dictionary<string, object> dataLoad) : base(dataLoad)
        {
        }
        /// <summary>
        /// Sets an integer value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>int</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, int value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a long value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>long</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, long value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a double value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>double</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, double value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a float value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>float</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, float value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a decimal value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>decimal</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, decimal value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a string value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>string</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, string value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a char value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>char</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, char value) => Insert_KeyValueClass(key, value);

        /// <summary>
        /// Sets a boolean value for the specified string key in the key-value store.
        /// If the key already exists, the previous value will be overwritten.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>bool</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void SET(string key, bool value) => Insert_KeyValueClass(key, value);
        //==================================
        //==================================
        /// <summary>
        /// Deletes the specified key and its associated value from the key-value store.
        /// If the key does not exist, no action is taken.
        /// </summary>
        /// <param name="key">The key to delete.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the key was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool DEL(string key) => Delete_KeyValueClass(key);
        //==================================
        //==================================
        /// <summary>
        /// Gets the string value associated with the specified key from the key-value store.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The string value if the key exists, otherwise null.</returns>
        public string GET(string key) => Read_KeyValueClass(key);

        /// <summary>
        /// Checks if the specified key exists in the key-value store.
        /// </summary>
        /// <param name="key">The key to check.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the key exists; otherwise, <b>false</b>.
        /// </returns>
        public bool EXISTS(string key) => Exists_KeyValueClass(key);

        /// <summary>
        /// Returns all keys present in the key-value store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A list containing all keys in the store.</returns>
        public List<string> KEYS() => Keys_KeyValueClass().Lists;

        /// <summary>
        /// Returns the total number of keys in the key-value store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The total count of keys.</returns>
        public int COUNT() => Keys_KeyValueClass().Count;
        //==================================
        //==================================

        /// <summary>
        /// Renames an existing key in the key-value store.
        /// </summary>
        /// <param name="oldKey">The current key to be renamed.</param>
        /// <param name="newKey">The new key name.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the key was successfully renamed; otherwise, <b>false</b>.
        /// </returns>
        public bool RENAME(string oldKey, string newKey) => Rename_KeyValueClass(oldKey, newKey);
    }
}
