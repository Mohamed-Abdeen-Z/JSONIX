using Internal.Iinterface.CoreManagement.KeyValueAsync;
using Internal.Asynchronous.CoreManagement.KeyValueAsync;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueAsync
{
    public class KeyValueAsyncF : KeyValueClassAsync, IKeyValueStoreAsync
    {
        internal KeyValueAsyncF(Task<Dictionary<string, object>> dataLoad) : base(dataLoad)
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
        public Task SET(string key, int value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, long value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, double value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, float value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, decimal value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, string value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, char value) => Insert_KeyValueClassAsync(key, value);

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
        public Task SET(string key, bool value) => Insert_KeyValueClassAsync(key, value);
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
        public Task<bool> DEL(string key) => Delete_KeyValueClassAsync(key);
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
        public Task<string> GET(string key) => Read_KeyValueClassAsync(key);

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
        public Task<bool> EXISTS(string key) => Exists_KeyValueClassAsync(key);

        /// <summary>
        /// Returns all keys present in the key-value store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A list containing all keys in the store.</returns>
        public Task<List<string>> KEYS() => Keys_KeyValueClassAsync().ContinueWith(t => t.Result.Lists);

        /// <summary>
        /// Returns the total number of keys in the key-value store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The total count of keys.</returns>
        public Task<int> COUNT() => Keys_KeyValueClassAsync().ContinueWith(t => t.Result.Count);
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
        public Task<bool> RENAME(string oldKey, string newKey) => Rename_KeyValueClassAsync(oldKey, newKey);
    }
}
