using System;

namespace _3_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество эементов в массиве: ");
            int kol_element = int.Parse(Console.ReadLine());
            int[] massiv_nachalnui = new int[kol_element];
            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < kol_element; ++i)
            {
                massiv_nachalnui[i] = i;
                Console.Write(massiv_nachalnui[i] + "\t");
            }
            Console.WriteLine();

            Console.Write("Cдвигать массив влево: ");
            int sdvig_element = int.Parse(Console.ReadLine());
            int[] massiv_sdvig = new int[kol_element];

            for (int i = 0; i < kol_element; i++)
            {
                massiv_sdvig[i] = (i + sdvig_element) % massiv_nachalnui.Length;
                Console.Write(massiv_sdvig[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
