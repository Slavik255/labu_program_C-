using System;

namespace _8_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, result;
            Console.WriteLine("Уравнение: 3 * x^4 - 5 * x^3 + 2 * x^2 - x + 7 \nВведите х:");
            x = Convert.ToDouble(Console.ReadLine());
            result = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine("Ответ: {0}", result);
        }
    }
}
