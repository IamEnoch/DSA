namespace SinglyLinkedList;

public class SinglyLinkedList<T>
{
    //Head of the linked list
    private Node<T>? head;

    public SinglyLinkedList()
    {
        head = null;
    }

    //Add first node
    public void AddFirst(T data)
    {
        var newNode = new Node<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    // Add last node
    public void AddLast(T data)
    {
        var newNode = new Node<T>(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null) current = current.Next;

            current.Next = newNode;
        }
    }

    //Print all nodes
    public void PrintAllNodes()
    {
        var current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }
}