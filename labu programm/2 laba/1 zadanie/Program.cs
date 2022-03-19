using System;

namespace _1_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа для решения уравнения a*x^2 + b*x + c = 0");
            Console.WriteLine("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discr = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            if (discr == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("\nx = {0}", x);
            }
            else if (discr > 0)
            {
                double x1 = (-b + discr) / (2 * a);
                double x2 = (-b - discr) / (2 * a);
                Console.WriteLine("\nD={0}, x1={1}, x2={2}", discr, x1, x2);
            }
            else
            {
                Console.WriteLine("\nРешений нет!");
            }

        }
    }
}
