using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    class Program
    {
        const int KMP = 1;
        const int BM = 2;


        /// <summary>
        ///         KMP |
        /// </summary>  v

        static int[] GetPrefix(string s)
        {
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {

                while (index >= 0 && s[index] != s[i]) { index--; }
                index++;
                result[i] = index;

            }

            return result;
        }

        static int FindSubstring(string pattern, string text)
        {


            int res = -1;
            int[] pf = GetPrefix(pattern);
            int index = 0;


            for (int i = 0; i < text.Length; i++)
            {

                while (index > 0 && pattern[index] != text[i]) { index = pf[index - 1]; }

                if (pattern[index] == text[i]) index++;
                if (index == pattern.Length)
                {
                    return res = i - index + 1;
                }
            }


            return res;
        }

        /// <summary>   ^
        ///         KMP |
        /// </summary>

        ///
        /// BM  |
        ///     v

        public static char[] SymbolOfX; //Таблица символов искомой строки  
        public static int[] ValueShift; //Таблица смещений для символов
        public static void ShiftBM(string x) //Процедура - формирование смещений
        {
            int j; //Счетчик
            int k = 0; //Счетчик
            bool fl; //Флаг
            SymbolOfX = new char[x.Length]; //Инициализация
            ValueShift = new int[x.Length]; //Инициализация
            //Цикл по искомой строке без последнего символа
            for (int i = x.Length - 2; i >= 0; i--)
            {
                fl = false; //Флаг
                j = 0; //Обнуление
                while ((j < k + 1) && (fl == false))
                {
                    if (SymbolOfX[j] == x[i]) fl = true;
                    j++;
                }
                if (fl == false)
                {
                    SymbolOfX[k] = x[i];
                    ValueShift[k] = x.Length - i - 1;
                    k++;
                }
            }
        }
        //Функция поиска алгоритмом БМ
        public static string BoerM(string x, string s)
        {
            bool has, have; //Флаги
            int l, j, i; //Счетчики
            ShiftBM(x); //Вызов процедуры, формирубщей таблицу смещений
            string nom = ""; //Строка с номерами вхождений
            if (x.Length > s.Length) return nom;
            //Основной цикл по исходной строке
            for (i = 0; i < s.Length - x.Length + 1; i++)
            {
                j = x.Length - 1;
                have = true;
                //Проверка с последнего символа                
                while ((j >= 0) && (have == true))
                {
                    //Если не совпадает символ искомой и исходной
                    if (s[i + j] != x[j])
                    {
                        have = false;
                        //Если это последний символ
                        if (j == x.Length - 1)
                        {
                            l = 0;
                            has = false; //Флаг
                            //Поиск символа в таблице смещений
                            while ((l < x.Length) && (has == false))
                            {
                                //Если символ есть
                                if (s[i + j] == SymbolOfX[l])
                                {
                                    has = true; //Изменение флага
                                    i = i + ValueShift[l] - 1; //Сдвиг на величину
                                }
                                l++;
                            }
                            //Если не найден символ в таблице смещений
                            if (has == false)
                                //Сдвиг на величину искомой строки
                                i = i + x.Length - 1;
                        }
                    }
                    j--;
                }
                if (have == true)
                    nom = nom + Convert.ToString(i) + ", ";
            }
            //Если строка номеров не пустая
            if (nom != "")
            {
                nom = nom.Substring(0, nom.Length - 2); //Удаление последней запятой и пробела
            }
            return nom; //Возвращение результата поиска
        }

        /// <summary>   ^
        ///         BM  |
        /// </summary>


        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст, в котором нужно искать подстроку:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите подстроку, которую нужно найти:");
            string pattern = Console.ReadLine();
            Console.WriteLine("Какой поиск использовать: 1 - КМП; 2 - БМ");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case KMP:
                    System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                    myStopwatch.Start();

                    int find = FindSubstring(pattern, text);
                    myStopwatch.Stop();
                    Console.WriteLine(myStopwatch.Elapsed);
                    Console.WriteLine($"Позиция найденного элемента: {find}");


                    break;
                case BM:
                    System.Diagnostics.Stopwatch myStopwatch1 = new System.Diagnostics.Stopwatch();
                    myStopwatch1.Start();

                    string find1 = BoerM(pattern, text);

                    myStopwatch1.Stop();
                    Console.WriteLine(myStopwatch1.Elapsed);

                    Console.WriteLine($"Позиция найденного элемента: {find1}");
                    break;

            }

            Console.ReadKey();
        }
    }
}
