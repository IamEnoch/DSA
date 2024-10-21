namespace DoublyLinkedList;

internal static class Progam
{
    public static void Main(string[] args)
    {
        var linkedList = new DoublyLinkedList<int>();

        linkedList.AddFirst(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);
        linkedList.AddLast(5);
        linkedList.AddFirst(10);

        linkedList.PrintNodesForward();
        linkedList.PrintNodesBackward();
    }
}