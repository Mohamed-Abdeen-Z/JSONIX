using Internal.Asynchronous.EngineAsync;
using Internal.Synchronous.Engine;
using JSONIX.Exceptions;
using JSONIX.Join;
using Public.ShowFunctions.Asynchronous.CoreManagement.CollectionAsync;
using Public.ShowFunctions.Asynchronous.CoreManagement.HashesAsync;
using Public.ShowFunctions.Asynchronous.CoreManagement.KeyValueAsync;
using Public.ShowFunctions.Synchronous.CoreManagement.Collection;
using Public.ShowFunctions.Synchronous.CoreManagement.Hashes;
using Public.ShowFunctions.Synchronous.CoreManagement.KeyValue;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JSONIX
{
    public class Client
    {
        private readonly JoinToJSON _join;

        private string _database;
        public KeyValueF KeyValue;
        public CollectionF Collection;
        public HashesF Hashes;

        public KeyValueAsyncF KeyValueAsync;
        public CollectionAsyncF CollectionAsync;
        public HashesAsyncF HashesAsync;

        public Client(string database, JsonSerializerOptions options = null)
        {
            try
            {
                if (!File.Exists(database))
                {
                    File.WriteAllText(database, "{}", Encoding.UTF8);
                }
            }
            catch (JsonException)
            {
                throw new Exception("JSONIX Error: Database file is corrupted or invalid JSON format.");
            }
            catch (IOException ex)
            {
                throw new IXActionFailedException($"Initialization failed: Cannot access storage. Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new IXActionFailedException($"JSONIX Client Initialization Error: {ex.Message}");
            }

            _database = database;
            ClassEngine engine = new ClassEngine(database, options);
            ClassEngineAsync engineAsync = new ClassEngineAsync(database, options);

            _join = new JoinToJSON(database, options);

            KeyValue = new KeyValueF(engine.Load());
            Collection = new CollectionF(engine);
            Hashes = new HashesF(engine.Load());

            KeyValueAsync = new KeyValueAsyncF(engineAsync);
            CollectionAsync = new CollectionAsyncF(engineAsync);
            HashesAsync = new HashesAsyncF(engineAsync);
        }

        public override string ToString()
        {
            string message = "Location: " + "\n" + $"- {_database}" + "\n" + "Default Option: " + "\n" + "- WriteIndented = true,\n- PropertyNamingPolicy = JsonNamingPolicy.CamelCase,\n- Converters = { new JsonStringEnumConverter() },\n- DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,\n- ReferenceHandler = ReferenceHandler.IgnoreCycles";
            return message;
        }

        public void Save()
        {
            if (KeyValue.flag)
                _join.Insert(KeyValue.data);
            if (Hashes.flag)
                _join.Insert(Hashes.data);

            KeyValue.data.Clear();
            Hashes.data.Clear();
        }
    }
}
