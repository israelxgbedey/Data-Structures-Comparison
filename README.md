# Data Storage and Comparison of Data Structures

This project demonstrates the use of various data structures in C#, including arrays, dictionaries (maps), stacks, and queues, to store and manage a large amount of data. The goal is to explore the differences in behavior and efficiency between these data structures.

## Project Overview

The project includes two primary comparisons:

1. **Array vs. Map (Dictionary)**
2. **Stack vs. Queue**

Each comparison highlights the unique characteristics and efficiency of each data structure, showing when each might be preferred based on different use cases.

## Data Structures Used

### Array
An array stores elements in contiguous memory locations, allowing for efficient index-based access.

- **Efficiency**: O(1) for direct access by index.
- **Use Case**: Best for fixed-size datasets with frequent access to elements by index.

### Dictionary (Map)
A dictionary stores data in key-value pairs, allowing for efficient retrieval based on unique keys.

- **Efficiency**: O(1) average for lookups, inserts, and deletes.
- **Use Case**: Ideal for dynamic datasets where data is accessed by a unique key, like animal names.

### Stack
A stack is a Last-In-First-Out (LIFO) data structure, suitable for scenarios where elements need to be accessed in reverse order of insertion.

- **Efficiency**: O(1) for push and pop operations.
- **Use Case**: Useful for undo operations, backtracking, and navigation history.

### Queue
A queue is a First-In-First-Out (FIFO) data structure, ideal for preserving the order of elements.

- **Efficiency**: O(1) for enqueue and dequeue operations.
- **Use Case**: Commonly used in task scheduling and request handling.

## Code API

### Stack Methods
- `public void Push(T element)`: Adds an element to the end of the list (O(1))
- `public T Pop()`: Removes an element from the end of the list (O(1))
- `public int Size()`: Returns the number of elements (O(1))
- `public bool IsEmpty()`: Checks if the stack is empty (O(1))

### Queue Methods
- `public void Enqueue(T element)`: Adds an element to the end of the list (O(1))
- `public T Dequeue()`: Removes an element from the front of the list (O(1))
- `public int Size()`: Returns the number of elements (O(1))
- `public bool IsEmpty()`: Checks if the queue is empty (O(1))

## Differences and Efficiency

### Array vs. Dictionary
- **Array**: Provides O(1) time complexity for accessing elements by index.
- **Dictionary**: Offers O(1) average time complexity for key-based lookups, inserts, and deletes, thanks to hash-based storage.

### Stack vs. Queue
- **Stack**: Follows LIFO principle, ideal for reverse-order scenarios.
- **Queue**: Follows FIFO principle, maintaining insertion order, ideal for task scheduling.

## Usage Instructions

1. **Create Data Files**  
   Prepare two text files named `Animal_data.txt` and `Habitat_data.txt`.
   - Each line in `Animal_data.txt` should contain an animal name.
   - Each line in `Habitat_data.txt` should contain the corresponding habitat.
   - Ensure both files have the same number of entries, with each line formatted as `Animal, Habitat`.

2. **Run the Program**  
   - Load the data from the files into the data structures.
   - Display the data and interactively search for animal habitats.
   - Experiment with the stack and queue by pushing/popping and enqueuing/dequeuing elements.
