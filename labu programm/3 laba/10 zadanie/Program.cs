using System;

namespace _10_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задаем массив на 100 элементов случайных чисел
            int[] massiv = new int[100];
            Random random = new Random();
            for (int i = 0; i < massiv.Length; i++)
                massiv[i] = random.Next(-50, 50);

            // Проверка на числа
            int pervaia_polovina = 0;
            int vtoraia_polovina = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (i < massiv.Length / 2)
                    if (massiv[i] < 0)
                        pervaia_polovina++;

                if (i > massiv.Length / 2)
                    if (massiv[i] < 0)
                        vtoraia_polovina++;
            }

            // Вывод информации о массиве
            if (pervaia_polovina > vtoraia_polovina)
            {
                Console.WriteLine("1");
            }
            if (pervaia_polovina < vtoraia_polovina)
            {
                Console.WriteLine("2");
            }
            if (pervaia_polovina == vtoraia_polovina)
            {
                Console.WriteLine("0");
            }

            Console.ReadKey();
        }
    }
}
