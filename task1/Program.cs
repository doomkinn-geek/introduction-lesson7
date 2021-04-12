using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите а: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a % b;
            Console.WriteLine($"Результат '%' - {c}");
            c = a / b;
            Console.WriteLine($"Результат '/' - {c}");
            c = a * b;
            Console.WriteLine($"Результат '*' - {c}");
            c = a - b;
            Console.WriteLine($"Результат '-' - {c}");
            c = a + b;
            Console.WriteLine($"Результат '+' - {c}");

        }
    }
}
