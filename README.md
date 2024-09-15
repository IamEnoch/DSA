# Data Structures and Algorithms Practice in C#

This repository contains various implementations of fundamental **Data Structures** and **Algorithms** using C#. The goal is to practice and reinforce understanding of different algorithms and data structures by writing clean, efficient, and well-documented code.

## Folder Structure

The project is organized into the following folders:

### 1. `Algorithms/`

This folder contains implementations of key algorithms, which are further categorized by type. Each algorithm is accompanied by a detailed description of how it works, its time complexity, and space complexity.

#### Subfolders:
- **`Sorting/`**: Implements sorting algorithms that arrange elements in a specific order. Examples include:
    - `BubbleSort.cs`
    - `QuickSort.cs`
    - `MergeSort.cs`

  These algorithms are useful when you need to arrange a collection of data, such as integers or strings, in ascending or descending order.

- **`Searching/`**: Contains algorithms used to search for elements within a dataset. Examples include:
    - `BinarySearch.cs`
    - `LinearSearch.cs`

  Searching algorithms help find elements efficiently in both sorted and unsorted datasets.

- **`Recursion/`**: This folder includes problems solved using recursion, a method where the solution to a problem depends on solutions to smaller instances of the same problem. Examples:
    - `Factorial.cs`: A recursive algorithm for computing factorials.
    - `Fibonacci.cs`: A recursive method for generating Fibonacci numbers.

Each algorithm file includes:
- An explanation of the algorithm.
- Its time complexity (Best, Average, and Worst cases).
- Its space complexity.
- Sample input and output.

### 2. `DataStructures/`

This folder contains the implementation of various data structures. Each data structure is implemented with operations like insertion, deletion, traversal, and searching where applicable. Understanding these structures is crucial for mastering algorithms, as many rely on specific structures for optimal performance.

#### Subfolders:
- **`LinkedList/`**: Implements various types of linked lists:
    - `SinglyLinkedList.cs`: A basic linked list where each node points to the next one.
    - `DoublyLinkedList.cs`: A linked list where nodes have pointers to both the next and the previous nodes.

- **`Trees/`**: Contains tree-based data structures:
    - `BinarySearchTree.cs`: Implements a binary search tree (BST) where each node has at most two children, and the left subtree contains values less than the parent node, while the right subtree contains values greater than the parent.
    - `AVLTree.cs`: A self-balancing binary search tree that maintains the height balance of the tree after insertions and deletions.

- **`Graphs/`**: Includes graph-related data structures:
    - `Graph.cs`: Implements a graph using an adjacency list. Useful for solving graph problems like shortest paths, depth-first search (DFS), and breadth-first search (BFS).

Each data structure file includes:
- A class definition with public methods for common operations (e.g., insert, delete, traverse).
- A discussion of the use cases for each data structure.
- An analysis of the time and space complexity of the various operations.

### 3. `Utilities/`

The `Utilities` folder contains helper classes that assist in the development and testing of algorithms and data structures. These utilities are reusable and can be used to benchmark performance or simplify input handling.

- **`InputHelper.cs`**: Contains methods for generating random input, validating user input, or formatting output to be used in algorithms and data structures.
- **`Timer.cs`**: A utility for timing the execution of algorithms. Useful for performance comparisons between different algorithms.

### 4. Solution File (`DsaPractice.sln`)

The repository includes a solution file (`.sln`) that helps manage the multiple console applications contained in the project. Each algorithm or data structure can be executed independently in its own console application.

### How to Run the Code

Each algorithm or data structure is implemented as part of a C# console application. You can run them by following these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/dsa-practice.git
   cd dsa-practice
