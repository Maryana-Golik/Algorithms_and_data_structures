
using System;
using System.Text;

namespace lab_3
{

    class Program
    {
        static void Main(string[] args)
        {


            BinaryStudentTree universityTree = new BinaryStudentTree();

            Console.WriteLine("ЛАБОРАТОРНА РОБОТА 1.3");


            // --- ЗАВДАННЯ ПЕРШОГО РІВНЯ ---
            Console.WriteLine("ЕТАП 1: Наповнення дерева елементами...");
            
            universityTree.Add(new Student("Коваль", "Андрій", 2, "KB10250967", "Спорт"));
            universityTree.Add(new Student("Мельник", "Марія", 1, "KB10106758", "Музика"));
            universityTree.Add(new Student("Бондар", "Олег", 2, "KB10454374", "Спорт"));
            universityTree.Add(new Student("Ткач", "Олена", 3, "KB10301290", "Малювання"));
            universityTree.Add(new Student("Шевченко", "Іван", 2, "KB10054587", "Танці"));


            universityTree.Add(new Student("Дублікат", "Тест", 4, "KB10106758", "Нічого"));

            Console.WriteLine("\nВміст дерева після створення (Послідовний обхід):");
            universityTree.PrintTree();


            // --- ЗАВДАННЯ ДРУГОГО РІВНЯ ---
            Console.WriteLine("\nЕТАП 2: Пошук вузлів за критерієм.");
            Console.WriteLine("Згідно з варіантом 5: Студенти 2-го курсу, хобі - Спорт.");
            
  
            universityTree.SearchByInputCriteria();

            Console.WriteLine("\nРоботу завершено. Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }

}