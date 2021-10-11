//Лабораторная 3.1

using System;
namespace Первая_программа
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("+------------------------+\n");
            Console.Write("|       X    |   Y       |\n");
            Console.Write("+------------------------+\n");
            for (int k = -5; k < 6; k++)
            {
                string m = "";
                var Y = GetY(k);
                if ((k >= 0 && Y < 0) | (k < 0 && Y > 0)) { m = "    "; }
                else if (k < 0 && Y < 0) { m = "   "; }
                else { m = "     "; }
                if (k >= 0)
                {
                    if (Y >= 0) { m = "    "; }
                    else { m = "   "; }
                    Console.Write($"|    {k:F4}  | {Y:F4}" + m + "|\n", k, Y);
                }
                else
                {
                    Console.Write($"|    {k:F4} | {Y:F4}" + m + "|\n", k, Y);
                }
            }
            Console.Write("+------------------------+\n");
        }
        static double GetY(double X)
        {
            double y;
            if (X <= -3) { return 1; }
            else if (X > -1 && X <= 2) { return -2; }
            else if (X > 2) { return X - 4; }
            else if (X >= -3 && X <= -1) { return -Math.Sqrt(4 - Math.Pow(X + 1, 2)); }
            else { return 1; }
        }
    }
}