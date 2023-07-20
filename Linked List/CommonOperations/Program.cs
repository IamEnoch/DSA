using System.Collections.Generic;

namespace CommonOperations;

class Program
{
    static void Main(string[] args)
    {
        //Create the linked list
        LinkedList<string> myLinkedList = new LinkedList<string>();

        //Add elements to the linked list
        //Adding elements from the tail
        myLinkedList.AddLast("John");
        myLinkedList.AddLast("Doe");
        myLinkedList.AddLast("Sarah");

        //Iterate through the linked list to print the elements in the linked list
        foreach (string item in myLinkedList)
        {
            Console.Write(item + "=>"); //Expected output John=>Doe=>Sarah
            Console.WriteLine();
        }

    }
}