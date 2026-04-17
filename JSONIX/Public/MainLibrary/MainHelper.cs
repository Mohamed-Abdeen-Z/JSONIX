using Collection;
using CollectionAsync;
using Hashes;
using HashesAsync;
using Internal.Asynchronous.EngineAsync;
using Internal.Synchronous.Engine;
using JSONIX.Exceptions;
using KeyValue;
using KeyValueAsync;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JSONIX
{
    public partial class Client : IAsyncDisposable,IDisposable
    {
        private string _database;
        private bool _disposed = false;
        private ClassEngine engine;
        private ClassEngineAsync engineAsync;

        /// <summary>
        /// Represents a key-value pair with floating-point values.
        /// </summary>
        public KeyValueF KeyValue;
        /// <summary>
        /// Represents the collection of items managed by this instance.
        /// </summary>
        public CollectionF Collection;
        /// <summary>
        /// Gets or sets the collection of hash values associated with the current instance.
        /// </summary>
        public HashesF Hashes;

        /// <summary>
        /// Gets or sets the asynchronous function used to retrieve a key-value pair.
        /// </summary>
        public KeyValueAsyncF KeyValueAsync;
        /// <summary>
        /// Gets or sets the asynchronous collection handler used to perform collection operations asynchronously.
        /// </summary>
        public CollectionAsyncF CollectionAsync;
        /// <summary>
        /// Gets or sets the delegate used to asynchronously compute hash values.
        /// </summary>
        public HashesAsyncF HashesAsync;


        public bool Save()
        {
            try
            {
                var data = engine.Load();

                if (KeyValue.flag && KeyValue.data != null)
                {
                    foreach (var item in KeyValue.data)
                    {
                        if (data.ContainsKey(item.Key) && (IsCollection(data[item.Key]) || IsHashes(data[item.Key])))
                        {
                            continue;
                        }
                        data[item.Key] = item.Value;
                    }
                }
                if (Collection.flag && Collection.data != null)
                {
                    foreach (var item in Collection.data)
                    {
                        if (data.ContainsKey(item.Key) && (IsKeyValue(data[item.Key]) || IsHashes(data[item.Key])))
                        {
                            continue;
                        }
                        data[item.Key] = item.Value;
                    }
                }
                if (Hashes.flag && Hashes.data != null)
                {
                    foreach (var item in Hashes.data)
                    {
                        if (data.ContainsKey(item.Key) && (IsKeyValue(data[item.Key]) || IsCollection(data[item.Key])))
                        {
                            continue;
                        }
                        data[item.Key] = item.Value;
                    }
                }
                if (KeyValue.flag || Collection.flag || Hashes.flag)
                {
                    engine.Insert(data);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new IXActionFailedException($"JSONIX Save Error: {ex.Message}");
            }
            finally
            {
                KeyValue.flag = false;
                Collection.flag = false;
                Hashes.flag = false;

                KeyValue.data?.Clear();
                Collection.data?.Clear();
                Hashes.data?.Clear();
            }
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                var data = await engineAsync.LoadAsync();

                if (KeyValueAsync.flag && KeyValueAsync.data != null)
                {
                    foreach (var item in KeyValueAsync.data)
                    {
                        if (data.ContainsKey(item.Key) && (IsCollection(data[item.Key]) || IsHashes(data[item.Key])))
                        {
                            continue;
                        }
                        data[item.Key] = item.Value;
                    }
                }

                if (CollectionAsync.flag && CollectionAsync.data != null)
                {
                    foreach (var item in CollectionAsync.data)
                    {
                        if (data.ContainsKey(item.Key) && (IsKeyValue(data[item.Key]) || IsHashes(data[item.Key])))
                        {
                            continue;
                        }
                        data[item.Key] = item.Value;
                    }
                }

                if (HashesAsync.flag && HashesAsync.data != null)
                {
                    foreach (var item in HashesAsync.data)
                    {
                        if (data.ContainsKey(item.Key) && (IsKeyValue(data[item.Key]) || IsCollection(data[item.Key])))
                        {
                            continue;
                        }
                        data[item.Key] = item.Value;
                    }
                }

                if (KeyValueAsync.flag || CollectionAsync.flag || HashesAsync.flag)
                {
                    await engineAsync.InsertAsync(data);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new IXActionFailedException($"JSONIX Save Error: {ex.Message}");
            }
            finally
            {
                KeyValueAsync.flag = false;
                CollectionAsync.flag = false;
                HashesAsync.flag = false;

                KeyValueAsync.data?.Clear();
                CollectionAsync.data?.Clear();
                HashesAsync.data?.Clear();
            }
        }
        public void Dispose()
        {
            if (_disposed) return;

            try
            {
                if (KeyValue.flag || Collection.flag || Hashes.flag)
                {
                    Save();
                }
            }
            catch (Exception ex)
            {
                throw new IXActionFailedException($"JSONIX Dispose Error: {ex.Message}");
            }
        }
        public async ValueTask DisposeAsync()
        {
            if (_disposed) return;

            try
            {
                if (KeyValueAsync.flag || CollectionAsync.flag || HashesAsync.flag)
                {
                    await SaveAsync();
                }
            }
            catch (Exception ex)
            {
                throw new IXActionFailedException($"JSONIX Dispose Error: {ex.Message}");
            }
        }

        private bool IsHashes(object data)
        {
            if (data is Dictionary<string, object>) return true;
            if (data is JsonElement check && check.ValueKind == JsonValueKind.Object) return true;
            return false;
        }

        private bool IsCollection(object data)
        {
            if (data is JsonElement check && check.ValueKind == JsonValueKind.Array) return true;
            return false;
        }

        private bool IsKeyValue(object data)
        {
            if (data is JsonElement check && (check.ValueKind == JsonValueKind.Array || check.ValueKind == JsonValueKind.Object)) return false;
            return true;
        } 
    }
}
