using System.Collections.Generic;
using System;

namespace alg2
{
    class DeckStructure
    {
        private Stack<object> deckFront, deckBehind, times;

        private Stack<object> PushToEnd(Stack<object> stack, object obj)
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
            times.Clear();
            return stack;
        }

        private Stack<object> PopFromEnd(Stack<object> stack)
        {
            while (stack.Count != 1)
            {
                times.Push(stack.Pop());
            }
            stack.Clear();
            while (times.Count != 0)
            {
                stack.Push(times.Pop());
            }
            times.Clear();
            return stack;
        }

        private string GetPrintedStr(Stack<object> stack)
        {
            return String.Join(" ", stack);
        }

        public void PushFront(object obj)
        {
            deckFront.Push(obj);
            deckBehind = PushToEnd(deckBehind, obj);
        }

        public void PushBehind(object obj)
        {
            deckBehind.Push(obj);
            deckFront = PushToEnd(deckFront, obj);
        }

        public object PopFront()
        {
            try
            {
                deckBehind = PopFromEnd(deckBehind);
                return deckFront.Pop();
            }
            catch
            {
                return "fail";
            }
        }

        public object PopBehind()
        {
            try
            {
                deckFront = PopFromEnd(deckFront);
                return deckBehind.Pop();
            }
            catch
            {
                return "fail";
            }
        }

        public object TopFront()
        {
            try
            {
                object s = deckFront.Pop();
                deckFront.Push(s);
                return s;
            }
            catch
            {
                return "fail";
            }
        }

        public object TopBehind()
        {
            try
            {
                object s = deckBehind.Pop();
                deckBehind.Push(s);
                return s;
            }
            catch
            {
                return "fail";
            }
        }

        public void Reset()
        {
            deckFront.Clear();
            deckBehind.Clear();
        }

        public bool Empty()
        {
            if (deckFront.Count == 0) return true;
            else return false;
        }

        public void PrintF()
        {
            Console.WriteLine(GetPrintedStr(deckFront));
        }

        public void PrintB()
        {
            Console.WriteLine(GetPrintedStr(deckBehind));
        }

        public DeckStructure()
        {
            deckFront = new Stack<object>();
            deckBehind = new Stack<object>();
            times = new Stack<object>();
        }
    }
}
