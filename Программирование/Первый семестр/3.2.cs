//Лабораторная работа 3.2

using System;
namespace Первая_программа
{
    class Program1
    {
        static void Main(string[] args)
        {
            double[] X = new double[10];
            double[] Y = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Instert X" + (i + 1) + ": \n");
                X[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Instert Y" + (i + 1) + ": \n");
                Y[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("+---------------------+\n");
            Console.Write("|  X  |  Y  |   ok?   |\n");
            Console.Write("+---------------------+\n");
            for (int i = 0; i < 10; i++)
            {
                string T = getTrust(X[i], Y[i]);
                Console.Write($"|  {X[i]}     {Y[i]}     {T}");
            }
            Console.Write("+---------------------+");
        }
        static string getTrust(double x, double y)
        {
            const int Rad = 10;
            while (true)
            {
                if (x == 0 && y == 0) { return "True\n"; }
                else if (x > 0 && x <= Rad)
                {
                    if (y == 0) { return "True\n"; }
                    else if (y < 0)
                    {
                        double Y = -Math.Sqrt(Rad * Rad - Math.Pow(x - Rad, 2));
                        if (y >= Y) { return "True\n"; }
                        else { return "False\n"; }
                    }
                    else if (y > 0) { return "False\n"; }
                }
                else if (x < 0 && x >= -Rad)
                {
                    if (y == 0) { return "True\n"; }
                    else if (y > 0)
                    {
                        double Y = Math.Sqrt(Rad * Rad - Math.Pow(x + Rad, 2));
                        if (y <= Y) { return "True\n"; }
                        else { return "False\n"; }
                    }
                    else if (y < 0) { return "False\n"; }
                }
                else { return "False\n"; }
            }
        }
    }
}