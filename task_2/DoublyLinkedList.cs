using System;

namespace Algorithms_and_data_structures;

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(int data) { Data = data; }
}

public class DoublyLinkedList
{
    private Node? _head;
    private Node? _tail;

    public bool IsEmpty() => _head == null;

    public void AddLast(int value)
    {
        Node newNode = new Node(value);
        if (IsEmpty())
        {
            _head = _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;
        }
    }


    public int RemoveFirst()
    {
        if (IsEmpty()) 
            throw new InvalidOperationException("Список порожній.");

        int value = _head!.Data;

        if (_head == _tail)
        {
            _head = _tail = null;
        }
        else
        {
            _head = _head.Next;
            if (_head != null) _head.Prev = null;
        }
        return value;
    }

    public void Print()
    {
        Console.Write("Зв'язний список: ");
        Node? current = _head;
        if (current == null) Console.WriteLine("порожній.");
        
        while (current != null)
        {
            Console.Write(current.Data + (current.Next != null ? " , " : ""));
            current = current.Next;
        }
        Console.WriteLine();
    }
}
