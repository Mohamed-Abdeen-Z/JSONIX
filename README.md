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

## Commands

### Key Value Commands

| Command                        | Description                                              | Return Value                          |
|-------------------------------|----------------------------------------------------------|---------------------------------------|
| `SET <key> <value>`           | Sets the value for the specified key. If the key already exists, the previous value will be overwritten. | No return value |
| `GET <key>`                   | Returns the value of the specified key.                  | `string` or `null` if not found |
| `DEL <key>`                   | Deletes the specified key and its value.                 | `true` if deleted, `false` if key not found |
| `EXISTS <key>`                | Checks if the specified key exists.                      | `true` or `false` |
| `KEYS`                        | Returns all keys in the store.                           | `List<string>` |
| `COUNT`                       | Returns the total number of keys in the store.           | `int` |
| `RENAME <oldKey> <newKey>`    | Renames an existing key to a new key name.               | `true` if successful, `false` otherwise |

### Hashes Commands

| Command                              | Description                                              | Return Value                              |
|-------------------------------------|----------------------------------------------------------|-------------------------------------------|
| `HSET <key> <field> <value>`        | Sets the value for the specified field in the hash.      | No return value |
| `HSET <key> <field> <value1> ...`   | Sets multiple values for the field (as a list).          | No return value |
| `GET <key>`                         | Returns the entire hash as a dictionary.                 | `Dictionary<string, object>` or `null` |
| `HGET <key> <field>`                | Returns the value of a specific field in the hash.       | `string` or `List<object>` |
| `DEL <key>`                         | Deletes the specified key and its value.                                | `true` if deleted, `false` otherwise |
| `DEL <key> <field>`                | Deletes one or more fields from the hash.                | `true` if any field deleted, `false` otherwise |
| `HDEL <key> <field> <value>`        | Deletes a specific value from a field (if it's a collection). | `true` if value removed, `false` otherwise |
| `EXISTS <key>`                      | Checks if the hash key exists.                           | `true` or `false` |
| `HEXISTS <key> <field>`             | Checks if a field exists in the hash.                    | `true` or `false` |
| `HITEM_EXISTS <key> <field> <value>` | Checks if a value exists within a field.                 | `true` or `false` |
| `KEYS`                              | Returns all hash keys.                                   | `List<string>` |
| `COUNT_KEYS`                        | Returns the total number of hash keys.                   | `int` |
| `TOTAL_FIELDS`                      | Returns all fields from all hashes.                      | `List<string>` |
| `COUNT_TOTAL_FIELDS`                | Returns the total number of fields across all hashes.    | `int` |
| `FIELDS <key>`                      | Returns all fields in a specific hash.                   | `List<string>` |
| `COUNT_FIELDS <key>`                | Returns the number of fields in a hash.                  | `int` |
| `RENAME <oldKey> <newKey>`          | Renames a hash key.                                      | `true` if successful, `false` otherwise |
| `HRENAME <key> <oldField> <newField>` | Renames a field inside a hash.                         | `true` if successful, `false` otherwise |

### Collection Commands

| Command                          | Description                                              | Return Value                          |
|----------------------------------|----------------------------------------------------------|---------------------------------------|
| `APPEND <key> <member>`          | Appends a member to the collection. Creates new collection if key doesn't exist. | No return value |
| `APPEND <key> <member1> <member2> ...` | Appends multiple members to the collection.         | No return value |
| `FETCH <key>`                    | Returns all members of the collection.                   | `List<object>` or `null` |
| `DEL <key>`                     | Deletes the specified key and its value.                           | `true` if deleted, `false` otherwise |
| `LDEL <key> <member>`          | Removes a specific member from the collection.           | `true` if removed, `false` otherwise |
| `LDEL <key> <member1> <member2> ...` | Removes one or more members from the collection.     | `true` if any removed, `false` otherwise |
| `KEYS`                           | Returns all collection keys.                             | `List<string>` |
| `COUNT`                          | Returns the total number of collection keys.             | `int` |
| `LEN <key>`                      | Returns the length (number of items) of the collection.  | `int` |
| `EXISTS <key>`                   | Checks if the collection key exists.                     | `true` or `false` |
| `RENAME <oldKey> <newKey>`       | Renames a collection key.                                | `true` if successful, `false` otherwise |

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
```


## 🛠 Configuration

JSONIX is pre-configured with the following `JsonSerializerOptions`:

- **Indented output** for better readability
- **CamelCase** property naming policy
- **Cycle ignoring** to safely handle circular references

## 📝 Release Notes (v1.0.0)

- Initial stable release
- Core Key-Value, Hash, and Collection (List/Set) functionality
- High-performance JSON persistence layer using JSONIX
- Support for multiple primitive data types (`int`, `long`, `double`, `string`, `bool`, ...)
- Implemented main commands: `SET`, `GET`, `HSET`, `APPEND`, `DEL`, `HDEL`, etc.

## 📄 License

This project is open source and licensed under the **GNU AGPL-3.0 License**.

You are free to use and modify the code, but:
- You **cannot** sell it as a closed-source product.
- Any modifications or derivative works must also be released as open source under the same license.
