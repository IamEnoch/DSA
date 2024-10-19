namespace SinglyLinkedList;

public static class Program
{
    public static void Main(string[] args)
    {
        var list = new SinglyLinkedList<int>();

        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddFirst(0);

        Console.WriteLine("List after adding nodes:");
        list.PrintAllNodes();
    }
}