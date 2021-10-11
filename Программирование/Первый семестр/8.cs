//Лаболаторная работа 8

using System;
using System.IO;
namespace Первая_программа
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("../../../input.txt");
            double b = Convert.ToDouble(f.ReadLine());
            f.Close();
            double z2 = Math.Sqrt(2 * b);

            double z1 = Math.Sqrt(Math.Pow(Math.Pow(2 * b + 1, 3), (double)1 / 5) + 64 * b) / (Math.Sqrt(5 * b) + 3 * Math.Sqrt(b) / 2);

            StreamWriter w = new StreamWriter("../../../output.txt");
            w.Write($"z1:{z1}\nz2:{z2}");
            w.Close();
        }
    }
}