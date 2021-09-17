//Лабораторная 2.1

using System;
namespace Первая_программа
{
    class Program1
    {
        static void Main1(string[] args)
        {
            double y;
            double X = Convert.ToDouble(Console.ReadLine());
            if (X <= -3) { Console.Write(1); }
            else if (X > -1 && X <= 2) { Console.Write(-2); }
            else if (X > 2) { Console.Write(X - 4); }
            else if (X >= -3 && X <= -1) { Console.Write(-Math.Sqrt(4 - Math.Pow(X + 1, 2))); }
            double xx = Convert.ToDouble(Console.ReadLine());
        }


    }
}