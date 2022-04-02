using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<object> A = new Stack<object>();
            Stack<int> B = new Stack<int>();
            
            int[] Q = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int i = 0;
            for (int k = 0; k<Q.Length; k++)
            {
                A.Push(Q[k]);
            }
            while (A.Count != 0)
            {
                B.Push(Convert.ToInt32(A.Pop()));
                i++;
            }
            for (int k = 0; k < i; k++)
            {
                if (i % 2 == 0 && k == i / 2)
                {
                    A.Push("*");
                }
                if (i % 2 == 1 && k == i / 2 + 1)
                {
                    A.Push("*");
                }
                A.Push(B.Pop());
            }
            //int i = 0;
            //while (B.Count != 0)
            //{
            //    if (i % 2 == 0)
            //    {
            //        A.Push(B.Pop());
            //    }
            //    else { B.Pop(); }
            //    i++;
            //}

            while (A.Count != 0)
            {
                Console.WriteLine(A.Pop());
            }
        }
    }
}