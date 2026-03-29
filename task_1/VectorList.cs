using System;

namespace Algorithms_and_data_structures;

public class VectorList
{
    private int[] _data;
    private int _size;
    private const int Capacity = 10;


    public int Count => _size;

    public VectorList()
    {
        _data = new int[Capacity];
        _size = 0;
    }

    public bool IsFull() => _size == Capacity;
    public bool IsEmpty() => _size == 0;

    public bool Add(int value)
    {
        if (IsFull())
        {
            Console.WriteLine("Помилка: Список заповнений!");
            return false;
        }
        _data[_size++] = value;
        return true;
    }

    public int RemoveAt(int index)
    {
        if (IsEmpty()) 
            throw new InvalidOperationException("Неможливо видалити: список порожній.");
        
        if (index < 0 || index >= _size)
            throw new IndexOutOfRangeException("Індекс поза межами списку.");

        int removedValue = _data[index];

        for (int i = index; i < _size - 1; i++)
        {
            _data[i] = _data[i + 1];
        }
        
        _size--;
        return removedValue;
    }

    public void Print()
    {
        Console.Write($"Векторний список: [ ");
        for (int i = 0; i < _size; i++)
        {
            Console.Write(_data[i] + (i < _size - 1 ? ", " : ""));
        }
        Console.WriteLine(" ]");
    }
}
