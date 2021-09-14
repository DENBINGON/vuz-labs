//Лабораторная 2.1

//using System;
//namespace Первая_программа
//{
//    class Program1
//    {
//        static void Main1(string[] args)
//        {
//            double y;
//            double X = Convert.ToDouble(Console.ReadLine());
//            if (X <= -3) { Console.Write(1); }
//            else if (X > -1 && X <= 2) { Console.Write(-2); }
//            else if (X > 2) { Console.Write(X - 4); }
//            else if (X >= -3 && X <= -1) { Console.Write(-Math.Sqrt(4 - Math.Pow(X + 1, 2))); }
//        }


//    }
//}

//Лабораторная 2.2

//using System;
//namespace Первая_программа
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            const int Rad = 10;
//                 while (true) {
//                Console.Write("Instert Y: \n");
//                double y = Convert.ToDouble(Console.ReadLine());
//                Console.Write("Instert X: \n");
//                double x = Convert.ToDouble(Console.ReadLine());
//                if (x == 0 && y == 0) { Console.Write("True\n"); }
//                else if ( x > 0 && x <= Rad) {
//                    if (y == 0 ) { Console.Write("True\n"); }
//                    else if ( y < 0 )
//                    {
//                        double Y = -Math.Sqrt(Rad * Rad - Math.Pow(x - Rad, 2));
//                        if ( y >= Y) { Console.Write("True\n"); }
//                        else { Console.Write("False\n"); }
//                    }
//                    else if (y > 0) { Console.Write("False\n"); }
//                }
//                else if ( x < 0 && x >= -Rad) {

//                    if (y == 0) { Console.Write("True\n"); }
//                    else if (y > 0)
//                    {
//                        double Y = Math.Sqrt(Rad * Rad - Math.Pow(x + Rad, 2));
//                        if (y <= Y) { Console.Write("True\n"); }
//                        else { Console.Write("False\n"); }
//                    }
//                    else if (y < 0) { Console.Write("False\n"); }
//                }
//                else { Console.Write("False\n"); }
//            }
//        }
//    }
//}


//Лабораторная 3.1

//using System;
//namespace Первая_программа
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("+------------------------+\n");
//            Console.Write("|       X    |   Y       |\n");
//            Console.Write("+------------------------+\n");
//            for (int k = -5; k < 6; k++ )
//            {
//                string m = "";
//                var Y = GetY(k);
//                if ((k >= 0 && Y < 0) | (k < 0 && Y > 0)) { m = "    "; }
//                else if (k < 0 && Y < 0) { m = "   "; }
//                else { m = "     "; }
//                    if (k >= 0)
//                    {
//                        if (Y>=0) { m = "    "; }
//                        else { m = "   "; }
//                        Console.Write($"|    {k:F4}  | {Y:F4}" + m  + "|\n", k, Y);
//                    }
//                    else
//                {
//                    Console.Write($"|    {k:F4} | {Y:F4}" + m + "|\n", k, Y);
//                }
//            }
//            Console.Write("+------------------------+\n");
//        }
//        static double GetY( double X)
//        {
//            double y;
//            if (X <= -3) { return 1; }
//            else if (X > -1 && X <= 2) { return -2; }
//            else if (X > 2) { return X - 4; }
//            else if (X >= -3 && X <= -1) { return -Math.Sqrt(4 - Math.Pow(X + 1, 2)); }
//            else { return 1; }
//        }
//    }
//}

//Лабораторная работа 3.2

//using System;
//namespace Первая_программа
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            double[] X = new double[10];
//            double[] Y = new double[10];
//            for (int i = 0; i<10; i++) {
//                Console.Write("Instert X"+(i+1)+": \n");
//                X[i] = Convert.ToDouble(Console.ReadLine());

//                Console.Write("Instert Y" + (i + 1) + ": \n");
//                Y[i] = Convert.ToDouble(Console.ReadLine());

//            }
//            Console.Write("+---------------------+\n");
//            Console.Write("|  X  |  Y  |   ok?   |\n");
//            Console.Write("+---------------------+\n");

//            for (int i = 0; i<10; i++) {
//                string T = getTrust(X[i], Y[i]);
//                Console.Write($"|  {X[i]}     {Y[i]}     {T}");
//            }
//            Console.Write("+---------------------+");

//        }



//        static string getTrust(double x, double y) { 
//            const int Rad = 10;
//            while (true)
//            {
//                if (x == 0 && y == 0) { return "True\n"; }
//                else if (x > 0 && x <= Rad)
//                {
//                    if (y == 0) { return "True\n"; }
//                    else if (y < 0)
//                    {
//                        double Y = -Math.Sqrt(Rad * Rad - Math.Pow(x - Rad, 2));
//                        if (y >= Y) { return "True\n"; }
//                        else { return "False\n"; }
//                    }
//                    else if (y > 0) { return "False\n"; }
//                }
//                else if (x < 0 && x >= -Rad)
//                {

//                    if (y == 0) { return "True\n"; }
//                    else if (y > 0)
//                    {
//                        double Y = Math.Sqrt(Rad * Rad - Math.Pow(x + Rad, 2));
//                        if (y <= Y) { return "True\n"; }
//                        else { return "False\n"; }
//                    }
//                    else if (y < 0) { return "False\n"; }
//                }
//                else { return "False\n"; }
//            }
//        }
//    }
//}

//Лабораторная работа 3.3

//using System;

//namespace labWork3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //настроечки sh - шаг Pog - погрешность
//            const double sh = 0.5;
//            const double Pog = 0.0001;

//            double XStart = 0.0;
//            double XEnd = 0;
//            int i = 0;

//            while (XStart <= 0.5 | XStart >= XEnd)
//            {
//                if (i > 0) { Console.Write("Что-то не то... Введите Х.нач > 0.5  и X.кон > и != X.нач\n"); }
//                Console.Write("Введите начальное значение x: ");
//                XStart = Convert.ToDouble(Console.ReadLine());
//                Console.Write("Введите конечное значение x: ");
//                XEnd = Convert.ToDouble(Console.ReadLine());
//                Console.Clear();
//                i++;

//            }
//            Console.Write("+-----+--------+--------+-------+\n");
//            Console.Write("|  X  |  З.L   |  З.F   | count |\n");
//            Console.Write("+-----+--------+--------+-------+\n");

//            while (XStart <= XEnd)
//            {
//                double ln = Math.Log(XStart);
//                var tt = lnx(XStart, Pog);
//                Console.Write(String.Format("|{0,5}|{1,5:F6}|{2,5:F6}|{3,5}  |\n", XStart, ln, tt.X, tt.con));
//                Console.Write("+-----+--------+--------+-------+\n");

//                //Console.Write($"|  {XStart}     {ln:F5}     {tt.X:F5}     {tt.con}   \n");
//                XStart += sh;

//            }


//        }

//        public static Type lnx(double x, double P)
//        {
//            Type type = new Type();

//            double X = 0;
//            int i = 0;
//            double lnc = Math.Log(x);


//            while (lnc - X > P)
//            {
//                i++;

//                X = X + Convert.ToDouble(Math.Pow(x - 1, i) / (i * Math.Pow(x, i)));

//            }
//            type.X = X;
//            type.con = i;

//            return type;
//        }
//    }
//    class Type
//    {
//        public double X { get; set; }
//        public int con { get; set; }

//        public Type()
//        {
//        }
//    }
//}