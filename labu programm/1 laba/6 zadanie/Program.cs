using System;

namespace _6_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int cshuslo = Convert.ToInt32(Console.ReadLine());
            int result = (cshuslo % 10) * (cshuslo / 10 % 10) * (cshuslo / 100 % 10) * (cshuslo / 1000);
            Console.WriteLine("Произведение цифр: " + result);
        }
    }
}
