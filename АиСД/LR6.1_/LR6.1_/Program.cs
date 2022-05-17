using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LR6._1_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*ВАРИАНТ 5. Найти элемент, разность соседних элементов которого не меньше 72.
             Если таких элементов несколько, выбрать максимальный. Если таких элементов нет, выдать сообщение.*/

            List<int> list = new List<int>() { 1, 2, 100, 5, 6, };
            list = Trans(list);
            Console.WriteLine(String.Join(" ", list));
        }

        private static int GetIndex(List<int> list, int num)
        {
            int maxIndex = -1;
            for (int i =1; i<list.Count-1; i++)
                if (list[i - 1] - list[i + 1] >= num && maxIndex < list[i - 1] - list[i + 1])
                    maxIndex = i;
            if (maxIndex == -1)
            {
                Console.WriteLine("Нет таких");
                Environment.Exit(1);
            }

            return maxIndex;
        }
        
        public static List<int> Trans(List<int> list)
        {
            int maxIndex = GetIndex(list, 72);

            while (maxIndex != 0)
            {
                (list[maxIndex], list[maxIndex - 1]) = (list[maxIndex - 1], list[maxIndex]);
                maxIndex--;
            }

            return list;
        }

        public static List<int> Perm(List<int> list)
        {
            int maxIndex = GetIndex(list, 72);
            int temp = list[0];
            list[0] = list[maxIndex];
            list.RemoveAt(maxIndex);
            for (int i = 1; i < list.Count; i++)
                (temp, list[i]) = (list[i], temp);
            list.Add(temp);
            return list;
        }
    }
}