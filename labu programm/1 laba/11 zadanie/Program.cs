using System;

namespace _11_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое уравнение: y = sin^3(x^2 + a)^2 - корень(x / b)");
            Console.WriteLine("Второе уравнение: z = (x^2 / a) + cos(x + b)^3");
            Console.Write("Введите a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x: ");
            double x = Convert.ToInt32(Console.ReadLine());

            double y = Math.Pow(Math.Sin(Math.Pow((Math.Pow(x, 2) + a), 2)), 3) - (Math.Sqrt(x / b));
            double z = (Math.Pow(x, 2) / a) + (Math.Pow(Math.Cos(x + b), 3));

            Console.WriteLine("\nВаш ответ: y = {0}, z = {1}", y, z);
            Console.ReadKey();
        }
    }
}
