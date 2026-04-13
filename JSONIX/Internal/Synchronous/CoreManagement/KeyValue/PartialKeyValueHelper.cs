using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Internal.Synchronous.CoreManagement.KeyValue
{
    public partial class KeyValueClass
    {
        private bool IsKeyValue(object data)
        {
            if (data is JsonElement check && (check.ValueKind == JsonValueKind.Array || check.ValueKind == JsonValueKind.Object)) return false;
            return true;
        }
    }
}
