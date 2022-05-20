using System;
using System.IO;

namespace _1_zadanie
{
    class Program
    {
        const int Linear = 1;
        const int Binary = 2;
        const int Interpolation = 3;

        /// <summary>
        /// Линейный поиск  |
        /// </summary>      v


        static int LinearSearch(int[] array, int x)//Находит все элементы и выводит позицию каждого
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int NotFoundResult = -1;
            int result = NotFoundResult;
            int count = 0;
            for (int index = 0; index < array.Length; index++)
            {
                count++;
                if (array[index] == x)
                {

                    result = index;
                    Console.WriteLine($"Позиция элемента: {result}");
                }
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");
            return result;
        }
        static int BetterLinearSearch(int[] array, int x)//Находит первое вхождение элемента
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int NotFoundResult = -1;
            int count = 0;
            for (int index = 0; index < array.Length; index++)
            {
                count++;
                if (array[index] == x)
                {
                    Console.WriteLine($"Позиция элемента: {index}");
                    myStopwatch.Stop();
                    Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");
                    return index;
                }
            }
            Console.WriteLine($"Элемента не найден: {NotFoundResult}");

            return NotFoundResult;
        }

        //public int SentinelLinearSearch(int[] array, int count, int x)
        //{
        //    int NotFoundResult = -1;
        //    int last = array[count - 1];
        //    array[count - 1] = x;

        //    int index = 0;

        //    while (array[index] != x)
        //    {
        //        index++;
        //    }

        //    array[count - 1] = last;

        //    if (index < count - 1 || array[count - 1] == x)
        //    {
        //        return index;
        //    }

        //    return NotFoundResult;
        //}
        /// <summary>       ^
        /// Линейный поиск  |
        /// </summary>      

        ///
        /// Бинарный поиск  |
        ///                 v
        //public static int Binary_Find(int[] m, int left, int right, int item)
        //{


        //    if (left > right)
        //        return -1;
        //    int found = left + (right - left) / 2;
        //    if (m[found] > item)
        //    {  return Binary_Find(m, left, found - 1, item); }
        //    else if (m[found] < item)
        //    {  return Binary_Find(m, found + 1, right, item); }
        //    else

        //    return m[found];

        //}
        public static void Binary_Find(int number, int[] mass)
        {

            int mid,
                left = 0,
                right = mass.Length - 1;
            bool flag = false;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (number < mass[mid]) { right = mid - 1; }

                if (number > mass[mid]) { left = mid + 1; }

                if (number == mass[mid])
                {

                    flag = true;
                    Console.WriteLine("Элемент найден на позиции:" + mass[mid]);
                    break;
                }
            }
            if (flag == false) Console.WriteLine("Поиск произведён! Нужного элемента нет в массиве.");
        }
        ///                 ^
        /// Бинарный поиск  |
        ///            

        ///
        /// Интерполяционный поиск  |
        ///                         v
        static int InterpolationSearch(int[] sortedArray, int toFind)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            // Возвращает индекс элемента со значением toFind или -1, если такого элемента не существует
            int mid;
            int low = 0;
            int high = sortedArray.Length - 1;

            while (sortedArray[low] < toFind && sortedArray[high] > toFind)
            {

                mid = low + ((toFind - sortedArray[low]) * (high - low)) / (sortedArray[high] - sortedArray[low]);



                if (sortedArray[mid] < toFind)
                { low = mid + 1; }

                else if (sortedArray[mid] > toFind)
                { high = mid - 1; }
                else
                {
                    return mid;
                }
            }

            if (sortedArray[low] == toFind)
            {

                return low;
            }
            if (sortedArray[high] == toFind)
            {

                return high;
            }
            return -1; // Not found

        }
        ///                         ^
        /// Интерполяционный поиск  |
        ///            


        static void Main(string[] args)
        {
            int[] array = new int[100000];

            StreamReader str = new StreamReader("sorted.dat");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(str.ReadLine());
            }


            Console.WriteLine("Выберите, какой использовать поиск элемента в массиве: 1 - линейный; 2 - бинарный; 3 - интерполяционный");


            int Choise = int.Parse(Console.ReadLine());

            switch (Choise)
            {

                case Linear:
                    Console.WriteLine("Введите, какой элемент нужно найти:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Как искать элемент: \n1 - искать все элементы, которые есть в массиве; \n2 - искать первое вхождение элемента");
                    int count = int.Parse(Console.ReadLine());
                    try
                    {
                        if (count == 1)
                        {
                            LinearSearch(array, x);
                        }
                        else if (count == 2)
                        {
                            BetterLinearSearch(array, x);
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели не тот номер");
                    }

                    break;
                case Binary:

                    Console.WriteLine("Введите, какой элемент нужно найти:");
                    int x1 = int.Parse(Console.ReadLine());

                    try
                    {
                        System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                        myStopwatch.Start();
                        //int result = Binary_Find(array, 0, array.Length - 1, x1);
                        Binary_Find(x1, array);
                        Console.WriteLine(myStopwatch.Elapsed);
                        //Console.WriteLine("Элемент найден на позиции {0}", result);

                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели не тот номер");
                    }
                    break;
                case Interpolation:
                    Console.WriteLine("Введите, какой элемент нужно найти:");
                    int x2 = int.Parse(Console.ReadLine());

                    try
                    {
                        System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                        myStopwatch.Start();
                        int result = InterpolationSearch(array, x2);
                        myStopwatch.Stop();
                        Console.WriteLine(myStopwatch.Elapsed);
                        Console.WriteLine("Элемент найден на позиции {0} ", result);

                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели не тот номер");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
