//Лабораторная 2.2

using System;
namespace Первая_программа
{
    class Program1
    {
        static void Main(string[] args)
        {
            const int Rad = 10;
            while (true)
            {
                Console.Write("Instert Y: \n");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Instert X: \n");
                double x = Convert.ToDouble(Console.ReadLine());
                if (x == 0 && y == 0) { Console.Write("True\n"); }
                else if (x > 0 && x <= Rad)
                {
                    if (y == 0) { Console.Write("True\n"); }
                    else if (y < 0)
                    {
                        double Y = -Math.Sqrt(Rad * Rad - Math.Pow(x - Rad, 2));
                        if (y >= Y) { Console.Write("True\n"); }
                        else { Console.Write("False\n"); }
                    }
                    else if (y > 0) { Console.Write("False\n"); }
                }
                else if (x < 0 && x >= -Rad)
                {

                    if (y == 0) { Console.Write("True\n"); }
                    else if (y > 0)
                    {
                        double Y = Math.Sqrt(Rad * Rad - Math.Pow(x + Rad, 2));
                        if (y <= Y) { Console.Write("True\n"); }
                        else { Console.Write("False\n"); }
                    }
                    else if (y < 0) { Console.Write("False\n"); }
                }
                else { Console.Write("False\n"); }
            }
        }
    }
}