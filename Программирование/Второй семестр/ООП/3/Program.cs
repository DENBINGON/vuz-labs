using System;

namespace oop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoodie o = new Hoodie();
            Hoodie w = new Hoodie();
            Hoodie e = new Hoodie();

            Hoodie q = new Hoodie(29, 44, true, "male");

            o.AddItem();
            q.AddItem();

            Console.WriteLine(o.GetItem() +"\n");
            Console.WriteLine(q.GetItem() + "\n");

            Console.WriteLine(o.GetOverCost() + "\n");
            Console.WriteLine(((ProductEnt) q).GetItem());
        }
    }
}
