// Decompiled with JetBrains decompiler
// Type: task1.Program
// Assembly: task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C6BE51C7-E6B9-4078-A343-F760C59CC936
// Assembly location: C:\Users\root\source\repos\introduction-lesson7\task1\bin\Release\netcoreapp3.1\task1.dll

using System;

namespace task1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
            Console.WriteLine("Приложение полученное в результате декомпиляции в dotPeek:");
            Console.Write("Введите а: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num2;
            Console.WriteLine(string.Format("Результат '%' - {0}", (object) (num1 % num3)));
            int num4 = num2;
            Console.WriteLine(string.Format("Результат '/' - {0}", (object) (num1 / num4)));
            int num5 = num2;
            Console.WriteLine(string.Format("Результат '*' - {0}", (object) (num1 * num5)));
            int num6 = num2;
            Console.WriteLine(string.Format("Результат '-' - {0}", (object) (num1 - num6)));
            int num7 = num2;
            Console.WriteLine(string.Format("Результат '+' - {0}", (object) (num1 + num7)));
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine(); 
    }
  }
}
