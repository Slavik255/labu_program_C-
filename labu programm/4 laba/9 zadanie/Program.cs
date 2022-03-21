using System;

namespace _9_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            Console.WriteLine("\nЧерез обработку строки как массива символов:");
            Console.WriteLine(Array(text));
            Console.WriteLine("\nС помощью с помощью методов классов string и / или StringBuilder: ");
            Console.WriteLine(StringMethod(text));
            Console.ReadKey();
        }
        static string Array(string text)
        {
            string[] words = text.Split();
            foreach (string word in words)
            {
                char[] charWord = word.ToCharArray();
                if (charWord[0] == charWord[charWord.Length - 1])
                {
                    text = text.Replace(word, "");
                }
            }
            return text;
        }
        static string StringMethod(string text)
        {
            string[] words = text.Split();
            foreach (string word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    text = text.Replace(word, "");
                }
            }
            return text;
        }
    }
}
