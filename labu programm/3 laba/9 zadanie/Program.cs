using System;

namespace _9_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] massiv = new int[9, 9];

            // Заполнение массива и его вывод
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    massiv[i, j] = random.Next(0, 20);
                }
            }
            Console.WriteLine("Матрица 9 x 9: ");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(massiv[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //По главной диагонали и побочной диагонали
            int glav_diagonal;
            int pobochnaia_diagonal;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == j)
                    {
                        glav_diagonal = massiv[i, j];
                        massiv[i, j] = massiv[9 - 1 - i, i];
                        massiv[9 - 1 - i, i] = glav_diagonal;
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i + j == 9 - 1)
                    {
                        pobochnaia_diagonal = massiv[i, j];
                        massiv[i, j] = massiv[9 - 1 - i, i];
                        massiv[9 - 1 - i, i] = pobochnaia_diagonal;
                    }
                }
            }

            //Отображение главной и побочной диагонали симметрично относительно вертикальной оси
            Console.WriteLine("Отображение главной и побочной диагонали симметрично относительно вертикальной оси:");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
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
