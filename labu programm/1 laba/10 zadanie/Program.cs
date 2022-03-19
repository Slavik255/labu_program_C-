using System;
using System.Collections;

namespace _10_zadanie
{
    public enum Vid
    {
         Тр,
         Тс,
         А
    }
    public class Tabl
    {
        public Vid vidTransporta;
        public String marhrut;
        public double protiagennost;
        public double vremia;
        public Tabl(Vid vidTransporta, string marhrut, double protiagennost, double vremia)
        {
            this.vidTransporta = vidTransporta;
            this.marhrut = marhrut;
            this.protiagennost = protiagennost;
            this.vremia = vremia;
        }
        public void Print()
        {
             Console.WriteLine($"|{this.vidTransporta,-24}|{this.marhrut,-12}|{this.protiagennost,-27}|{this.vremia,-20}|");
        }
    }
    public class Lab1_10
    {
        private static void Main()
        {
            ArrayList List = new();
            bool start = true;
            while (start)
            {
                Console.WriteLine("Введите данные: ");
                Vid vidTransporta;
                while (true)
                {
                    Console.WriteLine("Вид транспорта (Тр,Т-с,А): ");
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
                Console.WriteLine("№ Маршрут: ");
                string marhrut = Console.ReadLine();
                Console.WriteLine("Протяженность маршрута (км): ");
                double protiagennost = double.Parse(Console.ReadLine());
                Console.WriteLine("Время в дороге (мин): ");
                double vremia = double.Parse(Console.ReadLine());
                Tabl value = new(vidTransporta, marhrut, protiagennost, vremia);
                List.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить элементы в таблицу?\nда - продолжить\nнет - вывод таблицы");
                    string vvod = Console.ReadLine();
                    if (vvod == "да" || vvod == "нет")
                    {
                        if (vvod == "нет")
                        {
                            start = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода!Попробуйте еще раз!");
                        }
                    }
                }
            }
            Console.WriteLine(new String('-', 88));
            Console.WriteLine($"{"|Общественный транспорт",-87}|");
            Console.WriteLine(new String('-', 88));
            Console.WriteLine($"{"|Вид транспорта",-25}|{"№ Маршрута",-12}|{"Протяженность маршрута (км)",-20}|{"Время в дороге (мин)",-15}|");
            Console.WriteLine(new String('-', 88));
            foreach (Tabl item in List)
            {
                item.Print();
                Console.WriteLine(new String('-', 88));
            }
            Console.WriteLine($"{"|Перечисляемый тип: Тр - трамвай, Тс - троллейбус, А - автобус",-87}|");
            Console.WriteLine(new String('-', 88));
        }
    }
 
}
