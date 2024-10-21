namespace DoublyLinkedList;

public class DoublyLinkedListNode<T>(T data)
{
    public T Data { get; set; } = data;
    public DoublyLinkedListNode<T>? Next { get; set; } = null;
    public DoublyLinkedListNode<T>? Prev { get; set; } = null;
}