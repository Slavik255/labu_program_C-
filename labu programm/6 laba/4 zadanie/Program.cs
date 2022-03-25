using System;
using System.Collections.Generic;
using System.IO;

namespace _4_zadanie
{
    internal class Program
    {
        static void Main()
        {
            string text;

            string direktoria = @"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\6 laba\4 zadanie\Lab6_Temp";
            string sozdannoe = @"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\6 laba\1 zadanie\lab.dat";
            string kopirovanie = @"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\6 laba\4 zadanie\Lab6_Temp\lab.dat";
            string podobie_sozdannoe = direktoria + "\\lab_backup.dat";

            var direktoriaInfo = new DirectoryInfo(direktoria);
            // Проверяем существует ли файл, если нет, создаем
            if (!direktoriaInfo.Exists)
            {
                direktoriaInfo.Create();
            }

            if (File.Exists(kopirovanie))
            {
                File.Delete(kopirovanie);
            }
            File.Copy(sozdannoe, kopirovanie);

            List<byte> byteList = new List<byte>();

            // Считывание в байты
            using (StreamReader schituvanie = new StreamReader(sozdannoe, System.Text.Encoding.UTF8))
            {
                text = schituvanie.ReadToEnd();
            }

            // Чтение и запись
            using (FileStream chtenie = new FileStream(podobie_sozdannoe, FileMode.OpenOrCreate))
            {
                byte[] massiv = System.Text.Encoding.Default.GetBytes(text);
                chtenie.Write(massiv, 0, massiv.Length);
                Console.WriteLine("Текс из файла 'lab.dat' записан в файл 'lab_backup.dat'");
            }

            FileInfo fileInfo = new FileInfo(podobie_sozdannoe);
            Console.WriteLine();
            Console.WriteLine("Информация о файле 'lab.dat'");
            Console.WriteLine("Размер файла: " + fileInfo.Length);
            Console.WriteLine("Время последнего изменения: " + fileInfo.LastWriteTime);
            Console.WriteLine("Время последнего доступа: " + fileInfo.LastWriteTime);

            Console.ReadKey();

        }
    }
}
