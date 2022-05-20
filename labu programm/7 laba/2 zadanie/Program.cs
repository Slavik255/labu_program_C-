using System;
using System.IO;

namespace _2_zadanie
{
    class Program
    {
        const int Vibor = 1;
        const int Vstavka = 2;
        const int Bubble = 3;
        const int Sheyker = 4;
        const int Shell = 5;




        /// <summary>
        ///  Сортировка выбором |
        ///                     v
        /// </summary>


        static int[] ViborSort(int[] mas)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();

            int count = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;

                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        count++;
                        min = j;
                    }
                }
                //обмен элементов
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            myStopwatch.Stop();

            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < mas.Length; i++)
            {
                str.WriteLine(mas[i]);
            }
            str.Close();

            return mas;
        }
        static int[] ViborSortDecrease(int[] mas)//decrease - убывание
        {

            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск max числа
                int max = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] > mas[max])
                    {
                        count++;
                        max = j;
                    }
                }
                //обмен элементов
                int temp = mas[max];
                mas[max] = mas[i];
                mas[i] = temp;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");
            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < mas.Length; i++)
            {
                str.WriteLine(mas[i]);
            }
            str.Close();
            return mas;
        }

        /// <summary>
        ///  Сортировка выбором  ^
        ///                      |
        /// </summary>

        //
        //Сортировка вставками  |
        //                      v
        //

        static int[] InsertionSort(int[] array)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    count++;
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < array.Length; i++)
            {
                str.WriteLine(array[i]);
            }
            str.Close();

            return array;
        }
        static int[] InsertionSortDecrease(int[] array)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur > array[j - 1])
                {
                    count++;
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < array.Length; i++)
            {
                str.WriteLine(array[i]);
            }
            str.Close();
            return array;
        }

        //
        //Сортировка вставками  ^
        //                      |
        //

        //
        //Сортировка пузырьком  |
        //                      v
        //

        static int[] BubbleSort(int[] mas)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        count++;
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < mas.Length; i++)
            {
                str.WriteLine(mas[i]);
            }
            str.Close();
            return mas;
        }
        static int[] BubbleSortDecrease(int[] mas)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        count++;
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < mas.Length; i++)
            {
                str.WriteLine(mas[i]);
            }
            str.Close();
            return mas;
        }


        //
        //Сортировка пузырьком  ^
        //                      |
        //

        //
        //Сортировка шейкером   |
        //                      v
        //



        static void ArrSort(int[] myint)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();

            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed);
            Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < myint.Length; i++)
            {
                str.WriteLine(myint[i]);
            }
            str.Close();
        }


        static int[] ArrSortDecrease(int[] myint)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left < right)
            {

                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] < myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] < myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed);
            Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < myint.Length; i++)
            {
                str.WriteLine(myint[i]);
            }
            str.Close();
            return myint;
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
        //
        //Сортировка шейкером   ^
        //                      |
        //


        /// <summary>
        /// Сортировка Шелла    |
        ///                     v
        /// </summary>

        static int[] ShellSort(int[] arr)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        count++;
                        Swap(arr, j, j + step);
                        j = j - step;
                    }
                }
                step = step / 2;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < arr.Length; i++)
            {
                str.WriteLine(arr[i]);
            }
            str.Close();
            return arr;
        }

        static int[] ShellDecrease(int[] arr)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            int count = 0;
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] < arr[j + step]))
                    {
                        count++;
                        Swap(arr, j, j + step);
                        j = j - step;
                    }
                }
                step = step / 2;
            }
            myStopwatch.Stop();
            Console.WriteLine(myStopwatch.Elapsed + $"\tколичество замен:{count}");

            StreamWriter str = new StreamWriter("sorted.dat");
            for (int i = 0; i < arr.Length; i++)
            {
                str.WriteLine(arr[i]);
            }
            str.Close();
            return arr;
        }
        /// <summary>
        /// Сортировка Шелла    ^
        ///                     |
        /// </summary>

        static void Main(string[] args)
        {
            int[] array = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int random = rand.Next(1, 10);
                array[i] = random;
                //Console.WriteLine(array[i]);
            }

            Console.WriteLine("Выберите, как сортировать массив: \n1 - Выбором \n2 - Вставками \n3 - Пузьрьком \n4 - Шейкером \n5 - Шелла \n");

            int Choise = int.Parse(Console.ReadLine());

            switch (Choise)
            {
                case Vibor:
                    Console.WriteLine("\nВыберите, как сортировать массив выбором : \n1 - Убывание \n2 - Возрастание \n");
                    int ChoiseV = int.Parse(Console.ReadLine());
                    if (ChoiseV == 1)
                    {
                        ViborSortDecrease(array);
                    }
                    else
                    {
                        ViborSort(array);
                    }
                    break;
                case Vstavka:
                    Console.WriteLine("\nВыберите, как сортировать массив вставками : \n1 - Убывание \n2 - Возрастание \n");
                    int ChoiseVs = int.Parse(Console.ReadLine());
                    if (ChoiseVs == 1)
                    {
                        InsertionSortDecrease(array);
                    }
                    else
                    {
                        InsertionSort(array);
                    }

                    break;
                case Bubble:
                    Console.WriteLine("\nВыберите, как сортировать массив пузырьком : \n1 - Убывание \n2 - Возрастание \n");
                    int ChoiseB = int.Parse(Console.ReadLine());
                    if (ChoiseB == 1)
                    {
                        BubbleSortDecrease(array);
                    }
                    else
                    {
                        BubbleSort(array);
                    }

                    break;

                case Sheyker:
                    Console.WriteLine("\nВыберите, как сортировать массив шейкером : \n1 - Убывание \n2 - Возрастание \n");
                    int ChoiseS = int.Parse(Console.ReadLine());
                    if (ChoiseS == 1)
                    {
                        ArrSortDecrease(array);
                    }
                    else
                    {
                        ArrSort(array);
                    }

                    break;
                case Shell:
                    Console.WriteLine("\nВыберите, как сортировать массив шейкером : \n1 - Убывание \n2 - Возрастание \n");
                    int ChoiseSh = int.Parse(Console.ReadLine());
                    if (ChoiseSh == 1)
                    {
                        ShellDecrease(array);
                    }
                    else
                    {
                        ShellSort(array);
                    }

                    break;

            }


            //Console.WriteLine("Отсортированный массив:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            Console.ReadKey();
        }
    }
}
