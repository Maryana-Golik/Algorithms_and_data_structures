using System;
using System.Text;

namespace Algorithms_and_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("1. Тест 1");
                Console.WriteLine("2. Тест 2");
                Console.WriteLine("0. Вихід");
                Console.Write("\nВаш вибір: ");

                string? choice = Console.ReadLine();
                if (choice == "0") break;

                switch (choice)
                {
                    case "1": ExecuteTask1(); break;
                    case "2": ExecuteTask2(); break;
                    default: Console.WriteLine("Невірний вибір. Спробуйте ще раз."); break;
                }
            }
        }

        static void ExecuteTask1()
        {
            VectorList list = new VectorList();
            Random rnd = new Random();

            Console.WriteLine("\n--- ТЕСТУВАННЯ РІВНЯ 1 ---");
            Console.WriteLine("Генерація випадкових чисел до заповнення списку...");
            
            while (!list.IsFull()) 
            {
                list.Add(rnd.Next(10, 100));
            }
            list.Print();

            try 
            {
                if (!list.IsEmpty()) 
                {
                    int randomIndex = rnd.Next(0, list.Count); 
                    Console.WriteLine($"\nВидаляємо елемент за випадковим індексом {randomIndex}...");
                    
                    int val = list.RemoveAt(randomIndex);
                    Console.WriteLine($"Успішно видалено число: {val}");
                }
            } 
            catch (Exception e) 
            { 
                Console.WriteLine($"Помилка: {e.Message}"); 
            }

            list.Print();
        }

        static void ExecuteTask2()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Random rnd = new Random();

            Console.WriteLine("\n--- ТЕСТУВАННЯ РІВНЯ 2 ---");
            Console.WriteLine("Генерація 8 випадкових чисел...");
            for (int i = 0; i < 8; i++)
            {
                list.AddLast(rnd.Next(100, 1000));
            }
            list.Print();

            try 
            {
                if (!list.IsEmpty())
                {
                    int randomIndex = rnd.Next(0, list.Count);
                    Console.WriteLine($"\nВидаляємо вузол за випадковим індексом {randomIndex}...");
                    
                    int val = list.RemoveAt(randomIndex);
                    Console.WriteLine($"Успішно видалено число: {val}");
                }
            } 
            catch (Exception e) 
            { 
                Console.WriteLine($"Помилка: {e.Message}"); 
            }

            list.Print();
        }
    } 
} 