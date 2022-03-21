using System;

namespace _1_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Через обработку строки как массива символов: ");
            Stroka(text);
            Console.WriteLine();
            Console.WriteLine("Через методы класса string: ");
            String(text);
            Console.WriteLine();
        }
        // Работа через строку
        static void Stroka(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                int n = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (text[i] == text[j])
                    {
                        n++;
                    }
                }
                if (n == 0)
                {
                    Console.Write(text[i] + " ");
                }
            }

        }
        // Работа через метод класса
        static void String(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text.IndexOf(text[i]) == text.LastIndexOf(text[i]))
                {
                    Console.Write(text[i] + " ");
                }
            }
        }
    }
}
