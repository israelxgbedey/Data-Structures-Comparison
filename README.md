Data Storage and Comparison of Data Structures
This project demonstrates the use of various data structures such as arrays, dictionaries (maps), stacks, and queues to store and manage a large amount of data. The project includes two primary comparisons:

Array vs. Map (Dictionary)

Stack vs. Queue

How Each Data Structure Works
Array
An array stores elements in contiguous memory locations. Each element can be accessed directly using its index, making arrays efficient for random access.

Map (Dictionary)
A map (implemented as a dictionary in C#) stores key-value pairs. Each key maps to a specific value, allowing for efficient data retrieval based on the key. Dictionaries use a hash table internally to achieve average O(1) time complexity for lookups, inserts, and deletes.

Stack
A stack is a Last-In-First-Out (LIFO) data structure. Elements are added (pushed) and removed (popped) from the end of the list. This structure is suitable for scenarios where you need to reverse the order of elements, such as undo operations or navigating back through history.

Queue
A queue is a First-In-First-Out (FIFO) data structure. Elements are added (enqueued) to the end and removed (dequeued) from the front of the list. Queues are ideal for scenarios where the order of elements must be preserved, such as task scheduling or handling requests in a web server.

Differences and Efficiency
Array vs. Map (Dictionary)
Array
How it works: Stores elements in contiguous memory locations.

Efficiency: O(1) time complexity for accessing elements by index.

Scenario: Suitable for fixed-size datasets with frequent index-based access.

Map (Dictionary)
How it works: Stores key-value pairs using a hash table.

Efficiency: O(1) average time complexity for lookups, inserts, and deletes.

Scenario: Ideal for dynamic datasets where quick access to data based on unique keys is necessary.

Stack vs. Queue
Stack
API:

public void Push(T element): Adds element to the end of the list (O(1))

public T Pop(): Removes element from the end of the list (O(1))

public int Size(): Returns the number of elements (O(1))

public bool IsEmpty(): Checks if the stack is empty (O(1))

How it works: Follows the LIFO principle; last added element is the first to be removed.

Scenario: Suitable for scenarios requiring reverse operations, such as undo operations or navigating back in a browser.

Queue
API:

public void Enqueue(T element): Adds element to the end of the list (O(1))

public T Dequeue(): Removes element from the front of the list (O(1))

public int Size(): Returns the number of elements (O(1))

public bool IsEmpty(): Checks if the queue is empty (O(1))

How it works: Follows the FIFO principle; first added element is the first to be removed.

Scenario: Ideal for scenarios where order must be preserved, such as task scheduling or handling requests in a web server.

Code Implementation
The provided code demonstrates how to read data from external files, store them in various data structures, and perform operations like searching, displaying, and removing elements.

Usage Instructions
Create two text files: Animal_data.txt and Habitat_data.txt.

Animal_data.txt should contain a list of animals.

Habitat_data.txt should contain corresponding habitats.

Ensure both files have the same number of entries.

Run the program to load the data, display it, and interactively search for animal habitats.
