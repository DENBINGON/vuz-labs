using System;
using System.Collections.Generic;
namespace ConsoleApp9
{
    class Stac
    {
        private List<int> list = new List<int>();

        public void Push(int e)
        {
            list.Add(e);
        }

        public int Pop()
        {
            int k = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return k;
        }
        public bool Empty()
        {
            if (list.Count != 0) return true;
            else return false;
        }
        public bool Full()
        {
            return false;
        }
        public int StackTop()
        {
            return list[list.Count - 1];
        }

        public Stac() { }
    }
}
