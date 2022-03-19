using System;

namespace _7_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер члена ряда Фибоначи: ");
            int nomer = Convert.ToInt32(Console.ReadLine());
            if (nomer < 0)
            {
                Console.WriteLine("Введите положительное число");
            }
            else
            {
                Console.WriteLine("Число ряда Фибоначчи: " + Fibonacci(nomer));
            }
            Console.ReadKey();
        }
        static int Fibonacci(int nomer)
        {
            if (nomer == 0 | nomer == 1)
            {
                return 1;
            }
            return Fibonacci(nomer - 1) + Fibonacci(nomer - 2);
        }
    }
}
