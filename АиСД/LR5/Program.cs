using System;

namespace LR5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {3, 4, 153, 42, 654, 12, 543, 87, 12, 43, 234, 76, 21, 67, 12, 45, 99};
            
            int G = 50;
            int con = 0;
            
            foreach (int i in array)
                if (i > G)
                    con++;
            if (con>array.Length/2) Console.WriteLine("больше тех что больше");
            else Console.WriteLine("Больше тех что меньше");
        }
    }
}