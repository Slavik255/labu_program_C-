using System;

namespace _7_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую боковую сторону треугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую боковую сторону треугольника: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону(основание) треугольника: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Error");
            }
            if (a == b && a + b > c)
            {
                Console.WriteLine("True");
            }
            if (a + b > c || a + c > b || c + b > a)
            {
                Console.WriteLine("False");
            }
        }
    }
}
