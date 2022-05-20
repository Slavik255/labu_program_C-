using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите пожалуйста математический текст: ");
            string text = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            try
            {
                for (int i = 0; i <= text.Length - 1; i++)
                {
                    if (text[i] == '(')
                    {
                        stack.Push('(');
                    }
                    else if (text[i] == ')')
                    {
                        stack.Pop();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Выражение записано неверно");
                Console.ReadKey();
                return;
            }
            if (stack.Count == 0) Console.WriteLine("Выражение записано верно");
            else Console.WriteLine("Выражение записано неверно");
            Console.ReadKey();
        }
    }
}
