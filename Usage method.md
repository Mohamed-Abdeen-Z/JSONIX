# Engine Usage

## Synchronous
```csharp
using JSONIX.Join;

var join = new JoinToJSON("JSONIX.json");

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
## Asynchronous
```csharp
using JSONIX.JoinAsync;

var joinAsync = new JoinAsyncToJSON("JSONIX.json");

var data = await joinA.LoadAsync();
// Code
await joinA.InsertAsync(data);

// Example
public static async Task SET<T>(string name, T value)
{
    var data = await joinAsync.LoadAsync();
    data[name] = value;
    await joinAsync.InsertAsync(data);
}
```

# Manual saving
- ### using Save || SaveAsync Function
## Synchronous
```csharp
using JSONIX;

var CLIENT = new JSONIX.Client("JSONIX.json");

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
CLIENT.Save();
```
## Asynchronous
```csharp
using JSONIX;

var CLIENT = new JSONIX.Client("JSONIX.json");

// Key-Value
await CLIENT.KeyValueAsync.SET("username", "JSONIX");
await CLIENT.KeyValueAsync.SET("age-y", 3);
string name = await CLIENT.KeyValueAsync.GET("username");
bool exists = await CLIENT.KeyValueAsync.EXISTS("age-y");

// Hashes
await CLIENT.HashesAsync.HSET("user:1", "name", "Shadow");
await  CLIENT.HashesAsync.HSET("user:1", "skills", "C#", "SQL", "Redis");
var user = await CLIENT.HashesAsync.GET("user:1");
var skillList = await CLIENT.HashesAsync.HGET("user:1", "skills");

// Collections
await CLIENT.CollectionAsync.APPEND("fruits", "apple", "banana", "orange");
var fruits = await CLIENT.CollectionAsync.FETCH("fruits");
int count = await CLIENT.CollectionAsync.LEN("fruits");

// To Save the data to the JSON file
await CLIENT.SaveAsync();
```


# Automatic saving

## Synchronous
```csharp
using JSONIX;

using (var CLIENT = new JSONIX.Client("JSONIX.json"))
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
## Asynchronous
```csharp
using JSONIX;

await using (var CLIENT = new JSONIX.Client("JSONIX.json"))
{
    // Key-Value
    await CLIENT.KeyValueAsync.SET("username", "JSONIX");
    await CLIENT.KeyValueAsync.SET("age-y", 3);
    string name = await CLIENT.KeyValueAsync.GET("username");
    bool exists = await CLIENT.KeyValueAsync.EXISTS("age-y");

    // Hashes
    await CLIENT.HashesAsync.HSET("user:1", "name", "Shadow");
    await CLIENT.HashesAsync.HSET("user:1", "skills", "C#", "SQL", "Redis");
    var user = await CLIENT.HashesAsync.GET("user:1");
    var skillList = await CLIENT.HashesAsync.HGET("user:1", "skills");

    // Collections
    await CLIENT.CollectionAsync.APPEND("fruits", "apple", "banana", "orange");
    var fruits = await CLIENT.CollectionAsync.FETCH("fruits");
    int count = await CLIENT.CollectionAsync.LEN("fruits");
}
```
