using System;

namespace _5_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] firstMatrix = new int[n, n];
            int[,] secondMatrix = new int[n, n];
            int[,] thirdMatrix = new int[n, n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                for (int k = 0; k < n; k++)
                {
                    Console.Write("Введите элемент {0},{1} первой матрицы: ", i + 1, k + 1);
                    firstMatrix[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                for (int k = 0; k < n; k++)
                {
                    Console.Write("Введите элемент {0},{1} второй матрицы: ", i + 1, k + 1);
                    secondMatrix[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            Console.WriteLine("Ваши матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", firstMatrix[i, k]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", secondMatrix[i, k]);
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
                for (int k = 0; k < n; k++)
                    for (int q = 0; q < n; q++)
                        thirdMatrix[i, k] += firstMatrix[i, q] * secondMatrix[q, k];

            Console.WriteLine("Произведение двух матриц:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", thirdMatrix[i, k]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
