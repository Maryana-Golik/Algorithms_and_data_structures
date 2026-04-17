using System;

namespace Algorithms_and_data_structures
{
    public class DoublyLinkedList
    {

        private class Node
        {
            public int Data;
            public Node? Next;
            public Node? Prev;
            public Node(int data) => Data = data;
        }

        private Node? _head;
        private Node? _tail;
        private int _count;

        public int Count => _count;
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
            _count++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty()) throw new InvalidOperationException("Порожньо");
            int val = _head!.Data;
            _head = _head.Next;
            if (_head != null) _head.Prev = null;
            else _tail = null;
            _count--;
            return val;
        }

        public int RemoveAt(int index)
        {
            if (index < 0 || index >= _count) throw new IndexOutOfRangeException();
            if (index == 0) return RemoveFirst();

            Node? current = _head;
            for (int i = 0; i < index; i++) current = current!.Next;

            int val = current!.Data;
            
            if (current == _tail)
            {
                _tail = current.Prev;
                _tail!.Next = null;
            }
            else
            {
                current.Prev!.Next = current.Next;
                current.Next!.Prev = current.Prev;
            }
            _count--;
            return val;
        }

        public void Print()
        {
            Console.Write("Зв'язний список: ");
            Node? current = _head;
            while (current != null)
            {
                Console.Write(current.Data + (current.Next != null ? ", " : ""));
                current = current.Next;
            }
            Console.WriteLine();
        }
    } 
} 