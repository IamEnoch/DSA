# Stack (`Stack<T>`)

A **Stack** is a linear data structure that adheres to the **LIFO** (Last In, First Out) principle. In C#, the
`Stack<T>` class in the `System.Collections.Generic` namespace provides a robust, built-in stack implementation.

---

## Key Stack Operations

| Operation | Description                                 | Method   | Time Complexity |
|-----------|---------------------------------------------|----------|-----------------|
| Push      | Adds an element to the top of the stack     | `Push()` | **O(1)**        |
| Pop       | Removes and returns the top element         | `Pop()`  | **O(1)**        |
| Peek      | Returns the top element without removing    | `Peek()` | **O(1)**        |
| Count     | Returns the number of elements in the stack | `Count`  | **O(1)**        |

### Code Example

See [`Program.cs`](Program.cs)

## Operation Details

### Push

- **Description**: Adds an element to the top of the stack.
- **Syntax**: `stack.Push(element);`
- **Space Complexity**: **O(1)** for a single push operation.

### Pop

- **Description**: Removes the top element from the stack and returns it.
- **Note**: Throws an `InvalidOperationException` if the stack is empty.
- **Syntax**: `int removed = stack.Pop();`
- **Space Complexity**: **O(1)**.

### Peek

- **Description**: Returns the top element without modifying the stack.
- **Note**: Throws an `InvalidOperationException` if the stack is empty.
- **Syntax**: `int top = stack.Peek();`
- **Space Complexity**: **O(1)**.

### Count

- **Description**: Retrieves the total number of elements.
- **Syntax**: `int size = stack.Count;`

---

## Pros and Cons of Using a Stack

**Pros**:

- **Efficient LIFO Access**: The LIFO access pattern is highly efficient for scenarios requiring backtracking.
- **Simple Implementation**: Stacks are straightforward to implement and have predictable behavior.

**Cons**:

- **Limited Access**: Only the top element is accessible, limiting flexibility.
- **Memory Usage**: Recursive stack-based algorithms can lead to a stack overflow if not managed correctly.

---

## Space Complexity Overview

- Each **push** or **pop** operation has a constant space complexity of **O(1)** when adding or removing a single
  element.
- In terms of overall stack size, the space complexity is **O(n)**, where **n** is the total number of elements
  currently in the stack.

---

## Applications of Stacks

- **Expression Evaluation**: Used in parsing and evaluating postfix, prefix, or infix expressions.
- **Undo Mechanism**: Stacks facilitate "Undo" functionality in applications.
- **Backtracking Algorithms**: Useful in recursive algorithms like depth-first search (DFS) and pathfinding.


