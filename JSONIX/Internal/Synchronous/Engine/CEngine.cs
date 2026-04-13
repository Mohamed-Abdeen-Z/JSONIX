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
            try
            {
                if (!File.Exists(database))
                {
                    Insert(new Dictionary<string, object>());
                }
            }
            catch (IOException ex)
            {
                throw new IXActionFailedException($"Initialization failed: Cannot access storage. Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new IXActionFailedException($"JSONIX Client Initialization Error: {ex.Message}");
            }
            _options = options ?? DefaultOptions();
        }

        public Dictionary<string, object> Load(string database = null)
        {
            if (IsDatabaseCorrupted())
            {
                throw new IXFormatErrorException("The file format is invalid or corrupted.");
            }
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
            if (IsDatabaseCorrupted())
            {
                throw new IXFormatErrorException("The file format is invalid or corrupted.");
            }
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
            catch (Exception ex)
            {
                throw new Exception($"JSONIX Error during Insert: {ex.Message}", ex);
            }
        }

        public List<object> ConvertJSONToList(object data, int Loop = 0)
        {
            if (data is not JsonElement checkList) return data as List<object> ?? new List<object>();
            if (Loop > 0)
            {
                for (int i = 0; i < Loop; i++)
                {
                    if (checkList.ValueKind == JsonValueKind.Array && checkList.GetArrayLength() > 0) checkList = checkList[0];
                    else break;
                }
                return checkList.Deserialize<List<object>>() ?? new List<object>();
            }
            if (checkList.ValueKind == JsonValueKind.Array) return checkList.Deserialize<List<object>>() ?? new List<object>();
            return new List<object>();
        }

        public Dictionary<string, object> ConvertJSONToDictionary(object data, int Loop = 0)
        {
            if (data is not JsonElement checkList) return data as Dictionary<string, object> ?? new Dictionary<string, object>();
            if (Loop > 0 && checkList.ValueKind == JsonValueKind.Object)
            {
                foreach (var property in checkList.EnumerateObject())
                {
                    Dictionary<string, object> result = ConvertJSONToDictionary(property.Value, Loop - 1);
                    if (result.Count > 0) return result;
                }
            }
            if (checkList.ValueKind == JsonValueKind.Object) return checkList.Deserialize<Dictionary<string, object>>() ?? new Dictionary<string, object>();
            return new Dictionary<string, object>();
        }

        internal bool IsDatabaseCorrupted()
        {
            if (!File.Exists(_databasePath)) return false;
            try
            {
                using (FileStream OpFile = new FileStream(_databasePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (JsonDocument.Parse(OpFile)) { }
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }
    }
}
