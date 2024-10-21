namespace DoublyLinkedList;

public class DoublyLinkedList<T>
{
    // We implement a tail in this case to facilitate reverse traversal
    private DoublyLinkedListNode<T>? _head = null;
    private DoublyLinkedListNode<T>? _tail = null;


    //Add first node
    public void AddFirst(T data)
    {
        var firstNode = new DoublyLinkedListNode<T>(data);
        if (_head == null)
        {
            _head = firstNode;
            _tail = firstNode;
        }
        else
        {
            firstNode.Next = _head;
            _head.Prev = firstNode;
            _head = firstNode; // Update head. This is a reference to the first node.
        }
    }

    //Add last node
    public void AddLast(T data)
    {
        var lastNode = new DoublyLinkedListNode<T>(data);
        if (_head == null)
        {
            _head = lastNode;
            _tail = lastNode;
        }
        else
        {
            lastNode.Prev = _tail;
            _tail.Next = lastNode;
            _tail = lastNode; // Update tail. This is a reference to the last node.
        }
    }

    //Print nodes forward
    public void PrintNodesForward()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }

    //Print nodes backward
    public void PrintNodesBackward()
    {
        var current = _tail;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Prev;
        }

        Console.WriteLine("null");
    }
}