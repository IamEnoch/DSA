namespace HashMapImplementation;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Adding elements to a dictionary through intialization
        var fruits = new Dictionary<string, int>
        {
            { "Banana", 10 },
            { "Apple", 20 },
            { "Mango", 15 }
        };

        // Adding elements to a dictionary using the Add method
        fruits.Add("Orange", 25);

        // Accessing a value though a key
        Console.WriteLine("The number of bananas that we have is: " + fruits["Banana"]);

        // updating a value
        const int add = 5;
        fruits["Banana"] += add;
        Console.WriteLine($"We have added {add} bananas which brings it to a total of: {fruits["Banana"]}");

        // Check if a key exists
        Console.WriteLine("Checking if we have oranges...");
        Console.WriteLine($"Existence of oranges: {fruits.ContainsKey("Banana")}");

        // Iterate though the dictionary
        // Note that each element of a dictionary is of type KeyValuePair<TKey, TValue>
        foreach (var fruit in fruits) Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");

        // Get the total number of elements 
        Console.WriteLine($"The number of fruits in the system is: {fruits.Count}");

        // Clear all the element
        fruits.Clear();
        Console.WriteLine($"After clearing the inventory, we have {fruits.Count} fruits");
    }
}