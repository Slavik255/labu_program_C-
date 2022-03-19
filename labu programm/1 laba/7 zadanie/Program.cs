using System;

namespace _7_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("{0} -> ", a);
            //берем остаток каждый раз и повторяем пока полностью не переберем все число 
            // То есть получим 0, что прекращает работу while(true)
            int reversed = a % 10;
            while ((a /= 10) != 0)
            {
                reversed = reversed * 10 + a % 10;
            }
            Console.WriteLine("{0}", reversed);
        }
    }
}
