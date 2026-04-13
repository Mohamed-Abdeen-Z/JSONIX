using Public.ShowFunctions.Synchronous.CoreManagement.Collection;
using Public.ShowFunctions.Synchronous.CoreManagement.Hashes;
using Public.ShowFunctions.Synchronous.CoreManagement.KeyValue;
using Internal.Synchronous.CoreManagement.KeyValue;
using Internal.Synchronous.Engine;
using JSONIX.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace JSONIX
{
    public class Client
    {
        private string _database;
        public KeyValueF KeyValue;
        public CollectionF Collection;
        public HashesF Hashes;
        public Client(string database, JsonSerializerOptions options = null)
        {
            ClassEngine engine = new ClassEngine(database, options);
            try
            {
                if (!File.Exists(database))
                {
                    engine.Insert(new Dictionary<string, object>());
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
            _database = database;

            KeyValue = new KeyValueF(engine);
            Collection = new CollectionF(engine);
            Hashes = new HashesF(engine);
        }

        public override string ToString()
        {
            string message = "Location: " + "\n" + $"- {_database}" + "\n" + "Default Option: " + "\n" + "- WriteIndented = true,\n- PropertyNamingPolicy = JsonNamingPolicy.CamelCase,\n- Converters = { new JsonStringEnumConverter() },\n- DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,\n- ReferenceHandler = ReferenceHandler.IgnoreCycles";
            return message;
        }
    }
}
