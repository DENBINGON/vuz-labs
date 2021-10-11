using System;
namespace q
{
    class Program
    {
        static void Main(string[] args)
        {


            //ЛР МОИ №4 задание №1


            //byte p = 0b11101010;
            //Console.WriteLine(p >> 7);
            //Console.WriteLine((p << 2) >> 9);
            //Console.WriteLine((p << 4) >> 11);
            //Console.WriteLine((p << 6) >> 13);


            //ЛР МОИ №4 задание №2


            ////byte p = 0b11011011;
            ////byte p = 0b11110000;
            //bool k = true;

            //byte r = (byte)(p << 3);
            //Console.WriteLine(Convert.ToString(r>>7,2));

            //for (int i = 0; i < 8; i++)
            //{
            //    //STARSHIE
            //    byte o = (byte)(p << i);
            //    //MLADSHIE
            //    byte q = (byte)(p << 7-i);
            //    if (o >> 7 != q >> 7) { k = false; }
            //}
            //if (k)
            //{
            //    Console.WriteLine("полиндром");
            //}
            //else
            //{
            //    Console.WriteLine("не полиндром");
            //}


            //ЛР МОИ №4 задание №3


            //byte x = 0b01101010;
            //byte mask = 0b10100000;
            //bool k = true;
            //int i = 0;
            //while (k && i<8)
            //{
            //    byte l = (byte)(x << i);
            //    byte p = (byte)(l & mask);
            //    p >>= 5;
            //    if (p == 0b101)
            //    {
            //        Console.WriteLine(i+1);
            //        break;
            //    }
            //    i++;
            //    if (i == 8) { Console.WriteLine("нет такой последовательности"); break; }
            //}


            //ЛР МОИ №4 задание №4


            uint y = 0b011000010100100001101;
            byte seconds = (byte)y;
            y >>= 8;
            byte minutes = (byte)y;
            y >>= 8;
            byte hour = (byte) y;
            if (hour < 24 && minutes < 60 && seconds < 60)
            {
                Console.WriteLine("Часы: " + Convert.ToString(hour));
                Console.WriteLine("Минуты: " + Convert.ToString(minutes));
                Console.WriteLine("Секунды: " + Convert.ToString(seconds));
            }
            else
            {
                Console.WriteLine("Значения вне допустимого диапазона");
            }
        }
    }
}

