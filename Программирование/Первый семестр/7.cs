//Лаболаторная работа 7

using System;
namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: \n");
            string s = Console.ReadLine();
            for (int k = s.Length; k < s.Length + 10; k++)
            {
                Console.Write($"Ваше предложение выравненное по левому краю + {k}: \n" + s.PadLeft(k) + "\n");
            }
        }
    }
}