namespace HashSetImplementation;

internal static class Program
{
    public static void Main(string[] args)
    {
        // Create a HashSet of integers
        var numbers = new HashSet<int>();

        // Add elements to the HashSet
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Try adding a duplicate element (will be ignored)
        var added = numbers.Add(20);
        Console.WriteLine($"Was 20 added? {added}"); // Output: False (since 20 already exists)

        // Check if a certain element exists in the HashSet
        var exists = numbers.Contains(20);
        Console.WriteLine($"Does 20 exist in the set? {exists}"); // Output: True

        // Remove an element from the HashSet
        numbers.Remove(10);

        // Iterate over elements in the HashSet
        Console.WriteLine("Current elements in the set:");
        foreach (var number in numbers) Console.WriteLine(number); // Output: 20, 30 (order may vary)

        // Perform a Union operation with another HashSet
        var otherNumbers = new HashSet<int> { 30, 40, 50 };
        numbers.UnionWith(otherNumbers);

        Console.WriteLine("Elements after UnionWith operation:");
        foreach (var number in numbers) Console.WriteLine(number); // Output: 20, 30, 40, 50

        // Perform an Intersection operation with another HashSet
        var intersectSet = new HashSet<int> { 30, 50, 60 };
        numbers.IntersectWith(intersectSet);

        Console.WriteLine("Elements after IntersectWith operation:");
        foreach (var number in numbers) Console.WriteLine(number); // Output: 30, 50

        // Demonstrating the removal of all elements
        numbers.Clear();
        Console.WriteLine($"HashSet contains {numbers.Count} elements after clearing.");
    }
}