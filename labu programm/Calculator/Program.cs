using System;
// Калькулятор на С#
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;

                Console.WriteLine("Приветствую в калькуляторе от студента дизайнера");

                try
                {
                    Console.WriteLine("Введите пожалуйста первое число: ");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите пожалуйста второе число число: ");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Что бы вы хотели сделать в клаькуляторе? '+' '-' '*' '/' '%'");
                string v = Console.ReadLine();

                switch (v)
                {
                    case "+":
                        double result1 = a + b;
                        Console.WriteLine("Ваш результат: " + result1);
                        break;
                    case "-":
                        double result2 = a - b;
                        Console.WriteLine("Ваш результат: " + result2);
                        break;
                    case "*":
                        double result3 = a * b;
                        Console.WriteLine("Ваш результат: " + result3);
                        break;
                    case "/":
                        double result4 = a / b;
                        if (result4 == 0)
                        {
                            Console.WriteLine("Ваш результат: 0");
                        }
                        else
                        {
                            Console.WriteLine("Ваш результат: " + result4);
                        }
                        break;
                    case "%":
                        double result5 = a % b;
                        Console.WriteLine("Ваш результат: " + result5);
                        break;
                    default:
                        Console.WriteLine("Вы ввели неизвестное действие " + v + ".Я не знаю, что с этим делать");
                        Console.ReadLine();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
