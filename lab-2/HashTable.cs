using System;
using System.Collections.Generic;

namespace lab_2
{
    public class HashTable
    {
        private LinkedList<Square>[] table;
        private int size;
        private int level; // 1 — без колізій, 2 — ланцюжки

        public HashTable(int size, int level)
        {
            this.size = size;
            this.level = level;
            table = new LinkedList<Square>[size];
            for (int i = 0; i < size; i++)
                table[i] = new LinkedList<Square>();
        }

        private int GetIndex(double key)
        {

            return Math.Abs(key.GetHashCode() % size);
        }

        public bool Insert(Square s)
        {
            if (s == null || !s.IsValid()) return false;

            double key = s.GetPerimeter();
            int index = GetIndex(key);

            // РІВЕНЬ 1: Якщо позиція зайнята — відмова
            if (level == 1 && table[index].Count > 0)
            {
                Console.WriteLine("  Вставка: ключ={0,5:G} → ПОМИЛКА: Позиція {1} зайнята", key, index);
                return false;
            }

            // РІВЕНЬ 2: Якщо позиція зайнята — додаємо в ланцюжок
            if (level == 2 && table[index].Count > 0)
                Console.WriteLine("  Вставка: ключ={0,5:G} → КОЛІЗІЯ! Додаємо в ланцюжок {1}", key, index);
            else
                Console.WriteLine("  Вставка: ключ={0,5:G} → Позиція {1} (вільно)", key, index);

            table[index].AddLast(s);
            return true;
        }

        public void Print()
        {
            Console.WriteLine("\n  {0,-10} | {1}", "Індекс", "Дані (P: периметр, S: площа)");
            Console.WriteLine("  " + new string('-', 65));

            for (int i = 0; i < size; i++)
            {
                Console.Write("  | {0,-8} | ", i);
                if (table[i].Count == 0)
                    Console.WriteLine("— [порожньо]");
                else
                {
                    string row = "";
                    foreach (var sq in table[i])
                    {
                        // Виводимо P і S, прибираючи зайві нулі через G
                        row += string.Format("P:{0:G} S:{1:G} | ", sq.GetPerimeter(), sq.GetArea());
                    }
                    Console.WriteLine(row.TrimEnd(' ', '|'));
                }
            }
        }
    }
}