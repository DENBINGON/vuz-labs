using System;
using System.Collections.Generic;
namespace alg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<object> A = new Stack<object>();
            string a = "(()))";
            try
            {
                foreach (var i in a)
                {
                    if (i == Convert.ToChar("("))
                    {
                        A.Push(1);
                    }
                    else { A.Pop(); }
                }
                if (A.Count != 0)
                {
                    Console.WriteLine("Не правильная");
                }
                else
                {
                    Console.WriteLine("Правильная");
                }
            }
            catch
            {
                Console.WriteLine("Не правильная");
            }
        }
    }
}
