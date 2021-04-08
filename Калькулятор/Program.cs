using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true)
           {
            double a, b;
            string c;
                try
             {
                Console.WriteLine("Введите первую переменную: ");
                a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Выбирите действие: 1) сложение 2)выситание 3) умножение 4) деление 5) Возведение в квадрат");
                    c = Console.ReadLine();
                    b = 0;
                    if (c != "5")
                    {
                        Console.WriteLine("Введите вторую переменную: ");
                        b = double.Parse(Console.ReadLine());
                    }

             }
             catch(Exception)
             {
                Console.WriteLine("Нет такого числа. Выберите другое ");
                Console.ReadLine();
                continue;
             }

                switch (c)
                {
                    case "1":
                        Console.WriteLine( a + b);
                        break;

                    case "2":
                        Console.WriteLine(a - b);
                        break;

                    case "3":
                        Console.WriteLine(a * b);
                        break;

                    case "4":
                        if (b == 0)
                            Console.WriteLine("На 0 делить нельзя");
                        else
                            Console.WriteLine(a / b);
                        break;
                    case "5":
                        Console.WriteLine(a * a);
                        break;
                    default:
                        Console.WriteLine("Попробуйте еще раз.");
                        break;

                }

                Console.ReadLine();
                a = 0;
                b = 0;
                c = "";
            }

            
        }    
    }
}
