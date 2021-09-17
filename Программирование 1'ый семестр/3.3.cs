//Лабораторная работа 3.3

using System;

namespace labWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //настроечки sh - шаг Pog - погрешность
            const double sh = 0.5;
            const double Pog = 0.0000001;


            double XStart = 0.0;
            double XEnd = 0;
            int i = 0;
            while (XStart <= 0.5 | XStart >= XEnd)
            {
                if (i > 0) { Console.Write("Что-то не то... Введите Х.нач > 0.5  и X.кон > и != X.нач\n"); }
                Console.Write("Введите начальное значение x: ");
                XStart = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите конечное значение x: ");
                XEnd = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                i++;
            }
            Console.Write("+-----+--------+--------+-------+\n");
            Console.Write("|  X  |  З.L   |  З.F   | count |\n");
            Console.Write("+-----+--------+--------+-------+\n");
            while (XStart <= XEnd)
            {
                double ln = Math.Log(XStart);
                var tt = lnx(XStart, Pog);
                Console.Write(String.Format("|{0,5}|{1,5:F6}|{2,5:F6}|{3,5}  |\n", XStart, ln, tt.X, tt.con));
                Console.Write("+-----+--------+--------+-------+\n");
                //Console.Write($"|  {XStart}     {ln:F5}     {tt.X:F5}     {tt.con}   \n");
                XStart += sh;
            }
        }
        public static Type lnx(double x, double P)
        {
            Type type = new Type();
            double X = 0;
            int i = 0;
            double lnc = Math.Log(x);
            while (lnc - X > P)
            {
                i++;
                X = X + Convert.ToDouble(Math.Pow(x - 1, i) / (i * Math.Pow(x, i)));
            }
            type.X = X;
            type.con = i;
            return type;
        }
    }
    class Type
    {
        public double X { get; set; }
        public int con { get; set; }
        public Type()
        {
        }
    }
}