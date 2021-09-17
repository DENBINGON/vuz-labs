//Лабораторная работа 6

using System;
namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeUr ur = new TypeUr();
            Console.WriteLine("Значение а: ");
            ur.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значение b: ");
            ur.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значение с: ");
            ur.c = Convert.ToDouble(Console.ReadLine());
            ur = resh(ur);
            if (ur.D < 0) { Console.WriteLine(ur.Q); }
            else if (ur.D == 0) { Console.WriteLine("D = 0, x = " + $"{ur.x1:F6}"); }
            else if (ur.D > 0) { Console.WriteLine($"x.1 = {ur.x1:F6}\nx.2 = {ur.x2:F6}"); }
        }
        public static TypeUr resh( TypeUr L)
        {
            L.D = L.b * L.b - 4 * L.a * L.c;
            if (L.D > 0)
            {
                L.x1 = (-L.b + Math.Sqrt(L.D)) / 2 * L.a;
                L.x2 = (-L.b - Math.Sqrt(L.D)) / 2 * L.a;
            }
            else if (L.D == 0)
            {
                L.x1 = -L.b / 2 * L.a;
            }
            else if (L.D < 0)
            {
                L.Q = "Заданное уравнение не имеет корней";
            }
            return L;
        } 
    }
    class TypeUr
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double D { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public string Q { get; set; }
        public TypeUr() { }
    }
}