using System;
using System.Text;

namespace lab_3
{
public class BinaryStudentTree
    {

        private class Node
        {
            public Student Data;
            public Node? Left;
            public Node? Right;

            public Node(Student data) => Data = data;
        }

        private Node? _root; 


        public void Add(Student student)
        {
            _root = AddRecursive(_root, student);
        }

        private Node AddRecursive(Node? current, Student student)
{
    if (current == null) return new Node(student);


    int comparison = string.Compare(student.StudentID, current.Data.StudentID);

    if (comparison < 0)
    {
        current.Left = AddRecursive(current.Left, student);
    }
    else if (comparison > 0)
    {
        current.Right = AddRecursive(current.Right, student);
    }
    else
    {
        Console.WriteLine($"[!] Попередження: Студент з ID {student.StudentID} вже існує.");
    }
    return current;
}

        // ЗАВДАННЯ 1 РІВНЯ: Рекурсивний послідовний обхід (In-order)
        public void PrintTree()
        {
            if (_root == null)
            {
                Console.WriteLine("Дерево порожнє.");
                return;
            }
            PrintHeader();
            PrintRecursive(_root);
            Console.WriteLine(new string('-', 65));
        }

        private void PrintRecursive(Node? node)
        {
            if (node != null)
            {
                PrintRecursive(node.Left);
                Console.WriteLine(node.Data);
                PrintRecursive(node.Right);
            }
        }

        // ЗАВДАННЯ 2 РІВНЯ: Пошук за критеріями з клавіатури
        public void SearchByInputCriteria()
        {
            Console.WriteLine("\n--- Пошук за критеріями ---");
            Console.Write("Введіть курс для пошуку: ");
            if (!int.TryParse(Console.ReadLine(), out int searchCourse)) return;

            Console.Write("Введіть хобі для пошуку: ");
            string? searchHobby = Console.ReadLine();

            Console.WriteLine("\nРезультати пошуку:");
            PrintHeader();
            bool found = false;
            SearchRecursive(_root, searchCourse, searchHobby ?? "", ref found);
            
            if (!found)
            {
                Console.WriteLine("| " + "Збігів не знайдено".PadRight(61) + " |");
            }
            Console.WriteLine(new string('-', 65));
        }

        private void SearchRecursive(Node? node, int course, string hobby, ref bool found)
        {
            if (node == null) return;

            SearchRecursive(node.Left, course, hobby, ref found);

            if (node.Data.Course == course && node.Data.Hobby.Equals(hobby, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(node.Data);
                found = true;
            }

            SearchRecursive(node.Right, course, hobby, ref found);
        }

        private void PrintHeader()
        {
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("| Прізвище     | Ім'я       | Курс | Квиток     | Хобі         |");
            Console.WriteLine(new string('-', 65));
        }
    }


}