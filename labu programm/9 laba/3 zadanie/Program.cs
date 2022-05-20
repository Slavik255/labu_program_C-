using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace _3_zadanie
{
    public class What
    {
        public class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }
        public class CircularLinkedList<T> : IEnumerable<T>
        {
            Node<T> head;
            Node<T> tail;
            int count;
            public void Add(T data)
            {
                Node<T> node = new Node<T>(data);
                if (head == null)
                {
                    head = node;
                    tail = node;
                    tail.Next = head;
                }
                else
                {
                    node.Next = head;
                    tail.Next = node;
                    tail = node;
                }
                count++;
            }
            public void Сheck(int start, int countingCount)
            {
                for (int i = 0; i < start + countingCount - 2; i++)
                {
                    head = head.Next;
                }
                Console.WriteLine("Победителем становится: " + head.Data);
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }
            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                Node<T> currently = head;
                do
                {
                    if (currently != null)
                    {
                        yield return currently.Data;
                        currently = currently.Next;
                    }
                }
                while (currently != head);
            }
        }
        public static void Main()
        {
            int number = 0;
            while (number > 2 || number < 1)
            {
                Console.Write("Введите 1, чтобы решить её с помощью циклического связанного списка\nВведите 2, чтобы решить её без каких-либо дополнительных структур данных:\n ");
                number = int.Parse(Console.ReadLine());
            }

            string people = String.Empty;
            using (StreamReader file = new StreamReader(Path.Combine(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\labu programm\9 laba\3 zadanie\User.txt")))
            {
                people = file.ReadToEnd();
            }

            string[] participants = people.Split(new char[] { ' ' });
            Console.Write("Напишите предложение: ");
            string[] signs = Console.ReadLine().Split(new char[] { ' ', ',', '-', '.', '?', ';', ':', '"' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Выберите, с какого человека начать, от 1 до {0}: ", participants.Length);
            int start = 0;

            while (start > participants.Length || start < 1)
            {
                start = int.Parse(Console.ReadLine());
            }

            if (number == 1)
            {
                CircularLinkedList<string> users = new CircularLinkedList<string>();
                foreach (string s in participants)
                {
                    users.Add(s);
                }
                users.Сheck(start, signs.Length);
            }

            else if (number == 2)
            {
                Console.WriteLine("Победителем становится: " + participants[(signs.Length % participants.Length) - 2 + start]);
            }
            Console.ReadLine();
        }
    }
}