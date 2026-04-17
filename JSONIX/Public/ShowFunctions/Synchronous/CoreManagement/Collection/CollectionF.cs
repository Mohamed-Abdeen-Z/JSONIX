using Internal.Iinterface.CoreManagement.Collection;
using Internal.Synchronous.CoreManagement.Collection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class CollectionF : CollectionClass, ICollectionStore
    {
        internal CollectionF(Dictionary<string, object> dataLoad) : base(dataLoad)
        {
        }

        /// <summary>
        /// Appends an integer value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>int</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, int value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a long value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>long</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, long value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a double value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>double</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, double value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a float value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>float</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, float value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a decimal value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>decimal</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, decimal value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a string value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>string</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, string value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a char value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>char</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, char value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends a boolean value to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>bool</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, bool value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more integer values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params int[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params int[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more long values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params long[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params long[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more double values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params double[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params double[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more float values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params float[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params float[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more decimal values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params decimal[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params decimal[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more string values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params string[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params string[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more char values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params char[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params char[] value) => Insert_CollectionClass(key, value);

        /// <summary>
        /// Appends one or more boolean values to the collection associated with the specified key.
        /// If the key does not exist, a new collection will be created.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be stored.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params bool[]</b>
        /// </remarks>
        /// <returns>No return value.</returns>
        public void APPEND(string key, params bool[] value) => Insert_CollectionClass(key, value);

        //==================================
        //==================================

        /// <summary>
        /// Deletes the specified key and its entire collection from the store.
        /// </summary>
        /// <param name="key">The key to delete.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the key was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool DEL(string key) => Delete_CollectionClass(key);

        /// <summary>
        /// Deletes a specific integer value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>int</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, int value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific long value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>long</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, long value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific double value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>double</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, double value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific float value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>float</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, float value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific decimal value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>decimal</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, decimal value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific string value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, string value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific char value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>char</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, char value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes a specific boolean value from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The value to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>bool</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, bool value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more integer values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params int[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params int[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more long values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params long[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params long[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more double values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params double[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params double[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more float values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params float[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params float[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more decimal values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params decimal[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params decimal[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more string values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params string[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params string[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more char values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params char[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params char[] value) => Delete_item_CollectionClass(key, value);

        /// <summary>
        /// Deletes one or more boolean values from the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to associate the value with.</param>
        /// <param name="value">The values to be deleted.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>params bool[]</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if any value was found and deleted; otherwise, <b>false</b>.
        /// </returns>
        public bool LDEL(string key, params bool[] value) => Delete_item_CollectionClass(key, value);

        //==================================
        //==================================
        /// <summary>
        /// Returns the entire collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key to fetch the collection from.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A List<object> containing all values in the collection, or null if the key does not exist.</returns>
        public List<object> FETCH(string key) => Read_CollectionClass(key);

        /// <summary>
        /// Returns all keys present in the collection store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>A list containing all keys in the collection store.</returns>
        public List<string> KEYS() => Keys_CollectionClass().Lists;

        /// <summary>
        /// Returns the total number of keys in the collection store.
        /// </summary>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The total count of keys in the collection store.</returns>
        public int COUNT(string key) => Keys_CollectionClass().Count;

        /// <summary>
        /// Returns the length (number of items) of the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the collection.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>The number of items in the collection, or 0 if the key does not exist.</returns>
        public int LEN(string key) => Len_CollectionClass(key);

        /// <summary>
        /// Checks if the specified key exists in the collection store.
        /// </summary>
        /// <param name="key">The key to check.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the key exists; otherwise, <b>false</b>.
        /// </returns>
        public bool EXISTS(string key) => Exists_CollectionClass(key);

        /// <summary>
        /// Checks if a specific value exists within the collection associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the collection.</param>
        /// <param name="value">The value to check for.</param>
        /// <remarks>
        /// Key type: <b>string</b> | Value type: <b>object</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the value exists in the collection; otherwise, <b>false</b>.
        /// </returns>
        public bool EXISTS(string key, object value) => Exists_Item_CollectionClass(key, value);

        /// <summary>
        /// Renames an existing collection key to a new key name.
        /// </summary>
        /// <param name="oldKey">The current key name.</param>
        /// <param name="newKey">The new key name.</param>
        /// <remarks>
        /// Key type: <b>string</b>
        /// </remarks>
        /// <returns>
        /// <b>true</b> if the rename operation was successful; otherwise, <b>false</b>.
        /// </returns>
        public bool RENAME(string oldKey, string newKey) => Rename_CollectionClass(oldKey, newKey);

    }
}
