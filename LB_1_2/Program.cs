using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LB_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Основы языка и знакомство с основными элементами управления C#";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            double a, N, F, F1;
            Console.Write("Введите a >> ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите N >> ");
            N = Convert.ToDouble(Console.ReadLine());
            if (N<1)
                while (N < 1)
                {
                    Console.Write("N не может быть меньше 1!");
                    Console.Write("Введите N >> ");
                    N = Convert.ToDouble(Console.ReadLine());
                }
            int n;
            F = 0;
            //n = 0;
            //shag = 1;
            F1 = 1;
            Console.WriteLine("F = " + F1);
            for (n = 1; n <= N; n++)
            {
                F = F1 + 1f / Math.Pow(a, n);
                F1 = F;
                Console.WriteLine("F = " + F1);
            }
            Console.ReadKey();
        }
    }
}
