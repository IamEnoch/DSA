namespace CommonOperations;

public static class Program
{
    private static void Main(string[] args)
    {
        //Create the linked list
        var myLinkedList = new LinkedList<string>();

        //Add elements to the linked list
        //Adding elements from the tail
        myLinkedList.AddLast("John");
        myLinkedList.AddLast("Doe");
        myLinkedList.AddLast("Sarah");

        //Iterate through the linked list to print the elements in the linked list
        Console.WriteLine("Printing the linked list elements");
        foreach (var item in myLinkedList) Console.Write(item + "=>"); //Expected output John=>Doe=>Sarah=>
        Console.WriteLine();

        //Adding elements from the head
        myLinkedList.AddFirst("Hibiscus");
        myLinkedList.AddFirst("Orange");

        Console.WriteLine();

        //Iterate through the linked list to print the elements in the linked list
        Console.WriteLine("Printing the linked list elements");
        foreach (var item in
                 myLinkedList) Console.Write(item + "=>"); //Expected output Orange=>Hibiscus=>John=>Doe=>Sarah=>
        Console.WriteLine();

        //Check if the linked list contains a certain element
        Console.WriteLine("Checking whether the linked list contains the word: Sarah");
        Console.WriteLine(myLinkedList.Contains("Sarah")); //Expected output: True

        Console.WriteLine();

        //Remove the last element of te linked list
        Console.WriteLine("Linked list elements after removing the last element(Node)");
        myLinkedList.RemoveLast();
        foreach (var item in myLinkedList) Console.Write(item + "=>"); //Expected output Orange=>Hibiscus=>John=>Doe=>
        Console.WriteLine();
    }
}