namespace Queue;

internal class Program
{
    private static void Main()
    {
        var queue = new Queue<int>();

        // Adding elements to the queue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Accessing the front element
        Console.WriteLine("Front element: " + queue.Peek()); // Output: 10

        // Removing the front element
        Console.WriteLine("Dequeued element: " + queue.Dequeue()); // Output: 10

        // Displaying remaining elements
        foreach (var item in queue) Console.WriteLine(item);
    }
}