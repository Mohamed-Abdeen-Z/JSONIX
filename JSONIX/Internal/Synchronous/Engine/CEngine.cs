using Internal.Iinterface.Engine;
using JSONIX.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Internal.Synchronous.Engine
{
    internal class ClassEngine : IEngine
    {
        private string _databasePath { get; }
        private JsonSerializerOptions _options { get; }
        private static JsonSerializerOptions DefaultOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters = { new JsonStringEnumConverter() },
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            };
            return options;
        }

        public ClassEngine(string database, JsonSerializerOptions options = null)
        {
            _databasePath = database;
            _options = options ?? DefaultOptions();
        }

        public Dictionary<string, object> Load(string database = null)
        {
            try
            {
                if (!File.Exists(database ?? _databasePath)) return new Dictionary<string, object>();

                using (FileStream OpFile = new FileStream(database ?? _databasePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return JsonSerializer.Deserialize<Dictionary<string, object>>(OpFile) ?? new Dictionary<string, object>();
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

        public void Insert(Dictionary<string, object> data, string database = null)
        {
            try
            {
                using (FileStream OpFile = new FileStream(database ?? _databasePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    JsonSerializer.Serialize(OpFile, data, _options);
                }
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception($"JSONIX Error: The database file was not found at '{database ?? _databasePath}'.");
            }
            catch (JsonException)
            {
                throw new Exception("JSONIX Error: Database file is corrupted or invalid JSON format.");
            }
            catch (Exception ex)
            {
                throw new Exception($"JSONIX Error during Insert: {ex.Message}", ex);
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
