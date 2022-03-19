using System;

namespace _2_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Введите размер массива: ");
            int a = int.Parse(Console.ReadLine());
            int[,] massiv = new int[a, a];

            Console.WriteLine("Двумерный массив: ");
            Console.WriteLine();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    massiv[i, j] = random.Next(100);
                    Console.Write(massiv[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            for (int n = 0; n < 3; n++)
            {
                for (int i = 0; i < Math.Floor(Convert.ToDouble(a) / 2); i++)
                {
                    for (int j = 0; j < Math.Ceiling(Convert.ToDouble(a) / 2); j++)
                    {
                        int temp = massiv[i, j];
                        massiv[i, j] = massiv[j, a - 1 - i];
                        massiv[j, a - 1 - i] = massiv[a - 1 - i, a - 1 - j];
                        massiv[a - 1 - i, a - 1 - j] = massiv[a - 1 - j, i];
                        massiv[a - 1 - j, i] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Поворот двумерного массива на 90 градусов вправо: ");
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(massiv[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
