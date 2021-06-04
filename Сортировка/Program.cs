using System;

namespace Сортировка
{
    class Program
    {
        static public string Comand;
        static void Main(string[] args)
        {
            int usl;
            double[] arr = new double[8];
            bool arrayEntered = false;
            while (true)
            {
                {
                    Console.WriteLine("1 Заполнить данные ИЛИ заново заполнить массив");
                    Console.WriteLine("2 Полная сортировка пузырьком");
                    Console.WriteLine("3 Альтернативная сортировка пузырьком");
                    Console.WriteLine("4 Закрыть");
                    Comand = Console.ReadLine();
                    switch (Comand)
                    {
                        case "1":
                            try
                            {
                                Console.WriteLine("Введите чисела");
                                for (int i = 0; i < arr.Length; i++)
                                {
                                    Console.Write("{0}-е число: ", i + 1);
                                    arr[i] = double.Parse(Console.ReadLine());
                                }
                                arrayEntered = true;
                            }
                            catch
                            {
                              Console.WriteLine("Ошибка, повторите");
                                arrayEntered = false;
                            }

                            break;

                        case "2": 
                            if (arrayEntered)
                            {
                                    Console.WriteLine("Выберите направление сортировки");
                                    Console.WriteLine("1 Сортировка по возрастанию");
                                    Console.WriteLine("2 Сортировка по убыванию");
                                    Console.WriteLine();
                                    usl = int.Parse(Console.ReadLine());

                                    if (usl == 1)
                                    {
                                        double b;
                                        for (int i = 0; i < arr.Length - 1; i++)
                                        {
                                            for (int j = i + 1; j < arr.Length; j++)
                                            {
                                                if (arr[i] > arr[j])
                                                {
                                                    b = arr[i];
                                                    arr[i] = arr[j];
                                                    arr[j] = b;
                                                }
                                            }
                                        }
                                        Console.WriteLine("Отсортированный массив");

                                        {
                                            Console.WriteLine("[{0}]", string.Join(", ", arr));
                                        }
                                        Console.ReadLine();
                                    }
                                    else if (usl == 2)
                                    {
                                        double t;
                                        for (int i = 0; i < arr.Length - 1; i++)
                                        {
                                            for (int j = i + 1; j < arr.Length; j++)
                                            {
                                                if (arr[i] < arr[j])
                                                {
                                                    t = arr[i];
                                                    arr[i] = arr[j];
                                                    arr[j] = t;
                                                }
                                            }
                                        }
                                        Console.WriteLine("Отсортированный массив");

                                        {
                                            Console.WriteLine("[{0}]", string.Join(", ", arr));
                                        }
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка, повторите");
                                    }
                                
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, повторите");
                            }
                            break;

                        case "3":
                            if (arrayEntered)
                            {
                                double z;

                                for (int i = 0; i < 4; i++)
                                {
                                    for (int j = i + 1; j < 4; j++)
                                    {
                                        if (arr[i] > arr[j])
                                        {
                                            z = arr[i];
                                            arr[i] = arr[j];
                                            arr[j] = z;
                                        }
                                    }
                                }

                                double u;

                                for (int i = 4; i < 8; i++)
                                {

                                    for (int j = i + 1; j < 8; j++)
                                    {
                                        if (arr[i] < arr[j])
                                        {
                                            u = arr[i];
                                            arr[i] = arr[j];
                                            arr[j] = u;
                                        }
                                    }
                                }

                                {
                                    double[] zaz = new double[8];
                                    Array.Copy(arr, 0, zaz, 0, 8);
                                    Console.WriteLine("Отсортированный массив");

                                    {
                                        Console.WriteLine("[{0}]", string.Join(", ", zaz));
                                    }
                                }
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, повторите");
                            }
                            break;


                        case "4":
                            {
                                Environment.Exit(0);
                            }
                            break;
                    }

                }

            }
        }
    }
}
