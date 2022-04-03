using System;

namespace LR4
{
    
    /*5. Описать процедуру или функцию, которая:
      a) определяет, входит ли вершина с записью Е в дерево Т;
      b) если такая запись не найдена, то она добавляется.*/
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree(50);
            bt.Add(45);
            bt.Add(55);
            bt.Add(42);
            bt.Add(46);
            bt.Add(57);
            bt.Add(53);
            Console.WriteLine(bt.Find(58));
            bt.AddIfNotExist(58);
            Console.WriteLine(bt.Find(58));
        }
    }
}