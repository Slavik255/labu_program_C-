using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод пользователем предложений и запись в массив
            int number = 1;
            string[] text = new string[7];
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(number + ". " + "Введите строку: ");
                text[i] = Console.ReadLine();
                number++;
            }
            Console.WriteLine("\nЧерез обработку строки как массива символов:");
            Vuvod(List_com_array(text), The_number_of_spaces_array(text));
            Console.WriteLine("\nС помощью методов класса string:");
            Vuvod(List_com_method(text), The_number_of_spaces_method(text));
        }
        static void Vuvod(string[] list_com, int the_number_of_spaces)
        {
            // Вывод результата на консоль
            Console.WriteLine("Строки содержащие \".com\":");
            for (int i = 0; i < list_com.Length; i++)
            {
                Console.WriteLine(list_com[i]);
            }
            Console.WriteLine($"{the_number_of_spaces} строка содержит меньше всего пробелов.");
        }
        static string[] List_com_array(string[] text)
        {
            // Проверка на то, есть ли .com
            List<string> list_com = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string temp_string = text[i].ToLower();
                for (int j = 0; j < text[i].Length - 3; j++)
                {
                    if (temp_string[j].Equals('.') & temp_string[j + 1].Equals('c') & temp_string[j + 2].Equals('o') & temp_string[j + 3].Equals('m'))
                    {
                        list_com.Add(text[i]);
                    }
                }
            }
            return list_com.ToArray();
        }
        static int The_number_of_spaces_array(string[] text)
        {
            // Проверка на пробелы
            List<int> counts = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (text[i][j].Equals(' '))
                    {
                        count++;
                    }
                }
                counts.Add(count);
            }
            int the_number_of_spaces = counts.IndexOf(counts.Min()) + 1;
            return the_number_of_spaces;
        }
        static string[] List_com_method(string[] text)
        {
            // Проверка на то, есть ли .com
            List<string> list_com = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToLower().Contains(".com"))
                {
                    list_com.Add(text[i]);
                }
            }
            return list_com.ToArray();
        }
        static int The_number_of_spaces_method(string[] text)
        {
            // Проверка на пробелы
            List<int> counts = new List<int>();
            for (int i = 0; i < text.Length; i++)
            {
                int count = text[i].Count();
                counts.Add(count);
            }
            int the_number_of_spaces = counts.IndexOf(counts.Min()) + 1;
            return the_number_of_spaces;
        }
    }
}