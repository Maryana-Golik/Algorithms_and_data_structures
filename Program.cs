using System;
using System.Text;

namespace Algorithms_and_data_structures;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {

            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("0. Exit");
            Console.Write("\nYour choice: ");

            string? choice = Console.ReadLine();
            if (choice == "0") break;

            switch (choice)
            {
                case "1": ExecuteTask1(); break;
                case "2": ExecuteTask2(); break;
                default: Console.WriteLine("Wrong choice."); break;
            }
        }
    }

    static void ExecuteTask1()
    {
        VectorList list = new VectorList();
        Random rnd = new Random();

        Console.WriteLine("Генерація 7 випадкових чисел...");
        for (int i = 0; i < 7; i++)
        {
            list.Add(rnd.Next(10, 100));
        }
        list.Print();

        Console.WriteLine("\nВидаляємо елемент з середини (індекс 3)...");
        try {
            int val = list.RemoveAt(3);
            Console.WriteLine($"Видалено число: {val}");
        } catch (Exception e) { Console.WriteLine(e.Message); }
        
        list.Print();
    }

    static void ExecuteTask2()
    {

        DoublyLinkedList list = new DoublyLinkedList();
        Random rnd = new Random();

        Console.WriteLine("Генерація 5 випадкових чисел...");
        for (int i = 0; i < 5; i++)
        {
            list.AddLast(rnd.Next(100, 1000));
        }
        list.Print();

        Console.WriteLine("\nВидаляємо перший елемент зі списку...");
        try {
            int val = list.RemoveFirst();
            Console.WriteLine($"Видалено число: {val}");
        } catch (Exception e) { Console.WriteLine(e.Message); }

        list.Print();
    }
}