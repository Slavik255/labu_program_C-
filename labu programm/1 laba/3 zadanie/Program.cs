using System;

namespace _3_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Часы: ");
            int chasu = Convert.ToInt32(Console.ReadLine());
            if (chasu > 23 || chasu < 0)
            {
                Console.WriteLine("Ошибка!!!");
            }
            else
            {
                Console.Write("Минуты: ");
                int min = Convert.ToInt32(Console.ReadLine());
                if (min > 59 || min < 0)
                {
                    Console.WriteLine("Ошибка!!!");
                }
                else
                {
                    Console.Write("Секунды: ");
                    int sek = Convert.ToInt32(Console.ReadLine());
                    if (sek > 59 || sek < 0)
                    {
                        Console.WriteLine("Ошибка!!!");
                    }
                    else
                    {
                        int summa = (chasu * 3600) + (min + 60) + sek;
                        int ygol = (summa / 10) % 360;
                        Console.WriteLine("Угол будет равен " + ygol + " градусов");
                    }
                }
            }
        }
    }
}
