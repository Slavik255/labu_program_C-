using System;

namespace _4_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность квадратной матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] massiv_1 = new int[n, n];
            int[,] massiv_2 = new int[n, n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                for (int k = 0; k < n; k++)
                {
                    Console.Write("Введите элемент {0},{1} первой матрицы: ", i + 1, k + 1);
                    massiv_1[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                for (int k = 0; k < n; k++)
                {
                    Console.Write("Введите элемент {0},{1} второй матрицы: ", i + 1, k + 1);
                    massiv_2[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            Console.WriteLine("Ваши матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", massiv_1[i, k]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", massiv_2[i, k]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сложение: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", (massiv_2[i, k] + massiv_1[i, k]));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Вычитание: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                    Console.Write("\t{0}", (massiv_2[i, k] - massiv_1[i, k]));
                Console.WriteLine();
            }

            Console.WriteLine();
            double[] result = new double[2];
            double sum_1 = 0;
            double sum_2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    sum_1 = sum_1 + (massiv_1[i, k]);
                }
            }
            result[0] = sum_1 / massiv_1.Length;
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    sum_2 = sum_2 + (massiv_2[i, k]);
                }
            }
            result[1] = sum_2 / massiv_2.Length;
            Console.WriteLine("Среднее значение:\n\nПервый массив = {0}\n\nВторой массив = {1}", result[0], result[1]);
            Console.WriteLine();
        }
    }
}
