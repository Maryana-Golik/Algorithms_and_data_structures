using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[]
            {
                new Student("Шевченко", "Андрій", "KB1234", "БС-21"),
                new Student("Коваленко", "Марія", "KB5678", "АП-12"),
                new Student("Бондар", "Олег", "KB9012", "ВВ-31"),
                new Student("Мельник", "Анна", "KB3456", "АП-11"),
                new Student("Ткаченко", "Іван", "KB7890", "БС-22")
            };

            Console.WriteLine("--- Початковий список студентів: ---");
            PrintArray(students);

            // Виклик методу сортування
            BubbleSortByGroup(students);

            Console.WriteLine("\n--- Відсортовано за назвою групи (за зростанням): ---");
            PrintArray(students);
            
            Console.ReadKey();
        }

        // Алгоритм бульбашки 
        static void BubbleSortByGroup(Student[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (string.Compare(array[j].GroupName, array[j + 1].GroupName) > 0)
                    {

                        Student temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(Student[] array)
        {
            foreach (var student in array)
            {
                Console.WriteLine(student);
            }
        }
    }
}