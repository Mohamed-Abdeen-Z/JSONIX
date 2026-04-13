using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Internal.Synchronous.CoreManagement.Collection
{
    public partial class CollectionClass
    {
        private bool IsCollection(object data)
        {
            if (data is JsonElement check && check.ValueKind == JsonValueKind.Array) return true;
            return false;
        }

        private int numFound(List<object> dataList, object value)
        {
            int index = dataList.FindIndex(item =>
            {
                if (item == null && value == null) return true;
                if (item == null || value == null) return false;
                return item.ToString() == value.ToString();
            });

            return index;
        }

        private static List<object> ConvertToList(object data)
        {
            if (data is List<object> list)
                return list;

            if (data is JsonElement jsonElement && jsonElement.ValueKind == JsonValueKind.Array)
            {
                return jsonElement.Deserialize<List<object>>() ?? new List<object>();
            }
            return new List<object>();
        }
    }
}
