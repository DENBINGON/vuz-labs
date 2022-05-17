using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LR6._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class BinaryTree
    {
        private List<int> list;

        public bool Find(int num) => list.IndexOf(num) != -1;

        public void Add(int num)
        {
            list.Add(num);
            list.Sort();
        }

        public void AddIfNotExist(int num)
        {
            if (Find(num)) Add(num);
        }

        public void Insert(int position, int[] numbers)
        {
            
        }
        
        public BinaryTree()
        {
            list = new List<int>();
        }
    }
}