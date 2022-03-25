using System;
using System.IO;

namespace _5_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileNazvanie = Directory.GetFiles(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\6 laba\5 zadanie\images");
            Console.WriteLine("Текущие файлы в директории:");
            for (int i = 0; i < fileNazvanie.Length; i++)
            {
                Console.WriteLine(fileNazvanie[i]);
            }

            Console.WriteLine("Введите имя файла:");
            string file = @"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\6 laba\5 zadanie\images\" + Console.ReadLine();
            using (var reader = new BinaryReader(File.OpenRead(file)))
            {
                reader.BaseStream.Position = 2;
                Console.WriteLine($"\nРазмер файла в байтах: {reader.ReadInt32()}");
                reader.BaseStream.Position = 18;
                Console.WriteLine($"Ширина изображения в пикселях: {reader.ReadInt32()}");
                reader.BaseStream.Position = 22;
                Console.WriteLine($"Высота изображения в пикселях: {reader.ReadInt32()}");
                reader.BaseStream.Position = 28;
                Console.WriteLine($"Количество бит на пиксель: {reader.ReadInt16()}");
                reader.BaseStream.Position = 38;
                Console.WriteLine($"Горизонтальное разрешение, пиксел/м: {reader.ReadInt32()}");
                reader.BaseStream.Position = 42;
                Console.WriteLine($"Вертикальное разрешение, пиксел/м: {reader.ReadInt32()}");
                reader.BaseStream.Position = 30;
                Console.WriteLine($"Тип сжатия: {reader.ReadInt32()}");
            }
        }
    }
}