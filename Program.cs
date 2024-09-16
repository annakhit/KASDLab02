using System;

namespace KASDLab02
{
    internal class Program
    {
        static void Main()
        {
            Complex first = new Complex(0, 0);
            Complex result;
            while (true)
            {
                PrintMenuInfo();
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        Console.WriteLine("Введите вещественную часть:");
                        double real = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите мнимую часть:");
                        double imaginary = Convert.ToDouble(Console.ReadLine());
                        first = new Complex(real, imaginary);
                        first.Print();
                        break;
                    case "2":
                        result = first + InitSecondNumber();
                        Console.Write($"Сумма=");
                        result.Print();
                        break;
                    case "3":
                        result = first - InitSecondNumber();
                        Console.Write($"Разность=");
                        result.Print();
                        break;
                    case "4":
                        result = first * InitSecondNumber();
                        Console.Write($"Умножение=");
                        result.Print();
                        break;
                    case "5":
                        result = first / InitSecondNumber();
                        Console.Write($"Деление=");
                        result.Print();
                        break;
                    case "6":
                        Console.WriteLine($"Модуль={first.Abs()}");
                        break;
                    case "7":
                        Console.WriteLine($"Аргумент числа={first.Arg()}");
                        break;
                    case "8":
                        Console.WriteLine($"Мнимая часть={first.Im()}");
                        break;
                    case "9":
                        Console.WriteLine($"Вещественная часть={first.Re()}");
                        break;
                    case "10":
                        first.Print();
                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("неизвестная команда");
                        break;
                }
            }
        }

        static void PrintMenuInfo()
        {
            Console.WriteLine("Выберите нужную команду:");
            Console.WriteLine("создание комплексного числа по мнимой и вещ. частям - 1");
            Console.WriteLine("нахождентие суммы чисел - 2");
            Console.WriteLine("нахождение разности чисел - 3");
            Console.WriteLine("нахождение умножения чисел - 4");
            Console.WriteLine("нахождение деления чисел - 5");
            Console.WriteLine("нахождение модуля числа - 6");
            Console.WriteLine("нахождение аргумента числа - 7");
            Console.WriteLine("возврат мнимой части - 8");
            Console.WriteLine("возврат вещественной части - 9");
            Console.WriteLine("вывод числа - 10");
            Console.WriteLine("выход - Q или q");
        }

        static Complex InitSecondNumber()
        {
            Console.WriteLine("Введите 2е комплексное число: ");
            Console.WriteLine("Введите вещественную часть:");
            double real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть:");
            double imaginary = Convert.ToDouble(Console.ReadLine());
            return new Complex(real, imaginary);
        }
    }
}
