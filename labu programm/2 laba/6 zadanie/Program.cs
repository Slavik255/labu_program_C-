using System;

namespace _6_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int vozrast = int.Parse(Console.ReadLine());

            if (vozrast <= 0)
            {
                Console.WriteLine("\nВозраст не может быть отрицательным!\n");
            }
            else if (vozrast > 100)
            {
                Console.WriteLine("\nМы столько не живем :(\n");
            }
            else
            {
                int a = vozrast % 10;

                if (a == 1)
                {
                    Console.WriteLine("\n" + vozrast + " год\n");
                }
                else if (a == 2 || a == 3 || a == 4)
                {
                    Console.WriteLine("\n" + vozrast + " года\n");
                }
                else
                {
                    Console.WriteLine("\n" + vozrast + " лет\n");
                }
            }
        }
    }
}
