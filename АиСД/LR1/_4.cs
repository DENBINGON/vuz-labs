using System;
using System.Collections.Generic;
namespace deck
{
    public class DeckStr
    {
        private Stack<object> stack;
        private Stack<object> times;

        public void PushFront(object obj)
        {
            stack.Push(obj);
        }
        public object GetBehind()
        {
            while (stack.Count != 1)
            {
                times.Push(stack.Pop());
            }
            object t = stack.Pop();
            while (times.Count != 0)
            {
                stack.Push(times.Pop());
            }
            return t;
        }
        public void PushBehind(object obj)
        {
            while (stack.Count != 0)
            {
                times.Push(stack.Pop());
            }
            stack.Push(obj);
            while (times.Count != 0)
            {
                stack.Push(times.Pop());
            }
        }
        public object GetFront()
        {
            return stack.Pop();
        }
        public void Clear()
        {
            stack.Clear();
        }
        public bool Empty()
        {
            if (stack.Count == 0) return true;
            else return false;
        }


        public DeckStr()
        {
            stack = new Stack<object>();
            times = new Stack<object>();
        }
    }
}
