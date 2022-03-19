using System;

namespace _2_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер: ");
            int number = int.Parse(Console.ReadLine());

            bool plus = true;
            double pi = 0;
            for (int i = 1; i < number; i += 2)
            {
                if (plus)
                {
                    pi += 1.0 / i;

                }
                else
                {
                    pi -= 1.0 / i;
                }
                plus = !plus;
            }
            pi *= 4;
            Console.WriteLine("Значение pi: " + pi);
        }
    }
}
