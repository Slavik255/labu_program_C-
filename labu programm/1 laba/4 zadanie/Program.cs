using System;

namespace _4_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a} = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"{a} = {b}");
        }
    }
}
