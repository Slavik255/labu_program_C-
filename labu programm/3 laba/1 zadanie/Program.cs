using System;
using System.Linq;

namespace _1_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int limit_predela_1 = 1;
            int limit_predela_2 = 1;

            Console.Write("Введите число элементов массива: ");
            int a = int.Parse(Console.ReadLine());
            int[] massiv = new int[a];

            Console.WriteLine("Сам массив: ");
            Console.WriteLine();

            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = random.Next(-30, 45);
                if (limit_predela_1 > 10)
                {
                    Console.Write("\n");
                    limit_predela_1 = 1;
                }
                limit_predela_1++;
                Console.Write(massiv[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Массив в обратном порядке без отрицательных чисел: ");
            Console.WriteLine();

            massiv = massiv.Reverse().ToArray();
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] < 0)
                {
                    continue;
                }
                if (limit_predela_2 > 10)
                {
                    Console.Write("\n");
                    limit_predela_2 = 1;
                }
                limit_predela_2++;
                Console.Write(massiv[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
