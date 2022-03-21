using System;
using System.Text.RegularExpressions;

namespace _6_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int col = 1;
            Console.WriteLine("Введите строку, например «15 + 36 = 51»: ");
            string text = Console.ReadLine();
            Regex number = new Regex(@"-?\d+");
            MatchCollection nums = number.Matches(text);
            foreach (Match match in nums)
            {
                int num = int.Parse(match.Value);
                Console.WriteLine($"{col}) будет " + num + "  ");
                col++;
            }
            Console.ReadKey();
        }
    }
}