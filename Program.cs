using System;

namespace lab2_Pim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления НОД двух натуральных чисел");
            Console.WriteLine("Введите первое чилсо:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе чилсо:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД чисел {a} и {b}:");
            Console.WriteLine(Nod(a, b));
            Console.ReadLine();



            static int Nod(int a, int b)
            {
                while ((a != 0) && (b != 0))
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }

                return Math.Max(a, b);
            }
        }
    }
}
