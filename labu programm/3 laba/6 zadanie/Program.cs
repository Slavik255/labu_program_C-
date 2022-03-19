using System;

namespace _6_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int k = int.Parse(Console.ReadLine());
            int[] massiv = new int[k];
            Random random = new Random();
            int sumRec = 0;
            int minRec = int.MaxValue;
            for (int i = 0; i < k; i++)
            {
                massiv[i] = random.Next(k);
                Console.Write(massiv[i] + " ");
            }
            Console.WriteLine(" ");
            Console.Write("\nИтерационно вычисляет сумму элементов массива: " + sumIterative(massiv));
            Console.Write("\n\nРекурсивно вычисляет сумму элементов массива: " + sumRecursive(massiv, sumRec));
            Console.Write("\n\nИтерационно вычисляет минимальный элемент в массиве: " + minIterative(massiv));
            Console.Write("\n\nРекурсивно вычисляет минимальный элемент в массиве: " + minRecursive(massiv, minRec));
            Console.WriteLine();
            Console.WriteLine();
        }
        //итерационно 
        static int sumIterative(int[] massiv)
        {
            int sum = default;
            for (int i = 0; i < massiv.Length; i++)
            {
                sum += massiv[i];
            }
            return sum;
        }

        //рекурсивно 
        static int sumRecursive(int[] massiv, int sumRec, int i = 0)
        {
            if (i >= massiv.Length)
            {
                return sumRec;
            }
            else
            {
                sumRec += massiv[i];
                i++;
            }
            return sumRecursive(massiv, sumRec, i);
        }

        //итерационно 
        static int minIterative(int[] massiv)
        {
            int min = massiv[0];
            for (int i = 1; i < massiv.Length; i++)
            {
                if (min > massiv[i])
                    min = massiv[i];
            }
            return min;
        }

        //рекурсивно 
        static int minRecursive(int[] massiv, int minRec, int i = 0)
        {
            if (i < massiv.Length)
            {
                if (massiv[i] < minRec)
                {
                    minRec = massiv[i];
                }
                return minRecursive(massiv, minRec, i + 1);
            }
            return minRec;
        }
    }

}


