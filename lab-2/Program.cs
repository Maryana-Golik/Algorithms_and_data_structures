using System;

namespace lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Random rng = new Random(42); 


            int currentLevel = 1; 
            // ----------------------------------

            Console.WriteLine("=== ЛАБОРАТОРНА РОБОТА №2 (ЗАВДАННЯ РІВНЯ {0}) ===", currentLevel);
            Console.Write("Введіть розмір таблиці: ");
            if (!int.TryParse(Console.ReadLine(), out int size)) size = 10;

            HashTable ht = new HashTable(size, currentLevel);

            Square GenerateSquare()
            {

                bool makeInteger = rng.Next(0, 2) == 0;
                double x = rng.Next(1, 11);
                double y = rng.Next(1, 11);
                double side = makeInteger ? rng.Next(1, 11) : Math.Round(rng.NextDouble() * 9 + 1, 1);
                return new Square(x, y, side);
            }

            Console.WriteLine("\n--- ПРОЦЕС ВСТАВКИ ЕЛЕМЕНТІВ ---");
            for (int i = 0; i < 8; i++)
            {
                ht.Insert(GenerateSquare());
            }

            // Гарантована колізія: додаємо два однакові квадрати
            Console.WriteLine("\n[!] Спроба вставки однакових периметрів (колізія):");
            ht.Insert(new Square(5, 5, 5.0)); // P: 20
            ht.Insert(new Square(2, 2, 5.0)); // P: 20

            Console.WriteLine("\nФІНАЛЬНИЙ ВИГЛЯД ТАБЛИЦІ:");
            ht.Print();

            Console.WriteLine("\nПрограма завершена. Натисніть будь-яку клавішу...");
            Console.ReadKey();
        }
    }
}