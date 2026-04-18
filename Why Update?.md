# ✨ V[2.0.0] - 2025-04-18

## - In last Version 1.1.0.
### Fixed
- **Cannot add many items at the same time** - Was causing deadlock
  ### Before (Deadlock):
  ```csharp
  for (int i = 0; i < 1000000; i++)
  {
    client.Collection.APPEND("List", i); // Save on each iteration
  }
  ```
  ### After
  ```csharp
  for (int i = 0; i < 1000000; i++)
  {
    client.Collection.APPEND("List", i); // Batch operations
  }
  client.Save(); // Single save after all operations
  ```
- Asynchronous functions support - Added async/await patterns

### Changed
- Improved style for better user experience
- Type Safety - Added actual type restrictions for data integrity

### Added
- Asynchronous functions - Full async/await support
- Saving options - Both automatic and manual saving modes

### Removed
- Previous limitations in data type handling

### Performance Improvement
- Execution time - Significantly faster with batch operations
- Deadlock eliminated - No more thread blocking when adding multiple items

#

# ✨ V[1.1.0] - 2025-04-13

## - In last Version 1.0.0.
### Fixed
- Cannot add items to Hashes Storage (Key-Value single value)
- Insert and load data problems
- Cannot add items in same method

### Changed
- Improved style for better user experience
- Added actual type restrictions for data safety

### Removed
- Previous limitations in data type handling
