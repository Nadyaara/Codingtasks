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

                Console.WriteLine("Введите вторую переменную: ");
                b = double.Parse(Console.ReadLine());
             }
             catch(Exception)
             {
                Console.WriteLine("Нет такого числа. Выберите другое ");
                Console.ReadLine();
                continue;
             }

             Console.WriteLine("Выбирите действие: 1) сложение 2)выситание 3) умножение 4) деление ");
             c = Console.ReadLine();

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

                    default:
                        Console.WriteLine("Попробуйте еще раз.");
                        break;

                }

                Console.ReadLine();
            }

            
        }    
    }
}
