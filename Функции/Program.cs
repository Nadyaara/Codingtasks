using System;

namespace calculatorfunkcii
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n Введите первую переменную \n" +
                   "\n операцию( + , - , * , / , ^ ) \n " +
                    " \n вторую переменную \n");
                try
                {
                    Console.WriteLine(" \nРезультат: " + Calculate(Convert.ToDouble(Console.ReadLine()), Convert.ToChar(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Проверьте данные!!!");
                    Console.ReadLine();
                    continue;
                }
            }
        }
        static double Calculate(double a, char c, double b)
        {
            switch (c)
            {
                case '+':
                    return plus(a, b);

                case '-':
                    return minus(a, b);

                case '*':
                    return umn(a, b);

                case '/':
                    return del(a, b);

                case '^':
                    return step(a, b);
                default:
                    throw new FormatException();
            }
        }
        static double plus(double a, double b)
        {
            return a + b;
        }
        static double minus(double a, double b)
        {
            return a - b;
        }
        static double step(double a, double b)
        {
            if (a > 0 && b == Convert.ToInt32(b))
            {
               Console.WriteLine("Ошибка, попробуйте заново");
               return 0;
            }
            else
            {
                return Math.Pow(a, b);
            }
        }
        static double del(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль");
            }
            else
            {
                return a / b;
            }
        }
        static double umn(double a, double b)
        {
            return a * b;
        }

    }
}
