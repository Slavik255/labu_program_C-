using System;

namespace _5_zadanie
{
    internal class Program
    {
        static void Perimetr(double a, double b)
        {
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Периметр данного треугольника:  " + c);
        }
        static void Plochat(double a, double b)
        {
            double c = (a * b) / 2;
            Console.WriteLine("Площадь данного треугольника:  " + c);
            Perimetr(a, b);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double a, b;
                // Проверка на то, что вводится, дальше передаем где все вычисляеться и готово
                try
                {
                    Console.WriteLine("Введите первый катет: ");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второй катет: ");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!!!");
                    break;
                }
                Plochat(a, b);
            }
        }
    }
}
