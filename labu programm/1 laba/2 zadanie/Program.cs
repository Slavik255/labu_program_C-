using System;

namespace _2_zadanie
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Result(11111);
            Console.ReadLine();
        }
        static void Result(int seconds)
        {
            // Передаем данные, где изначально все 0, кроме передаваемых секунд
            // В итоге после используем struct для того, что бы найти минуты и часы и выводим
            TimeSpan a = new TimeSpan(0, 0, seconds);
            Console.WriteLine("Часов: {0}\nМинут: {1}\nСекунд: {2}", a.Hours, a.Minutes, a.Seconds);
            Console.ReadKey();
        }
    }
}
