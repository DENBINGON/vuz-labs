using System;
using System.IO;
using System.Text;
namespace ___
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЛР МОИ №9.3

            //Console.WriteLine("Число:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((num << 5) + (num << 3));

            //ЛР МОИ №9.4

            //Console.WriteLine("Число:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{num >> 4}.{num & 15}");

            //ЛР МОИ №13.а.4
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ////win1251
            //byte[] b = { 0xD1, 0xEE, 0xEB, 0xEE, 0xE2, 0xFC, 0xE5, 0xE2, 0x0D, 0x0A };
            ////866
            ////byte[] b = { 0x91, 0xAE, 0xAB, 0xAE, 0xA2, 0x9C, 0xF1, 0xA2, 0x0D, 0x0A };
            ////koi8 - r 20866
            ////byte[] b = { 0xF3, 0xCF, 0xCC, 0xCF, 0xD7, 0xD8, 0xC5, 0xD7, 0x0D, 0x0A };
            //Encoding enc = Encoding.GetEncoding(1251);
            //BinaryWriter binout = new BinaryWriter(new FileStream("../../../a.bin", FileMode.Create), enc);
            //binout.Write(b);
            //binout.Close();

            //ЛР МОИ №13.б.4

            //utf - 8
            //byte[] b = { 0xEF, 0xBB, 0xBF, 0xD0, 0xA1, 0xD0, 0xBE };
            //utf - 16le
            //byte[] b = { 0xFF, 0xFE, 0x21, 0x04, 0x3E, 0x04 };
            //utf - 32le
            //byte[] b = { 0xFF, 0xFE, 0x00, 0x00, 0x21, 0x04, 0x00, 0x00, 0x3E, 0x04, 0x00, 0x00 };
            //BinaryWriter binout = new BinaryWriter(new FileStream("../../../b.bin", FileMode.Create));
            //binout.Write(b);
            //binout.Close();

            //ЛР МОИ №10.доп

            //byte num = 0b11010101;
            //byte num_s = (byte)(num >> 4);
            //byte num_m = (byte)((byte)(num << 4) >> 4);
            //double sum = 0;
            //byte k = 0;
            //bool l = true;
            //for (byte i = 0; i < 4; i++)
            //{
            //    if ((byte)((byte)(num_s << 4 + i) >> 7) == 1)
            //    {
            //        l = false;
            //        sum += Math.Pow(2, i - k);
            //    }
            //    else if (l) k++;

            //    if ((byte)((byte)(num_m << 4 + i) >> 7) == 1)
            //    {
            //        sum += 1 / Math.Pow(2, i + 1);
            //    }
            //}

        }
    }
}































//BinaryReader b = new BinaryReader(new FileStream("../../../a.bin", FileMode.Open), Encoding.GetEncoding(1251));
//Console.WriteLine(Convert.ToString(b.Read(), 2));
