using System;

namespace _1_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получает число, после чего производит преобразования
            // То есть на пример 2,24 - 2 = 0,24
            // После чего умнажает на десять и преобразует, откуда получается 2
            double x = 2.24;
            int d = (int)((x - (int)x) * 10);
            Console.WriteLine("Ваше число будет: " + d);
        }
    }
}
