#  JSONIX Library

JSONIX is a lightweight key-value store based on JSON.

# In-Memory Data Store

A simple and fast in-memory data store supporting **Key-Value**, **Hashes**, and **Collections** (Lists/Sets).

## Features

- Key-Value storage
- Hash (Field-Value) storage
- Collection (List/Set) storage
- Support for multiple data types (int, long, double, float, decimal, string, bool, char)
- Simple and Redis-like commands

## Usage Examples

```csharp
using JSONIX;

JSONIX.Client CLIENT = new JSONIX.Client("JSONIX.json");

// Key-Value
CLIENT.KeyValue.SET("username", "JSONIX");
CLIENT.KeyValue.SET("age-y", 3);
string name = CLIENT.KeyValue.GET("username");
bool exists = CLIENT.KeyValue.EXISTS("age-y");

// Hashes
CLIENT.Hashes.HSET("user:1", "name", "Shadow");
CLIENT.Hashes.HSET("user:1", "skills", "C#", "SQL", "Redis");
var user = CLIENT.Hashes.GET("user:1");
var skillList = CLIENT.Hashes.HGET("user:1", "skills");

// Collections
CLIENT.Collection.APPEND("fruits", "apple", "banana", "orange");
var fruits = CLIENT.Collection.FETCH("fruits");
int count = CLIENT.Collection.LEN("fruits");

// To Save the data to the JSON file
CLIENT.SAVE();
```
## Auto Save
```csharp
using JSONIX;

using (JSONIX.Client CLIENT = new JSONIX.Client("JSONIX.json"))
{
    // Key-Value
    CLIENT.KeyValue.SET("username", "JSONIX");
    CLIENT.KeyValue.SET("age-y", 3);
    string name = CLIENT.KeyValue.GET("username");
    bool exists = CLIENT.KeyValue.EXISTS("age-y");

    // Hashes
    CLIENT.Hashes.HSET("user:1", "name", "Shadow");
    CLIENT.Hashes.HSET("user:1", "skills", "C#", "SQL", "Redis");
    var user = CLIENT.Hashes.GET("user:1");
    var skillList = CLIENT.Hashes.HGET("user:1", "skills");

    // Collections
    CLIENT.Collection.APPEND("fruits", "apple", "banana", "orange");
    var fruits = CLIENT.Collection.FETCH("fruits");
    int count = CLIENT.Collection.LEN("fruits");
}
```


## Engine Usage
### Creating custom functions using the JSONIX Engine
```csharp
using JSONIX.Join;

JoinToJSON join = new JoinToJSON("JSONIX.json");

var data = join.Load();
// Code
join.Insert(data);

// Example
public static void Set<T>(string name, T value)
{
    var data = join.Load();
    data[name] = value;
    join.Insert(data);
}
```
