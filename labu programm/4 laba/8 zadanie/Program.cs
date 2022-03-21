using System;
using System.Linq;
using System.Text;

namespace _8_zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Я не смог реализовать Книжный шифр поэтому выбрал Шифр простой одинарной перестановки 
            Console.WriteLine("Нажмите 1, если хотите выбрать Шифр Гронсфельда\nНажмите 2, если хотите выбрать Шифр простой одинарной перестановки\nНажмите 3, если хотите выбрать Шифр Тритемиуса");
            string sector = Console.ReadLine();
            if (sector == "1")
            {
                Console.WriteLine("Введите текст сообщения");
                string text = Console.ReadLine();
                Console.WriteLine("Введите ключ (каждую цифру через пробел): ");
                string key = Console.ReadLine();
                Console.WriteLine(GronsfeldEncryption(text, key));
                Console.ReadLine();
            }
            if (sector == "2")
            {
                Console.WriteLine("Введите текст: ");
                string text = Console.ReadLine();
                Console.WriteLine("Введите ключ (каждую цифру через пробел): ");
                string key = Console.ReadLine();
                string encrypted = Encrypt(text, key);
                string decrypted = Decrypt(encrypted, key);
                Console.WriteLine("Расшифрованный текст: " + decrypted);
                Console.WriteLine("Зашифрованный текст: " + encrypted);
                Console.ReadKey();
            }
            if (sector == "3")
            {
                char[] alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,.".ToCharArray();

                // Пытаемся вычислить размерность таблицы
                Console.WriteLine("Символов в алфавите: " + alphabet.Length);
                int rows = 0, columns;
                bool isValidTable;
                do
                {
                    Console.Write("\nКоличество колонок в таблице: ");
                    isValidTable = int.TryParse(Console.ReadLine(), out columns) && columns > 1;
                    if (!isValidTable)
                    {
                        Console.WriteLine("Необходимо ввести число больше 1");
                    }
                    else
                    {
                        rows = alphabet.Length / columns;
                        isValidTable &= rows > 1 && rows * columns == alphabet.Length;
                        if (!isValidTable)
                        {
                            Console.WriteLine("Необходимо ввести число колонок таким образом, чтобы число строк таблицы было больше 1 и таблица могла вмещать в себе все символы алфавита");
                        }
                    }
                }
                while (!isValidTable);

                // Пытаемся получить ключевое слово
                char[] keyWord;
                bool isValidKeyWord;
                do
                {
                    Console.Write("\nВведите ключевое слово: ");
                    keyWord = Console.ReadLine().ToUpper().Distinct().ToArray();
                    isValidKeyWord = keyWord.Length > 0 && keyWord.Length <= alphabet.Length;
                    if (!isValidKeyWord)
                    {
                        Console.WriteLine("Ключевое слово не может быть пустой строкой или содержать число уникальных символов больше размера алфавита");
                    }
                    else
                    {
                        isValidKeyWord &= !keyWord.Except(alphabet).Any();
                        if (!isValidKeyWord)
                        {
                            Console.WriteLine("Ключевое слово не может содержать символы, которых нет в алфавите");
                        }
                    }
                }
                while (!isValidKeyWord);

                // Создаем таблицу
                var table = new char[rows, columns];

                // Вписываем в нее ключевое слово
                for (var i = 0; i < keyWord.Length; i++)
                {
                    table[i / columns, i % columns] = keyWord[i];
                }

                // Исключаем уникальные символы ключевого слова из алфавита
                alphabet = alphabet.Except(keyWord).ToArray();

                // Вписываем алфавит
                for (var i = 0; i < alphabet.Length; i++)
                {
                    int position = i + keyWord.Length;
                    table[position / columns, position % columns] = alphabet[i];
                }

                // Получаем сообщение, которое необходимо зашифровать
                string message;
                bool isValidMessage;
                do
                {
                    Console.Write("\nВведите сообщение: ");
                    message = Console.ReadLine().ToUpper();
                    isValidMessage = !string.IsNullOrEmpty(message);
                    if (!isValidMessage)
                    {
                        Console.WriteLine("Сообщение не может быть пустой строкой");
                    }
                }
                while (!isValidMessage);

                // Создаем место для будущего зашифрованного сообщения
                var result = new char[message.Length];

                // Шифруем сообщение
                for (var k = 0; k < message.Length; k++)
                {
                    char symbol = message[k];
                    // Пытаемся найти символ в таблице
                    for (var i = 0; i < rows; i++)
                    {
                        for (var j = 0; j < columns; j++)
                        {
                            if (symbol == table[i, j])
                            {
                                symbol = table[(i + 1) % rows, j]; // Смещаемся циклически на следующую строку таблицы и запоминаем новый символ
                                i = rows; // Завершаем цикл по строкам
                                break; // Завершаем цикл по колонкам
                            }
                        }
                    }
                    // Записываем найденный символ
                    result[k] = symbol;
                }

                // Выводим зашифрованное сообщение
                Console.WriteLine("\nЗашифрованное сообщение: " + new string(result));
            }
        }
        public static string GronsfeldEncryption(string _text, string _key)
        {
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯабвгдежзийклмнопрстуфхцчшщьыъэюя0123456789 ";
            int[] keys = _key.Select(ch => (int)Char.GetNumericValue(ch)).ToArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _text.Length; i++)
            {
                sb.Append(alphabet[(alphabet.IndexOf(_text[i]) + keys[i % keys.Length]) % alphabet.Length]);
            }

            return sb.ToString();
        }
        static string Decrypt(string text, string key)
        {
            string res = "";
            string[] strKey = key.Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < strKey.Length; j++)
                {
                    if (int.Parse(strKey[j]) == i + 1)
                    {
                        res += text[j];
                        break;
                    }
                }
            }
            return res;
        }
        static string Encrypt(string text, string key)
        {
            string res = "";
            string[] strKey = key.Split(' ');
            for (int i = 0; i < strKey.Length; i++)
            {
                res += text[int.Parse(strKey[i]) - 1];
            }
            return res;
        }
    }
}


