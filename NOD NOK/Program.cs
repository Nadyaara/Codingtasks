using System;

namespace NOD_NOK
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int a, b, c;
                try
                {
                    Console.Write("Введите первое число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    c = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Нет такого числа. Выберите другое ");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("НОД={0}", nod(a, b, c));
                Console.WriteLine("НОК={0}", nok(a, b, c));
                Console.ReadKey();
            }
        }

        static double nod(double a, double b, double c)
        {
            if (b < 0)
                b = -b;
            if (a < 0)
                a = -a;
            if (c < 0)
                c = -c;
            while (b > 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
         }
         static double nok(double a, double b, double c)
         {
                return Math.Abs(a*b*c)/nod(a, b, c);
         }         
     
    }
    
}
 
 