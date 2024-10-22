## Hash Set (`HashSet<T>`)

A **Hash Set** is a collection that stores unique elements with no particular order. Unlike lists or arrays, hash sets
automatically prevent duplicate values and provide efficient lookup, insertion, and deletion operations. C# provides the
`HashSet<T>` class for this purpose.

### Key Features:

- **Unique Elements**: A hash set stores only unique values. If you try to add an element that already exists in the
  set, it is ignored.
- **No Order**: The elements in a hash set are not stored in any particular order.
- **Efficient Operations**: Hash sets offer fast insertion, deletion, and lookup, with an average time complexity of O(
  1).
- **Hash Function**: Each element is hashed using a hash function to determine its index within the internal structure.
  This ensures that operations can be performed quickly.
- **Collision Handling**: Hash sets handle collisions using techniques such as chaining (linked lists) or open
  addressing (probing), just like hash maps.
- **Time Complexity**: On average, the time complexity for adding, removing, and checking for the existence of an
  element is O(1). In the worst case, due to hash collisions or poor distribution, the time complexity can degrade to O(
  n).

### Common Operations:

- **Add**: Adds an element to the hash set if it does not already exist.
  ```csharp
  HashSet<int> mySet = new HashSet<int>();
  mySet.Add(10); // Adds 10 to the set
