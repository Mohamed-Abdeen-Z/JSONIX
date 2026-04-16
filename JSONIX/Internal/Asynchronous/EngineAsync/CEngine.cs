using Internal.Iinterface.Engine;
using JSONIX.Exceptions;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Internal.Asynchronous.EngineAsync
{
    internal class ClassEngineAsync : IEngineAsync
    {
        private string _databasePath { get; }
        private JsonSerializerOptions _options { get; }

        private static readonly SemaphoreSlim _fileLock = new SemaphoreSlim(1, 1);

        private static JsonSerializerOptions DefaultOptions()
        {
            return new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters = { new JsonStringEnumConverter() },
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            };
        }

        public ClassEngineAsync(string database, JsonSerializerOptions options = null)
        {
            _databasePath = database;
            _options = options ?? DefaultOptions();
        }


        public async Task<Dictionary<string, object>> LoadAsync(string database = null)
        {
            string path = database ?? _databasePath;

            try
            {
                if (!File.Exists(path))
                    return new Dictionary<string, object>();

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
                {
                    return await JsonSerializer.DeserializeAsync<Dictionary<string, object>>(fs, _options)
                           ?? new Dictionary<string, object>();
                }
            }
            catch (JsonException)
            {
                throw new Exception("JSONIX Error: Database file is corrupted or invalid JSON format.");
            }
            catch (Exception ex)
            {
                throw new Exception($"JSONIX Error during Load: {ex.Message}");
            }
        }

        public async Task InsertAsync(Dictionary<string, object> data, string database = null)
        {
            string path = database ?? _databasePath;

            await _fileLock.WaitAsync();

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                {
                    await JsonSerializer.SerializeAsync(fs, data, _options);
                    await fs.FlushAsync();
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception($"JSONIX Error: The database file was not found at '{path}'.");
            }
            catch (JsonException)
            {
                throw new Exception("JSONIX Error: Database file is corrupted or invalid JSON format.");
            }
            catch (Exception ex)
            {
                throw new Exception($"JSONIX Error during Insert: {ex.Message}", ex);
            }
            finally
            {
                _fileLock.Release();
            }
        }

        public static List<object> ConvertToList(object data)
        {
            if (data is List<object> list)
                return list;

            if (data is JsonElement jsonElement && jsonElement.ValueKind == JsonValueKind.Array)
            {
                return jsonElement.Deserialize<List<object>>() ?? new List<object>();
            }
            return new List<object>();
        }


        public static Dictionary<string, object> ConvertToDictionary(object data)
        {
            if (data is Dictionary<string, object> dict) return dict;
            if (data is JsonElement jsonElement && jsonElement.ValueKind == JsonValueKind.Object)
            {
                return jsonElement.Deserialize<Dictionary<string, object>>() ?? new Dictionary<string, object>();
            }
            return new Dictionary<string, object>();
        }
    }
}
