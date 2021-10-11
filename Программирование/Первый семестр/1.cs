using System;
namespace Первая_программа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение ");
            double b = Convert.ToDouble(Console.ReadLine());
            double z2 = Math.Sqrt(2 * b);

            double z1 = Math.Sqrt(Math.Pow(Math.Pow(2*b+1, 3), (double)1/5) + 64*b)/(Math.Sqrt(5*b) + 3*Math.Sqrt(b)/2);

            Console.Write($"z1:{z1} z2:{z2}");
        }
    }
}
