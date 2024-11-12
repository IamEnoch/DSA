# Queue in C#

A **Queue** is a linear data structure that follows the **FIFO** (First In, First Out) principle. In C#, the `Queue<T>`
class in the `System.Collections.Generic` namespace provides a built-in implementation of a queue.

---

## Key Queue Operations

| Operation | Description                                   | Method      | Time Complexity |
|-----------|-----------------------------------------------|-------------|-----------------|
| Enqueue   | Adds an element to the end of the queue       | `Enqueue()` | **O(1)**        |
| Dequeue   | Removes and returns the front element         | `Dequeue()` | **O(1)**        |
| Peek      | Returns the front element without removing it | `Peek()`    | **O(1)**        |
| Count     | Returns the number of elements in the queue   | `Count`     | **O(1)**        |

### Code Example

See [`Program.cs`](Program.cs)

## Operation Details

### Enqueue

- **Description**: Adds an element to the end of the queue.
- **Syntax**: `queue.Enqueue(element);`
- **Space Complexity**: **O(1)** for a single enqueue operation.

### Dequeue

- **Description**: Removes and returns the front element of the queue.
- **Note**: Throws an `InvalidOperationException` if the queue is empty.
- **Syntax**: `int removed = queue.Dequeue();`
- **Space Complexity**: **O(1)**.

### Peek

- **Description**: Returns the front element without removing it.
- **Note**: Throws an `InvalidOperationException` if the queue is empty.
- **Syntax**: `int front = queue.Peek();`
- **Space Complexity**: **O(1)**.

### Count

- **Description**: Retrieves the total number of elements in the queue.
- **Syntax**: `int size = queue.Count;`

---

## Pros and Cons of Using a Queue

**Pros**:

- **Efficient FIFO Access**: The FIFO structure is ideal for tasks that need sequential processing.
- **Simple Implementation**: Queues are straightforward to use and effective for many real-world applications.

**Cons**:

- **Limited Access**: Only the front and back elements are accessible, limiting flexibility.
- **Potential Memory Issue**: A queue can grow indefinitely if elements are continually enqueued without being dequeued.

---

## Space Complexity Overview

- Each **enqueue** or **dequeue** operation has a constant space complexity of **O(1)** when adding or removing a single
  element.
- The overall space complexity of the queue is **O(n)**, where **n** is the total number of elements currently in the
  queue.

---

## Applications of Queues

- **Task Scheduling**: Queues are used in CPU scheduling and managing tasks in operating systems.
- **Data Buffering**: Common in I/O buffering where data is stored temporarily in a queue before being processed.
- **Breadth-First Search (BFS)**: Useful in graph traversal algorithms, where nodes are processed level by level.
