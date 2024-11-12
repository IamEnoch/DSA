namespace Stack;

internal class Program
{
    private static void Main()
    {
        var stack = new Stack<int>();

        // Adding elements
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Accessing the top element
        Console.WriteLine("Top element: " + stack.Peek()); // Output: 30

        // Removing the top element
        Console.WriteLine("Popped element: " + stack.Pop()); // Output: 30

        // Displaying remaining elements
        foreach (var item in stack) Console.WriteLine(item);
    }
}