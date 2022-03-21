using System;

namespace _2_zadanie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();
            Console.WriteLine("\nЧерез обработку строки как массива символов: \n");
            Stroka(text);
            Console.WriteLine("\nС помощью метода класса string: \n");
            Console.WriteLine(String(text));
            Console.ReadKey();
        }
        // Через строку
        static void Stroka(string text)
        {
            int a = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]) && (text[i + 1] == ' ' || text[i + 1] == '-' || text[i + 1] == '.' || text[i + 1] == ','))
                {
                    a++;
                    Console.Write($"{text[i]}({a})");
                }
                else
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
        }
        // Через метод класса
        static string String(string text)
        {
            string text_2 = text;
            for (int i = 1, n = 1, count = 1; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]) && (text[i + 1] == ' ' || text[i + 1] == '-' || text[i + 1] == '.' || text[i + 1] == ','))
                {
                    string number = $"({count++})";
                    text_2 = text_2.Insert(i + n, number);
                    n += number.Length;
                }
            }
            return text_2;
        }
    }
}