using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1_zadanie
{
    class Program
    {
        public enum Vid
        {
            Тр,
            Тс,
            А
        }
        struct Worker
        {
            public Vid vidTransporta;
            public String marhrut;
            public decimal protiagennost;
            public int vremia;

            public void showTable()
            {
                Console.WriteLine($"|{vidTransporta,-24}|{marhrut,-12}|{protiagennost,-27}|{vremia,-20}|");
                Console.WriteLine(new String('-', 88));
            }
        }
        struct Log
        {
            public DateTime time;
            public string operation;
            public string name;

            public void logOutput()
            {
                Console.WriteLine("{0, -20} : {1, -15} {2, -15}", time, operation, name);
            }
        }
        public class DoublyNode<T>
        {
            public DoublyNode(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public DoublyNode<T> Previous { get; set; }
            public DoublyNode<T> Next { get; set; }
        }
        public class DoublyLinkedList<T> : IEnumerable<T>
        {
            DoublyNode<T> head;
            DoublyNode<T> tail;
            int count;
            public void Add(T data)
            {
                DoublyNode<T> node = new DoublyNode<T>(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    tail.Next = node;
                    node.Previous = tail;
                }
                tail = node;
                count++;
            }
            public bool Remove(T data)
            {
                DoublyNode<T> current = head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        break;
                    }
                    current = current.Next;
                }
                if (current != null)
                {
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    count--;
                    return true;
                }
                return false;
            }
            public void Change(T dataToChange, T newData)
            {
                DoublyNode<T> node = new DoublyNode<T>(dataToChange);
                DoublyNode<T> current = head;
                while (current != null)
                {
                    if (current.Data.Equals(dataToChange))
                    {
                        break;
                    }
                    current = current.Next;
                }
                current.Data = newData;
            }
            public int Count { get { return count; } }
            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }
            public bool Contains(T data)
            {
                DoublyNode<T> current = head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)this).GetEnumerator();
            }
            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                DoublyNode<T> current = head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
        }
        private static void Main(string[] args)
        {
            string choose = String.Empty;
            Console.Write("Введите 1, если вы хотите использовать таблицу с двойным списком\nВведите 2, если хотите использовать коллекцию .NET List\n");
            choose = Console.ReadLine();
            if (choose == "1")
            {
                Console.Write("Использование двусвязного списка\n");
                var logOfSession = new DoublyLinkedList<Log>();
                DateTime firstTime = DateTime.Now;
                DateTime secondTime = DateTime.Now;
                TimeSpan downtime = secondTime - firstTime;

                Worker Тр;
                Тр.vidTransporta = Vid.Тр;
                Тр.marhrut = "12";
                Тр.protiagennost = 27.55M;
                Тр.vremia = 75;

                Worker Тс;
                Тс.vidTransporta = Vid.Тс;
                Тс.marhrut = "17";
                Тс.protiagennost = 13.6M;
                Тс.vremia = 57;

                Worker А;
                А.vidTransporta = Vid.А;
                А.marhrut = "12а";
                А.protiagennost = 57.3M;
                А.vremia = 117;

                var tabl = new DoublyLinkedList<Worker>();
                tabl.Add(Тр);
                tabl.Add(Тс);
                tabl.Add(А);

                bool working = true;
                bool error = true;
                do
                {
                    Console.WriteLine("Выберите действие: ");
                    Console.WriteLine("1 - Просмотр таблицы.");
                    Console.WriteLine("2 - Добавить запись.");
                    Console.WriteLine("3 - Удалить запись.");
                    Console.WriteLine("4 - Обновить запись.");
                    Console.WriteLine("5 - Поиск записей.");
                    Console.WriteLine("6 - Просмотреть лог.");
                    Console.WriteLine("7 - Выход.");
                    int sektor = int.Parse(Console.ReadLine());
                    if (sektor == 1)
                    {
                        Console.WriteLine(new String('-', 88));
                        Console.WriteLine($"{"|Общественный транспорт",-87}|");
                        Console.WriteLine(new String('-', 88));
                        Console.WriteLine($"{"|Вид транспорта",-25}|{"№ Маршрута",-12}|{"Протяженность маршрута (км)",-20}|{"Время в дороге (мин)",-15}|");
                        Console.WriteLine(new String('-', 88));
                        foreach (var item in tabl)
                        {
                            item.showTable();
                        }
                        Console.WriteLine($"{"|Перечисляемый тип: Тр - трамвай, Тс - троллейбус, А - автобус",-87}|");
                        Console.WriteLine(new String('-', 88));
                    }
                    else if (sektor == 2)
                    {
                        Console.WriteLine("Введите данные: ");
                        var vidTransporta = Vid.А;
                        decimal protiagennost = 0;
                        int vremia = 0;
                        do
                        {
                            Console.WriteLine("Вид транспорта (Тр,Тс,А): ");
                            string tmp = Console.ReadLine();
                            if (tmp == "Tr" || tmp == "Тр")
                            {
                                vidTransporta = Vid.Тр;
                                break;
                            }
                            else if (tmp == "Tc" || tmp == "Тс")
                            {
                                vidTransporta = Vid.Тс;
                                break;
                            }
                            else if (tmp == "A" || tmp == "А")
                            {
                                vidTransporta = Vid.А;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод значения. Введите еще раз.");
                            }
                        }
                        while (error);
                        error = true;

                        Console.WriteLine("№ Маршрутa: ");
                        string marhrut = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Протяженность маршрута (км): ");
                            try
                            {
                                protiagennost = decimal.Parse(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                protiagennost = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                            catch (OverflowException)
                            {
                                protiagennost = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                        }
                        while (error);
                        error = true;

                        do
                        {
                            Console.WriteLine("Время в дороге (мин): ");
                            try
                            {
                                vremia = int.Parse(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                vremia = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                            catch (OverflowException)
                            {
                                vremia = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                        }
                        while (error);
                        error = true;

                        Worker newWorker;
                        newWorker.vidTransporta = vidTransporta;
                        newWorker.marhrut = marhrut;
                        newWorker.protiagennost = protiagennost;
                        newWorker.vremia = vremia;
                        tabl.Add(newWorker);

                        Log newLog;
                        newLog.time = DateTime.Now;
                        newLog.operation = "Добавлена запись";
                        newLog.name = marhrut;
                        logOfSession.Add(newLog);

                        firstTime = newLog.time;

                        TimeSpan secondDowntime = firstTime - secondTime;
                        if (downtime < secondDowntime)
                        {
                            downtime = secondDowntime;
                        }
                        secondTime = newLog.time;
                        Console.WriteLine();
                    }
                    else if (sektor == 3)
                    {
                        string v = String.Empty;
                        bool deleted = false;
                        string marhrut = string.Empty;
                        do
                        {
                            Console.WriteLine("Выберите полный № маршрута, который вы хотите удалить: ");
                            v = Console.ReadLine();
                            foreach (var item in tabl)
                            {
                                if (item.marhrut == v)
                                {
                                    tabl.Remove(item);
                                    deleted = true;
                                    marhrut = v;
                                    error = false;
                                    break;
                                }
                            }
                            if(!deleted)
                            {
                                Console.WriteLine("Такого маршрута нет!");
                            }                            
                        }
                        while (error);
                        error = true;

                        Log newLog;
                        newLog.time = DateTime.Now;
                        newLog.operation = "Запись удалена";
                        newLog.name = marhrut;
                        logOfSession.Add(newLog);

                        firstTime = newLog.time;
                        TimeSpan secondDowntime = firstTime - secondTime;
                        if (downtime < secondDowntime)
                        {
                            downtime = secondDowntime;
                        }
                        secondTime = newLog.time;
                        Console.WriteLine();
                    }
                    else if (sektor == 4)
                    {
                        string v = String.Empty;
                        string oldSurname = string.Empty;
                        string marhrut = string.Empty;
                        var vidTransporta = new Vid();
                        int vremia = 0;
                        decimal protiagennost = 0;
                        bool exit = true;
                        do
                        {
                            Console.WriteLine("Напишите полный № маршрута, которого вы хотите изменить: ");
                            v = Console.ReadLine();
                            foreach (var item in tabl)
                            {
                                if (item.marhrut == v)
                                {
                                    oldSurname = item.marhrut;
                                    Console.Write("Введите полный вид транспорта: ");
                                    marhrut = Console.ReadLine();
                                    do
                                    {
                                        Console.WriteLine("Вид транспорта (Тр,Тс,А): ");
                                        string tmp = Console.ReadLine();
                                        if (tmp == "Tr" || tmp == "Тр")
                                        {
                                            vidTransporta = Vid.Тр;
                                            error = false;
                                        }
                                        else if (tmp == "Tc" || tmp == "Тс")
                                        {
                                            vidTransporta = Vid.Тс;
                                            error = false;
                                        }
                                        else if (tmp == "A" || tmp == "А")
                                        {
                                            vidTransporta = Vid.А;
                                            error = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Некорректный ввод значения. Введите еще раз.");
                                            Console.WriteLine();
                                        }
                                    }
                                    while (error);
                                    error = true;

                                    Console.WriteLine("№ Маршрутa: ");
                                    marhrut = Console.ReadLine();

                                    do
                                    {
                                        Console.WriteLine("Протяженность маршрута (км): ");
                                        try
                                        {
                                            protiagennost = decimal.Parse(Console.ReadLine());
                                            error = false;
                                        }
                                        catch (FormatException)
                                        {
                                            protiagennost = 0;
                                            Console.WriteLine("Введены неверные данные!");
                                        }
                                        catch (OverflowException)
                                        {
                                            protiagennost = 0;
                                            Console.WriteLine("Введены неверные данные!");
                                        }
                                    }
                                    while (error);
                                    error = true;

                                    do
                                    {
                                        Console.WriteLine("Время в дороге (мин): ");
                                        try
                                        {
                                            vremia = int.Parse(Console.ReadLine());
                                            error = false;
                                        }
                                        catch (FormatException)
                                        {
                                            vremia = 0;
                                            Console.WriteLine("Введены неверные данные!");
                                        }
                                        catch (OverflowException)
                                        {
                                            vremia = 0;
                                            Console.WriteLine("Введены неверные данные!");
                                        }
                                    }
                                    while (error);

                                    Worker newtWorker;
                                    newtWorker.vidTransporta = vidTransporta;
                                    newtWorker.marhrut = marhrut;
                                    newtWorker.protiagennost = protiagennost;
                                    newtWorker.vremia = vremia;
                                    tabl.Change(item, newtWorker);
                                    exit = true;
                                }
                            }                          
                        }

                        while (error);
                        error = true;

                        if (!exit)
                            {
                                Console.WriteLine("Введите правильный полный вид транспорта!");
                            }
                        Log newLog;
                        newLog.time = DateTime.Now;
                        newLog.operation = "Обновлена запись";
                        newLog.name = oldSurname + " --> " + marhrut;
                        logOfSession.Add(newLog);

                        firstTime = newLog.time;
                        TimeSpan secondDowntime = firstTime - secondTime;
                        if (downtime < secondDowntime)
                        {
                            downtime = secondDowntime;
                        }
                        secondTime = newLog.time;
                        Console.WriteLine();
                    }
                    else if (sektor == 5)
                    {
                        var vidTransporta = new Vid();
                        do
                        {
                            Console.WriteLine("Введите что вы хотите найти (Тр - трамвай, Тс - троллейбус, А - автобус): ");
                            string select = Console.ReadLine();
                            Console.WriteLine();
                            if (select == "Тр" || select == "Тс" || select == "А")
                            {
                                if (select == "Тр")
                                {
                                    vidTransporta = Vid.Тр;
                                }
                                if (select == "Тс")
                                {
                                    vidTransporta = Vid.Тс;
                                }
                                if (select == "А")
                                {
                                    vidTransporta = Vid.А;
                                }
                                foreach (var item in tabl)
                                {
                                    if (item.vidTransporta == vidTransporta)
                                    {
                                        item.showTable();
                                    }
                                }
                                error = false;
                            }
                            else
                            {
                                Console.WriteLine("Введите П, С или А!");
                            }
                        }
                        while (error);
                        error = true;
                        Console.WriteLine();
                    }
                    else if (sektor == 6)
                    {
                        foreach (var item in logOfSession)
                        {
                            item.logOutput();
                        }
                        Console.WriteLine();
                        Console.WriteLine(downtime + " - Самый долгий период бездействия пользователя");
                        Console.WriteLine();
                    }
                    else if (sektor == 7)
                    {
                        working = false;
                    }
                    if (sektor < 1 || sektor > 7)
                    {
                        Console.WriteLine("Выберите действие от 1 до 7!");
                        Console.WriteLine();
                    }
                }
                while (working);
                {
                    Console.WriteLine();
                }
            }
            else if (choose == "2")
            {
                Console.Write("Использование коллекции .NET List\n");
                var logOfSession = new List<Log>(50);
                DateTime firstTime = DateTime.Now;
                DateTime secondTime = DateTime.Now;
                TimeSpan downtime = secondTime - firstTime;

                Worker Тр;
                Тр.vidTransporta = Vid.Тр;
                Тр.marhrut = "12";
                Тр.protiagennost = 27.55M;
                Тр.vremia = 75;

                Worker Тс;
                Тс.vidTransporta = Vid.Тс;
                Тс.marhrut = "17";
                Тс.protiagennost = 13.6M;
                Тс.vremia = 57;

                Worker А;
                А.vidTransporta = Vid.А;
                А.marhrut = "12а";
                А.protiagennost = 57.3M;
                А.vremia = 117;

                var tabl = new List<Worker>();
                tabl.Add(Тр);
                tabl.Add(Тс);
                tabl.Add(А);

                bool working = true;
                bool error = true;
                do
                {
                    Console.WriteLine("Выберите действие: ");
                    Console.WriteLine("1 - Просмотр таблицы.");
                    Console.WriteLine("2 - Добавить запись.");
                    Console.WriteLine("3 - Удалить запись.");
                    Console.WriteLine("4 - Обновить запись.");
                    Console.WriteLine("5 - Поиск записей.");
                    Console.WriteLine("6 - Просмотреть лог.");
                    Console.WriteLine("7 - Выход.");
                    int sektor = int.Parse(Console.ReadLine());
                    if (sektor == 1)
                    {
                        Console.WriteLine(new String('-', 88));
                        Console.WriteLine($"{"|Общественный транспорт",-87}|");
                        Console.WriteLine(new String('-', 88));
                        Console.WriteLine($"{"|Вид транспорта",-25}|{"№ Маршрута",-12}|{"Протяженность маршрута (км)",-20}|{"Время в дороге (мин)",-15}|");
                        Console.WriteLine(new String('-', 88));
                        for (int i = 0; i < tabl.Count; i++)
                        {
                            tabl[i].showTable();
                        }
                        Console.WriteLine($"{"|Перечисляемый тип: Тр - трамвай, Тс - троллейбус, А - автобус",-87}|");
                        Console.WriteLine(new String('-', 88));
                    }
                    if (sektor == 2)
                    {
                        Console.WriteLine("Введите данные: ");
                        var vidTransporta = Vid.А;
                        decimal protiagennost = 0;
                        int vremia = 0;
                        do
                        {
                            Console.WriteLine("Вид транспорта (Тр,Тс,А): ");
                            string tmp = Console.ReadLine();
                            if (tmp == "Tr" || tmp == "Тр")
                            {
                                vidTransporta = Vid.Тр;
                                break;
                            }
                            else if (tmp == "Tc" || tmp == "Тс")
                            {
                                vidTransporta = Vid.Тс;
                                break;
                            }
                            else if (tmp == "A" || tmp == "А")
                            {
                                vidTransporta = Vid.А;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод значения. Введите еще раз.");
                            }
                        }
                        while (error);
                        error = true;

                        Console.WriteLine("№ Маршрутa: ");
                        string marhrut = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Протяженность маршрута (км): ");
                            try
                            {
                                protiagennost = decimal.Parse(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                protiagennost = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                            catch (OverflowException)
                            {
                                protiagennost = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                        }
                        while (error);
                        error = true;

                        do
                        {
                            Console.WriteLine("Время в дороге (мин): ");
                            try
                            {
                                vremia = int.Parse(Console.ReadLine());
                                error = false;
                            }
                            catch (FormatException)
                            {
                                vremia = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                            catch (OverflowException)
                            {
                                vremia = 0;
                                Console.WriteLine("Введены неверные данные!");
                            }
                        }
                        while (error);
                        error = true;

                        Worker newWorker;
                        newWorker.vidTransporta = vidTransporta;
                        newWorker.marhrut = marhrut;
                        newWorker.protiagennost = protiagennost;
                        newWorker.vremia = vremia;
                        tabl.Add(newWorker);

                        Log newLog;
                        newLog.time = DateTime.Now;
                        newLog.operation = "Добавлена запись";
                        newLog.name = marhrut;
                        logOfSession.Add(newLog);

                        firstTime = newLog.time;

                        TimeSpan secondDowntime = firstTime - secondTime;
                        if (downtime < secondDowntime)
                        {
                            downtime = secondDowntime;
                        }
                        secondTime = newLog.time;
                        Console.WriteLine();
                    }
                    if (sektor == 3)
                    {
                        int number = 0;
                        string marhrut = string.Empty;
                        do
                        {
                            Console.WriteLine("Выберите номер строки для удаления: ");
                            number = int.Parse(Console.ReadLine());
                            if (number > 0 && number <= tabl.Count)
                            {
                                marhrut = tabl[number - 1].marhrut;
                                tabl.RemoveAt(number - 1);
                                error = false;
                            }
                            else
                            {
                                Console.WriteLine("Введите правильный номер!");
                            }
                        }
                        while (error);
                        error = true;

                        Log newLog;
                        newLog.time = DateTime.Now;
                        newLog.operation = "Запись удалена";
                        newLog.name = marhrut;
                        logOfSession.Add(newLog);

                        firstTime = newLog.time;
                        TimeSpan secondDowntime = firstTime - secondTime;
                        if (downtime < secondDowntime)
                        {
                            downtime = secondDowntime;
                        }
                        secondTime = newLog.time;
                        Console.WriteLine();
                    }
                    if (sektor == 4)
                    {
                        string oldSurname = string.Empty;
                        string marhrut = string.Empty;
                        var vidTransporta = Vid.А;
                        int vremia = 0;
                        decimal protiagennost = 0;
                        int number = 0;
                        do
                        {
                            Console.WriteLine("Выберите номер строки для обновления: ");
                            number = int.Parse(Console.ReadLine());
                            if (number > 0 && number <= tabl.Count)
                            {
                                oldSurname = tabl[number - 1].marhrut;

                                do
                                {
                                    Console.WriteLine("Вид транспорта (Тр,Тс,А): ");
                                    string tmp = Console.ReadLine();
                                    if (tmp == "Tr" || tmp == "Тр")
                                    {
                                        vidTransporta = Vid.Тр;
                                        break;
                                    }
                                    else if (tmp == "Tc" || tmp == "Тс")
                                    {
                                        vidTransporta = Vid.Тс;
                                        break;
                                    }
                                    else if (tmp == "A" || tmp == "А")
                                    {
                                        vidTransporta = Vid.А;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод значения. Введите еще раз.");
                                    }
                                }
                                while (error);
                                error = true;

                                Console.WriteLine("№ Маршрутa: ");
                                marhrut = Console.ReadLine();

                                do
                                {
                                    Console.WriteLine("Протяженность маршрута (км): ");
                                    try
                                    {
                                        protiagennost = decimal.Parse(Console.ReadLine());
                                        error = false;
                                    }
                                    catch (FormatException)
                                    {
                                        protiagennost = 0;
                                        Console.WriteLine("Введены неверные данные!");
                                    }
                                    catch (OverflowException)
                                    {
                                        protiagennost = 0;
                                        Console.WriteLine("Введены неверные данные!");
                                    }
                                }
                                while (error);
                                error = true;

                                do
                                {
                                    Console.WriteLine("Время в дороге (мин): ");
                                    try
                                    {
                                        vremia = int.Parse(Console.ReadLine());
                                        error = false;
                                    }
                                    catch (FormatException)
                                    {
                                        vremia = 0;
                                        Console.WriteLine("Введены неверные данные!");
                                    }
                                    catch (OverflowException)
                                    {
                                        vremia = 0;
                                        Console.WriteLine("Введены неверные данные!");
                                    }
                                }
                                while (error);
                                error = true;
                            }
                            else
                            {
                                Console.WriteLine("Введите правильный номер!");
                            }
                        }
                        while (error);
                        error = true;

                        Worker editWorker;
                        editWorker.vidTransporta = vidTransporta;
                        editWorker.marhrut = marhrut;
                        editWorker.protiagennost = protiagennost;
                        editWorker.vremia = vremia;
                        tabl.Insert(number - 1, editWorker);
                        tabl.Remove(tabl[number]);

                        Log newLog;
                        newLog.time = DateTime.Now;
                        newLog.operation = "Обновлена запись";
                        newLog.name = oldSurname + " --> " + marhrut;
                        logOfSession.Add(newLog);

                        firstTime = newLog.time;
                        TimeSpan secondDowntime = firstTime - secondTime;
                        if (downtime < secondDowntime)
                        {
                            downtime = secondDowntime;
                        }
                        secondTime = newLog.time;
                        Console.WriteLine();
                    }
                    if (sektor == 5)
                    {
                        var vidTransporta = Vid.А;
                        do
                        {
                            Console.WriteLine("Введите что вы хотите найти (Тр - трамвай, Тс - троллейбус, А - автобус): ");
                            string select = Console.ReadLine();
                            Console.WriteLine();
                            if (select == "Тр" || select == "Тс" || select == "А")
                            {
                                if (select == "Тр")
                                {
                                    vidTransporta = Vid.Тр;
                                }
                                if (select == "Тс")
                                {
                                    vidTransporta = Vid.Тс;
                                }
                                if (select == "А")
                                {
                                    vidTransporta = Vid.А;
                                }
                                for (int i = 0; i < tabl.Count; i++)
                                {
                                    if (tabl[i].vidTransporta == vidTransporta)
                                    {
                                        tabl[i].showTable();
                                    }
                                }
                                error = false;
                            }
                            else
                            {
                                Console.WriteLine("Введите П, С или А!");
                            }
                        }
                        while (error);
                        error = true;
                        Console.WriteLine();
                    }
                    if (sektor == 6)
                    {
                        for (int i = 0; i < logOfSession.Count; i++)
                        {
                            logOfSession[i].logOutput();
                        }
                        Console.WriteLine();
                        Console.WriteLine(downtime + " - Самый долгий период бездействия пользователя");
                        Console.WriteLine();
                    }
                    if (sektor == 7)
                    {
                        working = false;
                    }
                    if (sektor < 1 || sektor > 7)
                    {
                        Console.WriteLine("Выберите действие от 1 до 7!");
                        Console.WriteLine();
                    }
                }
                while (working);
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Выберите действие 1 или 2!");
                Console.WriteLine();
            }
        }
    }
}
