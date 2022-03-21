using System;

namespace _3_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();
            Console.Write("Выберите действие (\"array\" или \"string\"): ");
            string way = Console.ReadLine();
            switch (way)
            {
                case "array":
                    first_way_3(text);
                    break;
                case "string":
                    second_way_3(text);
                    break;
                default:
                    Console.WriteLine("Я не знаю такой команды!!");
                    break;
            }
            Console.ReadKey();
        }
        static void first_way_3(string text)
        {
            string[] words = new string[text.Length];
            char[] trigger = { ' ' };
            int counter = 0;
            for (int i = 0; i < text.Length; i = text.IndexOfAny(trigger, i) + 1)
            {
                if (counter == 0)
                {
                    text += " ";
                }
                for (int j = i; j != text.IndexOfAny(trigger, i) && j < text.Length; j++)
                {
                    words[counter] += text[j];
                }
                counter++;
            }
            Array.Resize(ref words, counter);
            Array.Reverse(words);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
        }
        static void second_way_3(string text)
        {
            string[] str = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 1)
                    Console.Write(str[i] + ".");
                else
                    Console.Write(str[i] + " ");
            }
        }
    }
}
