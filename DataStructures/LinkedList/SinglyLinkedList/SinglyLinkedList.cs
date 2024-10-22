namespace SinglyLinkedList;

public class SinglyLinkedList<T>
{
    //Head of the linked list
    private SinglyLinkedListNode<T>? _head = null;

    //Add first node
    public void AddFirst(T data)
    {
        var newNode = new SinglyLinkedListNode<T>(data)
        {
            Next = _head
        };
        _head = newNode;
    }

    // Add last node
    public void AddLast(T data)
    {
        var newNode = new SinglyLinkedListNode<T>(data);

        if (_head == null)
        {
            _head = newNode;
        }
        else
        {
            var current = _head;
            while (current.Next != null) current = current.Next; // Forward traversal of the singly linked list

            current.Next = newNode;
        }
    }

    //Print all nodes
    public void PrintAllNodes()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }
}