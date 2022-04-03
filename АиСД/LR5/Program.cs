using System;

namespace LR5
{
    /*Вывести на экран сообщение, каких чисел больше относительно 50, с помощью линейного поиска*/
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Массив чисел
            int[] array = {3, 4, 153, 42, 654, 12, 543, 87, 12, 43, 234, 76, 21, 67, 12, 45, 99};
            
            //граница
            int G = 50;
            
            //перебираем значения
            foreach (int i in array)
                if (i > G)
                    Console.Write(i);
        }
    }
}