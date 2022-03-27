//using System;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double[] argnumbers = new double[3];
//            int count = 0;
//            Console.WriteLine("Work with args directly:");
//            foreach (string arg in args)
//            {
//                Console.WriteLine(arg);
//                argnumbers[count] = Convert.ToDouble(arg);
//                count++;
//            }
//            Console.ReadKey();

//            Console.WriteLine($"{argnumbers[0]}, {argnumbers[1]}, {argnumbers[2]}");


//        }
//    }
//}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вступление
            Console.WriteLine("Финк Даниэль Дмитриевич ИУ5-35Б");
            Console.WriteLine("Решаем биквадратное уравнение");

            // Проверка на наличие заданных параметров
            double[] argnumbers = new double[3];
            int count = 0;

            
            Console.WriteLine("Work with args directly:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
                
                if (double.TryParse(arg, out argnumbers[count]))
                {
                    argnumbers[count] = Convert.ToDouble(arg);
                    count++;
                }
                else
                {
                    Console.WriteLine("Коэффициенты в аргументах командной строки неверны, завершаю работу.");
                    count++;
                    break;
                }
                if (count == 3) break;
            }
            Console.WriteLine("Work done");
            

            double A = argnumbers[0];
            double B = argnumbers[1];
            double C = argnumbers[2];

            if (count == 0) // Если нет коэф, ввод с клавы
            {
                A = 0;

                while (A == 0)
                {
                    bool CheckA = true;
                    while (CheckA)
                    {
                        Console.Write("Введите коэффициент А: ");
                        string lineA = Console.ReadLine();
                        bool result = double.TryParse(lineA, out A);
                        if (!result)
                        {
                            Console.WriteLine("   Коэффициент А введен неверно.");
                        }
                        else
                        {
                            A = Convert.ToDouble(lineA);
                            CheckA = false;
                        }
                    }
                    if (A == 0)
                    {
                        Console.WriteLine("Коэффициент А не может быть равен нулю.");
                    }
                }

                
                bool CheckB = true;
                while (CheckB)
                {
                    Console.Write("Введите коэффициент В: ");
                    string lineB = Console.ReadLine();
                    bool result = double.TryParse(lineB, out B);
                    if (!result)
                    {
                        Console.WriteLine("   Коэффициент А введен неверно.");
                    }
                    else
                    {
                        A = Convert.ToDouble(lineB);
                        CheckB = false;
                    }
                }


                bool CheckC = true;
                while (CheckC)
                {
                    Console.Write("Введите коэффициент C: ");
                    string lineC = Console.ReadLine();
                    bool result = double.TryParse(lineC, out C);
                    if (!result)
                    {
                        Console.WriteLine("   Коэффициент А введен неверно.");
                    }
                    else
                    {
                        A = Convert.ToDouble(lineC);
                        CheckC = false;
                    }
                }
            }

            if (A!=0 && B==0 && C == 0)
            {
                Console.WriteLine("У уравнения 4 корня, они равны 0");
            }
            else if (A != 0)
            {
                if ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C) >= 0 && ((-B + (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A) >= 0))
                {
                    double x1 = Math.Sqrt(((-B + (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"X1 = {x1}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корня Х1 не существует");
                }


                if ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C) >= 0 && ((-B - (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A) >= 0))
                {
                    double x2 = Math.Sqrt(((-B - (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"X2 = {x2}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корня Х2 не существует");
                }


                if ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C) >= 0 && ((-B + (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A) >= 0))
                {
                    double x3 = -Math.Sqrt(((-B + (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"X3 = {x3}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корня Х3 не существует");
                }


                if ((Math.Sqrt(Math.Pow(B, 2) - 4 * A * C) >= 0 && ((-B - (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A) >= 0))
                {
                    double x4 = -Math.Sqrt(((-B - (Math.Sqrt(Math.Pow(B, 2) - 4 * A * C)))) / (2 * A));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"X4 = {x4}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корня Х4 не существует");
                }
                Console.ResetColor();
            }
        }
    }
}
