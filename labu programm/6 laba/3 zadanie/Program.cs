using System;
using System.IO;

namespace _3_zadanie
{
    // Вопрос о реализации

    internal class Program
    {
        static void Main()
        {
            string directory = @"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\6 laba\3 zadanie";

            string firstFilePath = directory + "\\lab.txt";
            string secondFilePath = directory + "\\lab2.txt";

            string newText = String.Empty;
            int countOfVoidStrings = 0;

            string[] text = File.ReadAllLines(firstFilePath);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != "")
                {
                    newText += text[i] + "\n";
                }
                else if (text[i + 1] != "")
                {
                    newText += "\n" + text[i + 1] + "\n";
                    i++;
                }
                else
                {
                    countOfVoidStrings++;
                }
            }

            File.WriteAllLines(secondFilePath, newText.Split('\n'));
            Console.WriteLine();
            Console.WriteLine("Количество пустых строк: " + countOfVoidStrings);
            Console.ReadLine();
        }
    }
}