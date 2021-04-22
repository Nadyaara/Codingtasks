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
                double d, k;
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

                d = nod(a, b);
                k = nok(a, b);

                 
                Console.WriteLine("НОД={0}", nod(d, c));
                Console.WriteLine("НОК={0}", nok(k, c));
                Console.ReadKey();
            }

        }

        static double nod(double x, double y)
        {
            if (y < 0)
                y = -y;
            if (x < 0)
                x = -x;
            while (y > 0)
            {
                double temp = y;
                y = x % y;
                x = temp;
            }
            return x;      
         }
         static double nok(double a, double b)
         {
                return Math.Abs(a*b)/nod(a, b);
         }         
     
    }
    
}
 
 