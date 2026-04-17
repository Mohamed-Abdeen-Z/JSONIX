using Collection;
using Hashes;
using KeyValue;
using Internal.Synchronous.Engine;
using JSONIX.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using KeyValueAsync;
using Internal.Asynchronous.EngineAsync;
using CollectionAsync;
using HashesAsync;

namespace JSONIX
{
    public partial class Client
    {
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

            engine = new ClassEngine(database, options);
            engineAsync = new ClassEngineAsync(database, options);

            KeyValue = new KeyValueF(engine.Load());
            Collection = new CollectionF(engine.Load());
            Hashes = new HashesF(engine.Load());

            KeyValueAsync = new KeyValueAsyncF(engineAsync.LoadAsync());
            CollectionAsync = new CollectionAsyncF(engineAsync.LoadAsync());
            HashesAsync = new HashesAsyncF(engineAsync.LoadAsync());
        }


        

        public override string ToString()
        {
            string message = "Location: " + "\n" + $"- {_database}" + "\n" + "Default Option: " + "\n" + "- WriteIndented = true,\n- PropertyNamingPolicy = JsonNamingPolicy.CamelCase,\n- Converters = { new JsonStringEnumConverter() },\n- DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,\n- ReferenceHandler = ReferenceHandler.IgnoreCycles";
            return message;
        }
    }
}
