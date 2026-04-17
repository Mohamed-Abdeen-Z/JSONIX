using Internal.Iinterface.CoreManagement.HashesAsync;
using Internal.Asynchronous.CoreManagement.HashesAsync;
using System;
using System.Collections.Generic;
using System.Text;

namespace HashesAsync
{
    public class HashesAsyncF : HashesClassAsync, IHashesStoreAsync
    {
        internal HashesAsyncF(Task<Dictionary<string,object>> dataLoad) : base(dataLoad)
        {
        }

        /// <summary>
        /// Sets an integer value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>int</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, int value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a long value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>long</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, long value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a double value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>double</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, double value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a float value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>float</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, float value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a decimal value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>decimal</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, decimal value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a string value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>string</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, string value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a char value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>char</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, char value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets a boolean value for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>bool</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, bool value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more integer values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params int[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params int[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more long values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params long[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params long[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more double values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params double[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params double[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more float values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params float[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params float[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more decimal values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params decimal[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params decimal[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more string values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params string[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params string[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more char values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params char[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params char[] value) => Insert_HashesClassAsync(key, field, value);

        /// <summary>
        /// Sets one or more boolean values for the specified field in the hash stored at the given key.
        /// If the hash or field does not exist, it will be created.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field within the hash.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params bool[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public Task HSET(string key, string field, params bool[] value) => Insert_HashesClassAsync(key, field, value);
        //==================================
        //==================================

        /// <summary>
        /// Deletes the entire hash stored at the specified key.
        /// </summary>
        /// <param name="key">The hash key to delete.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the hash was found and deleted successfully; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> DEL(string key) => Delete_HashesClassAsync(key);

        /// <summary>
        /// Deletes one or more fields from the hash stored at the specified key.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field to delete.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any field was deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> DEL(string key, string field) => Delete_Hashes_HashesClassAsync(key, field);

        /// <summary>
        /// Deletes one or more fields from the hash stored at the specified key.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The fields to delete.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>params string[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any field was deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> DEL(string key, params string[] field) => Delete_Hashes_HashesClassAsync(key, field);

        /// <summary>
        /// Deletes a specific integer value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>int</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, int value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific long value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>long</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, long value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific double value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>double</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, double value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific float value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>float</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, float value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific decimal value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>decimal</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, decimal value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific string value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, string value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific char value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>char</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, char value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes a specific boolean value from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>bool</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, bool value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more integer values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params int[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params int[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more long values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params long[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params long[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more double values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params double[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params double[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more float values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params float[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params float[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more decimal values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params decimal[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params decimal[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more string values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params string[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params string[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more char values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params char[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params char[] value) => Delete_item_HashesClassAsync(key, field, value);

        /// <summary>
        /// Deletes one or more boolean values from a field (collection) inside the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The values to delete from the field.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>params bool[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HDEL(string key, string field, params bool[] value) => Delete_item_HashesClassAsync(key, field, value);
        //==================================
        //==================================

        /// <summary>
        /// Returns the entire hash stored at the specified key as a dictionary.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A Dictionary<string, object> representing the hash, or null if the key does not exist or is not a hash.</returns>
        public Task<Dictionary<string, object>> GET(string key) => ReadKey_HashesClassAsync(key);

        /// <summary>
        /// Returns the value of a specific field in the hash.
        /// If the field contains a collection, it returns List<object>, otherwise returns the value as string.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b>
        /// </remarks>
        /// <returns>The value of the field (as string or List<object> if it's a collection), or null if not found.</returns>
        public Task<dynamic> HGET(string key, string field) => ReadKeyField_HashesClassAsync(key, field);

        /// <summary>
        /// Checks if the specified hash key exists in the store.
        /// </summary>
        /// <param name="key">The hash key to check.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the hash exists; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> EXISTS(string key) => KeyExists_HashesClassAsync(key);

        /// <summary>
        /// Checks if a specific field exists within the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field to check.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the field exists in the hash; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HEXISTS(string key, string field) => FieldExists_HashesClassAsync(key, field);

        /// <summary>
        /// Checks if a specific integer value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>int</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, int value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific long value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>long</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, long value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific double value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>double</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, double value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific float value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>float</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, float value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific decimal value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>decimal</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, decimal value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific char value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>char</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, char value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific boolean value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>bool</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, bool value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Checks if a specific string value exists within a field in the hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="field">The field name.</param>
        /// <param name="value">The value to look for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b> | Value type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the field; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HITEM_EXISTS(string key, string field, string value) => ItemExists_HashesClassAsync(key, field, value);

        /// <summary>
        /// Returns all hash keys present in the store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A list containing all hash keys in the store.</returns>
        public Task<List<string>> KEYS() => Search_HashesClassAsync().ContinueWith(t => t.Result.keys);

        /// <summary>
        /// Returns all fields from all hashes in the store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A list containing all fields across all hashes.</returns>
        public Task<List<string>> TOTAL_FIELDS() => Search_HashesClassAsync().ContinueWith(t => t.Result.fields);

        /// <summary>
        /// Returns the total number of hash keys in the store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The total count of hash keys.</returns>
        public Task<int> COUNT_KEYS() => Search_HashesClassAsync().ContinueWith(t => t.Result.countKeys);

        /// <summary>
        /// Returns the total number of fields across all hashes in the store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The total count of fields across all hashes.</returns>
        public Task<int> COUNT_TOTAL_FIELDS() => Search_HashesClassAsync().ContinueWith(t => t.Result.countFields);

        /// <summary>
        /// Returns all fields in the specified hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A list of all fields in the specified hash, or empty list if the key does not exist.</returns>
        public Task<List<string>> FIELDS(string key) => SearchField_HashesClassAsync(key).ContinueWith(t => t.Result.field);

        /// <summary>
        /// Returns the number of fields in the specified hash.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The number of fields in the hash, or 0 if the key does not exist.</returns>
        public Task<int> COUNT_FIELDS(string key) => SearchField_HashesClassAsync(key).ContinueWith(t => t.Result.count);

        /// <summary>
        /// Renames an existing hash key to a new key name.
        /// </summary>
        /// <param name="oldKey">The current hash key name.</param>
        /// <param name="newKey">The new hash key name.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the rename operation was successful; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> RENAME(string oldKey, string newKey) => Rename_HashesClassAsync(oldKey, newKey);

        /// <summary>
        /// Renames a field inside a hash to a new field name.
        /// </summary>
        /// <param name="key">The hash key.</param>
        /// <param name="oldField">The current field name.</param>
        /// <param name="newField">The new field name.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Field type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the field was renamed successfully; otherwise, <b>false</b>.
        /// </returns>
        public Task<bool> HRENAME(string oldKey, string field, string newField) => RenameField_HashesClassAsync(oldKey, field, newField);
    }
}
