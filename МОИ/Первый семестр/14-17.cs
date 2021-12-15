using System;
using System.Numerics;
using System.Collections.Generic;
namespace МОИ14_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЛР МОИ 14.1
            //UInt32 Q = UInt32.MaxValue - 3339;
            //UInt32 R = Q;
            //for (int i = 1; i < 32; i++)
            //{
            //    UInt32 L = Q;
            //    for (int e = 0; e < i; e++)
            //    {
            //        L = L >> 1;
            //    }
            //    R -= L;
            //}
            //Console.WriteLine(Convert.ToString(R));
            //int q = 0;
            //R = Q;
            //for (int i = 0; i<32; i++)
            //{
            //    if ((byte) (R & 1) == 1) q++;
            //    R >>= 1;
            //}
            //Console.WriteLine(q);

            //ЛР МОИ 14.2

            //UInt32 Q = uint.MaxValue - 3339;
            //UInt32 R = Q;
            //UInt32 o = 0;
            //Console.WriteLine(R);
            //while (true)
            //{
            //    o++;
            //    try
            //    {
            //        UInt32 s = Q / Convert.ToUInt32(Math.Pow(10, o));
            //        R -= s*9;
            //    }
            //    catch { break;  }
            //}
            //Console.WriteLine(R);
            //int r = 0;
            //string q = Convert.ToString(Q);
            //for (int i = 0; i < q.Length; i++) r += Convert.ToInt16(q[i]) - 48;
            //Console.WriteLine(r);

            //ЛР МОИ 14.3

            //int l = 453;
            //List<int> arr = new List<int>();
            //Random r = new Random();
            //for (int i = 0; i < l; i++) arr.Add(r.Next(0, 2));
            //arr.Sort();
            //int b = 0;
            //while (true)
            //{
            //    if (arr[b] == 1) break;
            //    b += 1;
            //}
            //if (b > l - b) Console.WriteLine("Нулей больше");
            //else Console.WriteLine("Единиц больше");

            //ЛР МОИ 14.4

            //BigInteger integer = 1;
            //int k = 999;
            //for (int i = 1; i<k+1; i++)
            //{
            //    integer *= i;
            //}
            //Console.WriteLine(integer);

            //ЛР МОИ 15.2

            //int[] k = { 14, 18 };
            //Console.WriteLine(NOD(k));

            //ЛР МОИ 16.1

            List<int> p = GetUsual(1, 9999);
            Console.WriteLine(String.Join(" ", p));

        }

        static int NOD(int[] w)
        {
            while (w[1] != 0)
            {
                int k = w[0];
                w[0] = w[1];
                w[1] = k % w[0];
            }
            return w[0];
        }

        static bool Usual(UInt32 num)
        {
            for (int i = 2; i < num; i++) if (num % i == 0) return false;
            return true;
        }
        static List<int> GetUsual(int a, int b)
        {
            List<int> list = new List<int>();

            for (int i = a + 1; i < b; i++) if (Usual(Convert.ToUInt32(i))) list.Add(i);

            return list;
        }
    }
}
