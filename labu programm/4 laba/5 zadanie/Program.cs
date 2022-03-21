using System;
using System.Text.RegularExpressions;

namespace _5_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("\nЧерез обработку строки как массива символов:");
            Text(text);
            Console.WriteLine("\nС помощью регулярных выражений:");
            Console.WriteLine(Regular(text));

        }
        static void Text(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (Char.IsUpper(word[0]) && Char.IsNumber(word[word.Length - 1]) && Char.IsNumber(word[word.Length - 2]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
        static string Regular(string text)
        {
            Regex regex = new Regex(@"([A-Z]{1})([a-z]*)([0-9]{2})");
            MatchCollection words = regex.Matches(text);
            string newtext = "";
            foreach (Match match in words)
            {
                newtext = newtext + match.Value + " ";
            }
            return newtext;
        }
    }
}