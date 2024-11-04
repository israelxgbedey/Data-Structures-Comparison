using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DataStorage
{
    private string[] arrayData;
    private Dictionary<string, string> dictionaryData;
    private Stack<string> stackData;
    private Queue<string> queueData;

    public DataStorage(string animalsFilePath, string habitatsFilePath)
    {
        LoadData(animalsFilePath, habitatsFilePath);
    }

    private void LoadData(string animalsFilePath, string habitatsFilePath)
    {
        var animalLines = File.ReadAllLines(animalsFilePath);
        var habitatLines = File.ReadAllLines(habitatsFilePath);

        if (animalLines.Length != habitatLines.Length)
        {
            throw new InvalidOperationException("Animal and habitat data files must have the same number of entries.");
        }

        arrayData = animalLines;
        dictionaryData = new Dictionary<string, string>();
        stackData = new Stack<string>();
        queueData = new Queue<string>();

        for (int i = 0; i < animalLines.Length; i++)
        {
            var animal = animalLines[i].Trim();
            var habitat = habitatLines[i].Trim();

            dictionaryData[animal] = habitat;
            stackData.Push(animal);
            queueData.Enqueue(animal);
        }
    }

    public void DisplayData()
    {
        Console.WriteLine("Array Data (Index: Value):");
        for (int i = 0; i < arrayData.Length; i++)
        {
            Console.WriteLine($"[{i}]: {arrayData[i]}");
        }

        Console.WriteLine("\nDictionary Data (Animal: Habitat):");
        foreach (var kvp in dictionaryData)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.WriteLine("\nStack Data (LIFO order):");
        Console.WriteLine("Top -> ");
        foreach (var item in stackData)
        {
            Console.WriteLine($"| {item} |");
        }
        Console.WriteLine("Bottom");

        Console.WriteLine("\nQueue Data (FIFO order):");
        Console.WriteLine("Front -> ");
        foreach (var item in queueData)
        {
            Console.WriteLine($"| {item} |");
        }
        Console.WriteLine("Back");
    }


    public string SearchAnimalHabitat(string animal)
    {
        string formattedAnimal = char.ToUpper(animal[0]) + animal[1..].ToLower();

        if (dictionaryData.TryGetValue(formattedAnimal, out var habitat))
        {
            string pluralAnimal = formattedAnimal + (formattedAnimal.EndsWith("s") ? "" : "s");
            return $"{pluralAnimal} live in the {habitat}.";
        }
        return $"{formattedAnimal} not found.";
    }

    public void DisplayReversedStack()
    {
        Console.WriteLine("\nReversed Stack Data (FILO order):");
        foreach (var item in stackData.Reverse())
        {
            Console.WriteLine(item);
        }
    }


    public void RemoveFromQueue(string animal)
    {
        string formattedAnimal = char.ToUpper(animal[0]) + animal[1..].ToLower();
        queueData = new Queue<string>(queueData.Where(x => x != formattedAnimal));
    }
    public Queue<string> DisplayQueueWithoutAnimal(string animal)
    {
        string formattedAnimal = char.ToUpper(animal[0]) + animal[1..].ToLower();
        var tempQueue = new Queue<string>();

        foreach (var currentAnimal in queueData)
        {
            if (currentAnimal != formattedAnimal)
            {
                tempQueue.Enqueue(currentAnimal);
            }
        }

        return tempQueue;
    }

    public class CustomStack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T element) => items.Add(element);

        public T Pop()
        {
            if (items.Count == 0) throw new InvalidOperationException("Stack is empty");
            T element = items[^1];
            items.RemoveAt(items.Count - 1);
            return element;
        }

        public int Size() => items.Count;

        public bool IsEmpty() => items.Count == 0;
    }

    public class CustomQueue<T>
    {
        private List<T> items = new List<T>();

        public void Enqueue(T element) => items.Add(element);

        public T Dequeue()
        {
            if (items.Count == 0) throw new InvalidOperationException("Queue is empty");
            T element = items[0];
            items.RemoveAt(0);
            return element;
        }

        public int Size() => items.Count;

        public bool IsEmpty() => items.Count == 0;
    }

    public class Program
    {
        public static void Main()
        {
            var animalsFilePath = "Animal_data.txt";
            var habitatsFilePath = "Habitat_data.txt";

            if (!File.Exists(animalsFilePath) || !File.Exists(habitatsFilePath))
            {
                Console.WriteLine("Data files not found.");
                return;
            }

            DataStorage dataStorage = new DataStorage(animalsFilePath, habitatsFilePath);
            dataStorage.DisplayData();
            Console.WriteLine("\nQueue After Attempting to Remove 'Lion':");
            var updatedQueue = dataStorage.DisplayQueueWithoutAnimal("Lion");

            Console.WriteLine("Front -> ");
            foreach (var item in updatedQueue)
            {
                Console.WriteLine($"| {item} |");
            }
            Console.WriteLine("Back");

            while (true)
            {
                Console.WriteLine("\nEnter an animal to search for its habitat (or type 'exit' to quit):");
                string input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                string result = dataStorage.SearchAnimalHabitat(input);
                Console.WriteLine(result);
            }

            dataStorage.DisplayReversedStack();

            Console.WriteLine("\nRemove Animal from Queue:");
            dataStorage.RemoveFromQueue("Lion");
            dataStorage.DisplayData();
      

            Console.WriteLine("\nCustom Stack and Queue Demonstration:");

            var customStack = new CustomStack<string>();
            customStack.Push("A");
            customStack.Push("B");
            Console.WriteLine("Custom Stack Pop: " + customStack.Pop());  // Should print "B"
            Console.WriteLine("Is Custom Stack Empty? " + customStack.IsEmpty());

            var customQueue = new CustomQueue<string>();
            customQueue.Enqueue("X");
            customQueue.Enqueue("Y");
            Console.WriteLine("Custom Queue Dequeue: " + customQueue.Dequeue());  // Should print "X"
            Console.WriteLine("Is Custom Queue Empty? " + customQueue.IsEmpty());
        }
    }
}