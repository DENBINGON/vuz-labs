//Курсовая работа ln(x)

using System;
namespace courseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctInput = true;
            bool correctCheck = false;
            InsertData data = null;
            while (correctInput)
            {
                Print.meetMessage();
                if (correctCheck) Print.printIncorrectInput();
                try
                {
                    data = new InsertData();
                    if (data.primary > 0.5 && data.primary <= data.ending && data.step > 0 && data.infelicity > 0) correctInput = false;
                }
                catch { }
                correctCheck = true;
                Print.displayClear();
            }
            Print.printInsertData(data);
            Print.printHeader();
            double coordinate = data.primary;
            while (coordinate <= data.ending)
            {
                double systemNaturalLog = Math.Log(coordinate);
                RoundData row_Con = InteriorMath.natureLog(coordinate, data, systemNaturalLog);
                Print.printResult(coordinate, systemNaturalLog, row_Con);
                coordinate += data.step;
            }
        }
    }
    class InteriorMath
    {
        public static RoundData natureLog(double x, InsertData p, double lnx)
        {
            RoundData data = new RoundData();
            double X = 0;
            int i = 0;
          
            if (x >= 1)
            {
                while (lnx - X > p.infelicity)
                {
                    i++;
                    X += Convert.ToDouble(binaryPower(x - 1, Convert.ToUInt64(i)) / (i * binaryPower(x, Convert.ToUInt64(i))));
                }
            }
            else
            {
                while (Math.Abs(lnx + Math.Abs(X)) > p.infelicity)
                {
                    i++;
                    X += Convert.ToDouble(binaryPower(x - 1, Convert.ToUInt64(i)) / (i * binaryPower(x, Convert.ToUInt64(i))));
                }
            }
            data.logarithmRow = X;
            data.counter = i;
            return data;
        }
        static double binaryPower(double number, UInt64 power)
        {
            double cout = 1;
            while (power != 0)
            {
                if ((power & 1) != 0)
                {
                    cout *= number;
                }
                number *= number;
                power >>= 1;
            }
            
            return cout;
        }
    }
    class Print
    {
        private const string tableLine = "+----------+----------+----------+----------+";
        private const string tableHeaderSign = "\n|     X    |    З.L   |    З.F   |   count  |\n";
        public static void meetMessage() => Console.WriteLine("Вычисление натурального логарифма методом рядов Тейлора\n" +
                                                              "Для продолжения введите следующие 4 числа: \n" +
                                                              "1. Начальное значение (x>0.5)\n" +
                                                              "2. Конечное значение (начальное<=конечное)\n" +
                                                              "3. Шаг (>0)\n" +
                                                              "4. Погрешность (>0)");
        public static void displayClear() => Console.Clear();
        public static void printIncorrectInput() => Console.WriteLine("\nОдно из значений введено неверно...\n");
        public static void printHeader() => Console.WriteLine(tableLine + tableHeaderSign + tableLine);
        public static void printInsertData(InsertData data) => Console.WriteLine($"Начальное значение -> {data.primary}\nКонечное значение -> {data.ending}\nШаг -> {data.step}\nПогрешность -> {data.infelicity}\n");
        public static void printResult(double coordinate, double mathLogarithm, RoundData roundData)
        {
            Console.WriteLine("|{0,10:F2}|{1,10:F6}|{2,10:F6}|{3,10}|\n" + tableLine, coordinate, mathLogarithm, roundData.logarithmRow, roundData.counter);
        }
    }
    class InsertData
    {
        public double primary = Convert.ToDouble(Console.ReadLine());
        public double ending = Convert.ToDouble(Console.ReadLine());
        public double step = Convert.ToDouble(Console.ReadLine());
        public double infelicity = Convert.ToDouble(Console.ReadLine());
        public InsertData() { }
    }
    class RoundData
    {
        public double logarithmRow { get; set; }
        public int counter { get; set; }
        public RoundData() { }
    }
}