using System;

namespace _8_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for (i = 1; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    k = 101 * i + 10 * j;
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
