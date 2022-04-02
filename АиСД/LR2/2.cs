using System;
namespace алгоритмы_4_марта_2_часть
{
    class Queue
    {
        private object[] array = new object[0];

        public void Push(object obj)
        {
            if (array.Length == 0) array = new object[1];
            else
            {
                object[] array_ = new object[array.Length + 1];
                array_[0] = obj;
                for (int i = 1; i<array_.Length; i++)
                {
                    array_[i] = array[i - 1];
                }
                array = array_;
            }
        }

        public object Pop()
        {
            if (array.Length == 0) return "void";
            else
            {
                object obj = array[array.Length - 1];
                object[] array_ = new object[array.Length - 1];
                for (int i = 0; i<array_.Length; i++)
                {
                    array_[i] = array[i];
                }
                array = array_;
                return obj;
            }
        }

        public object GetFirst() => array[array.Length - 1];

        public bool Empty()
        {
            if (array.Length == 0) return true;
            else return false;
        }

        public void Clear()
        {
            array = new object[0];
        }


        public Queue()
        {
        }
    }
}
