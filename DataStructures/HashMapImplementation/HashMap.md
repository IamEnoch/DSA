## Hash Map (`Dictionary<TKey, TValue>`)

A **Hash Map** (also referred to as a dictionary, map, or associative array) is a data structure that stores key-value
pairs, allowing efficient data retrieval based on keys. C# provides a built-in implementation of hash maps through the
`Dictionary<TKey, TValue>` class.

### Key Features:

- **Unique Keys**: Each key in a hash map is unique, meaning no two entries can have the same key.
- **Efficient Lookup**: Hash maps allow fast access to values through their associated keys. The average time complexity
  for insertion, deletion, and lookup operations is O(1), assuming a well-distributed hash function.
- **Hash Function**: A hash function computes an index (bucket) based on the key.
- **Collision Handling**: When multiple keys hash to the same index, techniques like chaining (using linked lists) or
  open addressing (probing) are employed to resolve collisions.
- **Load Factor**: Represents how full the hash map is. It is calculated as the ratio of the number of elements to the
  number of available buckets. When the load factor exceeds a predefined threshold, the hash map resizes automatically
  to maintain performance.
- **Time Complexity**: On average, search, insert, and delete operations run in O(1) time, assuming a good hash function
  and appropriate load factor. In the worst-case scenario (due to poor hash distribution or excessive collisions), the
  time complexity can degrade to O(n).

### Example in C#:

See the `Program.cs` file for a full implementation and demonstration of a hash map using the `Dictionary<TKey, TValue>`
class in C#.
